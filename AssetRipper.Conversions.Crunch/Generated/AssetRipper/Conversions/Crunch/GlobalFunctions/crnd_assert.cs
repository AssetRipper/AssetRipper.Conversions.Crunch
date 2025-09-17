using System;
using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.InlineArrays;
using AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?crnd_assert@crnd@@YAXPEBD0I@Z")]
[DemangledName("void __cdecl crnd::crnd_assert(char const *, char const *, unsigned int)")]
internal static partial class crnd_assert
{
	public unsafe static void Invoke(void* pExp, void* pFile, int line)
	{
		InlineArray_512_w3otm9c inlineArray_512_w3otm9c = default(InlineArray_512_w3otm9c);
		sprintf.Invoke(&inlineArray_512_w3otm9c, String_tghxvvc.__pointer, default(ReadOnlySpan<nint>));
		crnd_output_debug_string.Invoke(&inlineArray_512_w3otm9c);
		puts.Invoke(&inlineArray_512_w3otm9c);
		if (crnd_is_debugger_present.Invoke())
		{
			crnd_debug_break.Invoke();
		}
	}
}
