using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sem_3
{
    internal class Program{
        static void Main(string[] args)
        {
            iniciar();
        }

        static void iniciar(){

            Console.WriteLine("Semana 3 POO");
            Console.WriteLine("Ingrese un radio:");

            double radio; // Es lo que el usuario va a ingresar

            radio = Convert.ToDouble(Console.ReadLine());

            polimorfismo(radio);

        }

        static void polimorfismo(double radio){//Es la posibilidad de definir múltiples clases con
            //funcionalidad diferente pero con métodos denominados de forma idéntica            

            if (radio == 0){
                Punto point = new Punto();
                point.imprimir();
            }
            else
            {
                if (radio > 0){
                    Punto circle = new Circulo(radio);
                    circle.imprimir();
                }
            }
            Console.ReadLine();

            
        }
    }
}
