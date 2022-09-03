using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MnemotestProject.Model;
using System.Drawing;

namespace MnemotestProject
{
    public class Mnemotest
    {
        public MnemotestParameters parameters;
        private int CurrentAttempt;
        private Attempt[] attempts;

        public List<int> Matrix { get; set; }
        public double AverageCorrectAnswers { get; private set; }
        public double AverageInvalidAnswers { get; private set; }
        public double AverageTime { get; private set; }
        public double CorrectAnswersDispersion { get; private set; }
        public double InvalidAnswersDispersion { get; private set; }
        public double TimeDispersion { get; private set; }

        public Mnemotest(int exposureTime, int postExposureTime, int preExposureTime, int difficult, bool reproductionMode, int rotateCount, int size, int attempts, int scatter)
        {
            Matrix = new List<int>();
            for (int i = 0; i < size * size; i++)
                Matrix.Add(-1);
            parameters = new MnemotestParameters(exposureTime,postExposureTime,preExposureTime,difficult, reproductionMode,rotateCount, size,attempts, scatter);
            this.attempts = new Attempt[attempts];
            for (int i = 0; i < this.attempts.Length; i++)
                this.attempts[i] = new Attempt();
            CurrentAttempt = 0;
        }

        public bool AttemptsIsOver()
        {
            if (CurrentAttempt == parameters.Attempts)
            {
                CalculateAverageCorrectAnswersCount();
                CalculateAverageInvalidAnswersCount();
                CalculateAverageTime();
                CalculateCorrectAnswersDispersion();
                CalculateInvalidAnswersDispersion();
                CalculateTimeDispersion();
                CurrentAttempt = 0;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns>True, если попытка закончена. Иначе, false.</returns>
        public bool AddToAnswers(int i)
        {
            attempts[CurrentAttempt].Answers.Add(i);
            if (attempts[CurrentAttempt].AttemptIsOver(parameters.Difficult, Matrix))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time">Время, потраченное на попытку</param>
        public void NextAttempt(Stopwatch time)
        {
            TimeSpan ts = time.Elapsed;
            attempts[CurrentAttempt].AttemptTime = ts.TotalSeconds;
            CurrentAttempt++;
        }

        private void CalculateAverageCorrectAnswersCount()
        {
            double averageCorrectAnswersCount = 0;
            foreach (var attempt in attempts)
                averageCorrectAnswersCount += attempt.GetCorrectAnswersCount();
            averageCorrectAnswersCount /= parameters.Attempts;
            AverageCorrectAnswers = Math.Round(averageCorrectAnswersCount,5);
        }

        private void CalculateAverageInvalidAnswersCount()
        {
            double averageInvalidAnswersCount = 0;
            foreach (var attempt in attempts)
                averageInvalidAnswersCount += attempt.GetInvalidAnswersCount();
            averageInvalidAnswersCount /= parameters.Attempts;
            AverageInvalidAnswers = Math.Round(averageInvalidAnswersCount,5);
        }

        private void CalculateAverageTime()
        {
            double averageTime = 0;
            foreach (var attempt in attempts)
                averageTime += attempt.AttemptTime;
            averageTime /= parameters.Attempts;
            AverageTime = Math.Round(averageTime,5);
        }

        public List<int> GetVerifiedAnswers()
        {
            return attempts[CurrentAttempt].VerifiedCorrectAnswers;
        }

        public List<int> GetAnswers()
        {
            return attempts[CurrentAttempt].Answers;
        }

        public void CalculateCorrectAnswersDispersion()
        {
            double sum = 0;
            foreach (var attempt in attempts)
                sum += (attempt.CorrectAnswersCount - AverageCorrectAnswers)* (attempt.CorrectAnswersCount - AverageCorrectAnswers);
            CorrectAnswersDispersion = Math.Round(sum / parameters.Attempts,5);
        }

        public void CalculateInvalidAnswersDispersion()
        {
            double sum = 0;
            foreach (var attempt in attempts)
                sum += (attempt.InvalidAnswersCount - AverageInvalidAnswers) * (attempt.InvalidAnswersCount - AverageInvalidAnswers);
            InvalidAnswersDispersion = Math.Round(sum / parameters.Attempts,5);
        }

        public void CalculateTimeDispersion()
        {
            double sum = 0;
            foreach (var attempt in attempts)
                sum += (Math.Round(attempt.AttemptTime,3) - AverageTime) * (Math.Round(attempt.AttemptTime, 3) - AverageTime);
            TimeDispersion = Math.Round(sum / parameters.Attempts,5);
        }

        private void ClearVariables()
        {
            for (int i = 0; i < Matrix.Count; i++)
                Matrix[i] = -1;
        }

        public void RandomGeneration()
        {
            ClearVariables();
            Random rnd = new Random();
            if (parameters.Scatter == 0)
            {
                for (int i = 0; i < parameters.Difficult; i++)
                {
                    int j;
                    do
                    {
                        j = rnd.Next(0, parameters.Size * parameters.Size);
                    } while (Matrix[j] != -1);
                    Matrix[j] = 1;
                }
            }
            else
            {
                int currentScatter = parameters.Scatter;
                int tempCells = parameters.Difficult-1;
                int cell = rnd.Next(0, parameters.Size * parameters.Size);
                Point startPoint = new Point(cell % parameters.Size, cell / parameters.Size);
                int[,] tempMatrix = new int[parameters.Size, parameters.Size];
                Distance distance = new Distance(parameters.Size, startPoint);

                for (int i = 0; i < parameters.Size; i++)
                    for (int j = i * parameters.Size, p = 0; j < (i + 1) * parameters.Size; j++, p++)
                        tempMatrix[i, p] = Matrix[j];
                tempMatrix[startPoint.Y, startPoint.X] = 1;

                while (tempCells >0)
                {
                    Point newPoint = distance.GetRandomPoint(currentScatter, rnd);
                    if (tempMatrix[newPoint.Y, newPoint.X] == -1)
                    {
                        tempMatrix[newPoint.Y, newPoint.X] = 1;
                        tempCells--;
                    }
                }
                Matrix.Clear();
                for (int i = 0; i < parameters.Size; i++)
                    for (int j = 0; j < parameters.Size; j++)
                        Matrix.Add(tempMatrix[i, j]);

            }
        }

        private void SwapElementsOfMassive(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void RotateMatrixClockwise()
        {
            if (parameters.RotateCount > 0)
            {
                int[,] tempMatrix = new int[parameters.Size, parameters.Size];
                for (int i = 0; i < parameters.Size; i++)
                    for (int j = i * parameters.Size, p = 0; j < (i + 1) * parameters.Size; j++, p++)
                        tempMatrix[i, p] = Matrix[j];

                int rotate = parameters.RotateCount;
                while (rotate > 0)
                {
                    for (int i = 0; i < parameters.Size; i++)
                        for (int j = 0; j < i; j++)
                            SwapElementsOfMassive(ref tempMatrix[i, j], ref tempMatrix[j, i]);

                    for (int i = 0; i < parameters.Size; i++)
                        for (int j = 0; j < parameters.Size / 2; j++)
                            SwapElementsOfMassive(ref tempMatrix[i, j], ref tempMatrix[i, parameters.Size - j - 1]);

                    rotate--;
                }

                Matrix.Clear();
                for (int i = 0; i < parameters.Size; i++)
                    for (int j = 0; j < parameters.Size; j++)
                        Matrix.Add(tempMatrix[i, j]);
            }
        }
    }
}
