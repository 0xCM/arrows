//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;


    [DisplayName("scenarios-primal")]
    class CommonPrimalScenarios
    {
        [MethodImpl(Inline | Optimize)]
        public static sbyte addI8(sbyte x, sbyte y)
            => (sbyte)(x + y);

        [MethodImpl(Inline | Optimize)]
        public static int addI32(int x, int y)
            => x + y;

        [MethodImpl(Inline | Optimize)]
        public static ulong addU64(ulong x, ulong y)
            => x + y;

        [MethodImpl(Inline | Optimize)]
        public static int subI32(int x, int y)
            => x - y;

        [MethodImpl(Inline | Optimize)]
        public static int mulI32(int x, int y)
            => x * y;

        [MethodImpl(Inline | Optimize)]
        public static byte andU8(byte x, byte y)
            => (byte)(x & y);

        [MethodImpl(Inline | Optimize)]
        public static ushort andU16(ushort x, ushort y)
            => (ushort)(x & y);

        [MethodImpl(Inline | Optimize)]
        public static ulong andU64(ulong x, ulong y)
            => x & y;

        [MethodImpl(Inline)]
        public static int addI32Loop()
        {
            var sum = 0;
            for(var i=0; i<100; i++)
                sum += i;
            return sum;
        }

        [MethodImpl(Inline | Optimize)]
        public static int addI32LoopOptimize()
        {
            var sum = 0;
            for(var i=0; i<100; i++)
                sum += i;
            return sum;
        }

        [MethodImpl(Inline)]
        public static int AddI32LoopCall()
            => addI32Loop();
    }


}