using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??1?$vector@I@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned int>::~vector<unsigned int>(void)")]
internal static partial class vector_unsigned_int_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		clear_utei2oa.Invoke(@this);
		if (ExceptionInfo.Current == null)
		{
			return;
		}
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
