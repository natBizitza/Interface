using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enfermo : Sanitario, IPersonalLaboral
    {
        public int Puesto { get; set; }

        //construtor 
        public Enfermo()
        {

        }

        //Get & Set()

        //other methods

        public double CalculaSueldo()
        {
            return;
        }

        public void Mostrar()
        {

        }
    }
}
