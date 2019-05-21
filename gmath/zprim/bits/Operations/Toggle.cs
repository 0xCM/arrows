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
          public static ref sbyte toggle(ref sbyte src, in int pos)
          {
               src ^= MaskI8(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref byte toggle(ref byte src, in int pos)
          {
               src ^= MaskU8(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short toggle(ref short src, in int pos)
          {
               src ^= MaskI16(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort toggle(ref ushort src, in int pos)
          {
               src ^= MaskU16(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int toggle(ref int src, in int pos)
          {
               src ^= MaskI32(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint toggle(ref uint src, in int pos)
          {
               src ^= MaskU32(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long toggle(ref long src, in int pos)
          {
               src ^= MaskI64(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong toggle(ref ulong src, in int pos)
          {
               src ^= MaskU64(src,pos);
               return ref src;
          } 
    }
}