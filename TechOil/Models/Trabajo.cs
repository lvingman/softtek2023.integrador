namespace TechOil.Models;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechOil.DTO;

public class Trabajo
{
    //Constructores

    public Trabajo(TrabajoDTO dto, int id)
    {
        Id = id;
        Fecha = dto.Fecha;
        IdProyecto = dto.IdProyecto;
        IdServicio = dto.IdServicio;
        CantidadHoras = dto.CantidadHoras;
        ValorHora = dto.ValorHora;
        Costo = dto.Costo;
        Active = true;
    }

    public Trabajo(TrabajoDTO dto)
    {
        Fecha = dto.Fecha;
        IdProyecto = dto.IdProyecto;
        IdServicio = dto.IdServicio;
        CantidadHoras = dto.CantidadHoras;
        ValorHora = dto.ValorHora;
        Costo = dto.Costo;
        Active = true;
    }

    public Trabajo()
    {

    }


    //Atributos
    public int Id { get; set; }

    [Required]
    [Column("Nombre", TypeName = "VARCHAR(50)")]
    //ToDo: Cambiar Fecha de String a DateTime/DateOnly (de alguna manera)
    public string Fecha { get; set; }
    [Required]
    [ForeignKey("Proyecto")]
    public int IdProyecto { get; set; }
    public Proyecto? Proyecto { get; set; }

    [Required]
    [ForeignKey("Servicio")]
    public int IdServicio { get; set; }
    public Servicio? Servicio { get; set; }
    [Required]
    [Column("CantidadHoras", TypeName = "int")]
    public int CantidadHoras { get; set; }
    [Required]
    [Column("ValorHora", TypeName = "float")]
    public double ValorHora { get; set; }
    [Required]
    [Column("Costo", TypeName = "float")]
    public double Costo { get; set; }

    [Column("Active", TypeName = "bit")]
    [DefaultValue(true)]
    public bool Active { get; set; }
}