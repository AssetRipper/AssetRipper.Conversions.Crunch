using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_0BL@MIJFKMEH@num?5?$CG?$CG?5?$CInum?5?$DN?$DN?5?$HOnum_check?$CJ?$AA@")]
[DemangledName("\"num && (num == ~num_check)\"")]
[CleanName("String")]
internal static partial class String_ec57feb
{
	public unsafe static InlineArray_27_w3otm9c* __pointer;

	public unsafe static InlineArray_27_w3otm9c Value
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
		__pointer = unchecked((InlineArray_27_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_27_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_27_w3otm9c, byte>("num && (num == ~num_check)\0"u8);
	}
}
