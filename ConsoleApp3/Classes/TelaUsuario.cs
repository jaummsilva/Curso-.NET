using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    class TelaUsuario
    {
        public static void Chamar()
        {


            Console.WriteLine("================== cadastro de Usuario ===================");

            while (true)
            {


                string mensagem =
                            "\nDigite uma das opçoes abaixo:" +
                            "\n" +
                            "\n0 -  Sair do cadastro" +
                            "\n1 -  Para cadastrar Usuarios:" +
                            "\n2 -  listar Usuarios";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var b = new Usuario();
                    Console.WriteLine("Digite o nome do Usuario");
                    b.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Usuario");
                    b.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Usuario");
                    b.CPF = Console.ReadLine();

                    b.Gravar();
                }
                else
                {
                  foreach (Usuario c in new Usuario().Ler())
                    {
                        Console.WriteLine("=================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " +  c.CPF);
                        Console.WriteLine("=================");
                    }
                }
            }
        }
    }
}
