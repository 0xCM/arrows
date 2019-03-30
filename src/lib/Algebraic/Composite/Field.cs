//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Structure
    {
        public interface Field<S,T> : CommutativeRing<S,T>, DivisionRing<S,T>
            where S : Field<S,T>,  new()
        {


        }

    }

}