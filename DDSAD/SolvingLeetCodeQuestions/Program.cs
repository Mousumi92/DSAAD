using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingLeetCodeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse Integer
            //int n;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //ReverseInteger r = new ReverseInteger();
            //int ans = r.Reverse(n);
            //Console.WriteLine(ans);
            //Console.ReadLine();

            //Complement of an integer
            //int n;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //ComplimentBase10 r = new ComplimentBase10();
            //int ans = r.BitwiseComplement(n);
            //Console.WriteLine(ans);
            //Console.ReadLine();

            int n;
            Console.Write("Enter any number ");
            n = Convert.ToInt32(Console.ReadLine());
            PowerOf2 p = new PowerOf2();
            bool ans = p.IsPowerOfTwo(n);
            Console.WriteLine(ans);
            Console.ReadLine();

        }
    }
}
