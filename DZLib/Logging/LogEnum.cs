using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EloBuddy; 
using LeagueSharp.Common; 
 namespace DZLib.Logging
{
    /// <summary>
    /// The Log Severity enum
    /// </summary>
    [DefaultValue(Medium)]
    public enum LogSeverity
    {
        Warning, Error, Low, Medium, Severe
    }
}
