using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sanitario
    {
        //declare attr(private) and methods(public)
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public double SueldoBase { get; set; }
        int Edad { get; set; }
        ////prop tab*2
        //public int MyProperty { get; set; }

        public Sanitario(string dni, string nombre, double sueldoBase, int edad)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.SueldoBase = sueldoBase;
            this.Edad = edad;
        }

        //Get & Set

       

        //other methods

        public bool Jubilable()
        {
            return true;
        }

        public void Mostrar()
        {

        }
        
    }
}
