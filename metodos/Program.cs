using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {
        /*
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
        */

        /*
        public Program()
        {

        }

        public Program(String name)
        {

        }

        public Program(String name, int age)
        {

        }

        public Program(int age, String name )
        {

        }

        

        static void Main(string[] args)
        {
            var cadena = Console.ReadLine();
            var data = new Program(52, "Alex" );
            new Program("Alex", 52);
            new Program("Alex");
            //Console.WriteLine("Las letras Mayusculas son: " + data.mayusculas() + "\n\n" + 
            // "Las letras minusculas son : " + data.minusculas());
            //data.metodoPrivado();
            //Console.WriteLine(data.metodoPrivado());
            Console.ReadLine();
            //data.metodoPublico();
        }
        */
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

        /*
        static void Main(string[] args) 
        {
            Object[] parametros = { "Alex", 25, true };
            new Program().metodo(parametros);
            Console.ReadLine();
        }

        private void metodo(object[] parametros)
        {
            var nommbre = parametros[0];
            String nombre = (string)parametros[0];
            int edad = (int)parametros[1];
            bool valor = (bool)parametros[2];
        }
        */

        /*
        static void Main(string[] args)
        {
            Object[] parametros = { "Alex", 25, true };
            new Program().metodo("Alex", 25, 'A');
            Console.ReadLine();
        }

        private void metodo(params object[] parametros)
        {
            var nommbre = parametros[0];
            String nombre = (string)parametros[0];
            int edad = (int)parametros[1];
            bool valor = (bool)parametros[2];
        }
        */

        /*
        static void Main(string[] args)
        {
            int edad = 30;
            int data = 67;
            new Program().metodo(data); 
            Console.ReadLine();
        }

        private void metodo(in int valor)
        {
            //valor = 48;
            Console.WriteLine(valor);
        }
        */
        /*
        static void Main(string[] args)
        {
            int edad = 30;
            int data = 67;
            new Program().metodo(ref data);
            Console.WriteLine(data);
            Console.ReadLine();
        }

        private void metodo(ref int valor)
        {
            valor = 48 + 47;
            
        }
        */
        /*
        static void Main(string[] args)
        {
            int edad = 30;
            int data = 67;
            new Program().metodo(out data);
            Console.WriteLine(data);
            Console.ReadLine();
        }

        private void metodo(out int valor)
        {
            valor = 48 + 47;

        }
        */

        /*
        static void Main(string[] args)
        {
            //int data;
            String nombre;
            //new Program().metodo(out data);
            mensaje();
            Console.WriteLine(nombre);
            void mensaje() => nombre = "Alex Joel";
            Console.ReadLine();
        }

        private void metodo(out int valor)
        {
            valor = funcion();

             int funcion() =>  50 + 20;
                //Console.WriteLine("Hola soy una funcion");
            

        }
        */

        /*
        static void Main()
        {
            int[] array = { 1, 2, 2, 3, 6, 4, 4, 4, 9, 5, 6, 5, 9, 2 };
            int[] list = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        if (numero(array[i]))
                        {
                            list[i] = array[i];
                        }
                    }
                }

                if (list[i] != 0)
                {
                    Console.WriteLine(list[i] + " se repite: " + count);
                }

            }

            bool numero(int num)
            {
                for(int i = 0; i < list.Length; i++)
                {
                    if (list[i] == num)
                    {
                        return false;
                    }
                }
                return true;
            }
        
        }
        */

        static void Main()
        {
            var data = new Conversor();
            data.Conversor1();
            //Conversor.velocidad = 3.0;
            var data1 = new Conversor();
            data1.Conversor2();
            //Conversor.Conversor1();
            //Conversor.Conversor2();
        }

        class Conversor
        {
            public double velocidad;

            public void Conversor1()
            {
                velocidad += 20;
                
            }

            public void Conversor2()
            {
                velocidad += 70;
            }
        }
    }
}
