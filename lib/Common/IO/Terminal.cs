//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Reflection;


using Z0;
using static Z0.Bibliography;
using static zcore;
using static Z0.Traits;
using static Z0.ReflectionFlags;

partial class zcore
{

    public class Terminal
    {
        object locker = new object();

        public void WriteLine(object src)
        {
            lock(locker)
                Console.WriteLine(src);
        }
             

        public void WriteLine()
        {
            lock(locker)
                Console.WriteLine();
        }
            
    
        public void Write(object src)
        {
            lock(locker)
                Console.Write(src);

        }

        public void WriteLine<T>(IEnumerable<T> items, string sep = ",")
        {
            lock(locker)
            {
                var written = false;
                foreach(var item in items)
                {
                    if(!written)
                        written = true;
                    else
                        Console.Write(sep);

                    Console.Write($"{item}");
                }
                if(!written)
                    Console.Write(emptyset());            
                Console.WriteLine();
            }
        }

        public void WriteLine(object src, ConsoleColor color)
        {
            lock(locker)
            {
                var fg = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(src);
                Console.ForegroundColor = fg;
            }
        }

        public void WriteMessage(AppMsg msg)
            => WriteLine(msg,ForeColor(msg.Level));
        
        public void WriteMessages(IEnumerable<AppMsg> messages)
        {
            lock(locker)            
            {
                var fg = Console.ForegroundColor;

                foreach(var msg in messages)
                {
                    Console.ForegroundColor = ForeColor(msg.Level);
                    Console.WriteLine(msg);
                }
                
                Console.ForegroundColor = fg;
            }            
        }

        public string ReadLine()
            => Console.ReadLine();

        static ConsoleColor ForeColor(SeverityLevel level)
            => (ConsoleColor)level;
    }

    static readonly Terminal terminal = new Terminal();


    /// <summary>
    /// Renders the supplied value to the console with no carriage return
    /// </summary>
    /// <param name="x"></param>
    [MethodImpl(Inline)]   
    public static void write(object x)
        => terminal.Write(x);


    /// <summary>
    /// Prints a sequence of messages in an unbroken block
    /// </summary>
    /// <param name="messages">The messages to print</param>    
    public static void print(IEnumerable<AppMsg> messages)
        => terminal.WriteMessages(messages);

    public static string read()
        => terminal.ReadLine();

    /// <summary>
    /// Emits an information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void inform(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Info, caller));

    /// <summary>
    /// Emits a highlighted information-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void hilite(object msg, SeverityLevel? level = null,  [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, level ?? SeverityLevel.HiliteBL, caller));

    /// <summary>
    /// Emits a verbose-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void babble(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Verbose, caller));

    /// <summary>
    /// Emits an error-level message
    /// </summary>
    /// <param name="msg">The message to emit</param>
    /// <param name="caller">The calling member</param>
    public static void error(object msg, [CallerMemberName] string caller = null)
        => terminal.WriteMessage(
                AppMsg.Define(msg?.ToString() ?? string.Empty, SeverityLevel.Error, caller));
}