//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    /// <summary>
    /// Identifies a bit position within a span of memory 
    /// via an element offset and relative index
    /// </summary>
    
    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public readonly struct BitPos
    {
        /// <summary>
        /// The span offset
        /// </summary>
        [FieldOffset(0)]
        public readonly ushort Offset;

        /// <summary>
        /// The bit position relative to the offset
        /// </summary>
        [FieldOffset(2)]
        public readonly byte Index;

        [MethodImpl(Inline)]
        public static BitPos Define(ushort Offset, byte Index)
            => new BitPos(Offset, Index);

        [MethodImpl(Inline)]
        public BitPos(ushort Offset, byte Index)
        {
            this.Offset = Offset;
            this.Index = Index;
        }   

        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
    }

}