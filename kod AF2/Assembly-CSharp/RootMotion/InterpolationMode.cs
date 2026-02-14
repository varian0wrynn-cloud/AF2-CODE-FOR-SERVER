using System;

namespace RootMotion
{
	// Token: 0x020003D4 RID: 980
	[Serializable]
	public enum InterpolationMode
	{
		// Token: 0x04001C07 RID: 7175
		None,
		// Token: 0x04001C08 RID: 7176
		InOutCubic,
		// Token: 0x04001C09 RID: 7177
		InOutQuintic,
		// Token: 0x04001C0A RID: 7178
		InOutSine,
		// Token: 0x04001C0B RID: 7179
		InQuintic,
		// Token: 0x04001C0C RID: 7180
		InQuartic,
		// Token: 0x04001C0D RID: 7181
		InCubic,
		// Token: 0x04001C0E RID: 7182
		InQuadratic,
		// Token: 0x04001C0F RID: 7183
		InElastic,
		// Token: 0x04001C10 RID: 7184
		InElasticSmall,
		// Token: 0x04001C11 RID: 7185
		InElasticBig,
		// Token: 0x04001C12 RID: 7186
		InSine,
		// Token: 0x04001C13 RID: 7187
		InBack,
		// Token: 0x04001C14 RID: 7188
		OutQuintic,
		// Token: 0x04001C15 RID: 7189
		OutQuartic,
		// Token: 0x04001C16 RID: 7190
		OutCubic,
		// Token: 0x04001C17 RID: 7191
		OutInCubic,
		// Token: 0x04001C18 RID: 7192
		OutInQuartic,
		// Token: 0x04001C19 RID: 7193
		OutElastic,
		// Token: 0x04001C1A RID: 7194
		OutElasticSmall,
		// Token: 0x04001C1B RID: 7195
		OutElasticBig,
		// Token: 0x04001C1C RID: 7196
		OutSine,
		// Token: 0x04001C1D RID: 7197
		OutBack,
		// Token: 0x04001C1E RID: 7198
		OutBackCubic,
		// Token: 0x04001C1F RID: 7199
		OutBackQuartic,
		// Token: 0x04001C20 RID: 7200
		BackInCubic,
		// Token: 0x04001C21 RID: 7201
		BackInQuartic
	}
}
