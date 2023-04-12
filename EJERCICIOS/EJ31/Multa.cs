using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ31
{
    internal class Multa
    {
        public bool Activo { get; }
        public Prestamo Prestamo { get; }
        DateTime? FechaFin;

        public Multa(bool activo, Prestamo prestamo, DateTime? fechaFin)
        {
            Activo = activo;
            Prestamo = prestamo;
            FechaFin = fechaFin;
        }

        public void ActualizarMulta(DateTime? fechaFinalizacion)
        {
            FechaFin = fechaFinalizacion;
        }
    }
}
