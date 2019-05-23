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

    /// <summary>
    /// Implments a thread-safe/thread-aware terminal absraction
    /// </summary>
    public class Terminal
    {
        public static Terminal Get()
            => TheOnly;
        
        static readonly Terminal TheOnly = new Terminal();
        
        readonly object locker;
     
        private Terminal()
            => locker = new object();

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
}
