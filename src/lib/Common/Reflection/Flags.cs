//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Defines useful collection of reflection binding flags
    /// </summary>
    public static class ReflectionFlags
    {
        public const BindingFlags BF_Instance
            = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags BF_Static =
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

        public const BindingFlags BF_AllRestrictedInstance
            = BindingFlags.FlattenHierarchy | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags BF_DeclaredRestrictedInstance
            = BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags BF_PublicInstance
            = BindingFlags.Public | BindingFlags.Instance;

        public const BindingFlags BF_PublicStatic
            = BindingFlags.Public | BindingFlags.Static;

        public const BindingFlags BF_DeclaredPublicInstance
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

        public const BindingFlags BF_DeclaredNonPublicInstance
            = BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags BF_AllPublicInstance
            = BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance;

        public const BindingFlags BF_DeclaredPublicStatic
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static;

        public const BindingFlags BF_DeclaredNonPublicStatic
            = BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Static;

        public const BindingFlags BF_Declared
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        public const BindingFlags BF_DeclaredStatic
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

        public const BindingFlags BF_DeclaredInstance
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags BF_AllPublicStatic
            = BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Static;

        public const BindingFlags BF_PublicNonPublic
        = BindingFlags.Public | BindingFlags.NonPublic;

        public const BindingFlags BF_InstanceStatic
            = BindingFlags.Instance | BindingFlags.Static;

        public const BindingFlags AnyVisibilityOrInstanceType
            = BindingFlags.Public
            | BindingFlags.NonPublic
            | BindingFlags.Instance
            | BindingFlags.Static;

    }

    public enum MemberInstanceType
    {
        Instance = 0,
        Static = 1
    }
}