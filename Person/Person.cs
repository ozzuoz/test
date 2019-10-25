using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace Ex2.Person
{
    class Person
    {
        public string firstName;
        public string secondName;
        public int dateOfBirth;
        public int weight;
        private double height;
        public bool glasses;

        public enum Sex
        {
            K,
            M
        };

        public  string CountAge()
        {
            int birthYear;  
            DateTime today = DateTime.Now;
            int time = today.Year;
            birthYear = time - dateOfBirth;
            string s = Convert.ToString(birthYear);
            return s + " years old";
        }

        public  Person(string firstName, string secondName, int dateOfBirth, int weight, bool glasses)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.weight = weight;
            this.glasses = glasses;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private Sex _sex;

        public Sex CurrentSex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public string AddPrefix()
        {
            if (_sex == Sex.K)
                return "The director is Mrs." + firstName + " "  + secondName;
            else
                return "The director is Mr." + firstName + " " + secondName;
        }

        public string CountBmi()
        {
            double BMI; 
            BMI = this.weight / Math.Pow(height / 100.0, 2);
            if (BMI < 16 & BMI <= 18.49)
                return "Your weight is less than correct weight!";
            else if (BMI >= 18.5 & BMI <= 24.99)
                return "Your weight is optimal.";
            else if (BMI >= 30.00 & BMI >= 40.00)
                return "Your weight is overweight!";

            return "Wrong data!";
        }
        
    }
}
