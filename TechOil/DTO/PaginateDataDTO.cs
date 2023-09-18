namespace TechOil.DTO;

public class PaginateDataDTO<T>
{
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
    public int TotalItems { get; set; }
    public string PrevURL { get; set; }
    public string NextURL { get; set; }
    public List<T> Items { get; set; }

}