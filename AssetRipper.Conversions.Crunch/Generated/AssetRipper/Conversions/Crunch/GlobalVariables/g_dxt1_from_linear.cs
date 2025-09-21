using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_dxt1_from_linear@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_dxt1_from_linear")]
internal static partial class g_dxt1_from_linear
{
	public unsafe static InlineArray4_SByte* __pointer;

	public unsafe static InlineArray4_SByte Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static g_dxt1_from_linear()
	{
		__pointer = unchecked((InlineArray4_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray4_SByte))));
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 0, 2, 3, 1 });
	}
}
