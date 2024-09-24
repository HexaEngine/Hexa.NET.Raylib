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
	/// BoundingBox<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "BoundingBox")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct BoundingBox
	{
		/// <summary>
		/// Minimum vertex box-corner<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "min")]
		[NativeName(NativeNameType.Type, "Vector3")]
		public Vector3 Min;

		/// <summary>
		/// Maximum vertex box-corner<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "max")]
		[NativeName(NativeNameType.Type, "Vector3")]
		public Vector3 Max;


		public unsafe BoundingBox(Vector3 min = default, Vector3 max = default)
		{
			Min = min;
			Max = max;
		}


	}

}