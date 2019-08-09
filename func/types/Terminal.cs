//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices; 
    using System.Text;

    /// <summary>
    /// Implments a thread-safe/thread-aware terminal absraction
    /// </summary>
    public class Terminal
    {
        public static Terminal Get()
            => TheOnly;
        
        static readonly Terminal TheOnly = new Terminal();
        
        readonly object locker;
     
        Option<Action> TerminationHandler;

        private Terminal()
        {
             locker = new object();
             Console.OutputEncoding = new UnicodeEncoding();      
             Console.CancelKeyPress += OnCancelKeyPressed;        
        }

        /// <summary>
        /// Specfifies the handler to invoke when the user enters a cancellation
        /// command, such as Ctrl+C
        /// </summary>
        /// <param name="handler">The handler to invoke when a termination command is received</param>
        public void SetTerminationHandler(Action handler)
            => TerminationHandler = handler;

        private void OnCancelKeyPressed(object sender, ConsoleCancelEventArgs args)
            => TerminationHandler.OnSome(h => h());

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
        
        public void WriteLine<T>(IEnumerable<T> items, string sep)
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
                    Console.Write("∅");            
                Console.WriteLine();
            }
        }

        public void WriteLine(object src, SeverityLevel level)
            => WriteLine(src, (ConsoleColor)level);
            
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

        void WriteError(object src, ConsoleColor color)
        {
            lock(locker)
            {
                var fg = Console.ForegroundColor;
                Console.ForegroundColor = color;                
                Console.Error.Write(src);
                Console.Error.Write(zfunc.eol());
                Console.ForegroundColor = fg;
            }

        }

        public void WriteError(AppMsg msg)
        {
            lock(locker)
            {
                var fg = Console.ForegroundColor;
                Console.ForegroundColor = ForeColor(msg.Level);                
                Console.Error.Write(msg);
                Console.Error.Write(zfunc.eol());
                Console.ForegroundColor = fg;
            }

        }


        public void Write(object src, ConsoleColor color)
        {
            lock(locker)
            {
                var fg = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(src);
                Console.ForegroundColor = fg;
            }
        }

        public void WriteMessage(AppMsg msg, bool cr = true)
        {   
            if(msg.Level == SeverityLevel.Error)
                WriteError(msg, ForeColor(msg.Level));
            else
            {
                if(cr)
                    WriteLine(msg, ForeColor(msg.Level)); 
                else
                    Write(msg, ForeColor(msg.Level));
            }
        }
                                
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

        public string ReadLine(AppMsg msg = null)
        {
             if(msg != null)
                WriteMessage(msg,false);
             return Console.ReadLine();
        }

        public char ReadKey(AppMsg msg = null)
        {
             if(msg != null)
                WriteMessage(msg,false);
              
            return Console.ReadKey().KeyChar;
        }

        static ConsoleColor ForeColor(SeverityLevel level)
            => (ConsoleColor)level;
    }
}
