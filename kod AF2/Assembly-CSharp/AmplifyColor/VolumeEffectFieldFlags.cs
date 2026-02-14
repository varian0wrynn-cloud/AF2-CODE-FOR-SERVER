using System;
using System.Reflection;

namespace AmplifyColor
{
	// Token: 0x020005DD RID: 1501
	[Serializable]
	public class VolumeEffectFieldFlags
	{
		// Token: 0x06013B3C RID: 80700 RVA: 0x00865F00 File Offset: 0x00864100
		public VolumeEffectFieldFlags(VolumeEffectField ILLLMBKGLOJ)
		{
			this.fieldName = ILLLMBKGLOJ.fieldName;
			this.fieldType = ILLLMBKGLOJ.fieldType;
			this.blendFlag = true;
		}

		// Token: 0x06013B3D RID: 80701 RVA: 0x00865F27 File Offset: 0x00864127
		public VolumeEffectFieldFlags(FieldInfo JFMMNIJJODD)
		{
			this.fieldName = JFMMNIJJODD.Name;
			this.fieldType = JFMMNIJJODD.FieldType.FullName;
		}

		// Token: 0x04002819 RID: 10265
		public string fieldName;

		// Token: 0x0400281A RID: 10266
		public string fieldType;

		// Token: 0x0400281B RID: 10267
		public bool blendFlag;
	}
}
