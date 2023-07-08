using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SolvingLeetcodeQuestionsArrays
{
    //https://leetcode.com/problems/unique-number-of-occurrences/
    internal class UniqueNumberOfOccurrences
    {
    //Traverse the given array arr[] and store the frequency of each element in a Map.
    //Now traverse the map and check if the count of any element occurred more than once.
    //If the count of any element in the above steps is more than one then print “No”, else print “Yes”.
      public bool checkUniqueFrequency(int[] arr)
        {
            // Freq map will store the frequency
            // of each element of the array
            Dictionary<int,int> freq = new Dictionary<int,int>();
            foreach(var num in arr) 
            {
                if(freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq.Add(num, 1);
                }
            }

            HashSet<int> list = new HashSet<int>();
            foreach (var num in freq) 
            {
                if(list.Contains(num.Value))
                {
                    return false;
                }
                list.Add(num.Value);
            }
            return true;
        }
    }
}
