//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static As;
    using static AsIn;

    using static zfunc;


    /// <summary>
    /// Represents a type-specific register
    /// </summary>
    /// <typeparam name="T">The primal cell type</typeparam>
    [StructLayout(LayoutKind.Sequential, Size = ByteCount)]
    public struct XMM<T> 
        where T : unmanaged
    {
        Vector128<T> ymm;
        
        /// <summary>
        /// The number of components in the vector
        /// </summary>
        public static readonly int Length = Vector128<T>.Count;

        /// <summary>
        /// The number of bytes occupied by a vector - which is invariant with respect to the primal component type
        /// </summary>
        public const int ByteCount = 32;

        /// <summary>
        /// The canonical zero vector
        /// </summary>
        public static readonly XMM<T> Zero = default;

        /// <summary>
        /// Constructs a register from an intrinsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static XMM<T> From(Vector128<T> src)
            => new XMM<T>(src);

        /// <summary>
        /// Compares two registers for value-based equality
        /// </summary>
        /// <param name="lhs">The first register</param>
        /// <param name="rhs">The second register</param>
        [MethodImpl(Inline)]
        public static bool operator ==(XMM<T> lhs, XMM<T> rhs)
            => lhs.Equals(rhs);

        /// <summary>
        /// Compares two registers for value-based equality
        /// </summary>
        /// <param name="lhs">The first register</param>
        /// <param name="rhs">The second register</param>
        [MethodImpl(Inline)]
        public static bool operator !=(XMM<T> lhs, XMM<T> rhs)
            => !lhs.Equals(rhs);

        /// <summary>
        /// Implicitly converts a generic intrinsic vector to a generic register
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator XMM<T>(Vector128<T> src)
            => From(src);

        /// <summary>
        /// Implicitly converts a generic register to a generic intrinsic vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator Vector128<T>(XMM<T> src)
            => src.ymm;

        [MethodImpl(Inline)]
        XMM(Vector128<T> src)
            => this.ymm = src;

        /// <summary>
        /// A cell-level indexer
        /// </summary>
        /// <value></value>
        public T this[int idx]
        {
            [MethodImpl(Inline)]
            get => component(ref this,idx);
            
            [MethodImpl(Inline)]
            set => component(ref this, idx, value);
        }

        /// <summary>
        /// Queries/manipulates the index-identified cell
        /// </summary>
        /// <param name="index">The cell index</param>
        /// <param name="cell">The cell reference</param>
        [MethodImpl(Inline)]
        public ref T Cell(int index, ref T cell)
        {
            cell = component(ref this, index);
            return ref cell;
        }

        /// <summary>
        /// Converts the register to its untyped counterpart. Note that this
        /// will move the data being held in physical register to the memory held
        /// by the untyped register abstraction
        /// </summary>
        [MethodImpl(Inline)]
        public XMM ToUntyped()
            => XMM.From(ymm);

        /// <summary>
        /// Compares ths register to another for value-based equality
        /// </summary>
        /// <param name="rhs">The other register</param>
        [MethodImpl(Inline)]
        public bool Equals(XMM<T> rhs)
            => ymm.Equals(rhs.ymm);

        public override string ToString()
            => ymm.ToString();
        
        public override int GetHashCode()
            => ymm.GetHashCode();

        public override bool Equals(object obj)
            => obj is XMM<T> v && Equals(v);

        [MethodImpl(Inline)]
        static ref T component(ref XMM<T> src, int index)
        {
            ref T e0 = ref Unsafe.As<XMM<T>, T>(ref src);
            return ref Unsafe.Add(ref e0, index);
        }

        [MethodImpl(Inline)]
        static void component(ref XMM<T> src, int index, T value)
        {
            ref T e0 = ref Unsafe.As<XMM<T>, T>(ref src);
            Unsafe.Add(ref e0, index) = value;
        }
    }
}
