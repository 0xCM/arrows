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

    public static class Gf512
    {
        static readonly BitVector32 Redux =  GfPoly.Lookup<N9,uint>().Scalar;

        [MethodImpl(Inline)]
        public static BitVector16 mul(BitVector16 a, BitVector16 b)
            => Bits.clmulr(a,b,Redux);

        public static BitVector16 mul_ref(BitVector16 a, BitVector16 b)
        {
            ulong r = Redux;
            var p = 0ul;
            ulong x = a;
            ulong y = b;
            for(var i=0; i<16; i++)
            {
                if((x & (1ul << i)) != 0)
                    p^= (y << i);
            }

            for(var i=30; i>=16; i--)
            {
                if((p & (1ul << i)) != 0)
                    p^= (r <<(i-16));
            }
            return (ushort)p;
        }

        /// <summary>
        /// Fills caller-allocated memory with a multiplication table
        /// </summary>
        /// <param name="min">The minimum operand value</param>
        /// <param name="max">The maximum operand value</param>
        static void products(ushort min, ushort max, ref ushort dst)
        {
            var width = max - min + 1;
            var cells = width*width;            
            var index = 0;
            for(ushort i=min; i<= max; i++)
            for(ushort j=min; j<= max; j++)
                Unsafe.Add(ref dst,index++) = mul(i,j);
        }

        /// <summary>
        /// Creates an N^2 multiplication table for the values [1...N]
        /// </summary>
        /// <typeparam name="N">The table order</typeparam>
        public static BlockMatrix<N,ushort> products<N>(N n = default)
            where N : ITypeNat, new()
        {
            var dst = BlockMatrix.Alloc<N,ushort>();
            products(1, (ushort)n.value, ref dst.Unblocked[0]);
            return dst;
        }

        /// <summary>
        /// Computes the full multiplication table for GF512
        /// </summary>
        /// <param name="dst">The target matrix</param>
        public static ref BlockMatrix<N512,ushort> products(out BlockMatrix<N512,ushort> dst)
        {
            dst = BlockMatrix.Alloc<N512,ushort>();
            for(ushort i=1; i < 512; i++)
            for(ushort j=1; j < 512; j++)
                dst[i, j] = Gf512.mul(i,j);
            return ref dst;
        }

    }

    public static class Gf256
    {
        static readonly ushort Redux =  GfPoly.Lookup<N8,ushort>().Scalar;
                        
        public static byte mul_ref(byte a, byte b)
        {
            ulong r = Redux;
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
        public static byte mul(byte a, byte b)
            => Bits.clmulr(a,b,Redux);


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
                Unsafe.Add(ref dst,index++) = mul(i,j);
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
        public static BlockMatrix<N,byte> products<N>(N n = default)
            where N : ITypeNat, new()
        {
            var dst = BlockMatrix.Alloc<N,byte>();
            products(1, (byte)n.value, ref dst.Unblocked[0]);
            return dst;
        }
 
         /// <summary>
        /// Computes the full multiplication table for GF256
        /// </summary>
        /// <param name="dst">The target matrix</param>
        public static ref BlockMatrix<N256,byte> products(out BlockMatrix<N256,byte> dst)
        {
            dst = BlockMatrix.Alloc<N256,byte>();
            for(uint i=1; i < 256; i++)
            for(uint j=1; j < 256; j++)
                dst[i, j] = Gf256.mul((byte)i,(byte)j);
            return ref dst;
        }

    }

}