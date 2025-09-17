using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("__local_stdio_printf_options")]
[DemangledName("__local_stdio_printf_options")]
internal static partial class local_stdio_printf_options
{
	public unsafe static void* Invoke()
	{
		return OptionsStorage.__pointer;
	}
}
