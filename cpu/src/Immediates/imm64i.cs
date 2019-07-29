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
    /// Defines a 64-bit immediate that has been sign-extended from an 8-bit or 32-bit source value
    /// </summary>    
    public readonly struct Imm64i : IImm<long>
    {        
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly long Value;

        /// <summary>
        /// Specifies the size of the immediate in bits
        /// </summary>
        public static readonly BitSize Size = 64;


        /// <summary>
        /// Defines a 64-bit signed-extended immediate from an 8-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm64i Define(long src)
            => src;

        /// <summary>
        /// Defines a 64-bit signed-extended immediate from a 32-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm64i Define(uint src)
            => src;

        /// <summary>
        /// Converts a source value to sign-extended 64-bit immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm64i(long src)
            => new Imm64i(src);

        /// <summary>
        /// Converts a source value to sign-extended 64-bit immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm64i(uint src)
            => new Imm64i(src);

        [MethodImpl(Inline)]
        public Imm64i(long Value)
        {
            this.Value = Value;
        }

        [MethodImpl(Inline)]
        public Imm64i(uint Value)
        {
            this.Value = Value;
        }
    
        public ImmInfo Description 
        {
            [MethodImpl(Inline)]
            get => new ImmInfo(Size,Value);
        }

        long IImm<long>.Value 
        {
            get => Value;
        }

        BitSize IImm<long>.SrcWidth
        {
            get => Value > Byte.MaxValue ? BitSize.Define(32) : BitSize.Define(8);
        }

        [MethodImpl(Inline)]
        public Imm64i Redefine(byte src)
            => new Imm64i(src);

        [MethodImpl(Inline)]
        public Imm64i Redefine(uint src)
            => new Imm64i(src);

   }

}
