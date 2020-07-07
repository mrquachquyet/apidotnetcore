using System;
using System.Collections.Generic;
using System.Text;

namespace VNCDCL.Core.Filters
{
    public class OrderDetailParameterFitler : GlobalParamFilter
    {
        public string AttachmentType { get; set; }
        public int OrderId { get; set; }
    }
}
