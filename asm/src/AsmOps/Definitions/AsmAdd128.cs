//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;
    using static AsmOps;

    partial class AsmOps
    {

        static class Add128Host
        {
            public static void Init()
            {
                vpaddbBytes.Liberate();
                vpaddwBytes.Liberate();
                vpadddBytes.Liberate();
            }

        }



        [MethodImpl(Inline)]
        public static AsmCode<T> Add128Code<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) || typeof(T) == typeof(byte))
                return AsmCode.FromBytes<T>(vpaddbBytes);                
            else if(typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
                return AsmCode.FromBytes<T>(vpaddwBytes);
            else if(typeof(T) == typeof(int) || typeof(T) == typeof(uint))
                return AsmCode.FromBytes<T>(vpadddBytes);
            else
                throw unsupported<T>();
        }

        static ReadOnlySpan<byte> vpaddbBytes 
            => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFC,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};        

        static ReadOnlySpan<byte> vpaddwBytes 
            => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFD,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};

        static ReadOnlySpan<byte> vpadddBytes 
            => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFE,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};

    }
}