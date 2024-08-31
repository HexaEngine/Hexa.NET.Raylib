# Hexa.NET.Raylib

Hexa.NET.Raylib is a minimal C# wrapper for the Raylib library, providing a thin, 1:1 binding to Raylib's C functions. This wrapper is designed for developers who need direct access to the Raylib library's functionality from C#, without added complexity or overhead.

## Features

- **Minimal Wrapper**: Provides a direct, 1:1 mapping to the Raylib C functions, staying true to the original API.
- **Cross-Platform Compatibility**: Works across all platforms supported by Raylib, including Windows, Linux, and macOS.
- **Pre-Built Native Libraries**: The package includes pre-built native libraries, so you don't need to worry about installing Raylib separately.
- **High-Performance**: The library uses a static vtable, which provides less overhead then DllImport/LibraryImport and faster startup times.

## Installation

You can install Hexa.NET.Raylib via NuGet:

```bash
dotnet add package Hexa.NET.Raylib
```

Alternatively, you can visit the [NuGet package page](https://www.nuget.org/packages/Hexa.NET.Raylib) and follow the instructions there.

## Contributing

Contributions are welcome! If you encounter any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License

Hexa.NET.Raylib is licensed under the MIT License. See the [LICENSE](https://github.com/HexaEngine/Hexa.NET.Raylib/blob/master/LICENSE.txt) file for more information.