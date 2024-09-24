// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Raylib
{
	/// <summary>
	/// Shader attribute data types<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "rlShaderAttributeDataType")]
	[Flags]
	public enum RlShaderAttributeDataType : int
	{
		/// <summary>
		/// Shader attribute type: float<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_SHADER_ATTRIB_FLOAT")]
		[NativeName(NativeNameType.Value, "0")]
		AttribFloat = unchecked(0),

		/// <summary>
		/// Shader attribute type: vec2 (2 float)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_SHADER_ATTRIB_VEC2")]
		[NativeName(NativeNameType.Value, "1")]
		AttribVec2 = unchecked(1),

		/// <summary>
		/// Shader attribute type: vec3 (3 float)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_SHADER_ATTRIB_VEC3")]
		[NativeName(NativeNameType.Value, "2")]
		AttribVec3 = unchecked(2),

		/// <summary>
		/// Shader attribute type: vec4 (4 float)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_SHADER_ATTRIB_VEC4")]
		[NativeName(NativeNameType.Value, "3")]
		AttribVec4 = unchecked(3),
	}
}