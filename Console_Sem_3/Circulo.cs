using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sem_3
{
    internal class Circulo : Punto //En este es: "Circulo herede de Punto
    {
        public Circulo(double radiux) {
            this.radio = radiux;
        }

        public override void imprimir() {  //Acá esta como SOBRE ESCRITO 
            Console.WriteLine("Soy un circulo"); //Está solo en las hijas 
        }                                       //OVERRIDE siempre va ir con VIRTUAL 

    }
}
