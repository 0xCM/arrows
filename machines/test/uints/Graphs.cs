//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Linq;
    using System.Threading;
    using static zfunc;


    public class GraphTest : UnitTest<GraphTest>
    {
       public void Create8()
        {                    
            var m = BitMatrix8.From(
                0b00001000, //0 -> 3
                0b01000000, //1 -> 6
                0b01000000, //2 -> 6
                0b00100000, //3 -> 5
                0b00100000, //4 -> 5
                0b10000010, //5 -> [1, 7]
                0b00100100, //6 -> [2, 5]
                0b01100000  //7 -> [5, 6]
                );
            var g = m.ToGraph();
            
            Claim.eq(8, g.VertexCount);
            Claim.eq(11, g.EdgeCount);
        }
 

    }

}