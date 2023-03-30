using System;

namespace DDSAD
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Recursion Day 1


            //Calculate Factorial
            //Console.Write("Enter any number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Factorial f = new Factorial();
            //int ansFactorial = f.CalculateFactorial(n);
            //Console.WriteLine("The Factorial is : " + ansFactorial);
            //Console.ReadLine();

            //Calculate Power
            //Console.Write("Enter any number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //PowerOfn p = new PowerOfn();
            //int ansPower = p.CalculatePower(n1);
            //Console.WriteLine("The Power result is : " + ansPower);
            //Console.ReadLine();

            //Counting
            //Console.Write("Enter any number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Counting c = new Counting();
            //c.PrintCount(n2);
            //Console.ReadLine();



            //Recursion Day 2

            //WalkingHome Example
            //int src = 1;
            //int dest = 10;
            //WalkingExample w = new WalkingExample();
            //w.ReachHome(src, dest);
            //Console.ReadLine();

            //Fibonacci Series
            //Console.Write("Enter any number: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //Fibonacci f = new Fibonacci();
            //int ansFib= f.Fib(n3);
            //Console.WriteLine(ansFib);
            //Console.ReadLine();

            //Climb Stairs
            //Console.Write("Enter any number: ");
            //int n4 = Convert.ToInt32(Console.ReadLine());
            //ClimbStairs c = new ClimbStairs();
            //int ansClimbStairs = c.DistinctWayToClimbStairs(n4);
            //Console.WriteLine(ansClimbStairs);
            //Console.ReadLine();

            //Say Digit
            //Console.Write("Enter any number: ");
            //int n5 = Convert.ToInt32(Console.ReadLine());
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //SayDigits s = new SayDigits();
            //s.sayDigit(n5, arr);
            //Console.ReadLine();


            //Recursion Day 3
            //Is Array Sorted
            //int[] arr = {2,4,6,8,9,10};
            //IsArraySorted a = new IsArraySorted();
            //bool ansIsSorted = a.IsSorted(arr, arr.Length);

            //if (ansIsSorted)
            //{
            //    Console.WriteLine("Array is sorted");
            //}
            //else
            //{
            //    Console.WriteLine("Array is not sorted");
            //}
            //Console.ReadLine();

            //Sum of array elements
            //int[] arr = { 2, 4, 6, 8, 9, 10 };
            //SumOfArrayElements s = new SumOfArrayElements();
            //int sumOfArray = s.GetSum(arr, arr.Length);
            //Console.WriteLine("Sum is : " + sumOfArray);
            //Console.ReadLine();

            //Linear Search
            //int[] arr = { 3, 5, 1, 2, 6 };
            //LinearSearch l = new LinearSearch();
            //bool keyFound = l.FindKey(arr, arr.Length, 11);
            //if (keyFound)
            //{
            //    Console.WriteLine("Key is found");
            //}
            //else
            //{
            //    Console.WriteLine("Key is not found");
            //}
            //Console.ReadLine();

            //Binary Search
            int[] arr = { 2, 4, 6, 10, 14, 18 };
            int key = 18;
            BinarySearch b = new BinarySearch();
            bool keyFound = b.FindUsingBinarySearch(arr, 0, 5, key);
            if (keyFound)
            {
                Console.WriteLine("Key is found");
            }
            else
            {
                Console.WriteLine("Key is not found");
            }
            Console.ReadLine();
        }
    }
}
