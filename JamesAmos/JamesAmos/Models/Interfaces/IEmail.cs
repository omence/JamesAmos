using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamesAmos.Models.Interfaces
{
    public interface IEmail
    {
        /// <summary>
        /// sends users message via email to admin
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendEmail(string email, string subject, string message);
    }
}
