//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    

    partial class Registers
    {

        [StructLayout(LayoutKind.Explicit)]
        public struct RSI : IGpReg64<RSI>
        {
            [FieldOffset(0)]
            public ulong rsi;

            [FieldOffset(0)]
            public ESI esi;

            [FieldOffset(0)]
            public SI si;

            [FieldOffset(0)]
            public SIL sil;

            public const GpRegId Id = GpRegId.rsi;


            [MethodImpl(Inline)]
            public static implicit operator ulong(RSI src)
                => src.rsi;

            [MethodImpl(Inline)]
            public static implicit operator RSI(ulong src)
                => new RSI(src);

            [MethodImpl(Inline)]
            public RSI(ulong src)
                : this()
            {
                rsi = src;
            }

            byte IGpReg64<RSI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => sil; 
 
                [MethodImpl(Inline)]
                set => sil = value;
            }
            
            ushort IGpReg64<RSI>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => si; 
 
                [MethodImpl(Inline)]
                set => si = value;
            }

            uint IGpReg64<RSI>.Lo32
            { 
                [MethodImpl(Inline)]
                get => esi; 
 
                [MethodImpl(Inline)]
                set => esi = value;
            }
   
            GpRegId IGpReg.Id 
                => Id;
 
        }
    }

}