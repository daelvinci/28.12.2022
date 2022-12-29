using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Dersdekiler.Interfaces;

namespace Dersdekiler
{
    internal class Soliton :IStore
    {
        private Product[] _products = new Product[0];
        public Product[] Products { get => _products; }

        private Sales[] _sales = new Sales[0];
        public Sales[] Sales { get => _sales; }

        private double _totalAmount = 0;
        public double TotalAmount { get => _totalAmount; }

        public void AddProduct(Product pr)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = pr;

        }
        public void Sell(string prName)
        {
            Product wantedProduct = FindByName(prName);

            if (wantedProduct != null)
            {
                _totalAmount += wantedProduct.Price;


                Sales newSale = new Sales
                {
                    ProductName = wantedProduct.Name,
                    Amount = wantedProduct.Price,
                    Date = DateTime.Now

                };
                Array.Resize(ref _sales, _sales.Length + 1);
                _sales[_sales.Length - 1] = newSale;
            }

        }

        public Product FindByName(string name)
        {
            name = name.ToLower();
            if (!string.IsNullOrEmpty(name))
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (_products[i].Name.ToLower() == name)
                    {
                        return _products[i];
                    }
                }

            }
            return null;
        }


        //1.Products arrayi var property ile(field evezi )
        //2. Sales Arrayi property (satislar arrayi) (field evezi)
        //3. Total amount property field evezi
        //4. AddProduct (void) parametr olaraq product obyekti qebul edir, abstract metod (private)
        //5. Sell parametr olaraq string name (productun name)     
    }
}
