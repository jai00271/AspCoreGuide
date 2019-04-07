namespace LoggerService
{
    using NLog;

    public class LoggerManager : ILoggerManager
    {
        /// <summary>
        /// you need to install the NLog.Extensions.Logging library in our LoggerService project. 
        /// NLog is logging platform for the .NET which will help us create and log our massages.
        /// </summary>
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// NLog needs to have information about the folder to create log files in, what the name of these files will be and what a minimum level of logging is. 
        /// Therefore, you need to create one text file in the main project with the name nlog.config and to populate it as in the example below.
        /// </summary>
        public LoggerManager()
        {
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}