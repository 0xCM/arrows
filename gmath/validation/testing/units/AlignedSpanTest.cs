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
    using static mfunc;


    sealed class AlignedSpanTest : UnitTest<AlignedSpanTest>
    {
        public  void CellSize()
        {
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


            Claim.eq(4, Span256<int>.CellSize);
            Claim.eq(1, Span256.cellsize<sbyte>());
            Claim.eq(1, Span256.cellsize<byte>());
            Claim.eq(2, Span256.cellsize<short>());
            Claim.eq(4, Span256.cellsize<int>());
            Claim.eq(4, Span256.cellsize<uint>());
            Claim.eq(4, Span256.cellsize<float>());
            Claim.eq(8, Span256.cellsize<ulong>());
            Claim.eq(8, Span256.cellsize<double>());
            Claim.eq(8, Span256.cellsize<long>());

        }

        public void BlockSize()
        {
            Claim.eq(16, Span128<int>.BlockSize);
            Claim.eq(16, Span128.blocksize<sbyte>());          
            Claim.eq(16, Span128.blocksize<byte>());          
            Claim.eq(16, Span128.blocksize<short>());            
            Claim.eq(16, Span128.blocksize<int>());            
            Claim.eq(16, Span128.blocksize<float>());          
            Claim.eq(16, Span128.blocksize<double>());          
            Claim.eq(16, Span128.blocksize<long>());          

            Claim.eq(32, Span256<int>.BlockSize);
            Claim.eq(32, Span256.blocksize<sbyte>());          
            Claim.eq(32, Span256.blocksize<byte>());          
            Claim.eq(32, Span256.blocksize<short>());            
            Claim.eq(32, Span256.blocksize<int>());            
            Claim.eq(32, Span256.blocksize<float>());          
            Claim.eq(32, Span256.blocksize<double>());          
            Claim.eq(32, Span256.blocksize<long>());          

        }

        public void BlockLength()
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
            Claim.eq(8, Span128.blocklength<int>(2));
            Claim.eq(4, Span128.blocklength<long>(2));
            Claim.eq(32, Span128.blocklength<byte>(2));


            Claim.eq(8, Span256<int>.BlockLength);
            Claim.eq(32, Span256.blocklength<sbyte>());
            Claim.eq(32, Span256.blocklength<byte>());
            Claim.eq(16, Span256.blocklength<short>());
            Claim.eq(16, Span256.blocklength<ushort>());
            Claim.eq(8, Span256.blocklength<int>());
            Claim.eq(8, Span256.blocklength<uint>());
            Claim.eq(4, Span256.blocklength<long>());
            Claim.eq(4, Span256.blocklength<ulong>());
            Claim.eq(8, Span256.blocklength<float>());
            Claim.eq(4, Span256.blocklength<double>());                
        }

        public void BlockCount()
        {
            Claim.eq(1, Span128.blockcount<sbyte>(16));
            Claim.eq(1, Span128.blockcount<byte>(16));

            Claim.eq(1, Span128.blockcount<short>(8));
            Claim.eq(1, Span128.blockcount<ushort>(8));

            Claim.eq(1, Span128.blockcount<int>(4));
            Claim.eq(1, Span128.blockcount<uint>(4));
            Claim.eq(1, Span128.blockcount<float>(4));

            Claim.eq(1, Span128.blockcount<long>(2));
            Claim.eq(1, Span128.blockcount<ulong>(2));
            Claim.eq(1, Span128.blockcount<double>(2));

            Claim.eq(1, Span256.blockcount<sbyte>(32));
            Claim.eq(1, Span256.blockcount<byte>(32));

            Claim.eq(1, Span256.blockcount<short>(16));
            Claim.eq(1, Span256.blockcount<ushort>(16));

            Claim.eq(1, Span256.blockcount<int>(8));
            Claim.eq(1, Span256.blockcount<uint>(8));
            Claim.eq(1, Span256.blockcount<float>(8));

            Claim.eq(1, Span256.blockcount<long>(4));
            Claim.eq(1, Span256.blockcount<ulong>(4));
            Claim.eq(1, Span256.blockcount<double>(4));
        }


        public void Alignment()
        {

            // Claim.eq(16, Span128.align<int>(16));
            // Claim.eq(32, Span128.align<int>(17));
            // Claim.eq(32, Span128.align<int>(25));

            Claim.eq(4, Span128.align<int>(4));
            Claim.@true(Span128.aligned<int>(4));

            Claim.eq(8, Span128.align<int>(5));
            Claim.@false(Span128.aligned<int>(5));

            Claim.eq(8, Span128.align<int>(6));
            Claim.@false(Span128.aligned<int>(6));

            Claim.eq(8, Span128.align<int>(7));
            Claim.@false(Span128.aligned<int>(7));

            Claim.eq(8, Span128.align<int>(8));
            Claim.@true(Span128.aligned<int>(8));

            Claim.eq(12, Span128.align<int>(9));
            Claim.@false(Span128.aligned<int>(9));


        }

        public void BlockSlice()
        {
            var x = Span128.load(array<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.Length);
            Claim.eq(block0, span(1,2,3,4));

            var block2 = x.Block(1);
            Claim.eq(4, block2.Length);
            Claim.eq(block2, span(5,6,7,8));

        }
        public void Load()
        {
            var x = Span128.load(array<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x.Unblock(), span(1,2,3,4,5,6,7,8));
            
        }

    }


}