using System;

namespace ConsoleApp5_Small_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer();
            cust1.FirstName = "Bob";
            cust1.LastName = "Dylan";
            cust1.Address = "Bongostreet 22";

            Console.WriteLine($"Name: {cust1.FirstName} {cust1.LastName}");

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

            while(selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("List Customers");
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
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("Bye bye!");

            Console.ReadLine();
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select What you want to do:\n");
          
            for (int i = 0; i < menuItems.Length; i++)
            {
                //Console.WriteLine((i + 1) + ":" + menuItems[i]);
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while( !int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 5)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            return selection;
        }
    }
}