//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class BitField
    {
        public static BitField<T> Define<T>(ulong data)
            where T : Enum
                => BitField<T>.Define(data);
    }

    /// <summary>
    /// Describes a bitfield bit
    /// </summary>
    public readonly struct BitFieldBit
    {
        [MethodImpl(Inline)]
        public BitFieldBit(byte Pos, string Name, Bit Value)
        {
            this.Pos = Pos;
            this.Name = Name;
            this.Value = Value;
        }
        
        /// <summary>
        /// The 0-based position of the bit
        /// </summary>
        public readonly byte Pos;

        /// <summary>
        /// The name/label identifier
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The value of the bit
        /// </summary>
        public readonly Bit Value;

        public override string ToString()
            => $"({Pos.ToString().PadLeft(2, AsciDigits.A0)}, {Name}, {Value})";
    }

    /// <summary>
    /// Defines a 64-bit bitfield parameterized by an enumeration
    /// that provides bit position, labels and identifiers that
    /// for accessing/describing the underlying bits
    /// </summary>
    public ref struct BitField<T>
        where T : Enum
    {
        static readonly BitSize DataSize = BitSize.x64;

        static readonly string[] Labels
            = Enum.GetNames(typeof(T));

        static readonly T[] Identifiers
            = (T[])Enum.GetValues(typeof(T));

        ulong data;

        BitView<ulong> bits;
        
        public static BitField<T> Define(ulong data)
            => new BitField<T>(data);

        BitField(ulong data)
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
        /// <value></value>
        public ReadOnlySpan<BitFieldBit> Bits
        {
            get
            {
                var len = Math.Min(DataSize, Labels.Length);
                Span<BitFieldBit> dst = new BitFieldBit[len];
                for(byte pos=0; pos< len; pos++)
                    dst[pos] = new BitFieldBit(pos, Labels[pos], this[Identifiers[pos]]);
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