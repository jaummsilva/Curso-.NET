using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Curso
{
    class funcoes
    {
        public  void Main(string[] args)
        {
            CalcularInt();
            CalcularVoid();
            Tabuada();
            
        }
        public static int CalcularInt() // Função int necessita de um "return" -
                                        // obs: não mostra na tela (Console)  
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = a + b + c;
            return d;
        }
        public static void CalcularVoid() // Função void não necessita de um "return" -
                                          // obs:  consigo mostrar o valor da outra função criada
        {
            Console.WriteLine(CalcularInt());
        }

        public static void Tabuada() // Função criada sem repetir o codigo só chamando na Main
                                               // com o valor que quiser
        {
            Console.WriteLine("Escolha o numero da tabuada");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }


    }
}
