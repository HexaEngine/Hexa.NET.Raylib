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
	/// Wave, audio wave data<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "Wave")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Wave
	{
		/// <summary>
		/// Total number of frames (considering channels)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "frameCount")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint FrameCount;

		/// <summary>
		/// Frequency (samples per second)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "sampleRate")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint SampleRate;

		/// <summary>
		/// Bit depth (bits per sample): 8, 16, 32 (24 not supported)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "sampleSize")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint SampleSize;

		/// <summary>
		/// Number of channels (1-mono, 2-stereo, ...)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "channels")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Channels;

		/// <summary>
		/// Buffer data pointer<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "data")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* Data;


		public unsafe Wave(uint frameCount = default, uint sampleRate = default, uint sampleSize = default, uint channels = default, void* data = default)
		{
			FrameCount = frameCount;
			SampleRate = sampleRate;
			SampleSize = sampleSize;
			Channels = channels;
			Data = data;
		}


	}

}
