using UnrealBuildTool;

public class UoP_GJ_ADPDTarget : TargetRules
{
	public UoP_GJ_ADPDTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("UoP_GJ_ADPD");
	}
}
