//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static PrimalKind;

    public static class PrimalKinds
    {
        public static readonly PrimalKind[] AllList = kinds<PrimalKind>();

        public static readonly PrimalKind[] IntList = array(int8, uint8, int16, uint16, int32, uint32, int64, uint64);
        
            

        [MethodImpl(Inline)]
        public static PrimalKind kind<T>()
            => PrimalKind<T>.Kind;

    }
}