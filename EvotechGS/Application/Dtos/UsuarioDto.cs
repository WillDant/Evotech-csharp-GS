using System.ComponentModel.DataAnnotations;

namespace EvotechGS.Application.Dtos
{
    public class UsuarioDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(2000, ErrorMessage = "O campo nome deve ter no máximo 2000 caracteres")]
        public string nm_usuario { get; set; } = string.Empty;


        [Required(ErrorMessage = "O campo email é obrigatório")]
        [StringLength(2000, ErrorMessage = "O campo email deve ter no máximo 2000 caracteres")]
        public string email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [StringLength(2000, ErrorMessage = "O campo senha deve ter no máximo 2000 caracteres")]
        public string senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        [StringLength(2000, ErrorMessage = "O campo telefone deve ter no máximo 2000 caracteres")]
        public string telefone { get; set; } = string.Empty;

        public System.DateTime dt_cadastro { get; set; }

        [Required(ErrorMessage = "O campo genero é obrigatório")]
        [StringLength(2000, ErrorMessage = "O campo genero deve ter no máximo 2000 caracteres")]
        public string genero { get; set; } = string.Empty;

    }

}
