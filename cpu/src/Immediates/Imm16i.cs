//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a 16-bit immediate that has been sign-extended from an 8-bit source value
    /// </summary>    
    public readonly struct Imm16i : IImm<short>
    {
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly short Value;

        /// <summary>
        /// Specifies the size of the immediate in bits
        /// </summary>
        public static readonly BitSize Size = 16;

        /// <summary>
        /// Defines a 16-bit sign-extended immediate from an 8-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm16i Define(short src)
            => src;

        /// <summary>
        /// Converts an 8-bit source value to a 16-bit sign-extended immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm16i(short src)
            => new Imm16i(src);

        [MethodImpl(Inline)]
        public Imm16i(short src)
            => this.Value = src;

        public ImmInfo Description 
        {
            [MethodImpl(Inline)]
            get => new ImmInfo(Size,Value);
        }

        short IImm<short>.Value 
        {
            [MethodImpl(Inline)]
            get => Value;
        }

    }


}