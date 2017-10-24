using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = MatematicaOperacao.Soma.OpSoma(1, 2);
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
