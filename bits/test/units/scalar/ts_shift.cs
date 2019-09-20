//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class ts_shift : ScalarBitTest<ts_shift>
    {
        public void sal_8i()
        {
            var src = Random.Array<sbyte>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<sbyte>.BitSize));            

            iter(SampleSize, i => Claim.eq((sbyte)(src[i] << offset[i]), gbits.sal(src[i], offset[i])));    
        }

        public void sar_8i()
        {
            var src = Random.Array<sbyte>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<sbyte>.BitSize));                
            iter(SampleSize, i => Claim.eq((sbyte)(src[i] >> offset[i]), gbits.sar(src[i], offset[i])));    
        }

        public void sal_32i()
        {
            var src = Random.Array<int>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<int>.BitSize));            
            iter(SampleSize, i => Claim.eq(src[i] << offset[i], gbits.sal(src[i], offset[i])));    
        }

        public void sar_32i()
        {
            var src = Random.Array<int>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<int>.BitSize));            
            iter(SampleSize, i => Claim.eq(src[i] >> offset[i], gbits.sar(src[i], offset[i])));
        }

        public void sal_64i()
        {
            var src = Random.Array<long>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<long>.BitSize));            

            iter(SampleSize, i => Claim.eq(src[i] << offset[i], gbits.sal(src[i], offset[i])));    
        }

        public void sar_64i()
        {
            var src = Random.Array<long>(SampleSize);            
            var offset = Random.Array<int>(SampleSize, closed(0, (int)SizeOf<long>.BitSize));            

            iter(SampleSize, i => Claim.eq(src[i] >> offset[i], gbits.sar(src[i], offset[i])));
        }

    }

}
