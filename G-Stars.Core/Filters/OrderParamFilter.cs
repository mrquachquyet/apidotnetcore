using System;
using System.Collections.Generic;
using System.Text;

namespace VNCDCL.Core.Filters
{
    public class OrderParamFilter: GlobalParamFilter
    {
        public int TotalDebtFrom { get; set; }
        public int TotalDebtTo { get; set; }
        public bool? IsSendMailConfirm { get; set; }

        public int UserAssign { get; set; }

    }
}
