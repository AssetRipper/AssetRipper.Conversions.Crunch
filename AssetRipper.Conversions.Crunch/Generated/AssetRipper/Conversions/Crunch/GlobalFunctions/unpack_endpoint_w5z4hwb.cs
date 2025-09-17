using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_endpoint@dxt5_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::unpack_endpoint(unsigned int, unsigned int)")]
[CleanName("unpack_endpoint")]
internal static partial class unpack_endpoint_w5z4hwb
{
	public unsafe static int Invoke(int packed, int index)
	{
		int num = 0;
		int num2 = 0;
		num = index;
		num2 = packed;
		unchecked
		{
			int num3;
			if ((uint)num < 2u)
			{
				num3 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_4tt2t2d.__pointer, String_yguirrd.__pointer, 3558);
				num3 = 0;
			}
			return (num2 >>> 8 * num) & 0xFF;
		}
	}
}
