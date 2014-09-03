using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_TemplateMethod.Modelo
{
    public abstract class Receita
    {

        public abstract string ObterConteudoPrincipal();

        public abstract List<string> ObterComplementos();

        public string Preparar()
        {
            var preparo = new StringBuilder();
            var lancheNm = this.GetType().Name;
            preparo.AppendFormat("Preparando o {0} \n", lancheNm);
            preparo.AppendFormat("Colocando fatias de Pão na chapa \n");
            preparo.AppendFormat("Adicionando {0} como conteúdo principal \n", ObterConteudoPrincipal());
            ObterComplementos().ForEach(complemento =>
            {
                preparo.AppendFormat("Adicionando complemento {0}  \n", complemento);
            });
            preparo.AppendFormat("Colocando a ultima fatia de pão ao lanche {0} \n", lancheNm);
            var lanche = preparo.ToString();
            preparo = null;

            return lanche;
        }
    }
}
