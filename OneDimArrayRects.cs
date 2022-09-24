using sess06_ClassesAndMethods;
using System;

namespace sess05_Arrays
{
    /// <summary>
    /// C# program to illustrate the use of reference/object types in single deimension array
    /// </summary>
    public class OneDimArrayRects
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rectangles would you like to create");
            int numOfRects = int.Parse(Console.ReadLine());

            //Declare and istantiate a single dimension array of rectangle
            Rect[] userRect = new Rect[numOfRects];
            int n = 0;//looping variables
            int len = 0, wid = 0;

            for (; n < userRect.Length; n++)
            {
                Console.WriteLine($"Please enter the length and width of the rectangle {n + 1}");
                len = int.Parse(Console.ReadLine());
                wid = int.Parse(Console.ReadLine());
            }
            //Instatiate rectangle[n] with the dimensions given by the user
            userRect[n] = new Rect(len, wid);

            //use a for..each loop to display each rectangle's dimensions
            foreach (Rect rect in userRect)
            {
                rect.displayDimensions();
            }
        }
    }
}
