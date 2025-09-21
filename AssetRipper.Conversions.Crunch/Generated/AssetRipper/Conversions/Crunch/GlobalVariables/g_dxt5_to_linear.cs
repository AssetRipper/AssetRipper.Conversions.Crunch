using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_dxt5_to_linear@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_dxt5_to_linear")]
internal static partial class g_dxt5_to_linear
{
	private static InlineArray8_SByte __value;

	public static InlineArray8_SByte Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	static g_dxt5_to_linear()
	{
		Value = InlineArrayHelper.Create<InlineArray8_SByte, byte>(new byte[8] { 0, 7, 1, 2, 3, 4, 5, 6 });
	}
}
