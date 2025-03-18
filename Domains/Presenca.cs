using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEvent_.Domains
{
    [Table("Presencas")]
    public class Presenca
    {
        [Key]
        public Guid IdPresenca { get; set; }

        public bool Situacao { get; set; }

        // referencia tabela usuario
        public Guid ?IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }


        // referencia tabela evento
        public Guid ?IdEvento { get; set; }
        [ForeignKey("IdEvento")]
        public Evento? Evento { get; set; }
    }
}
