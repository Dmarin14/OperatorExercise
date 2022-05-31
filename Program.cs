using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
                Console.WriteLine($"{a}/{b} is {b} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The radius of your circle is {AreaOfCirlce(radius)}");
            Console.ReadLine();
        }

        public static double AreaOfCirlce(double radius)
        {
            var result = Math.PI * radius * radius;
            return result; 
        }
    }
}
