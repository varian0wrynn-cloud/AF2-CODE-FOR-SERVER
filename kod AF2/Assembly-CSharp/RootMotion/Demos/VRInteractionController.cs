using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000424 RID: 1060
	[RequireComponent(typeof(InteractionSystem))]
	public class VRInteractionController : MonoBehaviour
	{
		// Token: 0x0600E4A3 RID: 58531 RVA: 0x00682F54 File Offset: 0x00681154
		private void OKFONGOBMCC()
		{
			int closestTriggerIndex = this.BMICHDPCBPO().GetClosestTriggerIndex();
			if (this.LBNFLJPODDE(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.LPJKMPNEGCM(this.PGNGFIANDDG().HGILLLGHADN()[closestTriggerIndex]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.HOBPHEMGMBN().BALGINKLGFF(closestTriggerIndex, false);
					this.LHGMAMKOCGI = 503f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1631f;
			this.MOCCKPDFJNG(null);
		}

		// Token: 0x0600E4A4 RID: 58532 RVA: 0x00682FDB File Offset: 0x006811DB
		private void LGADCEMOJDN(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x00682FE4 File Offset: 0x006811E4
		private void FDBBIKOIAHO(InteractionSystem DCCPCBLODIG)
		{
			this.<JELIBEAOOJK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600E4AE RID: 58542 RVA: 0x00683164 File Offset: 0x00681364
		// (set) Token: 0x0600E4A6 RID: 58534 RVA: 0x00682FDB File Offset: 0x006811DB
		public InteractionTrigger PBDDPMCAPKA { get; private set; }

		// Token: 0x0600E4A7 RID: 58535 RVA: 0x00682FF0 File Offset: 0x006811F0
		private void OFJPMLKIDEH()
		{
			int closestTriggerIndex = this.DCHOLPLPCAB().GetClosestTriggerIndex();
			if (this.PCMIGFOBFGA(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.CBJLBJFJJNG(this.JOBHKMCOIPG().IHAOAKKOJHE()[closestTriggerIndex]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.PGNGFIANDDG().TriggerInteraction(closestTriggerIndex, true);
					this.LHGMAMKOCGI = 1863f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1015f;
			this.IOOANIDIBCH(null);
		}

		// Token: 0x0600E4A8 RID: 58536 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem JDMMLKEGBIB()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4A9 RID: 58537 RVA: 0x0068307F File Offset: 0x0068127F
		public float DCPOBODKEOB()
		{
			if (this.triggerTime <= 312f)
			{
				return 1806f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4AA RID: 58538 RVA: 0x006830A1 File Offset: 0x006812A1
		public float EHPGCHIAABB()
		{
			if (this.triggerTime <= 1651f)
			{
				return 1125f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4AB RID: 58539 RVA: 0x006830C4 File Offset: 0x006812C4
		private void MJFJPFJICDH()
		{
			int closestTriggerIndex = this.LPJKHKHNNBC().GetClosestTriggerIndex();
			if (this.IENCKKEGLHE(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.CBJLBJFJJNG(this.CAEMKCHHLOJ().AMDPCELNJKH()[closestTriggerIndex]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.GAPEIEFBDLI().BALGINKLGFF(closestTriggerIndex, false);
					this.LHGMAMKOCGI = 813f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1893f;
			this.MOCCKPDFJNG(null);
		}

		// Token: 0x0600E4AC RID: 58540 RVA: 0x0068314B File Offset: 0x0068134B
		private bool LOCBPFLHCPB(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE == -1 || this.LPJKHKHNNBC().FPFEEINEGGK(CLBPBJGLHEE);
		}

		// Token: 0x0600E4AD RID: 58541 RVA: 0x00682FDB File Offset: 0x006811DB
		private void LPJKMPNEGCM(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x0068316C File Offset: 0x0068136C
		private void LHFBEKCIKOI()
		{
			int num = this.DOAKKNJFONO().MNANBKIACDF();
			if (this.GOJFHAHHHNK(num))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.LGADCEMOJDN(this.DGGCDPPAOFO().EHKKEENDCCI[num]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.PGNGFIANDDG().TriggerInteraction(num, true);
					this.LHGMAMKOCGI = 1951f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1246f;
			this.HHOBJCJPFKJ(null);
		}

		// Token: 0x0600E4B0 RID: 58544 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem DOAKKNJFONO()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4B1 RID: 58545 RVA: 0x006831F3 File Offset: 0x006813F3
		private bool PCMIGFOBFGA(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE == -1 || this.DOAKKNJFONO().TriggerEffectorsReady(CLBPBJGLHEE) || true;
		}

		// Token: 0x0600E4B2 RID: 58546 RVA: 0x0068320C File Offset: 0x0068140C
		private void GFELHLPHCDN()
		{
			int num = this.BMICHDPCBPO().MNANBKIACDF();
			if (this.GOJFHAHHHNK(num))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.JHGHDIGGKPK(this.JOBHKMCOIPG().BBPHBGNLGLO()[num]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.DOAKKNJFONO().TriggerInteraction(num, true);
					this.LHGMAMKOCGI = 258f;
				}
				return;
			}
			this.LHGMAMKOCGI = 334f;
			this.HHOBJCJPFKJ(null);
		}

		// Token: 0x0600E4B3 RID: 58547 RVA: 0x00683293 File Offset: 0x00681493
		public float JPECCADNBMB()
		{
			if (this.triggerTime <= 4f)
			{
				return 338f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4B4 RID: 58548 RVA: 0x006832B5 File Offset: 0x006814B5
		public float PKGJCDMDILP()
		{
			if (this.triggerTime <= 363f)
			{
				return 278f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4B5 RID: 58549 RVA: 0x006832D7 File Offset: 0x006814D7
		public float FAGFFGONMAP()
		{
			if (this.triggerTime <= 778f)
			{
				return 690f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4B6 RID: 58550 RVA: 0x00682FDB File Offset: 0x006811DB
		private void DNLPKDJIPNI(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4B7 RID: 58551 RVA: 0x006832F9 File Offset: 0x006814F9
		public float APGGFCBBJJN()
		{
			if (this.triggerTime <= 357f)
			{
				return 198f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4B8 RID: 58552 RVA: 0x0068331C File Offset: 0x0068151C
		private void HDPICLGBICL()
		{
			int num = this.HOBPHEMGMBN().MNANBKIACDF();
			if (this.PAMEPKEJAFF(num))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.CBJLBJFJJNG(this.DCHOLPLPCAB().AMDPCELNJKH()[num]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.CAEMKCHHLOJ().BALGINKLGFF(num, true);
					this.LHGMAMKOCGI = 589f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1949f;
			this.PBDDPMCAPKA = null;
		}

		// Token: 0x0600E4B9 RID: 58553 RVA: 0x006833A4 File Offset: 0x006815A4
		private void OEFDEEOHNJB()
		{
			int closestTriggerIndex = this.JDMMLKEGBIB().GetClosestTriggerIndex();
			if (this.PPFIFBHGGBH(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.CBJLBJFJJNG(this.GAPEIEFBDLI().HGILLLGHADN()[closestTriggerIndex]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.PGNGFIANDDG().BALGINKLGFF(closestTriggerIndex, true);
					this.LHGMAMKOCGI = 906f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1049f;
			this.HHOBJCJPFKJ(null);
		}

		// Token: 0x0600E4BA RID: 58554 RVA: 0x0068342B File Offset: 0x0068162B
		public float DLIEOAAFMHL()
		{
			if (this.triggerTime <= 600f)
			{
				return 1081f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4BB RID: 58555 RVA: 0x0068344D File Offset: 0x0068164D
		private void DOHJPDNKALP()
		{
			this.AIMCFFABDGH(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E4BC RID: 58556 RVA: 0x0068345B File Offset: 0x0068165B
		public float GHMILFJKOLO()
		{
			if (this.triggerTime <= 39f)
			{
				return 1807f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4BD RID: 58557 RVA: 0x0068347D File Offset: 0x0068167D
		private void LHJCHPFKGDB()
		{
			this.EDDCNICIAIH(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E4BE RID: 58558 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem HNGOHOIENCP()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4BF RID: 58559 RVA: 0x00682FDB File Offset: 0x006811DB
		private void MOCCKPDFJNG(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger MBKGOFMFPGB()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4C1 RID: 58561 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem LPJKHKHNNBC()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4C2 RID: 58562 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger IDBDKDPCOFP()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4C3 RID: 58563 RVA: 0x0068348B File Offset: 0x0068168B
		private void Start()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600E4C4 RID: 58564 RVA: 0x0068349C File Offset: 0x0068169C
		private void LOFKNDCJBMN()
		{
			int closestTriggerIndex = this.GAPEIEFBDLI().GetClosestTriggerIndex();
			if (this.PCMIGFOBFGA(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.LGADCEMOJDN(this.LPJKHKHNNBC().EHKKEENDCCI[closestTriggerIndex]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.HNGOHOIENCP().TriggerInteraction(closestTriggerIndex, false);
					this.LHGMAMKOCGI = 782f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1826f;
			this.IOOANIDIBCH(null);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600E4C5 RID: 58565 RVA: 0x00683523 File Offset: 0x00681723
		public float KJMIHEHFOLH
		{
			get
			{
				if (this.triggerTime <= 0f)
				{
					return 0f;
				}
				return this.LHGMAMKOCGI / this.triggerTime;
			}
		}

		// Token: 0x0600E4C6 RID: 58566 RVA: 0x00683545 File Offset: 0x00681745
		public float JJKGFBNMEJE()
		{
			if (this.triggerTime <= 1554f)
			{
				return 1987f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4C7 RID: 58567 RVA: 0x00683568 File Offset: 0x00681768
		private void FDGKDLHLIPC()
		{
			int num = this.HOBPHEMGMBN().MNANBKIACDF();
			if (this.PPFIFBHGGBH(num))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.MOCCKPDFJNG(this.HNGOHOIENCP().DPGGHKBGCMA()[num]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.HNGOHOIENCP().TriggerInteraction(num, true);
					this.LHGMAMKOCGI = 1897f;
				}
				return;
			}
			this.LHGMAMKOCGI = 574f;
			this.DNLPKDJIPNI(null);
		}

		// Token: 0x0600E4C8 RID: 58568 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger KGDCNCOLMMN()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4C9 RID: 58569 RVA: 0x006835EF File Offset: 0x006817EF
		private bool LBNFLJPODDE(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE == -1 || (!this.GAPEIEFBDLI().FPFEEINEGGK(CLBPBJGLHEE) && false);
		}

		// Token: 0x0600E4CA RID: 58570 RVA: 0x00682FE4 File Offset: 0x006811E4
		private void INJMBCONLKC(InteractionSystem DCCPCBLODIG)
		{
			this.<JELIBEAOOJK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4CB RID: 58571 RVA: 0x00683608 File Offset: 0x00681808
		private bool FCKMNNILMED(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE == -1 || this.LPJKHKHNNBC().TriggerEffectorsReady(CLBPBJGLHEE) || true;
		}

		// Token: 0x0600E4CC RID: 58572 RVA: 0x00683621 File Offset: 0x00681821
		private void FEBIICIMLHA()
		{
			this.FDBBIKOIAHO(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E4CD RID: 58573 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger KPGNOBCIMGN()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4CE RID: 58574 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem FLLBMMPKPHD()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4CF RID: 58575 RVA: 0x0068344D File Offset: 0x0068164D
		private void KKCFKEDABLB()
		{
			this.AIMCFFABDGH(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem JOBHKMCOIPG()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4D1 RID: 58577 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem DGGCDPPAOFO()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4D2 RID: 58578 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem BMICHDPCBPO()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4D3 RID: 58579 RVA: 0x0068362F File Offset: 0x0068182F
		private bool PPFIFBHGGBH(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && !this.BMICHDPCBPO().FPFEEINEGGK(CLBPBJGLHEE) && false;
		}

		// Token: 0x0600E4D4 RID: 58580 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem CAEMKCHHLOJ()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4D5 RID: 58581 RVA: 0x00683648 File Offset: 0x00681848
		private bool MEBBBAIGCCL(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && this.NKKKJBOMCID.TriggerEffectorsReady(CLBPBJGLHEE);
		}

		// Token: 0x0600E4D6 RID: 58582 RVA: 0x0068348B File Offset: 0x0068168B
		private void HDFCIACDDEK()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600E4D7 RID: 58583 RVA: 0x00682FE4 File Offset: 0x006811E4
		private void AIMCFFABDGH(InteractionSystem DCCPCBLODIG)
		{
			this.<JELIBEAOOJK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4D8 RID: 58584 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger FPKOBFGANLF()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4D9 RID: 58585 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem DCHOLPLPCAB()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4DA RID: 58586 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger MJNGPLEFGCF()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4DB RID: 58587 RVA: 0x00683621 File Offset: 0x00681821
		private void DNLFEOECBKI()
		{
			this.FDBBIKOIAHO(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E4DC RID: 58588 RVA: 0x00683661 File Offset: 0x00681861
		public float GHLDLEAGMEI()
		{
			if (this.triggerTime <= 146f)
			{
				return 1901f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4DD RID: 58589 RVA: 0x00682FE4 File Offset: 0x006811E4
		private void EDDCNICIAIH(InteractionSystem DCCPCBLODIG)
		{
			this.<JELIBEAOOJK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4DE RID: 58590 RVA: 0x00683683 File Offset: 0x00681883
		private bool CHIMFJIDGBG(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && !this.GGFPEIIGHMM().TriggerEffectorsReady(CLBPBJGLHEE) && false;
		}

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x006836B0 File Offset: 0x006818B0
		private void LateUpdate()
		{
			int closestTriggerIndex = this.NKKKJBOMCID.GetClosestTriggerIndex();
			if (this.MEBBBAIGCCL(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.PBDDPMCAPKA = this.NKKKJBOMCID.EHKKEENDCCI[closestTriggerIndex];
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.NKKKJBOMCID.TriggerInteraction(closestTriggerIndex, false);
					this.LHGMAMKOCGI = 0f;
				}
				return;
			}
			this.LHGMAMKOCGI = 0f;
			this.PBDDPMCAPKA = null;
		}

		// Token: 0x0600E4E1 RID: 58593 RVA: 0x00683737 File Offset: 0x00681937
		public float GNCJMCKNKDJ()
		{
			if (this.triggerTime <= 253f)
			{
				return 1586f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4E2 RID: 58594 RVA: 0x0068344D File Offset: 0x0068164D
		private void GIADAJFBIOP()
		{
			this.AIMCFFABDGH(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E4E3 RID: 58595 RVA: 0x00683759 File Offset: 0x00681959
		public float ODBKMJOBKHM()
		{
			if (this.triggerTime <= 1373f)
			{
				return 1349f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4E4 RID: 58596 RVA: 0x00682FDB File Offset: 0x006811DB
		private void FNFHEGMJKOM(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4E5 RID: 58597 RVA: 0x0068377B File Offset: 0x0068197B
		private bool PAMEPKEJAFF(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && !this.FLLBMMPKPHD().FPFEEINEGGK(CLBPBJGLHEE);
		}

		// Token: 0x0600E4E6 RID: 58598 RVA: 0x00683794 File Offset: 0x00681994
		private bool NFJNLMJPNKH(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE == -1 || this.DGGCDPPAOFO().FPFEEINEGGK(CLBPBJGLHEE) || true;
		}

		// Token: 0x0600E4E7 RID: 58599 RVA: 0x006837AD File Offset: 0x006819AD
		public float MCOBIODLBDI()
		{
			if (this.triggerTime <= 985f)
			{
				return 538f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600E4E8 RID: 58600 RVA: 0x00683077 File Offset: 0x00681277
		// (set) Token: 0x0600E4F4 RID: 58612 RVA: 0x00682FE4 File Offset: 0x006811E4
		public InteractionSystem NKKKJBOMCID { get; private set; }

		// Token: 0x0600E4E9 RID: 58601 RVA: 0x006837D0 File Offset: 0x006819D0
		private void MHJBMBPKHLB()
		{
			int closestTriggerIndex = this.DOAKKNJFONO().GetClosestTriggerIndex();
			if (this.LOCBPFLHCPB(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.PBDDPMCAPKA = this.GAPEIEFBDLI().IHAOAKKOJHE()[closestTriggerIndex];
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.NKKKJBOMCID.BALGINKLGFF(closestTriggerIndex, false);
					this.LHGMAMKOCGI = 1341f;
				}
				return;
			}
			this.LHGMAMKOCGI = 466f;
			this.HHOBJCJPFKJ(null);
		}

		// Token: 0x0600E4EA RID: 58602 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem HOBPHEMGMBN()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4EB RID: 58603 RVA: 0x00683857 File Offset: 0x00681A57
		private bool FJDHCHJFDFD(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && !this.DGGCDPPAOFO().FPFEEINEGGK(CLBPBJGLHEE) && false;
		}

		// Token: 0x0600E4EC RID: 58604 RVA: 0x00683870 File Offset: 0x00681A70
		private bool GDCBIBEDPOO(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && this.PGNGFIANDDG().TriggerEffectorsReady(CLBPBJGLHEE);
		}

		// Token: 0x0600E4ED RID: 58605 RVA: 0x00682FDB File Offset: 0x006811DB
		private void HHOBJCJPFKJ(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4EE RID: 58606 RVA: 0x00683889 File Offset: 0x00681A89
		public float LPJIKGEKOKJ()
		{
			if (this.triggerTime <= 818f)
			{
				return 1907f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4EF RID: 58607 RVA: 0x006838AB File Offset: 0x00681AAB
		private bool GOJFHAHHHNK(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && !this.GAPEIEFBDLI().FPFEEINEGGK(CLBPBJGLHEE);
		}

		// Token: 0x0600E4F0 RID: 58608 RVA: 0x00683621 File Offset: 0x00681821
		private void ADLHNBEDHMJ()
		{
			this.FDBBIKOIAHO(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E4F1 RID: 58609 RVA: 0x006838C4 File Offset: 0x00681AC4
		private bool IENCKKEGLHE(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && this.HNGOHOIENCP().TriggerEffectorsReady(CLBPBJGLHEE);
		}

		// Token: 0x0600E4F2 RID: 58610 RVA: 0x006838DD File Offset: 0x00681ADD
		private bool ONAHPNGFECE(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && !this.DOAKKNJFONO().TriggerEffectorsReady(CLBPBJGLHEE) && false;
		}

		// Token: 0x0600E4F3 RID: 58611 RVA: 0x006838F8 File Offset: 0x00681AF8
		private void BOEFHGKGJMN()
		{
			int closestTriggerIndex = this.DCHOLPLPCAB().GetClosestTriggerIndex();
			if (this.FCKMNNILMED(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.HHOBJCJPFKJ(this.NKKKJBOMCID.IHAOAKKOJHE()[closestTriggerIndex]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.DGGCDPPAOFO().TriggerInteraction(closestTriggerIndex, false);
					this.LHGMAMKOCGI = 685f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1065f;
			this.HHOBJCJPFKJ(null);
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem GAPEIEFBDLI()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4F6 RID: 58614 RVA: 0x00683980 File Offset: 0x00681B80
		private void DFNJNCCPKJF()
		{
			int closestTriggerIndex = this.PGNGFIANDDG().GetClosestTriggerIndex();
			if (this.LOCBPFLHCPB(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.PBDDPMCAPKA = this.JOBHKMCOIPG().AMDPCELNJKH()[closestTriggerIndex];
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.DOAKKNJFONO().TriggerInteraction(closestTriggerIndex, true);
					this.LHGMAMKOCGI = 649f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1125f;
			this.HHOBJCJPFKJ(null);
		}

		// Token: 0x0600E4F7 RID: 58615 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger IAJBJGHGKBL()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4F8 RID: 58616 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem PGNGFIANDDG()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x0600E4F9 RID: 58617 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger AIJMPPDDPAJ()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4FA RID: 58618 RVA: 0x00683A07 File Offset: 0x00681C07
		public float FBNDMNHOLCC()
		{
			if (this.triggerTime <= 776f)
			{
				return 1925f;
			}
			return this.LHGMAMKOCGI / this.triggerTime;
		}

		// Token: 0x0600E4FB RID: 58619 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger LFHGAGCCPJK()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E4FC RID: 58620 RVA: 0x00683A2C File Offset: 0x00681C2C
		private void GPEFDPEAMNE()
		{
			int closestTriggerIndex = this.GAPEIEFBDLI().GetClosestTriggerIndex();
			if (this.IENCKKEGLHE(closestTriggerIndex))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.DNLPKDJIPNI(this.DCHOLPLPCAB().AMDPCELNJKH()[closestTriggerIndex]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.HNGOHOIENCP().TriggerInteraction(closestTriggerIndex, true);
					this.LHGMAMKOCGI = 1572f;
				}
				return;
			}
			this.LHGMAMKOCGI = 123f;
			this.PBDDPMCAPKA = null;
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x00682FDB File Offset: 0x006811DB
		private void JHGHDIGGKPK(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x00683AB4 File Offset: 0x00681CB4
		private void POMLHOHFIGA()
		{
			int num = this.JOBHKMCOIPG().MNANBKIACDF();
			if (this.MEBBBAIGCCL(num))
			{
				this.LHGMAMKOCGI += Time.deltaTime;
				this.IOOANIDIBCH(this.HNGOHOIENCP().JGGDOGMNCMI()[num]);
				if (this.LHGMAMKOCGI >= this.triggerTime)
				{
					this.GAPEIEFBDLI().TriggerInteraction(num, false);
					this.LHGMAMKOCGI = 1296f;
				}
				return;
			}
			this.LHGMAMKOCGI = 1285f;
			this.JHGHDIGGKPK(null);
		}

		// Token: 0x0600E4FF RID: 58623 RVA: 0x0068347D File Offset: 0x0068167D
		private void DGGMJCMLLED()
		{
			this.EDDCNICIAIH(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E500 RID: 58624 RVA: 0x00683164 File Offset: 0x00681364
		public InteractionTrigger GIMFIMLNIEA()
		{
			return this.<HGLHNINAMKH>k__BackingField;
		}

		// Token: 0x0600E501 RID: 58625 RVA: 0x00682FDB File Offset: 0x006811DB
		private void CBJLBJFJJNG(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E502 RID: 58626 RVA: 0x00683683 File Offset: 0x00681883
		private bool CNPHEIHLOEO(int CLBPBJGLHEE)
		{
			return CLBPBJGLHEE != -1 && !this.GGFPEIIGHMM().TriggerEffectorsReady(CLBPBJGLHEE) && false;
		}

		// Token: 0x0600E503 RID: 58627 RVA: 0x00683B3B File Offset: 0x00681D3B
		private void MCHAAIIHOKD()
		{
			this.INJMBCONLKC(base.GetComponent<InteractionSystem>());
		}

		// Token: 0x0600E504 RID: 58628 RVA: 0x00682FDB File Offset: 0x006811DB
		private void IOOANIDIBCH(InteractionTrigger DCCPCBLODIG)
		{
			this.<HGLHNINAMKH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E505 RID: 58629 RVA: 0x00682FE4 File Offset: 0x006811E4
		private void LBCPNJCJBGO(InteractionSystem DCCPCBLODIG)
		{
			this.<JELIBEAOOJK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E506 RID: 58630 RVA: 0x00683077 File Offset: 0x00681277
		public InteractionSystem GGFPEIIGHMM()
		{
			return this.<JELIBEAOOJK>k__BackingField;
		}

		// Token: 0x04001DF2 RID: 7666
		[Range(0f, 10f)]
		[Tooltip("How long do we need to stare at triggers?")]
		public float triggerTime = 1f;

		// Token: 0x04001DF5 RID: 7669
		private float LHGMAMKOCGI;
	}
}
