//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;


    public enum CpuIdEcx : byte
    {
        SSE3 = 0,
        
        PCLMULQDQ = 1,
        
        DTES64 = 2,
        
        MONITOR = 3,

        DS_CPL = 4,
        
        VMX = 5,

        SMX = 6,
        
        EIST = 7

    }
    
    public static class CpuFeatureSet
    {
        public static EnumBitField<CpuIdEcx> Ecx(ulong data)
            => EnumBitField.Define<CpuIdEcx>(data);
    }

    public ref struct CpuFeatureSet<T>
        where T : Enum
    {
        static readonly BitSize DataSize = 32;

        static readonly string[] SlotNames
            = Enum.GetNames(typeof(T));

        static readonly T[] SlotValues
            = (T[])Enum.GetValues(typeof(T));

        uint data;


        BitView<uint> bits;
        
        public static CpuFeatureSet<T> Define(uint data)
            => new CpuFeatureSet<T>(data);

        CpuFeatureSet(uint data)
        {
            this.data = data;    
            this.bits = BitView.ViewBits(ref this.data);
        }

        public Bit this[T id]
        {
            
            get => bits[0,System.Convert.ToByte(id)];
            set => bits[0,System.Convert.ToByte(id)] = value;
        }
            
        // public string FormatBits()
        //     => bits.ToBitString().Format(blockWidth:8);


        // public string Format()
        // {
        //     var bs = bits.ToBitString();
        //     var maxix = Math.Min(DataSize, SlotNames.Length);
        //     var sb = sbuild();
        //     for(var i=0; i< maxix; i++)
        //         sb.AppendLine($"{SlotNames[i]} = {bs[i]}");
        //     return sb.ToString();
        // }

        public ReadOnlySpan<T> Available
        {
            get
            {
                var maxix = Math.Min(DataSize, SlotNames.Length);
                var count =0;
                Span<T> dst = new T[maxix];
                for(var i=0; i< maxix; i++)
                {
                    var sv = SlotValues[i];
                    if (this[SlotValues[i]])
                        dst[count++] = sv;
                }
                return dst.Slice(0, count);

            }

        }
    }

}