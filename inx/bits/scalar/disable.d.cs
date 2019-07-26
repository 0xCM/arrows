//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    
    partial class Bits
    {                
          [MethodImpl(Inline)]
          public static ref byte disable(ref byte src, in int pos)
          {
               var m = (byte)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref sbyte disable(ref sbyte src, in int pos)
          {
               var m = (sbyte)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short disable(ref short src, in int pos)
          {
               var m = (short)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort disable(ref ushort src, in int pos)
          {
               var m = (ushort)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int disable(ref int src, in int pos)
          {
               var m = 1 << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint disable(ref uint src, in int pos)
          {
               var m = 1u << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long disable(ref long src, in int pos)
          {
               var m = 1L << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong disable(ref ulong src, in int pos)
          {
               var m = 1ul << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref float disable(ref float src, in int pos)
          {
               ref var bits = ref Unsafe.As<float,int>(ref src);
               var m = 1 << pos;
               bits &= m.Flip();
               return ref src;
          } 

          [MethodImpl(Inline)]
          public static ref double disable(ref double src, in int pos)
          {
               ref var bits = ref Unsafe.As<double,long>(ref src);
               var m = 1L << pos;
               bits &= m.Flip();
               return ref src;
          } 


          [MethodImpl(Inline)]
          public static ref byte disable(ref byte src, byte pos)
          {
               var m = (byte)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref sbyte disable(ref sbyte src, byte pos)
          {
               var m = (sbyte)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short disable(ref short src, byte pos)
          {
               var m = (short)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort disable(ref ushort src, byte pos)
          {
               var m = (ushort)(1 << pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int disable(ref int src, byte pos)
          {
               var m = 1 << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint disable(ref uint src, byte pos)
          {
               var m = 1u << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long disable(ref long src, byte pos)
          {
               var m = 1L << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong disable(ref ulong src, byte pos)
          {
               var m = 1ul << pos;
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref float disable(ref float src, byte pos)
          {
               ref var bits = ref Unsafe.As<float,int>(ref src);
               var m = 1 << pos;
               bits &= m.Flip();
               return ref src;
          } 

          [MethodImpl(Inline)]
          public static ref double disable(ref double src, byte pos)
          {
               ref var bits = ref Unsafe.As<double,long>(ref src);
               var m = 1L << pos;
               bits &= m.Flip();
               return ref src;
          } 

    }
}