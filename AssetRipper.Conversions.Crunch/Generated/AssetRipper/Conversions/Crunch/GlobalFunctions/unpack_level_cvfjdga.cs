using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_level@crn_unpacker@crnd@@QEAA_NPEAPEAXIII@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::unpack_level(void **, unsigned int, unsigned int, unsigned int)")]
[CleanName("unpack_level")]
internal static partial class unpack_level_cvfjdga
{
	public unsafe static bool Invoke(void* @this, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int level_index)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		void* ptr = null;
		int num4 = 0;
		int num5 = 0;
		num = level_index;
		num2 = row_pitch_in_bytes;
		num3 = dst_size_in_bytes;
		ptr = pDst;
		unchecked
		{
			num4 = operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_20) + (nint)(uint)num * (nint)sizeof(crnd_crn_packed_uint_0));
			num5 = ((crnd_crn_unpacker*)@this)->field_2;
			if ((uint)(num + 1) < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_7))
			{
				num5 = operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_20) + (nint)(uint)(num + 1) * (nint)sizeof(crnd_crn_packed_uint_0));
			}
			int num6;
			if ((uint)num5 > (uint)num4)
			{
				num6 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_huvyfmc.__pointer, String_yguirrd.__pointer, 3694);
				num6 = 0;
			}
			return unpack_level_zjb72ec.Invoke(@this, (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)num4, num5 - num4, ptr, num3, num2, num);
		}
	}
}
