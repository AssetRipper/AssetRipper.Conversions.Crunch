using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?decode_color_endpoints@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_color_endpoints(void)")]
internal static partial class decode_color_endpoints
{
	private partial struct LocalVariables
	{
		public InlineArray2_crnd_static_huffman_data_model field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray2_crnd_static_huffman_data_model);
		unchecked
		{
			int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_num);
			bool flag = resize_a3d3m5b.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, num);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag2;
			if (!flag)
			{
				flag2 = false;
			}
			else if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_ofs)))
			{
				flag2 = false;
			}
			else
			{
				crnd_static_huffman_data_model* ptr = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
				crnd_static_huffman_data_model* ptr2 = ptr + 2L;
				crnd_static_huffman_data_model* intPtr = ptr;
				while (true)
				{
					void* ptr3 = intPtr;
					static_huffman_data_model_Constructor_tl33idc.Invoke(ptr3);
					if (ExceptionInfo.Current == null)
					{
						crnd_static_huffman_data_model* ptr4 = (crnd_static_huffman_data_model*)ptr3 + 1;
						if (ptr4 == ptr2)
						{
							break;
						}
						intPtr = ptr4;
						continue;
					}
					ExceptionInfo current = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					if (ptr != ptr3)
					{
						nint num2 = (nint)ptr3;
						while (true)
						{
							crnd_static_huffman_data_model* ptr5 = (crnd_static_huffman_data_model*)(num2 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
							static_huffman_data_model_Destructor.Invoke(ptr5);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (ptr5 == ptr)
							{
								break;
							}
							num2 = (nint)ptr5;
						}
					}
					ExceptionInfo.Current = current;
					return false;
				}
				int num3 = 0;
				while (true)
				{
					if ((uint)num3 < 2u)
					{
						bool flag3 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&localsPointer->field_0) + (nint)(uint)num3 * (nint)sizeof(crnd_static_huffman_data_model));
						if (ExceptionInfo.Current == null)
						{
							if (!flag3)
							{
								flag2 = false;
								break;
							}
							num3++;
							continue;
						}
					}
					else
					{
						int num4 = 0;
						int num5 = 0;
						int num6 = 0;
						int num7 = 0;
						int num8 = 0;
						int num9 = 0;
						void* ptr6 = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, 0);
						if (ExceptionInfo.Current == null)
						{
							void* ptr7 = ptr6;
							int num10 = 0;
							while ((uint)num10 < (uint)num)
							{
								int num11 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									num4 = (num4 + num11) & 0x1F;
									int num12 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
									if (ExceptionInfo.Current == null)
									{
										num5 = (num5 + num12) & 0x3F;
										int num13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num6 = (num6 + num13) & 0x1F;
											int num14 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
											if (ExceptionInfo.Current == null)
											{
												num7 = (num7 + num14) & 0x1F;
												int num15 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
												if (ExceptionInfo.Current == null)
												{
													num8 = (num8 + num15) & 0x3F;
													int num16 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
													if (ExceptionInfo.Current == null)
													{
														num9 = (num9 + num16) & 0x1F;
														int num17 = num6 | (num5 << 5) | (num4 << 11) | (num9 << 16) | (num8 << 21) | (num7 << 27);
														void* ptr8 = ptr7;
														ptr7 = (byte*)ptr8 + 4;
														*(int*)ptr8 = num17;
														num10++;
														continue;
													}
												}
											}
										}
									}
								}
								goto IL_03e6;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
							flag2 = true;
							break;
						}
					}
					goto IL_03e6;
					IL_03e6:
					ExceptionInfo current2 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					crnd_static_huffman_data_model* ptr9 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
					nint num18 = (nint)(ptr9 + 2L);
					while (true)
					{
						crnd_static_huffman_data_model* ptr10 = (crnd_static_huffman_data_model*)(num18 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr10);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (ptr10 == ptr9)
						{
							break;
						}
						num18 = (nint)ptr10;
					}
					ExceptionInfo.Current = current2;
					return false;
				}
				crnd_static_huffman_data_model* ptr11 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
				nint num19 = (nint)(ptr11 + 2L);
				while (true)
				{
					crnd_static_huffman_data_model* ptr12 = (crnd_static_huffman_data_model*)(num19 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
					static_huffman_data_model_Destructor.Invoke(ptr12);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (ptr12 != ptr11)
					{
						num19 = (nint)ptr12;
						continue;
					}
					break;
				}
			}
			bool result = flag2;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
