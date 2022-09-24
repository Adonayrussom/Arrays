using System;

namespace sess05_Arrays
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            string[][] companies = new string[5][];
            companies[0] = new string[] { "Intel", "AMD", "Apple" };
            companies[1] = new string[] { "Toyota", "Nissan", "Mazda", "Ford", "Porsche", "Isuzu" };
            companies[2] = new string[] { "Samsung", "HiSilicon", "Qualcom", "MediaTek" };
            companies[3] = new string[] { "Nvidia", "AMD" };
            companies[4] = new string[] { "Adonay", "Kelly", "Saliem", "Gitonga", "Elizabeth", "Hermon", "Sammy", "Veronica" };

            //Display the contents of the jagged array
            for (int n = 0; n <= companies.GetUpperBound(0); n++)
            {
                int a = 0;
                Console.WriteLine($"List of companies in group{(n + 1)}");
                do
                {
                    Console.WriteLine($"{companies[n][a]} ");
                    a++;
                } while (a < companies[n].GetLength(0));
                Console.WriteLine();
            }
        }
    }
}
