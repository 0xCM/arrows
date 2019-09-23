//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly ref struct AsmCode
    {
        /// <summary>
        /// Specifies the encoded asm bytes
        /// </summary>
        public readonly ReadOnlySpan<byte> Bytes;

        [MethodImpl(Inline)]
        public static AsmCode<T> FromBytes<T>(ReadOnlySpan<byte> Bytes)
            where T:unmanaged
                => Bytes;
        
        [MethodImpl(Inline)]
        public static implicit operator AsmCode(ReadOnlySpan<byte> Bytes)
            => new AsmCode(Bytes);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public AsmCode(ReadOnlySpan<byte> Bytes)
        {
            this.Bytes = Bytes;
        }

        /// <summary>
        /// Returns a pointer to the endoded bytes
        /// </summary>
        public readonly IntPtr Pointer
            => GetPointer();

        [MethodImpl(Inline)]
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
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator AsmCode<T>(ReadOnlySpan<byte> Bytes)
            => new AsmCode<T>(Bytes);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode<T> code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public AsmCode(ReadOnlySpan<byte> Bytes)
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
            where S : unmanaged
                => new AsmCode<S>(Bytes);        

    }

 
}