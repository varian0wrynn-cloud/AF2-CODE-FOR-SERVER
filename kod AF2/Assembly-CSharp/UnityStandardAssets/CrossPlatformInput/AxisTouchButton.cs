using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x0200038A RID: 906
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		// Token: 0x0600C42D RID: 50221 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void KGOIALNOPNP()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C42E RID: 50222 RVA: 0x0058CAA8 File Offset: 0x0058ACA8
		public void LNAFCEEFLAB(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.NOGNBELCJPC();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C42F RID: 50223 RVA: 0x0058CAF6 File Offset: 0x0058ACF6
		public void JJAEBPHPJMM(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), 1902f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C430 RID: 50224 RVA: 0x0058CB24 File Offset: 0x0058AD24
		public void BHGNEPIDDGE(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.PECHJNHBGGD();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void HBNDJPNJKFM()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C432 RID: 50226 RVA: 0x0058CB72 File Offset: 0x0058AD72
		public void NJFIPKFPFAH(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), 1417f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C433 RID: 50227 RVA: 0x0058CBA0 File Offset: 0x0058ADA0
		private void MEJAMIFNCGO()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.AAOJBHPOLGP();
		}

		// Token: 0x0600C434 RID: 50228 RVA: 0x0058CBEF File Offset: 0x0058ADEF
		public void OEPKJIKONAF(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 1390f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x0058CC20 File Offset: 0x0058AE20
		private void JAFNIHHFEIC()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C436 RID: 50230 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void FLFFEJFEPHF()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C437 RID: 50231 RVA: 0x0058CC7C File Offset: 0x0058AE7C
		private void NNMOAONPCDC()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C438 RID: 50232 RVA: 0x0058CCD8 File Offset: 0x0058AED8
		public void GLPNCAHLKKF(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.FAINNCKEIEG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C439 RID: 50233 RVA: 0x0058CD28 File Offset: 0x0058AF28
		private void CIPCEICIJJI()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x0058CD84 File Offset: 0x0058AF84
		private void PBICOFOGOLF()
		{
			this.MPFPHACDOCC.HAFJMIPHAIB();
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x0058CD91 File Offset: 0x0058AF91
		private void LNNKANCIIFM()
		{
			this.MPFPHACDOCC.LGAMHBGCPLC();
		}

		// Token: 0x0600C43C RID: 50236 RVA: 0x0058CD9E File Offset: 0x0058AF9E
		public void KEGCOPJMJHP(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 344f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x0058CDCC File Offset: 0x0058AFCC
		public void PCEHFJEEJLG(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.AHEOAOOJGPH();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C43E RID: 50238 RVA: 0x0058CE1A File Offset: 0x0058B01A
		public void DHFMPOKGANK(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 1063f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C43F RID: 50239 RVA: 0x0058CE48 File Offset: 0x0058B048
		public void OnPointerUp(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 0f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C440 RID: 50240 RVA: 0x0058CE78 File Offset: 0x0058B078
		private void GDCFOBBEBHF()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.HLKCCJGCPMM();
		}

		// Token: 0x0600C441 RID: 50241 RVA: 0x0058CEC8 File Offset: 0x0058B0C8
		public void OGGENHGPMBK(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.FIAHBIOPBPE();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C442 RID: 50242 RVA: 0x0058CF18 File Offset: 0x0058B118
		private void MNHNFKDMNIM()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C443 RID: 50243 RVA: 0x0058CD84 File Offset: 0x0058AF84
		private void HMILPFNLLJM()
		{
			this.MPFPHACDOCC.HAFJMIPHAIB();
		}

		// Token: 0x0600C444 RID: 50244 RVA: 0x0058CF74 File Offset: 0x0058B174
		public void GADJLPGFELM(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), 578f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C445 RID: 50245 RVA: 0x0058CFA4 File Offset: 0x0058B1A4
		public void CHJEEJBPIBF(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EGMILEECLPG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C446 RID: 50246 RVA: 0x0058CFF4 File Offset: 0x0058B1F4
		private void KFLFNGGBAEB()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.JAFNIHHFEIC();
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x0058D043 File Offset: 0x0058B243
		public void GCFPANLGMKI(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 1805f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C448 RID: 50248 RVA: 0x0058CD84 File Offset: 0x0058AF84
		private void JIGLHJINLFH()
		{
			this.MPFPHACDOCC.HAFJMIPHAIB();
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x0058D074 File Offset: 0x0058B274
		private void KNGNDJAFFFP()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C44A RID: 50250 RVA: 0x0058D0D0 File Offset: 0x0058B2D0
		private void FAINNCKEIEG()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C44B RID: 50251 RVA: 0x0058D12C File Offset: 0x0058B32C
		public void BGOMCBHCBOE(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 550f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C44C RID: 50252 RVA: 0x0058D15C File Offset: 0x0058B35C
		private void GICMHNKKECK()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.MNHNFKDMNIM();
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x0058D1AB File Offset: 0x0058B3AB
		public void KOFONJHFGNJ(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 1896f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C44E RID: 50254 RVA: 0x0058CD91 File Offset: 0x0058AF91
		private void ANHJAOPPMCI()
		{
			this.MPFPHACDOCC.LGAMHBGCPLC();
		}

		// Token: 0x0600C44F RID: 50255 RVA: 0x0058D1DC File Offset: 0x0058B3DC
		private void BHMLILLBFLP()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.FIAHBIOPBPE();
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x0058D22B File Offset: 0x0058B42B
		public void JBABOKKGFNM(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), 249f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x0058D25C File Offset: 0x0058B45C
		private void AHEOAOOJGPH()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C452 RID: 50258 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void KJAKKAMNEPG()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C453 RID: 50259 RVA: 0x0058D2B8 File Offset: 0x0058B4B8
		public void MMPGOBANHNL(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EGMILEECLPG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C454 RID: 50260 RVA: 0x0058D308 File Offset: 0x0058B508
		private void PECHJNHBGGD()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C455 RID: 50261 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void PEPOOEGHCMC()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C456 RID: 50262 RVA: 0x0058D364 File Offset: 0x0058B564
		public void EECMKKIAGCH(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 1578f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C457 RID: 50263 RVA: 0x0058D394 File Offset: 0x0058B594
		private void NFJKCBFCHBP()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.HLKCCJGCPMM();
		}

		// Token: 0x0600C458 RID: 50264 RVA: 0x0058D3E3 File Offset: 0x0058B5E3
		public void INMHAMOLDGI(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), 1819f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C459 RID: 50265 RVA: 0x0058D411 File Offset: 0x0058B611
		public void KABCBAFPLNB(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), 863f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C45A RID: 50266 RVA: 0x0058D440 File Offset: 0x0058B640
		public void FDEABNCFPAO(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.CMPANBHIHPI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x0058D490 File Offset: 0x0058B690
		private void FJBPGBMDBBF()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.LIGFLIHGKBB();
		}

		// Token: 0x0600C45C RID: 50268 RVA: 0x0058D4E0 File Offset: 0x0058B6E0
		public void OPDNFDDCPEE(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EGMILEECLPG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C45D RID: 50269 RVA: 0x0058D530 File Offset: 0x0058B730
		public void JFJBBFBLGIC(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.KNGNDJAFFFP();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C45E RID: 50270 RVA: 0x0058D580 File Offset: 0x0058B780
		private void INEHANLJIEM()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.CMPANBHIHPI();
		}

		// Token: 0x0600C45F RID: 50271 RVA: 0x0058D5D0 File Offset: 0x0058B7D0
		private void HHOJJINMMMA()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.FIAHBIOPBPE();
		}

		// Token: 0x0600C460 RID: 50272 RVA: 0x0058D61F File Offset: 0x0058B81F
		public void ODOOJAKCKCL(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 571f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x0058D650 File Offset: 0x0058B850
		private void HOLBFFJDDON()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C462 RID: 50274 RVA: 0x0058D6AC File Offset: 0x0058B8AC
		public void KHONIABGMCC(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.PECHJNHBGGD();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C463 RID: 50275 RVA: 0x0058D6FC File Offset: 0x0058B8FC
		public void ADHGJKNFFPG(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.CIPCEICIJJI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C464 RID: 50276 RVA: 0x0058D74A File Offset: 0x0058B94A
		public void OIPLLCMOPID(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), 1320f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C465 RID: 50277 RVA: 0x0058D778 File Offset: 0x0058B978
		public void KNLLPIKANOJ(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.HOLBFFJDDON();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C466 RID: 50278 RVA: 0x0058D7C8 File Offset: 0x0058B9C8
		private void INANFCFEMCN()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C467 RID: 50279 RVA: 0x0058D824 File Offset: 0x0058BA24
		private void CMPANBHIHPI()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C468 RID: 50280 RVA: 0x0058D880 File Offset: 0x0058BA80
		public void ENDGLAOEOCL(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), 728f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C469 RID: 50281 RVA: 0x0058D8B0 File Offset: 0x0058BAB0
		public void HKAOKDKAMEJ(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EFNHMMAOJCI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x0058D900 File Offset: 0x0058BB00
		public void ELFHDBHIEAE(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.FAINNCKEIEG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x0058D950 File Offset: 0x0058BB50
		public void AHEBHKDECEM(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.KNGNDJAFFFP();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C46C RID: 50284 RVA: 0x0058D9A0 File Offset: 0x0058BBA0
		public void NGODGAHANBO(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.CIPCEICIJJI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x0058D9F0 File Offset: 0x0058BBF0
		public void PKMCJGKCIHF(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.FIAHBIOPBPE();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C46E RID: 50286 RVA: 0x0058DA3E File Offset: 0x0058BC3E
		public void IBHGGALMCDM(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), 42f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x0058DA6C File Offset: 0x0058BC6C
		public void JADNJGHAJEC(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.CIPCEICIJJI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C470 RID: 50288 RVA: 0x0058DABC File Offset: 0x0058BCBC
		private void OJJKNBMONMD()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.PECHJNHBGGD();
		}

		// Token: 0x0600C471 RID: 50289 RVA: 0x0058DB0C File Offset: 0x0058BD0C
		public void MNDJFCHLBAE(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.KNGNDJAFFFP();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C472 RID: 50290 RVA: 0x0058DB5C File Offset: 0x0058BD5C
		public void EGFGNOHEBHI(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.HLKCCJGCPMM();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x0058DBAC File Offset: 0x0058BDAC
		private void BGKOJIDABKB()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.LIGFLIHGKBB();
		}

		// Token: 0x0600C474 RID: 50292 RVA: 0x0058DBFC File Offset: 0x0058BDFC
		private void ACEMCKCPPIC()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C475 RID: 50293 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void BGMDMBDAKJP()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C476 RID: 50294 RVA: 0x0058DC58 File Offset: 0x0058BE58
		private void CMCJAPGDFAE()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.KNGNDJAFFFP();
		}

		// Token: 0x0600C477 RID: 50295 RVA: 0x0058DCA8 File Offset: 0x0058BEA8
		private void AMGINIANPFJ()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.ACEMCKCPPIC();
		}

		// Token: 0x0600C478 RID: 50296 RVA: 0x0058DCF8 File Offset: 0x0058BEF8
		public void ENBAECOPNHH(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EFNHMMAOJCI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x0058DD48 File Offset: 0x0058BF48
		private void IDJOMLFLFCF()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.HOLBFFJDDON();
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x0058DD97 File Offset: 0x0058BF97
		public void FNLDKFNLEKB(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 430f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C47B RID: 50299 RVA: 0x0058DDC8 File Offset: 0x0058BFC8
		private void LIGFLIHGKBB()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x0058DE24 File Offset: 0x0058C024
		public void FMJGCCKNOAP(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.CMPANBHIHPI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x0058DE74 File Offset: 0x0058C074
		private void OnEnable()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.LIGFLIHGKBB();
		}

		// Token: 0x0600C47E RID: 50302 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void COEBEJJNLEE()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C47F RID: 50303 RVA: 0x0058DEC4 File Offset: 0x0058C0C4
		public void ELFLPGABELA(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EFNHMMAOJCI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C480 RID: 50304 RVA: 0x0058DF14 File Offset: 0x0058C114
		private void EBAJDGLIAPE()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.NOGNBELCJPC();
		}

		// Token: 0x0600C481 RID: 50305 RVA: 0x0058DF63 File Offset: 0x0058C163
		public void HONEIMOCJOP(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 517f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C482 RID: 50306 RVA: 0x0058DF94 File Offset: 0x0058C194
		public void DKPIAFAHEAJ(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.LIGFLIHGKBB();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C483 RID: 50307 RVA: 0x0058DFE4 File Offset: 0x0058C1E4
		public void LCOCNBDBPMN(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.FAINNCKEIEG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C484 RID: 50308 RVA: 0x0058E032 File Offset: 0x0058C232
		public void OPFLGDMIBBI(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 1210f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void HACJAOEBLFG()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C486 RID: 50310 RVA: 0x0058CD91 File Offset: 0x0058AF91
		private void OGMALNDHBEE()
		{
			this.MPFPHACDOCC.LGAMHBGCPLC();
		}

		// Token: 0x0600C487 RID: 50311 RVA: 0x0058E060 File Offset: 0x0058C260
		public void OHFKFHFPJFD(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.INANFCFEMCN();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C488 RID: 50312 RVA: 0x0058E0B0 File Offset: 0x0058C2B0
		private void EHBCDGAIHND()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.FIAHBIOPBPE();
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void OnDisable()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x0058E100 File Offset: 0x0058C300
		private void HLKCCJGCPMM()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C48B RID: 50315 RVA: 0x0058E15C File Offset: 0x0058C35C
		public void PJNGCKJMFOI(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 475f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C48C RID: 50316 RVA: 0x0058E18A File Offset: 0x0058C38A
		public void JDCFHJDMFFJ(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 188f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x0058E1B8 File Offset: 0x0058C3B8
		public void HMCOGJPAJHL(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), 1267f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x0058E1E8 File Offset: 0x0058C3E8
		public void LGLJIAKLKFD(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.INANFCFEMCN();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x0058E238 File Offset: 0x0058C438
		private void IOAKJCLGFJD()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.CIPCEICIJJI();
		}

		// Token: 0x0600C490 RID: 50320 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void LAOBJGDOJDH()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x0058CD91 File Offset: 0x0058AF91
		private void DAIKHLLJCPL()
		{
			this.MPFPHACDOCC.LGAMHBGCPLC();
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x0058CD84 File Offset: 0x0058AF84
		private void DNBMNPKDPHC()
		{
			this.MPFPHACDOCC.HAFJMIPHAIB();
		}

		// Token: 0x0600C493 RID: 50323 RVA: 0x0058E288 File Offset: 0x0058C488
		public void JEODICFBHIP(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.ACEMCKCPPIC();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C494 RID: 50324 RVA: 0x0058E2D6 File Offset: 0x0058C4D6
		public void HLBCKACNBKO(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 1551f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C495 RID: 50325 RVA: 0x0058E304 File Offset: 0x0058C504
		public void LKDJFCFBBLK(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.NNMOAONPCDC();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C496 RID: 50326 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void IABPIBODNNG()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x0058E354 File Offset: 0x0058C554
		public void OnPointerDown(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.LIGFLIHGKBB();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C498 RID: 50328 RVA: 0x0058E3A4 File Offset: 0x0058C5A4
		private void EGMILEECLPG()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C499 RID: 50329 RVA: 0x0058E400 File Offset: 0x0058C600
		public void NFHCAKMHKHI(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.NOGNBELCJPC();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C49A RID: 50330 RVA: 0x0058E450 File Offset: 0x0058C650
		public void FGBFADCIJFB(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EFNHMMAOJCI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C49B RID: 50331 RVA: 0x0058E49E File Offset: 0x0058C69E
		public void ILAKDEKJICN(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), 595f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x0058E4CC File Offset: 0x0058C6CC
		private void MJGKKNEHHKG()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.HLKCCJGCPMM();
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x0058E51C File Offset: 0x0058C71C
		private void EFNHMMAOJCI()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x0058E578 File Offset: 0x0058C778
		public void KHBIDIPOGAO(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), 368f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C49F RID: 50335 RVA: 0x0058E5A6 File Offset: 0x0058C7A6
		public void KOOCCLJMPCK(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.DMPEEGOEJCC(), 236f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x0058E5D4 File Offset: 0x0058C7D4
		private void FNEIKIGKDDO()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.KNGNDJAFFFP();
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x0058E624 File Offset: 0x0058C824
		private void EKOENFCHNKL()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.MNHNFKDMNIM();
		}

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x0058E674 File Offset: 0x0058C874
		public void AGPPMGGGJEF(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.IJMOCPNLBDH();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x0058E6C4 File Offset: 0x0058C8C4
		private void BEGDDIBIFDK()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.KNGNDJAFFFP();
		}

		// Token: 0x0600C4A4 RID: 50340 RVA: 0x0058CD91 File Offset: 0x0058AF91
		private void CNCGEPDEDKN()
		{
			this.MPFPHACDOCC.LGAMHBGCPLC();
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x0058E713 File Offset: 0x0058C913
		public void AAPLODOELJE(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), 13f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x0058E744 File Offset: 0x0058C944
		public void OCBCGEHEEAD(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.CMPANBHIHPI();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void EALKANLKOHI()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C4A8 RID: 50344 RVA: 0x0058E794 File Offset: 0x0058C994
		private void NOGNBELCJPC()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C4AA RID: 50346 RVA: 0x0058E824 File Offset: 0x0058CA24
		public void HPCHHHKGOOF(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 1784f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4AB RID: 50347 RVA: 0x0058E854 File Offset: 0x0058CA54
		private void OCIANPBJNND()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.EFNHMMAOJCI();
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x0058E8A4 File Offset: 0x0058CAA4
		private void AAOJBHPOLGP()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void LBABEDLHAIC()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x0058E900 File Offset: 0x0058CB00
		private void FIAHBIOPBPE()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x0058E95C File Offset: 0x0058CB5C
		public void MNLOADLPEMK(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), 1632f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x0058E98C File Offset: 0x0058CB8C
		public void DFOILEGFIKF(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.EGMILEECLPG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x0058E9DC File Offset: 0x0058CBDC
		public void HHPKEEEDDDG(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.FAINNCKEIEG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x0058EA2A File Offset: 0x0058CC2A
		public void JBJLIJENNJG(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), 181f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x0058EA58 File Offset: 0x0058CC58
		private void JNICJDIHBOF()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C4B4 RID: 50356 RVA: 0x0058CA9A File Offset: 0x0058AC9A
		private void IJLIJMPBHPA()
		{
			this.MPFPHACDOCC.NFFDECHIADD();
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x0058EAB4 File Offset: 0x0058CCB4
		public void PHKNPAADDOF(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.FAINNCKEIEG();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AEKPOKLKJHE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4B6 RID: 50358 RVA: 0x0058EB04 File Offset: 0x0058CD04
		public void DHDOKHEKFIM(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.HLKCCJGCPMM();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x0058EB54 File Offset: 0x0058CD54
		private void ECLPOEOLJKN()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x0058EBB0 File Offset: 0x0058CDB0
		public void KEBGKMBDPDO(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 201f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x0058EBDE File Offset: 0x0058CDDE
		public void CPGBJBPDNPO(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.AAPBLHMFFHP(), 712f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x0058EC0C File Offset: 0x0058CE0C
		private void PLIGIHLCONH()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x0058EC68 File Offset: 0x0058CE68
		private void BOIFJMFAOGK()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.PECHJNHBGGD();
		}

		// Token: 0x0600C4BC RID: 50364 RVA: 0x0058ECB7 File Offset: 0x0058CEB7
		public void NKPMHPDCLDO(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.BLIABANFOLH, 152f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4BD RID: 50365 RVA: 0x0058ECE8 File Offset: 0x0058CEE8
		private void LAFINGNBFCJ()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.AAOJBHPOLGP();
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x0058ED38 File Offset: 0x0058CF38
		private void ACCKEFCOBGN()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.KNGNDJAFFFP();
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x0058ED87 File Offset: 0x0058CF87
		public void KIBODGJKNND(PointerEventData DNHBPGOKLKD)
		{
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), 324f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x0058EDB8 File Offset: 0x0058CFB8
		private void BHEHCDDBKIE()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.NOGNBELCJPC();
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x0058EE08 File Offset: 0x0058D008
		private void IJMOCPNLBDH()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.GCDGAONIBCG = array[i];
					}
				}
			}
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x0058CD91 File Offset: 0x0058AF91
		private void BNCAPAJOMIA()
		{
			this.MPFPHACDOCC.LGAMHBGCPLC();
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x0058EE64 File Offset: 0x0058D064
		public void IADAMBCJHGL(PointerEventData DNHBPGOKLKD)
		{
			if (this.GCDGAONIBCG == null)
			{
				this.NOGNBELCJPC();
			}
			this.MPFPHACDOCC.FANPFKHEDPA(Mathf.MoveTowards(this.MPFPHACDOCC.CIDBAOOKEAM(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x0058EEB4 File Offset: 0x0058D0B4
		private void DEGFGIDFFLD()
		{
			if (!CELBHNONENJ.CICNHOLEAPA(this.axisName))
			{
				this.MPFPHACDOCC = new CELBHNONENJ.FANBIHFODMJ(this.axisName);
				CELBHNONENJ.DNDFOKKIBGB(this.MPFPHACDOCC);
			}
			else
			{
				this.MPFPHACDOCC = CELBHNONENJ.APBAGEPLCKO(this.axisName);
			}
			this.HOLBFFJDDON();
		}

		// Token: 0x04001A2C RID: 6700
		public string axisName = "Horizontal";

		// Token: 0x04001A2D RID: 6701
		public float axisValue = 1f;

		// Token: 0x04001A2E RID: 6702
		public float responseSpeed = 3f;

		// Token: 0x04001A2F RID: 6703
		public float returnToCentreSpeed = 3f;

		// Token: 0x04001A30 RID: 6704
		private AxisTouchButton GCDGAONIBCG;

		// Token: 0x04001A31 RID: 6705
		private CELBHNONENJ.FANBIHFODMJ MPFPHACDOCC;
	}
}
