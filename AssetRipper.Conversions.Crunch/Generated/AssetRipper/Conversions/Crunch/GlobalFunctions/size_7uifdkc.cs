using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?size@?$vector@I@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::vector<unsigned int>::size(void) const")]
[CleanName("size")]
internal static partial class size_7uifdkc
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((crnd_vector_maaktjc*)@this)->m_size;
	}
}
