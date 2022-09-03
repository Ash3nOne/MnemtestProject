using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.Model
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string InsurancePolicy { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }

        public Person(string firstName, string lastName, string fatherName, string insurancePolicy, int age, int gender)
        {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            InsurancePolicy = insurancePolicy;
            Age = age;
            Gender = gender;
        }
    }
}
