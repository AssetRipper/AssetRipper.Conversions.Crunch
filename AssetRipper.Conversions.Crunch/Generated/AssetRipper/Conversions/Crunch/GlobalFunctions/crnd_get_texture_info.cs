using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?crnd_get_texture_info@crnd@@YA_NPEBXIPEAUcrn_texture_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_texture_info(void const *, unsigned int, struct crnd::crn_texture_info *)")]
internal static partial class crnd_get_texture_info
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size, [NativeType("struct crnd::crn_texture_info *")] void* pInfo)
	{
		crnd_crn_header crnd_crn_header = default(crnd_crn_header);
		unchecked
		{
			if (pData == null || (ulong)(uint)data_size < 74uL || pInfo == null)
			{
				return false;
			}
			if ((long)(uint)((crnd_crn_texture_info*)pInfo)->field_0 != 36L)
			{
				return false;
			}
			crn_header_Constructor.Invoke(&crnd_crn_header);
			void* ptr = crnd_get_header.Invoke(&crnd_crn_header, pData, data_size);
			if (ptr == null)
			{
				return false;
			}
			((crnd_crn_texture_info*)pInfo)->field_1 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_5);
			((crnd_crn_texture_info*)pInfo)->field_2 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_6);
			((crnd_crn_texture_info*)pInfo)->field_3 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_7);
			((crnd_crn_texture_info*)pInfo)->field_4 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_8);
			((crnd_crn_texture_info*)pInfo)->field_8 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9);
			((crnd_crn_texture_info*)pInfo)->field_5 = InstructionHelper.Select((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9) != 0) ? (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9) == 9) : true, 8, 16);
			((crnd_crn_texture_info*)pInfo)->field_6 = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_12);
			((crnd_crn_texture_info*)pInfo)->field_7 = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_13);
			return true;
		}
	}
}
