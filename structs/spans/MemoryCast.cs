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
    using System.Buffers;

    using static zfunc;

    public static class MemoryCast
    {
        /// <summary>
        /// Casts memory cells of one type to another
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> As<S,T>(Memory<S> src)
            where S : unmanaged
            where T : unmanaged
        {
            if (typeof(S) == typeof(T)) 
                return (Memory<T>)(object)src;
            return new MemoryCast<S, T>(src).Memory;
        }

    }

    //https://stackoverflow.com/questions/54511330/how-can-i-cast-memoryt-to-another
    public sealed class MemoryCast<S, T> : MemoryManager<T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly Memory<S> source;

        [MethodImpl(Inline)]
        public MemoryCast(Memory<S> source) 
            => this.source = source;

        public override Span<T> GetSpan()
            => MemoryMarshal.Cast<S, T>(source.Span);

        protected override void Dispose(bool disposing) {}

        public override MemoryHandle Pin(int elementIndex = 0)
            => throw new NotSupportedException();

        public override void Unpin()
            => throw new NotSupportedException();
    }

}