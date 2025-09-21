using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?get_unshifted_max_code@decoder_tables@prefix_coding@crnd@@QEBAII@Z")]
[DemangledName("public: unsigned int __cdecl crnd::prefix_coding::decoder_tables::get_unshifted_max_code(unsigned int) const")]
internal static partial class Get_unshifted_max_code
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int len)
	{
		unchecked
		{
			if ((uint)len < 1u || (uint)len > 16u)
			{
				crnd_assert.Invoke(String_ajzw4md.__pointer, String_yguirrd.__pointer, 1960);
			}
			int num = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(len - 1)];
			if (num == 0)
			{
				return -1;
			}
			return num - 1 >>> 16 - len;
		}
	}
}
