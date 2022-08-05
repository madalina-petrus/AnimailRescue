using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal class Girl: Person
    {
        protected bool animalLover;
        protected Animal pet;

        public Girl(string name, int age, float height, string hairColor, bool animalLover) : base(name, age, height, hairColor)
        {
            this.animalLover = animalLover;
        }
        public Girl(string name, int age, float height, string hairColor,bool animalLover, Animal pet) : base(name, age, height, hairColor)
        {
            this.animalLover = animalLover;
            this.pet = pet;
        }

        public bool GetAnimalLover()
        {
            return this.animalLover;
        }

        public void SetAnimalLover(bool AnimalLover)
        {
            this.animalLover = animalLover;
        }


        public Animal  GetPet()
        {
            return this.pet;
        }

        public void SetPet(Animal Pet)
        {
            this.pet = pet;
        }
    }
}
