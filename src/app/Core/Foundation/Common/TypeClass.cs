//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    public interface TypeClass
    {
        
    }
    
    public interface TypeClass<T> : TypeClass, Singleton<T>
        where T : TypeClass<T>, new()
    {
        
    }

    public interface TypeClass<T,K> : TypeClass<T>
        where T : TypeClass<T>, new()
    {
        
    }

}