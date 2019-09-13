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

    public readonly struct MklRng : IRandomSource,  IDisposable
    {
        [MethodImpl(Inline)]
        public static MklRng Define(BRNG brng, uint seed = 0, int index = 0)
            =>  new MklRng(brng, seed, index);

        [MethodImpl(Inline)]
        internal MklRng(BRNG brng, uint seed = 0, int index = 0)
        {
            this.Source = brng.NewStream(seed, index);
            
        }
        
        internal VslStream Source {get;}        
        
        public RngKind RngKind
            => Source.RngKind();        

        public void Dispose()
            => Source.Dispose();
    }

}