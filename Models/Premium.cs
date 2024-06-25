using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace CrudTest.Models;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Título do Premium")]
    [StringLength(80, ErrorMessage = "O título deve conter 80 caracteres")]
    [MinLength(5, ErrorMessage = "O título deve conter ao menos 5 caracteres")]
    [DisplayName("Título: ")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("Início")]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Final")]
    public DateTime EndDate { get; set; }
    
    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Digite o aluno")]
    public int StudentId { get; set; }

    public Students? Student { get; set; }
}