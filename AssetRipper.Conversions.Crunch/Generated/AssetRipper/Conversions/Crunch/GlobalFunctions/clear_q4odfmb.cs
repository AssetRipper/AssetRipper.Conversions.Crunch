using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?clear@?$vector@E@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<unsigned char>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_q4odfmb
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_vector_f3cmzmc*)@this)->field_0 != null)
			{
				destruct_array_dhbxund.Invoke(n: ((crnd_vector_f3cmzmc*)@this)->field_1, p: ((crnd_vector_f3cmzmc*)@this)->field_0);
				crnd_free.Invoke(((crnd_vector_f3cmzmc*)@this)->field_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector_f3cmzmc*)@this)->field_0 = null;
				((crnd_vector_f3cmzmc*)@this)->field_1 = 0;
				((crnd_vector_f3cmzmc*)@this)->field_2 = 0;
			}
			((crnd_vector_f3cmzmc*)@this)->field_3 = 0;
		}
	}
}
