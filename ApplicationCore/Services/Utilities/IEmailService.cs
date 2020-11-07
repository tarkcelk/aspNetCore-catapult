using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Services.Utilities
{
    public interface IEmailService
    {
         bool Send(IEnumerable<string> emails, string subject, string body);
    }
}
