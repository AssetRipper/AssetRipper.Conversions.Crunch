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
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int blocks_x, [NativeType("unsigned int")] int blocks_y, [NativeType("unsigned int")] int chunks_x, [NativeType("unsigned int")] int chunks_y)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		InlineArray4_Int32 inlineArray4_Int = default(InlineArray4_Int32);
		InlineArray4_Int32 inlineArray4_Int2 = default(InlineArray4_Int32);
		int num5 = 1;
		unchecked
		{
			int n = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints);
			int n2 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_num);
			num = 0;
			num2 = 0;
			num3 = 0;
			num4 = 0;
			int num6 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_faces);
			for (int i = 0; (uint)i < (uint)num6; i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				for (int j = 0; (uint)j < (uint)chunks_y; j++)
				{
					int num7 = 0;
					int num8 = chunks_x;
					int num9 = 1;
					int num10 = 32;
					void* ptr2 = ptr;
					if ((j & 1) != 0)
					{
						num7 = chunks_x - 1;
						num8 = -1;
						num9 = -1;
						num10 = -32;
						ptr2 = (byte*)ptr2 + (uint)((chunks_x - 1) * 16 * 2);
					}
					sbyte b = ((j == chunks_y - 1 && (blocks_y & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
					for (int k = num7; k != num8; k = checked(k + num9))
					{
						if (num5 == 1)
						{
							num5 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_chunk_encoding_dm) | 0x200;
						}
						int num11 = num5 & 7;
						num5 >>>= 3;
						int num12 = (byte)((sbyte*)g_crnd_chunk_encoding_num_tiles.__pointer)[(uint)num11];
						void* tiles = &((crnd_crnd_encoding_tile_indices*)g_crnd_chunk_encoding_tiles.__pointer)[(uint)num11].m_tiles;
						sbyte b2 = (((blocks_x & 1) != 0 && k == checked(chunks_x - 1)) ? ((sbyte)1) : ((sbyte)0));
						for (int l = 0; (uint)l < (uint)num12; l++)
						{
							int num13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm) + sizeof(crnd_static_huffman_data_model));
							num += num13;
							limit.Invoke(&num, n);
							Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(uint)l * (nint)4)) = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, num));
						}
						for (int m = 0; (uint)m < (uint)num12; m++)
						{
							int num14 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm) + sizeof(crnd_static_huffman_data_model));
							num3 += num14;
							limit.Invoke(&num3, n);
							Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int2, (nint)(uint)m * (nint)4)) = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, num3));
						}
						void* ptr3 = ptr2;
						for (int num15 = 0; (uint)num15 < 2u; num15++)
						{
							int num16 = 0;
							while ((uint)num16 < 2u)
							{
								int num17 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_selector_delta_dm) + sizeof(crnd_static_huffman_data_model));
								num2 += num17;
								limit.Invoke(&num2, n2);
								int num18 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_selector_delta_dm) + sizeof(crnd_static_huffman_data_model));
								num4 += num18;
								limit.Invoke(&num4, n2);
								if ((num16 == 0 || (b2 & 1) != 1) && (num15 == 0 || (b & 1) != 1))
								{
									int num19 = (byte)((sbyte*)tiles)[(uint)(num16 + num15 * 2)];
									void* ptr4 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors, num2 * 3);
									void* ptr5 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors, num4 * 3);
									*(int*)ptr3 = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(uint)num19 * (nint)4)) | ((ushort)(*(short*)ptr4) << 16);
									((int*)ptr3)[1] = (ushort)((short*)ptr4)[1] | ((ushort)((short*)ptr4)[2] << 16);
									((int*)ptr3)[2] = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int2, (nint)(uint)num19 * (nint)4)) | ((ushort)(*(short*)ptr5) << 16);
									((int*)ptr3)[3] = (ushort)((short*)ptr5)[1] | ((ushort)((short*)ptr5)[2] << 16);
								}
								num16++;
								ptr3 = (byte*)ptr3 + 16;
							}
							ptr3 = (byte*)ptr3 + -32 + (uint)row_pitch_in_bytes;
						}
						ptr2 = (byte*)ptr2 + num10;
					}
					ptr = (byte*)ptr + (uint)(row_pitch_in_bytes * 2);
				}
			}
			return true;
		}
	}
}
