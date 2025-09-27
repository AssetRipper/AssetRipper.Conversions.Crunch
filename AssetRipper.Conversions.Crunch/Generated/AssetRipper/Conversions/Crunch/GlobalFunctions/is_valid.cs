using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?is_valid@crn_unpacker@crnd@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::is_valid(void) const")]
internal static partial class is_valid
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((crnd_crn_unpacker*)@this)->m_magic == 519686845;
	}
}
