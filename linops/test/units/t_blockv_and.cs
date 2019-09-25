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
    //using VecLen = NatSeq<N1,N2,N3>;
    using VecLen = N64;

    public class t_blockv_and : UnitTest<t_blockv_and>
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
            where T : unmanaged
            where N : ITypeNat, new()
        {
            var rep = new N();
            var len = (int)rep.value;
            var u = Random.BlockVec<N,T>();
            var v = Random.BlockVec<N,T>();
            var vResult = Linear.and(u, v);
            
            var calcs = span<T>(len);
            for(var i = 0; i< calcs.Length; i++)
                calcs[i] = gmath.and(u[i], v[i]);
            var vExpect = BlockVector.Load(calcs, rep);            
            
            Util.ClaimEqual(vExpect, vResult);
        }

    }

}