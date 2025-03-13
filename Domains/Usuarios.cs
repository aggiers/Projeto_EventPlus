using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEvent_.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuarios
    {
        [Key]
        public Guid IdUsuario { get; set; }

        public string? NomeUsuario { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
