// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {         

        [MethodImpl(Inline)]
        public static Bit readbit(sbyte src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(byte src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(short src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(ushort src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(int src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(uint src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(long src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(ulong src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(float src, int pos)
            => BitMask.test(src, pos);

        [MethodImpl(Inline)]
        public static Bit readbit(double src, int pos)
            => BitMask.test(src, pos);

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in sbyte src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in byte src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in short src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in ushort src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in int src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in uint src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in long src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in ulong src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in float src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

        /// <summary>
        /// Assigns the target bit with the value of the index-identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position in the source</param>
        /// <param name="dst">The target bit</param>
        [MethodImpl(Inline)]
        public static ref Bit read(in double src, in int pos, out Bit dst)
        {
            dst = test(in src, in pos);
            return ref dst;
        }

    }
}