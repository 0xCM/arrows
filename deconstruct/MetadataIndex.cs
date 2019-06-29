//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using dnlib.DotNet;
    using MdSig = dnlib.DotNet.MethodSig;

    using static zfunc;
    
    public class MetadataIndex
    {
        public static MetadataIndex Define(params Module[] modules)
            => new MetadataIndex(modules);

        MetadataIndex(params Module[] modules)
        {
            iter(modules, IndexModule);
        }

        public Option<MethodCilBody> FindCil(MethodInfo mi)
            => InstructionIndex.TryFind(mi.MetadataToken);

        public Option<TypeSig> FindMdSig(Type t)
        {
            if(TypeIndex.TryGetValue(t.MetadataToken, out TypeDef td))
                return td.ToTypeSig();
            else
                return none<TypeSig>();
        }

        public Option<MdSig> FindMdSig(MethodInfo mi)
        {
            if(MethodIndex.TryGetValue(mi.MetadataToken, out MethodDef md))
                return md.MethodSig;
            else
                return none<MdSig>();
        }

        ConcurrentDictionary<int, ModuleDefMD> ModuleIndex 
            = new ConcurrentDictionary<int, ModuleDefMD>();
        ConcurrentDictionary<int, TypeDef> TypeIndex 
            = new ConcurrentDictionary<int, TypeDef>();
        ConcurrentDictionary<int, MethodDef> MethodIndex 
            = new ConcurrentDictionary<int, MethodDef>();
        ConcurrentDictionary<int, MethodCilBody> InstructionIndex 
            = new ConcurrentDictionary<int, MethodCilBody>();

        TypeDef ResolveType(ModuleDefMD mod, string fullName)
        {
            var def =  new TypeRefUser(mod, fullName).Resolve();
            if(def == null)
                throw new Exception($"Coud not resolve type {fullName}");
            return def;
        }

        ModuleDefMD GetModDef(Module src)
        {
            var metadata = ModuleIndex.GetOrAdd(src.MetadataToken,
                 _ => ModuleDefMD.Load(src));
            return metadata;
        }

        TypeDef GetTypeDef(Type src)
        {
            var declMod = GetModDef(src.Module);
            var typeDef = TypeIndex.GetOrAdd(src.MetadataToken, 
                _ => ResolveType(declMod, src.FullName));
            return typeDef;
        }

        MethodCilBody ExtractCil(MethodDef md)
        {
            var mid = (int)md.MDToken.Raw;
            var instructions = md.Body.Instructions.ToReadOnlyList();
            var mcil = new MethodCilBody(mid, md.FullName, instructions);
            return mcil;
        }
        
        void IndexCil(MethodDef md)
        {
            var mid = (int)md.MDToken.Raw;
            var mcil = ExtractCil(md);
            Claim.yea(InstructionIndex.TryAdd(mid, mcil));
            md.FreeMethodBody();

        }
        void IndexMethod(MethodDef md)
        {
            var mid = (int)md.MDToken.Raw;
            Claim.yea(MethodIndex.TryAdd(mid, md));
            if(md.HasBody && md.Body.HasInstructions)
                IndexCil(md);

        }
        void IndexType(TypeDef t)
        {
            Claim.yea(TypeIndex.TryAdd((int)t.MDToken.Raw, t));
            foreach(var md in t.Methods)
                IndexMethod(md);

        }
        void IndexModule(Module mod)
        {
            var modDef = GetModDef(mod);
            foreach(var t in modDef.GetTypes())
                IndexType(t);
        }        
    }
}