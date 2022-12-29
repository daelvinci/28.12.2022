using System;
using System.Collections.Generic;
using System.Text;

namespace Dersdekiler.Interfaces
{
    internal interface IStore
    {
        Product[] Products { get; }
        Sales[] Sales { get; }
        void AddProduct(Product pr);
        void Sell(string name);
        double TotalAmount { get; }
       
        //1.Products arrayi var property ile(field evezi )
        //2. Sales Arrayi property (satislar arrayi) (field evezi)
        //3. Total amount property field evezi
        //. AddProduct (void) parametr olaraq product obyekti qebul edir, abstract metod (private)
        //4. Sell parametr olaraq string name (productun name) 

    }
}
