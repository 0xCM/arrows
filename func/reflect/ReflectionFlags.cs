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

        /// <summary>
        ///  All public static members, declared or inherited
        /// </summary>
        public const BindingFlags BF_AllPublicStatic
            = BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Static;

        /// <summary>
        ///  All public instance members, declared or inherited
        /// </summary>
        public const BindingFlags BF_AllPublicInstance
            = BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance;

        /// <summary>
        ///  All non-public static members, declared or inherited
        /// </summary>
        public const BindingFlags BF_AllRestrictedStatic
            = BindingFlags.FlattenHierarchy | BindingFlags.NonPublic | BindingFlags.Static;

        /// <summary>
        ///  All non-public instance members, declared or inherited
        /// </summary>
        public const BindingFlags BF_AllRestrictedInstance
            = BindingFlags.FlattenHierarchy | BindingFlags.NonPublic | BindingFlags.Instance;

        /// <summary>
        ///  All instance members, declared or inherited
        /// </summary>
        public const BindingFlags BF_AllInstance
            = BF_AllPublicInstance | BF_AllRestrictedInstance;

        /// <summary>
        ///  All static members, declared or inherited
        /// </summary>
        public const BindingFlags BF_AllStatic
            = BF_AllPublicStatic | BF_AllRestrictedStatic;
        
        /// <summary>
        ///  All members, declared or inherited
        /// </summary>
        public const BindingFlags BF_All
            = BF_AllInstance | BF_AllStatic;
        
        /// <summary>
        ///  All declared non-public instance members
        /// </summary>
        public const BindingFlags BF_DeclaredRestrictedInstance
            = BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags BF_DeclaredPublicInstance
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

        public const BindingFlags BF_DeclaredPublic
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static;

        public const BindingFlags BF_DeclaredNonPublicInstance
            = BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Instance;

        public const BindingFlags BF_DeclaredPublicStatic
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static;

        public const BindingFlags BF_DeclaredNonPublicStatic
            = BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Static;

        /// <summary>
        /// All declared static members
        /// </summary>
        public const BindingFlags BF_DeclaredStatic
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

        /// <summary>
        /// All declared instance members
        /// </summary>
        public const BindingFlags BF_DeclaredInstance
            = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        /// <summary>
        /// All declared members
        /// </summary>
        public const BindingFlags BF_Declared
            = BF_DeclaredInstance | BF_DeclaredStatic;

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