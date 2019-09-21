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


    public class tv_broadcast : UnitTest<tv_broadcast>
    {


        public void broadcast128()
        {
            broadcast128_check<sbyte>();   
            broadcast128_check<byte>();
            broadcast128_check<short>();
            broadcast128_check<ushort>();
            broadcast128_check<int>();
            broadcast128_check<uint>();
            broadcast128_check<long>();
            broadcast128_check<ulong>();
            broadcast128_check<float>(); 
            broadcast128_check<double>();
        }

        public void broadcast256()
        {
            broadcast256_check<sbyte>();   
            broadcast256_check<byte>();
            broadcast256_check<short>();
            broadcast256_check<ushort>();
            broadcast256_check<int>();
            broadcast256_check<uint>();
            broadcast256_check<long>();
            broadcast256_check<ulong>();
            broadcast256_check<float>(); 
            broadcast256_check<double>();
        }

        void broadcast128_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            var x = Random.Next<T>();
            ref var vX = ref ginx.broadcast(in x, out Vec128<T> _);
            var vY = Vec128.Fill(x);
            Claim.eq(vX,vY);
            TypeCaseEnd<T>();
        }

        void broadcast256_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            var x = Random.Next<T>();
            ref var vX = ref ginx.broadcast(in x, out Vec256<T> _);
            var vY = Vec256.Fill(x);
            Claim.eq(vX,vY);
            TypeCaseEnd<T>();
        }

    }

}