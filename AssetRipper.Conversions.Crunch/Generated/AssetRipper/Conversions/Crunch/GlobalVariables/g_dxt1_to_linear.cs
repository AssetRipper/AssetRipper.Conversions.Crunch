using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_dxt1_to_linear@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_dxt1_to_linear")]
internal static partial class g_dxt1_to_linear
{
	private static InlineArray4_SByte __value;

	public static InlineArray4_SByte Value
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

	static g_dxt1_to_linear()
	{
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 0, 3, 1, 2 });
	}
}
