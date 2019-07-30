//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly ref struct AsmCode
    {
        public static AsmCode<T> FromBytes<T>(in ReadOnlySpan<byte> Bytes)
            where T:struct
                => Bytes;
        
        [MethodImpl(Inline)]
        public static implicit operator AsmCode(in ReadOnlySpan<byte> Bytes)
            => new AsmCode(in Bytes);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(in AsmCode code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public AsmCode(in ReadOnlySpan<byte> Bytes)
        {
            this.Bytes = Bytes;
        }

        /// <summary>
        /// Specifies the encoded asm bytes
        /// </summary>
        public readonly ReadOnlySpan<byte> Bytes;


        /// <summary>
        /// Returns a pointer to the endoded bytes
        /// </summary>
        public readonly IntPtr Pointer
            => GetPointer();

        unsafe IntPtr GetPointer()        
            => (IntPtr)Unsafe.AsPointer(ref  As.asRef( in Bytes[0]));
        

        /// <summary>
        /// Creates a delegate to execute the encapsulated code
        /// </summary>
        /// <typeparam name="T">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public T CreateDelegate<T>()
            where T : Delegate        
                => Marshal.GetDelegateForFunctionPointer<T>(Pointer);

    }

    
    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly ref struct AsmCode<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static implicit operator AsmCode<T>(in ReadOnlySpan<byte> Bytes)
            => new AsmCode<T>(in Bytes);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(in AsmCode<T> code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public AsmCode(in ReadOnlySpan<byte> Bytes)
        {
            this.Bytes = Bytes;
        }


        /// <summary>
        /// Specifies the encoded asm bytes
        /// </summary>
        public readonly ReadOnlySpan<byte> Bytes;

        /// <summary>
        /// Returns a pointer to the endoded bytes
        /// </summary>
        public readonly IntPtr Pointer
            => GetPointer();

        unsafe IntPtr GetPointer()        
            => (IntPtr)Unsafe.AsPointer(ref  Z0.As.asRef( in Bytes[0]));
        
        /// <summary>
        /// Creates a delegate to execute the encapsulated code
        /// </summary>
        /// <typeparam name="T">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public S CreateDelegate<S>()
            where S : Delegate        
                => Marshal.GetDelegateForFunctionPointer<S>(Pointer);

        [MethodImpl(Inline)]
        public AsmCode<S> As<S>()
            where S : struct
                => new AsmCode<S>(Bytes);        

    }

}