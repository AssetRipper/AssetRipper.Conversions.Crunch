using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?get_alloc_failed@?$vector@E@crnd@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned char>::get_alloc_failed(void) const")]
internal static partial class Get_alloc_failed
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((crnd_vector_f3cmzmc*)@this)->field_3 & 1) == 1;
	}
}
