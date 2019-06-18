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
    using Z0.Diagnostics;

    using static zfunc;

    using D = PrimalDelegates;

    public class PrimalAtomicTest : UnitTest<PrimalAtomicTest>
    {


        public PrimalAtomicTest()
        {
            this.Verbose = false;

        }

        bool Verbose {get;}
        

        public void Add()
        {
            var op = OpKind.Add;
            Verify(op, (x,y) => (sbyte)(x + y), D.add<sbyte>());
            Verify(op, (x,y) => (byte)(x + y), D.add<byte>());
            Verify(op, (x,y) => (short)(x + y), D.add<short>());
            Verify(op, (x,y) => (ushort)(x + y), D.add<ushort>());
            Verify(op, (x,y) => (x + y), D.add<int>());
            Verify(op, (x,y) => (x + y), D.add<uint>());
            Verify(op, (x,y) => (x + y), D.add<long>());
            Verify(op, (x,y) => (x + y), D.add<ulong>());
            Verify(op, (x,y) => (x + y), D.add<float>());
            Verify(op, (x,y) => (x + y), D.add<double>());              
        }

        public void Sub()
        {
            var op = OpKind.Sub;
            Verify(op, (x,y) => (sbyte)(x - y), D.sub<sbyte>());
            Verify(op, (x,y) => (byte)(x - y), D.sub<byte>());
            Verify(op, (x,y) => (short)(x - y), D.sub<short>());
            Verify(op, (x,y) => (ushort)(x - y), D.sub<ushort>());
            Verify(op, (x,y) => (x - y), D.sub<int>());
            Verify(op, (x,y) => (x - y), D.sub<uint>());
            Verify(op, (x,y) => (x - y), D.sub<long>());
            Verify(op, (x,y) => (x - y), D.sub<ulong>());
            Verify(op, (x,y) => (x - y), D.sub<float>());
            Verify(op, (x,y) => (x - y), D.sub<double>());
              
        }

        public void Mul()
        {
            var op = OpKind.Mul;
            Verify(op, (x,y) => (sbyte)(x * y), D.mul<sbyte>());
            Verify(op, (x,y) => (byte)(x * y), D.mul<byte>());
            Verify(op, (x,y) => (short)(x * y), D.mul<short>());
            Verify(op, (x,y) => (ushort)(x * y), D.mul<ushort>());
            Verify(op, (x,y) => (x * y), D.mul<int>());
            Verify(op, (x,y) => (x * y), D.mul<uint>());
            Verify(op, (x,y) => (x * y), D.mul<long>());
            Verify(op, (x,y) => (x * y), D.mul<ulong>());
            Verify(op, (x,y) => (x * y), D.mul<float>());
            Verify(op, (x,y) => (x * y), D.mul<double>());
              
        }

        public void Div()
        {
            var op = OpKind.Div;
            Verify(op, (x,y) => (sbyte)(x / y), D.div<sbyte>(),true);
            Verify(op, (x,y) => (byte)(x / y), D.div<byte>(),true);
            Verify(op, (x,y) => (short)(x / y), D.div<short>());
            Verify(op, (x,y) => (ushort)(x / y), D.div<ushort>(),true);
            Verify(op, (x,y) => (x / y), D.div<int>(),true);
            Verify(op, (x,y) => (x / y), D.div<uint>(),true);
            Verify(op, (x,y) => (x / y), D.div<long>(),true);
            Verify(op, (x,y) => (x / y), D.div<ulong>(),true);
            Verify(op, (x,y) => (x / y), D.div<float>(),true);
            Verify(op, (x,y) => (x / y), D.div<double>(),true);
        }

        public void Mod()
        {
            var op = OpKind.Mod;
            Verify(op, (x,y) => (sbyte)(x % y), D.mod<sbyte>(),true);
            Verify(op, (x,y) => (byte)(x % y), D.mod<byte>(),true);
            Verify(op, (x,y) => (short)(x % y), D.mod<short>());
            Verify(op, (x,y) => (ushort)(x % y), D.mod<ushort>(),true);
            Verify(op, (x,y) => (x % y), D.mod<int>(),true);
            Verify(op, (x,y) => (x % y), D.mod<uint>(),true);
            Verify(op, (x,y) => (x % y), D.mod<long>(),true);
            Verify(op, (x,y) => (x % y), D.mod<ulong>(),true);
            Verify(op, (x,y) => (x % y), D.mod<float>(),true);
            Verify(op, (x,y) => (x % y), D.mod<double>(),true);
              
        }

        public void And()
        {
            var op = OpKind.And;
            Verify(op, (x,y) => (sbyte)(x & y), D.and<sbyte>());
            Verify(op, (x,y) => (byte)(x & y), D.and<byte>());
            Verify(op, (x,y) => (short)(x & y), D.and<short>());
            Verify(op, (x,y) => (ushort)(x & y), D.and<ushort>());
            Verify(op, (x,y) => (x & y), D.and<int>());
            Verify(op, (x,y) => (x & y), D.and<uint>());
            Verify(op, (x,y) => (x & y), D.and<long>());
            Verify(op, (x,y) => (x & y), D.and<ulong>());
        }

        public void Or()
        {
            var op = OpKind.Or;
            Verify(op, (x,y) => (sbyte)(x | y), D.or<sbyte>());
            Verify(op, (x,y) => (byte)(x | y), D.or<byte>());
            Verify(op, (x,y) => (short)(x | y), D.or<short>());
            Verify(op, (x,y) => (ushort)(x | y), D.or<ushort>());
            Verify(op, (x,y) => (x | y), D.or<int>());
            Verify(op, (x,y) => (x | y), D.or<uint>());
            Verify(op, (x,y) => (x | y), D.or<long>());
            Verify(op, (x,y) => (x | y), D.or<ulong>());
        }

        public void XOr()
        {
            var op = OpKind.XOr;
            Verify(op, (x,y) => (sbyte)(x ^ y), D.xor<sbyte>());
            Verify(op, (x,y) => (byte)(x ^ y), D.xor<byte>());
            Verify(op, (x,y) => (short)(x ^ y), D.xor<short>());
            Verify(op, (x,y) => (ushort)(x ^ y), D.xor<ushort>());
            Verify(op, (x,y) => (x ^ y), D.xor<int>());
            Verify(op, (x,y) => (x ^ y), D.xor<uint>());
            Verify(op, (x,y) => (x ^ y), D.xor<long>());
            Verify(op, (x,y) => (x ^ y), D.xor<ulong>());              
        }

        public void Flip()
        {
            var op = OpKind.Flip;
            Verify(op, x => (sbyte) ~x, D.flip<sbyte>());
            Verify(op, x => (byte) ~x, D.flip<byte>());
            Verify(op, x => (short) ~x, D.flip<short>());
            Verify(op, x => (ushort) ~x, D.flip<ushort>());
            Verify(op, x => ~x, D.flip<int>());
            Verify(op, x => ~x, D.flip<uint>());
            Verify(op, x => ~x, D.flip<long>());
            Verify(op, x => ~x, D.flip<ulong>());              
        }

        public void Negate()
        {
            var op = OpKind.Negate;
            Verify(op, x => (sbyte)-x, D.negate<sbyte>());
            Verify(op, x => (short)-x, D.negate<short>());
            Verify(op, x => -x, D.negate<int>());
            Verify(op, x => -x, D.negate<long>());
            Verify(op, x => -x, D.negate<float>());
            Verify(op, x => -x, D.negate<double>());              
        }

        public void Inc()
        {
            var op = OpKind.Inc;
            Verify(op, x => ++x, D.inc<sbyte>());
            Verify(op, x => ++x, D.inc<byte>());
            Verify(op, x => ++x, D.inc<short>());
            Verify(op, x => ++x, D.inc<ushort>());
            Verify(op, x => ++x, D.inc<int>());
            Verify(op, x => ++x, D.inc<uint>());
            Verify(op, x => ++x, D.inc<long>());
            Verify(op, x => ++x, D.inc<ulong>());
            Verify(op, x => ++x, D.inc<float>());
            Verify(op, x => ++x, D.inc<double>());              
        }

        public void Eq()
        {
            var op = OpKind.Eq;
            Verify(op, (x,y) => (x == y), D.eq<sbyte>());
            Verify(op, (x,y) => (x == y), D.eq<byte>());
            Verify(op, (x,y) => (x == y), D.eq<short>());
            Verify(op, (x,y) => (x == y), D.eq<ushort>());
            Verify(op, (x,y) => (x == y), D.eq<int>());
            Verify(op, (x,y) => (x == y), D.eq<uint>());
            Verify(op, (x,y) => (x == y), D.eq<long>());
            Verify(op, (x,y) => (x == y), D.eq<ulong>());
            Verify(op, (x,y) => (x == y), D.eq<float>());
            Verify(op, (x,y) => (x == y), D.eq<double>());              
        }

        public void Gt()
        {
            var op = OpKind.Gt;
            Verify(op, (x,y) => (x > y), D.gt<sbyte>());
            Verify(op, (x,y) => (x > y), D.gt<byte>());
            Verify(op, (x,y) => (x > y), D.gt<short>());
            Verify(op, (x,y) => (x > y), D.gt<ushort>());
            Verify(op, (x,y) => (x > y), D.gt<int>());
            Verify(op, (x,y) => (x > y), D.gt<uint>());
            Verify(op, (x,y) => (x > y), D.gt<long>());
            Verify(op, (x,y) => (x > y), D.gt<ulong>());
            Verify(op, (x,y) => (x > y), D.gt<float>());
            Verify(op, (x,y) => (x > y), D.gt<double>());              
        }

        public void GtEq()
        {
            var op = OpKind.GtEq;
            Verify(op, (x,y) => (x >= y), D.gteq<sbyte>());
            Verify(op, (x,y) => (x >= y), D.gteq<byte>());
            Verify(op, (x,y) => (x >= y), D.gteq<short>());
            Verify(op, (x,y) => (x >= y), D.gteq<ushort>());
            Verify(op, (x,y) => (x >= y), D.gteq<int>());
            Verify(op, (x,y) => (x >= y), D.gteq<uint>());
            Verify(op, (x,y) => (x >= y), D.gteq<long>());
            Verify(op, (x,y) => (x >= y), D.gteq<ulong>());
            Verify(op, (x,y) => (x >= y), D.gteq<float>());
            Verify(op, (x,y) => (x >= y), D.gteq<double>());              
        }

        public void Lt()
        {
            var op = OpKind.Lt;
            Verify(op, (x,y) => (x < y), D.lt<sbyte>());
            Verify(op, (x,y) => (x < y), D.lt<byte>());
            Verify(op, (x,y) => (x < y), D.lt<short>());
            Verify(op, (x,y) => (x < y), D.lt<ushort>());
            Verify(op, (x,y) => (x < y), D.lt<int>());
            Verify(op, (x,y) => (x < y), D.lt<uint>());
            Verify(op, (x,y) => (x < y), D.lt<long>());
            Verify(op, (x,y) => (x < y), D.lt<ulong>());
            Verify(op, (x,y) => (x < y), D.lt<float>());
            Verify(op, (x,y) => (x < y), D.lt<double>());              
        }

        public void LtEq()
        {
            var op = OpKind.LtEq;
            Verify(op, (x,y) => (x <= y), D.lteq<sbyte>());
            Verify(op, (x,y) => (x <= y), D.lteq<byte>());
            Verify(op, (x,y) => (x <= y), D.lteq<short>());
            Verify(op, (x,y) => (x <= y), D.lteq<ushort>());
            Verify(op, (x,y) => (x <= y), D.lteq<int>());
            Verify(op, (x,y) => (x <= y), D.lteq<uint>());
            Verify(op, (x,y) => (x <= y), D.lteq<long>());
            Verify(op, (x,y) => (x <= y), D.lteq<ulong>());
            Verify(op, (x,y) => (x <= y), D.lteq<float>());
            Verify(op, (x,y) => (x <= y), D.lteq<double>());              
        }
 
 
         T[] Sample<T>(bool nonzero = false)
            where T : struct
        {
            var config = Config.Get<T>();
             return nonzero 
                ? Random.NonZeroArray<T>(config.SampleSize, config.SampleDomain) 
                : Random.Array<T>(config.SampleSize, config.SampleDomain);
        }

        public void Verify<T>(OpKind opKind, UnaryOp<T> subject, UnaryOp<T> baseline, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();            
            var opid = opKind.PrimalGOpId<T>();           
            var src = Sample<T>(nonzero);
            var timing = stopwatch();                        

            for(var i = 0; i<src.Length; i++)
                Claim.eq(baseline(src[i]),subject(src[i]), caller, file, line);
            
        }

        public void Verify<T>(OpKind opKind, BinaryPredicate<T> baseline, BinaryPredicate<T> op, bool nonzero = false, 
            [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();            
            var opid = opKind.PrimalGOpId<T>();           
            var lhs = Sample<T>();
            var rhs = Sample<T>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();            

            for(var i = 0; i<len; i++)
                Claim.eq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);
            
        }

        public void Verify<T>(OpKind opKind, BinaryOp<T> baseline, BinaryOp<T> op, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>(); 
            var opid = opKind.PrimalGOpId<T>();           
            var lhs = Sample<T>();
            var rhs = Sample<T>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Require.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);
            
        }

    }
}