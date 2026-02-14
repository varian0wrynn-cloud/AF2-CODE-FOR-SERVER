using System;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002B3 RID: 691
	[HelpURL("http://kronnect.com/taptapgo")]
	[ExecuteInEditMode]
	public class DynamicFogManager : MonoBehaviour
	{
		// Token: 0x0600A224 RID: 41508 RVA: 0x0048A880 File Offset: 0x00488A80
		private void BAICIKOCDFP()
		{
			Vector4 vector = new Vector4(this.height + 29f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("-", vector);
			Shader.SetGlobalFloat("wpn_eat5", this.distanceFallOff * vector.z + 949f);
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x0048A8E5 File Offset: 0x00488AE5
		private void AMGINIANPFJ()
		{
			this.ILEDDOGLHJD();
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x0048A8ED File Offset: 0x00488AED
		private void EFCHIOAONJF()
		{
			this.FNEAKHPLPBC();
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x0048A8F8 File Offset: 0x00488AF8
		private void BDOCIAAEGLL()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(174f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("BowFire2", value);
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x0048AA08 File Offset: 0x00488C08
		private void GCCAPOHGAHA()
		{
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = false;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.CACKDKFHOJN();
				}
			}
			this.MGMNFLHEHPF();
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x0048AA90 File Offset: 0x00488C90
		private void NCFOHPPKLNN()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(834f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("id", value);
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x0048AB9D File Offset: 0x00488D9D
		private void MIFKCBJPDDI()
		{
			this.UpdateMaterialProperties();
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x0048ABA5 File Offset: 0x00488DA5
		private void AOEMHBKCBHA()
		{
			this.NNALCCKMELF();
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x0048ABB0 File Offset: 0x00488DB0
		private void Update()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.BMJEEMGBMFP();
				}
			}
			this.MOGAMBDPLGF();
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x0048AC36 File Offset: 0x00488E36
		public void AEPCMDEPLGG()
		{
			this.MOGAMBDPLGF();
			this.HHHGFKKPEJE();
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x0048AC44 File Offset: 0x00488E44
		private void PDKKCMJMEKJ()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(440f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("_", value);
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x0048AB9D File Offset: 0x00488D9D
		private void FJOBBDEIFOO()
		{
			this.UpdateMaterialProperties();
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x0048AD51 File Offset: 0x00488F51
		private void MJGKKNEHHKG()
		{
			this.EKBFJDGJINM();
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x0048AD59 File Offset: 0x00488F59
		private void FALJEAIANJG()
		{
			this.NBPAJOLHACA();
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x0048AD64 File Offset: 0x00488F64
		private void IOGAKGCADBL()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.NIEBOKPICPO();
				}
			}
			this.JIBJMDPNOPA();
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x0048ADEA File Offset: 0x00488FEA
		private void PCJAGJKHLHN()
		{
			this.LOIBEOFGBPD();
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x0048ADF2 File Offset: 0x00488FF2
		public void GJOLGNEPNPC()
		{
			this.MGMNFLHEHPF();
			this.NKPNBMGPDCM();
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x0048AE00 File Offset: 0x00489000
		private void LBKOIJKMCOL()
		{
			this.MKCCLACGDBD();
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x0048AE08 File Offset: 0x00489008
		private void OIBIGDFPHGO()
		{
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = false;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.BJHPJAOLOFA();
				}
			}
			this.EDCAFHGJENK();
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x0048AE90 File Offset: 0x00489090
		private void EGAEDOHFAJE()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = false;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.PDKKCMJMEKJ();
				}
			}
			this.MIPGKKOLBLC();
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x0048AF18 File Offset: 0x00489118
		private void PPOLFBODOFE()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(498f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("Hidden/Post FX/Grain Generator", value);
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x0048B028 File Offset: 0x00489228
		private void NIEBOKPICPO()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(523f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("Player", value);
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x0048B138 File Offset: 0x00489338
		private void HNOMCGFDCLC()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1929f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("MotorbikeHandstand", value);
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x0048B248 File Offset: 0x00489448
		private void MEIOHFKFEME()
		{
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.NKPNBMGPDCM();
				}
			}
			this.CHANJEBGLKE();
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x0048B365 File Offset: 0x00489565
		public void KLKICOBHHAD()
		{
			this.MGMNFLHEHPF();
			this.HHHGFKKPEJE();
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x0048A8ED File Offset: 0x00488AED
		private void LAHNGMMPPIM()
		{
			this.FNEAKHPLPBC();
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x0048B374 File Offset: 0x00489574
		private void NLMJPHIEDPB()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(506f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("error.wav", value);
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x0048B481 File Offset: 0x00489681
		private void DLPCDAIHLKP()
		{
			this.FILEFLMILJK();
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x0048B489 File Offset: 0x00489689
		public void MKCCLACGDBD()
		{
			this.GFLCEBOPFAD();
			this.NLMJPHIEDPB();
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x0048B498 File Offset: 0x00489698
		private void GFLCEBOPFAD()
		{
			Vector4 vector = new Vector4(this.height + 1309f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("WorkerHammer2", vector);
			Shader.SetGlobalFloat("MotorbikeLassoFwd", this.distanceFallOff * vector.z + 1132f);
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x0048B4FD File Offset: 0x004896FD
		public void EKBFJDGJINM()
		{
			this.MGMNFLHEHPF();
			this.GJHHKBELPCI();
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x0048B50B File Offset: 0x0048970B
		private void CPAAMONJPLC()
		{
			this.KPKCCHKELHF();
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x0048B514 File Offset: 0x00489714
		private void LHCPIKHAILN()
		{
			Vector4 vector = new Vector4(this.height + 508f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("priceCr", vector);
			Shader.SetGlobalFloat("ALP=", this.distanceFallOff * vector.z + 208f);
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x0048B579 File Offset: 0x00489779
		private void BOMPGKHDOJE()
		{
			this.CNPKOGOOLDJ();
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x0048AB9D File Offset: 0x00488D9D
		private void Reset()
		{
			this.UpdateMaterialProperties();
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x0048B581 File Offset: 0x00489781
		public void UpdateMaterialProperties()
		{
			this.MOGAMBDPLGF();
			this.BMJEEMGBMFP();
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x0048B590 File Offset: 0x00489790
		private void MIPGKKOLBLC()
		{
			Vector4 vector = new Vector4(this.height + 1480f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("ObscuredDouble vs double, ", vector);
			Shader.SetGlobalFloat("{0}wind_rose.png", this.distanceFallOff * vector.z + 16f);
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x0048B5F5 File Offset: 0x004897F5
		public void FFECDBMCMFE()
		{
			this.BPLIJEBLICN();
			this.APBNGANLHIE();
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x0048B604 File Offset: 0x00489804
		private void CHANJEBGLKE()
		{
			Vector4 vector = new Vector4(this.height + 72f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("Formatted Label", vector);
			Shader.SetGlobalFloat("2000", this.distanceFallOff * vector.z + 872f);
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x0048B66C File Offset: 0x0048986C
		private void IDKIOEOLOJD()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1017f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("Katana Ready Low", value);
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x0048B77C File Offset: 0x0048997C
		private void BHFFIKEDACI()
		{
			Vector4 vector = new Vector4(this.height + 170f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("SatNightFever", vector);
			Shader.SetGlobalFloat("t_beard", this.distanceFallOff * vector.z + 1181f);
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x0048B7E4 File Offset: 0x004899E4
		private void BPLIJEBLICN()
		{
			Vector4 vector = new Vector4(this.height + 289f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("V", vector);
			Shader.SetGlobalFloat("Invalid FBBIK setup. Please right-click on the component header and select 'Reinitiate'.", this.distanceFallOff * vector.z + 974f);
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x0048B849 File Offset: 0x00489A49
		private void NFJKCBFCHBP()
		{
			this.BKOIHGGAFPJ();
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x0048B854 File Offset: 0x00489A54
		private void ABECCDDJNCG()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(867f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("gi_tit_ch", value);
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x0048AD59 File Offset: 0x00488F59
		private void JAFCKIKCHGM()
		{
			this.NBPAJOLHACA();
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x0048B964 File Offset: 0x00489B64
		private void FMFMONGCDNB()
		{
			Vector4 vector = new Vector4(this.height + 1626f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("\n", vector);
			Shader.SetGlobalFloat("Gesture Hand Up", this.distanceFallOff * vector.z + 1941f);
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x0048B9C9 File Offset: 0x00489BC9
		private void DFJPGJJKLDF()
		{
			this.AEPCMDEPLGG();
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x0048B9C9 File Offset: 0x00489BC9
		private void HNGLBEOAIHN()
		{
			this.AEPCMDEPLGG();
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x0048B9D4 File Offset: 0x00489BD4
		private void NKPNBMGPDCM()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1623f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("\\n", value);
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x0048BAE1 File Offset: 0x00489CE1
		public void CNPKOGOOLDJ()
		{
			this.MOGAMBDPLGF();
			this.ABECCDDJNCG();
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x0048AE00 File Offset: 0x00489000
		private void ABHMIBGKGGM()
		{
			this.MKCCLACGDBD();
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x0048AD59 File Offset: 0x00488F59
		private void ICIFMFIGOKJ()
		{
			this.NBPAJOLHACA();
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x0048BAEF File Offset: 0x00489CEF
		public void ILEDDOGLHJD()
		{
			this.CHANJEBGLKE();
			this.IDKIOEOLOJD();
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x0048BB00 File Offset: 0x00489D00
		private void APBNGANLHIE()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1964f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("</color>\n", value);
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x0048BC10 File Offset: 0x00489E10
		private void MGMNFLHEHPF()
		{
			Vector4 vector = new Vector4(this.height + 854f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("brag", vector);
			Shader.SetGlobalFloat("AppID:", this.distanceFallOff * vector.z + 1662f);
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x0048BC75 File Offset: 0x00489E75
		private void EBLJKEAHIGD()
		{
			this.KLKICOBHHAD();
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x0048BC7D File Offset: 0x00489E7D
		private void PNFPFNADEJF()
		{
			this.PLCAMMCKDGJ();
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x0048BC85 File Offset: 0x00489E85
		private void ACCKEFCOBGN()
		{
			this.GJOLGNEPNPC();
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x0048B849 File Offset: 0x00489A49
		private void MMKMNFOOIKL()
		{
			this.BKOIHGGAFPJ();
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x0048BC90 File Offset: 0x00489E90
		private void PALHBPCINJC()
		{
			Vector4 vector = new Vector4(this.height + 1007f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("RendererD2 is init", vector);
			Shader.SetGlobalFloat("_BlurVector", this.distanceFallOff * vector.z + 130f);
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x0048BCF8 File Offset: 0x00489EF8
		private void IKHCCAANGOP()
		{
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = false;
				}
				if (flag)
				{
					this.NCFOHPPKLNN();
				}
			}
			this.BPLIJEBLICN();
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x0048BD7E File Offset: 0x00489F7E
		private void OJJKNBMONMD()
		{
			this.NJMJDKNPDOF();
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x0048BD88 File Offset: 0x00489F88
		private void LMGBKHCHPHO()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = false;
				}
				if (flag)
				{
					this.BIFEJIIMGON();
				}
			}
			this.EDCAFHGJENK();
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x0048B849 File Offset: 0x00489A49
		private void DKEFEKOLGFB()
		{
			this.BKOIHGGAFPJ();
		}

		// Token: 0x0600A265 RID: 41573 RVA: 0x0048BE10 File Offset: 0x0048A010
		private void BIFEJIIMGON()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(60f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("Calf", value);
		}

		// Token: 0x0600A266 RID: 41574 RVA: 0x0048BF1D File Offset: 0x0048A11D
		public void NNALCCKMELF()
		{
			this.BAICIKOCDFP();
			this.PDKKCMJMEKJ();
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x0048BF2B File Offset: 0x0048A12B
		private void KAKCPAJHCPN()
		{
			this.FFECDBMCMFE();
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x0048BF2B File Offset: 0x0048A12B
		private void CABDFNIKOOI()
		{
			this.FFECDBMCMFE();
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x0048BF33 File Offset: 0x0048A133
		private void OLHGBCBHDBF()
		{
			this.DDABMICOLLE();
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x0048BF3C File Offset: 0x0048A13C
		private void BMJEEMGBMFP()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("_FogColor", value);
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x0048ABA5 File Offset: 0x00488DA5
		private void KFLFNGGBAEB()
		{
			this.NNALCCKMELF();
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x0048AB9D File Offset: 0x00488D9D
		private void OnEnable()
		{
			this.UpdateMaterialProperties();
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x0048B481 File Offset: 0x00489681
		private void KDOIOPJDJPL()
		{
			this.FILEFLMILJK();
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x0048C049 File Offset: 0x0048A249
		public void LOIBEOFGBPD()
		{
			this.BAICIKOCDFP();
			this.GJHHKBELPCI();
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x0048BF2B File Offset: 0x0048A12B
		private void MFOGDJHDIDA()
		{
			this.FFECDBMCMFE();
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x0048C058 File Offset: 0x0048A258
		private void KJJEEMEHGBF()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = false;
				}
				if (flag)
				{
					this.PDKKCMJMEKJ();
				}
			}
			this.JIBJMDPNOPA();
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x0048C0E0 File Offset: 0x0048A2E0
		private void EDCAFHGJENK()
		{
			Vector4 vector = new Vector4(this.height + 1427f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("SkateboardKickPush", vector);
			Shader.SetGlobalFloat("ShotgunReloadMagazine", this.distanceFallOff * vector.z + 321f);
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x0048C145 File Offset: 0x0048A345
		public void NJMJDKNPDOF()
		{
			this.EDCAFHGJENK();
			this.APBNGANLHIE();
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x0048C154 File Offset: 0x0048A354
		private void BJHPJAOLOFA()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(852f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("IdleStand", value);
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x0048C261 File Offset: 0x0048A461
		public void PLCAMMCKDGJ()
		{
			this.GFLCEBOPFAD();
			this.PPOLFBODOFE();
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x0048C270 File Offset: 0x0048A470
		private void PNBGJBMJLFM()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = false;
				}
				if (flag)
				{
					this.HHHGFKKPEJE();
				}
			}
			this.BHFFIKEDACI();
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x0048C2F6 File Offset: 0x0048A4F6
		public void FILEFLMILJK()
		{
			this.MIPGKKOLBLC();
			this.PDKKCMJMEKJ();
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x0048A8ED File Offset: 0x00488AED
		private void EDDNLPPMPCB()
		{
			this.FNEAKHPLPBC();
		}

		// Token: 0x0600A278 RID: 41592 RVA: 0x0048C304 File Offset: 0x0048A504
		public void NBPAJOLHACA()
		{
			this.GFLCEBOPFAD();
			this.BDOCIAAEGLL();
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x0048C314 File Offset: 0x0048A514
		private void GJHHKBELPCI()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(452f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("\n", value);
		}

		// Token: 0x0600A27A RID: 41594 RVA: 0x0048C424 File Offset: 0x0048A624
		private void JIBJMDPNOPA()
		{
			Vector4 vector = new Vector4(this.height + 8f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("\n", vector);
			Shader.SetGlobalFloat(" ms", this.distanceFallOff * vector.z + 988f);
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x0048C489 File Offset: 0x0048A689
		public void BKOIHGGAFPJ()
		{
			this.LHCPIKHAILN();
			this.NLMJPHIEDPB();
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x0048B50B File Offset: 0x0048970B
		private void MBGOKFGOGKM()
		{
			this.KPKCCHKELHF();
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x0048C498 File Offset: 0x0048A698
		private void JFGGBEGNAFP()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = false;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.NIEBOKPICPO();
				}
			}
			this.JIBJMDPNOPA();
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x0048C520 File Offset: 0x0048A720
		private void KMLNBHIIGKH()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.CACKDKFHOJN();
				}
			}
			this.MOGAMBDPLGF();
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x0048BF33 File Offset: 0x0048A133
		private void MOJBLBHKCCM()
		{
			this.DDABMICOLLE();
		}

		// Token: 0x0600A280 RID: 41600 RVA: 0x0048C5A6 File Offset: 0x0048A7A6
		public void DDABMICOLLE()
		{
			this.CHANJEBGLKE();
			this.ABECCDDJNCG();
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x0048C5B4 File Offset: 0x0048A7B4
		private void IIAIGAHLJBL()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(582f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("_SampleCount", value);
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x0048C6C4 File Offset: 0x0048A8C4
		private void MOGAMBDPLGF()
		{
			Vector4 vector = new Vector4(this.height + 0.001f, this.baselineHeight, Camera.main.farClipPlane * this.distance, this.heightFallOff);
			Shader.SetGlobalVector("_FogData", vector);
			Shader.SetGlobalFloat("_FogData2", this.distanceFallOff * vector.z + 0.0001f);
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x0048C729 File Offset: 0x0048A929
		public void FNEAKHPLPBC()
		{
			this.CHANJEBGLKE();
			this.NLMJPHIEDPB();
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x0048C738 File Offset: 0x0048A938
		private void BLMBPFIJJBP()
		{
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = false;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.HNOMCGFDCLC();
				}
			}
			this.MIPGKKOLBLC();
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x0048C7C0 File Offset: 0x0048A9C0
		private void HHHGFKKPEJE()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(327f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor("glava", value);
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x0048AB9D File Offset: 0x00488D9D
		private void COIGADPCLOB()
		{
			this.UpdateMaterialProperties();
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x0048C8D0 File Offset: 0x0048AAD0
		private void CACKDKFHOJN()
		{
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(168f - this.JLGOCHGJAPF.y);
			Color value = this.color * this.KLGJFFCKPED * b;
			value.a = this.alpha;
			Shader.SetGlobalColor(" iterations for read and write", value);
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x0048C9DD File Offset: 0x0048ABDD
		public void KPKCCHKELHF()
		{
			this.CHANJEBGLKE();
			this.NCFOHPPKLNN();
		}

		// Token: 0x040014F3 RID: 5363
		[Range(0f, 1f)]
		public float alpha = 1f;

		// Token: 0x040014F4 RID: 5364
		[Range(0f, 1f)]
		public float noiseStrength = 0.5f;

		// Token: 0x040014F5 RID: 5365
		[Range(0f, 0.999f)]
		public float distance = 0.2f;

		// Token: 0x040014F6 RID: 5366
		[Range(0f, 2f)]
		public float distanceFallOff = 1f;

		// Token: 0x040014F7 RID: 5367
		[Range(0f, 500f)]
		public float height = 1f;

		// Token: 0x040014F8 RID: 5368
		[Range(0f, 1f)]
		public float heightFallOff = 1f;

		// Token: 0x040014F9 RID: 5369
		public float baselineHeight;

		// Token: 0x040014FA RID: 5370
		public Color color = new Color(0.89f, 0.89f, 0.89f, 1f);

		// Token: 0x040014FB RID: 5371
		public GameObject sun;

		// Token: 0x040014FC RID: 5372
		private Light HLGMMNEANMP;

		// Token: 0x040014FD RID: 5373
		private Vector3 JLGOCHGJAPF = Vector3.zero;

		// Token: 0x040014FE RID: 5374
		private Color KLGJFFCKPED = Color.white;

		// Token: 0x040014FF RID: 5375
		private float LBHPHLABBEC = 1f;
	}
}
