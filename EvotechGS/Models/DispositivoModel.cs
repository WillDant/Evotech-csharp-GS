﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvotechGS.Models
{
    [Table("tb_dispositivo")]
    public class DispositivoModel
    {
        [Key]
        public int id_dispositivo { get; set; }
        [Display(Name = "Nome do Dispositivo")]
        [Required(ErrorMessage = "O campo Nome do Dispositivo é obrigatório")]
        public string nm_dispositivo { get; set; }
        public float potencia { get; set; }
    }
}
