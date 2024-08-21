using HexaGen.Runtime;

#if NET7_0_OR_GREATER

using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshalling]
#endif

[assembly: NativeLibrary("raylib", TargetPlatform.Windows)]
[assembly: NativeLibrary("libraylib", TargetPlatform.Linux)]
[assembly: NativeLibrary("libraylib", TargetPlatform.OSX)]
[assembly: NativeLibrary("libraylib", TargetPlatform.Android)]