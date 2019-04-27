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
    using D = PrimalOps;

    [DisplayName(P.primops)]
    public class PrimOpsTests : UnitTest<PrimOpsTests>
    {
        [DisplayName(P.inc)]
        public void VerifyIncOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.inc,D.inc<sbyte>(), x => ++x);
            runner.Verify(P.inc,D.inc<byte>(), x => ++x);
            runner.Verify(P.inc,D.inc<short>(), x => ++x);
            runner.Verify(P.inc,D.inc<ushort>(), x => ++x);
            runner.Verify(P.inc,D.inc<int>(), x => ++x);
            runner.Verify(P.inc,D.inc<uint>(), x => ++x);
            runner.Verify(P.inc,D.inc<long>(), x => ++x);
            runner.Verify(P.inc,D.inc<ulong>(), x => ++x);
            runner.Verify(P.inc,D.inc<float>(), x => ++x);
            runner.Verify(P.inc,D.inc<double>(), x => ++x);
            runner.Verify(P.inc,D.inc<decimal>(), x => ++x);
            runner.Verify(P.add,D.inc<BigInteger>(), x => ++x);
              
        }


        [DisplayName(P.add)]
        public void VerifyEqOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.eq,D.eq<sbyte>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<byte>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<short>(), (x,y) =>(x == y));
            runner.Verify(P.eq,D.eq<ushort>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<int>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<uint>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<long>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<ulong>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<float>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<double>(), (x,y) => (x == y));
            runner.Verify(P.eq,D.eq<decimal>(), (x,y) => (x == y));
            runner.Verify(P.add,D.eq<BigInteger>(), (x,y) => (x == y));
              
        }

        [DisplayName(P.gt)]
        public void VerifyGtOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.gt,D.gt<sbyte>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<byte>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<short>(), (x,y) =>(x > y));
            runner.Verify(P.gt,D.gt<ushort>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<int>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<uint>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<long>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<ulong>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<float>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<double>(), (x,y) => (x > y));
            runner.Verify(P.gt,D.gt<decimal>(), (x,y) => (x > y));
            runner.Verify(P.add,D.gt<BigInteger>(), (x,y) => (x > y));
              
        }

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

        [DisplayName(P.mod)]
        public void VerifyXOrOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.xor, D.xor<sbyte>(), (x,y) => (sbyte)(x ^ y));
            runner.Verify(P.xor, D.xor<byte>(), (x,y) => (byte)(x ^ y));
            runner.Verify(P.xor, D.xor<short>(), (x,y) => (short)(x ^ y));
            runner.Verify(P.xor, D.xor<ushort>(), (x,y) => (ushort)(x ^ y));
            runner.Verify(P.xor, D.xor<int>(), (x,y) => (x ^ y));
            runner.Verify(P.xor, D.xor<uint>(), (x,y) => (x ^ y));
            runner.Verify(P.xor, D.xor<long>(), (x,y) => (x ^ y));
            runner.Verify(P.xor, D.xor<ulong>(), (x,y) => (x ^ y));
            runner.Verify(P.xor, D.xor<BigInteger>(), (x,y) => (x ^ y));
              
        }

        [DisplayName(P.mul)]
        public void VerifyMulOp()
        {
            var runner = new PrimOpsTest();
            runner.Verify(P.mul, D.mul<sbyte>(), (x,y) => (sbyte)(x * y));
            runner.Verify(P.mul, D.mul<byte>(), (x,y) => (byte)(x * y));
            runner.Verify(P.mul, D.mul<short>(), (x,y) => (short)(x * y));
            runner.Verify(P.mul, D.mul<ushort>(), (x,y) => (ushort)(x * y));
            runner.Verify(P.mul, D.mul<int>(), (x,y) => (x * y));
            runner.Verify(P.mul, D.mul<uint>(), (x,y) => (x * y));
            runner.Verify(P.mul, D.mul<long>(), (x,y) => (x * y));
            runner.Verify(P.mul, D.mul<ulong>(), (x,y) => (x * y));
            runner.Verify(P.mul, D.mul<float>(), (x,y) => (x * y));
            runner.Verify(P.mul, D.mul<double>(), (x,y) => (x * y));
            runner.Verify(P.mul, D.mul<decimal>(), (x,y) => (x * y));
            runner.Verify(P.mul, D.mul<BigInteger>(), (x,y) => (x * y));
              
        }

    }

}