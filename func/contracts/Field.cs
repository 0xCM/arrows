//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IFieldOps<T> : ICommutativeRingOps<T>, IDivisionRingOps<T>
        where T : struct
    {

    }
    
    public interface IField<S> : ICommutativeRing<S>, IDivisionRing<S>
            where S : IField<S>, new()
    {

     
    }
        
}