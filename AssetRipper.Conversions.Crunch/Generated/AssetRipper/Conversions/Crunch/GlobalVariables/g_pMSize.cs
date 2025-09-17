using AssetRipper.Conversions.Crunch.GlobalFunctions;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalVariables;

[MangledName("?g_pMSize@crnd@@3P6A_KPEAX0@ZEA")]
[DemangledName("unsigned __int64 (__cdecl *crnd::g_pMSize)(void *, void *)")]
internal static partial class g_pMSize
{
	private unsafe static void* __value;

	public unsafe static void* Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static g_pMSize()
	{
		Value = crnd_default_msize.__pointer;
	}
}
