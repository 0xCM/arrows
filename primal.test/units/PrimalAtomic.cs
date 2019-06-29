//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using D = PrimalDelegates;

    class PrimalAtomicTest : UnitTest<PrimalAtomicTest>
    {
        public PrimalAtomicTest()
            : base()
        {

        }
     
        public void Add()
        {
            var op = OpKind.Add;
            VerifyOp(op, (x,y) => (sbyte)(x + y), D.add<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x + y), D.add<byte>());
            VerifyOp(op, (x,y) => (short)(x + y), D.add<short>());
            VerifyOp(op, (x,y) => (ushort)(x + y), D.add<ushort>());
            VerifyOp(op, (x,y) => (x + y), D.add<int>());
            VerifyOp(op, (x,y) => (x + y), D.add<uint>());
            VerifyOp(op, (x,y) => (x + y), D.add<long>());
            VerifyOp(op, (x,y) => (x + y), D.add<ulong>());
            VerifyOp(op, (x,y) => (x + y), D.add<float>());
            VerifyOp(op, (x,y) => (x + y), D.add<double>());              
        }

        public void Sub()
        {
            var op = OpKind.Sub;
            VerifyOp(op, (x,y) => (sbyte)(x - y), D.sub<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x - y), D.sub<byte>());
            VerifyOp(op, (x,y) => (short)(x - y), D.sub<short>());
            VerifyOp(op, (x,y) => (ushort)(x - y), D.sub<ushort>());
            VerifyOp(op, (x,y) => (x - y), D.sub<int>());
            VerifyOp(op, (x,y) => (x - y), D.sub<uint>());
            VerifyOp(op, (x,y) => (x - y), D.sub<long>());
            VerifyOp(op, (x,y) => (x - y), D.sub<ulong>());
            VerifyOp(op, (x,y) => (x - y), D.sub<float>());
            VerifyOp(op, (x,y) => (x - y), D.sub<double>());
              
        }

        public void Mul()
        {
            var op = OpKind.Mul;
            VerifyOp(op, (x,y) => (sbyte)(x * y), D.mul<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x * y), D.mul<byte>());
            VerifyOp(op, (x,y) => (short)(x * y), D.mul<short>());
            VerifyOp(op, (x,y) => (ushort)(x * y), D.mul<ushort>());
            VerifyOp(op, (x,y) => (x * y), D.mul<int>());
            VerifyOp(op, (x,y) => (x * y), D.mul<uint>());
            VerifyOp(op, (x,y) => (x * y), D.mul<long>());
            VerifyOp(op, (x,y) => (x * y), D.mul<ulong>());
            VerifyOp(op, (x,y) => (x * y), D.mul<float>());
            VerifyOp(op, (x,y) => (x * y), D.mul<double>());
              
        }

        public void Div()
        {
            var op = OpKind.Div;
            VerifyOp(op, (x,y) => (sbyte)(x / y), D.div<sbyte>(),true);
            VerifyOp(op, (x,y) => (byte)(x / y), D.div<byte>(),true);
            VerifyOp(op, (x,y) => (short)(x / y), D.div<short>());
            VerifyOp(op, (x,y) => (ushort)(x / y), D.div<ushort>(),true);
            VerifyOp(op, (x,y) => (x / y), D.div<int>(),true);
            VerifyOp(op, (x,y) => (x / y), D.div<uint>(),true);
            VerifyOp(op, (x,y) => (x / y), D.div<long>(),true);
            VerifyOp(op, (x,y) => (x / y), D.div<ulong>(),true);
            VerifyOp(op, (x,y) => (x / y), D.div<float>(),true);
            VerifyOp(op, (x,y) => (x / y), D.div<double>(),true);
        }

        public void Mod()
        {
            var op = OpKind.Mod;
            VerifyOp(op, (x,y) => (sbyte)(x % y), D.mod<sbyte>(),true);
            VerifyOp(op, (x,y) => (byte)(x % y), D.mod<byte>(),true);
            VerifyOp(op, (x,y) => (short)(x % y), D.mod<short>());
            VerifyOp(op, (x,y) => (ushort)(x % y), D.mod<ushort>(),true);
            VerifyOp(op, (x,y) => (x % y), D.mod<int>(),true);
            VerifyOp(op, (x,y) => (x % y), D.mod<uint>(),true);
            VerifyOp(op, (x,y) => (x % y), D.mod<long>(),true);
            VerifyOp(op, (x,y) => (x % y), D.mod<ulong>(),true);
            VerifyOp(op, (x,y) => (x % y), D.mod<float>(),true);
            VerifyOp(op, (x,y) => (x % y), D.mod<double>(),true);
              
        }

        public void And()
        {
            var op = OpKind.And;
            VerifyOp(op, (x,y) => (sbyte)(x & y), D.and<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x & y), D.and<byte>());
            VerifyOp(op, (x,y) => (short)(x & y), D.and<short>());
            VerifyOp(op, (x,y) => (ushort)(x & y), D.and<ushort>());
            VerifyOp(op, (x,y) => (x & y), D.and<int>());
            VerifyOp(op, (x,y) => (x & y), D.and<uint>());
            VerifyOp(op, (x,y) => (x & y), D.and<long>());
            VerifyOp(op, (x,y) => (x & y), D.and<ulong>());
        }

        public void Or()
        {
            var op = OpKind.Or;
            VerifyOp(op, (x,y) => (sbyte)(x | y), D.or<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x | y), D.or<byte>());
            VerifyOp(op, (x,y) => (short)(x | y), D.or<short>());
            VerifyOp(op, (x,y) => (ushort)(x | y), D.or<ushort>());
            VerifyOp(op, (x,y) => (x | y), D.or<int>());
            VerifyOp(op, (x,y) => (x | y), D.or<uint>());
            VerifyOp(op, (x,y) => (x | y), D.or<long>());
            VerifyOp(op, (x,y) => (x | y), D.or<ulong>());
        }

        public void XOr()
        {
            var op = OpKind.XOr;
            VerifyOp(op, (x,y) => (sbyte)(x ^ y), D.xor<sbyte>());
            VerifyOp(op, (x,y) => (byte)(x ^ y), D.xor<byte>());
            VerifyOp(op, (x,y) => (short)(x ^ y), D.xor<short>());
            VerifyOp(op, (x,y) => (ushort)(x ^ y), D.xor<ushort>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<int>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<uint>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<long>());
            VerifyOp(op, (x,y) => (x ^ y), D.xor<ulong>());              
        }

        public void Flip()
        {
            var op = OpKind.Flip;
            VerifyOp(op, x => (sbyte) ~x, D.flip<sbyte>());
            VerifyOp(op, x => (byte) ~x, D.flip<byte>());
            VerifyOp(op, x => (short) ~x, D.flip<short>());
            VerifyOp(op, x => (ushort) ~x, D.flip<ushort>());
            VerifyOp(op, x => ~x, D.flip<int>());
            VerifyOp(op, x => ~x, D.flip<uint>());
            VerifyOp(op, x => ~x, D.flip<long>());
            VerifyOp(op, x => ~x, D.flip<ulong>());              
        }

        public void Negate()
        {
            var op = OpKind.Negate;
            VerifyOp(op, x => (sbyte)-x, D.negate<sbyte>());
            VerifyOp(op, x => (short)-x, D.negate<short>());
            VerifyOp(op, x => -x, D.negate<int>());
            VerifyOp(op, x => -x, D.negate<long>());
            VerifyOp(op, x => -x, D.negate<float>());
            VerifyOp(op, x => -x, D.negate<double>());              
        }

        public void Inc()
        {
            var op = OpKind.Inc;
            VerifyOp(op, x => ++x, D.inc<sbyte>());
            VerifyOp(op, x => ++x, D.inc<byte>());
            VerifyOp(op, x => ++x, D.inc<short>());
            VerifyOp(op, x => ++x, D.inc<ushort>());
            VerifyOp(op, x => ++x, D.inc<int>());
            VerifyOp(op, x => ++x, D.inc<uint>());
            VerifyOp(op, x => ++x, D.inc<long>());
            VerifyOp(op, x => ++x, D.inc<ulong>());
            VerifyOp(op, x => ++x, D.inc<float>());
            VerifyOp(op, x => ++x, D.inc<double>());              
        }

        public void Eq()
        {
            var op = OpKind.Eq;
            VerifyOp(op, (x,y) => (x == y), D.eq<sbyte>());
            VerifyOp(op, (x,y) => (x == y), D.eq<byte>());
            VerifyOp(op, (x,y) => (x == y), D.eq<short>());
            VerifyOp(op, (x,y) => (x == y), D.eq<ushort>());
            VerifyOp(op, (x,y) => (x == y), D.eq<int>());
            VerifyOp(op, (x,y) => (x == y), D.eq<uint>());
            VerifyOp(op, (x,y) => (x == y), D.eq<long>());
            VerifyOp(op, (x,y) => (x == y), D.eq<ulong>());
            VerifyOp(op, (x,y) => (x == y), D.eq<float>());
            VerifyOp(op, (x,y) => (x == y), D.eq<double>());              
        }

        public void Gt()
        {
            var op = OpKind.Gt;
            VerifyOp(op, (x,y) => (x > y), D.gt<sbyte>());
            VerifyOp(op, (x,y) => (x > y), D.gt<byte>());
            VerifyOp(op, (x,y) => (x > y), D.gt<short>());
            VerifyOp(op, (x,y) => (x > y), D.gt<ushort>());
            VerifyOp(op, (x,y) => (x > y), D.gt<int>());
            VerifyOp(op, (x,y) => (x > y), D.gt<uint>());
            VerifyOp(op, (x,y) => (x > y), D.gt<long>());
            VerifyOp(op, (x,y) => (x > y), D.gt<ulong>());
            VerifyOp(op, (x,y) => (x > y), D.gt<float>());
            VerifyOp(op, (x,y) => (x > y), D.gt<double>());              
        }

        public void GtEq()
        {
            var op = OpKind.GtEq;
            VerifyOp(op, (x,y) => (x >= y), D.gteq<sbyte>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<byte>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<short>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<ushort>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<int>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<uint>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<long>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<ulong>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<float>());
            VerifyOp(op, (x,y) => (x >= y), D.gteq<double>());              
        }

        public void Lt()
        {
            var op = OpKind.Lt;
            VerifyOp(op, (x,y) => (x < y), D.lt<sbyte>());
            VerifyOp(op, (x,y) => (x < y), D.lt<byte>());
            VerifyOp(op, (x,y) => (x < y), D.lt<short>());
            VerifyOp(op, (x,y) => (x < y), D.lt<ushort>());
            VerifyOp(op, (x,y) => (x < y), D.lt<int>());
            VerifyOp(op, (x,y) => (x < y), D.lt<uint>());
            VerifyOp(op, (x,y) => (x < y), D.lt<long>());
            VerifyOp(op, (x,y) => (x < y), D.lt<ulong>());
            VerifyOp(op, (x,y) => (x < y), D.lt<float>());
            VerifyOp(op, (x,y) => (x < y), D.lt<double>());              
        }

        public void LtEq()
        {
            var op = OpKind.LtEq;
            VerifyOp(op, (x,y) => (x <= y), D.lteq<sbyte>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<byte>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<short>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<ushort>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<int>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<uint>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<long>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<ulong>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<float>());
            VerifyOp(op, (x,y) => (x <= y), D.lteq<double>());     

        }
 
 
    }
}