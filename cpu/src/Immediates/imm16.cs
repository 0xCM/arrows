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
    /// Defines a 16-bit immediate
    /// </summary>    
    public readonly struct Imm16 : IImm<Imm16,ushort>
    {
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly ushort Value;

        /// <summary>
        /// Specifies the size of the immediate in bits
        /// </summary>
        public static readonly BitSize Size = 16;


        /// <summary>
        /// Defines a 16-bit immediate from a 16-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm16 Define(ushort src)
            => src;

        /// <summary>
        /// Converts a 16-bit source value to a 16-bit immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm16(ushort src)
            => new Imm16(src);

        [MethodImpl(Inline)]
        public Imm16(ushort src)
            => this.Value = src;

        public AsmOperandImm Description 
        {
            [MethodImpl(Inline)]
            get => new AsmOperandImm(Size,Value);
        }

        ushort IImm<ushort>.Value 
        {
            [MethodImpl(Inline)]
            get => Value;
        }


        [MethodImpl(Inline)]
        Imm16 IImm<Imm16,ushort>.Redefine(ushort src)
            => new Imm16(src);

    }


}
