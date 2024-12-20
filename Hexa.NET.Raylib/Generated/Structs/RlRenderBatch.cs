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
	/// rlRenderBatch type<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "rlRenderBatch")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct RlRenderBatch
	{
		/// <summary>
		/// Number of vertex buffers (multi-buffering support)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "bufferCount")]
		[NativeName(NativeNameType.Type, "int")]
		public int BufferCount;

		/// <summary>
		/// Current buffer tracking in case of multi-buffering<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "currentBuffer")]
		[NativeName(NativeNameType.Type, "int")]
		public int CurrentBuffer;

		/// <summary>
		/// Dynamic buffer(s) for vertex data<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vertexBuffer")]
		[NativeName(NativeNameType.Type, "rlVertexBuffer *")]
		public unsafe RlVertexBuffer* VertexBuffer;

		/// <summary>
		/// Draw calls array, depends on textureId<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "draws")]
		[NativeName(NativeNameType.Type, "rlDrawCall *")]
		public unsafe RlDrawCall* Draws;

		/// <summary>
		/// Draw calls counter<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "drawCounter")]
		[NativeName(NativeNameType.Type, "int")]
		public int DrawCounter;

		/// <summary>
		/// Current depth value for next draw<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "currentDepth")]
		[NativeName(NativeNameType.Type, "float")]
		public float CurrentDepth;


		public unsafe RlRenderBatch(int bufferCount = default, int currentBuffer = default, RlVertexBuffer* vertexBuffer = default, RlDrawCall* draws = default, int drawCounter = default, float currentDepth = default)
		{
			BufferCount = bufferCount;
			CurrentBuffer = currentBuffer;
			VertexBuffer = vertexBuffer;
			Draws = draws;
			DrawCounter = drawCounter;
			CurrentDepth = currentDepth;
		}


	}

}
