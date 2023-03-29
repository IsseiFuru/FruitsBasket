using UnrealBuildTool;

public class FruitsBasketTarget : TargetRules
{
	public FruitsBasketTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FruitsBasket");
	}
}
