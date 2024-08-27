using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligates
{
    internal class Calculator
    {

        public void AddNos(long X, long Y)
        {
            Console.WriteLine($"The Sum is: {X + Y}");
        }
        public double Multiply(double X, double Y)
        {
            Console.WriteLine("Multiply Method");
            return X * Y;
        }
        public   double  Divide(double X, double Y)
        {
            Console.WriteLine("Divide Method");
            return X / Y;
        }
    }
}
