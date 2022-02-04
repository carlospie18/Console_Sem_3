using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sem_3
{
    internal class Punto : Figura   //Lo que quiere decir es: Punto implementa a Figura
    {
        //internal: puede ser accedido por cualquier clase del namespace
        //readonly: solamente permite tener un get 
        //internal protected: una relación de herencia dentro del namespace
        //private protected: cualquier herencia dentro del mismo esamblado

        private int x;
        private int y;
        protected double radio;

        public const double pi = 3.14; //No se puede cambiar
        static public string nombre;

        public Punto() { //un constructo siempre va ir público
            this.radio = 0;
         }

        public double Area()
        {
            return 0;
        }

        public double Volumen()
        {
            return 0;
        }

        public virtual void imprimir() { //Un método virtual o tanmbién abstract es que no existe en la implementación
                            //Lo que se debe hacer es SOBRE ESCRIBIR ======= VIRTUAL si puede ir solo 
            Console.WriteLine("Soy un punto");
        }
    }
}
