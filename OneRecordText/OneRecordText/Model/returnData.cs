using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace OneRecordText.Model
{
    public class returnData
    {
        public int code { get; set; }
        public string headerUrl { get; set; }
    }

    public class ApiResponse<T>
    {
        public HttpStatusCode Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class ApiResponse : ApiResponse<object>
    {

    }
}
