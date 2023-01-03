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
        public void Main(string[] args)
        {
            TelaCliente.Chamar();

            var clientes = LerClientes();

            var cliente = new Cliente();
            cliente.Nome = "Nathan";
            cliente.Telefone = "9414194901941";
            cliente.CPF = "9414194901941";

            foreach(Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
            }

            
        }

        public Cliente(string Nome) {
            this.Nome = Nome;
        }

        public Cliente(int Telefone)
        {
            this.Telefone = Telefone.ToString();
        }

        public Cliente()
        {

        }


        public string Nome;
        public string Telefone;
        public string CPF;

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["base_clientes"];
        }
        private static string caminhoBaseUsuarios()
        {
            return ConfigurationManager.AppSettings["base_usuarios"];
        }

        public void Gravar()
        {
            if(this.GetType() == typeof(Cliente))
            {
                var clientes = LerClientes();
                clientes.Add(this);
                if (File.Exists(caminhoBaseClientes()))
                {
                    string conteudo = "Nome;Telefone;CPF;\n";
                    foreach (Cliente c in clientes)
                    {
                        conteudo += c.Nome + ";" + c.Telefone + ";" + c.CPF + ";\n";
                    }

                    File.WriteAllText(caminhoBaseClientes(), conteudo);
                };

            }
            else
            {
                var usuario  = Usuario.LerUsuarios();
                Usuario u = new Usuario(this.Nome, this.Telefone, this.CPF);
                usuario.Add(u);
                if (File.Exists(caminhoBaseUsuarios()))
                {
                    string conteudo = "Nome;Telefone;CPF;\n";
                    foreach (Usuario c in usuario)
                    {
                        conteudo += c.Nome + ";" + c.Telefone + ";" + c.CPF + ";\n";
                    }

                    File.WriteAllText(caminhoBaseClientes(), conteudo);
                };
            }
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

                        var cliente = new Cliente {
                            Nome = clienteArquivo[0], 
                            Telefone = clienteArquivo[1], 
                            CPF = clienteArquivo[2] };

                        clientes.Add(cliente);
                    }
                }
            }
                return clientes;

            }
        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>();
            if (File.Exists(caminhoBaseUsuarios())) // Verificando se existe a variavel acima (diretório do arquivo no pc) //
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseUsuarios()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null) // Looping lendo cada linha do arquivo //
                    {
                        i++;
                        if (i == 1) continue;
                        var usuarioArquivo = linha.Split(';');

                        var usuario = new Usuario
                        {
                            Nome = usuarioArquivo[0],
                            Telefone = usuarioArquivo[1],
                            CPF = usuarioArquivo[2]
                        };
                         
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }
    }
