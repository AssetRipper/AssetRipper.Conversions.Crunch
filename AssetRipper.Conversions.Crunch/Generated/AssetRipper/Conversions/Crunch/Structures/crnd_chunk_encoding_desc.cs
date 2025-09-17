using System.Runtime.InteropServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 84)]
[MangledName("struct.crnd::chunk_encoding_desc")]
public partial struct crnd_chunk_encoding_desc
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public InlineArray_4_pfnb5sb field_1;
}
