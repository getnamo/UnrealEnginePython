// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class UnrealEnginePython : ModuleRules
{

    private const string pythonHome = "python35";

    protected string PythonHome
    {
        get
        {
            return Path.GetFullPath(Path.Combine(ModuleDirectory, "..", "..", pythonHome));
        }
    }

    public UnrealEnginePython(TargetInfo Target)
    {

        System.Console.WriteLine("Using Python at: " + PythonHome);

        PublicIncludePaths.AddRange(
            new string[] {
                "UnrealEnginePython/Public",
				// ... add public include paths required here ...
            }
            );


        PrivateIncludePaths.AddRange(
            new string[] {
                "UnrealEnginePython/Private",
				// ... add other private include paths required here ...
			}
            );


        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
				// ... add other public dependencies that you statically link with here ...
			}
            );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "InputCore",
                "Slate",
                "SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
            );


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
				// ... add any modules that your module loads dynamically here ...
			}
            );




        PublicIncludePaths.Add(PythonHome);
        PublicAdditionalLibraries.Add(Path.Combine(PythonHome, "libs", "python35.lib"));

    }
}
