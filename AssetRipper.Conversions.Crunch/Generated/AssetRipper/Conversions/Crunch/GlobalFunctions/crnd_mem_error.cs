using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?crnd_mem_error@crnd@@YAXPEBD@Z")]
[DemangledName("void __cdecl crnd::crnd_mem_error(char const *)")]
internal static partial class crnd_mem_error
{
	public unsafe static void Invoke(void* p_msg)
	{
		crnd_assert.Invoke(p_msg, String_yguirrd.__pointer, 2506);
	}
}
