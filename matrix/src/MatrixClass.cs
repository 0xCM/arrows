//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    public interface IMatrixClass
    {
        
    }

    public interface ISquareMatrix : IMatrixClass
    {
        
    }


    public readonly struct MatrixClass : IMatrixClass
    {        



    }    

    
    
    public readonly struct MatrixClass<T> : IMatrixClass
        where T : struct    
    {        



    }    

    /// <summary>
    /// Defines matrix classifications 
    /// </summary>
    public readonly struct MatrixClass<M,N,T> : IMatrixClass
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where T : struct    
    {        



    }

    public enum TriangularKind : byte
    {
        
        /// <summary>
        /// Classifies a matrix as lower-triangular
        /// </summary>
        Lower,
        
        /// <summary>
        /// Classifies a matrix as upper-triangular
        /// </summary>
        Upper,
    }    
}