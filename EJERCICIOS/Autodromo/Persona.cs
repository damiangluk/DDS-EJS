
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPINTEGRADOR.Models
{
    public class Persona
    {
        public Persona() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int NumeroDoc { get; set; }
        public string TipoDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Peso { get; set; }
        public bool Verificada { get; set; }

        [ForeignKey("Id")]
        public int EquipoId { get; set; }

        public virtual Equipo Equipo { get; set; }


    }
}