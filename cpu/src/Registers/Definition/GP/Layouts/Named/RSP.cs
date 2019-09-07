//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    

    using static zfunc;
    
    partial class Registers
    {

        [StructLayout(LayoutKind.Explicit)]
        public struct RSP : IGpReg64<RSP>
        {
            [FieldOffset(0)]
            public ulong rsp;

            [FieldOffset(0)]
            public ESP esp;

            [FieldOffset(0)]
            public SP sp;

            [FieldOffset(0)]
            public SPL spl;

            public const GpRegId Id = GpRegId.rsp;

            [MethodImpl(Inline)]
            public static implicit operator ulong(RSP src)
                => src.rsp;

            [MethodImpl(Inline)]
            public static implicit operator RSP(ulong src)
                => new RSP(src);

            [MethodImpl(Inline)]
            public RSP(ulong src)
                : this()
            {
                rsp = src;
            }

            byte IGpReg64<RSP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => spl; 
 
                [MethodImpl(Inline)]
                set => spl = value;
            }
            
            ushort IGpReg64<RSP>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => sp; 
 
                [MethodImpl(Inline)]
                set => sp = value;
            }

            uint IGpReg64<RSP>.Lo32
            { 
                [MethodImpl(Inline)]
                get => esp; 
 
                [MethodImpl(Inline)]
                set => esp = value;
            }

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}