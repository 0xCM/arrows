//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                

          [MethodImpl(Inline)]
          public static sbyte toggle(sbyte src, BitPos pos)
               => src ^= (sbyte)(1 << pos);

          [MethodImpl(Inline)]
          public static byte toggle(byte src, BitPos pos)
               => src ^= (byte)(1 << pos);

          [MethodImpl(Inline)]
          public static short toggle(short src, BitPos pos)
               => src ^= (short)(1 << pos);

          [MethodImpl(Inline)]
          public static ushort toggle(ushort src, BitPos pos)
               => src ^= (ushort)(1 << pos);

          [MethodImpl(Inline)]
          public static int toggle(int src, BitPos pos)
               => src ^= (1 << pos);

          [MethodImpl(Inline)]
          public static uint toggle(uint src, BitPos pos)
               => src ^= (1u << pos);

          [MethodImpl(Inline)]
          public static long toggle(long src, BitPos pos)
               => src ^= (1L << pos);

          [MethodImpl(Inline)]
          public static ulong toggle(ulong src, BitPos pos)
               => src ^= (1ul << pos);

          [MethodImpl(Inline)]
          public static float toggle(float src, BitPos pos)
          {
               ref var bits = ref Unsafe.As<float,int>(ref src);
               bits ^= (1 << pos);
               return src;
          }

          [MethodImpl(Inline)]
          public static double toggle(double src, BitPos pos)
          {
               ref var bits = ref Unsafe.As<double,long>(ref src);
               bits ^= (1L << pos);
               return src;
          }

          [MethodImpl(Inline)]
          public static ref sbyte toggle(ref sbyte src, BitPos pos)
          {
               src ^= (sbyte)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref byte toggle(ref byte src, BitPos pos)
          {
               src ^= (byte)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short toggle(ref short src, BitPos pos)
          {
               src ^= (short)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort toggle(ref ushort src, BitPos pos)
          {
               src ^= (ushort)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int toggle(ref int src, BitPos pos)
          {
               src ^= (1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint toggle(ref uint src, BitPos pos)
          {
               src ^= (1u << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long toggle(ref long src, BitPos pos)
          {
               src ^= (1L << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong toggle(ref ulong src, BitPos pos)
          {
               src ^= (1ul << pos);
               return ref src;
          } 

          [MethodImpl(Inline)]
          public static ref float toggle(ref float src, BitPos pos)
          {
               ref var bits = ref Unsafe.As<float,int>(ref src);
               bits ^= (1 << pos);
               return ref src;
          } 

          [MethodImpl(Inline)]
          public static ref double toggle(ref double src, BitPos pos)
          {
               ref var bits = ref Unsafe.As<double,long>(ref src);
               bits ^= (1L << pos);
               return ref src;
          } 

    }
}