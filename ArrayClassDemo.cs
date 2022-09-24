using System;

namespace sess05_Arrays
{
    /// <summary>
    /// C# program to demonstrate some of the methods and properties of the array class
    /// </summary>
    public class ArrayClassDemo
    {
        static void Main(string[] args)
        {
            //Create a single dimension array using the CreateInstance() method
            Array courses = Array.CreateInstance(typeof(string), 5);
            courses.SetValue("Information Technology", 3);
            courses.SetValue("Marketing", 0);
            courses.SetValue("Human Resource", 2);
            courses.SetValue("Business Administration", 4);
            courses.SetValue("Finance", 1);

            //Display courses using for...each loop 
            //foreach (string course in courses) 
            //{ 
            // Console.WriteLine(course); 
            //}

            //Display the contents of the course array
            for (int n = 0; n <= courses.GetUpperBound(0); n++)
            {
                Console.WriteLine($"Course {(n + 1): 00} : {courses.GetValue(n)}");
            }

            //Create a multi dimension array using the CreateInstance() method
            Array empDetails = Array.CreateInstance(typeof(string), 2, 3);
            empDetails.SetValue("141", 0, 0);
            empDetails.SetValue("148", 0, 1);
            empDetails.SetValue("153", 0, 2);
            empDetails.SetValue("Nicole Kadzo", 1, 0);
            empDetails.SetValue("Elvin Wahito", 1, 2);
            empDetails.SetValue("Venna Atieno", 1, 2);

            //Display the Employee details
            Console.WriteLine("Employee ID \tName");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{ empDetails.GetValue(i, j),11} \t");
                    Console.WriteLine(empDetails.GetValue(i + 1, j));
                }
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"Rank of courses array is: {courses.Rank}" +
                $"\nRank of empDetails array is : {empDetails.Rank}");
        }
    }
}
