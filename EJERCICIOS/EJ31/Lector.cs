using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ31
{
    internal class Lector
    {
        public List<Prestamo> Prestamos { get; }
        List<Multa> Multas;

        public void TomarPrestamo(Prestamo prestamo)
        {
            Prestamos.Add(prestamo);
        }

        public void RecibirMulta(Multa multa)
        {
            Multas.Add(multa);
        }

        public bool TieneMultas()
        {
            return Multas.Where(m => m.Activo).Any();
        }

        public bool TieneMulta(Prestamo prestamo)
        {
            return Multas.Where(m => m.Activo && m.Prestamo == prestamo).Any();
        }

        public Multa ObtenerMulta(Prestamo prestamo)
        {
            return Multas.Single(m => m.Prestamo == prestamo);
        }
    }
}
