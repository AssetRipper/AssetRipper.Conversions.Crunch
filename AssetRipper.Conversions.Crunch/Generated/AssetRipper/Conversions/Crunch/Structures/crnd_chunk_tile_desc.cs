using System.Runtime.InteropServices;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 20)]
[MangledName("struct.crnd::chunk_tile_desc")]
[DemangledName("crnd::chunk_tile_desc")]
public partial struct crnd_chunk_tile_desc
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public int field_1;

	[FieldOffset(8)]
	public int field_2;

	[FieldOffset(12)]
	public int field_3;

	[FieldOffset(16)]
	public int field_4;
}
