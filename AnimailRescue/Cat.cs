using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal class Cat:Animal
    {

        private string theHatedPerson;

        public Cat(string name, int age, int health, int hunger, int happiness, string favoriteFood, string favoriteActivity, string theHatedPerson) : base(name, age, health, hunger, happiness, favoriteFood, favoriteActivity)
        {
            this.theHatedPerson = theHatedPerson;
        }

        public string GetTheHatedPerson()
        {
            return this.theHatedPerson;
        }
        public void SetTheHatedPerson(string theHatedPerson)
        {
            this.theHatedPerson = theHatedPerson;
        }

        public string meow()
        {
            return "MiauMiau";
        }
        public string toString()
        {
            return base.toString() + " ,TheHatedPerson: " + this.theHatedPerson;
        }

    }
}
