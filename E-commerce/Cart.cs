using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class Cart
    {

        public List<Products> Items { get; private set; }

        public Cart()
        {
            Items = new List<Products>();
        }

        public void AddToCart(Products product) {

            Items.Add(product);
        
        }

        public void RemoveFromCart(Products product) {

            if (Items.Contains(product))
            {
                Items.Remove(product);
            }
            else {
                Console.WriteLine(" Prodcut not exist ");
            }
        
        }


        public void GetTotalPrice() {
            decimal TotalPrice = 0;

            foreach (var item in Items)
            {
                TotalPrice += item.Price;
            }
            Console.WriteLine($"{TotalPrice}");
            
        }



       


        


    }
}
