using System;

namespace Interfaces.Repository
{
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}