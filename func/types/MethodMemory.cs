//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a method
    /// </summary>
    public readonly struct MethodMemory
    {        
        [MethodImpl(Inline)]
        public static MethodMemory Read(MethodInfo m)
        {                        
            return MethodMemory.ReadUntil(m, NatSpan.Alloc<N32,byte>(), 0xc3, 0xe0);
        }

        [MethodImpl(Inline)]
        public static MethodMemory Read<T>(string method)
        {
            return Read(method<T>(method));
        }

        [MethodImpl(Inline)]
        static unsafe ref byte Read(byte* pByte, ref byte dst)
        {
            dst = Unsafe.Read<byte>(pByte);
            return ref dst;
        }

        static unsafe MethodMemory ReadUntil<N>(MethodInfo m, Span<N,byte> dst, params byte[] conditions)
            where N : ITypeNat, new()
        {
            
            var pSrc = (byte*)m.Prepare().ToPointer();

            bool MeetsCondition(byte candidate)
            {
                for(var i=0; i<conditions.Length; i++)
                    if(conditions[i] == candidate)
                        return true;
                return false;
            }
            
            var offset = 0;
            var offsetMax = (int)(new N().value);
            var refLocalBuf = default(byte);
            ref var data = ref refLocalBuf;
            var pSrcCurrent = pSrc;            
            while(offset < offsetMax && !MeetsCondition(data))
                data = ref Read(pSrcCurrent++, ref dst[offset++]);                
            
            var startAddress = (ulong)pSrc;
            var endAddress = (ulong)pSrcCurrent;
            var bytesRead = (int)(endAddress - startAddress);
            return new MethodMemory(m, startAddress, endAddress, dst.Unsize().Slice(0, bytesRead));         
        }
        
        [MethodImpl(Inline)]
        public MethodMemory(MethodInfo method, ulong StartAddress, ulong EndAddress, Span<byte> body)
        {
            this.Method = method;
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Body = body.ToArray();

        }

        /// <summary>
        /// The deconstructed method
        /// </summary>
        public readonly MethodInfo Method;

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress;

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress;

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body;
        
        public ref readonly byte this[int ix]
        {
            [MethodImpl(Inline)]
            get => ref Body[ix];
        }

        public ulong Length 
            => EndAddress -StartAddress;

        public string Format()
        {
            var format = sbuild();
            var title = Method.Name;
            format.Append(StartAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.AppendLine($"{title} Begin, {Length} bytes");
            for(ushort i=0; i< Length; i++)
            {
                if(i % 2 == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    format.Append(i.FormatHex(true,false));
                    format.Append(AsciLower.h);
                    format.Append(AsciSym.Space);
                }
                format.Append(Body[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.Append(EndAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.Append($"{title} End");
            return format.ToString();
        }
    }
}