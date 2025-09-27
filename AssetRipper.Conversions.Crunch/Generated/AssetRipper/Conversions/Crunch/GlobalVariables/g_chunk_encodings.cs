using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_chunk_encodings@crnd@@3PAUchunk_encoding_desc@1@A")]
[DemangledName("struct crnd::chunk_encoding_desc *crnd::g_chunk_encodings")]
internal static partial class g_chunk_encodings
{
	private static InlineArray8_crnd_chunk_encoding_desc __value;

	public static InlineArray8_crnd_chunk_encoding_desc Value
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

	static g_chunk_encodings()
	{
		Value = new InlineArrayBuilder<InlineArray8_crnd_chunk_encoding_desc, crnd_chunk_encoding_desc>
		{
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 1,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
					new crnd_chunk_tile_desc
					{
						m_x_ofs = 0,
						m_y_ofs = 0,
						m_width = 8,
						m_height = 8,
						m_layout_index = 0
					},
					default(crnd_chunk_tile_desc),
					default(crnd_chunk_tile_desc),
					default(crnd_chunk_tile_desc)
				}
			},
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 2,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
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
					default(crnd_chunk_tile_desc),
					default(crnd_chunk_tile_desc)
				}
			},
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 2,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
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
					default(crnd_chunk_tile_desc),
					default(crnd_chunk_tile_desc)
				}
			},
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 3,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
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
					},
					default(crnd_chunk_tile_desc)
				}
			},
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 3,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
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
					default(crnd_chunk_tile_desc)
				}
			},
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 3,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
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
						m_height = 4,
						m_layout_index = 6
					},
					new crnd_chunk_tile_desc
					{
						m_x_ofs = 4,
						m_y_ofs = 4,
						m_width = 4,
						m_height = 4,
						m_layout_index = 8
					},
					default(crnd_chunk_tile_desc)
				}
			},
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 3,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
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
						m_x_ofs = 0,
						m_y_ofs = 4,
						m_width = 4,
						m_height = 4,
						m_layout_index = 7
					},
					default(crnd_chunk_tile_desc)
				}
			},
			new crnd_chunk_encoding_desc
			{
				m_num_tiles = 4,
				m_tiles = new InlineArrayBuilder<InlineArray4_crnd_chunk_tile_desc, crnd_chunk_tile_desc>
				{
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
				}
			}
		};
	}
}
