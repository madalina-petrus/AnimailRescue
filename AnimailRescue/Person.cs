using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal abstract class Person
    {
        protected string name;
        protected int age;
        protected float height;
        protected string hairColor;

        protected Person(string name, int age, float height, string hairColor)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.hairColor = hairColor;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public float GetHeight()
        {
            return this.height;
        }

        public void SetHeight(float height)
        {
            this.height = height;
        }

        public string GetHairColor()
        {
            return this.hairColor;
        }

        public void SetHairColor(string hairColor)
        {
            this.hairColor = hairColor;
        }
    }
}
