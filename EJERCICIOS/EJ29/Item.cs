using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ29
{
    internal class Item
    {
        Producto Producto;
        int Cantidad;
        int Valor;

        public int CalcularTotal()
        {
            return Valor * Cantidad;
        }
    }
}
