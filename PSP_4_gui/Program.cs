using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSP_4_control;

namespace PSP_4_gui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*** PSP4 - Regla de Simpson                  ***");
            Console.WriteLine("************************************************");
            Console.WriteLine("Para procesar un conjunto de valores x1, x2 y dof");
            Console.WriteLine("se debe crear un archivo de texto con la extención .txt");
            Console.WriteLine(@"y guardarlos en el directorio C:\PSP4");
            Console.WriteLine(@"La estructura del archivo debe ser:");
            Console.WriteLine(@"ValorX1;ValorX2;dof");
            Console.WriteLine(@"Ejemplo:");
            Console.WriteLine(@"0;1,1;9");
            Console.WriteLine(@"0;1,1812;10");
            Console.WriteLine(@"0;2,750;30");
            Console.WriteLine("---Presione una tecla para iniciar el procesamiento---");
            Console.ReadKey();

            ControlArchivo.ProcesarArchivo(@"C:\PSP4\Datos.txt");
            Console.WriteLine("---Presione una tecla para salir---");
            Console.ReadKey();
        }
    }
}
