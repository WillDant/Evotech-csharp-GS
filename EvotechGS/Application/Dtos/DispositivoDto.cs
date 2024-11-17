using System.ComponentModel.DataAnnotations;

namespace EvotechGS.Application.Dtos
{
    public class DispositivoDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(2000, ErrorMessage = "O campo nome deve ter no máximo 2000 caracteres")]
        public string nm_dispositivo { get; set; } = string.Empty;


        [Required(ErrorMessage = "O campo potência é obrigatório")]
        [Range(0, 100000, ErrorMessage = "O campo potência deve ser entre 0 e 100000")]
        public float potencia { get; set; }
    }
}
