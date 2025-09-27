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
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int blocks_x, [NativeType("unsigned int")] int blocks_y, [NativeType("unsigned int")] int chunks_x, [NativeType("unsigned int")] int chunks_y)
	{
		int num = 0;
		int num2 = 0;
		InlineArray4_Int32 inlineArray4_Int = default(InlineArray4_Int32);
		int num3 = 1;
		unchecked
		{
			int n = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints);
			int n2 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_num);
			num = 0;
			num2 = 0;
			int num4 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_faces);
			for (int i = 0; (uint)i < (uint)num4; i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				for (int j = 0; (uint)j < (uint)chunks_y; j++)
				{
					int num5 = 0;
					int num6 = chunks_x;
					int num7 = 1;
					int num8 = 16;
					void* ptr2 = ptr;
					if ((j & 1) != 0)
					{
						num5 = chunks_x - 1;
						num6 = -1;
						num7 = -1;
						num8 = -16;
						ptr2 = (byte*)ptr2 + (uint)((chunks_x - 1) * 8 * 2);
					}
					sbyte b = ((j == chunks_y - 1 && (blocks_y & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
					for (int k = num5; k != num6; k = checked(k + num7))
					{
						if (num3 == 1)
						{
							num3 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_chunk_encoding_dm) | 0x200;
						}
						int num9 = num3 & 7;
						num3 >>>= 3;
						int num10 = (byte)((sbyte*)g_crnd_chunk_encoding_num_tiles.__pointer)[(uint)num9];
						void* tiles = &((crnd_crnd_encoding_tile_indices*)g_crnd_chunk_encoding_tiles.__pointer)[(uint)num9].m_tiles;
						sbyte b2 = (((blocks_x & 1) != 0 && k == checked(chunks_x - 1)) ? ((sbyte)1) : ((sbyte)0));
						for (int l = 0; (uint)l < (uint)num10; l++)
						{
							int num11 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm) + sizeof(crnd_static_huffman_data_model));
							num += num11;
							limit.Invoke(&num, n);
							Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(uint)l * (nint)4)) = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, num));
						}
						void* ptr3 = ptr2;
						for (int m = 0; (uint)m < 2u; m++)
						{
							int num12 = 0;
							while ((uint)num12 < 2u)
							{
								int num13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_selector_delta_dm) + sizeof(crnd_static_huffman_data_model));
								num2 += num13;
								limit.Invoke(&num2, n2);
								if ((num12 == 0 || (b2 & 1) != 1) && (m == 0 || (b & 1) != 1))
								{
									int num14 = (byte)((sbyte*)tiles)[(uint)(num12 + m * 2)];
									void* ptr4 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors, num2 * 3);
									*(int*)ptr3 = Unsafe.As<InlineArray4_Int32, int>(ref Unsafe.AddByteOffset(ref inlineArray4_Int, (nint)(uint)num14 * (nint)4)) | ((ushort)(*(short*)ptr4) << 16);
									((int*)ptr3)[1] = (ushort)((short*)ptr4)[1] | ((ushort)((short*)ptr4)[2] << 16);
								}
								num12++;
								ptr3 = (byte*)ptr3 + 8;
							}
							ptr3 = (byte*)ptr3 + -16 + (uint)row_pitch_in_bytes;
						}
						ptr2 = (byte*)ptr2 + num8;
					}
					ptr = (byte*)ptr + (uint)(row_pitch_in_bytes * 2);
				}
			}
			return true;
		}
	}
}
