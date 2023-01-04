using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    public class Cliente : Base
    { 
        public Cliente(string Nome)
        {
            this.Nome = Nome;
        }

        public Cliente(int Telefone)
        {
            this.Telefone = Telefone.ToString();
        }

        public Cliente(){}
    }
}
