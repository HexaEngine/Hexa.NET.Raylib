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
	/// Music, audio stream, anything longer than ~10 seconds should be streamed<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "Music")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Music
	{
		/// <summary>
		/// Audio stream<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "stream")]
		[NativeName(NativeNameType.Type, "AudioStream")]
		public AudioStream Stream;

		/// <summary>
		/// Total number of frames (considering channels)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "frameCount")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint FrameCount;

		/// <summary>
		/// Music looping enable<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "looping")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte Looping;

		/// <summary>
		/// Type of music context (audio filetype)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ctxType")]
		[NativeName(NativeNameType.Type, "int")]
		public int CtxType;

		/// <summary>
		/// Audio context data, depends on type<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ctxData")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* CtxData;


		public unsafe Music(AudioStream stream = default, uint frameCount = default, bool looping = default, int ctxType = default, void* ctxData = default)
		{
			Stream = stream;
			FrameCount = frameCount;
			Looping = looping ? (byte)1 : (byte)0;
			CtxType = ctxType;
			CtxData = ctxData;
		}


	}

}
