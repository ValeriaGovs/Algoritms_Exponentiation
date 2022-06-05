using System;

namespace Algoritms_Exponentiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Exponentiation e = new Exponentiation();

            int n =  10000;
            double a =  1.001;
            TimeTest.Test(n, a, e.Iterative, $"iterative {a}^");
           
            TimeTest.Test(n, a, e.Multiply, $"Multiply {a}^");

            TimeTest.Test(n, a, e.BinaryDecomposition, $"BinaryDecomposition {a}^");

            
        }
    }
}
