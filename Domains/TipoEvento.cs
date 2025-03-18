using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEvent_.Domains
{
    [Table("TipoEventos")]
    public class TipoEvento
    {
        [Key]
        public Guid IdTipoEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O tipo do evento é obrigatório!")]
        public string ? TituloTipoEvento { get; set; }
    }
}
