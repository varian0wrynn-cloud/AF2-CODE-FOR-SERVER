using System;
using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003E7 RID: 999
	public class MechSpiderLeg : MonoBehaviour
	{
		// Token: 0x0600D65A RID: 54874 RVA: 0x0061ECED File Offset: 0x0061CEED
		public bool JGBEJNHDCBE()
		{
			return this.KCEDHKGHAAJ < 1840f;
		}

		// Token: 0x0600D65B RID: 54875 RVA: 0x0061ECFC File Offset: 0x0061CEFC
		private void PLBDELOIINH()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1189f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.BDPODKFGGGI(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.CMGFFGKLANM();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.FKKGBEOLMDK() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D65C RID: 54876 RVA: 0x0061ED9C File Offset: 0x0061CF9C
		public bool KMOKMMMCPIB()
		{
			return this.KCEDHKGHAAJ < 731f;
		}

		// Token: 0x0600D65D RID: 54877 RVA: 0x0061EDAC File Offset: 0x0061CFAC
		private void BHFMGBNIAMC()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 417f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.KPPIFEPMGFC(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.ALOFFADGPGF();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.BIANIJPPAFL() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D65E RID: 54878 RVA: 0x0061EE4C File Offset: 0x0061D04C
		private void ALDMBECNFFO()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1482f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.EMFGFFILKBM(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.CGMNLHIEJPL();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.HKMKMMMNIJE() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D65F RID: 54879 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 ALOFFADGPGF()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D660 RID: 54880 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void FFEMPCJDJOG(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D661 RID: 54881 RVA: 0x0061EF14 File Offset: 0x0061D114
		private void GHCMIKGJPJD()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 122f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.FFEMPCJDJOG(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.BIANIJPPAFL();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.HKMKMMMNIJE() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D662 RID: 54882 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator NPKFFAECPCP(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D663 RID: 54883 RVA: 0x0061EFD1 File Offset: 0x0061D1D1
		public bool AIMDNAJPLGO()
		{
			return this.KCEDHKGHAAJ < 983f;
		}

		// Token: 0x0600D664 RID: 54884 RVA: 0x0061EFE0 File Offset: 0x0061D1E0
		private Vector3 ACDMMPCHJHK(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.DLJAKDEFMCD()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.BEABCEDCDKI();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D665 RID: 54885 RVA: 0x0061F110 File Offset: 0x0061D310
		private void KJJEEMEHGBF()
		{
			if (this.BMGOECFGCGB())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.DLNODGCCCNA())
			{
				return;
			}
			bool flag = false;
			Vector3 vector = this.PDGKDCGAKFE(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.ICNNJPIFDBJ(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 1650f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.LOKFOOEJNPP(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(211f, 1375f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.KKBNGDPDMBN(this.ECLFLGKPPAL(), vector));
		}

		// Token: 0x0600D666 RID: 54886 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 PFKECDKPDGI()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D667 RID: 54887 RVA: 0x0061F200 File Offset: 0x0061D400
		private void IMABGALEMBI()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 230f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MGALEAJOGPL = array[array.Length - 0].transform.position;
			this.CGAFKGPDBAD.point = this.KCMNECIDMOP();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.CGMNLHIEJPL() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D668 RID: 54888 RVA: 0x0061F2A0 File Offset: 0x0061D4A0
		private void LGPJEFMIIOL()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1603f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MAOGOEODEBN(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.ECLFLGKPPAL();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.ONHMMPDADBH() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D669 RID: 54889 RVA: 0x0061F340 File Offset: 0x0061D540
		private void Start()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MGALEAJOGPL = array[array.Length - 1].transform.position;
			this.CGAFKGPDBAD.point = this.MGALEAJOGPL;
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.MGALEAJOGPL + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x0061F3E0 File Offset: 0x0061D5E0
		public bool OMGNOAOBKKL()
		{
			return this.KCEDHKGHAAJ < 1098f;
		}

		// Token: 0x0600D66B RID: 54891 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 ECLFLGKPPAL()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x0061F3EF File Offset: 0x0061D5EF
		private IEnumerator LMKCFAIGEPE(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			MechSpiderLeg.JFNDIBLJGGA jfndibljgga = new MechSpiderLeg.JFNDIBLJGGA(1);
			jfndibljgga.AENJLLPLILM = this;
			jfndibljgga.MBHKOMJGNOF = MBHKOMJGNOF;
			jfndibljgga.AOBKCEEGJNC = AOBKCEEGJNC;
			return jfndibljgga;
		}

		// Token: 0x0600D66D RID: 54893 RVA: 0x0061F40C File Offset: 0x0061D60C
		private void MPLCAGFGEBO()
		{
			if (this.MOICDEHINCG())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.ECDKANEHAKI())
			{
				return;
			}
			bool flag = true;
			Vector3 vector = this.LKIMLAMFAKF(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.BHEDKJIOGOP(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 758f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.CMGFFGKLANM(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(1163f, 350f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.FHLPMBNANNH(this.LOKFOOEJNPP(), vector));
		}

		// Token: 0x0600D66E RID: 54894 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 FPHKHDENIAB()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D66F RID: 54895 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 KCMNECIDMOP()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D670 RID: 54896 RVA: 0x0061F4FC File Offset: 0x0061D6FC
		private void MEIOHFKFEME()
		{
			if (this.DHBMALOAHJC())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.BMGOECFGCGB())
			{
				return;
			}
			bool flag = true;
			Vector3 vector = this.IHEIBCAEOLD(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.PDGKDCGAKFE(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 1258f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.JNNMFKPKIEG(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(1911f, 1098f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.FHLPMBNANNH(this.HKMKMMMNIJE(), vector));
		}

		// Token: 0x0600D671 RID: 54897 RVA: 0x0061F5EC File Offset: 0x0061D7EC
		private void ABEIHJCDDCH()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1187f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.IEMHCMMMBHI(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.KJHEPLOICHH();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.DLJAKDEFMCD() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D672 RID: 54898 RVA: 0x0061F68C File Offset: 0x0061D88C
		public bool DDCIFNMFALE()
		{
			return this.KCEDHKGHAAJ < 1493f;
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator BCFJDHNFJJK(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D674 RID: 54900 RVA: 0x0061F69C File Offset: 0x0061D89C
		private void HABONMJNDAL()
		{
			if (this.OAJBIABJNEJ())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.DLNODGCCCNA())
			{
				return;
			}
			bool flag = false;
			Vector3 vector = this.DPEEAPHAIMC(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.EALKDFMABCG(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 1819f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.HKMKMMMNIJE(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(1210f, 1274f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.JBHIONAGPIO(this.IBJHECDILKA(), vector));
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x0061F78C File Offset: 0x0061D98C
		private void DIAIKCBANBK()
		{
			if (this.OAJBIABJNEJ())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.JLPCBMNFBCE())
			{
				return;
			}
			bool flag = false;
			Vector3 vector = this.BDHCFDPPECE(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.JHMCKFFHKEO(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 916f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.KJHEPLOICHH(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(42f, 711f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.GCDINHMKILH(this.CJPHBIMGIKI(), vector));
		}

		// Token: 0x0600D676 RID: 54902 RVA: 0x0061F87C File Offset: 0x0061DA7C
		private Vector3 BDHCFDPPECE(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.JNNMFKPKIEG()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.MGALEAJOGPL;
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D677 RID: 54903 RVA: 0x0061F9AC File Offset: 0x0061DBAC
		private Vector3 EPIMBLHMHIG(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.BEABCEDCDKI()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.IBJHECDILKA();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D678 RID: 54904 RVA: 0x0061FADC File Offset: 0x0061DCDC
		private Vector3 IHEIBCAEOLD(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.ONHMMPDADBH()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.CIPEIGOCIGE();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D679 RID: 54905 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator LMBFEKNHBLH(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D67A RID: 54906 RVA: 0x0061FC0C File Offset: 0x0061DE0C
		private void ELCNJDNCAEP()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1562f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MAOGOEODEBN(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.ECLFLGKPPAL();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.BIANIJPPAFL() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D67B RID: 54907 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void HKJKCHLONED(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D67C RID: 54908 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 ONHMMPDADBH()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D67D RID: 54909 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 JNNMFKPKIEG()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D67E RID: 54910 RVA: 0x0061FCAC File Offset: 0x0061DEAC
		public bool MOICDEHINCG()
		{
			return this.KCEDHKGHAAJ < 1189f;
		}

		// Token: 0x0600D67F RID: 54911 RVA: 0x0061FCBB File Offset: 0x0061DEBB
		public bool PFMDKAMCMFK()
		{
			return this.KCEDHKGHAAJ < 527f;
		}

		// Token: 0x0600D680 RID: 54912 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void MAOGOEODEBN(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D681 RID: 54913 RVA: 0x0061FCCC File Offset: 0x0061DECC
		private void INDGOHJGCFN()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1714f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.KPPIFEPMGFC(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.CIPEIGOCIGE();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.ONHMMPDADBH() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D683 RID: 54915 RVA: 0x0061FDCC File Offset: 0x0061DFCC
		private Vector3 LMDFJBNIFBE(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.ECLFLGKPPAL()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.ALOFFADGPGF();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x0061FEFC File Offset: 0x0061E0FC
		private void KDCOHILDJJO()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 254f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MAOGOEODEBN(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.CMGFFGKLANM();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.HKMKMMMNIJE() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D685 RID: 54917 RVA: 0x0061FF9C File Offset: 0x0061E19C
		private Vector3 CMPDHKMBCBA(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.HKMKMMMNIJE()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.ONHMMPDADBH();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D686 RID: 54918 RVA: 0x006200CC File Offset: 0x0061E2CC
		private Vector3 AGGBOEOBFDG(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.LGCILKHAECF()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.FKKGBEOLMDK();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D687 RID: 54919 RVA: 0x006201FC File Offset: 0x0061E3FC
		private Vector3 IGGPMBMJJKF(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.HKMKMMMNIJE()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.PFKECDKPDGI();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600D688 RID: 54920 RVA: 0x0062032B File Offset: 0x0061E52B
		public bool KNEOCLPMKHN
		{
			get
			{
				return this.KCEDHKGHAAJ < 1f;
			}
		}

		// Token: 0x0600D689 RID: 54921 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void KDNCHPJGHOE(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D68A RID: 54922 RVA: 0x0062033C File Offset: 0x0061E53C
		private Vector3 BIJCGNDNPHI(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.DLJAKDEFMCD()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.LGCILKHAECF();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D68B RID: 54923 RVA: 0x0062046B File Offset: 0x0061E66B
		public bool DGIIGNPEBPE()
		{
			return this.KCEDHKGHAAJ < 916f;
		}

		// Token: 0x0600D68C RID: 54924 RVA: 0x0062047C File Offset: 0x0061E67C
		private void EJOAPOGPBFM()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 659f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MPDLLPMJGGO(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.HKMKMMMNIJE();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.PFKECDKPDGI() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D68D RID: 54925 RVA: 0x0061F3EF File Offset: 0x0061D5EF
		private IEnumerator AGMNBOOMBDF(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			MechSpiderLeg.JFNDIBLJGGA jfndibljgga = new MechSpiderLeg.JFNDIBLJGGA(1);
			jfndibljgga.AENJLLPLILM = this;
			jfndibljgga.MBHKOMJGNOF = MBHKOMJGNOF;
			jfndibljgga.AOBKCEEGJNC = AOBKCEEGJNC;
			return jfndibljgga;
		}

		// Token: 0x0600D68E RID: 54926 RVA: 0x0062051C File Offset: 0x0061E71C
		public bool FHIGHIPLILE()
		{
			return this.KCEDHKGHAAJ < 1617f;
		}

		// Token: 0x0600D68F RID: 54927 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void MPDLLPMJGGO(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D690 RID: 54928 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void IEMHCMMMBHI(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D691 RID: 54929 RVA: 0x0062052C File Offset: 0x0061E72C
		private Vector3 ICNNJPIFDBJ(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.CJPHBIMGIKI()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.IBJHECDILKA();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D692 RID: 54930 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator EPIGKJKGDKB(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D693 RID: 54931 RVA: 0x0062065C File Offset: 0x0061E85C
		private void Update()
		{
			if (this.KNEOCLPMKHN)
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.KNEOCLPMKHN)
			{
				return;
			}
			bool flag = false;
			Vector3 vector = this.BNMOLDDGJBE(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.BNMOLDDGJBE(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 3f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.MGALEAJOGPL, vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(0.9f, 1.2f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.DLPHANGIHHE(this.MGALEAJOGPL, vector));
		}

		// Token: 0x0600D694 RID: 54932 RVA: 0x0062074C File Offset: 0x0061E94C
		private void IIKDDILLGLF()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1296f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MAOGOEODEBN(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.FKKGBEOLMDK();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.CMGFFGKLANM() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D695 RID: 54933 RVA: 0x006207EC File Offset: 0x0061E9EC
		private void DDEBDCGNCPC()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1855f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.FFEMPCJDJOG(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.ECLFLGKPPAL();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.ONHMMPDADBH() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D696 RID: 54934 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 CMGFFGKLANM()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D697 RID: 54935 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void MMKECPOINPI(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D698 RID: 54936 RVA: 0x0062088C File Offset: 0x0061EA8C
		public bool BIHIGADIBBL()
		{
			return this.KCEDHKGHAAJ < 1889f;
		}

		// Token: 0x0600D699 RID: 54937 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator LDJGPAJLLLO(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D69A RID: 54938 RVA: 0x0061F3EF File Offset: 0x0061D5EF
		private IEnumerator JBHIONAGPIO(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			MechSpiderLeg.JFNDIBLJGGA jfndibljgga = new MechSpiderLeg.JFNDIBLJGGA(1);
			jfndibljgga.AENJLLPLILM = this;
			jfndibljgga.MBHKOMJGNOF = MBHKOMJGNOF;
			jfndibljgga.AOBKCEEGJNC = AOBKCEEGJNC;
			return jfndibljgga;
		}

		// Token: 0x0600D69B RID: 54939 RVA: 0x0062089B File Offset: 0x0061EA9B
		public bool IOKDLLKDHPL()
		{
			return this.KCEDHKGHAAJ < 39f;
		}

		// Token: 0x0600D69C RID: 54940 RVA: 0x006208AA File Offset: 0x0061EAAA
		public bool OAJBIABJNEJ()
		{
			return this.KCEDHKGHAAJ < 1138f;
		}

		// Token: 0x0600D69D RID: 54941 RVA: 0x006208BC File Offset: 0x0061EABC
		private Vector3 EALKDFMABCG(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.FPHKHDENIAB()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.IBJHECDILKA();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600D69E RID: 54942 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		// (set) Token: 0x0600D69F RID: 54943 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public Vector3 MGALEAJOGPL
		{
			get
			{
				return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
			}
			set
			{
				this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(value);
			}
		}

		// Token: 0x0600D6A0 RID: 54944 RVA: 0x006209EB File Offset: 0x0061EBEB
		public bool LGHPBNDMPBL()
		{
			return this.KCEDHKGHAAJ < 1014f;
		}

		// Token: 0x0600D6A1 RID: 54945 RVA: 0x006209FA File Offset: 0x0061EBFA
		public bool DLNODGCCCNA()
		{
			return this.KCEDHKGHAAJ < 140f;
		}

		// Token: 0x0600D6A2 RID: 54946 RVA: 0x00620A0C File Offset: 0x0061EC0C
		private void EGDBNKCJOCD()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 729f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.IPHEDJPFDBA(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.FPHKHDENIAB();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.FKKGBEOLMDK() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6A3 RID: 54947 RVA: 0x00620AAC File Offset: 0x0061ECAC
		private void AFFAJKPPMHF()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1930f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.PCGGIBKDEGD(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.DLJAKDEFMCD();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.ECLFLGKPPAL() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6A4 RID: 54948 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 CGMNLHIEJPL()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 IBJHECDILKA()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x00620B4C File Offset: 0x0061ED4C
		private void AAEFACEGJMB()
		{
			if (this.CNENBCKBGPM())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.JGBEJNHDCBE())
			{
				return;
			}
			bool flag = false;
			Vector3 vector = this.BDHCFDPPECE(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.GCOGOEFBEDL(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 227f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.FKKGBEOLMDK(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(107f, 137f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.EIGOBKPIOGF(this.LGCILKHAECF(), vector));
		}

		// Token: 0x0600D6A7 RID: 54951 RVA: 0x00620C3A File Offset: 0x0061EE3A
		public bool BMGOECFGCGB()
		{
			return this.KCEDHKGHAAJ < 218f;
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x0061F3EF File Offset: 0x0061D5EF
		private IEnumerator EIGOBKPIOGF(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			MechSpiderLeg.JFNDIBLJGGA jfndibljgga = new MechSpiderLeg.JFNDIBLJGGA(1);
			jfndibljgga.AENJLLPLILM = this;
			jfndibljgga.MBHKOMJGNOF = MBHKOMJGNOF;
			jfndibljgga.AOBKCEEGJNC = AOBKCEEGJNC;
			return jfndibljgga;
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x00620C4C File Offset: 0x0061EE4C
		private void LDDIGEMBDNF()
		{
			if (this.LGHPBNDMPBL())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.AAGHJCCAPKJ())
			{
				return;
			}
			bool flag = false;
			Vector3 vector = this.JHMCKFFHKEO(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.BNMOLDDGJBE(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 213f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.ECLFLGKPPAL(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(1113f, 392f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.LOFDDHDLDEM(this.JNNMFKPKIEG(), vector));
		}

		// Token: 0x0600D6AA RID: 54954 RVA: 0x00620D3C File Offset: 0x0061EF3C
		private void DPPAAIJCFLC()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 608f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.IEMHCMMMBHI(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.CJPHBIMGIKI();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.ALOFFADGPGF() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6AB RID: 54955 RVA: 0x00620DDC File Offset: 0x0061EFDC
		private void ACEODGIJKFH()
		{
			if (this.IPLNANNJJMI())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.BIHIGADIBBL())
			{
				return;
			}
			bool flag = true;
			Vector3 vector = this.AGGBOEOBFDG(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.BHEDKJIOGOP(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 94f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.LGCILKHAECF(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(284f, 1658f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.BHNPKIAGDDN(this.IBJHECDILKA(), vector));
		}

		// Token: 0x0600D6AC RID: 54956 RVA: 0x00620ECC File Offset: 0x0061F0CC
		private Vector3 GCOGOEFBEDL(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.CJPHBIMGIKI()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.BEABCEDCDKI();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6AD RID: 54957 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 CJPHBIMGIKI()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6AE RID: 54958 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 BEABCEDCDKI()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6AF RID: 54959 RVA: 0x00620FFC File Offset: 0x0061F1FC
		private Vector3 CAHGKMFOEMB(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.DLJAKDEFMCD()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.CGMNLHIEJPL();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6B0 RID: 54960 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator IBIFHNMJIIM(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6B1 RID: 54961 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator BHNPKIAGDDN(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6B2 RID: 54962 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void KPPIFEPMGFC(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6B3 RID: 54963 RVA: 0x0062112B File Offset: 0x0061F32B
		public bool ECDKANEHAKI()
		{
			return this.KCEDHKGHAAJ < 877f;
		}

		// Token: 0x0600D6B4 RID: 54964 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator DLPHANGIHHE(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6B5 RID: 54965 RVA: 0x0062113C File Offset: 0x0061F33C
		private Vector3 DPEEAPHAIMC(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.CIPEIGOCIGE()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.ECLFLGKPPAL();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6B6 RID: 54966 RVA: 0x0062126B File Offset: 0x0061F46B
		public bool GKLDMFGOBKP()
		{
			return this.KCEDHKGHAAJ < 1928f;
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator GCDINHMKILH(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6B8 RID: 54968 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void BDPODKFGGGI(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6B9 RID: 54969 RVA: 0x0062127C File Offset: 0x0061F47C
		private void HHGGCBLOJGB()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1051f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.MMKECPOINPI(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.FPHKHDENIAB();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.JNNMFKPKIEG() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6BA RID: 54970 RVA: 0x0062131C File Offset: 0x0061F51C
		private Vector3 LKIMLAMFAKF(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.ECLFLGKPPAL()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.MGALEAJOGPL;
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6BB RID: 54971 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 FKKGBEOLMDK()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6BC RID: 54972 RVA: 0x0062144B File Offset: 0x0061F64B
		public bool CGKPPFPNAAF()
		{
			return this.KCEDHKGHAAJ < 1291f;
		}

		// Token: 0x0600D6BD RID: 54973 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void IPHEDJPFDBA(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6BE RID: 54974 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator HMIIBDKCDAC(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6BF RID: 54975 RVA: 0x0062145C File Offset: 0x0061F65C
		private Vector3 BHEDKJIOGOP(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.ECLFLGKPPAL()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.ECLFLGKPPAL();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6C0 RID: 54976 RVA: 0x0062158B File Offset: 0x0061F78B
		public bool DHBMALOAHJC()
		{
			return this.KCEDHKGHAAJ < 589f;
		}

		// Token: 0x0600D6C1 RID: 54977 RVA: 0x0062159C File Offset: 0x0061F79C
		private void PFNPOHMMJDN()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 761f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.BDLNJBEGMAB(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.KJHEPLOICHH();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.ABDELKLHJHF() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6C2 RID: 54978 RVA: 0x0062163C File Offset: 0x0061F83C
		public bool EFIOGKLFKMJ()
		{
			return this.KCEDHKGHAAJ < 542f;
		}

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x0062164C File Offset: 0x0061F84C
		private Vector3 OONAFHKBAOJ(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.CGMNLHIEJPL()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.LGCILKHAECF();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 KJHEPLOICHH()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6C5 RID: 54981 RVA: 0x0062177C File Offset: 0x0061F97C
		private void KFNOEOIIBOI()
		{
			if (this.DDCIFNMFALE())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.JLPCBMNFBCE())
			{
				return;
			}
			bool flag = false;
			Vector3 vector = this.ACDMMPCHJHK(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.ICNNJPIFDBJ(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 1813f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.LOKFOOEJNPP(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(1710f, 42f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.FHLPMBNANNH(this.ONHMMPDADBH(), vector));
		}

		// Token: 0x0600D6C6 RID: 54982 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator KKBNGDPDMBN(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6C7 RID: 54983 RVA: 0x0062186A File Offset: 0x0061FA6A
		public bool PCMIMJNLJAG()
		{
			return this.KCEDHKGHAAJ < 1900f;
		}

		// Token: 0x0600D6C8 RID: 54984 RVA: 0x0062187C File Offset: 0x0061FA7C
		private Vector3 BNMOLDDGJBE(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.MGALEAJOGPL) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.MGALEAJOGPL;
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 BIANIJPPAFL()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x006219AB File Offset: 0x0061FBAB
		public bool JJAMEAFBKJK()
		{
			return this.KCEDHKGHAAJ < 1459f;
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x006219BA File Offset: 0x0061FBBA
		public bool DOEHFCNANML()
		{
			return this.KCEDHKGHAAJ < 433f;
		}

		// Token: 0x0600D6CC RID: 54988 RVA: 0x006219CC File Offset: 0x0061FBCC
		private Vector3 ONGKAOALHEH(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.DLJAKDEFMCD()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.CIPEIGOCIGE();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6CD RID: 54989 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 DLJAKDEFMCD()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6CE RID: 54990 RVA: 0x00621AFC File Offset: 0x0061FCFC
		private void LHHKDNILMDI()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1824f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.FJDBKFOLMDO(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.KJHEPLOICHH();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.LOKFOOEJNPP() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x00621B9C File Offset: 0x0061FD9C
		public bool CNENBCKBGPM()
		{
			return this.KCEDHKGHAAJ < 721f;
		}

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 LGCILKHAECF()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x00621BAC File Offset: 0x0061FDAC
		private Vector3 PDGKDCGAKFE(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.ECLFLGKPPAL()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.ABDELKLHJHF();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x00621CDC File Offset: 0x0061FEDC
		private void OPDCJCFMIPE()
		{
			if (this.ECDKANEHAKI())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.DLNODGCCCNA())
			{
				return;
			}
			bool flag = true;
			Vector3 vector = this.PDGKDCGAKFE(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.OONAFHKBAOJ(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 551f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.CMGFFGKLANM(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(762f, 1699f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.NPKFFAECPCP(this.FKKGBEOLMDK(), vector));
		}

		// Token: 0x0600D6D3 RID: 54995 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator LOFDDHDLDEM(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6D4 RID: 54996 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 LOKFOOEJNPP()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 ABDELKLHJHF()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void EMFGFFILKBM(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x0061F3EF File Offset: 0x0061D5EF
		private IEnumerator FHLPMBNANNH(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			MechSpiderLeg.JFNDIBLJGGA jfndibljgga = new MechSpiderLeg.JFNDIBLJGGA(1);
			jfndibljgga.AENJLLPLILM = this;
			jfndibljgga.MBHKOMJGNOF = MBHKOMJGNOF;
			jfndibljgga.AOBKCEEGJNC = AOBKCEEGJNC;
			return jfndibljgga;
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void PCGGIBKDEGD(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6D9 RID: 55001 RVA: 0x00621DCC File Offset: 0x0061FFCC
		private void OHMDFPHPFMB()
		{
			if (this.JLPCBMNFBCE())
			{
				return;
			}
			if (Time.time < this.KJGPJGJFPLN + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.CGKPPFPNAAF())
			{
				return;
			}
			bool flag = true;
			Vector3 vector = this.EALKDFMABCG(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				vector = this.BIJCGNDNPHI(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 1543f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.DLJAKDEFMCD(), vector) < this.maxOffset * this.mechSpider.scale * UnityEngine.Random.Range(1708f, 1004f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.DLPHANGIHHE(this.LGCILKHAECF(), vector));
		}

		// Token: 0x0600D6DA RID: 55002 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 CIPEIGOCIGE()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6DB RID: 55003 RVA: 0x00621EBA File Offset: 0x006200BA
		public bool JLPCBMNFBCE()
		{
			return this.KCEDHKGHAAJ < 437f;
		}

		// Token: 0x0600D6DC RID: 55004 RVA: 0x00621ECC File Offset: 0x006200CC
		private void LMEJKAEIDCO()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1454f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.BDPODKFGGGI(array[array.Length - 1].transform.position);
			this.CGAFKGPDBAD.point = this.FKKGBEOLMDK();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.KCMNECIDMOP() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6DD RID: 55005 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void KNJJAHKCNDJ(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6DE RID: 55006 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void FJDBKFOLMDO(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x0061EFB4 File Offset: 0x0061D1B4
		private IEnumerator FKJECGFGBIA(Vector3 MBHKOMJGNOF, Vector3 AOBKCEEGJNC)
		{
			this.KCEDHKGHAAJ = 0f;
			while (this.KCEDHKGHAAJ < 1f)
			{
				this.KCEDHKGHAAJ += Time.deltaTime * this.stepSpeed;
				this.MGALEAJOGPL = Vector3.Lerp(MBHKOMJGNOF, AOBKCEEGJNC, this.KCEDHKGHAAJ);
				this.MGALEAJOGPL += this.mechSpider.transform.up * this.yOffset.Evaluate(this.KCEDHKGHAAJ) * this.mechSpider.scale;
				yield return null;
			}
			this.MGALEAJOGPL = AOBKCEEGJNC;
			if (this.sand != null)
			{
				this.sand.transform.position = this.MGALEAJOGPL - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.KJGPJGJFPLN = Time.time;
			yield break;
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x00621F6C File Offset: 0x0062016C
		private void IBPGMFNDPHH()
		{
			this.OJMBOCNNLMI = base.GetComponent<IK>();
			this.KCEDHKGHAAJ = 1155f;
			this.CGAFKGPDBAD = default(RaycastHit);
			IKSolver.Point[] array = this.OJMBOCNNLMI.GetIKSolver().DJOBICJNHOD();
			this.PCGGIBKDEGD(array[array.Length - 0].transform.position);
			this.CGAFKGPDBAD.point = this.CMGFFGKLANM();
			this.GIIKIGDLJGB = this.mechSpider.transform.InverseTransformPoint(this.KJHEPLOICHH() + this.offset * this.mechSpider.scale);
		}

		// Token: 0x0600D6E1 RID: 55009 RVA: 0x0062200C File Offset: 0x0062020C
		private Vector3 JHMCKFFHKEO(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.DLJAKDEFMCD()) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.ABDELKLHJHF();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = true;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6E2 RID: 55010 RVA: 0x0062213C File Offset: 0x0062033C
		private Vector3 ONBHIBFMKHH(out bool JIGKBKNGPJI, float FGGHEONKKMP, float DKIHDOELFEH)
		{
			JIGKBKNGPJI = true;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.GIIKIGDLJGB) + (this.CGAFKGPDBAD.point - this.MGALEAJOGPL) * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.LOKFOOEJNPP();
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(FGGHEONKKMP, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.CGAFKGPDBAD, this.mechSpider.raycastHeight * this.mechSpider.scale + DKIHDOELFEH, this.mechSpider.raycastLayers))
			{
				JIGKBKNGPJI = false;
			}
			return this.CGAFKGPDBAD.point + this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x0061EEEC File Offset: 0x0061D0EC
		public Vector3 HKMKMMMNIJE()
		{
			return this.OJMBOCNNLMI.GetIKSolver().AEPMIDGGBAP();
		}

		// Token: 0x0600D6E4 RID: 55012 RVA: 0x0062226B File Offset: 0x0062046B
		public bool AAGHJCCAPKJ()
		{
			return this.KCEDHKGHAAJ < 1094f;
		}

		// Token: 0x0600D6E5 RID: 55013 RVA: 0x0061EEFE File Offset: 0x0061D0FE
		public void BDLNJBEGMAB(Vector3 DCCPCBLODIG)
		{
			this.OJMBOCNNLMI.GetIKSolver().HJHGGGEMEBJ(DCCPCBLODIG);
		}

		// Token: 0x0600D6E6 RID: 55014 RVA: 0x0062227A File Offset: 0x0062047A
		public bool IPLNANNJJMI()
		{
			return this.KCEDHKGHAAJ < 86f;
		}

		// Token: 0x04001C87 RID: 7303
		public MechSpider mechSpider;

		// Token: 0x04001C88 RID: 7304
		public MechSpiderLeg unSync;

		// Token: 0x04001C89 RID: 7305
		public Vector3 offset;

		// Token: 0x04001C8A RID: 7306
		public float minDelay = 0.2f;

		// Token: 0x04001C8B RID: 7307
		public float maxOffset = 1f;

		// Token: 0x04001C8C RID: 7308
		public float stepSpeed = 5f;

		// Token: 0x04001C8D RID: 7309
		public float footHeight = 0.15f;

		// Token: 0x04001C8E RID: 7310
		public float velocityPrediction = 0.2f;

		// Token: 0x04001C8F RID: 7311
		public float raycastFocus = 0.1f;

		// Token: 0x04001C90 RID: 7312
		public AnimationCurve yOffset;

		// Token: 0x04001C91 RID: 7313
		public ParticleSystem sand;

		// Token: 0x04001C92 RID: 7314
		private IK OJMBOCNNLMI;

		// Token: 0x04001C93 RID: 7315
		private float KCEDHKGHAAJ = 1f;

		// Token: 0x04001C94 RID: 7316
		private float KJGPJGJFPLN;

		// Token: 0x04001C95 RID: 7317
		private Vector3 GIIKIGDLJGB;

		// Token: 0x04001C96 RID: 7318
		private RaycastHit CGAFKGPDBAD;
	}
}
