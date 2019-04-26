//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;

    using static zcore;
    using P = Paths;
    using D = PrimOpDelegates;

    [DisplayName(P.primops)]
    public class PrimOpsTests : UnitTest<PrimOpsTests>
    {
        [DisplayName(P.add)]
        public void VerifyAddOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.add,D.add<sbyte>(), (x,y) => (sbyte)(x + y));
            runner.Verify(P.add,D.add<byte>(), (x,y) => (byte)(x + y));
            runner.Verify(P.add,D.add<short>(), (x,y) => (short)(x + y));
            runner.Verify(P.add,D.add<ushort>(), (x,y) => (ushort)(x + y));
            runner.Verify(P.add,D.add<int>(), (x,y) => (x + y));
            runner.Verify(P.add,D.add<uint>(), (x,y) => (x + y));
            runner.Verify(P.add,D.add<long>(), (x,y) => (x + y));
            runner.Verify(P.add,D.add<ulong>(), (x,y) => (x + y));
            runner.Verify(P.add,D.add<float>(), (x,y) => (x + y));
            runner.Verify(P.add,D.add<double>(), (x,y) => (x + y));
            runner.Verify(P.add,D.add<decimal>(), (x,y) => (x + y));
            runner.Verify(P.add,D.add<BigInteger>(), (x,y) => (x + y));
              
        }

        [DisplayName(P.sub)]
        public void VerifySubOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.sub,D.sub<sbyte>(), (x,y) => (sbyte)(x - y));
            runner.Verify(P.sub,D.sub<byte>(), (x,y) => (byte)(x - y));
            runner.Verify(P.sub,D.sub<short>(), (x,y) => (short)(x - y));
            runner.Verify(P.sub,D.sub<ushort>(), (x,y) => (ushort)(x - y));
            runner.Verify(P.sub,D.sub<int>(), (x,y) => (x - y));
            runner.Verify(P.sub,D.sub<uint>(), (x,y) => (x - y));
            runner.Verify(P.sub,D.sub<long>(), (x,y) => (x - y));
            runner.Verify(P.sub,D.sub<ulong>(), (x,y) => (x - y));
            runner.Verify(P.sub,D.sub<float>(), (x,y) => (x - y));
            runner.Verify(P.sub,D.sub<double>(), (x,y) => (x - y));
            runner.Verify(P.sub,D.sub<decimal>(), (x,y) => (x - y));
            runner.Verify(P.sub,D.sub<BigInteger>(), (x,y) => (x - y));
              
        }

        [DisplayName(P.div)]
        public void VerifyDivOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.div, D.div<sbyte>(), (x,y) => (sbyte)(x / y), z => z != 0);
            runner.Verify(P.div, D.div<byte>(), (x,y) => (byte)(x / y), z => z != 0);
            runner.Verify(P.div, D.div<short>(), (x,y) => (short)(x / y), z => z != 0);
            runner.Verify(P.div, D.div<ushort>(), (x,y) => (ushort)(x / y), z => z != 0);
            runner.Verify(P.div, D.div<int>(), (x,y) => (x / y), z => z != 0);
            runner.Verify(P.div, D.div<uint>(), (x,y) => (x / y), z => z != 0);
            runner.Verify(P.div, D.div<long>(), (x,y) => (x / y), z => z != 0);
            runner.Verify(P.div, D.div<ulong>(), (x,y) => (x / y), z => z != 0);
            runner.Verify(P.div, D.div<float>(), (x,y) => (x / y), z => z != 0);
            runner.Verify(P.div, D.div<double>(), (x,y) => (x / y), z => z != 0);
            runner.Verify(P.div, D.div<decimal>(), (x,y) => (x / y), z => z != 0);
            runner.Verify(P.div, D.div<BigInteger>(), (x,y) => (x / y), z => z != 0);
              
        }

        [DisplayName(P.mod)]
        public void VerifyModOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.mod, D.mod<sbyte>(), (x,y) => (sbyte)(x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<byte>(), (x,y) => (byte)(x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<short>(), (x,y) => (short)(x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<ushort>(), (x,y) => (ushort)(x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<int>(), (x,y) => (x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<uint>(), (x,y) => (x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<long>(), (x,y) => (x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<ulong>(), (x,y) => (x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<float>(), (x,y) => (x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<double>(), (x,y) => (x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<decimal>(), (x,y) => (x % y), z => z != 0);
            runner.Verify(P.mod, D.mod<BigInteger>(), (x,y) => (x % y), z => z != 0);
              
        }

        [DisplayName(P.mod)]
        public void VerifyAndOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.and, D.and<sbyte>(), (x,y) => (sbyte)(x & y));
            runner.Verify(P.and, D.and<byte>(), (x,y) => (byte)(x & y));
            runner.Verify(P.and, D.and<short>(), (x,y) => (short)(x & y));
            runner.Verify(P.and, D.and<ushort>(), (x,y) => (ushort)(x & y));
            runner.Verify(P.and, D.and<int>(), (x,y) => (x & y));
            runner.Verify(P.and, D.and<uint>(), (x,y) => (x & y));
            runner.Verify(P.and, D.and<long>(), (x,y) => (x & y));
            runner.Verify(P.and, D.and<ulong>(), (x,y) => (x & y));
            runner.Verify(P.and, D.and<BigInteger>(), (x,y) => (x & y));
              
        }

        [DisplayName(P.mod)]
        public void VerifyOrOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.or, D.or<sbyte>(), (x,y) => (sbyte)(x | y));
            runner.Verify(P.or, D.or<byte>(), (x,y) => (byte)(x | y));
            runner.Verify(P.or, D.or<short>(), (x,y) => (short)(x | y));
            runner.Verify(P.or, D.or<ushort>(), (x,y) => (ushort)(x | y));
            runner.Verify(P.or, D.or<int>(), (x,y) => (x | y));
            runner.Verify(P.or, D.or<uint>(), (x,y) => (x | y));
            runner.Verify(P.or, D.or<long>(), (x,y) => (x | y));
            runner.Verify(P.or, D.or<ulong>(), (x,y) => (x | y));
            runner.Verify(P.or, D.or<BigInteger>(), (x,y) => (x | y));
              
        }

    }

}