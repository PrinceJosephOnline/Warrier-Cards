using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using RTEC.Utilities.Diagnostics;
using System.Configuration;
using System.Collections.Specialized;

namespace Warriers.Framework
{
    /// <summary>
    /// This singleton class wraps the RMS the logger
    /// </summary>
    public class Logger
    {
        #region Member Variables

        /// <summary>
        /// class referred for the logging method.
        /// </summary>
        //private static CSystemDiagnosticsAgent SystemDiagnosticsAgent;

        /// <summary>
        /// static Logger instance
        /// </summary>
        static private Logger RTECLogger = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance of Logger class
        /// </summary>
        private Logger()
        {
            InitializeDiagnosticsAgent();
        }

        #endregion

        #region Enums

        /// This enumerator is corresponds to the enumerator named 'DiagnosticsLevels' in the CSystemDiagnosticsAgent class.
        /// This enumerator is kept in this class to avoid the reference of RTEC.Diagnostics.dll in all projects where 
        /// the Logger is implemented and the DiagnosticsLevels enumerator is used. Important thing to be noted is 
        /// that when a change applied to the enumerator named DiagnosticsLevels from CSystemDiagnosticsAgent class 
        /// is modified that modification must be done in this enumerator (LogLevel) also. 
        /// ie.Both enumerator members must be same. 
        /// </summary>
        public enum LogLevel
        {
            Error = -1,
            Zero = 0,
            Basic = 1,
            Normal = 2,
            Lownormal = 3,
            Warnings = 4,
            Lowwarnings = 5,
            Highwarnings = 6,
            Info = 7,
            Verbose1 = 8,
            Verbose2 = 9,
            Verbose3 = 10,
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// This method gets a singleton object of Logger class
        /// </summary>
        /// <returns></returns>
        public static Logger Instance()
        {
            if (RTECLogger == null)
            {
                RTECLogger = new Logger();
            }
            return RTECLogger;
        }

        /// <summary>
        /// This method Log data into file
        /// </summary>
        /// <param name="Module">name of module</param>
        /// <param name="data">message to log</param>
        /// <param name="loglevel">type of message - error, info etc.</param>
        public void Log(string module, string data, LogLevel loglevel)
        {
            //if (SystemDiagnosticsAgent != null)
            //{
            //    SystemDiagnosticsAgent.Log(module, data, (DiagnosticsLevels)loglevel);
            //}
        }

        /// <summary>
        /// This method Log data into file
        /// </summary>
        /// <param name="Module">name of module</param>
        /// <param name="data">message to log</param>
        /// <param name="loglevel">type of message - error, info etc.</param>
        public void Log(string module, LogLevel loglevel, string logFormat, params object [] args)
        {
            //if (SystemDiagnosticsAgent != null)
            //{
            //    SystemDiagnosticsAgent.Log(module, string.Format(logFormat, args), (DiagnosticsLevels)loglevel);
            //}
        }

        /// <summary>
        /// This method logs an Exception into file
        /// </summary>
        /// <param name="Module">name of module</param>
        /// <param name="exceptionData">exception to log</param>
        public void Log(string module, Exception exceptionData)
        {
            //if (SystemDiagnosticsAgent != null)
            //{
            //    SystemDiagnosticsAgent.Log(module, exceptionData.ToString(), DiagnosticsLevels.DIAGS_LEVEL_ERROR);
            //}
        }

        /// <summary>
        /// This method logs string and an error code
        /// </summary>
        /// <param name="module">name of the module</param>
        /// <param name="errorCode">error code to be displayed in the logger message</param>
        /// <param name="data">data information of the error to be displayed in the logger message</param>
        /// <param name="loglevel">Log level to show the severity</param>
        public void Log(string module, long errorCode, String data, LogLevel loglevel)
        {
            //SystemDiagnosticsAgent.Log(module, errorCode, data, (DiagnosticsLevels)loglevel);
        }

        /// <summary>
        /// This method logs an error code
        /// </summary>
        /// <param name="Module">Name of the module</param>
        /// <param name="errorCode">error code to be displayed in the logger message</param>
        /// <param name="loglevel">Log level to show the severity</param>
        public void Log(string module, long errorCode, LogLevel loglevel)
        {
            //SystemDiagnosticsAgent.Log(module, errorCode, (DiagnosticsLevels)loglevel);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Method to initialize Diagnostic agent propertied related to logging. Read the configuration 
        /// file to get the properties to assign for initialization.
        /// </summary>
        private void InitializeDiagnosticsAgent()
        {

            //SystemDiagnosticsAgent = new CSystemDiagnosticsAgent(DiagnosticsOptions.LOGTO_EVENTLOG |
            //                                                     DiagnosticsOptions.LOGTO_FILE |
            //                                                     DiagnosticsOptions.LOGFILE_ROLLOVER |
            //                                                     DiagnosticsOptions.LOGTO_TRACERS);
            //SystemDiagnosticsAgent.Enable = true;
            //var section = ConfigurationManager.GetSection(@"RTECLogger/Diagnostics") as NameValueCollection;
            //if (section != null)
            //{
            //    int diagnosticsLevel = Convert.ToInt32(section["DiagnosticsLevel"]);
            //    SystemDiagnosticsAgent.DiagnosticsLevel = (DiagnosticsLevels)diagnosticsLevel;
            //    if (!string.IsNullOrEmpty(section["DiagnosticsFile"]))
            //    {
            //        SystemDiagnosticsAgent.Filename = section["DiagnosticsFile"];
            //    }
            //}
            //if (string.IsNullOrEmpty(SystemDiagnosticsAgent.Filename))
            //{
            //    SystemDiagnosticsAgent.Filename = "RTEC.Misc_.log";
            //    SystemDiagnosticsAgent.DiagnosticsLevel = DiagnosticsLevels.DIAGS_LEVEL_VERBOSE3;
            //}

            //SystemDiagnosticsAgent.Open();
        }

        #endregion
    }
}
