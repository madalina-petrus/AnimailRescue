using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal class AnimalFood
    {
        private string name;
        private float price;
        private int quantity;
        private DateOnly expirationDate;
        private int inStock;

        public AnimalFood(string name, float price, int quantity, DateOnly expirationDate, int inStock)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
            this.inStock = inStock;
        }
    }
}
