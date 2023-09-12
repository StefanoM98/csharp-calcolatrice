namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nella calcolatrice pazza");

            int num1 = 3;
            int num2 = 8;

            double numd1 = 3.73924;
            double numd2 = 5.39;




            //Somma
            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.SommaDueNumeri(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.WriteLine(CalcoliHelper.SommaDueNumeri(numd1, numd2));


            //Differenza
            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.DifferenzaDueNumeri(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.DifferenzaDueNumeri(numd1, numd2));

            //Moltiplicazione
            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.MoltiplicaDueNumeri(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.MoltiplicaDueNumeri(numd1, numd2));

            //Valore Assoluto

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.ValoreAssoluto(num1));

            Console.WriteLine();

            Console.Write("Il risultato è: ");

            Console.Write(CalcoliHelper.ValoreAssoluto(numd1));

            Console.WriteLine();

            //Valore Minimo

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Minimo(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Minimo(numd1, numd2));

            //Valore Massimo

            Console.WriteLine();

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Massimo(num1, num2));

            Console.WriteLine();

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Massimo(numd1, numd2));

            Console.WriteLine();

            //BONUS

            Console.WriteLine("Bonus");

            Console.Write("Il risultato è: ");
            Console.Write(CalcoliHelper.Esponente(num1, num2));
        }

    }
}
