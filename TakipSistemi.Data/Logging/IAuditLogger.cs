using Microsoft.EntityFrameworkCore.ChangeTracking;
using TakipSistemi.Objects;
using System;
using System.Collections.Generic;

namespace TakipSistemi.Data.Logging
{
    public interface IAuditLogger : IDisposable
    {
        void Log(IEnumerable<EntityEntry<BaseModel>> entries);
        void Save();
    }
}
