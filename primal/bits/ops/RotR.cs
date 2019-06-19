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
        public static byte rotr(in byte value, int offset)
            => (byte)((value >> offset) | (value << (8 - offset)));

        [MethodImpl(Inline)]
        public static ushort rotr(in ushort value, int offset)
            => (ushort)((value >> offset) | (value << (16 - offset)));

        [MethodImpl(Inline)]
        public static uint rotr(in uint value, int offset)
            => (value >> offset) | (value << (32 - offset));

        [MethodImpl(Inline)]
        public static ulong rotr(in ulong  value, int offset)
            => (value >> offset) | (value << (64 - offset));


        [MethodImpl(Inline)]
        public static ulong rotate(ulong src, int offset, bool left = false)            
            => left ? BitOperations.RotateLeft(src,offset) 
                    : BitOperations.RotateRight(src,offset);

        [MethodImpl(Inline)]
        public static uint rotate(uint src, int offset, bool left = false)            
            => left ? BitOperations.RotateLeft(src,offset) 
                    : BitOperations.RotateRight(src,offset);

        [MethodImpl(Inline)]
        public static ref byte rotr(ref byte lhs, in int rhs)
        {
            lhs = rotr(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort rotr(ref ushort lhs, in int rhs)
        {
            lhs = rotr(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint rotr(ref uint lhs, in int rhs)
        {
            lhs = rotr(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong rotr(ref ulong lhs, in int rhs)
        {
            lhs = rotr(lhs,rhs);
            return ref lhs;
        }


    }

}