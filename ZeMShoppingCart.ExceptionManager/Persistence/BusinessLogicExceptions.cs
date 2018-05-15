using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ZeMShoppingCart.ExceptionManager
{
    public class BusinessLogicExceptions : Exception, IBusinessLogicExceptions
    {
        #region Constructor
        public BusinessLogicExceptions()
        {

        }
        public BusinessLogicExceptions(string message)
                : base(message)
        {

        }
        public BusinessLogicExceptions( Exception innerException)
                : base(innerException.Message, innerException)
        {

        }

        #endregion

        #region Interface Methods
        void IBusinessLogicExceptions.WriteExceptionMessageToFile(Exception exception)
        {
            WriteExceptionMessageToFile( exception);
        }
        #endregion

        #region Static Methods
        public static void WriteExceptionMessageToFile( Exception exception)
        {
            try
            {
                string fileName = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["BusinessLogicExceptionFileName"]);

                StringBuilder errorMessages = new StringBuilder();
                errorMessages.AppendLine("----------------------------------------------" + "\n");
                errorMessages.AppendLine("DateTime : " + DateTime.Now + "\n");
                errorMessages.AppendLine("Message : " + exception.Message + "\n");
                errorMessages.AppendLine("Link : " + exception.HelpLink + "\n");
                errorMessages.AppendLine("InnerException : " + exception.InnerException + "\n");
                //errorMessages.AppendLine("Source : " + exception.Source + "\n");
                errorMessages.AppendLine("StackTrace: " + exception.StackTrace);

                errorMessages.AppendLine(HttpContext.Current.User.Identity.Name);
                errorMessages.AppendLine("----------------------------------------------" + "\n");

                if (File.Exists(fileName) && fileName != null)
                {
                    File.AppendAllText(fileName, errorMessages.ToString());
                }
            }
            catch (Exception)
            {

                var fileName = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["BusinessLogicExceptionFileName"]);

                var errorMessages = new StringBuilder();
                errorMessages.AppendLine("----------------------------------------------" + "\n");
                errorMessages.AppendLine("DateTime : " + DateTime.Now + "\n");
                errorMessages.AppendLine("Message : " + exception.Message + "\n");
                errorMessages.AppendLine("Link : " + exception.HelpLink + "\n");
                errorMessages.AppendLine("InnerException : " + exception.InnerException + "\n");
                errorMessages.AppendLine("StackTrace: " + exception.StackTrace);
                errorMessages.AppendLine("----------------------------------------------" + "\n");

                if (File.Exists(fileName) && fileName != null)
                {
                    File.AppendAllText(fileName, errorMessages.ToString());
                }
            }

        }
        #endregion

    }
}
