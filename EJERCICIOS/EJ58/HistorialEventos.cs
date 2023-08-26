using System;
using System.Collections.Generic;
using Internal;

namespace Application
{


    // Clase para manejar el historial de eventos
    class HistorialEventos
    {
        private static HistorialEventos instancia;
        private List<Evento> eventos;

        private HistorialEventos()
        {
            eventos = new List<Evento>();
        }

        // Propiedad para obtener la instancia única del Singleton
        public static HistorialEventos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new HistorialEventos();
                }
                return instancia;
            }
        }

        // Método para agregar un nuevo evento al historial
        public void AgregarEvento(string usuario, string opcion)
        {
            Evento nuevoEvento = new Evento
            {
                FechaHora = DateTime.Now,
                Usuario = usuario,
                Opcion = opcion
            };

            eventos.Add(nuevoEvento);
        }

        // Método para mostrar todos los eventos en el historial
        public void MostrarEventos()
        {
            foreach (Evento evento in eventos)
            {
                Console.WriteLine($"Fecha y Hora: {evento.FechaHora}");
                Console.WriteLine($"Usuario: {evento.Usuario}");
                Console.WriteLine($"Opción: {evento.Opcion}");
                Console.WriteLine();
            }
        }

        //Maneja el evento
        public void OnButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("El botón fue clickeado!");
        }
    }


}

