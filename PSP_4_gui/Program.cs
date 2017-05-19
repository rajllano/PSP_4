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
            ControlArchivo.ProcesarArchivo(@"C:\PSP4\Datos.txt");
            Console.ReadKey();
        }
    }
}
