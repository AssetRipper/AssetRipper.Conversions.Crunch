using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_crnd_chunk_encoding_num_tiles@crnd@@3PAEA")]
[DemangledName("unsigned char *crnd::g_crnd_chunk_encoding_num_tiles")]
internal static partial class g_crnd_chunk_encoding_num_tiles
{
	public unsafe static InlineArray8_SByte* __pointer;

	public unsafe static InlineArray8_SByte Value
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

	unsafe static g_crnd_chunk_encoding_num_tiles()
	{
		__pointer = unchecked((InlineArray8_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray8_SByte))));
		Value = InlineArrayHelper.Create<InlineArray8_SByte, byte>(new byte[8] { 1, 2, 2, 3, 3, 3, 3, 4 });
	}
}
