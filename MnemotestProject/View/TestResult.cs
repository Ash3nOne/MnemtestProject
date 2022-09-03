using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MnemotestProject.View
{
    public sealed class TestResult : Template
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FatherName { get; private set; }
        public string AverageCorrectAnswersCount { get; private set; }
        public string CorrectAnswersDispersion { get; private set; }
        public string AverageInvalidAnswersCount { get; private set; }
        public string InvalidAnswersDispersion { get; private set; }
        public string AverageTime { get; private set; }
        public string TimeDispersion { get; private set; }
        public TestResult
        (
            string lastName, string firstName, string fatherName, string averageCorrectAnswersCount, string correctAnswersDispersion,
            string averageInvalidAnswersCount, string invalidAnswersDispersion, string averageTime, string timeDispersion, string exposureTime,
            string postExposureTime, string preExposureTime, string difficult, string reproductionMode, string rotateCount, string size,
            string attempts, string scatter) :
            base(exposureTime, postExposureTime, preExposureTime, difficult, reproductionMode, rotateCount, size, attempts, scatter)
        {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            AverageCorrectAnswersCount = averageCorrectAnswersCount;
            CorrectAnswersDispersion = correctAnswersDispersion;
            AverageInvalidAnswersCount = averageInvalidAnswersCount;
            InvalidAnswersDispersion = invalidAnswersDispersion;
            AverageTime = averageTime;
            TimeDispersion = timeDispersion;
        }

        public string GetParameterForIndex(int index)
        {
            string text = "";
            switch (index)
            {
                case 0:
                    text = LastName + " " + FirstName + " " + FatherName;
                    break;
                case 1:
                    text = AverageCorrectAnswersCount;
                    break;
                case 2:
                    text = CorrectAnswersDispersion;
                    break;
                case 3:
                    text = AverageInvalidAnswersCount;
                    break;
                case 4:
                    text = AverageInvalidAnswersCount;
                    break;
                case 5:
                    text = AverageTime;
                    break;
                case 6:
                    text = TimeDispersion;
                    break;
                case 7:
                    text = ExposureTime;
                    break;
                case 8:
                    text = PostExposureTime;
                    break;
                case 9:
                    text = PreExposureTime;
                    break;
                case 10:
                    text = Difficult;
                    break;
                case 11:
                    text = ReproductionMode;
                    break;
                case 12:
                    text = RotateCount;
                    break;
                case 13:
                    text = Size;
                    break;
                case 14:
                    text = Attempts;
                    break;
                case 15:
                    text = Scatter;
                    break;
            }
            return text;
        }


    }
}
