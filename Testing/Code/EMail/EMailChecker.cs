using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Code.EMail
{
    /// <summary>
    /// Email validation functionality
    /// </summary>
    public class EMailChecker
    {
        /// <summary>
        /// Is an email valid?
        /// </summary>
        /// <param name="email">The email to check</param>
        /// <returns>If the email is valid or not</returns>
        public Boolean Valid(String email)
        { 
            try
            {
                // If this fails it can't be real
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch { }

            return false;
        }
    }
}
