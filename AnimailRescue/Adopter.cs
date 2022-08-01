using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal class Adopter
    {
        private string name;
        private float money;

        public Adopter(string name, float money)
        {
            this.name = name;
            this.money = money;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public float GetMoney()
        {
            return this.money;
        }

        public void SetMoney(int money)
        {
            this.money = money;
        }

        public string toString()
        {
            return "Name: " + this.name + ", Money: " + this.money;
        }
    }
}
