using ApplicationCore.Constants.Api;
using ApplicationCore.Extensions.Json;
using System;

namespace Api.Helper.Api
{
    public class ApiResult
    {
        public ApiResult(string response, string message, bool success, string status)
        {
            Response = response;
            Message = message;
            Success = success;
            Status = status;
        }

        public string Response { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Status { get; set; }

    }
    public static class ApiResultExtension
    {
        public static ApiResult Send(this object obj) => new ApiResult(obj.ToJson(), ResponseMessages.SuccessMessage, true, "200");
        public static ApiResult ExceptionEncountered(this Exception exc) => new ApiResult(exc.InnerException != null ? exc.InnerException.Message : exc.Message, ResponseMessages.FailedMessage, false, "500");
    }
}
