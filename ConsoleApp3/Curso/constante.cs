using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Curso
{
    class constante
    {
        public void Main(string[] args)
        {
            // SAIDA_PROGRAMA = 2 (erro) // 
            while (true) // enquanto verdadeiro // 
            {
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do programa");
                int valor = int.Parse(Console.ReadLine()); // Pegando o que é digitado no console e transformando com Parse
                                                           // em inteiro 


                if (SAIDA_PROGRAMA == valor) // O programa só acaba se o que for digitado no console ser 1 //
                {
                    break;
                }
            }

        }
        public const int SAIDA_PROGRAMA = 0; // Função com constante, o numero ou qualquer valor não poderá
                                             // ser alterado, caso alterado irá dar erro.
                                             // ex:colocar outro valor pra SAIDA_PROGRAMA = 2 (declarado na função main)
                                             // vai ocorrer um erro
    }
}


// Padrão de nome Constante , Letras maiusculas separadas com _ . Ex: CASA_COR_VERDE //
