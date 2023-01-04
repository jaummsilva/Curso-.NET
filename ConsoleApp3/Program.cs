using ConsoleApp3.Classes;
using Curso.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Email.Instancia.Corpo = "bla bla bla";
            Email.Instancia.Titulo = "Titulo do Email";
            Email.Instancia.Destino = "Destinodo@Email.com";
            Email.Instancia.Origin = "Origindo@Email.com";

            Email.Instancia.EnviarEmail();
            

            ProgOrientadaFuncao.FunçaoOrientada();                 
        }
    }
}
