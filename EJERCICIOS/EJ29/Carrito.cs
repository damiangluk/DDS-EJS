using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.EJ29
{
    internal class Carrito
    {
        Cliente Cliente;
        List<Item> Items;
        bool Estado;

        void SolicitarCompra()
        {
            Tarjeta tarjetaAUtilizar = Cliente.ElegirTarjeta();

            int total = CalcularTotal();
            if(tarjetaAUtilizar.Pagar(total))
                Estado = false;
        }

        void AgregarItem(Item item)
        {
            Items.Add(item);
        }

        void EliminarItem(Item item)
        {
            Items.Remove(item);
        }

        public int CalcularTotal()
        {
            int monto = 0;
            Items.ForEach(item => { monto += item.CalcularTotal(); });
            return monto;
        }
    }
}
