using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?crnd_get_crn_format_bits_per_texel@crnd@@YAIW4crn_format@@@Z")]
[DemangledName("unsigned int __cdecl crnd::crnd_get_crn_format_bits_per_texel(enum crn_format)")]
internal static partial class crnd_get_crn_format_bits_per_texel
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("enum crn_format")] int fmt)
	{
		switch (fmt)
		{
		case 0:
		case 9:
		case 10:
			return 4;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
			return 8;
		default:
			crnd_assert.Invoke(String_xxn2wad.__pointer, String_yguirrd.__pointer, 2672);
			return 0;
		}
	}
}
