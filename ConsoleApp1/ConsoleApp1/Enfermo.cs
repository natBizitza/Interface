using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Enfermo : Sanitario, IPersonalLaboral
    {
        public int Puesto { get; set; }

        //construtor 
        public Enfermo(string dni, string nombre, double sueldoBase, int edad): base (dni, nombre, sueldoBase, edad)
        {

        }

        //Get & Set()

        //other methods

        public override double CalculaSueldo()
        {
            int mas = 200;
            return base.CalculaSueldo() + mas;
        }

        public override string Mostrar()
        {
            string result = "";

            if (this.Puesto > 0)
            {
                result += "Puesto " + this.Puesto + " ";

            }

            return base.Mostrar() + result;

        }
    }
}
