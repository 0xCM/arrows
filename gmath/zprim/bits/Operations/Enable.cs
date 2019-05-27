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
          public static ref sbyte enable(ref sbyte src, in int pos)
          {
               src |= MaskI8(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref byte enable(ref byte src, in int pos)
          {
               src |= MaskU8(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short enable(ref short src, in int pos)
          {
               src |= MaskI16(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort enable(ref ushort src, in int pos)
          {
               src |= MaskU16(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong enable(ref ulong src, in int pos)
          {
               src |= MaskU64(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int enable(ref int src, in int pos)
          {
               src |= MaskI32(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint enable(ref uint src, in int pos)
          {
               src |= MaskU32(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long enable(ref long src, in int pos)
          {
               src |= MaskI64(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref float enable(ref float src, in int pos)
          {
               var srcBits = BitConverter.SingleToInt32Bits(src);
               srcBits |= MaskI32(srcBits, pos);
               src = BitConverter.Int32BitsToSingle(srcBits);            
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref double enable(ref double src, in int pos)
          {               
               var srcBits = BitConverter.DoubleToInt64Bits(src);
               srcBits |= MaskI64(srcBits, pos);
               src = BitConverter.Int64BitsToDouble(srcBits);                           
               return ref src;
          }
     }
}