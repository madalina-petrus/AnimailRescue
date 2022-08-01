using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal class Animal
    {
        private string name;
        private int age;
        private int health;
        private int hunger;
        private int happiness;
        private string favoriteFood;
        private string favoriteActivity;

        public Animal(string name, int age, int health, int hunger, int happiness, string favoriteFood, string favoriteActivity)
        {
            this.name = name;
            this.age = age;
            this.health = health;
            this.hunger = hunger;
            this.happiness = happiness;
            this.favoriteFood = favoriteFood;
            this.favoriteActivity = favoriteActivity;
        }

       
    }
}
