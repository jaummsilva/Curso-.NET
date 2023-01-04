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

            ProgOrientadaFuncao.FunçaoOrientada();                 
        }
        partial class Animal
        {
            public string teste;
            partial void tt();
        }
        partial class Animal
        {
            public string teste2;
            partial void tt()
            {
                Console.WriteLine("teste");
            }
        }


    }
}
