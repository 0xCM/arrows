//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;

    using static zfunc;    
    
    partial class Bits
    {                
        [MethodImpl(Inline)]
        public static byte rotr(in byte src, int offset)
            => (byte)((src >> offset) | (src << (8 - offset)));

        [MethodImpl(Inline)]
        public static byte rotr(in byte src, byte offset)
            => (byte)((src >> offset) | (src << (8 - offset)));

        [MethodImpl(Inline)]
        public static ushort rotr(in ushort src, int offset)
            => (ushort)((src >> offset) | (src << (16 - offset)));

        [MethodImpl(Inline)]
        public static uint rotr(in uint src, int offset)
            => (src >> offset) | (src << (32 - offset));

        [MethodImpl(Inline)]
        public static ulong rotr(in ulong src, int offset)
            => (src >> offset) | (src << (64 - offset));

        [MethodImpl(Inline)]
        public static ushort rotr(in ushort src, ushort offset)
            => (ushort)((src >> offset) | (src << (16 - offset)));

        [MethodImpl(Inline)]
        public static uint rotr(in uint src, uint offset)
            => (src >> (int)offset) | (src << (32 - (int)offset));

        [MethodImpl(Inline)]
        public static ulong rotr(in ulong src, ulong offset)
            => (src >> (int)offset) | (src << (64 - (int)offset));

        [MethodImpl(Inline)]
        public static ref byte rotr(ref byte src, in int offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort rotr(ref ushort src, in int offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint rotr(ref uint src, in int offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong rotr(ref ulong src, in int offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte rotr(ref byte src, in byte offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort rotr(ref ushort src, in ushort offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint rotr(ref uint src, in uint offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong rotr(ref ulong src, in ulong offset)
        {
            src = rotr(src,offset);
            return ref src;
        }

        /// <summary>
        /// Derived from PCG implementation
        /// </summary>
        [MethodImpl(Inline)]
        static uint rotrAlt(uint src, uint count)
        {            
            var lhs = src >> (int)count;
            var rhs = src << (int)(~count & 31) + 1;
            return lhs | rhs;
        }            
    }

}