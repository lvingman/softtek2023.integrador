namespace TechOil.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Proyecto
{
    public int Id { get; set; }
    
    [Required]
    [Column("Nombre", TypeName = "VARCHAR(50)")]
    public string Nombre { get; set; }
    
    [Required]
    [Column("Direccion", TypeName = "VARCHAR(200)")]
    public string Direccion { get; set; }
    
    [Required]
    public int Estado { get; set; }
}