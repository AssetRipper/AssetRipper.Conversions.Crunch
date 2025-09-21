using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_0BL@MIJFKMEH@num?5?$CG?$CG?5?$CInum?5?$DN?$DN?5?$HOnum_check?$CJ?$AA@")]
[DemangledName("\"num && (num == ~num_check)\"")]
[CleanName("String")]
internal static partial class String_ec57feb
{
	public unsafe static InlineArray27_SByte* __pointer;

	public unsafe static InlineArray27_SByte Value
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

	unsafe static String_ec57feb()
	{
		__pointer = unchecked((InlineArray27_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray27_SByte))));
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("num && (num == ~num_check)\0"u8);
	}
}
