using MnemotestProject.Model;
using MnemotestProject.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.Presenter
{
    public sealed class MnemotestPresenter
    {
        private IViewMnemotest mnemotestView;
        private Mnemotest mnemotest;
        private List<UserResult> userResults = null;

        public MnemotestPresenter(IViewMnemotest mnemotestView)
        {
            this.mnemotestView = mnemotestView;
        }

        public void CreateMnemotest()
        {
            int exposureTime = Convert.ToInt32(mnemotestView.ExposureTime);
            int postExposureTime = Convert.ToInt32(mnemotestView.PostExposureTime);
            int preExposureTume = Convert.ToInt32(mnemotestView.PreExposureTime);
            int difficult = Convert.ToInt32(mnemotestView.Difficult);
            int rotateCount = Convert.ToInt32(mnemotestView.RotateCount == "90" ? "1" : (mnemotestView.RotateCount == "180" ? "2" : (mnemotestView.RotateCount == "270" ? "3" : "0")));
            int size = Convert.ToInt32(mnemotestView.MatrixSize);
            int attempts = Convert.ToInt32(mnemotestView.Attempts);
            bool reproductionMode = mnemotestView.ReproductionMode == "Да";
            int grouping = Convert.ToInt32(mnemotestView.Scatter);
            grouping = grouping > ((size * 2)-2) ? ((size * 2)-2) : grouping;
            mnemotest = new Mnemotest(exposureTime, postExposureTime, preExposureTume, difficult, reproductionMode, rotateCount, size, attempts, grouping);
        }


        public void MatrixGeneration()
        {
            mnemotest.RandomGeneration();
        }
        public void RotateMatrixClockwise()
        {
            mnemotest.RotateMatrixClockwise();
        }

        public bool AddToAnswers(string buttonTag)
        {
            return mnemotest.AddToAnswers(Convert.ToInt32(buttonTag));
        }

        public void NextAttempt(Stopwatch timer)
        {
            mnemotest.NextAttempt(timer);
        }
        public bool AttemptsIsOver()
        {
            return mnemotest.AttemptsIsOver();
        }
        public string GetAverageCorrectAnswersCount()
        {
            return mnemotest.AverageCorrectAnswers.ToString("N3");
        }

        public string GetAverageInvalidAnswersCount()
        {
            return mnemotest.AverageInvalidAnswers.ToString("N3");
        }

        public string GetAverageTime()
        {
            return mnemotest.AverageTime.ToString("N3");
        }

        public List<int> GetVerifiedAnswers()
        {
            return mnemotest.GetVerifiedAnswers();
        }

        public List<int> GetAnswers()
        {
            return mnemotest.GetAnswers();
        }

        public int GetExposureTime()
        {
            return mnemotest.parameters.ExposureTime;
        }

        public int GetPreExposureTime()
        {
            return mnemotest.parameters.PreExposureTime;
        }

        public int GetPostExposureTime()
        {
            return mnemotest.parameters.PostExposureTime;
        }

        public int GetSize()
        {
            return mnemotest.parameters.Size;
        }

        public List<int> GetMatrix()
        {
            return mnemotest.Matrix;
        }

        public string GetCorrectAnswersDispersion()
        {
            return mnemotest.CorrectAnswersDispersion.ToString("N3");
        }

        public string GetInvalidAnswersDispersion()
        {
            return mnemotest.InvalidAnswersDispersion.ToString("N3");
        }

        public string GetTimeDispersion()
        {
            return mnemotest.TimeDispersion.ToString("N3");
        }

        public bool GetReproductionMode()
        {
            return mnemotest.parameters.ReproductionMode;
        }

        public void AddToDB()
        {
            string firstName = mnemotestView.FirstName;
            string lastName = mnemotestView.LastName;
            string fatherName = mnemotestView.FatherName;
            string insurancePolicy = mnemotestView.InsurencePolicy;
            int age = Convert.ToInt32(mnemotestView.Age);
            int gender = mnemotestView.Gender == "Мужчина" ? 1 : 2;
            Person person = new Person(firstName, lastName, fatherName, insurancePolicy, age, gender);
            long personID = MnemotestDB.AddPerson(person);

            int exposureTime = Convert.ToInt32(mnemotestView.ExposureTime);
            int postExposureTime = Convert.ToInt32(mnemotestView.PostExposureTime);
            int preExposureTime = Convert.ToInt32(mnemotestView.PreExposureTime);
            int difficult = Convert.ToInt32(mnemotestView.Difficult);
            int rotateCount = Convert.ToInt32(mnemotestView.RotateCount == "90" ? "1" : (mnemotestView.RotateCount == "180" ? "2" : (mnemotestView.RotateCount == "270" ? "3" : "0")));
            int size = Convert.ToInt32(mnemotestView.MatrixSize);
            int attempts = Convert.ToInt32(mnemotestView.Attempts);
            bool reproductionMode = mnemotestView.ReproductionMode == "Да";
            int scatter = Convert.ToInt32(mnemotestView.Scatter);
            MnemotestParameters parameters = new MnemotestParameters(exposureTime, postExposureTime, preExposureTime, difficult, reproductionMode, rotateCount, size, attempts, scatter);
            MnemotestDB.AddResult(personID, mnemotest.AverageCorrectAnswers, mnemotest.CorrectAnswersDispersion, mnemotest.AverageInvalidAnswers, mnemotest.InvalidAnswersDispersion, mnemotest.AverageTime, mnemotest.TimeDispersion, parameters);
        }

        public bool IsValidPerson()
        {
            string firstName = mnemotestView.FirstName;
            string lastName = mnemotestView.LastName;
            string fatherName = mnemotestView.FatherName;
            string insurancePolicy = mnemotestView.InsurencePolicy;
            int age = Convert.ToInt32(mnemotestView.Age);
            int gender = mnemotestView.Gender == "Мужчина" ? 1 : 2;
            Person person = new Person(firstName, lastName, fatherName, insurancePolicy, age, gender);
            return MnemotestDB.IsValidPerson(person);
        }

        public List<Template> GetDefaultParameters()
        {
            List<List<string>> parameters = MnemotestDB.GetDefaultParameters();
            List<Template> result = new List<Template>();
            foreach (var parameter in parameters)
            {
                parameter[5] = (parameter[5] == "True" ? "Да" : "Нет");
                parameter[6] = (parameter[6] == "1" ? "90" : (parameter[6] == "2" ? "180" : (parameter[6] == "3" ? "270" : "0")));

                result.Add(new Template(parameter[0], parameter[1], parameter[2], parameter[3], parameter[4], parameter[5], parameter[6], parameter[7], parameter[8], parameter[9]));
            }
            return result;
        }

        public List<TestResult> GetAllTestResults(string insurancePolicy)
        {
            userResults = MnemotestDB.GetAllResults(insurancePolicy);
            List<TestResult> results = new List<TestResult>();

            foreach (var result in userResults)
            {
                string rotateCount = result.Parameters.RotateCount.ToString();
                results.Add(new TestResult(result.Person.LastName, result.Person.FirstName, result.Person.FatherName, result.AverageCorrectAnswersCount.ToString(), 
                    result.CorrectAnswersDispersion.ToString(), result.AverageInvalidAnswersCount.ToString(), result.InvalidAnswersDispersion.ToString(), result.AverageTime.ToString(), result.TimeDispersion.ToString(), 
                    result.Parameters.ExposureTime.ToString(), result.Parameters.PostExposureTime.ToString(), result.Parameters.PreExposureTime.ToString(), result.Parameters.Difficult.ToString(), 
                    result.Parameters.ReproductionMode ? "Да" : "Нет", rotateCount == "0" ? "0" : (rotateCount == "1" ? "90" : (rotateCount == "2" ? "180" : (rotateCount == "3" ? "270" : "0"))), 
                    result.Parameters.Size.ToString(), result.Parameters.Attempts.ToString(), result.Parameters.Scatter.ToString()));
            }
            return results;
        }

        public void AddToExcel(string path)
        {
            ResultsToExcel.Add(userResults,path);
        }


    }
}
