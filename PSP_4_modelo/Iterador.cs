using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_4_modelo
{
    public interface Iterador
    {
        Dato Siguiente();

        bool tieneSiguiente();
    }
}