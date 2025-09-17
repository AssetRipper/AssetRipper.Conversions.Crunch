using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_0DG@KEHBKINA@?$CI?$CIuint32?$CJp_new?5?$CG?5?$CICRND_MIN_ALLOC@")]
[DemangledName("\"((uint32)p_new & (CRND_MIN_ALLOC\"...")]
[CleanName("String")]
internal static partial class String_e9ixvnc
{
	public unsafe static InlineArray_54_w3otm9c* __pointer;

	public unsafe static InlineArray_54_w3otm9c Value
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

	unsafe static String_e9ixvnc()
	{
		__pointer = unchecked((InlineArray_54_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_54_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_54_w3otm9c, byte>("((uint32)p_new & (CRND_MIN_ALLOC_ALIGNMENT - 1)) == 0\0"u8);
	}
}
