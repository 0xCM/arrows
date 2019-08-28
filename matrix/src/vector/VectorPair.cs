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
    using System.Runtime.InteropServices;
    
    using static nfunc;
    using static zfunc;


    /// <summary>
    /// Defines a pair of pair of natural vectors
    /// </summary>
    public ref struct VectorPair<N,T>
        where T : struct
        where N : ITypeNat, new()
    {
        public VectorPair(Vector<N,T> Left, Vector<N,T> Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
        
        public Vector<N,T> Left;


        public Vector<N,T> Right;
    }

}