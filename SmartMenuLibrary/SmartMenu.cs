﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        List<string> menuStructure = new List<string>();
        List<string> menuPoints = new List<string>();

        public void Load(string path)
        {
            if (path == "fejl")
            {
                Console.WriteLine("det indtastede input kendes ikke, prøv igen.");
            }
            else
            {
                System.IO.StreamReader txtmenu =
                    new System.IO.StreamReader(@"\Users\Christian\source\repos\SmartMenuLibrary!\SmartMenuLibrary\" + path);

                string line;
                int i = 1;

                menuStructure.Add(txtmenu.ReadLine());
                menuStructure.Add(" ");
                string lastLine = txtmenu.ReadLine();

                while ((line = txtmenu.ReadLine()) != null)
                {
                    string[] splitMenu = line.Split(';');
                    menuStructure.Add(" " + i + ". " + splitMenu[0]);
                    menuPoints.Add(splitMenu[1]);
                    i++;
                }
                menuStructure.Add(" ");
                menuStructure.Add(lastLine);
            }
        }

        public void Activate()
        {

            bool usingMenu = true;
            while (usingMenu)
            {
                Console.Clear();
                menuStructure.ForEach(Console.WriteLine);
                int.TryParse(Console.ReadLine(), out int r);
                Console.Clear();
                switch (r)
                {
                    case 0:
                        Console.WriteLine("leaving menu");
                        usingMenu = false;
                        break;

                    case 1:
                        Bindings.Callid(menuPoints[0]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 2:
                        Bindings.Callid(menuPoints[1]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 3:
                        Bindings.Callid(menuPoints[2]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 4:
                        Bindings.Callid(menuPoints[3]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 5:
                        Bindings.Callid(menuPoints[4]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 6:
                        Bindings.Callid(menuPoints[5]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 7:
                        Bindings.Callid(menuPoints[6]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 8:
                        Bindings.Callid(menuPoints[7]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    case 9:
                        Bindings.Callid(menuPoints[8]);
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                    default:
                        Console.WriteLine("input var ikke et menu punkt");
                        Console.WriteLine();
                        Console.WriteLine("press enter to return");
                        break;

                }
                Console.ReadLine();

            }
        }

        public string ChooseLanguage(int language)
        {
            if (language == 1)
            {
                return "MenuSpecDK.txt";
            }
            else if (language == 2)
            {
                return "MenuSpecEN.txt";
            }
            return "fejl";
        }
    }
}
