using System;

namespace DDSAD
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Calculate Factorial
            Console.Write("Enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Factorial f = new Factorial();
            int ans = f.CalculateFactorial(n);
            Console.WriteLine("The Factorial is : " + ans);
            Console.ReadLine();
        }
    }
}
