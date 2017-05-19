using PSP_4_modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_4_control
{
    public static class ControlArchivo
    {
        /// <summary>
        /// Esta funcion recibe un archivo, lee su estructura y lo carga en la lista 
        /// </summary>
        /// <param name="Archivo">Archivo a procesar</param>
        public static void ProcesarArchivo(String RutaArchivo)
        {
            if (!File.Exists(RutaArchivo))
                throw new Exception("Archivo no existe");

            FileInfo Archivo = new FileInfo(RutaArchivo);

            StreamReader ArchivoTexto = new StreamReader(Archivo.FullName);
            string Linea;
            String[] Arreglo;
            Double x1, x2, dof;
            int ContadorLinea = 0;
            Dato d;

            while ((Linea = ArchivoTexto.ReadLine()) != null)
            {
                if (Linea.Trim().Length > 0)
                {
                    Arreglo = Linea.Split(';');
                    ContadorLinea++;

                    if (Arreglo.Length != 3)
                        throw new Exception("La estructura del archivo no es correcta");

                    try
                    {
                        x1 = Convert.ToDouble(Arreglo[0]);
                    }
                    catch
                    {
                        throw new Exception("Archivo [" + Archivo.Name + "] Linea [" + ContadorLinea + "] En valor de x1 no es numerico");
                    }

                    try
                    {
                        x2 = Convert.ToDouble(Arreglo[1]);
                    }
                    catch
                    {
                        throw new Exception("Archivo [" + Archivo.Name + "] Linea [" + ContadorLinea + "] En valor de x2 no es numerico");
                    }

                    try
                    {
                        dof = Convert.ToDouble(Arreglo[2]);
                    }
                    catch
                    {
                        throw new Exception("Archivo [" + Archivo.Name + "] Linea [" + ContadorLinea + "] En valor de dof no es numerico");
                    }

                    d = new Dato(x1, x2, dof);

                    Aplicacion.getInstancia().ColeccionDato.Agregar(d);
                }
            }

            ArchivoTexto.Close();
            ControlCalculo.ReglaSimpson();
        }
    }
}
