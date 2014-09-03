using POC_TemplateMethod.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            // Preparancdo o churrasco Plus
            Receita lancheDeChurrasco = new ChurrascoPlus();

            Console.Write(lancheDeChurrasco.Preparar()+"\n");

            Console.WriteLine("====================================================================\n");
            //Console.Read();

            // Preparancdo o churrasco Plus
            Receita lancheDeFrango = new FrangoX();

            Console.Write(lancheDeFrango.Preparar());

            Console.Read();
        }
    }
}
