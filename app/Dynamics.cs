namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static zcore;
    static class DynInvoke
    {
        [MethodImpl(Inline)]
        public static uint baseline(uint x, uint y)
            => x * y;

        const int Reps = (int)Pow2.T22;
        
        static long DirectInvoke()
        {
            var title = "Direct Invoke:".PadRight(20) + $"Reps = {Reps}";
            var sw = stopwatch();
            for (int i = 0; i < Reps; i++) 
                baseline(2, 3); 
            var duration = snapshot(sw);            
            
            var msg = AppMsg.Define($"{title} | {duration.format}", SeverityLevel.Perform);
            print(msg);
            return duration.ticks;           

        }

        static long LocalDelegate()
        {
            var title = "Local Delegate:".PadRight(20) + $"Reps = {Reps}";
            var f = new Func<uint,uint,uint>(baseline);
            var sw = stopwatch();
            for (int i = 0; i < Reps; i++) 
                f(2, 3);

            var duration = snapshot(sw);
            var msg = AppMsg.Define($"{title} | {duration.format}", SeverityLevel.Perform);
            print(msg);
            return duration.ticks;           
        }

        static long PrimitiveOp()
        {
            var title = "Primop:".PadRight(20) + $"Reps = {Reps}";
            var f = PrimalOps.mul<uint>();
            var sw = stopwatch();
            for (int i = 0; i < Reps; i++) 
                f(25, 30);

            var duration = snapshot(sw);
            var msg = AppMsg.Define($"{title} | {duration.format}", SeverityLevel.Perform);
            print(msg);
            return duration.ticks;           

        }

        static long MsilCall()
        {
            var title = "MSIL Call:".PadRight(20) + $"Reps = {Reps}";
            var target = typeof(DynInvoke).StaticMethod(nameof(baseline)).Require();
            var f = target.ToBinaryOperator<uint>();
            
            var sw = stopwatch();
            for (int i = 0; i < Reps; i++) 
                f(2, 3);

            var duration = snapshot(sw);
            var msg = AppMsg.Define($"{title} | {duration.format}", SeverityLevel.Perform);
            print(msg);            
            return duration.ticks;           

        }

        public static void Test()
        {
            var direct = 0L;
            var local = 0L;
            var msil = 0L;
            var prim = 0L;
            for(var i=0; i< 100; i++)
            {
                direct += DirectInvoke();
                local += LocalDelegate();
                prim += PrimitiveOp();
                msil += MsilCall();
            }

            inform($"Direct Invoke".PadRight(20) + $"{ticksToMs(direct)} ms");
            inform($"Local Delegate".PadRight(20) + $"{ticksToMs(local)} ms");
            inform($"Primop".PadRight(20) + $"{ticksToMs(prim)} ms");
            inform($"Msil Call".PadRight(20) + $"{ticksToMs(msil)} ms");

        }

    }
}