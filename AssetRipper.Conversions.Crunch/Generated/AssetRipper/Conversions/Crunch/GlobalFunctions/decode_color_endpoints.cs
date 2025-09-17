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
		public bool field_0;

		public int field_1;

		public InlineArray_2_h3ee4zc field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public int field_9;

		public int field_10;

		public unsafe void* field_11;

		public int field_12;

		public int field_13;

		public int field_14;

		public int field_15;

		public int field_16;

		public int field_17;

		public int field_18;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = default(InlineArray_2_h3ee4zc);
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_16 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_17 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_18 = 0;
		unchecked
		{
			int field_ = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_14.field_2);
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
			bool flag = resize_a3d3m5b.Invoke(&((crnd_crn_unpacker*)@this)->field_9, startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_5, buf_size: operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_14.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_14.field_0)))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				crnd_static_huffman_data_model* ptr = (crnd_static_huffman_data_model*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
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
						nint num = (nint)ptr3;
						while (true)
						{
							crnd_static_huffman_data_model* ptr5 = (crnd_static_huffman_data_model*)(num + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
							static_huffman_data_model_Destructor.Invoke(ptr5);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (ptr5 == ptr)
							{
								break;
							}
							num = (nint)ptr5;
						}
					}
					ExceptionInfo.Current = current;
					return false;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
				while (true)
				{
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3 < 2u)
					{
						crnd_symbol_codec* field_2 = &((crnd_crn_unpacker*)@this)->field_5;
						long num2 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3;
						bool flag2 = decode_receive_static_data_model.Invoke(field_2, (byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2) + (nint)num2 * sizeof(crnd_static_huffman_data_model));
						if (ExceptionInfo.Current == null)
						{
							if (!flag2)
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
								startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 1;
								break;
							}
							int field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_3 + 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_3;
							continue;
						}
					}
					else
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
						void* field_4 = Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, 0);
						if (ExceptionInfo.Current == null)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_4;
							startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
							while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_12 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1)
							{
								int field_5 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
								if (ExceptionInfo.Current == null)
								{
									startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_5;
									int field_6 = (startFrame.GetLocalsPointer<LocalVariables>()->field_5 + startFrame.GetLocalsPointer<LocalVariables>()->field_13) & 0x1F;
									startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_6;
									int field_7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2) + sizeof(crnd_static_huffman_data_model));
									if (ExceptionInfo.Current == null)
									{
										startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_7;
										int field_8 = (startFrame.GetLocalsPointer<LocalVariables>()->field_6 + startFrame.GetLocalsPointer<LocalVariables>()->field_14) & 0x3F;
										startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_8;
										int field_9 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
										if (ExceptionInfo.Current == null)
										{
											startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_9;
											int field_10 = (startFrame.GetLocalsPointer<LocalVariables>()->field_7 + startFrame.GetLocalsPointer<LocalVariables>()->field_15) & 0x1F;
											startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_10;
											int field_11 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
											if (ExceptionInfo.Current == null)
											{
												startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_11;
												int field_12 = (startFrame.GetLocalsPointer<LocalVariables>()->field_8 + startFrame.GetLocalsPointer<LocalVariables>()->field_16) & 0x1F;
												startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_12;
												int field_13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, (byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2) + sizeof(crnd_static_huffman_data_model));
												if (ExceptionInfo.Current == null)
												{
													startFrame.GetLocalsPointer<LocalVariables>()->field_17 = field_13;
													int field_14 = (startFrame.GetLocalsPointer<LocalVariables>()->field_9 + startFrame.GetLocalsPointer<LocalVariables>()->field_17) & 0x3F;
													startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_14;
													int field_15 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
													if (ExceptionInfo.Current == null)
													{
														startFrame.GetLocalsPointer<LocalVariables>()->field_18 = field_15;
														int field_16 = (startFrame.GetLocalsPointer<LocalVariables>()->field_10 + startFrame.GetLocalsPointer<LocalVariables>()->field_18) & 0x1F;
														startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_16;
														int num3 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 | (startFrame.GetLocalsPointer<LocalVariables>()->field_6 << 5) | (startFrame.GetLocalsPointer<LocalVariables>()->field_5 << 11) | (startFrame.GetLocalsPointer<LocalVariables>()->field_10 << 16) | (startFrame.GetLocalsPointer<LocalVariables>()->field_9 << 21) | (startFrame.GetLocalsPointer<LocalVariables>()->field_8 << 27);
														void* field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_11;
														startFrame.GetLocalsPointer<LocalVariables>()->field_11 = (byte*)field_17 + 4;
														*(int*)field_17 = num3;
														int field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_12 + 1;
														startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_18;
														continue;
													}
												}
											}
										}
									}
								}
								goto IL_078a;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_5);
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
							startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 1;
							break;
						}
					}
					goto IL_078a;
					IL_078a:
					ExceptionInfo current2 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					crnd_static_huffman_data_model* ptr6 = (crnd_static_huffman_data_model*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
					nint num4 = (nint)(ptr6 + 2L);
					while (true)
					{
						crnd_static_huffman_data_model* ptr7 = (crnd_static_huffman_data_model*)(num4 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr7);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (ptr7 == ptr6)
						{
							break;
						}
						num4 = (nint)ptr7;
					}
					ExceptionInfo.Current = current2;
					return false;
				}
				crnd_static_huffman_data_model* ptr8 = (crnd_static_huffman_data_model*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
				nint num5 = (nint)(ptr8 + 2L);
				while (true)
				{
					crnd_static_huffman_data_model* ptr9 = (crnd_static_huffman_data_model*)(num5 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
					static_huffman_data_model_Destructor.Invoke(ptr9);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (ptr9 != ptr8)
					{
						num5 = (nint)ptr9;
						continue;
					}
					break;
				}
			}
			bool field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_19;
		}
	}
}
