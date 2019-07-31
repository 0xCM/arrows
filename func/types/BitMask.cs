//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    
     public static class BitMask
     {
          [MethodImpl(Inline)]
          public static ref sbyte enable(ref sbyte src, in int pos)
          {
               src |= (sbyte)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref byte enable(ref byte src, in int pos)
          {
               src |= (byte)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short enable(ref short src, in int pos)
          {
               src |= (short)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort enable(ref ushort src, in int pos)
          {
               src |= (ushort)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int enable(ref int src, in int pos)
          {
               src |= (1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint enable(ref uint src, in int pos)
          {
               src |= (1u << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long enable(ref long src, in int pos)
          {
               src |= (1L << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong enable(ref ulong src, in int pos)
          {
               src |= (1ul << pos);
               return ref src;
          }          

          [MethodImpl(Inline)]
          public static ref float enable(ref float src, in int pos)
          {
               var srcBits = BitConverter.SingleToInt32Bits(src);
               srcBits |= 1 << pos;
               src = BitConverter.Int32BitsToSingle(srcBits);            
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref double enable(ref double src, in int pos)
          {               
               var srcBits = BitConverter.DoubleToInt64Bits(src);
               srcBits |= 1L << pos;
               src = BitConverter.Int64BitsToDouble(srcBits);                           
               return ref src;
          }

          [MethodImpl(Inline)]
          public static sbyte enable(sbyte src, int pos)
            =>  src |= (sbyte)(1 << pos);
               
          [MethodImpl(Inline)]
          public static byte enable(byte src, int pos)
            =>  src |= (byte)(1 << pos);

          [MethodImpl(Inline)]
          public static short enable(short src, int pos)
            =>  src |= (short)(1 << pos);
               
          [MethodImpl(Inline)]
          public static ushort enable(ushort src, int pos)
            =>  src |= (ushort)(1 << pos);

          [MethodImpl(Inline)]
          public static int enable(int src, int pos)
            =>  src |= (1 << pos);

          [MethodImpl(Inline)]
          public static uint enable(uint src, int pos)
            =>  src |= (1u << pos);

          [MethodImpl(Inline)]
          public static long enable(long src, int pos)
            =>  src |= (1L << pos);

          [MethodImpl(Inline)]
          public static ulong enable(ulong src, int pos)
            =>  src |= (1ul << pos);

          [MethodImpl(Inline)]
          public static ref byte disable(ref byte src, in int pos)
          {
               var m = (byte)(1 << pos);
               src &= (byte)~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref sbyte disable(ref sbyte src, in int pos)
          {
               var m = (sbyte)(1 << pos);
               src &= (sbyte)~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short disable(ref short src, in int pos)
          {
               var m = (short)(1 << pos);
               src &= (short)~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort disable(ref ushort src, in int pos)
          {
               var m = (ushort)(1 << pos);
               src &= (ushort)~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int disable(ref int src, in int pos)
          {
               var m = 1 << pos;
               src &= ~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint disable(ref uint src, in int pos)
          {
               var m = 1u << pos;
               src &= ~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long disable(ref long src, in int pos)
          {
               var m = 1L << pos;
               src &= ~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong disable(ref ulong src, in int pos)
          {
               var m = 1ul << pos;
               src &= ~m;
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref float disable(ref float src, in int pos)
          {
               ref var bits = ref Unsafe.As<float,int>(ref src);
               var m = 1 << pos;
               bits &= ~m;
               return ref src;
          } 

          [MethodImpl(Inline)]
          public static ref double disable(ref double src, in int pos)
          {
               ref var bits = ref Unsafe.As<double,long>(ref src);
               var m = 1L << pos;
               bits &= ~m;
               return ref src;
          } 

        [MethodImpl(Inline)]
        public static bool test(in sbyte src, in int pos)
            => (src & (1 << pos)) != 0;
            
        [MethodImpl(Inline)]
        public static bool test(in byte src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in short src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in ushort src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in int src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in uint src, in int pos)
            => (src & (1u << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool test(in long src, in int pos)
            => (src & (1L << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool test(in ulong src, in int pos)
            => (src & (1ul << pos)) != 0ul;

        [MethodImpl(Inline)]
        public static bool test(in float src, in int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        [MethodImpl(Inline)]
        public static bool test(in double src, in int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        [MethodImpl(Inline)]
        public static bool test(in sbyte src, byte pos)
            => (src & (1 << pos)) != 0;
            
        [MethodImpl(Inline)]
        public static bool test(in byte src, byte pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in short src, byte pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in ushort src, byte pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in int src, byte pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in uint src, byte pos)
            => (src & (1u << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool test(in long src, byte pos)
            => (src & (1L << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool test(in ulong src, byte pos)
            => (src & (1ul << pos)) != 0ul;

        [MethodImpl(Inline)]
        public static bool test(in float src, byte pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        [MethodImpl(Inline)]
        public static bool test(in double src, byte pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

 
         /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref byte set(ref byte src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref sbyte set(ref sbyte src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref short set(ref short src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref ushort set(ref ushort src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref int set(ref int src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref uint set(ref uint src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref long set(ref long src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref ulong set(ref ulong src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref float set(ref float src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }

        /// <summary>
        /// Aligns an index-identified bit in a source value with a supplied bit value
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source bit index</param>
        /// <param name="value">The state with which to align a source bit</param>
        [MethodImpl(Inline)]
        public static ref double set(ref double src, byte index, in Bit value)            
        {
            if(value) enable(ref src, index);
            else disable(ref src, index);
            return ref src;
        }


     }


}