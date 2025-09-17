using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

internal static partial class puts
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(void* P_0)
	{
		return IntrinsicFunctions.PutString(unchecked((sbyte*)P_0));
	}
}
