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
	/// Framebuffer attachment type<br/>
	/// NOTE: By default up to 8 color channels defined, but it can be more<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "rlFramebufferAttachType")]
	[Flags]
	public enum RlFramebufferAttachType : int
	{
		/// <summary>
		/// Framebuffer attachment type: color 0<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL0")]
		[NativeName(NativeNameType.Value, "0")]
		AttachmentColorChannel0 = unchecked(0),

		/// <summary>
		/// Framebuffer attachment type: color 1<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL1")]
		[NativeName(NativeNameType.Value, "1")]
		AttachmentColorChannel1 = unchecked(1),

		/// <summary>
		/// Framebuffer attachment type: color 2<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL2")]
		[NativeName(NativeNameType.Value, "2")]
		AttachmentColorChannel2 = unchecked(2),

		/// <summary>
		/// Framebuffer attachment type: color 3<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL3")]
		[NativeName(NativeNameType.Value, "3")]
		AttachmentColorChannel3 = unchecked(3),

		/// <summary>
		/// Framebuffer attachment type: color 4<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL4")]
		[NativeName(NativeNameType.Value, "4")]
		AttachmentColorChannel4 = unchecked(4),

		/// <summary>
		/// Framebuffer attachment type: color 5<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL5")]
		[NativeName(NativeNameType.Value, "5")]
		AttachmentColorChannel5 = unchecked(5),

		/// <summary>
		/// Framebuffer attachment type: color 6<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL6")]
		[NativeName(NativeNameType.Value, "6")]
		AttachmentColorChannel6 = unchecked(6),

		/// <summary>
		/// Framebuffer attachment type: color 7<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_COLOR_CHANNEL7")]
		[NativeName(NativeNameType.Value, "7")]
		AttachmentColorChannel7 = unchecked(7),

		/// <summary>
		/// Framebuffer attachment type: depth<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_DEPTH")]
		[NativeName(NativeNameType.Value, "100")]
		AttachmentDepth = unchecked(100),

		/// <summary>
		/// Framebuffer attachment type: stencil<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "RL_ATTACHMENT_STENCIL")]
		[NativeName(NativeNameType.Value, "200")]
		AttachmentStencil = unchecked(200),
	}
}
