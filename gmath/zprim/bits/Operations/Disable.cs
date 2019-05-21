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
          public static ref byte disable(ref byte src, in int pos)
          {
               var m = MaskU8(src,pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref sbyte disable(ref sbyte src, in int pos)
          {
               var m = MaskI8(src,pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short disable(ref short src, in int pos)
          {
               var m = MaskI16(src,pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort disable(ref ushort src, in int pos)
          {
               var m = MaskU16(src,pos);
               src &= m.Flip();
               return ref src;
          }


          [MethodImpl(Inline)]
          public static ref int disable(ref int src, in int pos)
          {
               var m = MaskI32(src,pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint disable(ref uint src, in int pos)
          {
               var m = MaskU32(src,pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long disable(ref long src, in int pos)
          {
               var m = MaskI64(src,pos);
               src &= m.Flip();
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong disable(ref ulong src, in int pos)
          {
               var m = MaskU64(src,pos);
               src &= m.Flip();
               return ref src;
          }
    }
}