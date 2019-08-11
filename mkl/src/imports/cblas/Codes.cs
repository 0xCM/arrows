//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    public enum MatrixLayout 
    {
        RowMajor=101, /* row-major arrays */
        ColMajor=102 /* column-major arrays */

    }

    public enum MatrixTranspose 
    {
        None = 111, /* trans='N' */
        Transpose = 112, /* trans='T' */
        Conjugate = 113 /* trans='C' */
    };

    public enum CBLAS_UPLO 
    {
        CblasUpper=121, /* uplo ='U' */
        CblasLower=122 /* uplo ='L' */

    };
    
    public enum CBLAS_DIAG 
    {
        CblasNonUnit=131, /* diag ='N' */
        CblasUnit=132 /* diag ='U' */

    };

    public enum CBLAS_SIDE 
    {
        CblasLeft=141, /* side ='L' */

        CblasRight=142 /* side ='R' */

    };

    public enum CBLAS_STORAGE 
    {
        CblasPacked=151
    };

    public enum CBLAS_IDENTIFIER 
    {
        CblasAMatrix=161, 
        CblasBMatrix=162
    };

    public enum CBLAS_OFFSET 
    {
        CblasRowOffset=171, 
        CblasColOffset=172, 
        CblasFixOffset=173
    };
}