using System;

namespace Curso.Curso
{
    class Variaveis_conversoes
    {
        public void Main(string[] args)
        {

            int i = 1; // Inteiro //
            string y = Convert.ToString(i); // Conversão de Inteiro para String


            char m = 'M'; // Char //
            string j = Convert.ToString(m); // Conversão de Char para String 

            float f = 1.5f; // Float //
            double f2 = Convert.ToDouble(f); // Conversão de Float para Double  

            double d = 1500.00; // Double //
            decimal d2 = Convert.ToDecimal(d); // Conversão de Double para Decimal

            bool b = true; // Boolean (False e True) 
            bool b3 = bool.Parse("False"); // String para Boolean, Com Parse
            string b2 = Convert.ToString(b); // Conversão de Boolean para String //  

            Console.WriteLine(y);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(m);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(f2);
            Console.WriteLine(d2);
        }
    }
}