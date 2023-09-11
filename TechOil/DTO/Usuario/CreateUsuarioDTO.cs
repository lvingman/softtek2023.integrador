namespace TechOil.DTO;

public class CreateUsuarioDTO
{
    public string Nombre { get; set; }
    public int Dni { get; set; }
    public int Tipo { get; set; }
    public string Email { get; set; }
    public string Contrasena { get; set; }
}