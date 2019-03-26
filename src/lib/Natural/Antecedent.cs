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
        /// Specifies the value of the natural number represented by a singleton type
        /// </summary>
        uint value {get;}

        byte[] digits();

    }

    /// <summary>
    /// Characterizes a type-level sequence of typenats
    /// </summary>
    public interface NatSeq : TypeNat
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
        /// Specifies the current value of the representative type
        /// </summary>
        TypeNat rep {get;}

    }

    /// <summary>
    /// Characterizes a typenat and its successor
    /// </summary>
    /// <typeparam name="T1">The represented type</typeparam>
    /// <typeparam name="T2">The type of the successor</typeparam>
    public interface TypeNat<T1,T2> : TypeNat<T1>
        where T1: TypeNat
        where T2: TypeNat
    {
        /// <summary>
        /// The singleton value of the representative
        /// </summary>
        /// <value></value>
        T2 nextrep {get;}
    }

        public interface NatOp<S,T1,T2> : TypeNat<S>
            where S : NatOp<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {
            
        }

        public interface NatOp<S,T1,T2,T3> : TypeNat<S>
            where S : NatOp<S,T1,T2,T3>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
        {
        }

        public interface NatOp<S,T1,T2,T3,T4> : TypeNat<S>
            where S : NatOp<S,T1,T2,T3,T4>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
        {
        }

    
}