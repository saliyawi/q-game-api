using System;

namespace q_game_api.Filters
{
    public class ApiValidationExceptionFilter : Exception
    {
        public int StatusCode { get; set; }

        public string Value { get; set; }

        public ApiValidationExceptionFilter(string message, int statusCode = 400) : base(message)
        {
            StatusCode = statusCode;
            Value = message;
        }
    }
}
