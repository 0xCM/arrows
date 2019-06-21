//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
 
    public interface IRandomSource
    {
        
        ulong NextInt();

        ulong NextInt(ulong max);

        int NextInt(int max);
        
        double NextDouble();

    }


    public interface IRandomSource<T> 
        where T : struct
    {
        T Next();    

        IEnumerable<T> Stream();            
    }

}