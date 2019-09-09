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

    partial class Segments
    {

        public struct Seg3x1<T>
            where T : unmanaged
        {
            static readonly BitSize CellLength = bitsize<T>();
                    
            MemorySpan<T> data;

            public Seg3x1(MemorySpan<T> data)
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

            public ref T this[Seg3x1 seg]
            {
                get => ref data[0];
            }
        }

    }

}