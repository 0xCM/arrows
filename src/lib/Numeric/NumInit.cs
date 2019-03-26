//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Numerics;
    using static zcore;

    public sealed class NumInit : SysInit<NumInit>
    {
        protected override void ExecInit()
        {
            Resolver.define<Int8Ops,sbyte>();
            Resolver.define<UInt8Ops,byte>();
            Resolver.define<Int16Ops, short>();
            Resolver.define<UInt16Ops,ushort>();
            Resolver.define<Int32Ops, int>();
            Resolver.define<UInt32Ops, uint>();
            Resolver.define<Int64Ops, long>();
            Resolver.define<UInt64Ops, ulong>();
            Resolver.define<BigIntOps, BigInteger>();
            Resolver.define<DecimalOps, decimal>();
            Resolver.define<Float32Ops, float>();
            Resolver.define<Float64Ops, double>();
            
        }
    }

}

