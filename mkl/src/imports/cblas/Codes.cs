//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    public enum BlasLayout 
    {
        RowMajor=101, /* row-major arrays */
        
        ColMajor=102 /* column-major arrays */

    }

    public enum BlasTrans 
    {
        None = 111, /* trans='N' */
        
        Transpose = 112, /* trans='T' */
        
        Conjugate = 113 /* trans='C' */
    };

    public enum BlasUpLo 
    {
        CblasUpper=121, /* uplo ='U' */
        
        CblasLower=122 /* uplo ='L' */

    };
    
    public enum BlasDiagonal 
    {
        CblasNonUnit=131, /* diag ='N' */
        
        CblasUnit=132 /* diag ='U' */

    };

    public enum BlasSide 
    {
        Left=141, /* side ='L' */

        Right=142 /* side ='R' */

    };


    public enum BlasIdentifier 
    {
        AMatrix=161, 
        
        BMatrix=162
    };

    public enum MatrixOffset
    {
        RowOffset=171, 

        ColOffset=172, 

        FixOffset=173
    };
}