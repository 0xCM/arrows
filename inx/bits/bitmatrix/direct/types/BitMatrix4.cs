//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public ref struct BitMatrix4
    {        
        internal Span<byte> bits;

        public static readonly N4 N = default;

        public static BitMatrix4 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(BitMatrixStore.Identity4x4);
        }

        public static BitMatrix4 Zero 
        {
            [MethodImpl(Inline)]
            get => Define(0,0);
        }

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(params byte[] src)        
            => src.Length == 0 ? new BitMatrix4(0,0)  : new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(Span<byte> src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(ReadOnlySpan<byte> src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        BitMatrix4(params byte[] src)
        {                    
            require(src.Length == Pow2.T01);
            this.bits = src;
        }

        [MethodImpl(Inline)]
        BitMatrix4(ReadOnlySpan<byte> src)
        {                    
            require(src.Length == Pow2.T01);
            this.bits = src.Replicate();
        }

        [MethodImpl(Inline)]
        BitMatrix4(Span<byte> src)
        {
            require(src.Length == Pow2.T01);
            this.bits = src;
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => this.GetBit(row,col);

            [MethodImpl(Inline)]
            set => this.SetBit(row,col,value);
        }            
    }
}