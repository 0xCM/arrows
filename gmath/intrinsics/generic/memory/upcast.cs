//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static mfunc;
    using static zfunc;    
    using static As;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static void upcast<S,T>(in Vec128<S> lhs, out Vec128<T> rhs)
            where S : struct
            where T : struct
        {
            var srcKind = PrimalKinds.kind<S>();
            var dstKind = PrimalKinds.kind<T>();
            switch(srcKind)
            {
                case PrimalKind.int8:
                {
                    var src = int8(lhs);                    
                    switch(dstKind)
                    {
                        case PrimalKind.int16:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<short> _));
                            break;
                        case PrimalKind.int32:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<int> _));
                            break;
                        case PrimalKind.int64:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<long> _));
                            break;
                        default: 
                            throw unsupported(srcKind, dstKind);
                    }
                }
                break;
                case PrimalKind.uint8:
                {
                    var src = uint8(lhs);
                    switch(dstKind)
                    {
                        case PrimalKind.int16:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<short> _));
                            break;
                        case PrimalKind.int32:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<int> _));
                            break;
                        case PrimalKind.int64:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<long> _));
                            break;
                        default: 
                            throw unsupported(srcKind, dstKind);
                    }
                }
                break;
                case PrimalKind.int16:
                {
                    var src = int16(lhs);
                    switch(dstKind)
                    {
                        case PrimalKind.int32:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<int> _));
                            break;
                        case PrimalKind.int64:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<long> _));
                            break;
                        default: 
                            throw unsupported(srcKind, dstKind);
                    }
                }
                break;
                case PrimalKind.uint16:
                {
                    var src = uint16(lhs);
                    switch(dstKind)
                    {
                        case PrimalKind.int32:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<int> _));
                            break;
                        case PrimalKind.int64:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<long> _));
                            break;
                        default: 
                            throw unsupported(srcKind, dstKind);
                    }
                }
                break;
                case PrimalKind.int32:
                {
                    var src = int32(lhs);
                    switch(dstKind)
                    {
                        case PrimalKind.int64:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<long> _));
                            break;
                        default: 
                            throw unsupported(srcKind, dstKind);
                    }
                }
                break;
                case PrimalKind.uint32:
                {
                    var src = uint32(lhs);
                    switch(dstKind)
                    {
                        case PrimalKind.int64:
                            rhs = generic<T>(dinx.upcast(src, out Vec128<long> _));
                            break;
                        default: 
                            throw unsupported(srcKind, dstKind);
                    }
                }
                break;                
                default:
                    throw unsupported(srcKind, dstKind);
            }            
        }

    }

}