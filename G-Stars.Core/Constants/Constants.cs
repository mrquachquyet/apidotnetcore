using System.ComponentModel;

namespace VNCDCL.Core.Constants
{
    public static class Constants
    {
        public const string AdminUserName = "Admin";
        public const string SessionMenu = "SessionMenu";
        public const string SessionRole = "SessionRole";
        public const string SessionUserId = "SessionUserId";

        public class ConfigKey
        {
            public const string EmailAccount = "EmailAccount";
            public const string TitleNotificationInvoice = "TitleNotificationInvoice";
            public const string ContentNotificationInvoice = "ContentNotificationInvoice";
            public const string TitleNotificationRemind = "TitleNotificationRemind";
            public const string JobRemind = "JobRemind";
        }

        public class ReplaceMerge
        {
            public const string UserName = "{username}";
            public const string OrderName = "{ordername}";
            public const string InvoiceNo = "{invoiceno}";
            public const string TotalPrice = "{totalprice}";

        }

        public class SortByData
        {
            public const string Name = "NAME";

            public const string Status = "STATUS";

            public const string CreateDate = "CREATEDATE";

            public const string UpdatedDate = "UPDATEDDATE";

            public const string OrderBy = "ORDERBY";
            public const string Code = "Code";
            public const string Price = "Price";
        }

        public class OrderByData
        {
            public const string Desc = "DESC";

            public const string Asc = "ASC";
        }

        public class Status
        {
            [Description("Publish")]
            public const string Publish = "PUBLISH";

            [Description("Draft")]
            public const string Draft = "DRAFT";

            [Description("Delete")]
            public const string Delete = "DELETE";

            [Description("Active")]
            public const int Active = 1;

            [Description("In Active")]
            public const int InActive = 0;

        }
        public class CustomerStatus
        {
            [Description("Active")]
            public const string Active = "ACTIVE";

            [Description("Stand by")]
            public const string StandBy = "STAND_BY";

            [Description("Delete")]
            public const string Delete = "DELETE";

        }

        public class OrderStatus
        {
            [Description("Pending")]
            public const string Pending = "PENDING";

            [Description("Active")]
            public const string Active = "ACTIVE";

            [Description("Close")]
            public const string Close = "CLOSE";
        }

        public class PaymentStatus
        {
            [Description("Paid")]
            public const string Paid = "PAID";

            [Description("Wait confirm")]
            public const string WaitPayment = "WAIT_PAY";
        }

        public class LogSendEmailType
        {
            [Description("Confirm to customer")]
            public const string ConfirmToCustomer = "CONFIRM_CUSTOMER";

            /// <summary>
            /// gửi report báo cáo cho khách hàng
            /// </summary>
            [Description("Customer report")]
            public const string CustomerReport = "CUSTOMER_REPORT";

            [Description("Notification")]
            public const string Notification = "NOTIFICATION";

            [Description("remind")]
            public const string Remind = "REMIND";
        }

        public class AttachmentType
        {
            /// <summary>
            /// Ánh xạ sang bảng order
            /// </summary>
            [Description("Order")]
            public const string Order = "ORDER";

            /// <summary>
            /// 
            /// </summary>
            [Description("Order detail")]
            public const string OrderDetail = "ORDER_DETAIL";

            [Description("Send email")]
            public const string SendEmail = "SEND_EMAIL";

            [Description("Invoice send email RefId = InvoiceId")]
            public const string Invoice_Email = "SEND_EMAIL_INVOICE";

            [Description("send all Invoice send email RefId = OrderId")]
            public const string Invoice_Email_All_OrderId = "INVOICE_EMAIL_All_ORDERID";

            [Description("Invoice")]
            public const string Invoice = "INVOICE";
        }

        public class InvoiceStatus
        {
            [Description("publish")]
            public const string Publish = "PUBLISH";
            [Description("Delete")]
            public const string Delete = "DELETE";
            [Description("Draft")]
            public const string Draf = "DRAF";
        }
        public class NotificationType
        {
            [Description("Remind")]
            public const string Remind = "REMIND";

            [Description("Notification")]
            public const string Notification = "NOTIFICATION";
        }

        public class UserType
        {
            
            public const string Admin = "ADMIN"; // full
            
            public const string Collector = "COLLECTOR";  // view this
            
            public const string Invoice = "INVOICE";// view

            public const string Customer = "CUSTOMER";// view this
        }

        public class CurrencyCode
        {
            public const string USD = "USD";

            public const string VND = "VND";

            public const string EUR = "EUR";
        }
        public class StatusJsonResponse
        {
            public const string Success = "OK";
            public const string Error = "NG";
        }

        public class Message
        {
            public const string DeleteConfirm = "Are you sure you want to delete {0}?";
            public const string IsExists = "{0} is existed";
            public const string IsNotExists = "{0} is not existed";
            // Create
            public const string FailToCreate = "This {0} has been create unsuccessfully";
            public const string SuccessToCreate = "This {0} has been create successfully";

            // Update
            public const string FailToUpdate = "This {0} has been update unsuccessfully";
            public const string SuccessToUpdate = "This {0} has been update successfully";
            public const string ChangeStatus = "This {0} has changed to {1}";

            // Delete
            public const string FailToDelete = "This {0} has been delete unsuccessfully";
            public const string SuccessToDelete = "This {0} has been delete successfully";
            public const string UsedCannotDelete = "This {0} has been used, cannot be deleted";

            //Sendmail
            public const string SendEmailSuccess = "Email sent successfully";
            public const string SendEmailError = "Email sent failed";

