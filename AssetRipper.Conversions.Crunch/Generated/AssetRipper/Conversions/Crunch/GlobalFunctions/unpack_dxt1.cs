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
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int blocks_x, [NativeType("unsigned int")] int blocks_y, [NativeType("unsigned int")] int chunks_x, [NativeType("unsigned int")] int chunks_y)
	{
		int num = 0;
		int num2 = 0;
		InlineArray4_Int32 inlineArray4_Int = default(InlineArray4_Int32);
		int num3 = 1;
		unchecked
		{
			int n = size_878nzu.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints);
			int n2 = size_878nzu.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors);
			num = 0;
			num2 = 0;
			int num4 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_faces);
			int num5 = row_pitch_in_bytes >>> 2;
			for (int i = 0; (uint)i < (uint)num4; i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				for (int j = 0; (uint)j < (uint)chunks_y; j++)
				{
					int num6 = 0;
					int num7 = chunks_x;
					int num8 = 1;
					int num9 = 16;
					void* ptr2 = ptr;
					if ((j & 1) != 0)
					{
						num6 = chunks_x - 1;
						num7 = -1;
						num8 = -1;
						num9 = -16;
						ptr2 = (byte*)ptr2 + (uint)((chunks_x - 1) * 8 * 2);
					}
					sbyte b = ((j == chunks_y - 1 && (blocks_y & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
					for (int k = num6; k != num7; k = checked(k + num8))
					{
						if (num3 == 1)
						{
							num3 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_chunk_encoding_dm) | 0x200;
						}
						int num10 = num3 & 7;
						num3 >>>= 3;
						int num11 = (byte)((sbyte*)g_crnd_chunk_encoding_num_tiles.__pointer)[(uint)num10];
						for (int l = 0; (uint)l < (uint)num11; l++)
						{
							int num12 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm);
							num += num12;
							limit.Invoke(&num, n);
							Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(uint)l * (nint)4)) = *(int*)vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, num);
						}
						void* tiles = &((crnd_crnd_encoding_tile_indices*)g_crnd_chunk_encoding_tiles.__pointer)[(uint)num10].m_tiles;
						sbyte b2 = (((blocks_x & 1) != 0 && k == checked(chunks_x - 1)) ? ((sbyte)1) : ((sbyte)0));
						void* ptr3 = ptr2;
						if ((b & 1) != 1 && (b2 & 1) != 1)
						{
							*(int*)ptr3 = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(byte)(*(sbyte*)tiles) * (nint)4));
							int num13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
							num2 += num13;
							limit.Invoke(&num2, n2);
							((int*)ptr3)[1] = *(int*)vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num2);
							((int*)ptr3)[2] = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(byte)((sbyte*)tiles)[1] * (nint)4));
							int num14 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
							num2 += num14;
							limit.Invoke(&num2, n2);
							((int*)ptr3)[3] = *(int*)vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num2);
							((int*)ptr3)[(uint)(0 + num5)] = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(byte)((sbyte*)tiles)[2] * (nint)4));
							int num15 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
							num2 += num15;
							limit.Invoke(&num2, n2);
							((int*)ptr3)[(uint)(1 + num5)] = *(int*)vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num2);
							((int*)ptr3)[(uint)(2 + num5)] = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(byte)((sbyte*)tiles)[3] * (nint)4));
							int num16 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
							num2 += num16;
							limit.Invoke(&num2, n2);
							((int*)ptr3)[(uint)(3 + num5)] = *(int*)vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num2);
						}
						else
						{
							for (int m = 0; (uint)m < 2u; m++)
							{
								ptr3 = (byte*)ptr2 + (uint)(row_pitch_in_bytes * m);
								int num17 = 0;
								while ((uint)num17 < 2u)
								{
									int num18 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
									num2 += num18;
									limit.Invoke(&num2, n2);
									if ((num17 == 0 || (b2 & 1) != 1) && (m == 0 || (b & 1) != 1))
									{
										*(int*)ptr3 = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(byte)((sbyte*)tiles)[(uint)(num17 + m * 2)] * (nint)4));
										((int*)ptr3)[1] = *(int*)vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num2);
									}
									num17++;
									ptr3 = (byte*)ptr3 + 8;
								}
							}
						}
						ptr2 = (byte*)ptr2 + num9;
					}
					ptr = (byte*)ptr + (uint)(row_pitch_in_bytes * 2);
				}
			}
			return true;
		}
	}
}
