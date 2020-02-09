using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitordp
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            Chocolate toblerone = new Chocolate(95);

            Console.WriteLine(toblerone);

            Console.WriteLine($"Price after tax = {toblerone.Accept(endOfYearVisitor)}");

            Circle c = new Circle();
            c.Radius = 3.9f;
            ShapeVisitor shapeVisitor = new ShapeVisitor();

            Console.WriteLine(c.Accept(shapeVisitor)); // calc area

            Shape3dVisitor shape3dVisitor = new Shape3dVisitor();
            Console.WriteLine(c.Accept(shape3dVisitor)); // calc area

        }
    }
}
