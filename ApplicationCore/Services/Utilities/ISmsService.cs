using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Services.Utilities
{
    public interface ISmsService
    {
        bool Send(IEnumerable<string> numbers, string title, string message);
    }
}
