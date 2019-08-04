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

    public interface IRecord
    {
        string Delimited(char delimiter = ',', bool digitcommas = false);

        IReadOnlyList<string> GetHeaders();
        
    }

    public interface IRecord<T> : IRecord
    {
        IReadOnlyList<string> Headers
            => type<T>().DeclaredProperties().Select(p => p.Name).ToReadOnlyList();
    }

    public static class Records
    {
        static Type Example()
        {
            var f1 = FieldSpec.Define("Field1", 0, 0, typeof(int).AssemblyQualifiedName);
            var f2 = FieldSpec.Define("Field2", 1, 4, typeof(long).AssemblyQualifiedName);
            var f3 = FieldSpec.Define("Field3", 2, 12, typeof(bool).AssemblyQualifiedName);
            var r = RecordSpec.Define("Test.Records", "MyRecord", f1,f2,f3);
            var t = r.DefineType();
            return t;

        }

        static FieldBuilder DefineRecordField(this TypeBuilder tb, FieldSpec spec)
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
                tb.DefineRecordField(field);
            var type = tb.CreateType();
            return type;            
        }

        static ModuleBuilder DefineModule()        
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
            return ab.DefineDynamicModule("Primary");
        }

        public static Type DefineType(this RecordSpec spec)        
        {
            var mb = DefineModule();
            return mb.DefineRecord(spec);
        }

        public static IEnumerable<Type> DefineTypes(this IEnumerable<RecordSpec> specs)
        {
            var mb = DefineModule();
            foreach(var r in specs)
                yield return mb.DefineRecord(r);            
        }
    }

    public class RecordSpec
    {   
        public static RecordSpec Define(string Namespace, string TypeName, params FieldSpec[] Fields)
            => new RecordSpec(Namespace, TypeName, Fields);
        
        public RecordSpec(string Namespace, string TypeName, params FieldSpec[] Fields)
        {
            this.Namespace = Namespace;
            this.TypeName = TypeName;
            this.Fields = Fields;
        }
        
        public string Namespace {get;}
        
        public string TypeName {get;}

        public FieldSpec[] Fields {get;}

    }

    public class FieldSpec
    {
        public static FieldSpec Define(string FieldName, int Position, ByteSize Offset, string FieldType)
            => new FieldSpec(FieldName, Position, Offset, FieldType);

        public FieldSpec(string FieldName, int Position, ByteSize Offset, string FieldType)
        {
            this.FieldName = FieldName;
            this.Position = Position;
            this.Offset = Offset;
            this.FieldType = FieldType;
        }
        public string FieldName {get;}

        public int Position {get;}
        
        public ByteSize Offset {get;}

        public string FieldType {get;}

        
    }

    public abstract class Record<T> : IRecord<T>
        where T : Record<T>, new()
    {
        public static readonly T Empty = new T();

        public abstract string Delimited(char delimiter = ',', bool digitcommas = false);

        protected IRecord<T> This
            => this;

        IReadOnlyList<string> IRecord.GetHeaders()
            => This.Headers;    
    
        protected static IReadOnlyList<string> GetHeaders()
            => Empty.This.Headers;
    }


    public static class Record
    {
        public static IReadOnlyList<string> GetHeaders<T>()
            => type<T>().DeclaredProperties().Select(p => p.Name).ToReadOnlyList();

        public static IEnumerable<string> Delimited<T>(this IEnumerable<IRecord<T>> records, char delimiter  = ',')
            => records.Select(r => r.Delimited(delimiter));
    }


}