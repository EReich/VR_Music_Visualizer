using UnrealBuildTool;

public class VR_Music_VisualizerTarget : TargetRules
{
	public VR_Music_VisualizerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_Music_Visualizer");
	}
}
