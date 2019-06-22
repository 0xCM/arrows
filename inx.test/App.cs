//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using System.Diagnostics;
    using Microsoft.Diagnostics.Runtime;
    using DR = Microsoft.Diagnostics.Runtime;

    using static zfunc;

    public class App : TestApp<App>
    {            


        static byte[] GetMethodAsm(MethodInfo method)
        {
            RuntimeHelpers.PrepareMethod(method.MethodHandle);
            var handle = method.MethodHandle;
            var pointer = handle.GetFunctionPointer();
            using var target = DR.DataTarget.AttachToProcess(Process.GetCurrentProcess().Id, uint.MaxValue, AttachFlag.Passive);
            var runtime = target.ClrVersions.Single(x => x.Flavor == ClrFlavor.Core).CreateRuntime();
            var clrMethod = runtime.GetMethodByAddress((ulong)pointer);
            Claim.eq(clrMethod.Name, method.Name);
            
            var start = clrMethod.HotColdInfo.HotStart;
            var size = clrMethod.HotColdInfo.HotSize;

            var buffer = new byte[size];
            var success = runtime.ReadMemory(start,buffer, (int)size, out int count);
            if(success)
                return buffer;
            else
                throw new Exception($"Unabled to read data for {clrMethod.Name}");
            
        }

        static void GetMethodAsmExample()
        {
            var method = typeof(App).DeclaredMethods(nameof(Mul)).NonGeneric().Concrete().Single();
            var asm = GetMethodAsm(method).Bracket();
            print(asm);

        }

        public static int Mul(int a, int b)
            => a * b;
        
        Duration Mul256u64(int blocks)
        {
            var domain = closed(0ul, UInt32.MaxValue);
            var lhs = Random.Span256<ulong>(blocks, domain);
            var rhs = Random.Span256<ulong>(blocks, domain);
            
            var sw = stopwatch();

            for(var block=0; block<blocks; block++)
            {
                var x = lhs.ToVec256(block);
                var y = rhs.ToVec256(block);
                dinx.mul(x,y); 
            }
            return snapshot(sw);

        }

        protected override void RunTests()
        {            
            var time = Mul256u64(Pow2.T20);
            show(() => time);


            //base.RunTests();

        }

        public static void Main(params string[] args)
            => Run(args);
    }
}