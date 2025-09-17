using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_crnd_chunk_encoding_tiles@crnd@@3PAUcrnd_encoding_tile_indices@1@A")]
[DemangledName("struct crnd::crnd_encoding_tile_indices *crnd::g_crnd_chunk_encoding_tiles")]
internal static partial class g_crnd_chunk_encoding_tiles
{
	public unsafe static InlineArray_8_s73yuvc* __pointer;

	public unsafe static InlineArray_8_s73yuvc Value
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

	unsafe static g_crnd_chunk_encoding_tiles()
	{
		__pointer = unchecked((InlineArray_8_s73yuvc*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_8_s73yuvc))));
		Value = new InlineArrayBuilder<InlineArray_8_s73yuvc, crnd_crnd_encoding_tile_indices>
		{
			default(crnd_crnd_encoding_tile_indices),
			new crnd_crnd_encoding_tile_indices
			{
				field_0 = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 0, 0, 1, 1 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				field_0 = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 0, 1, 0, 1 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				field_0 = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 0, 0, 1, 2 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				field_0 = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 1, 2, 0, 0 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				field_0 = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 0, 1, 0, 2 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				field_0 = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 1, 0, 2, 0 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				field_0 = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 0, 1, 2, 3 })
			}
		};
	}
}
