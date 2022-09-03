using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.Model
{
    public sealed class UserResult
    {
        public MnemotestParameters Parameters { get; }
        public Person Person { get; private set; }
        public double AverageCorrectAnswersCount { get; }
        public double CorrectAnswersDispersion { get; }
        public double AverageInvalidAnswersCount { get; }
        public double InvalidAnswersDispersion { get; }
        public double AverageTime { get;}
        public double TimeDispersion { get; }
        public UserResult(MnemotestParameters parameters, Person person, double averageCorrectAnswersCount, double correctAnswersDispersion,
            double averageInvalidAnswersCount, double invalidAnswersDispersion, double averageTime, double timeDispersion)
        {
            Parameters = parameters;
            Person = person;
            AverageCorrectAnswersCount = averageCorrectAnswersCount;
            CorrectAnswersDispersion = correctAnswersDispersion;
            AverageInvalidAnswersCount = averageInvalidAnswersCount;
            InvalidAnswersDispersion = invalidAnswersDispersion;
            AverageTime = averageTime;
            TimeDispersion = timeDispersion;
        }
    }
}
