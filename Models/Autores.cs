using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenBlazor.Models;

public class Autores
{
    [Key]
    public int IdAutor{get; set;}
    [Required(ErrorMessage ="el nombre es obligatorio")]
    [StringLength(80, ErrorMessage ="maximo de 80 caracteres")]
    public string Nombres{get; set;} =string.Empty;
    [Required(ErrorMessage ="la nacionalidad es obligatoria")]
    public string Nacionalidad{get; set;}= string.Empty;
    [Required(ErrorMessage ="la fecha de nacimiento es obligatoria")]
    public DateTime FechaNacimiento{get; set;} =DateTime.Today;
    [Range(0.01, 1000000, ErrorMessage ="el sueldo debe ser mayor que 0")]
    [Column(TypeName ="decimal(18,2)")]
    public decimal Sueldo{get; set;}

}