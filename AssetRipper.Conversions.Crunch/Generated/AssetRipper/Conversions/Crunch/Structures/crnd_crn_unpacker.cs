using System.Runtime.InteropServices;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;

namespace AssetRipper.Conversions.Crunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 440)]
[MangledName("class.crnd::crn_unpacker")]
public partial struct crnd_crn_unpacker
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(8)]
	public unsafe void* field_1;

	[FieldOffset(16)]
	public int field_2;

	[FieldOffset(20)]
	public crnd_crn_header field_3;

	[FieldOffset(96)]
	public unsafe void* field_4;

	[FieldOffset(104)]
	public crnd_symbol_codec field_5;

	[FieldOffset(144)]
	public crnd_static_huffman_data_model field_6;

	[FieldOffset(184)]
	public InlineArray_2_h3ee4zc field_7;

	[FieldOffset(264)]
	public InlineArray_2_h3ee4zc field_8;

	[FieldOffset(344)]
	public crnd_vector_5 field_9;

	[FieldOffset(368)]
	public crnd_vector_5 field_10;

	[FieldOffset(392)]
	public crnd_vector_8 field_11;

	[FieldOffset(416)]
	public crnd_vector_8 field_12;
}
