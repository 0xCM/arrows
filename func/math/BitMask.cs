//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    public static class BitMaskG
    {
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        public static bool test<T>(in T src, byte pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return BitMask.test(in int8(in src), pos);
            else if(typeof(T) == typeof(byte))
                 return BitMask.test(in uint8(in src), pos);
            else if(typeof(T) == typeof(short))
                 return BitMask.test(in int16(in src), pos);
            else if(typeof(T) == typeof(ushort))
                 return BitMask.test(in uint16(in src), pos);
            else if(typeof(T) == typeof(int))
                 return BitMask.test(in int32(in src), pos);
            else if(typeof(T) == typeof(uint))
                 return BitMask.test(in uint32(in src), pos);
            else if(typeof(T) == typeof(long))
                 return BitMask.test(in int64(in src), pos);
            else if(typeof(T) == typeof(ulong))
                 return BitMask.test(in uint64(in src), pos);
            else if(typeof(T) == typeof(float))
                 return BitMask.test(in float32(in src), pos);
            else if(typeof(T) == typeof(double))
                 return BitMask.test(in float64(in src), pos);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Enables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T enable<T>(ref T src, in int pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitMask.enable(ref int8(ref src), in pos);
            else if(typeof(T) == typeof(byte))
                BitMask.enable(ref uint8(ref src), in pos);
            else if(typeof(T) == typeof(short))
                BitMask.enable(ref int16(ref src), in pos);
            else if(typeof(T) == typeof(ushort))
                BitMask.enable(ref uint16(ref src), in pos);
            else if(typeof(T) == typeof(int))
                BitMask.enable(ref int32(ref src), in pos);
            else if(typeof(T) == typeof(uint))
                BitMask.enable(ref uint32(ref src), in pos);
            else if(typeof(T) == typeof(long))
                BitMask.enable(ref int64(ref src), in pos);
            else if(typeof(T) == typeof(ulong))
                BitMask.enable(ref uint64(ref src), in pos);
            else
                throw unsupported<T>();

            return ref src;                            
        }

        /// <summary>
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T disable<T>(ref T src, byte pos)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                BitMask.disable(ref int8(ref src), pos);
            else if(typeof(T) == typeof(byte))
                BitMask.disable(ref uint8(ref src), pos);
            else if(typeof(T) == typeof(short))
                BitMask.disable(ref int16(ref src), pos);
            else if(typeof(T) == typeof(ushort))
                BitMask.disable(ref uint16(ref src), pos);
            else if(typeof(T) == typeof(int))
                BitMask.disable(ref int32(ref src), pos);
            else if(typeof(T) == typeof(uint))
                BitMask.disable(ref uint32(ref src), pos);
            else if(typeof(T) == typeof(long))
                BitMask.disable(ref int64(ref src), pos);
            else if(typeof(T) == typeof(ulong))
                BitMask.disable(ref uint64(ref src), pos);
            else if(typeof(T) == typeof(float))
                BitMask.disable(ref float32(ref src), pos);
            else if(typeof(T) == typeof(double))
                BitMask.disable(ref float64(ref src), pos);
            else
                throw unsupported<T>();
                
            return ref src;                            
        }

        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref T set<T>(ref T src, byte pos, in Bit value)            
            where T : struct
        {
            if(value)
                enable(ref src, pos);
            else
                disable(ref src, pos);
            return ref src;
        }

    }

     public static class BitMask
     {


         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref sbyte enable(ref sbyte src, in int pos)
          {
               src |= (sbyte)(1 << pos);
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref byte enable(ref byte src, in int pos)
          {
               src |= (byte)(1 << pos);
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref short enable(ref short src, in int pos)
          {
               src |= (short)(1 << pos);
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref ushort enable(ref ushort src, in int pos)
          {
               src |= (ushort)(1 << pos);
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref int enable(ref int src, in int pos)
          {
               src |= (1 << pos);
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref uint enable(ref uint src, in int pos)
          {
               src |= (1u << pos);
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref long enable(ref long src, in int pos)
          {
               src |= (1L << pos);
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref ulong enable(ref ulong src, in int pos)
          {
               src |= (1ul << pos);
               return ref src;
          }          

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref float enable(ref float src, in int pos)
          {
               var srcBits = BitConverter.SingleToInt32Bits(src);
               srcBits |= 1 << pos;
               src = BitConverter.Int32BitsToSingle(srcBits);            
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ref double enable(ref double src, in int pos)
          {               
               var srcBits = BitConverter.DoubleToInt64Bits(src);
               srcBits |= 1L << pos;
               src = BitConverter.Int64BitsToDouble(srcBits);                           
               return ref src;
          }

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static sbyte enable(sbyte src, int pos)
            =>  src |= (sbyte)(1 << pos);
               
         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static byte enable(byte src, int pos)
            =>  src |= (byte)(1 << pos);

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static short enable(short src, int pos)
            =>  src |= (short)(1 << pos);
               
         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ushort enable(ushort src, int pos)
            =>  src |= (ushort)(1 << pos);

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static int enable(int src, int pos)
            =>  src |= (1 << pos);

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static uint enable(uint src, int pos)
            =>  src |= (1u << pos);

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static long enable(long src, int pos)
            =>  src |= (1L << pos);

         /// <summary>
         /// Enables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to enable</param>
          [MethodImpl(Inline)]
          public static ulong enable(ulong src, int pos)
            =>  src |= (1ul << pos);

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref byte disable(ref byte src, in int pos)
          {
               var m = (byte)(1 << pos);
               src &= (byte)~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref sbyte disable(ref sbyte src, in int pos)
          {
               var m = (sbyte)(1 << pos);
               src &= (sbyte)~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref short disable(ref short src, in int pos)
          {
               var m = (short)(1 << pos);
               src &= (short)~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref ushort disable(ref ushort src, in int pos)
          {
               var m = (ushort)(1 << pos);
               src &= (ushort)~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref int disable(ref int src, in int pos)
          {
               var m = 1 << pos;
               src &= ~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref uint disable(ref uint src, in int pos)
          {
               var m = 1u << pos;
               src &= ~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref long disable(ref long src, in int pos)
          {
               var m = 1L << pos;
               src &= ~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref ulong disable(ref ulong src, in int pos)
          {
               var m = 1ul << pos;
               src &= ~m;
               return ref src;
          }

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
          [MethodImpl(Inline)]
          public static ref float disable(ref float src, in int pos)
          {
               ref var bits = ref Unsafe.As<float,int>(ref src);
               var m = 1 << pos;
               bits &= ~m;
               return ref src;
          } 

         /// <summary>
         /// Disables a specified source bit
         /// </summary>
         /// <param name="src">The source value to manipulate</param>
         /// <param name="pos">The position of the bit to disable</param>
         [MethodImpl(Inline)]
         public static ref double disable(ref double src, in int pos)
         {
              ref var bits = ref Unsafe.As<double,long>(ref src);
              var m = 1L << pos;
              bits &= ~m;
              return ref src;
         } 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in sbyte src, in int pos)
            => (src & (1 << pos)) != 0;
            
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in byte src, in int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in short src, in int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in ushort src, in int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in int src, in int pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in uint src, in int pos)
            => (src & (1u << pos)) != 0u;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in long src, in int pos)
            => (src & (1L << pos)) != 0L;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in ulong src, in int pos)
            => (src & (1ul << pos)) != 0ul;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in float src, in int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in double src, in int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in sbyte src, byte pos)
            => (src & (1 << pos)) != 0;
            
        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in byte src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in short src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in ushort src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in int src, byte pos)
            => (src & (1 << pos)) != 0;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in uint src, byte pos)
            => (src & (1u << pos)) != 0u;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in long src, byte pos)
            => (src & (1L << pos)) != 0L;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in ulong src, byte pos)
            => (src & (1ul << pos)) != 0ul;

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool test(in float src, byte pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        /// <summary>
        /// Determines whether a bit in a specified position is enabled
        /// </summary>
        /// <param name="src">The value to interrogate</param>
        /// <param name="pos">The position to check</param>
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