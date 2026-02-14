using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002DA RID: 730
	public class ObjectResetter : MonoBehaviour
	{
		// Token: 0x0600ABC7 RID: 43975 RVA: 0x004BE7C0 File Offset: 0x004BC9C0
		public void AAMOFAHNFHJ(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FCPBMPBJINE(JLHNJDFMHMO));
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator MNPHAHJDLKO(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x004BE7E6 File Offset: 0x004BC9E6
		public void IHOHFKDKGNG(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FOCPKBMLLJM(JLHNJDFMHMO));
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x004BE7F6 File Offset: 0x004BC9F6
		public void HJEBIIMMKMO(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.GGNGLKAMCOF(JLHNJDFMHMO));
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x004BE808 File Offset: 0x004BCA08
		private void LMEJKAEIDCO()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x004BE854 File Offset: 0x004BCA54
		private void EFJDBBDMPMC()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x004BE8A0 File Offset: 0x004BCAA0
		private void BMNJGPIPKLL()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x004BE8EC File Offset: 0x004BCAEC
		private void CBLGFOFHNPJ()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x004BE938 File Offset: 0x004BCB38
		public void IPABCNGJDFF(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.PKIPODAEBJO(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x004BE948 File Offset: 0x004BCB48
		public void IMPFPIDGOOL(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.KCDEMAOFEEK(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x004BE7F6 File Offset: 0x004BC9F6
		public void GDDNDGALGMN(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.GGNGLKAMCOF(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x004BE958 File Offset: 0x004BCB58
		public void INDJDHOCKJO(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FCELBNCCLFL(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x004BE7F6 File Offset: 0x004BC9F6
		public void ENOKFBINHOC(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.GGNGLKAMCOF(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x004BE938 File Offset: 0x004BCB38
		public void KAMADCEKPNB(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.PKIPODAEBJO(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x004BE968 File Offset: 0x004BCB68
		private void KEMGOLACEHI()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x004BE958 File Offset: 0x004BCB58
		public void FFHPDNBFOHP(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FCELBNCCLFL(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x004BE9B4 File Offset: 0x004BCBB4
		public void DelayedReset(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.ResetCoroutine(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x004BE938 File Offset: 0x004BCB38
		public void CGMNGAGMBNE(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.PKIPODAEBJO(JLHNJDFMHMO));
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x004BE9C4 File Offset: 0x004BCBC4
		private void MKNPFMEMOJO()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator FCOLDHOGLOH(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x004BEA10 File Offset: 0x004BCC10
		private void ONIHHFLOJMN()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x004BE958 File Offset: 0x004BCB58
		public void GOBOGEEFCNF(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FCELBNCCLFL(JLHNJDFMHMO));
		}

		// Token: 0x0600ABDD RID: 43997 RVA: 0x004BEA5C File Offset: 0x004BCC5C
		public void HAEHKNDMCEH(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.MNPHAHJDLKO(JLHNJDFMHMO));
		}

		// Token: 0x0600ABDE RID: 43998 RVA: 0x004BE938 File Offset: 0x004BCB38
		public void INPAEPBMADK(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.PKIPODAEBJO(JLHNJDFMHMO));
		}

		// Token: 0x0600ABDF RID: 43999 RVA: 0x004BEA6C File Offset: 0x004BCC6C
		public IEnumerator NOGKABLMNKM(float JLHNJDFMHMO)
		{
			ObjectResetter.EMIFEOJCICF emifeojcicf = new ObjectResetter.EMIFEOJCICF(1);
			emifeojcicf.AENJLLPLILM = this;
			emifeojcicf.JLHNJDFMHMO = JLHNJDFMHMO;
			return emifeojcicf;
		}

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x004BEA84 File Offset: 0x004BCC84
		private void CGFDDFHECLJ()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x004BE7F6 File Offset: 0x004BC9F6
		public void BFMEDONOFFA(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.GGNGLKAMCOF(JLHNJDFMHMO));
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator KCDEMAOFEEK(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x004BEA6C File Offset: 0x004BCC6C
		public IEnumerator FOCPKBMLLJM(float JLHNJDFMHMO)
		{
			ObjectResetter.EMIFEOJCICF emifeojcicf = new ObjectResetter.EMIFEOJCICF(1);
			emifeojcicf.AENJLLPLILM = this;
			emifeojcicf.JLHNJDFMHMO = JLHNJDFMHMO;
			return emifeojcicf;
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator FCPBMPBJINE(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator CCHDFEGDJCJ(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x004BE7E6 File Offset: 0x004BC9E6
		public void HJJKBJGPIMO(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FOCPKBMLLJM(JLHNJDFMHMO));
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x004BE7F6 File Offset: 0x004BC9F6
		public void KAEJFLLKKBM(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.GGNGLKAMCOF(JLHNJDFMHMO));
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x004BE9B4 File Offset: 0x004BCBB4
		public void DANPKCCLLCE(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.ResetCoroutine(JLHNJDFMHMO));
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x004BEAD0 File Offset: 0x004BCCD0
		public void FEICCOAMINJ(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FCOLDHOGLOH(JLHNJDFMHMO));
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x004BEAE0 File Offset: 0x004BCCE0
		public void FMHGPFGGPNA(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.CKMAMMEFBEA(JLHNJDFMHMO));
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x004BEAF0 File Offset: 0x004BCCF0
		private void HDFCIACDDEK()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator NNGHAALEOHF(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x004BEB3C File Offset: 0x004BCD3C
		private void Start()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x004BEB88 File Offset: 0x004BCD88
		private void DHJDMKLBLEF()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x004BEBD4 File Offset: 0x004BCDD4
		private void OFGMIEJKMGC()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator FCELBNCCLFL(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x004BE7C0 File Offset: 0x004BC9C0
		public void LJKEMMJEPAO(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.FCPBMPBJINE(JLHNJDFMHMO));
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator CKMAMMEFBEA(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x004BEC20 File Offset: 0x004BCE20
		public void JHOPEIDFIJG(float JLHNJDFMHMO)
		{
			base.StartCoroutine(this.NNGHAALEOHF(JLHNJDFMHMO));
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator LHGHOFKLGJD(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x004BEC30 File Offset: 0x004BCE30
		private void EHFPLKEINFO()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x004BEC7C File Offset: 0x004BCE7C
		private void AFFAJKPPMHF()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x004BECC8 File Offset: 0x004BCEC8
		private void ANHOOJFEJJE()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABF9 RID: 44025 RVA: 0x004BE7D0 File Offset: 0x004BC9D0
		public IEnumerator ResetCoroutine(float JLHNJDFMHMO)
		{
			yield return new WaitForSeconds(JLHNJDFMHMO);
			foreach (Transform transform in base.GetComponentsInChildren<Transform>())
			{
				if (!this.MELCFDMGELB.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = this.LEAHKEEMEJB;
			base.transform.rotation = this.NGPKGELNJPJ;
			if (this.DBFEPAHJFGO)
			{
				this.DBFEPAHJFGO.velocity = Vector3.zero;
				this.DBFEPAHJFGO.angularVelocity = Vector3.zero;
			}
			base.SendMessage("Reset");
			yield break;
		}

		// Token: 0x0600ABFA RID: 44026 RVA: 0x004BEA6C File Offset: 0x004BCC6C
		public IEnumerator PKIPODAEBJO(float JLHNJDFMHMO)
		{
			ObjectResetter.EMIFEOJCICF emifeojcicf = new ObjectResetter.EMIFEOJCICF(1);
			emifeojcicf.AENJLLPLILM = this;
			emifeojcicf.JLHNJDFMHMO = JLHNJDFMHMO;
			return emifeojcicf;
		}

		// Token: 0x0600ABFB RID: 44027 RVA: 0x004BED14 File Offset: 0x004BCF14
		private void ELADFDNPOOI()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x004BED60 File Offset: 0x004BCF60
		private void PFNPOHMMJDN()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x004BEA6C File Offset: 0x004BCC6C
		public IEnumerator GGNGLKAMCOF(float JLHNJDFMHMO)
		{
			ObjectResetter.EMIFEOJCICF emifeojcicf = new ObjectResetter.EMIFEOJCICF(1);
			emifeojcicf.AENJLLPLILM = this;
			emifeojcicf.JLHNJDFMHMO = JLHNJDFMHMO;
			return emifeojcicf;
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x004BEDAC File Offset: 0x004BCFAC
		private void EDGALMCHPPH()
		{
			this.MELCFDMGELB = new List<Transform>(base.GetComponentsInChildren<Transform>());
			this.LEAHKEEMEJB = base.transform.position;
			this.NGPKGELNJPJ = base.transform.rotation;
			this.DBFEPAHJFGO = base.GetComponent<Rigidbody>();
		}

		// Token: 0x04001604 RID: 5636
		private Vector3 LEAHKEEMEJB;

		// Token: 0x04001605 RID: 5637
		private Quaternion NGPKGELNJPJ;

		// Token: 0x04001606 RID: 5638
		private List<Transform> MELCFDMGELB;

		// Token: 0x04001607 RID: 5639
		private Rigidbody DBFEPAHJFGO;
	}
}
