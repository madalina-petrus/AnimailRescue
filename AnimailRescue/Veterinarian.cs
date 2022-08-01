using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimailRescue
{
    internal class Veterinarian
    {
        private string name;
        private string specialization;

        public Veterinarian(string name, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetSpecialization()
        {
            return this.specialization;
        }

        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }


        public string toString()
        {
            return "Name: " + this.name + ", Specialization: " + this.specialization;
        }
    }
}
