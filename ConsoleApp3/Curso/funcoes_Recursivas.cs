using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Curso
{
    class funçoes_Recursivas
    {
        public void Main(string[] args)
        {
            LerArquivo(1);
        }

        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }

        // Função recursiva que lê um arquivo //
        public static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt"; // Variavel = Diretório + numero que está na função acima //
            Console.WriteLine("========= Lendo o arquivo: ========" + "\n" + arquivoComCaminho + "\n" + "===========");
            if (File.Exists(arquivoComCaminho)) // Verificando se existe a variavel acima (diretório do arquivo no pc) //
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null) // Looping lendo cada linha do arquivo //
                    {
                        Console.WriteLine(linha);
                    }
                }
                Console.WriteLine("============");
                string arquivoComCaminho2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
                if (File.Exists(arquivoComCaminho2)) // Esse if faz com que não precise repetir a mesma função novamente //
                {
                    LerArquivo(numeroArquivo + 1);
                }
            }
        }

    }
}

