using System.Runtime.InteropServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 2)]
[MangledName("struct.crnd::crn_packed_uint")]
public partial struct crnd_crn_packed_uint
{
	[FieldOffset(0)]
	public InlineArray_2_w3otm9c field_0;
}
