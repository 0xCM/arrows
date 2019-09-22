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
    
    using static zfunc;

    public class t_half : UnitTest<t_half>
    {

        public void test1()
        {
            ref readonly var circuit = ref Circuits.halfadder<byte>();
            BitVector8 a = 0b11010110;
            BitVector8 b = 0b10101001;


            (BitVector8 s, BitVector8 c) = circuit.Send(a, b);
            Trace(a.Format());
            Trace(b.Format());
            Trace(s.Format());
            Trace(c.Format());
        }
    }
}