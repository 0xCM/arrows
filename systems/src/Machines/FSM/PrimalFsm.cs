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
        static IFsmContext CreateContext<T>(this PrimalFsmSpec<T> src, IRandomSource random)
            where T : struct     
                => Fsm.CreateContext(random, src.ReceiptLimit);

        static IEnumerable<T> SampleEvents<T>(this PrimalFsmSpec<T> src, IFsmContext context)
            where T : struct     
        {
            var random = context.Random;
            var count = random.Next<T>(closed(src.MinEventSampleSize, src.MaxEventSampleSize));
            return random.SampleWithoutReplacement(src.EventCount, count);
        }

        static IEnumerable<T> SampleStates<T>(this PrimalFsmSpec<T> src, IFsmContext context, T count, T exclude)
            where T : struct     
        {   
            var random = context.Random;
            return random.SampleWithoutReplacement(src.StateCount, count).Where(s => gmath.neq(s, exclude));
        }

        static IEnumerable<TransitionRule<T,T>> Transitions<T>(this PrimalFsmSpec<T> spec, IFsmContext context)        
            where T : struct
        {            
            var indices = range<T>(spec.StateCount);
            foreach(var source in indices)
            {                
                var events = spec.SampleEvents(context).ToArray();
                var targets = spec.SampleStates(context, convert<int,T>(events.Length), source);
                var rules = events.Zip(targets).Select(x => Fsm.TransitionRule(x.First, source, x.Second));
                foreach(var r in rules)
                    yield return r;
            }
        }

        static int LastMachineId = 0;

        static Fsm<T,T> CreateMachine<T>(this PrimalFsmSpec<T> spec, ulong seed, ulong index)
            where T : struct
        {
            var id = Interlocked.Increment(ref LastMachineId);
            var random = RNG.Pcg64(seed, index);
            var context = spec.CreateContext(random);
            var transF =  spec.Transitions(context).ToFunction();            
            return Fsm.Machine($"{spec.Classifier}-{id}", context, spec.StartState, spec.EndState, transF);
        }

        /// <summary>
        /// Defines and executes a set of machines that conform to a specification
        /// </summary>
        /// <param name="spec">The FSM spec that determines machine characteristics </param>
        /// <param name="machineCount">The number of machines to execute</param>
        /// <param name="sequential">Specifies whether the machines will be executed sequentially</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<FsmStats> Run<T>(this PrimalFsmSpec<T> spec, int machineCount, bool sequential = false)
            where T : struct
        {
            var seeds = Entropy.Values<ulong>(machineCount);
            var indices = range(0xFFFFul, 0xFFFFFFFFul).Where(x => x % 2 != 0).Take(machineCount).ToArray();
            var stats = new ConcurrentBag<FsmStats>();
            if(sequential)
            {
                for(var i=0; i< machineCount; i++)
                    Fsm.Run(spec.CreateMachine(seeds[i],indices[i])).Result.OnSome(s => stats.Add(s));
            }
            else
            {
                var tasks = new Task[machineCount];
                for(var i=0; i< machineCount; i++)
                    tasks[i] = Fsm.Run(spec.CreateMachine(seeds[i],indices[i])).ContinueWith(t => t.Result.OnSome(s => stats.Add(s)));
                Task.WaitAll(tasks);                            
            }
            return stats;

        }
    }
}