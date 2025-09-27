using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??0crn_header@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::crn_header::crn_header(void)")]
internal static partial class crn_header_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_sig);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_header_size);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_header_crc16);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->m_data_size);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_data_crc16);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_width);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_height);
			crn_packed_uint_1_Constructor.Invoke(&((crnd_crn_header*)@this)->m_levels);
			crn_packed_uint_1_Constructor.Invoke(&((crnd_crn_header*)@this)->m_faces);
			crn_packed_uint_1_Constructor.Invoke(&((crnd_crn_header*)@this)->m_format);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_flags);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->m_reserved);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->m_userdata0);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->m_userdata1);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->m_color_endpoints);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->m_color_selectors);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->m_alpha_endpoints);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->m_alpha_selectors);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->m_tables_size);
			crn_packed_uint_3_Constructor.Invoke(&((crnd_crn_header*)@this)->m_tables_ofs);
			crnd_crn_packed_uint_jymcebc* level_ofs = (crnd_crn_packed_uint_jymcebc*)(&((crnd_crn_header*)@this)->m_level_ofs);
			crnd_crn_packed_uint_jymcebc* ptr = level_ofs + 1;
			crnd_crn_packed_uint_jymcebc* intPtr = level_ofs;
			while (true)
			{
				void* ptr2 = intPtr;
				crn_packed_uint_4_Constructor.Invoke(ptr2);
				crnd_crn_packed_uint_jymcebc* ptr3 = (crnd_crn_packed_uint_jymcebc*)ptr2 + 1;
				if (ptr3 == ptr)
				{
					break;
				}
				intPtr = ptr3;
			}
			return @this;
		}
	}
}
