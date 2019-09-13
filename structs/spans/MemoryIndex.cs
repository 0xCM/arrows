    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static zfunc;
    
    public unsafe ref struct MemoryIndex<T>
        where T : unmanaged
    {
        T* data;

        [MethodImpl(Inline)]
        public MemoryIndex(ref T data)
        {
            this.data = (T*)Unsafe.AsPointer(ref data);
                        
        }

        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref data[i];
        }
    }

    public ref struct SpanIndex<T>
        where T : unmanaged
    {

        Span<T> data;

        [MethodImpl(Inline)]
        public SpanIndex(Span<T> src)
        {
            this.data = src;                        
        }

        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref data[i];
        }
    }

}