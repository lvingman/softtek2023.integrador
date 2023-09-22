using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechOil.DTO;

namespace TechOil.Models;

public class Servicio
{
    //CONSTRUCTORES
    public Servicio(ServicioDTO dto, int id)
    {
        Id = id;
        Descripcion = dto.Descripcion;
        Estado = dto.Estado;
        ValorHora = dto.ValorHora;
    }
    
    public Servicio(ServicioDTO dto)
    {
        Descripcion = dto.Descripcion;
        Estado = dto.Estado;
        ValorHora = dto.ValorHora;
    }
    public Servicio()
    {
        
    }
    
    //ATRIBUTOS
    [Required]
    public int Id { get; set; }
    
    //Texto con descripcion de texto
    [Required]
    [Column("Descripcion", TypeName = "VARCHAR(100)")]
    public string Descripcion { get; set; }
    
    //Define si el servicio esta activo o no
    [Required]
    [Column ("Estado", TypeName = "bit")]
    public bool Estado { get; set; }
    
    //Valor decimal que indica el costo por hora de este servicio
    [Required]
    [Column ("ValorHora", TypeName = "float")]
    public double ValorHora { get; set; }

}