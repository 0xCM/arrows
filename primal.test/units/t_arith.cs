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

    class t_arith : UnitTest<t_arith>
    {
        public t_arith()
            : base()
        {

        }
     
        public void inc()
        {
            VerifyOp(x => ++x, D.inc<sbyte>());
            VerifyOp(x => ++x, D.inc<byte>());
            VerifyOp(x => ++x, D.inc<short>());
            VerifyOp(x => ++x, D.inc<ushort>());
            VerifyOp(x => ++x, D.inc<int>());
            VerifyOp(x => ++x, D.inc<uint>());
            VerifyOp(x => ++x, D.inc<long>());
            VerifyOp(x => ++x, D.inc<ulong>());
            VerifyOp(x => ++x, D.inc<float>());
            VerifyOp(x => ++x, D.inc<double>());              
        }

        public void eq()
        {
            VerifyOp((x,y) => (x == y), D.eq<sbyte>());
            VerifyOp((x,y) => (x == y), D.eq<byte>());
            VerifyOp((x,y) => (x == y), D.eq<short>());
            VerifyOp((x,y) => (x == y), D.eq<ushort>());
            VerifyOp((x,y) => (x == y), D.eq<int>());
            VerifyOp((x,y) => (x == y), D.eq<uint>());
            VerifyOp((x,y) => (x == y), D.eq<long>());
            VerifyOp((x,y) => (x == y), D.eq<ulong>());
            VerifyOp((x,y) => (x == y), D.eq<float>());
            VerifyOp((x,y) => (x == y), D.eq<double>());              
        }

        public void gt()
        {
            VerifyOp((x,y) => (x > y), D.gt<sbyte>());
            VerifyOp((x,y) => (x > y), D.gt<byte>());
            VerifyOp((x,y) => (x > y), D.gt<short>());
            VerifyOp((x,y) => (x > y), D.gt<ushort>());
            VerifyOp((x,y) => (x > y), D.gt<int>());
            VerifyOp((x,y) => (x > y), D.gt<uint>());
            VerifyOp((x,y) => (x > y), D.gt<long>());
            VerifyOp((x,y) => (x > y), D.gt<ulong>());
            VerifyOp((x,y) => (x > y), D.gt<float>());
            VerifyOp((x,y) => (x > y), D.gt<double>());              
        }

        public void gteq()
        {
            VerifyOp((x,y) => (x >= y), D.gteq<sbyte>());
            VerifyOp((x,y) => (x >= y), D.gteq<byte>());
            VerifyOp((x,y) => (x >= y), D.gteq<short>());
            VerifyOp((x,y) => (x >= y), D.gteq<ushort>());
            VerifyOp((x,y) => (x >= y), D.gteq<int>());
            VerifyOp((x,y) => (x >= y), D.gteq<uint>());
            VerifyOp((x,y) => (x >= y), D.gteq<long>());
            VerifyOp((x,y) => (x >= y), D.gteq<ulong>());
            VerifyOp((x,y) => (x >= y), D.gteq<float>());
            VerifyOp((x,y) => (x >= y), D.gteq<double>());              
        }

        public void lt()
        {
            VerifyOp((x,y) => (x < y), D.lt<sbyte>());
            VerifyOp((x,y) => (x < y), D.lt<byte>());
            VerifyOp((x,y) => (x < y), D.lt<short>());
            VerifyOp((x,y) => (x < y), D.lt<ushort>());
            VerifyOp((x,y) => (x < y), D.lt<int>());
            VerifyOp((x,y) => (x < y), D.lt<uint>());
            VerifyOp((x,y) => (x < y), D.lt<long>());
            VerifyOp((x,y) => (x < y), D.lt<ulong>());
            VerifyOp((x,y) => (x < y), D.lt<float>());
            VerifyOp((x,y) => (x < y), D.lt<double>());              
        }

        public void lteq()
        {
            VerifyOp((x,y) => (x <= y), D.lteq<sbyte>());
            VerifyOp((x,y) => (x <= y), D.lteq<byte>());
            VerifyOp((x,y) => (x <= y), D.lteq<short>());
            VerifyOp((x,y) => (x <= y), D.lteq<ushort>());
            VerifyOp((x,y) => (x <= y), D.lteq<int>());
            VerifyOp((x,y) => (x <= y), D.lteq<uint>());
            VerifyOp((x,y) => (x <= y), D.lteq<long>());
            VerifyOp((x,y) => (x <= y), D.lteq<ulong>());
            VerifyOp((x,y) => (x <= y), D.lteq<float>());
            VerifyOp((x,y) => (x <= y), D.lteq<double>());     
        }
    }
}