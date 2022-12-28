using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Curso
{
     class looping
    {

        public void Main(string[] args)
        {
            LoopingWhile();
            LoopingFor();
            LoopingForEach();
        }

        // Variavel i é igual a 1, enquanto i for menor que 5, mostra o console e adiciona i + 1,
        // repete o processo até o i ser 4 // 
        public static void LoopingWhile()
        {
            var i = 1;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // Dentro do próprio for, crio a variavel e dou um valor a ela, nesse exemplo o (int a = 0),
        // dou a condição ( a < 3) e o incremento ( a++), no console ira mostrar [0,1,2] // 
        public static void LoopingFor()
        {
            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine(a);
            }
        }

        // informo um array com os valores que quiser, no exemplo o (f), dentro do foreach, crie outra variavel (v),
        // o v irá percorrer todos os valores de f, um por um até acabar, por fim ira mostrar cada um no console //
        public static void LoopingForEach()
        {

            int[] f = { 1, 2, 3 };
            foreach (int v in f)
            {
                Console.WriteLine(v);
            }
        }

    }
}

