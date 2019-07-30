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
    /// Defines a generic immediate
    /// </summary>    
    public readonly struct Imm<T> :  IImm<Imm<T>, T>
        where T : struct
    {        
        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly T Value;

        /// <summary>
        /// Specifies the size of the immediate in bits
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        public static readonly BitSize Width = Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Defines a generic immediate from a generic source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm<T> From(T src)
            => src;

        [MethodImpl(Inline)]
        public static Imm<T> From(IImm<T> src)
        {
            if(typeof(T) == typeof(byte))
                return new Imm<byte>(Z0.As.uint8(ref src)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return new Imm<ushort>(Z0.As.uint16(ref src)).As<T>();
            else if(typeof(T) == typeof(uint))
                return new Imm<uint>(Z0.As.uint32(ref src)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return new Imm<ulong>(Z0.As.uint64(ref src)).As<T>();
            else 
                throw unsupported<T>();                
        }

        [MethodImpl(Inline)]
        public static Imm<T> From(Imm8 src)        
            => new Imm<byte>(src.Value).As<T>();                    

        [MethodImpl(Inline)]
        public static Imm<T> From(Imm16 src)        
            => new Imm<ushort>(src.Value).As<T>();                    

        [MethodImpl(Inline)]
        public static Imm<T> From(Imm32 src)        
            => new Imm<uint>(src.Value).As<T>();                    

        [MethodImpl(Inline)]
        public static Imm<T> From(Imm64 src)        
            => new Imm<ulong>(src.Value).As<T>();                    

        /// <summary>
        /// Converts a source value to a 64-bit immediate
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Imm<T>(T src)
            => new Imm<T>(src);

        [MethodImpl(Inline)]
        public Imm(T src)
            => this.Value = src;

        /// <summary>
        /// Specifies whether the immediate is sign-extended
        /// </summary>
        public bool IsSignExtended
        {
            [MethodImpl(Inline)]
            get => PrimalInfo.signed<T>();
        }

        /// <summary>
        /// Specifies a label for the immedate that has the form imm{BitWidth}
        /// </summary>
        public string Label
        {
            [MethodImpl(Inline)]
            get => $"imm{Width}";
        }

        T IImm<T>.Value 
        {
            [MethodImpl(Inline)]
            get => Value;
        }

        public AsmOperandImm Description 
            => new AsmOperandImm(Width, imagine(ref Unsafe.AsRef(in Value), out ulong _));

        [MethodImpl(Inline)]
        public Imm<T> Redefine(T src)         
            => new Imm<T>(src);

        [MethodImpl(Inline)]
        public Imm<S> As<S>()
            where S : struct
                => imagine<Imm<T>, Imm<S>>(ref Unsafe.AsRef(in this));            

        [MethodImpl(Inline)]
        public Imm<S> SignExtend<S>()
            where S : struct
        {
            if (this.IsSignExtended || !PrimalInfo.signed<S>())
                throw new NotSupportedException();
            return new Imm<S>(convert<T,S>(Value, out S dst));
        }
    }
}
