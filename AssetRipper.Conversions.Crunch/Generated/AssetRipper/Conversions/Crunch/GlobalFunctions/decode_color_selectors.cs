using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?decode_color_selectors@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_color_selectors(void)")]
internal static partial class decode_color_selectors
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;

		public crnd_static_huffman_data_model field_2;

		public int field_3;

		public InlineArray_49_vqkfj7a field_4;

		public InlineArray_49_vqkfj7a field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public InlineArray_16_vqkfj7a field_9;

		public unsafe void* field_10;

		public unsafe void* field_11;

		public int field_12;

		public int field_13;

		public int field_14;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = default(crnd_static_huffman_data_model);
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = default(InlineArray_49_vqkfj7a);
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = default(InlineArray_49_vqkfj7a);
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = default(InlineArray_16_vqkfj7a);
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		unchecked
		{
			int field_ = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_15.field_2);
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_5, buf_size: operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_15.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_15.field_0)))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				goto IL_08b2;
			}
			static_huffman_data_model_Constructor_tl33idc.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			bool flag = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			if (ExceptionInfo.Current == null)
			{
				if (!flag)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
					startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 1;
					goto IL_0862;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_6 = -3;
				startFrame.GetLocalsPointer<LocalVariables>()->field_7 = -3;
				startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 < 49u)
				{
					int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_6;
					long num = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
					((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[num] = field_2;
					int field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_7;
					long num2 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
					((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num2] = field_3;
					checked
					{
						int num3 = startFrame.GetLocalsPointer<LocalVariables>()->field_6 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_6 = num3;
						if (num3 > 3)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_6 = -3;
							int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_4;
						}
					}
					int field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_5;
				}
				zero_object_vtkonjd.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_9);
				if (ExceptionInfo.Current == null)
				{
					bool flag2 = resize_a3d3m5b.Invoke(&((crnd_crn_unpacker*)@this)->field_10, startFrame.GetLocalsPointer<LocalVariables>()->field_1);
					if (ExceptionInfo.Current == null)
					{
						if (!flag2)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
							startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 1;
						}
						else
						{
							void* field_6 = Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_10, 0);
							if (ExceptionInfo.Current != null)
							{
								goto IL_0880;
							}
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_6;
							void* _pointer = g_dxt1_from_linear.__pointer;
							startFrame.GetLocalsPointer<LocalVariables>()->field_11 = _pointer;
							startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
							while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_12 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1)
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
								while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13 < 8u)
								{
									int field_7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_5, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
									if (ExceptionInfo.Current == null)
									{
										startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_7;
										long num4 = startFrame.GetLocalsPointer<LocalVariables>()->field_14;
										int num5 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[num4];
										long num6 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 * 2 + 0);
										int num7 = (num5 + ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[num6]) & 3;
										long num8 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 * 2 + 0);
										((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[num8] = num7;
										long num9 = startFrame.GetLocalsPointer<LocalVariables>()->field_14;
										int num10 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num9];
										long num11 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 * 2 + 1);
										int num12 = (num10 + ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[num11]) & 3;
										long num13 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 * 2 + 1);
										((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[num13] = num12;
										int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_13 + 1;
										startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_8;
										continue;
									}
									goto IL_0880;
								}
								int num14 = (byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)(*(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))] | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[1]] << 2) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[2]] << 4) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[3]] << 6) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[4]] << 8) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[5]] << 10) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[6]] << 12) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[7]] << 14) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[8]] << 16) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[9]] << 18) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[10]] << 20) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[11]] << 22) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[12]] << 24) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[13]] << 26) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[14]] << 28) | ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[(uint)((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_9))[15]] << 30);
								void* field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
								startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (byte*)field_9 + 4;
								*(int*)field_9 = num14;
								int field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_12 + 1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_10;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_5);
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
							startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 1;
						}
						goto IL_0862;
					}
				}
			}
			goto IL_0880;
		}
		IL_08b2:
		bool field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_11;
		IL_0880:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		ExceptionInfo.Current = current;
		return false;
		IL_0862:
		static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		goto IL_08b2;
	}
}
