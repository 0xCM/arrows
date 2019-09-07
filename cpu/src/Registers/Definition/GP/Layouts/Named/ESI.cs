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
        public struct ESI : IGpReg32<ESI>
        {

            [FieldOffset(0)]
            public uint esi;

            [FieldOffset(0)]
            public SI si;

            [FieldOffset(0)]
            public SIL sil;

            public const GpRegId Id = GpRegId.esi;


            [MethodImpl(Inline)]
            public static implicit operator uint(ESI src)
                => src.esi;

            [MethodImpl(Inline)]
            public static implicit operator ESI(uint src)
                => new ESI(src);

            [MethodImpl(Inline)]
            public ESI(uint src)
                : this()
            {
                esi = src;
            }

            byte IGpReg32<ESI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => sil; 
 
                [MethodImpl(Inline)]
                set => sil = value;
            }
            
            ushort IGpReg32<ESI>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => si; 
 
                [MethodImpl(Inline)]
                set => si = value;
            }

            GpRegId IGpReg.Id 
                => Id;
 
        }
    }

}