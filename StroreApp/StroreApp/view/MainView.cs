using System;
using StroreApp.controller;

namespace StroreApp.view
{
    public class MainView
    {
        private static ProductController controller = new ProductController();
        public static void GenerateMenu()
        {
            Console.WriteLine("Welcome to Product management program");
            while (true)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option to continue");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        controller.Add();
                        break;
                    case 2:
                        controller.Display();
                        break;
                    case 3:
                        controller.Delete();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}