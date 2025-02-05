using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntuacion_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa tu puntuacion");
            double p = double.Parse(Console.ReadLine());
            if(p >= 100)
            {
                System.Console.WriteLine("ALTO");
            }
            else
            {
                System.Console.WriteLine("BAJO");
            }
        }
    }
}
