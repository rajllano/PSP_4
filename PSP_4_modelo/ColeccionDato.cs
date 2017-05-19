using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_4_modelo
{
    /// <summary>
    /// Esta clase hereda de Coleccion y de esta forma puede efectuar todas
    /// sus funcionalidades
    /// </summary>
    public class ColeccionDato : Coleccion<Dato>
    {
        /// <summary>
        /// Matodo: Patron de diseño iterador que abstrae el recorrido de la coleccion
        /// </summary>
        /// <returns></returns>
        public IteradorColeccionDato Iterador()
        {
            return new IteradorColeccionDato(this.Lista);
        }
    }
}