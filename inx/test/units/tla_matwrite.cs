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
    using static nfunc;
    using static Nats;

    public class tla_matwrite : UnitTest<tla_matwrite>
    {
        public void WriteMatrix()
        {
            VerifyWriter<N12,N14,long>(Pow2.T03);        
            VerifyWriter<N19,N32,byte>(Pow2.T03);        
            VerifyWriter<N5,N5,float>(Pow2.T03);    
            VerifyWriter(Pow2.T03, N31, N31, 0u);                    
            VerifyWriter<N7,N7,double>(Pow2.T03);    
            
        }

        static T round<T>(T src)
            where T : struct
        {
            return gfp.round(src, 4);
        }

        void VerifyWriter<M,N,T>(int count, M m = default, N n = default, T exemplar = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var isFp = gmath.isFloat<T>();
            TypeCaseStart<M,N,T>();
            for(var i=0; i< count; i++)
            {
                var filename = Matrix.DataFileName<M,N,T>();
                var dstpath = LogSettings.Get().TestLogPath(filename);
                var A = Random.Matrix<M,N,T>();
                if(isFp)
                    A.Apply(round);
                A.WriteTo(dstpath);

                var srcPath = dstpath;
                var B = Matrix.ReadFrom<M,N,T>(srcPath);
                if(isFp)
                    B.Apply(round);

                Claim.yea(A == B);

            }

            TypeCaseEnd<M,N,T>();
        }


    }

}