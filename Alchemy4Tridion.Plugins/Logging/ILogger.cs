using System;

namespace Alchemy4Tridion.Plugins.Logging
{
    /// <summary>
    /// Interface for wrapper of logger for the Alchemy4Tridion framework.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a message at the debug level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Zero or more arguments to pass to the log message's format string.</param>
        void Debug(string message, params object[] args);

        /// <summary>
        /// Logs an exception at the debug level.
        /// </summary>
        /// <param name="ex"></param>
        void Debug(Exception ex);

        /// <summary>
        /// Logs a message at the error level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Zero or more arguments to pass to the log message's format string.</param>
        void Error(string message, params object[] args);

        /// <summary>
        /// Logs an exception at the error level.
        /// </summary>
        /// <param name="ex"></param>
        void Error(Exception ex);

        /// <summary>
        /// Logs a message at the fatal level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Zero or more arguments to pass to the log message's format string.</param>
        void Fatal(string message, params object[] args);

        /// <summary>
        /// Logs an exception at the fatal level.
        /// </summary>
        /// <param name="ex"></param>
        void Fatal(Exception ex);

        /// <summary>
        /// Logs a message at the info level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Zero or more arguments to pass to the log message's format string.</param>
        void Info(string message, params object[] args);

        /// <summary>
        /// Logs a message at the info level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Info(string message);

        /// <summary>
        /// Logs a message at the warning level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Zero or more arguments to pass to the log message's format string.</param>
        void Warn(string message, params object[] args);

        /// <summary>
        /// Logs an exception at the warning level.
        /// </summary>
        /// <param name="ex"></param>
        void Warn(Exception ex);


        /// <summary>
        /// Logs a message at the audit level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Zero or more arguments to pass to the log message's format string.</param>
        void Audit(string message, params object[] args);

        /// <summary>
        /// Logs an exception at the audit level.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Audit(string message);

        bool IsDebugEnabled { get; }

    }
}
