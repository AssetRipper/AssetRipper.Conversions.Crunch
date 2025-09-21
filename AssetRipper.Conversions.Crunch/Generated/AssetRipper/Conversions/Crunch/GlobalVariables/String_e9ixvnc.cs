using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_0DG@KEHBKINA@?$CI?$CIuint32?$CJp_new?5?$CG?5?$CICRND_MIN_ALLOC@")]
[DemangledName("\"((uint32)p_new & (CRND_MIN_ALLOC\"...")]
[CleanName("String")]
internal static partial class String_e9ixvnc
{
	public unsafe static InlineArray54_SByte* __pointer;

	public unsafe static InlineArray54_SByte Value
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
		__pointer = unchecked((InlineArray54_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray54_SByte))));
		Value = InlineArrayHelper.Create<InlineArray54_SByte, byte>("((uint32)p_new & (CRND_MIN_ALLOC_ALIGNMENT - 1)) == 0\0"u8);
	}
}
