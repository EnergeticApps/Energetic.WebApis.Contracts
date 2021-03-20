using Serious.Dtos;

namespace Serious.Dtos
{
    public class ErrorDto
    {
        public ErrorDto(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
        public int StatusCode { get; }
        public string Message { get; }
    }
}
