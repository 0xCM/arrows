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
    /// Defines a 32-bit immediate that has been sign-extended from an 8-bit source value
    /// </summary>    
    public readonly struct Imm32i  : IImm<int>
    {
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly int Value;

        /// <summary>
        /// Specifies the size of the immediate in bits
        /// </summary>
        public static readonly BitSize Size = 32;


        /// <summary>
        /// Defines a 32-bit signed-extended immediate from an 8-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm32i Define(int src)
            => src;

        /// <summary>
        /// Converts an 8-bit source value to a 32-bit sign-extended immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm32i(int src)
            => new Imm32i(src);

        [MethodImpl(Inline)]
        public Imm32i(int src)
            => this.Value = src;

        public AsmImmInfo Description 
        {
            [MethodImpl(Inline)]
            get => new AsmImmInfo(Size,Value);
        }

        int IImm<int>.Value 
        {
            get => Value;
        }

        public Imm32i Redefine(byte src)
            => new Imm32i(src);
    }
}
