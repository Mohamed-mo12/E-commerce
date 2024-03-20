using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class Products
    {
        private static int IDincremnet = 0;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Model { get;  private set; }

        
        public Products(string name , decimal price , int model)
        {
            this.Id = IDincremnet++;
            this.Name = name;
            this.Model = model;
            this.Price = price;

        }

        



    }
}
