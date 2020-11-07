using ApplicationCore.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Utilities
{
    public class SmsService : ISmsService
    {
        public bool Send(IEnumerable<string> numbers, string title, string message)
        {
            throw new NotImplementedException();
        }
    }
}
