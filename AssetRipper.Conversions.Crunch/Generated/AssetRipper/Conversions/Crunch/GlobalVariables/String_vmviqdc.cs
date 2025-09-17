using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_0BF@OMHJAMGG@m_size?5?$DM?$DN?5m_capacity?$AA@")]
[DemangledName("\"m_size <= m_capacity\"")]
[CleanName("String")]
internal static partial class String_vmviqdc
{
	public unsafe static InlineArray_21_w3otm9c* __pointer;

	public unsafe static InlineArray_21_w3otm9c Value
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

	unsafe static String_vmviqdc()
	{
		__pointer = unchecked((InlineArray_21_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_21_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_21_w3otm9c, byte>("m_size <= m_capacity\0"u8);
	}
}
