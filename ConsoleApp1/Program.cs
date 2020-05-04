using System;

namespace ConsoleApp2._2
{
    public class Program
    {
        static public double Calculation(double x)
        {
            double z = (2 + x * 3) / (x + Math.Sqrt(13 * Math.Abs(x)));
            return z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" y = f(x) на промiжку [-3, 3]  dx = 0.5.\n\tx\t\ty = f(x)");
            double x = -3;
            double y;
            do
            {
                y = Calculation(x);
                Console.WriteLine("\t{0}\t\t{1}", x, y);
                x += 0.5;
            } while (x <= 3);
        }
    }
}