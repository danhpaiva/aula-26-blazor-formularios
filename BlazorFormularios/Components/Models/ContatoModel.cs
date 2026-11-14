using System.ComponentModel.DataAnnotations;

namespace BlazorFormularios.Components.Models
{
    public class ContatoModel
    {
        [Required(ErrorMessage = "Informe o nome do contato")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe o email do contato")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe a idade do contato")]
        [Range(1, 120, ErrorMessage = "Informe uma idade válida (1 a 120)")]
        public int Idade { get; set; }
        public bool Newsletter { get; set; }
    }
}