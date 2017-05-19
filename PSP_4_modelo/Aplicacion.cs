using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_4_modelo
{
    public class Aplicacion
    {
        private static Aplicacion Instancia = null;

        /// <summary>
        /// Metodo: singleton de la aplicación para garantizar la unidad del objeto Aplicación
        /// </summary>
        /// <returns>Retorna en todas las invocaciones la misma instancia</returns>
        public static Aplicacion getInstancia()
        {
            if (Instancia == null)
                Instancia = new Aplicacion();

            return Instancia;
        }

        public ColeccionDato ColeccionDato { get; set; }

        /// <summary>
        /// Metodo (Constructor): crea la instancia de la coleccion
        /// </summary>
        public Aplicacion()
        {
            this.ColeccionDato = new ColeccionDato();
        }

        /// <summary>
        /// Metodo (Destructor): elimina la referencia de la colección e invoca el recolector de basura
        /// </summary>
        ~Aplicacion()
        {
            this.ColeccionDato = null;

            GC.Collect();
        }
    }
}