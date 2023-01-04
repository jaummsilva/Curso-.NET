using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compentess
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este método só pode ser acessado dentro deste assembly componentess";
        }
        public string MetodoParaTodosQueUtilizarMeuAssembly()
        {
            
            return "Este método é para todos";
        }
    }
}
