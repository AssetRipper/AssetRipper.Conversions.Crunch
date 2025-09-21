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
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_0);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_1);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_2);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->field_3);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_4);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_5);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_6);
			crn_packed_uint_1_Constructor.Invoke(&((crnd_crn_header*)@this)->field_7);
			crn_packed_uint_1_Constructor.Invoke(&((crnd_crn_header*)@this)->field_8);
			crn_packed_uint_1_Constructor.Invoke(&((crnd_crn_header*)@this)->field_9);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_10);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->field_11);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->field_12);
			crn_packed_uint_4_Constructor.Invoke(&((crnd_crn_header*)@this)->field_13);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->field_14);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->field_15);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->field_16);
			crn_palette_Constructor.Invoke(&((crnd_crn_header*)@this)->field_17);
			crn_packed_uint_2_Constructor.Invoke(&((crnd_crn_header*)@this)->field_18);
			crn_packed_uint_3_Constructor.Invoke(&((crnd_crn_header*)@this)->field_19);
			crnd_crn_packed_uint_jymcebc* field_ = (crnd_crn_packed_uint_jymcebc*)(&((crnd_crn_header*)@this)->field_20);
			crnd_crn_packed_uint_jymcebc* ptr = field_ + 1;
			crnd_crn_packed_uint_jymcebc* intPtr = field_;
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
