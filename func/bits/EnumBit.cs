//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a bit in an enum bitfield
    /// </summary>
    public readonly struct EnumBit
    {
        [MethodImpl(Inline)]
        public EnumBit(byte Pos, string Name, Bit Value)
        {
            this.Pos = Pos;
            this.Name = Name;
            this.Value = Value;
        }
        
        /// <summary>
        /// The 0-based position of the bit
        /// </summary>
        public readonly byte Pos;

        /// <summary>
        /// The name/label identifier
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The value of the bit
        /// </summary>
        public readonly Bit Value;

        public override string ToString()
            => $"({Pos.ToString().PadLeft(2, AsciDigits.A0)}, {Name}, {Value})";
    }

}