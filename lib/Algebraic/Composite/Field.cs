//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {
        public interface IFieldOps<T> : ICommutativeRingOps<T>, IDivisionRingOps<T>
        {

        }


    }
    partial class Structures
    {
        
        public interface IField<S> : ICommutativeRing<S>, IDivisionRing<S>
            where S : IField<S>, new()
        {

        }
        

    }

}