//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    using static zfunc;

    public static class PrimalFsm
    {
        /// <summary>
        /// Defines a primal state machine
        /// </summary>
        /// <param name="classifier">An identifier that defines a membership class that is propagaged to all machines predicated on the specification</param>
        /// <param name="states">The number of states the machine will support</param>
        /// <param name="events">The number of events the machine will recognize</param>
        /// <param name="minSamples">The minimum number of events that will be sampled for each state</param>
        /// <param name="maxSamples">The maximum number of events that will be sampled for each state</param>
        /// <param name="maxReceipts">The maximum number of events that the machine will accept</param>
        /// <typeparam name="T">A scalar type of sufficient size to accomodate specified characteristics</typeparam>
        public static PrimalFsmSpec<T> Specify<T>(string classifier, T states, T events, T minSamples, T maxSamples, ulong maxReceipts)
            where T : unmanaged
                => new PrimalFsmSpec<T>(classifier, states, events, minSamples, maxSamples, maxReceipts);

        /// <summary>
        /// Creates a primal FSM according to a supplied spec with a specified random seed and stream index
        /// </summary>
        /// <param name="spec">The FSM definition</param>
        /// <param name="seed">The rng seed</param>
        /// <param name="index">The rng stream index</param>
        /// <typeparam name="T">The primal fsm type</typeparam>
        public static Fsm<T,T> Create<T>(PrimalFsmSpec<T> spec, ulong seed, ulong index)
            where T : unmanaged
        {
            var id = $"{spec.Classifier}-{Interlocked.Increment(ref MachineCounter)}";
            var context = Fsm.CreateContext(RNG.Pcg64(seed, index).ToPolyrand(), spec.ReceiptLimit);
            return Fsm.Machine(id, context, spec.StartState, spec.EndState, Transition(context, spec));
        }

        /// <summary>
        /// Executes one or more primal state machines
        /// </summary>
        /// <param name="spec">The FSM spec that determines machine characteristics </param>
        /// <param name="machineCount">The number of machines to execute</param>
        /// <param name="sequential">Specifies whether the machines will be executed sequentially</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<FsmStats> Run<T>(PrimalFsmSpec<T> spec, int machineCount, bool sequential = false)
            where T : unmanaged
        {
            var seeds = Entropy.Values<ulong>(machineCount);
            var indices = range(0xFFFFul, 0xFFFFFFFFul).Where(x => x % 2 != 0).Take(machineCount).ToArray();
            if(sequential)
                return RunSequential(spec, seeds, indices).Force();
            else
                return RunConcurrent(spec,seeds, indices).Force();
        }

        /// <summary>
        /// Executes the specified machines concurrently
        /// </summary>
        /// <param name="spec">The machine definition</param>
        /// <param name="seeds">The rng seeds that determine initial states of the randomizers</param>
        /// <param name="indices">The rng stream position indices</param>
        /// <typeparam name="T">The primal FSM type</typeparam>
        static IEnumerable<FsmStats> RunConcurrent<T>(PrimalFsmSpec<T> spec, Span<ulong> seeds, Span<ulong> indices)
            where T : unmanaged
        {            
            var stats = new ConcurrentBag<FsmStats>();
            var tasks = new Task[seeds.Length];
            for(var i=0; i< tasks.Length; i++)
            {
                var machine = Create(spec, seeds[i],indices[i]);
                tasks[i] = Fsm.Run(machine).ContinueWith(t => t.Result.OnSome(s => stats.Add(s)));
            }
                
            Task.WaitAll(tasks);
            return stats;
        }

        /// <summary>
        /// Executes the specified machines sequentially
        /// </summary>
        /// <param name="spec">The machine definition</param>
        /// <param name="seeds">The rng seeds that determine initial states of the randomizers</param>
        /// <param name="indices">The rng stream position indices</param>
        /// <typeparam name="T">The primal FSM type</typeparam>
        static IEnumerable<FsmStats> RunSequential<T>(PrimalFsmSpec<T> spec, Span<ulong> seeds, Span<ulong> indices)
            where T : unmanaged
        {
            var stats = new ConcurrentBag<FsmStats>();
            for(var i=0; i< seeds.Length; i++)
            {             
               var machine = Create(spec, seeds[i], indices[i]);
               var result = Fsm.Run(machine).Result;
               result.OnSome(s => stats.Add(s));
            }            
            return stats;
        }

        static MachineTransition<T,T> Transition<T>(IFsmContext context, PrimalFsmSpec<T> spec)        
            where T : unmanaged
        {            
            var sources = range<T>(spec.StateCount).ToArray();
            var random = context.Random;
            var rules = new List<TransitionRule<T,T>>();
            foreach(var source in sources)
            {                                
                var evss = random.Next<T>(spec.MinEventSamples, spec.MaxEventSamples);
                var targets = from t in random.SampleDistinct(spec.StateCount, evss) where gmath.neq(t,source) select t;
                var events = random.SampleDistinct(spec.EventCount, evss);
                rules.AddRange(events.Zip(targets).Select(x => Fsm.TransitionRule(x.First, source, x.Second)));
            }
            return rules.ToFunction();
        }

        static int MachineCounter = 0;


     }
}