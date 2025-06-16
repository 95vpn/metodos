using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {

        private String cadena;
        private String verMayusculas = "";
        private String verMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMy;
        private string[] tempMn;


        private String mayusculas()
        {
            for (int i = 0; i < n; i++)
            {
                if (char.IsUpper(cadena[i]))
                {

                }
            }
        }

        static void Main(string[] args)
        {
            var data = new Program();
            //data.metodoPrivado();
            Console.WriteLine(data.metodoPrivado());
            Console.ReadLine();
            //data.metodoPublico();
        }

        /*
        private string metodoPrivado()
        {
            return $"Alex Joel {25}";
        }
        */

        /*
        private int metodoPrivado()
        {
            return Convert.ToInt16("562");
        }
        */

        /*
        public void metodoPublico()
        {
            Console.WriteLine("Alex");
            Console.ReadLine();
        }
        */
    }
}
