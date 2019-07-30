//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static zfunc;

    /// <summary>
    /// Defines an 8-bit immediate
    /// </summary>    
    public readonly struct Imm8 : IImm<Imm8,byte>
    {            
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly byte Value;

        /// <summary>
        /// Specifies the size of the immediate in bytes
        /// </summary>
        public static readonly BitSize Size = 8;

        /// <summary>
        /// Defines an 8-bit immediate from an 8-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm8 Define(byte src)
            => src;

        [MethodImpl(Inline)]
        public static implicit operator Imm8(byte src)
            => new Imm8(src);

        [MethodImpl(Inline)]
        public Imm8(byte src)
            => this.Value = src;

        public AsmOperandImm Description 
        {
            [MethodImpl(Inline)]
            get => new AsmOperandImm(Size,Value);
        }
            

        byte IImm<byte>.Value 
            => Value;

        Imm8 IImm<Imm8,byte>.Redefine(byte src)
            => new Imm8(src);
    }

}
