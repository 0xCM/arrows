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
        Index<AppMsg> Flush(params AppMsg[] addenda);

    }

    public readonly struct Timing
    {
        [MethodImpl(Inline)]
        public static Timing Start(string Title)
            => new Timing(Title);
        
        [MethodImpl(Inline)]
        public Timing(string Title)
        {
            this.Title = Title;
            this.Stopwatch = stopwatch();
        }
        
        public readonly string Title;

        public readonly Stopwatch Stopwatch;
    }

    public abstract class Context<T> : IContext
    {                
        protected IRandomizer Random {get;}

        List<AppMsg> Messages {get;} = new List<AppMsg>();


        public Index<AppMsg> Flush(params AppMsg[] addenda)
        {
            Messages.AddRange(addenda);
            var messages = Messages.ToIndex();
            Messages.Clear();
            return messages;
        }

        public void Emit(params AppMsg[] addenda)
        {
            var messages = Flush(addenda);
            print(messages);
            log(messages, LogTarget.TestLog);

        }

        /// <summary>
        /// Constructs a context-specific/local randomizer that should not be shared across threads
        /// </summary>
        /// <typeparam name="R">The primal type</typeparam>
        protected IRandomizer<R> Randomizer<R>()
            where R : struct, IEquatable<R>
            => Random.Primal<R>();
        
        public IEnumerable<R> RandomStream<R>(Interval<R> domain, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                 => filter != null 
                 ? Randomizer<R>().stream(domain).Where(filter) 
                 : Randomizer<R>().stream(domain);

        public IEnumerable<bit> RandomBits()
            => Random.bits();

        protected Vector<N,R> RandomVector<N,R>(Interval<R> domain, Func<R,bool> filter = null)
            where N : TypeNat, new()
            where R : struct, IEquatable<R>
                => vector<N,R>(RandomStream(domain,filter).Take(nati<N>()));

        protected IEnumerable<Vector<N,R>> RandomVectors<N,R>(Interval<R> domain, Func<R,bool> filter = null)
            where N : TypeNat, new()
            where R : struct, IEquatable<R>
        {
            var stream = RandomStream(domain,filter);
            while(true)
                yield return vector<N,R>(stream.Take(nati<N>()));
        }

        public Index<R> RandomIndex<R>(Interval<R> domain, int count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => RandomStream(domain,filter).Freeze(count);

        public Index<R> RandomIndex<R>(Interval<R> domain, uint count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => RandomStream(domain,filter).Freeze(count);

        public Index<R> RandomIndex<R>(uint count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => RandomStream(Defaults.get<R>().Domain,filter).Freeze(count);

        public R[] RandomArray<R>(Interval<R> domain, int count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => RandomStream(domain,filter).TakeArray(count);

        public R[] RandomArray<R>(Interval<R> domain, uint count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => RandomStream(domain,filter).TakeArray((int)count);

        public R[] RandomArray<R>(int count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => RandomStream(Defaults.get<R>().Domain,filter).TakeArray((int)count);

        public R[] RandomArray<R>(uint count, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
                => RandomStream(Defaults.get<R>().Domain,filter).TakeArray((int)count);

        public IEnumerable<R[]> RandomArrays<R>(Interval<R> domain, int len, Func<R,bool> filter = null)
            where R : struct, IEquatable<R>
        {
            while(true)
                yield return RandomArray<R>(domain,len,filter);
        }
        
        protected Context(ulong[] seed)
            => Random = Z0.Randomizer.define(seed);

        protected void hilite(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.HiliteCL, GetType().DisplayName() + caller));            

        protected Timing begin(string title)
        {
            Emit(AppMsg.Define($"{title} begin".PadRight(25), SeverityLevel.HiliteCL, string.Empty));            
            return Timing.Start(title);
        }

        [MethodImpl(Inline)]
        protected Duration end(Timing timing)
        {
            var duration = Duration.define(elapsed(timing.Stopwatch));
            Emit(AppMsg.Define($"{timing.Title} end".PadRight(25) + $"| Duration = {duration}", SeverityLevel.HiliteML, string.Empty));
            return duration;
        }
    
        protected void trace(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.Info, GetType().DisplayName() + caller));            


    }   
}