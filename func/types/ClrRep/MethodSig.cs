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

    /// <summary>
    /// Identifies and describes a method that, whithin some useful scope, is unique
    /// </summary>
    public class MethodSig
    {
        public static MethodSig Define(MethodInfo method)
        {            
            return new MethodSig(
                method.MetadataToken,
                method.Module.Assembly.GetSimpleName(),
                method.Module.Name,
                method.DeclaringType.Namespace,
                method.DeclaringType.Name,
                method.DisplayName(),
                TypeRep.FromType(method.ReturnType),
                method.GetParameters().Select(p => new MethodParamRep(TypeRep.FromParameter(p), p.Direction(), p.Name, p.Position)).ToArray(),
                method.GenericSlots().Mapi((i,t) => new TypeParamRep(t.DisplayName(), i, t.IsGenericType)));
        }

        public MethodSig(int MethodId, string DefiningAssembly, string DefiningModule, string DeclaringNamespace, string DeclaringType, string MethodName, TypeRep ReturnType, MethodParamReps ValueParams, TypeParamReps TypeParams)
        {
            this.MethodId = MethodId;
            this.DefiningAssembly = DefiningAssembly;
            this.DefiningModule = DefiningModule;
            this.DeclaringType = DeclaringType;
            this.MethodName = MethodName;
            this.ReturnType = ReturnType;
            this.ValueParams = ValueParams;
            this.TypeParams = TypeParams;
        }
        
        public int MethodId {get;}
        
        public string MethodName {get;}

        public string DefiningAssembly {get;}

        public string DefiningModule {get;}

        public string DeclaringNamespace {get;}

        public string DeclaringType {get;}

        public TypeRep ReturnType {get; }

        public MethodParamReps ValueParams {get; }

        public TypeParamReps TypeParams {get; }
                
        public string Format()
        {
            var sigtext = sbuild();            
            sigtext.Append(ReturnType.Format());
            sigtext.Append(AsciSym.Space);
            sigtext.Append(MethodName);
            sigtext.Append(ValueParams.Format(true));
            var text = sigtext.ToString();
            return text;
            
        }

        public override string ToString()
            => Format();
    }
}