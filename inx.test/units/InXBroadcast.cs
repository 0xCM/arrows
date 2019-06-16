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


    public class InxBroadcast : UnitTest<InxBroadcast>
    {

        void Broadcast128<T>()
            where T : struct
        {
            var x = Randomizer.Next<T>();
            ref var vX = ref ginx.broadcast(in x, out Vec128<T> _);
            var vY = Vec128.define(x);
            Claim.eq(vX,vY);
            TypeCaseEnd<T>();
        }

        void Broadcast256<T>()
            where T : struct
        {
            var x = Randomizer.Next<T>();
            ref var vX = ref ginx.broadcast(in x, out Vec256<T> _);
            var vY = Vec256.define(x);
            Claim.eq(vX,vY);
            TypeCaseEnd<T>();
        }

        public void Broadcast128()
        {
            Broadcast128<sbyte>();   
            Broadcast128<byte>();
            Broadcast128<short>();
            Broadcast128<ushort>();
            Broadcast128<int>();
            Broadcast128<uint>();
            Broadcast128<long>();
            Broadcast128<ulong>();
            Broadcast128<float>(); 
            Broadcast128<double>();
        }

        public void Broadcast256()
        {
            Broadcast256<sbyte>();   
            Broadcast256<byte>();
            Broadcast256<short>();
            Broadcast256<ushort>();
            Broadcast256<int>();
            Broadcast256<uint>();
            Broadcast256<long>();
            Broadcast256<ulong>();
            Broadcast256<float>(); 
            Broadcast256<double>();
        }

    }

}