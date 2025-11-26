using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??$zero_object@$$BY0BA@I@utils@crnd@@YAXAEAY0BA@I@Z")]
[DemangledName("void __cdecl crnd::utils::zero_object<unsigned int[16]>(unsigned int (&)[16])")]
[CleanName("zero_object")]
internal static partial class zero_object_ra884z
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int (&)[16]")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 64L, isVolatile: false);
	}
}
