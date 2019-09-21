//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class IMM
    {

        public readonly ref struct Imm8
        {            
            /// <summary>
            /// The value of the immediate constant
            /// </summary>
            public readonly byte Value;

            /// <summary>
            /// Specifies the size of the immediate in bytes
            /// </summary>
            public static readonly BitSize Size = 8;

            /// <summary>
            /// Defines an 8-bit immediate from an 8-bit source value
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public static Imm8 From(byte src)
                => src;

            /// <summary>
            /// Defines an 8-bit immediate from 8 explicitly specified bit values
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public static Imm8 From(
                Bit b0 = default(Bit), Bit b1 = default(Bit), Bit b2 = default(Bit), Bit b3 = default(Bit), 
                Bit b4 = default(Bit), Bit b5 = default(Bit), Bit b6 = default(Bit), Bit b7 = default(Bit))
            {
                byte dst = b0;
                dst |= (byte)(b1 << 1);
                dst |= (byte)(b2 << 2);
                dst |= (byte)(b3 << 3);
                dst |= (byte)(b4 << 4);
                dst |= (byte)(b5 << 5);
                dst |= (byte)(b6 << 6);
                dst |= (byte)(b7 << 7);
                return new Imm8(dst);
            }

            /// <summary>
            /// Implicitly converts a byte to an immdiate
            /// </summary>
            /// <param name="src">The source byte</param>
            [MethodImpl(Inline)]
            public static implicit operator Imm8(byte src)
                => new Imm8(src);

            /// <summary>
            /// Implicitly converts the immediate to a byte
            /// </summary>
            /// <param name="src">The source immediate</param>
            [MethodImpl(Inline)]
            public static implicit operator byte(Imm8 src)
                => src.Value;

            /// <summary>
            /// Initializes the immediate with a byte value
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public Imm8(byte src)
                => this.Value = src;

            /// <summary>
            /// Formats the immediate value as a bitstring
            /// </summary>
            [MethodImpl(Inline)]
            public string FormatBits()
                => Value.ToBitString().Format();
            
            /// <summary>
            /// Formats the immediate as a block of primal cells, one for each bit
            /// </summary>
            /// <typeparam name="T">The primal type</typeparam>
            public string FormatBlocked<T>()
                where T : unmanaged
            {
                var label = $"imm8".PadRight(6);
                var format = Unpack(new Span<T>(new T[8])).FormatCellBlocks();
                return $"{label}{format}";
            }

            /// <summary>
            /// Populates a primal span where each cell indicates the value of the corresponding bit
            /// </summary>
            /// <param name="dst">The target span</param>
            /// <typeparam name="T">The primal type</typeparam>
            public Span<T> Unpack<T>(Span<T> dst)
                where T : unmanaged
            {
                var bitseq = Value.ToBitString().BitSeq;
                for(var i=0; i<dst.Length; i++)
                    dst[i] = convert<T>(bitseq[i]);                    
                return dst;
            }
        }

    } 

}