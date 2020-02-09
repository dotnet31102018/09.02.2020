using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{


    class Program
    {
        static void Main(string[] args)
        {
            Point secretPoint = new Point(4.5f, 9.876f);

            Point clonedPoint = secretPoint.Clone();
            ShareSecretData(clonedPoint);

            Console.WriteLine(secretPoint);

            Line l1 = new Line(new Point(10, 5), new Point(100, 100));
            Console.WriteLine("Before ");
            Console.WriteLine(l1);
            Line cloned_line = l1.Clone();
            ShareSecretData(cloned_line);
            Console.WriteLine("After ");
            Console.WriteLine(l1);

            Console.WriteLine("=============================================");
            Console.WriteLine();
            LineW l2 = new LineW(new Point(4, 5), new Point(6, 7));

            Console.WriteLine("=============================================");
            Console.WriteLine();
            Employee e = new Employee() { Id = 1, FName = "Assi", LName = "Cohen" };
            e.Print();
            int x = 5;
            Console.WriteLine(x.Div2());
            Employee new_employee = e.CloneObject<Employee>();

        }
        static void ShareSecretData(Point p)
        {
            Console.WriteLine("Register point");
            p.X = -999;
            Console.WriteLine($"Point in ShareSecretData {p}");
        }

        static void ShareSecretData(Line l1)
        {
            Console.WriteLine("Register line");
            l1.P1.X = -999;
            Console.WriteLine($"Line in ShareSecretData {l1}");
        }
    }
}
