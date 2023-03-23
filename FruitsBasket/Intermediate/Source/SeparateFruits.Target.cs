using UnrealBuildTool;

public class SeparateFruitsTarget : TargetRules
{
	public SeparateFruitsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SeparateFruits");
	}
}
