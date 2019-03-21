//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    public interface TypeClass
    {
        
    }
    
    public interface TypeClass<T0> : TypeClass
        where T0 : TypeClass<T0>, new()
    {
        
    }


}