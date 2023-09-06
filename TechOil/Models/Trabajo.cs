namespace TechOil.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Trabajo
{
    public int Id { get; set; }
    
    [Column("Nombre", TypeName = "Date")]
    public DateTime Fecha { get; set; }
    
    public int IdProyecto { get; set; }
    public int IdServicio { get; set; }
    public int CantidadHoras { get; set; }
    public double ValorHora { get; set; }
    public double Costo { get; set; }
}