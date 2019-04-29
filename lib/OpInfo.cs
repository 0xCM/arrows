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

    using static zcore;
    using static primops;

    public interface IOpInfo
    {
        string Name {get;}

        string Symbol {get;}
        
    }
    public abstract class OpInfo<T> : IOpInfo
        where T : OpInfo<T>
    {
        public string Name {get;}

        public string Symbol {get;}


        protected OpInfo(string Name, string Symbol = null)
        {
            this.Name = Name;
            this.Symbol = Symbol ?? string.Empty;
        }
        
        public override string ToString()
            => ifBlank(Symbol,Name);
    }

    public static class OpInfo    
    {
        public static readonly AddInfo Add = AddInfo.TheOnly;
        
        public static readonly SubInfo Sub = SubInfo.TheOnly;

        public sealed class AddInfo : OpInfo<AddInfo>
        {
            internal static readonly AddInfo TheOnly = new AddInfo();
            
            AddInfo()
            : base("add","+")
            {


            }
        }

        public sealed class SubInfo : OpInfo<SubInfo>
        {
            internal static readonly SubInfo TheOnly = new SubInfo();
            
            SubInfo()
            : base("sub","-")
            {


            }
        }

    }

    public enum OpSet
    {
        
        All, 
        
        Primal, // PrimalAtomic & PrimalFused
        
        Intrisic,   // IntricFused & IntrinsicAtomic
        
        Fused,      //IntrinsicFused & PrimalFused

        Atomic    //IntrinsicAtomic & PrimalAtomic
        
    }

    

 
}