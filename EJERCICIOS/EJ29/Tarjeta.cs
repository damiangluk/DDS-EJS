using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ29
{
    internal class Tarjeta
    {
        string Nombre;
        int Numero;
        DateTime Fecha;
        string Codigo;
        bool Verificada;
        Cliente Cliente;

        public bool Pagar(int total)
        {
            total = RealizarDescuento(total);

            if(Verificada)
            {
                // Pagar total
                return true;
            }

            return false;
        }

        int RealizarDescuento(int Monto)
        {
            if (Cliente.EsPreferencial())
                return Monto; // - DESCUENTO;
            return Monto;
        }
    }
}
