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
    using VecLen = NatSeq<N1,N2,N3>;

    public class tlv_vand : UnitTest<tlv_vand>
    {
        public void vand()
        {
            and<VecLen,byte>();
            and<VecLen,sbyte>();
            and<VecLen,short>();
            and<VecLen,ushort>();
            and<VecLen,int>();
            and<VecLen,uint>();
            and<VecLen,long>();
            and<VecLen,ulong>();
            
        }

        void and<N,T>()
            where T : struct
            where N : ITypeNat, new()
        {
            var rep = new N();
            var len = (int)rep.value;
            var data = Random.NatVecPair<N,T>();            
            var vResult = Linear.and(ref data.Left, data.Right);
            
            var calcs = span<T>(len);
            for(var i = 0; i< calcs.Length; i++)
                calcs[i] = gbits.and(data.Left[i], data.Right[i]);
            var vExpect = Vector.Load(calcs, rep);            
            
            Verification.Equality(vExpect, vResult);
        }

    }

}