using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?crnd_unpack_level@crnd@@YA_NPEAXPEAPEAXIII@Z")]
[DemangledName("bool __cdecl crnd::crnd_unpack_level(void *, void **, unsigned int, unsigned int, unsigned int)")]
internal static partial class crnd_unpack_level
{
	public unsafe static bool Invoke(void* pContext, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int level_index)
	{
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		num = level_index;
		num2 = row_pitch_in_bytes;
		num3 = dst_size_in_bytes;
		ptr = pDst;
		ptr2 = pContext;
		if (unchecked(ptr2 == null || ptr == null || (uint)num3 < 8u || (uint)num >= 16u))
		{
			return false;
		}
		ptr3 = ptr2;
		if (!is_valid.Invoke(ptr3))
		{
			return false;
		}
		return unpack_level_cvfjdga.Invoke(ptr3, ptr, num3, num2, num);
	}
}
