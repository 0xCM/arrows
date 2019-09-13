//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Clasifies application message severities
    /// </summary>
    public enum SeverityLevel
    {   
        /// <summary>
        /// Boring
        /// </summary>
        Unspecified = ConsoleColor.White,
        
        /// <summary>
        /// Identifies chatty content
        /// </summary>
        Babble = ConsoleColor.DarkGray,

        /// <summary>
        /// Identifies iformational content
        /// </summary>
        Info = ConsoleColor.Green,
        
        /// <summary>
        /// Identifies warning content
        /// </summary>
        Warning = ConsoleColor.Yellow,

        /// <summary>
        /// Identifies error content
        /// </summary>
        Error = ConsoleColor.Red,
        
        /// <summary>
        /// Identifies benchmark/timing result
        /// </summary>
        Benchmark = ConsoleColor.Magenta,

        /// <summary>
        /// Dark blue foreground 
        /// </summary>
        HiliteBD = ConsoleColor.DarkBlue,

        /// <summary>
        /// Light blue foreground 
        /// </summary>
        HiliteBL = ConsoleColor.Blue,

        /// <summary>
        /// Dark cyan foreground 
        /// </summary>
        HiliteCD = ConsoleColor.DarkCyan,

        /// <summary>
        /// Cyan foreground 
        /// </summary>
        HiliteCL = ConsoleColor.Cyan,

        /// <summary>
        /// Dark magenta foreground
        /// </summary>
        HiliteMD = ConsoleColor.DarkMagenta,

        /// <summary>
        /// Magenta foreground
        /// </summary>
        HiliteML = ConsoleColor.Magenta,
    }

}