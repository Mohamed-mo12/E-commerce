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

        public Products RemoveProduct(string Name) {

            Products P = SerachProdcut(Name);
            if (P != null )
            {
                products.Remove(P);
                Console.WriteLine($" Secssefully Deleted {Name} ");
            }
            else
            {
                Console.WriteLine(" Product not Found ");
            }
            return P; 
        }
        


        public Products SerachProdcut(string name) {

            foreach (var item in products)
            {
                if (item.Name == name)
                {
                    Console.WriteLine($" product {name} is Exist ");
                    return item;
                }
            }
            Console.WriteLine(" Product name is not Found  ");
            return null;            
        }

        

        
    }
}
