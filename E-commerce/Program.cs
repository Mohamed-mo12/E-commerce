using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Our Website ");
            int number;
            Category Electrics = new Category();
            do
            {
                Console.WriteLine(" To Add product press 1 \n" +
                    "To Display Products press 2 \n" +
                    "To Remove Product press  3 \n" +
                    "To Search for products press 4  \n" +
                    " To Exit press 5 ");
                Console.WriteLine(" Enter number ");
                 number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                  
                        Console.WriteLine(" oky , You can Add now ");
                        Console.WriteLine("Enter Name  ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Price ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Model ");
                        int model = int.Parse(Console.ReadLine());
                        Products P1 = new Products(name,price,model);
                        Electrics.AddProduct(P1);
                        break;
                    case 2:
                        Console.WriteLine(" This is All products in Electrics ");
                        Electrics.DisplayProducts();
                        break;
                    case 3:
                        Electrics.RemoveProduct(P1);
                    default:
                        break;
                }

            } while (number != 5 );

            Console.ReadKey();

        }
    }
}
