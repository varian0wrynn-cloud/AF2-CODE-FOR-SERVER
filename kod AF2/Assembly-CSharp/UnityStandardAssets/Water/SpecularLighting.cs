using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x020002F5 RID: 757
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		// Token: 0x0600B146 RID: 45382 RVA: 0x004D24F0 File Offset: 0x004D06F0
		public void Update()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("_WorldLightDir", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x004D2573 File Offset: 0x004D0773
		public void KEMGOLACEHI()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x004D2573 File Offset: 0x004D0773
		public void HHGGCBLOJGB()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x004D2573 File Offset: 0x004D0773
		public void ANHOOJFEJJE()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x004D2598 File Offset: 0x004D0798
		public void KJJBBLDJHPD()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("\n", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x004D261C File Offset: 0x004D081C
		public void OFPGMNGFLNH()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("FOG_EXP2", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x004D2573 File Offset: 0x004D0773
		public void INDGOHJGCFN()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x004D2573 File Offset: 0x004D0773
		public void OBJCOJEHLBE()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x004D2573 File Offset: 0x004D0773
		public void EDGALMCHPPH()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x004D26A0 File Offset: 0x004D08A0
		public void CBBLGEDCJBF()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("head", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B150 RID: 45392 RVA: 0x004D2573 File Offset: 0x004D0773
		public void MCHAAIIHOKD()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B151 RID: 45393 RVA: 0x004D2573 File Offset: 0x004D0773
		public void Start()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B152 RID: 45394 RVA: 0x004D2724 File Offset: 0x004D0924
		public void JLFBDOPFDDJ()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("t_much", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B153 RID: 45395 RVA: 0x004D27A8 File Offset: 0x004D09A8
		public void BOAJJAKEMLH()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("RollerBladeTurnRight", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x004D282C File Offset: 0x004D0A2C
		public void LBGKAMLLACN()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("] ", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x004D2573 File Offset: 0x004D0773
		public void LPNDCJKAKEA()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x004D28B0 File Offset: 0x004D0AB0
		public void LMMDHJJJNJO()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("shop_bccount", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x004D2573 File Offset: 0x004D0773
		public void ELFLOPJDAKK()
		{
			this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x004D2934 File Offset: 0x004D0B34
		public void OPDCJCFMIPE()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("<color='#80ffff'>", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x004D29B8 File Offset: 0x004D0BB8
		public void AKLFCMNCPKL()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("OnDestroy", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x004D2A3C File Offset: 0x004D0C3C
		public void LIOCDEICIFD()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("wpn_rod2", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x004D2AC0 File Offset: 0x004D0CC0
		public void IGEICBNMPAD()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("knopje.wav", this.specularLight.transform.forward);
			}
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x004D2B44 File Offset: 0x004D0D44
		public void LDDIGEMBDNF()
		{
			if (!this.EMHBENGDKAB)
			{
				this.EMHBENGDKAB = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
			}
			if (this.specularLight && this.EMHBENGDKAB.sharedMaterial)
			{
				this.EMHBENGDKAB.sharedMaterial.SetVector("Assets/Weapons/baseLegs.unity3d", this.specularLight.transform.forward);
			}
		}

		// Token: 0x04001675 RID: 5749
		public Transform specularLight;

		// Token: 0x04001676 RID: 5750
		private WaterBase EMHBENGDKAB;
	}
}
