using System.ComponentModel.DataAnnotations.Schema;
using TechOil.DTO;

namespace TechOil.Models
{
    public class Rol
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Descripcion")]
        public string Descripcion { get; set; }
        [Column("Active")]
        public bool Active { get; set; }
        
        //Create
        public Rol(RolDTO dto) 
        {
            Nombre = dto.Nombre;
            Descripcion = dto.Descripcion;
            Active = true;
        }
        
        //Update
        public Rol(RolDTO dto, int id)
        {
            Id = id;
            Nombre= dto.Nombre;
            Descripcion= dto.Descripcion;
            Active = true;
        }

        public Rol()
        {

        }
    
    }
}
