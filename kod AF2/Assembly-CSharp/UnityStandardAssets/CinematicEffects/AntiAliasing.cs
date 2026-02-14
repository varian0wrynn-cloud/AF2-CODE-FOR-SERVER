using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000347 RID: 839
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("Image Effects/Anti-aliasing")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class AntiAliasing : MonoBehaviour
	{
		// Token: 0x0600BEEC RID: 48876 RVA: 0x0056447A File Offset: 0x0056267A
		public MNAIGPKICAE JNGGMFDOKHJ()
		{
			if (this.CLMECBOCGCA() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600BEED RID: 48877 RVA: 0x00564491 File Offset: 0x00562691
		private void DGFPAAOANCE()
		{
			this.HPDIDCEIKNB().GEKDJDMHMKC(this.PHDAGKLKGLL);
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x005644A4 File Offset: 0x005626A4
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.HDGCIMPLICJ.BPPEDFOAHLK(this.PHDAGKLKGLL, JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x005644B9 File Offset: 0x005626B9
		public int CLMECBOCGCA()
		{
			return this.m_Method;
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600BEF0 RID: 48880 RVA: 0x005644C1 File Offset: 0x005626C1
		public MNAIGPKICAE HDGCIMPLICJ
		{
			get
			{
				if (this.FIBNBHLLNHI == 0)
				{
					return this.m_SMAA;
				}
				return this.m_FXAA;
			}
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x005644D8 File Offset: 0x005626D8
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.JNGGMFDOKHJ().BPPEDFOAHLK(this.PHDAGKLKGLL, JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BEF2 RID: 48882 RVA: 0x0056447A File Offset: 0x0056267A
		public MNAIGPKICAE HPDIDCEIKNB()
		{
			if (this.CLMECBOCGCA() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600BEF3 RID: 48883 RVA: 0x005644ED File Offset: 0x005626ED
		private void PCKEAEAHAKG()
		{
			this.m_SMAA.NOLGMGLINIJ();
			this.m_FXAA.GPCIBDPEAAE();
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x00564505 File Offset: 0x00562705
		private void MLPCBOGCEEO()
		{
			this.m_SMAA.BPDNFFGPMPP();
			this.m_FXAA.BKFHJFNCPAA();
		}

		// Token: 0x0600BEF5 RID: 48885 RVA: 0x0056451D File Offset: 0x0056271D
		private void OnDisable()
		{
			this.m_SMAA.BKFHJFNCPAA();
			this.m_FXAA.BKFHJFNCPAA();
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x00564535 File Offset: 0x00562735
		private void OnPostRender()
		{
			this.HDGCIMPLICJ.GEKDJDMHMKC(this.PHDAGKLKGLL);
		}

		// Token: 0x0600BEF7 RID: 48887 RVA: 0x00564548 File Offset: 0x00562748
		public MNAIGPKICAE FEKNGNLOABG()
		{
			if (this.AJEELFKFGKI() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x0056447A File Offset: 0x0056267A
		public MNAIGPKICAE DLBLDMCFNLJ()
		{
			if (this.CLMECBOCGCA() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600BEF9 RID: 48889 RVA: 0x0056455F File Offset: 0x0056275F
		private void JKDCKHECHEJ()
		{
			this.m_SMAA.NOLGMGLINIJ();
			this.m_FXAA.PBDNGIFDEFC();
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x00564577 File Offset: 0x00562777
		private void MPNHAGONKBG()
		{
			this.m_SMAA.IEHEAJJALNG(this);
			this.m_FXAA.INEHANLJIEM(this);
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x0056447A File Offset: 0x0056267A
		public MNAIGPKICAE MLBELMCPFIC()
		{
			if (this.CLMECBOCGCA() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600BEFD RID: 48893 RVA: 0x005645AF File Offset: 0x005627AF
		private void OnEnable()
		{
			this.m_SMAA.ADBAOPJBGHG(this);
			this.m_FXAA.ADBAOPJBGHG(this);
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600BEFE RID: 48894 RVA: 0x005644B9 File Offset: 0x005626B9
		// (set) Token: 0x0600BF00 RID: 48896 RVA: 0x005645DC File Offset: 0x005627DC
		public int FIBNBHLLNHI
		{
			get
			{
				return this.m_Method;
			}
			set
			{
				if (this.m_Method == value)
				{
					return;
				}
				this.m_Method = value;
			}
		}

		// Token: 0x0600BEFF RID: 48895 RVA: 0x005645C9 File Offset: 0x005627C9
		private void OnPreCull()
		{
			this.HDGCIMPLICJ.OEMNNJHHGCI(this.PHDAGKLKGLL);
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600BF01 RID: 48897 RVA: 0x005645EF File Offset: 0x005627EF
		public Camera PHDAGKLKGLL
		{
			get
			{
				if (this.MPCEHPBGHII == null)
				{
					this.MPCEHPBGHII = base.GetComponent<Camera>();
				}
				return this.MPCEHPBGHII;
			}
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x005644C1 File Offset: 0x005626C1
		public MNAIGPKICAE GKHHGPPJANK()
		{
			if (this.FIBNBHLLNHI == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x00564611 File Offset: 0x00562811
		private void INEHANLJIEM()
		{
			this.m_SMAA.NKKHCJDLMII(this);
			this.m_FXAA.ADBAOPJBGHG(this);
		}

		// Token: 0x0600BF04 RID: 48900 RVA: 0x0056462B File Offset: 0x0056282B
		private void KPHHOEJCMMO()
		{
			this.MLBELMCPFIC().OEMNNJHHGCI(this.PHDAGKLKGLL);
		}

		// Token: 0x0600BF05 RID: 48901 RVA: 0x0056463E File Offset: 0x0056283E
		private void KOAEBJLNOLI()
		{
			this.m_SMAA.IEHEAJJALNG(this);
			this.m_FXAA.ADBAOPJBGHG(this);
		}

		// Token: 0x0600BF06 RID: 48902 RVA: 0x00564548 File Offset: 0x00562748
		public MNAIGPKICAE IHDDFOPCKNP()
		{
			if (this.AJEELFKFGKI() == 0)
			{
				return this.m_SMAA;
			}
			return this.m_FXAA;
		}

		// Token: 0x0600BF07 RID: 48903 RVA: 0x00564658 File Offset: 0x00562858
		private void AHMFIGNLJOB()
		{
			this.m_SMAA.NOLGMGLINIJ();
			this.m_FXAA.EILDKNMOKBB();
		}

		// Token: 0x0600BF08 RID: 48904 RVA: 0x00564670 File Offset: 0x00562870
		private void IBOMADDAFAO()
		{
			this.m_SMAA.FLPMJFEGJLG(this);
			this.m_FXAA.INEHANLJIEM(this);
		}

		// Token: 0x0600BF09 RID: 48905 RVA: 0x005644B9 File Offset: 0x005626B9
		public int AJEELFKFGKI()
		{
			return this.m_Method;
		}

		// Token: 0x040018DC RID: 6364
		[SerializeField]
		private SMAA m_SMAA = new SMAA();

		// Token: 0x040018DD RID: 6365
		[SerializeField]
		private FXAA m_FXAA = new FXAA();

		// Token: 0x040018DE RID: 6366
		[SerializeField]
		[HideInInspector]
		private int m_Method;

		// Token: 0x040018DF RID: 6367
		private Camera MPCEHPBGHII;

		// Token: 0x02000348 RID: 840
		public enum LLEKDDEBKKP
		{
			// Token: 0x040018E1 RID: 6369
			Smaa,
			// Token: 0x040018E2 RID: 6370
			Fxaa
		}
	}
}
