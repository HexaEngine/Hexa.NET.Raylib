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
	/// ModelAnimation<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "ModelAnimation")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ModelAnimation
	{
		/// <summary>
		/// Number of bones<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "boneCount")]
		[NativeName(NativeNameType.Type, "int")]
		public int BoneCount;

		/// <summary>
		/// Number of animation frames<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "frameCount")]
		[NativeName(NativeNameType.Type, "int")]
		public int FrameCount;

		/// <summary>
		/// Bones information (skeleton)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "bones")]
		[NativeName(NativeNameType.Type, "BoneInfo*")]
		public unsafe BoneInfo* Bones;

		/// <summary>
		/// Poses array by frame<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "framePoses")]
		[NativeName(NativeNameType.Type, "Transform**")]
		public unsafe Transform** FramePoses;

		/// <summary>
		/// Animation name<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "name")]
		[NativeName(NativeNameType.Type, "char[32]")]
		public byte Name_0;
		public byte Name_1;
		public byte Name_2;
		public byte Name_3;
		public byte Name_4;
		public byte Name_5;
		public byte Name_6;
		public byte Name_7;
		public byte Name_8;
		public byte Name_9;
		public byte Name_10;
		public byte Name_11;
		public byte Name_12;
		public byte Name_13;
		public byte Name_14;
		public byte Name_15;
		public byte Name_16;
		public byte Name_17;
		public byte Name_18;
		public byte Name_19;
		public byte Name_20;
		public byte Name_21;
		public byte Name_22;
		public byte Name_23;
		public byte Name_24;
		public byte Name_25;
		public byte Name_26;
		public byte Name_27;
		public byte Name_28;
		public byte Name_29;
		public byte Name_30;
		public byte Name_31;


		public unsafe ModelAnimation(int boneCount = default, int frameCount = default, BoneInfo* bones = default, Transform** framePoses = default, byte* name = default)
		{
			BoneCount = boneCount;
			FrameCount = frameCount;
			Bones = bones;
			FramePoses = framePoses;
			if (name != default(byte*))
			{
				Name_0 = name[0];
				Name_1 = name[1];
				Name_2 = name[2];
				Name_3 = name[3];
				Name_4 = name[4];
				Name_5 = name[5];
				Name_6 = name[6];
				Name_7 = name[7];
				Name_8 = name[8];
				Name_9 = name[9];
				Name_10 = name[10];
				Name_11 = name[11];
				Name_12 = name[12];
				Name_13 = name[13];
				Name_14 = name[14];
				Name_15 = name[15];
				Name_16 = name[16];
				Name_17 = name[17];
				Name_18 = name[18];
				Name_19 = name[19];
				Name_20 = name[20];
				Name_21 = name[21];
				Name_22 = name[22];
				Name_23 = name[23];
				Name_24 = name[24];
				Name_25 = name[25];
				Name_26 = name[26];
				Name_27 = name[27];
				Name_28 = name[28];
				Name_29 = name[29];
				Name_30 = name[30];
				Name_31 = name[31];
			}
		}

		public unsafe ModelAnimation(int boneCount = default, int frameCount = default, BoneInfo* bones = default, Transform** framePoses = default, Span<byte> name = default)
		{
			BoneCount = boneCount;
			FrameCount = frameCount;
			Bones = bones;
			FramePoses = framePoses;
			if (name != default(Span<byte>))
			{
				Name_0 = name[0];
				Name_1 = name[1];
				Name_2 = name[2];
				Name_3 = name[3];
				Name_4 = name[4];
				Name_5 = name[5];
				Name_6 = name[6];
				Name_7 = name[7];
				Name_8 = name[8];
				Name_9 = name[9];
				Name_10 = name[10];
				Name_11 = name[11];
				Name_12 = name[12];
				Name_13 = name[13];
				Name_14 = name[14];
				Name_15 = name[15];
				Name_16 = name[16];
				Name_17 = name[17];
				Name_18 = name[18];
				Name_19 = name[19];
				Name_20 = name[20];
				Name_21 = name[21];
				Name_22 = name[22];
				Name_23 = name[23];
				Name_24 = name[24];
				Name_25 = name[25];
				Name_26 = name[26];
				Name_27 = name[27];
				Name_28 = name[28];
				Name_29 = name[29];
				Name_30 = name[30];
				Name_31 = name[31];
			}
		}


	}

}