using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_level@crn_unpacker@crnd@@QEAA_NPEBXIPEAPEAXIII@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::unpack_level(void const *, unsigned int, void **, unsigned int, unsigned int, unsigned int)")]
[CleanName("unpack_level")]
internal static partial class unpack_level_zjb72ec
{
	public unsafe static bool Invoke(void* @this, void* pSrc, int src_size_in_bytes, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int level_index)
	{
		bool flag = false;
		int num = 0;
		int num2 = 0;
		void* ptr = null;
		int num3 = 0;
		void* ptr2 = null;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		sbyte b = 0;
		num = row_pitch_in_bytes;
		num2 = dst_size_in_bytes;
		ptr = pDst;
		num3 = src_size_in_bytes;
		ptr2 = pSrc;
		unchecked
		{
			int num10 = maximum.Invoke(operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_5) >>> level_index, 1);
			int num11 = maximum.Invoke(operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_6) >>> level_index, 1);
			num4 = num10 + 3 >>> 2;
			num5 = num11 + 3 >>> 2;
			bool flag2 = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_9) != 0) ? (operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_9) == 9) : true);
			_ = flag2;
			num7 = InstructionHelper.Select(flag2, 8, 16) * num4;
			if (num == 0)
			{
				num = num7;
			}
			else if ((uint)num < (uint)num7 || (num & 3) != 0)
			{
				return false;
			}
			if ((uint)num2 < (uint)(num * num5))
			{
				return false;
			}
			num8 = num4 + 1 >>> 1;
			num9 = num5 + 1 >>> 1;
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_5, ptr2, num3))
			{
				return false;
			}
			b = 0;
			switch (operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_9))
			{
			case 0:
				b = (unpack_dxt1.Invoke(@this, ptr, num2, num, num4, num5, num8, num9) ? ((sbyte)1) : ((sbyte)0));
				break;
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
				b = (unpack_dxt5.Invoke(@this, ptr, num2, num, num4, num5, num8, num9) ? ((sbyte)1) : ((sbyte)0));
				break;
			case 9:
				b = (unpack_dxt5a.Invoke(@this, ptr, num2, num, num4, num5, num8, num9) ? ((sbyte)1) : ((sbyte)0));
				break;
			case 7:
			case 8:
				b = (unpack_dxn.Invoke(@this, ptr, num2, num, num4, num5, num8, num9) ? ((sbyte)1) : ((sbyte)0));
				break;
			default:
				return false;
			}
			if ((b & 1) != 1)
			{
				return false;
			}
			stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_5);
			return true;
		}
	}
}
