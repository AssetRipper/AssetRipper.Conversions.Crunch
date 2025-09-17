using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_dxt5@crn_unpacker@crnd@@AEAA_NPEAPEAEIIIIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxt5(unsigned char **, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxt5
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
		int num15 = 0;
		int num16 = 0;
		void* ptr2 = null;
		int num17 = 0;
		int num18 = 0;
		int num19 = 0;
		int num20 = 0;
		int num21 = 0;
		void* ptr3 = null;
		sbyte b = 0;
		int num22 = 0;
		InlineArray_4_vqkfj7a inlineArray_4_vqkfj7a = default(InlineArray_4_vqkfj7a);
		InlineArray_4_vqkfj7a inlineArray_4_vqkfj7a2 = default(InlineArray_4_vqkfj7a);
		int num23 = 0;
		int num24 = 0;
		void* ptr4 = null;
		sbyte b2 = 0;
		void* ptr5 = null;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		int num29 = 0;
		int num30 = 0;
		int num31 = 0;
		int num32 = 0;
		int num33 = 0;
		void* ptr6 = null;
		num = chunks_y;
		num2 = chunks_x;
		num3 = blocks_y;
		num4 = blocks_x;
		num5 = row_pitch_in_bytes;
		ptr = pDst;
		num6 = 1;
		unchecked
		{
			num7 = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_9);
			num8 = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			num9 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
			num10 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_17.field_2);
			num11 = 0;
			num12 = 0;
			num13 = 0;
			num14 = 0;
			num15 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_8);
			for (num16 = 0; (uint)num16 < (uint)num15; num16++)
			{
				ptr2 = ((void**)ptr)[(uint)num16];
				for (num17 = 0; (uint)num17 < (uint)num; num17++)
				{
					num18 = 0;
					num19 = num2;
					num20 = 1;
					num21 = 32;
					ptr3 = ptr2;
					if ((num17 & 1) != 0)
					{
						num18 = num2 - 1;
						num19 = -1;
						num20 = -1;
						num21 = -32;
						ptr3 = (byte*)ptr3 + (uint)((num2 - 1) * 16 * 2);
					}
					b = ((num17 == num - 1 && (num3 & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
					for (num22 = num18; num22 != num19; num22 = checked(num22 + num20))
					{
						if (num6 == 1)
						{
							num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_6) | 0x200;
						}
						num23 = num6 & 7;
						num6 >>>= 3;
						num24 = (byte)((sbyte*)g_crnd_chunk_encoding_num_tiles.__pointer)[(uint)num23];
						ptr4 = &((crnd_crnd_encoding_tile_indices*)g_crnd_chunk_encoding_tiles.__pointer)[(uint)num23].field_0;
						b2 = (((num4 & 1) != 0 && num22 == checked(num2 - 1)) ? ((sbyte)1) : ((sbyte)0));
						ptr5 = ptr3;
						for (num25 = 0; (uint)num25 < (uint)num24; num25++)
						{
							num26 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
							num13 += num26;
							limit.Invoke(&num13, num9);
							Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a2, (nint)(uint)num25 * (nint)4)) = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num13));
						}
						for (num27 = 0; (uint)num27 < (uint)num24; num27++)
						{
							num28 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_7);
							num11 += num28;
							limit.Invoke(&num11, num7);
							Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(uint)num27 * (nint)4)) = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, num11);
						}
						ptr5 = ptr3;
						for (num29 = 0; (uint)num29 < 2u; num29++)
						{
							num30 = 0;
							while ((uint)num30 < 2u)
							{
								num31 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_8) + sizeof(crnd_static_huffman_data_model));
								num14 += num31;
								limit.Invoke(&num14, num10);
								num32 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_8);
								num12 += num32;
								limit.Invoke(&num12, num8);
								if ((num30 == 0 || (b2 & 1) != 1) && (num29 == 0 || (b & 1) != 1))
								{
									num33 = (byte)((sbyte*)ptr4)[(uint)(num30 + num29 * 2)];
									ptr6 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num14 * 3);
									*(int*)ptr5 = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a2, (nint)(uint)num33 * (nint)4)) | ((ushort)(*(short*)ptr6) << 16);
									((int*)ptr5)[1] = (ushort)((short*)ptr6)[1] | ((ushort)((short*)ptr6)[2] << 16);
									((int*)ptr5)[2] = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(uint)num33 * (nint)4));
									((int*)ptr5)[3] = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num12);
								}
								num30++;
								ptr5 = (byte*)ptr5 + 16;
							}
							ptr5 = (byte*)ptr5 + -32 + (uint)num5;
						}
						ptr3 = (byte*)ptr3 + num21;
					}
					ptr2 = (byte*)ptr2 + (uint)(num5 * 2);
				}
			}
			return true;
		}
	}
}
