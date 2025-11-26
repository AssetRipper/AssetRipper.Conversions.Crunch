using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??0?$vector@E@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned char>::vector<unsigned char>(void)")]
internal static partial class vector_unsigned_char_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_vector_uksit8*)@this)->m_p = null;
			((crnd_vector_uksit8*)@this)->m_size = 0;
			((crnd_vector_uksit8*)@this)->m_capacity = 0;
			((crnd_vector_uksit8*)@this)->m_alloc_failed = 0;
			return @this;
		}
	}
}
