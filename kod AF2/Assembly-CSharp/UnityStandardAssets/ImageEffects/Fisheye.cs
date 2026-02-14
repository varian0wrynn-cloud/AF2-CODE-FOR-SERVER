using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000321 RID: 801
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Fisheye : PostEffectsBase
	{
		// Token: 0x0600B751 RID: 46929 RVA: 0x0051A09C File Offset: 0x0051829C
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 742f;
			float num2 = (float)JONJODLFAEN.width * 1694f / ((float)JONJODLFAEN.height * 522f);
			this.GFDDPBELFPL.SetVector("{0} {1} {2} {3}", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x0051A124 File Offset: 0x00518324
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1853f;
			float num2 = (float)JONJODLFAEN.width * 189f / ((float)JONJODLFAEN.height * 1841f);
			this.GFDDPBELFPL.SetVector("Transform is null.", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x0051A1AC File Offset: 0x005183AC
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 99f;
			float num2 = (float)JONJODLFAEN.width * 1804f / ((float)JONJODLFAEN.height * 716f);
			this.GFDDPBELFPL.SetVector("knopje.wav", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x0051A231 File Offset: 0x00518431
		public virtual bool DKMLGBCDFLG()
		{
			base.NHCAHIHJHMF(true);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x0051A267 File Offset: 0x00518467
		public virtual bool DPGLLLMLAAB()
		{
			base.OLMOAHDIDNG(false);
			this.GFDDPBELFPL = base.IIIIADNBONI(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x0051A29D File Offset: 0x0051849D
		public virtual bool OLEILCHLACC()
		{
			base.CGEGCOKMPHN(false);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x0051A2D4 File Offset: 0x005184D4
		private void DLOGCPJNGLM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 299f;
			float num2 = (float)JONJODLFAEN.width * 1624f / ((float)JONJODLFAEN.height * 1558f);
			this.GFDDPBELFPL.SetVector("_WaterLevel", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x0051A35C File Offset: 0x0051855C
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1527f;
			float num2 = (float)JONJODLFAEN.width * 735f / ((float)JONJODLFAEN.height * 694f);
			this.GFDDPBELFPL.SetVector("error baseid: ", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x0051A3E4 File Offset: 0x005185E4
		private void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 860f;
			float num2 = (float)JONJODLFAEN.width * 275f / ((float)JONJODLFAEN.height * 152f);
			this.GFDDPBELFPL.SetVector("Grounding pelvis is null. Can't initiate Grounding.", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x0051A469 File Offset: 0x00518669
		public virtual bool NFFLLNPGHNC()
		{
			base.CGEGCOKMPHN(false);
			this.GFDDPBELFPL = base.ALJPMGLOIEG(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x0051A4A0 File Offset: 0x005186A0
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1268f;
			float num2 = (float)JONJODLFAEN.width * 583f / ((float)JONJODLFAEN.height * 1384f);
			this.GFDDPBELFPL.SetVector("Hidden/Post FX/Blit", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x0051A525 File Offset: 0x00518725
		public virtual bool PNMIMCJGPGL()
		{
			base.PKDIKFGAJKM(true);
			this.GFDDPBELFPL = base.OOAOHFFDMJP(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x0051A55B File Offset: 0x0051875B
		public virtual bool NLCKKCKGJDN()
		{
			base.OFKOBOMCECF(false);
			this.GFDDPBELFPL = base.ALJPMGLOIEG(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x0051A591 File Offset: 0x00518791
		public override bool MNDOFMMGLMO()
		{
			base.LGANGHEOPOG(false);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x0051A5C7 File Offset: 0x005187C7
		public virtual bool DCEJLCLOCJC()
		{
			base.DAOKCAOFIGE(false);
			this.GFDDPBELFPL = base.BAPJBHPEDIF(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x0051A600 File Offset: 0x00518800
		private void EKMKDLLLGFB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1678f;
			float num2 = (float)JONJODLFAEN.width * 363f / ((float)JONJODLFAEN.height * 1085f);
			this.GFDDPBELFPL.SetVector("Zombie Crawl", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x0051A688 File Offset: 0x00518888
		private void EEDJEMLFJKP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 52f;
			float num2 = (float)JONJODLFAEN.width * 674f / ((float)JONJODLFAEN.height * 1942f);
			this.GFDDPBELFPL.SetVector("{0}", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x0051A70D File Offset: 0x0051890D
		public virtual bool JPEBNJPIFAF()
		{
			base.CGEGCOKMPHN(true);
			this.GFDDPBELFPL = base.OOAOHFFDMJP(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x0051A744 File Offset: 0x00518944
		private void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1348f;
			float num2 = (float)JONJODLFAEN.width * 1234f / ((float)JONJODLFAEN.height * 1343f);
			this.GFDDPBELFPL.SetVector("Mouse X", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x0051A7CC File Offset: 0x005189CC
		private void DNPIJGHMNGK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1248f;
			float num2 = (float)JONJODLFAEN.width * 1265f / ((float)JONJODLFAEN.height * 612f);
			this.GFDDPBELFPL.SetVector("Assets/Weapons/", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x0051A854 File Offset: 0x00518A54
		private void BMJCNICLDEK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1362f;
			float num2 = (float)JONJODLFAEN.width * 29f / ((float)JONJODLFAEN.height * 1382f);
			this.GFDDPBELFPL.SetVector("Kernel", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x0051A8D9 File Offset: 0x00518AD9
		public virtual bool PNGJGNKGLIG()
		{
			base.EHGENDOEHLP(true);
			this.GFDDPBELFPL = base.IIIIADNBONI(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B768 RID: 46952 RVA: 0x0051A930 File Offset: 0x00518B30
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1018f;
			float num2 = (float)JONJODLFAEN.width * 1714f / ((float)JONJODLFAEN.height * 663f);
			this.GFDDPBELFPL.SetVector("IdleStrafeRight", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B769 RID: 46953 RVA: 0x0051A9B5 File Offset: 0x00518BB5
		public virtual bool JOAPNOCFFBG()
		{
			base.OAAFLHNDKBJ(false);
			this.GFDDPBELFPL = base.OOAOHFFDMJP(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x0051A9EC File Offset: 0x00518BEC
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 791f;
			float num2 = (float)JONJODLFAEN.width * 690f / ((float)JONJODLFAEN.height * 1024f);
			this.GFDDPBELFPL.SetVector("'>", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x0051AA74 File Offset: 0x00518C74
		private void LIKPOPLLIDJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1393f;
			float num2 = (float)JONJODLFAEN.width * 599f / ((float)JONJODLFAEN.height * 713f);
			this.GFDDPBELFPL.SetVector("Mouse ScrollWheel", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x0051AAFC File Offset: 0x00518CFC
		private void CONNCGCNJPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1146f;
			float num2 = (float)JONJODLFAEN.width * 1774f / ((float)JONJODLFAEN.height * 986f);
			this.GFDDPBELFPL.SetVector("Wheely", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x0051AB84 File Offset: 0x00518D84
		private void FEAGGDCEGFE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 33f;
			float num2 = (float)JONJODLFAEN.width * 1604f / ((float)JONJODLFAEN.height * 1687f);
			this.GFDDPBELFPL.SetVector("time_format2", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x0051AC09 File Offset: 0x00518E09
		public virtual bool POKDAEAADAC()
		{
			base.LGANGHEOPOG(true);
			this.GFDDPBELFPL = base.BOOFEOGDMBI(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x0051AC3F File Offset: 0x00518E3F
		public virtual bool MANMIKHECBF()
		{
			base.NHCAHIHJHMF(false);
			this.GFDDPBELFPL = base.BAPJBHPEDIF(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B770 RID: 46960 RVA: 0x0051AC75 File Offset: 0x00518E75
		public virtual bool NGKAKAAKDJH()
		{
			base.BGIALJEIEFO(true);
			this.GFDDPBELFPL = base.IIIIADNBONI(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x0051ACAC File Offset: 0x00518EAC
		private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 836f;
			float num2 = (float)JONJODLFAEN.width * 824f / ((float)JONJODLFAEN.height * 1464f);
			this.GFDDPBELFPL.SetVector("sadokfull", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x0051AD34 File Offset: 0x00518F34
		private void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1330f;
			float num2 = (float)JONJODLFAEN.width * 248f / ((float)JONJODLFAEN.height * 1164f);
			this.GFDDPBELFPL.SetVector("OfficeSittingBack", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x0051ADB9 File Offset: 0x00518FB9
		public virtual bool EPOEAKJPIEE()
		{
			base.EHGENDOEHLP(true);
			this.GFDDPBELFPL = base.BAPJBHPEDIF(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x0051ADF0 File Offset: 0x00518FF0
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1821f;
			float num2 = (float)JONJODLFAEN.width * 479f / ((float)JONJODLFAEN.height * 165f);
			this.GFDDPBELFPL.SetVector("Idle Stand", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x0051AE78 File Offset: 0x00519078
		private void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 968f;
			float num2 = (float)JONJODLFAEN.width * 1507f / ((float)JONJODLFAEN.height * 1485f);
			this.GFDDPBELFPL.SetVector("<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B776 RID: 46966 RVA: 0x0051AEFD File Offset: 0x005190FD
		public virtual bool KPDPMCNDNOA()
		{
			base.CDBNBLBOLCL(false);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B777 RID: 46967 RVA: 0x0051AF33 File Offset: 0x00519133
		public override bool GGJKGIHGMGC()
		{
			base.EHGENDOEHLP(false);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x0051AF6C File Offset: 0x0051916C
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 194f;
			float num2 = (float)JONJODLFAEN.width * 1913f / ((float)JONJODLFAEN.height * 1603f);
			this.GFDDPBELFPL.SetVector("{0} {1}.{2} ({3:f2}, {4:f2})  {5}", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x0051AFF4 File Offset: 0x005191F4
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1931f;
			float num2 = (float)JONJODLFAEN.width * 783f / ((float)JONJODLFAEN.height * 1365f);
			this.GFDDPBELFPL.SetVector("LocationGui.getI.backLockImage.rectTransform is null", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x0051B07C File Offset: 0x0051927C
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1827f;
			float num2 = (float)JONJODLFAEN.width * 1556f / ((float)JONJODLFAEN.height * 881f);
			this.GFDDPBELFPL.SetVector("_LrDepthTex", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x0051B101 File Offset: 0x00519301
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x0051B138 File Offset: 0x00519338
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 875f;
			float num2 = (float)JONJODLFAEN.width * 81f / ((float)JONJODLFAEN.height * 679f);
			this.GFDDPBELFPL.SetVector("CCDIK not found!", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x0051B1C0 File Offset: 0x005193C0
		private void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1578f;
			float num2 = (float)JONJODLFAEN.width * 1762f / ((float)JONJODLFAEN.height * 1738f);
			this.GFDDPBELFPL.SetVector("Hidden/Amplify Color/BlendCache", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x0051B245 File Offset: 0x00519445
		public virtual bool DEHFEHNMOFH()
		{
			base.OLMOAHDIDNG(false);
			this.GFDDPBELFPL = base.OOAOHFFDMJP(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x0051B27B File Offset: 0x0051947B
		public virtual bool CPIFBHFDEFO()
		{
			base.NHCAHIHJHMF(false);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x0051B2B4 File Offset: 0x005194B4
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 371f;
			float num2 = (float)JONJODLFAEN.width * 623f / ((float)JONJODLFAEN.height * 731f);
			this.GFDDPBELFPL.SetVector("_Opacity", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x0051B339 File Offset: 0x00519539
		public virtual bool OJFBHAHHDNC()
		{
			base.NHCAHIHJHMF(true);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x0051B36F File Offset: 0x0051956F
		public virtual bool HHCKHLDCKMF()
		{
			base.OLMOAHDIDNG(false);
			this.GFDDPBELFPL = base.ALJPMGLOIEG(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x0051B3A8 File Offset: 0x005195A8
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 93f;
			float num2 = (float)JONJODLFAEN.width * 265f / ((float)JONJODLFAEN.height * 51f);
			this.GFDDPBELFPL.SetVector("_BaseTex", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x0051B430 File Offset: 0x00519630
		private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1855f;
			float num2 = (float)JONJODLFAEN.width * 1610f / ((float)JONJODLFAEN.height * 167f);
			this.GFDDPBELFPL.SetVector("' is not a valid integer", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x0051B4B8 File Offset: 0x005196B8
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1090f;
			float num2 = (float)JONJODLFAEN.width * 776f / ((float)JONJODLFAEN.height * 1264f);
			this.GFDDPBELFPL.SetVector("_ProjectionInv", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x0051B53D File Offset: 0x0051973D
		public virtual bool PPJAMONPAPC()
		{
			base.EBEBJHLBBBI(true);
			this.GFDDPBELFPL = base.BAPJBHPEDIF(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x0051B573 File Offset: 0x00519773
		public virtual bool ILBEKBHHEEL()
		{
			base.CGEGCOKMPHN(true);
			this.GFDDPBELFPL = base.BOOFEOGDMBI(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x0051B5A9 File Offset: 0x005197A9
		public virtual bool LNHMJPEKJPH()
		{
			base.LGANGHEOPOG(false);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x0051B5E0 File Offset: 0x005197E0
		private void HOACOEINOJB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1711f;
			float num2 = (float)JONJODLFAEN.width * 1737f / ((float)JONJODLFAEN.height * 360f);
			this.GFDDPBELFPL.SetVector("_ChromaticAberration", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x0051B665 File Offset: 0x00519865
		public virtual bool NEOHPOGEHNF()
		{
			base.CBJDCDELBJN(true);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x0051B69B File Offset: 0x0051989B
		public virtual bool LBKOJOCPFJG()
		{
			base.CBJDCDELBJN(false);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x0051B6D4 File Offset: 0x005198D4
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1354f;
			float num2 = (float)JONJODLFAEN.width * 608f / ((float)JONJODLFAEN.height * 370f);
			this.GFDDPBELFPL.SetVector("RollerBladeFrontFlip", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x0051B75C File Offset: 0x0051995C
		private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1700f;
			float num2 = (float)JONJODLFAEN.width * 1703f / ((float)JONJODLFAEN.height * 215f);
			this.GFDDPBELFPL.SetVector("\n", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x0051B7E1 File Offset: 0x005199E1
		public virtual bool DGLPHOKKFDC()
		{
			base.CBJDCDELBJN(true);
			this.GFDDPBELFPL = base.IIIIADNBONI(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x0051B818 File Offset: 0x00519A18
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 386f;
			float num2 = (float)JONJODLFAEN.width * 1947f / ((float)JONJODLFAEN.height * 1985f);
			this.GFDDPBELFPL.SetVector("Packet processor error cmd: ", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B790 RID: 46992 RVA: 0x0051B8A0 File Offset: 0x00519AA0
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1203f;
			float num2 = (float)JONJODLFAEN.width * 1985f / ((float)JONJODLFAEN.height * 1805f);
			this.GFDDPBELFPL.SetVector("startA", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x0051B928 File Offset: 0x00519B28
		private void HLLKILIIBGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 874f;
			float num2 = (float)JONJODLFAEN.width * 915f / ((float)JONJODLFAEN.height * 1632f);
			this.GFDDPBELFPL.SetVector("Bone", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x0051B9AD File Offset: 0x00519BAD
		public virtual bool CGJBGGCEBAO()
		{
			base.CBJDCDELBJN(true);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x0051B9E4 File Offset: 0x00519BE4
		private void EIBBJMGHBLC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 504f;
			float num2 = (float)JONJODLFAEN.width * 113f / ((float)JONJODLFAEN.height * 874f);
			this.GFDDPBELFPL.SetVector("auk_wavg", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x0051BA69 File Offset: 0x00519C69
		public virtual bool JKMNILOPECN()
		{
			base.EHGENDOEHLP(false);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x0051BAA0 File Offset: 0x00519CA0
		private void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 962f;
			float num2 = (float)JONJODLFAEN.width * 1287f / ((float)JONJODLFAEN.height * 1357f);
			this.GFDDPBELFPL.SetVector("1HandSwordChargeUp", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x0051BB28 File Offset: 0x00519D28
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 0.15625f;
			float num2 = (float)JONJODLFAEN.width * 1f / ((float)JONJODLFAEN.height * 1f);
			this.GFDDPBELFPL.SetVector("intensity", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x0051BBAD File Offset: 0x00519DAD
		public virtual bool AHMAHFLOJBM()
		{
			base.MGHNCKDCFGL(false);
			this.GFDDPBELFPL = base.ALJPMGLOIEG(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x0051BBE4 File Offset: 0x00519DE4
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1848f;
			float num2 = (float)JONJODLFAEN.width * 573f / ((float)JONJODLFAEN.height * 540f);
			this.GFDDPBELFPL.SetVector("/", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x0051BC6C File Offset: 0x00519E6C
		private void MMLCIGHEHJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 428f;
			float num2 = (float)JONJODLFAEN.width * 1906f / ((float)JONJODLFAEN.height * 1680f);
			this.GFDDPBELFPL.SetVector("2000", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B79A RID: 47002 RVA: 0x0051BCF4 File Offset: 0x00519EF4
		private void LNLFICAJADP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1904f;
			float num2 = (float)JONJODLFAEN.width * 689f / ((float)JONJODLFAEN.height * 1671f);
			this.GFDDPBELFPL.SetVector("RangeMarker", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x0051BD79 File Offset: 0x00519F79
		public virtual bool IIKPOFNDHFM()
		{
			base.CBJDCDELBJN(true);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x0051BDB0 File Offset: 0x00519FB0
		private void FEKDECGCLCJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 235f;
			float num2 = (float)JONJODLFAEN.width * 1627f / ((float)JONJODLFAEN.height * 1533f);
			this.GFDDPBELFPL.SetVector("Roll", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B79D RID: 47005 RVA: 0x0051BE35 File Offset: 0x0051A035
		public virtual bool PKLOCPBBHNH()
		{
			base.BGIALJEIEFO(false);
			this.GFDDPBELFPL = base.IIIIADNBONI(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B79E RID: 47006 RVA: 0x0051BE6B File Offset: 0x0051A06B
		public virtual bool KFLGCBLCKJD()
		{
			base.IDFIHFBEIKD(true);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B79F RID: 47007 RVA: 0x0051BEA4 File Offset: 0x0051A0A4
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 1106f;
			float num2 = (float)JONJODLFAEN.width * 433f / ((float)JONJODLFAEN.height * 1606f);
			this.GFDDPBELFPL.SetVector("repair.ogg", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B7A0 RID: 47008 RVA: 0x0051BF2C File Offset: 0x0051A12C
		private void MCCMFFLILNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			float num = 414f;
			float num2 = (float)JONJODLFAEN.width * 137f / ((float)JONJODLFAEN.height * 491f);
			this.GFDDPBELFPL.SetVector("Assets/Weapons/wbaseLegs.unity3d", new Vector4(this.strengthX * num2 * num, this.strengthY * num, this.strengthX * num2 * num, this.strengthY * num));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GFDDPBELFPL);
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x0051BFB1 File Offset: 0x0051A1B1
		public virtual bool CFHOHAOFPIO()
		{
			base.AHFDGALLKFC(true);
			this.GFDDPBELFPL = base.JBHLGBPJFEL(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x0051BFE7 File Offset: 0x0051A1E7
		public virtual bool CFODPFPIHIF()
		{
			base.EHGENDOEHLP(true);
			this.GFDDPBELFPL = base.DJFOEIJIMJB(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x0051C01D File Offset: 0x0051A21D
		public virtual bool FLJEDBINFJC()
		{
			base.OLMOAHDIDNG(true);
			this.GFDDPBELFPL = base.OOAOHFFDMJP(this.fishEyeShader, this.GFDDPBELFPL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x040017F8 RID: 6136
		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		// Token: 0x040017F9 RID: 6137
		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		// Token: 0x040017FA RID: 6138
		public Shader fishEyeShader;

		// Token: 0x040017FB RID: 6139
		private Material GFDDPBELFPL;
	}
}
