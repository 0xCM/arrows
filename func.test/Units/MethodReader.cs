//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;


    public sealed class MethodReaderTest : UnitTest<MethodReaderTest>
    {

        static int Method1(int a, int b)
            => a + b;

        static int Method2(int a, int b)
            => a - b;

        static void Method3()
        {
            Console.WriteLine("");
        }

        public unsafe void TestMethod1()
        {
            var m1 = MethodMemory.Read<MethodReaderTest>(nameof(Method1));
            Trace(m1.Format());

            var m2 = MethodMemory.Read<MethodReaderTest>(nameof(Method2));
            Trace(m2.Format());
            
            var m3 = MethodMemory.Read<MethodReaderTest>(nameof(Method3));            
            Trace(m3.Format());

        }


    }

}