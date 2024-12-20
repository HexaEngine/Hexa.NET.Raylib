// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Raylib
{
	/// <summary>
	/// Dynamic vertex buffers (position + texcoords + colors + indices arrays)<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "rlVertexBuffer")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct RlVertexBuffer
	{
		/// <summary>
		/// Number of elements in the buffer (QUADS)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "elementCount")]
		[NativeName(NativeNameType.Type, "int")]
		public int ElementCount;

		/// <summary>
		/// Vertex position (XYZ - 3 components per vertex) (shader-location = 0)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vertices")]
		[NativeName(NativeNameType.Type, "float *")]
		public unsafe float* Vertices;

		/// <summary>
		/// Vertex texture coordinates (UV - 2 components per vertex) (shader-location = 1)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "texcoords")]
		[NativeName(NativeNameType.Type, "float *")]
		public unsafe float* Texcoords;

		/// <summary>
		/// Vertex normal (XYZ - 3 components per vertex) (shader-location = 2)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "normals")]
		[NativeName(NativeNameType.Type, "float *")]
		public unsafe float* Normals;

		/// <summary>
		/// Vertex colors (RGBA - 4 components per vertex) (shader-location = 3)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "colors")]
		[NativeName(NativeNameType.Type, "unsigned char *")]
		public unsafe byte* Colors;

		/// <summary>
		/// Vertex indices (in case vertex data comes indexed) (6 indices per quad)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "indices")]
		[NativeName(NativeNameType.Type, "unsigned int *")]
		public unsafe uint* Indices;

		/// <summary>
		/// OpenGL Vertex Array Object id<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vaoId")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint VaoId;

		/// <summary>
		/// OpenGL Vertex Buffer Objects id (5 types of vertex data)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vboId")]
		[NativeName(NativeNameType.Type, "unsigned int[5]")]
		public uint VboId_0;
		public uint VboId_1;
		public uint VboId_2;
		public uint VboId_3;
		public uint VboId_4;


		public unsafe RlVertexBuffer(int elementCount = default, float* vertices = default, float* texcoords = default, float* normals = default, byte* colors = default, uint* indices = default, uint vaoId = default, uint* vboId = default)
		{
			ElementCount = elementCount;
			Vertices = vertices;
			Texcoords = texcoords;
			Normals = normals;
			Colors = colors;
			Indices = indices;
			VaoId = vaoId;
			if (vboId != default(uint*))
			{
				VboId_0 = vboId[0];
				VboId_1 = vboId[1];
				VboId_2 = vboId[2];
				VboId_3 = vboId[3];
				VboId_4 = vboId[4];
			}
		}

		public unsafe RlVertexBuffer(int elementCount = default, float* vertices = default, float* texcoords = default, float* normals = default, byte* colors = default, uint* indices = default, uint vaoId = default, Span<uint> vboId = default)
		{
			ElementCount = elementCount;
			Vertices = vertices;
			Texcoords = texcoords;
			Normals = normals;
			Colors = colors;
			Indices = indices;
			VaoId = vaoId;
			if (vboId != default(Span<uint>))
			{
				VboId_0 = vboId[0];
				VboId_1 = vboId[1];
				VboId_2 = vboId[2];
				VboId_3 = vboId[3];
				VboId_4 = vboId[4];
			}
		}


	}

}
