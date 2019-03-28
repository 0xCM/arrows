//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type-level natural number, a *typenat*
    /// </summary>
    public interface TypeNat
    {
        /// <summary>
        /// Specifies the value of the associated natural number
        /// </summary>
        uint value {get;}

        /// <summary>
        /// Specifies the associated base-10 digits 
        /// </summary>
        byte[] digits();

        /// <summary>
        /// Specifies the canonical sequence representative
        /// </summary>
        NatSeq seq {get;}

    }

    /// <summary>
    /// Characterizes a type-level sequence of typenats
    /// </summary>
    public interface NatSeq : TypeNat
    {

    }

    /// <summary>
    /// Characterizes a natural sequence with an unspecified number of terms
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface NatSeq<S> : TypeNat<S>, NatSeq
        where S : NatSeq<S>, new()
    {

    }

    
    /// <summary>
    /// Characterizes a typenat
    /// </summary>
    /// <typeparam name="T">The represented type</typeparam>
    public interface TypeNat<T> : TypeNat 
        where T: TypeNat
    {
        /// <summary>
        /// Specifies the representing type
        /// </summary>
        TypeNat rep {get;}


    }

    /// <summary>
    /// Characterizes an atom of the type natural grammar
    /// </summary>
    /// <typeparam name="N">The reifying type</typeparam>
    public interface NatPrim<N> : TypeNat<N>
        where N : NatPrim<N>,new()
    {
        
    }

    public interface NatOp<S,T1,T2> : TypeNat<S>
        where S : NatOp<S,T1,T2>, new()
        where T1 : TypeNat, new()
        where T2 : TypeNat, new()
    {
        
    }    
}