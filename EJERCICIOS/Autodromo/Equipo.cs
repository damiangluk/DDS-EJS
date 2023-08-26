using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPINTEGRADOR.Models
{
    public class Equipo
    {
        public Equipo() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual ICollection<Persona> Integrantes { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}