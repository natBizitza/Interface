using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sanitario : IPersonalLaboral
    {
        //declare attr(private) and methods(public)
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public double SueldoBase { get; set; }
        public int Edad { get; set; }
        ////prop tab*2
        //public int MyProperty { get; set; }

        public Sanitario(string Dni, string Nombre, double SueldoBase, int Edad) 
        {
            this.Dni = Dni;
            this.Nombre = Nombre;
            this.SueldoBase = SueldoBase;
            this.Edad = Edad;
        }

        //Get & Set

       

        //other methods

        public bool Jubilable()
        {
            if (this.Edad >= 65 )
            {
                Console.WriteLine("This person is retired");
                return true;
            }
            Console.WriteLine("This person is not retired");
            return false;
        }

        public virtual string Mostrar()
        {
            string result = "";

            if (this.Dni != "")
            {
                result += "Dni " + this.Dni + " ";

            }
            if (this.Nombre != "")
            {
                result += "NOMBRE " + this.Nombre + " ";
            }
            if (this.SueldoBase > 0)
            {
                result += "SUELDO BASE " + this.SueldoBase + " ";
            }
            if (this.Edad> 0)
            {
                result += "EDAD " + this.Edad + " ";
            }
            return result;
        }

        public virtual double CalculaSueldo()
        {
            return this.SueldoBase;
        }
    }
}
