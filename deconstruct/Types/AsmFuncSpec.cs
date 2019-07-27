//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Iced.Intel;
    using static zfunc;
        

    public class AsmFuncInstruction
    {
        public AsmFuncInstruction(ushort Offset, string Display, string Mnemonic,  string OpCode, string EncodingKind, byte[] Encoding)
        {
            this.Offset = Offset;
            this.Display = Display;
            this.Mnemonic = Mnemonic;
            this.OpCode = OpCode;
            this.EncodingKind = EncodingKind;
            this.Encoding = Encoding;
        }
        
        public ushort Offset {get;}

        public string Display {get;}

        public string Mnemonic {get;}
        
        public string OpCode {get;}

        public string EncodingKind {get;}

        public byte[] Encoding {get;}

        public string Format(int? pad = null)
        {
            var label =$"{Offset.ToHexString(true,false)}h ";
            var content = Display.PadRight(pad ?? 24, ' ');
            var encoding = $"encoding({EncodingKind}) = " + Encoding.FormatHex(false, ' ');
            var len = $"({Encoding.Length} bytes)";
            return label + content + $"; {Mnemonic} | {OpCode} | {encoding} {len}";            
        }

        public override string ToString()
            => Format();
    }


    public class AsmFuncSpec
    {
        
        public AsmFuncSpec(ulong StartAddress, ulong EndAddress, MethodSig Signature, AsmFuncInstruction[] Instructions, byte[] Encoding)
        {
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Signature = Signature;
            this.Instructions = Instructions;
            this.Encoding = Encoding;
            this.IPad = 30;
            this.HPad = IPad + 6;


        }

        int IPad {get;}

        int HPad {get;}

        public ulong StartAddress {get;}

        public ulong EndAddress {get;}

        public MethodSig Signature {get;}

        public AsmFuncInstruction[] Instructions {get;}

        public string FormatInstructions(int? pad = null)
        {
            var format = sbuild();            
            foreach(var i in Instructions)
                format.AppendLine(i.Format(pad ?? IPad));
            return format.ToString();
        }    

        public byte[] Encoding {get;}        
        
        public string EncodingFormat
            => embrace(Encoding.FormatHex(false,','));
        
        public string FormatHeader(int? pad = null)
            => concat(Signature.Format().PadRight(pad ?? HPad), AsciSym.Semicolon, AsciSym.Space, EncodingFormat);

        public string Format()
        {
            var sb = sbuild();            
            sb.AppendLine(FormatHeader());
            sb.Append(FormatInstructions());
            return sb.ToString();
        }        

        public override string ToString()
            => Format();
    }

}
//sbyte add8i(sbyte x, sbyte y)  
//0009h movsx rdx,dl                  