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
				field_0 = 0,
				field_1 = 0,
				field_2 = 8,
				field_3 = 8,
				field_4 = 0
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 0,
				field_1 = 0,
				field_2 = 8,
				field_3 = 4,
				field_4 = 1
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 0,
				field_1 = 4,
				field_2 = 8,
				field_3 = 4,
				field_4 = 2
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 0,
				field_1 = 0,
				field_2 = 4,
				field_3 = 8,
				field_4 = 3
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 4,
				field_1 = 0,
				field_2 = 4,
				field_3 = 8,
				field_4 = 4
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 0,
				field_1 = 0,
				field_2 = 4,
				field_3 = 4,
				field_4 = 5
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 4,
				field_1 = 0,
				field_2 = 4,
				field_3 = 4,
				field_4 = 6
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 0,
				field_1 = 4,
				field_2 = 4,
				field_3 = 4,
				field_4 = 7
			},
			new crnd_chunk_tile_desc
			{
				field_0 = 4,
				field_1 = 4,
				field_2 = 4,
				field_3 = 4,
				field_4 = 8
			}
		};
	}
}
