using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?clear@?$vector@I@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<unsigned int>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_utei2oa
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_vector_maaktjc*)@this)->m_p != null)
			{
				destruct_array_rsqiwgc.Invoke(n: ((crnd_vector_maaktjc*)@this)->m_size, p: ((crnd_vector_maaktjc*)@this)->m_p);
				crnd_free.Invoke(((crnd_vector_maaktjc*)@this)->m_p);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector_maaktjc*)@this)->m_p = null;
				((crnd_vector_maaktjc*)@this)->m_size = 0;
				((crnd_vector_maaktjc*)@this)->m_capacity = 0;
			}
			((crnd_vector_maaktjc*)@this)->m_alloc_failed = 0;
		}
	}
}
