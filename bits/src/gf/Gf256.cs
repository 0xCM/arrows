//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;


    public static class Gf256
    {
        //public static readonly BitVector16 Reducer =  0b1_0001_1101;
        public static readonly BitVector16 Reducer =  GfPoly.Lookup<N8,ushort>(4).Scalar;
                 
        public static byte mulAlt(byte a, byte b)
        {
            ulong r = Reducer;
            var p = 0ul;
            ulong x = a;
            ulong y = b;
            for(var i=0; i<8; i++)
            {
                if((x & (1ul << i)) != 0)
                    p^= (y << i);
            }

            for(var i=14; i>=8; i--)
            {
                if((p & (1ul << i)) != 0)
                    p^= (r <<(i-8));
            }
            return (byte)p;
        }

        [MethodImpl(Inline)]
        static uint clmul(uint a, uint b)
        {
            var p = dinx.clmul(a,b);
            p ^= dinx.clmul(p >> 8, Reducer);
            p ^= dinx.clmul(p >> 8, Reducer);
            return p;
        }

        [MethodImpl(Inline)]
        public static byte mul(byte a, byte b)
            => (byte)clmul((uint)a, (uint)b);

        /// <summary>
        /// Fills caller-allocated memory with a multiplication table
        /// </summary>
        /// <param name="min">The minimum operand value</param>
        /// <param name="max">The maximum operand value</param>
        public static void products(byte min, byte max, ref byte dst)
        {
            var width = max - min + 1;
            var cells = width*width;            
            var index = 0;
            for(uint i=min; i<= max; i++)
            for(uint j=min; j<= max; j++)
                Unsafe.Add(ref dst,index++) = (byte)clmul(i,j);
        }

        /// <summary>
        /// Creates a multiplication table
        /// </summary>
        /// <param name="min">The minimum operand value</param>
        /// <param name="max">The maximum operand value</param>
        public static byte[,] products(byte min, byte max)
        {
            var width = max - min + 1;
            var cells = width*width;            
            var dst = new byte[width,width];
            products(min,max, ref dst[0,0]);
            return dst;
        }

        /// <summary>
        /// Creates an N^2 multiplication table for the values [1...N]
        /// </summary>
        /// <typeparam name="N">The table order</typeparam>
        public static Matrix<N,byte> products<N>(N n = default)
            where N : ITypeNat, new()
        {
            var dst = Matrix.Alloc<N,byte>();
            products(1, (byte)n.value, ref dst.Unblocked[0]);
            return dst;
        }

    }

}