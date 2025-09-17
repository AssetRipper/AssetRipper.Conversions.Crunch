using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?get_bits_init@symbol_codec@crnd@@AEAAXXZ")]
[DemangledName("private: void __cdecl crnd::symbol_codec::get_bits_init(void)")]
internal static partial class Get_bits_init
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((crnd_symbol_codec*)@this)->field_4 = 0;
			((crnd_symbol_codec*)@this)->field_5 = 0;
		}
	}
}
