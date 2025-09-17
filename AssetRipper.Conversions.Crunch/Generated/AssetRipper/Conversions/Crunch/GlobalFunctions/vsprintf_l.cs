using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("_vsprintf_l")]
[DemangledName("_vsprintf_l")]
internal static partial class vsprintf_l
{
	public unsafe static int Invoke(void* Buffer, void* Format, void* Locale, void* ArgList)
	{
		return vsnprintf_l.Invoke(Buffer, -1L, Format, Locale, ArgList);
	}
}
