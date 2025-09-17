using System;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

[MangledName("__CxxFrameHandler3")]
[DemangledName("__CxxFrameHandler3")]
internal static partial class CxxFrameHandler3
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(ReadOnlySpan<nint> args)
	{
		return IntrinsicFunctions.CxxFrameHandler3(args);
	}
}
