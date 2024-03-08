using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public string FullName(Person pers)
        {
            return pers.FName + " " + pers.LName;
        }
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public double calculateBMI(Person pers)
        {
            double BMI = pers.Weight / (pers.Height * pers.Height);
            return BMI;
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person()
            {
                Age = age,
                FName = fname,
                Height = height,
                LName = lname,
                Weight = weight
            };
            return person;
        }
    }
}
