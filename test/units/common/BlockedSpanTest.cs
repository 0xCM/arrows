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
    
    using Z0.Diagnostics;    
    using static zfunc;


    public class BlockedSpanTest : UnitTest<BlockedSpanTest>
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
            Claim.eq(1, Span128.blocks<sbyte>(16));
            Claim.eq(1, Span128.blocks<byte>(16));

            Claim.eq(1, Span128.blocks<short>(8));
            Claim.eq(1, Span128.blocks<ushort>(8));

            Claim.eq(1, Span128.blocks<int>(4));
            Claim.eq(1, Span128.blocks<uint>(4));
            Claim.eq(1, Span128.blocks<float>(4));

            Claim.eq(1, Span128.blocks<long>(2));
            Claim.eq(1, Span128.blocks<ulong>(2));
            Claim.eq(1, Span128.blocks<double>(2));

            Claim.eq(1, Span256.blocks<sbyte>(32));
            Claim.eq(1, Span256.blocks<byte>(32));

            Claim.eq(1, Span256.blocks<short>(16));
            Claim.eq(1, Span256.blocks<ushort>(16));

            Claim.eq(1, Span256.blocks<int>(8));
            Claim.eq(1, Span256.blocks<uint>(8));
            Claim.eq(1, Span256.blocks<float>(8));

            Claim.eq(1, Span256.blocks<long>(4));
            Claim.eq(1, Span256.blocks<ulong>(4));
            Claim.eq(1, Span256.blocks<double>(4));
        }


        public void Alignment()
        {

            Claim.eq(4, Span128.align<int>(4));
            Claim.yea(Span128.aligned<int>(4));

            Claim.eq(8, Span128.align<int>(5));
            Claim.nea(Span128.aligned<int>(5));

            Claim.eq(8, Span128.align<int>(6));
            Claim.nea(Span128.aligned<int>(6));

            Claim.eq(8, Span128.align<int>(7));
            Claim.nea(Span128.aligned<int>(7));

            Claim.eq(8, Span128.align<int>(8));
            Claim.yea(Span128.aligned<int>(8));

            Claim.eq(12, Span128.align<int>(9));
            Claim.nea(Span128.aligned<int>(9));


        }

        public void BlockSlice()
        {
            var x = Span128.load(span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.SliceBlock(0);
            Claim.eq(4, block0.Length);            
            block0.RequireEq(Span128.load(span(1,2,3,4)));

            var block2 = x.SliceBlock(1);
            Claim.eq(4, block2.Length);
            Require.RequireEq(block2, span(5,6,7,8));

        }
        public void Load1()
        {
            var x = Span128.load(span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Require.RequireEq(x.Unblock(), span(1,2,3,4,5,6,7,8));
            
        }

        public void Fill1()
        {

            var blocks = Pow2.T08;   
            var blocklen = Span128<int>.BlockLength;                     
            var src = Random.ReadOnlySpan128<int>(blocks);
            var dst = Span128.alloc<int>(blocks);

            Claim.eq(src.Length, dst.Length);

            for(int block = 0, idx = 0; block<blocks; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];                
            }

            Claim.eq(src.Unblock(),dst.Unblock());

        }


        public void Fill2()
        {
            var blockX = Span128.alloc<int>(1);
            blockX[0] = 1;
            blockX[1] = 2;
            blockX[2] = 3;
            blockX[3] = 4;

            var blockY = Span128.load(blockX.Unblock());
            Claim.eq(blockX, blockY);

        }

    }


}