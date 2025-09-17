using System;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

internal static partial class sprintf
{
	public unsafe static int Invoke(void* Buffer, void* Format, ReadOnlySpan<nint> args)
	{
		void* argList = null;
		InstructionHelper.VAStart(&argList, args);
		return vsprintf_l.Invoke(Buffer, Format, null, argList);
	}
}
