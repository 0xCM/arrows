//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
 
    /// <summary>
    /// Defines required operations for all RNG's 
    /// </summary>
    public interface IRandomSource
    {
        
        ulong NextInt();

        ulong NextInt(ulong max);

        int NextInt(int max);
        
        double NextDouble();

    }

    public interface IRandomSource<T> : IRandomSource
        where T : struct
    {
                
    }

}