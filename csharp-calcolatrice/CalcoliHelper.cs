using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {


        public static int SommaDueNumeri(int num1, int num2)
        {
            return num1 + num2;
        }


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
        public static int Esponente(int numeroBase, int potenza)
        {
            // SPECIAL CASES:
            // 0 ^ 1 = 0
            // 0 ^ 0 = 1
            // 0 ^ n = 0
            // n ^ 0 = 1;
            // n ^ (-n) = 1 / (n^n)

            //return Math.Pow(numeroBase, potenza);

            //numeroBase *= numeroBase;

            int accumulatore = 1;

            for(int i = 0; i < potenza; i++)
            {
                accumulatore *= numeroBase;
            }

            if (potenza < 0)
            {
                return 1 / accumulatore; 
            }

            return accumulatore;
        }

    }
}
