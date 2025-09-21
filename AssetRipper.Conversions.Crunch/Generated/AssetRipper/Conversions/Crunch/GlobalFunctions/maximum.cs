using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??$maximum@I@math@crnd@@YAIII@Z")]
[DemangledName("unsigned int __cdecl crnd::math::maximum<unsigned int>(unsigned int, unsigned int)")]
internal static partial class maximum
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return unchecked((uint)a <= (uint)b) ? b : a;
	}
}
