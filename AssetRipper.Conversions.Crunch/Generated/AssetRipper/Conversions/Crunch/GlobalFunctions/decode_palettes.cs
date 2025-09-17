using AssetRipper.Conversions.Crunch.Helpers;
using AssetRipper.Conversions.Crunch.Structures;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("?decode_palettes@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_palettes(void)")]
internal static partial class decode_palettes
{
	private partial struct LocalVariables
	{
		public bool field_0;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		if (operator_unsigned_int_f3crpsb.Invoke(&unchecked((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_14.field_2) == 0)
		{
			goto IL_0093;
		}
		bool flag = decode_color_endpoints.Invoke(@this);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		if (!flag)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		}
		else
		{
			bool flag2 = decode_color_selectors.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (flag2)
			{
				goto IL_0093;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		}
		goto IL_011d;
		IL_010a:
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
		goto IL_011d;
		IL_0093:
		if (operator_unsigned_int_f3crpsb.Invoke(&unchecked((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_4)->field_16.field_2) == 0)
		{
			goto IL_010a;
		}
		bool flag3 = decode_alpha_endpoints.Invoke(@this);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		if (!flag3)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		}
		else
		{
			bool flag4 = decode_alpha_selectors.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (flag4)
			{
				goto IL_010a;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		}
		goto IL_011d;
		IL_011d:
		bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_;
	}
}
