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


    
    class CompositeScenarios : Deconstructable<CompositeScenarios>
    {
        public CompositeScenarios()
            : base(callerfile())
        {

        }


        #region rot

        public static byte rotr8u(byte src, byte offset)
            => (byte) (((uint)src >> (int)offset) | ((uint)src << (32 - offset)));

        public static ushort rotr16u(ushort src, ushort offset)
            => (byte) (((uint)src >> (int)offset) | ((uint)src << (32 - offset)));

        public static uint rotr32u(uint src, uint offset)
            => (src >> (int)offset) | (src << (32 - (int)offset));

        public static ulong rotr64u(ulong src, ulong offset)
            => (src >> (int)offset) | (src << (64 - (int)offset));

        public static byte rotl8u(byte x, byte offset)
            => (byte) (((uint)x << (int)offset) | ((uint)x >> (int)(32 - offset)));

        public static ushort rotl16u(ushort x, ushort offset)
            => (ushort) (((uint)x << (int)offset) | ((uint)x >> (int)(32 - offset)));

        public static uint rotl32u(uint x, uint offset)
            => (x << (int)offset) | (x >> (int)(32 - offset));

        public static ulong rotl64u(ulong x, ulong offset)
            =>  (x << (int)offset) | (x >> (int)(64 - offset));



        
        #endregion


        public static void loopedCall(int count, Action<int> callee)
        {
            for(var i=0; i<count; i++)
                callee(i);
        }

        public static void swap8u(ref byte x, ref byte y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }

        public static void swap32i(ref int x, ref int y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }

        static readonly int A = 1;
        static readonly int B = 2;

        static readonly int C = 3;

        public static int space3()
        {
            var a = A;
            var b = B;
            var c = C;
            return a + b + c;
        }
    }

}