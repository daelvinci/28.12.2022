using System;

namespace Dersdekiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soliton soliton = new Soliton();

            soliton.AddProduct(new Product { Name = "Paltaryuyan", Price = 2000, ExpireDate = new DateTime(2023, 10, 20) });
            soliton.AddProduct(new Product { Name = "Etceken", Price = 190, ExpireDate = new DateTime(2024, 10, 20) });
            soliton.AddProduct(new Product { Name = "Tozsoran toshiba", Price = 300, ExpireDate = new DateTime(2024, 12, 24) });

            soliton.Sell("Paltaryuyan");
            soliton.Sell("Etceken");
            soliton.Sell("Tozsoran toshiba");

            Console.WriteLine(soliton.TotalAmount);
        }
    }
}
