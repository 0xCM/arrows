//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using static zfunc;
    using static As;

    public readonly struct RngStream : IDisposable
    {
        [MethodImpl(Inline)]
        public static RngStream Define(BRNG brng, uint seed = 0, int index = 0)
            =>  new RngStream(brng, seed, index);


        [MethodImpl(Inline)]
        internal RngStream(BRNG brng, uint seed = 0, int index = 0)
        {
            this.VslSource = brng.NewStream(seed, index);
        }
        
        internal VslStream VslSource {get;}
        
        
        public RngKind RngKind
            => VslSource.RngKind();
        

        public void Dispose()
        {
            VslSource.Dispose();
        }
    }


}