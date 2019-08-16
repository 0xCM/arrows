//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class FixedBuffers
    {
                        
    
        [StructLayout(LayoutKind.Explicit, Size = ByteSize, Pack = 0)]
        public struct F512
        {
            public const int ByteSize = 64;
            
            [MethodImpl(Inline)]
            public static ref F512 FromSpan<T>(Span<T> src)
                where T : struct
            {
                var check = src.Length * Unsafe.SizeOf<T>();
                if(check != ByteSize)
                    throw Errors.LengthMismatch(64, check);
                return ref MemoryMarshal.Cast<T,F512>(src)[0];
            }

            [MethodImpl(Inline)]
            public static Span<T> ToSpan<T>(ref F512 src)
                where T : struct
                    => MemoryMarshal.Cast<byte,T>(src.Bytes);            

            [FieldOffset(0)]
            public ulong x0;

            [FieldOffset(8)]
            public ulong x1;

            [FieldOffset(16)]
            public ulong x2;

            [FieldOffset(24)]
            public ulong x3;

            [FieldOffset(32)]
            public ulong x4;

            [FieldOffset(40)]
            public ulong x5;

            [FieldOffset(48)]
            public ulong x6;

            [FieldOffset(56)]
            public ulong x7;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get =>bytes(in this);
            }
        }     

    }

}