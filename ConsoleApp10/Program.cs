using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Parallelepiped
    {
        private double x, y, z;

        public Parallelepiped(double a, double b, double c)
        { x = a; y = b; z = c; }

        public void Print()
        { Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z); }

        public bool Correct()
        { if (x > 0 && y > 0 && z > 0) return true; else return false; }

        public double Area()
        { return 2 * (x * y + x * z + y * z); }

        public double Volume()
        { return x * y * z; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x, y, z;
                Console.WriteLine("Enter x: "); x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter y: "); y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter z: "); z = Convert.ToDouble(Console.ReadLine());

                Parallelepiped P = new Parallelepiped(x, y, z);
                P.Print();
                if (P.Correct())
                {

                    Console.WriteLine("Area size = " + P.Area() );
                    Console.WriteLine("Volume = " + P.Volume() );
                }
                else Console.WriteLine("Object cannot exist! Sides can only be positive numbers!");
                
            }
            catch(Exception Exc)
            {
                Console.WriteLine("Error: " + Convert.ToString(Exc));
            }
            Console.ReadLine();
        }
    }
}
