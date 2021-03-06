//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.As;

partial class zfunc
{

    public static readonly N0 n0 = default;

    public static readonly N1 n1 = default;

    public static readonly N2 n2 = default;

    public static readonly N3 n3 = default;
    
    public static readonly N4 n4 = default;

    public static readonly N5 n5 = default;

    public static readonly N6 n6 = default;

    public static readonly N7 n7 = default;

    public static readonly N8 n8 = default;
    
    public static readonly N9 n9 = default;
    
    public static readonly N10 n10 = default;
    
    public static readonly N11 n11 = default;

    public static readonly N12 n12 = default;

    public static readonly N13 n13 = default;

    public static readonly N14 n14 = default;

    public static readonly N15 n15 = default;

    public static readonly N16 n16 = default;

    public static readonly N17 n17 = default;

    public static readonly N18 n18 = default;

    public static readonly N19 n19 = default;

    public static readonly N20 n20 = default;

    public static readonly N21 n21 = default;

    public static readonly N22 n22 = default;

    public static readonly N23 n23 = default;

    public static readonly N24 n24 = default;

    public static readonly N25 n25 = default;

    public static readonly N26 N26 = default;

    public static readonly N27 n27 = default;

    public static readonly N28 n28 = default;

    public static readonly N29 n29 = default;

    public static readonly NatSeq<N3,N0> n30 = default;

    public static readonly NatSeq<N3,N1> n31 = default;

    public static readonly N32 n32 = default;

    public static readonly NatSeq<N3,N3> n33 = default;

    public static readonly NatSeq<N3,N4> n34 = default;

    public static readonly NatSeq<N3,N5> n35 = default;

    public static readonly NatSeq<N3,N6> n36 = default;

    public static readonly NatSeq<N3,N7> n37 = default;

    public static readonly NatSeq<N3,N8> n38 = default;

    public static readonly NatSeq<N3,N9> n39 = default;

    public static readonly NatSeq<N4,N0> n40 = default;

    public static readonly NatSeq<N4,N1> N41 = default;

    public static readonly NatSeq<N4,N2> n42 = default;

    public static readonly NatSeq<N4,N3> n43 = default;

    public static readonly NatSeq<N4,N4> n44 = default;

    public static readonly NatSeq<N4,N5> n45 = default;

    public static readonly NatSeq<N4,N5> n47 = default;

    public static readonly NatSeq<N4,N8> N48 = default;

    public static readonly N63 n63 = default;

    public static readonly N64 n64 = default;

    public static readonly NatSeq<N6,N5> n65 = default;

    public static readonly NatSeq<N6,N6> n66 = default;

    public static readonly NatSeq<N6,N7> n67 = default;

    public static readonly NatSeq<N6,N8> n68 = default;

    public static readonly NatSeq<N8,N7> n87 = default;

    public static readonly NatSeq<N8,N7> n88 = default;

    public static readonly NatSeq<N1,N1,N1> n111 = default;

    public static readonly N127 n127 = default;

    public static readonly N128 n128 = default;

    public static readonly N255 n255 = default;

    public static readonly N256 n256 = default;

    public static readonly NatSeq<N2,N5,N7> n257 = default;

    public static readonly N512 n512 = default;

    public static readonly N1024 n1024 = default;

    public static readonly NatSeq<N1,N2,N7,N7> n1277 = default;        

    public static readonly N2048 n2048 = default;

    public static readonly N4096 n4096 = default;

    public static readonly N8192 n8192 = default;

    public static readonly N16384 n16384 = default; 

    /// <summary>
    /// Creates a natural sequence of length 2
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2> nat<K1,K2>(K1 k1 = default, K2 k2 = default)
        where K1 : INatPrimitive<K1>,new()
        where K2 : INatPrimitive<K2>, new()
            => NatSeq<K1,K2>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 3
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <param name="k3">The third term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    /// <typeparam name="K3">The third term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3> nat<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
        where K1 : INatPrimitive<K1>, new()
        where K2 : INatPrimitive<K2>, new()
        where K3 : INatPrimitive<K3>, new()
            => NatSeq<K1,K2,K3>.Rep;

    /// <summary>
    /// Creates a natural sequence of length 4
    /// </summary>
    /// <param name="k1">The first term</param>
    /// <param name="k2">The second term</param>
    /// <param name="k3">The third term</param>
    /// <typeparam name="K1">The first term type</typeparam>
    /// <typeparam name="K2">The second term type</typeparam>
    /// <typeparam name="K3">The third term type</typeparam>
    [MethodImpl(Inline)]
    public static NatSeq<K1,K2,K3,K4> nat<K1,K2,K3,K4>(K1 k1 = default, K2 k2 = default, K3 k3 = default, K4 k4 = default)
        where K1 : INatPrimitive<K1>, new()
        where K2 : INatPrimitive<K2>, new()
        where K3 : INatPrimitive<K3>, new()
        where K4 : INatPrimitive<K4>, new()
            => NatSeq<K1,K2,K3,K4>.Rep;
}