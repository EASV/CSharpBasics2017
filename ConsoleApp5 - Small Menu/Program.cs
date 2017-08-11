using System;

namespace ConsoleApp5___Small_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = {
                "List All Customers",
                "Add Customer",
                "Delete Customer",
                "Edit Customer",
                "Exit"
            };

            //Show Menu
            //Wait for Selection
            // - Show selection or
            // - Warning and go back to menu

            var selection = ShowMenu(menuItems);

            if (selection == 1)
            {
                Console.WriteLine("List Customers");
            }
            else if (selection == 2)
            {
                Console.WriteLine("Add Customer");
            }
            else if (selection == 3)
            {
                Console.WriteLine("Delete Customer");
            }
            else if (selection == 4)
            {
                Console.WriteLine("Edit Customer");
            }
            else
            {
                Console.WriteLine("Bye bye!");
            }

            Console.ReadLine();
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.Clear();
            Console.WriteLine("Select What you want to do:");
            Console.WriteLine("");
          
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);

            }

            int selection;
            while( !int.TryParse(Console.ReadLine(), out selection)
                //OR
                || selection < 1
                || selection > 5)
            {
                Console.WriteLine("You need to select a number between 1-5");
            }

            return selection;
        }
    }
}