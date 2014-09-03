using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_TemplateMethod.Modelo
{
    public class ChurrascoPlus : Receita
    {
        public override string ObterConteudoPrincipal()
        {
            return "Picanha+ ";
        }

        public override List<string> ObterComplementos()
        {
            var c = new List<string>
            {
                "Queijo",
                "Tomate",
                "Cebola"
            };

            return c;
        }
    }
}
