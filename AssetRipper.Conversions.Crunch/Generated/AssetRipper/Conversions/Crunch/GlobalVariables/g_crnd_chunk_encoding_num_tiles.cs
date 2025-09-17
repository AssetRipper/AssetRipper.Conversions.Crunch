using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_crnd_chunk_encoding_num_tiles@crnd@@3PAEA")]
[DemangledName("unsigned char *crnd::g_crnd_chunk_encoding_num_tiles")]
internal static partial class g_crnd_chunk_encoding_num_tiles
{
	public unsafe static InlineArray_8_w3otm9c* __pointer;

	public unsafe static InlineArray_8_w3otm9c Value
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
		__pointer = unchecked((InlineArray_8_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_8_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_8_w3otm9c, byte>(new byte[8] { 1, 2, 2, 3, 3, 3, 3, 4 });
	}
}
