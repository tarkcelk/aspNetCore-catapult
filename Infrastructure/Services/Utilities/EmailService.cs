using ApplicationCore.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Utilities
{
    public class EmailService : IEmailService
    {
        public bool Send(IEnumerable<string> emails, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
