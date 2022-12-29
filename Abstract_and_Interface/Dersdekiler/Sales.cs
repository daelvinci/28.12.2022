using System;
using System.Collections.Generic;
using System.Text;

namespace Dersdekiler
{
    internal class Sales
    {
        public string ProductName;
        public double Amount;
        public DateTime Date;

        public string GetInfo()
        {
            return $"Product name {ProductName} - Amount {Amount} - Date {Date}";
        }
    }
}
