using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoEvent_.Domains
{
    [Table("Eventos")]
    public class Eventos
    {
        [Key]
        public Guid IdEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório!")]
        public string ? NomeEvento { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do evento é obrigatória!")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A Descrição do evento é obrigatória!")]
        public string ? Descricao { get; set; }


        // referencia tabela tipos usuario

        [Required(ErrorMessage = "O nome do usuário é obrigatório!")]
        public Guid IdTiposUsuario { get; set; }

        [ForeignKey("IdTiposUsuario")]
        public TiposEventos ? TiposEventos { get; set; }


        // referencia tabela tipos evento

        [Required(ErrorMessage = "O tipo do evento é obrigatório!")]
        public Guid IdTiposEvento { get; set; }

        [ForeignKey("IdInstituicao")]
        public Instituicoes? Instituicoes { get; set; }

    }
}
