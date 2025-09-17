using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

internal static partial class realloc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(void* ptr, long size)
	{
		return IntrinsicFunctions.ReAlloc(ptr, size);
	}
}
