using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holamundo
{
    class holaMundo
    {
        public void Mostrar()
        {
            Console.WriteLine("Hola Mundo");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            holaMundo HW = new holaMundo();
            HW.Mostrar();
            Console.ReadKey();           

        }
    }
}
