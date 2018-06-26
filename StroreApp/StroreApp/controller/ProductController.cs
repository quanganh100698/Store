using System;
using StroreApp.model;
using StroreApp.entity;

namespace StroreApp.controller
{
    public class ProductController
    {
        private ProductModel model = new ProductModel();
        public void Add()
        {
            Console.WriteLine("Please enter your product infomation");
            Console.WriteLine("Product ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Product name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Product price: ");
            var price = Console.ReadLine();
            var product = new Product(id, name, price);
            model.Save(product);
            Console.WriteLine("Success!");
            Console.ReadLine();
        }

        public void Display()
        {
            
        }

        public void Delete()
        {
            Console.WriteLine("Enter product ID you want to delete");
            var id = Console.ReadLine();
            model.GetId(id);
        }
    }
}