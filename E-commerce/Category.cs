using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class Category
    {
        private static int Idincrement = 0 ;

        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> category { get; set; }
        public List<Products> products { get; set; }

        public Category()
        {
            this.Id = Idincrement++;
            products = new List<Products>();
        }


        public void AddCategory(string name) {

            category.Add(name);
        
        }
        /*public Category(string name )
        {
            this.Id = Idincrement++;
            this.Name = name;
            products = new List<Products>();
        }
        */

        public void AddProduct(Products product) {

            if (product == null)
            {
                Console.WriteLine(" Invalid prodcut, cannot add null product ");
            }

            if (string.IsNullOrEmpty(product.Name))
            {
                Console.WriteLine(" Invalid product Name ");
                return;
            }
            if (product.Price <= 0)
            {
                Console.WriteLine("invalid");
                return;
            }
            if (product.Model < 2000)
            {
                Console.WriteLine("Invalid Model");
                return;
            }

            this.products.Add(product);
            Console.WriteLine(" You are add successfully ");
            
        
        }
            
        public void DisplayProducts() {

            if (products.Count == 0)
            {
                Console.WriteLine(" Empty ");
                return;
            }


            foreach (var item in products)
            {
                Console.WriteLine($" product Name: {item.Name}\n " +
                          $"product Model: {item.Model}\n" +
                          $"product Price: {item.Price}");
            }
        
        }

        public void RemoveProduct(Products product) {

            if (products.Contains(product))
            {
                products.Remove(product);
                Console.WriteLine($" {product.Name} Removed seccssuffully  ");

            }
            else
            {
                Console.WriteLine(" Product not exist ");
            }
            /*
             (we can by for loop aslo )
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] == product)
                {
                    products.Remove(product);
                }
            }
            */
        }

        public Products SerachProdcut(Products product) {

            if (products.Contains(product))
            {
                Console.WriteLine($" prodcut found : {product}");
                return product;
            }
            else
            {
                Console.WriteLine("Product not found.");
                return null;
            }
        
        }

        
    }
}
