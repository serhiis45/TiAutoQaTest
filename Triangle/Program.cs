using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Triangle
    {
        static void Main(string[] args)
        {

            // input of application
            Console.WriteLine("Enter coordinate x of a dot A: ");
            double xA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of a dot A: ");
            double yA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of a dot B: ");
            double xB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of a dot B: ");
            double yB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of a dot C: ");
            double xC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of a dot C: ");
            double yC = Convert.ToDouble(Console.ReadLine());

            // the length of triangle sides           
            double AB = Convert.ToDouble(Math.Sqrt((Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2))));
            Console.WriteLine("Lenght of AB is: '" + AB + "'");
            double BC = Convert.ToDouble(Math.Sqrt((Math.Pow(xB - xC, 2) + Math.Pow(yB - yC, 2))));
            Console.WriteLine("Lenght of BC is '" + BC + "'");
            double AC = Convert.ToDouble(Math.Sqrt((Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2))));
            Console.WriteLine("Lenght of AC is: '" + AC + "'");

            // is it equilateral triangle?
            if (double.Equals(AB, BC) && double.Equals(AB, AC) && double.Equals(BC, AC))
            {
                Console.WriteLine("\nTriangle IS equilateral");
            }
            else
            {
                Console.WriteLine("\nTriangle IS NOT equilateral");
            }

            // is it isosceles triangle?
            if (double.Equals(AB, BC) || double.Equals(AB, AC) || double.Equals(BC, AC))
            {
                Console.WriteLine("Triangle IS isosceles");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT isosceles");
            }

            // is it right triangle?
            double AB2 = Math.Pow(AB, 2);
            double BC2 = Math.Pow(BC, 2);
            double AC2 = Math.Pow(AC, 2);

            if ((AB2 - (BC2 + AC2) <= 0.1) || (BC2 - (AB2 + AC2) <= 0.1) || (AC2 - (AB2 + BC2) <= 0.1))
            {
                Console.WriteLine("Triangle IS right");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT right");
            }
            // perimeter
            double perimeter = AB + BC + AC;
            Console.WriteLine("Perimeter: '" + perimeter + "'");

            // parity array
            double roundPerimeter = Math.Ceiling(perimeter);
            int intRoundPerimeter = Convert.ToInt32(roundPerimeter);

            Console.WriteLine("\n Parity numbers in range from 0 to triangle perimeter: ");
            Parity(2, intRoundPerimeter);

            static void Parity(int stVal, int intRoundPerimeter)
            {
                if (stVal > intRoundPerimeter)
                    return;
                Console.Write(" {0}  ", stVal);
                Parity(stVal + 2, intRoundPerimeter);
            }

        }
    }
}
