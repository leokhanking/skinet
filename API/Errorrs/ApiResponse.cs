using System;

namespace API.Errorrs
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(StatusCode);;
        }

        

        public int StatusCode { get; set; } 
        public string Message { get; set; } 

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return StatusCode switch 
            {
                    400 => "A bad request. You have made",
                    401 => "Authorized, you are not",
                    404 => "Resource Found. it was not",
                    500=> "Errors are the path to the darl side. Errors lead to anger, Error lead to hate, Hate  lead to career change",
                    _ => null
            };
        }       
    }
}