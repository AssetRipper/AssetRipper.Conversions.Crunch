using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Intrinsics.Unimplemented;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("_vsnprintf_l")]
[DemangledName("_vsnprintf_l")]
internal static partial class vsnprintf_l
{
	public unsafe static int Invoke(void* Buffer, long BufferCount, void* Format, void* Locale, void* ArgList)
	{
		int num = 0;
		num = stdio_common_vsprintf.Invoke(*unchecked((long*)local_stdio_printf_options.Invoke()) | 1L, Buffer, BufferCount, Format, Locale, ArgList);
		return (num >= 0) ? num : (-1);
	}
}
