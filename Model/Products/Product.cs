using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList
{
    public class Product
    {
        private string  _name, _description, _price;
        private int _stock, _id;

        public Product()
        {
        }

        public Product(int id, string name, string description, string price, int stock)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
            _stock = stock;
        }
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string Price { get => _price; set => _price = value; }
        public int Stock { get => _stock; set => _stock = value; }
    }
}
