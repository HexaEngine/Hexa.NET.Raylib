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
	/// VrDeviceInfo, Head-Mounted-Display device parameters<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "VrDeviceInfo")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VrDeviceInfo
	{
		/// <summary>
		/// Horizontal resolution in pixels<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "hResolution")]
		[NativeName(NativeNameType.Type, "int")]
		public int HResolution;

		/// <summary>
		/// Vertical resolution in pixels<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vResolution")]
		[NativeName(NativeNameType.Type, "int")]
		public int VResolution;

		/// <summary>
		/// Horizontal size in meters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "hScreenSize")]
		[NativeName(NativeNameType.Type, "float")]
		public float HScreenSize;

		/// <summary>
		/// Vertical size in meters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vScreenSize")]
		[NativeName(NativeNameType.Type, "float")]
		public float VScreenSize;

		/// <summary>
		/// Screen center in meters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vScreenCenter")]
		[NativeName(NativeNameType.Type, "float")]
		public float VScreenCenter;

		/// <summary>
		/// Distance between eye and display in meters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "eyeToScreenDistance")]
		[NativeName(NativeNameType.Type, "float")]
		public float EyeToScreenDistance;

		/// <summary>
		/// Lens separation distance in meters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "lensSeparationDistance")]
		[NativeName(NativeNameType.Type, "float")]
		public float LensSeparationDistance;

		/// <summary>
		/// IPD (distance between pupils) in meters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "interpupillaryDistance")]
		[NativeName(NativeNameType.Type, "float")]
		public float InterpupillaryDistance;

		/// <summary>
		/// Lens distortion constant parameters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "lensDistortionValues")]
		[NativeName(NativeNameType.Type, "float[4]")]
		public float LensDistortionValues_0;
		public float LensDistortionValues_1;
		public float LensDistortionValues_2;
		public float LensDistortionValues_3;

		/// <summary>
		/// Chromatic aberration correction parameters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "chromaAbCorrection")]
		[NativeName(NativeNameType.Type, "float[4]")]
		public float ChromaAbCorrection_0;
		public float ChromaAbCorrection_1;
		public float ChromaAbCorrection_2;
		public float ChromaAbCorrection_3;


		public unsafe VrDeviceInfo(int hResolution = default, int vResolution = default, float hScreenSize = default, float vScreenSize = default, float vScreenCenter = default, float eyeToScreenDistance = default, float lensSeparationDistance = default, float interpupillaryDistance = default, float* lensDistortionValues = default, float* chromaAbCorrection = default)
		{
			HResolution = hResolution;
			VResolution = vResolution;
			HScreenSize = hScreenSize;
			VScreenSize = vScreenSize;
			VScreenCenter = vScreenCenter;
			EyeToScreenDistance = eyeToScreenDistance;
			LensSeparationDistance = lensSeparationDistance;
			InterpupillaryDistance = interpupillaryDistance;
			if (lensDistortionValues != default(float*))
			{
				LensDistortionValues_0 = lensDistortionValues[0];
				LensDistortionValues_1 = lensDistortionValues[1];
				LensDistortionValues_2 = lensDistortionValues[2];
				LensDistortionValues_3 = lensDistortionValues[3];
			}
			if (chromaAbCorrection != default(float*))
			{
				ChromaAbCorrection_0 = chromaAbCorrection[0];
				ChromaAbCorrection_1 = chromaAbCorrection[1];
				ChromaAbCorrection_2 = chromaAbCorrection[2];
				ChromaAbCorrection_3 = chromaAbCorrection[3];
			}
		}

		public unsafe VrDeviceInfo(int hResolution = default, int vResolution = default, float hScreenSize = default, float vScreenSize = default, float vScreenCenter = default, float eyeToScreenDistance = default, float lensSeparationDistance = default, float interpupillaryDistance = default, Span<float> lensDistortionValues = default, Span<float> chromaAbCorrection = default)
		{
			HResolution = hResolution;
			VResolution = vResolution;
			HScreenSize = hScreenSize;
			VScreenSize = vScreenSize;
			VScreenCenter = vScreenCenter;
			EyeToScreenDistance = eyeToScreenDistance;
			LensSeparationDistance = lensSeparationDistance;
			InterpupillaryDistance = interpupillaryDistance;
			if (lensDistortionValues != default(Span<float>))
			{
				LensDistortionValues_0 = lensDistortionValues[0];
				LensDistortionValues_1 = lensDistortionValues[1];
				LensDistortionValues_2 = lensDistortionValues[2];
				LensDistortionValues_3 = lensDistortionValues[3];
			}
			if (chromaAbCorrection != default(Span<float>))
			{
				ChromaAbCorrection_0 = chromaAbCorrection[0];
				ChromaAbCorrection_1 = chromaAbCorrection[1];
				ChromaAbCorrection_2 = chromaAbCorrection[2];
				ChromaAbCorrection_3 = chromaAbCorrection[3];
			}
		}


	}

}