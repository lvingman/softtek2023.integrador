using TechOil.DTO;

namespace TechOil.Helper;

public static class PaginateHelper
{
    //Helpers son estaticos en su mayoria
    public static PaginateDataDTO<T> Paginate<T>(List<T> itemsToPaginate , int currentPage, string url)
    {
        int pageSize = 10;
        var totalItems = itemsToPaginate.Count;
        var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
        var paginateItems = itemsToPaginate.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

        var prevUrl = currentPage > 1 ? $"{url}?page={currentPage - 1}" : null;
        var nextUrl = currentPage < totalPages ? $"{url}?page={currentPage + 1}" : null;

        return new PaginateDataDTO<T>()
        {
            CurrentPage = currentPage,
            PageSize = pageSize,
            TotalItems = totalItems,
            TotalPages = totalPages,
            PrevURL = prevUrl,
            NextURL = nextUrl,
            Items = paginateItems
        };

    }
}