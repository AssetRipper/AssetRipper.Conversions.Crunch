using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_0O@DJHKEBCN@value?5?$DM?$DN?50xFF?$AA@")]
[DemangledName("\"value <= 0xFF\"")]
[CleanName("String")]
internal static partial class String_932ftxa
{
	public unsafe static InlineArray14_SByte* __pointer;

	public unsafe static InlineArray14_SByte Value
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

	unsafe static String_932ftxa()
	{
		__pointer = unchecked((InlineArray14_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray14_SByte))));
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("value <= 0xFF\0"u8);
	}
}
