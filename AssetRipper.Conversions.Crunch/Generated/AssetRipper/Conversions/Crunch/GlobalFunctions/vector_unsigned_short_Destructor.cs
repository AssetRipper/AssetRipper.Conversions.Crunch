using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??1?$vector@G@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned short>::~vector<unsigned short>(void)")]
internal static partial class vector_unsigned_short_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		clear_bqconyd.Invoke(@this);
		if (ExceptionInfo.Current == null)
		{
			return;
		}
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
