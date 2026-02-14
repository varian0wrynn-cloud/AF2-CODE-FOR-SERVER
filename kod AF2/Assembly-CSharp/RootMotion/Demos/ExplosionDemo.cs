using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F2 RID: 1010
	public class ExplosionDemo : MonoBehaviour
	{
		// Token: 0x0600D929 RID: 55593 RVA: 0x00636E60 File Offset: 0x00635060
		private void DKAMODCBBGE(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.leftFootEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D92A RID: 55594 RVA: 0x00636EC8 File Offset: 0x006350C8
		private void JLFBDOPFDDJ()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 962f, 586f);
			if (Input.GetKeyDown((KeyCode)(-37)) && this.character.CMDCIOFMHLN())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 477f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position;
				this.OJMBOCNNLMI.solver.rightFootEffector.position = this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position;
				this.NKHBAJKMAGD = 806f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1521f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 282f && this.character.MPGNPAEGAJC())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1971f, 1493f, 473f);
			}
			this.JJDHLDINNPJ(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D92B RID: 55595 RVA: 0x006370E7 File Offset: 0x006352E7
		private void PBMPJPIMJBF()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D92C RID: 55596 RVA: 0x0063711C File Offset: 0x0063531C
		private void PFPPDNHLCCA()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 635f, 864f);
			if (Input.GetKeyDown(KeyCode.R) && this.character.KAKOOHBEIJG())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 540f;
				this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position;
				this.NKHBAJKMAGD = 1609f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1386f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 743f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 739f, 682f, 641f);
			}
			this.OEOOBANFJNB(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D92D RID: 55597 RVA: 0x0063733C File Offset: 0x0063553C
		private void JIKGIJEHGAP()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1892f, 736f);
			if (Input.GetKeyDown((KeyCode)(-75)) && this.character.CCJDMNAHMHF())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 212f;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.MJOPIBNHGIK().position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().position = this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position;
				this.NKHBAJKMAGD = 1981f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 168f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1583f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 824f, 1069f, 1154f);
			}
			this.CHJOFDNCIKN(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D92E RID: 55598 RVA: 0x0063755C File Offset: 0x0063575C
		private void AKLFCMNCPKL()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1712f, 1936f);
			if (Input.GetKeyDown(KeyCode.Less) && this.character.MPGNPAEGAJC())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 138f;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.IAGDDAJGGGE().position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position;
				this.NKHBAJKMAGD = 1724f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1549f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 940f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 580f, 817f, 1662f);
			}
			this.OEOOBANFJNB(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D92F RID: 55599 RVA: 0x0063777C File Offset: 0x0063597C
		private void LOJBPKECGOO(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D930 RID: 55600 RVA: 0x006370E7 File Offset: 0x006352E7
		private void AFFAJKPPMHF()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D931 RID: 55601 RVA: 0x006377E4 File Offset: 0x006359E4
		private void MEFOGCFJBNE()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1089f, 1292f);
			if (Input.GetKeyDown((KeyCode)(-92)) && this.character.MDAGKCBONHC())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 973f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.EAIGBIHMAGB().position = this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position;
				this.NKHBAJKMAGD = 243f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 837f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1400f && this.character.CMDCIOFMHLN())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 64f, 1001f, 1164f);
			}
			this.CHJOFDNCIKN(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D932 RID: 55602 RVA: 0x006370E7 File Offset: 0x006352E7
		private void INDGOHJGCFN()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D933 RID: 55603 RVA: 0x00637A04 File Offset: 0x00635C04
		private void JJDHLDINNPJ(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D934 RID: 55604 RVA: 0x00637A6C File Offset: 0x00635C6C
		private void JFGGBEGNAFP()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 387f, 811f);
			if (Input.GetKeyDown(KeyCode.Asterisk) && this.character.KAKOOHBEIJG())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 242f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.IAGDDAJGGGE().position = this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position;
				this.NKHBAJKMAGD = 364f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1088f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1709f && this.character.FBNGDMCBGIE())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1648f, 1977f, 1331f);
			}
			this.PDPPKBCICOO(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D935 RID: 55605 RVA: 0x006370E7 File Offset: 0x006352E7
		private void CBLGFOFHNPJ()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D936 RID: 55606 RVA: 0x006370E7 File Offset: 0x006352E7
		private void ANHOOJFEJJE()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D937 RID: 55607 RVA: 0x00637C8C File Offset: 0x00635E8C
		private void PJHEGHHOJHJ()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1763f, 404f);
			if (Input.GetKeyDown((KeyCode)(-82)) && this.character.AOEPFPLJFCG())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 160f;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.IAGDDAJGGGE().position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position;
				this.NKHBAJKMAGD = 566f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 341f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1463f && this.character.FBNGDMCBGIE())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1520f, 1703f, 1064f);
			}
			this.OEOOBANFJNB(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D938 RID: 55608 RVA: 0x00637EAC File Offset: 0x006360AC
		private void OHKHOAKCENL()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1868f, 670f);
			if (Input.GetKeyDown((KeyCode)(-48)) && this.character.FBNGDMCBGIE())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 435f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.EAIGBIHMAGB().position = this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position;
				this.NKHBAJKMAGD = 1050f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1936f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1526f && this.character.KAKOOHBEIJG())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1388f, 1624f, 1480f);
			}
			this.CAPDJKNPGFJ(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D939 RID: 55609 RVA: 0x006380CC File Offset: 0x006362CC
		private void PNDPEHGLAMA(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D93A RID: 55610 RVA: 0x00638134 File Offset: 0x00636334
		private void IIONMMCIKGA(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D93B RID: 55611 RVA: 0x006370E7 File Offset: 0x006352E7
		private void AOCDDBNBADJ()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D93C RID: 55612 RVA: 0x0063819C File Offset: 0x0063639C
		private void DPGECEOMHNM()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 932f, 351f);
			if (Input.GetKeyDown((KeyCode)(-127)) && this.character.MPGNPAEGAJC())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 899f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position;
				this.NKHBAJKMAGD = 211f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1782f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1577f && this.character.KAKOOHBEIJG())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1829f, 1548f, 1643f);
			}
			this.CHJOFDNCIKN(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D93D RID: 55613 RVA: 0x006370E7 File Offset: 0x006352E7
		private void EDGALMCHPPH()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x006383BC File Offset: 0x006365BC
		private void MEJCNCMJKEK(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x006370E7 File Offset: 0x006352E7
		private void CGNGBFFGGBP()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D940 RID: 55616 RVA: 0x006370E7 File Offset: 0x006352E7
		private void HDFCIACDDEK()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D941 RID: 55617 RVA: 0x006370E7 File Offset: 0x006352E7
		private void MODJFGGIAHD()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D942 RID: 55618 RVA: 0x006370E7 File Offset: 0x006352E7
		private void KIEIPFFEDHC()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D943 RID: 55619 RVA: 0x006370E7 File Offset: 0x006352E7
		private void FEBIICIMLHA()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D944 RID: 55620 RVA: 0x00638424 File Offset: 0x00636624
		private void PNBGJBMJLFM()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1981f, 437f);
			if (Input.GetKeyDown((KeyCode)(-25)) && this.character.KAKOOHBEIJG())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 700f;
				this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.leftHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.ANFNMIKKLOM().position = this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position;
				this.NKHBAJKMAGD = 934f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1948f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 105f && this.character.CCJDMNAHMHF())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1417f, 15f, 278f);
			}
			this.IDFEBFOBGHP(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D945 RID: 55621 RVA: 0x00638644 File Offset: 0x00636844
		private void MPLCAGFGEBO()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 408f, 1918f);
			if (Input.GetKeyDown(KeyCode.Semicolon) && this.character.NMPDKHCEDKP)
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1200f;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.IAGDDAJGGGE().position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.ANGCEEAGHCB().position = this.OJMBOCNNLMI.solver.rightFootEffector.bone.position;
				this.NKHBAJKMAGD = 1413f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 28f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1146f && this.character.KAKOOHBEIJG())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1559f, 1696f, 876f);
			}
			this.JJDHLDINNPJ(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D946 RID: 55622 RVA: 0x00638864 File Offset: 0x00636A64
		private void CAPDJKNPGFJ(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D947 RID: 55623 RVA: 0x006370E7 File Offset: 0x006352E7
		private void KJJNMNKPNCH()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D948 RID: 55624 RVA: 0x006388CC File Offset: 0x00636ACC
		private void OEOOBANFJNB(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D949 RID: 55625 RVA: 0x006370E7 File Offset: 0x006352E7
		private void JPHBPEAMNHB()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D94A RID: 55626 RVA: 0x00638934 File Offset: 0x00636B34
		private void CHJOFDNCIKN(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x0063899C File Offset: 0x00636B9C
		private void HAIMGCDKPDC()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1595f, 595f);
			if (Input.GetKeyDown((KeyCode)29) && this.character.MDAGKCBONHC())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1527f;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.IAGDDAJGGGE().position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position;
				this.NKHBAJKMAGD = 720f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1097f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 432f && this.character.CCJDMNAHMHF())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 296f, 1098f, 1999f);
			}
			this.IIONMMCIKGA(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D94C RID: 55628 RVA: 0x00638BBC File Offset: 0x00636DBC
		private void IDFEBFOBGHP(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D94D RID: 55629 RVA: 0x00638C24 File Offset: 0x00636E24
		private void PDPPKBCICOO(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D94E RID: 55630 RVA: 0x00638C8C File Offset: 0x00636E8C
		private void IGEICBNMPAD()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 271f, 1730f);
			if (Input.GetKeyDown((KeyCode)(-32)) && this.character.CCJDMNAHMHF())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 535f;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position;
				this.OJMBOCNNLMI.solver.ANFNMIKKLOM().position = this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position;
				this.NKHBAJKMAGD = 1598f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 932f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1799f && this.character.CMDCIOFMHLN())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1697f, 1686f, 1741f);
			}
			this.JJDHLDINNPJ(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D950 RID: 55632 RVA: 0x00638EE0 File Offset: 0x006370E0
		private void KBMKHLDOIKP()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 208f, 1974f);
			if (Input.GetKeyDown((KeyCode)(-22)) && this.character.NMPDKHCEDKP)
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1114f;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.MJOPIBNHGIK().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.EAIGBIHMAGB().position = this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position;
				this.NKHBAJKMAGD = 456f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 83f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 200f && this.character.AOEPFPLJFCG())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1118f, 640f, 193f);
			}
			this.IDFEBFOBGHP(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D951 RID: 55633 RVA: 0x00639100 File Offset: 0x00637300
		private void IKHCCAANGOP()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 15f, 319f);
			if (Input.GetKeyDown((KeyCode)(-126)) && this.character.CCJDMNAHMHF())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1643f;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position;
				this.OJMBOCNNLMI.solver.rightFootEffector.position = this.OJMBOCNNLMI.solver.JIHGEPGJDEC().bone.position;
				this.NKHBAJKMAGD = 291f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1872f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 454f && this.character.CMDCIOFMHLN())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 619f, 978f, 1893f);
			}
			this.PNDPEHGLAMA(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D952 RID: 55634 RVA: 0x006370E7 File Offset: 0x006352E7
		private void CKGPEFOKKNL()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D953 RID: 55635 RVA: 0x006370E7 File Offset: 0x006352E7
		private void IJOCHELLKJH()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D954 RID: 55636 RVA: 0x006370E7 File Offset: 0x006352E7
		private void Start()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D955 RID: 55637 RVA: 0x00639320 File Offset: 0x00637520
		private void JBKEJACLBIC(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D956 RID: 55638 RVA: 0x00639388 File Offset: 0x00637588
		private void LMGBKHCHPHO()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1596f, 1252f);
			if (Input.GetKeyDown(KeyCode.E) && this.character.MDAGKCBONHC())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 150f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position;
				this.OJMBOCNNLMI.solver.rightFootEffector.position = this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position;
				this.NKHBAJKMAGD = 1874f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1895f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1744f && this.character.CMDCIOFMHLN())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 579f, 486f, 1417f);
			}
			this.LOJBPKECGOO(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D957 RID: 55639 RVA: 0x006395A8 File Offset: 0x006377A8
		private void GLJLDLFEMLB(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D958 RID: 55640 RVA: 0x00639610 File Offset: 0x00637810
		private void PMGMELJJAKG(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.leftFootEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D959 RID: 55641 RVA: 0x00639678 File Offset: 0x00637878
		private void LBOONMDONCF()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1455f, 413f);
			if (Input.GetKeyDown(KeyCode.W) && this.character.CMDCIOFMHLN())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1310f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.position;
				this.OJMBOCNNLMI.solver.MJOPIBNHGIK().position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.EAIGBIHMAGB().bone.position;
				this.NKHBAJKMAGD = 1016f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 675f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1762f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1063f, 561f, 1501f);
			}
			this.IIONMMCIKGA(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D95A RID: 55642 RVA: 0x00639898 File Offset: 0x00637A98
		private void GCNGEFBKMNC()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 856f, 1888f);
			if (Input.GetKeyDown(KeyCode.Z) && this.character.MPGNPAEGAJC())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1184f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.JIHGEPGJDEC().position = this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position;
				this.NKHBAJKMAGD = 823f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 583f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1629f && this.character.AOEPFPLJFCG())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1581f, 140f, 747f);
			}
			this.POLKEHHPOCF(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D95B RID: 55643 RVA: 0x006370E7 File Offset: 0x006352E7
		private void JFFPLABGMNF()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D95C RID: 55644 RVA: 0x00639AB8 File Offset: 0x00637CB8
		private void POLKEHHPOCF(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D95D RID: 55645 RVA: 0x006370E7 File Offset: 0x006352E7
		private void MMACLBBMDLA()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D95E RID: 55646 RVA: 0x00639B20 File Offset: 0x00637D20
		private void KJJEEMEHGBF()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 283f, 1814f);
			if (Input.GetKeyDown((KeyCode)26) && this.character.AOEPFPLJFCG())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1780f;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.OJMBOCNNLMI.solver.leftHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.IAGDDAJGGGE().position = this.OJMBOCNNLMI.solver.JHKNHMMGKCG().bone.position;
				this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().position = this.OJMBOCNNLMI.solver.ANFNMIKKLOM().bone.position;
				this.NKHBAJKMAGD = 1899f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1445f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1920f && this.character.CMDCIOFMHLN())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1452f, 432f, 1295f);
			}
			this.PMGMELJJAKG(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D95F RID: 55647 RVA: 0x006370E7 File Offset: 0x006352E7
		private void PNJHMJNFPLP()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D960 RID: 55648 RVA: 0x00639D40 File Offset: 0x00637F40
		private void JOHDLNOKCOK()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1413f, 1667f);
			if (Input.GetKeyDown((KeyCode)(-41)) && this.character.CMDCIOFMHLN())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1062f;
				this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.position;
				this.OJMBOCNNLMI.solver.MJOPIBNHGIK().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().position = this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position;
				this.NKHBAJKMAGD = 480f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1396f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1251f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 544f, 969f, 1737f);
			}
			this.PMGMELJJAKG(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D961 RID: 55649 RVA: 0x00639F60 File Offset: 0x00638160
		private void LBGKAMLLACN()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 117f, 303f);
			if (Input.GetKeyDown((KeyCode)80) && this.character.FBNGDMCBGIE())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 705f;
				this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.position;
				this.OJMBOCNNLMI.solver.MJOPIBNHGIK().position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.JHKNHMMGKCG().position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.ANGCEEAGHCB().position = this.OJMBOCNNLMI.solver.ANGCEEAGHCB().bone.position;
				this.NKHBAJKMAGD = 66f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1013f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 461f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 283f, 1882f, 1857f);
			}
			this.LOJBPKECGOO(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D962 RID: 55650 RVA: 0x0063A180 File Offset: 0x00638380
		private void NIKEJBEIBOB(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.leftFootEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.ANFNMIKKLOM().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D963 RID: 55651 RVA: 0x0063A1E8 File Offset: 0x006383E8
		private void Update()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 0f, 1f);
			if (Input.GetKeyDown(KeyCode.E) && this.character.NMPDKHCEDKP)
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1f;
				this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.leftHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.rightFootEffector.position = this.OJMBOCNNLMI.solver.rightFootEffector.bone.position;
				this.NKHBAJKMAGD = 1f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 0f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 0.5f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 3f, 0f, 1f);
			}
			this.LFOKJAKFGEK(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D964 RID: 55652 RVA: 0x0063A408 File Offset: 0x00638608
		private void DFFOEGHGPGP()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1687f, 1818f);
			if (Input.GetKeyDown((KeyCode)(-83)) && this.character.CCJDMNAHMHF())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 845f;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.leftFootEffector.bone.position;
				this.OJMBOCNNLMI.solver.ANFNMIKKLOM().position = this.OJMBOCNNLMI.solver.rightFootEffector.bone.position;
				this.NKHBAJKMAGD = 199f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1295f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1151f && this.character.FBNGDMCBGIE())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 1693f, 1492f, 595f);
			}
			this.HIKLPJHJMMH(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x0063A628 File Offset: 0x00638828
		private void HIKLPJHJMMH(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D966 RID: 55654 RVA: 0x006370E7 File Offset: 0x006352E7
		private void PMDPLLIBJAF()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D967 RID: 55655 RVA: 0x0063A690 File Offset: 0x00638890
		private void DJGJAPJEAIO(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D968 RID: 55656 RVA: 0x006370E7 File Offset: 0x006352E7
		private void FECFLBMPAAL()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D969 RID: 55657 RVA: 0x0063A6F8 File Offset: 0x006388F8
		private void KMLNBHIIGKH()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1581f, 919f);
			if (Input.GetKeyDown((KeyCode)(-33)) && this.character.MPGNPAEGAJC())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1749f;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position;
				this.OJMBOCNNLMI.solver.IANMIEDIJPJ().position = this.OJMBOCNNLMI.solver.rightHandEffector.bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.ANFNMIKKLOM().position = this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position;
				this.NKHBAJKMAGD = 1125f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 1521f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1788f && this.character.NMPDKHCEDKP)
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 434f, 138f, 320f);
			}
			this.OEOOBANFJNB(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D96A RID: 55658 RVA: 0x006370E7 File Offset: 0x006352E7
		private void PFNPOHMMJDN()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D96B RID: 55659 RVA: 0x0063A918 File Offset: 0x00638B18
		private void LFOKJAKFGEK(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.leftFootEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D96C RID: 55660 RVA: 0x006370E7 File Offset: 0x006352E7
		private void LHHKDNILMDI()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D96D RID: 55661 RVA: 0x0063A980 File Offset: 0x00638B80
		private void KBLGGKIELJM(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D96E RID: 55662 RVA: 0x006370E7 File Offset: 0x006352E7
		private void DOHJPDNKALP()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D96F RID: 55663 RVA: 0x006370E7 File Offset: 0x006352E7
		private void BMNJGPIPKLL()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D970 RID: 55664 RVA: 0x006370E7 File Offset: 0x006352E7
		private void ELFLOPJDAKK()
		{
			this.HJILDDOIKCO = base.transform.localScale;
			this.AJMNDCHJPNK = this.character.GetComponent<Rigidbody>();
			this.OJMBOCNNLMI = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x0063A9E8 File Offset: 0x00638BE8
		private void PIJGGGEMCCE(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.ANGCEEAGHCB().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x0063AA50 File Offset: 0x00638C50
		private void BLPGKONHJBJ(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JHKNHMMGKCG().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.EAIGBIHMAGB().positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D973 RID: 55667 RVA: 0x0063AAB8 File Offset: 0x00638CB8
		private void DEGCCLNOEKJ()
		{
			this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * this.weightFalloffSpeed, 1915f, 1404f);
			if (Input.GetKeyDown(KeyCode.None) && this.character.AOEPFPLJFCG())
			{
				this.OJMBOCNNLMI.solver.IKPositionWeight = 1703f;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.position;
				this.OJMBOCNNLMI.solver.rightHandEffector.position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position;
				this.OJMBOCNNLMI.solver.leftFootEffector.position = this.OJMBOCNNLMI.solver.IAGDDAJGGGE().bone.position;
				this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().position = this.OJMBOCNNLMI.solver.JFOHJFFFPGJ().bone.position;
				this.NKHBAJKMAGD = 1544f;
				Vector3 vector = this.AJMNDCHJPNK.position - base.transform.position;
				vector.y = 991f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.AJMNDCHJPNK.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.NKHBAJKMAGD < 1174f && this.character.FBNGDMCBGIE())
			{
				this.NKHBAJKMAGD = Mathf.Clamp(this.NKHBAJKMAGD - Time.deltaTime * 905f, 1605f, 1954f);
			}
			this.GLJLDLFEMLB(this.weightFalloff.Evaluate(this.NKHBAJKMAGD));
			base.transform.localScale = this.scale.Evaluate(this.NKHBAJKMAGD) * this.HJILDDOIKCO;
		}

		// Token: 0x0600D974 RID: 55668 RVA: 0x0063ACD8 File Offset: 0x00638ED8
		private void HBMBNJDKBBA(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.IAGDDAJGGGE().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightFootEffector.positionWeight = OICADHEPMLH;
		}

		// Token: 0x0600D975 RID: 55669 RVA: 0x0063AD40 File Offset: 0x00638F40
		private void MGIHDCDOMII(float OICADHEPMLH)
		{
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.leftFootEffector.positionWeight = OICADHEPMLH;
			this.OJMBOCNNLMI.solver.JIHGEPGJDEC().positionWeight = OICADHEPMLH;
		}

		// Token: 0x04001CCC RID: 7372
		public SimpleLocomotion character;

		// Token: 0x04001CCD RID: 7373
		public float forceMlp = 1f;

		// Token: 0x04001CCE RID: 7374
		public float upForce = 1f;

		// Token: 0x04001CCF RID: 7375
		public float weightFalloffSpeed = 1f;

		// Token: 0x04001CD0 RID: 7376
		public AnimationCurve weightFalloff;

		// Token: 0x04001CD1 RID: 7377
		public AnimationCurve explosionForceByDistance;

		// Token: 0x04001CD2 RID: 7378
		public AnimationCurve scale;

		// Token: 0x04001CD3 RID: 7379
		private float NKHBAJKMAGD;

		// Token: 0x04001CD4 RID: 7380
		private Vector3 HJILDDOIKCO = Vector3.one;

		// Token: 0x04001CD5 RID: 7381
		private Rigidbody AJMNDCHJPNK;

		// Token: 0x04001CD6 RID: 7382
		private FullBodyBipedIK OJMBOCNNLMI;
	}
}
