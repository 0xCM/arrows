//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;
    using static Nats;

    public class tgetrf : MklTest<tgetrf>
    {
        // Taken from https://www.ibm.com/support/knowledgecenter/en/SSFHY8_6.1/reference/am5gr_hsgetrf.html
        static Matrix<N9,double> DGETRF_In
            => Matrix.Define(new double[]{
            1.0,  1.2,  1.4,  1.6,  1.8,  2.0,  2.2,  2.4,  2.6,
            1.2,  1.0,  1.2,  1.4,  1.6,  1.8,  2.0,  2.2,  2.4,
            1.4,  1.2,  1.0,  1.2,  1.4,  1.6,  1.8,  2.0,  2.2,
            1.6,  1.4,  1.2,  1.0,  1.2,  1.4,  1.6,  1.8,  2.0,
            1.8,  1.6,  1.4,  1.2,  1.0,  1.2,  1.4,  1.6,  1.8,             
            2.0,  1.8,  1.6,  1.4,  1.2,  1.0,  1.2,  1.4,  1.6, 
            2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0,  1.2,  1.4, 
            2.4,  2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0,  1.2,
            2.6,  2.4,  2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0
            }, N9);
            
        static Matrix<N9,double> DGETRF_Out
            => Matrix.Define(new double[]{
                2.6,   2.4,  2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0, 
                0.4,   0.3,  0.6,  0.8,  1.1,  1.4,  1.7,  1.9,  2.2,
                0.5,  -0.4,  0.4,  0.8,  1.2,  1.6,  2.0,  2.4,  2.8,
                0.5,  -0.3,  0.0,  0.4,  0.8,  1.2,  1.6,  2.0,  2.4,
                0.6,  -0.3,  0.0,  0.0,  0.4,  0.8,  1.2,  1.6,  2.0,
                0.7,  -0.2,  0.0,  0.0,  0.0,  0.4,  0.8,  1.2,  1.6,
                0.8,  -0.2,  0.0,  0.0,  0.0,  0.0,  0.4,  0.8,  1.2,
                0.8,  -0.1,  0.0,  0.0,  0.0,  0.0,  0.0,  0.4,  0.8,
                0.9,  -0.1,  0.0,  0.0,  0.0,  0.0,  0.0,  0.0,  0.4 
            },N9);


        public void Getrf32()
        {


        }

        public void Getrf64_A()
        {
            var A = DGETRF_In;
            var X = A.Replicate(true);
            Span<int> pivots = new int[18];
            mkl.getrf(A, pivots, ref X);
            X.Apply(x => x.Round(1));
            Claim.yea(X == DGETRF_Out);
        }

        void Getrf64<M,N>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var m = nati<M>();
            var n = nati<N>(); 
            var cells = m*n;
            
            
            Span<int> pivots = new int[math.max(m,n)*2];

            var A = RMat<M,N,double>(closed(1,250.0)).Apply(x => x.Truncate());
            var X = Matrix.Alloc<M,N,double>();
            mkl.getrf(A, pivots, ref X);
            X.Apply(x => x.Round(4));

        }

        public void Getrf64()
        {
            Getrf64<N8,N8>();                
        }
    }

}