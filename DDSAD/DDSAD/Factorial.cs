namespace DDSAD
{
    public class Factorial
    {
        //Calculate Factorial
        public int CalculateFactorial (int n)
        {
            if (n == 0)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
