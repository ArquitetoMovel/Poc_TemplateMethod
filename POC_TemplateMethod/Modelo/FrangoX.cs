using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_TemplateMethod.Modelo
{
    public class FrangoX : Receita
    {
        public override string ObterConteudoPrincipal()
        {
            return "Peito de Frango grelhado";
        }

        public override List<string> ObterComplementos()
        {
            var c = new List<string>
            {
                "Vinagrete",
                "Mostarda",
                "Pepino"
            };

            return c;
        }
    }
}
