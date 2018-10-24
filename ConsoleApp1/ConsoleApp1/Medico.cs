using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Medico : Sanitario, IPersonalLaboral
    {
        public string Especialidad { get; set; }
        public int NumeroPacientes { get; set; }

        //constructor
        public Medico()
        {

        }

        //Get &Set

        //other methods

        public double CalculoSueldo()
        {
            return; 
        }

        public void Mostrar()
        {

        }
         

    }
}
