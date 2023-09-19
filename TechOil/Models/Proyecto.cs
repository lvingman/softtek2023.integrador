using System.ComponentModel;
using TechOil.DTO;

namespace TechOil.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Proyecto
{
    
    //Constructores

    public Proyecto(ProyectoDTO dto, int id)
    {
        Id = id;
        Nombre = dto.Nombre;
        Direccion = dto.Direccion;
        IdEstado = dto.IdEstado;
    }
    public Proyecto(ProyectoDTO dto)
    {
        Nombre = dto.Nombre;
        Direccion = dto.Direccion;
        IdEstado = dto.IdEstado;
        Active = true;
    }
    
    public Proyecto()
    {
        
    }
    
    //Atributos
    public int Id { get; set; }
    
    [Required]
    [Column("Nombre", TypeName = "VARCHAR(50)")]
    public string Nombre { get; set; }
    
    [Required]
    [Column("Direccion", TypeName = "VARCHAR(200)")]
    public string Direccion { get; set; }
    
    [Required]
    public int IdEstado { get; set; }
    [NotMapped]
    public string? Estado
    {
        get => ((Estado)IdEstado).ToString();
    }

 
    
    [DefaultValue(true)]
    public bool Active { get; set; }
    
  

    
}