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
    using static mfunc;
    
     partial class Bits
     {                
          [MethodImpl(Inline)]
          public static ref sbyte toggle(ref sbyte src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static sbyte toggle(sbyte src, int pos)
               => toggle(ref src, pos);

          [MethodImpl(Inline)]
          public static ref byte toggle(ref byte src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static byte toggle(byte src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref short toggle(ref short src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static short toggle(short src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref ushort toggle(ref ushort src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ushort toggle(ushort src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref int toggle(ref int src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static int toggle(int src, int pos)
               => src ^= LeftMask(src,pos);


          [MethodImpl(Inline)]
          public static uint toggle(uint src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref uint toggle(ref uint src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static long toggle(long src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref long toggle(ref long src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ulong toggle(ulong src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref ulong toggle(ref ulong src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }
     }
}