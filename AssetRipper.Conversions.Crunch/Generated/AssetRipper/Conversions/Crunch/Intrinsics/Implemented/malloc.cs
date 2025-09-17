using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

internal static partial class malloc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(long size)
	{
		return IntrinsicFunctions.Alloc(size);
	}
}
