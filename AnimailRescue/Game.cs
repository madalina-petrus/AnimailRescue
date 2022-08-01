using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal class Game
    {
        private Adopter adopter;
        private Animal animal;
        private Veterinarian veterinarian;

        public Game(Adopter adopter, Animal animal, Veterinarian veterinarian)
        {
            this.adopter = adopter;
            this.animal = animal;
            this.veterinarian = veterinarian;
        }

        public Adopter GetAdopter()
        {
            return this.adopter;
        }

        public void SetAdopter(Adopter adopter)
        {
            this.adopter = adopter;
        }

        public Animal GetAnimal()
        {
            return this.animal;
        }

        public void SetAnimal(Animal animal)
        {
            this.animal = animal;
        }

        public Veterinarian Getveterinarian()
        {
            return this.veterinarian;
        }

        public void SetVeterinarian(Veterinarian veterinarian)
        {
            this.veterinarian = veterinarian;
        }

        public string toString()
        {
           return "Adopter: "+ "Name: " + this.adopter.GetName() + ", Money: " + 
                this.adopter.GetMoney() + 
                " \nAnimal: " + "Name: " + this.animal.GetName() + ", Age: " + this.animal.GetAge() +
                ", Health: " + this.animal.GetHealth() + ", Hunger: " +
                this.animal.GetHunger() + ", Happiness: " + this.animal.GetHappiness() + ", Favorite food: " 
                + this.animal.GetFavoriteFood() +
                ", Favorite Activity: " + this.animal.GetFavoriteActivity() +
            "\nVeterinarian: " + "Name: " + this.veterinarian.GetName() + ", Specialization: " + 
                this.veterinarian.GetSpecialization(); 
        }
    }
}
