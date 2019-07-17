//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;

    using static zfunc;

    public abstract class Rng
    {
        internal Queue<Bit> BitQ {get;}
            = new Queue<Bit>(64);

        internal Queue<byte> ByteQ {get;}
            = new Queue<byte>(8);

    }    

}