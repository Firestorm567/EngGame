using UnrealBuildTool;

public class EngGameTarget : TargetRules
{
	public EngGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("EngGame");
	}
}
