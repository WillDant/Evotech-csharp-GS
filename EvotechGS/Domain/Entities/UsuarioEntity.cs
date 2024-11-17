using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvotechGS.Domain.Entities
{

    [Table("tb_usuario")]
    public class UsuarioEntity
    {
        public int id_usuario { get; set; }
        [Required(ErrorMessage = "Nome do usuário é obrigatório")]
        public string nm_usuario { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage = "Senha é obrigatória")]
        public string senha { get; set; }
        public string telefone { get; set; }
        public DateTime dt_cadastro { get; set; }
        public string genero { get; set; }
    }
}
