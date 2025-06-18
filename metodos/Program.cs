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

        public Program(String cadena) 
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new String[n];
            Minusculas = new String[n];
            tempMy = new String[n];
            tempMn = new String[n];
        }


        private String mayusculas()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(cadena[i]))
                {
                    tempMy[i] = Convert.ToString(cadena[i]); 
                }
            }

            for (int i = 0; i < tempMy.Length; i++)
            {
                if (tempMy[i] != null)
                {
                    Mayusculas[i] = tempMy[i];
                    verMayusculas = $"{verMayusculas},{Mayusculas[i]}"  ;
                }
            }
            return verMayusculas;
        }

        public String minusculas()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsLower(cadena[i]))
                {
                    tempMn[i] = Convert.ToString(cadena[i]);
                }
            }

            for (int i = 0; i < tempMn.Length; i++)
            {
                if (tempMn[i] != null)
                {
                    Minusculas[i] = tempMn[i];
                    verMinusculas = $"{verMinusculas},{Mayusculas[i]}";
                }
            }
            return verMinusculas; 
        }

        static void Main(string[] args)
        {
            var cadena = Console.ReadLine();
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
