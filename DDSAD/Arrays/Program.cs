using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[2] {2, 5};

            //Max and Min of an array
            //int size;
            //Console.Write("Enter size of the array ");
            //size = Convert.ToInt32(Console.ReadLine());

            //int[] num = new int[100];
            //for(int i=0; i<size; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //MaxMinOfArray m = new MaxMinOfArray();
            //Console.WriteLine("Maximum value of the array is " + m.GetMax(num, size));
            //Console.WriteLine("Minimum value of the array is " + m.GetMin(num, size));

            //Sum of Array Elements
            //int size;
            //Console.Write("Enter size of the array ");
            //size = Convert.ToInt32(Console.ReadLine());

            //int[] num = new int[100];
            //for (int i = 0; i < size; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //SumOfArrayElements s = new SumOfArrayElements();
            //int result= s.CalculateSumOfArrayElements(num, size);
            //Console.WriteLine("Sum of Array Elements is "+ result);

            //Linear Search
            //int[] arr =  { 5, 7, -2, 10, 22, -2, 0, 5, 22, 1 };
            //Console.Write("Enter the element to search for ");
            //int key;
            //key = Convert.ToInt32(Console.ReadLine());
            //LinearSearch l = new LinearSearch();
            //bool found = l.Search(arr, 10, key);
            //if(found)
            //{
            //    Console.WriteLine("Key is present");
            //}
            //else
            //{
            //    Console.WriteLine("Key is absent");
            //}

            //Reverse Array
            int[] arr = { 1, 4, 0, 5, -2, 15 };
            int[] brr = { 2, 6, 3, 9, 4 };
            ReverseArray r = new ReverseArray();
            r.Reverse(arr, 6);
            r.Reverse(brr, 5);
            r.PrintArray(arr, 6);
            r.PrintArray(brr, 5);
            Console.ReadLine();
        }
    }
}
