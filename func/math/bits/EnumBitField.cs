//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a 64-bit bitfield parameterized by an enumeration that confers bit position, 
    /// labels and identifiers that for accessing/describing the underlying bits.
    /// The enumeration type itself would/should be tagged with that [Flags] attribute though
    /// that is not required.
    /// </summary>
    public ref struct EnumBitField<T>
        where T : Enum
    {
        static readonly BitSize DataSize = BitSize.x64;

        static readonly string[] Labels
            = Enum.GetNames(typeof(T));

        static readonly T[] Identifiers
            = (T[])Enum.GetValues(typeof(T));

        ulong data;

        BitView<ulong> bits;
        
        public static EnumBitField<T> Define(ulong data)
            => new EnumBitField<T>(data);

        EnumBitField(ulong data)
        {
            this.data = data;    
            this.bits = BitView.ViewBits(ref this.data);
        }

        /// <summary>
        /// Reads or Sets a value-identified field
        /// </summary>
        public Bit this[T id]
        {
            
            get => bits[0,System.Convert.ToByte(id)];
            set => bits[0,System.Convert.ToByte(id)] = value;
        }

        /// <summary>
        /// Retrieves all bits in the field
        /// </summary>
        public ReadOnlySpan<EnumBit> Bits
        {
            get
            {
                var len = Math.Min(DataSize, Labels.Length);
                Span<EnumBit> dst = new EnumBit[len];
                for(byte pos=0; pos< len; pos++)
                    dst[pos] = new EnumBit(pos, Labels[pos], this[Identifiers[pos]]);
                return dst;
            }
        }        

        /// <summary>
        /// Retrieves the enabled fields
        /// </summary>
        public ReadOnlySpan<T> Enabled
        {
            get
            {
                var len = Math.Min(DataSize, Labels.Length);
                var count =0;
                Span<T> dst = new T[len];
                for(var i=0; i< len; i++)
                {
                    var sv = Identifiers[i];
                    if (this[Identifiers[i]])
                        dst[count++] = sv;
                }
                return dst.Slice(0, count);
            }
        }
    }

}