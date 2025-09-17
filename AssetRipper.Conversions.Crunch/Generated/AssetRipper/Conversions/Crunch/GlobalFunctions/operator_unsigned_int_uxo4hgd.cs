using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??B?$crn_packed_uint@$03@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::crn_packed_uint<4>::operator unsigned int(void) const")]
[CleanName("operator_unsigned_int")]
internal static partial class operator_unsigned_int_uxo4hgd
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked(((byte)(*(sbyte*)(&((crnd_crn_packed_uint_0*)@this)->field_0)) << 24) | ((byte)((sbyte*)(&((crnd_crn_packed_uint_0*)@this)->field_0))[1] << 16) | ((byte)((sbyte*)(&((crnd_crn_packed_uint_0*)@this)->field_0))[2] << 8) | (byte)((sbyte*)(&((crnd_crn_packed_uint_0*)@this)->field_0))[3]);
	}
}
