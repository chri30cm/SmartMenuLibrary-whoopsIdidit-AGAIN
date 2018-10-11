using System;
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
        List<string> menuDescription = new List<string>();
        List<string> menuReturn = new List<string>();

        public void Load(string path)
        {
            if (path == "fejl")
            {
                Console.WriteLine("det indtastede input kendes ikke, prøv igen.");
            }
            else
            {
                System.IO.StreamReader txtmenu =
                    new System.IO.StreamReader(@"\Users\Bruger\source\repos\SmartMenuLibrary\SmartMenuLibrary\" + path);

                string line;
                int i = 1;

                menuStructure.Add(txtmenu.ReadLine());
                menuStructure.Add(" ");
                string lastLine = txtmenu.ReadLine();

                while ((line = txtmenu.ReadLine()) != null)
                {
                    string[] splitMenu = line.Split(';');
                    menuStructure.Add(" " + i + ". " + splitMenu[0]);
                    menuDescription.Add(splitMenu[1]);
                    menuReturn.Add(splitMenu[2]);
                    menuPoints.Add(splitMenu[3]);
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
                Console.WriteLine(" ");
                Console.Write(": ");
                int.TryParse(Console.ReadLine(), out int r);
                Console.Clear();
                switch (r)
                {
                    case 0:
                        Console.WriteLine(" :hej hej bye bye ");
                        usingMenu = false;
                        break;

                    case 1:
                        Console.WriteLine(menuDescription[0]);
                        Bindings.Callid(menuPoints[0]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[0]);
                        break;

                    case 2:
                        Console.WriteLine(menuDescription[1]);
                        Bindings.Callid(menuPoints[1]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[1]);
                        break;

                    case 3:
                        Console.WriteLine(menuDescription[2]);
                        Bindings.Callid(menuPoints[2]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[2]);
                        break;

                    case 4:
                        Console.WriteLine(menuDescription[3]);
                        Bindings.Callid(menuPoints[3]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[3]);
                        break;

                    case 5:
                        Console.WriteLine(menuDescription[4]);
                        Bindings.Callid(menuPoints[4]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[4]);
                        break;

                    case 6:
                        Console.WriteLine(menuDescription[5]);
                        Bindings.Callid(menuPoints[5]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[5]);
                        break;

                    case 7:
                        Console.WriteLine(menuDescription[6]);
                        Bindings.Callid(menuPoints[6]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[6]);
                        break;

                    case 8:
                        Console.WriteLine(menuDescription[7]);
                        Bindings.Callid(menuPoints[7]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[7]);
                        break;

                    case 9:
                        Console.WriteLine(menuDescription[8]);
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[8]);
                        Bindings.Callid(menuPoints[8]);
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("input var ikke et menu punkt, im sorry.");
                        Console.WriteLine();
                        Console.WriteLine(menuReturn[9]);
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
