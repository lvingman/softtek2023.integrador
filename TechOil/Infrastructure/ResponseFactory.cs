using Microsoft.AspNetCore.Mvc;

namespace TechOil.Infrastructure;

public static class ResponseFactory
{
    public static IActionResult CreateSuccessResponse(int statusCode, object? data)
    {
        var response = new ApiSuccessResponse()
        {
            Status = statusCode, Data = data
        };
        return new ObjectResult(response)
        {
            StatusCode = statusCode
        };

    }
    
    //TODO:  terminar esto
    /*
    public static IActionResult CreateErrorResponse(int statusCode, string[] errors)
    {
        var response = new ApiErrorResponse()
        {
            Status = statusCode,
            Error = new List<ApiErrorResponse.ResponseError>
        };

        foreach (var error in errors)
        {
            response.Error.Add
        }
        
        return new ObjectResult(response)
        {
            StatusCode = statusCode
        };

    }
    */
    
    
}