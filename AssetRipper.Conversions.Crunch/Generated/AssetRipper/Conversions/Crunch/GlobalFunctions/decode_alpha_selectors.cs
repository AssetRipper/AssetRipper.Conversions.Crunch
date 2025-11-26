using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?decode_alpha_selectors@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_selectors(void)")]
internal static partial class decode_alpha_selectors
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;

		public InlineArray225_Int32 field_1;

		public InlineArray225_Int32 field_2;

		public InlineArray16_Int32 field_3;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		localsPointer->field_1 = default(InlineArray225_Int32);
		localsPointer->field_2 = default(InlineArray225_Int32);
		localsPointer->field_3 = default(InlineArray16_Int32);
		unchecked
		{
			int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_num);
			bool flag;
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_ofs)))
			{
				flag = false;
			}
			else
			{
				static_huffman_data_model_Constructor_c98ih8.Invoke(&localsPointer->field_0);
				bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					goto IL_04d9;
				}
				if (!flag2)
				{
					flag = false;
				}
				else
				{
					int num2 = -7;
					int num3 = -7;
					for (int i = 0; (uint)i < 225u; i++)
					{
						((int*)(&localsPointer->field_1))[(uint)i] = num2;
						((int*)(&localsPointer->field_2))[(uint)i] = num3;
						checked
						{
							int num4 = num2 + 1;
							num2 = num4;
							if (num4 > 7)
							{
								num2 = -7;
								num3++;
							}
						}
					}
					zero_object_ra884z.Invoke(&localsPointer->field_3);
					bool flag3 = resize_9ubjj8.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors, num * 3);
					if (ExceptionInfo.Current != null)
					{
						goto IL_04d9;
					}
					if (!flag3)
					{
						flag = false;
					}
					else
					{
						void* ptr = vector_unsigned_short_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors, 0);
						if (ExceptionInfo.Current != null)
						{
							goto IL_04d9;
						}
						void* ptr2 = ptr;
						void* _pointer = g_dxt5_from_linear.__pointer;
						for (int j = 0; (uint)j < (uint)num; j++)
						{
							int num5 = 0;
							while ((uint)num5 < 8u)
							{
								int num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									int num7 = num6;
									int num8 = (((int*)(&localsPointer->field_1))[num7] + ((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 0)]) & 7;
									((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 0)] = num8;
									int num9 = (((int*)(&localsPointer->field_2))[num7] + ((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 1)]) & 7;
									((int*)(&localsPointer->field_3))[(uint)(num5 * 2 + 1)] = num9;
									num5++;
									continue;
								}
								goto IL_04d9;
							}
							short num10 = (short)((byte)((sbyte*)_pointer)[(uint)(*(int*)(&localsPointer->field_3))] | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[1]] << 3) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[2]] << 6) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[3]] << 9) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[4]] << 12) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[5]] << 15));
							void* ptr3 = ptr2;
							ptr2 = (byte*)ptr3 + 2;
							*(short*)ptr3 = num10;
							short num11 = (short)(((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[5]] >> 1) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[6]] << 2) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[7]] << 5) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[8]] << 8) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[9]] << 11) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[10]] << 14));
							void* ptr4 = ptr2;
							ptr2 = (byte*)ptr4 + 2;
							*(short*)ptr4 = num11;
							short num12 = (short)(((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[10]] >> 2) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[11]] << 1) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[12]] << 4) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[13]] << 7) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[14]] << 10) | ((byte)((sbyte*)_pointer)[(uint)((int*)(&localsPointer->field_3))[15]] << 13));
							void* ptr5 = ptr2;
							ptr2 = (byte*)ptr5 + 2;
							*(short*)ptr5 = num12;
						}
						stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
						flag = true;
					}
				}
				static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			bool result = flag;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
		IL_04d9:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		ExceptionInfo.Current = current;
		return false;
	}
}
