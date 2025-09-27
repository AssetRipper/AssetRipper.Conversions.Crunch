using System.Runtime.InteropServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 440)]
[MangledName("class.crnd::crn_unpacker")]
[DemangledName("crnd::crn_unpacker")]
public partial struct crnd_crn_unpacker
{
	[FieldOffset(0)]
	public int m_magic;

	[FieldOffset(8)]
	public unsafe void* m_pData;

	[FieldOffset(16)]
	public int m_data_size;

	[FieldOffset(20)]
	public crnd_crn_header m_tmp_header;

	[FieldOffset(96)]
	public unsafe void* m_pHeader;

	[FieldOffset(104)]
	public crnd_symbol_codec m_codec;

	[FieldOffset(144)]
	public crnd_static_huffman_data_model m_chunk_encoding_dm;

	[FieldOffset(184)]
	public InlineArray2_crnd_static_huffman_data_model m_endpoint_delta_dm;

	[FieldOffset(264)]
	public InlineArray2_crnd_static_huffman_data_model m_selector_delta_dm;

	[FieldOffset(344)]
	public crnd_vector_maaktjc m_color_endpoints;

	[FieldOffset(368)]
	public crnd_vector_maaktjc m_color_selectors;

	[FieldOffset(392)]
	public crnd_vector_rf9iywd m_alpha_endpoints;

	[FieldOffset(416)]
	public crnd_vector_rf9iywd m_alpha_selectors;
}
