using System;
using System.Collections.Generic;
using CalculatorLibrary;

namespace SmartMenuLibrary
{
    public class Bindings
    {
        public static void Callid(string menu_id)
        {
            if (menu_id == "menu1")
            {
                Console.WriteLine("Enter 2 numbers which you wish to Add");
                Console.WriteLine(" ");
                string lineadd = Console.ReadLine();
                Console.Write(" + ");
                string lineadd2 = Console.ReadLine();
                double.TryParse(lineadd, out double r);
                double.TryParse(lineadd2, out double r2);
                Console.WriteLine(" ");
                Console.WriteLine(r + " + " + r2 + " = " + Calculator.Add(r, r2));
            }

            else if (menu_id == "menu2")
            {
                Console.WriteLine("Enter 2 numbers which you wish to Subtract");
                Console.WriteLine(" ");
                string linesub = Console.ReadLine();
                Console.WriteLine("-");
                string linesub2 = Console.ReadLine();
                double.TryParse(linesub, out double r);
                double.TryParse(linesub2, out double r2);
                Console.WriteLine(" ");
                Console.WriteLine(r + " - " + r2 + " = " + Calculator.Subtract(r, r2));
            }

            else if (menu_id == "menu3")
            {
                Console.WriteLine("Enter 2 numbers which you wish to Multiply");
                Console.WriteLine(" ");
                string linemulti = Console.ReadLine();
                Console.WriteLine("*");
                string linemulti2 = Console.ReadLine();
                double.TryParse(linemulti, out double r);
                double.TryParse(linemulti2, out double r2);
                Console.WriteLine(" ");
                Console.WriteLine(r + " * " + r2 + " = " + Calculator.Multiply(r, r2));
            }

            else if (menu_id == "menu4")
            {
                Console.WriteLine("Enter 2 numbers which you wish to Divide");
                Console.WriteLine(" ");
                string linediv = Console.ReadLine();
                Console.WriteLine("/");
                string linediv2 = Console.ReadLine();
                double.TryParse(linediv, out double r);
                double.TryParse(linediv2, out double r2);
                Console.WriteLine(" ");
                Console.WriteLine(r + " / " + r2 + " = " + Calculator.Divide(r, r2));
            }

            else if (menu_id == "menu5")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine("Tast alle de tal ind du vil Summere og afslut med tom linje");
                Console.WriteLine(" ");
                while (double.TryParse(Console.ReadLine(), out double r) != false)
                {
                    numbers.Add(r);
                }

                Console.WriteLine(" = " + Calculator.Sum(numbers));
            }

            else if (menu_id == "menu6")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine("Tast alle de tal ind du vil finde Minumum af og afslut med tom linje");
                Console.WriteLine(" ");
                while (double.TryParse(Console.ReadLine(), out double r) != false)
                {
                    numbers.Add(r);
                }

                Console.WriteLine(" = " + Calculator.Minimum(numbers));
            }

            else if (menu_id == "menu7")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine("Tast alle de tal ind du vil finde Maximum af og afslut med tom linje");
                Console.WriteLine(" ");
                while (double.TryParse(Console.ReadLine(), out double r) != false)
                {
                    numbers.Add(r);
                }

                Console.WriteLine(" = " + Calculator.Maximum(numbers));
            }

            else if (menu_id == "menu8")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine("Tast alle de tal ind du vil finde Gennemsnittet af og afslut med tom linje");
                Console.WriteLine(" ");
                while (double.TryParse(Console.ReadLine(), out double r) != false)
                {
                    numbers.Add(r);
                }

                Console.WriteLine(" = " + Calculator.Average(numbers));
            }

            else if (menu_id == "menu9")
            {
                Console.WriteLine("Jeg Elsker Dig :)");
                Console.WriteLine(" ");
                Console.WriteLine("tryk enter for at gå tilbage");
                Console.WriteLine(Calculator.Haha_snydT(Console.ReadLine()));
            }
        }
    }
}