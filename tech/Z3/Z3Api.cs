//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Microsoft.Z3;
    using Z3 = Microsoft.Z3;
    using Z3C = Microsoft.Z3.Context;

    using static zfunc;


    public ref struct Z3Api
    {
        /// <summary>
        /// Creates a new context
        /// </summary>
        public static Z3Api Create()
            => new Z3Api(new Z3.Context(), true);

        /// <summary>
        /// Assumes ownership of an existing context as thus disposes of
        /// context when out-of-scope
        /// </summary>
        public static Z3Api Own(Z3.Context context)
            => new Z3Api(context, true);

        /// <summary>
        /// Wraps an existing context but does not assume ownership
        /// and hence does not dispose of context
        /// </summary>
        public static Z3Api Share(Z3.Context context)
            => new Z3Api(context, false);

        public static implicit operator Z3.Context(Z3Api svc)
            => svc.Context;

        readonly Z3.Context Context;

        readonly bool OwnsContext;

        [MethodImpl(Inline)]
        Z3Api(Z3.Context context, bool owns)
        {
            this.Context = context;
            this.OwnsContext = owns;
        }

        public void Dispose()
        {
            if(OwnsContext)
            {
                babble("Disposing Z3 context");
                Context.Dispose();
            }
        }

        [MethodImpl(Inline)]
        public Solver Solver()
            => Context.MkSolver();
        
        [MethodImpl(Inline)]
        public Probe Probe(string name)
            => Context.MkProbe(name);
        
        public Params Params()
            => Context.MkParams();        

        static void AddParam<T>(Params parms, (string name, T value) pv)
        {
            if(typeof(T) == typeof(bool))
                parms.Add(pv.name, Unsafe.As<T,bool>(ref pv.value));
            else if(typeof(T) == typeof(uint))
                parms.Add(pv.name, Unsafe.As<T,uint>(ref pv.value));
            else if(typeof(T) == typeof(double))
                parms.Add(pv.name, Unsafe.As<T,uint>(ref pv.value));
            else if(typeof(T) == typeof(string))
                parms.Add(pv.name, pv.value.ToString());
            else if(typeof(T) == typeof(Z3.Symbol))
                parms.Add(pv.name, Unsafe.As<T,Z3.Symbol>(ref pv.value));
            else
                throw unsupported<T>();
        }

        public Params Params<T>(params (string name, T value)[] parms)
        {
            var result = Params();
            iter(parms, p=> AddParam(result, p));
            return result;
        }

        public Params Params<S,T>((string name, S value) p1, (string name, T value) p2)
        {
            var result = Params();
            AddParam(result, p1);
            AddParam(result, p2);
            return result;

        }

        /// <summary>
        /// Defines an equality expression between two operands
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        [MethodImpl(Inline)]
        public BoolExpr Eq(Expr x, Expr y)
            => Context.MkEq(x,y);


        /// <summary>
        /// Create a constant bitvector expression
        /// </summary>
        /// <param name="name">The variable name</param>
        /// <param name="size">The bitvector size</param>
        [MethodImpl(Inline)]
        public BitVecExpr BvConst(string name, uint size)    
            => Context.MkBVConst(name, size);

        /// <summary>
        /// Create a constant bitvector exppression of natural length
        /// </summary>
        /// <param name="name">The variable name</param>
        /// <param name="size">The bitvector size</param>
        [MethodImpl(Inline)]
        public BitVecExpr BvConst<N>(string name, N size = default)    
            where N : ITypeNat, new()
                => BvConst(name, (uint)size.value);

        /// <summary>
        /// Creates a bitvector kind/classification
        /// </summary>
        /// <param name="size">The bitvector size</param>
        [MethodImpl(Inline)]
        BitVecSort BvSort(uint size)
            => Context.MkBitVecSort(size);

        [MethodImpl(Inline)]
        public BitVecSort BvSort<N>(N size = default)
            where N : ITypeNat, new()
            => BvSort((uint)size.value);        

        [MethodImpl(Inline)]
        public BitVecNum BvVal(int src, uint size = 32)
            => Context.MkBV(src, size);

        [MethodImpl(Inline)]
        public BitVecNum BvVal(uint src, uint size = 32)
            => Context.MkBV(src, (uint)size);

        [MethodImpl(Inline)]
        public BitVecNum BvVal(long src, uint size = 64)
            => Context.MkBV(src, (uint)size);

        [MethodImpl(Inline)]
        public BitVecNum BvVal(ulong src, uint size = 64)
            => Context.MkBV(src, (uint)size);

        [MethodImpl(Inline)]
        public BitVecNum BvVal<N>(int src, N size = default)
            where N : ITypeNat, new()
            => BvVal(src, (uint)size.value);

        [MethodImpl(Inline)]
        public BitVecNum BvVal<N>(uint src, N size = default)
            where N : ITypeNat, new()
            => BvVal(src, (uint)size.value);

        [MethodImpl(Inline)]
        public BitVecNum BvVal<N>(long src, N size = default)
            where N : ITypeNat, new()
            => BvVal(src, (uint)size.value);

        [MethodImpl(Inline)]
        public BitVecNum BvVal<N>(ulong src, N size = default)
            where N : ITypeNat, new()
            => BvVal(src, (uint)size.value);

        [MethodImpl(Inline)]
        public BitVecNum BvVal(bool[] bits)
            => Context.MkBV(bits);

        [MethodImpl(Inline)]
        public BitVecNum BvVal(string bits)
            => Context.MkBV(bits,(uint)bits.Length);
        
        public EnumSort Enum(string name, params string[] labels)
        {
            var sname = Context.Symbol(name);
            var list = Context.MkEnumSort(sname, Context.Symbols(labels));
            return list;
        }

        /// <summary>
        /// Forms a boolean expression by computing the disjunction of an arbitrary number of boolean expressions
        /// </summary>
        /// <param name="expressions">The source expressions</param>
        [MethodImpl(Inline)]
        public BoolExpr Or(params BoolExpr[] expressions)
            => Context.MkOr(expressions);

        /// <summary>
        /// Forms a boolean expression by computing the conjunction of an arbitrary number of boolean expressions
        /// </summary>
        /// <param name="expressions">The source expressions</param>
        [MethodImpl(Inline)]
        public BoolExpr And(params BoolExpr[] expressions)
            => Context.MkAnd(expressions);

        /// <summary>
        /// Forms a boolean expression by computing the exclusive or of an arbitrary number of boolean expressions
        /// </summary>
        /// <param name="expressions">The source expressions</param>
        [MethodImpl(Inline)]
        public BoolExpr XOr(params BoolExpr[] expressions)
            => Context.MkXor(expressions);

        /// <summary>
        /// Creates a bitwise XOR expression between two bitvector operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BitVecExpr XOr(BitVecExpr x, BitVecExpr y)
            => Context.MkBVXOR(x,y);

        /// <summary>
        /// Creates a bitwise OR expression between two bitvector operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BitVecExpr Or(BitVecExpr x, BitVecExpr y)
            => Context.MkBVOR(x,y);

        /// <summary>
        /// Creates a bitwise AND expression between two bitvector operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BitVecExpr And(BitVecExpr x, BitVecExpr y)
            => Context.MkBVAND(x,y);

        /// <summary>
        /// Creates a bitwise two's complement unary expression
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BitVecExpr Not(BitVecExpr x)
            => Context.MkBVNot(x);

        /// <summary>
        /// Creates a multiplication expression between two bitvector operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BitVecExpr Mul(BitVecExpr x, BitVecExpr y)
            => Context.MkBVMul(x,y);

        /// <summary>
        /// Creates a subtraction expression between two bitvector operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BitVecExpr Sub(BitVecExpr x, BitVecExpr y)
            => Context.MkBVSub(x,y);

        [MethodImpl(Inline)]
        public BitVecExpr Div(BitVecExpr x, BitVecExpr y)
            => Context.MkBVUDiv(x,y);

        [MethodImpl(Inline)]
        public BitVecExpr Mod(BitVecExpr x, BitVecExpr y)
            => Context.MkBVSMod(x,y);

        [MethodImpl(Inline)]
        public BitVecExpr Rem(BitVecExpr x, BitVecExpr y)
            => Context.MkBVURem(x,y);

        /// <summary>
        /// Defines an expression to rotates a bitvector leftwards
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The rotation displacement</param>
        [MethodImpl(Inline)]
        public BitVecExpr RotL(BitVecExpr src, uint offset)
            => Context.MkBVRotateLeft(offset,src);

        /// <summary>
        /// Defines an expression to rotate a bitvector rightwards
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The rotation displacement</param>
        [MethodImpl(Inline)]
        public BitVecExpr RotR(BitVecExpr src, uint offset)
            => Context.MkBVRotateRight(offset,src);

        /// <summary>
        /// Defines an expression to convert a bitvector to an unsigned integral value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public IntExpr ToUInt(BitVecExpr src)
            => Context.MkBV2Int(src,false);

        /// <summary>
        /// Defines an expression to convert a bitvector to a signed integral value
        /// </summary>
        /// <param name="src">The source vector</param>
        public IntExpr ToInt(BitVecExpr src)
            => Context.MkBV2Int(src,true);

        [MethodImpl(Inline)]
        public BitVecNum BvNumeral(string value, uint size)
            => (BitVecNum)Context.MkNumeral(value, BvSort(size));

        [MethodImpl(Inline)]
        public BitVecNum BvNumeral(int value, uint size)
            => (BitVecNum)Context.MkNumeral(value, BvSort(size));

        [MethodImpl(Inline)]
        public BitVecNum BvNumeral(ulong value, uint size)
            => (BitVecNum)Context.MkNumeral(value, BvSort(size));

        [MethodImpl(Inline)]
        public BitVecNum BvNumeral(uint value, uint size)
            => (BitVecNum)Context.MkNumeral(value, BvSort(size));

        [MethodImpl(Inline)]
        public BitVecNum BvNumeral<N>(string value, N size = default)
            where N : ITypeNat, new()
            => BvNumeral(value, (uint)size.value);

        /// <summary>
        /// Creates a boolean expression to compute whether the first (unsigned)
        /// bitvector is less than or equal to the second (unsigned) bitvector
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BoolExpr LtEq(BitVecExpr x, BitVecExpr y)
            => Context.MkBVULE(x,y);

        /// <summary>
        /// Creates a boolean expression to compute whether the first (unsigned)
        /// bitvector is strictly less than the second (unsigned) bitvector
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BoolExpr Lt(BitVecExpr x, BitVecExpr y)
            => Context.MkBVULT(x,y);

        /// <summary>
        /// Creates a boolean expression to compute whether the first (unsigned)
        /// bitvector is greater than or equal to the second (unsigned) bitvector
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BoolExpr GtEq(BitVecExpr x, BitVecExpr y)
            => Context.MkBVUGE(x,y);

        /// <summary>
        /// Creates a boolean expression to compute whether the first (unsigned)
        /// bitvector is strictly greater than the second (unsigned) bitvector
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public BoolExpr Gt(BitVecExpr x, BitVecExpr y)
            => Context.MkBVUGT(x,y);

    }

}