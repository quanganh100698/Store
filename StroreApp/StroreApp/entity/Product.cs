﻿namespace StroreApp.entity
{
    public class Product
    {
        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Price
        {
            get => _price;
            set => _price = value;
        }

        public Product(string id, string name, string price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        private string _id;
        private string _name;
        private string _price;
        
    }
}