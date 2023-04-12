using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EJERCICIOS.EJ29
{
    internal class Cliente
    {
        string Nombre;
        string DireccionEnvio;
        string DireccionCobro;
        string Email;
        int Dni;
        List<Tarjeta> Tarjetas;
        List<Carrito> Carritos;
        bool Preferencial;

        public Tarjeta ElegirTarjeta()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(Tarjetas.Count() - 1);

            return Tarjetas[numeroAleatorio];
        }

        public bool EsPreferencial()
        {
            return Preferencial;
        }
    }
}
