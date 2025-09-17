using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??A?$vector@E@crnd@@QEAAAEAEI@Z")]
[DemangledName("public: unsigned char & __cdecl crnd::vector<unsigned char>::operator[](unsigned int)")]
[CleanName("Index")]
internal static partial class Index_o39mi9c
{
	public unsafe static void* Invoke(void* @this, int i)
	{
		int num = 0;
		num = i;
		unchecked
		{
			int num2;
			if ((uint)num < (uint)((crnd_vector*)@this)->field_1)
			{
				num2 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 910);
				num2 = 0;
			}
			return (byte*)((crnd_vector*)@this)->field_0 + (uint)num;
		}
	}
}
