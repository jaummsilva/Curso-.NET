using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    public class Cliente
    {
        public static void Main(string[] args)
        {

            var clientes = LerClientes();

        }

        public string Nome;
        public string Telefone;
        public string CPF;

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["base_clientes"];
        }

        public void Gravar()
        {
            // forget //
        }
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(caminhoBaseClientes())) // Verificando se existe a variavel acima (diretório do arquivo no pc) //
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null) // Looping lendo cada linha do arquivo //
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente();
                        cliente.Nome = clienteArquivo[0];
                        cliente.Telefone = clienteArquivo[1];
                        cliente.CPF = clienteArquivo[2];

                        clientes.Add(cliente);
                    }
                }
            }
                return clientes;

            }
        }
    }
