//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static mfunc;

    partial class Vec128Bench
    {   

        public IBenchComparison CreateI8()
        {
            var data = UnaryOpInit<sbyte>();
            var opid = Id<sbyte>(OpKind.New);

            var src = data.Source;
            var direct = Measure(opid, () => 
                {
                    var i =0;
                    dinx.store(Vec128.define(
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++],
                        src[i++], src[i++], src[i++], src[i++]),
                        data.RightTarget);
                });

            var generic = Measure(~opid, () => 
                dinx.store(Vec128.define(ref src), data.LeftTarget));

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison CreateI32()
        {
            var data = UnaryOpInit<int>();
            var opid = Id<int>(OpKind.New);

            var src = data.Source;
            var direct = Measure(opid, () => 
                dinx.store(Vec128.define(src[0], src[1], src[2], src[3]), data.RightTarget));

            var generic = Measure(~opid, () => 
                dinx.store(Vec128.define(ref src), data.LeftTarget));

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

        public IBenchComparison CreateF64()
        {
            var data = UnaryOpInit<double>();
            var opid = Id<double>(OpKind.New);

            var src = data.Source;
            var direct = Measure(opid, () => 
                dinx.store(Vec128.define(src[0], src[1]), data.RightTarget));

            var generic = Measure(~opid, () => 
                dinx.store(Vec128.define(ref src), data.LeftTarget));

            var comparison = Compare(opid, direct, generic);
            Claim.eq(data.LeftTarget, data.RightTarget);        
            return Finish(comparison);            
        }

    }

}