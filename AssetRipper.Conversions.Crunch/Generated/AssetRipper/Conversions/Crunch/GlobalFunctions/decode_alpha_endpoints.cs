using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?decode_alpha_endpoints@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_endpoints(void)")]
internal static partial class decode_alpha_endpoints
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		unchecked
		{
			int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_num);
			bool flag;
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_ofs)))
			{
				flag = false;
			}
			else
			{
				static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
				bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					goto IL_01e9;
				}
				if (!flag2)
				{
					flag = false;
				}
				else
				{
					bool flag3 = resize_w95s75a.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, num);
					if (ExceptionInfo.Current != null)
					{
						goto IL_01e9;
					}
					if (!flag3)
					{
						flag = false;
					}
					else
					{
						void* ptr = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, 0);
						if (ExceptionInfo.Current != null)
						{
							goto IL_01e9;
						}
						void* ptr2 = ptr;
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						while ((uint)num4 < (uint)num)
						{
							int num5 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
							if (ExceptionInfo.Current == null)
							{
								int num6 = num5;
								int num7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									int num8 = num7;
									num2 = (num6 + num2) & 0xFF;
									num3 = (num8 + num3) & 0xFF;
									short num9 = (short)(num2 | (num3 << 8));
									void* ptr3 = ptr2;
									ptr2 = (byte*)ptr3 + 2;
									*(short*)ptr3 = num9;
									num4++;
									continue;
								}
							}
							goto IL_01e9;
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
		IL_01e9:
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
