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
    /// Defines a 64-bit immediate
    /// </summary>    
    public readonly struct Imm64 :  IImm<Imm64, ulong>
    {
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly ulong Value;

        /// <summary>
        /// Specifies the size of the immediate in bits
        /// </summary>
        public static readonly BitSize Size = 64;

        /// <summary>
        /// Defines a 64-bit immediate from a 64-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm64 Define(ulong src)
            => src;

        /// <summary>
        /// Converts a source value to a 64-bit immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm64(ulong src)
            => new Imm64(src);

        [MethodImpl(Inline)]
        public Imm64(ulong src)
            => this.Value = src;
        
        public AsmOperandImm Description 
        {
            [MethodImpl(Inline)]
            get => new AsmOperandImm(Size,Value);
        }

        ulong IImm<ulong>.Value 
        {
            get => Value;
        }
            
        Imm64 IImm<Imm64,ulong>.Redefine(ulong src)
            => new Imm64(src);
    }
}
