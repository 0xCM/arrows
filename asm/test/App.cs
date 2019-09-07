//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Test
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    public class App : TestApp<App>
    {            
        // static unsafe void PrintPrivate()
        // {
        //     var t = typeof(MnemonicKind).Assembly.Types().WithNameLike("PrivateImplementation").Single();
        //     foreach(var f in t.AllFields().WithTypeNameLike("__StaticArrayInitTypeSize="))
        //     {
        //         var fieldAddress = (ulong)f.FieldHandle.Value;
        //         var fieldAddressFmt = fieldAddress.FormatHex(false);
        //         var typeName = f.FieldType.Name;
        //         var eqidx = typeName.LastIndexOf(AsciSym.Eq);
        //         var size =  eqidx > 0 ? parse<int>(typeName.Substring(eqidx + 1)) : -1;                                
        //         var o = f.GetValue(null);
        //         var data = Unsafe.As<object,ulong>(ref o);
        //         var format = data.FormatHex();                                
        //         var rawDescription = $"{t.Name}::{f.Name} : {f.FieldType.Name}";
        //         print($"{f.Name}({fieldAddressFmt}) : byte[{size}] = {format}");
        //     }
        //}     
           
        protected override void RunTests(params string[] filters)
        {
            sbyte x = -24;
            print(x.FormatHex());

            base.RunTests(filters);


        }



        public static void Main(params string[] args)
            => Run(args);
    }
}