using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_4_modelo
{
    public class IteradorColeccionDato : Iterador
    {
        private List<Dato> Lista;
        private int Indice;

        /// <summary>
        /// Metodo (Constructor)
        /// </summary>
        /// <param name="Lista">Referencia de la coleccion a iterar</param>
        public IteradorColeccionDato(List<Dato> Lista)
        {
            this.Lista = Lista;
            Indice = -1;
        }

        /// <summary>
        /// Metodo: Itera al siguiente elemento de la coleccion
        /// </summary>
        /// <returns>Retorna el objeto siguiente</returns>
        public Dato Siguiente()
        {
            Indice++;

            if (Indice < this.Lista.Count)
                return this.Lista[Indice];

            return null;
        }

        /// <summary>
        /// Metodo: determina si existe un elemento siguiente en la colección
        /// </summary>
        /// <returns>True: existen mas elementos. False: no existen mas elementos</returns>
        public bool tieneSiguiente()
        {
            if (Indice + 1 < Lista.Count)
                return true;

            return false;
        }
    }
}