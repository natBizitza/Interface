using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Medico : Sanitario, IPersonalLaboral
    {
        public string Especialidad { get; set; }
        public int NumeroPacientes { get; set; }

        //constructor
        public Medico(string Dni, string Nombre, double SueldoBase, int Edad, string Especialidad, int NumeroPacientes) : base (Dni, Nombre, SueldoBase, Edad)
        {
            //this.Dni =Dni;
            //this.Nombre = Nombre;
            //this.SueldoBase = SueldoBase;
            //this.Edad = Edad;
            this.Especialidad = Especialidad;
            this.NumeroPacientes = NumeroPacientes;
        }

        //Get &Set

        //other methods


        public override string Mostrar()
        {
            string result = "";

            if (this.Especialidad != "")
            {
                result += "Especialidad " + this.Especialidad + " ";

            }
            if(this.NumeroPacientes > -1)
            {
                result += "Numero Pacientes " + this.NumeroPacientes + " ";

            }
            return base.Mostrar() + result;
        }

        public override double CalculaSueldo()
        {
            double mas = this.NumeroPacientes*1.20;
            return base.CalculaSueldo() + mas;
        }
    }
}
