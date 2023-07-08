using System;

namespace LoopsAndPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conditionals
            //Console.Write("Enter any character: ");
            //char user_input = Convert.ToChar(Console.ReadLine());
            //int ascii = user_input;

            //if (ascii >= 65 && ascii <= 90)
            //{
            //    Console.WriteLine("Upper Case");
            //}
            //else if (ascii >= 97 && ascii <= 122)
            //{
            //    Console.WriteLine("Lower Case");
            //}
            //else if (ascii >= 48 && ascii <= 57)
            //{
            //    Console.WriteLine("Numerical");
            //}
            //else
            //{
            //    Console.WriteLine("something else");
            //}
            //Console.ReadLine();

            //While loop -- sum of n numbers

            //Console.Write("Enter any number ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int i = 1;
            //while (i <= n)
            //{
            //    sum = sum + i;
            //    i = i + 1;
            //}
            //Console.WriteLine("The value of sum is " + sum);
            //Console.ReadLine();

            //Sum of N even Numbers
            //Console.Write("Enter any number ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int i = 2;
            //while (i <= n)
            //{
            //    sum = sum + i;
            //    i = i + 2;
            //}
            //Console.WriteLine("The value of sum is " + sum);
            //Console.ReadLine();

            //Farenheit to Celcius Table
            //int f, c;
            //Console.Write("Enter any number ");
            //f = Convert.ToInt32(Console.ReadLine());
            //c = 5 * (f - 32) / 9;
            //Console.WriteLine( c + " Degree Celcius ");
            //Console.ReadLine();

            //Prime Number: is a number which has only 1 and the number itself as its factor.
            //int n;
            //int i = 2;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while(i < n)
            //{
            //    if(n % i == 0)
            //    {
            //        Console.WriteLine(" Not Prime for " + i );
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Prime for "+ i);
            //    }
            //    i += 1;
            //}
            //Console.ReadLine();

            //Print Patterns

            //Q1
            //***
            //***
            //***
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while(i <= n)
            //{
            //    int j = 1;
            //    while(j <= n)
            //    {
            //        Console.Write("* ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}

            //Console.ReadLine();

            //Q2

            //1 1 1
            //2 2 2
            //3 3 3
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= n)
            //    {
            //        Console.Write(i+ " " );
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}

            //Console.ReadLine();


            //Q3

            //1 2 3 4
            //1 2 3 4
            //1 2 3 4
            //1 2 3 4
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= n)
            //    {
            //        Console.Write(j + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}

            //Console.ReadLine();

            //Q4

            // 3 2 1
            // 3 2 1
            // 3 2 1
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= n)
            //    {
            //        Console.Write(n - j + 1 + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}

            //Console.ReadLine();

            //Q5

            //1 2 3
            //4 5 6
            //7 8 9
            //int n;
            //int i = 1;
            //int count = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1 ;
            //    while (j <= n)
            //    {
            //        Console.Write(count + " ");
            //        j = j + 1;
            //        count = count + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q6

            //*
            //* *
            //* * *
            //* * * *
            //* * * * *
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = n - i + 1;
            //    while (j <= n)
            //    {
            //        Console.Write("* ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}

            //Console.ReadLine();

            //2nd Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j =  1;
            //    while (j <= i)
            //    {
            //        Console.Write("* ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q7
            //1
            //2 2
            //3 3 3
            //4 4 4 4
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(i + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q8

            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //int n;
            //int i = 1;
            //int count = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(count + " ");
            //        j = j + 1;
            //        count = count + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q9

            //1
            //2 3
            //3 4 5
            //4 5 6 7
            //5 6 7 8 9

            //1st Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int value = i;
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(value + " ");
            //        j = j + 1;
            //        value = value + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();




            //1
            //2 3
            //3 4 5
            //4 5 6 7
            //5 6 7 8 9

            //2nd Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(i + j - 1 + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q10
            //1
            //2 1
            //3 2 1
            //4 3 2 1
            //5 4 3 2 1

            //1st Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    int value = i;
            //    while (j <= i)
            //    {
            //        Console.Write(value + " ");
            //        j = j + 1;
            //        value = value - 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //2nd Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(i- j + 1 + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q11
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5

            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    int value = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(value + " ");
            //        j = j + 1;
            //        value = value +  1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q12
            //A A A
            //B B B
            //C C C
            //1st Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //int start = 'A';
            //while (i <= n)
            //{
            //    int j = 1;

            //    while (j <= n)
            //    {
            //        Console.Write(Convert.ToChar(start) + " ");

            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //    start = start + 1;
            //}
            //Console.ReadLine();

            //2nd Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine()); 
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= n)
            //    {
            //        char ch = (char) ('A' + i - 1);
            //        Console.Write(ch + " ");

            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q13
            //A B C
            //A B C
            //A B C
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= n)
            //    {
            //        char ch = (char)('A' + j - 1);
            //        Console.Write(ch + " ");

            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q14
            //A B C
            //D E F
            //G H I
            //int n;
            //int start = 'A';
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= n)
            //    {
            //        Console.Write(Convert.ToChar(start) + " ");
            //        start = start + 1;
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q15
            //A B C
            //B C D
            //C D E
            //1st Approach
            //Add 'A'- 1 to both the sides
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= n)
            //    {
            //        char ch = (char)('A' + i + j - 2);
            //        Console.Write(ch + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //A B C
            //B C D
            //C D E
            //2nd Approach

            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    int start = 'A' + i - j;
            //    while (j <= n)
            //    {
            //        Console.Write(Convert.ToChar(start) + " ");
            //        j = j + 1;
            //        start = start + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q16
            //A 
            //B B
            //C C C

            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        char ch = (char)('A' + i - 1);
            //        Console.Write(ch + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q17
            //A
            //B C
            //D E F

            //int n;
            //int i = 1;
            //int start = 'A';
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(Convert.ToChar(start) + " ");
            //        j = j + 1;
            //        start = start + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q18
            //A
            //B C
            //C D E
            //D E F G

            //Add 'A' - 1 to both the sides
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        char ch = (char)('A' + i + j - 2);
            //        Console.Write(ch + " ");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q19
            //D
            //C D
            //B C D
            //A B C D
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());  
            //while (i <= n)
            //{
            //    int j = 1;
            //    int start = 'A' + n - i;
            //    while (j <= i)
            //    {                
            //        Console.Write(Convert.ToChar(start) + " ");
            //        j = j + 1;
            //        start = start + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q20
            //        *
            //      * *
            //    * * *
            //  * * * * 
            //* * * * *
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    //print space
            //    int space = n - i;
            //    while(space > 0)
            //    {
            //        Console.Write(" ");
            //        space = space - 1;
            //    }

            //    //print star
            //    int j = 1;
            //    while(j <= i)
            //    {
            //        Console.Write("*");
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q21
            //* * * *    
            //* * *
            //* *
            //* 

            //1st Approach
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    int j = n - i + 1;
            //    while (j >0)
            //    {
            //        Console.Write("* ");
            //        j = j - 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q22
            //* * * * *
            //  * * * *
            //    * * *
            //      * *
            //        *
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    //print space
            //    int space = i- 1;
            //    while (space > 0)
            //    {
            //        Console.Write(" ");
            //        space = space - 1;
            //    }

            //    //print star
            //    int j = n-  i + 1;
            //    while (j > 0)
            //    {
            //        Console.Write("*");
            //        j = j - 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q23
            //1 1 1 1
            //  2 2 2
            //    3 3 
            //      4
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    //print space
            //    int space = i - 1;
            //    while (space > 0)
            //    {
            //        Console.Write(" ");
            //        space = space - 1;
            //    }
            //    int j = n - i + 1;
            //    while (j > 0)
            //    {
            //        Console.Write(i);
            //        j = j - 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q24
            //      1
            //    2 2 
            //  3 3 3
            //4 4 4 4      
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    //print space
            //    int space = n - i;
            //    while (space > 0)
            //    {
            //        Console.Write(" ");
            //        space = space - 1;
            //    }
            //    int j = 1;
            //    while (j <=i)
            //    {
            //        Console.Write(i);
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();



            //Q25
            //1 2 3 4    
            //  2 3 4
            //    3 4
            //      4      
            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    //print space
            //    int space = i - 1;
            //    while (space > 0)
            //    {
            //        Console.Write(" ");
            //        space = space - 1;
            //    }
            //    int j = i;
            //    while (j <= n)
            //    {
            //        Console.Write(j);
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();


            //Q25
            //      1    
            //    2 3
            //  4 5 6
            //7 8 9 10      
            //int n;
            //int i = 1;
            //int count = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    //print space
            //    int space = n - i;
            //    while (space > 0)
            //    {
            //        Console.Write(" ");
            //        space = space - 1;
            //    }

            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(count);
            //        count = count + 1;
            //        j = j + 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;
            //}
            //Console.ReadLine();

            //Q26
            //      1
            //    1 2 1
            //  1 2 3 2 1
            //1 2 3 4 3 2 1

            //int n;
            //int i = 1;
            //Console.Write("Enter any number ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    //print space
            //    int space = n - i;
            //    while (space > 0)
            //    {
            //        Console.Write(" ");
            //        space = space - 1;
            //    }

            //    //Print first triangle
            //    int j = 1;
            //    while(j <= i) 
            //    {
            //        Console.Write(j);
            //        j = j + 1;
            //    }

            //    //print second triangle
            //    int k = i-1;
            //    while (k >0)
            //    {
            //        Console.Write(k);
            //        k = k - 1;
            //    }
            //    Console.WriteLine();
            //    i = i + 1;          
            //}
            //Console.ReadLine();

            //Q27
            //1 2 3 4 5 5 4 3 2 1
            //1 2 3 4 * * 4 3 2 1
            //1 2 3 * * * * 3 2 1
            //1 2 * * * * * * 2 1
            //1 * * * * * * * * 1

            int n;
            int i = 1;
            Console.Write("Enter any number ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                //print first triangle
                int j = 1;
                while (j<= n-i+1)
                {
                    Console.Write(j);
                    j = j + 1;
                }

                //Print second triangle
                int k = 1;
                while (k <= i - 1)
                {
                    Console.Write("*");
                    k = k + 1;
                }

                //print third triangle
                int l = 1;
                while (l <= i - 1)
                {
                    Console.Write("*");
                    l = l + 1;
                }

                //print fourth triangle
                int m = n - i + 1;
                while (m > 0)
                {
                    Console.Write(m);
                    m = m - 1;
                }
                Console.WriteLine();
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}
