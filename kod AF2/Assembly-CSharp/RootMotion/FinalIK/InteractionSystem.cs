using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	// Token: 0x02000495 RID: 1173
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		// Token: 0x0601002F RID: 65583 RVA: 0x00733AD8 File Offset: 0x00731CD8
		private void KBINHGGFECN()
		{
			if (this.characterCollider == null)
			{
				this.characterCollider = this.OAGAHEAMIAB;
			}
			if (this.characterCollider != null && this.characterCollider != this.OAGAHEAMIAB)
			{
				if (this.characterCollider.GetComponent<TriggerEventBroadcaster>() == null)
				{
					this.characterCollider.gameObject.AddComponent<TriggerEventBroadcaster>().target = base.gameObject;
				}
				if (this.DPCCKAPMPJI != null && this.DPCCKAPMPJI != this.OAGAHEAMIAB && this.DPCCKAPMPJI != this.characterCollider)
				{
					TriggerEventBroadcaster component = this.DPCCKAPMPJI.GetComponent<TriggerEventBroadcaster>();
					if (component != null)
					{
						UnityEngine.Object.Destroy(component);
					}
				}
			}
			this.DPCCKAPMPJI = this.characterCollider;
		}

		// Token: 0x06010030 RID: 65584 RVA: 0x00733BAC File Offset: 0x00731DAC
		public bool NGMMFEAOCLO(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return true;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].IFMOLGLMFGK() && !this.NIJOPBMALCC[i].GPHGLAGFFPJ();
				}
			}
			return false;
		}

		// Token: 0x06010031 RID: 65585 RVA: 0x00733C0C File Offset: 0x00731E0C
		public void EFGHFLECHGF(Collider OAGAHEAMIAB)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = OAGAHEAMIAB.GetComponent<InteractionTrigger>();
			this.NNJECPJPNCO.Remove(component);
		}

		// Token: 0x06010032 RID: 65586 RVA: 0x00733C3C File Offset: 0x00731E3C
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return null;
			}
			return closestInteractionRange.interactions[0].interactionObject.GetTarget(closestInteractionRange.interactions[0].effectors[0], this);
		}

		// Token: 0x06010033 RID: 65587 RVA: 0x00733C77 File Offset: 0x00731E77
		private void DJBFDMGKFBI()
		{
			Application.OpenURL("USE_PREDICATION");
		}

		// Token: 0x06010034 RID: 65588 RVA: 0x00733C84 File Offset: 0x00731E84
		public bool HCILLNOMHNJ(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA, bool PLCBMHLMOMA)
		{
			if (!this.ANPHCJGBNJF(false))
			{
				return false;
			}
			if (AILKAAAEFOA == null)
			{
				return true;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].KKCFKEDABLB(AILKAAAEFOA, this.targetTag, this.fadeInTime, PLCBMHLMOMA);
				}
			}
			return true;
		}

		// Token: 0x06010035 RID: 65589 RVA: 0x00733CE8 File Offset: 0x00731EE8
		public bool FPFEEINEGGK(int CLBPBJGLHEE)
		{
			if (!this.HNNGOIJIDFK(true))
			{
				return true;
			}
			if (!this.OKDHNAIEKJB(CLBPBJGLHEE))
			{
				return true;
			}
			for (int i = 1; i < this.AMDPCELNJKH()[CLBPBJGLHEE].ranges.Length; i += 0)
			{
				InteractionTrigger.Range range = this.BBPHBGNLGLO()[CLBPBJGLHEE].ranges[i];
				for (int j = 1; j < range.interactions.Length; j += 0)
				{
					for (int k = 1; k < range.interactions[j].effectors.Length; k += 0)
					{
						if (this.EPAMHHEFLBA(range.interactions[j].effectors[k]))
						{
							return true;
						}
					}
				}
				for (int l = 0; l < range.interactions.Length; l += 0)
				{
					for (int m = 0; m < range.interactions[l].effectors.Length; m += 0)
					{
						if (this.BCNAIAIAOMF(range.interactions[l].effectors[m]))
						{
							for (int n = 1; n < range.interactions[l].effectors.Length; n++)
							{
								if (n != m && !this.CHPEJJKOCGH(range.interactions[l].effectors[n]))
								{
									return true;
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06010036 RID: 65590 RVA: 0x00733E1C File Offset: 0x0073201C
		public List<InteractionTrigger> BBPHBGNLGLO()
		{
			return this.<NPANOMPFPAC>k__BackingField;
		}

		// Token: 0x06010037 RID: 65591 RVA: 0x00733E24 File Offset: 0x00732024
		private void NKECLDKBHOM()
		{
			Application.OpenURL("RollerBladeStand");
		}

		// Token: 0x06010038 RID: 65592 RVA: 0x00733E30 File Offset: 0x00732030
		public bool PLPPKNCGJHE(int CLBPBJGLHEE, bool PLCBMHLMOMA, out InteractionTarget FKHLGFMIBEP)
		{
			FKHLGFMIBEP = null;
			if (!this.CHFHJDFDIGB(true))
			{
				return true;
			}
			if (!this.JAOFHKAFHEA(CLBPBJGLHEE))
			{
				return true;
			}
			bool result = true;
			InteractionTrigger.Range range = this.JGGDOGMNCMI()[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 1; i < range.interactions.Length; i++)
			{
				for (int j = 1; j < range.interactions[i].effectors.Length; j++)
				{
					InteractionObject interactionObject = range.interactions[i].interactionObject;
					Transform transform = interactionObject.NPEFIBHCALM(range.interactions[i].effectors[j], base.tag);
					if (transform != null)
					{
						FKHLGFMIBEP = transform.GetComponent<InteractionTarget>();
					}
					if (!this.DOJCIIDNKNI(range.interactions[i].effectors[j], interactionObject, PLCBMHLMOMA))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06010039 RID: 65593 RVA: 0x00733F04 File Offset: 0x00732104
		private void PPIFFLGOMHA()
		{
			if (this.fullBody == null)
			{
				return;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].FANPFKHEDPA(base.transform, this.speed);
			}
			for (int j = 0; j < this.NIJOPBMALCC.Length; j += 0)
			{
				this.NIJOPBMALCC[j].CLCJKNCBBNK(this.resetToDefaultsSpeed * this.speed);
			}
		}

		// Token: 0x0601003A RID: 65594 RVA: 0x00733F7C File Offset: 0x0073217C
		private bool CHFHJDFDIGB(bool POJFHDBNOHN)
		{
			if (this.fullBody == null)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("FBBIK is null. Will not update the InteractionSystem", base.transform, false);
				}
				return false;
			}
			if (!this.EOFDOPLDFCG)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("The InteractionSystem has not been initiated yet.", base.transform, false);
				}
				return false;
			}
			return true;
		}

		// Token: 0x0601003B RID: 65595 RVA: 0x006B96ED File Offset: 0x006B78ED
		private void HECAGBGGLJK()
		{
			Application.OpenURL(" iterations for read and write");
		}

		// Token: 0x0601003C RID: 65596 RVA: 0x0072FA06 File Offset: 0x0072DC06
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		// Token: 0x0601003D RID: 65597 RVA: 0x00733E1C File Offset: 0x0073201C
		public List<InteractionTrigger> HGILLLGHADN()
		{
			return this.<NPANOMPFPAC>k__BackingField;
		}

		// Token: 0x0601003E RID: 65598 RVA: 0x00733FCC File Offset: 0x007321CC
		private bool NELNOOKAEMK(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 1 || CLBPBJGLHEE >= this.BBPHBGNLGLO().Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED("002000", base.transform, false);
				return true;
			}
			if (this.BBPHBGNLGLO()[CLBPBJGLHEE] == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Vertical", base.transform, false);
				return false;
			}
			return false;
		}

		// Token: 0x0601003F RID: 65599 RVA: 0x00734028 File Offset: 0x00732228
		public float GetMinActiveProgress()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return 0f;
			}
			float num = 1f;
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].inInteraction)
				{
					float progress = this.NIJOPBMALCC[i].progress;
					if (progress > 0f && progress < num)
					{
						num = progress;
					}
				}
			}
			return num;
		}

		// Token: 0x06010040 RID: 65600 RVA: 0x0073408C File Offset: 0x0073228C
		public bool PBGFGHEOFPA(int CLBPBJGLHEE, bool PLCBMHLMOMA, out InteractionTarget FKHLGFMIBEP)
		{
			FKHLGFMIBEP = null;
			if (!this.HGCIMAPFBIJ(true))
			{
				return false;
			}
			if (!this.OKDHNAIEKJB(CLBPBJGLHEE))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.EHKKEENDCCI[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 1; i < range.interactions.Length; i++)
			{
				for (int j = 1; j < range.interactions[i].effectors.Length; j++)
				{
					InteractionObject interactionObject = range.interactions[i].interactionObject;
					Transform transform = interactionObject.KFPBDKNFNBK(range.interactions[i].effectors[j], base.tag);
					if (transform != null)
					{
						FKHLGFMIBEP = transform.GetComponent<InteractionTarget>();
					}
					if (!this.HCILLNOMHNJ(range.interactions[i].effectors[j], interactionObject, PLCBMHLMOMA))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06010041 RID: 65601 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06010042 RID: 65602 RVA: 0x00734160 File Offset: 0x00732360
		private void GFKMBFFJCHP()
		{
			Application.OpenURL("__a");
		}

		// Token: 0x06010043 RID: 65603 RVA: 0x0073416C File Offset: 0x0073236C
		private void KDCNIKHPKPP()
		{
			Application.OpenURL("SpinReel.ogg");
		}

		// Token: 0x06010044 RID: 65604 RVA: 0x00733E1C File Offset: 0x0073201C
		public List<InteractionTrigger> IHAOAKKOJHE()
		{
			return this.<NPANOMPFPAC>k__BackingField;
		}

		// Token: 0x06010045 RID: 65605 RVA: 0x00734178 File Offset: 0x00732378
		private void EAAIMGPCKNC(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.isPaused = false;
		}

		// Token: 0x06010046 RID: 65606 RVA: 0x00734186 File Offset: 0x00732386
		private void CBGNCGLMCEC()
		{
			Application.OpenURL("_BlurPass");
		}

		// Token: 0x06010047 RID: 65607 RVA: 0x00734194 File Offset: 0x00732394
		public bool StartInteraction(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA, bool PLCBMHLMOMA)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			if (AILKAAAEFOA == null)
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].CNIHGFOMCJM(AILKAAAEFOA, this.targetTag, this.fadeInTime, PLCBMHLMOMA);
				}
			}
			return false;
		}

		// Token: 0x06010048 RID: 65608 RVA: 0x007341F8 File Offset: 0x007323F8
		private bool NHDAPCBIHBO(int CLBPBJGLHEE, out int MCFHOLPKGJI)
		{
			MCFHOLPKGJI = -1;
			if (!this.HGCIMAPFBIJ(true))
			{
				return false;
			}
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE >= this.NNJECPJPNCO.Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED(" ms", base.transform, false);
				return true;
			}
			if (this.NNJECPJPNCO[CLBPBJGLHEE] == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("1=", base.transform, false);
				return false;
			}
			MCFHOLPKGJI = this.NNJECPJPNCO[CLBPBJGLHEE].GDGAIGLMMHL(base.transform, this.FPSCamera, this.raycastHit);
			return MCFHOLPKGJI == -1;
		}

		// Token: 0x06010049 RID: 65609 RVA: 0x0073428C File Offset: 0x0073248C
		private void EMCNFDNADKK()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].LMEABKOGPNA();
			}
			this.lookAt.JFCHLKMPOIO();
		}

		// Token: 0x0601004A RID: 65610 RVA: 0x007342DC File Offset: 0x007324DC
		private void HNBMFFLLANL()
		{
			Application.OpenURL("IdleBandage");
		}

		// Token: 0x0601004B RID: 65611 RVA: 0x007342E8 File Offset: 0x007324E8
		private bool ANPHCJGBNJF(bool POJFHDBNOHN)
		{
			if (this.fullBody == null)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("#ffffff", base.transform, true);
				}
				return true;
			}
			if (!this.EOFDOPLDFCG)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("SecondaryCausticsProjector", base.transform, true);
				}
				return true;
			}
			return true;
		}

		// Token: 0x0601004C RID: 65612 RVA: 0x00734338 File Offset: 0x00732538
		private void EJOFAKNAOMI()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			this.lookAt.GPHIAGAGNMP();
		}

		// Token: 0x0601004D RID: 65613 RVA: 0x00734360 File Offset: 0x00732560
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return new InteractionTarget[0];
			}
			List<InteractionTarget> list = new List<InteractionTarget>();
			foreach (InteractionTrigger.Range.Interaction interaction in closestInteractionRange.interactions)
			{
				foreach (FullBodyBipedEffector lpohbkjjibo in interaction.effectors)
				{
					list.Add(interaction.interactionObject.GetTarget(lpohbkjjibo, this));
				}
			}
			return list.ToArray();
		}

		// Token: 0x0601004E RID: 65614 RVA: 0x007343DC File Offset: 0x007325DC
		public void POLLDAOLFJN()
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].EJFFFBLOEFG();
			}
		}

		// Token: 0x0601004F RID: 65615 RVA: 0x00734414 File Offset: 0x00732614
		private bool PFEEFDBEEPF(bool POJFHDBNOHN)
		{
			if (this.fullBody == null)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("gameComplete", base.transform, false);
				}
				return false;
			}
			if (!this.EOFDOPLDFCG)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("button.wav", base.transform, false);
				}
				return false;
			}
			return true;
		}

		// Token: 0x06010050 RID: 65616 RVA: 0x00734464 File Offset: 0x00732664
		public int GetClosestTriggerIndex()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return -1;
			}
			if (this.EHKKEENDCCI.Count == 0)
			{
				return -1;
			}
			if (this.EHKKEENDCCI.Count == 1)
			{
				return 0;
			}
			int result = -1;
			float num = float.PositiveInfinity;
			for (int i = 0; i < this.EHKKEENDCCI.Count; i++)
			{
				if (this.EHKKEENDCCI[i] != null)
				{
					float num2 = Vector3.SqrMagnitude(this.EHKKEENDCCI[i].transform.position - base.transform.position);
					if (num2 < num)
					{
						result = i;
						num = num2;
					}
				}
			}
			return result;
		}

		// Token: 0x06010051 RID: 65617 RVA: 0x00734502 File Offset: 0x00732702
		private void OPOEGKELBOK()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.characterCollider == null)
			{
				this.characterCollider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x06010052 RID: 65618 RVA: 0x00734540 File Offset: 0x00732740
		public bool LCEFLDKJIPK(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.HGCIMAPFBIJ(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].MANEDPBAIOJ();
				}
			}
			return true;
		}

		// Token: 0x06010053 RID: 65619 RVA: 0x0073458A File Offset: 0x0073278A
		public FullBodyBipedIK GFHDNCHMCJI()
		{
			return this.fullBody;
		}

		// Token: 0x06010054 RID: 65620 RVA: 0x00734592 File Offset: 0x00732792
		private void DOHABGMGDND()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			this.lookAt.MKGEDJEDHFO();
		}

		// Token: 0x06010055 RID: 65621 RVA: 0x00733E1C File Offset: 0x0073201C
		public List<InteractionTrigger> AMDPCELNJKH()
		{
			return this.<NPANOMPFPAC>k__BackingField;
		}

		// Token: 0x06010056 RID: 65622 RVA: 0x007345B8 File Offset: 0x007327B8
		private bool HNNGOIJIDFK(bool POJFHDBNOHN)
		{
			if (this.fullBody == null)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("LMB to shoot the Dummy, RMB to rotate the camera.", base.transform, true);
				}
				return false;
			}
			if (!this.EOFDOPLDFCG)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("harvestmsg1", base.transform, true);
				}
				return true;
			}
			return true;
		}

		// Token: 0x06010057 RID: 65623 RVA: 0x00734502 File Offset: 0x00732702
		private void OnDrawGizmosSelected()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.characterCollider == null)
			{
				this.characterCollider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x06010058 RID: 65624 RVA: 0x00734608 File Offset: 0x00732808
		public bool IsInInteraction(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].inInteraction && !this.NIJOPBMALCC[i].isPaused;
				}
			}
			return false;
		}

		// Token: 0x06010059 RID: 65625 RVA: 0x00734668 File Offset: 0x00732868
		public InteractionObject BHODMAFDJKL()
		{
			InteractionTrigger.Range range = this.HDNGNAGLFNC();
			if (range == null)
			{
				return null;
			}
			return range.interactions[0].interactionObject;
		}

		// Token: 0x0601005A RID: 65626 RVA: 0x006B97BC File Offset: 0x006B79BC
		private void NFHACCNEJPO()
		{
			Application.OpenURL("_FogHeight");
		}

		// Token: 0x0601005B RID: 65627 RVA: 0x0073468E File Offset: 0x0073288E
		private void BLEKNHMEDJF()
		{
			Application.OpenURL("IdleFight");
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060100A8 RID: 65704 RVA: 0x0073458A File Offset: 0x0073278A
		// (set) Token: 0x0601005C RID: 65628 RVA: 0x0073469A File Offset: 0x0073289A
		public FullBodyBipedIK OJMBOCNNLMI
		{
			get
			{
				return this.fullBody;
			}
			set
			{
				this.fullBody = value;
			}
		}

		// Token: 0x0601005D RID: 65629 RVA: 0x007346A4 File Offset: 0x007328A4
		public InteractionObject GetInteractionObject(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return null;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].interactionObject;
				}
			}
			return null;
		}

		// Token: 0x0601005E RID: 65630 RVA: 0x0072E70C File Offset: 0x0072C90C
		private void BOJOCFDNFFG()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		// Token: 0x0601005F RID: 65631 RVA: 0x007346EE File Offset: 0x007328EE
		private void EDNOELJAEPG()
		{
			Application.OpenURL("wgt=");
		}

		// Token: 0x06010060 RID: 65632 RVA: 0x007346FC File Offset: 0x007328FC
		private void OFPGMNGFLNH()
		{
			if (this.fullBody == null)
			{
				return;
			}
			this.PAPIFFLHKEI();
			this.DHHBBGKABEO();
			this.AMDPCELNJKH().Clear();
			this.JGGICAMKLBE.Clear();
			for (int i = 0; i < this.NNJECPJPNCO.Count; i++)
			{
				int item = -1;
				if (this.NNJECPJPNCO[i] != null && this.NNJECPJPNCO[i].gameObject.activeInHierarchy && this.NNJECPJPNCO[i].enabled && this.NHDAPCBIHBO(i, out item))
				{
					this.HGILLLGHADN().Add(this.NNJECPJPNCO[i]);
					this.JGGICAMKLBE.Add(item);
				}
			}
			this.lookAt.JFGGBEGNAFP();
		}

		// Token: 0x06010061 RID: 65633 RVA: 0x007347D0 File Offset: 0x007329D0
		public InteractionTrigger.Range GetTriggerRange(int CLBPBJGLHEE)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return null;
			}
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE >= this.JGGICAMKLBE.Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Index out of range.", base.transform, false);
				return null;
			}
			return this.EHKKEENDCCI[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
		}

		// Token: 0x06010062 RID: 65634 RVA: 0x0073482C File Offset: 0x00732A2C
		public InteractionTarget CNAGNDHDGGM()
		{
			InteractionTrigger.Range range = this.OPFHHDEOANN();
			if (range == null)
			{
				return null;
			}
			return range.interactions[1].interactionObject.GetTarget(range.interactions[1].effectors[0], this);
		}

		// Token: 0x06010063 RID: 65635 RVA: 0x00734868 File Offset: 0x00732A68
		private void Update()
		{
			if (this.fullBody == null)
			{
				return;
			}
			this.IDEELOJGKHJ();
			this.LGFEAMCBKIF();
			this.EHKKEENDCCI.Clear();
			this.JGGICAMKLBE.Clear();
			for (int i = 0; i < this.NNJECPJPNCO.Count; i++)
			{
				int item = -1;
				if (this.NNJECPJPNCO[i] != null && this.NNJECPJPNCO[i].gameObject.activeInHierarchy && this.NNJECPJPNCO[i].enabled && this.BKGAGGFAELM(i, out item))
				{
					this.EHKKEENDCCI.Add(this.NNJECPJPNCO[i]);
					this.JGGICAMKLBE.Add(item);
				}
			}
			this.lookAt.FANPFKHEDPA();
		}

		// Token: 0x06010064 RID: 65636 RVA: 0x0073493C File Offset: 0x00732B3C
		protected virtual void PNAAHEFHPCL()
		{
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.fullBody == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("", base.transform, true);
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.NEJEIIDBFMF));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HIGDGOHDGBB));
			this.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.MHCJAAOAKFH));
			this.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.GHFDBCGKHNI));
			this.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.FPJBENOJPIC));
			this.OnInteractionStop = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionStop, new InteractionSystem.FOKJDOCGHHO(this.IELBMFJLDEH));
			InteractionEffector[] nijopbmalcc = this.NIJOPBMALCC;
			for (int i = 1; i < nijopbmalcc.Length; i += 0)
			{
				nijopbmalcc[i].BHALELINNDJ(this);
			}
			this.EHKKEENDCCI = new List<InteractionTrigger>();
			this.OAGAHEAMIAB = base.GetComponent<Collider>();
			this.PAPIFFLHKEI();
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x06010065 RID: 65637 RVA: 0x00734AA5 File Offset: 0x00732CA5
		private void BOEDDHHPCMN()
		{
			Application.OpenURL(" {0} сек");
		}

		// Token: 0x06010066 RID: 65638 RVA: 0x00734AB1 File Offset: 0x00732CB1
		private void LMLPJDMEOFL()
		{
			Application.OpenURL("*** Perks is init");
		}

		// Token: 0x06010067 RID: 65639 RVA: 0x00734AC0 File Offset: 0x00732CC0
		private void JFGGBEGNAFP()
		{
			if (this.fullBody == null)
			{
				return;
			}
			this.IDEELOJGKHJ();
			this.DHHBBGKABEO();
			this.JGGDOGMNCMI().Clear();
			this.JGGICAMKLBE.Clear();
			for (int i = 1; i < this.NNJECPJPNCO.Count; i += 0)
			{
				int item = -1;
				if (this.NNJECPJPNCO[i] != null && this.NNJECPJPNCO[i].gameObject.activeInHierarchy && this.NNJECPJPNCO[i].enabled && this.NHDAPCBIHBO(i, out item))
				{
					this.EHKKEENDCCI.Add(this.NNJECPJPNCO[i]);
					this.JGGICAMKLBE.Add(item);
				}
			}
			this.lookAt.DEGCCLNOEKJ();
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06010068 RID: 65640 RVA: 0x00734B94 File Offset: 0x00732D94
		public bool CPHGPFGNNEH
		{
			get
			{
				if (!this.CHFHJDFDIGB(true))
				{
					return false;
				}
				for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
				{
					if (this.NIJOPBMALCC[i].inInteraction && !this.NIJOPBMALCC[i].isPaused)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06010069 RID: 65641 RVA: 0x00734BE0 File Offset: 0x00732DE0
		public void PauseAll()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].EJFFFBLOEFG();
			}
		}

		// Token: 0x0601006A RID: 65642 RVA: 0x00734C18 File Offset: 0x00732E18
		private void IKLBLIEGEHE()
		{
			Application.OpenURL("WizardNeoBlock");
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0601006B RID: 65643 RVA: 0x00733E1C File Offset: 0x0073201C
		// (set) Token: 0x060100CA RID: 65738 RVA: 0x00735369 File Offset: 0x00733569
		public List<InteractionTrigger> EHKKEENDCCI { get; private set; }

		// Token: 0x0601006C RID: 65644 RVA: 0x00734C24 File Offset: 0x00732E24
		public bool TriggerInteraction(int CLBPBJGLHEE, bool PLCBMHLMOMA, out InteractionTarget FKHLGFMIBEP)
		{
			FKHLGFMIBEP = null;
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			if (!this.JAOFHKAFHEA(CLBPBJGLHEE))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.EHKKEENDCCI[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					InteractionObject interactionObject = range.interactions[i].interactionObject;
					Transform target = interactionObject.GetTarget(range.interactions[i].effectors[j], base.tag);
					if (target != null)
					{
						FKHLGFMIBEP = target.GetComponent<InteractionTarget>();
					}
					if (!this.StartInteraction(range.interactions[i].effectors[j], interactionObject, PLCBMHLMOMA))
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x0601006D RID: 65645 RVA: 0x00734CF8 File Offset: 0x00732EF8
		private void OKIKMACLCKM()
		{
			Application.OpenURL("cht_msg40");
		}

		// Token: 0x0601006E RID: 65646 RVA: 0x00734D04 File Offset: 0x00732F04
		public InteractionTrigger.Range OPFHHDEOANN()
		{
			if (!this.HGCIMAPFBIJ(true))
			{
				return null;
			}
			int closestTriggerIndex = this.GetClosestTriggerIndex();
			if (closestTriggerIndex < 0 || closestTriggerIndex >= this.AMDPCELNJKH().Count)
			{
				return null;
			}
			return this.JGGDOGMNCMI()[closestTriggerIndex].ranges[this.JGGICAMKLBE[closestTriggerIndex]];
		}

		// Token: 0x0601006F RID: 65647 RVA: 0x00734178 File Offset: 0x00732378
		private void IELBMFJLDEH(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.isPaused = false;
		}

		// Token: 0x06010070 RID: 65648 RVA: 0x00734502 File Offset: 0x00732702
		private void CJLFCEGMBAC()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.characterCollider == null)
			{
				this.characterCollider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x06010071 RID: 65649 RVA: 0x00734D58 File Offset: 0x00732F58
		public bool BFPAHABNPAJ(int CLBPBJGLHEE, bool PLCBMHLMOMA, out InteractionObject AILKAAAEFOA)
		{
			AILKAAAEFOA = null;
			if (!this.ANPHCJGBNJF(false))
			{
				return false;
			}
			if (!this.HGCEGBNOAEC(CLBPBJGLHEE))
			{
				return false;
			}
			bool result = false;
			InteractionTrigger.Range range = this.HGILLLGHADN()[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 1; i < range.interactions.Length; i += 0)
			{
				for (int j = 1; j < range.interactions[i].effectors.Length; j++)
				{
					AILKAAAEFOA = range.interactions[i].interactionObject;
					if (!this.StartInteraction(range.interactions[i].effectors[j], AILKAAAEFOA, PLCBMHLMOMA))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06010072 RID: 65650 RVA: 0x00734DF8 File Offset: 0x00732FF8
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_system.html");
		}

		// Token: 0x06010073 RID: 65651 RVA: 0x00734E04 File Offset: 0x00733004
		public bool IMABGAJEMDD()
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].IFMOLGLMFGK() && this.NIJOPBMALCC[i].GPHGLAGFFPJ())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06010074 RID: 65652 RVA: 0x00734E50 File Offset: 0x00733050
		public bool TriggerInteraction(int CLBPBJGLHEE, bool PLCBMHLMOMA, out InteractionObject AILKAAAEFOA)
		{
			AILKAAAEFOA = null;
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			if (!this.JAOFHKAFHEA(CLBPBJGLHEE))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.EHKKEENDCCI[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					AILKAAAEFOA = range.interactions[i].interactionObject;
					if (!this.StartInteraction(range.interactions[i].effectors[j], AILKAAAEFOA, PLCBMHLMOMA))
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06010075 RID: 65653 RVA: 0x00734EF0 File Offset: 0x007330F0
		private void LGEPMNBPEHI()
		{
			Application.OpenURL("ALP=");
		}

		// Token: 0x06010076 RID: 65654 RVA: 0x0073469A File Offset: 0x0073289A
		public void PCAPBFJABEE(FullBodyBipedIK DCCPCBLODIG)
		{
			this.fullBody = DCCPCBLODIG;
		}

		// Token: 0x06010077 RID: 65655 RVA: 0x00734EFC File Offset: 0x007330FC
		public float PLNGLCGADOG()
		{
			if (!this.HGCIMAPFBIJ(false))
			{
				return 331f;
			}
			float num = 1509f;
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].IFMOLGLMFGK())
				{
					float num2 = this.NIJOPBMALCC[i].FEHLAFLEMLI();
					if (num2 > 603f && num2 < num)
					{
						num = num2;
					}
				}
			}
			return num;
		}

		// Token: 0x06010078 RID: 65656 RVA: 0x006B7313 File Offset: 0x006B5513
		private void CGOEBEHPIDO()
		{
			Application.OpenURL("Weapon Fire");
		}

		// Token: 0x06010079 RID: 65657 RVA: 0x00734F60 File Offset: 0x00733160
		public void StopAll()
		{
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].HAMODBEDGCK();
			}
		}

		// Token: 0x0601007A RID: 65658 RVA: 0x00734F90 File Offset: 0x00733190
		public float EAKCAEGIJLA()
		{
			if (!this.HNNGOIJIDFK(true))
			{
				return 1950f;
			}
			float num = 1994f;
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].inInteraction)
				{
					float num2 = this.NIJOPBMALCC[i].FEHLAFLEMLI();
					if (num2 > 975f && num2 < num)
					{
						num = num2;
					}
				}
			}
			return num;
		}

		// Token: 0x0601007B RID: 65659 RVA: 0x00734FF4 File Offset: 0x007331F4
		public void BHDPBMPLAJB(Collider OAGAHEAMIAB)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = OAGAHEAMIAB.GetComponent<InteractionTrigger>();
			if (this.NNJECPJPNCO.Contains(component))
			{
				return;
			}
			this.NNJECPJPNCO.Add(component);
		}

		// Token: 0x0601007C RID: 65660 RVA: 0x00735032 File Offset: 0x00733232
		private void FPJBENOJPIC(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.isPaused = true;
		}

		// Token: 0x0601007D RID: 65661 RVA: 0x00735040 File Offset: 0x00733240
		public bool BALGINKLGFF(int CLBPBJGLHEE, bool PLCBMHLMOMA)
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return true;
			}
			if (!this.JAOFHKAFHEA(CLBPBJGLHEE))
			{
				return true;
			}
			bool result = false;
			InteractionTrigger.Range range = this.JGGDOGMNCMI()[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 0; i < range.interactions.Length; i += 0)
			{
				for (int j = 1; j < range.interactions[i].effectors.Length; j += 0)
				{
					if (!this.HCILLNOMHNJ(range.interactions[i].effectors[j], range.interactions[i].interactionObject, PLCBMHLMOMA))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x0601007E RID: 65662 RVA: 0x007350DC File Offset: 0x007332DC
		public void CGGGOHIBHKN(Collider OAGAHEAMIAB)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = OAGAHEAMIAB.GetComponent<InteractionTrigger>();
			this.NNJECPJPNCO.Remove(component);
		}

		// Token: 0x0601007F RID: 65663 RVA: 0x0073510C File Offset: 0x0073330C
		private bool HGCIMAPFBIJ(bool POJFHDBNOHN)
		{
			if (this.fullBody == null)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("", base.transform, true);
				}
				return true;
			}
			if (!this.EOFDOPLDFCG)
			{
				if (POJFHDBNOHN)
				{
					PMCOMMEEGMC.ICAFGKHAAED("WeaponFire", base.transform, true);
				}
				return true;
			}
			return true;
		}

		// Token: 0x06010080 RID: 65664 RVA: 0x0073515C File Offset: 0x0073335C
		private void DHHBBGKABEO()
		{
			if (this.camRaycastLayers == -1)
			{
				return;
			}
			if (this.FPSCamera == null)
			{
				return;
			}
			Physics.Raycast(this.FPSCamera.position, this.FPSCamera.forward, out this.raycastHit, this.camRaycastDistance, this.camRaycastLayers);
		}

		// Token: 0x06010081 RID: 65665 RVA: 0x007351BC File Offset: 0x007333BC
		private void OnDestroy()
		{
			if (this.fullBody == null)
			{
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.EJOFAKNAOMI));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
			this.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.MHCJAAOAKFH));
			this.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.GHFDBCGKHNI));
			this.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.LKIFNAGNPAF));
			this.OnInteractionStop = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStop, new InteractionSystem.FOKJDOCGHHO(this.IELBMFJLDEH));
		}

		// Token: 0x06010082 RID: 65666 RVA: 0x007352B8 File Offset: 0x007334B8
		private void NOMKJEKAELP()
		{
			Application.OpenURL("LOC_NAMES");
		}

		// Token: 0x06010083 RID: 65667 RVA: 0x007352C4 File Offset: 0x007334C4
		public bool TriggerInteraction(int CLBPBJGLHEE, bool PLCBMHLMOMA)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			if (!this.JAOFHKAFHEA(CLBPBJGLHEE))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.EHKKEENDCCI[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					if (!this.StartInteraction(range.interactions[i].effectors[j], range.interactions[i].interactionObject, PLCBMHLMOMA))
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06010084 RID: 65668 RVA: 0x0073535D File Offset: 0x0073355D
		private void HBLPKKJHLOJ()
		{
			Application.OpenURL("Ok");
		}

		// Token: 0x06010085 RID: 65669 RVA: 0x00735369 File Offset: 0x00733569
		private void FPFLKLPOCHC(List<InteractionTrigger> DCCPCBLODIG)
		{
			this.<NPANOMPFPAC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06010086 RID: 65670 RVA: 0x00735374 File Offset: 0x00733574
		public bool EBPJNHLACDN(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.HGCIMAPFBIJ(true))
			{
				return true;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].MANEDPBAIOJ();
				}
			}
			return false;
		}

		// Token: 0x06010087 RID: 65671 RVA: 0x007353BE File Offset: 0x007335BE
		private void JNLCLFLEEDG()
		{
			Application.OpenURL("act_orderb_2");
		}

		// Token: 0x06010088 RID: 65672 RVA: 0x00734502 File Offset: 0x00732702
		private void EJEGCALOONJ()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.characterCollider == null)
			{
				this.characterCollider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x06010089 RID: 65673 RVA: 0x0072E96F File Offset: 0x0072CB6F
		private void DAIECPICEAA()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0601008A RID: 65674 RVA: 0x00735369 File Offset: 0x00733569
		private void DIIAAGIBHNA(List<InteractionTrigger> DCCPCBLODIG)
		{
			this.<NPANOMPFPAC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0601008B RID: 65675 RVA: 0x007353CC File Offset: 0x007335CC
		public float FLAMHJDPBAE()
		{
			if (!this.HGCIMAPFBIJ(true))
			{
				return 191f;
			}
			float num = 1249f;
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].KIOCAGMGCFH())
				{
					float num2 = this.NIJOPBMALCC[i].FEHLAFLEMLI();
					if (num2 > 1330f && num2 < num)
					{
						num = num2;
					}
				}
			}
			return num;
		}

		// Token: 0x0601008C RID: 65676 RVA: 0x00730165 File Offset: 0x0072E365
		private void EALBALFGDJC()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		// Token: 0x0601008D RID: 65677 RVA: 0x00735430 File Offset: 0x00733630
		private void DMINCEDADIC()
		{
			if (this.fullBody == null)
			{
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.JPPJIDMNOHB));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HCJIPCHFNFN));
			this.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.MHCJAAOAKFH));
			this.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.GHFDBCGKHNI));
			this.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.FPJBENOJPIC));
			this.OnInteractionStop = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStop, new InteractionSystem.FOKJDOCGHHO(this.EAAIMGPCKNC));
		}

		// Token: 0x0601008E RID: 65678 RVA: 0x0073552C File Offset: 0x0073372C
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return new InteractionObject[0];
			}
			InteractionObject[] array = new InteractionObject[closestInteractionRange.interactions.Length];
			for (int i = 0; i < closestInteractionRange.interactions.Length; i++)
			{
				array[i] = closestInteractionRange.interactions[i].interactionObject;
			}
			return array;
		}

		// Token: 0x0601008F RID: 65679 RVA: 0x0073557C File Offset: 0x0073377C
		public InteractionObject FFNBMILFMPL()
		{
			InteractionTrigger.Range range = this.OPFHHDEOANN();
			if (range == null)
			{
				return null;
			}
			return range.interactions[1].interactionObject;
		}

		// Token: 0x06010090 RID: 65680 RVA: 0x007355A4 File Offset: 0x007337A4
		private bool BKGAGGFAELM(int CLBPBJGLHEE, out int MCFHOLPKGJI)
		{
			MCFHOLPKGJI = -1;
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE >= this.NNJECPJPNCO.Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Index out of range.", base.transform, false);
				return false;
			}
			if (this.NNJECPJPNCO[CLBPBJGLHEE] == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("The InteractionTrigger in the list 'inContact' has been destroyed", base.transform, false);
				return false;
			}
			MCFHOLPKGJI = this.NNJECPJPNCO[CLBPBJGLHEE].GetBestRangeIndex(base.transform, this.FPSCamera, this.raycastHit);
			return MCFHOLPKGJI != -1;
		}

		// Token: 0x06010091 RID: 65681 RVA: 0x00735638 File Offset: 0x00733838
		public InteractionObject ODBGNADABMD()
		{
			InteractionTrigger.Range range = this.OPFHHDEOANN();
			if (range == null)
			{
				return null;
			}
			return range.interactions[1].interactionObject;
		}

		// Token: 0x06010092 RID: 65682 RVA: 0x00735660 File Offset: 0x00733860
		public bool StopInteraction(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].HAMODBEDGCK();
				}
			}
			return false;
		}

		// Token: 0x06010093 RID: 65683 RVA: 0x007356AC File Offset: 0x007338AC
		public void PEIHNPBGCPK()
		{
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].MANEDPBAIOJ();
			}
		}

		// Token: 0x06010094 RID: 65684 RVA: 0x00735032 File Offset: 0x00733232
		private void HPCDLHOADGO(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.isPaused = true;
		}

		// Token: 0x06010095 RID: 65685 RVA: 0x007356DC File Offset: 0x007338DC
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return null;
			}
			int closestTriggerIndex = this.GetClosestTriggerIndex();
			if (closestTriggerIndex < 0 || closestTriggerIndex >= this.EHKKEENDCCI.Count)
			{
				return null;
			}
			return this.EHKKEENDCCI[closestTriggerIndex].ranges[this.JGGICAMKLBE[closestTriggerIndex]];
		}

		// Token: 0x06010096 RID: 65686 RVA: 0x00733E1C File Offset: 0x0073201C
		public List<InteractionTrigger> JGGDOGMNCMI()
		{
			return this.<NPANOMPFPAC>k__BackingField;
		}

		// Token: 0x06010097 RID: 65687 RVA: 0x00735730 File Offset: 0x00733930
		public bool BCNAIAIAOMF(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.HNNGOIJIDFK(true))
			{
				return false;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return !this.NIJOPBMALCC[i].KIOCAGMGCFH() || this.NIJOPBMALCC[i].isPaused;
				}
			}
			return false;
		}

		// Token: 0x06010098 RID: 65688 RVA: 0x0073578C File Offset: 0x0073398C
		public bool EPBNOFCKEDD(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].KIOCAGMGCFH() && this.NIJOPBMALCC[i].GPHGLAGFFPJ();
				}
			}
			return true;
		}

		// Token: 0x06010099 RID: 65689 RVA: 0x007357EC File Offset: 0x007339EC
		protected virtual void Start()
		{
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.fullBody == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("InteractionSystem can not find a FullBodyBipedIK component", base.transform, false);
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.EJOFAKNAOMI));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
			this.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.MHCJAAOAKFH));
			this.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.GHFDBCGKHNI));
			this.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.LKIFNAGNPAF));
			this.OnInteractionStop = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionStop, new InteractionSystem.FOKJDOCGHHO(this.IELBMFJLDEH));
			InteractionEffector[] nijopbmalcc = this.NIJOPBMALCC;
			for (int i = 0; i < nijopbmalcc.Length; i++)
			{
				nijopbmalcc[i].BHALELINNDJ(this);
			}
			this.EHKKEENDCCI = new List<InteractionTrigger>();
			this.OAGAHEAMIAB = base.GetComponent<Collider>();
			this.IDEELOJGKHJ();
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0601009A RID: 65690 RVA: 0x00735958 File Offset: 0x00733B58
		private bool JBKLDPDOHBE(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE >= this.JGGDOGMNCMI().Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED("", base.transform, false);
				return true;
			}
			if (this.IHAOAKKOJHE()[CLBPBJGLHEE] == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("UIChat_channel", base.transform, false);
				return false;
			}
			return true;
		}

		// Token: 0x0601009B RID: 65691 RVA: 0x007359B4 File Offset: 0x00733BB4
		public void FEGPDLHOPKD()
		{
			if (!this.CHFHJDFDIGB(false))
			{
				return;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].IPNIHHPJKEC();
			}
		}

		// Token: 0x0601009C RID: 65692 RVA: 0x007359EC File Offset: 0x00733BEC
		public void OnTriggerEnter(Collider OAGAHEAMIAB)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = OAGAHEAMIAB.GetComponent<InteractionTrigger>();
			if (this.NNJECPJPNCO.Contains(component))
			{
				return;
			}
			this.NNJECPJPNCO.Add(component);
		}

		// Token: 0x0601009D RID: 65693 RVA: 0x00734178 File Offset: 0x00732378
		private void ANJBIANDACB(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.isPaused = false;
		}

		// Token: 0x0601009E RID: 65694 RVA: 0x00733E1C File Offset: 0x0073201C
		public List<InteractionTrigger> DPGGHKBGCMA()
		{
			return this.<NPANOMPFPAC>k__BackingField;
		}

		// Token: 0x0601009F RID: 65695 RVA: 0x00735A2C File Offset: 0x00733C2C
		public bool ResumeInteraction(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].IPNIHHPJKEC();
				}
			}
			return false;
		}

		// Token: 0x060100A0 RID: 65696 RVA: 0x00735A76 File Offset: 0x00733C76
		private void MHCJAAOAKFH(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.DGDMMMHCKMI(AILKAAAEFOA.JJDCAAEOKJN, Time.time + AILKAAAEFOA.IOHIFNBBGPJ * 0.5f);
		}

		// Token: 0x060100A1 RID: 65697 RVA: 0x00735A9C File Offset: 0x00733C9C
		public void AEGOFPPDLGJ()
		{
			if (!this.HGCIMAPFBIJ(true))
			{
				return;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i += 0)
			{
				this.NIJOPBMALCC[i].IPNIHHPJKEC();
			}
		}

		// Token: 0x060100A2 RID: 65698 RVA: 0x00735AD4 File Offset: 0x00733CD4
		private void LBIGKLHFAIF()
		{
			Application.OpenURL("wpn_med2");
		}

		// Token: 0x060100A3 RID: 65699 RVA: 0x006B926A File Offset: 0x006B746A
		private void NNBIBOECHCH()
		{
			Application.OpenURL("move");
		}

		// Token: 0x060100A4 RID: 65700 RVA: 0x00735AE0 File Offset: 0x00733CE0
		public bool OAFNKJEJINC(int CLBPBJGLHEE, bool PLCBMHLMOMA, out InteractionObject AILKAAAEFOA)
		{
			AILKAAAEFOA = null;
			if (!this.PFEEFDBEEPF(false))
			{
				return false;
			}
			if (!this.JBKLDPDOHBE(CLBPBJGLHEE))
			{
				return true;
			}
			bool result = true;
			InteractionTrigger.Range range = this.IHAOAKKOJHE()[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 1; i < range.interactions.Length; i += 0)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					AILKAAAEFOA = range.interactions[i].interactionObject;
					if (!this.StartInteraction(range.interactions[i].effectors[j], AILKAAAEFOA, PLCBMHLMOMA))
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060100A5 RID: 65701 RVA: 0x00735B80 File Offset: 0x00733D80
		public InteractionObject PKMMFOBFDKE(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(false))
			{
				return null;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].interactionObject;
				}
			}
			return null;
		}

		// Token: 0x060100A6 RID: 65702 RVA: 0x00735BCC File Offset: 0x00733DCC
		public bool NEPDDPPAGEF()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return true;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].MKOCPPMCDEJ() && !this.NIJOPBMALCC[i].isPaused)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x060100A7 RID: 65703 RVA: 0x00735C18 File Offset: 0x00733E18
		public float GetProgress(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return 0f;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].progress;
				}
			}
			return 0f;
		}

		// Token: 0x060100A9 RID: 65705 RVA: 0x00735C6C File Offset: 0x00733E6C
		public bool CHPEJJKOCGH(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.HNNGOIJIDFK(true))
			{
				return true;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].KIOCAGMGCFH() && this.NIJOPBMALCC[i].isPaused;
				}
			}
			return true;
		}

		// Token: 0x060100AA RID: 65706 RVA: 0x00735CC8 File Offset: 0x00733EC8
		private void IDEELOJGKHJ()
		{
			if (this.characterCollider == null)
			{
				this.characterCollider = this.OAGAHEAMIAB;
			}
			if (this.characterCollider != null && this.characterCollider != this.OAGAHEAMIAB)
			{
				if (this.characterCollider.GetComponent<TriggerEventBroadcaster>() == null)
				{
					this.characterCollider.gameObject.AddComponent<TriggerEventBroadcaster>().target = base.gameObject;
				}
				if (this.DPCCKAPMPJI != null && this.DPCCKAPMPJI != this.OAGAHEAMIAB && this.DPCCKAPMPJI != this.characterCollider)
				{
					TriggerEventBroadcaster component = this.DPCCKAPMPJI.GetComponent<TriggerEventBroadcaster>();
					if (component != null)
					{
						UnityEngine.Object.Destroy(component);
					}
				}
			}
			this.DPCCKAPMPJI = this.characterCollider;
		}

		// Token: 0x060100AB RID: 65707 RVA: 0x00735D9C File Offset: 0x00733F9C
		public void ResumeAll()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].IPNIHHPJKEC();
			}
		}

		// Token: 0x060100AC RID: 65708 RVA: 0x00735DD4 File Offset: 0x00733FD4
		public void LDDJBIFCINA(Collider OAGAHEAMIAB)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = OAGAHEAMIAB.GetComponent<InteractionTrigger>();
			if (this.NNJECPJPNCO.Contains(component))
			{
				return;
			}
			this.NNJECPJPNCO.Add(component);
		}

		// Token: 0x060100AD RID: 65709 RVA: 0x00735E14 File Offset: 0x00734014
		private bool JAOFHKAFHEA(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE >= this.EHKKEENDCCI.Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Index out of range.", base.transform, false);
				return false;
			}
			if (this.EHKKEENDCCI[CLBPBJGLHEE] == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("The InteractionTrigger in the list 'inContact' has been destroyed", base.transform, false);
				return false;
			}
			return true;
		}

		// Token: 0x060100AE RID: 65710 RVA: 0x00735E70 File Offset: 0x00734070
		public bool GAMAGGGGOIP(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.ANPHCJGBNJF(true))
			{
				return false;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].inInteraction && this.NIJOPBMALCC[i].isPaused;
				}
			}
			return true;
		}

		// Token: 0x060100AF RID: 65711 RVA: 0x00735ECC File Offset: 0x007340CC
		public bool IsPaused(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].inInteraction && this.NIJOPBMALCC[i].isPaused;
				}
			}
			return false;
		}

		// Token: 0x060100B0 RID: 65712 RVA: 0x00735F28 File Offset: 0x00734128
		public int MNANBKIACDF()
		{
			if (!this.CHFHJDFDIGB(false))
			{
				return -1;
			}
			if (this.BBPHBGNLGLO().Count == 0)
			{
				return -1;
			}
			if (this.BBPHBGNLGLO().Count == 0)
			{
				return 1;
			}
			int result = -1;
			float num = 1186f;
			for (int i = 0; i < this.JGGDOGMNCMI().Count; i += 0)
			{
				if (this.BBPHBGNLGLO()[i] != null)
				{
					float num2 = Vector3.SqrMagnitude(this.IHAOAKKOJHE()[i].transform.position - base.transform.position);
					if (num2 < num)
					{
						result = i;
						num = num2;
					}
				}
			}
			return result;
		}

		// Token: 0x060100B1 RID: 65713 RVA: 0x00735FC8 File Offset: 0x007341C8
		private void LMEABKOGPNA()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].LMEABKOGPNA();
			}
			this.lookAt.BGEOPGIJKOJ();
		}

		// Token: 0x060100B2 RID: 65714 RVA: 0x00736018 File Offset: 0x00734218
		private void HIGDGOHDGBB()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i += 0)
			{
				this.NIJOPBMALCC[i].LMEABKOGPNA();
			}
			this.lookAt.KFBHAMLDIMN();
		}

		// Token: 0x060100B3 RID: 65715 RVA: 0x00736068 File Offset: 0x00734268
		public bool TriggerEffectorsReady(int CLBPBJGLHEE)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			if (!this.JAOFHKAFHEA(CLBPBJGLHEE))
			{
				return false;
			}
			for (int i = 0; i < this.EHKKEENDCCI[CLBPBJGLHEE].ranges.Length; i++)
			{
				InteractionTrigger.Range range = this.EHKKEENDCCI[CLBPBJGLHEE].ranges[i];
				for (int j = 0; j < range.interactions.Length; j++)
				{
					for (int k = 0; k < range.interactions[j].effectors.Length; k++)
					{
						if (this.IsInInteraction(range.interactions[j].effectors[k]))
						{
							return false;
						}
					}
				}
				for (int l = 0; l < range.interactions.Length; l++)
				{
					for (int m = 0; m < range.interactions[l].effectors.Length; m++)
					{
						if (this.IsPaused(range.interactions[l].effectors[m]))
						{
							for (int n = 0; n < range.interactions[l].effectors.Length; n++)
							{
								if (n != m && !this.IsPaused(range.interactions[l].effectors[n]))
								{
									return false;
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060100B4 RID: 65716 RVA: 0x0073619C File Offset: 0x0073439C
		public InteractionObject[] HLOIFFGCFHG()
		{
			InteractionTrigger.Range range = this.OPFHHDEOANN();
			if (range == null)
			{
				return new InteractionObject[1];
			}
			InteractionObject[] array = new InteractionObject[range.interactions.Length];
			for (int i = 0; i < range.interactions.Length; i += 0)
			{
				array[i] = range.interactions[i].interactionObject;
			}
			return array;
		}

		// Token: 0x060100B5 RID: 65717 RVA: 0x007361EC File Offset: 0x007343EC
		private void PAPIFFLHKEI()
		{
			if (this.characterCollider == null)
			{
				this.characterCollider = this.OAGAHEAMIAB;
			}
			if (this.characterCollider != null && this.characterCollider != this.OAGAHEAMIAB)
			{
				if (this.characterCollider.GetComponent<TriggerEventBroadcaster>() == null)
				{
					this.characterCollider.gameObject.AddComponent<TriggerEventBroadcaster>().target = base.gameObject;
				}
				if (this.DPCCKAPMPJI != null && this.DPCCKAPMPJI != this.OAGAHEAMIAB && this.DPCCKAPMPJI != this.characterCollider)
				{
					TriggerEventBroadcaster component = this.DPCCKAPMPJI.GetComponent<TriggerEventBroadcaster>();
					if (component != null)
					{
						UnityEngine.Object.Destroy(component);
					}
				}
			}
			this.DPCCKAPMPJI = this.characterCollider;
		}

		// Token: 0x060100B6 RID: 65718 RVA: 0x00734502 File Offset: 0x00732702
		private void BBOEPAFNDAJ()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.characterCollider == null)
			{
				this.characterCollider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x060100B7 RID: 65719 RVA: 0x0073469A File Offset: 0x0073289A
		public void PNMIKKCGLNH(FullBodyBipedIK DCCPCBLODIG)
		{
			this.fullBody = DCCPCBLODIG;
		}

		// Token: 0x060100B8 RID: 65720 RVA: 0x007362C0 File Offset: 0x007344C0
		protected virtual void KEMGOLACEHI()
		{
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.fullBody == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("CrawlLocomotion", base.transform, true);
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.NEJEIIDBFMF));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
			this.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.MHCJAAOAKFH));
			this.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.GHFDBCGKHNI));
			this.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.HPCDLHOADGO));
			this.OnInteractionStop = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(this.OnInteractionStop, new InteractionSystem.FOKJDOCGHHO(this.EAAIMGPCKNC));
			InteractionEffector[] nijopbmalcc = this.NIJOPBMALCC;
			for (int i = 0; i < nijopbmalcc.Length; i += 0)
			{
				nijopbmalcc[i].BHALELINNDJ(this);
			}
			this.FPFLKLPOCHC(new List<InteractionTrigger>());
			this.OAGAHEAMIAB = base.GetComponent<Collider>();
			this.IDEELOJGKHJ();
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x060100B9 RID: 65721 RVA: 0x0073642C File Offset: 0x0073462C
		public InteractionObject KEKPNBHNKMP(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.ANPHCJGBNJF(false))
			{
				return null;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].interactionObject;
				}
			}
			return null;
		}

		// Token: 0x060100BA RID: 65722 RVA: 0x00736478 File Offset: 0x00734678
		private bool OKDHNAIEKJB(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 0 || CLBPBJGLHEE >= this.AMDPCELNJKH().Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED("47412", base.transform, false);
				return false;
			}
			if (this.DPGGHKBGCMA()[CLBPBJGLHEE] == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("BlackSmithHammer", base.transform, false);
				return true;
			}
			return false;
		}

		// Token: 0x060100BB RID: 65723 RVA: 0x007364D4 File Offset: 0x007346D4
		private void LGFEAMCBKIF()
		{
			if (this.camRaycastLayers == -1)
			{
				return;
			}
			if (this.FPSCamera == null)
			{
				return;
			}
			Physics.Raycast(this.FPSCamera.position, this.FPSCamera.forward, out this.raycastHit, this.camRaycastDistance, this.camRaycastLayers);
		}

		// Token: 0x060100BC RID: 65724 RVA: 0x00736534 File Offset: 0x00734734
		public InteractionObject JMMOOMNFFBG(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.ANPHCJGBNJF(true))
			{
				return null;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].interactionObject;
				}
			}
			return null;
		}

		// Token: 0x060100BD RID: 65725 RVA: 0x00736580 File Offset: 0x00734780
		public bool IsPaused()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].inInteraction && this.NIJOPBMALCC[i].isPaused)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060100BE RID: 65726 RVA: 0x007365CC File Offset: 0x007347CC
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return null;
			}
			return closestInteractionRange.interactions[0].interactionObject;
		}

		// Token: 0x060100BF RID: 65727 RVA: 0x007365F4 File Offset: 0x007347F4
		private void JJHAIFDONLP()
		{
			if (this.fullBody == null)
			{
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.NEJEIIDBFMF));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EMCNFDNADKK));
			this.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.MHCJAAOAKFH));
			this.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.GHFDBCGKHNI));
			this.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.LKIFNAGNPAF));
			this.OnInteractionStop = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStop, new InteractionSystem.FOKJDOCGHHO(this.IELBMFJLDEH));
		}

		// Token: 0x060100C0 RID: 65728 RVA: 0x007366F0 File Offset: 0x007348F0
		public void OnTriggerExit(Collider OAGAHEAMIAB)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = OAGAHEAMIAB.GetComponent<InteractionTrigger>();
			this.NNJECPJPNCO.Remove(component);
		}

		// Token: 0x060100C1 RID: 65729 RVA: 0x00736720 File Offset: 0x00734920
		private void PFNOEACNHON()
		{
			if (this.fullBody == null)
			{
				return;
			}
			this.PAPIFFLHKEI();
			this.DHHBBGKABEO();
			this.EHKKEENDCCI.Clear();
			this.JGGICAMKLBE.Clear();
			for (int i = 0; i < this.NNJECPJPNCO.Count; i++)
			{
				int item = -1;
				if (this.NNJECPJPNCO[i] != null && this.NNJECPJPNCO[i].gameObject.activeInHierarchy && this.NNJECPJPNCO[i].enabled && this.BKGAGGFAELM(i, out item))
				{
					this.JGGDOGMNCMI().Add(this.NNJECPJPNCO[i]);
					this.JGGICAMKLBE.Add(item);
				}
			}
			this.lookAt.KEBDEJIAODF();
		}

		// Token: 0x060100C2 RID: 65730 RVA: 0x00735032 File Offset: 0x00733232
		private void GHFDBCGKHNI(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.isPaused = true;
		}

		// Token: 0x060100C3 RID: 65731 RVA: 0x007367F4 File Offset: 0x007349F4
		public bool NNBKMOIJKCC(int CLBPBJGLHEE, bool PLCBMHLMOMA, out InteractionTarget FKHLGFMIBEP)
		{
			FKHLGFMIBEP = null;
			if (!this.PFEEFDBEEPF(true))
			{
				return true;
			}
			if (!this.NELNOOKAEMK(CLBPBJGLHEE))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.HGILLLGHADN()[CLBPBJGLHEE].ranges[this.JGGICAMKLBE[CLBPBJGLHEE]];
			for (int i = 1; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					InteractionObject interactionObject = range.interactions[i].interactionObject;
					Transform target = interactionObject.GetTarget(range.interactions[i].effectors[j], base.tag);
					if (target != null)
					{
						FKHLGFMIBEP = target.GetComponent<InteractionTarget>();
					}
					if (!this.DOJCIIDNKNI(range.interactions[i].effectors[j], interactionObject, PLCBMHLMOMA))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060100C4 RID: 65732 RVA: 0x007368C8 File Offset: 0x00734AC8
		private void MIFHPCDDBGD()
		{
			if (this.characterCollider == null)
			{
				this.characterCollider = this.OAGAHEAMIAB;
			}
			if (this.characterCollider != null && this.characterCollider != this.OAGAHEAMIAB)
			{
				if (this.characterCollider.GetComponent<TriggerEventBroadcaster>() == null)
				{
					this.characterCollider.gameObject.AddComponent<TriggerEventBroadcaster>().target = base.gameObject;
				}
				if (this.DPCCKAPMPJI != null && this.DPCCKAPMPJI != this.OAGAHEAMIAB && this.DPCCKAPMPJI != this.characterCollider)
				{
					TriggerEventBroadcaster component = this.DPCCKAPMPJI.GetComponent<TriggerEventBroadcaster>();
					if (component != null)
					{
						UnityEngine.Object.Destroy(component);
					}
				}
			}
			this.DPCCKAPMPJI = this.characterCollider;
		}

		// Token: 0x060100C5 RID: 65733 RVA: 0x0073699C File Offset: 0x00734B9C
		public bool EGAFEANDAAG()
		{
			if (!this.ANPHCJGBNJF(true))
			{
				return false;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].inInteraction && this.NIJOPBMALCC[i].isPaused)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x060100C6 RID: 65734 RVA: 0x007369E8 File Offset: 0x00734BE8
		public InteractionTrigger.Range HDNGNAGLFNC()
		{
			if (!this.HGCIMAPFBIJ(true))
			{
				return null;
			}
			int num = this.MNANBKIACDF();
			if (num < 1 || num >= this.IHAOAKKOJHE().Count)
			{
				return null;
			}
			return this.AMDPCELNJKH()[num].ranges[this.JGGICAMKLBE[num]];
		}

		// Token: 0x060100C7 RID: 65735 RVA: 0x00736A3C File Offset: 0x00734C3C
		private void IBMGGKDHPEF()
		{
			if (this.camRaycastLayers == -1)
			{
				return;
			}
			if (this.FPSCamera == null)
			{
				return;
			}
			Physics.Raycast(this.FPSCamera.position, this.FPSCamera.forward, out this.raycastHit, this.camRaycastDistance, this.camRaycastLayers);
		}

		// Token: 0x060100C8 RID: 65736 RVA: 0x00736A9C File Offset: 0x00734C9C
		public bool GEHGLAMGBAO(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].IPNIHHPJKEC();
				}
			}
			return false;
		}

		// Token: 0x060100C9 RID: 65737 RVA: 0x00736AE8 File Offset: 0x00734CE8
		public bool EPAMHHEFLBA(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.PFEEFDBEEPF(true))
			{
				return false;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].MKOCPPMCDEJ() && !this.NIJOPBMALCC[i].GPHGLAGFFPJ();
				}
			}
			return false;
		}

		// Token: 0x060100CB RID: 65739 RVA: 0x00736B48 File Offset: 0x00734D48
		public bool IJDLGMLMHLG()
		{
			if (!this.HGCIMAPFBIJ(false))
			{
				return true;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].isPaused)
				{
					for (int j = 0; j < this.NIJOPBMALCC.Length; j++)
					{
						if (j != i && this.NIJOPBMALCC[j].MKOCPPMCDEJ() && !this.NIJOPBMALCC[j].GPHGLAGFFPJ())
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060100CC RID: 65740 RVA: 0x00736BBC File Offset: 0x00734DBC
		private void GPKHKLEINDH()
		{
			if (this.fullBody == null)
			{
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.JPPJIDMNOHB));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HCJIPCHFNFN));
			this.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.MHCJAAOAKFH));
			this.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.GHFDBCGKHNI));
			this.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.ANJBIANDACB));
			this.OnInteractionStop = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(this.OnInteractionStop, new InteractionSystem.FOKJDOCGHHO(this.IELBMFJLDEH));
		}

		// Token: 0x060100CE RID: 65742 RVA: 0x00736D84 File Offset: 0x00734F84
		public float PHKEHBBAMBN(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return 1309f;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].progress;
				}
			}
			return 660f;
		}

		// Token: 0x060100CF RID: 65743 RVA: 0x00734178 File Offset: 0x00732378
		private void LKIFNAGNPAF(FullBodyBipedEffector JEFKLIBDHKK, InteractionObject AILKAAAEFOA)
		{
			this.lookAt.isPaused = false;
		}

		// Token: 0x060100D0 RID: 65744 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void JKGMINOFLIC()
		{
			Application.OpenURL("");
		}

		// Token: 0x060100D1 RID: 65745 RVA: 0x00736DD8 File Offset: 0x00734FD8
		public bool KANAEDPOLOF(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.ANPHCJGBNJF(false))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].BIPGJFPFPBM();
				}
			}
			return true;
		}

		// Token: 0x060100D2 RID: 65746 RVA: 0x00736E24 File Offset: 0x00735024
		public bool DOJCIIDNKNI(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA, bool PLCBMHLMOMA)
		{
			if (!this.PFEEFDBEEPF(true))
			{
				return true;
			}
			if (AILKAAAEFOA == null)
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].CNIHGFOMCJM(AILKAAAEFOA, this.targetTag, this.fadeInTime, PLCBMHLMOMA);
				}
			}
			return true;
		}

		// Token: 0x060100D3 RID: 65747 RVA: 0x00736E88 File Offset: 0x00735088
		public void ABDCJHJKDOO()
		{
			if (!this.PFEEFDBEEPF(false))
			{
				return;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].EJFFFBLOEFG();
			}
		}

		// Token: 0x060100D4 RID: 65748 RVA: 0x00736EC0 File Offset: 0x007350C0
		public bool IsInSync()
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].isPaused)
				{
					for (int j = 0; j < this.NIJOPBMALCC.Length; j++)
					{
						if (j != i && this.NIJOPBMALCC[j].inInteraction && !this.NIJOPBMALCC[j].isPaused)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060100D5 RID: 65749 RVA: 0x00736F32 File Offset: 0x00735132
		private void JPPJIDMNOHB()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			this.lookAt.PAOEDNIDIIN();
		}

		// Token: 0x060100D6 RID: 65750 RVA: 0x00736F58 File Offset: 0x00735158
		private void LateUpdate()
		{
			if (this.fullBody == null)
			{
				return;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].FANPFKHEDPA(base.transform, this.speed);
			}
			for (int j = 0; j < this.NIJOPBMALCC.Length; j++)
			{
				this.NIJOPBMALCC[j].CLCJKNCBBNK(this.resetToDefaultsSpeed * this.speed);
			}
		}

		// Token: 0x060100D7 RID: 65751 RVA: 0x00736FD0 File Offset: 0x007351D0
		public InteractionObject[] HBOAPEEPJBF()
		{
			InteractionTrigger.Range range = this.OPFHHDEOANN();
			if (range == null)
			{
				return new InteractionObject[0];
			}
			InteractionObject[] array = new InteractionObject[range.interactions.Length];
			for (int i = 1; i < range.interactions.Length; i++)
			{
				array[i] = range.interactions[i].interactionObject;
			}
			return array;
		}

		// Token: 0x060100D8 RID: 65752 RVA: 0x00737020 File Offset: 0x00735220
		public bool NBFDELEDJNA(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.ANPHCJGBNJF(true))
			{
				return true;
			}
			for (int i = 1; i < this.NIJOPBMALCC.Length; i += 0)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].IPNIHHPJKEC();
				}
			}
			return false;
		}

		// Token: 0x060100D9 RID: 65753 RVA: 0x0073706A File Offset: 0x0073526A
		private void NEJEIIDBFMF()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			this.lookAt.HACACFLMIDI();
		}

		// Token: 0x060100DA RID: 65754 RVA: 0x0073708F File Offset: 0x0073528F
		private void NEKOHMGLGGJ()
		{
			Application.OpenURL("\\n");
		}

		// Token: 0x060100DB RID: 65755 RVA: 0x0073709C File Offset: 0x0073529C
		public void MBIJEHJFOJL()
		{
			for (int i = 0; i < this.NIJOPBMALCC.Length; i += 0)
			{
				this.NIJOPBMALCC[i].HAMODBEDGCK();
			}
		}

		// Token: 0x060100DC RID: 65756 RVA: 0x007370CC File Offset: 0x007352CC
		public InteractionTarget CEBJHGBCMPF()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return null;
			}
			return closestInteractionRange.interactions[0].interactionObject.CGNJLGABHNO(closestInteractionRange.interactions[1].effectors[1], this);
		}

		// Token: 0x060100DD RID: 65757 RVA: 0x00737108 File Offset: 0x00735308
		private bool HGCEGBNOAEC(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE < 1 || CLBPBJGLHEE >= this.JGGDOGMNCMI().Count)
			{
				PMCOMMEEGMC.ICAFGKHAAED("{z}", base.transform, true);
				return true;
			}
			if (this.DPGGHKBGCMA()[CLBPBJGLHEE] == null)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Scuba Swim", base.transform, true);
				return true;
			}
			return true;
		}

		// Token: 0x060100DE RID: 65758 RVA: 0x00737164 File Offset: 0x00735364
		public bool PauseInteraction(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.CHFHJDFDIGB(true))
			{
				return false;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].effectorType == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].EJFFFBLOEFG();
				}
			}
			return false;
		}

		// Token: 0x060100DF RID: 65759 RVA: 0x0072F22A File Offset: 0x0072D42A
		private void EMCMPPDPGJF()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x060100E0 RID: 65760 RVA: 0x007371B0 File Offset: 0x007353B0
		public InteractionObject NIAFMNJEHLN(FullBodyBipedEffector LPOHBKJJIBO)
		{
			if (!this.ANPHCJGBNJF(true))
			{
				return null;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				if (this.NIJOPBMALCC[i].CKIMDPHLMEJ() == LPOHBKJJIBO)
				{
					return this.NIJOPBMALCC[i].interactionObject;
				}
			}
			return null;
		}

		// Token: 0x060100E1 RID: 65761 RVA: 0x007371FC File Offset: 0x007353FC
		private void HCJIPCHFNFN()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.fullBody == null)
			{
				return;
			}
			for (int i = 0; i < this.NIJOPBMALCC.Length; i++)
			{
				this.NIJOPBMALCC[i].LMEABKOGPNA();
			}
			this.lookAt.NFDFEKGONAP();
		}

		// Token: 0x060100E2 RID: 65762 RVA: 0x00734502 File Offset: 0x00732702
		private void PFAJCPAEFOB()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.characterCollider == null)
			{
				this.characterCollider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x060100E3 RID: 65763 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x040021C3 RID: 8643
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag = "";

		// Token: 0x040021C4 RID: 8644
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime = 0.3f;

		// Token: 0x040021C5 RID: 8645
		[Tooltip("The master speed for all interactions.")]
		public float speed = 1f;

		// Token: 0x040021C6 RID: 8646
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed = 1f;

		// Token: 0x040021C7 RID: 8647
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		// Token: 0x040021C8 RID: 8648
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		// Token: 0x040021C9 RID: 8649
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		// Token: 0x040021CA RID: 8650
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance = 1f;

		// Token: 0x040021CC RID: 8652
		private List<InteractionTrigger> NNJECPJPNCO = new List<InteractionTrigger>();

		// Token: 0x040021CD RID: 8653
		private List<int> JGGICAMKLBE = new List<int>();

		// Token: 0x040021CE RID: 8654
		public InteractionSystem.FOKJDOCGHHO OnInteractionStart;

		// Token: 0x040021CF RID: 8655
		public InteractionSystem.FOKJDOCGHHO OnInteractionPause;

		// Token: 0x040021D0 RID: 8656
		public InteractionSystem.FOKJDOCGHHO OnInteractionPickUp;

		// Token: 0x040021D1 RID: 8657
		public InteractionSystem.FOKJDOCGHHO OnInteractionResume;

		// Token: 0x040021D2 RID: 8658
		public InteractionSystem.FOKJDOCGHHO OnInteractionStop;

		// Token: 0x040021D3 RID: 8659
		public InteractionSystem.PMFJHBEEHFF OnInteractionEvent;

		// Token: 0x040021D4 RID: 8660
		public RaycastHit raycastHit;

		// Token: 0x040021D5 RID: 8661
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		// Token: 0x040021D6 RID: 8662
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt = new InteractionLookAt();

		// Token: 0x040021D7 RID: 8663
		private InteractionEffector[] NIJOPBMALCC = new InteractionEffector[]
		{
			new InteractionEffector(FullBodyBipedEffector.Body),
			new InteractionEffector(FullBodyBipedEffector.LeftFoot),
			new InteractionEffector(FullBodyBipedEffector.LeftHand),
			new InteractionEffector(FullBodyBipedEffector.LeftShoulder),
			new InteractionEffector(FullBodyBipedEffector.LeftThigh),
			new InteractionEffector(FullBodyBipedEffector.RightFoot),
			new InteractionEffector(FullBodyBipedEffector.RightHand),
			new InteractionEffector(FullBodyBipedEffector.RightShoulder),
			new InteractionEffector(FullBodyBipedEffector.RightThigh)
		};

		// Token: 0x040021D8 RID: 8664
		private bool EOFDOPLDFCG;

		// Token: 0x040021D9 RID: 8665
		private Collider DPCCKAPMPJI;

		// Token: 0x040021DA RID: 8666
		private Collider OAGAHEAMIAB;

		// Token: 0x02000496 RID: 1174
		// (Invoke) Token: 0x060100E5 RID: 65765
		public delegate void FOKJDOCGHHO(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA);

		// Token: 0x02000497 RID: 1175
		// (Invoke) Token: 0x060100E9 RID: 65769
		public delegate void PMFJHBEEHFF(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA, InteractionObject.InteractionEvent NGOAKCIIPEB);
	}
}
