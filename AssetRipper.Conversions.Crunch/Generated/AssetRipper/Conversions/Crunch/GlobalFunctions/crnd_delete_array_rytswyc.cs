using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??$crnd_delete_array@G@crnd@@YAXPEAG@Z")]
[DemangledName("void __cdecl crnd::crnd_delete_array<unsigned short>(unsigned short *)")]
[CleanName("crnd_delete_array")]
internal static partial class crnd_delete_array_rytswyc
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned short *")] void* p)
	{
		unchecked
		{
			if (p != null)
			{
				int num = *(int*)((byte*)p + -4);
				int num2 = *(int*)((byte*)p + -8);
				if (num == 0 || num != (num2 ^ -1))
				{
					crnd_assert.Invoke(String_ec57feb.__pointer, String_yguirrd.__pointer, 651);
				}
				destruct_array_viasmsc.Invoke(p, num);
				crnd_free.Invoke((byte*)p + -8);
				if (ExceptionInfo.Current == null)
				{
				}
			}
		}
	}
}
