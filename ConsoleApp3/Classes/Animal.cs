using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3.Classes
{
    public abstract class Animal
    {
        public string Coleira;
        public string Pelo;
        public string Olhos;

        public abstract void Latir();

        public string Correr()
        {
            return "animal está correndo";
        }
    }
}
