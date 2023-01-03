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

        while(true) {


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
                    var cliente = new Cliente();
                    Console.WriteLine("Digite o nome do Cliente");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Cliente");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Cliente");
                    cliente.CPF = Console.ReadLine();

                    cliente.Gravar();
                }
                else 
                {
                    var verClientes = Cliente.LerClientes();

                    foreach (Cliente c in verClientes)
                    {
                        Console.WriteLine(c.Nome);
                    }
                }


                var clientes = Cliente.LerClientes();

                foreach(Cliente c in clientes){
                Console.WriteLine(c.Nome);}
            }
        }
    }
}
