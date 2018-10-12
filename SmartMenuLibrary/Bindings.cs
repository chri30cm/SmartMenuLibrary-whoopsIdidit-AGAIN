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
                Console.WriteLine();
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine("+");
                double input2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(input + " + " + input2 + " = " + Calculator.Add(input, input2));
            }

            else if (menu_id == "menu2")
            {
                Console.WriteLine();
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine("-");
                double input2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(input + " - " + input2 + " = " + Calculator.Subtract(input, input2));
            }

            else if (menu_id == "menu3")
            {
                Console.WriteLine();
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine("*");
                double input2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(input + " + " + input2 + " = " + Calculator.Multiply(input, input2));
            }

            else if (menu_id == "menu4")
            {
                Console.WriteLine();
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine("/");
                double input2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(input + " / " + input2 + " = " + Calculator.Divide(input, input2));
            }

            else if (menu_id == "menu5")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine();

                bool Looprunning = true;
                while (Looprunning != false)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        numbers.Add(0);
                        Looprunning = false;
                    }
                    else
                    {
                        double inputD = double.Parse(input);
                        numbers.Add(inputD);
                    }
                }

                Console.WriteLine(" = " + Calculator.Sum(numbers));
            }

            else if (menu_id == "menu6")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine();

                bool Looprunning = true;
                while (Looprunning != false)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        numbers.Add(0);
                        Looprunning = false;
                    }
                    else
                    {
                        double inputD = double.Parse(input);
                        numbers.Add(inputD);
                    }
                }

                Console.WriteLine(" = " + Calculator.Minimum(numbers));
            }

            else if (menu_id == "menu7")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine();

                bool Looprunning = true;
                while (Looprunning != false)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        numbers.Add(0);
                        Looprunning = false;
                    }
                    else
                    {
                        double inputD = double.Parse(input);
                        numbers.Add(inputD);
                    }
                }

                Console.WriteLine(" = " + Calculator.Maximum(numbers));
            }

            else if (menu_id == "menu8")
            {
                List<double> numbers = new List<double>();
                Console.WriteLine();

                bool Looprunning = true;
                while (Looprunning != false)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        numbers.Add(0);
                        Looprunning = false;
                    }
                    else
                    {
                        double inputD = double.Parse(input);
                        numbers.Add(inputD);
                    }
                }

                Console.WriteLine(" = " + Calculator.Average(numbers));
            }

            if (menu_id == "menu9")
            {
                Console.WriteLine();
                double input = double.Parse(Console.ReadLine());
                Console.WriteLine("%");
                double input2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(input + " % " + input2 + " = " + Calculator.Procent(input, input2));
            }
        }
    }
}

//try
//{
//    string hytteost = Console.ReadLine();

//    if (string.IsNullOrEmpty(hytteost))
//    {

//            Console.WriteLine("fejl");
//    }
//    else
//    {

//        double hytteostD = Convert.ToDouble(hytteost);
//        numbers.Add(hytteostD);
//    }

//}
//catch 
//{
//    while
//}