
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Representation.StudentMenu();
                ConsoleKeyInfo select = Console.ReadKey(true);
                switch (select.Key)
                {
                    case ConsoleKey.A:
                        Representation.Add();
                        break;

                    case ConsoleKey.P:
                        Representation.Print();
                        break;

                    case ConsoleKey.D:
                        Representation.Delete();
                        break;


                    case ConsoleKey.E:
                        Representation.Edite();
                        break;


                    case ConsoleKey.Escape:
                        break;

                    default:
                        Representation.WrongInput();
                        break;
                }

            }

            
        }
    }
}
