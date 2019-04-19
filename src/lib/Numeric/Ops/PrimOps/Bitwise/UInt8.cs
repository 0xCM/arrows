//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    
    using static zcore;
    using static Operative;

    using target = System.Byte;
    using targets = System.Collections.Generic.IReadOnlyList<byte>;

    partial class PrimOps { partial class Reify {

        public readonly partial struct Bitwise : 
            Bitwise<target> 
        {

            [MethodImpl(Inline)]   
            public target and(target lhs, target rhs) 
                => (target)(lhs & rhs);

            [MethodImpl(Inline)]
            public targets and(targets lhs, targets rhs)
                => fuse(lhs,rhs, and, out target[] dst);

            [MethodImpl(Inline)]   
            public target or(target lhs, target rhs) 
                => (target)(lhs | rhs);

            [MethodImpl(Inline)]
            public targets or(targets lhs, targets rhs)
                => fuse(lhs,rhs, or, out target[] dst);

            [MethodImpl(Inline)]   
            public target xor(target lhs, target rhs) 
                => (target)(lhs ^ rhs);

            [MethodImpl(Inline)]
            public targets xor(targets lhs, targets rhs)
                => fuse(lhs,rhs, xor, out target[] dst);

            [MethodImpl(Inline)]   
            public target lshift(target src, int shift) 
                => (target)(src << shift);

            [MethodImpl(Inline)]   
            public target rshift(target a, int shift) 
                => (target)(a >> shift);

            [MethodImpl(Inline)]   
            public target flip(target a) 
                => (target)~ a;

            [MethodImpl(Inline)]
            public targets flip(targets lhs)
                => map(lhs,flip);

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public string bitchars(target src)
                => lpadZ(Convert.ToString(src,2), primops.bitsize<target>());

            [MethodImpl(Inline)]   
            public BitString bitstring(target src) 
                => BitString.define(bit.parse(bitchars(src)));

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(target src, int pos)
                => (src & (1 << pos)) != 0;
        
            [MethodImpl(Inline)]
            public bit[] bits(target src)
            {
                var dst = array<bit>(SizeOf<target>.BitSize);
                for(var i = 0; i < SizeOf<target>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }

            /// <summary>
            /// Interprets the source as an array of targets
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => array(src);

            /// <summary>
            /// Counts the number of leading zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countLeadingOff(target src)
                => countLeadingOff((ushort)src) - 8;

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(target src)
                => countTrailingOff((uint)src);
        }
    }
}

}

