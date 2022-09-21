using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resta
{
    class Resta
    {
        //atributos, caracterisiticas,campos 
        private double num1;
        private double num2;

        public Resta (double n1, double n2)
        {
           
            this.num1 = n1;
            this.num2 = n2;
        }
        public Resta (double n1)
        {
            this.num1 = n1;
        }
        //Metodo 
        public double sresta()
        {
            // regresar vaalores 
            return (num1 - num2);

        }
    }
    //aqui termina la clase division 
}
//aqui termina el espacio de nombre 

