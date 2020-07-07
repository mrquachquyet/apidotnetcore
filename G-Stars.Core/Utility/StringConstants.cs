using System;
using System.Collections.Generic;
using System.Text;
using VNCDCL.Core.Constants;
using static VNCDCL.Core.Constants.Constants;

namespace VNCDCL.Core.Utility
{
    public static class StringConstants
    {
        public static string StringPaymentStatus(this string status)
        {
            switch (status)
            {
                case Constants.Constants.PaymentStatus.Paid:
                    return "Paid";
                case Constants.Constants.PaymentStatus.WaitPayment:
                    return "Wait Payment";
                default:
                    return string.Empty;
            }
        }
    }
}
