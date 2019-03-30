//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    using static Nats;
    using static zcore;



    public class MatrixShaping
    {

        static readonly RandUInt random = Context.Random;

        static IEnumerable<Matrix<M,N, real<byte>>> matrices<M,N>(Dim<M,N> dim)
            where M : TypeNat, new()
            where N : TypeNat, new()
            {
                var len = dim.volume();
                while(true)
                {
                    var entries = random.next(len, Byte.MinValue, Byte.MaxValue);
                    yield return Matrix.define(dim, entries);
                }
                    
            }  


        public static void deletion()
        {
            var srcdim = dim(N5,N5);
            var src = matrices(srcdim).Take(5);
            var ops = Matrix.ops(srcdim, real<byte>(0));
            foreach(var m in src)
            {
                // var r = m.row(0);
                // var c = m.col(0);
                var deleted = ops.delete(m, 0, 0).reinterpret(dim(N4,N4));
                var submatrix = ops.submatrix(m, dim(N4,N4), (1,1));

                print($"full matrix: {m}");
                print($"deleted matrix: {deleted}");
                print($"submatrix: {submatrix}");

            }
            

        }

    }

}