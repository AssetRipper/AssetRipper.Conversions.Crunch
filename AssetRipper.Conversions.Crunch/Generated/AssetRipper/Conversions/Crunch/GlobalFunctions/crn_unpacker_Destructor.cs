using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??1crn_unpacker@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::crn_unpacker::~crn_unpacker(void)")]
internal static partial class crn_unpacker_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((crnd_crn_unpacker*)@this)->m_magic = 0;
			vector_unsigned_short_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_short_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_int_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_int_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			crnd_static_huffman_data_model* selector_delta_dm = (crnd_static_huffman_data_model*)(&((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
			nint num = (nint)(selector_delta_dm + 2L);
			while (true)
			{
				crnd_static_huffman_data_model* ptr = (crnd_static_huffman_data_model*)(num + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
				static_huffman_data_model_Destructor.Invoke(ptr);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr == selector_delta_dm)
				{
					break;
				}
				num = (nint)ptr;
			}
			crnd_static_huffman_data_model* endpoint_delta_dm = (crnd_static_huffman_data_model*)(&((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm);
			nint num2 = (nint)(endpoint_delta_dm + 2L);
			while (true)
			{
				crnd_static_huffman_data_model* ptr2 = (crnd_static_huffman_data_model*)(num2 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
				static_huffman_data_model_Destructor.Invoke(ptr2);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr2 == endpoint_delta_dm)
				{
					break;
				}
				num2 = (nint)ptr2;
			}
			static_huffman_data_model_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->m_chunk_encoding_dm);
		}
	}
}
