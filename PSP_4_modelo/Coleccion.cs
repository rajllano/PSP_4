using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_4_modelo
{
    /// <summary>
    /// Esta clase se encarga de abstraer el manejo de cualquier colección en este modelo.
    /// Se uso generics para sellar el tipo de objeto que puede recibir una coleccion
    /// </summary>
    /// <typeparam name="T">Tipo de objeto que sera guardado en la coleccion</typeparam>
    public class Coleccion<T>
    {
        public List<T> Lista { get; set; }

        /// <summary>
        /// Metodo (Constructor): crea la instancia de la lista
        /// </summary>
        public Coleccion()
        {
            this.Lista = new List<T>();
        }

        /// <summary>
        /// Metodo (Destructor): elimina la referencia de la lista e invoca el recolector de basura
        /// </summary>
        ~Coleccion()
        {
            this.Lista = null;

            GC.Collect();
        }

        /// <summary>
        /// Metodo: Agrega un elemento a la coleccion
        /// </summary>
        /// <param name="Elemento">Recibe el objeto a ser guardado en la lista</param>
        public void Agregar(T Elemento)
        {
            this.Lista.Add(Elemento);
        }

        /// <summary>
        /// Metodo: Elimina un elemento de la coleccion
        /// </summary>
        /// <param name="Elemento">Elemento a ser eliminado de la coleccion</param>
        public void Eliminar(T Elemento)
        {
            this.Lista.Remove(Elemento);
        }

        /// <summary>
        /// Metodo: Tamaño de la coleccion
        /// </summary>
        /// <returns>Retorna el tamaño de la coleccion</returns>
        public int Tamano()
        {
            return this.Lista.Count;
        }

        /// <summary>
        /// Metodo: Retorna un elemento de la lista
        /// </summary>
        /// <param name="Indice">Indice del elemento</param>
        /// <returns>Objeto de la lista</returns>
        public T Elemento(int Indice)
        {
            return this.Lista[Indice];
        }
    }
}