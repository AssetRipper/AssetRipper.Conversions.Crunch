using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_01GBGANLPD@0?$AA@")]
[DemangledName("\"0\"")]
[CleanName("String")]
internal static partial class String_xzkwrkb
{
	public unsafe static InlineArray_2_w3otm9c* __pointer;

	public unsafe static InlineArray_2_w3otm9c Value
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

	unsafe static String_xzkwrkb()
	{
		__pointer = unchecked((InlineArray_2_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_2_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_2_w3otm9c, byte>("0\0"u8);
	}
}
