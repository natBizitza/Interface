using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico medico1 = new Medico("1111", "JULIA", 40000, 41, "J",  5);
            List<Sanitario> sanitario = new List<Sanitario>()
            {
                medico1
            };

            //TODO: change it ...
            Sanitario.CalculaSueldo(medico1);
            //get
            //Dni1.Dni;
            //set
            //Dni1 = q111i;
            Console.ReadLine();
        }
    }
}
