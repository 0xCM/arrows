//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;
    using static inxfunc;


    sealed class Span128Test : UnitTest<Span128Test>
    {

        public void SpanProperties()
        {
            Claim.eq(4, Span128<int>.BlockLength);
            Claim.eq(16, Span128.blocklength<sbyte>());
            Claim.eq(16, Span128.blocklength<byte>());
            Claim.eq(8, Span128.blocklength<short>());
            Claim.eq(8, Span128.blocklength<ushort>());
            Claim.eq(4, Span128.blocklength<int>());
            Claim.eq(4, Span128.blocklength<uint>());
            Claim.eq(2, Span128.blocklength<long>());
            Claim.eq(2, Span128.blocklength<ulong>());
            Claim.eq(4, Span128.blocklength<float>());
            Claim.eq(2, Span128.blocklength<double>());
            
            Claim.eq(4, Span128<int>.CellSize);
            Claim.eq(1, Span128.cellsize<sbyte>());
            Claim.eq(1, Span128.cellsize<byte>());
            Claim.eq(2, Span128.cellsize<short>());
            Claim.eq(4, Span128.cellsize<int>());
            Claim.eq(4, Span128.cellsize<uint>());
            Claim.eq(4, Span128.cellsize<float>());
            Claim.eq(8, Span128.cellsize<ulong>());
            Claim.eq(8, Span128.cellsize<double>());
            Claim.eq(8, Span128.cellsize<long>());

            
            Claim.eq(16, Span128<int>.BlockSize);
            Claim.eq(16, Span128.blocksize<sbyte>());          
            Claim.eq(16, Span128.blocksize<byte>());          
            Claim.eq(16, Span128.blocksize<short>());            
            Claim.eq(16, Span128.blocksize<int>());            
            Claim.eq(16, Span128.blocksize<float>());          
            Claim.eq(16, Span128.blocksize<double>());          
            Claim.eq(16, Span128.blocksize<long>());          

            Claim.eq(16, Span128.datasize<byte>(1));
            Claim.eq(16, Span128.datasize<int>(1));
            Claim.eq(16, Span128.datasize<float>(1));
            Claim.eq(16, Span128.datasize<double>(1));
            Claim.eq(32, Span128.datasize<int>(2));
            Claim.eq(32, Span128.datasize<double>(2));
            Claim.eq(64, Span128.datasize<int>(4));
            Claim.eq(64, Span128.datasize<float>(4));



            Claim.eq(16, Span128.blockoffset<int>(1));
            Claim.eq(32, Span128.blockoffset<int>(2));

            Claim.eq(16, Span128.align<int>(16));
            Claim.eq(32, Span128.align<int>(17));
            Claim.eq(32, Span128.align<int>(25));

            Claim.@false(Span128.aligned<int>(17));
            Claim.@false(Span128.aligned<int>(18));
            Claim.@true(Span128.aligned<int>(16));
            Claim.@true(Span128.aligned<int>(32));
            Claim.@true(Span128.aligned<int>(48));
            Claim.@true(Span128.aligned<int>(64));

        }

        public void Creation()
        {
            var x = Span128.load(array<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x.ToSpan(), span(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            // Claim.eq(4, block0.Length);
            // Claim.eq(block0, span(1,2,3,4));

            // var block2 = x.Block(1);
            // Claim.eq(4, block2.Length);
            // Claim.eq(block2, span(5,6,7,8));

            
        }

    }


}