using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace Cashflow.Api.Service
{
    public class LogService
    {
        private ILog _log;

        public LogService()
        {
            _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            XmlConfigurator.Configure(LogManager.GetRepository(Assembly.GetEntryAssembly()), new FileInfo("log4net.config"));
        }

        public void Debug(string message) => _log.Debug(message);

        public void Info(string message) => _log.Info(message);

        public void Error(string message) => _log.Error(message);
    }
}