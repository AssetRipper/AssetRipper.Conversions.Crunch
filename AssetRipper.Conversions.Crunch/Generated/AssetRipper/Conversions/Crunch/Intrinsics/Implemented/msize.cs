using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

[MangledName("_msize")]
[DemangledName("_msize")]
internal static partial class msize
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static long Invoke(void* ptr)
	{
		return IntrinsicFunctions.Size(ptr);
	}
}
