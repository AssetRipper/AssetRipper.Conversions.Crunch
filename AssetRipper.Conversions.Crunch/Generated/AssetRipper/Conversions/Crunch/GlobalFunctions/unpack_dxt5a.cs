using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_dxt5a@crn_unpacker@crnd@@AEAA_NPEAPEAEIIIIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxt5a(unsigned char **, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxt5a
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
		void* ptr2 = null;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		void* ptr3 = null;
		sbyte b = 0;
		int num18 = 0;
		InlineArray_4_vqkfj7a inlineArray_4_vqkfj7a = default(InlineArray_4_vqkfj7a);
		int num19 = 0;
		int num20 = 0;
		void* ptr4 = null;
		sbyte b2 = 0;
		void* ptr5 = null;
		int num21 = 0;
		int num22 = 0;
		int num23 = 0;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
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
			num7 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
			num8 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_17.field_2);
			num9 = 0;
			num10 = 0;
			num11 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_8);
			for (num12 = 0; (uint)num12 < (uint)num11; num12++)
			{
				ptr2 = ((void**)ptr)[(uint)num12];
				for (num13 = 0; (uint)num13 < (uint)num; num13++)
				{
					num14 = 0;
					num15 = num2;
					num16 = 1;
					num17 = 16;
					ptr3 = ptr2;
					if ((num13 & 1) != 0)
					{
						num14 = num2 - 1;
						num15 = -1;
						num16 = -1;
						num17 = -16;
						ptr3 = (byte*)ptr3 + (uint)((num2 - 1) * 8 * 2);
					}
					b = ((num13 == num - 1 && (num3 & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
					for (num18 = num14; num18 != num15; num18 = checked(num18 + num16))
					{
						if (num6 == 1)
						{
							num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_6) | 0x200;
						}
						num19 = num6 & 7;
						num6 >>>= 3;
						num20 = (byte)((sbyte*)g_crnd_chunk_encoding_num_tiles.__pointer)[(uint)num19];
						ptr4 = &((crnd_crnd_encoding_tile_indices*)g_crnd_chunk_encoding_tiles.__pointer)[(uint)num19].field_0;
						b2 = (((num4 & 1) != 0 && num18 == checked(num2 - 1)) ? ((sbyte)1) : ((sbyte)0));
						ptr5 = ptr3;
						for (num21 = 0; (uint)num21 < (uint)num20; num21++)
						{
							num22 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
							num9 += num22;
							limit.Invoke(&num9, num7);
							Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(uint)num21 * (nint)4)) = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num9));
						}
						ptr5 = ptr3;
						for (num23 = 0; (uint)num23 < 2u; num23++)
						{
							num24 = 0;
							while ((uint)num24 < 2u)
							{
								num25 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&((crnd_crn_unpacker*)@this)->field_8) + sizeof(crnd_static_huffman_data_model));
								num10 += num25;
								limit.Invoke(&num10, num8);
								if ((num24 == 0 || (b2 & 1) != 1) && (num23 == 0 || (b & 1) != 1))
								{
									num26 = (byte)((sbyte*)ptr4)[(uint)(num24 + num23 * 2)];
									ptr6 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num10 * 3);
									*(int*)ptr5 = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(uint)num26 * (nint)4)) | ((ushort)(*(short*)ptr6) << 16);
									((int*)ptr5)[1] = (ushort)((short*)ptr6)[1] | ((ushort)((short*)ptr6)[2] << 16);
								}
								num24++;
								ptr5 = (byte*)ptr5 + 8;
							}
							ptr5 = (byte*)ptr5 + -16 + (uint)num5;
						}
						ptr3 = (byte*)ptr3 + num17;
					}
					ptr2 = (byte*)ptr2 + (uint)(num5 * 2);
				}
			}
			return true;
		}
	}
}
