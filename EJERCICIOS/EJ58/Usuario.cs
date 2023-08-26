using System;
namespace Application
{
	public class Usuario
	{

		
		public Usuario() { }
		

        // Evento
        public event EventHandler ButtonClicked;


		// Método que llama al evento
		public void Click(String opcion){
		ButtonClicked?.Invoke(this, EventArgs.Empty);
        HistorialEventos historial = HistorialEventos.Instancia;
		historial.AgregarEvento(this.nombreusuario, opcion);
        }


        }
}


// Delegado de evento
delegate void EventHandler(object sender, EventArgs e);