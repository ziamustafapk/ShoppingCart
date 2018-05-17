using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Web;

namespace ZeMShoppingCart.ExceptionManager
{
    public class CustomExceptions : Exception, ICustomExceptions
    {
        #region Constructor
        public CustomExceptions()
        {

        }
        public CustomExceptions(string message)
                : base(message)
        {

        }
        public CustomExceptions(Exception innerException)
                : base(innerException.Message, innerException)
        {

        }

        #endregion

        #region Interface Methods
        void ICustomExceptions.WriteExceptionMessageToFile(Exception exception)
        {
            WriteExceptionMessageToFile(exception);
        }
        #endregion

        #region Static Methods
        public static void WriteExceptionMessageToFile(Exception exception)
        {
            
                string fileName = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["CustomMessageFileName"]);

                StringBuilder errorMessages = new StringBuilder();
                errorMessages.AppendLine("----------------------------------------------" + "\n");
                errorMessages.AppendLine("DateTime : " + DateTime.Now + "\n");
                errorMessages.AppendLine("Message : " + exception.Message + "\n");
                errorMessages.AppendLine("Link : " + exception.HelpLink + "\n");
                errorMessages.AppendLine("InnerException : " + exception.InnerException + "\n");
                errorMessages.AppendLine("Source : " + exception.Source + "\n");
                errorMessages.AppendLine("StackTrace: " + exception.StackTrace);

                errorMessages.AppendLine(HttpContext.Current.User.Identity.Name);
                errorMessages.AppendLine("----------------------------------------------" + "\n");

                if (File.Exists(fileName) && fileName != null)
                {
                    File.AppendAllText(fileName, errorMessages.ToString());
                }
            else
                {
                    if (fileName == null) return;
                    using (var fs = File.Create(fileName))
                    {
                        // Add some text to file
                        var title = new UTF8Encoding(true).GetBytes("File For Bussiness Logic Exceptions");
                        fs.Write(title, 0, title.Length);
                        var author = new UTF8Encoding(true).GetBytes("Zia Mustafa");
                        fs.Write(author, 0, author.Length);
                    }
                    File.AppendAllText(fileName, errorMessages.ToString());
                }



        }
        #endregion

    }
}
