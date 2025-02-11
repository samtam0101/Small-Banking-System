using System.Net;

namespace Domain.Responses;

public class Response<T>
{
    public T Data { get; set; }
    public int? StatusCode { get; set; }
    public List<string>? Errors { get; set; } = new List<string>();
    public Response(T data)
    {
        StatusCode = 200;
        Data = data;
    }
    public Response(HttpStatusCode httpStatusCode, string error)
    {
        StatusCode = (int)HttpStatusCode.OK;
        Errors.Add(error);
    }
    public Response(HttpStatusCode httpStatusCode, List<string> errors)
    {
        StatusCode = (int)HttpStatusCode.OK;
        Errors = errors;
    }
    public Response(T data,List<string> errors,HttpStatusCode statusCode)
    {
        StatusCode = (int)HttpStatusCode.OK;
        Data = data;
        Errors = errors;
    }
}
