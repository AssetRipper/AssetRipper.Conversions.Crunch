using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_endpoint@dxt5_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::unpack_endpoint(unsigned int, unsigned int)")]
[CleanName("unpack_endpoint")]
internal static partial class unpack_endpoint_w5z4hwb
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int")] int packed, [NativeType("unsigned int")] int index)
	{
		unchecked
		{
			if ((uint)index >= 2u)
			{
				crnd_assert.Invoke(String_4tt2t2d.__pointer, String_yguirrd.__pointer, 3558);
			}
			return (packed >>> 8 * index) & 0xFF;
		}
	}
}
