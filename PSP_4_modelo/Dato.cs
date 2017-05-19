using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_4_modelo
{
    public class Dato
    {
        /// <summary>
        /// Metodo: constructor de la clase, no recibe ningun parametro
        /// </summary>
        public Dato()
        {

        }

        /// <summary>
        /// Metodo (Constructor): recibe dos parametros, el valor de x1, x2 y dof.
        /// </summary>
        /// <param name="x1">Valor de x</param>
        /// <param name="x2">Valor de y</param>
        /// /// <param name="dof">Valor de y</param>
        public Dato(Double x1, Double x2, Double dof)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.dof = dof;
        }

        public Double x1 { get; set; }

        public Double x2 { get; set; }

        public Double dof { get; set; }
    }
}