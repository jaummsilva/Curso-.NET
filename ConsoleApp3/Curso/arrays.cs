using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Curso
{
    class Array_Collections
    {
        public void Main(string[] args)
        {
            ArrayString();
            CollectionString();
        }
        public static void ArrayString()
        {
            string[] cars = { "volvo", "chevrolet", "fiat" };
            Console.WriteLine(cars[0]); // Posição 0 = Primeiro elemento do array //
            Console.WriteLine(cars.Length); // Length = Quantidade de elementos do array // 
            Array.Sort(cars); // ordena o array por ordem alfabética //

            if (Array.Exists(cars, e => e == "volvo")) // Verificando se exite volvo no Array //
            {
                Console.WriteLine("Existe volvo no array");
            }

            foreach (string i in cars) // mostrando cada valor de cars por ordem alfabética // 
            {
                Console.WriteLine(i);
            }
        }
        public static void CollectionString()
        {
            List<string> a = new List<string>(); // Crie um Collection //
            a.Add("Nissan"); // Adiciona Nissan a Collection // 
            a.Add("Toyota"); // "" // 
            a.Add("Jeep");   // "" //
            a.Add("Kia");

            foreach (string b in a) // Percorrendo cada valor de a //  
            {
                Console.WriteLine(b); // Mostrando os valores de a //
            }

            if (a.Exists(e => e == "Chevrolet")) // Verificando se existe o nome nissan no Collection // 
            {
                Console.WriteLine("Encontrei o nome Chevrolet no Collection");
            }
            else
            {
                Console.WriteLine("Não Encontrei o Chevrolet");
            }
        }

    }
}

