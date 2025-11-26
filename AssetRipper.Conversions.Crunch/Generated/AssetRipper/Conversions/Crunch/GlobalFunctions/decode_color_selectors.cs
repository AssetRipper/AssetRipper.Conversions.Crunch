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
		public crnd_static_huffman_data_model field_0;

		public InlineArray49_Int32 field_1;

		public InlineArray49_Int32 field_2;

		public InlineArray16_Int32 field_3;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		localsPointer->field_1 = default(InlineArray49_Int32);
		localsPointer->field_2 = default(InlineArray49_Int32);
		localsPointer->field_3 = default(InlineArray16_Int32);
		bool flag;
		unchecked
		{
			int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_selectors.m_num);
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_selectors.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_selectors.m_ofs)))
			{
				flag = false;
				goto IL_04bb;
			}
			static_huffman_data_model_Constructor_c98ih8.Invoke(&localsPointer->field_0);
			bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				if (!flag2)
				{
					flag = false;
					goto IL_0477;
				}
				int num2 = -3;
				int num3 = -3;
				for (int i = 0; (uint)i < 49u; i++)
				{
					((int*)(&localsPointer->field_1))[(uint)i] = num2;
					((int*)(&localsPointer->field_2))[(uint)i] = num3;
					checked
					{
						int num4 = num2 + 1;
						num2 = num4;
						if (num4 > 3)
						{
							num2 = -3;
							num3++;
						}
					}
				}
				zero_object_ra884z.Invoke(&localsPointer->field_3);
				if (ExceptionInfo.Current == null)
				{
					bool flag3 = resize_dreg6y.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num);
					if (ExceptionInfo.Current == null)
					{
						if (!flag3)
						{
							flag = false;
						}
						else
						{
							void* ptr = vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, 0);
							if (ExceptionInfo.Current != null)
							{
								goto IL_048f;
							}
							void* ptr2 = ptr;
							void* _pointer = g_dxt1_from_linear.__pointer;
							for (int j = 0; (uint)j < (uint)num; j++)
							{
								int num5 = 0;
								while ((uint)num5 < 8u)
								{
									int num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
									if (ExceptionInfo.Current == null)
									{
										int num7 = num6;
										int num8 = (((int*)(&localsPointer->field_1))[num7] + ((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 0)]) & 3;
										((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 0)] = num8;
										int num9 = (((int*)(&localsPointer->field_2))[num7] + ((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 1)]) & 3;
										((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 1)] = num9;
										num5++;
										continue;
									}
									goto IL_048f;
								}
								int num10 = (byte)((sbyte*)_pointer)[(uint)(*(int*)(&localsPointer->field_3))] | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[1]] << 2) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[2]] << 4) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[3]] << 6) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[4]] << 8) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[5]] << 10) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[6]] << 12) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[7]] << 14) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[8]] << 16) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[9]] << 18) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[10]] << 20) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[11]] << 22) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[12]] << 24) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[13]] << 26) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[14]] << 28) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[15]] << 30);
								void* ptr3 = ptr2;
								ptr2 = (byte*)ptr3 + 4;
								*(int*)ptr3 = num10;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
							flag = true;
						}
						goto IL_0477;
					}
				}
			}
			goto IL_048f;
		}
		IL_04bb:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_048f:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		ExceptionInfo.Current = current;
		return false;
		IL_0477:
		static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		goto IL_04bb;
	}
}
