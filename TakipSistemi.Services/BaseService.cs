using TakipSistemi.Data.Core;
using System;

namespace TakipSistemi.Services
{
    public abstract class BaseService : IService
    {
        public Int32 CurrentAccountId { get; set; }
        protected IUnitOfWork UnitOfWork { get; }

        protected BaseService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}
