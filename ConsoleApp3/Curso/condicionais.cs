using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Curso
{
    class Condicionais
    {
        public void Main(string[] args)
        {

            CondicionalCase();
            CondicionalIf();

        }
        public static void CondicionalCase()
        {
            var b = 3;
            switch (b)
            {
                case 1:
                    Console.WriteLine("Case1");
                    break;
                case 2:
                    Console.WriteLine("Case2");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
        public static void CondicionalIf()
        {
            // IF (se) , ELSE ( se não), ELSE IF (se não se) // 

            var a = 2;
            if (a == 1)
            {
                Console.WriteLine("entrou na condição if");
            }
            else if (a == 2)
            {
                Console.WriteLine("Caiu na condição a == 2");
            }
            else
            {
                Console.WriteLine("Caiu em nenhum dos blocos acima");
            }
            Console.Read();

        }

    }
}

