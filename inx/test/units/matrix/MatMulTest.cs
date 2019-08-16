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

    public class MatMulTest : UnitTest<MatMulTest>
    {

        // public void MatMulSquare()
        // {
        //     var domain = closed(-1024f, 1024f);
        //     var m1 = Random.Matrix<N5,float>(domain, x => x.Round(0));
        //     var m2 = Random.Matrix<N5,float>(domain, x => x.Round(0));
        //     var m3 = Matrix.Alloc<N5,float>();
        //     var m4 = Matrix.Alloc<N5,float>();
        //     var m5 = m1.Mul(m2,ref m3);
        //     var m6 = MatrixRefOps.Mul(m1,m2,ref m4);
        //     Claim.yea(m5 == m6);
        // }

        // void VerifyMatrixPower<N>(int exp)
        //     where N : ITypeNat, new()
        // {
        //     var m = Random.MarkovMatrix<N,double>();
        //     var powered = m.Pow(exp);
        //     Claim.yea(powered.IsRightStochastic());

        // }
        // public void MatrixPowers()
        // {
        //     VerifyMatrixPower<N7>(12);
        // }

    }

}