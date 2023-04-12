using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ31
{
    internal class Prestamo
    {
        public Copia Copia { get; }
        Lector Lector;
        DateTime FechaVencimiento;
        DateTime? FechaDevolucion;
        bool Activo;

        public Prestamo(Copia copia, Lector lector, DateTime fechaVencimiento, DateTime? fechaDevolucion, bool activo)
        {
            Copia = copia;
            Lector = lector;
            FechaVencimiento = fechaVencimiento;
            FechaDevolucion = fechaDevolucion;
            Activo = activo;
        }

        public bool MereceMulta()
        {
            return DateTime.Now > FechaVencimiento && !FechaDevolucion.HasValue;
        }

        public void DevolverPrestamo()
        {
            FechaDevolucion = DateTime.Now;
            Activo = false;

        }

        public bool EstaActivo() { return Activo; }

        public DateTime? CalcularMulta()
        {
            if (!FechaDevolucion.HasValue) return null;

            return DateTime.Now.AddDays((FechaDevolucion.Value - FechaVencimiento).TotalDays * 2);
        }
    }
}
