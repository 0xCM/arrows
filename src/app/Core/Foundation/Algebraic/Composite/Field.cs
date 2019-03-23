//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Traits
    {
        public interface Field<S,T> : CommutativeRing<S,T>, DivisionRing<S,T>
            where S : Field<S,T>,  new()
        {


        }

    }

}