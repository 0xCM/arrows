//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public abstract class ClrItemRef
    {
        protected ClrItemRef(string Name)
            => this.Name = Name;

        public virtual string Name {get;}

        public virtual string Format()
            => Name.ToString();

        public override string ToString()
            => Format();
    }

    public abstract class ClrItemRefs<S,T>
        where S : ClrItemRefs<S,T>
        where T : ClrItemRef
    {
        protected abstract IReadOnlyList<T> Items {get;}

        public virtual string Format()
            => Items.Select(x => x.Format()).Concat(", ");            
        
        public override string ToString()
            => Format();
    }

    /// <summary>
    /// Identifes and describes (but does not define) a type
    /// </summary>
    public class TypeRef : ClrItemRef
    {        
        public static TypeRef FromType(Type src)
            => new TypeRef(src.DisplayName(), src.IsConstructedGenericType,  
                    src.IsGenericType && !src.IsConstructedGenericType);

        public TypeRef(string TypeName, bool IsOpenGeneric, bool IsClosedGeneric)
            : base(TypeName)
        {
            this.IsOpenGeneric = IsOpenGeneric;
            this.IsClosedGeneric = IsClosedGeneric;
        }

        public bool IsOpenGeneric {get;}

        public bool IsClosedGeneric {get;}


        
    }

    /// <summary>
    /// Identifes and describes (but does not define) a type parameter
    /// which appear in generic type/method definitions
    /// </summary>
    public class TypeParamRef : TypeRef
    {
        public TypeParamRef(string Name, int Position, bool IsOpenGeneric = true)
            : base(Name, IsOpenGeneric, !IsOpenGeneric)
        {
            this.Position = Position;
        }

        public int Position {get;}
        
        public string Format(bool fence)
            => fence ? angled(Name) : Name;

        public override string Format()
            => Format(false);

    }

    public class TypeParamRefs : ClrItemRefs<TypeParamRefs, TypeParamRef>
    {
        readonly TypeParamRef[] refs;

        public TypeParamRefs(IEnumerable<TypeParamRef> refs)
            => this.refs = refs.ToArray();

        protected override IReadOnlyList<TypeParamRef> Items
            => refs;

        public string Format(bool fence)
        {            
            var content = refs.Select(x => x.Format(false)).Concat(", ");
            return fence ? angled(content) : content;
        }

        public override string Format()
            => Format(true);
    }

    public class MethodParamRef : ClrItemRef
    {        
        public MethodParamRef(TypeRef Type, string ParamName, int Position)
            : base(ParamName)            
        {
            this.Type = Type;
            this.Position = Position;
        }

        public TypeRef Type {get;}

        public int Position {get;}

        public override string Format()
            => $"{Type} {Name}";

        public override string ToString()
            => Format();

    }

    public class MethodSig
    {
        public static MethodSig Define(MethodInfo method)
        {
            var sig = new MethodSig();
            var ret = method.ReturnType;

            sig.MethodName = method.DisplayName();
            sig.ReturnType =  TypeRef.FromType(ret);
            sig.MethodParams = method.GetParameters().Select(x => new MethodParamRef(TypeRef.FromType(x.ParameterType), x.Name, x.Position)).ToList();
            sig.TypeParams = new TypeParamRefs(method.GenericSlots().Mapi((i,t) => new TypeParamRef(t.DisplayName(), i)));
            
            return sig;
        }

        public string MethodName {get; private set;}

        public TypeRef ReturnType {get; private set;}

        public IReadOnlyList<MethodParamRef> MethodParams {get; private set;}

        public TypeParamRefs TypeParams {get; private set;}
        
        public string Format()
        {
            var sigtext = sbuild();            
            sigtext.Append(ReturnType.Format());
            sigtext.Append(AsciSym.Space);
            sigtext.Append(MethodName);
            sigtext.Append(TypeParams.Format(true));
            sigtext.Append(AsciSym.LParen);            
            sigtext.Append(MethodParams.Select(mp => mp.Format()).Concat(", "));
            sigtext.Append(AsciSym.RParen);
            return sigtext.ToString();
        }

        public override string ToString()
            => Format();


    }


}