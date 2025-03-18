using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEvent_.Domains
{
    [Table("ComentarioEventos")]
    public class ComentarioEvento
    {
        [Key]
        public Guid IdComentarioEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A Descrição do comentário é obrigatória!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A Exibição do comentário é obrigatória!")]
        public bool? Exibe { get; set; }


        // referencia tabela usuario

        public Guid ?IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }


        // referencia tabela evento

        public Guid ? IdEvento { get; set; }
        [ForeignKey("IdEvento")]
        public Evento ? Evento { get; set; }
    }
}
