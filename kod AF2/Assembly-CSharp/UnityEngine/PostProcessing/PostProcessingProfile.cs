using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000575 RID: 1397
	public class PostProcessingProfile : ScriptableObject
	{
		// Token: 0x040025C8 RID: 9672
		public BuiltinDebugViewsModel debugViews = new BuiltinDebugViewsModel();

		// Token: 0x040025C9 RID: 9673
		public FogModel fog = new FogModel();

		// Token: 0x040025CA RID: 9674
		public AntialiasingModel antialiasing = new AntialiasingModel();

		// Token: 0x040025CB RID: 9675
		public AmbientOcclusionModel ambientOcclusion = new AmbientOcclusionModel();

		// Token: 0x040025CC RID: 9676
		public ScreenSpaceReflectionModel screenSpaceReflection = new ScreenSpaceReflectionModel();

		// Token: 0x040025CD RID: 9677
		public DepthOfFieldModel depthOfField = new DepthOfFieldModel();

		// Token: 0x040025CE RID: 9678
		public MotionBlurModel motionBlur = new MotionBlurModel();

		// Token: 0x040025CF RID: 9679
		public EyeAdaptationModel eyeAdaptation = new EyeAdaptationModel();

		// Token: 0x040025D0 RID: 9680
		public BloomModel bloom = new BloomModel();

		// Token: 0x040025D1 RID: 9681
		public ColorGradingModel colorGrading = new ColorGradingModel();

		// Token: 0x040025D2 RID: 9682
		public UserLutModel userLut = new UserLutModel();

		// Token: 0x040025D3 RID: 9683
		public ChromaticAberrationModel chromaticAberration = new ChromaticAberrationModel();

		// Token: 0x040025D4 RID: 9684
		public GrainModel grain = new GrainModel();

		// Token: 0x040025D5 RID: 9685
		public VignetteModel vignette = new VignetteModel();

		// Token: 0x040025D6 RID: 9686
		public DitheringModel dithering = new DitheringModel();
	}
}
