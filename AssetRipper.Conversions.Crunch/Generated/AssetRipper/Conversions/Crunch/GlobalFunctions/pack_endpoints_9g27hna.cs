using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?pack_endpoints@dxt1_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::pack_endpoints(unsigned int, unsigned int)")]
[CleanName("pack_endpoints")]
internal static partial class pack_endpoints_9g27hna
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int")] int lo, [NativeType("unsigned int")] int hi)
	{
		if (unchecked((uint)lo > 65535u || (uint)hi > 65535u))
		{
			crnd_assert.Invoke(String_myspu3d.__pointer, String_yguirrd.__pointer, 3454);
		}
		return lo | (hi << 16);
	}
}
