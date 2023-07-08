using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetcodeQuestionsArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Swap alternate elements of an array
            //int[] even = { 5, 2, 9, 4, 7, 6, 1, 0 };
            //int[] odd = { 11, 33, 9, 76, 43 };
            //SwapAlternate s = new SwapAlternate();
            //s.SwapAlternateElements(even, 8);
            //s.PrintArray(even, 8);

            //s.SwapAlternateElements(odd, 5);
            //s.PrintArray(odd, 5);

            //Find Unique Element
            //int[] arr = { 2,3,1,6,3,6,2};
            //FindUniqueElement f = new FindUniqueElement();
            //int a = f.FindUniqueArrayElement(arr, 7);
            //Console.WriteLine("The unique element is " + a);

            //Check if there are unique number of occurrences
            //int[] arr = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            //int[] arr = { -3, 0, 1, -3, 1, 1, 0, -3, 10, 0 };
            //UniqueNumberOfOccurrences u = new UniqueNumberOfOccurrences();
            //bool res = u.checkUniqueFrequency(arr);
            //if(res)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //Find duplicate element
            //int[] arr = { 1,2,3,3,4 };
            //FindDuplicateElement u = new FindDuplicateElement();
            //int res = u.FindDuplicateArrayElement(arr);
            //Console.WriteLine(res);

            //Print duplicate elements
            //int[] arr = { 1, 2, 3, 3, 4, 2 };
            //PrintDuplicateElements p = new PrintDuplicateElements();
            //IList<int> res = p.FindDuplicateArrayElements(arr);
            //foreach(int i in res)
            //{
            //    Console.WriteLine(i+" ");
            //}

            //Intersecton of array elements
            //int[] arr1= {1, 2, 3};
            //int[] arr2 = { 3, 4 };
            //int[] arr1 = { 1, 2, 2, 2, 3, 4 };
            //int[] arr2 = { 2, 2, 3, 3 };
            //FindIntersectionOfArrayElements f = new FindIntersectionOfArrayElements();
            //IList<int> ans = f.IntersectedArrayElement(arr1 , arr2, 6, 4);
            //foreach (int i in ans)
            //{
            //    Console.WriteLine(i + " ");
            //}

            //Find Pair Sum
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum = 5;
            //FindPairSum p = new FindPairSum();
            //IEnumerable<List<int>> list = p.PairSum(arr, sum);
            //foreach(var result in list)
            //{
            //    foreach(var j in result)
            //    {
            //        Console.Write(j+ " ");
            //    }
            //    Console.WriteLine();
            //}

            //Find Triplet Sum
            //int[] arr = { 1, 4, 45, 6, 10, 8 };
            //int sum = 22;
            //TripletsWithGivenSum t = new TripletsWithGivenSum();
            //IEnumerable<List<int>> list = t.TripletSum(arr, sum);
            //foreach (var result in list)
            //{
            //    foreach (var j in result)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Sort 0,1
            //int[] arr = { 1, 1, 0, 0, 0, 0, 1, 0 };
            //int[] arr = { 0, 0, 0, 1, 0, 1, 1, 1 };
            //Sort01 s = new Sort01();
            //s.SortOne(arr, 8);
            //s.PrintArray(arr, 8);

            //Sort 0, 1, 2
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            Sort012 s = new Sort012();
            s.SortOneTwo(arr, 8);
            s.PrintArray(arr, 8);
            Console.ReadLine();
        }
    }
}
