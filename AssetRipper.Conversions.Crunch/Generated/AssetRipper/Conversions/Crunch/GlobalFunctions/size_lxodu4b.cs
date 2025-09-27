using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?size@?$vector@G@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::vector<unsigned short>::size(void) const")]
[CleanName("size")]
internal static partial class size_lxodu4b
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((crnd_vector_rf9iywd*)@this)->m_size;
	}
}
