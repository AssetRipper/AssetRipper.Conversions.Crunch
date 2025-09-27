using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_crnd_chunk_encoding_tiles@crnd@@3PAUcrnd_encoding_tile_indices@1@A")]
[DemangledName("struct crnd::crnd_encoding_tile_indices *crnd::g_crnd_chunk_encoding_tiles")]
internal static partial class g_crnd_chunk_encoding_tiles
{
	public unsafe static InlineArray8_crnd_crnd_encoding_tile_indices* __pointer;

	public unsafe static InlineArray8_crnd_crnd_encoding_tile_indices Value
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
		__pointer = unchecked((InlineArray8_crnd_crnd_encoding_tile_indices*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray8_crnd_crnd_encoding_tile_indices))));
		Value = new InlineArrayBuilder<InlineArray8_crnd_crnd_encoding_tile_indices, crnd_crnd_encoding_tile_indices>
		{
			default(crnd_crnd_encoding_tile_indices),
			new crnd_crnd_encoding_tile_indices
			{
				m_tiles = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 0, 0, 1, 1 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				m_tiles = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 0, 1, 0, 1 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				m_tiles = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 0, 0, 1, 2 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				m_tiles = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 1, 2, 0, 0 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				m_tiles = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 0, 1, 0, 2 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				m_tiles = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 1, 0, 2, 0 })
			},
			new crnd_crnd_encoding_tile_indices
			{
				m_tiles = InlineArrayHelper.Create<InlineArray4_SByte, byte>(new byte[4] { 0, 1, 2, 3 })
			}
		};
	}
}
