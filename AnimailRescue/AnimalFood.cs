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


        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public void SetMoney(float price)
        {
            this.price = price;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public DateOnly GetExpirationDate()
        {
            return this.expirationDate;
        }

        public void SetExpirationDate(DateOnly expirationDate)
        {
            this.expirationDate = expirationDate;
        }

        public string toString()
        {
            return "Name: " + this.name + ", Price: " + this.price + ", Quantity: " + this.quantity +
                ", Expiration Date: " + this.expirationDate + ", In Stock: " + this.inStock ;
        }

    }
}
