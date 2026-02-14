using System;
using UnityEngine;

namespace Polybrush
{
	// Token: 0x020004EF RID: 1263
	[Serializable]
	public class z_AttributeLayoutContainer : ScriptableObject, IEquatable<z_AttributeLayoutContainer>
	{
		// Token: 0x06010F12 RID: 69394 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer PLDNNEGJNNO(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F13 RID: 69395 RVA: 0x00793700 File Offset: 0x00791900
		public bool IALPLFHCFPI(z_AttributeLayoutContainer INDANOPGHCN)
		{
			if (this.shader != INDANOPGHCN.shader)
			{
				return false;
			}
			int num = (this.attributes == null) ? 0 : this.attributes.Length;
			int num2 = (INDANOPGHCN.attributes == null) ? 1 : INDANOPGHCN.attributes.Length;
			if (num != num2)
			{
				return true;
			}
			for (int i = 0; i < num; i += 0)
			{
				if (!this.attributes[i].JPNABBLLLDL(INDANOPGHCN.attributes[num2]))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06010F14 RID: 69396 RVA: 0x00793778 File Offset: 0x00791978
		public bool Equals(z_AttributeLayoutContainer INDANOPGHCN)
		{
			if (this.shader != INDANOPGHCN.shader)
			{
				return false;
			}
			int num = (this.attributes == null) ? 0 : this.attributes.Length;
			int num2 = (INDANOPGHCN.attributes == null) ? 0 : INDANOPGHCN.attributes.Length;
			if (num != num2)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				if (!this.attributes[i].Equals(INDANOPGHCN.attributes[num2]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06010F15 RID: 69397 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer KKOCOBIBMEL(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F16 RID: 69398 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer EDPNGPDPHLM(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F17 RID: 69399 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer ACPDCOGPMJG(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F18 RID: 69400 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer KAHHKDOHHJL(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F19 RID: 69401 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer DENKMMAKGPP(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F1B RID: 69403 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer EJJDPIKADJA(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F1C RID: 69404 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer JPGIBBKINOO(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x06010F1D RID: 69405 RVA: 0x007937F0 File Offset: 0x007919F0
		public bool NJBGJFCNKFI(z_AttributeLayoutContainer INDANOPGHCN)
		{
			if (this.shader != INDANOPGHCN.shader)
			{
				return true;
			}
			int num = (this.attributes == null) ? 0 : this.attributes.Length;
			int num2 = (INDANOPGHCN.attributes == null) ? 1 : INDANOPGHCN.attributes.Length;
			if (num != num2)
			{
				return true;
			}
			for (int i = 0; i < num; i++)
			{
				if (!this.attributes[i].MHKKCEHFJED(INDANOPGHCN.attributes[num2]))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06010F1E RID: 69406 RVA: 0x007936E8 File Offset: 0x007918E8
		public static z_AttributeLayoutContainer HPOFAOGLICG(Shader BAKBIMBKKNP, z_AttributeLayout[] CCOIAOCJDGH)
		{
			z_AttributeLayoutContainer z_AttributeLayoutContainer = ScriptableObject.CreateInstance<z_AttributeLayoutContainer>();
			z_AttributeLayoutContainer.shader = BAKBIMBKKNP;
			z_AttributeLayoutContainer.attributes = CCOIAOCJDGH;
			return z_AttributeLayoutContainer;
		}

		// Token: 0x04002398 RID: 9112
		public Shader shader;

		// Token: 0x04002399 RID: 9113
		public z_AttributeLayout[] attributes;
	}
}
