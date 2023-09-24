using System.Globalization;

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
        Costo = dto.ValorHora * dto.CantidadHoras;
        Active = true;
    }

    public Trabajo(TrabajoDTO dto)
    {
        Fecha = dto.Fecha;
        IdProyecto = dto.IdProyecto;
        IdServicio = dto.IdServicio;
        CantidadHoras = dto.CantidadHoras;
        ValorHora = dto.ValorHora;
        Costo = dto.ValorHora * dto.CantidadHoras;
        Active = true;
    }

    public Trabajo()
    {
       
    }


    //Atributos
    public int Id { get; set; }

    [Required]
    public DateTime Fecha { get; set; }
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

    [Required] [Column("ValorHora", TypeName = "float")]
    private double valorHora;

    public double ValorHora
    {
        get { return valorHora; }
        set
        {
            valorHora = value;
            Costo = CantidadHoras * valorHora;
        }
    }
    [Required]
    [Column("Costo", TypeName = "float")]
    
    private double costo;

    public double Costo
    {
        get { return costo; }
        private set { costo = value; }
    }

    [Column("Active", TypeName = "bit")]
    [DefaultValue(true)]
    public bool Active { get; set; }
}