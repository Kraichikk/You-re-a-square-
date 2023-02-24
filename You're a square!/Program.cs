using System;

namespace You_re_a_square_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSquare(25));
            Console.WriteLine(IsSquare(26));
        }
        public static bool IsSquare(int n)
        {
            if (n < 0)
                return false;

            if (n == 0)
                return true;

            int num = 0;
            double dobNum = 0;
            double result = 0;

            num = Convert.ToInt32(Math.Sqrt(n));
            dobNum = Math.Sqrt(n);
            result = dobNum - num;

            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
