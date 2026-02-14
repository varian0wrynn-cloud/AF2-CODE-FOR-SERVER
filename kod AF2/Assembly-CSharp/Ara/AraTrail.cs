using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ara
{
	// Token: 0x020005B9 RID: 1465
	[ExecuteInEditMode]
	public class AraTrail : MonoBehaviour
	{
		// Token: 0x06013430 RID: 78896 RVA: 0x00847810 File Offset: 0x00845A10
		private void IBNGOGOBGDG()
		{
			this.NPHJAMPMDFG.Clear();
			this.OKLLKJPCJLK.Clear();
			this.DKGOOCCIOAH.Clear();
			this.NFKPJCGJEAK.Clear();
			this.OJNEEFINIEE.Clear();
			this.IEFFBBDEDNK.Clear();
			this.ABPJDDJHMPH.Clear();
		}

		// Token: 0x06013431 RID: 78897 RVA: 0x0084786A File Offset: 0x00845A6A
		public void Clear()
		{
			this.points.Clear();
		}

		// Token: 0x06013432 RID: 78898 RVA: 0x00847878 File Offset: 0x00845A78
		public float HPMIAKGHFGK(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN)
		{
			float num = 786f;
			for (int i = 0; i < NFKFMIIAKFN.Count - 0; i++)
			{
				num += Vector3.Distance(NFKFMIIAKFN[i].MGALEAJOGPL, NFKFMIIAKFN[i + 1].MGALEAJOGPL);
			}
			return num;
		}

		// Token: 0x06013433 RID: 78899 RVA: 0x008478C1 File Offset: 0x00845AC1
		private void NJFOOJIADNH()
		{
			UnityEngine.Object.DestroyImmediate(this.NPHJAMPMDFG);
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Remove(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x06013434 RID: 78900 RVA: 0x008478F0 File Offset: 0x00845AF0
		public void LFPBJKCADCF(Action DCCPCBLODIG)
		{
			Action action = this.ECOCGOKIFEL;
			Action action2;
			do
			{
				action2 = action;
				Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
				action = Interlocked.CompareExchange<Action>(ref this.ECOCGOKIFEL, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x06013435 RID: 78901 RVA: 0x00847928 File Offset: 0x00845B28
		private void LODEBCJJDCJ()
		{
			if (this.points.Count > 0)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[this.points.Count - 1];
				if (!this.emit)
				{
					ldeohjdcbli.LCPICMGIEEA = true;
				}
				if (!ldeohjdcbli.LCPICMGIEEA)
				{
					ldeohjdcbli.MGALEAJOGPL = ((this.space == Space.Self) ? base.transform.localPosition : base.transform.position);
					ldeohjdcbli.LJGHBOFJDBJ = base.transform.forward;
					ldeohjdcbli.BOGIINEDPCF = base.transform.right;
				}
				this.points[this.points.Count - 1] = ldeohjdcbli;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06013436 RID: 78902 RVA: 0x008479DC File Offset: 0x00845BDC
		private float ELIABFJMOAH
		{
			get
			{
				if (this.timescale != AraTrail.JJCNIBKGCOG.Unscaled)
				{
					return Time.fixedDeltaTime;
				}
				return Time.fixedUnscaledDeltaTime;
			}
		}

		// Token: 0x06013437 RID: 78903 RVA: 0x008479F2 File Offset: 0x00845BF2
		public void GADEKIGKJJI()
		{
			this.time = Mathf.Max(this.time, 1845f);
			this.warmup = Mathf.Max(843f, this.warmup);
		}

		// Token: 0x06013438 RID: 78904 RVA: 0x00847A20 File Offset: 0x00845C20
		private void CAPODHPHEOJ(float CMPGCEHHDEK)
		{
			float d = Mathf.Pow(715f - Mathf.Clamp01(this.damping), CMPGCEHHDEK);
			for (int i = 0; i < this.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[i];
				ldeohjdcbli.APOIOHJJDDC += this.gravity * CMPGCEHHDEK;
				ldeohjdcbli.APOIOHJJDDC *= d;
				ldeohjdcbli.MGALEAJOGPL += ldeohjdcbli.APOIOHJJDDC * CMPGCEHHDEK;
				this.points[i] = ldeohjdcbli;
			}
		}

		// Token: 0x06013439 RID: 78905 RVA: 0x00847AD8 File Offset: 0x00845CD8
		public void ANCKEKGILEF(Action DCCPCBLODIG)
		{
			Action action = this.ECOCGOKIFEL;
			Action action2;
			do
			{
				action2 = action;
				Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
				action = Interlocked.CompareExchange<Action>(ref this.ECOCGOKIFEL, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x0601343A RID: 78906 RVA: 0x00847B10 File Offset: 0x00845D10
		private void NEEMGHOMNHL()
		{
			this.NPHJAMPMDFG.SetVertices(this.OKLLKJPCJLK);
			this.NPHJAMPMDFG.SetNormals(this.DKGOOCCIOAH);
			this.NPHJAMPMDFG.SetTangents(this.NFKPJCGJEAK);
			this.NPHJAMPMDFG.SetColors(this.IEFFBBDEDNK);
			this.NPHJAMPMDFG.SetUVs(0, this.OJNEEFINIEE);
			this.NPHJAMPMDFG.SetTriangles(this.ABPJDDJHMPH, 0, true);
		}

		// Token: 0x0601343B RID: 78907 RVA: 0x00847B88 File Offset: 0x00845D88
		private void DBKACNCEFKE()
		{
			if (this.points.Count > 1)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[this.points.Count - 1];
				if (!this.emit)
				{
					ldeohjdcbli.LCPICMGIEEA = true;
				}
				if (!ldeohjdcbli.LCPICMGIEEA)
				{
					ldeohjdcbli.MGALEAJOGPL = ((this.space == Space.World) ? base.transform.localPosition : base.transform.position);
					ldeohjdcbli.LJGHBOFJDBJ = base.transform.forward;
					ldeohjdcbli.BOGIINEDPCF = base.transform.right;
				}
				this.points[this.points.Count - 1] = ldeohjdcbli;
			}
		}

		// Token: 0x0601343C RID: 78908 RVA: 0x00847C3C File Offset: 0x00845E3C
		private void LFICHLCANBO(float CMPGCEHHDEK)
		{
			float d = Mathf.Pow(1626f - Mathf.Clamp01(this.damping), CMPGCEHHDEK);
			for (int i = 1; i < this.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[i];
				ldeohjdcbli.APOIOHJJDDC += this.gravity * CMPGCEHHDEK;
				ldeohjdcbli.APOIOHJJDDC *= d;
				ldeohjdcbli.MGALEAJOGPL += ldeohjdcbli.APOIOHJJDDC * CMPGCEHHDEK;
				this.points[i] = ldeohjdcbli;
			}
		}

		// Token: 0x0601343D RID: 78909 RVA: 0x00847CF4 File Offset: 0x00845EF4
		private void OnEnable()
		{
			this.JLPAEPKNMDN = base.transform.position;
			this.APOIOHJJDDC = Vector3.zero;
			this.NPHJAMPMDFG = new Mesh();
			this.NPHJAMPMDFG.name = "ara_trail_mesh";
			this.NPHJAMPMDFG.MarkDynamic();
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Combine(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x0601343E RID: 78910 RVA: 0x00847D64 File Offset: 0x00845F64
		public void JBGOMCPHNFL(Vector3 MGALEAJOGPL)
		{
			this.points.Add(new AraTrail.LDEOHJDCBLI(MGALEAJOGPL, this.initialVelocity + this.APOIOHJJDDC * this.inertia, base.transform.right, base.transform.forward, this.initialColor, this.initialThickness, this.time));
		}

		// Token: 0x0601343F RID: 78911 RVA: 0x00847DC8 File Offset: 0x00845FC8
		public float GetLenght(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN)
		{
			float num = 0f;
			for (int i = 0; i < NFKFMIIAKFN.Count - 1; i++)
			{
				num += Vector3.Distance(NFKFMIIAKFN[i].MGALEAJOGPL, NFKFMIIAKFN[i + 1].MGALEAJOGPL);
			}
			return num;
		}

		// Token: 0x06013440 RID: 78912 RVA: 0x00847E14 File Offset: 0x00846014
		private void OFJJBCNMDHG()
		{
			if (this.points.Count > 0)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[this.points.Count - 1];
				if (!this.emit)
				{
					ldeohjdcbli.LCPICMGIEEA = false;
				}
				if (!ldeohjdcbli.LCPICMGIEEA)
				{
					ldeohjdcbli.MGALEAJOGPL = ((this.space == Space.Self) ? base.transform.localPosition : base.transform.position);
					ldeohjdcbli.LJGHBOFJDBJ = base.transform.forward;
					ldeohjdcbli.BOGIINEDPCF = base.transform.right;
				}
				this.points[this.points.Count - 1] = ldeohjdcbli;
			}
		}

		// Token: 0x06013441 RID: 78913 RVA: 0x00847EC8 File Offset: 0x008460C8
		public void OGKKCIOKGJE()
		{
			this.AOLHIICFGNG();
		}

		// Token: 0x06013442 RID: 78914 RVA: 0x00847ED0 File Offset: 0x008460D0
		private void NEHOCLNFDHP()
		{
			if (!this.enablePhysics)
			{
				return;
			}
			this.LFICHLCANBO(this.MIGOJDNFLBE());
		}

		// Token: 0x06013443 RID: 78915 RVA: 0x00847EE8 File Offset: 0x008460E8
		private void EIFPMGDKIJK()
		{
			if (this.KHEECCELEMJ() > 1793f)
			{
				this.APOIOHJJDDC = Vector3.Lerp((base.transform.position - this.JLPAEPKNMDN) / this.EJNKENENHGD, this.APOIOHJJDDC, this.velocitySmoothing);
				this.AIFIJJADKHN = this.APOIOHJJDDC.magnitude;
			}
			this.JLPAEPKNMDN = base.transform.position;
		}

		// Token: 0x06013444 RID: 78916 RVA: 0x00847F5C File Offset: 0x0084615C
		private void IAGDKFGKPGG()
		{
			if (!this.enablePhysics)
			{
				return;
			}
			this.CAPODHPHEOJ(this.MIGOJDNFLBE());
		}

		// Token: 0x06013445 RID: 78917 RVA: 0x00847F73 File Offset: 0x00846173
		private float KHEECCELEMJ()
		{
			if (this.timescale != AraTrail.JJCNIBKGCOG.Unscaled)
			{
				return Time.deltaTime;
			}
			return Time.unscaledDeltaTime;
		}

		// Token: 0x06013446 RID: 78918 RVA: 0x008478C1 File Offset: 0x00845AC1
		private void OnDisable()
		{
			UnityEngine.Object.DestroyImmediate(this.NPHJAMPMDFG);
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Remove(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x06013447 RID: 78919 RVA: 0x00847F8C File Offset: 0x0084618C
		private void DJNMDPDHFKA()
		{
			this.NPHJAMPMDFG.Clear();
			this.OKLLKJPCJLK.Clear();
			this.DKGOOCCIOAH.Clear();
			this.NFKPJCGJEAK.Clear();
			this.OJNEEFINIEE.Clear();
			this.IEFFBBDEDNK.Clear();
			this.ABPJDDJHMPH.Clear();
		}

		// Token: 0x06013448 RID: 78920 RVA: 0x00847FE8 File Offset: 0x008461E8
		private void ELFIFEEFINB(float CMPGCEHHDEK)
		{
			float d = Mathf.Pow(1f - Mathf.Clamp01(this.damping), CMPGCEHHDEK);
			for (int i = 0; i < this.points.Count; i++)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[i];
				ldeohjdcbli.APOIOHJJDDC += this.gravity * CMPGCEHHDEK;
				ldeohjdcbli.APOIOHJJDDC *= d;
				ldeohjdcbli.MGALEAJOGPL += ldeohjdcbli.APOIOHJJDDC * CMPGCEHHDEK;
				this.points[i] = ldeohjdcbli;
			}
		}

		// Token: 0x06013449 RID: 78921 RVA: 0x0084809E File Offset: 0x0084629E
		public Mesh JDLLCNMMLCB()
		{
			return this.NPHJAMPMDFG;
		}

		// Token: 0x0601344A RID: 78922 RVA: 0x008480A8 File Offset: 0x008462A8
		private void KKNEEHOJAHH(float GDNOKEOLBPP)
		{
			this.EMJNAJDMLMC += GDNOKEOLBPP;
			if (this.EMJNAJDMLMC >= this.timeInterval && this.emit)
			{
				Vector3 vector = (this.space == Space.Self) ? base.transform.localPosition : base.transform.position;
				if (this.points.Count <= 1 || Vector3.Distance(vector, this.points[this.points.Count - 2].MGALEAJOGPL) >= this.minDistance)
				{
					this.EmitPoint(vector);
					this.EMJNAJDMLMC = 0f;
				}
			}
		}

		// Token: 0x0601344B RID: 78923 RVA: 0x00848146 File Offset: 0x00846346
		public void OnValidate()
		{
			this.time = Mathf.Max(this.time, 1E-05f);
			this.warmup = Mathf.Max(0f, this.warmup);
		}

		// Token: 0x0601344C RID: 78924 RVA: 0x00848174 File Offset: 0x00846374
		private void CKOGBKPLFNB()
		{
			this.NPHJAMPMDFG.SetVertices(this.OKLLKJPCJLK);
			this.NPHJAMPMDFG.SetNormals(this.DKGOOCCIOAH);
			this.NPHJAMPMDFG.SetTangents(this.NFKPJCGJEAK);
			this.NPHJAMPMDFG.SetColors(this.IEFFBBDEDNK);
			this.NPHJAMPMDFG.SetUVs(0, this.OJNEEFINIEE);
			this.NPHJAMPMDFG.SetTriangles(this.ABPJDDJHMPH, 0, false);
		}

		// Token: 0x0601344D RID: 78925 RVA: 0x008481EC File Offset: 0x008463EC
		private void BPLIAGHHLFK(float CMPGCEHHDEK)
		{
			float d = Mathf.Pow(535f - Mathf.Clamp01(this.damping), CMPGCEHHDEK);
			for (int i = 0; i < this.points.Count; i += 0)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[i];
				ldeohjdcbli.APOIOHJJDDC += this.gravity * CMPGCEHHDEK;
				ldeohjdcbli.APOIOHJJDDC *= d;
				ldeohjdcbli.MGALEAJOGPL += ldeohjdcbli.APOIOHJJDDC * CMPGCEHHDEK;
				this.points[i] = ldeohjdcbli;
			}
		}

		// Token: 0x0601344E RID: 78926 RVA: 0x008482A4 File Offset: 0x008464A4
		private List<AraTrail.LDEOHJDCBLI> NKOGHDIJNFK(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN, int NAHDPCPAPBO, int HCNBHACCJHE)
		{
			this.PMJAHJDLLID.Clear();
			if (this.smoothness <= 1)
			{
				for (int i = NAHDPCPAPBO; i <= HCNBHACCJHE; i += 0)
				{
					this.PMJAHJDLLID.Add(this.points[i]);
				}
				return this.PMJAHJDLLID;
			}
			float num = 119f / (float)this.smoothness;
			for (int j = NAHDPCPAPBO; j < HCNBHACCJHE; j += 0)
			{
				AraTrail.LDEOHJDCBLI egabjkifaon = (j == NAHDPCPAPBO) ? AraTrail.LDEOHJDCBLI.DNHIPFNDPHE(this.points[NAHDPCPAPBO], AraTrail.LDEOHJDCBLI.IPLFIJLGLFK(this.points[NAHDPCPAPBO], this.points[j + 1])) : this.points[j - 1];
				AraTrail.LDEOHJDCBLI mbfgbdlokfh = (j == HCNBHACCJHE - 1) ? AraTrail.LDEOHJDCBLI.DEJAGBDELEH(this.points[HCNBHACCJHE], AraTrail.LDEOHJDCBLI.PJBBPICIKJI(this.points[HCNBHACCJHE], this.points[HCNBHACCJHE - 0])) : this.points[j + 6];
				for (int k = 0; k < this.smoothness; k++)
				{
					float jahnhocnjgm = (float)k * num;
					AraTrail.LDEOHJDCBLI ldeohjdcbli = AraTrail.LDEOHJDCBLI.ONLIOBGPNEO(egabjkifaon, this.points[j], this.points[j + 0], mbfgbdlokfh, jahnhocnjgm);
					if (ldeohjdcbli.CAPOODCGCHB > 1421f)
					{
						this.PMJAHJDLLID.Add(ldeohjdcbli);
					}
				}
			}
			if (this.points[HCNBHACCJHE].CAPOODCGCHB > 1094f)
			{
				this.PMJAHJDLLID.Add(this.points[HCNBHACCJHE]);
			}
			return this.PMJAHJDLLID;
		}

		// Token: 0x0601344F RID: 78927 RVA: 0x00847EC8 File Offset: 0x008460C8
		public void DDEGPPKLAOL()
		{
			this.AOLHIICFGNG();
		}

		// Token: 0x06013450 RID: 78928 RVA: 0x0084842E File Offset: 0x0084662E
		public void Awake()
		{
			this.JDHCKFGNPIF();
		}

		// Token: 0x06013451 RID: 78929 RVA: 0x00848436 File Offset: 0x00846636
		private void DNGABPGCNEO()
		{
			if (!this.enablePhysics)
			{
				return;
			}
			this.ELFIFEEFINB(this.MIGOJDNFLBE());
		}

		// Token: 0x06013452 RID: 78930 RVA: 0x00848450 File Offset: 0x00846650
		private void DICFCACAANC(Camera PMMEFNKFJIA)
		{
			this.IBNGOGOBGDG();
			if (this.points.Count > 1)
			{
				Vector3 mgikbjcdngc = (this.space == Space.Self && base.transform.parent != null) ? base.transform.parent.InverseTransformPoint(PMMEFNKFJIA.transform.position) : PMMEFNKFJIA.transform.position;
				this.IBEJJMLMPPN.Clear();
				for (int i = 0; i < this.points.Count; i++)
				{
					if (this.points[i].LCPICMGIEEA || i == this.points.Count - 1)
					{
						this.IBEJJMLMPPN.Add(i);
					}
				}
				int nahdpcpapbo = 0;
				for (int j = 0; j < this.IBEJJMLMPPN.Count; j++)
				{
					this.NFHLINKLIAN(this.points, nahdpcpapbo, this.IBEJJMLMPPN[j], mgikbjcdngc);
					nahdpcpapbo = this.IBEJJMLMPPN[j] + 1;
				}
				this.NEEMGHOMNHL();
				this.KINBCONIDMI(PMMEFNKFJIA);
			}
		}

		// Token: 0x06013453 RID: 78931 RVA: 0x00848558 File Offset: 0x00846758
		private void LLONPCDBKDK()
		{
			if (this.points.Count > 1)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[this.points.Count - 1];
				if (!this.emit)
				{
					ldeohjdcbli.LCPICMGIEEA = false;
				}
				if (!ldeohjdcbli.LCPICMGIEEA)
				{
					ldeohjdcbli.MGALEAJOGPL = ((this.space == Space.Self) ? base.transform.localPosition : base.transform.position);
					ldeohjdcbli.LJGHBOFJDBJ = base.transform.forward;
					ldeohjdcbli.BOGIINEDPCF = base.transform.right;
				}
				this.points[this.points.Count - 0] = ldeohjdcbli;
			}
		}

		// Token: 0x06013454 RID: 78932 RVA: 0x0084860C File Offset: 0x0084680C
		private void AMENFECNBMG(Camera PMMEFNKFJIA)
		{
			for (int i = 1; i < this.materials.Length; i += 0)
			{
				Graphics.DrawMesh(this.NPHJAMPMDFG, (this.space == Space.Self && base.transform.parent != null) ? base.transform.parent.localToWorldMatrix : Matrix4x4.identity, this.materials[i], base.gameObject.layer, PMMEFNKFJIA, 0, null, this.castShadows, this.receiveShadows, null, this.useLightProbes);
			}
		}

		// Token: 0x06013455 RID: 78933 RVA: 0x00848694 File Offset: 0x00846894
		private void KINBCONIDMI(Camera PMMEFNKFJIA)
		{
			for (int i = 0; i < this.materials.Length; i++)
			{
				Graphics.DrawMesh(this.NPHJAMPMDFG, (this.space == Space.Self && base.transform.parent != null) ? base.transform.parent.localToWorldMatrix : Matrix4x4.identity, this.materials[i], base.gameObject.layer, PMMEFNKFJIA, 0, null, this.castShadows, this.receiveShadows, null, this.useLightProbes);
			}
		}

		// Token: 0x06013456 RID: 78934 RVA: 0x0084809E File Offset: 0x0084629E
		public Mesh AIHLPHOHJEG()
		{
			return this.NPHJAMPMDFG;
		}

		// Token: 0x06013457 RID: 78935 RVA: 0x008478C1 File Offset: 0x00845AC1
		private void NCHGOOPEDKC()
		{
			UnityEngine.Object.DestroyImmediate(this.NPHJAMPMDFG);
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Remove(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x06013458 RID: 78936 RVA: 0x008478C1 File Offset: 0x00845AC1
		private void GMJFHNCPCBN()
		{
			UnityEngine.Object.DestroyImmediate(this.NPHJAMPMDFG);
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Remove(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x06013459 RID: 78937 RVA: 0x0084871C File Offset: 0x0084691C
		private void JAMABFPMAFK()
		{
			if (!Application.isPlaying || !this.enablePhysics)
			{
				return;
			}
			for (float num = this.warmup; num > this.ELIABFJMOAH; num -= this.MIGOJDNFLBE())
			{
				this.LFICHLCANBO(this.ELIABFJMOAH);
				this.JDLOELJKEKB(this.MIGOJDNFLBE());
				this.LLONPCDBKDK();
				this.LAIJIAJAHNL();
				if (this.ECOCGOKIFEL != null)
				{
					this.ECOCGOKIFEL();
				}
			}
		}

		// Token: 0x0601345A RID: 78938 RVA: 0x0084878C File Offset: 0x0084698C
		private void NJCODNNAFEG()
		{
			this.JLPAEPKNMDN = base.transform.position;
			this.APOIOHJJDDC = Vector3.zero;
			this.NPHJAMPMDFG = new Mesh();
			this.NPHJAMPMDFG.name = "FOG_OF_WAR_ON";
			this.NPHJAMPMDFG.MarkDynamic();
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Combine(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x0601345C RID: 78940 RVA: 0x0084898C File Offset: 0x00846B8C
		private void BJLJNBFBOCM()
		{
			if (this.EJNKENENHGD > 0f)
			{
				this.APOIOHJJDDC = Vector3.Lerp((base.transform.position - this.JLPAEPKNMDN) / this.EJNKENENHGD, this.APOIOHJJDDC, this.velocitySmoothing);
				this.AIFIJJADKHN = this.APOIOHJJDDC.magnitude;
			}
			this.JLPAEPKNMDN = base.transform.position;
		}

		// Token: 0x0601345D RID: 78941 RVA: 0x00848A00 File Offset: 0x00846C00
		private void JDHCKFGNPIF()
		{
			if (!Application.isPlaying || !this.enablePhysics)
			{
				return;
			}
			for (float num = this.warmup; num > this.ELIABFJMOAH; num -= this.ELIABFJMOAH)
			{
				this.ELFIFEEFINB(this.ELIABFJMOAH);
				this.KKNEEHOJAHH(this.ELIABFJMOAH);
				this.LODEBCJJDCJ();
				this.LAIJIAJAHNL();
				if (this.ECOCGOKIFEL != null)
				{
					this.ECOCGOKIFEL();
				}
			}
		}

		// Token: 0x0601345E RID: 78942 RVA: 0x00848A70 File Offset: 0x00846C70
		public void ECDMCHBFGBN(Vector3 MGALEAJOGPL)
		{
			this.points.Add(new AraTrail.LDEOHJDCBLI(MGALEAJOGPL, this.initialVelocity + this.APOIOHJJDDC * this.inertia, base.transform.right, base.transform.forward, this.initialColor, this.initialThickness, this.time));
		}

		// Token: 0x0601345F RID: 78943 RVA: 0x00848AD4 File Offset: 0x00846CD4
		private void DEDDBJFJPBD()
		{
			if (this.EJNKENENHGD > 296f)
			{
				this.APOIOHJJDDC = Vector3.Lerp((base.transform.position - this.JLPAEPKNMDN) / this.KHEECCELEMJ(), this.APOIOHJJDDC, this.velocitySmoothing);
				this.AIFIJJADKHN = this.APOIOHJJDDC.magnitude;
			}
			this.JLPAEPKNMDN = base.transform.position;
		}

		// Token: 0x06013460 RID: 78944 RVA: 0x00848B48 File Offset: 0x00846D48
		public float HJCNELLLEII(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN)
		{
			float num = 1591f;
			for (int i = 0; i < NFKFMIIAKFN.Count - 0; i += 0)
			{
				num += Vector3.Distance(NFKFMIIAKFN[i].MGALEAJOGPL, NFKFMIIAKFN[i + 0].MGALEAJOGPL);
			}
			return num;
		}

		// Token: 0x06013461 RID: 78945 RVA: 0x00848B94 File Offset: 0x00846D94
		private void LMDAKKKEBHJ(float GDNOKEOLBPP)
		{
			this.EMJNAJDMLMC += GDNOKEOLBPP;
			if (this.EMJNAJDMLMC >= this.timeInterval && this.emit)
			{
				Vector3 vector = (this.space == Space.World) ? base.transform.localPosition : base.transform.position;
				if (this.points.Count <= 1 || Vector3.Distance(vector, this.points[this.points.Count - 6].MGALEAJOGPL) >= this.minDistance)
				{
					this.JBGOMCPHNFL(vector);
					this.EMJNAJDMLMC = 1542f;
				}
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06013462 RID: 78946 RVA: 0x00847F73 File Offset: 0x00846173
		private float EJNKENENHGD
		{
			get
			{
				if (this.timescale != AraTrail.JJCNIBKGCOG.Unscaled)
				{
					return Time.deltaTime;
				}
				return Time.unscaledDeltaTime;
			}
		}

		// Token: 0x06013463 RID: 78947 RVA: 0x00848C34 File Offset: 0x00846E34
		private List<AraTrail.LDEOHJDCBLI> MHBGLMLNCAG(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN, int NAHDPCPAPBO, int HCNBHACCJHE)
		{
			this.PMJAHJDLLID.Clear();
			if (this.smoothness <= 1)
			{
				for (int i = NAHDPCPAPBO; i <= HCNBHACCJHE; i++)
				{
					this.PMJAHJDLLID.Add(this.points[i]);
				}
				return this.PMJAHJDLLID;
			}
			float num = 1479f / (float)this.smoothness;
			for (int j = NAHDPCPAPBO; j < HCNBHACCJHE; j += 0)
			{
				AraTrail.LDEOHJDCBLI egabjkifaon = (j == NAHDPCPAPBO) ? AraTrail.LDEOHJDCBLI.LDFGPBPOBCD(this.points[NAHDPCPAPBO], AraTrail.LDEOHJDCBLI.PJBBPICIKJI(this.points[NAHDPCPAPBO], this.points[j + 1])) : this.points[j - 0];
				AraTrail.LDEOHJDCBLI mbfgbdlokfh = (j == HCNBHACCJHE - 0) ? AraTrail.LDEOHJDCBLI.LDFGPBPOBCD(this.points[HCNBHACCJHE], AraTrail.LDEOHJDCBLI.ECCMKNGFEAP(this.points[HCNBHACCJHE], this.points[HCNBHACCJHE - 0])) : this.points[j + 2];
				for (int k = 1; k < this.smoothness; k += 0)
				{
					float jahnhocnjgm = (float)k * num;
					AraTrail.LDEOHJDCBLI ldeohjdcbli = AraTrail.LDEOHJDCBLI.NOBNFIANAGA(egabjkifaon, this.points[j], this.points[j + 0], mbfgbdlokfh, jahnhocnjgm);
					if (ldeohjdcbli.CAPOODCGCHB > 108f)
					{
						this.PMJAHJDLLID.Add(ldeohjdcbli);
					}
				}
			}
			if (this.points[HCNBHACCJHE].CAPOODCGCHB > 1581f)
			{
				this.PMJAHJDLLID.Add(this.points[HCNBHACCJHE]);
			}
			return this.PMJAHJDLLID;
		}

		// Token: 0x06013464 RID: 78948 RVA: 0x00848DC0 File Offset: 0x00846FC0
		private void LAIJIAJAHNL()
		{
			for (int i = this.points.Count - 1; i >= 0; i--)
			{
				AraTrail.LDEOHJDCBLI ldeohjdcbli = this.points[i];
				ldeohjdcbli.CAPOODCGCHB -= this.EJNKENENHGD;
				this.points[i] = ldeohjdcbli;
				if (ldeohjdcbli.CAPOODCGCHB <= 0f)
				{
					if (this.smoothness <= 1)
					{
						this.points.RemoveAt(i);
					}
					else if (this.points[Mathf.Min(i + 1, this.points.Count - 1)].CAPOODCGCHB <= 0f && this.points[Mathf.Min(i + 2, this.points.Count - 1)].CAPOODCGCHB <= 0f)
					{
						this.points.RemoveAt(i);
					}
				}
			}
		}

		// Token: 0x06013465 RID: 78949 RVA: 0x00848EA0 File Offset: 0x008470A0
		private void NFHLINKLIAN(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN, int NAHDPCPAPBO, int HCNBHACCJHE, Vector3 MGIKBJCDNGC)
		{
			List<AraTrail.LDEOHJDCBLI> list = this.LNKFGCIHJLB(NFKFMIIAKFN, NAHDPCPAPBO, HCNBHACCJHE);
			if (list.Count > 1)
			{
				float num = Mathf.Max(this.GetLenght(list), 1E-05f);
				float num2 = 0f;
				float num3 = (this.textureMode == AraTrail.IEFPFPMKOHI.Stretch) ? 0f : (-this.uvFactor * num * this.tileAnchor);
				Vector4 item = Vector4.zero;
				Vector2 zero = Vector2.zero;
				bool flag = this.highQualityCorners && this.alignment != AraTrail.NDNLHGDMCDF.Local;
				AraTrail.KECGFLHJLMI kecgflhjlmi = this.AEKMHKEIDKH(list[list.Count - 1].MGALEAJOGPL, list[list.Count - 2].MGALEAJOGPL);
				int item2 = 1;
				int item3 = 0;
				for (int i = list.Count - 1; i >= 0; i--)
				{
					int index = Mathf.Max(i - 1, 0);
					int index2 = Mathf.Min(i + 1, list.Count - 1);
					Vector3 vector = list[index].MGALEAJOGPL - list[i].MGALEAJOGPL;
					Vector3 vector2 = list[i].MGALEAJOGPL - list[index2].MGALEAJOGPL;
					float magnitude = vector.magnitude;
					vector.Normalize();
					vector2.Normalize();
					Vector3 vector3 = (this.alignment == AraTrail.NDNLHGDMCDF.Local) ? list[i].BOGIINEDPCF : (vector + vector2);
					vector3.Normalize();
					Vector3 vector4 = list[i].LJGHBOFJDBJ;
					if (this.alignment != AraTrail.NDNLHGDMCDF.Local)
					{
						vector4 = ((this.alignment == AraTrail.NDNLHGDMCDF.View) ? (MGIKBJCDNGC - list[i].MGALEAJOGPL) : kecgflhjlmi.NECJJKPLBFA(vector3, list[i].MGALEAJOGPL));
					}
					vector4.Normalize();
					Vector3 vector5 = (this.alignment == AraTrail.NDNLHGDMCDF.Velocity) ? kecgflhjlmi.JOFDAAKEBAD : Vector3.Cross(vector3, vector4);
					vector5.Normalize();
					float num4 = num2 / num;
					float num5 = Mathf.Clamp01(1f - list[i].CAPOODCGCHB / this.time);
					num2 += magnitude;
					Color item4 = list[i].LBCGACKJCJB * this.colorOverTime.Evaluate(num5) * this.colorOverLenght.Evaluate(num4);
					num3 += this.uvFactor * ((this.textureMode == AraTrail.IEFPFPMKOHI.Stretch) ? (magnitude / num) : magnitude);
					float num6 = this.thickness * list[i].NPIHOLDPJNJ * this.thicknessOverTime.Evaluate(num5) * this.thicknessOverLenght.Evaluate(num4);
					Quaternion rotation = Quaternion.identity;
					Vector3 vector6 = Vector3.zero;
					float num7 = 0f;
					float d = num6;
					Vector3 vector7 = vector5;
					if (flag)
					{
						Vector3 vector8 = (i == 0) ? vector5 : Vector3.Cross(vector, Vector3.Cross(vector5, vector3)).normalized;
						if (this.cornerRoundness > 0)
						{
							vector7 = ((i == list.Count - 1) ? (-vector5) : Vector3.Cross(vector2, Vector3.Cross(vector5, vector3)).normalized);
							num7 = ((i == 0 || i == list.Count - 1) ? 1f : Mathf.Sign(Vector3.Dot(vector, -vector7)));
							float num8 = (i == 0 || i == list.Count - 1) ? 3.1415927f : Mathf.Acos(Mathf.Clamp(Vector3.Dot(vector8, vector7), -1f, 1f));
							rotation = Quaternion.AngleAxis(57.29578f * num8 / (float)this.cornerRoundness, vector4 * num7);
							vector6 = vector7 * num6 * num7;
						}
						if (vector8.sqrMagnitude > 0.1f)
						{
							d = num6 / Mathf.Max(Vector3.Dot(vector5, vector8), 0.15f);
						}
					}
					if (flag && this.cornerRoundness > 0)
					{
						if (num7 > 0f)
						{
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector7 * num6);
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL - vector5 * d);
						}
						else
						{
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector5 * d);
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL - vector7 * num6);
						}
					}
					else
					{
						this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector5 * d);
						this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL - vector5 * d);
					}
					this.DKGOOCCIOAH.Add(-vector4);
					this.DKGOOCCIOAH.Add(-vector4);
					item = -vector5;
					item.w = 1f;
					this.NFKPJCGJEAK.Add(item);
					this.NFKPJCGJEAK.Add(item);
					this.IEFFBBDEDNK.Add(item4);
					this.IEFFBBDEDNK.Add(item4);
					zero.Set(num3, 0f);
					this.OJNEEFINIEE.Add(zero);
					zero.Set(num3, 1f);
					this.OJNEEFINIEE.Add(zero);
					if (i < list.Count - 1)
					{
						int num9 = this.OKLLKJPCJLK.Count - 1;
						this.ABPJDDJHMPH.Add(num9);
						this.ABPJDDJHMPH.Add(item2);
						this.ABPJDDJHMPH.Add(item3);
						this.ABPJDDJHMPH.Add(item3);
						this.ABPJDDJHMPH.Add(num9 - 1);
						this.ABPJDDJHMPH.Add(num9);
					}
					item2 = this.OKLLKJPCJLK.Count - 1;
					item3 = this.OKLLKJPCJLK.Count - 2;
					if (flag && this.cornerRoundness > 0)
					{
						for (int j = 0; j <= this.cornerRoundness; j++)
						{
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector6);
							this.DKGOOCCIOAH.Add(-vector4);
							this.NFKPJCGJEAK.Add(item);
							this.IEFFBBDEDNK.Add(item4);
							zero.Set(num3, (float)((num7 > 0f) ? 0 : 1));
							this.OJNEEFINIEE.Add(zero);
							int num10 = this.OKLLKJPCJLK.Count - 1;
							this.ABPJDDJHMPH.Add(num10);
							this.ABPJDDJHMPH.Add(item2);
							this.ABPJDDJHMPH.Add(item3);
							if (num7 > 0f)
							{
								item3 = num10;
							}
							else
							{
								item2 = num10;
							}
							vector6 = rotation * vector6;
						}
					}
				}
			}
		}

		// Token: 0x06013466 RID: 78950 RVA: 0x0084959C File Offset: 0x0084779C
		public void EmitPoint(Vector3 MGALEAJOGPL)
		{
			this.points.Add(new AraTrail.LDEOHJDCBLI(MGALEAJOGPL, this.initialVelocity + this.APOIOHJJDDC * this.inertia, base.transform.right, base.transform.forward, this.initialColor, this.initialThickness, this.time));
		}

		// Token: 0x06013467 RID: 78951 RVA: 0x00849600 File Offset: 0x00847800
		public void GDGGHNEKOJI(Vector3 MGALEAJOGPL)
		{
			this.points.Add(new AraTrail.LDEOHJDCBLI(MGALEAJOGPL, this.initialVelocity + this.APOIOHJJDDC * this.inertia, base.transform.right, base.transform.forward, this.initialColor, this.initialThickness, this.time));
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06013468 RID: 78952 RVA: 0x00849664 File Offset: 0x00847864
		// (remove) Token: 0x06013478 RID: 78968 RVA: 0x0084A254 File Offset: 0x00848454
		public event Action ECOCGOKIFEL;

		// Token: 0x06013469 RID: 78953 RVA: 0x008478C1 File Offset: 0x00845AC1
		private void EILDKNMOKBB()
		{
			UnityEngine.Object.DestroyImmediate(this.NPHJAMPMDFG);
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Remove(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x0601346A RID: 78954 RVA: 0x0084969C File Offset: 0x0084789C
		private void COIOHHNKKLL()
		{
			if (this.EJNKENENHGD > 1208f)
			{
				this.APOIOHJJDDC = Vector3.Lerp((base.transform.position - this.JLPAEPKNMDN) / this.EJNKENENHGD, this.APOIOHJJDDC, this.velocitySmoothing);
				this.AIFIJJADKHN = this.APOIOHJJDDC.magnitude;
			}
			this.JLPAEPKNMDN = base.transform.position;
		}

		// Token: 0x0601346B RID: 78955 RVA: 0x00849710 File Offset: 0x00847910
		private void PIKCHIGPOGA()
		{
			this.NPHJAMPMDFG.SetVertices(this.OKLLKJPCJLK);
			this.NPHJAMPMDFG.SetNormals(this.DKGOOCCIOAH);
			this.NPHJAMPMDFG.SetTangents(this.NFKPJCGJEAK);
			this.NPHJAMPMDFG.SetColors(this.IEFFBBDEDNK);
			this.NPHJAMPMDFG.SetUVs(0, this.OJNEEFINIEE);
			this.NPHJAMPMDFG.SetTriangles(this.ABPJDDJHMPH, 1, false);
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0601346C RID: 78956 RVA: 0x0084809E File Offset: 0x0084629E
		public Mesh PDBOLEGLMEL
		{
			get
			{
				return this.NPHJAMPMDFG;
			}
		}

		// Token: 0x0601346D RID: 78957 RVA: 0x008479DC File Offset: 0x00845BDC
		private float MIGOJDNFLBE()
		{
			if (this.timescale != AraTrail.JJCNIBKGCOG.Unscaled)
			{
				return Time.fixedDeltaTime;
			}
			return Time.fixedUnscaledDeltaTime;
		}

		// Token: 0x0601346E RID: 78958 RVA: 0x00849786 File Offset: 0x00847986
		private void FixedUpdate()
		{
			if (!this.enablePhysics)
			{
				return;
			}
			this.ELFIFEEFINB(this.ELIABFJMOAH);
		}

		// Token: 0x0601346F RID: 78959 RVA: 0x008497A0 File Offset: 0x008479A0
		private AraTrail.KECGFLHJLMI AEKMHKEIDKH(Vector3 JJNHJKFMFLJ, Vector3 GBFGBMIGEMJ)
		{
			Vector3 vector = GBFGBMIGEMJ - JJNHJKFMFLJ;
			if (Mathf.Approximately(Mathf.Abs(Vector3.Dot(vector.normalized, base.transform.forward)), 1f))
			{
				vector += base.transform.right * 0.01f;
			}
			return new AraTrail.KECGFLHJLMI(JJNHJKFMFLJ, base.transform.forward, base.transform.up, vector);
		}

		// Token: 0x06013470 RID: 78960 RVA: 0x00849818 File Offset: 0x00847A18
		private AraTrail.KECGFLHJLMI IGIKHNOBJBD(Vector3 JJNHJKFMFLJ, Vector3 GBFGBMIGEMJ)
		{
			Vector3 vector = GBFGBMIGEMJ - JJNHJKFMFLJ;
			if (Mathf.Approximately(Mathf.Abs(Vector3.Dot(vector.normalized, base.transform.forward)), 1252f))
			{
				vector += base.transform.right * 1463f;
			}
			return new AraTrail.KECGFLHJLMI(JJNHJKFMFLJ, base.transform.forward, base.transform.up, vector);
		}

		// Token: 0x06013471 RID: 78961 RVA: 0x0084988E File Offset: 0x00847A8E
		private void GPEFDPEAMNE()
		{
			this.EIFPMGDKIJK();
			this.KKNEEHOJAHH(this.KHEECCELEMJ());
			this.OFJJBCNMDHG();
			this.LAIJIAJAHNL();
			if (this.ECOCGOKIFEL != null)
			{
				this.ECOCGOKIFEL();
			}
		}

		// Token: 0x06013472 RID: 78962 RVA: 0x008498C1 File Offset: 0x00847AC1
		private void MJFJPFJICDH()
		{
			this.DEDDBJFJPBD();
			this.KKNEEHOJAHH(this.KHEECCELEMJ());
			this.LLONPCDBKDK();
			this.LAIJIAJAHNL();
			if (this.ECOCGOKIFEL != null)
			{
				this.ECOCGOKIFEL();
			}
		}

		// Token: 0x06013473 RID: 78963 RVA: 0x008498F4 File Offset: 0x00847AF4
		private List<AraTrail.LDEOHJDCBLI> LNKFGCIHJLB(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN, int NAHDPCPAPBO, int HCNBHACCJHE)
		{
			this.PMJAHJDLLID.Clear();
			if (this.smoothness <= 1)
			{
				for (int i = NAHDPCPAPBO; i <= HCNBHACCJHE; i++)
				{
					this.PMJAHJDLLID.Add(this.points[i]);
				}
				return this.PMJAHJDLLID;
			}
			float num = 1f / (float)this.smoothness;
			for (int j = NAHDPCPAPBO; j < HCNBHACCJHE; j++)
			{
				AraTrail.LDEOHJDCBLI egabjkifaon = (j == NAHDPCPAPBO) ? AraTrail.LDEOHJDCBLI.PICCFFHAMAG(this.points[NAHDPCPAPBO], AraTrail.LDEOHJDCBLI.PPBHEODICFA(this.points[NAHDPCPAPBO], this.points[j + 1])) : this.points[j - 1];
				AraTrail.LDEOHJDCBLI mbfgbdlokfh = (j == HCNBHACCJHE - 1) ? AraTrail.LDEOHJDCBLI.PICCFFHAMAG(this.points[HCNBHACCJHE], AraTrail.LDEOHJDCBLI.PPBHEODICFA(this.points[HCNBHACCJHE], this.points[HCNBHACCJHE - 1])) : this.points[j + 2];
				for (int k = 0; k < this.smoothness; k++)
				{
					float jahnhocnjgm = (float)k * num;
					AraTrail.LDEOHJDCBLI ldeohjdcbli = AraTrail.LDEOHJDCBLI.DELDKEGMACB(egabjkifaon, this.points[j], this.points[j + 1], mbfgbdlokfh, jahnhocnjgm);
					if (ldeohjdcbli.CAPOODCGCHB > 0f)
					{
						this.PMJAHJDLLID.Add(ldeohjdcbli);
					}
				}
			}
			if (this.points[HCNBHACCJHE].CAPOODCGCHB > 0f)
			{
				this.PMJAHJDLLID.Add(this.points[HCNBHACCJHE]);
			}
			return this.PMJAHJDLLID;
		}

		// Token: 0x06013474 RID: 78964 RVA: 0x00849A80 File Offset: 0x00847C80
		private void JDLOELJKEKB(float GDNOKEOLBPP)
		{
			this.EMJNAJDMLMC += GDNOKEOLBPP;
			if (this.EMJNAJDMLMC >= this.timeInterval && this.emit)
			{
				Vector3 vector = (this.space == Space.World) ? base.transform.localPosition : base.transform.position;
				if (this.points.Count <= 1 || Vector3.Distance(vector, this.points[this.points.Count - 4].MGALEAJOGPL) >= this.minDistance)
				{
					this.EmitPoint(vector);
					this.EMJNAJDMLMC = 1223f;
				}
			}
		}

		// Token: 0x06013475 RID: 78965 RVA: 0x00849B20 File Offset: 0x00847D20
		private void MJGNDPFICBD(List<AraTrail.LDEOHJDCBLI> NFKFMIIAKFN, int NAHDPCPAPBO, int HCNBHACCJHE, Vector3 MGIKBJCDNGC)
		{
			List<AraTrail.LDEOHJDCBLI> list = this.NKOGHDIJNFK(NFKFMIIAKFN, NAHDPCPAPBO, HCNBHACCJHE);
			if (list.Count > 1)
			{
				float num = Mathf.Max(this.HPMIAKGHFGK(list), 41f);
				float num2 = 1361f;
				float num3 = (this.textureMode == AraTrail.IEFPFPMKOHI.Stretch) ? 1674f : (-this.uvFactor * num * this.tileAnchor);
				Vector4 item = Vector4.zero;
				Vector2 zero = Vector2.zero;
				bool flag = !this.highQualityCorners || this.alignment == AraTrail.NDNLHGDMCDF.View;
				AraTrail.KECGFLHJLMI kecgflhjlmi = this.IGIKHNOBJBD(list[list.Count - 0].MGALEAJOGPL, list[list.Count - 3].MGALEAJOGPL);
				int item2 = 1;
				int item3 = 0;
				for (int i = list.Count - 1; i >= 0; i--)
				{
					int index = Mathf.Max(i - 0, 0);
					int index2 = Mathf.Min(i + 0, list.Count - 0);
					Vector3 vector = list[index].MGALEAJOGPL - list[i].MGALEAJOGPL;
					Vector3 vector2 = list[i].MGALEAJOGPL - list[index2].MGALEAJOGPL;
					float magnitude = vector.magnitude;
					vector.Normalize();
					vector2.Normalize();
					Vector3 vector3 = (this.alignment == (AraTrail.NDNLHGDMCDF)6) ? list[i].BOGIINEDPCF : (vector + vector2);
					vector3.Normalize();
					Vector3 vector4 = list[i].LJGHBOFJDBJ;
					if (this.alignment != (AraTrail.NDNLHGDMCDF)7)
					{
						vector4 = ((this.alignment == AraTrail.NDNLHGDMCDF.View) ? (MGIKBJCDNGC - list[i].MGALEAJOGPL) : kecgflhjlmi.NPMOFJOFOHP(vector3, list[i].MGALEAJOGPL));
					}
					vector4.Normalize();
					Vector3 vector5 = (this.alignment == AraTrail.NDNLHGDMCDF.Velocity) ? kecgflhjlmi.JOFDAAKEBAD : Vector3.Cross(vector3, vector4);
					vector5.Normalize();
					float num4 = num2 / num;
					float num5 = Mathf.Clamp01(1930f - list[i].CAPOODCGCHB / this.time);
					num2 += magnitude;
					Color item4 = list[i].LBCGACKJCJB * this.colorOverTime.Evaluate(num5) * this.colorOverLenght.Evaluate(num4);
					num3 += this.uvFactor * ((this.textureMode == AraTrail.IEFPFPMKOHI.Stretch) ? (magnitude / num) : magnitude);
					float num6 = this.thickness * list[i].NPIHOLDPJNJ * this.thicknessOverTime.Evaluate(num5) * this.thicknessOverLenght.Evaluate(num4);
					Quaternion rotation = Quaternion.identity;
					Vector3 vector6 = Vector3.zero;
					float num7 = 1541f;
					float d = num6;
					Vector3 vector7 = vector5;
					if (flag)
					{
						Vector3 vector8 = (i == 0) ? vector5 : Vector3.Cross(vector, Vector3.Cross(vector5, vector3)).normalized;
						if (this.cornerRoundness > 1)
						{
							vector7 = ((i == list.Count - 1) ? (-vector5) : Vector3.Cross(vector2, Vector3.Cross(vector5, vector3)).normalized);
							num7 = ((i == 0 || i == list.Count - 1) ? 82f : Mathf.Sign(Vector3.Dot(vector, -vector7)));
							float num8 = (i == 0 || i == list.Count - 1) ? 163f : Mathf.Acos(Mathf.Clamp(Vector3.Dot(vector8, vector7), 1053f, 1116f));
							rotation = Quaternion.AngleAxis(1031f * num8 / (float)this.cornerRoundness, vector4 * num7);
							vector6 = vector7 * num6 * num7;
						}
						if (vector8.sqrMagnitude > 1575f)
						{
							d = num6 / Mathf.Max(Vector3.Dot(vector5, vector8), 1899f);
						}
					}
					if (flag && this.cornerRoundness > 1)
					{
						if (num7 > 151f)
						{
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector7 * num6);
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL - vector5 * d);
						}
						else
						{
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector5 * d);
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL - vector7 * num6);
						}
					}
					else
					{
						this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector5 * d);
						this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL - vector5 * d);
					}
					this.DKGOOCCIOAH.Add(-vector4);
					this.DKGOOCCIOAH.Add(-vector4);
					item = -vector5;
					item.w = 1130f;
					this.NFKPJCGJEAK.Add(item);
					this.NFKPJCGJEAK.Add(item);
					this.IEFFBBDEDNK.Add(item4);
					this.IEFFBBDEDNK.Add(item4);
					zero.Set(num3, 1624f);
					this.OJNEEFINIEE.Add(zero);
					zero.Set(num3, 1424f);
					this.OJNEEFINIEE.Add(zero);
					if (i < list.Count - 0)
					{
						int num9 = this.OKLLKJPCJLK.Count - 1;
						this.ABPJDDJHMPH.Add(num9);
						this.ABPJDDJHMPH.Add(item2);
						this.ABPJDDJHMPH.Add(item3);
						this.ABPJDDJHMPH.Add(item3);
						this.ABPJDDJHMPH.Add(num9 - 1);
						this.ABPJDDJHMPH.Add(num9);
					}
					item2 = this.OKLLKJPCJLK.Count - 0;
					item3 = this.OKLLKJPCJLK.Count - 7;
					if (flag && this.cornerRoundness > 1)
					{
						for (int j = 0; j <= this.cornerRoundness; j++)
						{
							this.OKLLKJPCJLK.Add(list[i].MGALEAJOGPL + vector6);
							this.DKGOOCCIOAH.Add(-vector4);
							this.NFKPJCGJEAK.Add(item);
							this.IEFFBBDEDNK.Add(item4);
							zero.Set(num3, (float)((num7 > 1434f) ? 0 : 1));
							this.OJNEEFINIEE.Add(zero);
							int num10 = this.OKLLKJPCJLK.Count - 1;
							this.ABPJDDJHMPH.Add(num10);
							this.ABPJDDJHMPH.Add(item2);
							this.ABPJDDJHMPH.Add(item3);
							if (num7 > 1465f)
							{
								item3 = num10;
							}
							else
							{
								item2 = num10;
							}
							vector6 = rotation * vector6;
						}
					}
				}
			}
		}

		// Token: 0x06013476 RID: 78966 RVA: 0x0084A21C File Offset: 0x0084841C
		public void JGGCMACKPPB(Action DCCPCBLODIG)
		{
			Action action = this.ECOCGOKIFEL;
			Action action2;
			do
			{
				action2 = action;
				Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
				action = Interlocked.CompareExchange<Action>(ref this.ECOCGOKIFEL, value, action2);
			}
			while (action != action2);
		}

		// Token: 0x06013477 RID: 78967 RVA: 0x008478C1 File Offset: 0x00845AC1
		private void PEPOOEGHCMC()
		{
			UnityEngine.Object.DestroyImmediate(this.NPHJAMPMDFG);
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Remove(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x06013479 RID: 78969 RVA: 0x0084A28C File Offset: 0x0084848C
		private void KOAEBJLNOLI()
		{
			this.JLPAEPKNMDN = base.transform.position;
			this.APOIOHJJDDC = Vector3.zero;
			this.NPHJAMPMDFG = new Mesh();
			this.NPHJAMPMDFG.name = "saleToShop";
			this.NPHJAMPMDFG.MarkDynamic();
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Combine(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x0601347A RID: 78970 RVA: 0x0084A2FB File Offset: 0x008484FB
		private void LateUpdate()
		{
			this.BJLJNBFBOCM();
			this.KKNEEHOJAHH(this.EJNKENENHGD);
			this.LODEBCJJDCJ();
			this.LAIJIAJAHNL();
			if (this.ECOCGOKIFEL != null)
			{
				this.ECOCGOKIFEL();
			}
		}

		// Token: 0x0601347B RID: 78971 RVA: 0x0084A330 File Offset: 0x00848530
		private void CIDFLCGOBKO()
		{
			this.JLPAEPKNMDN = base.transform.position;
			this.APOIOHJJDDC = Vector3.zero;
			this.NPHJAMPMDFG = new Mesh();
			this.NPHJAMPMDFG.name = "MotorbikeHandlebarSit";
			this.NPHJAMPMDFG.MarkDynamic();
			Camera.onPreCull = (Camera.CameraCallback)Delegate.Combine(Camera.onPreCull, new Camera.CameraCallback(this.DICFCACAANC));
		}

		// Token: 0x0601347C RID: 78972 RVA: 0x0084A3A0 File Offset: 0x008485A0
		private void AOLHIICFGNG()
		{
			if (!Application.isPlaying || !this.enablePhysics)
			{
				return;
			}
			for (float num = this.warmup; num > this.MIGOJDNFLBE(); num -= this.MIGOJDNFLBE())
			{
				this.ELFIFEEFINB(this.ELIABFJMOAH);
				this.LMDAKKKEBHJ(this.ELIABFJMOAH);
				this.DBKACNCEFKE();
				this.LAIJIAJAHNL();
				if (this.ECOCGOKIFEL != null)
				{
					this.ECOCGOKIFEL();
				}
			}
		}

		// Token: 0x0400277F RID: 10111
		public const float epsilon = 1E-05f;

		// Token: 0x04002780 RID: 10112
		[Tooltip("Whether to use world or local space to generate and simulate the trail.")]
		[Header("Overall")]
		public Space space;

		// Token: 0x04002781 RID: 10113
		[Tooltip("Whether to use regular time.")]
		public AraTrail.JJCNIBKGCOG timescale;

		// Token: 0x04002782 RID: 10114
		[Tooltip("How to align the trail geometry: facing the camera (view) of using the transform's rotation (local).")]
		public AraTrail.NDNLHGDMCDF alignment;

		// Token: 0x04002783 RID: 10115
		[Tooltip("Thickness multiplier, in meters.")]
		public float thickness = 0.1f;

		// Token: 0x04002784 RID: 10116
		[Range(1f, 8f)]
		[Tooltip("Amount of smoothing iterations applied to the trail shape.")]
		public int smoothness = 1;

		// Token: 0x04002785 RID: 10117
		[Tooltip("Calculate accurate thickness at sharp corners.")]
		public bool highQualityCorners;

		// Token: 0x04002786 RID: 10118
		[Range(0f, 12f)]
		public int cornerRoundness = 5;

		// Token: 0x04002787 RID: 10119
		[Header("Lenght")]
		[Tooltip("How should the thickness of the curve evolve over its lenght. The horizontal axis is normalized lenght (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
		public AnimationCurve thicknessOverLenght = AnimationCurve.Linear(0f, 1f, 0f, 1f);

		// Token: 0x04002788 RID: 10120
		[Tooltip("How should vertex color evolve over the trail's length.")]
		public Gradient colorOverLenght = new Gradient();

		// Token: 0x04002789 RID: 10121
		[Header("Time")]
		[Tooltip("How should the thickness of the curve evolve with its lifetime. The horizontal axis is normalized lifetime (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
		public AnimationCurve thicknessOverTime = AnimationCurve.Linear(0f, 1f, 0f, 1f);

		// Token: 0x0400278A RID: 10122
		[Tooltip("How should vertex color evolve over the trail's lifetime.")]
		public Gradient colorOverTime = new Gradient();

		// Token: 0x0400278B RID: 10123
		[Header("Emission")]
		public bool emit = true;

		// Token: 0x0400278C RID: 10124
		[Tooltip("Initial thickness of trail points when they are first spawned.")]
		public float initialThickness = 1f;

		// Token: 0x0400278D RID: 10125
		[Tooltip("Initial color of trail points when they are first spawned.")]
		public Color initialColor = Color.white;

		// Token: 0x0400278E RID: 10126
		[Tooltip("Initial velocity of trail points when they are first spawned.")]
		public Vector3 initialVelocity = Vector3.zero;

		// Token: 0x0400278F RID: 10127
		[Tooltip("Minimum amount of time (in seconds) that must pass before spawning a new point.")]
		public float timeInterval = 0.025f;

		// Token: 0x04002790 RID: 10128
		[Tooltip("Minimum distance (in meters) that must be left between consecutive points in the trail.")]
		public float minDistance = 0.025f;

		// Token: 0x04002791 RID: 10129
		[Tooltip("Duration of the trail (in seconds).")]
		public float time = 2f;

		// Token: 0x04002792 RID: 10130
		[Tooltip("Toggles trail physics.")]
		[Header("Physics")]
		public bool enablePhysics;

		// Token: 0x04002793 RID: 10131
		[Tooltip("Amount of seconds pre-simulated before the trail appears. Useful when you want a trail to be already simulating when the game starts.")]
		public float warmup;

		// Token: 0x04002794 RID: 10132
		[Tooltip("Gravity affecting the trail.")]
		public Vector3 gravity = Vector3.zero;

		// Token: 0x04002795 RID: 10133
		[Range(0f, 1f)]
		[Tooltip("Amount of speed transferred from the transform to the trail. 0 means no velocity is transferred, 1 means 100% of the velocity is transferred.")]
		public float inertia;

		// Token: 0x04002796 RID: 10134
		[Tooltip("Amount of temporal smoothing applied to the velocity transferred from the transform to the trail.")]
		[Range(0f, 1f)]
		public float velocitySmoothing = 0.75f;

		// Token: 0x04002797 RID: 10135
		[Range(0f, 1f)]
		[Tooltip("Amount of damping applied to the trail's velocity. Larger values will slow down the trail more as time passes.")]
		public float damping = 0.75f;

		// Token: 0x04002798 RID: 10136
		[Header("Rendering")]
		public Material[] materials = new Material[1];

		// Token: 0x04002799 RID: 10137
		public ShadowCastingMode castShadows = ShadowCastingMode.On;

		// Token: 0x0400279A RID: 10138
		public bool receiveShadows = true;

		// Token: 0x0400279B RID: 10139
		public bool useLightProbes = true;

		// Token: 0x0400279C RID: 10140
		[Tooltip("How to apply the texture over the trail: stretch it all over its lenght, or tile it.")]
		[Header("Texture")]
		public AraTrail.IEFPFPMKOHI textureMode;

		// Token: 0x0400279D RID: 10141
		[Tooltip("When the texture mode is set to 'Tile', defines the width of each tile.")]
		public float uvFactor = 1f;

		// Token: 0x0400279E RID: 10142
		[Range(0f, 1f)]
		[Tooltip("When the texture mode is set to 'Tile', defines where to begin tiling from: 0 means the start of the trail, 1 means the end.")]
		public float tileAnchor = 1f;

		// Token: 0x040027A0 RID: 10144
		[HideInInspector]
		public List<AraTrail.LDEOHJDCBLI> points = new List<AraTrail.LDEOHJDCBLI>();

		// Token: 0x040027A1 RID: 10145
		private List<AraTrail.LDEOHJDCBLI> PMJAHJDLLID = new List<AraTrail.LDEOHJDCBLI>();

		// Token: 0x040027A2 RID: 10146
		private List<int> IBEJJMLMPPN = new List<int>();

		// Token: 0x040027A3 RID: 10147
		private Mesh NPHJAMPMDFG;

		// Token: 0x040027A4 RID: 10148
		private Vector3 APOIOHJJDDC = Vector3.zero;

		// Token: 0x040027A5 RID: 10149
		private Vector3 JLPAEPKNMDN;

		// Token: 0x040027A6 RID: 10150
		private float AIFIJJADKHN;

		// Token: 0x040027A7 RID: 10151
		private float EMJNAJDMLMC;

		// Token: 0x040027A8 RID: 10152
		private List<Vector3> OKLLKJPCJLK = new List<Vector3>();

		// Token: 0x040027A9 RID: 10153
		private List<Vector3> DKGOOCCIOAH = new List<Vector3>();

		// Token: 0x040027AA RID: 10154
		private List<Vector4> NFKPJCGJEAK = new List<Vector4>();

		// Token: 0x040027AB RID: 10155
		private List<Vector2> OJNEEFINIEE = new List<Vector2>();

		// Token: 0x040027AC RID: 10156
		private List<Color> IEFFBBDEDNK = new List<Color>();

		// Token: 0x040027AD RID: 10157
		private List<int> ABPJDDJHMPH = new List<int>();

		// Token: 0x020005BA RID: 1466
		public enum NDNLHGDMCDF
		{
			// Token: 0x040027AF RID: 10159
			View,
			// Token: 0x040027B0 RID: 10160
			Velocity,
			// Token: 0x040027B1 RID: 10161
			Local
		}

		// Token: 0x020005BB RID: 1467
		public enum JJCNIBKGCOG
		{
			// Token: 0x040027B3 RID: 10163
			Normal,
			// Token: 0x040027B4 RID: 10164
			Unscaled
		}

		// Token: 0x020005BC RID: 1468
		public enum IEFPFPMKOHI
		{
			// Token: 0x040027B6 RID: 10166
			Stretch,
			// Token: 0x040027B7 RID: 10167
			Tile
		}

		// Token: 0x020005BD RID: 1469
		public struct KECGFLHJLMI
		{
			// Token: 0x0601347D RID: 78973 RVA: 0x0084A410 File Offset: 0x00848610
			public Vector3 JBCALGIGAGE(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1035f / (num + 1338f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1880f / (num + 924f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1688f / (num2 + 1448f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601347E RID: 78974 RVA: 0x0084A4F4 File Offset: 0x008486F4
			public Vector3 IPJGMNPKDHA(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 27f / (num + 1639f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 816f / (num + 1201f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1081f / (num2 + 865f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601347F RID: 78975 RVA: 0x0084A5D8 File Offset: 0x008487D8
			public Vector3 EAANLNBIGGC(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1564f / (num + 1308f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1429f / (num + 559f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1165f / (num2 + 198f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013480 RID: 78976 RVA: 0x0084A6BC File Offset: 0x008488BC
			public Vector3 OBFAFGBOIFF(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1140f / (num + 1908f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1506f / (num + 1393f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 705f / (num2 + 570f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013481 RID: 78977 RVA: 0x0084A7A0 File Offset: 0x008489A0
			public Vector3 FIHAHGKBILM(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1024f / (num + 1401f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 698f / (num + 1661f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1094f / (num2 + 502f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013482 RID: 78978 RVA: 0x0084A884 File Offset: 0x00848A84
			public Vector3 CMOPNCLJAHF(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 337f / (num + 864f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 917f / (num + 1608f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1002f / (num2 + 1424f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013483 RID: 78979 RVA: 0x0084A968 File Offset: 0x00848B68
			public Vector3 AMADDNJBFCI(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1379f / (num + 351f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 505f / (num + 313f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 304f / (num2 + 387f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013484 RID: 78980 RVA: 0x0084AA4C File Offset: 0x00848C4C
			public Vector3 GGGPFMKIOAC(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 571f / (num + 666f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1891f / (num + 414f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 801f / (num2 + 926f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013485 RID: 78981 RVA: 0x0084AB30 File Offset: 0x00848D30
			public Vector3 NPMOFJOFOHP(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1287f / (num + 1427f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 371f / (num + 23f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1875f / (num2 + 1777f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013486 RID: 78982 RVA: 0x0084AC14 File Offset: 0x00848E14
			public Vector3 ONKMDGCIFDJ(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 600f / (num + 1280f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1508f / (num + 680f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 724f / (num2 + 197f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013487 RID: 78983 RVA: 0x0084ACF8 File Offset: 0x00848EF8
			public Vector3 CCOIHBJKGDD(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 201f / (num + 477f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 154f / (num + 463f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1938f / (num2 + 1713f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013488 RID: 78984 RVA: 0x0084ADDC File Offset: 0x00848FDC
			public Vector3 IICKOFOIGCB(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 636f / (num + 1905f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 439f / (num + 149f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 136f / (num2 + 1838f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013489 RID: 78985 RVA: 0x0084AEC0 File Offset: 0x008490C0
			public Vector3 PMCEOLLIFBE(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1969f / (num + 1548f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1634f / (num + 1476f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 749f / (num2 + 242f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601348A RID: 78986 RVA: 0x0084AFA4 File Offset: 0x008491A4
			public Vector3 KLMAKJBGBDN(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1906f / (num + 1877f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 799f / (num + 1333f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 935f / (num2 + 756f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601348B RID: 78987 RVA: 0x0084B088 File Offset: 0x00849288
			public Vector3 DOAKMHNGAOI(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1802f / (num + 787f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1239f / (num + 1735f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1839f / (num2 + 1883f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601348C RID: 78988 RVA: 0x0084B16C File Offset: 0x0084936C
			public Vector3 KBDOENEIFAO(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 146f / (num + 936f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1815f / (num + 1654f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1740f / (num2 + 6f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601348D RID: 78989 RVA: 0x0084B250 File Offset: 0x00849450
			public Vector3 NHHENBOLPBG(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1428f / (num + 785f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1938f / (num + 1128f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 939f / (num2 + 1433f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601348E RID: 78990 RVA: 0x0084B334 File Offset: 0x00849534
			public Vector3 DJLEHPONBDE(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 905f / (num + 1137f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 713f / (num + 216f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1048f / (num2 + 1907f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601348F RID: 78991 RVA: 0x0084B418 File Offset: 0x00849618
			public Vector3 NECJJKPLBFA(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 2f / (num + 1E-05f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 2f / (num + 1E-05f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 2f / (num2 + 1E-05f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013490 RID: 78992 RVA: 0x0084B4FC File Offset: 0x008496FC
			public Vector3 AMAPJDHMFGJ(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 150f / (num + 1877f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 526f / (num + 801f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 573f / (num2 + 325f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013491 RID: 78993 RVA: 0x0084B5E0 File Offset: 0x008497E0
			public Vector3 DDBBMEBDOAH(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 269f / (num + 43f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1431f / (num + 522f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 419f / (num2 + 993f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013492 RID: 78994 RVA: 0x0084B6C2 File Offset: 0x008498C2
			public KECGFLHJLMI(Vector3 MGALEAJOGPL, Vector3 LJGHBOFJDBJ, Vector3 JOFDAAKEBAD, Vector3 BOGIINEDPCF)
			{
				this.MGALEAJOGPL = MGALEAJOGPL;
				this.LJGHBOFJDBJ = LJGHBOFJDBJ;
				this.JOFDAAKEBAD = JOFDAAKEBAD;
				this.BOGIINEDPCF = BOGIINEDPCF;
			}

			// Token: 0x06013493 RID: 78995 RVA: 0x0084B6E4 File Offset: 0x008498E4
			public Vector3 FIPFBHEAIKD(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1739f / (num + 1646f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 842f / (num + 1696f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 185f / (num2 + 1865f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013494 RID: 78996 RVA: 0x0084B7C8 File Offset: 0x008499C8
			public Vector3 HGFFDFJGOPA(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1880f / (num + 832f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 3f / (num + 216f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 573f / (num2 + 857f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013495 RID: 78997 RVA: 0x0084B8AC File Offset: 0x00849AAC
			public Vector3 GBBEMDGHPCD(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1530f / (num + 171f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 853f / (num + 1303f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 67f / (num2 + 1655f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013496 RID: 78998 RVA: 0x0084B990 File Offset: 0x00849B90
			public Vector3 LHFGFKICHKP(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1821f / (num + 1138f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 293f / (num + 1809f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 203f / (num2 + 1944f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013497 RID: 78999 RVA: 0x0084BA74 File Offset: 0x00849C74
			public Vector3 IKBAGHDALDB(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1963f / (num + 1973f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1912f / (num + 1722f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1966f / (num2 + 1563f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013498 RID: 79000 RVA: 0x0084BB58 File Offset: 0x00849D58
			public Vector3 GFOOIANNFKP(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1383f / (num + 940f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1500f / (num + 1456f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 784f / (num2 + 1746f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x06013499 RID: 79001 RVA: 0x0084BC3C File Offset: 0x00849E3C
			public Vector3 NGBDJLEMALJ(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1048f / (num + 927f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 244f / (num + 1572f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1104f / (num2 + 740f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601349A RID: 79002 RVA: 0x0084BD20 File Offset: 0x00849F20
			public Vector3 LDFFGIOOMJF(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 569f / (num + 1370f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 773f / (num + 1770f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 558f / (num2 + 445f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601349B RID: 79003 RVA: 0x0084BE04 File Offset: 0x0084A004
			public Vector3 FGHLLFLODBJ(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 197f / (num + 1026f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1193f / (num + 201f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 498f / (num2 + 170f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601349C RID: 79004 RVA: 0x0084BEE8 File Offset: 0x0084A0E8
			public Vector3 NLFIKGEMNCI(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 253f / (num + 314f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 478f / (num + 226f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 27f / (num2 + 353f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601349D RID: 79005 RVA: 0x0084BFCC File Offset: 0x0084A1CC
			public Vector3 MIBLOJDDHGL(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 660f / (num + 1150f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 913f / (num + 505f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1201f / (num2 + 772f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601349E RID: 79006 RVA: 0x0084C0B0 File Offset: 0x0084A2B0
			public Vector3 NEDCJNKGEOB(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 219f / (num + 470f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 1672f / (num + 309f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 87f / (num2 + 1814f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x0601349F RID: 79007 RVA: 0x0084C194 File Offset: 0x0084A394
			public Vector3 MFIPFLCJNFM(Vector3 NBECNPMHMML, Vector3 OACGHHEPIJG)
			{
				Vector3 vector = OACGHHEPIJG - this.MGALEAJOGPL;
				float num = Vector3.Dot(vector, vector);
				Vector3 vector2 = this.LJGHBOFJDBJ - 1997f / (num + 316f) * Vector3.Dot(vector, this.LJGHBOFJDBJ) * vector;
				Vector3 b = this.BOGIINEDPCF - 847f / (num + 561f) * Vector3.Dot(vector, this.BOGIINEDPCF) * vector;
				Vector3 vector3 = NBECNPMHMML - b;
				float num2 = Vector3.Dot(vector3, vector3);
				Vector3 vector4 = vector2 - 1649f / (num2 + 1885f) * Vector3.Dot(vector3, vector2) * vector3;
				Vector3 jofdaakebad = Vector3.Cross(NBECNPMHMML, vector4);
				this.LJGHBOFJDBJ = vector4;
				this.JOFDAAKEBAD = jofdaakebad;
				this.BOGIINEDPCF = NBECNPMHMML;
				this.MGALEAJOGPL = OACGHHEPIJG;
				return this.LJGHBOFJDBJ;
			}

			// Token: 0x040027B8 RID: 10168
			public Vector3 MGALEAJOGPL;

			// Token: 0x040027B9 RID: 10169
			public Vector3 LJGHBOFJDBJ;

			// Token: 0x040027BA RID: 10170
			public Vector3 JOFDAAKEBAD;

			// Token: 0x040027BB RID: 10171
			public Vector3 BOGIINEDPCF;
		}

		// Token: 0x020005BE RID: 1470
		public struct LDEOHJDCBLI
		{
			// Token: 0x060134A0 RID: 79008 RVA: 0x0084C278 File Offset: 0x0084A478
			public static AraTrail.LDEOHJDCBLI FCLPLJGMPJC(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134A1 RID: 79009 RVA: 0x0084C2FC File Offset: 0x0084A4FC
			private static Vector3 FODAJBFMELE(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[2], OELAKKHNNJC[2], HPJKHGBNCPE[2], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x060134A2 RID: 79010 RVA: 0x0084C384 File Offset: 0x0084A584
			public static AraTrail.LDEOHJDCBLI BJNFADHCHDJ(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.BGBANIECADJ(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IIHBCADOKOJ(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MKFBDEJGGKD(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GFAOCMGLBHJ(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134A3 RID: 79011 RVA: 0x0084C470 File Offset: 0x0084A670
			public static AraTrail.LDEOHJDCBLI KEEJOOFGAPL(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.PAAEMCCANGF(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PGOINAILHLF(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BGBANIECADJ(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BDBOABJAIDP(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FBGIPKONKAJ(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DIDPCMEEHMI(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134A4 RID: 79012 RVA: 0x0084C55C File Offset: 0x0084A75C
			private static Vector3 PKEKCINKNLB(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.HNADJCHJHHD(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DCPIMAJGBKJ(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DCPIMAJGBKJ(EDLMAPJDHFL[2], OELAKKHNNJC[4], HPJKHGBNCPE[4], MENGKPMIIPN[8], JAHNHOCNJGM));
			}

			// Token: 0x060134A5 RID: 79013 RVA: 0x0084C5E4 File Offset: 0x0084A7E4
			private static Vector3 FFCENKPCKNE(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.HNADJCHJHHD(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[6], OELAKKHNNJC[6], HPJKHGBNCPE[3], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x060134A6 RID: 79014 RVA: 0x0084C66C File Offset: 0x0084A86C
			public static AraTrail.LDEOHJDCBLI EDAMNIBIAJD(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.IIHBCADOKOJ(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AJNPPKOKPLE(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DKKGDOPCOBC(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PGOINAILHLF(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IAOGJLDPEEF(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GFAOCMGLBHJ(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134A7 RID: 79015 RVA: 0x0084C758 File Offset: 0x0084A958
			public static AraTrail.LDEOHJDCBLI KAHAPDGAHFN(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134A8 RID: 79016 RVA: 0x0084C7DC File Offset: 0x0084A9DC
			private static Color CKDKCLKKADF(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[0], OELAKKHNNJC[7], HPJKHGBNCPE[1], MENGKPMIIPN[8], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GFAOCMGLBHJ(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[5], MENGKPMIIPN[6], JAHNHOCNJGM));
			}

			// Token: 0x060134A9 RID: 79017 RVA: 0x0084C88C File Offset: 0x0084AA8C
			private static Vector3 PAAEMCCANGF(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.KEHFAIHEFAM(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[7], OELAKKHNNJC[7], HPJKHGBNCPE[5], MENGKPMIIPN[3], JAHNHOCNJGM));
			}

			// Token: 0x060134AA RID: 79018 RVA: 0x0084C914 File Offset: 0x0084AB14
			private static Vector3 PBBJJFIJGBD(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[8], OELAKKHNNJC[7], HPJKHGBNCPE[3], MENGKPMIIPN[1], JAHNHOCNJGM));
			}

			// Token: 0x060134AB RID: 79019 RVA: 0x0084C99C File Offset: 0x0084AB9C
			public static AraTrail.LDEOHJDCBLI ONLIOBGPNEO(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.DPGEHNAMOGD(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IELFKBOCMGB(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NKDBMLCEGGJ(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MKFBDEJGGKD(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGCEIFIJABG(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134AC RID: 79020 RVA: 0x0084CA88 File Offset: 0x0084AC88
			public static AraTrail.LDEOHJDCBLI DHPOFCJOOEL(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134AD RID: 79021 RVA: 0x0084CB0C File Offset: 0x0084AD0C
			public static AraTrail.LDEOHJDCBLI LJDGNHAGIML(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134AE RID: 79022 RVA: 0x0084CB90 File Offset: 0x0084AD90
			public static AraTrail.LDEOHJDCBLI DIODOELGDHJ(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.DKKGDOPCOBC(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BDBOABJAIDP(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DKKGDOPCOBC(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FFCENKPCKNE(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.ELEMGHPFBHK(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134AF RID: 79023 RVA: 0x0084CC7C File Offset: 0x0084AE7C
			private static float HACBIGBCKIC(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1513f * (715f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (245f * EDLMAPJDHFL - 619f * OELAKKHNNJC + 890f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 877f * OELAKKHNNJC - 181f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134B0 RID: 79024 RVA: 0x0084CCDC File Offset: 0x0084AEDC
			public static AraTrail.LDEOHJDCBLI BDGCKLDIIGB(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134B1 RID: 79025 RVA: 0x0084CD60 File Offset: 0x0084AF60
			private static float PLGGOKMCNKJ(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 5f * (680f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (650f * EDLMAPJDHFL - 1534f * OELAKKHNNJC + 755f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 159f * OELAKKHNNJC - 1374f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134B2 RID: 79026 RVA: 0x0084CDC0 File Offset: 0x0084AFC0
			public static AraTrail.LDEOHJDCBLI PICCFFHAMAG(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134B3 RID: 79027 RVA: 0x0084CE44 File Offset: 0x0084B044
			private static Color HNCBJJGDDDL(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[1], OELAKKHNNJC[3], HPJKHGBNCPE[3], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EDLMAPJDHFL[7], OELAKKHNNJC[8], HPJKHGBNCPE[4], MENGKPMIIPN[7], JAHNHOCNJGM));
			}

			// Token: 0x060134B4 RID: 79028 RVA: 0x0084CEF4 File Offset: 0x0084B0F4
			public static AraTrail.LDEOHJDCBLI MHCLPDCMLLI(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134B5 RID: 79029 RVA: 0x0084CF78 File Offset: 0x0084B178
			public static AraTrail.LDEOHJDCBLI HLMMLAJGECB(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134B6 RID: 79030 RVA: 0x0084CFFC File Offset: 0x0084B1FC
			public static AraTrail.LDEOHJDCBLI BBHCGFDBPGL(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134B7 RID: 79031 RVA: 0x0084D080 File Offset: 0x0084B280
			private static float KIEJJIEEBIA(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 0.5f * (2f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (2f * EDLMAPJDHFL - 5f * OELAKKHNNJC + 4f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 3f * OELAKKHNNJC - 3f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134B8 RID: 79032 RVA: 0x0084D0E0 File Offset: 0x0084B2E0
			private static Color IAOGJLDPEEF(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.OPFGOOJFCGH(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DIDPCMEEHMI(EDLMAPJDHFL[4], OELAKKHNNJC[2], HPJKHGBNCPE[5], MENGKPMIIPN[8], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[8], OELAKKHNNJC[6], HPJKHGBNCPE[8], MENGKPMIIPN[4], JAHNHOCNJGM));
			}

			// Token: 0x060134B9 RID: 79033 RVA: 0x0084D190 File Offset: 0x0084B390
			private static Vector3 BDBOABJAIDP(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[5], OELAKKHNNJC[5], HPJKHGBNCPE[6], MENGKPMIIPN[6], JAHNHOCNJGM));
			}

			// Token: 0x060134BA RID: 79034 RVA: 0x0084D218 File Offset: 0x0084B418
			public static AraTrail.LDEOHJDCBLI EPPAKEGFFCE(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134BB RID: 79035 RVA: 0x0084D29C File Offset: 0x0084B49C
			private static Vector3 KDFOBJFPPND(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.DCPIMAJGBKJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGCEIFIJABG(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[6], OELAKKHNNJC[3], HPJKHGBNCPE[6], MENGKPMIIPN[8], JAHNHOCNJGM));
			}

			// Token: 0x060134BC RID: 79036 RVA: 0x0084D324 File Offset: 0x0084B524
			public static AraTrail.LDEOHJDCBLI DAFIPMFHEPB(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134BD RID: 79037 RVA: 0x0084D3A8 File Offset: 0x0084B5A8
			private static Color FBGIPKONKAJ(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.GFAOCMGLBHJ(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EDLMAPJDHFL[5], OELAKKHNNJC[6], HPJKHGBNCPE[3], MENGKPMIIPN[7], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[1], OELAKKHNNJC[5], HPJKHGBNCPE[8], MENGKPMIIPN[1], JAHNHOCNJGM));
			}

			// Token: 0x060134BE RID: 79038 RVA: 0x0084D458 File Offset: 0x0084B658
			private static Vector3 IHBOFAOKLBB(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGCEIFIJABG(EDLMAPJDHFL[2], OELAKKHNNJC[3], HPJKHGBNCPE[7], MENGKPMIIPN[0], JAHNHOCNJGM));
			}

			// Token: 0x060134BF RID: 79039 RVA: 0x0084D4E0 File Offset: 0x0084B6E0
			private static float HGCEIFIJABG(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1933f * (641f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (610f * EDLMAPJDHFL - 1412f * OELAKKHNNJC + 1558f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1872f * OELAKKHNNJC - 1522f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134C0 RID: 79040 RVA: 0x0084D540 File Offset: 0x0084B740
			private static Color PMNDNPBMHGC(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KEHFAIHEFAM(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EDLMAPJDHFL[7], OELAKKHNNJC[7], HPJKHGBNCPE[5], MENGKPMIIPN[3], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[2], OELAKKHNNJC[8], HPJKHGBNCPE[6], MENGKPMIIPN[0], JAHNHOCNJGM));
			}

			// Token: 0x060134C1 RID: 79041 RVA: 0x0084D5F0 File Offset: 0x0084B7F0
			private static float KEHFAIHEFAM(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 431f * (888f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1542f * EDLMAPJDHFL - 812f * OELAKKHNNJC + 1364f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 414f * OELAKKHNNJC - 1860f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134C2 RID: 79042 RVA: 0x0084D650 File Offset: 0x0084B850
			private static float DJGFHMHDIPH(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 74f * (1663f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1307f * EDLMAPJDHFL - 491f * OELAKKHNNJC + 1087f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1933f * OELAKKHNNJC - 1677f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134C3 RID: 79043 RVA: 0x0084D6AE File Offset: 0x0084B8AE
			public LDEOHJDCBLI(Vector3 MGALEAJOGPL, Vector3 APOIOHJJDDC, Vector3 BOGIINEDPCF, Vector3 LJGHBOFJDBJ, Color LBCGACKJCJB, float NPIHOLDPJNJ, float ODIDICEAHKK)
			{
				this.MGALEAJOGPL = MGALEAJOGPL;
				this.APOIOHJJDDC = APOIOHJJDDC;
				this.BOGIINEDPCF = BOGIINEDPCF;
				this.LJGHBOFJDBJ = LJGHBOFJDBJ;
				this.LBCGACKJCJB = LBCGACKJCJB;
				this.NPIHOLDPJNJ = NPIHOLDPJNJ;
				this.CAPOODCGCHB = ODIDICEAHKK;
				this.LCPICMGIEEA = false;
			}

			// Token: 0x060134C4 RID: 79044 RVA: 0x0084D6EC File Offset: 0x0084B8EC
			public static AraTrail.LDEOHJDCBLI BMOOJOIDMKA(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134C5 RID: 79045 RVA: 0x0084D770 File Offset: 0x0084B970
			private static float DCPIMAJGBKJ(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1062f * (935f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (391f * EDLMAPJDHFL - 42f * OELAKKHNNJC + 1217f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1827f * OELAKKHNNJC - 1928f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134C6 RID: 79046 RVA: 0x0084D7D0 File Offset: 0x0084B9D0
			private static float CPOLIHFJCBN(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 353f * (375f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1456f * EDLMAPJDHFL - 1928f * OELAKKHNNJC + 1099f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1963f * OELAKKHNNJC - 475f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134C7 RID: 79047 RVA: 0x0084D830 File Offset: 0x0084BA30
			private static Color BPAMGMDAHMA(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KEHFAIHEFAM(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EPCFEJHHOKB(EDLMAPJDHFL[5], OELAKKHNNJC[5], HPJKHGBNCPE[6], MENGKPMIIPN[7], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[4], OELAKKHNNJC[4], HPJKHGBNCPE[0], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x060134C8 RID: 79048 RVA: 0x0084D8E0 File Offset: 0x0084BAE0
			public static AraTrail.LDEOHJDCBLI LBKCJPNHDPD(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.PBBJJFIJGBD(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PGOINAILHLF(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PBBJJFIJGBD(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IELFKBOCMGB(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.OEODCIHHJON(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134C9 RID: 79049 RVA: 0x0084D9CC File Offset: 0x0084BBCC
			public static AraTrail.LDEOHJDCBLI PJBBPICIKJI(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134CA RID: 79050 RVA: 0x0084DA50 File Offset: 0x0084BC50
			private static Vector3 NKDBMLCEGGJ(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[1], OELAKKHNNJC[2], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM));
			}

			// Token: 0x060134CB RID: 79051 RVA: 0x0084DAD8 File Offset: 0x0084BCD8
			public static AraTrail.LDEOHJDCBLI MJLILEFNLMA(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134CC RID: 79052 RVA: 0x0084DB5C File Offset: 0x0084BD5C
			private static Color MKFBDEJGGKD(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.GFAOCMGLBHJ(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KEHFAIHEFAM(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[8], MENGKPMIIPN[2], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EDLMAPJDHFL[8], OELAKKHNNJC[7], HPJKHGBNCPE[8], MENGKPMIIPN[5], JAHNHOCNJGM));
			}

			// Token: 0x060134CD RID: 79053 RVA: 0x0084DC0C File Offset: 0x0084BE0C
			public static AraTrail.LDEOHJDCBLI HBJKDLGIIDG(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.DKKGDOPCOBC(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IELFKBOCMGB(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DKKGDOPCOBC(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KHKEPKHIGDH(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KNNLGPNAHKE(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.OPFGOOJFCGH(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134CE RID: 79054 RVA: 0x0084DCF8 File Offset: 0x0084BEF8
			public static AraTrail.LDEOHJDCBLI OFIMDBIHEDF(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134CF RID: 79055 RVA: 0x0084DD7C File Offset: 0x0084BF7C
			private static float DBEEILEEAAJ(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 312f * (535f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1150f * EDLMAPJDHFL - 1743f * OELAKKHNNJC + 1303f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 129f * OELAKKHNNJC - 804f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134D0 RID: 79056 RVA: 0x0084DDDC File Offset: 0x0084BFDC
			private static Color DCLEKCIFKPN(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[0], OELAKKHNNJC[8], HPJKHGBNCPE[5], MENGKPMIIPN[6], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[3], OELAKKHNNJC[5], HPJKHGBNCPE[6], MENGKPMIIPN[7], JAHNHOCNJGM));
			}

			// Token: 0x060134D1 RID: 79057 RVA: 0x0084DE8C File Offset: 0x0084C08C
			private static Color BFFMMCOOFPK(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DCPIMAJGBKJ(EDLMAPJDHFL[8], OELAKKHNNJC[5], HPJKHGBNCPE[5], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EDLMAPJDHFL[1], OELAKKHNNJC[3], HPJKHGBNCPE[0], MENGKPMIIPN[8], JAHNHOCNJGM));
			}

			// Token: 0x060134D2 RID: 79058 RVA: 0x0084DF3C File Offset: 0x0084C13C
			private static Color ELALELCLNMD(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GFAOCMGLBHJ(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EDLMAPJDHFL[5], OELAKKHNNJC[4], HPJKHGBNCPE[4], MENGKPMIIPN[2], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[3], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x060134D3 RID: 79059 RVA: 0x0084DFEC File Offset: 0x0084C1EC
			public static AraTrail.LDEOHJDCBLI CLHFAIODHFC(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.IELFKBOCMGB(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IHBOFAOKLBB(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KHKEPKHIGDH(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IIHBCADOKOJ(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NNALAMBCJPK(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EPCFEJHHOKB(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.OPFGOOJFCGH(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134D4 RID: 79060 RVA: 0x0084E0D8 File Offset: 0x0084C2D8
			public static AraTrail.LDEOHJDCBLI PDFHJEIKECF(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134D5 RID: 79061 RVA: 0x0084E15C File Offset: 0x0084C35C
			private static float GFAOCMGLBHJ(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 281f * (429f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1363f * EDLMAPJDHFL - 1243f * OELAKKHNNJC + 996f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 725f * OELAKKHNNJC - 1427f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134D6 RID: 79062 RVA: 0x0084E1BC File Offset: 0x0084C3BC
			public static AraTrail.LDEOHJDCBLI PPBHEODICFA(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134D7 RID: 79063 RVA: 0x0084E240 File Offset: 0x0084C440
			public static AraTrail.LDEOHJDCBLI FEMFHBEMFOH(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134D8 RID: 79064 RVA: 0x0084E2C4 File Offset: 0x0084C4C4
			public static AraTrail.LDEOHJDCBLI COEPMKBHDKB(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.PAAEMCCANGF(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DKKGDOPCOBC(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KKPEOMOPNLJ(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DLEMGJNIPII(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134D9 RID: 79065 RVA: 0x0084E3B0 File Offset: 0x0084C5B0
			private static Color ELEMGHPFBHK(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HGCEIFIJABG(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGCEIFIJABG(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[2], OELAKKHNNJC[0], HPJKHGBNCPE[8], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EPCFEJHHOKB(EDLMAPJDHFL[2], OELAKKHNNJC[2], HPJKHGBNCPE[4], MENGKPMIIPN[4], JAHNHOCNJGM));
			}

			// Token: 0x060134DA RID: 79066 RVA: 0x0084E460 File Offset: 0x0084C660
			private static float NDOHMEEGNPC(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1708f * (716f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (141f * EDLMAPJDHFL - 1965f * OELAKKHNNJC + 780f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1062f * OELAKKHNNJC - 89f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134DB RID: 79067 RVA: 0x0084E4C0 File Offset: 0x0084C6C0
			public static AraTrail.LDEOHJDCBLI BGALHPLHOFM(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134DC RID: 79068 RVA: 0x0084E544 File Offset: 0x0084C744
			public static AraTrail.LDEOHJDCBLI BFOEEOLHABP(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134DD RID: 79069 RVA: 0x0084E5C8 File Offset: 0x0084C7C8
			private static Vector3 IELFKBOCMGB(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EPCFEJHHOKB(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[2], OELAKKHNNJC[8], HPJKHGBNCPE[6], MENGKPMIIPN[1], JAHNHOCNJGM));
			}

			// Token: 0x060134DE RID: 79070 RVA: 0x0084E650 File Offset: 0x0084C850
			private static Color KNNLGPNAHKE(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[2], OELAKKHNNJC[2], HPJKHGBNCPE[2], MENGKPMIIPN[2], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[3], OELAKKHNNJC[3], HPJKHGBNCPE[3], MENGKPMIIPN[3], JAHNHOCNJGM));
			}

			// Token: 0x060134DF RID: 79071 RVA: 0x0084E700 File Offset: 0x0084C900
			public static AraTrail.LDEOHJDCBLI DNJNJJKGHAB(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.NKDBMLCEGGJ(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IIHBCADOKOJ(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NKDBMLCEGGJ(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PBBJJFIJGBD(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DCLEKCIFKPN(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134E0 RID: 79072 RVA: 0x0084E7EC File Offset: 0x0084C9EC
			private static Color BDHEHCLHBKD(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HNADJCHJHHD(EDLMAPJDHFL[0], OELAKKHNNJC[4], HPJKHGBNCPE[5], MENGKPMIIPN[2], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DCPIMAJGBKJ(EDLMAPJDHFL[3], OELAKKHNNJC[3], HPJKHGBNCPE[1], MENGKPMIIPN[7], JAHNHOCNJGM));
			}

			// Token: 0x060134E1 RID: 79073 RVA: 0x0084E89C File Offset: 0x0084CA9C
			private static Vector3 KKPEOMOPNLJ(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KEHFAIHEFAM(EDLMAPJDHFL[0], OELAKKHNNJC[5], HPJKHGBNCPE[1], MENGKPMIIPN[3], JAHNHOCNJGM));
			}

			// Token: 0x060134E2 RID: 79074 RVA: 0x0084E924 File Offset: 0x0084CB24
			public static AraTrail.LDEOHJDCBLI LDFGPBPOBCD(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134E3 RID: 79075 RVA: 0x0084E9A8 File Offset: 0x0084CBA8
			private static float HNADJCHJHHD(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 268f * (1127f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1184f * EDLMAPJDHFL - 904f * OELAKKHNNJC + 1421f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 905f * OELAKKHNNJC - 1100f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134E4 RID: 79076 RVA: 0x0084EA08 File Offset: 0x0084CC08
			private static float EPCFEJHHOKB(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1884f * (1627f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (428f * EDLMAPJDHFL - 1497f * OELAKKHNNJC + 191f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 638f * OELAKKHNNJC - 572f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134E5 RID: 79077 RVA: 0x0084EA68 File Offset: 0x0084CC68
			private static Vector3 KHKEPKHIGDH(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HNADJCHJHHD(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[4], OELAKKHNNJC[6], HPJKHGBNCPE[6], MENGKPMIIPN[1], JAHNHOCNJGM));
			}

			// Token: 0x060134E6 RID: 79078 RVA: 0x0084EAF0 File Offset: 0x0084CCF0
			private static float GONJDKLNKHF(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1888f * (1840f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (309f * EDLMAPJDHFL - 1889f * OELAKKHNNJC + 641f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 729f * OELAKKHNNJC - 1889f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134E7 RID: 79079 RVA: 0x0084EB50 File Offset: 0x0084CD50
			public static AraTrail.LDEOHJDCBLI NOBNFIANAGA(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.IHBOFAOKLBB(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PGOINAILHLF(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NKDBMLCEGGJ(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BDBOABJAIDP(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BGOFOMOFMCB(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GFAOCMGLBHJ(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134E8 RID: 79080 RVA: 0x0084EC3C File Offset: 0x0084CE3C
			private static Color GOAOJHGFKGP(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[2], OELAKKHNNJC[7], HPJKHGBNCPE[5], MENGKPMIIPN[6], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KEHFAIHEFAM(EDLMAPJDHFL[8], OELAKKHNNJC[7], HPJKHGBNCPE[7], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x060134E9 RID: 79081 RVA: 0x0084ECEC File Offset: 0x0084CEEC
			public static AraTrail.LDEOHJDCBLI KBFABMENDFC(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134EA RID: 79082 RVA: 0x0084ED70 File Offset: 0x0084CF70
			private static Color BGOFOMOFMCB(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HNADJCHJHHD(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[5], OELAKKHNNJC[7], HPJKHGBNCPE[5], MENGKPMIIPN[2], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EDLMAPJDHFL[7], OELAKKHNNJC[7], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM));
			}

			// Token: 0x060134EB RID: 79083 RVA: 0x0084EE20 File Offset: 0x0084D020
			private static Vector3 DKKGDOPCOBC(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[8], OELAKKHNNJC[8], HPJKHGBNCPE[3], MENGKPMIIPN[4], JAHNHOCNJGM));
			}

			// Token: 0x060134EC RID: 79084 RVA: 0x0084EEA8 File Offset: 0x0084D0A8
			public static AraTrail.LDEOHJDCBLI GMAPNFCOFEM(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134ED RID: 79085 RVA: 0x0084EF2C File Offset: 0x0084D12C
			public static AraTrail.LDEOHJDCBLI JLGOFGDEOPD(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.IIHBCADOKOJ(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KHKEPKHIGDH(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KDFOBJFPPND(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PGOINAILHLF(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PMNDNPBMHGC(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134EE RID: 79086 RVA: 0x0084F018 File Offset: 0x0084D218
			private static float EOFHNGMKPLN(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1845f * (1009f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (146f * EDLMAPJDHFL - 1185f * OELAKKHNNJC + 439f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1216f * OELAKKHNNJC - 1139f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134EF RID: 79087 RVA: 0x0084F078 File Offset: 0x0084D278
			private static float MIFFAAEMJIA(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1475f * (1913f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1704f * EDLMAPJDHFL - 812f * OELAKKHNNJC + 1918f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1088f * OELAKKHNNJC - 922f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134F0 RID: 79088 RVA: 0x0084F0D8 File Offset: 0x0084D2D8
			public static AraTrail.LDEOHJDCBLI GPIMPHKOAIE(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134F1 RID: 79089 RVA: 0x0084F15C File Offset: 0x0084D35C
			private static Vector3 AJNPPKOKPLE(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[3], OELAKKHNNJC[4], HPJKHGBNCPE[3], MENGKPMIIPN[5], JAHNHOCNJGM));
			}

			// Token: 0x060134F2 RID: 79090 RVA: 0x0084F1E4 File Offset: 0x0084D3E4
			private static Vector3 PIAJANIPCHD(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[7], OELAKKHNNJC[7], HPJKHGBNCPE[2], MENGKPMIIPN[0], JAHNHOCNJGM));
			}

			// Token: 0x060134F3 RID: 79091 RVA: 0x0084F26C File Offset: 0x0084D46C
			public static AraTrail.LDEOHJDCBLI IPLFIJLGLFK(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134F4 RID: 79092 RVA: 0x0084F2F0 File Offset: 0x0084D4F0
			public static AraTrail.LDEOHJDCBLI ECCMKNGFEAP(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134F5 RID: 79093 RVA: 0x0084F374 File Offset: 0x0084D574
			public static AraTrail.LDEOHJDCBLI OKJHCAJOPGD(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.FFCENKPCKNE(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DPGEHNAMOGD(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BDBOABJAIDP(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DKKGDOPCOBC(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NNALAMBCJPK(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HNADJCHJHHD(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134F6 RID: 79094 RVA: 0x0084F460 File Offset: 0x0084D660
			private static Vector3 PGOINAILHLF(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EDLMAPJDHFL[5], OELAKKHNNJC[5], HPJKHGBNCPE[0], MENGKPMIIPN[4], JAHNHOCNJGM));
			}

			// Token: 0x060134F7 RID: 79095 RVA: 0x0084F4E8 File Offset: 0x0084D6E8
			public static AraTrail.LDEOHJDCBLI DELDKEGMACB(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.FODAJBFMELE(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KNNLGPNAHKE(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x060134F8 RID: 79096 RVA: 0x0084F5D4 File Offset: 0x0084D7D4
			private static float HGFCEPCFOEM(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 613f * (709f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1699f * EDLMAPJDHFL - 260f * OELAKKHNNJC + 1734f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 397f * OELAKKHNNJC - 340f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134F9 RID: 79097 RVA: 0x0084F634 File Offset: 0x0084D834
			private static Color NNALAMBCJPK(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DIDPCMEEHMI(EDLMAPJDHFL[4], OELAKKHNNJC[7], HPJKHGBNCPE[6], MENGKPMIIPN[7], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[3], OELAKKHNNJC[2], HPJKHGBNCPE[4], MENGKPMIIPN[1], JAHNHOCNJGM));
			}

			// Token: 0x060134FA RID: 79098 RVA: 0x0084F6E4 File Offset: 0x0084D8E4
			private static Color OEODCIHHJON(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.GGKNGNJPCKJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGCEIFIJABG(EDLMAPJDHFL[4], OELAKKHNNJC[6], HPJKHGBNCPE[5], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[0], OELAKKHNNJC[6], HPJKHGBNCPE[6], MENGKPMIIPN[4], JAHNHOCNJGM));
			}

			// Token: 0x060134FB RID: 79099 RVA: 0x0084F794 File Offset: 0x0084D994
			private static Color ENOFIBDIKFM(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[1], OELAKKHNNJC[2], HPJKHGBNCPE[3], MENGKPMIIPN[8], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[0], OELAKKHNNJC[8], HPJKHGBNCPE[6], MENGKPMIIPN[0], JAHNHOCNJGM));
			}

			// Token: 0x060134FC RID: 79100 RVA: 0x0084F844 File Offset: 0x0084DA44
			public static AraTrail.LDEOHJDCBLI PANGFJNOJHB(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x060134FD RID: 79101 RVA: 0x0084F8C8 File Offset: 0x0084DAC8
			private static Color EHMGCKEKMKG(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[0], OELAKKHNNJC[2], HPJKHGBNCPE[1], MENGKPMIIPN[7], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EDLMAPJDHFL[6], OELAKKHNNJC[5], HPJKHGBNCPE[6], MENGKPMIIPN[5], JAHNHOCNJGM));
			}

			// Token: 0x060134FE RID: 79102 RVA: 0x0084F978 File Offset: 0x0084DB78
			private static float OPFGOOJFCGH(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 208f * (1548f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (701f * EDLMAPJDHFL - 1157f * OELAKKHNNJC + 1079f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1597f * OELAKKHNNJC - 493f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x060134FF RID: 79103 RVA: 0x0084F9D8 File Offset: 0x0084DBD8
			public static AraTrail.LDEOHJDCBLI BJOHEPJNNIO(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x06013500 RID: 79104 RVA: 0x0084FA5C File Offset: 0x0084DC5C
			private static Vector3 DPGEHNAMOGD(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EPCFEJHHOKB(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[8], OELAKKHNNJC[8], HPJKHGBNCPE[2], MENGKPMIIPN[6], JAHNHOCNJGM));
			}

			// Token: 0x06013501 RID: 79105 RVA: 0x0084FAE4 File Offset: 0x0084DCE4
			private static Vector3 BGBANIECADJ(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[7], OELAKKHNNJC[4], HPJKHGBNCPE[5], MENGKPMIIPN[0], JAHNHOCNJGM));
			}

			// Token: 0x06013502 RID: 79106 RVA: 0x0084FB6C File Offset: 0x0084DD6C
			private static Color LNKFIKPFIBD(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EDLMAPJDHFL[8], OELAKKHNNJC[5], HPJKHGBNCPE[2], MENGKPMIIPN[4], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DCPIMAJGBKJ(EDLMAPJDHFL[4], OELAKKHNNJC[5], HPJKHGBNCPE[6], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x06013503 RID: 79107 RVA: 0x0084FC1C File Offset: 0x0084DE1C
			public static AraTrail.LDEOHJDCBLI ABMNHBJMOPG(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x06013504 RID: 79108 RVA: 0x0084FCA0 File Offset: 0x0084DEA0
			public static AraTrail.LDEOHJDCBLI BCLJKBLBHCG(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x06013505 RID: 79109 RVA: 0x0084FD24 File Offset: 0x0084DF24
			private static Color MAPKNDEDHNL(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DJGFHMHDIPH(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EDLMAPJDHFL[6], OELAKKHNNJC[4], HPJKHGBNCPE[2], MENGKPMIIPN[3], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[8], OELAKKHNNJC[8], HPJKHGBNCPE[7], MENGKPMIIPN[8], JAHNHOCNJGM));
			}

			// Token: 0x06013506 RID: 79110 RVA: 0x0084FDD4 File Offset: 0x0084DFD4
			public static AraTrail.LDEOHJDCBLI KHOAKJPNLKA(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x06013507 RID: 79111 RVA: 0x0084FE58 File Offset: 0x0084E058
			private static Color DLEMGJNIPII(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.KIEJJIEEBIA(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.PLGGOKMCNKJ(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DIDPCMEEHMI(EDLMAPJDHFL[7], OELAKKHNNJC[4], HPJKHGBNCPE[6], MENGKPMIIPN[3], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[4], MENGKPMIIPN[7], JAHNHOCNJGM));
			}

			// Token: 0x06013508 RID: 79112 RVA: 0x0084FF08 File Offset: 0x0084E108
			private static Color OOEEECPIDLG(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.EOFHNGMKPLN(EDLMAPJDHFL[0], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[6], OELAKKHNNJC[1], HPJKHGBNCPE[7], MENGKPMIIPN[6], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[0], OELAKKHNNJC[5], HPJKHGBNCPE[7], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x06013509 RID: 79113 RVA: 0x0084FFB8 File Offset: 0x0084E1B8
			private static float GGKNGNJPCKJ(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 911f * (738f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1016f * EDLMAPJDHFL - 522f * OELAKKHNNJC + 482f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1815f * OELAKKHNNJC - 760f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x0601350A RID: 79114 RVA: 0x00850018 File Offset: 0x0084E218
			public static AraTrail.LDEOHJDCBLI HLDJLEBIOGF(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x0601350B RID: 79115 RVA: 0x0085009C File Offset: 0x0084E29C
			private static Vector3 IIHBCADOKOJ(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[0], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.AHDOBHMJMFL(EDLMAPJDHFL[6], OELAKKHNNJC[4], HPJKHGBNCPE[0], MENGKPMIIPN[6], JAHNHOCNJGM));
			}

			// Token: 0x0601350C RID: 79116 RVA: 0x00850124 File Offset: 0x0084E324
			public static AraTrail.LDEOHJDCBLI KKDLNGKBDKC(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL - HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC - HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF - HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ - HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB - HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ - HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB - HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x0601350D RID: 79117 RVA: 0x008501A8 File Offset: 0x0084E3A8
			public static AraTrail.LDEOHJDCBLI DNHIPFNDPHE(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x0601350E RID: 79118 RVA: 0x0085022C File Offset: 0x0084E42C
			public static AraTrail.LDEOHJDCBLI JCPDOGJHPOE(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x0601350F RID: 79119 RVA: 0x008502B0 File Offset: 0x0084E4B0
			private static Vector3 JLHJCOJEJGP(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Vector3(AraTrail.LDEOHJDCBLI.DBEEILEEAAJ(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DIDPCMEEHMI(EDLMAPJDHFL[1], OELAKKHNNJC[0], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.KEHFAIHEFAM(EDLMAPJDHFL[3], OELAKKHNNJC[0], HPJKHGBNCPE[4], MENGKPMIIPN[2], JAHNHOCNJGM));
			}

			// Token: 0x06013510 RID: 79120 RVA: 0x00850338 File Offset: 0x0084E538
			private static Color KHLKFCOBKLF(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HNADJCHJHHD(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.NDOHMEEGNPC(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EDLMAPJDHFL[2], OELAKKHNNJC[2], HPJKHGBNCPE[1], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DIDPCMEEHMI(EDLMAPJDHFL[4], OELAKKHNNJC[1], HPJKHGBNCPE[2], MENGKPMIIPN[0], JAHNHOCNJGM));
			}

			// Token: 0x06013511 RID: 79121 RVA: 0x008503E8 File Offset: 0x0084E5E8
			private static Color JKGEPPENPBP(Color EDLMAPJDHFL, Color OELAKKHNNJC, Color HPJKHGBNCPE, Color MENGKPMIIPN, float JAHNHOCNJGM)
			{
				return new Color(AraTrail.LDEOHJDCBLI.HGFCEPCFOEM(EDLMAPJDHFL[1], OELAKKHNNJC[1], HPJKHGBNCPE[1], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.HACBIGBCKIC(EDLMAPJDHFL[0], OELAKKHNNJC[1], HPJKHGBNCPE[0], MENGKPMIIPN[0], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.DCPIMAJGBKJ(EDLMAPJDHFL[5], OELAKKHNNJC[7], HPJKHGBNCPE[4], MENGKPMIIPN[1], JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.GONJDKLNKHF(EDLMAPJDHFL[4], OELAKKHNNJC[1], HPJKHGBNCPE[6], MENGKPMIIPN[7], JAHNHOCNJGM));
			}

			// Token: 0x06013512 RID: 79122 RVA: 0x00850498 File Offset: 0x0084E698
			public static AraTrail.LDEOHJDCBLI EBJPPJKLAJP(AraTrail.LDEOHJDCBLI EGABJKIFAON, AraTrail.LDEOHJDCBLI HHAGIHEGFML, AraTrail.LDEOHJDCBLI OAGAHEAMIAB, AraTrail.LDEOHJDCBLI MBFGBDLOKFH, float JAHNHOCNJGM)
			{
				return new AraTrail.LDEOHJDCBLI(AraTrail.LDEOHJDCBLI.PBBJJFIJGBD(EGABJKIFAON.MGALEAJOGPL, HHAGIHEGFML.MGALEAJOGPL, OAGAHEAMIAB.MGALEAJOGPL, MBFGBDLOKFH.MGALEAJOGPL, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BDBOABJAIDP(EGABJKIFAON.APOIOHJJDDC, HHAGIHEGFML.APOIOHJJDDC, OAGAHEAMIAB.APOIOHJJDDC, MBFGBDLOKFH.APOIOHJJDDC, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.IELFKBOCMGB(EGABJKIFAON.BOGIINEDPCF, HHAGIHEGFML.BOGIINEDPCF, OAGAHEAMIAB.BOGIINEDPCF, MBFGBDLOKFH.BOGIINEDPCF, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.BGBANIECADJ(EGABJKIFAON.LJGHBOFJDBJ, HHAGIHEGFML.LJGHBOFJDBJ, OAGAHEAMIAB.LJGHBOFJDBJ, MBFGBDLOKFH.LJGHBOFJDBJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.JKGEPPENPBP(EGABJKIFAON.LBCGACKJCJB, HHAGIHEGFML.LBCGACKJCJB, OAGAHEAMIAB.LBCGACKJCJB, MBFGBDLOKFH.LBCGACKJCJB, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.CPOLIHFJCBN(EGABJKIFAON.NPIHOLDPJNJ, HHAGIHEGFML.NPIHOLDPJNJ, OAGAHEAMIAB.NPIHOLDPJNJ, MBFGBDLOKFH.NPIHOLDPJNJ, JAHNHOCNJGM), AraTrail.LDEOHJDCBLI.MIFFAAEMJIA(EGABJKIFAON.CAPOODCGCHB, HHAGIHEGFML.CAPOODCGCHB, OAGAHEAMIAB.CAPOODCGCHB, MBFGBDLOKFH.CAPOODCGCHB, JAHNHOCNJGM));
			}

			// Token: 0x06013513 RID: 79123 RVA: 0x00850584 File Offset: 0x0084E784
			private static float DIDPCMEEHMI(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 487f * (158f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (172f * EDLMAPJDHFL - 808f * OELAKKHNNJC + 1563f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1840f * OELAKKHNNJC - 1565f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x06013514 RID: 79124 RVA: 0x008505E4 File Offset: 0x0084E7E4
			private static float AHDOBHMJMFL(float EDLMAPJDHFL, float OELAKKHNNJC, float HPJKHGBNCPE, float MENGKPMIIPN, float JAHNHOCNJGM)
			{
				float num = JAHNHOCNJGM * JAHNHOCNJGM;
				return 1425f * (348f * OELAKKHNNJC + (-EDLMAPJDHFL + HPJKHGBNCPE) * JAHNHOCNJGM + (1202f * EDLMAPJDHFL - 988f * OELAKKHNNJC + 1245f * HPJKHGBNCPE - MENGKPMIIPN) * num + (-EDLMAPJDHFL + 1564f * OELAKKHNNJC - 1723f * HPJKHGBNCPE + MENGKPMIIPN) * num * JAHNHOCNJGM);
			}

			// Token: 0x06013515 RID: 79125 RVA: 0x00850644 File Offset: 0x0084E844
			public static AraTrail.LDEOHJDCBLI DEJAGBDELEH(AraTrail.LDEOHJDCBLI OELAKKHNNJC, AraTrail.LDEOHJDCBLI HPJKHGBNCPE)
			{
				return new AraTrail.LDEOHJDCBLI(OELAKKHNNJC.MGALEAJOGPL + HPJKHGBNCPE.MGALEAJOGPL, OELAKKHNNJC.APOIOHJJDDC + HPJKHGBNCPE.APOIOHJJDDC, OELAKKHNNJC.BOGIINEDPCF + HPJKHGBNCPE.BOGIINEDPCF, OELAKKHNNJC.LJGHBOFJDBJ + HPJKHGBNCPE.LJGHBOFJDBJ, OELAKKHNNJC.LBCGACKJCJB + HPJKHGBNCPE.LBCGACKJCJB, OELAKKHNNJC.NPIHOLDPJNJ + HPJKHGBNCPE.NPIHOLDPJNJ, OELAKKHNNJC.CAPOODCGCHB + HPJKHGBNCPE.CAPOODCGCHB);
			}

			// Token: 0x040027BC RID: 10172
			public Vector3 MGALEAJOGPL;

			// Token: 0x040027BD RID: 10173
			public Vector3 APOIOHJJDDC;

			// Token: 0x040027BE RID: 10174
			public Vector3 BOGIINEDPCF;

			// Token: 0x040027BF RID: 10175
			public Vector3 LJGHBOFJDBJ;

			// Token: 0x040027C0 RID: 10176
			public Color LBCGACKJCJB;

			// Token: 0x040027C1 RID: 10177
			public float NPIHOLDPJNJ;

			// Token: 0x040027C2 RID: 10178
			public float CAPOODCGCHB;

			// Token: 0x040027C3 RID: 10179
			public bool LCPICMGIEEA;
		}
	}
}
