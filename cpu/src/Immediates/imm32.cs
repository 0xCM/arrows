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
    /// Defines a 32-bit immediate
    /// </summary>    
    public readonly struct Imm32 :  IImm<Imm32,uint>
    {
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly uint Value;

        /// <summary>
        /// Specifies the size of the immediate in bits
        /// </summary>
        public static readonly BitSize Size = 32;


        /// <summary>
        /// Defines an 32-bit immediate from a 32-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm32 Define(uint src)
            => src;

        /// <summary>
        /// Converts a 32-bit source value to a 32-bit immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm32(uint src)
            => new Imm32(src);

        [MethodImpl(Inline)]
        public Imm32(uint src)
            => this.Value = src;

        public AsmImmInfo Description 
        {
            [MethodImpl(Inline)]
            get => new AsmImmInfo(Size,Value);
        }

        uint IImm<uint>.Value 
        {
            get => Value;
        }

        Imm32 IImm<Imm32,uint>.Redefine(uint src)
            => new Imm32(src);

    }


}
