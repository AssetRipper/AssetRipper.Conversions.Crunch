using AssetRipper.Conversions.Crunch.GlobalVariables;
using AssetRipper.Conversions.Crunch.Helpers;

namespace AssetRipper.Conversions.Crunch.GlobalFunctions;

[MangledName("??$crnd_delete_array@I@crnd@@YAXPEAI@Z")]
[DemangledName("void __cdecl crnd::crnd_delete_array<unsigned int>(unsigned int *)")]
[CleanName("crnd_delete_array")]
internal static partial class crnd_delete_array_nughn5d
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public int field_1;

		public int field_2;
	}

	public unsafe static void Invoke(void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = p;
		unchecked
		{
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_0 != null)
			{
				int field_ = *(int*)((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + -4);
				startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
				int field_2 = *(int*)((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + -8);
				startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_2;
				int num;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 != 0 && startFrame.GetLocalsPointer<LocalVariables>()->field_1 == (startFrame.GetLocalsPointer<LocalVariables>()->field_2 ^ -1))
				{
					num = -1;
				}
				else
				{
					crnd_assert.Invoke(String_ec57feb.__pointer, String_yguirrd.__pointer, 651);
					num = 0;
				}
				destruct_array_lrbdoxa.Invoke(n: startFrame.GetLocalsPointer<LocalVariables>()->field_1, p: startFrame.GetLocalsPointer<LocalVariables>()->field_0);
				crnd_free.Invoke((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + -8);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
