using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000278 RID: 632
public class LineRope : MonoBehaviour
{
	// Token: 0x0600928E RID: 37518 RVA: 0x0041A08C File Offset: 0x0041828C
	private void AEMAHKFCOPE()
	{
		float num = Vector3.Distance(this.IGHOCIEBPFD.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC);
		float t = this.JLJJKMLJBAK.FAFHKDGNCLH / num;
		Vector3 position = Vector3.Lerp(this.IGHOCIEBPFD.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, t);
		this.IGHOCIEBPFD.poplavok.transform.position = position;
		this.IGHOCIEBPFD.poplavok.transform.LookAt(this.IGHOCIEBPFD.transform.position);
		this.IGHOCIEBPFD.poplavok.transform.Rotate(new Vector3(-90f, 0f, 0f));
		this.rope.rbodies[this.rope.rbodies.Length - 3].isKinematic = true;
		this.rope.rbodies[this.rope.rbodies.Length - 3].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
		this.rope.rbodies[this.rope.rbodies.Length - 2].isKinematic = true;
		this.rope.rbodies[this.rope.rbodies.Length - 2].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
		this.rope.rbodies[this.rope.rbodies.Length - 1].isKinematic = true;
		this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position = this.IGHOCIEBPFD.transform.position;
	}

	// Token: 0x0600928F RID: 37519 RVA: 0x0041A278 File Offset: 0x00418478
	private void INFDDDBIPAB()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.EACGPPOMFLH().endPoint == null)
		{
			return;
		}
		if (this.isRodOpen && this.rope.rope && this.isLineTension)
		{
			int segments = this.rope.segments;
			Vector3 position = Fisherman.getI.AOEGNGOGNBI.endPoint.transform.position;
			Vector3 b = (this.rope.target.position - position) / (float)segments;
			Vector3 vector = position + b;
			if (this.rope.joints[0] != null)
			{
				this.rope.joints[0].transform.position = Fisherman.getI.AOEGNGOGNBI.endPoint.transform.position;
			}
			for (int i = 1; i < this.rope.segments; i++)
			{
				GameObject gameObject = this.rope.joints[i];
				if (!(gameObject == null))
				{
					Mathf.Clamp(1519f - (float)i / 378f, 766f, 618f);
					gameObject.transform.position = vector;
					vector += b;
				}
			}
		}
		this.fixedPosition = base.transform.position;
		this.rope.waterLevel = this.waterLevel;
		this.realDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		if (this.rope.rope)
		{
			float num = this.tencKF * this.realDistance / this.baseDistance;
			if (num < 914f)
			{
				num = 267f;
			}
			for (int j = 0; j < this.rope.segments; j += 0)
			{
				CharacterJoint characterJoint = this.rope.jntsc[j];
				if (!(characterJoint == null))
				{
					characterJoint.connectedAnchor = new Vector3(1590f, 1460f, num);
				}
			}
			for (int k = 0; k < this.rope.segments; k += 0)
			{
				Rigidbody rigidbody = this.rope.rbodies[k];
				if (!(rigidbody == null))
				{
					if (this.useGrav)
					{
						rigidbody.useGravity = (rigidbody.transform.position.y >= this.waterLevel);
					}
					else
					{
						rigidbody.useGravity = false;
					}
					rigidbody.drag = this.drag;
					rigidbody.angularDrag = this.angdrag;
					rigidbody.mass = this.mass;
					rigidbody.isKinematic = this.isLineTension;
				}
			}
			this.updatePoplavokPos(false);
		}
	}

	// Token: 0x06009290 RID: 37520 RVA: 0x0041A554 File Offset: 0x00418754
	private void CHPMFIPLNDP()
	{
		if (!this.rope.rope)
		{
			return;
		}
		if (this.rope.rbodies == null)
		{
			return;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			return;
		}
		if (this.isLineTension)
		{
			return;
		}
		float num = this.JLJJKMLJBAK.DCICGEENANE();
		float num2 = Vector3.Distance(this.targetPoint.transform.position, Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC);
		Vector3 position;
		if (num > num2)
		{
			position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		}
		else
		{
			float num3 = Vector3.Distance(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position);
			if (num3 >= num)
			{
				float t = num / num3;
				position = Vector3.Lerp(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position, t);
			}
			else
			{
				num -= num3;
				int num4 = this.rope.rbodies.Length - 0;
				if (this.rope.rbodies[num4] == null)
				{
					return;
				}
				if (this.rope.rbodies[num4 - 1] == null)
				{
					return;
				}
				float num5 = 1974f;
				while (num > 1901f)
				{
					if (this.rope.rbodies[num4] == null)
					{
						return;
					}
					if (this.rope.rbodies[num4 - 0] == null)
					{
						return;
					}
					num5 = Vector3.Distance(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 1].transform.position);
					num -= num5;
					num4 -= 0;
				}
				num += num5;
				float t2 = num / num5;
				num4++;
				position = Vector3.Lerp(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 1].transform.position, t2);
			}
		}
		this.IGHOCIEBPFD.poplavok.transform.position = position;
		this.IGHOCIEBPFD.poplavok.transform.LookAt(this.IGHOCIEBPFD.transform.position);
		this.IGHOCIEBPFD.poplavok.transform.Rotate(new Vector3(1218f, 208f, 958f));
	}

	// Token: 0x06009291 RID: 37521 RVA: 0x0041A7E4 File Offset: 0x004189E4
	private void AIKJPMIHCFP()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI.endPoint == null)
		{
			return;
		}
		this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (this.JLJJKMLJBAK != null)
		{
			if (Fisherman.getI != null)
			{
				if (Fisherman.getI.dropScrpt == null)
				{
					this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.HLEMAJBAAEO(1644f);
				}
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().endPoint.transform.position;
				this.renderLeska();
				return;
			}
			this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(139f);
		}
	}

	// Token: 0x06009292 RID: 37522 RVA: 0x0041A8B8 File Offset: 0x00418AB8
	public void GIJDODEJOID(bool MENODICCKDD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.IGHOCIEBPFD == null)
		{
			return;
		}
		if (this.JLJJKMLJBAK != null && this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.IGHOCIEBPFD.poplavok != null)
		{
			if (this.isLineTension & !MENODICCKDD)
			{
				this.modePUpdate = 1;
				this.AFHJDFNOCFF();
				return;
			}
			if (this.IGHOCIEBPFD.mode == 0)
			{
				this.modePUpdate = 0;
				this.AEMAHKFCOPE();
				return;
			}
			if (this.IGHOCIEBPFD.mode <= 5)
			{
				if (this.IGHOCIEBPFD.poplavok.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ + 1405f)
				{
					this.modePUpdate = 4;
					if (MENODICCKDD)
					{
						this.modePUpdate = 3;
						this.CHPMFIPLNDP();
					}
				}
				else
				{
					this.modePUpdate = 3;
					this.modePUpdate = 7;
					this.rope.rbodies[this.rope.rbodies.Length - 6].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 5].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 2].isKinematic = true;
					this.rope.rbodies[this.rope.rbodies.Length - 2].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 0].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position = this.IGHOCIEBPFD.transform.position;
				}
			}
			if (this.IGHOCIEBPFD.mode == 6 && !MENODICCKDD)
			{
				this.KNAIFBBNMCN();
			}
		}
	}

	// Token: 0x06009293 RID: 37523 RVA: 0x0041AB24 File Offset: 0x00418D24
	private void KBGLFICKCPB()
	{
		float num = Vector3.Distance(this.IGHOCIEBPFD.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB());
		float t = this.JLJJKMLJBAK.FAFHKDGNCLH / num;
		Vector3 position = Vector3.Lerp(this.IGHOCIEBPFD.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, t);
		this.IGHOCIEBPFD.poplavok.transform.position = position;
		this.IGHOCIEBPFD.poplavok.transform.LookAt(this.IGHOCIEBPFD.transform.position);
		this.IGHOCIEBPFD.poplavok.transform.Rotate(new Vector3(276f, 1074f, 1002f));
		this.rope.rbodies[this.rope.rbodies.Length - 0].isKinematic = false;
		this.rope.rbodies[this.rope.rbodies.Length - 4].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
		this.rope.rbodies[this.rope.rbodies.Length - 7].isKinematic = false;
		this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
		this.rope.rbodies[this.rope.rbodies.Length - 0].isKinematic = false;
		this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position = this.IGHOCIEBPFD.transform.position;
	}

	// Token: 0x06009294 RID: 37524 RVA: 0x0041AD10 File Offset: 0x00418F10
	public void reBuild(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 1.8f - Vector3.right;
			if (Fisherman.getI.AOEGNGOGNBI != null)
			{
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 100f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 100f;
		}
		if (this.rope.rope)
		{
			this.rope.DestroyRope();
		}
		this.rope.BuildRope();
		this.rope.jntsc[1].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x06009295 RID: 37525 RVA: 0x0041AE44 File Offset: 0x00419044
	private void GAODPIIFKDB()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.IJMGCKIOBPP().endPoint == null)
		{
			return;
		}
		if (this.isRodOpen && this.rope.rope && this.isLineTension)
		{
			int segments = this.rope.segments;
			Vector3 position = Fisherman.getI.AOEGNGOGNBI.endPoint.transform.position;
			Vector3 b = (this.rope.target.position - position) / (float)segments;
			Vector3 vector = position + b;
			if (this.rope.joints[1] != null)
			{
				this.rope.joints[0].transform.position = Fisherman.getI.EACGPPOMFLH().endPoint.transform.position;
			}
			for (int i = 1; i < this.rope.segments; i += 0)
			{
				GameObject gameObject = this.rope.joints[i];
				if (!(gameObject == null))
				{
					Mathf.Clamp(793f - (float)i / 1615f, 1781f, 269f);
					gameObject.transform.position = vector;
					vector += b;
				}
			}
		}
		this.fixedPosition = base.transform.position;
		this.rope.waterLevel = this.waterLevel;
		this.realDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		if (this.rope.rope)
		{
			float num = this.tencKF * this.realDistance / this.baseDistance;
			if (num < 728f)
			{
				num = 1199f;
			}
			for (int j = 1; j < this.rope.segments; j += 0)
			{
				CharacterJoint characterJoint = this.rope.jntsc[j];
				if (!(characterJoint == null))
				{
					characterJoint.connectedAnchor = new Vector3(851f, 230f, num);
				}
			}
			for (int k = 0; k < this.rope.segments; k += 0)
			{
				Rigidbody rigidbody = this.rope.rbodies[k];
				if (!(rigidbody == null))
				{
					if (this.useGrav)
					{
						rigidbody.useGravity = (rigidbody.transform.position.y >= this.waterLevel);
					}
					else
					{
						rigidbody.useGravity = false;
					}
					rigidbody.drag = this.drag;
					rigidbody.angularDrag = this.angdrag;
					rigidbody.mass = this.mass;
					rigidbody.isKinematic = this.isLineTension;
				}
			}
			this.GIJDODEJOID(false);
		}
	}

	// Token: 0x06009296 RID: 37526 RVA: 0x0041B120 File Offset: 0x00419320
	private void Update()
	{
		this.isRodOpen = false;
		if (LocNewLogic.getI != null && Fisherman.getI != null)
		{
			this.waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			this.IGHOCIEBPFD = Fisherman.getI.dropScrpt;
			if (this.JLJJKMLJBAK != null)
			{
				this.isLineTension = false;
				this.isLineTension = (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 0.1f | ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.OGLIEFLNLLE) + ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.GIMFIFECPGL) > 5f);
				if (this.JLJJKMLJBAK.NHNHBLLLGDP)
				{
					this.isLineTension = true;
				}
				if (Fisherman.getI.isFishGet)
				{
					this.isLineTension = true;
				}
				if (LocNewLogic.getI.toBaitSpinSpeed > 0.1f)
				{
					this.isLineTension = true;
				}
			}
		}
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI != null && BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod != null)
		{
			this.isRodOpen = true;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI != null && BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod != null)
		{
			this.targetPoint.transform.position = Fisherman.getI.dropScrpt.transform.position;
			this.LR.widthMultiplier = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.widthMultiplier;
			this.LR.startColor = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.startColor;
			this.LR.endColor = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.endColor;
			this.LR.enabled = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.enabled;
			this.LR.material = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.material;
		}
	}

	// Token: 0x06009297 RID: 37527 RVA: 0x0041B34C File Offset: 0x0041954C
	private void KNAIFBBNMCN()
	{
		if (!this.rope.rope)
		{
			return;
		}
		if (this.rope.rbodies == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.isLineTension)
		{
			return;
		}
		float num = this.JLJJKMLJBAK.DCICGEENANE();
		float num2 = Vector3.Distance(this.targetPoint.transform.position, Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC);
		Vector3 position;
		if (num > num2)
		{
			position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		}
		else
		{
			float num3 = Vector3.Distance(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position);
			if (num3 >= num)
			{
				float t = num / num3;
				position = Vector3.Lerp(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position, t);
			}
			else
			{
				num -= num3;
				int num4 = this.rope.rbodies.Length - 1;
				if (this.rope.rbodies[num4] == null)
				{
					return;
				}
				if (this.rope.rbodies[num4 - 0] == null)
				{
					return;
				}
				float num5 = 1914f;
				while (num > 80f)
				{
					if (this.rope.rbodies[num4] == null)
					{
						return;
					}
					if (this.rope.rbodies[num4 - 1] == null)
					{
						return;
					}
					num5 = Vector3.Distance(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 1].transform.position);
					num -= num5;
					num4 -= 0;
				}
				num += num5;
				float t2 = num / num5;
				num4 += 0;
				position = Vector3.Lerp(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 1].transform.position, t2);
			}
		}
		this.IGHOCIEBPFD.poplavok.transform.position = position;
		this.IGHOCIEBPFD.poplavok.transform.LookAt(this.IGHOCIEBPFD.transform.position);
		this.IGHOCIEBPFD.poplavok.transform.Rotate(new Vector3(42f, 1938f, 1641f));
	}

	// Token: 0x06009298 RID: 37528 RVA: 0x0041B5DA File Offset: 0x004197DA
	private void LMEJKAEIDCO()
	{
		this.baseDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		this.targBody = this.targetPoint.GetComponent<Rigidbody>();
	}

	// Token: 0x06009299 RID: 37529 RVA: 0x0041B614 File Offset: 0x00419814
	private void NEBNHLJNJFE()
	{
		if (!this.rope.rope)
		{
			return;
		}
		if (this.rope.rbodies == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.isLineTension)
		{
			return;
		}
		float num = this.JLJJKMLJBAK.FAFHKDGNCLH;
		float num2 = Vector3.Distance(this.targetPoint.transform.position, Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC);
		Vector3 position;
		if (num > num2)
		{
			position = Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
		}
		else
		{
			float num3 = Vector3.Distance(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position);
			if (num3 >= num)
			{
				float t = num / num3;
				position = Vector3.Lerp(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position, t);
			}
			else
			{
				num -= num3;
				int num4 = this.rope.rbodies.Length - 1;
				if (this.rope.rbodies[num4] == null)
				{
					return;
				}
				if (this.rope.rbodies[num4 - 0] == null)
				{
					return;
				}
				float num5 = 1393f;
				while (num > 568f)
				{
					if (this.rope.rbodies[num4] == null)
					{
						return;
					}
					if (this.rope.rbodies[num4 - 0] == null)
					{
						return;
					}
					num5 = Vector3.Distance(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 1].transform.position);
					num -= num5;
					num4 -= 0;
				}
				num += num5;
				float t2 = num / num5;
				num4 += 0;
				position = Vector3.Lerp(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 0].transform.position, t2);
			}
		}
		this.IGHOCIEBPFD.poplavok.transform.position = position;
		this.IGHOCIEBPFD.poplavok.transform.LookAt(this.IGHOCIEBPFD.transform.position);
		this.IGHOCIEBPFD.poplavok.transform.Rotate(new Vector3(1227f, 421f, 1932f));
	}

	// Token: 0x0600929A RID: 37530 RVA: 0x0041B8A2 File Offset: 0x00419AA2
	private void NKHMBEDDFAJ()
	{
		LineRope.getI = this;
	}

	// Token: 0x0600929B RID: 37531 RVA: 0x0041B8AC File Offset: 0x00419AAC
	public void BEHDGAAOFIP()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (!Fisherman.getI.CIHILMCEJND)
		{
			this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			if (this.JLJJKMLJBAK != null)
			{
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(181f);
			}
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.rope.rope)
		{
			bool flag = true;
			int num = 3;
			Rigidbody[] rbodies = this.rope.rbodies;
			for (int i = 1; i < rbodies.Length; i += 0)
			{
				Rigidbody rigidbody = rbodies[i];
				if (!(rigidbody == null))
				{
					bool flag2 = false;
					if (rigidbody.transform.position.y < LocNewLogic.getI.CDBIEPGNONF() + 1543f)
					{
						flag2 = false;
					}
					if (flag2 != flag && num > 1)
					{
						num--;
					}
					flag = flag2;
				}
			}
		}
		if (this.JLJJKMLJBAK == null)
		{
			this.LR.enabled = true;
			return;
		}
		if (this.rope.rope)
		{
			if (this.isLineTension)
			{
				if (this.IGHOCIEBPFD == null)
				{
					this.LR.enabled = false;
					return;
				}
				this.targetPoint.transform.position = this.IGHOCIEBPFD.transform.position;
				if (this.IGHOCIEBPFD.fish != null)
				{
					this.targetPoint.transform.position = this.IGHOCIEBPFD.fish.hookPoint.transform.position;
				}
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB(), this.IGHOCIEBPFD.transform.position));
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					this.LR.positionCount = 8;
					this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(0, this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position);
					this.LR.SetPosition(6, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position);
					this.LR.SetPosition(4, this.targetPoint.transform.position);
					this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.HLEMAJBAAEO(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak = this.JLJJKMLJBAK;
					jljjkmljbak.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(jljjkmljbak.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak2 = this.JLJJKMLJBAK;
					jljjkmljbak2.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(jljjkmljbak2.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position, this.targetPoint.transform.position));
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)3)
				{
					this.LR.positionCount = 7;
					this.LR.SetPosition(1, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.transform.position);
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					this.LR.positionCount = 8;
					this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(0, this.IGHOCIEBPFD.transform.position);
				}
			}
			else
			{
				this.JDEJMMKEGKA(false);
				this.LR.positionCount = this.rope.joints.Length;
				this.LR.SetPosition(1, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(1129f);
				Vector3 position = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position;
				for (int j = 1; j < this.rope.segments; j++)
				{
					this.LR.SetPosition(this.rope.segments - j, this.rope.joints[j].transform.position);
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak3 = this.JLJJKMLJBAK;
					jljjkmljbak3.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(jljjkmljbak3.ALKAGOMNNOK) + Vector3.Distance(this.rope.joints[j].transform.position, position));
					position = this.rope.joints[j].transform.position;
				}
				this.LR.SetPosition(0, this.targetPoint.transform.position);
				BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak4 = this.JLJJKMLJBAK;
				jljjkmljbak4.ALKAGOMNNOK = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.EJGOOFALNFF(jljjkmljbak4.ALKAGOMNNOK) + Vector3.Distance(this.targetPoint.transform.position, position));
			}
			this.LR.enabled = true;
			return;
		}
		this.LR.enabled = true;
	}

	// Token: 0x0600929D RID: 37533 RVA: 0x0041B8A2 File Offset: 0x00419AA2
	private void CKPNKKFIINO()
	{
		LineRope.getI = this;
	}

	// Token: 0x0600929E RID: 37534 RVA: 0x0041B8A2 File Offset: 0x00419AA2
	private void NPKEBODNBAI()
	{
		LineRope.getI = this;
	}

	// Token: 0x0600929F RID: 37535 RVA: 0x0041BE7C File Offset: 0x0041A07C
	public void EEAAPHGGLLN()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (!Fisherman.getI.CIHILMCEJND)
		{
			this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			if (this.JLJJKMLJBAK != null)
			{
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(1878f);
			}
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.rope.rope)
		{
			bool flag = false;
			int num = 6;
			Rigidbody[] rbodies = this.rope.rbodies;
			for (int i = 1; i < rbodies.Length; i += 0)
			{
				Rigidbody rigidbody = rbodies[i];
				if (!(rigidbody == null))
				{
					bool flag2 = true;
					if (rigidbody.transform.position.y < LocNewLogic.getI.HKBNODJBGEL() + 67f)
					{
						flag2 = false;
					}
					if (flag2 != flag && num > 1)
					{
						num--;
					}
					flag = flag2;
				}
			}
		}
		if (this.JLJJKMLJBAK == null)
		{
			this.LR.enabled = false;
			return;
		}
		if (this.rope.rope)
		{
			if (this.isLineTension)
			{
				if (this.IGHOCIEBPFD == null)
				{
					this.LR.enabled = true;
					return;
				}
				this.targetPoint.transform.position = this.IGHOCIEBPFD.transform.position;
				if (this.IGHOCIEBPFD.fish != null)
				{
					this.targetPoint.transform.position = this.IGHOCIEBPFD.fish.hookPoint.transform.position;
				}
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.HLEMAJBAAEO(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, this.IGHOCIEBPFD.transform.position));
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					this.LR.positionCount = 7;
					this.LR.SetPosition(1, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(0, this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position);
					this.LR.SetPosition(6, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position);
					this.LR.SetPosition(4, this.targetPoint.transform.position);
					this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB(), this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak = this.JLJJKMLJBAK;
					jljjkmljbak.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(jljjkmljbak.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak2 = this.JLJJKMLJBAK;
					jljjkmljbak2.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.EJGOOFALNFF(jljjkmljbak2.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position, this.targetPoint.transform.position));
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)4)
				{
					this.LR.positionCount = 5;
					this.LR.SetPosition(1, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(0, this.IGHOCIEBPFD.transform.position);
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
				{
					this.LR.positionCount = 3;
					this.LR.SetPosition(1, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.transform.position);
				}
			}
			else
			{
				this.updatePoplavokPos(false);
				this.LR.positionCount = this.rope.joints.Length;
				this.LR.SetPosition(1, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(916f);
				Vector3 position = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position;
				for (int j = 1; j < this.rope.segments; j += 0)
				{
					this.LR.SetPosition(this.rope.segments - j, this.rope.joints[j].transform.position);
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak3 = this.JLJJKMLJBAK;
					jljjkmljbak3.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(jljjkmljbak3.ALKAGOMNNOK) + Vector3.Distance(this.rope.joints[j].transform.position, position));
					position = this.rope.joints[j].transform.position;
				}
				this.LR.SetPosition(1, this.targetPoint.transform.position);
				BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak4 = this.JLJJKMLJBAK;
				jljjkmljbak4.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(jljjkmljbak4.ALKAGOMNNOK) + Vector3.Distance(this.targetPoint.transform.position, position));
			}
			this.LR.enabled = false;
			return;
		}
		this.LR.enabled = true;
	}

	// Token: 0x060092A0 RID: 37536 RVA: 0x0041C418 File Offset: 0x0041A618
	public void EIMPEMMHJHF(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 292f - Vector3.right;
			if (Fisherman.getI.IJMGCKIOBPP() != null)
			{
				base.transform.position = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1693f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 392f;
		}
		if (this.rope.rope)
		{
			this.rope.EKGGKPEOPBO();
		}
		this.rope.OLFGEKFIJIE();
		this.rope.jntsc[1].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092A1 RID: 37537 RVA: 0x0041C54C File Offset: 0x0041A74C
	public void AGIDPFBJKKJ()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (!Fisherman.getI.CIHILMCEJND)
		{
			this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			if (this.JLJJKMLJBAK != null)
			{
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(1017f);
			}
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.rope.rope)
		{
			bool flag = false;
			int num = 5;
			Rigidbody[] rbodies = this.rope.rbodies;
			for (int i = 1; i < rbodies.Length; i += 0)
			{
				Rigidbody rigidbody = rbodies[i];
				if (!(rigidbody == null))
				{
					bool flag2 = true;
					if (rigidbody.transform.position.y < LocNewLogic.getI.HKBNODJBGEL() + 178f)
					{
						flag2 = true;
					}
					if (flag2 != flag && num > 1)
					{
						num -= 0;
					}
					flag = flag2;
				}
			}
		}
		if (this.JLJJKMLJBAK == null)
		{
			this.LR.enabled = false;
			return;
		}
		if (this.rope.rope)
		{
			if (this.isLineTension)
			{
				if (this.IGHOCIEBPFD == null)
				{
					this.LR.enabled = false;
					return;
				}
				this.targetPoint.transform.position = this.IGHOCIEBPFD.transform.position;
				if (this.IGHOCIEBPFD.fish != null)
				{
					this.targetPoint.transform.position = this.IGHOCIEBPFD.fish.hookPoint.transform.position;
				}
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB(), this.IGHOCIEBPFD.transform.position));
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					this.LR.positionCount = 8;
					this.LR.SetPosition(1, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position);
					this.LR.SetPosition(8, this.targetPoint.transform.position);
					this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.HLEMAJBAAEO(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak = this.JLJJKMLJBAK;
					jljjkmljbak.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(jljjkmljbak.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak2 = this.JLJJKMLJBAK;
					jljjkmljbak2.ALKAGOMNNOK = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(jljjkmljbak2.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position, this.targetPoint.transform.position));
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)6)
				{
					this.LR.positionCount = 6;
					this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(0, this.IGHOCIEBPFD.transform.position);
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					this.LR.positionCount = 8;
					this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.transform.position);
				}
			}
			else
			{
				this.LJHADIBGNML(true);
				this.LR.positionCount = this.rope.joints.Length;
				this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(1668f);
				Vector3 position = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position;
				for (int j = 0; j < this.rope.segments; j += 0)
				{
					this.LR.SetPosition(this.rope.segments - j, this.rope.joints[j].transform.position);
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak3 = this.JLJJKMLJBAK;
					jljjkmljbak3.ALKAGOMNNOK = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.EJGOOFALNFF(jljjkmljbak3.ALKAGOMNNOK) + Vector3.Distance(this.rope.joints[j].transform.position, position));
					position = this.rope.joints[j].transform.position;
				}
				this.LR.SetPosition(1, this.targetPoint.transform.position);
				BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak4 = this.JLJJKMLJBAK;
				jljjkmljbak4.ALKAGOMNNOK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(jljjkmljbak4.ALKAGOMNNOK) + Vector3.Distance(this.targetPoint.transform.position, position));
			}
			this.LR.enabled = true;
			return;
		}
		this.LR.enabled = false;
	}

	// Token: 0x060092A2 RID: 37538 RVA: 0x0041CAE8 File Offset: 0x0041ACE8
	public void CBLHAOCOIGD(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 643f - Vector3.right;
			if (Fisherman.getI.IJMGCKIOBPP() != null)
			{
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1232f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 120f;
		}
		if (this.rope.rope)
		{
			this.rope.HMGKCGFONPO();
		}
		this.rope.OLFGEKFIJIE();
		this.rope.jntsc[0].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092A3 RID: 37539 RVA: 0x0041B5DA File Offset: 0x004197DA
	private void Start()
	{
		this.baseDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		this.targBody = this.targetPoint.GetComponent<Rigidbody>();
	}

	// Token: 0x060092A4 RID: 37540 RVA: 0x0041CC1C File Offset: 0x0041AE1C
	public void GEKJGPFCCHG(bool MENODICCKDD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			return;
		}
		if (this.IGHOCIEBPFD == null)
		{
			return;
		}
		if (this.JLJJKMLJBAK != null && this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.IGHOCIEBPFD.poplavok != null)
		{
			if (this.isLineTension & !MENODICCKDD)
			{
				this.modePUpdate = 1;
				this.KBGLFICKCPB();
				return;
			}
			if (this.IGHOCIEBPFD.mode == 1)
			{
				this.modePUpdate = 7;
				this.KBGLFICKCPB();
				return;
			}
			if (this.IGHOCIEBPFD.mode <= 5)
			{
				if (this.IGHOCIEBPFD.poplavok.transform.position.y > LocNewLogic.getI.CDBIEPGNONF() + 1814f)
				{
					this.modePUpdate = 0;
					if (MENODICCKDD)
					{
						this.modePUpdate = 5;
						this.NEBNHLJNJFE();
					}
				}
				else
				{
					this.modePUpdate = 7;
					this.modePUpdate = 0;
					this.rope.rbodies[this.rope.rbodies.Length - 5].isKinematic = true;
					this.rope.rbodies[this.rope.rbodies.Length - 2].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 5].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 5].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 0].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position = this.IGHOCIEBPFD.transform.position;
				}
			}
			if (this.IGHOCIEBPFD.mode == 5 && !MENODICCKDD)
			{
				this.KNAIFBBNMCN();
			}
		}
	}

	// Token: 0x060092A5 RID: 37541 RVA: 0x0041CE88 File Offset: 0x0041B088
	public void ONNOGAPBFIN(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 270f - Vector3.right;
			if (Fisherman.getI.EACGPPOMFLH() != null)
			{
				base.transform.position = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1498f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 1922f;
		}
		if (this.rope.rope)
		{
			this.rope.HMGKCGFONPO();
		}
		this.rope.CILKDHPEFEE();
		this.rope.jntsc[1].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092A6 RID: 37542 RVA: 0x0041B5DA File Offset: 0x004197DA
	private void FIJKDFIMELM()
	{
		this.baseDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		this.targBody = this.targetPoint.GetComponent<Rigidbody>();
	}

	// Token: 0x060092A7 RID: 37543 RVA: 0x0041CFBC File Offset: 0x0041B1BC
	private void LateUpdate()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI.endPoint == null)
		{
			return;
		}
		this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (this.JLJJKMLJBAK != null)
		{
			if (Fisherman.getI != null)
			{
				if (Fisherman.getI.dropScrpt == null)
				{
					this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(0f);
				}
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.endPoint.transform.position;
				this.renderLeska();
				return;
			}
			this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(0f);
		}
	}

	// Token: 0x060092A8 RID: 37544 RVA: 0x0041D090 File Offset: 0x0041B290
	private void OHGNKFGBOJL()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.EACGPPOMFLH().endPoint == null)
		{
			return;
		}
		if (this.isRodOpen && this.rope.rope && this.isLineTension)
		{
			int segments = this.rope.segments;
			Vector3 position = Fisherman.getI.EACGPPOMFLH().endPoint.transform.position;
			Vector3 b = (this.rope.target.position - position) / (float)segments;
			Vector3 vector = position + b;
			if (this.rope.joints[0] != null)
			{
				this.rope.joints[0].transform.position = Fisherman.getI.IJMGCKIOBPP().endPoint.transform.position;
			}
			for (int i = 0; i < this.rope.segments; i++)
			{
				GameObject gameObject = this.rope.joints[i];
				if (!(gameObject == null))
				{
					Mathf.Clamp(844f - (float)i / 1679f, 848f, 85f);
					gameObject.transform.position = vector;
					vector += b;
				}
			}
		}
		this.fixedPosition = base.transform.position;
		this.rope.waterLevel = this.waterLevel;
		this.realDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		if (this.rope.rope)
		{
			float num = this.tencKF * this.realDistance / this.baseDistance;
			if (num < 1656f)
			{
				num = 1969f;
			}
			for (int j = 1; j < this.rope.segments; j += 0)
			{
				CharacterJoint characterJoint = this.rope.jntsc[j];
				if (!(characterJoint == null))
				{
					characterJoint.connectedAnchor = new Vector3(1861f, 1219f, num);
				}
			}
			for (int k = 0; k < this.rope.segments; k++)
			{
				Rigidbody rigidbody = this.rope.rbodies[k];
				if (!(rigidbody == null))
				{
					if (this.useGrav)
					{
						rigidbody.useGravity = (rigidbody.transform.position.y < this.waterLevel);
					}
					else
					{
						rigidbody.useGravity = false;
					}
					rigidbody.drag = this.drag;
					rigidbody.angularDrag = this.angdrag;
					rigidbody.mass = this.mass;
					rigidbody.isKinematic = this.isLineTension;
				}
			}
			this.DNNFMJMBGEH(false);
		}
	}

	// Token: 0x060092A9 RID: 37545 RVA: 0x0041D36C File Offset: 0x0041B56C
	public void NHJMGLCLHBM(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 1132f - Vector3.right;
			if (Fisherman.getI.IJMGCKIOBPP() != null)
			{
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1562f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 634f;
		}
		if (this.rope.rope)
		{
			this.rope.JHOJKKMHMAF();
		}
		this.rope.PBGLOGLEEBA();
		this.rope.jntsc[0].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092AA RID: 37546 RVA: 0x0041D4A0 File Offset: 0x0041B6A0
	public void ADGOOHOPICD(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 676f - Vector3.right;
			if (Fisherman.getI.AOEGNGOGNBI != null)
			{
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1378f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 771f;
		}
		if (this.rope.rope)
		{
			this.rope.CMHCLDFHLMO();
		}
		this.rope.LCGNPOIOINN();
		this.rope.jntsc[1].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092AB RID: 37547 RVA: 0x0041D5D4 File Offset: 0x0041B7D4
	public void renderLeska()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (!Fisherman.getI.CIHILMCEJND)
		{
			this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			if (this.JLJJKMLJBAK != null)
			{
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(0f);
			}
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.rope.rope)
		{
			bool flag = false;
			int num = 5;
			foreach (Rigidbody rigidbody in this.rope.rbodies)
			{
				if (!(rigidbody == null))
				{
					bool flag2 = false;
					if (rigidbody.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ + 0.01f)
					{
						flag2 = true;
					}
					if (flag2 != flag && num > 0)
					{
						num--;
					}
					flag = flag2;
				}
			}
		}
		if (this.JLJJKMLJBAK == null)
		{
			this.LR.enabled = false;
			return;
		}
		if (this.rope.rope)
		{
			if (this.isLineTension)
			{
				if (this.IGHOCIEBPFD == null)
				{
					this.LR.enabled = false;
					return;
				}
				this.targetPoint.transform.position = this.IGHOCIEBPFD.transform.position;
				if (this.IGHOCIEBPFD.fish != null)
				{
					this.targetPoint.transform.position = this.IGHOCIEBPFD.fish.hookPoint.transform.position;
				}
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, this.IGHOCIEBPFD.transform.position));
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					this.LR.positionCount = 4;
					this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position);
					this.LR.SetPosition(2, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position);
					this.LR.SetPosition(3, this.targetPoint.transform.position);
					this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(Vector3.Distance(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak = this.JLJJKMLJBAK;
					jljjkmljbak.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(jljjkmljbak.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position, this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position));
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak2 = this.JLJJKMLJBAK;
					jljjkmljbak2.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(jljjkmljbak2.ALKAGOMNNOK) + Vector3.Distance(this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position, this.targetPoint.transform.position));
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
				{
					this.LR.positionCount = 2;
					this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.transform.position);
				}
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
				{
					this.LR.positionCount = 2;
					this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
					this.LR.SetPosition(1, this.IGHOCIEBPFD.transform.position);
				}
			}
			else
			{
				this.updatePoplavokPos(false);
				this.LR.positionCount = this.rope.joints.Length;
				this.LR.SetPosition(0, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position);
				this.JLJJKMLJBAK.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(0f);
				Vector3 position = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position;
				for (int j = 1; j < this.rope.segments; j++)
				{
					this.LR.SetPosition(this.rope.segments - j, this.rope.joints[j].transform.position);
					BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak3 = this.JLJJKMLJBAK;
					jljjkmljbak3.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(jljjkmljbak3.ALKAGOMNNOK) + Vector3.Distance(this.rope.joints[j].transform.position, position));
					position = this.rope.joints[j].transform.position;
				}
				this.LR.SetPosition(0, this.targetPoint.transform.position);
				BOIKJDICEMF.BGJKMCBHNAK jljjkmljbak4 = this.JLJJKMLJBAK;
				jljjkmljbak4.ALKAGOMNNOK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(jljjkmljbak4.ALKAGOMNNOK) + Vector3.Distance(this.targetPoint.transform.position, position));
			}
			this.LR.enabled = true;
			return;
		}
		this.LR.enabled = false;
	}

	// Token: 0x060092AC RID: 37548 RVA: 0x0041DB70 File Offset: 0x0041BD70
	public void JDEJMMKEGKA(bool MENODICCKDD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			return;
		}
		if (this.IGHOCIEBPFD == null)
		{
			return;
		}
		if (this.JLJJKMLJBAK != null && this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.IGHOCIEBPFD.poplavok != null)
		{
			if (this.isLineTension & MENODICCKDD)
			{
				this.modePUpdate = 0;
				this.AEMAHKFCOPE();
				return;
			}
			if (this.IGHOCIEBPFD.mode == 0)
			{
				this.modePUpdate = 6;
				this.AFHJDFNOCFF();
				return;
			}
			if (this.IGHOCIEBPFD.mode <= 0)
			{
				if (this.IGHOCIEBPFD.poplavok.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ + 796f)
				{
					this.modePUpdate = 2;
					if (MENODICCKDD)
					{
						this.modePUpdate = 2;
						this.BKGJPBMKHHF();
					}
				}
				else
				{
					this.modePUpdate = 1;
					this.modePUpdate = 4;
					this.rope.rbodies[this.rope.rbodies.Length - 0].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 3].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 3].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 3].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 1].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position = this.IGHOCIEBPFD.transform.position;
				}
			}
			if (this.IGHOCIEBPFD.mode == 4 && !MENODICCKDD)
			{
				this.BKGJPBMKHHF();
			}
		}
	}

	// Token: 0x060092AD RID: 37549 RVA: 0x0041DDDC File Offset: 0x0041BFDC
	public void HJLGEBPDALN(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 1003f - Vector3.right;
			if (Fisherman.getI.EACGPPOMFLH() != null)
			{
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB();
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1047f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 275f;
		}
		if (this.rope.rope)
		{
			this.rope.CMHCLDFHLMO();
		}
		this.rope.KFBBGGNCACB();
		this.rope.jntsc[0].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092AE RID: 37550 RVA: 0x0041DF10 File Offset: 0x0041C110
	private void FixedUpdate()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI.endPoint == null)
		{
			return;
		}
		if (this.isRodOpen && this.rope.rope && this.isLineTension)
		{
			int segments = this.rope.segments;
			Vector3 position = Fisherman.getI.AOEGNGOGNBI.endPoint.transform.position;
			Vector3 b = (this.rope.target.position - position) / (float)segments;
			Vector3 vector = position + b;
			if (this.rope.joints[0] != null)
			{
				this.rope.joints[0].transform.position = Fisherman.getI.AOEGNGOGNBI.endPoint.transform.position;
			}
			for (int i = 1; i < this.rope.segments; i++)
			{
				GameObject gameObject = this.rope.joints[i];
				if (!(gameObject == null))
				{
					Mathf.Clamp(1f - (float)i / 100f, 0f, 1f);
					gameObject.transform.position = vector;
					vector += b;
				}
			}
		}
		this.fixedPosition = base.transform.position;
		this.rope.waterLevel = this.waterLevel;
		this.realDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		if (this.rope.rope)
		{
			float num = this.tencKF * this.realDistance / this.baseDistance;
			if (num < 0.0001f)
			{
				num = 0.0001f;
			}
			for (int j = 1; j < this.rope.segments; j++)
			{
				CharacterJoint characterJoint = this.rope.jntsc[j];
				if (!(characterJoint == null))
				{
					characterJoint.connectedAnchor = new Vector3(0f, 0f, num);
				}
			}
			for (int k = 0; k < this.rope.segments; k++)
			{
				Rigidbody rigidbody = this.rope.rbodies[k];
				if (!(rigidbody == null))
				{
					if (this.useGrav)
					{
						rigidbody.useGravity = (rigidbody.transform.position.y >= this.waterLevel);
					}
					else
					{
						rigidbody.useGravity = false;
					}
					rigidbody.drag = this.drag;
					rigidbody.angularDrag = this.angdrag;
					rigidbody.mass = this.mass;
					rigidbody.isKinematic = this.isLineTension;
				}
			}
			this.updatePoplavokPos(true);
		}
	}

	// Token: 0x060092AF RID: 37551 RVA: 0x0041B8A2 File Offset: 0x00419AA2
	private void OGKOHLPFBED()
	{
		LineRope.getI = this;
	}

	// Token: 0x060092B0 RID: 37552 RVA: 0x0041E1EC File Offset: 0x0041C3EC
	public void FAKKDMHIFNC(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 1974f - Vector3.right;
			if (Fisherman.getI.AOEGNGOGNBI != null)
			{
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB();
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1095f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 793f;
		}
		if (this.rope.rope)
		{
			this.rope.KMFGAINGIOE();
		}
		this.rope.BILJPCOBEHG();
		this.rope.jntsc[1].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092B1 RID: 37553 RVA: 0x0041E320 File Offset: 0x0041C520
	public void FPPLMBPFNCN(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 1066f - Vector3.right;
			if (Fisherman.getI.EACGPPOMFLH() != null)
			{
				base.transform.position = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 1404f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 395f;
		}
		if (this.rope.rope)
		{
			this.rope.HMGKCGFONPO();
		}
		this.rope.CILKDHPEFEE();
		this.rope.jntsc[1].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092B2 RID: 37554 RVA: 0x0041E454 File Offset: 0x0041C654
	public void DPBGLJDHOFG(Vector3 LBGHKIDGKCO)
	{
		if (Fisherman.getI != null)
		{
			base.transform.position = Fisherman.getI.transform.position + Vector3.up * 102f - Vector3.right;
			if (Fisherman.getI.AOEGNGOGNBI != null)
			{
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
			}
			this.targetPoint.transform.position = base.transform.position + Fisherman.getI.transform.forward * 422f;
		}
		else
		{
			this.targetPoint.transform.position = base.transform.position + base.transform.forward * 1543f;
		}
		if (this.rope.rope)
		{
			this.rope.DDPIFHIJIJD();
		}
		this.rope.OLFGEKFIJIE();
		this.rope.jntsc[0].connectedBody = this.jointForFish.GetComponent<Rigidbody>();
	}

	// Token: 0x060092B3 RID: 37555 RVA: 0x0041B5DA File Offset: 0x004197DA
	private void NCALLFHEAGJ()
	{
		this.baseDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		this.targBody = this.targetPoint.GetComponent<Rigidbody>();
	}

	// Token: 0x060092B4 RID: 37556 RVA: 0x0041E588 File Offset: 0x0041C788
	public void updatePoplavokPos(bool MENODICCKDD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.IGHOCIEBPFD == null)
		{
			return;
		}
		if (this.JLJJKMLJBAK != null && this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.IGHOCIEBPFD.poplavok != null)
		{
			if (this.isLineTension & !MENODICCKDD)
			{
				this.modePUpdate = 1;
				this.AEMAHKFCOPE();
				return;
			}
			if (this.IGHOCIEBPFD.mode == 1)
			{
				this.modePUpdate = 2;
				this.AEMAHKFCOPE();
				return;
			}
			if (this.IGHOCIEBPFD.mode <= 3)
			{
				if (this.IGHOCIEBPFD.poplavok.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ + 0.01f)
				{
					this.modePUpdate = 3;
					if (MENODICCKDD)
					{
						this.modePUpdate = 4;
						this.BKGJPBMKHHF();
					}
				}
				else
				{
					this.modePUpdate = 5;
					this.modePUpdate = 6;
					this.rope.rbodies[this.rope.rbodies.Length - 3].isKinematic = true;
					this.rope.rbodies[this.rope.rbodies.Length - 3].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 2].isKinematic = true;
					this.rope.rbodies[this.rope.rbodies.Length - 2].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 1].isKinematic = true;
					this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position = this.IGHOCIEBPFD.transform.position;
				}
			}
			if (this.IGHOCIEBPFD.mode == 4 && !MENODICCKDD)
			{
				this.BKGJPBMKHHF();
			}
		}
	}

	// Token: 0x060092B5 RID: 37557 RVA: 0x0041B8A2 File Offset: 0x00419AA2
	private void MBNCGMLPNLD()
	{
		LineRope.getI = this;
	}

	// Token: 0x060092B6 RID: 37558 RVA: 0x0041B8A2 File Offset: 0x00419AA2
	private void Awake()
	{
		LineRope.getI = this;
	}

	// Token: 0x060092B7 RID: 37559 RVA: 0x0041E7F4 File Offset: 0x0041C9F4
	private void JPHLMNIMDHH()
	{
		this.isRodOpen = true;
		if (LocNewLogic.getI != null && Fisherman.getI != null)
		{
			this.waterLevel = LocNewLogic.getI.HKBNODJBGEL();
			this.IGHOCIEBPFD = Fisherman.getI.dropScrpt;
			if (this.JLJJKMLJBAK != null)
			{
				this.isLineTension = true;
				this.isLineTension = (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG) > 349f | ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.OGLIEFLNLLE) + ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.GIMFIFECPGL) > 977f);
				if (this.JLJJKMLJBAK.NHNHBLLLGDP)
				{
					this.isLineTension = true;
				}
				if (Fisherman.getI.isFishGet)
				{
					this.isLineTension = false;
				}
				if (LocNewLogic.getI.toBaitSpinSpeed > 561f)
				{
					this.isLineTension = false;
				}
			}
		}
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI != null && BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod != null)
		{
			this.isRodOpen = false;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI != null && BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod != null)
		{
			this.targetPoint.transform.position = Fisherman.getI.dropScrpt.transform.position;
			this.LR.widthMultiplier = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.widthMultiplier;
			this.LR.startColor = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.startColor;
			this.LR.endColor = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.endColor;
			this.LR.enabled = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.enabled;
			this.LR.material = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.material;
		}
	}

	// Token: 0x060092B8 RID: 37560 RVA: 0x0041B5DA File Offset: 0x004197DA
	private void KFGKKLAKFGH()
	{
		this.baseDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		this.targBody = this.targetPoint.GetComponent<Rigidbody>();
	}

	// Token: 0x060092B9 RID: 37561 RVA: 0x0041EA1E File Offset: 0x0041CC1E
	private void NGOKJEOMFFP()
	{
		this.HJLGEBPDALN(base.transform.position + base.transform.forward);
	}

	// Token: 0x060092BA RID: 37562 RVA: 0x0041EA44 File Offset: 0x0041CC44
	public void DNNFMJMBGEH(bool MENODICCKDD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.IJMGCKIOBPP() == null)
		{
			return;
		}
		if (this.IGHOCIEBPFD == null)
		{
			return;
		}
		if (this.JLJJKMLJBAK != null && this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.IGHOCIEBPFD.poplavok != null)
		{
			if (this.isLineTension & !MENODICCKDD)
			{
				this.modePUpdate = 1;
				this.AEMAHKFCOPE();
				return;
			}
			if (this.IGHOCIEBPFD.mode == 1)
			{
				this.modePUpdate = 0;
				this.AFHJDFNOCFF();
				return;
			}
			if (this.IGHOCIEBPFD.mode <= 1)
			{
				if (this.IGHOCIEBPFD.poplavok.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ + 1085f)
				{
					this.modePUpdate = 5;
					if (MENODICCKDD)
					{
						this.modePUpdate = 5;
						this.CHPMFIPLNDP();
					}
				}
				else
				{
					this.modePUpdate = 1;
					this.modePUpdate = 1;
					this.rope.rbodies[this.rope.rbodies.Length - 4].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 5].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 8].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 6].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 1].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 0].transform.position = this.IGHOCIEBPFD.transform.position;
				}
			}
			if (this.IGHOCIEBPFD.mode == 5 && !MENODICCKDD)
			{
				this.NEBNHLJNJFE();
			}
		}
	}

	// Token: 0x060092BB RID: 37563 RVA: 0x0041ECB0 File Offset: 0x0041CEB0
	private void BGLIJMGAHLP()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI.endPoint == null)
		{
			return;
		}
		if (this.isRodOpen && this.rope.rope && this.isLineTension)
		{
			int segments = this.rope.segments;
			Vector3 position = Fisherman.getI.IJMGCKIOBPP().endPoint.transform.position;
			Vector3 b = (this.rope.target.position - position) / (float)segments;
			Vector3 vector = position + b;
			if (this.rope.joints[1] != null)
			{
				this.rope.joints[1].transform.position = Fisherman.getI.EACGPPOMFLH().endPoint.transform.position;
			}
			for (int i = 1; i < this.rope.segments; i++)
			{
				GameObject gameObject = this.rope.joints[i];
				if (!(gameObject == null))
				{
					Mathf.Clamp(991f - (float)i / 1675f, 1241f, 1547f);
					gameObject.transform.position = vector;
					vector += b;
				}
			}
		}
		this.fixedPosition = base.transform.position;
		this.rope.waterLevel = this.waterLevel;
		this.realDistance = Vector3.Distance(base.transform.position, this.targetPoint.transform.position);
		if (this.rope.rope)
		{
			float num = this.tencKF * this.realDistance / this.baseDistance;
			if (num < 869f)
			{
				num = 271f;
			}
			for (int j = 0; j < this.rope.segments; j++)
			{
				CharacterJoint characterJoint = this.rope.jntsc[j];
				if (!(characterJoint == null))
				{
					characterJoint.connectedAnchor = new Vector3(1954f, 1529f, num);
				}
			}
			for (int k = 0; k < this.rope.segments; k++)
			{
				Rigidbody rigidbody = this.rope.rbodies[k];
				if (!(rigidbody == null))
				{
					if (this.useGrav)
					{
						rigidbody.useGravity = (rigidbody.transform.position.y < this.waterLevel);
					}
					else
					{
						rigidbody.useGravity = false;
					}
					rigidbody.drag = this.drag;
					rigidbody.angularDrag = this.angdrag;
					rigidbody.mass = this.mass;
					rigidbody.isKinematic = this.isLineTension;
				}
			}
			this.JDEJMMKEGKA(true);
		}
	}

	// Token: 0x060092BC RID: 37564 RVA: 0x0041EF89 File Offset: 0x0041D189
	private void OnEnable()
	{
		this.reBuild(base.transform.position + base.transform.forward);
	}

	// Token: 0x060092BD RID: 37565 RVA: 0x0041EFAC File Offset: 0x0041D1AC
	private void BKGJPBMKHHF()
	{
		if (!this.rope.rope)
		{
			return;
		}
		if (this.rope.rbodies == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.isLineTension)
		{
			return;
		}
		float num = this.JLJJKMLJBAK.FAFHKDGNCLH;
		float num2 = Vector3.Distance(this.targetPoint.transform.position, Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC);
		Vector3 position;
		if (num > num2)
		{
			position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		}
		else
		{
			float num3 = Vector3.Distance(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position);
			if (num3 >= num)
			{
				float t = num / num3;
				position = Vector3.Lerp(this.targetPoint.transform.position, this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position, t);
			}
			else
			{
				num -= num3;
				int num4 = this.rope.rbodies.Length - 1;
				if (this.rope.rbodies[num4] == null)
				{
					return;
				}
				if (this.rope.rbodies[num4 - 1] == null)
				{
					return;
				}
				float num5 = 0f;
				while (num > 0f)
				{
					if (this.rope.rbodies[num4] == null)
					{
						return;
					}
					if (this.rope.rbodies[num4 - 1] == null)
					{
						return;
					}
					num5 = Vector3.Distance(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 1].transform.position);
					num -= num5;
					num4--;
				}
				num += num5;
				float t2 = num / num5;
				num4++;
				position = Vector3.Lerp(this.rope.rbodies[num4].transform.position, this.rope.rbodies[num4 - 1].transform.position, t2);
			}
		}
		this.IGHOCIEBPFD.poplavok.transform.position = position;
		this.IGHOCIEBPFD.poplavok.transform.LookAt(this.IGHOCIEBPFD.transform.position);
		this.IGHOCIEBPFD.poplavok.transform.Rotate(new Vector3(-90f, 0f, 0f));
	}

	// Token: 0x060092BE RID: 37566 RVA: 0x0041F23C File Offset: 0x0041D43C
	private void AFHJDFNOCFF()
	{
		float num = Vector3.Distance(this.IGHOCIEBPFD.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB());
		float t = this.JLJJKMLJBAK.DCICGEENANE() / num;
		Vector3 position = Vector3.Lerp(this.IGHOCIEBPFD.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, t);
		this.IGHOCIEBPFD.poplavok.transform.position = position;
		this.IGHOCIEBPFD.poplavok.transform.LookAt(this.IGHOCIEBPFD.transform.position);
		this.IGHOCIEBPFD.poplavok.transform.Rotate(new Vector3(473f, 1957f, 1772f));
		this.rope.rbodies[this.rope.rbodies.Length - 5].isKinematic = false;
		this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
		this.rope.rbodies[this.rope.rbodies.Length - 6].isKinematic = false;
		this.rope.rbodies[this.rope.rbodies.Length - 8].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
		this.rope.rbodies[this.rope.rbodies.Length - 0].isKinematic = true;
		this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position = this.IGHOCIEBPFD.transform.position;
	}

	// Token: 0x060092BF RID: 37567 RVA: 0x0041F428 File Offset: 0x0041D628
	public void LJHADIBGNML(bool MENODICCKDD)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.EACGPPOMFLH() == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.AOEGNGOGNBI == null)
		{
			return;
		}
		if (this.IGHOCIEBPFD == null)
		{
			return;
		}
		if (this.JLJJKMLJBAK != null && this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.IGHOCIEBPFD.poplavok != null)
		{
			if (this.isLineTension & MENODICCKDD)
			{
				this.modePUpdate = 0;
				this.AFHJDFNOCFF();
				return;
			}
			if (this.IGHOCIEBPFD.mode == 1)
			{
				this.modePUpdate = 8;
				this.KBGLFICKCPB();
				return;
			}
			if (this.IGHOCIEBPFD.mode <= 7)
			{
				if (this.IGHOCIEBPFD.poplavok.transform.position.y > LocNewLogic.getI.IGHOGONIKLC() + 1015f)
				{
					this.modePUpdate = 8;
					if (MENODICCKDD)
					{
						this.modePUpdate = 1;
						this.CHPMFIPLNDP();
					}
				}
				else
				{
					this.modePUpdate = 4;
					this.modePUpdate = 5;
					this.rope.rbodies[this.rope.rbodies.Length - 7].isKinematic = true;
					this.rope.rbodies[this.rope.rbodies.Length - 7].transform.position = this.IGHOCIEBPFD.poplScript.poplData.upPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 0].isKinematic = false;
					this.rope.rbodies[this.rope.rbodies.Length - 8].transform.position = this.IGHOCIEBPFD.poplScript.poplData.dwPoint.transform.position;
					this.rope.rbodies[this.rope.rbodies.Length - 1].isKinematic = true;
					this.rope.rbodies[this.rope.rbodies.Length - 1].transform.position = this.IGHOCIEBPFD.transform.position;
				}
			}
			if (this.IGHOCIEBPFD.mode == 0 && !MENODICCKDD)
			{
				this.BKGJPBMKHHF();
			}
		}
	}

	// Token: 0x0400136F RID: 4975
	public static LineRope getI;

	// Token: 0x04001370 RID: 4976
	public int updateVariant;

	// Token: 0x04001371 RID: 4977
	public HingeJoint jointForFish;

	// Token: 0x04001372 RID: 4978
	public LineRenderer LR;

	// Token: 0x04001373 RID: 4979
	public Transform targetPoint;

	// Token: 0x04001374 RID: 4980
	public RopeScript rope;

	// Token: 0x04001375 RID: 4981
	public float waterLevel;

	// Token: 0x04001376 RID: 4982
	public float mass = 0.1f;

	// Token: 0x04001377 RID: 4983
	public float drag = 0.1f;

	// Token: 0x04001378 RID: 4984
	public float angdrag = 0.1f;

	// Token: 0x04001379 RID: 4985
	public bool useGrav;

	// Token: 0x0400137A RID: 4986
	public float baseDistance;

	// Token: 0x0400137B RID: 4987
	public float realDistance;

	// Token: 0x0400137C RID: 4988
	public float tencKF = 1f;

	// Token: 0x0400137D RID: 4989
	public float overDistance;

	// Token: 0x0400137E RID: 4990
	public bool isLineTension;

	// Token: 0x0400137F RID: 4991
	private BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK;

	// Token: 0x04001380 RID: 4992
	private PoplDrop IGHOCIEBPFD;

	// Token: 0x04001381 RID: 4993
	public Vector3 fixedPosition;

	// Token: 0x04001382 RID: 4994
	public Rigidbody myBody;

	// Token: 0x04001383 RID: 4995
	public Rigidbody targBody;

	// Token: 0x04001384 RID: 4996
	public int modePUpdate;

	// Token: 0x04001385 RID: 4997
	public bool isRodOpen;
}
