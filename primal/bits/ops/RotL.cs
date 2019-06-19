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
    
    using static zfunc;    
    

    partial class Bits
    {                
        [MethodImpl(Inline)]
        public static byte rotl(in byte src, int offset)
            => (byte)((src << offset) | (src >> (8 - offset)));

        [MethodImpl(Inline)]
        public static ushort rotl(in ushort src, int offset)
            => (ushort)((src << offset) | (src >> (16 - offset)));

        [MethodImpl(Inline)]
        public static uint rotl(in uint src, int offset)
            => (src << offset) | (src >> (32 - offset));

        [MethodImpl(Inline)]
        public static ulong rotl(in ulong src, int offset)
            => (src << offset) | (src >> (64 - offset));
    
    
        [MethodImpl(Inline)]
        public static ref byte rotl(ref byte lhs, in int rhs)
        {
            lhs = rotl(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort rotl(ref ushort lhs, in int rhs)
        {
            lhs = rotl(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint rotl(ref uint lhs, in int rhs)
        {
            lhs = rotl(lhs,rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong rotl(ref ulong lhs, in int rhs)
        {
            lhs = rotl(lhs,rhs);
            return ref lhs;
        }
    
    }
}