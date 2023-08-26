
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPINTEGRADOR.Models
{
    public class Vehiculo
    {
        public Vehiculo() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        [ForeignKey("Id")]
        public int EquipoId { get; set; }

        public virtual Equipo Equipo { get; set; }
    }
}