using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject
{
    public class Attempt
    {
        public int CorrectAnswersCount { get; set; }
        public int InvalidAnswersCount { get; set; }
        public List<int> Answers { get; set; }
        public double AttemptTime { get; set; }

        public List<int> VerifiedCorrectAnswers { get; set; }


        public Attempt()
        {
            CorrectAnswersCount = 0;
            InvalidAnswersCount = 0;
            Answers = new List<int>();
            VerifiedCorrectAnswers = new List<int>();
            AttemptTime = 0;
        }

        public bool AttemptIsOver(int difficult, List<int> Matrix)
        {
            if (Answers.Count == difficult)
            {
                CheckAnswers(Matrix);
                return true;
            }
            else
                return false;
        }

        public List<int> CheckAnswers(List<int> Matrix)
        {
            for (int i = 0; i < Answers.Count; i++)
            {
                if (Matrix[Answers[i]] == 1)
                {
                    VerifiedCorrectAnswers.Add(1);
                    CorrectAnswersCount++;
                }
                else
                {
                    InvalidAnswersCount++;
                    VerifiedCorrectAnswers.Add(-1);
                }
            }
            return VerifiedCorrectAnswers;
        }

        public int GetCorrectAnswersCount()
        {
            int correctAnswersCount = 0;
            foreach (var answer in VerifiedCorrectAnswers)
                correctAnswersCount += answer == 1 ? 1 : 0;
            return correctAnswersCount;
        }

        public int GetInvalidAnswersCount()
        {
            int invalidAnswersCount = 0;
            foreach (var answer in VerifiedCorrectAnswers)
                invalidAnswersCount += answer == -1 ? 1 : 0;
            return invalidAnswersCount;
        }
    }
}
