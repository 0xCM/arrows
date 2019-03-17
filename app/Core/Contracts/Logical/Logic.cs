//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    public interface Doctrine<D>
    {
        
    }

    /// <summary>
    /// Characterizes a logical type-theoretic context that specifies the 
    /// assumptions prior to adjudication/judgement of the truth of a statement
    /// within a given doctrine
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// See https://ncatlab.org/nlab/show/context
    /// See https://ncatlab.org/nlab/show/doctrine
    public interface Context<C,D>
        where D : Doctrine<D>
    {

    }


}