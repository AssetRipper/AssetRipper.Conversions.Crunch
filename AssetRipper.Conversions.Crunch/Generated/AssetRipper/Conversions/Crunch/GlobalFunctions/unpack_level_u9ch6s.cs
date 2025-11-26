using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?unpack_level@crn_unpacker@crnd@@QEAA_NPEBXIPEAPEAXIII@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::unpack_level(void const *, unsigned int, void **, unsigned int, unsigned int, unsigned int)")]
[CleanName("unpack_level")]
internal static partial class unpack_level_u9ch6s
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const *")] void* pSrc, [NativeType("unsigned int")] int src_size_in_bytes, [NativeType("void **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int level_index)
	{
		int num = row_pitch_in_bytes;
		unchecked
		{
			int num2 = maximum.Invoke(crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_width) >>> level_index, 1);
			int num3 = maximum.Invoke(crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_height) >>> level_index, 1);
			int num4 = num2 + 3 >>> 2;
			int num5 = num3 + 3 >>> 2;
			int num6 = InstructionHelper.Select((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) != 0) ? (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 9) : true, 8, 16) * num4;
			if (num == 0)
			{
				num = num6;
			}
			else if ((uint)num < (uint)num6 || (num & 3) != 0)
			{
				return false;
			}
			if ((uint)dst_size_in_bytes < (uint)(num * num5))
			{
				return false;
			}
			int chunks_x = num4 + 1 >>> 1;
			int chunks_y = num5 + 1 >>> 1;
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, pSrc, src_size_in_bytes))
			{
				return false;
			}
			sbyte b;
			switch (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format))
			{
			case 0:
				b = (unpack_dxt1.Invoke(@this, pDst, dst_size_in_bytes, num, num4, num5, chunks_x, chunks_y) ? ((sbyte)1) : ((sbyte)0));
				break;
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
				b = (unpack_dxt5.Invoke(@this, pDst, dst_size_in_bytes, num, num4, num5, chunks_x, chunks_y) ? ((sbyte)1) : ((sbyte)0));
				break;
			case 9:
				b = (unpack_dxt5a.Invoke(@this, pDst, dst_size_in_bytes, num, num4, num5, chunks_x, chunks_y) ? ((sbyte)1) : ((sbyte)0));
				break;
			case 7:
			case 8:
				b = (unpack_dxn.Invoke(@this, pDst, dst_size_in_bytes, num, num4, num5, chunks_x, chunks_y) ? ((sbyte)1) : ((sbyte)0));
				break;
			default:
				return false;
			}
			if ((b & 1) != 1)
			{
				return false;
			}
			stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
			return true;
		}
	}
}
