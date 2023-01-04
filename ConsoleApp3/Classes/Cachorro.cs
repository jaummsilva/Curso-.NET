using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    
   public class Cachorro : Animal
   {

        public int Idade;

        private int idadePreDefinida = 2;

        public int idade2 { 
            get
            {
                return idadePreDefinida;
            }
            set
            {
                idadePreDefinida = value;
            }
        }
        public override void Latir()
        {
                Console.WriteLine("Au eu sou um cachorro");
        }
   }
}
