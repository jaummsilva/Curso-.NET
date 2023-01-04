using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    class TelaCliente
    {
        public static void Chamar()
        {


            Console.WriteLine("================== cadastro de cliente ===================");

            while (true)
            {


                string mensagem =
                            "\nDigite uma das opçoes abaixo:" +
                            "\n" +
                            "\n0 -  Sair do cadastro" +
                            "\n1 -  Para cadastrar clientes:" +
                            "\n2 -  listar clientes";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var b = new Cliente();
                    Console.WriteLine("Digite o nome do Cliente");
                    b.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Cliente");
                    b.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Cliente");
                    b.CPF = Console.ReadLine();

                    b.Gravar();
                }
                else
                {
                  foreach (Cliente c in new Cliente().Ler())
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.CPF);
                        Console.WriteLine("=================");
                    }
                }
            }
        }
    }
}
