using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mini Calculator
            //int a, b;
            //Console.Write("Enter the value of a ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.Write("Enter the value of b ");
            //b = Convert.ToInt32(Console.ReadLine());

            //char op;
            //Console.Write("Enter the operation you want to perform ");
            //op = Convert.ToChar(Console.ReadLine());

            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine(a + b);
            //        break;
            //    case '-':
            //        Console.WriteLine (a - b);
            //        break;
            //    case '*':
            //        Console.WriteLine(a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine(a / b);
            //        break;
            //    case '%':
            //        Console.WriteLine(a % b);
            //        break;
            //    default:
            //        Console.WriteLine("It is a default case");
            //        break;

            //}

            //Find number of notes of a particular denomination
            //Console.Write("Please Enter Your total Amount to find the notes : ");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //int rs100, rs50, rs20, rs1;

            //switch (amount > 100)
            //{
            //    case true:
            //        rs100 = amount / 100;
            //        amount = amount - (rs100 * 100);
            //        Console.WriteLine("Total no: of 100rs = " + rs100);
            //        break;
            //}

            //switch (amount > 50)
            //{
            //    case true:
            //        rs50 = amount / 50;
            //        amount = amount - (rs50 * 50);
            //        Console.WriteLine("Total no: of 50rs = " + rs50);
            //        break;
            //}
            //switch (amount > 20)
            //{
            //    case true:
            //        rs20 = amount / 20;
            //        amount = amount - (rs20 * 20);
            //        Console.WriteLine("Total no: of 20rs = " + rs20);
            //        break;
            //}
            //switch (amount > 1)
            //{
            //    case true:
            //        rs1 = amount / 1;
            //        amount = amount - (rs1 * 1);
            //        Console.WriteLine("Total no: of 1rs = " + rs1);
            //        break;
            //}
            //Console.ReadLine();

            //Power of a and b
            //int a, b;
            //Console.Write("Enter the value of a ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.Write("Enter the value of b ");
            //b = Convert.ToInt32(Console.ReadLine());
            //PowerOfaAndb p = new PowerOfaAndb();
            //int result = p.power(a, b);
            //Console.WriteLine(result);

            //Even Odd Program
            //int n;
            //Console.Write("Enter the number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //EvenOdd e = new EvenOdd();
            //bool result = e.IsEven(n);
            //if(result)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //Calculate nCr 
            //int n, r;
            //Console.Write("Enter the value of n ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.Write("Enter the value of r ");
            //r = Convert.ToInt32(Console.ReadLine());

            //nCr c = new nCr();
            //int result = c.CalculatenCr(n, r);
            //Console.WriteLine(result);


            //Print Counting
            //int n;
            //Console.Write("Enter the value of n ");
            //n = Convert.ToInt32(Console.ReadLine());
            //PrintCounting p = new PrintCounting();
            //p.CountingNumbers(n);

            //Find nth term of AP
            //int n;
            //Console.Write("Enter the value of n ");
            //n = Convert.ToInt32(Console.ReadLine());
            //AP a = new AP();
            //int ans = a.FindAP(n);
            //Console.WriteLine(ans);

            //int a, b;
            //Console.Write("Enter the value of a ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.Write("Enter the value of b ");
            //b = Convert.ToInt32(Console.ReadLine());
            //SetBitsAandB s = new SetBitsAandB();
            //int ans1 = s.setBitsA(a);
            //int ans2= s.setBitsB(b);
            //int ans = ans1 + ans2;
            //Console.WriteLine("Total set bits of a and b are " + ans);

            //Fibonacci series
            int n;
            Console.Write("Enter the value of n ");
            n = Convert.ToInt32(Console.ReadLine());
            Fibonacci f = new Fibonacci();
            int ans = f.fibonacci(n);
            Console.WriteLine(ans);
            Console.ReadLine();


        }
    }
}
