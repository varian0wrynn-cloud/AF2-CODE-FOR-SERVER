using System;
using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000427 RID: 1063
	public class Phone : MonoBehaviour
	{
		// Token: 0x0600E59D RID: 58781 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KKINILDDPDA()
		{
		}

		// Token: 0x0600E59E RID: 58782 RVA: 0x00022FCC File Offset: 0x000211CC
		private void ODJBFPBEDGB()
		{
		}

		// Token: 0x0600E59F RID: 58783 RVA: 0x006880E2 File Offset: 0x006862E2
		private void ODGBOEBDJEH()
		{
			this.pickUpObject.MAKEGLCIHAJ.FEGPDLHOPKD();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5A0 RID: 58784 RVA: 0x00022FCC File Offset: 0x000211CC
		private void ALMAGGEBKLL()
		{
		}

		// Token: 0x0600E5A1 RID: 58785 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator MNFHNIECMCG()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5A2 RID: 58786 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator PGHKHNLGKGL()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5A3 RID: 58787 RVA: 0x0068812A File Offset: 0x0068632A
		private void DMNIECGLJPH()
		{
			this.pickUpObject.MAKEGLCIHAJ.FEGPDLHOPKD();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5A4 RID: 58788 RVA: 0x00688154 File Offset: 0x00686354
		private void KMEPONLOPAA()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = false;
		}

		// Token: 0x0600E5A5 RID: 58789 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator GODKMLCHBLG()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5A6 RID: 58790 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator AIMPGCJPMOK()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5A7 RID: 58791 RVA: 0x00022FCC File Offset: 0x000211CC
		private void JOKFCKLEEDB()
		{
		}

		// Token: 0x0600E5A8 RID: 58792 RVA: 0x00022FCC File Offset: 0x000211CC
		private void MNMPGLHOLFF()
		{
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x00022FCC File Offset: 0x000211CC
		private void OBHAHPOFJAA()
		{
		}

		// Token: 0x0600E5AA RID: 58794 RVA: 0x00688173 File Offset: 0x00686373
		private void GHPNFEBKMAF()
		{
			this.pickUpObject.HCMKKLDHBHN().ResumeAll();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5AB RID: 58795 RVA: 0x006881A0 File Offset: 0x006863A0
		private void PGNCLFPGNGJ()
		{
			this.pickUpCollider.enabled = true;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.HCMKKLDHBHN().transform;
			base.GetComponent<Rigidbody>().isKinematic = true;
			base.StartCoroutine(this.GKMEEOOHBBH());
		}

		// Token: 0x0600E5AC RID: 58796 RVA: 0x00022FCC File Offset: 0x000211CC
		private void HMPMFPMOJAO()
		{
		}

		// Token: 0x0600E5AD RID: 58797 RVA: 0x00022FCC File Offset: 0x000211CC
		private void DCPPLBDKDHF()
		{
		}

		// Token: 0x0600E5AF RID: 58799 RVA: 0x00688200 File Offset: 0x00686400
		private void OGPBAHDOCHE()
		{
			this.pickUpCollider.enabled = true;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.MAKEGLCIHAJ.transform;
			base.GetComponent<Rigidbody>().isKinematic = false;
			base.StartCoroutine(this.IAEFOGBFBJF());
		}

		// Token: 0x0600E5B0 RID: 58800 RVA: 0x0068825E File Offset: 0x0068645E
		private void NKFFMPPFPHA()
		{
			this.pickUpObject.MAKEGLCIHAJ.FEGPDLHOPKD();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5B1 RID: 58801 RVA: 0x00688288 File Offset: 0x00686488
		private void MAPACAKNPAD()
		{
			this.pickUpObject.HCMKKLDHBHN().AEGOFPPDLGJ();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5B2 RID: 58802 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator EBONFHNCICC()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator GEENLPCMGHK()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5B4 RID: 58804 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator DKDDOJAIHND()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5B5 RID: 58805 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator AMDDDNKDFOB()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5B6 RID: 58806 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator NFAEKEGJIJI()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5B7 RID: 58807 RVA: 0x006882B2 File Offset: 0x006864B2
		private void FGNPLIOIGOL()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = true;
		}

		// Token: 0x0600E5B8 RID: 58808 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator HKJNBPJGHAD()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5B9 RID: 58809 RVA: 0x006882B2 File Offset: 0x006864B2
		private void PNGJKFNPNPL()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = true;
		}

		// Token: 0x0600E5BA RID: 58810 RVA: 0x006882D1 File Offset: 0x006864D1
		private void GALNKDNAOBJ()
		{
			this.pickUpObject.HCMKKLDHBHN().AEGOFPPDLGJ();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5BB RID: 58811 RVA: 0x006882FB File Offset: 0x006864FB
		private void CEIPACEDBED()
		{
			this.pickUpObject.MAKEGLCIHAJ.ResumeAll();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5BC RID: 58812 RVA: 0x00688154 File Offset: 0x00686354
		private void HOEAEOHJJMO()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = false;
		}

		// Token: 0x0600E5BD RID: 58813 RVA: 0x00688154 File Offset: 0x00686354
		private void PDAFCDCKENK()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = false;
		}

		// Token: 0x0600E5BE RID: 58814 RVA: 0x00688328 File Offset: 0x00686528
		private void MJCIMEDAHBM()
		{
			this.pickUpCollider.enabled = false;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.HCMKKLDHBHN().transform;
			base.GetComponent<Rigidbody>().isKinematic = true;
			base.StartCoroutine(this.GODKMLCHBLG());
		}

		// Token: 0x0600E5BF RID: 58815 RVA: 0x00688154 File Offset: 0x00686354
		private void PENPPEHFLNO()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = false;
		}

		// Token: 0x0600E5C0 RID: 58816 RVA: 0x00022FCC File Offset: 0x000211CC
		private void JDMMEKCOGPM()
		{
		}

		// Token: 0x0600E5C1 RID: 58817 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator MPMNBOLBLLH()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5C2 RID: 58818 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator EDJIGHBGAKH()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5C3 RID: 58819 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator ANGKALAPKAC()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5C4 RID: 58820 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator KGCMDKCOEKI()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5C5 RID: 58821 RVA: 0x00688386 File Offset: 0x00686586
		private void AGBFBPPNKNI()
		{
			this.pickUpObject.HCMKKLDHBHN().ResumeAll();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5C6 RID: 58822 RVA: 0x00688386 File Offset: 0x00686586
		private void DADPAKMFBGH()
		{
			this.pickUpObject.HCMKKLDHBHN().ResumeAll();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5C7 RID: 58823 RVA: 0x006883B0 File Offset: 0x006865B0
		private void MEEOGAPBIAD()
		{
			this.pickUpCollider.enabled = false;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.MAKEGLCIHAJ.transform;
			base.GetComponent<Rigidbody>().isKinematic = true;
			base.StartCoroutine(this.PPAHHBBJEPK());
		}

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator GKMEEOOHBBH()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5C9 RID: 58825 RVA: 0x00688410 File Offset: 0x00686610
		private void PPOBILIMACM()
		{
			this.pickUpCollider.enabled = false;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.HCMKKLDHBHN().transform;
			base.GetComponent<Rigidbody>().isKinematic = false;
			base.StartCoroutine(this.IAEFOGBFBJF());
		}

		// Token: 0x0600E5CA RID: 58826 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator BPLAMCAEMAJ()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5CB RID: 58827 RVA: 0x00022FCC File Offset: 0x000211CC
		private void AIHGNNFIEIM()
		{
		}

		// Token: 0x0600E5CC RID: 58828 RVA: 0x006882FB File Offset: 0x006864FB
		private void PAOEHDAGEAD()
		{
			this.pickUpObject.MAKEGLCIHAJ.ResumeAll();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5CD RID: 58829 RVA: 0x006882B2 File Offset: 0x006864B2
		private void JEICMFINBLF()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = true;
		}

		// Token: 0x0600E5CE RID: 58830 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator PPAHHBBJEPK()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5CF RID: 58831 RVA: 0x00688470 File Offset: 0x00686670
		private void OCJPJDAAPAP()
		{
			this.pickUpCollider.enabled = true;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.HCMKKLDHBHN().transform;
			base.GetComponent<Rigidbody>().isKinematic = true;
			base.StartCoroutine(this.DKDDOJAIHND());
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KMLCMBKBKKK()
		{
		}

		// Token: 0x0600E5D1 RID: 58833 RVA: 0x006884D0 File Offset: 0x006866D0
		private void HLIBGACINBP()
		{
			this.pickUpCollider.enabled = true;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.MAKEGLCIHAJ.transform;
			base.GetComponent<Rigidbody>().isKinematic = false;
			base.StartCoroutine(this.BPLAMCAEMAJ());
		}

		// Token: 0x0600E5D2 RID: 58834 RVA: 0x0068852E File Offset: 0x0068672E
		private void IOOBFCIBGPB()
		{
			this.pickUpObject.HCMKKLDHBHN().ResumeAll();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5D3 RID: 58835 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KMFGMIFKKLG()
		{
		}

		// Token: 0x0600E5D4 RID: 58836 RVA: 0x00022FCC File Offset: 0x000211CC
		private void ADDEPOEFIOI()
		{
		}

		// Token: 0x0600E5D5 RID: 58837 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KMMNGDIKEIL()
		{
		}

		// Token: 0x0600E5D6 RID: 58838 RVA: 0x00688558 File Offset: 0x00686758
		private void GFLMPKDPFPK()
		{
			this.pickUpObject.MAKEGLCIHAJ.ResumeAll();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5D7 RID: 58839 RVA: 0x00022FCC File Offset: 0x000211CC
		private void EBEBMFMHOBD()
		{
		}

		// Token: 0x0600E5D8 RID: 58840 RVA: 0x00688154 File Offset: 0x00686354
		private void PBKNLDJGMNC()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = false;
		}

		// Token: 0x0600E5D9 RID: 58841 RVA: 0x00688584 File Offset: 0x00686784
		private void EGDELLMMJDH()
		{
			this.pickUpCollider.enabled = true;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.MAKEGLCIHAJ.transform;
			base.GetComponent<Rigidbody>().isKinematic = true;
			base.StartCoroutine(this.MNFHNIECMCG());
		}

		// Token: 0x0600E5DA RID: 58842 RVA: 0x00688386 File Offset: 0x00686586
		private void AAGICIEFDCI()
		{
			this.pickUpObject.HCMKKLDHBHN().ResumeAll();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5DB RID: 58843 RVA: 0x00022FCC File Offset: 0x000211CC
		private void JBLNKMCJNGE()
		{
		}

		// Token: 0x0600E5DC RID: 58844 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator KLEAHFDAALD()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x006885E2 File Offset: 0x006867E2
		private void EKOBLALIIOM()
		{
			this.pickUpObject.HCMKKLDHBHN().AEGOFPPDLGJ();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x00022FCC File Offset: 0x000211CC
		private void FDLFGPOKLML()
		{
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x00688558 File Offset: 0x00686758
		private void JGJBEIOPNKK()
		{
			this.pickUpObject.MAKEGLCIHAJ.ResumeAll();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x0068860C File Offset: 0x0068680C
		private void CPAKPGODNJF()
		{
			this.pickUpCollider.enabled = true;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.MAKEGLCIHAJ.transform;
			base.GetComponent<Rigidbody>().isKinematic = false;
			base.StartCoroutine(this.KLEAHFDAALD());
		}

		// Token: 0x0600E5E1 RID: 58849 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator JIKLMEPNAJE()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5E2 RID: 58850 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator GNKCOLOBOIP()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5E3 RID: 58851 RVA: 0x00022FCC File Offset: 0x000211CC
		private void MIBKLFBIIDF()
		{
		}

		// Token: 0x0600E5E4 RID: 58852 RVA: 0x0068811B File Offset: 0x0068631B
		private IEnumerator CFKHLCJJEEA()
		{
			yield return new WaitForSeconds(1f);
			this.display.SetActive(true);
			yield break;
		}

		// Token: 0x0600E5E5 RID: 58853 RVA: 0x00022FCC File Offset: 0x000211CC
		private void BLBHKPDEEBJ()
		{
		}

		// Token: 0x0600E5E6 RID: 58854 RVA: 0x006882FB File Offset: 0x006864FB
		private void DJMLINIHIJE()
		{
			this.pickUpObject.MAKEGLCIHAJ.ResumeAll();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5E7 RID: 58855 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator HCOBIBNLKMN()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5E8 RID: 58856 RVA: 0x00688154 File Offset: 0x00686354
		private void LIJPNCAJNJD()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = false;
		}

		// Token: 0x0600E5E9 RID: 58857 RVA: 0x00022FCC File Offset: 0x000211CC
		private void EKEHNOHOCKK()
		{
		}

		// Token: 0x0600E5EA RID: 58858 RVA: 0x00022FCC File Offset: 0x000211CC
		private void PFBADDJMGIC()
		{
		}

		// Token: 0x0600E5EB RID: 58859 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator LINFJFBGIHN()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5EC RID: 58860 RVA: 0x0068866C File Offset: 0x0068686C
		private void NKMCCPBMMBL()
		{
			this.pickUpCollider.enabled = false;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.MAKEGLCIHAJ.transform;
			base.GetComponent<Rigidbody>().isKinematic = true;
			base.StartCoroutine(this.AIMPGCJPMOK());
		}

		// Token: 0x0600E5ED RID: 58861 RVA: 0x00688154 File Offset: 0x00686354
		private void LMJBEAJJPHL()
		{
			base.transform.parent = this.OCBAOFLJBGP;
			base.GetComponent<Rigidbody>().isKinematic = false;
		}

		// Token: 0x0600E5EE RID: 58862 RVA: 0x006886CA File Offset: 0x006868CA
		private void IOGIPALJGMH()
		{
			this.pickUpObject.MAKEGLCIHAJ.AEGOFPPDLGJ();
			this.pickUpCollider.enabled = false;
			this.display.SetActive(true);
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x00022FCC File Offset: 0x000211CC
		private void NICJNOPHEDE()
		{
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator FPGNOABBHNC()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5F1 RID: 58865 RVA: 0x006886F4 File Offset: 0x006868F4
		private void OAFBHNEMLGK()
		{
			this.pickUpCollider.enabled = true;
			this.OCBAOFLJBGP = base.transform.parent;
			base.transform.parent = this.pickUpObject.HCMKKLDHBHN().transform;
			base.GetComponent<Rigidbody>().isKinematic = false;
			base.StartCoroutine(this.GEENLPCMGHK());
		}

		// Token: 0x0600E5F2 RID: 58866 RVA: 0x00022FCC File Offset: 0x000211CC
		private void DGADMDCJGOM()
		{
		}

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x0068810C File Offset: 0x0068630C
		private IEnumerator IAEFOGBFBJF()
		{
			Phone.CLGIOFFJMIP clgioffjmip = new Phone.CLGIOFFJMIP(1);
			clgioffjmip.AENJLLPLILM = this;
			return clgioffjmip;
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x006882FB File Offset: 0x006864FB
		private void HGEGDEDBFLK()
		{
			this.pickUpObject.MAKEGLCIHAJ.ResumeAll();
			this.pickUpCollider.enabled = true;
			this.display.SetActive(false);
		}

		// Token: 0x0600E5F5 RID: 58869 RVA: 0x00022FCC File Offset: 0x000211CC
		private void BBKGNKKHIPL()
		{
		}

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x00022FCC File Offset: 0x000211CC
		private void LHADFIIEOOB()
		{
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x00022FCC File Offset: 0x000211CC
		private void LPAKFDPMCKL()
		{
		}

		// Token: 0x04001E03 RID: 7683
		[Tooltip("The collider that is used for triggering the picking up interaction.")]
		public Collider pickUpCollider;

		// Token: 0x04001E04 RID: 7684
		[Tooltip("InteractionObject of the picking up interaction.")]
		public InteractionObject pickUpObject;

		// Token: 0x04001E05 RID: 7685
		[Tooltip("Root of the phone's display that has all the buttons parented to it.")]
		public GameObject display;

		// Token: 0x04001E06 RID: 7686
		private Transform OCBAOFLJBGP;
	}
}
