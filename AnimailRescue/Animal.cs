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
        
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name=name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetHealth()
        {
            return this.health;
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public int GetHunger()
        {
            return this.hunger;
        }

        public void SetHunger(int age)
        {
            this.age = age;
        }

        public int GetHappiness()
        {
            return this.happiness;
        }

        public void SetHappiness(int happiness)
        {
            this.happiness = happiness;
        }

        public string GetFavoriteFood()
        {
            return this.favoriteFood;
        }

        public void SetFavoriteFood(string favoriteFood)
        {
            this.favoriteFood = favoriteFood;
        }

        public string GetFavoriteActivity()
        {
            return this.favoriteActivity;
        }

        public void SetFavoriteActivity(string favoriteActivity)
        {
            this.favoriteActivity = favoriteActivity;
        }
        


        public string toString()
        {
           return "Name: " + this.name + ", Age: " + this.age + ", Health: " + this.health + ", Hunger: " +
                this.hunger + ", Happiness: " + this.happiness + ", Favorite food: " +this.favoriteFood +
                ", Favorite Activity: " + this.favoriteActivity;
        }

    }
}
