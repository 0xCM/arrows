//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Threading;
    using System.Reflection.Emit;
    using System.Linq;

    using static zfunc;

    public static class Record
    {
        /// <summary>
        /// Defines a record field
        /// </summary>
        /// <param name="FieldName">The field name</param>
        /// <param name="Position">The ordinal position</param>
        /// <param name="Offset">The struct layout offset</param>
        /// <param name="FieldType">The assembly-qualified field type name</param>
        public static FieldSpec DefineField(string FieldName, int Position, ByteSize Offset, string FieldType)
            => new FieldSpec(FieldName, Position, Offset, FieldType);

        /// <summary>
        /// Defines a record
        /// </summary>
        /// <param name="Namespace">The enclosing namespace</param>
        /// <param name="TypeName">The name of the type, i.e. the simple type name that does not include the namespece</param>
        /// <param name="Fields">The record fields</param>
        public static RecordSpec DefineRecord(string Namespace, string TypeName, params FieldSpec[] Fields)
            => new RecordSpec(Namespace, TypeName, Fields);

        public static IReadOnlyList<string> GetHeaders<T>()
            => type<T>().DeclaredProperties().Select(p => p.Name).ToReadOnlyList();

        public static IEnumerable<string> Delimited<T>(this IEnumerable<IRecord<T>> records, char delimiter  = '|')
            => records.Select(r => r.DelimitedText(delimiter));

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type CreateType(RecordSpec spec)        
            => DefineModule().DefineRecord(spec);

        /// <summary>
        /// Manufactures the types that reifies supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        public static Type[] CreateTypes(params RecordSpec[] specs)
        {
            var dst = new Type[specs.Length];
            var mb = DefineModule();
            for(var i=0; i< specs.Length; i++)
                dst[i] = mb.DefineRecord(specs[i]);
            return dst;
        }

        static Type Example()
        {
            var f1 = Record.DefineField("Field1", 0, 0, typeof(int).AssemblyQualifiedName);
            var f2 = Record.DefineField("Field2", 1, 4, typeof(long).AssemblyQualifiedName);
            var f3 = Record.DefineField("Field3", 2, 12, typeof(bool).AssemblyQualifiedName);
            var r = Record.DefineRecord("Test.Records", "MyRecord", f1,f2,f3);
            var t = r.CreateType();
            return t;
        }

        static FieldBuilder DefineField(this TypeBuilder tb, FieldSpec spec)
        {            
            
            var fb = tb.DefineField(spec.FieldName,Type.GetType(spec.FieldType), FieldAttributes.Public);
            fb.SetOffset(spec.Offset);            
            return fb;
        }

        static Type DefineRecord(this ModuleBuilder mb, RecordSpec spec)
        {
            const TypeAttributes attribs 
                = TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.ExplicitLayout |
                  TypeAttributes.Serializable | TypeAttributes.AnsiClass;
            
            var fullName = string.IsNullOrWhiteSpace(spec.Namespace) ? spec.Namespace : $"{spec.Namespace}.{spec.TypeName}";
            TypeBuilder tb = mb.DefineType(fullName, attribs, typeof(ValueType));
            foreach(var field in spec.Fields)
                tb.DefineField(field);
            var type = tb.CreateType();
            return type;            
        }

        static ModuleBuilder DefineModule()        
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
            return ab.DefineDynamicModule("Primary");
        }
    }
}