using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??0static_huffman_data_model@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::static_huffman_data_model::static_huffman_data_model(void)")]
[CleanName("static_huffman_data_model_Constructor")]
internal static partial class static_huffman_data_model_Constructor_tl33idc
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->field_0 = 0;
			vector_unsigned_char_Constructor.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1);
			((crnd_static_huffman_data_model*)@this)->field_2 = null;
			return @this;
		}
	}
}
