//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static zcore;

    public abstract class Context<T>
    {                
        IRandomizer Randomizer {get;}

        List<AppMsg> Messages {get;} = new List<AppMsg>();


        /// <summary>
        /// Constructs a context-specific/local randomizer that should not be shared across threads
        /// </summary>
        /// <typeparam name="R">The primal type</typeparam>
        public IRandom<R> Random<R>()
            where R : struct, IEquatable<R>
            => Randomizer.Primal<R>();
        
        public IEnumerable<R> Rand<R>(R min, R max)
            where R : struct, IEquatable<R>
                => Random<R>().stream(min,max);

        public IEnumerable<R> Rand<R>(Interval<R> domain)
            where R : struct, IEquatable<R>
                => Rand(domain.left,domain.right);

        public R[] RandArray<R>(R min, R max, int len)
            where R : struct, IEquatable<R>
                => Rand(min,max).TakeArray(len);

        public R[] RandArray<R>(Interval<R> domain, int len)
            where R : struct, IEquatable<R>
                => Rand(domain).TakeArray(len);

        public IEnumerable<R[]> RandArrays<R>(R min, R max, int len)
            where R : struct, IEquatable<R>
        {
            while(true)
                yield return RandArray<R>(min,max,len);
        }

        protected Context(ulong[] seed)
        {
            Randomizer = Z0.Randomizer.define(seed);
        }

        protected Stopwatch begin(string msg, [CallerMemberName] string caller = null)
        {
            Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, GetType().DisplayName() + caller));            
            return stopwatch();
        }

        protected long end(string msg, Stopwatch sw, [CallerMemberName] string caller = null)
        {
            var ms = sw.ElapsedMilliseconds;
            Messages.Add(AppMsg.Define(msg + $" ({ms}ms)", SeverityLevel.HiliteML, GetType().DisplayName() + caller));            
            return ms;
        }

        protected void trace(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.Info, GetType().DisplayName() + caller));            

        protected Index<AppMsg> DequeueMessages()
        {
            var messages = Messages.ToIndex();
            Messages.Clear();
            return messages;
        }

        protected void PrintMsgQueue()
            => print(DequeueMessages());
    }   
}