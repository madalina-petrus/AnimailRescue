using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    
    internal class Dog : Animal
    {
        private string favoriteHuman;

        public Dog(string name, int age, int health, int hunger, int happiness, string favoriteFood, string favoriteActivity, string favoriteHuman) : base(name, age, health, hunger, happiness, favoriteFood, favoriteActivity)
        {
            this.favoriteHuman= favoriteHuman;
        }

  
        public string GetFavoriteHuman()
        {
            return this.favoriteHuman;
        }
        public void SetFavoriteHuman(string favoriteHuman)
        {
            this.favoriteHuman = favoriteHuman;
        }

        public override string speak()
        {
            return "HamHam";
        }
        public string toString()
        {
            return base.toString() + " ,FavoriteHuman: "+this.favoriteHuman;
        }
           
    }
}
