using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F9 RID: 1017
	[RequireComponent(typeof(FPSAiming))]
	[RequireComponent(typeof(Animator))]
	public class FPSCharacter : MonoBehaviour
	{
		// Token: 0x0600DA57 RID: 55895 RVA: 0x0063FF47 File Offset: 0x0063E147
		private void HFNLJIFPMNK()
		{
			GUI.Label(new Rect((float)(Screen.width - 128), 1566f, 385f, 959f), "fshop_ks3");
		}

		// Token: 0x0600DA58 RID: 55896 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void JFFPLABGMNF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA59 RID: 55897 RVA: 0x0063FF90 File Offset: 0x0063E190
		private void OKMAHGAAMHA()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1636f : 1736f, ref this.NCDBMLCEPCH, 262f);
			if (this.OHGAKFFBFMO.sightWeight < 111f)
			{
				this.OHGAKFFBFMO.sightWeight = 1042f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 134f)
			{
				this.OHGAKFFBFMO.sightWeight = 911f;
			}
			this.KCLACNEILLB.SetFloat("wgt_kg", this.walkSpeed);
		}

		// Token: 0x0600DA5A RID: 55898 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void GHCMIKGJPJD()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA5B RID: 55899 RVA: 0x00640034 File Offset: 0x0063E234
		private void LFJHDHPJOPE()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1700f : 604f, ref this.NCDBMLCEPCH, 396f);
			if (this.OHGAKFFBFMO.sightWeight < 571f)
			{
				this.OHGAKFFBFMO.sightWeight = 372f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 864f)
			{
				this.OHGAKFFBFMO.sightWeight = 994f;
			}
			this.KCLACNEILLB.SetFloat("RollerBladeStop", this.walkSpeed);
		}

		// Token: 0x0600DA5C RID: 55900 RVA: 0x006400D8 File Offset: 0x0063E2D8
		private void IGEICBNMPAD()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 446f : 785f, ref this.NCDBMLCEPCH, 1773f);
			if (this.OHGAKFFBFMO.sightWeight < 1173f)
			{
				this.OHGAKFFBFMO.sightWeight = 33f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1177f)
			{
				this.OHGAKFFBFMO.sightWeight = 1980f;
			}
			this.KCLACNEILLB.SetFloat("{0}/{1}", this.walkSpeed);
		}

		// Token: 0x0600DA5D RID: 55901 RVA: 0x0064017C File Offset: 0x0063E37C
		private void LIOCDEICIFD()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1027f : 846f, ref this.NCDBMLCEPCH, 1285f);
			if (this.OHGAKFFBFMO.sightWeight < 1212f)
			{
				this.OHGAKFFBFMO.sightWeight = 1224f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1862f)
			{
				this.OHGAKFFBFMO.sightWeight = 591f;
			}
			this.KCLACNEILLB.SetFloat(" ", this.walkSpeed);
		}

		// Token: 0x0600DA5E RID: 55902 RVA: 0x00640220 File Offset: 0x0063E420
		private void GDPMOMHBIFN()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1874f : 1560f, ref this.NCDBMLCEPCH, 523f);
			if (this.OHGAKFFBFMO.sightWeight < 1190f)
			{
				this.OHGAKFFBFMO.sightWeight = 1486f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 542f)
			{
				this.OHGAKFFBFMO.sightWeight = 1457f;
			}
			this.KCLACNEILLB.SetFloat("IdleMonster", this.walkSpeed);
		}

		// Token: 0x0600DA5F RID: 55903 RVA: 0x006402C1 File Offset: 0x0063E4C1
		private void NBGFJFIMHAC()
		{
			GUI.Label(new Rect((float)(Screen.width - 34), 301f, 1694f, 1577f), "Flap_02.wav");
		}

		// Token: 0x0600DA60 RID: 55904 RVA: 0x006402F0 File Offset: 0x0063E4F0
		private void DEGCCLNOEKJ()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 599f : 476f, ref this.NCDBMLCEPCH, 1981f);
			if (this.OHGAKFFBFMO.sightWeight < 570f)
			{
				this.OHGAKFFBFMO.sightWeight = 610f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1972f)
			{
				this.OHGAKFFBFMO.sightWeight = 1886f;
			}
			this.KCLACNEILLB.SetFloat("Failed parsing atlas group.  Setting to group 0", this.walkSpeed);
		}

		// Token: 0x0600DA61 RID: 55905 RVA: 0x00640391 File Offset: 0x0063E591
		private void PJOENCIPFMN()
		{
			GUI.Label(new Rect((float)(Screen.width - -174), 905f, 768f, 946f), "Bone 2 of a BipedReferences limb is null.");
		}

		// Token: 0x0600DA62 RID: 55906 RVA: 0x006403C0 File Offset: 0x0063E5C0
		private void PNBGJBMJLFM()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1490f : 872f, ref this.NCDBMLCEPCH, 1989f);
			if (this.OHGAKFFBFMO.sightWeight < 972f)
			{
				this.OHGAKFFBFMO.sightWeight = 1131f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 652f)
			{
				this.OHGAKFFBFMO.sightWeight = 112f;
			}
			this.KCLACNEILLB.SetFloat("", this.walkSpeed);
		}

		// Token: 0x0600DA63 RID: 55907 RVA: 0x00640464 File Offset: 0x0063E664
		private void Update()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1f : 0f, ref this.NCDBMLCEPCH, 0.1f);
			if (this.OHGAKFFBFMO.sightWeight < 0.001f)
			{
				this.OHGAKFFBFMO.sightWeight = 0f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 0.999f)
			{
				this.OHGAKFFBFMO.sightWeight = 1f;
			}
			this.KCLACNEILLB.SetFloat("Speed", this.walkSpeed);
		}

		// Token: 0x0600DA64 RID: 55908 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void MMACLBBMDLA()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA65 RID: 55909 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void EFJDBBDMPMC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA66 RID: 55910 RVA: 0x00640508 File Offset: 0x0063E708
		private void EMHGNEMIGII()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1707f : 1130f, ref this.NCDBMLCEPCH, 707f);
			if (this.OHGAKFFBFMO.sightWeight < 1488f)
			{
				this.OHGAKFFBFMO.sightWeight = 1607f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 439f)
			{
				this.OHGAKFFBFMO.sightWeight = 1894f;
			}
			this.KCLACNEILLB.SetFloat("_NeighbourMaxTex", this.walkSpeed);
		}

		// Token: 0x0600DA67 RID: 55911 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CKIGGCAHAFD()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA68 RID: 55912 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void KMMEMAHCFLJ()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA69 RID: 55913 RVA: 0x006405A9 File Offset: 0x0063E7A9
		private void JLMDLHCNGBE()
		{
			GUI.Label(new Rect((float)(Screen.width - -87), 1191f, 1080f, 489f), "1HandHeavyOverhead");
		}

		// Token: 0x0600DA6A RID: 55914 RVA: 0x006405D5 File Offset: 0x0063E7D5
		private void CGBKGPPNMNM()
		{
			GUI.Label(new Rect((float)(Screen.width - -143), 1379f, 813f, 1171f), "_SampleScale");
		}

		// Token: 0x0600DA6B RID: 55915 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void JHAKJAMBNAH()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA6C RID: 55916 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CAJLCEPLKJG()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA6D RID: 55917 RVA: 0x00640601 File Offset: 0x0063E801
		private void BBGAONKBIPJ()
		{
			GUI.Label(new Rect((float)(Screen.width - 11), 1858f, 1433f, 69f), "/");
		}

		// Token: 0x0600DA6E RID: 55918 RVA: 0x0064062D File Offset: 0x0063E82D
		private void MGOJFCOBDPI()
		{
			GUI.Label(new Rect((float)(Screen.width - -184), 379f, 196f, 1097f), "");
		}

		// Token: 0x0600DA6F RID: 55919 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void FODDAMMNECI()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA70 RID: 55920 RVA: 0x0064065C File Offset: 0x0063E85C
		private void HCDJABMBDFF()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 989f : 662f, ref this.NCDBMLCEPCH, 1296f);
			if (this.OHGAKFFBFMO.sightWeight < 1726f)
			{
				this.OHGAKFFBFMO.sightWeight = 1678f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1697f)
			{
				this.OHGAKFFBFMO.sightWeight = 369f;
			}
			this.KCLACNEILLB.SetFloat("isKeyPress", this.walkSpeed);
		}

		// Token: 0x0600DA71 RID: 55921 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void PNJHMJNFPLP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA72 RID: 55922 RVA: 0x006406FD File Offset: 0x0063E8FD
		private void JGAMNLOICJN()
		{
			GUI.Label(new Rect((float)(Screen.width - 70), 1081f, 2f, 1508f), "Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).");
		}

		// Token: 0x0600DA73 RID: 55923 RVA: 0x0064072C File Offset: 0x0063E92C
		private void PBEKBHFDHAM()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 997f : 1193f, ref this.NCDBMLCEPCH, 1134f);
			if (this.OHGAKFFBFMO.sightWeight < 662f)
			{
				this.OHGAKFFBFMO.sightWeight = 969f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 169f)
			{
				this.OHGAKFFBFMO.sightWeight = 1914f;
			}
			this.KCLACNEILLB.SetFloat("", this.walkSpeed);
		}

		// Token: 0x0600DA74 RID: 55924 RVA: 0x006407CD File Offset: 0x0063E9CD
		private void JCMGHHKALDM()
		{
			GUI.Label(new Rect((float)(Screen.width - -70), 66f, 18f, 595f), "");
		}

		// Token: 0x0600DA76 RID: 55926 RVA: 0x0064080C File Offset: 0x0063EA0C
		private void IPFNFHPFAOE()
		{
			GUI.Label(new Rect((float)(Screen.width - -162), 769f, 515f, 1193f), " ");
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CGFDDFHECLJ()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA78 RID: 55928 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CKGPEFOKKNL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA79 RID: 55929 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void DGEIACONKCJ()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA7A RID: 55930 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void PNAAHEFHPCL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x00640838 File Offset: 0x0063EA38
		private void PDEEOGAAMBB()
		{
			GUI.Label(new Rect((float)(Screen.width - 197), 982f, 1179f, 1090f), "Horizontal");
		}

		// Token: 0x0600DA7C RID: 55932 RVA: 0x00640864 File Offset: 0x0063EA64
		private void HONIFOPBBKC()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 80f : 847f, ref this.NCDBMLCEPCH, 798f);
			if (this.OHGAKFFBFMO.sightWeight < 1925f)
			{
				this.OHGAKFFBFMO.sightWeight = 1661f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1398f)
			{
				this.OHGAKFFBFMO.sightWeight = 1478f;
			}
			this.KCLACNEILLB.SetFloat("TOD_MoonMeshColor", this.walkSpeed);
		}

		// Token: 0x0600DA7D RID: 55933 RVA: 0x00640908 File Offset: 0x0063EB08
		private void BOAJJAKEMLH()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1576f : 323f, ref this.NCDBMLCEPCH, 1992f);
			if (this.OHGAKFFBFMO.sightWeight < 792f)
			{
				this.OHGAKFFBFMO.sightWeight = 369f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 437f)
			{
				this.OHGAKFFBFMO.sightWeight = 643f;
			}
			this.KCLACNEILLB.SetFloat("Middle click", this.walkSpeed);
		}

		// Token: 0x0600DA7E RID: 55934 RVA: 0x006409A9 File Offset: 0x0063EBA9
		private void MFPNPKDDLII()
		{
			GUI.Label(new Rect((float)(Screen.width - -163), 1454f, 1558f, 1728f), "id");
		}

		// Token: 0x0600DA7F RID: 55935 RVA: 0x006409D8 File Offset: 0x0063EBD8
		private void BBFCMCAFOMH()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 917f : 1758f, ref this.NCDBMLCEPCH, 1820f);
			if (this.OHGAKFFBFMO.sightWeight < 1030f)
			{
				this.OHGAKFFBFMO.sightWeight = 1961f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 856f)
			{
				this.OHGAKFFBFMO.sightWeight = 1447f;
			}
			this.KCLACNEILLB.SetFloat("WeaponRunBackward", this.walkSpeed);
		}

		// Token: 0x0600DA80 RID: 55936 RVA: 0x00640A7C File Offset: 0x0063EC7C
		private void FPLNDDMFFKG()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1215f : 566f, ref this.NCDBMLCEPCH, 1830f);
			if (this.OHGAKFFBFMO.sightWeight < 1462f)
			{
				this.OHGAKFFBFMO.sightWeight = 607f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1350f)
			{
				this.OHGAKFFBFMO.sightWeight = 819f;
			}
			this.KCLACNEILLB.SetFloat("_WaterLevel", this.walkSpeed);
		}

		// Token: 0x0600DA81 RID: 55937 RVA: 0x00640B1D File Offset: 0x0063ED1D
		private void KBEOAOKBHEK()
		{
			GUI.Label(new Rect((float)(Screen.width - 143), 1237f, 451f, 344f), "_CurveTex");
		}

		// Token: 0x0600DA82 RID: 55938 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CHDJGEOFHEE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA83 RID: 55939 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CBLGFOFHNPJ()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void ANHOOJFEJJE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA85 RID: 55941 RVA: 0x00640B4C File Offset: 0x0063ED4C
		private void OPDCJCFMIPE()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 907f : 963f, ref this.NCDBMLCEPCH, 1556f);
			if (this.OHGAKFFBFMO.sightWeight < 1291f)
			{
				this.OHGAKFFBFMO.sightWeight = 1330f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 219f)
			{
				this.OHGAKFFBFMO.sightWeight = 886f;
			}
			this.KCLACNEILLB.SetFloat("OfficeSittingReadingPageFlip", this.walkSpeed);
		}

		// Token: 0x0600DA86 RID: 55942 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CGNGBFFGGBP()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA87 RID: 55943 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void PFNPOHMMJDN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA88 RID: 55944 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void EDGALMCHPPH()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA89 RID: 55945 RVA: 0x00640BED File Offset: 0x0063EDED
		private void JJJNMPOAPAA()
		{
			GUI.Label(new Rect((float)(Screen.width - -140), 1811f, 254f, 800f), "OneHandSwordReady");
		}

		// Token: 0x0600DA8A RID: 55946 RVA: 0x00640C19 File Offset: 0x0063EE19
		private void JADGLEGEDGJ()
		{
			GUI.Label(new Rect((float)(Screen.width - 111), 1602f, 1306f, 494f), " ");
		}

		// Token: 0x0600DA8B RID: 55947 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void ACLJDJBJLCD()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA8C RID: 55948 RVA: 0x00640C45 File Offset: 0x0063EE45
		private void MGMMDKNGDCA()
		{
			GUI.Label(new Rect((float)(Screen.width - -103), 644f, 1197f, 1031f), "FOG_OF_WAR_ON");
		}

		// Token: 0x0600DA8D RID: 55949 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void OFGMIEJKMGC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA8E RID: 55950 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void DHJDMKLBLEF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA8F RID: 55951 RVA: 0x00640C71 File Offset: 0x0063EE71
		private void PBADPBBJBEJ()
		{
			GUI.Label(new Rect((float)(Screen.width - -61), 481f, 557f, 442f), "Idle Feed Throw");
		}

		// Token: 0x0600DA90 RID: 55952 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void FJGIBCHABIG()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA91 RID: 55953 RVA: 0x00640CA0 File Offset: 0x0063EEA0
		private void JJFHPGDPHGB()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 964f : 1899f, ref this.NCDBMLCEPCH, 608f);
			if (this.OHGAKFFBFMO.sightWeight < 39f)
			{
				this.OHGAKFFBFMO.sightWeight = 160f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 425f)
			{
				this.OHGAKFFBFMO.sightWeight = 1286f;
			}
			this.KCLACNEILLB.SetFloat("gameban", this.walkSpeed);
		}

		// Token: 0x0600DA92 RID: 55954 RVA: 0x00640D44 File Offset: 0x0063EF44
		private void JLFBDOPFDDJ()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1059f : 1874f, ref this.NCDBMLCEPCH, 1059f);
			if (this.OHGAKFFBFMO.sightWeight < 1218f)
			{
				this.OHGAKFFBFMO.sightWeight = 260f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1951f)
			{
				this.OHGAKFFBFMO.sightWeight = 828f;
			}
			this.KCLACNEILLB.SetFloat("Fire1", this.walkSpeed);
		}

		// Token: 0x0600DA93 RID: 55955 RVA: 0x00640DE8 File Offset: 0x0063EFE8
		private void MIFLHGMPLJD()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1506f : 1197f, ref this.NCDBMLCEPCH, 1835f);
			if (this.OHGAKFFBFMO.sightWeight < 1415f)
			{
				this.OHGAKFFBFMO.sightWeight = 1161f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 421f)
			{
				this.OHGAKFFBFMO.sightWeight = 1043f;
			}
			this.KCLACNEILLB.SetFloat("Boxed", this.walkSpeed);
		}

		// Token: 0x0600DA94 RID: 55956 RVA: 0x00640E89 File Offset: 0x0063F089
		private void MJBLMFLLMAG()
		{
			GUI.Label(new Rect((float)(Screen.width - 111), 1797f, 1383f, 527f), "IceHockeyGoalieSave1");
		}

		// Token: 0x0600DA95 RID: 55957 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void NCBLFNKNEDK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA96 RID: 55958 RVA: 0x00640EB5 File Offset: 0x0063F0B5
		private void NCLNNJIGFOO()
		{
			GUI.Label(new Rect((float)(Screen.width - -192), 1774f, 625f, 924f), "");
		}

		// Token: 0x0600DA97 RID: 55959 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void KIEIPFFEDHC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA98 RID: 55960 RVA: 0x00640EE4 File Offset: 0x0063F0E4
		private void JFGGBEGNAFP()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1185f : 529f, ref this.NCDBMLCEPCH, 1330f);
			if (this.OHGAKFFBFMO.sightWeight < 1728f)
			{
				this.OHGAKFFBFMO.sightWeight = 408f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1943f)
			{
				this.OHGAKFFBFMO.sightWeight = 1891f;
			}
			this.KCLACNEILLB.SetFloat("cntx_close", this.walkSpeed);
		}

		// Token: 0x0600DA99 RID: 55961 RVA: 0x00640F88 File Offset: 0x0063F188
		private void GGGKKEAABKK()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1775f : 1635f, ref this.NCDBMLCEPCH, 190f);
			if (this.OHGAKFFBFMO.sightWeight < 1986f)
			{
				this.OHGAKFFBFMO.sightWeight = 1350f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 80f)
			{
				this.OHGAKFFBFMO.sightWeight = 1103f;
			}
			this.KCLACNEILLB.SetFloat("LDR", this.walkSpeed);
		}

		// Token: 0x0600DA9A RID: 55962 RVA: 0x00641029 File Offset: 0x0063F229
		private void AGBEEDOOOHA()
		{
			GUI.Label(new Rect((float)(Screen.width - -101), 151f, 15f, 400f), "wpn_add/base");
		}

		// Token: 0x0600DA9B RID: 55963 RVA: 0x00641055 File Offset: 0x0063F255
		private void BGJFLKLBOPK()
		{
			GUI.Label(new Rect((float)(Screen.width - 117), 1966f, 456f, 1412f), "");
		}

		// Token: 0x0600DA9C RID: 55964 RVA: 0x00641081 File Offset: 0x0063F281
		private void KGACCCCNDOF()
		{
			GUI.Label(new Rect((float)(Screen.width - -46), 1869f, 1405f, 1959f), "");
		}

		// Token: 0x0600DA9D RID: 55965 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void HEMEEOGJDOE()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DA9E RID: 55966 RVA: 0x006410B0 File Offset: 0x0063F2B0
		private void HMLNMHOMMNO()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1413f : 1396f, ref this.NCDBMLCEPCH, 471f);
			if (this.OHGAKFFBFMO.sightWeight < 1315f)
			{
				this.OHGAKFFBFMO.sightWeight = 1233f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1367f)
			{
				this.OHGAKFFBFMO.sightWeight = 1536f;
			}
			this.KCLACNEILLB.SetFloat("{0}:{1}:{2}:{3}", this.walkSpeed);
		}

		// Token: 0x0600DA9F RID: 55967 RVA: 0x00641151 File Offset: 0x0063F351
		private void FLDMAFHJLNB()
		{
			GUI.Label(new Rect((float)(Screen.width - 159), 1890f, 162f, 426f), "GiantGrabIdle");
		}

		// Token: 0x0600DAA0 RID: 55968 RVA: 0x0064117D File Offset: 0x0063F37D
		private void CKFIKGNJCKB()
		{
			GUI.Label(new Rect((float)(Screen.width - 99), 1571f, 1084f, 1525f), "GAMMA");
		}

		// Token: 0x0600DAA1 RID: 55969 RVA: 0x006411AC File Offset: 0x0063F3AC
		private void MPLCAGFGEBO()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1723f : 1997f, ref this.NCDBMLCEPCH, 1099f);
			if (this.OHGAKFFBFMO.sightWeight < 1926f)
			{
				this.OHGAKFFBFMO.sightWeight = 1482f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 5f)
			{
				this.OHGAKFFBFMO.sightWeight = 763f;
			}
			this.KCLACNEILLB.SetFloat("1HandSwordStrafeLeft", this.walkSpeed);
		}

		// Token: 0x0600DAA2 RID: 55970 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void DMAOHJDKMNN()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAA3 RID: 55971 RVA: 0x0064124D File Offset: 0x0063F44D
		private void LFCIINOHNLB()
		{
			GUI.Label(new Rect((float)(Screen.width - -43), 1216f, 655f, 960f), "sys");
		}

		// Token: 0x0600DAA4 RID: 55972 RVA: 0x0064127C File Offset: 0x0063F47C
		private void INKGAFANFIB()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1175f : 831f, ref this.NCDBMLCEPCH, 981f);
			if (this.OHGAKFFBFMO.sightWeight < 647f)
			{
				this.OHGAKFFBFMO.sightWeight = 1474f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1931f)
			{
				this.OHGAKFFBFMO.sightWeight = 1605f;
			}
			this.KCLACNEILLB.SetFloat("#url Sound ", this.walkSpeed);
		}

		// Token: 0x0600DAA5 RID: 55973 RVA: 0x00641320 File Offset: 0x0063F520
		private void PFPPDNHLCCA()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 920f : 1628f, ref this.NCDBMLCEPCH, 636f);
			if (this.OHGAKFFBFMO.sightWeight < 326f)
			{
				this.OHGAKFFBFMO.sightWeight = 1318f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1903f)
			{
				this.OHGAKFFBFMO.sightWeight = 22f;
			}
			this.KCLACNEILLB.SetFloat("Giant2HandSlamIdle", this.walkSpeed);
		}

		// Token: 0x0600DAA6 RID: 55974 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void MAGJOJDOGKH()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAA7 RID: 55975 RVA: 0x006413C4 File Offset: 0x0063F5C4
		private void LMGBKHCHPHO()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 719f : 527f, ref this.NCDBMLCEPCH, 1501f);
			if (this.OHGAKFFBFMO.sightWeight < 349f)
			{
				this.OHGAKFFBFMO.sightWeight = 899f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 11f)
			{
				this.OHGAKFFBFMO.sightWeight = 142f;
			}
			this.KCLACNEILLB.SetFloat("ANTI_FLICKER", this.walkSpeed);
		}

		// Token: 0x0600DAA8 RID: 55976 RVA: 0x00641468 File Offset: 0x0063F668
		private void IOGAKGCADBL()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 895f : 295f, ref this.NCDBMLCEPCH, 1459f);
			if (this.OHGAKFFBFMO.sightWeight < 640f)
			{
				this.OHGAKFFBFMO.sightWeight = 1327f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 694f)
			{
				this.OHGAKFFBFMO.sightWeight = 577f;
			}
			this.KCLACNEILLB.SetFloat("PistolFire", this.walkSpeed);
		}

		// Token: 0x0600DAA9 RID: 55977 RVA: 0x00641509 File Offset: 0x0063F709
		private void AHEAJPNHBBB()
		{
			GUI.Label(new Rect((float)(Screen.width - -171), 1119f, 1078f, 595f), "IV");
		}

		// Token: 0x0600DAAA RID: 55978 RVA: 0x00641538 File Offset: 0x0063F738
		private void EDEODHDFANE()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 863f : 120f, ref this.NCDBMLCEPCH, 393f);
			if (this.OHGAKFFBFMO.sightWeight < 706f)
			{
				this.OHGAKFFBFMO.sightWeight = 1083f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 990f)
			{
				this.OHGAKFFBFMO.sightWeight = 381f;
			}
			this.KCLACNEILLB.SetFloat("Horizontal", this.walkSpeed);
		}

		// Token: 0x0600DAAB RID: 55979 RVA: 0x006415D9 File Offset: 0x0063F7D9
		private void IBEHHMCBCIH()
		{
			GUI.Label(new Rect((float)(Screen.width - -176), 1508f, 1028f, 219f), " POSITION not found");
		}

		// Token: 0x0600DAAC RID: 55980 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void PNOHGOJEJKL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAAD RID: 55981 RVA: 0x00641608 File Offset: 0x0063F808
		private void JIBKGOFOPHJ()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 198f : 1603f, ref this.NCDBMLCEPCH, 1944f);
			if (this.OHGAKFFBFMO.sightWeight < 1091f)
			{
				this.OHGAKFFBFMO.sightWeight = 788f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1506f)
			{
				this.OHGAKFFBFMO.sightWeight = 735f;
			}
			this.KCLACNEILLB.SetFloat("WalkDehydrated", this.walkSpeed);
		}

		// Token: 0x0600DAAE RID: 55982 RVA: 0x006416AC File Offset: 0x0063F8AC
		private void CIBBPIIDHJH()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1504f : 1194f, ref this.NCDBMLCEPCH, 1495f);
			if (this.OHGAKFFBFMO.sightWeight < 246f)
			{
				this.OHGAKFFBFMO.sightWeight = 90f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 719f)
			{
				this.OHGAKFFBFMO.sightWeight = 1003f;
			}
			this.KCLACNEILLB.SetFloat("_NoiseTilingPerChannel", this.walkSpeed);
		}

		// Token: 0x0600DAAF RID: 55983 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void JPHBPEAMNHB()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x0064174D File Offset: 0x0063F94D
		private void BCJFDHBDAHD()
		{
			GUI.Label(new Rect((float)(Screen.width - -90), 1806f, 1987f, 1816f), "ComeHere");
		}

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x0064177C File Offset: 0x0063F97C
		private void PMKOAHMNBBG()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1091f : 1057f, ref this.NCDBMLCEPCH, 1035f);
			if (this.OHGAKFFBFMO.sightWeight < 1413f)
			{
				this.OHGAKFFBFMO.sightWeight = 1060f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1482f)
			{
				this.OHGAKFFBFMO.sightWeight = 1801f;
			}
			this.KCLACNEILLB.SetFloat("offsets", this.walkSpeed);
		}

		// Token: 0x0600DAB2 RID: 55986 RVA: 0x00641820 File Offset: 0x0063FA20
		private void HAIMGCDKPDC()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1705f : 480f, ref this.NCDBMLCEPCH, 1815f);
			if (this.OHGAKFFBFMO.sightWeight < 1027f)
			{
				this.OHGAKFFBFMO.sightWeight = 84f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 657f)
			{
				this.OHGAKFFBFMO.sightWeight = 1387f;
			}
			this.KCLACNEILLB.SetFloat("paper.wav", this.walkSpeed);
		}

		// Token: 0x0600DAB3 RID: 55987 RVA: 0x006418C1 File Offset: 0x0063FAC1
		private void MHOHPKGCMHC()
		{
			GUI.Label(new Rect((float)(Screen.width - 83), 475f, 848f, 274f), "MotorbikeSuperman");
		}

		// Token: 0x0600DAB4 RID: 55988 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void HDFCIACDDEK()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAB5 RID: 55989 RVA: 0x006418ED File Offset: 0x0063FAED
		private void POFHKNCEHKF()
		{
			GUI.Label(new Rect((float)(Screen.width - -104), 840f, 1931f, 1043f), "ClimbLeft");
		}

		// Token: 0x0600DAB6 RID: 55990 RVA: 0x00641919 File Offset: 0x0063FB19
		private void CKLEENCFBNM()
		{
			GUI.Label(new Rect((float)(Screen.width - 29), 1288f, 2f, 287f), "WRINKLE_MAPS");
		}

		// Token: 0x0600DAB7 RID: 55991 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void JHFAHBIIJDC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAB8 RID: 55992 RVA: 0x00641948 File Offset: 0x0063FB48
		private void IDMCOLDDNCF()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 757f : 1071f, ref this.NCDBMLCEPCH, 1958f);
			if (this.OHGAKFFBFMO.sightWeight < 14f)
			{
				this.OHGAKFFBFMO.sightWeight = 1021f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1904f)
			{
				this.OHGAKFFBFMO.sightWeight = 476f;
			}
			this.KCLACNEILLB.SetFloat("[minwgt]", this.walkSpeed);
		}

		// Token: 0x0600DAB9 RID: 55993 RVA: 0x006419E9 File Offset: 0x0063FBE9
		private void AEFGOFJAKDO()
		{
			GUI.Label(new Rect((float)(Screen.width - 172), 1964f, 413f, 1366f), "Wizard2HandThrow");
		}

		// Token: 0x0600DABA RID: 55994 RVA: 0x00641A15 File Offset: 0x0063FC15
		private void ECLMFCKLJNM()
		{
			GUI.Label(new Rect((float)(Screen.width - 134), 916f, 1163f, 1818f), "error");
		}

		// Token: 0x0600DABB RID: 55995 RVA: 0x00641A41 File Offset: 0x0063FC41
		private void KIEFPGLDOCD()
		{
			GUI.Label(new Rect((float)(Screen.width - 17), 161f, 1964f, 511f), "");
		}

		// Token: 0x0600DABC RID: 55996 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void DPPAAIJCFLC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x00641A6D File Offset: 0x0063FC6D
		private void MJDKGMEPMHK()
		{
			GUI.Label(new Rect((float)(Screen.width - 169), 1771f, 939f, 371f), "\n");
		}

		// Token: 0x0600DABE RID: 55998 RVA: 0x00641A9C File Offset: 0x0063FC9C
		private void PFNOEACNHON()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 608f : 1059f, ref this.NCDBMLCEPCH, 311f);
			if (this.OHGAKFFBFMO.sightWeight < 1683f)
			{
				this.OHGAKFFBFMO.sightWeight = 1995f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1759f)
			{
				this.OHGAKFFBFMO.sightWeight = 49f;
			}
			this.KCLACNEILLB.SetFloat("_FogDownsampled", this.walkSpeed);
		}

		// Token: 0x0600DABF RID: 55999 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void CLHGHANANNL()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAC0 RID: 56000 RVA: 0x00641B40 File Offset: 0x0063FD40
		private void JIFOELPAEHG()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 31f : 1049f, ref this.NCDBMLCEPCH, 1012f);
			if (this.OHGAKFFBFMO.sightWeight < 1533f)
			{
				this.OHGAKFFBFMO.sightWeight = 520f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1735f)
			{
				this.OHGAKFFBFMO.sightWeight = 821f;
			}
			this.KCLACNEILLB.SetFloat("Index", this.walkSpeed);
		}

		// Token: 0x0600DAC1 RID: 56001 RVA: 0x00641BE4 File Offset: 0x0063FDE4
		private void DKOIOBMMAGN()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1487f : 1310f, ref this.NCDBMLCEPCH, 7f);
			if (this.OHGAKFFBFMO.sightWeight < 648f)
			{
				this.OHGAKFFBFMO.sightWeight = 252f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1746f)
			{
				this.OHGAKFFBFMO.sightWeight = 92f;
			}
			this.KCLACNEILLB.SetFloat("?", this.walkSpeed);
		}

		// Token: 0x0600DAC2 RID: 56002 RVA: 0x00641C88 File Offset: 0x0063FE88
		private void DIAIKCBANBK()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 1940f : 1474f, ref this.NCDBMLCEPCH, 923f);
			if (this.OHGAKFFBFMO.sightWeight < 709f)
			{
				this.OHGAKFFBFMO.sightWeight = 1229f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1280f)
			{
				this.OHGAKFFBFMO.sightWeight = 1606f;
			}
			this.KCLACNEILLB.SetFloat("WorkerShovel", this.walkSpeed);
		}

		// Token: 0x0600DAC3 RID: 56003 RVA: 0x00641D29 File Offset: 0x0063FF29
		private void BLCDCEHNNNC()
		{
			GUI.Label(new Rect((float)(Screen.width - 161), 1024f, 1261f, 395f), "_TreatBackfaceHitAsMiss");
		}

		// Token: 0x0600DAC4 RID: 56004 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void BHFMGBNIAMC()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAC5 RID: 56005 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void EHDPACPIBNF()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAC6 RID: 56006 RVA: 0x00641D55 File Offset: 0x0063FF55
		private void OnGUI()
		{
			GUI.Label(new Rect((float)(Screen.width - 210), 10f, 200f, 25f), "Hold RMB to aim down the sight");
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x00641D84 File Offset: 0x0063FF84
		private void PAKOHKKBKHD()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(0) ? 482f : 1060f, ref this.NCDBMLCEPCH, 19f);
			if (this.OHGAKFFBFMO.sightWeight < 1257f)
			{
				this.OHGAKFFBFMO.sightWeight = 583f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1125f)
			{
				this.OHGAKFFBFMO.sightWeight = 186f;
			}
			this.KCLACNEILLB.SetFloat("_UserLut_Params", this.walkSpeed);
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void Start()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DAC9 RID: 56009 RVA: 0x0063FF73 File Offset: 0x0063E173
		private void KECMAHFJBCD()
		{
			this.KCLACNEILLB = base.GetComponent<Animator>();
			this.OHGAKFFBFMO = base.GetComponent<FPSAiming>();
		}

		// Token: 0x0600DACA RID: 56010 RVA: 0x00641E25 File Offset: 0x00640025
		private void GLJJBDNLANI()
		{
			GUI.Label(new Rect((float)(Screen.width - -28), 1125f, 30f, 1419f), "");
		}

		// Token: 0x0600DACB RID: 56011 RVA: 0x00641E54 File Offset: 0x00640054
		private void ACFEBEDDIAI()
		{
			this.OHGAKFFBFMO.sightWeight = Mathf.SmoothDamp(this.OHGAKFFBFMO.sightWeight, Input.GetMouseButton(1) ? 1506f : 1861f, ref this.NCDBMLCEPCH, 369f);
			if (this.OHGAKFFBFMO.sightWeight < 577f)
			{
				this.OHGAKFFBFMO.sightWeight = 211f;
			}
			if (this.OHGAKFFBFMO.sightWeight > 1698f)
			{
				this.OHGAKFFBFMO.sightWeight = 674f;
			}
			this.KCLACNEILLB.SetFloat("CrouchStrafeLeft", this.walkSpeed);
		}

		// Token: 0x0600DACC RID: 56012 RVA: 0x00641EF5 File Offset: 0x006400F5
		private void PNJNNNJEBGA()
		{
			GUI.Label(new Rect((float)(Screen.width - -198), 1600f, 296f, 309f), "InteractionSystem can not find a FullBodyBipedIK component");
		}

		// Token: 0x04001CFF RID: 7423
		[Range(0f, 1f)]
		public float walkSpeed = 0.5f;

		// Token: 0x04001D00 RID: 7424
		private float NCDBMLCEPCH;

		// Token: 0x04001D01 RID: 7425
		private Animator KCLACNEILLB;

		// Token: 0x04001D02 RID: 7426
		private FPSAiming OHGAKFFBFMO;
	}
}
