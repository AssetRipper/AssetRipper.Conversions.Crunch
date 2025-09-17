using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_dxn@crn_unpacker@crnd@@AEAA_NPEAPEAEIIIIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxn(unsigned char **, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxn
{
	public unsafe static bool Invoke(void* @this, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int blocks_x, int blocks_y, int chunks_x, int chunks_y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		void* ptr = null;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		void* ptr2 = null;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		int num19 = 0;
		void* ptr3 = null;
		sbyte b = 0;
		int num20 = 0;
		InlineArray_4_vqkfj7a inlineArray_4_vqkfj7a = default(InlineArray_4_vqkfj7a);
		InlineArray_4_vqkfj7a inlineArray_4_vqkfj7a2 = default(InlineArray_4_vqkfj7a);
		int num21 = 0;
		int num22 = 0;
		void* ptr4 = null;
		sbyte b2 = 0;
		void* ptr5 = null;
		int num23 = 0;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		int num29 = 0;
		int num30 = 0;
		int num31 = 0;
		void* ptr6 = null;
		void* ptr7 = null;
		num = chunks_y;
		num2 = chunks_x;
		num3 = blocks_y;
		num4 = blocks_x;
		num5 = row_pitch_in_bytes;
		ptr = pDst;
		num6 = 1;
		unchecked
		{
			num7 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
			num8 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_17.field_2);
			num9 = 0;
			num10 = 0;
			num11 = 0;
			num12 = 0;
			num13 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_8);
			for (num14 = 0; (uint)num14 < (uint)num13; num14++)
			{
				ptr2 = ((void**)ptr)[(uint)num14];
				for (num15 = 0; (uint)num15 < (uint)num; num15++)
				{
					num16 = 0;
					num17 = num2;
					num18 = 1;
					num19 = 32;
					ptr3 = ptr2;
					if ((num15 & 1) != 0)
					{
						num16 = num2 - 1;
						num17 = -1;
						num18 = -1;
						num19 = -32;
						ptr3 = (byte*)ptr3 + (uint)((num2 - 1) * 16 * 2);
					}
					b = ((num15 == num - 1 && (num3 & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
					for (num20 = num16; num20 != num17; num20 = checked(num20 + num18))
					{
						if (num6 == 1)
						{
							num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_6) | 0x200;
						}
						num21 = num6 & 7;
						num6 >>>= 3;
						num22 = (byte)((sbyte*)g_crnd_chunk_encoding_num_tiles.__pointer)[(uint)num21];
						ptr4 = &((crnd_crnd_encoding_tile_indices*)g_crnd_chunk_encoding_tiles.__pointer)[(uint)num21].field_0;
						b2 = (((num4 & 1) != 0 && num20 == checked(num2 - 1)) ? ((sbyte)1) : ((sbyte)0));
						ptr5 = ptr3;
						for (num23 = 0; (uint)num23 < (uint)num22; num23++)
						{
							num24 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
							num9 += num24;
							limit.Invoke(&num9, num7);
							Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(uint)num23 * (nint)4)) = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num9));
						}
						for (num25 = 0; (uint)num25 < (uint)num22; num25++)
						{
							num26 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
							num11 += num26;
							limit.Invoke(&num11, num7);
							Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a2, (nint)(uint)num25 * (nint)4)) = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num11));
						}
						ptr5 = ptr3;
						for (num27 = 0; (uint)num27 < 2u; num27++)
						{
							num28 = 0;
							while ((uint)num28 < 2u)
							{
								num29 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_8) + sizeof(crnd_static_huffman_data_model));
								num10 += num29;
								limit.Invoke(&num10, num8);
								num30 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_8) + sizeof(crnd_static_huffman_data_model));
								num12 += num30;
								limit.Invoke(&num12, num8);
								if ((num28 == 0 || (b2 & 1) != 1) && (num27 == 0 || (b & 1) != 1))
								{
									num31 = (byte)((sbyte*)ptr4)[(uint)(num28 + num27 * 2)];
									ptr6 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num10 * 3);
									ptr7 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num12 * 3);
									*(int*)ptr5 = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(uint)num31 * (nint)4)) | ((ushort)(*(short*)ptr6) << 16);
									((int*)ptr5)[1] = (ushort)((short*)ptr6)[1] | ((ushort)((short*)ptr6)[2] << 16);
									((int*)ptr5)[2] = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a2, (nint)(uint)num31 * (nint)4)) | ((ushort)(*(short*)ptr7) << 16);
									((int*)ptr5)[3] = (ushort)((short*)ptr7)[1] | ((ushort)((short*)ptr7)[2] << 16);
								}
								num28++;
								ptr5 = (byte*)ptr5 + 16;
							}
							ptr5 = (byte*)ptr5 + -32 + (uint)num5;
						}
						ptr3 = (byte*)ptr3 + num19;
					}
					ptr2 = (byte*)ptr2 + (uint)(num5 * 2);
				}
			}
			return true;
		}
	}
}
