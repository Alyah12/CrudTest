using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudTest.Models;

public class Students
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O nomme deve conter 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter ao menos 5 caracteres")]
    [DisplayName("Nome completo: ")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Insira seu email")]
    [EmailAddress(ErrorMessage = "O email deve ser válido")]
    [DisplayName("Email")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premium { get; set; } = new();
}