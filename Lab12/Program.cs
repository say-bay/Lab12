using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Сir.Per(10));
            Console.WriteLine(Program.Сir.Sq(10));
            Console.WriteLine(Program.Сir.Aff(10, 15, 18));
            Console.ReadKey();
        }
        public static class Сir
        {
            public static double Per(int rad)
            {
                double result = 2 * Math.PI * rad;
                return result;
            }
            public static double Sq(int rad)
            {
                double result = Math.PI * rad * rad;
                return result;
            }
            public static bool Aff(int x, int y, int rad)
            {
                if (((x * x) + (y * y)) <= (rad * rad))
                {
                    bool result = true;
                    return result;
                }
                else
                {
                    bool result = false;
                    return result;
                }
            }

        }
    }
}
