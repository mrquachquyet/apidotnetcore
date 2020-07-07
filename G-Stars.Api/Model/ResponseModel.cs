using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G_Stars.Api.Model
{
    public class ResponseModel
    {
        public int TotalRecords { get; set; }
        public object Data { get; set; }
        public int StatusCode { get; set; }
    }
}
