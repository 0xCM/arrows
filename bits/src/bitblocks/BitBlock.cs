//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public struct BitBlock<T> : IBitBlock<T>
        where T : unmanaged, IBitBlock
    {
        T data;

        /// <summary>
        /// The count of represented bits and the number of bytes occupied by the representation
        /// </summary>
        /// <typeparam name="T">The block type</typeparam>
        public static readonly int Size = Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        public static BitBlock<T> FromSpan(Span<byte> src)
            => new BitBlock<T>(MemoryMarshal.AsRef<T>(src));

        [MethodImpl(Inline)]
        public static BitBlock<T> Alloc()
            => default;

        [MethodImpl(Inline)]
        public BitBlock(T src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Span<byte> AsSpan()
            => BitView.ViewBits(ref this).Bytes;        
        
        [MethodImpl(Inline)]        
        public void CopyTo(Span<byte> dst)        
            => BitView.ViewBits(ref this).CopyTo(dst);            
        
        [MethodImpl(Inline)]
        public byte GetPart(int i)
            => Unsafe.Add(ref Unsafe.As<T, byte>(ref data), i);

        [MethodImpl(Inline)]
        public void SetPart(int i, byte value)
            => Unsafe.Add(ref Unsafe.As<T, byte>(ref data), i) = value;
        
        public byte this [int i]
        {
            [MethodImpl(Inline)]
            get => GetPart(i);
            
            [MethodImpl(Inline)]
            set => SetPart(i,value);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        public T Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Reverses the bits in the block
        /// </summary>
        public void Reverse()
        {
            var span = AsSpan();
            span.Reverse();
            data = MemoryMarshal.AsRef<T>(span);
        }

        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromBitSeq(AsSpan());
    
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
            => ToBitString().Format(tlz, specifier,blockWidth,blocksep);
    }

}