using System;
using System.ComponentModel.DataAnnotations;

namespace LandingPage.Models
{
    public class Lead
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Nome { get; set; }

        [Required, EmailAddress, StringLength(200)]
        public string Email { get; set; }

        [Phone, StringLength(30)]
        public string? Telefone { get; set; }

        [StringLength(2000)]
        public string? Mensagem { get; set; }

        [Required]
        public bool AceiteLGPD { get; set; }

        public DateTime CriadoEm { get; set; }

        [StringLength(100)]
        public string? Origem { get; set; }
    }
}
