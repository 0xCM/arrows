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
          public static BitVectorU128 bitvector(ulong x0, ulong x1)
               => new BitVectorU128(UInt128.Define(x0, x1));

          [MethodImpl(Inline)]
          public static BitVectorU128 bitvector(Span<Bit> src)
               => pack(src, out UInt128 dst);

          [MethodImpl(Inline)]
          public static ref UInt128 enable(ref UInt128 src, int pos)
          {
               if(pos < 64)
                    Bits.enable(ref src.x0, pos);
               else
                    Bits.enable(ref src.x1, pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref Int128 enable(ref Int128 src, int pos)
          {
               if(pos < 64)
                    Bits.enable(ref src.x0, pos);
               else
                    Bits.enable(ref src.x1, pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref UInt128 disable(this ref UInt128 src, int pos)
          {
               if(pos < 64)
                    Bits.disable(ref src.x0, pos);
               else
                    Bits.disable(ref src.x1, pos);
               return ref src;               
          }

          [MethodImpl(Inline)]
          public static ref Int128 disable(this ref Int128 src, int pos)
          {
               if(pos < 64)
                    Bits.disable(ref src.x0, pos);
               else
                    Bits.disable(ref src.x1, pos);
               return ref src;               
          }

          [MethodImpl(Inline)]
          public static bool test(in UInt128 src, int pos)
               => pos < 64 ? Bits.test(src.x0, pos) : Bits.test(src.x1, pos) ;

          [MethodImpl(Inline)]
          public static bool test(in Int128 src, int pos)
               => pos < 64 ? Bits.test(src.x0, pos) : Bits.test(src.x1, pos) ;

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
          public static string bitstring(in UInt128 src)
               => Bits.bitstring(src.x11) + Bits.bitstring(src.x10) + Bits.bitstring(src.x01) + Bits.bitstring(src.x00);

          [MethodImpl(Inline)]
          public static string bitstring(in Int128 src)
               => Bits.bitstring(src.x11) + Bits.bitstring(src.x10) + Bits.bitstring(src.x01) + Bits.bitstring(src.x00);

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
               => (int)(Popcnt.X64.PopCount(src.x0) + Popcnt.X64.PopCount(src.x1));

          [MethodImpl(Inline)]
          public static int pop(in Int128 src)
               => (int)(Bits.pop(src.x0) + Bits.pop(src.x1));

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