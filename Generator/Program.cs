using HexaGen;
using HexaGen.Patching;

CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.json");
CsCodeGenerator generator = new(config);
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["Raylib"], NamingPatchOptions.None));
generator.Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.Raylib/Generated");