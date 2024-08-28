using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdasExercise03
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            var value = GetRandomDouble(100);
            PrintValue(value);
        }
        static double GetRandomDouble(int max)
        {
            return max * random.NextDouble();
        }
        static void PrintValue(double d)
        {
            Console.WriteLine($"The value is {d:0.0000}");
        }
    }
}
