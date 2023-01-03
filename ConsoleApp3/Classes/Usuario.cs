using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    public class Usuario : Cliente
    {
        public Usuario(string nome, string telefone, string cpf)
        {

            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Usuario()
        { }
        private static string caminhoBaseUsuarios()
        {
            return ConfigurationManager.AppSettings["base_usuarios"];
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
        public override void Gravar()
        {
            var usuario = Usuario.LerUsuarios();
            Usuario u = new Usuario(this.Nome, this.Telefone, this.CPF);
            usuario.Add(u);
            if (File.Exists(caminhoBaseUsuarios()))
            {
                string conteudo = "Nome;Telefone;CPF;\n";
                foreach (Usuario c in usuario)
                {
                    conteudo += c.Nome + ";" + c.Telefone + ";" + c.CPF + ";\n";
                }

                File.WriteAllText(caminhoBaseUsuarios(), conteudo);
            };
        }
    }
}
