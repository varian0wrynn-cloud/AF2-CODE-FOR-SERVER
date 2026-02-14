using System;
using UnityEngine;

namespace Ara
{
	// Token: 0x020005BF RID: 1471
	[RequireComponent(typeof(AraTrail))]
	public class ColorFromSpeed : MonoBehaviour
	{
		// Token: 0x06013516 RID: 79126 RVA: 0x008506C8 File Offset: 0x0084E8C8
		private void OIOBJBMEDAK()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1E-05f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013517 RID: 79127 RVA: 0x00850751 File Offset: 0x0084E951
		private void EHKCHPFDNCA()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.CDEGJHADNDF));
		}

		// Token: 0x06013518 RID: 79128 RVA: 0x0085076C File Offset: 0x0084E96C
		private void BCIJHNEBCIG()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1644f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013519 RID: 79129 RVA: 0x008507F5 File Offset: 0x0084E9F5
		private void FDMGAGCBBDP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.JIAFJHOGHDE;
		}

		// Token: 0x0601351A RID: 79130 RVA: 0x0085081C File Offset: 0x0084EA1C
		private void COAEAFBDBJJ()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(837f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601351B RID: 79131 RVA: 0x008508A5 File Offset: 0x0084EAA5
		private void EMOFOHBMJBD()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.JICFCBMBLLN;
		}

		// Token: 0x0601351C RID: 79132 RVA: 0x008508CA File Offset: 0x0084EACA
		private void IDLLAMOBGGO()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.IJDGOEOEOFO;
		}

		// Token: 0x0601351D RID: 79133 RVA: 0x008508E4 File Offset: 0x0084EAE4
		private void IJDGOEOEOFO()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1288f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601351E RID: 79134 RVA: 0x00850970 File Offset: 0x0084EB70
		private void BIOOGDKJHLP()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(567f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601351F RID: 79135 RVA: 0x008509F9 File Offset: 0x0084EBF9
		private void IICFAPMJLCN()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.DEJPGJCHLID));
		}

		// Token: 0x06013520 RID: 79136 RVA: 0x00850A12 File Offset: 0x0084EC12
		private void MJGKKNEHHKG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.MAFHNJINAPP;
		}

		// Token: 0x06013521 RID: 79137 RVA: 0x00850A38 File Offset: 0x0084EC38
		private void JFDKMMODNIC()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1083f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013522 RID: 79138 RVA: 0x00850AC1 File Offset: 0x0084ECC1
		private void OnEnable()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OIOBJBMEDAK;
		}

		// Token: 0x06013523 RID: 79139 RVA: 0x00850AE6 File Offset: 0x0084ECE6
		private void DCPLDAKDDBG()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.CDEGJHADNDF));
		}

		// Token: 0x06013524 RID: 79140 RVA: 0x00850B00 File Offset: 0x0084ED00
		private void CECECBKNHBG()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1742f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013525 RID: 79141 RVA: 0x00850B89 File Offset: 0x0084ED89
		private void OBIPAJDKIHF()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.ENBCDECHCDJ;
		}

		// Token: 0x06013526 RID: 79142 RVA: 0x00850BAE File Offset: 0x0084EDAE
		private void PBDNGIFDEFC()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.COAEAFBDBJJ;
		}

		// Token: 0x06013527 RID: 79143 RVA: 0x00850BC7 File Offset: 0x0084EDC7
		private void FGHHAIDJNMM()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.BIOOGDKJHLP;
		}

		// Token: 0x06013528 RID: 79144 RVA: 0x00850BE0 File Offset: 0x0084EDE0
		private void OEIGFMOCHMG()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1905f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013529 RID: 79145 RVA: 0x00850C69 File Offset: 0x0084EE69
		private void EILDKNMOKBB()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.EFGBLJDOOMF;
		}

		// Token: 0x0601352A RID: 79146 RVA: 0x00850C84 File Offset: 0x0084EE84
		private void AFFJPHILILP()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(728f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601352C RID: 79148 RVA: 0x00850D2C File Offset: 0x0084EF2C
		private void MAFHNJINAPP()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1255f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601352D RID: 79149 RVA: 0x00850DB8 File Offset: 0x0084EFB8
		private void CFFPHLKCHBJ()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1142f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601352E RID: 79150 RVA: 0x00850E41 File Offset: 0x0084F041
		private void IIONABJOCBN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.GANOMPDNCFB;
		}

		// Token: 0x0601352F RID: 79151 RVA: 0x00850E66 File Offset: 0x0084F066
		private void JGHJOBDKDKM()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.KMJFCICCFFA));
		}

		// Token: 0x06013530 RID: 79152 RVA: 0x00850E7F File Offset: 0x0084F07F
		private void JOKAAEKICJK()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OEIGFMOCHMG;
		}

		// Token: 0x06013531 RID: 79153 RVA: 0x00850EA4 File Offset: 0x0084F0A4
		private void ENBCDECHCDJ()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(605f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013532 RID: 79154 RVA: 0x00850F30 File Offset: 0x0084F130
		private void OJKMOFMKFGM()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1383f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013533 RID: 79155 RVA: 0x00850FB9 File Offset: 0x0084F1B9
		private void IMEIOFGKMDK()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.JFDKMMODNIC;
		}

		// Token: 0x06013534 RID: 79156 RVA: 0x00850FE0 File Offset: 0x0084F1E0
		private void EFGBLJDOOMF()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(15f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013535 RID: 79157 RVA: 0x00851069 File Offset: 0x0084F269
		private void HPGMKBPAFGM()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.OIOBJBMEDAK;
		}

		// Token: 0x06013536 RID: 79158 RVA: 0x00851082 File Offset: 0x0084F282
		private void NFJKCBFCHBP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OJKMOFMKFGM;
		}

		// Token: 0x06013537 RID: 79159 RVA: 0x00851069 File Offset: 0x0084F269
		private void OnDisable()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.OIOBJBMEDAK;
		}

		// Token: 0x06013538 RID: 79160 RVA: 0x008510A8 File Offset: 0x0084F2A8
		private void KMJFCICCFFA()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1522f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013539 RID: 79161 RVA: 0x00851131 File Offset: 0x0084F331
		private void DCPLMIMFNHG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.CECECBKNHBG;
		}

		// Token: 0x0601353A RID: 79162 RVA: 0x00851158 File Offset: 0x0084F358
		private void JIAFJHOGHDE()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1858f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601353B RID: 79163 RVA: 0x00850E7F File Offset: 0x0084F07F
		private void NKKHCJDLMII()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OEIGFMOCHMG;
		}

		// Token: 0x0601353C RID: 79164 RVA: 0x008511E1 File Offset: 0x0084F3E1
		private void NIOMOLMCNOO()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.OJKMOFMKFGM));
		}

		// Token: 0x0601353D RID: 79165 RVA: 0x008511FC File Offset: 0x0084F3FC
		private void GANOMPDNCFB()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1364f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601353E RID: 79166 RVA: 0x00850AE6 File Offset: 0x0084ECE6
		private void HMILPFNLLJM()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.CDEGJHADNDF));
		}

		// Token: 0x0601353F RID: 79167 RVA: 0x00851285 File Offset: 0x0084F485
		private void CCMOKEDKMNJ()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.BCIJHNEBCIG;
		}

		// Token: 0x06013540 RID: 79168 RVA: 0x008512AA File Offset: 0x0084F4AA
		private void KLHDJKDMCJN()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.JIAFJHOGHDE));
		}

		// Token: 0x06013541 RID: 79169 RVA: 0x00850E7F File Offset: 0x0084F07F
		private void CCGIGJMJCDH()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OEIGFMOCHMG;
		}

		// Token: 0x06013542 RID: 79170 RVA: 0x008512C3 File Offset: 0x0084F4C3
		private void CALDPCOLDNO()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.EFGBLJDOOMF;
		}

		// Token: 0x06013543 RID: 79171 RVA: 0x00850B89 File Offset: 0x0084ED89
		private void MEJAMIFNCGO()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.ENBCDECHCDJ;
		}

		// Token: 0x06013544 RID: 79172 RVA: 0x008512E8 File Offset: 0x0084F4E8
		private void IFJEIFBOPCI()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.PMGLADCOIDA;
		}

		// Token: 0x06013545 RID: 79173 RVA: 0x00851301 File Offset: 0x0084F501
		private void BGKOJIDABKB()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.CDEGJHADNDF;
		}

		// Token: 0x06013546 RID: 79174 RVA: 0x00851328 File Offset: 0x0084F528
		private void PMGLADCOIDA()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1563f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013547 RID: 79175 RVA: 0x008513B4 File Offset: 0x0084F5B4
		private void GGCEKGGNEBP()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1429f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013548 RID: 79176 RVA: 0x00851440 File Offset: 0x0084F640
		private void JICFCBMBLLN()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(915f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013549 RID: 79177 RVA: 0x008514C9 File Offset: 0x0084F6C9
		private void NJBEKBHCLIO()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.BIOOGDKJHLP));
		}

		// Token: 0x0601354A RID: 79178 RVA: 0x00851082 File Offset: 0x0084F282
		private void AKPLEHHPKGC()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OJKMOFMKFGM;
		}

		// Token: 0x0601354B RID: 79179 RVA: 0x008514E2 File Offset: 0x0084F6E2
		private void APJACOJADAF()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.ILIIBJDFCHF));
		}

		// Token: 0x0601354C RID: 79180 RVA: 0x008514FB File Offset: 0x0084F6FB
		private void HHOJJINMMMA()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.IJDGOEOEOFO;
		}

		// Token: 0x0601354D RID: 79181 RVA: 0x008507F5 File Offset: 0x0084E9F5
		private void IDGIPDDGDFN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.JIAFJHOGHDE;
		}

		// Token: 0x0601354E RID: 79182 RVA: 0x00851520 File Offset: 0x0084F720
		private void ONOAKBGLIGM()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.CDEGJHADNDF));
		}

		// Token: 0x0601354F RID: 79183 RVA: 0x00851539 File Offset: 0x0084F739
		private void PLLCHLCDKFA()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.BIOOGDKJHLP;
		}

		// Token: 0x06013550 RID: 79184 RVA: 0x00850FB9 File Offset: 0x0084F1B9
		private void KFLFNGGBAEB()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.JFDKMMODNIC;
		}

		// Token: 0x06013551 RID: 79185 RVA: 0x00851082 File Offset: 0x0084F282
		private void CIDFLCGOBKO()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OJKMOFMKFGM;
		}

		// Token: 0x06013552 RID: 79186 RVA: 0x00850B89 File Offset: 0x0084ED89
		private void DKEFEKOLGFB()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.ENBCDECHCDJ;
		}

		// Token: 0x06013553 RID: 79187 RVA: 0x00850E7F File Offset: 0x0084F07F
		private void OLHGBCBHDBF()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.OEIGFMOCHMG;
		}

		// Token: 0x06013554 RID: 79188 RVA: 0x0085155E File Offset: 0x0084F75E
		private void CCCAOGJKJOD()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.ILIIBJDFCHF;
		}

		// Token: 0x06013555 RID: 79189 RVA: 0x00851577 File Offset: 0x0084F777
		private void PLBMFJMPMKL()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.CECECBKNHBG));
		}

		// Token: 0x06013556 RID: 79190 RVA: 0x00850B89 File Offset: 0x0084ED89
		private void OJJKNBMONMD()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.ENBCDECHCDJ;
		}

		// Token: 0x06013557 RID: 79191 RVA: 0x00851590 File Offset: 0x0084F790
		private void ILIIBJDFCHF()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1276f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013558 RID: 79192 RVA: 0x00851619 File Offset: 0x0084F819
		private void IDFEHJKAJAM()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.DEJPGJCHLID;
		}

		// Token: 0x06013559 RID: 79193 RVA: 0x00851632 File Offset: 0x0084F832
		private void JKDCKHECHEJ()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.KMJFCICCFFA;
		}

		// Token: 0x0601355A RID: 79194 RVA: 0x008514FB File Offset: 0x0084F6FB
		private void JMFMOADCCIE()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.IJDGOEOEOFO;
		}

		// Token: 0x0601355B RID: 79195 RVA: 0x0085164B File Offset: 0x0084F84B
		private void BHMLILLBFLP()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.DEJPGJCHLID;
		}

		// Token: 0x0601355C RID: 79196 RVA: 0x00851670 File Offset: 0x0084F870
		private void DEJPGJCHLID()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(120f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x0601355D RID: 79197 RVA: 0x008516F9 File Offset: 0x0084F8F9
		private void PIPJPGGEFOL()
		{
			this.GDILALKKEIL.ANCKEKGILEF(new Action(this.BIOOGDKJHLP));
		}

		// Token: 0x0601355E RID: 79198 RVA: 0x00850A12 File Offset: 0x0084EC12
		private void FHPLPPPOPJF()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.MAFHNJINAPP;
		}

		// Token: 0x0601355F RID: 79199 RVA: 0x00851712 File Offset: 0x0084F912
		private void OCIANPBJNND()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.GGCEKGGNEBP;
		}

		// Token: 0x06013560 RID: 79200 RVA: 0x00851738 File Offset: 0x0084F938
		private void HLLAILFPABD()
		{
			for (int i = 0; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1247f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013561 RID: 79201 RVA: 0x008517C1 File Offset: 0x0084F9C1
		private void NGMMNKHDOPG()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.KMJFCICCFFA;
		}

		// Token: 0x06013562 RID: 79202 RVA: 0x008517E6 File Offset: 0x0084F9E6
		private void PEKNHINKHCK()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.DEJPGJCHLID));
		}

		// Token: 0x06013563 RID: 79203 RVA: 0x00850751 File Offset: 0x0084E951
		private void LNNKANCIIFM()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.CDEGJHADNDF));
		}

		// Token: 0x06013564 RID: 79204 RVA: 0x008517FF File Offset: 0x0084F9FF
		private void LLFANOGKPKM()
		{
			this.GDILALKKEIL.ECOCGOKIFEL -= this.GANOMPDNCFB;
		}

		// Token: 0x06013565 RID: 79205 RVA: 0x00851818 File Offset: 0x0084FA18
		private void HNGLBEOAIHN()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.HLLAILFPABD;
		}

		// Token: 0x06013566 RID: 79206 RVA: 0x0085183D File Offset: 0x0084FA3D
		private void LKGIJBLNANI()
		{
			this.GDILALKKEIL.JGGCMACKPPB(new Action(this.JIAFJHOGHDE));
		}

		// Token: 0x06013567 RID: 79207 RVA: 0x00851858 File Offset: 0x0084FA58
		private void CDEGJHADNDF()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1839f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x06013568 RID: 79208 RVA: 0x008518E1 File Offset: 0x0084FAE1
		private void EBAJDGLIAPE()
		{
			this.GDILALKKEIL = base.GetComponent<AraTrail>();
			this.GDILALKKEIL.ECOCGOKIFEL += this.COAEAFBDBJJ;
		}

		// Token: 0x06013569 RID: 79209 RVA: 0x00851906 File Offset: 0x0084FB06
		private void IABPIBODNNG()
		{
			this.GDILALKKEIL.LFPBJKCADCF(new Action(this.PMGLADCOIDA));
		}

		// Token: 0x0601356A RID: 79210 RVA: 0x00851920 File Offset: 0x0084FB20
		private void JBFGLGBPADK()
		{
			for (int i = 1; i < this.GDILALKKEIL.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI value = this.GDILALKKEIL.points[i];
				value.LBCGACKJCJB = this.colorFromSpeed.Evaluate((value.APOIOHJJDDC.magnitude - this.minSpeed) / Mathf.Max(1108f, this.maxSpeed - this.minSpeed));
				this.GDILALKKEIL.points[i] = value;
			}
		}

		// Token: 0x040027C4 RID: 10180
		private AraTrail GDILALKKEIL;

		// Token: 0x040027C5 RID: 10181
		[Tooltip("Maps trail speed to color. Control how much speed is transferred to the trail by setting inertia > 0. The trail will be colorized even if physics are disabled. ")]
		public Gradient colorFromSpeed = new Gradient();

		// Token: 0x040027C6 RID: 10182
		[Tooltip("Min speed used to map speed to color.")]
		public float minSpeed;

		// Token: 0x040027C7 RID: 10183
		[Tooltip("Max speed used to map speed to color.")]
		public float maxSpeed = 5f;
	}
}
