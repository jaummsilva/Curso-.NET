using ConsoleApp3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Curso
{
    class ProgOrientadaFuncao
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDORES = 6;


        // Função utilizando 3 funções criadas anteriormente em outros arquivos //
        public static void FunçaoOrientada()
        {
            while (true)
            {
                string mensagem = "Olá usuario, bem vindo ao programa\n" +
                    "\n   Aplicação Console final" +
                    "\n" +
                    "\nDigite uma das opçoes abaixo:" +
                    "\n" +
                    "\n0 -  Sair do programa" +
                    "\n1 -  Para ler arquivos:" +
                    "\n2 -  Para executar a tabuada" +
                    "\n3 -  Calcular média de alunos" +
                    "\n4 -  Cadastrar clientes" + 
                    "\n5 -  Cadastrar usuarios" +
                    "\n6 -  Cadastrar fornecedores";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("====================== opção Ler Arquivos ================");
                    funçoes_Recursivas.LerArquivo(1);
                    Console.WriteLine("======================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("====================== opçao tabuada ================");
                    funcoes.Tabuada();
                    Console.WriteLine("======================================");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    CalcularMediaAluno();
                    Console.WriteLine("======================================");
                }
                else if  (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("======================================");
                }
                else if (valor == CADASTRAR_USUARIOS)
                {
                    TelaUsuario.Chamar();
                    Console.WriteLine("======================================");
                }
                else if (valor == CADASTRAR_FORNECEDORES)
                {
                    TelaFornecedor.Chamar();
                    Console.WriteLine("======================================");
                }
                else
                {
                    Console.WriteLine("Opção invalida, digite novamente");
                    Console.WriteLine("======================================");
                }

            }
        }
        private static void CalcularMediaAluno()
        {
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);

            List<int> notas = new List<int>();
            int totalNotas = 0;

            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + " é " + media);
            Console.WriteLine("========================= \n");
            Console.WriteLine("Suas notas são\n");

            foreach (int nota in notas)
            {
                Console.WriteLine("Nota do aluno " + nome + ":" + "\n" + nota);
            }
        }
    }

}
