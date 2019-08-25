using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OfficeManagement.Responses
{
    public class CustomHttpResponseMessage
    {
        public string apiVersion { get; set; }
        public HttpStatusCode statusCode { get; set; }
        public Object Result { get; set; }
        public DateTime responseDateTime { get; set; }
    }
}
