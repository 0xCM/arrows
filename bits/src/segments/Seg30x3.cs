//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;
    using static BitMasks;

    public static partial class Segments
    {
        public unsafe struct Seg30x3<T>
            where T : unmanaged
        {            
            MemorySpan<T> data;

            static readonly BitSize CellLength = bitsize<T>();
            
            public Seg30x3(MemorySpan<T> data)
            {
                this.data = data;
            }
            
            public ref T Seg0
            {
                get => ref data[0];
            }

            public ref T Seg1
            {
                get => ref data[1];
            }

            public ref T Seg2
            {
                get => ref data[2];
            }

            public ref T Seg3
            {
                get => ref data[3];
            }

            public ref T Seg4
            {
                get => ref data[4];
            }

            public ref T Seg5
            {
                get => ref data[5];
            }

            public ref T Seg6
            {
                get => ref data[6];
            }

            public ref T Seg7
            {
                get => ref data[7];
            }

            public ref T Seg8
            {
                get => ref data[8];
            }

            public ref T Seg9
            {
                get => ref data[9];
            }

            public T this[Seg30x3 seg]
            {
                get => default;
            }

        }

    }
}