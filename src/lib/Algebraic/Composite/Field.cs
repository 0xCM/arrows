//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {
        public interface Field<T> : CommutativeRing<T>, DivisionRing<T>
        {

        }


    }
    partial class Structures
    {
        
        public interface Field<S> : CommutativeRing<S>, DivisionRing<S>
            where S : Field<S>, new()
        {

        }
        

    }

}