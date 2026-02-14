using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200041C RID: 1052
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class FixFeet : MonoBehaviour
	{
		// Token: 0x0600E2D9 RID: 58073 RVA: 0x00672C57 File Offset: 0x00670E57
		private void AOCDDBNBADJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.IAHGFEGHCOG();
		}

		// Token: 0x0600E2DA RID: 58074 RVA: 0x00672C6C File Offset: 0x00670E6C
		private void PCGMJEBLBLD()
		{
			if (this.weight <= 1197f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2DB RID: 58075 RVA: 0x00672DD1 File Offset: 0x00670FD1
		private void DGDGMFDPEHO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.ABNLDJDHGEI();
		}

		// Token: 0x0600E2DC RID: 58076 RVA: 0x00672DE8 File Offset: 0x00670FE8
		public void ALJILFJIGFK()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E2DD RID: 58077 RVA: 0x00672EB5 File Offset: 0x006710B5
		private void OLBDJCFPKFG()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MLIMDNLPPKK();
		}

		// Token: 0x0600E2DE RID: 58078 RVA: 0x00672EC9 File Offset: 0x006710C9
		private void JCELICPHGEP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MDFNFIJJICP();
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x00672EC9 File Offset: 0x006710C9
		private void BJHGPFGBFKF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MDFNFIJJICP();
		}

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x00672EDD File Offset: 0x006710DD
		private void FCCAIANLEFE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.LDDHEAKEBFE();
		}

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x00672EF4 File Offset: 0x006710F4
		public void OHJOIPDFDHJ()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.rightFootEffector.bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation;
		}

		// Token: 0x0600E2E2 RID: 58082 RVA: 0x00672DD1 File Offset: 0x00670FD1
		private void EHDPACPIBNF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.ABNLDJDHGEI();
		}

		// Token: 0x0600E2E3 RID: 58083 RVA: 0x00672FC1 File Offset: 0x006711C1
		private void NCALLFHEAGJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.FDOIAALDEJL();
		}

		// Token: 0x0600E2E4 RID: 58084 RVA: 0x00672FD8 File Offset: 0x006711D8
		private void MLKCOBKDPCK()
		{
			if (this.weight <= 756f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2E5 RID: 58085 RVA: 0x0067313D File Offset: 0x0067133D
		private void PMDPLLIBJAF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.HGJNOBLLJIF();
		}

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x00673154 File Offset: 0x00671354
		public void ABNLDJDHGEI()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation;
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x00673224 File Offset: 0x00671424
		private void HPEMKDKDKFC()
		{
			if (this.weight <= 68f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x0067338C File Offset: 0x0067158C
		private void KBKONONANKH()
		{
			if (this.weight <= 1398f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x006734F4 File Offset: 0x006716F4
		public void ECNPBPIENOF()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.rightFootEffector.bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation;
		}

		// Token: 0x0600E2EA RID: 58090 RVA: 0x006735C4 File Offset: 0x006717C4
		public void CBIFCMOOJGM()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation;
		}

		// Token: 0x0600E2EB RID: 58091 RVA: 0x00673694 File Offset: 0x00671894
		public void PBEMNDJOCPH()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation;
		}

		// Token: 0x0600E2EC RID: 58092 RVA: 0x00673764 File Offset: 0x00671964
		private void NGHOJBOHIBA()
		{
			if (this.weight <= 1693f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.rightFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x006738C9 File Offset: 0x00671AC9
		private void LHJCHPFKGDB()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.FFLLNBLMOKO();
		}

		// Token: 0x0600E2EE RID: 58094 RVA: 0x006738E0 File Offset: 0x00671AE0
		public void ILOHAPNCGGN()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E2EF RID: 58095 RVA: 0x00672EDD File Offset: 0x006710DD
		private void KEIILPMCFEO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.LDDHEAKEBFE();
		}

		// Token: 0x0600E2F0 RID: 58096 RVA: 0x006739B0 File Offset: 0x00671BB0
		private void BOEFHGKGJMN()
		{
			if (this.weight <= 320f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x00673B18 File Offset: 0x00671D18
		private void POCOKCJDCHK()
		{
			if (this.weight <= 11f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x00673C80 File Offset: 0x00671E80
		public void CHOHDBEFLDP()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x00673D50 File Offset: 0x00671F50
		private void EFFFHHCHPIN()
		{
			if (this.weight <= 1298f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2F4 RID: 58100 RVA: 0x00673EB8 File Offset: 0x006720B8
		public void MCIPOEKPENM()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E2F5 RID: 58101 RVA: 0x00673F88 File Offset: 0x00672188
		private void NANEAKKPDBH()
		{
			if (this.weight <= 857f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2F6 RID: 58102 RVA: 0x006740F0 File Offset: 0x006722F0
		private void EIEKEPGNGPL()
		{
			if (this.weight <= 1706f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2F7 RID: 58103 RVA: 0x00674258 File Offset: 0x00672458
		private void PHBMICFMADO()
		{
			if (this.weight <= 564f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2F8 RID: 58104 RVA: 0x006743BD File Offset: 0x006725BD
		private void DGGMJCMLLED()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.KLCBOFBJPIP();
		}

		// Token: 0x0600E2F9 RID: 58105 RVA: 0x006743D1 File Offset: 0x006725D1
		private void LCBIFGKANMD()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.OHJOIPDFDHJ();
		}

		// Token: 0x0600E2FA RID: 58106 RVA: 0x006743E5 File Offset: 0x006725E5
		private void GGBMJFNGHMC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.NCMLADMAOPF();
		}

		// Token: 0x0600E2FB RID: 58107 RVA: 0x006743FC File Offset: 0x006725FC
		private void GJKCGGCCIAJ()
		{
			if (this.weight <= 1111f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E2FC RID: 58108 RVA: 0x00672DD1 File Offset: 0x00670FD1
		private void JHAKJAMBNAH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.ABNLDJDHGEI();
		}

		// Token: 0x0600E2FD RID: 58109 RVA: 0x00674561 File Offset: 0x00672761
		private void Start()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.Sample();
		}

		// Token: 0x0600E2FE RID: 58110 RVA: 0x00674575 File Offset: 0x00672775
		private void FPLHODJCJDO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MKNNLJJKIHC();
		}

		// Token: 0x0600E2FF RID: 58111 RVA: 0x00672EC9 File Offset: 0x006710C9
		private void OFGMIEJKMGC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MDFNFIJJICP();
		}

		// Token: 0x0600E300 RID: 58112 RVA: 0x00674589 File Offset: 0x00672789
		private void AFFAJKPPMHF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.EMLNKBKGDEF();
		}

		// Token: 0x0600E301 RID: 58113 RVA: 0x006745A0 File Offset: 0x006727A0
		private void JNBBPFALNFB()
		{
			if (this.weight <= 1507f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E302 RID: 58114 RVA: 0x00674708 File Offset: 0x00672908
		private void GEOHKEPJFCJ()
		{
			if (this.weight <= 1305f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E303 RID: 58115 RVA: 0x00674870 File Offset: 0x00672A70
		public void CHCPAPIPFJM()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x0067493D File Offset: 0x00672B3D
		private void DGEIACONKCJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.GFCIKAIMKEH();
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x00674954 File Offset: 0x00672B54
		private void NPDBHEONIDA()
		{
			if (this.weight <= 1100f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E306 RID: 58118 RVA: 0x0067493D File Offset: 0x00672B3D
		private void DDEBDCGNCPC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.GFCIKAIMKEH();
		}

		// Token: 0x0600E307 RID: 58119 RVA: 0x00674ABC File Offset: 0x00672CBC
		private void JDICIPNCLGJ()
		{
			if (this.weight <= 1049f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.rightFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E308 RID: 58120 RVA: 0x00674C24 File Offset: 0x00672E24
		private void JJMGNAMFJGJ()
		{
			if (this.weight <= 999f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.rightFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E309 RID: 58121 RVA: 0x00672C57 File Offset: 0x00670E57
		private void BFBBJILCKAK()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.IAHGFEGHCOG();
		}

		// Token: 0x0600E30A RID: 58122 RVA: 0x00674D89 File Offset: 0x00672F89
		private void IIKDDILLGLF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.CHOHDBEFLDP();
		}

		// Token: 0x0600E30B RID: 58123 RVA: 0x00674DA0 File Offset: 0x00672FA0
		private void CMDJHGMGLCG()
		{
			if (this.weight <= 911f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E30C RID: 58124 RVA: 0x00674F08 File Offset: 0x00673108
		public void FFOKPCLCMIL()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E30D RID: 58125 RVA: 0x00674FD8 File Offset: 0x006731D8
		private void BENCPPPLDIC()
		{
			if (this.weight <= 1036f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E30E RID: 58126 RVA: 0x00675140 File Offset: 0x00673340
		private void GKNGOOCGMED()
		{
			if (this.weight <= 1820f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.rightFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E30F RID: 58127 RVA: 0x006752A8 File Offset: 0x006734A8
		public void MLIMDNLPPKK()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E310 RID: 58128 RVA: 0x00675378 File Offset: 0x00673578
		public void BEKHOGLHGCH()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E311 RID: 58129 RVA: 0x00675445 File Offset: 0x00673645
		private void BHFMGBNIAMC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.OLCLABONCDJ();
		}

		// Token: 0x0600E312 RID: 58130 RVA: 0x0067545C File Offset: 0x0067365C
		private void IAJCKOGDIMM()
		{
			if (this.weight <= 1435f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E313 RID: 58131 RVA: 0x006738C9 File Offset: 0x00671AC9
		private void CGFDDFHECLJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.FFLLNBLMOKO();
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x006755C1 File Offset: 0x006737C1
		private void KJJNMNKPNCH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.BEKHOGLHGCH();
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x006755D8 File Offset: 0x006737D8
		private void GOAIDNCOCIB()
		{
			if (this.weight <= 1845f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E316 RID: 58134 RVA: 0x00675740 File Offset: 0x00673940
		private void IKEBNJAMNDB()
		{
			if (this.weight <= 995f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E317 RID: 58135 RVA: 0x006758A5 File Offset: 0x00673AA5
		private void LHMNFJBJBJM()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.KALAPOHOBBL();
		}

		// Token: 0x0600E318 RID: 58136 RVA: 0x006758BC File Offset: 0x00673ABC
		public void AHMCNIJOLLM()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E319 RID: 58137 RVA: 0x0067598C File Offset: 0x00673B8C
		private void IOJAKOAKEHD()
		{
			if (this.weight <= 173f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E31A RID: 58138 RVA: 0x00675AF1 File Offset: 0x00673CF1
		private void IJFPHGEFOLF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.CHCPAPIPFJM();
		}

		// Token: 0x0600E31B RID: 58139 RVA: 0x00675B08 File Offset: 0x00673D08
		public void EBFPFMEFBIA()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E31C RID: 58140 RVA: 0x00675BD5 File Offset: 0x00673DD5
		private void FECFLBMPAAL()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.AEKFMJDMPIC();
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x00675BEC File Offset: 0x00673DEC
		private void MJFJPFJICDH()
		{
			if (this.weight <= 1976f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E31E RID: 58142 RVA: 0x00675D54 File Offset: 0x00673F54
		private void EFDGMFCGKKA()
		{
			if (this.weight <= 877f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x00675445 File Offset: 0x00673645
		private void ACLJDJBJLCD()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.OLCLABONCDJ();
		}

		// Token: 0x0600E320 RID: 58144 RVA: 0x00675EBC File Offset: 0x006740BC
		public void NCMLADMAOPF()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.rightFootEffector.bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E321 RID: 58145 RVA: 0x00675F8C File Offset: 0x0067418C
		public void PGDJJHNIFNI()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation;
		}

		// Token: 0x0600E322 RID: 58146 RVA: 0x00675445 File Offset: 0x00673645
		private void EGDBNKCJOCD()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.OLCLABONCDJ();
		}

		// Token: 0x0600E323 RID: 58147 RVA: 0x0067605C File Offset: 0x0067425C
		public void JIJKMNDOIPH()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E325 RID: 58149 RVA: 0x00672DD1 File Offset: 0x00670FD1
		private void HEMEEOGJDOE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.ABNLDJDHGEI();
		}

		// Token: 0x0600E326 RID: 58150 RVA: 0x0067613C File Offset: 0x0067433C
		private void EMMMEIGNPCH()
		{
			if (this.weight <= 1704f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E327 RID: 58151 RVA: 0x006762A4 File Offset: 0x006744A4
		public void AEKFMJDMPIC()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E328 RID: 58152 RVA: 0x00676371 File Offset: 0x00674571
		private void KMMEMAHCFLJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MCIPOEKPENM();
		}

		// Token: 0x0600E329 RID: 58153 RVA: 0x00676388 File Offset: 0x00674588
		public void BGOJGMHILGH()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E32A RID: 58154 RVA: 0x00676455 File Offset: 0x00674655
		private void OPNPODKLOJK()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.JPIDHNCGGCH();
		}

		// Token: 0x0600E32B RID: 58155 RVA: 0x0067646C File Offset: 0x0067466C
		public void JPIDHNCGGCH()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E32C RID: 58156 RVA: 0x0067653C File Offset: 0x0067473C
		public void FFLLNBLMOKO()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E32D RID: 58157 RVA: 0x0067660C File Offset: 0x0067480C
		public void KALAPOHOBBL()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E32E RID: 58158 RVA: 0x00674575 File Offset: 0x00672775
		private void INDGOHJGCFN()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MKNNLJJKIHC();
		}

		// Token: 0x0600E32F RID: 58159 RVA: 0x006766DC File Offset: 0x006748DC
		private void CPINFJNCLMI()
		{
			if (this.weight <= 643f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E330 RID: 58160 RVA: 0x006738C9 File Offset: 0x00671AC9
		private void EFJDBBDMPMC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.FFLLNBLMOKO();
		}

		// Token: 0x0600E331 RID: 58161 RVA: 0x00676844 File Offset: 0x00674A44
		public void MDFNFIJJICP()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.rightFootEffector.bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E332 RID: 58162 RVA: 0x00676911 File Offset: 0x00674B11
		private void OBJCOJEHLBE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.JIJKMNDOIPH();
		}

		// Token: 0x0600E333 RID: 58163 RVA: 0x00676928 File Offset: 0x00674B28
		public void FCHGOIIKEAI()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation;
		}

		// Token: 0x0600E334 RID: 58164 RVA: 0x00674561 File Offset: 0x00672761
		private void EFCCCKGCOCB()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.Sample();
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x006769F8 File Offset: 0x00674BF8
		public void LDDHEAKEBFE()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E336 RID: 58166 RVA: 0x00676AC8 File Offset: 0x00674CC8
		private void APHJJJHNFNP()
		{
			if (this.weight <= 1840f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E337 RID: 58167 RVA: 0x00676C30 File Offset: 0x00674E30
		private void JIFIMFCJDHL()
		{
			if (this.weight <= 792f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E338 RID: 58168 RVA: 0x00676D98 File Offset: 0x00674F98
		public void BNJIHNNCCFB()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.rightFootEffector.bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x00676E68 File Offset: 0x00675068
		private void AOGONMIBGJK()
		{
			if (this.weight <= 1341f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E33A RID: 58170 RVA: 0x00676FD0 File Offset: 0x006751D0
		public void FOICHFCFIKL()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E33B RID: 58171 RVA: 0x006770A0 File Offset: 0x006752A0
		public void EJHHCJCLMAO()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E33C RID: 58172 RVA: 0x0067716D File Offset: 0x0067536D
		private void LHHKDNILMDI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.BGOJGMHILGH();
		}

		// Token: 0x0600E33D RID: 58173 RVA: 0x00677181 File Offset: 0x00675381
		private void GIADAJFBIOP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.JJHOOEIFKJD();
		}

		// Token: 0x0600E33E RID: 58174 RVA: 0x00677198 File Offset: 0x00675398
		private void LateUpdate()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.leftFootEffector.positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.rightFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E33F RID: 58175 RVA: 0x00677300 File Offset: 0x00675500
		private void OPKNGIJPOMB()
		{
			if (this.weight <= 1163f)
			{
				return;
			}
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionOffset = (base.transform.TransformPoint(this.KDJOLJEBPBM) - this.OJMBOCNNLMI.solver.leftFootEffector.bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionOffset = (base.transform.TransformPoint(this.HNEEHJCKFLL) - this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position) * this.weight;
			this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation, base.transform.rotation * this.NGKPPHBBHAO, this.weight);
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation = Quaternion.Lerp(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation, base.transform.rotation * this.LGFLIFBAMEN, this.weight);
		}

		// Token: 0x0600E340 RID: 58176 RVA: 0x00677468 File Offset: 0x00675668
		public void OLCLABONCDJ()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.rotation;
		}

		// Token: 0x0600E341 RID: 58177 RVA: 0x00677538 File Offset: 0x00675738
		public void MONKKHBNIKA()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation;
		}

		// Token: 0x0600E342 RID: 58178 RVA: 0x00677608 File Offset: 0x00675808
		public void DPEBLCIFOML()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation;
		}

		// Token: 0x0600E343 RID: 58179 RVA: 0x006776D8 File Offset: 0x006758D8
		public void HGJNOBLLJIF()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation;
		}

		// Token: 0x0600E344 RID: 58180 RVA: 0x006777A8 File Offset: 0x006759A8
		public void KLCBOFBJPIP()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E345 RID: 58181 RVA: 0x00677878 File Offset: 0x00675A78
		public void GFCIKAIMKEH()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E346 RID: 58182 RVA: 0x00677945 File Offset: 0x00675B45
		private void EHFPLKEINFO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.PBEMNDJOCPH();
		}

		// Token: 0x0600E347 RID: 58183 RVA: 0x00677959 File Offset: 0x00675B59
		private void ADLHNBEDHMJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.BNJIHNNCCFB();
		}

		// Token: 0x0600E348 RID: 58184 RVA: 0x00677970 File Offset: 0x00675B70
		public void IAHGFEGHCOG()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E349 RID: 58185 RVA: 0x006743E5 File Offset: 0x006725E5
		private void DNLFEOECBKI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.NCMLADMAOPF();
		}

		// Token: 0x0600E34A RID: 58186 RVA: 0x00674589 File Offset: 0x00672789
		private void JFFPLABGMNF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.EMLNKBKGDEF();
		}

		// Token: 0x0600E34B RID: 58187 RVA: 0x00677A3D File Offset: 0x00675C3D
		private void ECMAANIDEBA()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.CBIFCMOOJGM();
		}

		// Token: 0x0600E34C RID: 58188 RVA: 0x00674575 File Offset: 0x00672775
		private void LMEJKAEIDCO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.MKNNLJJKIHC();
		}

		// Token: 0x0600E34D RID: 58189 RVA: 0x00677A54 File Offset: 0x00675C54
		public void FDOIAALDEJL()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.rotation;
		}

		// Token: 0x0600E34E RID: 58190 RVA: 0x006755C1 File Offset: 0x006737C1
		private void FIJKDFIMELM()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.BEKHOGLHGCH();
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x00672EDD File Offset: 0x006710DD
		private void MKNPFMEMOJO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.LDDHEAKEBFE();
		}

		// Token: 0x0600E350 RID: 58192 RVA: 0x00677B24 File Offset: 0x00675D24
		public void MKNNLJJKIHC()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.rotation;
		}

		// Token: 0x0600E351 RID: 58193 RVA: 0x00677BF4 File Offset: 0x00675DF4
		public void GAOOHBPCPKC()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.rotation;
		}

		// Token: 0x0600E352 RID: 58194 RVA: 0x00677CC4 File Offset: 0x00675EC4
		public void EMLNKBKGDEF()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x0600E353 RID: 58195 RVA: 0x00677D94 File Offset: 0x00675F94
		public void JJHOOEIFKJD()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.rightFootEffector.bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.rotation;
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x00677A3D File Offset: 0x00675C3D
		private void FDBNPLCPFJB()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			this.CBIFCMOOJGM();
		}

		// Token: 0x0600E355 RID: 58197 RVA: 0x00677E64 File Offset: 0x00676064
		public void Sample()
		{
			this.KDJOLJEBPBM = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.leftFootEffector.bone.position);
			this.HNEEHJCKFLL = base.transform.InverseTransformPoint(this.OJMBOCNNLMI.solver.rightFootEffector.bone.position);
			this.NGKPPHBBHAO = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.leftFootEffector.bone.rotation;
			this.LGFLIFBAMEN = Quaternion.Inverse(base.transform.rotation) * this.OJMBOCNNLMI.solver.rightFootEffector.bone.rotation;
		}

		// Token: 0x04001DA9 RID: 7593
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04001DAA RID: 7594
		private FullBodyBipedIK OJMBOCNNLMI;

		// Token: 0x04001DAB RID: 7595
		private Vector3 KDJOLJEBPBM;

		// Token: 0x04001DAC RID: 7596
		private Vector3 HNEEHJCKFLL;

		// Token: 0x04001DAD RID: 7597
		private Quaternion NGKPPHBBHAO;

		// Token: 0x04001DAE RID: 7598
		private Quaternion LGFLIFBAMEN;
	}
}
