using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces.Library
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }
}
