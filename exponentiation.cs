using System;


namespace Algoritms_Exponentiation
{
    public class Exponentiation
    {
        public void Iterative(int degree,double a)
        {
            double n = 1;
            for (int i = 0; i < degree; i++)
                n *= a;

            Console.WriteLine($"{n}");

        }


        public void Multiply(int degree, double d)
        {
            double a = d;
            int i = 1;
            for (; i <= degree/2; i*=2)
                d *= d;

            for (; i < degree; i++)
                d *= a;

            Console.WriteLine($"{d}");
        }

        public void BinaryDecomposition(int degree,double a)
        {
            int n = degree;
            double d = a;
            double p=1;

            while (n > 1)
            {
                n /= 2;
                d *=d;

                if (n % 2 == 1)
                    p *= d;
            }

            Console.WriteLine($" {p}");
        }
    }
}
