using System;
using UnityEngine;
using UnityEngine.AI;

namespace UnityStandardAssets.Characters.ThirdPerson
{
	// Token: 0x020003A0 RID: 928
	[RequireComponent(typeof(ThirdPersonCharacter))]
	[RequireComponent(typeof(NavMeshAgent))]
	public class AICharacterControl : MonoBehaviour
	{
		// Token: 0x0600C7FF RID: 51199 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void BAONNLKHFJO(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C800 RID: 51200 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void HJGMNCGOPEC(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C801 RID: 51201 RVA: 0x00597C98 File Offset: 0x00595E98
		private void HLOKCDBBGGA(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C802 RID: 51202 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter BFEKKEBMIJO()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C803 RID: 51203 RVA: 0x00597C98 File Offset: 0x00595E98
		private void EMMJHAJDBMK(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C804 RID: 51204 RVA: 0x00597CA9 File Offset: 0x00595EA9
		private void CBLGFOFHNPJ()
		{
			this.JBKPHGGOLJC(base.GetComponentInChildren<NavMeshAgent>());
			this.JBJOPNHICAG(base.GetComponent<ThirdPersonCharacter>());
			this.NMDHEDAKBIG().updateRotation = true;
			this.EFOJNEMFHJN.updatePosition = false;
		}

		// Token: 0x0600C805 RID: 51205 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void KINMOMDKPLA(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C806 RID: 51206 RVA: 0x00597C98 File Offset: 0x00595E98
		private void JBJOPNHICAG(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void GHIDCEDADEC(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C808 RID: 51208 RVA: 0x00597CE4 File Offset: 0x00595EE4
		private void HDFCIACDDEK()
		{
			this.BAONNLKHFJO(base.GetComponentInChildren<NavMeshAgent>());
			this.JBJOPNHICAG(base.GetComponent<ThirdPersonCharacter>());
			this.PCJLFHGBECE().updateRotation = false;
			this.EFOJNEMFHJN.updatePosition = true;
		}

		// Token: 0x0600C809 RID: 51209 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void LMBHJMPDGAK(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C80A RID: 51210 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter AMHHNICMPNJ()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C80B RID: 51211 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter ILKPMNLPBGH()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter CAFPADKOFPM()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C80D RID: 51213 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent ABIOBDCALOH()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C80E RID: 51214 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void HAGALICGIEI(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C80F RID: 51215 RVA: 0x00597D20 File Offset: 0x00595F20
		private void AIILFFCEKKM()
		{
			if (this.target != null)
			{
				this.NLALDCPCCJC().SetDestination(this.target.position);
			}
			if (this.EFOJNEMFHJN.remainingDistance > this.PCJLFHGBECE().stoppingDistance)
			{
				this.BNLGDFIMMHN().HPGBIANDJPO(this.PFBJKJJMPJO().desiredVelocity, false, false);
				return;
			}
			this.KBFNBNPLFHO().HPGBIANDJPO(Vector3.zero, true, true);
		}

		// Token: 0x0600C810 RID: 51216 RVA: 0x00597C98 File Offset: 0x00595E98
		private void BDODIPBBEGP(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C811 RID: 51217 RVA: 0x00597D98 File Offset: 0x00595F98
		private void AJCHHNKFOHO()
		{
			if (this.target != null)
			{
				this.JNFKFMGKPPJ().SetDestination(this.target.position);
			}
			if (this.PCJLFHGBECE().remainingDistance > this.PCJLFHGBECE().stoppingDistance)
			{
				this.AHKKIMICJFG().LLBLGDJGIMP(this.NMDHEDAKBIG().desiredVelocity, false, false);
				return;
			}
			this.BFEKKEBMIJO().BCBPAJDGBJD(Vector3.zero, false, true);
		}

		// Token: 0x0600C812 RID: 51218 RVA: 0x00597E0D File Offset: 0x0059600D
		private void PNJHMJNFPLP()
		{
			this.CKPNBGDLKPO(base.GetComponentInChildren<NavMeshAgent>());
			this.EGHIKIFGMIO(base.GetComponent<ThirdPersonCharacter>());
			this.HEICHAEECDC().updateRotation = false;
			this.IAHGCIECPMP().updatePosition = true;
		}

		// Token: 0x0600C813 RID: 51219 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void DNAAKIFGJNC(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C814 RID: 51220 RVA: 0x00597E40 File Offset: 0x00596040
		private void DAFJMNMFOON()
		{
			if (this.target != null)
			{
				this.NLALDCPCCJC().SetDestination(this.target.position);
			}
			if (this.LAMILHLNKKM().remainingDistance > this.EFOJNEMFHJN.stoppingDistance)
			{
				this.EHGJIPFPKPL().MKEMPIEPDGK(this.LAMILHLNKKM().desiredVelocity, false, true);
				return;
			}
			this.EHGJIPFPKPL().PEGCCIJGGDP(Vector3.zero, false, true);
		}

		// Token: 0x0600C815 RID: 51221 RVA: 0x00597EB5 File Offset: 0x005960B5
		private void EFCCCKGCOCB()
		{
			this.JBKPHGGOLJC(base.GetComponentInChildren<NavMeshAgent>());
			this.EMMJHAJDBMK(base.GetComponent<ThirdPersonCharacter>());
			this.ABIOBDCALOH().updateRotation = false;
			this.EFOJNEMFHJN.updatePosition = true;
		}

		// Token: 0x0600C816 RID: 51222 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter BLMCHHAJKPE()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C817 RID: 51223 RVA: 0x00597EE7 File Offset: 0x005960E7
		private void KEIILPMCFEO()
		{
			this.HAGALICGIEI(base.GetComponentInChildren<NavMeshAgent>());
			this.INHHOACMELF(base.GetComponent<ThirdPersonCharacter>());
			this.PNKAJJEPALH().updateRotation = false;
			this.OLAFJKLGNEF().updatePosition = true;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600C818 RID: 51224 RVA: 0x00597CA1 File Offset: 0x00595EA1
		// (set) Token: 0x0600C842 RID: 51266 RVA: 0x00597C98 File Offset: 0x00595E98
		public ThirdPersonCharacter IFIIFDKAKDJ { get; private set; }

		// Token: 0x0600C819 RID: 51225 RVA: 0x00597C98 File Offset: 0x00595E98
		private void PABMBIECPEG(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C81A RID: 51226 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void PKPBCDHKCKC(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C81B RID: 51227 RVA: 0x00597F1C File Offset: 0x0059611C
		private void PFPPDNHLCCA()
		{
			if (this.target != null)
			{
				this.HEICHAEECDC().SetDestination(this.target.position);
			}
			if (this.LKCACEGJNIF().remainingDistance > this.IAHGCIECPMP().stoppingDistance)
			{
				this.BLMCHHAJKPE().MKEMPIEPDGK(this.CIDPHFFCBJF().desiredVelocity, false, false);
				return;
			}
			this.DADBAEKGFCJ().LLBLGDJGIMP(Vector3.zero, false, true);
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter LEMBPIHMEFB()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C81D RID: 51229 RVA: 0x00597F94 File Offset: 0x00596194
		private void AKLFCMNCPKL()
		{
			if (this.target != null)
			{
				this.JNFKFMGKPPJ().SetDestination(this.target.position);
			}
			if (this.PFBJKJJMPJO().remainingDistance > this.LAMILHLNKKM().stoppingDistance)
			{
				this.LCLPOFEAPBP().BCBPAJDGBJD(this.NLALDCPCCJC().desiredVelocity, true, false);
				return;
			}
			this.FDAMPNBAGAG().PEGCCIJGGDP(Vector3.zero, false, true);
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void HDCNAABAFNO(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent HFOFDAFEOBO()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C820 RID: 51232 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent LKCACEGJNIF()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C821 RID: 51233 RVA: 0x0059800C File Offset: 0x0059620C
		private void CLCJPEDHFJA()
		{
			if (this.target != null)
			{
				this.NMDHEDAKBIG().SetDestination(this.target.position);
			}
			if (this.NMDHEDAKBIG().remainingDistance > this.NLALDCPCCJC().stoppingDistance)
			{
				this.DFFMFLLJCEP().HPGBIANDJPO(this.OLAFJKLGNEF().desiredVelocity, false, false);
				return;
			}
			this.DHBPAGJGLGE().PEGCCIJGGDP(Vector3.zero, false, false);
		}

		// Token: 0x0600C822 RID: 51234 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void BOFLHFMCGIB(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void PAACBENIBLA(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C824 RID: 51236 RVA: 0x00598081 File Offset: 0x00596281
		private void EJOAPOGPBFM()
		{
			this.KINMOMDKPLA(base.GetComponentInChildren<NavMeshAgent>());
			this.JBJOPNHICAG(base.GetComponent<ThirdPersonCharacter>());
			this.NMDHEDAKBIG().updateRotation = false;
			this.JNFKFMGKPPJ().updatePosition = true;
		}

		// Token: 0x0600C825 RID: 51237 RVA: 0x00597C98 File Offset: 0x00595E98
		private void LFKKBFKJEGI(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C826 RID: 51238 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void JBKPHGGOLJC(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x005980B4 File Offset: 0x005962B4
		private void OLGDMBDGLAN()
		{
			if (this.target != null)
			{
				this.LAMILHLNKKM().SetDestination(this.target.position);
			}
			if (this.PNKAJJEPALH().remainingDistance > this.HFOFDAFEOBO().stoppingDistance)
			{
				this.EHGJIPFPKPL().LLBLGDJGIMP(this.CIDPHFFCBJF().desiredVelocity, true, true);
				return;
			}
			this.PHNJALLKLFB().LOIHEBEJOMI(Vector3.zero, false, false);
		}

		// Token: 0x0600C828 RID: 51240 RVA: 0x00597C98 File Offset: 0x00595E98
		private void PJEBCGIFFEE(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C829 RID: 51241 RVA: 0x0059812C File Offset: 0x0059632C
		private void KEBDEJIAODF()
		{
			if (this.target != null)
			{
				this.HFOFDAFEOBO().SetDestination(this.target.position);
			}
			if (this.HFOFDAFEOBO().remainingDistance > this.LKCACEGJNIF().stoppingDistance)
			{
				this.BNLGDFIMMHN().LLBLGDJGIMP(this.PCJLFHGBECE().desiredVelocity, false, true);
				return;
			}
			this.FDAMPNBAGAG().Move(Vector3.zero, false, false);
		}

		// Token: 0x0600C82A RID: 51242 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent CIDPHFFCBJF()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void LGOIFPNLMKE(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C82D RID: 51245 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent HEICHAEECDC()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C82E RID: 51246 RVA: 0x005981A1 File Offset: 0x005963A1
		private void NOKJMMDMJNO()
		{
			this.LMBHJMPDGAK(base.GetComponentInChildren<NavMeshAgent>());
			this.DEDPACFJOFC(base.GetComponent<ThirdPersonCharacter>());
			this.HEICHAEECDC().updateRotation = true;
			this.LAMILHLNKKM().updatePosition = true;
		}

		// Token: 0x0600C82F RID: 51247 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void KNGFNEEFLHG(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C830 RID: 51248 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter MKPFMFOEICG()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C831 RID: 51249 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void SetTarget(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void CKMFICCOHBE(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x005981D4 File Offset: 0x005963D4
		private void MPLCAGFGEBO()
		{
			if (this.target != null)
			{
				this.NLALDCPCCJC().SetDestination(this.target.position);
			}
			if (this.PNKAJJEPALH().remainingDistance > this.PNKAJJEPALH().stoppingDistance)
			{
				this.CAFPADKOFPM().MKEMPIEPDGK(this.DIJCFGPEJGO().desiredVelocity, false, false);
				return;
			}
			this.BLMCHHAJKPE().DBGDNKOAGPJ(Vector3.zero, false, true);
		}

		// Token: 0x0600C834 RID: 51252 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void OMNCEMGAPKD(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C835 RID: 51253 RVA: 0x00597C98 File Offset: 0x00595E98
		private void GJEFLFOGHHB(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C836 RID: 51254 RVA: 0x0059824C File Offset: 0x0059644C
		private void GHOBHBMFKHN()
		{
			if (this.target != null)
			{
				this.HFOFDAFEOBO().SetDestination(this.target.position);
			}
			if (this.PNKAJJEPALH().remainingDistance > this.LFNELPJLODK().stoppingDistance)
			{
				this.FDAMPNBAGAG().ONGLOCLINIM(this.ONFMNKDNCMJ().desiredVelocity, false, true);
				return;
			}
			this.BFEKKEBMIJO().Move(Vector3.zero, false, false);
		}

		// Token: 0x0600C837 RID: 51255 RVA: 0x005982C4 File Offset: 0x005964C4
		private void DEGCCLNOEKJ()
		{
			if (this.target != null)
			{
				this.OLAFJKLGNEF().SetDestination(this.target.position);
			}
			if (this.ABIOBDCALOH().remainingDistance > this.EFOJNEMFHJN.stoppingDistance)
			{
				this.DFFMFLLJCEP().LOIHEBEJOMI(this.JNFKFMGKPPJ().desiredVelocity, false, true);
				return;
			}
			this.KBFNBNPLFHO().MKEMPIEPDGK(Vector3.zero, false, true);
		}

		// Token: 0x0600C838 RID: 51256 RVA: 0x00598339 File Offset: 0x00596539
		private void Start()
		{
			this.EFOJNEMFHJN = base.GetComponentInChildren<NavMeshAgent>();
			this.IFIIFDKAKDJ = base.GetComponent<ThirdPersonCharacter>();
			this.EFOJNEMFHJN.updateRotation = false;
			this.EFOJNEMFHJN.updatePosition = true;
		}

		// Token: 0x0600C839 RID: 51257 RVA: 0x00597C98 File Offset: 0x00595E98
		private void INHHOACMELF(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C83A RID: 51258 RVA: 0x0059836C File Offset: 0x0059656C
		private void JFGGBEGNAFP()
		{
			if (this.target != null)
			{
				this.JNFKFMGKPPJ().SetDestination(this.target.position);
			}
			if (this.LFNELPJLODK().remainingDistance > this.OLAFJKLGNEF().stoppingDistance)
			{
				this.BLMCHHAJKPE().PEGCCIJGGDP(this.CIDPHFFCBJF().desiredVelocity, true, false);
				return;
			}
			this.AHKKIMICJFG().BCBPAJDGBJD(Vector3.zero, false, false);
		}

		// Token: 0x0600C83B RID: 51259 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent DIJCFGPEJGO()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C83C RID: 51260 RVA: 0x005983E4 File Offset: 0x005965E4
		private void PMKOAHMNBBG()
		{
			if (this.target != null)
			{
				this.LKCACEGJNIF().SetDestination(this.target.position);
			}
			if (this.JNFKFMGKPPJ().remainingDistance > this.NMDHEDAKBIG().stoppingDistance)
			{
				this.BLMCHHAJKPE().ONGLOCLINIM(this.NMDHEDAKBIG().desiredVelocity, true, false);
				return;
			}
			this.LCLPOFEAPBP().PEGCCIJGGDP(Vector3.zero, false, true);
		}

		// Token: 0x0600C83D RID: 51261 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void PCKPCDFHLEA(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C83E RID: 51262 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent OLAFJKLGNEF()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C83F RID: 51263 RVA: 0x0059845C File Offset: 0x0059665C
		private void OHKHOAKCENL()
		{
			if (this.target != null)
			{
				this.EFOJNEMFHJN.SetDestination(this.target.position);
			}
			if (this.PCJLFHGBECE().remainingDistance > this.HEICHAEECDC().stoppingDistance)
			{
				this.PHNJALLKLFB().ONGLOCLINIM(this.CIDPHFFCBJF().desiredVelocity, false, false);
				return;
			}
			this.IFIIFDKAKDJ.HPGBIANDJPO(Vector3.zero, false, false);
		}

		// Token: 0x0600C840 RID: 51264 RVA: 0x005984D4 File Offset: 0x005966D4
		private void HMEAENGBFKC()
		{
			if (this.target != null)
			{
				this.ABIOBDCALOH().SetDestination(this.target.position);
			}
			if (this.NMDHEDAKBIG().remainingDistance > this.EFOJNEMFHJN.stoppingDistance)
			{
				this.EDPOACIPOJO().ONGLOCLINIM(this.EFOJNEMFHJN.desiredVelocity, true, false);
				return;
			}
			this.LEMBPIHMEFB().HMMKAGPJEAC(Vector3.zero, true, true);
		}

		// Token: 0x0600C841 RID: 51265 RVA: 0x00598549 File Offset: 0x00596749
		private void DPPAAIJCFLC()
		{
			this.PGAOOFNGDCC(base.GetComponentInChildren<NavMeshAgent>());
			this.NFKHGJNOFMD(base.GetComponent<ThirdPersonCharacter>());
			this.ONFMNKDNCMJ().updateRotation = false;
			this.IAHGCIECPMP().updatePosition = true;
		}

		// Token: 0x0600C843 RID: 51267 RVA: 0x00597C98 File Offset: 0x00595E98
		private void JDPDKEAPPAK(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C844 RID: 51268 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void NDOALAHDEEP(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C845 RID: 51269 RVA: 0x0059857C File Offset: 0x0059677C
		private void Update()
		{
			if (this.target != null)
			{
				this.EFOJNEMFHJN.SetDestination(this.target.position);
			}
			if (this.EFOJNEMFHJN.remainingDistance > this.EFOJNEMFHJN.stoppingDistance)
			{
				this.IFIIFDKAKDJ.Move(this.EFOJNEMFHJN.desiredVelocity, false, false);
				return;
			}
			this.IFIIFDKAKDJ.Move(Vector3.zero, false, false);
		}

		// Token: 0x0600C846 RID: 51270 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter DADBAEKGFCJ()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C847 RID: 51271 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent IAHGCIECPMP()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C848 RID: 51272 RVA: 0x005985F1 File Offset: 0x005967F1
		private void LPNDCJKAKEA()
		{
			this.JBKPHGGOLJC(base.GetComponentInChildren<NavMeshAgent>());
			this.HHLALAKAJGE(base.GetComponent<ThirdPersonCharacter>());
			this.PFBJKJJMPJO().updateRotation = true;
			this.NMDHEDAKBIG().updatePosition = true;
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x00597C98 File Offset: 0x00595E98
		private void FOJJFALDKEH(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter FDAMPNBAGAG()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C84B RID: 51275 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter PHNJALLKLFB()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C84C RID: 51276 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter AHKKIMICJFG()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C84D RID: 51277 RVA: 0x00597C98 File Offset: 0x00595E98
		private void DEDPACFJOFC(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void NEJBCBBJECN(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x00598623 File Offset: 0x00596823
		private void GHCMIKGJPJD()
		{
			this.KNGFNEEFLHG(base.GetComponentInChildren<NavMeshAgent>());
			this.BDODIPBBEGP(base.GetComponent<ThirdPersonCharacter>());
			this.CIDPHFFCBJF().updateRotation = true;
			this.PFBJKJJMPJO().updatePosition = true;
		}

		// Token: 0x0600C850 RID: 51280 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent PNKAJJEPALH()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C851 RID: 51281 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter EDPOACIPOJO()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C852 RID: 51282 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent ONFMNKDNCMJ()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C853 RID: 51283 RVA: 0x00598655 File Offset: 0x00596855
		private void APPLKMOGAMJ()
		{
			this.JAGOBHLMANP(base.GetComponentInChildren<NavMeshAgent>());
			this.INHHOACMELF(base.GetComponent<ThirdPersonCharacter>());
			this.OLAFJKLGNEF().updateRotation = true;
			this.ONFMNKDNCMJ().updatePosition = true;
		}

		// Token: 0x0600C854 RID: 51284 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter BNLGDFIMMHN()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C855 RID: 51285 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void AJHIDPOGJDK(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C856 RID: 51286 RVA: 0x00597C98 File Offset: 0x00595E98
		private void NFKHGJNOFMD(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C857 RID: 51287 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter KBFNBNPLFHO()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void IBLHBAENHFN(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C859 RID: 51289 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter DHBPAGJGLGE()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C85A RID: 51290 RVA: 0x00598687 File Offset: 0x00596887
		private void GGBMJFNGHMC()
		{
			this.JBKPHGGOLJC(base.GetComponentInChildren<NavMeshAgent>());
			this.LFKKBFKJEGI(base.GetComponent<ThirdPersonCharacter>());
			this.PNKAJJEPALH().updateRotation = false;
			this.HEICHAEECDC().updatePosition = false;
		}

		// Token: 0x0600C85B RID: 51291 RVA: 0x005986B9 File Offset: 0x005968B9
		private void AIFIEAGFIMM()
		{
			this.JAGOBHLMANP(base.GetComponentInChildren<NavMeshAgent>());
			this.BDODIPBBEGP(base.GetComponent<ThirdPersonCharacter>());
			this.EFOJNEMFHJN.updateRotation = true;
			this.ONFMNKDNCMJ().updatePosition = true;
		}

		// Token: 0x0600C85C RID: 51292 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent LFNELPJLODK()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C85D RID: 51293 RVA: 0x00597C98 File Offset: 0x00595E98
		private void AJPBFAPFICP(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C85E RID: 51294 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void PLOBOGHJCBM(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C85F RID: 51295 RVA: 0x00597C98 File Offset: 0x00595E98
		private void LBFHHEHDLFD(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C860 RID: 51296 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void CKPNBGDLKPO(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600C861 RID: 51297 RVA: 0x00597D16 File Offset: 0x00595F16
		// (set) Token: 0x0600C868 RID: 51304 RVA: 0x00597C8F File Offset: 0x00595E8F
		public NavMeshAgent EFOJNEMFHJN { get; private set; }

		// Token: 0x0600C862 RID: 51298 RVA: 0x005986EC File Offset: 0x005968EC
		private void LEHBKPPGHPC()
		{
			if (this.target != null)
			{
				this.LKCACEGJNIF().SetDestination(this.target.position);
			}
			if (this.JNFKFMGKPPJ().remainingDistance > this.PNKAJJEPALH().stoppingDistance)
			{
				this.AHKKIMICJFG().LOIHEBEJOMI(this.HFOFDAFEOBO().desiredVelocity, true, false);
				return;
			}
			this.AHKKIMICJFG().DBGDNKOAGPJ(Vector3.zero, true, false);
		}

		// Token: 0x0600C863 RID: 51299 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent PFBJKJJMPJO()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C864 RID: 51300 RVA: 0x00597C98 File Offset: 0x00595E98
		private void NPOMNLFPCNM(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C865 RID: 51301 RVA: 0x00598764 File Offset: 0x00596964
		private void KLFPOILLKDF()
		{
			if (this.target != null)
			{
				this.PNKAJJEPALH().SetDestination(this.target.position);
			}
			if (this.ONFMNKDNCMJ().remainingDistance > this.LKCACEGJNIF().stoppingDistance)
			{
				this.FDAMPNBAGAG().LOIHEBEJOMI(this.HFOFDAFEOBO().desiredVelocity, false, true);
				return;
			}
			this.LCLPOFEAPBP().LOIHEBEJOMI(Vector3.zero, false, false);
		}

		// Token: 0x0600C866 RID: 51302 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void JJGPPFJGGGB(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C867 RID: 51303 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent NLALDCPCCJC()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x005987DC File Offset: 0x005969DC
		private void BAIKCLKJPAA()
		{
			if (this.target != null)
			{
				this.NMDHEDAKBIG().SetDestination(this.target.position);
			}
			if (this.JNFKFMGKPPJ().remainingDistance > this.CIDPHFFCBJF().stoppingDistance)
			{
				this.LEMBPIHMEFB().MKEMPIEPDGK(this.ABIOBDCALOH().desiredVelocity, false, true);
				return;
			}
			this.IFIIFDKAKDJ.DBGDNKOAGPJ(Vector3.zero, true, false);
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void JAGOBHLMANP(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x00597C98 File Offset: 0x00595E98
		private void HHLALAKAJGE(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C86C RID: 51308 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter LCLPOFEAPBP()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C86D RID: 51309 RVA: 0x00597C98 File Offset: 0x00595E98
		private void MCBNGMNCIBG(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C86E RID: 51310 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent NMDHEDAKBIG()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C86F RID: 51311 RVA: 0x00598854 File Offset: 0x00596A54
		private void EMFOECIPBIP()
		{
			if (this.target != null)
			{
				this.NLALDCPCCJC().SetDestination(this.target.position);
			}
			if (this.CIDPHFFCBJF().remainingDistance > this.JNFKFMGKPPJ().stoppingDistance)
			{
				this.EDPOACIPOJO().DBGDNKOAGPJ(this.OLAFJKLGNEF().desiredVelocity, false, true);
				return;
			}
			this.BFEKKEBMIJO().PEGCCIJGGDP(Vector3.zero, false, false);
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent PCJLFHGBECE()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x005988CC File Offset: 0x00596ACC
		private void KBMKHLDOIKP()
		{
			if (this.target != null)
			{
				this.LAMILHLNKKM().SetDestination(this.target.position);
			}
			if (this.EFOJNEMFHJN.remainingDistance > this.PCJLFHGBECE().stoppingDistance)
			{
				this.BFEKKEBMIJO().Move(this.CIDPHFFCBJF().desiredVelocity, true, false);
				return;
			}
			this.DHBPAGJGLGE().LLBLGDJGIMP(Vector3.zero, true, true);
		}

		// Token: 0x0600C872 RID: 51314 RVA: 0x00597C98 File Offset: 0x00595E98
		private void EGHIKIFGMIO(ThirdPersonCharacter DCCPCBLODIG)
		{
			this.<BCENHNALNCL>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C873 RID: 51315 RVA: 0x00598944 File Offset: 0x00596B44
		private void ACFEBEDDIAI()
		{
			if (this.target != null)
			{
				this.JNFKFMGKPPJ().SetDestination(this.target.position);
			}
			if (this.PCJLFHGBECE().remainingDistance > this.ONFMNKDNCMJ().stoppingDistance)
			{
				this.EDPOACIPOJO().MKEMPIEPDGK(this.EFOJNEMFHJN.desiredVelocity, false, false);
				return;
			}
			this.DFFMFLLJCEP().ONGLOCLINIM(Vector3.zero, false, false);
		}

		// Token: 0x0600C874 RID: 51316 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter EHGJIPFPKPL()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent LAMILHLNKKM()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x00597C8F File Offset: 0x00595E8F
		private void PGAOOFNGDCC(NavMeshAgent DCCPCBLODIG)
		{
			this.<AODADIKPMMK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C877 RID: 51319 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void NCDPAHFEEPJ(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void DCLKFHLAFLI(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x00597CDB File Offset: 0x00595EDB
		public void ELLLJBEDJDL(Transform FFGIAHPIPEK)
		{
			this.target = FFGIAHPIPEK;
		}

		// Token: 0x0600C87A RID: 51322 RVA: 0x00597D16 File Offset: 0x00595F16
		public NavMeshAgent JNFKFMGKPPJ()
		{
			return this.<AODADIKPMMK>k__BackingField;
		}

		// Token: 0x0600C87B RID: 51323 RVA: 0x00597CA1 File Offset: 0x00595EA1
		public ThirdPersonCharacter DFFMFLLJCEP()
		{
			return this.<BCENHNALNCL>k__BackingField;
		}

		// Token: 0x04001A89 RID: 6793
		public Transform target;
	}
}
