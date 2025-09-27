using System.Runtime.InteropServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 4)]
[MangledName("struct.crnd::crnd_encoding_tile_indices")]
[DemangledName("crnd::crnd_encoding_tile_indices")]
public partial struct crnd_crnd_encoding_tile_indices
{
	[FieldOffset(0)]
	public InlineArray4_SByte m_tiles;
}
