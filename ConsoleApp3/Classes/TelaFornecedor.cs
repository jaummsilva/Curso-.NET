using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {


            Console.WriteLine("================== cadastro de Fornecedor ===================");

            while (true)
            {


                string mensagem =
                            "\nDigite uma das opçoes abaixo:" +
                            "\n" +
                            "\n0 -  Sair do cadastro" +
                            "\n1 -  Para cadastrar Fornecedores:" +
                            "\n2 -  listar Fornecedores";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var b = new Fornecedor();
                    Console.WriteLine("Digite o nome do Fornecedor");
                    b.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o CNPJ do Fornecedor");
                    b.CNPJ = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Fornecedor");
                    b.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do gerente");
                    b.CPF = Console.ReadLine();

                    b.Gravar();
                }
                else
                {
                  foreach (Fornecedor c in new Fornecedor().Ler())
                    {
                        Console.WriteLine("=================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("CNPJ: " + c.CNPJ);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " +  c.CPF);
                        Console.WriteLine("=================");
                    }
                }
            }
        }
    }
}
