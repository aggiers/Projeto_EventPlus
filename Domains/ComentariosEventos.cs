using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEvent_.Domains
{
    [Table("ComentariosEventos")]
    public class ComentariosEventos
    {
        [Key]
        public Guid IdComnetarioEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A Descrição do comentário é obrigatória!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A Exibição do comentário é obrigatória!")]
        public bool? Exibe { get; set; }


        // referencia tabela usuario

        [Required(ErrorMessage = "O nome do usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios? Usuarios { get; set; }


        // referencia tabela evento

        [Required(ErrorMessage = "O nome do evento é obrigatório!")]
        public Guid IdEvento { get; set; }

        [ForeignKey("IdEvento")]
        public Eventos? Eventos { get; set; }
    }
}
