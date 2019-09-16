//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class tbm_unpack : UnitTest<tbm_unpack>
    {
        public void bm_unpack_8x8x8_8x8x8()
        {
            var dst = Matrix.Alloc<N8,byte>();
            var m = dst.ColCount;
            var n = dst.RowCount;
            for(var sample=0; sample<SampleSize; sample++)
            {
                var src = Random.BitMatrix8();
                BitMatrix.unpack(src, ref dst);
                
                for(var i=0; i< m; i++)
                for(var j=0; j< n; j++)
                    Claim.eq(src[i,j], dst[i,j] == 0 ? Bit.Off : Bit.On);
            }
        }

        public void bm_unpack_64x64x64_64x64x64()
        {
            var dst = Matrix.Alloc<N64,ulong>();
            var m = dst.ColCount;
            var n = dst.RowCount;
            for(var sample=0; sample<SampleSize; sample++)
            {
                var src = Random.BitMatrix64();
                BitMatrix.unpack(src, ref dst);
                
                for(var i=0; i< m; i++)
                for(var j=0; j< n; j++)
                    Claim.eq(src[i,j], dst[i,j] == 0 ? Bit.Off : Bit.On);

            }

        }

    }

}