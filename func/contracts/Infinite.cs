//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum OrientedInfinity
    {
        NegativeInfinity = Orientation.Left,

        PositiveInfinity = Orientation.Right
    }

    /// <summary>
    /// Characterizes operations over operands for which a given reification may be infinite
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IInfiniteOps<T>
    
    {
        
    }
}