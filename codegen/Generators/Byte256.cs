//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    using static zfunc;

    public class Byte256 : CodeGenerator
    {
        char MakeBitChar(byte src, int pos)
            => Bits.test(src, pos) ? '1' : '0';

        char MakeBitChar(sbyte src, int pos)
            => Bits.test(src, pos) ? '1' : '0';

        string MakeBsArray(byte src)
        {
            var dst = sbuild();
            dst.Append("new char[]{");
            for(var i=0; i<8; i++)
            {
                dst.Append("'");
                dst.Append(MakeBitChar(src,i));
                dst.Append("'");
                if(i != 7)
                    dst.Append(',');
            }
            dst.Append('}');
            return dst.ToString();
        }
        string MakeBsArray(sbyte src)
        {
            var dst = sbuild();
            dst.Append("new char[]{");
            for(var i=0; i<8; i++)
            {
                dst.Append("'");
                dst.Append(MakeBitChar(src,i));
                dst.Append("'");
                if(i != 7)
                    dst.Append(',');
            }
            dst.Append('}');
            return dst.ToString();
        }

        string MakeBsIndex(byte src)
        {
            var dst = sbuild();
            dst.Append("0b");
            for(var i=7; i>=0; i--)
                dst.Append(MakeBitChar(src,i));
            return dst.ToString();
        }

        string MakeBsIndex(sbyte src)
        {
            var dst = sbuild();
            if(src < 0)
                dst.Append("-");
            dst.Append("0b");            
            if(src >= 0)
                dst.Append("0");
            for(var i=6; i>=0; i--)
                dst.Append(MakeBitChar(src,i));
            return dst.ToString();
        }

        string MakeBsText(byte src)
        {
            Span<char> dst = stackalloc char[8];

            for(var i=7; i>=0; i--)
                dst[i] = MakeBitChar(src, 7-i);
            return enquote(new string(dst));
        }

        string MakeBsText(sbyte src)
        {
            Span<char> dst = stackalloc char[8];

            for(var i=7; i>=0; i--)
                dst[i] = MakeBitChar(src, 7-i);
            return enquote(new string(dst));
        }

        //new byte[]{0,0,0,0,0,0,0,0}
        string MakeBsSeq(byte src)
        {
            var dst = sbuild();
            dst.Append("new byte[]{");
            for(var i=0; i<8; i++)
            {
                dst.Append(MakeBitChar(src,i));
                if(i != 7)
                    dst.Append(',');
            }
            dst.Append("}");
            return dst.ToString();
        }

        string MakeBsSeq(sbyte src)
        {
            var dst = sbuild();
            dst.Append("new sbyte[]{");
            for(var i=0; i<8; i++)
            {
                dst.Append(MakeBitChar(src,i));
                if(i != 7)
                    dst.Append(',');
            }
            dst.Append("}");
            return dst.ToString();
        }

        public IEnumerable<(string decidx, string index, string bitseq, string bitchars, string text)> MakeBitStringsInt8()
        {
            for(int i=SByte.MinValue, j = 0; i <= SByte.MaxValue; i++, j++)
                yield return (j.ToString(), MakeBsIndex((sbyte)i), MakeBsSeq((sbyte)i), MakeBsArray((sbyte)i), MakeBsText((sbyte)i));                
        }

        public IEnumerable<(string decidx, string index, string bitseq, string bitchars, string text)> MakeBitStringsUInt8()
        {
            var length = 8;
            var count = (int)Pow2.pow(length) - 1;
            for(var i=0; i <= count; i++)
                yield return (i.ToString(), MakeBsIndex((byte)i), MakeBsSeq((byte)i), MakeBsArray((byte)i), MakeBsText((byte)i));                
        }

        public CSharpSource GenerateSourceInt8()
        {
            var indent8 = new string(' ', 8);
            var indent12 = new string(' ',12);
            var sb = new StringBuilder();   
            var returnType = "(sbyte index, sbyte[] bitseq, char[] bitchars, string text)[]";
            var returnInit = "new (sbyte index, sbyte[] bitseq, char[] bitchars, string text)[256]";
            sb.AppendLine($"{indent8}static {returnType} DefineI8Index()");
            sb.AppendLine(indent8 + "{");
            sb.AppendLine($"{indent12}var dst = {returnInit};");
            foreach(var bs in MakeBitStringsInt8())
                sb.AppendLine($"{indent12}dst[{bs.decidx}] =".PadRight(23) +  $"({bs.index}, {bs.bitseq}, {bs.bitchars}, {bs.text});");
            sb.AppendLine($"{indent12}return dst;");
            sb.AppendLine(indent8 + "}");
            
            return new CSharpSource(sb.ToString());
        }

        public CSharpSource GenerateSourceUInt8()
        {
            var indent8 = new string(' ', 8);
            var indent12 = new string(' ',12);
            var sb = new StringBuilder();   
            var returnType = "(byte index, byte[] bitseq, char[] bitchars, string text)[]";
            var returnInit = "new (byte index, byte[] bitseq, char[] bitchars, string text)[256]";
            sb.AppendLine($"{indent8}static {returnType} DefineU8Index()");
            sb.AppendLine(indent8 + "{");
            sb.AppendLine($"{indent12}var dst = {returnInit};");
            foreach(var bs in MakeBitStringsUInt8())
                sb.AppendLine($"{indent12}dst[{bs.decidx}] =".PadRight(23) +  $"({bs.index}, {bs.bitseq}, {bs.bitchars}, {bs.text});");
            sb.AppendLine($"{indent12}return dst;");
            sb.AppendLine(indent8 + "}");
            
            return new CSharpSource(sb.ToString());
        }
        
    }


}
