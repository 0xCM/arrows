//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    /// <summary>
    /// Represents 8 bits with 8 bytes, with the value of each byhte taken from {0,1}
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size=8)]
    public struct BitBlock8 : IBitBlock
    {
        /// <summary>
        ///  Bit 0
        /// </summary>
        public byte Bit0;

        /// <summary>
        ///  Bit 1
        /// </summary>
        public byte Bit1;

        /// <summary>
        ///  Bit 2
        /// </summary>
        public byte Bit2;

        /// <summary>
        ///  Bit 2
        /// </summary>
        public byte Bit3;
        
        /// <summary>
        ///  Bit 4
        /// </summary>
        public byte Bit4;

        /// <summary>
        ///  Bit 5
        /// </summary>
        public byte Bit5;

        /// <summary>
        ///  Bit 6
        /// </summary>
        public byte Bit6;

        /// <summary>
        ///  Bit 7
        /// </summary>
        public byte Bit7;
        

        [MethodImpl(Inline)]
        public byte GetPart(int i)
            => Unsafe.Add(ref Unsafe.As<BitBlock8, byte>(ref this), i);

        [MethodImpl(Inline)]
        public void SetPart(int i, byte value)
            => Unsafe.Add(ref Unsafe.As<BitBlock8, byte>(ref this), i) = value;
        
        public byte this [int i]
        {
            [MethodImpl(Inline)]
            get => GetPart(i);
            
            [MethodImpl(Inline)]
            set => SetPart(i,value);
        }

        public string Format()
            => this.AsGeneric().Format(); 

        public override string ToString() 
            => Format();

    }

}