using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_dxt1@crn_unpacker@crnd@@AEAA_NPEAPEAEIIIIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxt1(unsigned char **, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxt1
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
		void* ptr2 = null;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		void* ptr3 = null;
		sbyte b = 0;
		int num19 = 0;
		InlineArray_4_vqkfj7a inlineArray_4_vqkfj7a = default(InlineArray_4_vqkfj7a);
		int num20 = 0;
		int num21 = 0;
		int num22 = 0;
		int num23 = 0;
		void* ptr4 = null;
		sbyte b2 = 0;
		void* ptr5 = null;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		int num28 = 0;
		int num29 = 0;
		int num30 = 0;
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
			num9 = 0;
			num10 = 0;
			num11 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_8);
			num12 = num5 >>> 2;
			for (num13 = 0; (uint)num13 < (uint)num11; num13++)
			{
				ptr2 = ((void**)ptr)[(uint)num13];
				for (num14 = 0; (uint)num14 < (uint)num; num14++)
				{
					num15 = 0;
					num16 = num2;
					num17 = 1;
					num18 = 16;
					ptr3 = ptr2;
					if ((num14 & 1) != 0)
					{
						num15 = num2 - 1;
						num16 = -1;
						num17 = -1;
						num18 = -16;
						ptr3 = (byte*)ptr3 + (uint)((num2 - 1) * 8 * 2);
					}
					b = ((num14 == num - 1 && (num3 & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
					for (num19 = num15; num19 != num16; num19 = checked(num19 + num17))
					{
						if (num6 == 1)
						{
							num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_6) | 0x200;
						}
						num20 = num6 & 7;
						num6 >>>= 3;
						num21 = (byte)((sbyte*)g_crnd_chunk_encoding_num_tiles.__pointer)[(uint)num20];
						for (num22 = 0; (uint)num22 < (uint)num21; num22++)
						{
							num23 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_7);
							num9 += num23;
							limit.Invoke(&num9, num7);
							Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(uint)num22 * (nint)4)) = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, num9);
						}
						ptr4 = &((crnd_crnd_encoding_tile_indices*)g_crnd_chunk_encoding_tiles.__pointer)[(uint)num20].field_0;
						b2 = (((num4 & 1) != 0 && num19 == checked(num2 - 1)) ? ((sbyte)1) : ((sbyte)0));
						ptr5 = ptr3;
						if ((b & 1) != 1 && (b2 & 1) != 1)
						{
							*(int*)ptr5 = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(byte)(*(sbyte*)ptr4) * (nint)4));
							num24 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_8);
							num10 += num24;
							limit.Invoke(&num10, num8);
							((int*)ptr5)[1] = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num10);
							((int*)ptr5)[2] = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(byte)((sbyte*)ptr4)[1] * (nint)4));
							num25 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_8);
							num10 += num25;
							limit.Invoke(&num10, num8);
							((int*)ptr5)[3] = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num10);
							((int*)ptr5)[(uint)(0 + num12)] = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(byte)((sbyte*)ptr4)[2] * (nint)4));
							num26 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_8);
							num10 += num26;
							limit.Invoke(&num10, num8);
							((int*)ptr5)[(uint)(1 + num12)] = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num10);
							((int*)ptr5)[(uint)(2 + num12)] = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(byte)((sbyte*)ptr4)[3] * (nint)4));
							num27 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_8);
							num10 += num27;
							limit.Invoke(&num10, num8);
							((int*)ptr5)[(uint)(3 + num12)] = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num10);
						}
						else
						{
							for (num28 = 0; (uint)num28 < 2u; num28++)
							{
								ptr5 = (byte*)ptr3 + (uint)(num5 * num28);
								num29 = 0;
								while ((uint)num29 < 2u)
								{
									num30 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &((crnd_crn_unpacker*)@this)->field_8);
									num10 += num30;
									limit.Invoke(&num10, num8);
									if ((num29 == 0 || (b2 & 1) != 1) && (num28 == 0 || (b & 1) != 1))
									{
										*(int*)ptr5 = Unsafe.As<InlineArray_4_vqkfj7a, int>(ref Unsafe.AddByteOffset(ref inlineArray_4_vqkfj7a, (nint)(byte)((sbyte*)ptr4)[(uint)(num29 + num28 * 2)] * (nint)4));
										((int*)ptr5)[1] = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num10);
									}
									num29++;
									ptr5 = (byte*)ptr5 + 8;
								}
							}
						}
						ptr3 = (byte*)ptr3 + num18;
					}
					ptr2 = (byte*)ptr2 + (uint)(num5 * 2);
				}
			}
			return true;
		}
	}
}
