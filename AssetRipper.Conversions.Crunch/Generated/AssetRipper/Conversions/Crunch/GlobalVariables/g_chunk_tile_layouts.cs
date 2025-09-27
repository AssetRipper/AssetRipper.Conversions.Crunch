using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_chunk_tile_layouts@crnd@@3PAUchunk_tile_desc@1@A")]
[DemangledName("struct crnd::chunk_tile_desc *crnd::g_chunk_tile_layouts")]
internal static partial class g_chunk_tile_layouts
{
	private static InlineArray9_crnd_chunk_tile_desc __value;

	public static InlineArray9_crnd_chunk_tile_desc Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	static g_chunk_tile_layouts()
	{
		Value = new InlineArrayBuilder<InlineArray9_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
		{
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 0,
				m_y_ofs = 0,
				m_width = 8,
				m_height = 8,
				m_layout_index = 0
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 0,
				m_y_ofs = 0,
				m_width = 8,
				m_height = 4,
				m_layout_index = 1
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 0,
				m_y_ofs = 4,
				m_width = 8,
				m_height = 4,
				m_layout_index = 2
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 0,
				m_y_ofs = 0,
				m_width = 4,
				m_height = 8,
				m_layout_index = 3
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 4,
				m_y_ofs = 0,
				m_width = 4,
				m_height = 8,
				m_layout_index = 4
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 0,
				m_y_ofs = 0,
				m_width = 4,
				m_height = 4,
				m_layout_index = 5
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 4,
				m_y_ofs = 0,
				m_width = 4,
				m_height = 4,
				m_layout_index = 6
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 0,
				m_y_ofs = 4,
				m_width = 4,
				m_height = 4,
				m_layout_index = 7
			},
			new crnd_chunk_tile_desc
			{
				m_x_ofs = 4,
				m_y_ofs = 4,
				m_width = 4,
				m_height = 4,
				m_layout_index = 8
			}
		};
	}
}
