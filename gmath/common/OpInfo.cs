//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;
    
    public interface IOpInfo : IKinded<OpKind>
    {
        string Symbol {get;}        
    }

    /// <summary>
    /// Encapsulates selected operaator metadata and provides vehicle for
    /// polymorphic operator selection
    /// </summary>
    /// <typeparam name="T">The derived subtype</typeparam>   
    public abstract class OpInfo<T> : IOpInfo
        where T : OpInfo<T>, new()
    {
        public static readonly T Rep = new T();
        
        public OpKind Kind {get;}

        public string Symbol {get;}


        protected OpInfo(OpKind Kind, string Symbol = null)
        {
            this.Kind = Kind;
            this.Symbol = Symbol ?? string.Empty;
        }
        
        public override string ToString()
            => ifBlank(Symbol, $"{Kind}".ToLower());

        public override bool Equals(object obj)
            => (obj as OpInfo<T>) != null 
              ? (obj as OpInfo<T>).Kind == this.Kind 
              : false;

        public override int GetHashCode()
            => Kind.GetHashCode();

    }

    public static class OpInfo    
    {
        /// <summary>
        /// The Add operator descriptor representative
        /// </summary>
        public static readonly Add AddRep = Add.Rep;
        
        /// <summary>
        /// The Sub operator descriptor representative
        /// </summary>
        public static readonly Sub SubRep = Sub.Rep;

        /// <summary>
        /// The Mul operator descriptor representative
        /// </summary>
        public static readonly Mul MulRep = Mul.Rep;

        /// <summary>
        /// The Div operator descriptor representative
        /// </summary>
        public static readonly Div DivRep = Div.Rep;

        /// <summary>
        /// The Mod operator descriptor representative
        /// </summary>
        public static readonly Mod ModRep = Mod.Rep;

        /// <summary>
        /// The And operator descriptor representative
        /// </summary>
        public static readonly And AndRep = And.Rep;

        /// <summary>
        /// The Or operator descriptor representative
        /// </summary>
        public static readonly Or OrRep = Or.Rep;

        /// <summary>
        /// The XOr operator descriptor representative
        /// </summary>
        public static readonly XOr XOrRep = XOr.Rep;


        /// <summary>
        /// Describes the Add operation
        /// </summary>
        public sealed class Add : OpInfo<Add>
        {
            public Add()
            : base(OpKind.Add,"+")
            {


            }
        }

        /// <summary>
        /// Describes the Sub operation
        /// </summary>
        public sealed class Sub : OpInfo<Sub>
        {
            public Sub()
            : base(OpKind.Sub,"-")
            {


            }
        }

        /// <summary>
        /// Describes the Sub operation
        /// </summary>
        public sealed class Sum : OpInfo<Sum>
        {
            public Sum()
            : base(OpKind.Sum,"Σ")
            {


            }
        }


        /// <summary>
        /// Describes the Mul operation
        /// </summary>
        public sealed class Mul : OpInfo<Mul>
        {
            public Mul()
             : base(OpKind.Mul,"-")
            {


            }
        }


        /// <summary>
        /// Describes the Div operation
        /// </summary>
        public sealed class Div : OpInfo<Div>
        {
            public Div()
             : base(OpKind.Div,"/")
            {

            }
        }

        /// <summary>
        /// Describes the Mod operation
        /// </summary>
        public sealed class Mod : OpInfo<Mod>
        {
            public Mod()
             : base(OpKind.Mod,"/")
            {


            }
        }
    
        /// <summary>
        /// Describes the bitwise and operation
        /// </summary>
        public sealed class And : OpInfo<And>
        {
            public And()
             : base(OpKind.Add,"&")
            {


            }
        }

        /// <summary>
        /// Describes the bitwise or operation
        /// </summary>
        public sealed class Or : OpInfo<Or>
        {
            public Or()
             : base(OpKind.Or,"|")
            {

            }
        }

        /// <summary>
        /// Describes the bitwise xor operation
        /// </summary>
        public sealed class XOr : OpInfo<XOr>
        {
            public XOr()
             : base(OpKind.XOr,"^")
            {


            }
        }
    }
}