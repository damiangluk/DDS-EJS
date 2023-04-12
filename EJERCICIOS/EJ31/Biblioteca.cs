using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ31
{
    public sealed class Biblioteca
    {
        private static readonly Biblioteca instance = new Biblioteca();

        private Biblioteca() { }

        public static Biblioteca GetInstance
        {
            get
            {
                return instance;
            }
        }

        // OBTENER BIBLIOTECA: Biblioteca b = Biblioteca.GetInstance;

        void RealizarPrestamo(Lector lector, Copia copia)
        {
            if(PuedeRecibirPrestamo(lector) && !lector.TieneMultas() && copia.EstaDisponible())
            {
                Prestamo prestamo = new Prestamo(copia, lector, DateTime.Now.AddDays(30), null, true);
                lector.TomarPrestamo(prestamo);
                copia.EstablecerEstado(Estado.PRESTADO);
            }
        }

        void DevolucionPrestamo(Lector lector, Prestamo prestamo)
        {
            prestamo.DevolverPrestamo();
            if(lector.TieneMulta(prestamo))
            {
                DateTime? fechaFinalizacion = prestamo.CalcularMulta();
                Multa multa = lector.ObtenerMulta(prestamo);
                multa.ActualizarMulta(fechaFinalizacion);
            }
            prestamo.Copia.EstablecerEstado(Estado.BIBLIOTECA);
        }

        // METODO DE VERIFICACION DIARIA
        void VerificarMulta(Lector lector, Prestamo prestamo)
        {
            if (prestamo.MereceMulta() && !lector.TieneMulta(prestamo))
            {
                Multa multa = new Multa(true, prestamo, null);
                lector.RecibirMulta(multa);
                prestamo.Copia.EstablecerEstado(Estado.RETRASO);
            }
        }

        bool PuedeRecibirPrestamo(Lector lector)
        {
            return lector.Prestamos.Where(p => p.EstaActivo()).Count() < 3;
        }
    }
}
