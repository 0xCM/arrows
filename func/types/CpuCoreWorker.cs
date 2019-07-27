//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;

    /// <summary>
    /// Eccompasses a worker routine and bits of runtime state that
    /// are scheduled to be executed on a specific core
    /// </summary>
    public class CpuCoreWorker<T>
    {        
        internal CpuCoreWorker(IContext Context, uint CoreNumber, Func<T,T> Worker, T Data, TimeSpan Frequency, ulong? MaxCycles = null)
        {
            this.Context = Context;
            this.CoreNumber = CoreNumber;
            this.Worker = Worker;
            this.State =Data;
            this.Frequency = Frequency;
            this.MaxCycles = MaxCycles;
            this.WorkerThread = null;
            this.CycleCount = 0;
        }


        public readonly uint CoreNumber;

        public readonly TimeSpan Frequency;

        public readonly ulong? MaxCycles;

        public ulong CurrentCycle
        {
            [MethodImpl(Inline)]
            get => CycleCount;
        }

        public Duration TotalCpuUsage
        {
            [MethodImpl(Inline)]
            get  => WorkerThread.TotalProcessorTime.Ticks;
        }

        public T CurrentState
        {
            [MethodImpl(Inline)]
            get  => State;
        }

        readonly Func<T,T> Worker;


        ulong CycleCount;

        ProcessThread WorkerThread;

        T State;

        IContext Context;

        /// <summary>
        /// Executes a single work cycle
        /// </summary>
        [MethodImpl(Inline)]
        void RunCycle()
        {
            var max = MaxCycles ?? 1_000_000ul;
            for(var i=0ul; i<max; i++)           
                State = Worker(State);                    
        }

        async Task RunOnce()
        {
            RunCycle();
            ++CycleCount;
            print(FinishedCycle(CurrentCycle, TotalCpuUsage, State, CoreNumber));
            await asyncDelay(Frequency);
        }

        async Task RunForever()
        {                
            while(true)
               await RunOnce();
        }

        async Task RunCycles()
        {                
            var max = MaxCycles.Value;
            while(CycleCount++ <= max)
                await RunOnce();
        }
        
        internal async Task Run()
        {
            WorkerThread = thread(OS.CurrentThreadId).ValueOrDefault();
            if(WorkerThread == null)
            {
                error("Thread lookup failed. Aborting worker");
                return;
            }

            WorkerThread.IdealProcessor = (int)CoreNumber;

            if(MaxCycles == null)
                await RunForever();
            else 
                await RunCycles();
        }

        public void Control()
        {
            Run().Wait();
        }

        static async Task asyncDelay(TimeSpan duration)
            => await Task.Delay(duration);
    
        public static AppMsg FinishedCycle(ulong cycle, Duration totalCpu, T state, uint? core = null)
        {
            var coreTxt = core != null ? $"core = {core}, " : string.Empty;
            var cycleTxt = $"cycle = {cycle.ToString().PadLeft(5, '0')}, ";
            var cpuTxt = $"cputime = {totalCpu}, ";
            var stateTxt = $"current state = {state}";            
            var msgText = $"({coreTxt}{cycleTxt}{cpuTxt}{stateTxt}";
            var msg = appMsg(msgText, SeverityLevel.HiliteML);
            return msg;            
        }    
    }

    public static class CpuCoreWorker
    {
        static int WorkerId;
        
        static string WorkerName(uint cpucore)
            => $"{Interlocked.Increment(ref WorkerId)}/{cpucore}";


        static CpuCoreWorker<ulong> Example(IContext context)
        {
            ulong Sum(ulong max)
            {
                var sum = 0ul;
                for(var i=0; i<(int)max; i++)
                    sum += (ulong)i;
                return sum;
            }
            
            return Start(context, 1, Sum, (ulong)Pow2.T20, new TimeSpan(0,0,1));
            
        }

        public static CpuCoreWorker<T> Start<T>(IContext context, uint cpucore, Func<T,T> worker, T state, TimeSpan frequency, ulong? MaxCycles = null)
        {
            var cpuWorker = new CpuCoreWorker<T>(context, cpucore, worker, state, frequency, MaxCycles);
            var workerThread = new Thread(new ThreadStart(cpuWorker.Control))
            {
                IsBackground = true,
                Name = WorkerName(cpucore)
            };

            workerThread.Start();
            return cpuWorker;
        }

    }
}