using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?crnd_unpack_level_segmented@crnd@@YA_NPEAXPEBXIPEAPEAXIII@Z")]
[DemangledName("bool __cdecl crnd::crnd_unpack_level_segmented(void *, void const *, unsigned int, void **, unsigned int, unsigned int, unsigned int)")]
internal static partial class crnd_unpack_level_segmented
{
	public unsafe static bool Invoke(void* pContext, void* pSrc, int src_size_in_bytes, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int level_index)
	{
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		void* ptr = null;
		int num4 = 0;
		void* ptr2 = null;
		void* ptr3 = null;
		void* ptr4 = null;
		num = level_index;
		num2 = row_pitch_in_bytes;
		num3 = dst_size_in_bytes;
		ptr = pDst;
		num4 = src_size_in_bytes;
		ptr2 = pSrc;
		ptr3 = pContext;
		if (unchecked(ptr3 == null || ptr2 == null || ptr == null || (uint)num3 < 8u || (uint)num >= 16u))
		{
			return false;
		}
		ptr4 = ptr3;
		if (!is_valid.Invoke(ptr4))
		{
			return false;
		}
		return unpack_level_zjb72ec.Invoke(ptr4, ptr2, num4, ptr, num3, num2, num);
	}
}
