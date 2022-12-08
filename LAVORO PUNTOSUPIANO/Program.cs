using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LAVORO_PUNTOSUPIANO
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto uno = new Punto(1, 4);
            double x2, y2;
            Console.WriteLine("Please insert two values (x and y)");
            
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(uno.Distanza2Punti(uno.X, uno.Y, x2, y2));

            Thread.Sleep(5000);
        }
    }
}
