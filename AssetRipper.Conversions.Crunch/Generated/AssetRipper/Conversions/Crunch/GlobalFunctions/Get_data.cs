using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?get_data@crn_unpacker@crnd@@QEBAPEBXXZ")]
[DemangledName("public: void const * __cdecl crnd::crn_unpacker::get_data(void) const")]
internal static partial class Get_data
{
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((crnd_crn_unpacker*)@this)->field_1;
	}
}