            //Validate
            public const string ValidateFormat = "Wrong {0} format";
            public const string ValidateFail = "Please enter the correct and complete information";

            public const string PasswordIncorrect = "Current password is incorrect";

            //Error
            public const string ApplicationError = "This action can not be executed by the cause of the network or server. Please try again a few times!";

            //Order
            public const string OrderStatusActive = "Order was active. Please not edit!";
            public const string OrderStatusClose = "Order was close. Please not edit!";
            public const string OrderCloseSuccess = "This order has been close successfully";
            public const string OrderAssignSuccess = "This order has been assign successfully";
            public const string OrderFailToUpdate = "This order has been update unsuccessfully";
            public const string OrderSuccessToUpdate = "This order has been update successfully";
            public const string OrderFailToCreate = "This order has been create unsuccessfully";
            public const string OrderSuccessToCreate = "This order has been create successfully";
            public const string OrderViewFaild = "This order has been view unsuccessfully";

            //OrderDetail
            public const string DeleteOrderDetailSuccess = "Delete order detail sucessfully";
            public const string CreateOrderDetailSuccess = "Create order detail successfully";
            public const string warningOrderCloseCreateOrderDetail = "Can not order detail create. Because Order was been close";

            //authorized
            public const string Authorized = "You are not authorized to access the function";
            //authorized assign user
            public const string AuthorizedOrder = "You are not authorized to access this is order";
            //authorized assign user
            public const string AuthorizedRecord = "You are not authorized to access this is record";

            //Customer
            public const string CustomerSuccessToCreate = "This customer has been create successfully";
            public const string CustomerSuccessToUpdate = "This customer has been update successfully";

            //Creditor
            public const string CreditorSuccessToCreate = "This creditor has been create successfully";
            public const string CreditorSuccessToUpdate = "This creditor has been update successfully";
            public const string CreditorBeingUsed = "Creditor are being used";

            //Debtor
            public const string DebtorSuccessToCreate = "This debtor has been create successfully";
            public const string DebtorSuccessToUpdate = "This debtor has been update successfully";
            public const string DebtorBeingUsed = "Debtor are being used";

            //User
            public const string UserSuccessToCreate = "This user has been create successfully";
            public const string UserSuccessToUpdate = "This user has been update successfully";
            public const string UserCanNotDelete = "The user has been assigned to case. Can not delete";
            public const string UserPassSuccessToUpdate = "This password has been update successfully";
            public const string UserPassFailToUpdate = "This password has been update unsuccessfully";

            // Currency
            public const string CurrencySuccessToCreate = "This currency has been create successfully";
            public const string CurrencySuccessToUpdate = "This currency has been update successfully";
            public const string CurrencyIsExists = "Currency is existed";
            public const string CurrencyIsNotExists = "Currency is not existed";
            public const string CurrencyCannotDelete = "This currency has been used, cannot be deleted";

            // UserGroup
            public const string UserGroupSuccessToCreate = "This user group has been create successfully";
            public const string UserGroupSuccessToUpdate = "This user group has been update successfully";
            public const string UserGroupIsNotExists = "User group is not existed";

            // Permissions
            public const string PermissionsSuccessToCreate = "This permissions has been create successfully";
            public const string PermissionsSuccessToUpdate = "This permissions has been update successfully";
            public const string PermissionsFailToUpdate = "This permissions has been update unsuccessfully";
            public const string PermissionsIsNotExists = "Permissions is not existed";

            //Setting
            public const string EmailSuccessToUpdate = "This email account has been update successfully";
            public const string EmailTemplateResetPassword = "This email template reset password has been update successfully";
        }

        public class TempDataKey
        {
            public const string Success = "SUCCESS";
            public const string Error = "ERROR";
        }

        public class LogType
        {
            public const string Insert = "INSERT";
            public const string Update = "UPDATE";
            public const string Delete = "DELETE";
            public const string Search = "SEARCH";
            public const string SendEmail = "SENDEMAIL";
        }

        public class ResourceType
        {
            public const string Admin = "ADMIN";
            public const string Api = "API";
        }

        public class MessageLog
        {
            public const string Insert = "Insert {0}: {1}";
            public const string Update = "Update {0}: {1}";
            public const string Delete = "Delete {0}: {1}";
            public const string SendEmail = "Send email {0}: {1}";
        }

        public class AppSettings
        {
            public const string FolderEmailTemplates = "AppSettings:FolderEmailTemplates";
            public const string EmailTemplateResetPassword = "AppSettings:EmailTemplateResetPassword";
            public const string SubjectEmailResetPassword = "AppSettings:SubjectEmailResetPassword";
        }

        public class MailMergeKeyword
        {
            public const string Day = "{Day}";
            public const string Month = "{Month}";
            public const string Year = "{Year}";
            public const string Title = "{Title}";
            public const string Description = "{Description}";
            public const string Url = "{Url}";
            public const string Header = "{Header}";
            public const string Content = "{Content}";
            public const string Password = "{Password}";
            public const string FullName = "{FullName}";
            public const string UserName = "{UserName}";
            public const string Email = "{Email}";
        }

        public class TitleNotification
        {
            public const string CREATE_INVOICE = "Create Invoice";
            public const string REMIND_NOTIFICATION = "Remind";
        }

        public class OrderDetailAction
        {
            public const string Call = "CALL";
            public const string Email = "EMAIL";
            public const string Directly_Meeting = "DIRECTLY_MEETING";
        }

        public class HttpResponseStatus
        {
            public const string Success = "Success";
            public const string Error = "Error";
            public const string Authorized = "Authorized";
        }
    }
}
