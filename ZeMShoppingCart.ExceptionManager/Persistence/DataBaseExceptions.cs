using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Web;

namespace ZeMShoppingCart.ExceptionManager
{
    public class DataBaseExceptions : Exception, IDataBaseExceptions
    {
        #region Constructor
        public DataBaseExceptions()
        {

        }
        public DataBaseExceptions(string message)
                : base(message)
        {

        }
        public DataBaseExceptions( Exception innerException)
                : base(innerException.Message, innerException)
        {

        }

        #endregion

        #region Interface Methods
        void IDataBaseExceptions.WriteExceptionMessageToFile( Exception exception)
        {
            WriteExceptionMessageToFile(exception);
        }
        #endregion

        #region Static Methods
        public static void WriteExceptionMessageToFile(Exception exception)
        {

            var fileName = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["DataBaseExceptionFileName"]);
               
                var errorMessages = new StringBuilder();
                errorMessages.AppendLine("----------------------------------------------" + "\n");
                errorMessages.AppendLine("DateTime : " + DateTime.Now + "\n");
                errorMessages.AppendLine("Message : " + exception.Message + "\n");
                errorMessages.AppendLine("Link : " + exception.HelpLink + "\n");
                errorMessages.AppendLine("InnerException : " + exception.InnerException + "\n");
                errorMessages.AppendLine(HttpContext.Current.User.Identity.Name);
                errorMessages.AppendLine("StackTrace: " + exception.StackTrace);
                errorMessages.AppendLine("----------------------------------------------" + "\n");

                if (File.Exists(fileName) && fileName != null)
                {
                    File.AppendAllText(fileName, errorMessages.ToString());
            }
                else
                {
                    if (fileName == null) return;
                    using (FileStream fs = File.Create(fileName))
                    {
                        // Add some text to file
                        var title = new UTF8Encoding(true).GetBytes("File For Database Exceptions\n");
                        fs.Write(title, 0, title.Length);
                        var author = new UTF8Encoding(true).GetBytes("Zia Mustafa\n");
                        fs.Write(author, 0, author.Length);
                    }
                    File.AppendAllText(fileName, errorMessages.ToString());
                }




        }
        #endregion
    }
}
