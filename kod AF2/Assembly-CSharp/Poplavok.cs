using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200012C RID: 300
public class Poplavok : MonoBehaviour
{
	// Token: 0x06003E20 RID: 15904 RVA: 0x001BEC98 File Offset: 0x001BCE98
	public void HLOFDNPNGOK()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.OCCMKOPELGK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1831f, 734f, 898f, 528f);
		gameObject.transform.localScale = new Vector3(802f, 474f, 179f);
		this.rotAngle = 422f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 276f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = 95;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("rollSoundVolume"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("dress", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E21 RID: 15905 RVA: 0x001BEE58 File Offset: 0x001BD058
	private void LMGBKHCHPHO()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 364f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 689f - 1468f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 698f / (Time.deltaTime + 1557f);
		this.oldPosition = base.transform.position;
		if (num3 > 1461f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.CDBIEPGNONF()) < 1624f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 8)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 868f, 1576f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 702f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1361f;
		vector2.y -= 1444f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 33f;
		if (num5 > 179f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 678f);
		}
		if (num5 > 492f)
		{
			float num7 = (position2.x - position.x) * 526f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1070f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1867f - num9;
		if (num9 < 1170f)
		{
			if (num9 < 932f)
			{
				num9 = 837f;
			}
			float num10 = 427f - num9;
			this.rotAngle = 1329f - num10 * 996f;
		}
		else
		{
			this.rotAngle = 1339f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1719f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 244f + 1766f * (this.poplParams.LOIBCMBMLEC() / 1560f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 178f + this.poplParams.PHLLHDNNOMB() * 315f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1096f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 1906f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.IGHOGONIKLC();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.CDBIEPGNONF())
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 1617f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.CLAEAFMCDMP();
				}
				float num15 = num13 * num14 * 1628f;
				num15 = Mathf.Clamp(num15, 1088f, 578f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E22 RID: 15906 RVA: 0x001BF4E0 File Offset: 0x001BD6E0
	private IEnumerator FJOCNECIMAI()
	{
		Poplavok.OJLHNCNAJIL ojlhncnajil = new Poplavok.OJLHNCNAJIL(1);
		ojlhncnajil.AENJLLPLILM = this;
		return ojlhncnajil;
	}

	// Token: 0x06003E23 RID: 15907 RVA: 0x001BF4EF File Offset: 0x001BD6EF
	private void AOCDDBNBADJ()
	{
		this.isWork = false;
		base.StartCoroutine(this.OCOOCJPFJOA());
	}

	// Token: 0x06003E24 RID: 15908 RVA: 0x001BF508 File Offset: 0x001BD708
	public void DFHGBNABLEC()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.OCCMKOPELGK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(569f, 1903f, 1734f, 1250f);
		gameObject.transform.localScale = new Vector3(428f, 494f, 207f);
		this.rotAngle = 900f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 520f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = 47;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("Speed"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("RollerBladeSkateFwd", LocNewLogic.getI.CDBIEPGNONF());
			}
		}
	}

	// Token: 0x06003E25 RID: 15909 RVA: 0x001BF6C8 File Offset: 0x001BD8C8
	public void KFNHCJGPFAJ()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.OCCMKOPELGK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1633f, 269f, 117f, 1080f);
		gameObject.transform.localScale = new Vector3(598f, 1732f, 1469f);
		this.rotAngle = 351f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 372f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = 52;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("Flap_02.wav"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("Water Refl Camera id", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E26 RID: 15910 RVA: 0x001BF888 File Offset: 0x001BDA88
	private void FPLNDDMFFKG()
	{
		if (base.transform.position.y > LocNewLogic.getI.HKBNODJBGEL())
		{
			return;
		}
		float d = 944f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 312f - 379f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1773f / (Time.deltaTime + 1021f);
		this.oldPosition = base.transform.position;
		if (num3 > 415f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.CDBIEPGNONF()) < 666f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 5)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 324f, 1053f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1911f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1027f;
		vector2.y -= 921f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 954f;
		if (num5 > 1173f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1026f);
		}
		if (num5 > 812f)
		{
			float num7 = (position2.x - position.x) * 1533f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 230f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.HKBNODJBGEL() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 1640f - num9;
		if (num9 < 1298f)
		{
			if (num9 < 1608f)
			{
				num9 = 3f;
			}
			float num10 = 831f - num9;
			this.rotAngle = 555f - num10 * 270f;
		}
		else
		{
			this.rotAngle = 390f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1955f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position3.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 70f + 1102f * (this.poplParams.OAAKPMLGJJH() / 510f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 929f + this.poplParams.PHLLHDNNOMB() * 393f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1571f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 1082f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.CDBIEPGNONF())
					{
						position.y = LocNewLogic.getI.IGHOGONIKLC();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.IGHOGONIKLC() - position.y;
				float num14 = 1603f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.EIHMJDCOOCC();
				}
				float num15 = num13 * num14 * 645f;
				num15 = Mathf.Clamp(num15, 1676f, 393f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E27 RID: 15911 RVA: 0x001BFF10 File Offset: 0x001BE110
	private void JCELICPHGEP()
	{
		this.isWork = true;
		base.StartCoroutine(this.BHBLFDNEMFJ());
	}

	// Token: 0x06003E28 RID: 15912 RVA: 0x001BFF28 File Offset: 0x001BE128
	private void KMLNBHIIGKH()
	{
		if (base.transform.position.y > LocNewLogic.getI.CDBIEPGNONF())
		{
			return;
		}
		float d = 1258f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 138f - 127f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1269f / (Time.deltaTime + 892f);
		this.oldPosition = base.transform.position;
		if (num3 > 1622f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.CDBIEPGNONF()) < 122f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 1)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1379f, 338f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 725f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1739f;
		vector2.y -= 1145f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 690f;
		if (num5 > 1442f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 220f);
		}
		if (num5 > 98f)
		{
			float num7 = (position2.x - position.x) * 623f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1392f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 447f - num9;
		if (num9 < 1433f)
		{
			if (num9 < 1557f)
			{
				num9 = 1366f;
			}
			float num10 = 1158f - num9;
			this.rotAngle = 371f - num10 * 1693f;
		}
		else
		{
			this.rotAngle = 622f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 57f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position3.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 478f + 1817f * (this.poplParams.LOIBCMBMLEC() / 707f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 372f + this.poplParams.FDCKJDDOJPB() * 1427f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 208f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 542f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.HKBNODJBGEL())
					{
						position.y = LocNewLogic.getI.HKBNODJBGEL();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.HKBNODJBGEL())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 1365f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.PHLLHDNNOMB();
				}
				float num15 = num13 * num14 * 1600f;
				num15 = Mathf.Clamp(num15, 908f, 1381f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E29 RID: 15913 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator LGNCBKDKDNH()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E2A RID: 15914 RVA: 0x001C05BF File Offset: 0x001BE7BF
	private void FPLHODJCJDO()
	{
		this.isWork = false;
		base.StartCoroutine(this.BHBLFDNEMFJ());
	}

	// Token: 0x06003E2B RID: 15915 RVA: 0x001C05D8 File Offset: 0x001BE7D8
	public void NHNKJPMICCF()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.OCNGPIEBEIG();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1299f, 1521f, 265f, 1240f);
		gameObject.transform.localScale = new Vector3(1595f, 947f, 959f);
		this.rotAngle = 449f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 52f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -103;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("_FresnelFade"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E2C RID: 15916 RVA: 0x001C0798 File Offset: 0x001BE998
	private void JPHLMNIMDHH()
	{
		if (base.transform.position.y > LocNewLogic.getI.CDBIEPGNONF())
		{
			return;
		}
		float d = 676f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1997f - 1047f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1021f / (Time.deltaTime + 389f);
		this.oldPosition = base.transform.position;
		if (num3 > 1186f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) < 671f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 0)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1204f, 1385f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 939f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 698f;
		vector2.y -= 611f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1300f;
		if (num5 > 287f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 864f);
		}
		if (num5 > 680f)
		{
			float num7 = (position2.x - position.x) * 1574f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 207f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.CDBIEPGNONF() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1786f - num9;
		if (num9 < 1933f)
		{
			if (num9 < 778f)
			{
				num9 = 64f;
			}
			float num10 = 208f - num9;
			this.rotAngle = 1906f - num10 * 791f;
		}
		else
		{
			this.rotAngle = 1347f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 719f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position3.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 544f + 1202f * (this.poplParams.OBEOJCGHOGL / 804f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1002f + this.poplParams.FDCKJDDOJPB() * 1499f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 617f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1706f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.CDBIEPGNONF())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 509f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.NAHLEJDLCNF();
				}
				float num15 = num13 * num14 * 1898f;
				num15 = Mathf.Clamp(num15, 1723f, 73f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E2D RID: 15917 RVA: 0x001C0E20 File Offset: 0x001BF020
	public void GJDCJFLEGMI()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.GNHNOEIALLK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1903f, 889f, 559f, 535f);
		gameObject.transform.localScale = new Vector3(1705f, 1361f, 1589f);
		this.rotAngle = 1086f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1541f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = -90;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("Roller Blade Grind Royale"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("SneakLeft", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E2E RID: 15918 RVA: 0x001C0FE0 File Offset: 0x001BF1E0
	public void PFMONFAKHBK()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.LFHPJGAPPCC();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(4f, 1487f, 691f, 554f);
		gameObject.transform.localScale = new Vector3(1827f, 1154f, 1056f);
		this.rotAngle = 1071f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 974f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -76;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("KatanaReady"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat(" assetbundle(s) in memory before unloading ", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E2F RID: 15919 RVA: 0x001C11A0 File Offset: 0x001BF3A0
	public void NEDPNIAFOIC()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.CPHOPIMGFBI();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(942f, 1368f, 996f, 604f);
		gameObject.transform.localScale = new Vector3(1319f, 1368f, 1902f);
		this.rotAngle = 982f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1174f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -120;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("◍◍◍"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("_TempRT", LocNewLogic.getI.IGHOGONIKLC());
			}
		}
	}

	// Token: 0x06003E30 RID: 15920 RVA: 0x001C1360 File Offset: 0x001BF560
	public void KCAGFFHECOM()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.EFEDICJAKPA();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1546f, 1270f, 145f, 1455f);
		gameObject.transform.localScale = new Vector3(1624f, 809f, 377f);
		this.rotAngle = 830f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 948f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -19;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("OneHandSwordSwing"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("Hidden/Post FX/Ambient Occlusion", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E31 RID: 15921 RVA: 0x001C151E File Offset: 0x001BF71E
	private void BFBBJILCKAK()
	{
		this.isWork = true;
		base.StartCoroutine(this.HPMCPCABMOP());
	}

	// Token: 0x06003E32 RID: 15922 RVA: 0x001C1534 File Offset: 0x001BF734
	private void PGIHAIPCJLL()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 1079f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1333f - 660f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 182f / (Time.deltaTime + 135f);
		this.oldPosition = base.transform.position;
		if (num3 > 1695f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) < 1111f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 7)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1777f, 965f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 957f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1500f;
		vector2.y -= 1146f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1606f;
		if (num5 > 122f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 431f);
		}
		if (num5 > 552f)
		{
			float num7 = (position2.x - position.x) * 1617f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 741f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 897f - num9;
		if (num9 < 14f)
		{
			if (num9 < 248f)
			{
				num9 = 1596f;
			}
			float num10 = 81f - num9;
			this.rotAngle = 1399f - num10 * 609f;
		}
		else
		{
			this.rotAngle = 552f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1436f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position3.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1552f + 1717f * (this.poplParams.OBEOJCGHOGL / 443f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 194f + this.poplParams.FDCKJDDOJPB() * 1981f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 124f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1666f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
					if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.HKBNODJBGEL())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 472f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.NAHLEJDLCNF();
				}
				float num15 = num13 * num14 * 1497f;
				num15 = Mathf.Clamp(num15, 1960f, 1177f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E33 RID: 15923 RVA: 0x001C1BBC File Offset: 0x001BFDBC
	private void GCNGEFBKMNC()
	{
		if (base.transform.position.y > LocNewLogic.getI.HKBNODJBGEL())
		{
			return;
		}
		float d = 543f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 246f - 1190f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1088f / (Time.deltaTime + 557f);
		this.oldPosition = base.transform.position;
		if (num3 > 311f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.CDBIEPGNONF()) < 1832f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 8)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1997f, 116f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 892f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1353f;
		vector2.y -= 329f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 337f;
		if (num5 > 1113f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1571f);
		}
		if (num5 > 470f)
		{
			float num7 = (position2.x - position.x) * 294f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1811f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.CDBIEPGNONF() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1422f - num9;
		if (num9 < 1124f)
		{
			if (num9 < 1179f)
			{
				num9 = 1817f;
			}
			float num10 = 1323f - num9;
			this.rotAngle = 1442f - num10 * 849f;
		}
		else
		{
			this.rotAngle = 1794f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 945f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 854f + 1504f * (this.poplParams.OAAKPMLGJJH() / 1170f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 375f + this.poplParams.JLLJFKOGLHJ * 1407f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1155f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 908f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
					if (position.y > LocNewLogic.getI.HKBNODJBGEL())
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 1439f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.EIHMJDCOOCC();
				}
				float num15 = num13 * num14 * 600f;
				num15 = Mathf.Clamp(num15, 1559f, 1737f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E34 RID: 15924 RVA: 0x001C2244 File Offset: 0x001C0444
	public void NBOCAPIABNI()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.LFHPJGAPPCC();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1111f, 1805f, 947f, 457f);
		gameObject.transform.localScale = new Vector3(1691f, 1312f, 1038f);
		this.rotAngle = 1653f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 64f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = 100;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty(""))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("RollerBladeCrossoverLeft", LocNewLogic.getI.CDBIEPGNONF());
			}
		}
	}

	// Token: 0x06003E35 RID: 15925 RVA: 0x001C2404 File Offset: 0x001C0604
	public void BBCINJAGHEP()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.MKJJJBAJGPO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1808f, 191f, 664f, 1633f);
		gameObject.transform.localScale = new Vector3(1123f, 1782f, 1500f);
		this.rotAngle = 1311f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 390f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -92;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("wpn_wgt"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("SoccerKeeperDiveStrafeCloseRight", LocNewLogic.getI.CDBIEPGNONF());
			}
		}
	}

	// Token: 0x06003E36 RID: 15926 RVA: 0x001C25C4 File Offset: 0x001C07C4
	private void FJEEADNCKAG()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 1461f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1866f - 1658f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 952f / (Time.deltaTime + 1993f);
		this.oldPosition = base.transform.position;
		if (num3 > 1747f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 1523f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 4)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 875f, 40f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1511f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 786f;
		vector2.y -= 848f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 1818f;
		if (num5 > 1153f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1590f);
		}
		if (num5 > 319f)
		{
			float num7 = (position2.x - position.x) * 1694f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1296f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.CDBIEPGNONF() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 1463f - num9;
		if (num9 < 818f)
		{
			if (num9 < 637f)
			{
				num9 = 563f;
			}
			float num10 = 807f - num9;
			this.rotAngle = 1075f - num10 * 1096f;
		}
		else
		{
			this.rotAngle = 1710f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1704f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1489f + 1101f * (this.poplParams.OAAKPMLGJJH() / 812f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 175f + this.poplParams.NAHLEJDLCNF() * 615f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 753f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1531f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.HKBNODJBGEL())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 288f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.FDCKJDDOJPB();
				}
				float num15 = num13 * num14 * 910f;
				num15 = Mathf.Clamp(num15, 744f, 1486f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E37 RID: 15927 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BKPJAHOPBCP()
	{
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x001C2C4C File Offset: 0x001C0E4C
	private void JIKGIJEHGAP()
	{
		if (base.transform.position.y > LocNewLogic.getI.IGHOGONIKLC())
		{
			return;
		}
		float d = 1034f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1522f - 1561f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1057f / (Time.deltaTime + 1322f);
		this.oldPosition = base.transform.position;
		if (num3 > 1031f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) < 1116f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 8)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 389f, 779f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1565f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 815f;
		vector2.y -= 497f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 536f;
		if (num5 > 1861f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1130f);
		}
		if (num5 > 132f)
		{
			float num7 = (position2.x - position.x) * 627f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 237f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.IGHOGONIKLC() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 148f - num9;
		if (num9 < 623f)
		{
			if (num9 < 1809f)
			{
				num9 = 1142f;
			}
			float num10 = 1182f - num9;
			this.rotAngle = 1129f - num10 * 1738f;
		}
		else
		{
			this.rotAngle = 126f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 562f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position3.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1049f + 1403f * (this.poplParams.PDMNLDLGJNG() / 1948f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1298f + this.poplParams.PHLLHDNNOMB() * 832f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1647f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1370f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.HKBNODJBGEL())
					{
						position.y = LocNewLogic.getI.HKBNODJBGEL();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 1779f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.FDCKJDDOJPB();
				}
				float num15 = num13 * num14 * 1104f;
				num15 = Mathf.Clamp(num15, 297f, 1880f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E39 RID: 15929 RVA: 0x001C32D4 File Offset: 0x001C14D4
	public void LCOEPODKCEB()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.PGPNBDMKIGO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1633f, 1656f, 289f, 50f);
		gameObject.transform.localScale = new Vector3(449f, 704f, 295f);
		this.rotAngle = 1606f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 722f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -15;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("===== ObscuredVector3Test =====\n"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("ApplePick", LocNewLogic.getI.CDBIEPGNONF());
			}
		}
	}

	// Token: 0x06003E3A RID: 15930 RVA: 0x001C3492 File Offset: 0x001C1692
	private void ELFALPCLKIE()
	{
		this.isWork = true;
		base.StartCoroutine(this.DNFALLIMFAE());
	}

	// Token: 0x06003E3B RID: 15931 RVA: 0x001C34A8 File Offset: 0x001C16A8
	private void Update()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 1f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1.5f - 0.3f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1f / (Time.deltaTime + 0.0001f);
		this.oldPosition = base.transform.position;
		if (num3 > 0.1f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 0.03f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 4)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 0f, 0f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 0.1f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 0f;
		vector2.y -= 180f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 100f;
		if (num5 > 0.15f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 5.5f);
		}
		if (num5 > 0.1f)
		{
			float num7 = (position2.x - position.x) * 0.3f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 0.3f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 100f - num9;
		if (num9 < 0.2f)
		{
			if (num9 < 0f)
			{
				num9 = 0f;
			}
			float num10 = 0.2f - num9;
			this.rotAngle = 90f - num10 * 450f;
		}
		else
		{
			this.rotAngle = 90f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + -0.001f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position3.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 6f + 6f * (this.poplParams.OBEOJCGHOGL / 100f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 0.2f + this.poplParams.JLLJFKOGLHJ * 0.1f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + -0.001f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 100f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 2f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.JLLJFKOGLHJ;
				}
				float num15 = num13 * num14 * 10f;
				num15 = Mathf.Clamp(num15, 0f, 0.25f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E3C RID: 15932 RVA: 0x001C3B30 File Offset: 0x001C1D30
	public void DHKFJABPKCB()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.MKJJJBAJGPO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1478f, 1377f, 812f, 841f);
		gameObject.transform.localScale = new Vector3(1065f, 1978f, 309f);
		this.rotAngle = 427f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1282f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = -32;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("ncht_ach1"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("ThinWall", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E3D RID: 15933 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator EOMMNKPNJPH()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E3E RID: 15934 RVA: 0x001C3CF0 File Offset: 0x001C1EF0
	public void JBOELKHCJKI()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.EFEDICJAKPA();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(53f, 296f, 502f, 1062f);
		gameObject.transform.localScale = new Vector3(157f, 225f, 1247f);
		this.rotAngle = 513f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1306f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -102;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("name"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("_NeutralTonemapperParams1", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E3F RID: 15935 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FIPDKFFEKDD()
	{
	}

	// Token: 0x06003E40 RID: 15936 RVA: 0x001C3EAE File Offset: 0x001C20AE
	private void MCHAAIIHOKD()
	{
		this.isWork = true;
		base.StartCoroutine(this.FJOCNECIMAI());
	}

	// Token: 0x06003E41 RID: 15937 RVA: 0x001C3EC4 File Offset: 0x001C20C4
	private void MIFLHGMPLJD()
	{
		if (base.transform.position.y > LocNewLogic.getI.IGHOGONIKLC())
		{
			return;
		}
		float d = 1644f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 251f - 1328f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 789f / (Time.deltaTime + 1688f);
		this.oldPosition = base.transform.position;
		if (num3 > 826f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.CDBIEPGNONF()) < 179f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 2)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1963f, 526f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 334f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 389f;
		vector2.y -= 507f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1384f;
		if (num5 > 44f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 281f);
		}
		if (num5 > 537f)
		{
			float num7 = (position2.x - position.x) * 1789f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 919f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.HKBNODJBGEL() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1861f - num9;
		if (num9 < 1219f)
		{
			if (num9 < 1090f)
			{
				num9 = 328f;
			}
			float num10 = 1607f - num9;
			this.rotAngle = 1376f - num10 * 130f;
		}
		else
		{
			this.rotAngle = 672f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 774f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position3.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1717f + 1224f * (this.poplParams.OBEOJCGHOGL / 734f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1331f + this.poplParams.CLAEAFMCDMP() * 1229f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1340f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 362f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
					if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 1988f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.NAHLEJDLCNF();
				}
				float num15 = num13 * num14 * 779f;
				num15 = Mathf.Clamp(num15, 1756f, 1828f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E42 RID: 15938 RVA: 0x001C454C File Offset: 0x001C274C
	private void KJJEEMEHGBF()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 948f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1905f - 538f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1229f / (Time.deltaTime + 848f);
		this.oldPosition = base.transform.position;
		if (num3 > 575f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 653f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 1)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 105f, 366f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 385f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1362f;
		vector2.y -= 11f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 1673f;
		if (num5 > 92f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1017f);
		}
		if (num5 > 1718f)
		{
			float num7 = (position2.x - position.x) * 426f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1968f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 831f - num9;
		if (num9 < 1794f)
		{
			if (num9 < 1937f)
			{
				num9 = 657f;
			}
			float num10 = 321f - num9;
			this.rotAngle = 108f - num10 * 1721f;
		}
		else
		{
			this.rotAngle = 860f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1504f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1801f + 1232f * (this.poplParams.LOIBCMBMLEC() / 134f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1823f + this.poplParams.JLLJFKOGLHJ * 714f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1222f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 406f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.CDBIEPGNONF())
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 1519f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.EIHMJDCOOCC();
				}
				float num15 = num13 * num14 * 983f;
				num15 = Mathf.Clamp(num15, 158f, 245f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E43 RID: 15939 RVA: 0x001BF4E0 File Offset: 0x001BD6E0
	private IEnumerator DAFENHOLBLA()
	{
		Poplavok.OJLHNCNAJIL ojlhncnajil = new Poplavok.OJLHNCNAJIL(1);
		ojlhncnajil.AENJLLPLILM = this;
		return ojlhncnajil;
	}

	// Token: 0x06003E44 RID: 15940 RVA: 0x001C4BD4 File Offset: 0x001C2DD4
	public void NGHGDJPPNAP()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.GNHNOEIALLK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1010f, 1273f, 439f, 915f);
		gameObject.transform.localScale = new Vector3(613f, 1865f, 1687f);
		this.rotAngle = 1132f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1804f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = -88;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("_FinalReflectionTexture"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("Moon reference not set.", LocNewLogic.getI.IGHOGONIKLC());
			}
		}
	}

	// Token: 0x06003E45 RID: 15941 RVA: 0x001C4D94 File Offset: 0x001C2F94
	private void BBFCMCAFOMH()
	{
		if (base.transform.position.y > LocNewLogic.getI.IGHOGONIKLC())
		{
			return;
		}
		float d = 245f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1302f - 1600f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1058f / (Time.deltaTime + 1277f);
		this.oldPosition = base.transform.position;
		if (num3 > 1042f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 1022f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 6)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 780f, 1960f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1941f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1185f;
		vector2.y -= 1299f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 109f;
		if (num5 > 1708f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1249f);
		}
		if (num5 > 634f)
		{
			float num7 = (position2.x - position.x) * 324f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 220f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.IGHOGONIKLC() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 582f - num9;
		if (num9 < 174f)
		{
			if (num9 < 656f)
			{
				num9 = 309f;
			}
			float num10 = 1446f - num9;
			this.rotAngle = 308f - num10 * 123f;
		}
		else
		{
			this.rotAngle = 1527f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 699f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 306f + 1780f * (this.poplParams.LOIBCMBMLEC() / 1519f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 909f + this.poplParams.CLAEAFMCDMP() * 1674f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1019f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 618f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
					if (position.y > LocNewLogic.getI.CDBIEPGNONF())
					{
						position.y = LocNewLogic.getI.HKBNODJBGEL();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 841f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.PHLLHDNNOMB();
				}
				float num15 = num13 * num14 * 849f;
				num15 = Mathf.Clamp(num15, 453f, 1325f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E46 RID: 15942 RVA: 0x001C541C File Offset: 0x001C361C
	private void JIFOELPAEHG()
	{
		if (base.transform.position.y > LocNewLogic.getI.HKBNODJBGEL())
		{
			return;
		}
		float d = 529f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 48f - 1090f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 590f / (Time.deltaTime + 774f);
		this.oldPosition = base.transform.position;
		if (num3 > 1805f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.IGHOGONIKLC()) < 212f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 8)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1798f, 1398f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 584f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1198f;
		vector2.y -= 752f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 713f;
		if (num5 > 1292f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1426f);
		}
		if (num5 > 783f)
		{
			float num7 = (position2.x - position.x) * 148f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 985f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.IGHOGONIKLC() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1625f - num9;
		if (num9 < 1455f)
		{
			if (num9 < 1245f)
			{
				num9 = 1580f;
			}
			float num10 = 1543f - num9;
			this.rotAngle = 862f - num10 * 1215f;
		}
		else
		{
			this.rotAngle = 1390f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 822f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 69f + 1712f * (this.poplParams.OAAKPMLGJJH() / 1590f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1911f + this.poplParams.FDCKJDDOJPB() * 277f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 391f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1814f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
					if (position.y > LocNewLogic.getI.HKBNODJBGEL())
					{
						position.y = LocNewLogic.getI.IGHOGONIKLC();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 1954f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.FDCKJDDOJPB();
				}
				float num15 = num13 * num14 * 1542f;
				num15 = Mathf.Clamp(num15, 1321f, 771f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E47 RID: 15943 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator IIEELAHGCBK()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E48 RID: 15944 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KMLAENJBADF()
	{
	}

	// Token: 0x06003E49 RID: 15945 RVA: 0x001C5AA4 File Offset: 0x001C3CA4
	private void FNBGGJJLIGG()
	{
		this.isWork = true;
		base.StartCoroutine(this.DJAHBHNEJMD());
	}

	// Token: 0x06003E4A RID: 15946 RVA: 0x001C5ABC File Offset: 0x001C3CBC
	public void IMDCJMLPGHI()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.GNHNOEIALLK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(957f, 988f, 523f, 1523f);
		gameObject.transform.localScale = new Vector3(572f, 230f, 1733f);
		this.rotAngle = 1022f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1637f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -1;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("qd_prise"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("_Gain", LocNewLogic.getI.CDBIEPGNONF());
			}
		}
	}

	// Token: 0x06003E4B RID: 15947 RVA: 0x001C5C7C File Offset: 0x001C3E7C
	public void Init()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.OCNGPIEBEIG();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		this.rotAngle = 90f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 0f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = 20;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("_WaterLevel"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("_WaterLevel", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E4C RID: 15948 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator OBMGEDBOFFG()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E4D RID: 15949 RVA: 0x001C5E3A File Offset: 0x001C403A
	private void MMACLBBMDLA()
	{
		this.isWork = true;
		base.StartCoroutine(this.LGNCBKDKDNH());
	}

	// Token: 0x06003E4E RID: 15950 RVA: 0x001C5E50 File Offset: 0x001C4050
	private void INKGAFANFIB()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 987f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1994f - 1363f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1817f / (Time.deltaTime + 1577f);
		this.oldPosition = base.transform.position;
		if (num3 > 1370f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.IGHOGONIKLC()) < 1755f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 4)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1950f, 1534f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 885f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 898f;
		vector2.y -= 1752f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 140f;
		if (num5 > 1901f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1377f);
		}
		if (num5 > 957f)
		{
			float num7 = (position2.x - position.x) * 1230f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1340f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.CDBIEPGNONF() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1375f - num9;
		if (num9 < 1617f)
		{
			if (num9 < 1517f)
			{
				num9 = 1664f;
			}
			float num10 = 1871f - num9;
			this.rotAngle = 1166f - num10 * 81f;
		}
		else
		{
			this.rotAngle = 25f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1835f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position3.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 747f + 1982f * (this.poplParams.OBEOJCGHOGL / 221f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 768f + this.poplParams.FDCKJDDOJPB() * 822f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1147f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1819f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.CDBIEPGNONF())
					{
						position.y = LocNewLogic.getI.HKBNODJBGEL();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.CDBIEPGNONF() - position.y;
				float num14 = 1312f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.JLLJFKOGLHJ;
				}
				float num15 = num13 * num14 * 160f;
				num15 = Mathf.Clamp(num15, 756f, 806f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E4F RID: 15951 RVA: 0x001C64D8 File Offset: 0x001C46D8
	private void PNBGJBMJLFM()
	{
		if (base.transform.position.y > LocNewLogic.getI.CDBIEPGNONF())
		{
			return;
		}
		float d = 153f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1607f - 280f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1082f / (Time.deltaTime + 435f);
		this.oldPosition = base.transform.position;
		if (num3 > 1641f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) < 729f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 8)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 191f, 559f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 264f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1739f;
		vector2.y -= 1304f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 771f;
		if (num5 > 1770f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 190f);
		}
		if (num5 > 1859f)
		{
			float num7 = (position2.x - position.x) * 395f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1553f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.HKBNODJBGEL() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 1260f - num9;
		if (num9 < 254f)
		{
			if (num9 < 1950f)
			{
				num9 = 1401f;
			}
			float num10 = 98f - num9;
			this.rotAngle = 528f - num10 * 1157f;
		}
		else
		{
			this.rotAngle = 1871f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1570f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position3.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 380f + 1136f * (this.poplParams.DOFNAOOCDDB() / 1140f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 560f + this.poplParams.NAHLEJDLCNF() * 1486f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1690f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 1328f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
					if (position.y > LocNewLogic.getI.HKBNODJBGEL())
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.IGHOGONIKLC() - position.y;
				float num14 = 921f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.NAHLEJDLCNF();
				}
				float num15 = num13 * num14 * 395f;
				num15 = Mathf.Clamp(num15, 913f, 1541f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E50 RID: 15952 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MGOJFCOBDPI()
	{
	}

	// Token: 0x06003E51 RID: 15953 RVA: 0x001C6B60 File Offset: 0x001C4D60
	public void ONBFICFJPLM()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.EFEDICJAKPA();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(467f, 583f, 7f, 1108f);
		gameObject.transform.localScale = new Vector3(1216f, 1883f, 848f);
		this.rotAngle = 553f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 288f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = 112;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("RemoveFinger index out of bounds."))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("Colors length of ", LocNewLogic.getI.IGHOGONIKLC());
			}
		}
	}

	// Token: 0x06003E52 RID: 15954 RVA: 0x001C6D20 File Offset: 0x001C4F20
	private void BNKJNBIDPME()
	{
		if (base.transform.position.y > LocNewLogic.getI.CDBIEPGNONF())
		{
			return;
		}
		float d = 1320f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1142f - 443f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 593f / (Time.deltaTime + 337f);
		this.oldPosition = base.transform.position;
		if (num3 > 998f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.IGHOGONIKLC()) < 1239f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 8)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1969f, 1578f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1795f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 67f;
		vector2.y -= 1120f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 10f;
		if (num5 > 1270f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1234f);
		}
		if (num5 > 869f)
		{
			float num7 = (position2.x - position.x) * 983f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 660f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.IGHOGONIKLC() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 870f - num9;
		if (num9 < 1143f)
		{
			if (num9 < 612f)
			{
				num9 = 1722f;
			}
			float num10 = 977f - num9;
			this.rotAngle = 922f - num10 * 526f;
		}
		else
		{
			this.rotAngle = 1428f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1673f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position3.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 971f + 910f * (this.poplParams.LOIBCMBMLEC() / 557f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1886f + this.poplParams.PHLLHDNNOMB() * 102f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1981f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 735f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 1224f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.FDCKJDDOJPB();
				}
				float num15 = num13 * num14 * 985f;
				num15 = Mathf.Clamp(num15, 444f, 1609f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E53 RID: 15955 RVA: 0x001C73A8 File Offset: 0x001C55A8
	private void ACLJDJBJLCD()
	{
		this.isWork = true;
		base.StartCoroutine(this.IJOPFNLPMHB());
	}

	// Token: 0x06003E54 RID: 15956 RVA: 0x001C05BF File Offset: 0x001BE7BF
	private void EFJDBBDMPMC()
	{
		this.isWork = false;
		base.StartCoroutine(this.BHBLFDNEMFJ());
	}

	// Token: 0x06003E55 RID: 15957 RVA: 0x001C73C0 File Offset: 0x001C55C0
	private void DKOIOBMMAGN()
	{
		if (base.transform.position.y > LocNewLogic.getI.CDBIEPGNONF())
		{
			return;
		}
		float d = 1856f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1817f - 775f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1382f / (Time.deltaTime + 462f);
		this.oldPosition = base.transform.position;
		if (num3 > 572f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.IGHOGONIKLC()) < 1753f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 0)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 600f, 571f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 526f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 467f;
		vector2.y -= 932f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 822f;
		if (num5 > 304f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1134f);
		}
		if (num5 > 251f)
		{
			float num7 = (position2.x - position.x) * 1538f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1296f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 669f - num9;
		if (num9 < 1267f)
		{
			if (num9 < 572f)
			{
				num9 = 34f;
			}
			float num10 = 1560f - num9;
			this.rotAngle = 181f - num10 * 615f;
		}
		else
		{
			this.rotAngle = 356f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1426f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 124f + 620f * (this.poplParams.DOFNAOOCDDB() / 1408f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 495f + this.poplParams.CLAEAFMCDMP() * 1864f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1042f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 729f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
					{
						position.y = LocNewLogic.getI.IGHOGONIKLC();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.HKBNODJBGEL())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 418f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.JLLJFKOGLHJ;
				}
				float num15 = num13 * num14 * 769f;
				num15 = Mathf.Clamp(num15, 1561f, 70f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E56 RID: 15958 RVA: 0x001C7A48 File Offset: 0x001C5C48
	private void HMEAENGBFKC()
	{
		if (base.transform.position.y > LocNewLogic.getI.IGHOGONIKLC())
		{
			return;
		}
		float d = 806f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1254f - 1886f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1444f / (Time.deltaTime + 1664f);
		this.oldPosition = base.transform.position;
		if (num3 > 675f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) < 1372f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 3)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 82f, 135f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1914f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1291f;
		vector2.y -= 359f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 496f;
		if (num5 > 1592f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1037f);
		}
		if (num5 > 1223f)
		{
			float num7 = (position2.x - position.x) * 831f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 138f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.HKBNODJBGEL() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 230f - num9;
		if (num9 < 1493f)
		{
			if (num9 < 1638f)
			{
				num9 = 1193f;
			}
			float num10 = 1352f - num9;
			this.rotAngle = 455f - num10 * 967f;
		}
		else
		{
			this.rotAngle = 867f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1199f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1159f + 1732f * (this.poplParams.OAAKPMLGJJH() / 250f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1365f + this.poplParams.JLLJFKOGLHJ * 1396f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 685f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 1763f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.CDBIEPGNONF())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 1489f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.JLLJFKOGLHJ;
				}
				float num15 = num13 * num14 * 927f;
				num15 = Mathf.Clamp(num15, 1763f, 934f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E57 RID: 15959 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HPDBKKOFBHN()
	{
	}

	// Token: 0x06003E58 RID: 15960 RVA: 0x001C80D0 File Offset: 0x001C62D0
	private void KBMKHLDOIKP()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 63f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 257f - 1389f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1781f / (Time.deltaTime + 1111f);
		this.oldPosition = base.transform.position;
		if (num3 > 1831f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 1667f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 7)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1365f, 967f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1128f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 949f;
		vector2.y -= 349f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 315f;
		if (num5 > 1906f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 311f);
		}
		if (num5 > 874f)
		{
			float num7 = (position2.x - position.x) * 789f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1559f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.HKBNODJBGEL() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 1141f - num9;
		if (num9 < 1617f)
		{
			if (num9 < 1837f)
			{
				num9 = 1743f;
			}
			float num10 = 1910f - num9;
			this.rotAngle = 1132f - num10 * 1988f;
		}
		else
		{
			this.rotAngle = 1100f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1649f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 275f + 376f * (this.poplParams.OBEOJCGHOGL / 354f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1144f + this.poplParams.EIHMJDCOOCC() * 136f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 30f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 374f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
					if (position.y > LocNewLogic.getI.CDBIEPGNONF())
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 107f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.PHLLHDNNOMB();
				}
				float num15 = num13 * num14 * 912f;
				num15 = Mathf.Clamp(num15, 289f, 1590f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E59 RID: 15961 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JAOIOHLFLFO()
	{
	}

	// Token: 0x06003E5A RID: 15962 RVA: 0x001C05BF File Offset: 0x001BE7BF
	private void BBFPILBIMKC()
	{
		this.isWork = false;
		base.StartCoroutine(this.BHBLFDNEMFJ());
	}

	// Token: 0x06003E5B RID: 15963 RVA: 0x001BFF10 File Offset: 0x001BE110
	private void KKCFKEDABLB()
	{
		this.isWork = true;
		base.StartCoroutine(this.BHBLFDNEMFJ());
	}

	// Token: 0x06003E5C RID: 15964 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OnGUI()
	{
	}

	// Token: 0x06003E5D RID: 15965 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AGBEEDOOOHA()
	{
	}

	// Token: 0x06003E5E RID: 15966 RVA: 0x001C3EAE File Offset: 0x001C20AE
	private void PNJHMJNFPLP()
	{
		this.isWork = true;
		base.StartCoroutine(this.FJOCNECIMAI());
	}

	// Token: 0x06003E5F RID: 15967 RVA: 0x001C8758 File Offset: 0x001C6958
	public void CKBAGPLCNHF()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.PGPNBDMKIGO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(955f, 1027f, 23f, 1298f);
		gameObject.transform.localScale = new Vector3(1372f, 1570f, 961f);
		this.rotAngle = 24f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1851f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -79;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("chatconnect"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("Road Points Marker", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E60 RID: 15968 RVA: 0x001C8918 File Offset: 0x001C6B18
	public void LMBCMOGIOAC()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.OCNGPIEBEIG();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1815f, 635f, 491f, 86f);
		gameObject.transform.localScale = new Vector3(1234f, 458f, 1252f);
		this.rotAngle = 74f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1896f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = -4;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("index"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("Mouse X", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E61 RID: 15969 RVA: 0x001C8AD6 File Offset: 0x001C6CD6
	private void JPHBPEAMNHB()
	{
		this.isWork = false;
		base.StartCoroutine(this.DNFALLIMFAE());
	}

	// Token: 0x06003E62 RID: 15970 RVA: 0x001C151E File Offset: 0x001BF71E
	private void FCCAIANLEFE()
	{
		this.isWork = true;
		base.StartCoroutine(this.HPMCPCABMOP());
	}

	// Token: 0x06003E63 RID: 15971 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NOBANMDHKNK()
	{
	}

	// Token: 0x06003E64 RID: 15972 RVA: 0x001C8AEC File Offset: 0x001C6CEC
	private void DHJDMKLBLEF()
	{
		this.isWork = true;
		base.StartCoroutine(this.OCOOCJPFJOA());
	}

	// Token: 0x06003E65 RID: 15973 RVA: 0x001C8B02 File Offset: 0x001C6D02
	private void Start()
	{
		this.isWork = false;
		base.StartCoroutine(this.IIEELAHGCBK());
	}

	// Token: 0x06003E66 RID: 15974 RVA: 0x001BF4E0 File Offset: 0x001BD6E0
	private IEnumerator ICHHGIFGKBH()
	{
		Poplavok.OJLHNCNAJIL ojlhncnajil = new Poplavok.OJLHNCNAJIL(1);
		ojlhncnajil.AENJLLPLILM = this;
		return ojlhncnajil;
	}

	// Token: 0x06003E67 RID: 15975 RVA: 0x001C8B18 File Offset: 0x001C6D18
	private void IKHCCAANGOP()
	{
		if (base.transform.position.y > LocNewLogic.getI.CDBIEPGNONF())
		{
			return;
		}
		float d = 259f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 611f - 416f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 550f / (Time.deltaTime + 693f);
		this.oldPosition = base.transform.position;
		if (num3 > 904f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.CDBIEPGNONF()) < 593f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 4)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1230f, 942f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 997f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 295f;
		vector2.y -= 1118f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1686f;
		if (num5 > 994f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1287f);
		}
		if (num5 > 475f)
		{
			float num7 = (position2.x - position.x) * 309f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 898f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 1337f - num9;
		if (num9 < 1883f)
		{
			if (num9 < 1462f)
			{
				num9 = 1377f;
			}
			float num10 = 1667f - num9;
			this.rotAngle = 91f - num10 * 1059f;
		}
		else
		{
			this.rotAngle = 1614f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1369f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1932f + 1333f * (this.poplParams.OBEOJCGHOGL / 994f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1463f + this.poplParams.JLLJFKOGLHJ * 563f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1458f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1295f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.CDBIEPGNONF())
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 1039f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.CLAEAFMCDMP();
				}
				float num15 = num13 * num14 * 1217f;
				num15 = Mathf.Clamp(num15, 1372f, 1798f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E68 RID: 15976 RVA: 0x001C91A0 File Offset: 0x001C73A0
	public void JBCDKDGIDHM()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.MKJJJBAJGPO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1120f, 1202f, 1552f, 663f);
		gameObject.transform.localScale = new Vector3(130f, 929f, 767f);
		this.rotAngle = 320f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 589f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -103;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("ScubaSwim"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("effect", LocNewLogic.getI.IGHOGONIKLC());
			}
		}
	}

	// Token: 0x06003E69 RID: 15977 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator OGGAPCJGDCE()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E6A RID: 15978 RVA: 0x001C05BF File Offset: 0x001BE7BF
	private void HHGGCBLOJGB()
	{
		this.isWork = false;
		base.StartCoroutine(this.BHBLFDNEMFJ());
	}

	// Token: 0x06003E6B RID: 15979 RVA: 0x001C8B02 File Offset: 0x001C6D02
	private void FECFLBMPAAL()
	{
		this.isWork = false;
		base.StartCoroutine(this.IIEELAHGCBK());
	}

	// Token: 0x06003E6C RID: 15980 RVA: 0x001BF4E0 File Offset: 0x001BD6E0
	private IEnumerator DNFALLIMFAE()
	{
		Poplavok.OJLHNCNAJIL ojlhncnajil = new Poplavok.OJLHNCNAJIL(1);
		ojlhncnajil.AENJLLPLILM = this;
		return ojlhncnajil;
	}

	// Token: 0x06003E6D RID: 15981 RVA: 0x001C9360 File Offset: 0x001C7560
	public void KJPEFOIIHGN()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.OCCMKOPELGK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1955f, 423f, 284f, 926f);
		gameObject.transform.localScale = new Vector3(242f, 1758f, 1827f);
		this.rotAngle = 935f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 925f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = 1;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("WeaponReady"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("FlyRight", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E6E RID: 15982 RVA: 0x001C951E File Offset: 0x001C771E
	private void NCBLFNKNEDK()
	{
		this.isWork = false;
		base.StartCoroutine(this.DAFENHOLBLA());
	}

	// Token: 0x06003E6F RID: 15983 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KGACCCCNDOF()
	{
	}

	// Token: 0x06003E70 RID: 15984 RVA: 0x001C9534 File Offset: 0x001C7734
	private void KJJNMNKPNCH()
	{
		this.isWork = true;
		base.StartCoroutine(this.EOMMNKPNJPH());
	}

	// Token: 0x06003E71 RID: 15985 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DCHAPIHINBJ()
	{
	}

	// Token: 0x06003E72 RID: 15986 RVA: 0x001C954C File Offset: 0x001C774C
	public void DJJJGJEJLHI()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.PGPNBDMKIGO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(202f, 1348f, 902f, 391f);
		gameObject.transform.localScale = new Vector3(1138f, 1760f, 684f);
		this.rotAngle = 476f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1951f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = 124;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("Cloth_01.wav"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("bases/base_{0}", LocNewLogic.getI.CDBIEPGNONF());
			}
		}
	}

	// Token: 0x06003E73 RID: 15987 RVA: 0x001C970C File Offset: 0x001C790C
	private void JOHDLNOKCOK()
	{
		if (base.transform.position.y > LocNewLogic.getI.IGHOGONIKLC())
		{
			return;
		}
		float d = 1145f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 884f - 1925f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1375f / (Time.deltaTime + 308f);
		this.oldPosition = base.transform.position;
		if (num3 > 287f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 33f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 0)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1366f, 690f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 753f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1263f;
		vector2.y -= 450f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1831f;
		if (num5 > 871f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1359f);
		}
		if (num5 > 76f)
		{
			float num7 = (position2.x - position.x) * 713f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 629f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.IGHOGONIKLC() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 127f - num9;
		if (num9 < 997f)
		{
			if (num9 < 667f)
			{
				num9 = 1237f;
			}
			float num10 = 180f - num9;
			this.rotAngle = 1017f - num10 * 1140f;
		}
		else
		{
			this.rotAngle = 1275f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 46f > BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position3.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 248f + 424f * (this.poplParams.DOFNAOOCDDB() / 1374f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 924f + this.poplParams.JLLJFKOGLHJ * 1725f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 259f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 686f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
					if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
					{
						position.y = LocNewLogic.getI.IGHOGONIKLC();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.CDBIEPGNONF() - position.y;
				float num14 = 346f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.FDCKJDDOJPB();
				}
				float num15 = num13 * num14 * 669f;
				num15 = Mathf.Clamp(num15, 634f, 493f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E74 RID: 15988 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator BAAAIAGODJP()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E75 RID: 15989 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator IJOPFNLPMHB()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E76 RID: 15990 RVA: 0x001C9D94 File Offset: 0x001C7F94
	private void EMHGNEMIGII()
	{
		if (base.transform.position.y > LocNewLogic.getI.HKBNODJBGEL())
		{
			return;
		}
		float d = 1717f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1998f - 347f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1430f / (Time.deltaTime + 762f);
		this.oldPosition = base.transform.position;
		if (num3 > 1647f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) < 1291f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 7)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 823f, 1542f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 432f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 504f;
		vector2.y -= 859f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 417f;
		if (num5 > 1633f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 960f);
		}
		if (num5 > 1587f)
		{
			float num7 = (position2.x - position.x) * 1251f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 527f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.IGHOGONIKLC() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 528f - num9;
		if (num9 < 11f)
		{
			if (num9 < 1881f)
			{
				num9 = 722f;
			}
			float num10 = 1870f - num9;
			this.rotAngle = 1897f - num10 * 1675f;
		}
		else
		{
			this.rotAngle = 665f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1646f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1838f + 1343f * (this.poplParams.PDMNLDLGJNG() / 145f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 740f + this.poplParams.PHLLHDNNOMB() * 970f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 1098f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 296f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
					if (position.y > LocNewLogic.getI.CDBIEPGNONF())
					{
						position.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.IGHOGONIKLC())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 375f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.PHLLHDNNOMB();
				}
				float num15 = num13 * num14 * 522f;
				num15 = Mathf.Clamp(num15, 1449f, 981f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E77 RID: 15991 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator IEGGAINIBJM()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E78 RID: 15992 RVA: 0x001BF4E0 File Offset: 0x001BD6E0
	private IEnumerator OCOOCJPFJOA()
	{
		Poplavok.OJLHNCNAJIL ojlhncnajil = new Poplavok.OJLHNCNAJIL(1);
		ojlhncnajil.AENJLLPLILM = this;
		return ojlhncnajil;
	}

	// Token: 0x06003E79 RID: 15993 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KLBGEGDHCGA()
	{
	}

	// Token: 0x06003E7A RID: 15994 RVA: 0x001BFF10 File Offset: 0x001BE110
	private void CGNGBFFGGBP()
	{
		this.isWork = true;
		base.StartCoroutine(this.BHBLFDNEMFJ());
	}

	// Token: 0x06003E7B RID: 15995 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MBADKFPCOEJ()
	{
	}

	// Token: 0x06003E7D RID: 15997 RVA: 0x001CA46B File Offset: 0x001C866B
	private void LMEJKAEIDCO()
	{
		this.isWork = false;
		base.StartCoroutine(this.BAAAIAGODJP());
	}

	// Token: 0x06003E7E RID: 15998 RVA: 0x001CA484 File Offset: 0x001C8684
	private void KFNOEOIIBOI()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 1867f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1317f - 34f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1338f / (Time.deltaTime + 160f);
		this.oldPosition = base.transform.position;
		if (num3 > 1497f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) < 170f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 1)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 703f, 1825f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 299f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 815f;
		vector2.y -= 569f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 1272f;
		if (num5 > 13f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 417f);
		}
		if (num5 > 1082f)
		{
			float num7 = (position2.x - position.x) * 556f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 817f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.HKBNODJBGEL() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 1484f - num9;
		if (num9 < 1484f)
		{
			if (num9 < 106f)
			{
				num9 = 1806f;
			}
			float num10 = 1850f - num9;
			this.rotAngle = 816f - num10 * 1213f;
		}
		else
		{
			this.rotAngle = 1895f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1919f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1179f + 1252f * (this.poplParams.OAAKPMLGJJH() / 69f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1082f + this.poplParams.FDCKJDDOJPB() * 1546f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 590f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1932f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.HKBNODJBGEL())
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 1019f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.EIHMJDCOOCC();
				}
				float num15 = num13 * num14 * 1001f;
				num15 = Mathf.Clamp(num15, 1235f, 784f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E7F RID: 15999 RVA: 0x001CAB0C File Offset: 0x001C8D0C
	private void HDGNIHBIEDG()
	{
		this.isWork = true;
		base.StartCoroutine(this.BAAAIAGODJP());
	}

	// Token: 0x06003E80 RID: 16000 RVA: 0x001CAB24 File Offset: 0x001C8D24
	private void DEGCCLNOEKJ()
	{
		if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
		{
			return;
		}
		float d = 548f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 3f - 79f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1795f / (Time.deltaTime + 334f);
		this.oldPosition = base.transform.position;
		if (num3 > 995f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.IGHOGONIKLC()) < 47f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 5)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1887f, 1350f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1189f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1986f;
		vector2.y -= 465f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 891f;
		if (num5 > 1750f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1616f);
		}
		if (num5 > 46f)
		{
			float num7 = (position2.x - position.x) * 1953f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 985f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 199f - num9;
		if (num9 < 287f)
		{
			if (num9 < 1763f)
			{
				num9 = 1889f;
			}
			float num10 = 23f - num9;
			this.rotAngle = 120f - num10 * 1258f;
		}
		else
		{
			this.rotAngle = 437f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 138f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.CDBIEPGNONF())
				{
					position3.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 269f + 1512f * (this.poplParams.OBEOJCGHOGL / 1445f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 76f + this.poplParams.EIHMJDCOOCC() * 1333f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 719f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA / 1790f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.CDBIEPGNONF())
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 101f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.FDCKJDDOJPB();
				}
				float num15 = num13 * num14 * 1340f;
				num15 = Mathf.Clamp(num15, 1670f, 1599f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E81 RID: 16001 RVA: 0x001CB1AC File Offset: 0x001C93AC
	private void IJFPHGEFOLF()
	{
		this.isWork = true;
		base.StartCoroutine(this.ICHHGIFGKBH());
	}

	// Token: 0x06003E82 RID: 16002 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JEJGFDBHABC()
	{
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ADHEBPPFMOF()
	{
	}

	// Token: 0x06003E84 RID: 16004 RVA: 0x001CB1C4 File Offset: 0x001C93C4
	public void PGEGJANAHOK()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.OCNGPIEBEIG();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1292f, 1944f, 1518f, 846f);
		gameObject.transform.localScale = new Vector3(1818f, 1585f, 1495f);
		this.rotAngle = 1293f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 928f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = 78;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("Shoot Right"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("****softSpawn to ", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E85 RID: 16005 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator DJAHBHNEJMD()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E86 RID: 16006 RVA: 0x001CB382 File Offset: 0x001C9582
	private void IBPGMFNDPHH()
	{
		this.isWork = false;
		base.StartCoroutine(this.HPMCPCABMOP());
	}

	// Token: 0x06003E87 RID: 16007 RVA: 0x001CB398 File Offset: 0x001C9598
	public void OPMJGELNIEM()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.MKJJJBAJGPO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(904f, 545f, 317f, 1126f);
		gameObject.transform.localScale = new Vector3(983f, 1003f, 1475f);
		this.rotAngle = 194f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1029f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -25;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("BowInstant2"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("error.wav", LocNewLogic.getI.HKBNODJBGEL());
			}
		}
	}

	// Token: 0x06003E88 RID: 16008 RVA: 0x001C3EAE File Offset: 0x001C20AE
	private void KECMAHFJBCD()
	{
		this.isWork = true;
		base.StartCoroutine(this.FJOCNECIMAI());
	}

	// Token: 0x06003E89 RID: 16009 RVA: 0x001CB558 File Offset: 0x001C9758
	public void JPECAGNDMGB()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.OCCMKOPELGK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1015f, 638f, 58f, 1485f);
		gameObject.transform.localScale = new Vector3(266f, 772f, 1922f);
		this.rotAngle = 880f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 524f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -83;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("FlyDown"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("Player", LocNewLogic.getI.IGHOGONIKLC());
			}
		}
	}

	// Token: 0x06003E8A RID: 16010 RVA: 0x001CB718 File Offset: 0x001C9918
	public void EIDLDGDJPNL()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.CPHOPIMGFBI();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1504f, 1605f, 220f, 1803f);
		gameObject.transform.localScale = new Vector3(623f, 1651f, 1982f);
		this.rotAngle = 903f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 352f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -81;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty(" "))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("FS ", LocNewLogic.getI.IGHOGONIKLC());
			}
		}
	}

	// Token: 0x06003E8B RID: 16011 RVA: 0x001CB8D8 File Offset: 0x001C9AD8
	public void HGFCGPNEOHO()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.GNHNOEIALLK();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(854f, 926f, 1330f, 649f);
		gameObject.transform.localScale = new Vector3(1221f, 456f, 562f);
		this.rotAngle = 457f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 146f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = 80;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("There is already a virtual button named "))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat(" шт.", LocNewLogic.getI.IGHOGONIKLC());
			}
		}
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CKFIKGNJCKB()
	{
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LGKEFLBKIGN()
	{
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x001CBA98 File Offset: 0x001C9C98
	private void NFPFDOEENLA()
	{
		if (base.transform.position.y > LocNewLogic.getI.CDBIEPGNONF())
		{
			return;
		}
		float d = 14f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC, base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1853f - 808f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1420f / (Time.deltaTime + 165f);
		this.oldPosition = base.transform.position;
		if (num3 > 709f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 1664f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 3)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1355f, 1268f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1671f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 1584f;
		vector2.y -= 836f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 536f;
		if (num5 > 1913f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1097f);
		}
		if (num5 > 1339f)
		{
			float num7 = (position2.x - position.x) * 936f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 1661f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.OGJHINOLHJJ - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 1380f - num9;
		if (num9 < 1974f)
		{
			if (num9 < 1075f)
			{
				num9 = 822f;
			}
			float num10 = 748f - num9;
			this.rotAngle = 1121f - num10 * 1796f;
		}
		else
		{
			this.rotAngle = 27f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1077f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 1103f + 1939f * (this.poplParams.LOIBCMBMLEC() / 882f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 1896f + this.poplParams.FDCKJDDOJPB() * 10f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 9f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 405f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.HKBNODJBGEL();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.HKBNODJBGEL())
			{
				float num13 = LocNewLogic.getI.HKBNODJBGEL() - position.y;
				float num14 = 1372f;
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.CLAEAFMCDMP();
				}
				float num15 = num13 * num14 * 1134f;
				num15 = Mathf.Clamp(num15, 812f, 601f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E8F RID: 16015 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KBAJMMCHDOC()
	{
	}

	// Token: 0x06003E90 RID: 16016 RVA: 0x001BF4E0 File Offset: 0x001BD6E0
	private IEnumerator BHBLFDNEMFJ()
	{
		Poplavok.OJLHNCNAJIL ojlhncnajil = new Poplavok.OJLHNCNAJIL(1);
		ojlhncnajil.AENJLLPLILM = this;
		return ojlhncnajil;
	}

	// Token: 0x06003E91 RID: 16017 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GKEFNBPOEPJ()
	{
	}

	// Token: 0x06003E92 RID: 16018 RVA: 0x001CC120 File Offset: 0x001CA320
	public void LFLNBKOCHND()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.PGPNBDMKIGO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(448f, 1998f, 1763f, 1947f);
		gameObject.transform.localScale = new Vector3(748f, 1617f, 1864f);
		this.rotAngle = 964f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 395f));
		foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
		{
			transform.gameObject.layer = 38;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("popl.ogg"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("CrouchWalk", LocNewLogic.getI.CDBIEPGNONF());
			}
		}
	}

	// Token: 0x06003E93 RID: 16019 RVA: 0x001CC2E0 File Offset: 0x001CA4E0
	public void DHNNBLIMMGI()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CPEEOJICPCB.CPHOPIMGFBI();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(1920f, 322f, 218f, 1899f);
		gameObject.transform.localScale = new Vector3(126f, 1495f, 348f);
		this.rotAngle = 553f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 1135f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = -119;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("cash.ogg"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E94 RID: 16020 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator HPMCPCABMOP()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E95 RID: 16021 RVA: 0x001C8AEC File Offset: 0x001C6CEC
	private void EHDPACPIBNF()
	{
		this.isWork = true;
		base.StartCoroutine(this.OCOOCJPFJOA());
	}

	// Token: 0x06003E96 RID: 16022 RVA: 0x001CC4A0 File Offset: 0x001CA6A0
	private void EGAEDOHFAJE()
	{
		if (base.transform.position.y > LocNewLogic.getI.HKBNODJBGEL())
		{
			return;
		}
		float d = 1378f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1049f - 691f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 853f / (Time.deltaTime + 990f);
		this.oldPosition = base.transform.position;
		if (num3 > 775f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.CDBIEPGNONF()) < 843f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 4)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1250f, 1656f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1639f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 928f;
		vector2.y -= 1440f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 44f;
		if (num5 > 1432f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 861f);
		}
		if (num5 > 50f)
		{
			float num7 = (position2.x - position.x) * 1750f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 705f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.HKBNODJBGEL() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 397f - num9;
		if (num9 < 860f)
		{
			if (num9 < 1201f)
			{
				num9 = 902f;
			}
			float num10 = 976f - num9;
			this.rotAngle = 922f - num10 * 35f;
		}
		else
		{
			this.rotAngle = 1272f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 801f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH)
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
				if (position3.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position3.y = LocNewLogic.getI.OGJHINOLHJJ;
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 541f + 1992f * (this.poplParams.OBEOJCGHOGL / 1671f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 207f + this.poplParams.EIHMJDCOOCC() * 85f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 127f < BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 372f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
					if (position.y > LocNewLogic.getI.HKBNODJBGEL())
					{
						position.y = LocNewLogic.getI.CDBIEPGNONF();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 1847f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.CLAEAFMCDMP();
				}
				float num15 = num13 * num14 * 24f;
				num15 = Mathf.Clamp(num15, 1862f, 1214f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position.y = LocNewLogic.getI.HKBNODJBGEL();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x06003E97 RID: 16023 RVA: 0x001C05B0 File Offset: 0x001BE7B0
	private IEnumerator PHBJLBPEBIN()
	{
		this.AIOBJMPBNGJ = base.transform.position.y;
		for (;;)
		{
			float y = base.transform.position.y;
			if (this.isWork && y < this.AIOBJMPBNGJ)
			{
				LocNewLogic.getI.createWaterCircleSmall(base.transform.position, (int)(1f + (this.AIOBJMPBNGJ - y) * 100f));
			}
			this.AIOBJMPBNGJ = y;
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x06003E98 RID: 16024 RVA: 0x001CCB28 File Offset: 0x001CAD28
	public void DONMKBAAMKK()
	{
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
		{
			this.poplParams = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI;
		}
		GameObject gameObject = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CPEEOJICPCB.MKJJJBAJGPO();
		gameObject.transform.position = base.transform.position;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = new Quaternion(439f, 306f, 43f, 1087f);
		gameObject.transform.localScale = new Vector3(918f, 947f, 859f);
		this.rotAngle = 943f;
		this.poplData = gameObject.GetComponent<PoplavokData>();
		if (this.poplData == null)
		{
			this.poplData = base.gameObject.AddComponent<PoplavokData>();
			this.poplData.upPoint = base.transform;
			this.poplData.dwPoint = base.transform;
		}
		base.transform.rotation = Quaternion.Euler(new Vector3(this.rotAngle, this.rotWAngle, 47f));
		Transform[] componentsInChildren = gameObject.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Transform transform = componentsInChildren[i];
			transform.gameObject.layer = 37;
			if (transform.gameObject.GetComponent<Renderer>() != null && transform.gameObject.GetComponent<Renderer>().material.HasProperty("auk_wcnt"))
			{
				transform.gameObject.GetComponent<Renderer>().material.SetFloat("_WrinkleOcclusionMap0", LocNewLogic.getI.OGJHINOLHJJ);
			}
		}
	}

	// Token: 0x06003E99 RID: 16025 RVA: 0x001CCCE8 File Offset: 0x001CAEE8
	private void IEOICHPKEMD()
	{
		if (base.transform.position.y > LocNewLogic.getI.IGHOGONIKLC())
		{
			return;
		}
		float d = 1753f;
		base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
		if (!Fisherman.getI.fishRod)
		{
			float num = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB(), base.transform.position);
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1716f - 1122f;
			if (num > num2)
			{
				Vector3 vector = base.transform.position - Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
				vector.Normalize();
				vector *= num2;
				base.transform.position = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB() + vector;
			}
		}
		float num3 = Vector3.Distance(this.oldPosition, base.transform.position) * 1548f / (Time.deltaTime + 217f);
		this.oldPosition = base.transform.position;
		if (num3 > 1060f && Mathf.Abs(base.transform.position.y - LocNewLogic.getI.IGHOGONIKLC()) < 1439f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
		if (!this.isWork)
		{
			return;
		}
		if (PoplDrop.getI.mode == 3)
		{
			return;
		}
		Vector3 b = new Vector3(this.rotAngle, 1524f, 252f);
		Vector3 vector2 = this.baitObj.transform.position - base.transform.position;
		Quaternion rotation = base.transform.rotation;
		if (vector2.magnitude > 1211f)
		{
			rotation.SetLookRotation(vector2);
		}
		vector2 = rotation.eulerAngles;
		vector2.x = 769f;
		vector2.y -= 1973f;
		float num4 = this.rotAngle;
		Vector3 position = base.transform.position;
		Vector3 position2 = this.baitObj.transform.position;
		float num5 = Vector3.Distance(position, position2);
		float num6 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP() / 454f;
		if (num5 > 552f)
		{
			Quaternion b2 = Quaternion.Euler(vector2 + b);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * 1132f);
		}
		if (num5 > 77f)
		{
			float num7 = (position2.x - position.x) * 1327f * Time.deltaTime;
			float num8 = (position2.z - position.z) * 795f * Time.deltaTime;
			position.x += num7;
			position.z += num8;
			base.transform.position = position;
		}
		float num9 = LocNewLogic.getI.CDBIEPGNONF() - this.baitObj.transform.position.y;
		num9 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA / 211f - num9;
		if (num9 < 1284f)
		{
			if (num9 < 618f)
			{
				num9 = 688f;
			}
			float num10 = 1096f - num9;
			this.rotAngle = 643f - num10 * 1806f;
		}
		else
		{
			this.rotAngle = 1285f;
		}
		position = base.transform.position;
		if (position.y - this.baitObj.transform.position.y + 1096f > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE())
		{
			if (this.takeFish)
			{
				Vector3 position3 = this.baitObj.transform.position;
				position3.y += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
				if (position3.y > LocNewLogic.getI.IGHOGONIKLC())
				{
					position3.y = LocNewLogic.getI.IGHOGONIKLC();
				}
				Vector3 vector3 = position3 - base.transform.position;
				float num11 = 273f + 1725f * (this.poplParams.OBEOJCGHOGL / 683f);
				position.y += vector3.y * num11 * Time.deltaTime;
				base.transform.position = position;
			}
			else
			{
				float num12 = 758f + this.poplParams.EIHMJDCOOCC() * 91f;
				position.y -= num12 * Time.deltaTime;
				if (position.y - this.baitObj.transform.position.y + 436f < BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFELKILNKFP() / 583f)
				{
					position.y = this.baitObj.transform.position.y + BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
					if (position.y > LocNewLogic.getI.IGHOGONIKLC())
					{
						position.y = LocNewLogic.getI.HKBNODJBGEL();
					}
				}
			}
		}
		else
		{
			position = base.transform.position;
			if (!this.takeFish && position.y < LocNewLogic.getI.HKBNODJBGEL())
			{
				float num13 = LocNewLogic.getI.OGJHINOLHJJ - position.y;
				float num14 = 655f;
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD != null)
				{
					num14 += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.PHLLHDNNOMB();
				}
				float num15 = num13 * num14 * 1456f;
				num15 = Mathf.Clamp(num15, 1412f, 1680f);
				position.y += num15 * Time.deltaTime;
				if (position.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					position.y = LocNewLogic.getI.CDBIEPGNONF();
				}
				this.baitObj.transform.position = new Vector3(this.baitObj.transform.position.x, position.y - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH, this.baitObj.transform.position.z);
			}
		}
		base.transform.position = position;
	}

	// Token: 0x040008F1 RID: 2289
	public PoplavokData poplData;

	// Token: 0x040008F2 RID: 2290
	public GameObject baitObj;

	// Token: 0x040008F3 RID: 2291
	public IIBEEKCAAHK poplParams = new IIBEEKCAAHK(1.0, 1.0, 1.0);

	// Token: 0x040008F4 RID: 2292
	public bool isWork;

	// Token: 0x040008F5 RID: 2293
	public float rotAngle = 90f;

	// Token: 0x040008F6 RID: 2294
	public float rotWAngle;

	// Token: 0x040008F7 RID: 2295
	public bool takeFish;

	// Token: 0x040008F8 RID: 2296
	private float AIOBJMPBNGJ;

	// Token: 0x040008F9 RID: 2297
	public Vector3 oldPosition = Vector3.zero;
}
