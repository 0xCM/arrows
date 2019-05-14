//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type-level natural number, a *typenat*
    /// </summary>
    public interface ITypeNat
    {
        /// <summary>
        /// Specifies the value of the associated natural number
        /// </summary>
        ulong value {get;}

        /// <summary>
        /// Specifies the associated base-10 digits 
        /// </summary>
        byte[] Digits();

        /// <summary>
        /// Specifies the canonical sequence representative
        /// </summary>
        NatSeq seq {get;}

    }

    /// <summary>
    /// Characterizes a typenat
    /// </summary>
    /// <typeparam name="T">The represented type</typeparam>
    public interface TypeNat<T> : ITypeNat 
        where T: ITypeNat
    {
        /// <summary>
        /// Specifies the representing type
        /// </summary>
        ITypeNat rep {get;}


    }

}