//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    /// <summary>
    /// Defines non-parametric bitmasking and selection functions
    /// </summary>
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
            src &= (byte)~((byte)(1 << pos));
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
            if(value) 
                enable(ref src, index);
            else 
                disable(ref src, index);
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

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref byte setif(in byte src, int srcpos, ref byte dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, srcpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref sbyte setif(in sbyte src, int srcpos, ref sbyte dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, srcpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref short setif(in short src, int srcpos, ref short dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, srcpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref ushort setif(in ushort src, int srcpos, ref ushort dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }


        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref int setif(in int src, int srcpos, ref int dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref uint setif(in uint src, int srcpos, ref uint dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref long setif(in long src, int srcpos, ref long dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref ulong setif(in ulong src, int srcpos, ref ulong dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref float setif(in float src, int srcpos, ref float dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref double setif(in double src, int srcpos, ref double dst, int dstpos)        
        {
            if(test(src, srcpos))
                enable(ref dst, dstpos);
            return ref dst;
        }

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static sbyte toggle(sbyte src, int pos)
            => src ^= (sbyte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static byte toggle(byte src, int pos)
            => src ^= (byte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static short toggle(short src, int pos)
            => src ^= (short)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ushort toggle(ushort src, int pos)
            => src ^= (ushort)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static int toggle(int src, int pos)
            => src ^= (1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static uint toggle(uint src, int pos)
            => src ^= (1u << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static long toggle(long src, int pos)
            => src ^= (1L << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ulong toggle(ulong src, int pos)
            => src ^= (1ul << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static float toggle(float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            bits ^= (1 << pos);
            return src;
        }

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static double toggle(double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            bits ^= (1L << pos);
            return src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref sbyte toggle(ref sbyte src, int pos)
        {
            src ^= (sbyte)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref byte toggle(ref byte src, int pos)
        {
            src ^= (byte)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref short toggle(ref short src, int pos)
        {
            src ^= (short)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref ushort toggle(ref ushort src, int pos)
        {
            src ^= (ushort)(1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref int toggle(ref int src, int pos)
        {
            src ^= (1 << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref uint toggle(ref uint src, int pos)
        {
            src ^= (1u << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref long toggle(ref long src, int pos)
        {
            src ^= (1L << pos);
            return ref src;
        }

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref ulong toggle(ref ulong src, int pos)
        {
            src ^= (1ul << pos);
            return ref src;
        } 

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref float toggle(ref float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            bits ^= (1 << pos);
            return ref src;
        } 

        /// <summary>
        /// Flips an identified source bit in-place
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        public static ref double toggle(ref double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            bits ^= (1L << pos);
            return ref src;
        } 

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static byte between(in byte src, BitPos i0, BitPos i1)        
            => (byte)Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static sbyte between(in sbyte src, BitPos i0, BitPos i1)        
            => (sbyte)between((byte)src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ushort between(in ushort src, BitPos i0, BitPos i1)        
            => (ushort)Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static short between(in short src, BitPos i0, BitPos i1)        
            => (short)between((ushort)src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static uint between(in uint src, BitPos i0, BitPos i1)        
            => Bmi1.BitFieldExtract(src, i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static int between(in int src, BitPos i0, BitPos i1)        
            => (int)between((uint)src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ulong between(in ulong src, BitPos i0, BitPos i1)
            => Bmi1.X64.BitFieldExtract(src, i0, (byte)(i1 - i0));            

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static long between(in long src, BitPos i0, BitPos i1)        
            => (long)between((long)src, i0, i1);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static float between(in float src, BitPos i0, BitPos i1)        
            => BitConverter.Int32BitsToSingle(between(BitConverter.SingleToInt32Bits(src), i0, i1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The bit position within the source where extraction should begin</param>
        /// <param name="i1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static double between(in double src, BitPos i0, BitPos i1)        
            => BitConverter.Int64BitsToDouble(between(BitConverter.DoubleToInt64Bits(src), i0, i1));

    }   
}