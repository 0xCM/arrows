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

    public static class Gf8
    {
        const byte Reducer = 0b1011;

        [MethodImpl(Inline)]
        public static byte clmul(byte a, byte b)
        {
            var p = dinx.clmul(a,b);
            p ^= dinx.clmul((byte)(p >> 3), Reducer);
            p ^= dinx.clmul((byte)(p >> 3), Reducer);
            return (byte)p;
        }

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
            for(byte i=min; i<= max; i++)
            for(byte j=min; j<= max; j++)
                Unsafe.Add(ref dst,index++) = clmul(i,j);
        }
        
        /// <summary>
        /// Creates a complete multiplication table
        /// </summary>
        /// <param name="min">The minimum operand value</param>
        /// <param name="max">The maximum operand value</param>
        public static Matrix<N7,byte> products()
        {
            var dst = Matrix.Alloc<N7,byte>();
            products(1, (byte)0b111, ref dst.Unblocked[0]);
            return dst;
        }

        public static string FormatTable<N,T>(Matrix<N,T> src)
            where T : struct
            where N : ITypeNat, new()
                => src.Format(render:x => BitString.FromScalar(x).Format());            

    }

}