using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?limit@crn_unpacker@crnd@@CAXAEAII@Z")]
[DemangledName("private: static void __cdecl crnd::crn_unpacker::limit(unsigned int &, unsigned int)")]
internal static partial class limit
{
	public unsafe static void Invoke(void* x, int n)
	{
		unchecked
		{
			int num = *(int*)x - n;
			int num2 = num >> 31;
			*(int*)x = (*(int*)x & num2) | (num & (num2 ^ -1));
		}
	}
}
