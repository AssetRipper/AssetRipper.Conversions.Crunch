using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?decode_palettes@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_palettes(void)")]
internal static partial class decode_palettes
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_14.field_2) != 0)
			{
				bool flag = decode_color_endpoints.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
				bool flag2 = decode_color_selectors.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					return false;
				}
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_16.field_2) != 0)
			{
				bool flag3 = decode_alpha_endpoints.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag3)
				{
					return false;
				}
				bool flag4 = decode_alpha_selectors.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag4)
				{
					return false;
				}
			}
			return true;
		}
	}
}
