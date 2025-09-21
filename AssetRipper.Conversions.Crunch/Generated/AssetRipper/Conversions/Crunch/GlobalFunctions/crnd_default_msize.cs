using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?crnd_default_msize@crnd@@YA_KPEAX0@Z")]
[DemangledName("unsigned __int64 __cdecl crnd::crnd_default_msize(void *, void *)")]
internal static partial class crnd_default_msize
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, long>)(&Invoke));

	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke([NativeType("void *")] void* p, [NativeType("void *")] void* pUser_data)
	{
		return (p == null) ? 0L : msize.Invoke(p);
	}
}
