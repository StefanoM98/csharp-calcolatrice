using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {

        public static double SommaDueNumeri(double num1, double num2)
        {
            return num1 + num2;
        }


        public static double DifferenzaDueNumeri(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double MoltiplicaDueNumeri(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double ValoreAssoluto(double num1)
        {
            if (num1 < 0)
            {
                return num1 * -1;
            }
            else
            {
                return num1;
            }
        }

        public static double Minimo(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1; 
            } 
            else
            {
                return num2;
            }
        }

        public static double Massimo(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        //Bonus
        public static double Esponente(int numeroBase, int potenza)
        {
            
            return Math.Pow(numeroBase, potenza);
        }

    }
}
