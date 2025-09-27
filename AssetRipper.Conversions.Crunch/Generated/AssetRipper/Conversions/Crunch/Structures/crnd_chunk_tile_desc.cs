using System.Runtime.InteropServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 20)]
[MangledName("struct.crnd::chunk_tile_desc")]
[DemangledName("crnd::chunk_tile_desc")]
public partial struct crnd_chunk_tile_desc
{
	[FieldOffset(0)]
	public int m_x_ofs;

	[FieldOffset(4)]
	public int m_y_ofs;

	[FieldOffset(8)]
	public int m_width;

	[FieldOffset(12)]
	public int m_height;

	[FieldOffset(16)]
	public int m_layout_index;
}
