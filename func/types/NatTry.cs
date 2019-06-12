namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static NatProve;
    using static nfunc;

    public static class NatTry
    {

        /// <summary>
        /// Evaluates a function within a try block and returns the value of the computation if 
        /// successful; otherwise, returns None together with the reported exceptions
        /// </summary>
        /// <typeparam name="T">The result type</typeparam>
        /// <param name="f">The function to evaluate</param>
        /// <returns></returns>
        public static Option<T> Try<T>(Func<T> f, Action<Exception> error = null)
        {
            try
            {
                return f();
            }
            catch (Exception e)
            {
                error?.Invoke(e);
                return zfunc.none<T>();
            }
        }


        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Sum<K1,K2>> tryAdd<K1,K2>(uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
                => Try(() => add<K1,K2>(expected));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Sum<K1,K2>> tryAdd<K1,K2>(K1 k1, K2 k2, uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
                => Try(() => sum(k1,k2,expected));

        /// <summary>
        /// Attempts to prove that that n:K & n1:K1 & n2:K2 => n1 <= n <= n2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        /// <typeparam name="K1">The lower inclusive bound</typeparam>
        /// <typeparam name="K2">The upper inclusive bound</typeparam>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Option<NatBetween<K,K1,K2>> tryBetween<K,K1,K2>()
            where K: ITypeNat, new()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => between<K,K1,K2>());

        /// <summary>
        /// Attempts to prove that that n:K & n1:K1 & n2:K2 => n1 <= n <= n2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        /// <typeparam name="K1">The lower inclusive bound</typeparam>
        /// <typeparam name="K2">The upper inclusive bound</typeparam>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Option<NatBetween<K,K1,K2>> tryBetween<K,K1,K2>(K k, K1 k1, K2 k2)
            where K: ITypeNat, new()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => between<K,K1,K2>(k, k1, k2));
 

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Option<NatEq<K1,K2>> tryEqual<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatEq<K1,K2>(natrep<K1>(),natrep<K2>()));

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 = k2; otherwise
        /// raises an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Option<NatEq<K1,K2>> tryEqual<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatEq<K1,K2>(k1,k2));                             

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 > k2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The larger type</typeparam>
        /// <typeparam name="K2">The smaller type</typeparam>
        public static Option<NatGt<K1,K2>> gtTry<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatGt<K1,K2>(natrep<K1>(),natrep<K2>())); 

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 > k2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <param name="k1">The larger value</param>
        /// <param name="k2">The smaller value</param>
        /// <typeparam name="K1">The larger type</typeparam>
        /// <typeparam name="K2">The smaller type</typeparam>
        public static Option<NatGt<K1,K2>> gtTry<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try( () => new NatGt<K1,K2>(k1,k2)); 

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 < k2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The smaller type</typeparam>
        /// <typeparam name="K2">The larger type</typeparam>
        public static Option<NatLt<K1,K2>> tryLt<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatLt<K1,K2>(natrep<K1>(),natrep<K2>())); 

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 < k2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The smaller type</typeparam>
        /// <typeparam name="K2">The larger type</typeparam>
        public static Option<NatLt<K1,K2>> tryLt<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatLt<K1,K2>(k1,k2));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 * k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Product<K1,K2>> tryMul<K1,K2>(uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
                => Try(() => mul<K1,K2>(expected));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 * k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Product<K1,K2>> tryMul<K1,K2>(K1 k1, K2 k2, uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
                => Try(() => mul(k1,k2,expected));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        /// <typeparam name="K3">The third natural type</typeparam>
        public static Option<NatMod<K1,K2,K3>> tryMod<K1,K2,K3>()
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => Try( () => new NatMod<K1,K2,K3>(natrep<K1>(), natrep<K2>(),natrep<K3>()));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        /// <typeparam name="K3">The third natural type</typeparam>
        public static Option<NatMod<K1,K2,K3>> tryMod<K1,K2,K3>(K1 k1, K2 k2, K3 k3)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => Try( () => new NatMod<K1,K2,K3>(k1, k2, k3));

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        public static Option<NatEven<K>> tryEven<K>(K k)
            where K: ITypeNat, new()
                => Try(() => new NatEven<K>(k));

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        public static Option<NatEven<K>> tryEven<K>()
            where K: ITypeNat, new()
                => Try(() => new NatEven<K>(natrep<K>()));

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        public static Option<NatOdd<K>> tryOdd<K>(K k)
            where K: ITypeNat, new()
                => Try( () => new NatOdd<K>(k));


        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        public static Option<NatOdd<K>> tryOdd<K>()
            where K: ITypeNat, new()
                => Try(() => new NatOdd<K>(natrep<K>()));


        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 + 1 = k2; otherwise
        /// returns none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        public static Option<NatNext<K1,K2>> tryNext<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatNext<K1,K2>(natrep<K1>(),natrep<K2>()));                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 + 1 = k2; otherwise
        /// returns none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        public static Option<NatNext<K1,K2>> tryNext<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatNext<K1,K2>(k1,k2));                             

        /// <summary>
        /// Attempts to prove that k:K => k != 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">A nonzero natural type</typeparam>
        public static Option<Nonzero<K>> tryNonzero<K>()
            where K: ITypeNat, new()
                => Try(() => new Nonzero<K>(natrep<K>())); 

        /// <summary>
        /// Attempts to prove that k:K => k != 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">A nonzero natural type</typeparam>
        public static Option<Nonzero<K>> tryNonzero<K>(K k)
            where K: ITypeNat, new()
                => Try( () => new Nonzero<K>(k)); 

        /// <summary>
        /// If possible, constructs evidence that n:K => n prime; otherwise,
        /// yields none
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        public static Option<NatPrime<K>> tryPrime<K>()
            where K: ITypeNat, new()
                => Try(() => prime<K>());

        /// <summary>
        /// If possible, constructs evidence that n:K => n prime; otherwise,
        /// yields none
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        public static Option<NatPrime<K>> tryPrime<K>(K k)
            where K: ITypeNat, new()
                => Try(() => prime<K>(k));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 => k1 = k2 + 1;
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        public static Option<NatPrior<K1,K2>> tryPrior<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatPrior<K1,K2>(natrep<K1>(),natrep<K2>()));                             

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 => k1 = k2 + 1;
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        public static Option<NatPrior<K1,K2>> tryPrior<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatPrior<K1,K2>(k1,k2));  

        public static Option<NatBetween<T,K1,K2>> contains<T,K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
            where T : ITypeNat, new() 
                => tryBetween<T,K1,K2>();

    }
}