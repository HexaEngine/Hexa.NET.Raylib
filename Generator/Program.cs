using HexaGen;
using HexaGen.Patching;

BatchGenerator batch = new();
batch.Start()
    .Setup<CsCodeGenerator>("generator.json")
    .AddPrePatch(new NamingPatch(["Raylib"], NamingPatchOptions.None))
    .Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.Raylib/Generated");