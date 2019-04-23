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
    using System.Linq;

    using static zcore;

    public interface IContext
    {
        Index<AppMsg> FlushMessages();

    }

    public abstract class Context<T> : IContext
    {                
        protected IRandomizer Random {get;}

        List<AppMsg> Messages {get;} = new List<AppMsg>();

        /// <summary>
        /// Constructs a context-specific/local randomizer that should not be shared across threads
        /// </summary>
        /// <typeparam name="R">The primal type</typeparam>
        protected IRandomizer<R> Randomizer<R>()
            where R : struct, IEquatable<R>
            => Random.Primal<R>();
        
        public IEnumerable<R> RandomStream<R>(Interval<R> domain)
            where R : struct, IEquatable<R>
                => Randomizer<R>().stream(domain);
        
        public IEnumerable<bit> RandomBits()
            => Random.bits();

        protected Vector<N,R> RandomVector<N,R>(Interval<R> domain)
            where N : TypeNat, new()
            where R : struct, IEquatable<R>
                => vector<N,R>(RandomStream(domain).Take(nati<N>()));

        protected IEnumerable<Vector<N,R>> RandomVectors<N,R>(Interval<R> domain)
            where N : TypeNat, new()
            where R : struct, IEquatable<R>
        {
            var stream = RandomStream(domain);
            while(true)
                yield return vector<N,R>(stream.Take(nati<N>()));
        }

        public Index<R> RandomIndex<R>(Interval<R> domain, int count)
            where R : struct, IEquatable<R>
                => RandomStream(domain).Freeze(count);

        public Index<R> RandomIndex<R>(Interval<R> domain, uint count)
            where R : struct, IEquatable<R>
                => RandomStream(domain).Freeze(count);

        public R[] RandomArray<R>(Interval<R> domain, int count)
            where R : struct, IEquatable<R>
                => RandomStream(domain).TakeArray(count);

        public IEnumerable<R[]> RandomArrays<R>(Interval<R> domain, int len)
            where R : struct, IEquatable<R>
        {
            while(true)
                yield return RandomArray<R>(domain,len);
        }
        
        protected Context(ulong[] seed)
            => Random = Z0.Randomizer.define(seed);

        protected void hilite(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, GetType().DisplayName() + caller));            

        protected Stopwatch begin(string msg, [CallerMemberName] string caller = null)
        {
            Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, GetType().DisplayName() + caller));            
            return stopwatch();
        }

        protected long end(string msg, Stopwatch sw, [CallerMemberName] string caller = null)
        {
            var ms = sw.ElapsedMilliseconds;
            Messages.Add(AppMsg.Define(msg + $" | Duration = {elapsed(sw)}ms", SeverityLevel.HiliteML, GetType().DisplayName() + caller));            
            return ms;
        }

        protected void end(string msg, long duration, [CallerMemberName] string caller = null)
        {
            Messages.Add(AppMsg.Define(msg + $" | Duration = {duration}ms", SeverityLevel.HiliteML, GetType().DisplayName() + caller));            
        }

        protected void trace(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.Info, GetType().DisplayName() + caller));            

        public Index<AppMsg> FlushMessages()
        {
            var messages = Messages.ToIndex();
            Messages.Clear();
            return messages;
        }

    }   
}