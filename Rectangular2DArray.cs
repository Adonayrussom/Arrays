using System;

namespace sess05_Arrays
{
    public class Rectangular2DArray
    {
        static void Main(string[] args)
        {
            int[,] dimension = new int[4, 5];//Rectangular 2-d array of 20 elements
            int numOne = 1;//Used to populate the array and display purposes
            for (int n = 0; n < dimension.Length; n++)
            {
                for (int a = 0; a < 5; a++)
                {
                    //Populate the array elements with values
                    dimension[n, a] = numOne++;
                }
            }

            //Display the values in the 2-d array populated above 
            for (int n = 0; n < dimension.GetLength(0); n++)
            {
                for (int a = 0; a < dimension.GetLength(1); a++)
                {
                    Console.WriteLine($"{dimension[n, a]:00} ");
                }
                Console.WriteLine();
            }
        }
    }
}
