using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??$zero_object@$$BY0BB@I@utils@crnd@@YAXAEAY0BB@I@Z")]
[DemangledName("void __cdecl crnd::utils::zero_object<unsigned int[17]>(unsigned int (&)[17])")]
[CleanName("zero_object")]
internal static partial class zero_object_5n5m5id
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int (&)[17]")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 68L, isVolatile: false);
	}
}
