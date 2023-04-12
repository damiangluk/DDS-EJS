using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ31
{
    internal class Copia
    {
        Libro Libro;
        int NumeroCopia;
        Estado Estado;

        public void EstablecerEstado(Estado estado)
        {
            Estado = estado;
        }

        public bool EstaDisponible()
        {
            return Estado == Estado.BIBLIOTECA;
        }
    }
}
