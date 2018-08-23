using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    public class Printer
    {
        readonly string[] menuItems = {
                "List All Customers",
                "Add Customer",
                "Delete Customer",
                "Edit Customer",
                "Exit"
            };

        public Printer() {


            //Show Menu
            //Wait for Selection
            // - Show selection or
            // - Warning and go back to menu

            var selection = ShowMenu();

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("List All Customers");
                        break;
                    case 2:
                        Console.WriteLine("Add Customer");
                        break;
                    case 3:
                        Console.WriteLine("Delete Customer");
                        break;
                    case 4:
                        Console.WriteLine("Edit Customer");
                        break;
                    default:
                        break;
                }
                selection = ShowMenu();
            }
            Console.WriteLine("Bye bye!");

            Console.ReadLine();
        }

        int ShowMenu()
        {
            Console.WriteLine("Select What you want to do:\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                //Console.WriteLine((i + 1) + ":" + menuItems[i]);
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 5)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            return selection;
        }
    }
}
