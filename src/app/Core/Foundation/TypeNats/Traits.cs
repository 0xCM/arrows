//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;



    public interface TypeNat
    {
        /// <summary>
        /// Specifies the value of the natural number represented by a singleton type
        /// </summary>
        uint value {get;}

    }


    public interface NatSeq : TypeNat
    {
        byte[] digits();
    }
    


    /// <summary>
    /// Characterizes a typenat
    /// </summary>
    /// <typeparam name="T0">The represented type</typeparam>
    public interface TypeNat<T0> : TypeNat 
        where T0: TypeNat
    {
        /// <summary>
        /// Specifies the current value of the representative type
        /// </summary>
        T0 rep {get;}

    }


    /// <summary>
    /// Characterizes a typenat and its successor
    /// </summary>
    /// <typeparam name="T0">The represented type</typeparam>
    /// <typeparam name="T1">The type of the successor</typeparam>
    public interface TypeNat<T0,T1> : TypeNat<T0>
        where T0: TypeNat
        where T1: TypeNat
    {
        /// <summary>
        /// The singleton value of the representative
        /// </summary>
        /// <value></value>
        T1 nextrep {get;}
    }

    partial class Traits
    {
        public interface NatSeq<S,T1> : TypeNat<S>, NatSeq
            where S : NatSeq<S,T1>, new()
            where T1 : TypeNat, new()
        {

        }


        public interface NatSeq<S,T1,T2> : TypeNat<S>, NatSeq
            where S : NatSeq<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {

        }

        public interface NatSeq<S,T1,T2,T3> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
        {

        }

        public interface NatSeq<S,T1,T2,T3,T4> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
        {

        }

        public interface NatSeq<S,T1,T2,T3,T4,T5> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4,T5>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()        {

        }

        public interface NatSeq<S,T1,T2,T3,T4,T5,T6> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4,T5,T6>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()        
            where T6 : TypeNat, new()        
        {

        }

        public interface NatSeq<S,T1,T2,T3,T4,T5,T6,T7> : TypeNat<S>
            where S : NatSeq<S,T1,T2,T3,T4,T5,T6,T7>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
            where T3 : TypeNat, new()
            where T4 : TypeNat, new()
            where T5 : TypeNat, new()        
            where T6 : TypeNat, new()        
            where T7 : TypeNat, new()        
        {

        }

        public interface NatOp<S,T1,T2> : TypeNat<S>
            where S : NatOp<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {
            NatSeq natseq();
        }

        public interface NatAdd<S,T1,T2> : NatOp<S,T1,T2>
            where S : NatAdd<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {

        }

        public interface NatMul<S,T1,T2> : NatOp<S,T1,T2>
            where S : NatMul<S,T1,T2>, new()
            where T1 : TypeNat, new()
            where T2 : TypeNat, new()
        {
            
        }

        public interface NatExp<S,B,E> : NatOp<S,B,E>
            where S : NatExp<S,B,E>, new()
            where B : TypeNat, new()
            where E : TypeNat, new()
        {
            

        }


    }
}