using System;

namespace Ex2.Person
{
    namespace Ex2
    {
        class Program
        {
            static void Main(string[] args)
            { 
                Person director = new Person("Christopher", "Merly", 666, 50, true);

                Console.WriteLine($"{director.firstName}  {director.secondName}\n{"Born in: " + director.dateOfBirth}, {director.weight + " kg"}\n{director.glasses}");
                Console.WriteLine(director.CountAge()); 
                director.CurrentSex = Person.Sex.M;
                Console.WriteLine(director.AddPrefix());

                Person patient = new Person("Sylvester", "Rane", 1975, 12, false);
                patient.Height = 190.4;
                Console.WriteLine($"{patient.CountBmi()}");
            }
        }
    }

}
