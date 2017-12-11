using System;

namespace TakipSistemi.Components.Logging
{
    public interface ILogger
    {
        void Log(String message);
        void Log(Exception exception);
    }
}
