using System;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

internal static partial class sprintf
{
	public unsafe static int Invoke([MangledName("_Buffer")] void* Buffer, [MangledName("_Format")] void* Format, ReadOnlySpan<nint> args)
	{
		void* argList = null;
		InstructionHelper.VAStart(&argList, args);
		return vsprintf_l.Invoke(Buffer, Format, null, argList);
	}
}
