using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    public class Base : IPessoa
    {
        public Base(string nome, string telefone, string cpf)
        {

            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Base()
        { }




        public string Nome;
        public string Telefone;
        public string CPF;

        public  void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public void SetTelefone(string telefone)
        {
            this.Telefone= telefone;
        }
        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorio())) // Verificando se existe a variavel acima (diretório do arquivo no pc) //
            {
                using (StreamReader arquivo = File.OpenText(diretorio()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null) // Looping lendo cada linha do arquivo //
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');
                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCPF(baseArquivo[2]);
                        dados.Add(b);
                    }
                }
            }
            return dados;

        }

        private string diretorio()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"] + this.GetType().Name + ".txt";
        }

        public virtual void Gravar()
        {

            var dados = this.Ler();
            dados.Add(this);
            if (File.Exists(diretorio()))
            {
                string conteudo = "Nome;Telefone;CPF;\n";
                foreach (Base b in dados)
                {
                    conteudo += b.Nome + ";" + b.Telefone + ";" + b.CPF + ";\n";
                }

                File.WriteAllText(diretorio(), conteudo);
            }
                
        }
    }
}
