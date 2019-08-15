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
    
    using static zfunc;

    public class BlockedSpanTest : UnitTest<BlockedSpanTest>
    {
        public  void CellSize()
        {
            Claim.eq(4, Span128<int>.CellSize);
            Claim.eq(1, Span128.CellSize<sbyte>());
            Claim.eq(1, Span128.CellSize<byte>());
            Claim.eq(2, Span128.CellSize<short>());
            Claim.eq(4, Span128.CellSize<int>());
            Claim.eq(4, Span128.CellSize<uint>());
            Claim.eq(4, Span128.CellSize<float>());
            Claim.eq(8, Span128.CellSize<ulong>());
            Claim.eq(8, Span128.CellSize<double>());
            Claim.eq(8, Span128.CellSize<long>());


            Claim.eq(4, Span256<int>.CellSize);
            Claim.eq(1, Span256.CellSize<sbyte>());
            Claim.eq(1, Span256.CellSize<byte>());
            Claim.eq(2, Span256.CellSize<short>());
            Claim.eq(4, Span256.CellSize<int>());
            Claim.eq(4, Span256.CellSize<uint>());
            Claim.eq(4, Span256.CellSize<float>());
            Claim.eq(8, Span256.CellSize<ulong>());
            Claim.eq(8, Span256.CellSize<double>());
            Claim.eq(8, Span256.CellSize<long>());

        }

        public void BlockSize()
        {
            Claim.eq(16, Span128<int>.BlockSize);
            Claim.eq(16, Span128.BlockSize<sbyte>());          
            Claim.eq(16, Span128.BlockSize<byte>());          
            Claim.eq(16, Span128.BlockSize<short>());            
            Claim.eq(16, Span128.BlockSize<int>());            
            Claim.eq(16, Span128.BlockSize<float>());          
            Claim.eq(16, Span128.BlockSize<double>());          
            Claim.eq(16, Span128.BlockSize<long>());          

            Claim.eq(32, Span256<int>.BlockSize);
            Claim.eq(32, Span256.BlockSize<sbyte>());          
            Claim.eq(32, Span256.BlockSize<byte>());          
            Claim.eq(32, Span256.BlockSize<short>());            
            Claim.eq(32, Span256.BlockSize<int>());            
            Claim.eq(32, Span256.BlockSize<float>());          
            Claim.eq(32, Span256.BlockSize<double>());          
            Claim.eq(32, Span256.BlockSize<long>());          

        }

        public void BlockLength()
        {
            Claim.eq(4, Span128<int>.BlockLength);
            Claim.eq(16, Span128.BlockLength<sbyte>());
            Claim.eq(16, Span128.BlockLength<byte>());
            Claim.eq(8, Span128.BlockLength<short>());
            Claim.eq(8, Span128.BlockLength<ushort>());
            Claim.eq(4, Span128.BlockLength<int>());
            Claim.eq(4, Span128.BlockLength<uint>());
            Claim.eq(2, Span128.BlockLength<long>());
            Claim.eq(2, Span128.BlockLength<ulong>());
            Claim.eq(4, Span128.BlockLength<float>());
            Claim.eq(2, Span128.BlockLength<double>());                
            Claim.eq(8, Span128.BlockLength<int>(2));
            Claim.eq(4, Span128.BlockLength<long>(2));
            Claim.eq(32, Span128.BlockLength<byte>(2));


            Claim.eq(8, Span256<int>.BlockLength);
            Claim.eq(32, Span256.BlockLength<sbyte>());
            Claim.eq(32, Span256.BlockLength<byte>());
            Claim.eq(16, Span256.BlockLength<short>());
            Claim.eq(16, Span256.BlockLength<ushort>());
            Claim.eq(8, Span256.BlockLength<int>());
            Claim.eq(8, Span256.BlockLength<uint>());
            Claim.eq(4, Span256.BlockLength<long>());
            Claim.eq(4, Span256.BlockLength<ulong>());
            Claim.eq(8, Span256.BlockLength<float>());
            Claim.eq(4, Span256.BlockLength<double>());                
        }

        public void BlockCount()
        {
            Claim.eq(1, Span128.WholeBlocks<sbyte>(16));
            Claim.eq(1, Span128.WholeBlocks<byte>(16));

            Claim.eq(1, Span128.WholeBlocks<short>(8));
            Claim.eq(1, Span128.WholeBlocks<ushort>(8));

            Claim.eq(1, Span128.WholeBlocks<int>(4));
            Claim.eq(1, Span128.WholeBlocks<uint>(4));
            Claim.eq(1, Span128.WholeBlocks<float>(4));

            Claim.eq(1, Span128.WholeBlocks<long>(2));
            Claim.eq(1, Span128.WholeBlocks<ulong>(2));
            Claim.eq(1, Span128.WholeBlocks<double>(2));

            Claim.eq(1, Span256.WholeBlocks<sbyte>(32));
            Claim.eq(1, Span256.WholeBlocks<byte>(32));

            Claim.eq(1, Span256.WholeBlocks<short>(16));
            Claim.eq(1, Span256.WholeBlocks<ushort>(16));

            Claim.eq(1, Span256.WholeBlocks<int>(8));
            Claim.eq(1, Span256.WholeBlocks<uint>(8));
            Claim.eq(1, Span256.WholeBlocks<float>(8));

            Claim.eq(1, Span256.WholeBlocks<long>(4));
            Claim.eq(1, Span256.WholeBlocks<ulong>(4));
            Claim.eq(1, Span256.WholeBlocks<double>(4));
        }


        public void Alignment()
        {

            Claim.eq(4, Span128.Align<int>(4));
            Claim.yea(Span128.IsAligned<int>(4));

            Claim.eq(8, Span128.Align<int>(5));
            Claim.nea(Span128.IsAligned<int>(5));

            Claim.eq(8, Span128.Align<int>(6));
            Claim.nea(Span128.IsAligned<int>(6));

            Claim.eq(8, Span128.Align<int>(7));
            Claim.nea(Span128.IsAligned<int>(7));

            Claim.eq(8, Span128.Align<int>(8));
            Claim.yea(Span128.IsAligned<int>(8));

            Claim.eq(12, Span128.Align<int>(9));
            Claim.nea(Span128.IsAligned<int>(9));


        }

        public void BlockSlice()
        {
            var x = Span128.Load(span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.SliceBlock(0);
            Claim.eq(4, block0.Length);            
            block0.ClaimEqual(Span128.Load(span(1,2,3,4)));

            var block2 = x.SliceBlock(1);
            Claim.eq(4, block2.Length);
            block2.ClaimEqual(Span128.FromParts(5,6,7,8));

        }
        public void Load1()
        {
            var x = Span128.Load(span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            x.ClaimEqual(Span128.FromParts(1,2,3,4,5,6,7,8));
            
        }

        public void Fill1()
        {

            var blocks = Pow2.T08;   
            var blocklen = Span128<int>.BlockLength;                     
            var src = Random.ReadOnlySpan128<int>(blocks);
            var dst = Span128.AllocBlocks<int>(blocks);

            Claim.eq(src.Length, dst.Length);

            for(int block = 0, idx = 0; block<blocks; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];                
            }

            src.ClaimEqual(dst);

        }


        public void Fill2()
        {
            var blockX = Span128.AllocBlocks<int>(1);
            blockX[0] = 1;
            blockX[1] = 2;
            blockX[2] = 3;
            blockX[3] = 4;

            var blockY = Span128.Load(blockX.Unblock());
            Claim.eq(blockX, blockY);

        }

    }


}