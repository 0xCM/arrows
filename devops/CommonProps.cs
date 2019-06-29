//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static Property;
    
    public class MsVars
    {
        public static Variable MsBuildProjectName  => buildvar();
        
        public static Variable IntermediateBuildDir => buildvar();

        public static Variable IntermediateOutputPath => buildvar();

        public static Variable AssemblyVersion => buildvar();
    }
    
    public class Vars : MsVars
    {

        public static Variable TopDir => buildvar();

        public static Variable BuildRootDir => buildvar();

        public static Variable LibBuildDir => buildvar();
    }

    public static class CommonProps
    {                
        public static Property AssemblyVersion => prop("1.0.9");
        public static Property TopDir => prop(@"J:\dev\projects\z0\");                
        public static Property BuildRootDir => prop($"{Vars.TopDir}bin\\");        
        public static Property LibBuildDir => prop($"{BuildRootDir}lib\\");        
        public static Property OutputDir => prop(Vars.LibBuildDir);
        public static Property OutputPath => prop(Vars.LibBuildDir);
        public static Property DocumentationFile => prop($"{Vars.LibBuildDir}$(MSBuildProjectName).xml");
        public static Property IntermediateBuildDir => prop($"{Vars.BuildRootDir}obj\\{Vars.MsBuildProjectName}\\");
        public static Property IntermediateOutputPath => prop(Vars.IntermediateBuildDir);
        public static Property BaseIntermediateOutputPath => prop(Vars.IntermediateBuildDir);
        public static Property NoWarn => prop(1591,1572,1573,1701,1702,1712,1711,1570,1571,1574,1710,8321);
        public static Property NullableReferenceTypes => prop(true);
        public static Property NullableContextOptions => prop("disable");
        public static Property AllowUnsafeBlocks => prop(true);
        public static Property Optimize => prop(true);        
        public static Property Prefer32Bit => prop(false);
        public static Property DebugType => prop("pdbonly");
        public static Property DebugSymbols => prop(true);
        public static Property LangVersion => prop("preview");
        public static Property SuppressNETCoreSdkPreviewMessage => prop(true);
        public static Property VersionPrefix => prop(Vars.AssemblyVersion);

        public static IEnumerable<Property> All 
            => from p in typeof(CommonProps).GetProperties(BindingFlags.Public | BindingFlags.Static).Where(p =>p.PropertyType == typeof(Property))
                select (Property)p.GetValue(null);

        public static PropertyGroup CreateGroup()
            => PropertyGroup.Define("common", All.ToArray());

    }
    
}