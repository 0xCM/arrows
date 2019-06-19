//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;


     public static class ZBits
     {

          [MethodImpl(Inline)]
          public static ref UInt128 enable(ref UInt128 src, int pos)
          {
               if(pos < 64)
                    Bits.enable(ref src.lo, pos);
               else
                    Bits.enable(ref src.hi, pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref Int128 enable(ref Int128 src, int pos)
          {
               if(pos < 64)
                    Bits.enable(ref src.lo, pos);
               else
                    Bits.enable(ref src.hi, pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref UInt128 disable(this ref UInt128 src, int pos)
          {
               if(pos < 64)
                    Bits.disable(ref src.lo, pos);
               else
                    Bits.disable(ref src.hi, pos);
               return ref src;               
          }

          [MethodImpl(Inline)]
          public static ref Int128 disable(this ref Int128 src, int pos)
          {
               if(pos < 64)
                    Bits.disable(ref src.lo, pos);
               else
                    Bits.disable(ref src.hi, pos);
               return ref src;               
          }

          [MethodImpl(Inline)]
          public static bool test(in UInt128 src, int pos)
               => pos < 64 ? Bits.test(src.lo, pos) : Bits.test(src.hi, pos) ;

          [MethodImpl(Inline)]
          public static bool test(in Int128 src, int pos)
               => pos < 64 ? Bits.test(src.lo, pos) : Bits.test(src.hi, pos) ;

          [MethodImpl(NotInline)]
          public static Span<Bit> bits(in UInt128 src)
          {
               var dst = span<Bit>(128);
               for(var i = 0; i < 128; i++)
                    dst[i] = test(src,i);
               return dst; 
          }

          [MethodImpl(NotInline)]
          public static Span<Bit> bits(in Int128 src)
          {
               var dst = span<Bit>(128);
               for(var i = 0; i < 128; i++)
                    dst[i] = test(src,i);
               return dst; 
          }

          [MethodImpl(Inline)]
          public static BitString bitstring(in UInt128 src)
               => BitStringConvert.FromValue(src.x11) 
               + BitStringConvert.FromValue(src.x10) 
               + BitStringConvert.FromValue(src.x01) 
               + BitStringConvert.FromValue(src.x00);

          [MethodImpl(Inline)]
          public static BitString bitstring(in Int128 src)
               => BitStringConvert.FromValue(src.x11) 
               + BitStringConvert.FromValue(src.x10) 
               + BitStringConvert.FromValue(src.x01) 
               + BitStringConvert.FromValue(src.x00);

          [MethodImpl(Inline)]
          public static Span<byte> bytes(this in UInt128 src)
               => span(
                    src.x0000, src.x0001, src.x0010, src.x0011,
                    src.x0100, src.x0101, src.x0110, src.x0111,                        
                    src.x1100, src.x1101, src.x1110, src.x1111,            
                    src.x1000, src.x1001, src.x1010, src.x1011
               );

          [MethodImpl(Inline)]
          public static Span<byte> bytes(this in Int128 src)
               => span(
                    src.x0000, src.x0001, src.x0010, src.x0011,
                    src.x0100, src.x0101, src.x0110, src.x0111,                        
                    src.x1100, src.x1101, src.x1110, src.x1111,            
                    src.x1000, src.x1001, src.x1010, src.x1011
               );

          [MethodImpl(Inline)]
          public static int pop(in UInt128 src)
               => (int)(Popcnt.X64.PopCount(src.lo) + Popcnt.X64.PopCount(src.hi));

          [MethodImpl(Inline)]
          public static int pop(in Int128 src)
               => (int)(Bits.pop(src.lo) + Bits.pop(src.hi));

          [MethodImpl(Inline)]
          public static UInt128 pack(in Span<Bit> src, out UInt128 dst)
          {
               var x1 = 0ul;
               Bits.pack(src, out ulong x0);
               if (src.Length >= 64)
                    Bits.pack(src.Slice(64), out x1);
               dst = UInt128.Define(x0, x1);
               return dst;
          }
     }
}