namespace TechOil.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Dni { get; set; }
    public int Tipo { get; set; }
    public string Contrasena { get; set; }
    public string Email { get; set; }
    
    //Todo: Considerar agregar un mail al usuario
    
}