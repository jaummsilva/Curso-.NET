using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    public class Fornecedor : Base
    {
        public string CNPJ;
        public Fornecedor(string nome, string telefone, string cpf, string cnpj)
        {

            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.CNPJ = cnpj;
        }
        public Fornecedor(){ }

        private string diretorio()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"] + this.GetType().Name + ".txt";
        }

        public override List<IPessoa> Ler()
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
                        var b = (Fornecedor)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCPF(baseArquivo[2]);
                        b.CNPJ = baseArquivo[3];
                        dados.Add(b);
                    }
                }
            }
            return dados;

        }

        public override void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);
            if (File.Exists(diretorio()))
            {
                string conteudo = "Nome;Telefone;CPF;CNPJ;\n";
                foreach (Fornecedor b in dados)
                {
                    conteudo += b.Nome + ";" + b.Telefone + ";" + b.CPF + ";" + b.CNPJ + ";\n";
                }

                File.WriteAllText(diretorio(), conteudo);
            }
        }
    }
}
