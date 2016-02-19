using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Text;

namespace Common
{
    /// <summary>
    /// 日志操作
    /// </summary>
    public class CommonLogHelper
    {
        private static readonly object Lock = new object();

        private static CommonLogHelper _instance;

        /// <summary>
        /// The m_ logger
        /// </summary>
        private readonly Logger _mLogger;

        /// <summary>
        /// Prevents a default instance of the <see cref="CommonLogHelper"/> class from being created.
        /// </summary>
        private CommonLogHelper()
        {
            InitConfig();
            _mLogger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonLogHelper"/> class.
        /// </summary>
        /// <param name="loggerName">Name of the logger.</param>
        private CommonLogHelper(string loggerName)
        {
            InitConfig();
            _mLogger = LogManager.GetLogger(loggerName);
        }

        /// <summary>
        /// 生成自定义异常消息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>
        /// <returns>异常字符串文本</returns>
        public static string GetExceptionMsg(Exception ex, string backStr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************异常文本****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            if (ex != null)
            {
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
                sb.AppendLine("【堆栈调用】：" + ex.StackTrace);

                if (ex.InnerException != null)
                {
                    sb.AppendLine("【内部异常】：");
                    sb.AppendLine("【内部异常类型】：" + ex.InnerException.GetType().Name);
                    sb.AppendLine("【内部异常信息】：" + ex.InnerException.Message);
                    sb.AppendLine("【内部堆栈调用】：" + ex.InnerException.StackTrace);
                }
            }
            else
            {
                sb.AppendLine("【未处理异常】：" + backStr);
            }
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>LogHelper.</returns>
        public static CommonLogHelper GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CommonLogHelper();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="loggerName">Name of the logger.</param>
        /// <returns>LogHelper.</returns>
        public static CommonLogHelper GetInstance(string loggerName)
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CommonLogHelper(loggerName);
                    }
                }
            }
            return _instance;
        }

        private void InitConfig()
        {
            try
            {           
                LoggingConfiguration config = new LoggingConfiguration();
                FileTarget fileTarget = new FileTarget
                {
                    FileName = "${basedir}/Log/${shortdate}/${level}${shortdate}.log"
                };
                config.AddTarget("Log", fileTarget);
                LoggingRule rule = new LoggingRule("*", LogLevel.Trace, fileTarget);
                config.LoggingRules.Add(rule);
                LogManager.Configuration = config;
            }
            catch
            {
                throw;
            }
        }

        #region Log Content

        public bool IsDebugEnabled => _mLogger.IsDebugEnabled;

        public bool IsErrorEnabled => _mLogger.IsErrorEnabled;

        public bool IsFatalEnabled => _mLogger.IsFatalEnabled;

        public bool IsInfoEnabled => _mLogger.IsInfoEnabled;

        public bool IsTraceEnabled => _mLogger.IsTraceEnabled;

        public bool IsWarnEnabled => _mLogger.IsWarnEnabled;

        /// <summary>
        /// Debugs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            if (_mLogger.IsDebugEnabled)
                _mLogger.Debug(message);
        }

        /// <summary>
        /// Debugs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The executable.</param>
        public void Debug(string message, Exception ex)
        {
            _mLogger.Debug(message);
        }

        /// <summary>
        /// Debugs the exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The executable.</param>
        [Obsolete]
        public void DebugException(string message, Exception ex)
        {
            if (_mLogger.IsDebugEnabled)
                _mLogger.DebugException(message, ex);
        }

        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
            _mLogger.Error(message);
        }

        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The executable.</param>
        public void Error(string message, Exception ex)
        {
            _mLogger.Error(message + "" + Environment.NewLine + ex.Message + "" + Environment.NewLine + ex.StackTrace);
        }

        public void Fatal(string message)
        {
            if (_mLogger.IsFatalEnabled)
                _mLogger.Fatal(message);
        }

        /// <summary>
        /// Info Message
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            _mLogger.Info(message);
        }

        /// <summary>
        /// Warns the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warn(string message)
        {
            if (_mLogger.IsWarnEnabled)
                _mLogger.Warn(message);
        }

        #endregion Log Content
    }
}