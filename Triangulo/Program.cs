using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(5, 5, 5);
            Triangulo triangulo2 = new Triangulo(5, 5, 6);
            Triangulo triangulo3 = new Triangulo(5, 7, 8);
            Triangulo triangulo4 = new Triangulo(1, 2, 5);

            Triangulo triangulo5 = new Triangulo(5, 6, 5);
            Triangulo triangulo6 = new Triangulo(6, 5, 5);

            Console.WriteLine(triangulo1.MostrarTipo());
            Console.WriteLine(triangulo2.MostrarTipo());
            Console.WriteLine(triangulo5.MostrarTipo());
            Console.WriteLine(triangulo6.MostrarTipo());
            Console.WriteLine(triangulo3.MostrarTipo());
            Console.WriteLine(triangulo4.MostrarTipo());
            Console.ReadLine();
        }
    }
}
