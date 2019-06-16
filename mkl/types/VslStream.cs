//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct VslStream : IDisposable
    {
        public static implicit operator VslStream(IntPtr src)
            => new VslStream(src);

        public static implicit operator IntPtr(VslStream src)
            => src.Pointer;
    
        readonly IntPtr Pointer;

        public VslStream(IntPtr Pointer)
            => this.Pointer = Pointer;

        public void Dispose()
        {
            // if(Pointer != IntPtr.Zero)
            //     VSL.vslDeleteStream(Pointer);
        }

        public IntPtr Raw()
            => Pointer;
    }



}