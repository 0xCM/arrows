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


    readonly struct AddU32
    {
        [MethodImpl(Inline)]
        public static implicit operator uint(AddU32 src)
            => src.Value;

        [MethodImpl(Inline)]
        public AddU32(uint lhs, uint rhs)
            => Value = lhs + rhs;        
        
        public Result<uint> Value {get;}

        [MethodImpl(Inline)]
        public AddU32 Recompute(uint lhs, uint rhs)
            => new AddU32(lhs,rhs);
    }
    static class DynInvoke
    {
        [MethodImpl(Inline)]
        public static uint baseline(uint x, uint y)
            => x * y;

        [MethodImpl(Inline)]
        public static T add<T>(T x, T y)
            where T : struct
        {
            var kind = PrimKinds.kind<T>();

            if(kind == PrimKind.uint32)
            {
                var result = Unsafe.As<T,uint>(ref x) +  Unsafe.As<T,uint>(ref y);
                return Unsafe.As<uint,T>(ref result);
            }
            
            if(kind == PrimKind.float32)
            {
                var result = Unsafe.As<T,float>(ref x) +  Unsafe.As<T,float>(ref y);
                return Unsafe.As<float,T>(ref result);
            }
        
            if(kind == PrimKind.float64)
            {
                var result = Unsafe.As<T,double>(ref x) +  Unsafe.As<T,double>(ref y);
                return Unsafe.As<double,T>(ref result);
            }
            throw new NotSupportedException();

        }



        const int Reps = (int)Pow2.T22;
                
        static long DirectInvoke()
        {
            var title = "Direct Invoke:".PadRight(20) + $"Reps = {Reps}";
            var sw = stopwatch();
            for (int i = 0; i < Reps; i++) 
            {
                var value = baseline(2, 3); 
            }
            var duration = snapshot(sw);            
            
            var msg = AppMsg.Define($"{title} | {duration.format}", SeverityLevel.Perform);
            print(msg);
            return duration.ticks;           

        }

        static long GenericValue()
        {
            var title = "Generic Value:".PadRight(20) + $"Reps = {Reps}";
            //var f = new AddU32();
            // var sw = stopwatch();
            // for (int i = 0; i < Reps; i++) 
            // {
            //     var resut = FastOps.add(2u,3u).Wrapped;
            //     // var result = f.Recompute(2, 3);
            //     // var value = result.Value;
            // }
                

            var duration = FastOps.TimeAdd(Reps);
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
            {
                var value = f(2, 3);
            }

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
            {
                var value = f(25, 30);
            }

            var duration = snapshot(sw);
            var msg = AppMsg.Define($"{title} | {duration.format}", SeverityLevel.Perform);
            print(msg);
            return duration.ticks;           

        }

        static long GenericOp()
        {
            var title = "Generic:".PadRight(20) + $"Reps = {Reps}";
            var sw = stopwatch();
            for (int i = 0; i < Reps; i++) 
            {
                var value = add(25u, 30u);
            }

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
            {
                var value = f(2, 3);
            }

            var duration = snapshot(sw);
            var msg = AppMsg.Define($"{title} | {duration.format}", SeverityLevel.Perform);
            print(msg);            
            return duration.ticks;           

        }

        public static void Test()
        {
            var direct = 0L;
            //var local = 0L;
            var msil = 0L;
            var prim = 0L;
            var gv = 0L;
            //var generic = 0L;
            for(var i=0; i< 100; i++)
            {
                direct += DirectInvoke();
                //local += LocalDelegate();
                prim += PrimitiveOp();
                msil += MsilCall();
                gv += GenericValue();
                //generic += GenericOp();
            }

            inform($"Direct Invoke".PadRight(20) + $"{ticksToMs(direct)} ms");
            //inform($"Local Delegate".PadRight(20) + $"{ticksToMs(local)} ms");
            inform($"Primop".PadRight(20) + $"{ticksToMs(prim)} ms");
            inform($"Msil Call".PadRight(20) + $"{ticksToMs(msil)} ms");
            inform($"Generic Value".PadRight(20) + $"{ticksToMs(gv)} ms");
            //inform($"Generic Op".PadRight(20) + $"{ticksToMs(generic)} ms");

        }

    }
}