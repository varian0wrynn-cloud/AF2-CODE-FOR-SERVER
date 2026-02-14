using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004A1 RID: 1185
	public class HandPoser : Poser
	{
		// Token: 0x06010290 RID: 66192 RVA: 0x0073ED2C File Offset: 0x0073CF2C
		protected virtual void NFPBKFCNEIN()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x06010291 RID: 66193 RVA: 0x0073ED80 File Offset: 0x0073CF80
		protected virtual void PPAFJNOBOFO()
		{
			if (this.weight <= 1752f)
			{
				return;
			}
			if (this.localPositionWeight <= 828f && this.localRotationWeight <= 1143f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("post_5", base.transform, false);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x06010292 RID: 66194 RVA: 0x0073EEA0 File Offset: 0x0073D0A0
		protected virtual void FLGKHPHDIMJ()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x06010293 RID: 66195 RVA: 0x0073EEF4 File Offset: 0x0073D0F4
		protected virtual void IDKAGNKBPKI()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x06010294 RID: 66196 RVA: 0x0073EF48 File Offset: 0x0073D148
		protected virtual void EFKCAICPGDH()
		{
			if (this.weight <= 1808f)
			{
				return;
			}
			if (this.localPositionWeight <= 714f && this.localRotationWeight <= 1358f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("{0}+{1}={2}", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x06010295 RID: 66197 RVA: 0x0073F068 File Offset: 0x0073D268
		protected virtual void HFDAFIPNHEN()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x06010296 RID: 66198 RVA: 0x0073F0BC File Offset: 0x0073D2BC
		protected virtual void ELILOPJBKLG()
		{
			if (this.weight <= 1492f)
			{
				return;
			}
			if (this.localPositionWeight <= 832f && this.localRotationWeight <= 1867f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("1HandSwordChargeHeavyBash", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x06010297 RID: 66199 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void LMPPAMDFDPG()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x06010298 RID: 66200 RVA: 0x0073F218 File Offset: 0x0073D418
		protected virtual void OMKEEOBDKMP()
		{
			if (this.weight <= 846f)
			{
				return;
			}
			if (this.localPositionWeight <= 718f && this.localRotationWeight <= 464f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("name", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x06010299 RID: 66201 RVA: 0x0073F338 File Offset: 0x0073D538
		protected virtual void LGBHONGEJOI()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.HEHHHBFCBOG();
		}

		// Token: 0x0601029A RID: 66202 RVA: 0x0073F34C File Offset: 0x0073D54C
		protected virtual void HJPDCMNOMEJ()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x0601029B RID: 66203 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void HDCCEAOODPE()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x0601029C RID: 66204 RVA: 0x0073F3A0 File Offset: 0x0073D5A0
		private void FNMEIDJKEJH()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x0601029D RID: 66205 RVA: 0x0073F418 File Offset: 0x0073D618
		protected virtual void GPJNACFPJOF()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.FNMEIDJKEJH();
		}

		// Token: 0x0601029E RID: 66206 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void OJECIKFMDIJ()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x0601029F RID: 66207 RVA: 0x0073F468 File Offset: 0x0073D668
		protected virtual void BKPJFLHNHGH()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102A0 RID: 66208 RVA: 0x0073F4BC File Offset: 0x0073D6BC
		protected virtual void CCJGLJHEPEH()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102A1 RID: 66209 RVA: 0x0073F510 File Offset: 0x0073D710
		private void BAMHFMPCDPI()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102A2 RID: 66210 RVA: 0x0073F588 File Offset: 0x0073D788
		protected virtual void HJLGKCAOANF()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102A3 RID: 66211 RVA: 0x0073F5DA File Offset: 0x0073D7DA
		protected virtual void JPIPNDIIECH()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.FEMKKCCGLJM();
		}

		// Token: 0x060102A4 RID: 66212 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void NHEENMCHLNL()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102A5 RID: 66213 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void IAGCJBLEDOF()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102A6 RID: 66214 RVA: 0x0073F5EE File Offset: 0x0073D7EE
		protected virtual void AHDDDCBKEJI()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.EBEBHELEBEH();
		}

		// Token: 0x060102A7 RID: 66215 RVA: 0x0073F604 File Offset: 0x0073D804
		protected virtual void BNBENPKBHBL()
		{
			if (this.weight <= 1675f)
			{
				return;
			}
			if (this.localPositionWeight <= 1175f && this.localRotationWeight <= 934f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("threshold", base.transform, false);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102A8 RID: 66216 RVA: 0x0073F724 File Offset: 0x0073D924
		private void IMGICAIEMBK()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102A9 RID: 66217 RVA: 0x0073F79C File Offset: 0x0073D99C
		protected virtual void KNCOACDICNP()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.BAMHFMPCDPI();
		}

		// Token: 0x060102AB RID: 66219 RVA: 0x0073F7B0 File Offset: 0x0073D9B0
		private void MMOCBJKNJMH()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102AC RID: 66220 RVA: 0x0073F828 File Offset: 0x0073DA28
		protected virtual void PCEAJPPPCLG()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.MDDHEDJINFP();
		}

		// Token: 0x060102AD RID: 66221 RVA: 0x0073F83C File Offset: 0x0073DA3C
		protected virtual void DKIHAIEMOKN()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.CPNFMDMNMCE();
		}

		// Token: 0x060102AE RID: 66222 RVA: 0x0073F850 File Offset: 0x0073DA50
		protected virtual void AAMKGJNPLJC()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JLNCMBFGHKC();
		}

		// Token: 0x060102AF RID: 66223 RVA: 0x0073F864 File Offset: 0x0073DA64
		protected virtual void PJNAGDCLKOF()
		{
			if (this.weight <= 957f)
			{
				return;
			}
			if (this.localPositionWeight <= 535f && this.localRotationWeight <= 1431f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("IceHockeyGoalieSave1", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102B0 RID: 66224 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void LGHMIMGBNOM()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102B1 RID: 66225 RVA: 0x0073F984 File Offset: 0x0073DB84
		protected virtual void LAKCPEEIFLE()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.HNHJAEMMMHC();
		}

		// Token: 0x060102B2 RID: 66226 RVA: 0x0073F998 File Offset: 0x0073DB98
		protected override void FNPFFPPGGFD()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.LDBCNLFLAHC();
		}

		// Token: 0x060102B3 RID: 66227 RVA: 0x0073F79C File Offset: 0x0073D99C
		protected virtual void NNBOBCOLGJF()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.BAMHFMPCDPI();
		}

		// Token: 0x060102B4 RID: 66228 RVA: 0x0073F9AC File Offset: 0x0073DBAC
		protected override void BLHJPADDJOM()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.localPositionWeight <= 0f && this.localRotationWeight <= 0f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Number of children does not match with the pose", base.transform, false);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102B5 RID: 66229 RVA: 0x0073FACC File Offset: 0x0073DCCC
		protected virtual void OKBNBDKANIH()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.NEBONMADCAO();
		}

		// Token: 0x060102B6 RID: 66230 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void OJLDEDMMDJC()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102B7 RID: 66231 RVA: 0x0073FAE0 File Offset: 0x0073DCE0
		protected virtual void HIECEJGFOBI()
		{
			if (this.weight <= 355f)
			{
				return;
			}
			if (this.localPositionWeight <= 1813f && this.localRotationWeight <= 540f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("", base.transform, false);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102B8 RID: 66232 RVA: 0x0073FC00 File Offset: 0x0073DE00
		private void LDBCNLFLAHC()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102B9 RID: 66233 RVA: 0x0073F418 File Offset: 0x0073D618
		protected virtual void HDKKECOEDMB()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.FNMEIDJKEJH();
		}

		// Token: 0x060102BA RID: 66234 RVA: 0x0073FC78 File Offset: 0x0073DE78
		protected virtual void MGOBMFJJLCJ()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.EGHOJLDBAFH();
		}

		// Token: 0x060102BB RID: 66235 RVA: 0x0073FC8C File Offset: 0x0073DE8C
		protected virtual void BNFCCMCHJMM()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102BC RID: 66236 RVA: 0x0073FCE0 File Offset: 0x0073DEE0
		private void HNHJAEMMMHC()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102BD RID: 66237 RVA: 0x0073FD58 File Offset: 0x0073DF58
		private void FJPDLFOBECF()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102BE RID: 66238 RVA: 0x0073FDD0 File Offset: 0x0073DFD0
		protected virtual void JOODMIJNDKP()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102BF RID: 66239 RVA: 0x0073F42C File Offset: 0x0073D62C
		public override void AutoMapping()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102C0 RID: 66240 RVA: 0x0073FE24 File Offset: 0x0073E024
		protected virtual void PAKIBCDCBEN()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102C1 RID: 66241 RVA: 0x0073FE78 File Offset: 0x0073E078
		private void JDJJMGFGAAD()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102C2 RID: 66242 RVA: 0x0073FEF0 File Offset: 0x0073E0F0
		protected virtual void CHLCHPFCHBO()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.PLAOJHCHAML();
		}

		// Token: 0x060102C3 RID: 66243 RVA: 0x0073FF04 File Offset: 0x0073E104
		protected virtual void HKHPOEPAFAI()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102C4 RID: 66244 RVA: 0x0073FF58 File Offset: 0x0073E158
		protected virtual void NKMCHOGDOGB()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102C5 RID: 66245 RVA: 0x0073FFAC File Offset: 0x0073E1AC
		protected virtual void NJJIDKFPEFP()
		{
			if (this.weight <= 666f)
			{
				return;
			}
			if (this.localPositionWeight <= 1788f && this.localRotationWeight <= 1596f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("SatNightFever", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102C6 RID: 66246 RVA: 0x007400CC File Offset: 0x0073E2CC
		protected virtual void AGGNFFBNCHH()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102C7 RID: 66247 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void HCCHFICDBND()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102C8 RID: 66248 RVA: 0x00740120 File Offset: 0x0073E320
		protected virtual void IAIAHPMCPME()
		{
			if (this.weight <= 1327f)
			{
				return;
			}
			if (this.localPositionWeight <= 881f && this.localRotationWeight <= 1252f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("firsStartInfoPanel", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102C9 RID: 66249 RVA: 0x00740240 File Offset: 0x0073E440
		private void JLNCMBFGHKC()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102CA RID: 66250 RVA: 0x007402B8 File Offset: 0x0073E4B8
		private void EBEBHELEBEH()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102CB RID: 66251 RVA: 0x0073F850 File Offset: 0x0073DA50
		protected virtual void IHPEDDOBPEA()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JLNCMBFGHKC();
		}

		// Token: 0x060102CC RID: 66252 RVA: 0x00740330 File Offset: 0x0073E530
		private void CPNFMDMNMCE()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102CD RID: 66253 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void DJGCNPCCNCG()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102CE RID: 66254 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void ONIKDDFODHA()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102CF RID: 66255 RVA: 0x007403A8 File Offset: 0x0073E5A8
		protected virtual void MOAKHGCONIO()
		{
			if (this.weight <= 1645f)
			{
				return;
			}
			if (this.localPositionWeight <= 594f && this.localRotationWeight <= 508f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("1", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102D0 RID: 66256 RVA: 0x007404C8 File Offset: 0x0073E6C8
		private void EGHOJLDBAFH()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102D1 RID: 66257 RVA: 0x00740540 File Offset: 0x0073E740
		private void PLAOJHCHAML()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102D2 RID: 66258 RVA: 0x007405B8 File Offset: 0x0073E7B8
		protected virtual void EJJINLGCAHI()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102D3 RID: 66259 RVA: 0x0074060C File Offset: 0x0073E80C
		private void HEHHHBFCBOG()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102D4 RID: 66260 RVA: 0x00740684 File Offset: 0x0073E884
		private void JNIKLNBHEOA()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102D5 RID: 66261 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void JKDLGDBKGPJ()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102D6 RID: 66262 RVA: 0x007406FC File Offset: 0x0073E8FC
		protected virtual void HMADEDBFMEA()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.GDKECGAFNPA();
		}

		// Token: 0x060102D7 RID: 66263 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void AGIIDLPLAHK()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102D8 RID: 66264 RVA: 0x00740710 File Offset: 0x0073E910
		protected virtual void KDJKBJCPNJC()
		{
			if (this.weight <= 234f)
			{
				return;
			}
			if (this.localPositionWeight <= 1224f && this.localRotationWeight <= 1772f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED(" ", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102D9 RID: 66265 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void FCJGJLCKKEJ()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102DA RID: 66266 RVA: 0x0073FEF0 File Offset: 0x0073E0F0
		protected virtual void OOFOOJJJCFN()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.PLAOJHCHAML();
		}

		// Token: 0x060102DB RID: 66267 RVA: 0x00740830 File Offset: 0x0073EA30
		private void MDDHEDJINFP()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102DC RID: 66268 RVA: 0x007408A8 File Offset: 0x0073EAA8
		protected virtual void JDCOAMNDOJG()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102DD RID: 66269 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void IJNFJBMPDDH()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102DE RID: 66270 RVA: 0x007408FC File Offset: 0x0073EAFC
		protected virtual void LPCLJLEKLMH()
		{
			if (this.weight <= 1572f)
			{
				return;
			}
			if (this.localPositionWeight <= 1989f && this.localRotationWeight <= 1006f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("The image effect ", base.transform, false);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102DF RID: 66271 RVA: 0x00740A1C File Offset: 0x0073EC1C
		protected virtual void EDBNHEHGABL()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.FJPDLFOBECF();
		}

		// Token: 0x060102E0 RID: 66272 RVA: 0x00740A30 File Offset: 0x0073EC30
		protected virtual void LJGCOKONKDF()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102E1 RID: 66273 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void NKPLLEJEGOD()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102E2 RID: 66274 RVA: 0x00740A84 File Offset: 0x0073EC84
		protected override void NPJKDOKKPJJ()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102E3 RID: 66275 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void EAJAEGHNCFI()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102E4 RID: 66276 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void ODGDFKGENHO()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102E5 RID: 66277 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void DHKCIIHGLNC()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102E6 RID: 66278 RVA: 0x00740AD8 File Offset: 0x0073ECD8
		protected virtual void MAMKGFELMME()
		{
			if (this.weight <= 940f)
			{
				return;
			}
			if (this.localPositionWeight <= 519f && this.localRotationWeight <= 284f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("OfficeSittingReadingCoffeeSip", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102E7 RID: 66279 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void MHOMFHAJLLO()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102E8 RID: 66280 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void HLDAOPLGJGP()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102E9 RID: 66281 RVA: 0x00740BF8 File Offset: 0x0073EDF8
		protected virtual void MINMHKOCPAH()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102EA RID: 66282 RVA: 0x00740C4C File Offset: 0x0073EE4C
		protected virtual void GCEDAGBLLLN()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102EB RID: 66283 RVA: 0x00740CA0 File Offset: 0x0073EEA0
		protected virtual void GKCEJMOEDHD()
		{
			if (this.weight <= 1801f)
			{
				return;
			}
			if (this.localPositionWeight <= 1146f && this.localRotationWeight <= 1090f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("quests/achivments_name/qd", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102EC RID: 66284 RVA: 0x00740DC0 File Offset: 0x0073EFC0
		protected virtual void ABNFIIAJEPI()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.JDJJMGFGAAD();
		}

		// Token: 0x060102ED RID: 66285 RVA: 0x00740DD4 File Offset: 0x0073EFD4
		private void GDKECGAFNPA()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102EE RID: 66286 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void JJPLDMBPNAP()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102EF RID: 66287 RVA: 0x00740E4C File Offset: 0x0073F04C
		protected virtual void KIFPFOCJHEC()
		{
			if (this.weight <= 1399f)
			{
				return;
			}
			if (this.localPositionWeight <= 740f && this.localRotationWeight <= 761f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("Crouch Walk Backward", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102F0 RID: 66288 RVA: 0x0073F42C File Offset: 0x0073D62C
		public virtual void EOJMNLEKBAF()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[0];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x060102F1 RID: 66289 RVA: 0x0073F998 File Offset: 0x0073DB98
		protected virtual void CMIGNONOLNC()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.LDBCNLFLAHC();
		}

		// Token: 0x060102F2 RID: 66290 RVA: 0x0073F418 File Offset: 0x0073D618
		protected virtual void MNKDAPPHEEB()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.FNMEIDJKEJH();
		}

		// Token: 0x060102F3 RID: 66291 RVA: 0x00740F6C File Offset: 0x0073F16C
		protected virtual void LBLMOGILOGN()
		{
			if (this.weight <= 365f)
			{
				return;
			}
			if (this.localPositionWeight <= 521f && this.localRotationWeight <= 1455f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("(", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102F4 RID: 66292 RVA: 0x0074108C File Offset: 0x0073F28C
		private void MLJPEBJIALN()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102F5 RID: 66293 RVA: 0x00741104 File Offset: 0x0073F304
		protected virtual void CJPFMJMDIEL()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102F6 RID: 66294 RVA: 0x00741158 File Offset: 0x0073F358
		protected virtual void KMFMMDPNPDO()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102F7 RID: 66295 RVA: 0x0073F338 File Offset: 0x0073D538
		protected virtual void HHOOJKPNBGJ()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.HEHHHBFCBOG();
		}

		// Token: 0x060102F8 RID: 66296 RVA: 0x007411AC File Offset: 0x0073F3AC
		private void FEMKKCCGLJM()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102F9 RID: 66297 RVA: 0x0073FACC File Offset: 0x0073DCCC
		protected virtual void GNIHKGJHNMH()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.NEBONMADCAO();
		}

		// Token: 0x060102FA RID: 66298 RVA: 0x0073F828 File Offset: 0x0073DA28
		protected virtual void OCDEOFIHBJE()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.MDDHEDJINFP();
		}

		// Token: 0x060102FB RID: 66299 RVA: 0x00741224 File Offset: 0x0073F424
		protected virtual void PANCNLFECGK()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x060102FC RID: 66300 RVA: 0x00741278 File Offset: 0x0073F478
		private void NEBONMADCAO()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102FD RID: 66301 RVA: 0x007412F0 File Offset: 0x0073F4F0
		protected virtual void IFNNFEKOGHI()
		{
			if (this.weight <= 539f)
			{
				return;
			}
			if (this.localPositionWeight <= 1398f && this.localRotationWeight <= 670f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("------------------------------------------------------", base.transform, true);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x060102FE RID: 66302 RVA: 0x00741410 File Offset: 0x0073F610
		private void NFCFKANJAJA()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x060102FF RID: 66303 RVA: 0x00741488 File Offset: 0x0073F688
		protected virtual void MDAIHLJPKGD()
		{
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x06010300 RID: 66304 RVA: 0x0073F998 File Offset: 0x0073DB98
		protected virtual void HGBHFBEKDDB()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.LDBCNLFLAHC();
		}

		// Token: 0x06010301 RID: 66305 RVA: 0x007414DC File Offset: 0x0073F6DC
		protected virtual void NBDJBBJEONO()
		{
			if (this.weight <= 66f)
			{
				return;
			}
			if (this.localPositionWeight <= 1186f && this.localRotationWeight <= 1183f)
			{
				return;
			}
			if (this.GAJOGKIFJIO != this.poseRoot)
			{
				this.AutoMapping();
			}
			if (this.poseRoot == null)
			{
				return;
			}
			if (this.NJONNOOBGPJ.Length != this.PODOPHKLFOI.Length)
			{
				PMCOMMEEGMC.ICAFGKHAAED("SneakIdle", base.transform, false);
				return;
			}
			float t = this.localRotationWeight * this.weight;
			float t2 = this.localPositionWeight * this.weight;
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				if (this.NJONNOOBGPJ[i] != base.transform)
				{
					this.NJONNOOBGPJ[i].localRotation = Quaternion.Lerp(this.NJONNOOBGPJ[i].localRotation, this.PODOPHKLFOI[i].localRotation, t);
					this.NJONNOOBGPJ[i].localPosition = Vector3.Lerp(this.NJONNOOBGPJ[i].localPosition, this.PODOPHKLFOI[i].localPosition, t2);
				}
			}
		}

		// Token: 0x06010302 RID: 66306 RVA: 0x007415FC File Offset: 0x0073F7FC
		private void EAJJOALLBAI()
		{
			this.KLLMKBMFFDN = new Vector3[this.NJONNOOBGPJ.Length];
			this.GMOAKADAFIN = new Quaternion[this.NJONNOOBGPJ.Length];
			for (int i = 0; i < this.NJONNOOBGPJ.Length; i += 0)
			{
				this.KLLMKBMFFDN[i] = this.NJONNOOBGPJ[i].localPosition;
				this.GMOAKADAFIN[i] = this.NJONNOOBGPJ[i].localRotation;
			}
		}

		// Token: 0x06010303 RID: 66307 RVA: 0x0073F1DC File Offset: 0x0073D3DC
		public virtual void GKFBLENNIHK()
		{
			if (this.poseRoot == null)
			{
				this.PODOPHKLFOI = new Transform[1];
			}
			else
			{
				this.PODOPHKLFOI = this.poseRoot.GetComponentsInChildren<Transform>();
			}
			this.GAJOGKIFJIO = this.poseRoot;
		}

		// Token: 0x06010304 RID: 66308 RVA: 0x00741674 File Offset: 0x0073F874
		protected virtual void NDFOHKBJJGB()
		{
			this.NJONNOOBGPJ = base.GetComponentsInChildren<Transform>();
			this.MLJPEBJIALN();
		}

		// Token: 0x06010305 RID: 66309 RVA: 0x00741688 File Offset: 0x0073F888
		protected virtual void MKGIINFANCE()
		{
			for (int i = 1; i < this.NJONNOOBGPJ.Length; i++)
			{
				this.NJONNOOBGPJ[i].localPosition = this.KLLMKBMFFDN[i];
				this.NJONNOOBGPJ[i].localRotation = this.GMOAKADAFIN[i];
			}
		}

		// Token: 0x04002200 RID: 8704
		private Transform GAJOGKIFJIO;

		// Token: 0x04002201 RID: 8705
		private Transform[] NJONNOOBGPJ;

		// Token: 0x04002202 RID: 8706
		private Transform[] PODOPHKLFOI;

		// Token: 0x04002203 RID: 8707
		private Vector3[] KLLMKBMFFDN;

		// Token: 0x04002204 RID: 8708
		private Quaternion[] GMOAKADAFIN;
	}
}
