using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_CENTHIA_Y_YEIDRY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el decimal que desee convertir:");
            int midecimal = int.Parse(Console.ReadLine());
            string mibinario = "";

            while (midecimal > 0)
            {
                mibinario = midecimal % 2 + mibinario;

                midecimal = midecimal / 2;

            }

            Console.WriteLine("El resultado de la conversion es:" + mibinario);
            Console.ReadLine();

        }
    }
}
