using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Program();
            data.metodoPrivado();

        }

        private void metodoPrivado()
        {
            Console.WriteLine("Hola");
            Console.ReadLine();
        }
    }
}
