using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("??_C@_0L@GPMGHDBL@i?5?$DM?5m_size?$AA@")]
[DemangledName("\"i < m_size\"")]
[CleanName("String")]
internal static partial class String_ededlgd
{
	public unsafe static InlineArray11_SByte* __pointer;

	public unsafe static InlineArray11_SByte Value
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

	unsafe static String_ededlgd()
	{
		__pointer = unchecked((InlineArray11_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray11_SByte))));
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("i < m_size\0"u8);
	}
}
