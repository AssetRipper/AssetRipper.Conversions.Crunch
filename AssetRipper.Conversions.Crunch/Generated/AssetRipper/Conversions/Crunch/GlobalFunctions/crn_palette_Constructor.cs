using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??0crn_palette@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::crn_palette::crn_palette(void)")]
internal static partial class crn_palette_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			crn_packed_uint_3_Constructor.Invoke(&((crnd_crn_palette*)@this)->field_0);
			crn_packed_uint_3_Constructor.Invoke(&((crnd_crn_palette*)@this)->field_1);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_palette*)@this)->field_2);
			return @this;
		}
	}
}
