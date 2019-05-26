//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Drawing;

    using static Ansi8;
    using static Ansi256;
    using static AnsiBright;
    using static AnsiGray;

    public class Ansi8
    {
        public const string Black = "30";
            
        public const string Red = "31";
        
        public const string Green = "32";        

        public const string Yellow = "33";   

        public const string Blue = "34";

        public const string Magenta = "35";
        
        public const string Cyan = "36";        

        public const string White = "37";
    }

    public class AnsiBright
    {

        public const string BrightBlack = Black + ";1";

        public const string BrightRed = Red + ";1";
        
        public const string BrightGreen = Green + ";1";        

        public const string BrightYellow = Yellow + ";1"; 

        public const string BrightBlue = Blue + ";1";

        public const string BrightMagenta = Magenta + ";1";
        
        public const string BrightCyan = Cyan + ";1";        

        public const string BrightWhite = White + ";1";

    }

    public class AnsiGray
    {
        const int MinCode = 0xE8;
        
        const int MaxCode = 0xFF;

        public const string FGE8 = "38;5;232";
        public const string FGE9 = "38;5;233";
        public const string FGEA = "38;5;234";
        public const string FGEB = "38;5;235";

        public const string BGE8 = "48;5;232";
        public const string BGE9 = "48;5;233";
        public const string BGEA = "48;5;234";
        public const string BGEB = "48;5;235";


        public const string FGEC = "38;5;236";
        public const string FGED = "38;5;237";
        public const string FGEE = "38;5;238";
        public const string FGEF = "38;5;239";

        public const string BGEC = "48;5;236";
        public const string BGED = "48;5;237";
        public const string BGEE = "48;5;238";
        public const string BGEF = "48;5;239";


        public const string FGF0 = "38;5;240";
        public const string FGF1 = "38;5;241";
        public const string FGF2 = "38;5;242";
        public const string FGF3 = "38;5;243";


        public const string BGF0 = "48;5;240";
        public const string BGF1 = "48;5;241";
        public const string BGF2 = "48;5;242";
        public const string BGF3 = "48;5;243";
        

        public const string FGF4 = "38;5;244";
        public const string FGF5 = "38;5;245";
        public const string FGF6 = "38;5;246";
        public const string FGF7 = "38;5;247";


        public const string BGF4 = "48;5;244";
        public const string BGF5 = "48;5;245";
        public const string BGF6 = "48;5;246";
        public const string BGF7 = "48;5;247";

        public const string FGF8 = "38;5;248";
        public const string FGF9 = "38;5;249";
        public const string FGFA = "38;5;250";
        public const string FGFB = "38;5;251";

        public const string BGF8 = "38;5;248";
        public const string BGF9 = "38;5;249";
        public const string BGFA = "38;5;250";
        public const string BGFB = "38;5;251";


        public const string FGFC = "38;5;252";
        public const string FGFD = "38;5;253";
        public const string FGFE = "38;5;254";
        public const string FGFF = "38;5;255";

        public const string BGFC = "48;5;252";
        public const string BGFD = "48;5;253";
        public const string BGFE = "48;5;254";
        public const string BGFF = "48;5;255";

        public static string GrayCode(int level = 9, bool fg = true)
        {
            var code = Math.Clamp(level + MinCode, MinCode, MaxCode);
            var fgcode = fg ? 38 : 48;
            return $"{fgcode};5;{code}";    
        }
    }

    public class Ansi256
    {
        public const string C00 = "38;5;0";
        public const string C01 = "38;5;1";
        public const string C02 = "38;5;2";
        public const string C03 = "38;5;3";
        

        public const string C04 = "38;5;4";
        public const string C05 = "38;5;5";
        public const string C06 = "38;5;6";
        public const string C07 = "38;5;7";

    
        public const string C08 = "38;5;8";
        public const string C09 = "38;5;9";
        public const string C0A = "38;5;10";
        public const string C0B = "38;5;11";


        public const string C0C = "38;5;12";
        public const string C0D = "38;5;13";
        public const string C0E = "38;5;14";
        public const string C0F = "38;5;15";

        public const string C10 = "38;5;16";
        public const string C11 = "38;5;17";
        public const string C12 = "38;5;18";
        public const string C13 = "38;5;19";

        public const string C14 = "38;5;20";
        public const string C15 = "38;5;21";
        public const string C16 = "38;5;22";
        public const string C17 = "38;5;23";

        public const string C18 = "38;5;24";
        public const string C19 = "38;5;25";
        public const string C1A = "38;5;26";
        public const string C1B = "38;5;27";

        public const string C1C = "38;5;28";
        public const string C1D = "38;5;29";
        public const string C1E = "38;5;30";
        public const string C1F = "38;5;31";

        public const string C20 = "38;5;31";
        public const string C21 = "38;5;32";
        public const string C22 = "38;5;33";
        public const string C23 = "38;5;34";
        public const string Green0 = C23;
        public const string Green1 = Green0;

        public const string C24 = "38;5;35";
        public const string C25 = "38;5;36";
        public const string C26 = "38;5;37";
        public const string C27 = "38;5;38";

        public const string C28 = "38;5;39";
        public const string C29 = "38;5;40";
        public const string Green2 = C29;
        public const string C30 = "38;5;41";
        public const string C31 = "38;5;42";


        public const string CC5 = "38;5;197";
        public const string DeepPink0 = CC5;
        public const string DeepPink1 = CC5;

        public const string CC6 = "38;5;198";
        public const string DeepPink2 = CC6;
        public const string CC7 = "38;5;199";
        public const string DeepPink3 = CC7;
        public const string CC8 = "38;5;200";
        public const string Magenta0 = CC8;
        public const string Magenta1 = CC8;                
        public const string CC9 = "38;5;201";
        public const string Magenta2 = CC9;


        public const string CD4 = "38;5;212";
        public const string Orchid0 = CD4;
        public const string Orchid1 = CD4;
        public const string CD5 = "38;5;213";        
        public const string Orchid2 = CD5;
        public const string CD6 = "38;5;214";        
        public const string CD7 = "38;5;215";        

        public const string CD8 = "38;5;216";
        public const string CD9 = "38;5;217";        
        public const string CDA = "38;5;218";        
        public const string CDB = "38;5;219";        

        public const string CDC = "38;5;220";
        public const string CDD = "38;5;221";        
        public const string CDE = "38;5;222";        
        public const string CDF = "38;5;223";        
    }

    /// <summary>
    /// Ansi encoding wrapper
    /// </summary>
    /// <remarks>
    /// See http://www.lihaoyi.com/post/BuildyourownCommandLinewithANSIescapecodes.html for a nice reference
    /// </remarks>
    public class Ansi
    {
        public static Ansi Define(string content, string code)
            => new Ansi(content, code);

        public static string CodeString(string code)
            => $"{code}m";

        public static string Encode(string content, string code)
            => $"{Prefix}{CodeString(code)}{content}{Reset}";

        public static implicit operator string(Ansi src)
            =>  src.Encoded;

        const string Prefix ="\u001b[";
        
        const string Reset = "\u001b[0m";
        
        public Ansi(string content, string code)
        {
            this.Content = content;
            this.Code = code;
            this.Encoded = Encode(code, content);
        }

        public string Content {get;}

        public string Code {get;}
        
        public string Encoded {get;}


        public override string ToString()
            => Encoded;
    }

}


