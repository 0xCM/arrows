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
        public struct SP : IGpReg16<SP>
        {
            [FieldOffset(0)]
            public ushort sp;

            [FieldOffset(0)]
            public SPL spl;

            public const GpRegId Id = GpRegId.bx;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(SP src)
                => src.sp;

            [MethodImpl(Inline)]
            public static implicit operator SP(ushort src)
                => new SP(src);

            [MethodImpl(Inline)]
            public SP(ushort src)
                : this()
            {
                this.sp = src;
            }
 
            byte IGpReg16<SP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => spl; 
 
                [MethodImpl(Inline)]
                set => spl = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}