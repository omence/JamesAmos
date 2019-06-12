using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamesAmos.Models.Interfaces
{
    public interface IEmail
    {
        Task SendEmail(string email, string subject, string message);
    }
}
