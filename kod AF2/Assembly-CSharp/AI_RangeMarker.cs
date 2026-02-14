using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class AI_RangeMarker : MonoBehaviour
{
	// Token: 0x060009F4 RID: 2548 RVA: 0x000610D2 File Offset: 0x0005F2D2
	private void NLPHGJJOLOO()
	{
		if (this.NDLBHDAFBDL)
		{
			this.MFKADBEAABM();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x000610F4 File Offset: 0x0005F2F4
	private void JIFBPLHGLJB()
	{
		if (Application.isPlaying)
		{
			this.CEDPLAJKACL();
		}
		float num = this.angleView * 795f;
		Transform transform = new GameObject("1 Hand Sword Run").transform;
		Transform transform2 = new GameObject("B").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 841f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1506f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0006120C File Offset: 0x0005F40C
	private void HODGGMPGBAK()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(657f, -this.angleView * 517f, 411f);
			this.anchorRight.Rotate(956f, this.angleView * 547f, 120f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(585f, 943f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(150f, -this.angleView * 1858f, 1810f);
		this.anchorRight.Rotate(1027f, this.angleView * 1275f, 595f);
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x000613D0 File Offset: 0x0005F5D0
	private void DGFELGHEHFC()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1326f, -this.angleView * 37f, 470f);
			this.anchorRight.Rotate(314f, this.angleView * 1742f, 524f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(703f, 202f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1850f, -this.angleView * 669f, 390f);
		this.anchorRight.Rotate(810f, this.angleView * 1518f, 1392f);
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00061594 File Offset: 0x0005F794
	private void LDJOKIPCCBN()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1348f, -this.angleView * 1505f, 178f);
			this.anchorRight.Rotate(650f, this.angleView * 1006f, 311f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1656f, 1635f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1437f, -this.angleView * 1218f, 794f);
		this.anchorRight.Rotate(1582f, this.angleView * 1598f, 1585f);
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00061758 File Offset: 0x0005F958
	private void DGEIACONKCJ()
	{
		this.colorBack = this.color;
		this.AADBKKJELMG();
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0006176C File Offset: 0x0005F96C
	private void ECKGFMENAKF()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1386f);
			Gizmos.DrawWireSphere(base.transform.position, 524f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.GGJODAGEBBO();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0006181C File Offset: 0x0005FA1C
	private void OLBNLLBBGLI()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 746f);
			Gizmos.DrawWireSphere(base.transform.position, 1831f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.OFDNLDIGKHE();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x000618CC File Offset: 0x0005FACC
	private void PJNIBEFMPMF()
	{
		if (Application.isPlaying)
		{
			this.MJEKIIIMAKI();
		}
		float num = this.angleView * 393f;
		Transform transform = new GameObject("Level load event").transform;
		Transform transform2 = new GameObject("BOTTOM").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 565f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 894f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x000619E4 File Offset: 0x0005FBE4
	private void MFKADBEAABM()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1729f, -this.angleView * 1265f, 1938f);
			this.anchorRight.Rotate(1661f, this.angleView * 1416f, 31f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(193f, 1305f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1657f, -this.angleView * 379f, 311f);
		this.anchorRight.Rotate(1301f, this.angleView * 1209f, 1062f);
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00061BA8 File Offset: 0x0005FDA8
	private void GGJODAGEBBO()
	{
		if (Application.isPlaying)
		{
			this.FCMCELHHCNA();
		}
		float num = this.angleView * 1841f;
		Transform transform = new GameObject("Kernel").transform;
		Transform transform2 = new GameObject("wpn_rem3").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 145f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1743f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00061CC0 File Offset: 0x0005FEC0
	private void INCNMJBEFCK()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1697f, -this.angleView * 429f, 578f);
			this.anchorRight.Rotate(1437f, this.angleView * 1772f, 1315f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(585f, 1261f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(460f, -this.angleView * 1157f, 541f);
		this.anchorRight.Rotate(1607f, this.angleView * 1339f, 1898f);
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00061E84 File Offset: 0x00060084
	private void OAKCGBKOIGL()
	{
		this.anchorLeft = new GameObject("UserChange" + this.zoneName).transform;
		this.anchorRight = new GameObject("?" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject(" ").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("ShotgunReadyFire").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1040f, 67f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(161f, this.runtimeDistance, 1084f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(415f, 1259f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x0006207C File Offset: 0x0006027C
	private void AEFAILKLLCC()
	{
		if (Application.isPlaying)
		{
			this.AFDEKKBJMBJ();
		}
		float num = this.angleView * 966f;
		Transform transform = new GameObject("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/").transform;
		Transform transform2 = new GameObject("").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1004f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1112f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00062194 File Offset: 0x00060394
	private void AHBKDNFCCPP()
	{
		this.anchorLeft = new GameObject("Flap_04.wav" + this.zoneName).transform;
		this.anchorRight = new GameObject("perk" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject(" (").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("_FoamContrast").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1078f, 620f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(926f, this.runtimeDistance, 1328f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1231f, 1529f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags)(-108);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0006238C File Offset: 0x0006058C
	private void NLEEOBAEAMD()
	{
		if (Application.isPlaying)
		{
			this.ALEGPOLMMBL();
		}
		float num = this.angleView * 1455f;
		Transform transform = new GameObject("One of the Bones is null.").transform;
		Transform transform2 = new GameObject("tech").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 62f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 643f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x000624A2 File Offset: 0x000606A2
	private void LOFKNDCJBMN()
	{
		if (this.NDLBHDAFBDL)
		{
			this.INCNMJBEFCK();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x000624C4 File Offset: 0x000606C4
	private void PGANLMGHFPC()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1450f);
			Gizmos.DrawWireSphere(base.transform.position, 1007f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.ICGCIECHPKA();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x000610D2 File Offset: 0x0005F2D2
	private void LKOLHNPIBLM()
	{
		if (this.NDLBHDAFBDL)
		{
			this.MFKADBEAABM();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00062574 File Offset: 0x00060774
	private void OKJAOLDGCED()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 798f);
			Gizmos.DrawWireSphere(base.transform.position, 985f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.AHDMGNJIFFP();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00062624 File Offset: 0x00060824
	private void KEHGBGPAINI()
	{
		this.anchorLeft = new GameObject("ClimbUp" + this.zoneName).transform;
		this.anchorRight = new GameObject("[ACTk] WallHack Detector: already running!" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.HideInHierarchy);
		this.anchorTarget = new GameObject("{0} {1}").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("BOTTOM").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1568f, 1919f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(86f, this.runtimeDistance, 334f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(937f, 86f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags)(-66);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x0006281C File Offset: 0x00060A1C
	private void HOJMECAPIMG()
	{
		if (Application.isPlaying)
		{
			this.FPLAIKGOOLD();
		}
		float num = this.angleView * 166f;
		Transform transform = new GameObject("IdleDie2").transform;
		Transform transform2 = new GameObject("}").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 317f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1629f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00061758 File Offset: 0x0005F958
	private void FCCAIANLEFE()
	{
		this.colorBack = this.color;
		this.AADBKKJELMG();
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00062932 File Offset: 0x00060B32
	private void FDGKDLHLIPC()
	{
		if (this.NDLBHDAFBDL)
		{
			this.ALEGPOLMMBL();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00062954 File Offset: 0x00060B54
	private void AADBKKJELMG()
	{
		this.anchorLeft = new GameObject("1HandSwordChargeSwipe" + this.zoneName).transform;
		this.anchorRight = new GameObject("OfficeSittingHandRestFingerTap" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.HideInHierarchy);
		this.anchorTarget = new GameObject("FOG_AREA_BOX").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject(" ").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1442f, 1905f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1941f, this.runtimeDistance, 1342f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(98f, 158f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags)72;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00062B4C File Offset: 0x00060D4C
	private void NPNCOKOKNNH()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1500f);
			Gizmos.DrawWireSphere(base.transform.position, 1402f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.HPGGMNPLCHB();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00062BFC File Offset: 0x00060DFC
	private void KILAJHDIJHE()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1039f);
			Gizmos.DrawWireSphere(base.transform.position, 1987f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.AHDMGNJIFFP();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00062CAC File Offset: 0x00060EAC
	private void EGGPCFBPKGP()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(18f, -this.angleView * 761f, 1944f);
			this.anchorRight.Rotate(618f, this.angleView * 1047f, 1334f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1258f, 397f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(680f, -this.angleView * 1749f, 1271f);
		this.anchorRight.Rotate(816f, this.angleView * 887f, 1352f);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00062E70 File Offset: 0x00061070
	private void GIHHBEIJMEN()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1655f);
			Gizmos.DrawWireSphere(base.transform.position, 1455f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.GGJODAGEBBO();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00062F20 File Offset: 0x00061120
	private void EMJFAONJFIB()
	{
		if (Application.isPlaying)
		{
			this.DGFELGHEHFC();
		}
		float num = this.angleView * 1858f;
		Transform transform = new GameObject("PER_PIXEL").transform;
		Transform transform2 = new GameObject("").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 572f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 445f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00063038 File Offset: 0x00061238
	private void BGJCDMKCECM()
	{
		if (Application.isPlaying)
		{
			this.ALEGPOLMMBL();
		}
		float num = this.angleView * 1698f;
		Transform transform = new GameObject("Podsek action 2").transform;
		Transform transform2 = new GameObject("usrto_ignor").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 242f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1043f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00063150 File Offset: 0x00061350
	private void LMNGJGPBAGN()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1713f);
			Gizmos.DrawWireSphere(base.transform.position, 556f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.ICGCIECHPKA();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00063200 File Offset: 0x00061400
	private void DGDMJDEHJKL()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1733f, -this.angleView * 1030f, 665f);
			this.anchorRight.Rotate(865f, this.angleView * 1367f, 104f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(44f, 500f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1520f, -this.angleView * 378f, 1032f);
		this.anchorRight.Rotate(1254f, this.angleView * 1839f, 401f);
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x000633C4 File Offset: 0x000615C4
	private void DILMFDGCOLO()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1086f, -this.angleView * 334f, 1675f);
			this.anchorRight.Rotate(845f, this.angleView * 1733f, 801f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(698f, 1557f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1761f, -this.angleView * 1541f, 714f);
		this.anchorRight.Rotate(1223f, this.angleView * 1078f, 1713f);
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00063588 File Offset: 0x00061788
	private void CEDPLAJKACL()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1999f, -this.angleView * 497f, 1213f);
			this.anchorRight.Rotate(188f, this.angleView * 214f, 198f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1845f, 1369f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1585f, -this.angleView * 318f, 1106f);
		this.anchorRight.Rotate(1437f, this.angleView * 1779f, 133f);
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x0006374C File Offset: 0x0006194C
	private void GOAIDNCOCIB()
	{
		if (this.NDLBHDAFBDL)
		{
			this.PIDBJJOANDK();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x0006376C File Offset: 0x0006196C
	private void CINABDONMBC()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 663f);
			Gizmos.DrawWireSphere(base.transform.position, 289f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.NOIFKCBBKDG();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x0006381C File Offset: 0x00061A1C
	private void ABJJGADBLGK()
	{
		this.anchorLeft = new GameObject("<color='#206000'>" + this.zoneName).transform;
		this.anchorRight = new GameObject("UI_MapWindow_b" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.HideInHierarchy);
		this.anchorTarget = new GameObject("F").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("MotorbikeHeadstand").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 323f, 712f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(743f, this.runtimeDistance, 455f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1690f, 1121f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00063A14 File Offset: 0x00061C14
	private void JOGKNAFEHAC()
	{
		if (Application.isPlaying)
		{
			this.PMGHMAMIBCK();
		}
		float num = this.angleView * 129f;
		Transform transform = new GameObject("WorkerShovel2").transform;
		Transform transform2 = new GameObject("WeaponInstant").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 441f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1453f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00063B2C File Offset: 0x00061D2C
	private void DIMBGANFAHO()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(149f, -this.angleView * 191f, 1163f);
			this.anchorRight.Rotate(870f, this.angleView * 1705f, 1908f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1795f, 1878f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(230f, -this.angleView * 1097f, 1890f);
		this.anchorRight.Rotate(1859f, this.angleView * 1790f, 693f);
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00063CF0 File Offset: 0x00061EF0
	private void JCMLNNKODJG()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(234f, -this.angleView * 1615f, 30f);
			this.anchorRight.Rotate(53f, this.angleView * 1142f, 1566f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(494f, 474f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(435f, -this.angleView * 1901f, 571f);
		this.anchorRight.Rotate(65f, this.angleView * 648f, 1663f);
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00061758 File Offset: 0x0005F958
	private void OPNPODKLOJK()
	{
		this.colorBack = this.color;
		this.AADBKKJELMG();
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00063EB4 File Offset: 0x000620B4
	private void BGLEMFODNGG()
	{
		this.anchorLeft = new GameObject("codepage" + this.zoneName).transform;
		this.anchorRight = new GameObject("PaperTurn.wav" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("{{ {{{0}:{1}}}, {{{2}:{3}}} }}").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("IdleFeedThrow").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 509f, 1631f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(145f, this.runtimeDistance, 1656f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(181f, 1699f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x000640AC File Offset: 0x000622AC
	private void FBLMNKIDMDD()
	{
		if (Application.isPlaying)
		{
			this.LDJOKIPCCBN();
		}
		float num = this.angleView * 618f;
		Transform transform = new GameObject("wpn_add/base").transform;
		Transform transform2 = new GameObject("cntx_close").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1682f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1419f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x000641C4 File Offset: 0x000623C4
	private void PDHBKPELMGP()
	{
		this.anchorLeft = new GameObject("S " + this.zoneName).transform;
		this.anchorRight = new GameObject(" locid=" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.HideInHierarchy);
		this.anchorTarget = new GameObject("_rcIn.ogg").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("name").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1513f, 1419f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1010f, this.runtimeDistance, 1371f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1966f, 213f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags)79;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x000643BC File Offset: 0x000625BC
	private void OnDrawGizmosSelected()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 0.075f);
			Gizmos.DrawWireSphere(base.transform.position, 0.1f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.NOIFKCBBKDG();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x0006446C File Offset: 0x0006266C
	private void DFMFJNDKALD()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1966f);
			Gizmos.DrawWireSphere(base.transform.position, 1790f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.AEFAILKLLCC();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x0006451C File Offset: 0x0006271C
	private void HPGGMNPLCHB()
	{
		if (Application.isPlaying)
		{
			this.DILMFDGCOLO();
		}
		float num = this.angleView * 386f;
		Transform transform = new GameObject("RollerBladeRoll").transform;
		Transform transform2 = new GameObject("OneHandSwordBlock").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 159f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1237f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00064634 File Offset: 0x00062834
	private void EOPDDPALFMA()
	{
		this.anchorLeft = new GameObject("Whistle" + this.zoneName).transform;
		this.anchorRight = new GameObject("money" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("BlendMaterial").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("GiantGrabThrow").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1175f, 1741f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1523f, this.runtimeDistance, 702f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1110f, 250f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags)80;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x0006482C File Offset: 0x00062A2C
	private void PMGHMAMIBCK()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1362f, -this.angleView * 238f, 1595f);
			this.anchorRight.Rotate(635f, this.angleView * 1678f, 1176f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1018f, 641f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1267f, -this.angleView * 536f, 1520f);
		this.anchorRight.Rotate(1010f, this.angleView * 1565f, 1283f);
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x000649F0 File Offset: 0x00062BF0
	private void PIDBJJOANDK()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1633f, -this.angleView * 1657f, 1581f);
			this.anchorRight.Rotate(1160f, this.angleView * 1832f, 1970f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(476f, 1624f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1754f, -this.angleView * 629f, 684f);
		this.anchorRight.Rotate(738f, this.angleView * 1799f, 9f);
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00064BB4 File Offset: 0x00062DB4
	private void NENOAPOICLA()
	{
		if (this.NDLBHDAFBDL)
		{
			this.INCNMJBEFCK();
		}
		this.NDLBHDAFBDL = this.NDLBHDAFBDL;
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00064BD3 File Offset: 0x00062DD3
	private void JFHOMJMKBNJ()
	{
		this.colorBack = this.color;
		this.AHBKDNFCCPP();
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00064BE8 File Offset: 0x00062DE8
	private void DCEAPPGKCBF()
	{
		this.anchorLeft = new GameObject("<color='#a0a0a0'>" + this.zoneName).transform;
		this.anchorRight = new GameObject("Turn" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("invn_ver6").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("gi_um_4").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 18f, 698f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1914f, this.runtimeDistance, 1185f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1695f, 1638f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = HideFlags.DontSaveInEditor;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00064DDE File Offset: 0x00062FDE
	private void DPPAAIJCFLC()
	{
		this.colorBack = this.color;
		this.DCEAPPGKCBF();
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00064DF4 File Offset: 0x00062FF4
	private void NCHDIHMHCJE()
	{
		this.anchorLeft = new GameObject("BowIdle" + this.zoneName).transform;
		this.anchorRight = new GameObject("rewgt_msg" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("GiantEat").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("* change").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1165f, 384f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(20f, this.runtimeDistance, 1565f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1496f, 443f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00064FEC File Offset: 0x000631EC
	private void KILOOPEIIJA()
	{
		this.anchorLeft = new GameObject("1=" + this.zoneName).transform;
		this.anchorRight = new GameObject("_Radius2" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("Mouse ScrollWheel").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("\n").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1722f, 531f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1891f, this.runtimeDistance, 453f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(169f, 940f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x000651E4 File Offset: 0x000633E4
	private void CHFKGLAAKMJ()
	{
		if (Application.isPlaying)
		{
			this.DGDMJDEHJKL();
		}
		float num = this.angleView * 1379f;
		Transform transform = new GameObject("wpn_eat3").transform;
		Transform transform2 = new GameObject("cntx_refine").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 667f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1310f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x000652FC File Offset: 0x000634FC
	private void OFDNLDIGKHE()
	{
		if (Application.isPlaying)
		{
			this.OFFCJKDHCCK();
		}
		float num = this.angleView * 368f;
		Transform transform = new GameObject("WorkerHammer").transform;
		Transform transform2 = new GameObject("_man").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 828f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 837f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00065414 File Offset: 0x00063614
	private void ELDEOONDBKK()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1303f);
			Gizmos.DrawWireSphere(base.transform.position, 1537f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.JIFBPLHGLJB();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x000654C4 File Offset: 0x000636C4
	private void GAOKKHEMOOJ()
	{
		this.anchorLeft = new GameObject("_Radius" + this.zoneName).transform;
		this.anchorRight = new GameObject("Flap_08.wav" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.HideInHierarchy);
		this.anchorTarget = new GameObject("IdleDodgeRight").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("_SSAOTex").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1971f, 625f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1301f, this.runtimeDistance, 544f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(544f, 1123f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x000656BA File Offset: 0x000638BA
	private void POCOKCJDCHK()
	{
		if (this.NDLBHDAFBDL)
		{
			this.AFDEKKBJMBJ();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x000656DC File Offset: 0x000638DC
	private void OLGPKNIKEPF()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 865f);
			Gizmos.DrawWireSphere(base.transform.position, 360f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.HGIHOEJPEPI();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x0006578C File Offset: 0x0006398C
	private void CICNOFOLPNF()
	{
		this.anchorLeft = new GameObject("" + this.zoneName).transform;
		this.anchorRight = new GameObject("***Wpn Lots event " + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("Full Body IK is missing the left thigh node.").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 303f, 771f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1384f, this.runtimeDistance, 208f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1031f, 1400f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00064DDE File Offset: 0x00062FDE
	private void AFFAJKPPMHF()
	{
		this.colorBack = this.color;
		this.DCEAPPGKCBF();
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00065984 File Offset: 0x00063B84
	private void AFDEKKBJMBJ()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1724f, -this.angleView * 249f, 1221f);
			this.anchorRight.Rotate(1817f, this.angleView * 867f, 632f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1375f, 78f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(723f, -this.angleView * 1054f, 1324f);
		this.anchorRight.Rotate(1875f, this.angleView * 848f, 1182f);
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00065B48 File Offset: 0x00063D48
	private void HDPICLGBICL()
	{
		if (this.NDLBHDAFBDL)
		{
			this.MFNEFLIGEFI();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00065B68 File Offset: 0x00063D68
	private void BIHDAMNGLBO()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1303f, -this.angleView * 1467f, 342f);
			this.anchorRight.Rotate(274f, this.angleView * 1810f, 1070f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1949f, 1634f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1654f, -this.angleView * 453f, 513f);
		this.anchorRight.Rotate(1380f, this.angleView * 1304f, 631f);
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00065D2C File Offset: 0x00063F2C
	private void JDICIPNCLGJ()
	{
		if (this.NDLBHDAFBDL)
		{
			this.MJEKIIIMAKI();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00065D4C File Offset: 0x00063F4C
	private void MJEKIIIMAKI()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(141f, -this.angleView * 1165f, 1425f);
			this.anchorRight.Rotate(982f, this.angleView * 708f, 361f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1384f, 1293f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(119f, -this.angleView * 1065f, 1038f);
		this.anchorRight.Rotate(811f, this.angleView * 796f, 534f);
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x00065F10 File Offset: 0x00064110
	private void OMIHIFEILEB()
	{
		if (Application.isPlaying)
		{
			this.DGFELGHEHFC();
		}
		float num = this.angleView * 1917f;
		Transform transform = new GameObject("wpn_eat7").transform;
		Transform transform2 = new GameObject("System.Single").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1600f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 371f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00066028 File Offset: 0x00064228
	private void NEDNAPLHEOF()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(131f, -this.angleView * 185f, 1746f);
			this.anchorRight.Rotate(1045f, this.angleView * 1498f, 675f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1430f, 659f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(507f, -this.angleView * 726f, 1264f);
		this.anchorRight.Rotate(1120f, this.angleView * 1560f, 758f);
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x000661EC File Offset: 0x000643EC
	private void KGJBJGHNAFE()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(998f, -this.angleView * 1448f, 789f);
			this.anchorRight.Rotate(1774f, this.angleView * 921f, 851f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1802f, 832f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(941f, -this.angleView * 601f, 533f);
		this.anchorRight.Rotate(851f, this.angleView * 592f, 668f);
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x000663B0 File Offset: 0x000645B0
	private void ALEGPOLMMBL()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(820f, -this.angleView * 1620f, 585f);
			this.anchorRight.Rotate(1460f, this.angleView * 694f, 224f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(729f, 1530f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(263f, -this.angleView * 450f, 94f);
		this.anchorRight.Rotate(1792f, this.angleView * 221f, 1684f);
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00066574 File Offset: 0x00064774
	private void NOIFKCBBKDG()
	{
		if (Application.isPlaying)
		{
			this.FKNOHDLGPJM();
		}
		float num = this.angleView * 0.1f;
		Transform transform = new GameObject("cond").transform;
		Transform transform2 = new GameObject("condAnchor").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 5f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, -5f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x0006668A File Offset: 0x0006488A
	private void CBLGFOFHNPJ()
	{
		this.colorBack = this.color;
		this.KILOOPEIIJA();
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x0006669E File Offset: 0x0006489E
	private void LMEJKAEIDCO()
	{
		this.colorBack = this.color;
		this.PDHBKPELMGP();
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x000666CC File Offset: 0x000648CC
	private void NGHOJBOHIBA()
	{
		if (this.NDLBHDAFBDL)
		{
			this.FPLAIKGOOLD();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x000666EB File Offset: 0x000648EB
	private void GJKCGGCCIAJ()
	{
		if (this.NDLBHDAFBDL)
		{
			this.OFFCJKDHCCK();
		}
		this.NDLBHDAFBDL = this.NDLBHDAFBDL;
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0006670C File Offset: 0x0006490C
	private void BBOEPAFNDAJ()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 133f);
			Gizmos.DrawWireSphere(base.transform.position, 808f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.HGIHOEJPEPI();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x000667B9 File Offset: 0x000649B9
	private void PPIJKKNAJAC()
	{
		if (this.NDLBHDAFBDL)
		{
			this.LAJMDPJHGHL();
		}
		this.NDLBHDAFBDL = this.NDLBHDAFBDL;
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x000667D8 File Offset: 0x000649D8
	private void FKNOHDLGPJM()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(0f, -this.angleView * 0.5f, 0f);
			this.anchorRight.Rotate(0f, this.angleView * 0.5f, 0f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(0f, 0f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(0f, -this.angleView * 0.5f, 0f);
		this.anchorRight.Rotate(0f, this.angleView * 0.5f, 0f);
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x0006699C File Offset: 0x00064B9C
	private void FPLAIKGOOLD()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(514f, -this.angleView * 516f, 1301f);
			this.anchorRight.Rotate(364f, this.angleView * 133f, 741f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(387f, 956f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1694f, -this.angleView * 1572f, 534f);
		this.anchorRight.Rotate(851f, this.angleView * 380f, 926f);
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00066B60 File Offset: 0x00064D60
	private void JPHBPEAMNHB()
	{
		this.colorBack = this.color;
		this.ABJJGADBLGK();
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00066B74 File Offset: 0x00064D74
	private void CKEMPAMKDBG()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 70f);
			Gizmos.DrawWireSphere(base.transform.position, 1697f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.NOIFKCBBKDG();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00066C24 File Offset: 0x00064E24
	private void MFNEFLIGEFI()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1100f, -this.angleView * 1502f, 808f);
			this.anchorRight.Rotate(1144f, this.angleView * 882f, 576f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1880f, 1971f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1386f, -this.angleView * 251f, 285f);
		this.anchorRight.Rotate(699f, this.angleView * 1136f, 1298f);
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00066DE8 File Offset: 0x00064FE8
	private void OFLBLPGKOPF()
	{
		this.anchorLeft = new GameObject("BackPackSearch" + this.zoneName).transform;
		this.anchorRight = new GameObject("_WaterLevel" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("1").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("IKMappingBone's bone is null.").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 912f, 1068f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(448f, this.runtimeDistance, 1517f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1031f, 1801f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags)74;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00066FDE File Offset: 0x000651DE
	private void LateUpdate()
	{
		if (this.NDLBHDAFBDL)
		{
			this.FKNOHDLGPJM();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00066FFD File Offset: 0x000651FD
	private void Start()
	{
		this.colorBack = this.color;
		this.CFGAKBNNHKB();
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00067011 File Offset: 0x00065211
	private void PFLHNDLBELI()
	{
		if (this.NDLBHDAFBDL)
		{
			this.DGDMJDEHJKL();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00067030 File Offset: 0x00065230
	private void OFFCJKDHCCK()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1628f, -this.angleView * 1051f, 999f);
			this.anchorRight.Rotate(652f, this.angleView * 194f, 679f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(933f, 1336f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(436f, -this.angleView * 1328f, 443f);
		this.anchorRight.Rotate(1266f, this.angleView * 390f, 598f);
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x000671F4 File Offset: 0x000653F4
	private void AELKBACACBE()
	{
		if (Application.isPlaying)
		{
			this.JCMLNNKODJG();
		}
		float num = this.angleView * 555f;
		Transform transform = new GameObject("[AmplifyColor] Please disable \"Generate Mip Maps\" import settings on all LUT textures to avoid visual glitches. Change Texture Type to \"Advanced\" to access Mip settings.").transform;
		Transform transform2 = new GameObject("{not_found}").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1701f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1124f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0006730C File Offset: 0x0006550C
	private void OENEGEKFKDG()
	{
		if (Application.isPlaying)
		{
			this.MJEKIIIMAKI();
		}
		float num = this.angleView * 952f;
		Transform transform = new GameObject("IdleFight").transform;
		Transform transform2 = new GameObject("__c").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1098f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1452f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00067422 File Offset: 0x00065622
	private void OOGNHIIPHBH()
	{
		if (this.NDLBHDAFBDL)
		{
			this.JCMLNNKODJG();
		}
		this.NDLBHDAFBDL = this.NDLBHDAFBDL;
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00067444 File Offset: 0x00065644
	private void DIBJBGCELJH()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(760f, -this.angleView * 89f, 927f);
			this.anchorRight.Rotate(1589f, this.angleView * 626f, 910f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1911f, 1632f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(756f, -this.angleView * 985f, 1202f);
		this.anchorRight.Rotate(1637f, this.angleView * 691f, 274f);
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00067608 File Offset: 0x00065808
	private void ELGBMKNBEOP()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 745f);
			Gizmos.DrawWireSphere(base.transform.position, 80f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.PJNIBEFMPMF();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x000676B8 File Offset: 0x000658B8
	private void PBOPIPJMDDC()
	{
		if (Application.isPlaying)
		{
			this.DIMBGANFAHO();
		}
		float num = this.angleView * 1598f;
		Transform transform = new GameObject("get_lut").transform;
		Transform transform2 = new GameObject("</color>").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1257f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1851f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x000677CE File Offset: 0x000659CE
	private void AGCPGBGIHOP()
	{
		if (this.NDLBHDAFBDL)
		{
			this.FPLAIKGOOLD();
		}
		this.NDLBHDAFBDL = this.NDLBHDAFBDL;
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x000677F0 File Offset: 0x000659F0
	private void CBMCMPKMMAE()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 596f);
			Gizmos.DrawWireSphere(base.transform.position, 303f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.AELKBACACBE();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x000666CC File Offset: 0x000648CC
	private void NPDBHEONIDA()
	{
		if (this.NDLBHDAFBDL)
		{
			this.FPLAIKGOOLD();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x000678A0 File Offset: 0x00065AA0
	private void OMPKODENPAO()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 338f);
			Gizmos.DrawWireSphere(base.transform.position, 791f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.HGIHOEJPEPI();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00067950 File Offset: 0x00065B50
	private void NNLIAJENBDP()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 50f);
			Gizmos.DrawWireSphere(base.transform.position, 963f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.OMIHIFEILEB();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00067A00 File Offset: 0x00065C00
	private void CLNBPCBNLFB()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 490f);
			Gizmos.DrawWireSphere(base.transform.position, 243f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.PLGIAGCICOD();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00067AB0 File Offset: 0x00065CB0
	private void ODDOGIIDPEF()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 639f);
			Gizmos.DrawWireSphere(base.transform.position, 1232f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.JOGKNAFEHAC();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00067B60 File Offset: 0x00065D60
	private void JJIMHMNNMOP()
	{
		if (Application.isPlaying)
		{
			this.FPLAIKGOOLD();
		}
		float num = this.angleView * 1603f;
		Transform transform = new GameObject("finger").transform;
		Transform transform2 = new GameObject("</i></color>").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1924f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 390f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00067C78 File Offset: 0x00065E78
	private void CFGAKBNNHKB()
	{
		this.anchorLeft = new GameObject("Anchore Left_" + this.zoneName).transform;
		this.anchorRight = new GameObject("Anchore Right_" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.HideInHierarchy);
		this.anchorTarget = new GameObject("Anchor Target").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("_parent").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 0f, 0f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(0f, this.runtimeDistance, 0f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(0f, 0f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = HideFlags.HideAndDontSave;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00067E70 File Offset: 0x00066070
	private void EJGFOPBIKKC()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1242f, -this.angleView * 1067f, 539f);
			this.anchorRight.Rotate(297f, this.angleView * 300f, 1962f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(334f, 1441f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1884f, -this.angleView * 869f, 734f);
		this.anchorRight.Rotate(686f, this.angleView * 354f, 335f);
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00068034 File Offset: 0x00066234
	private void HNPGDIPOMBD()
	{
		this.anchorLeft = new GameObject("RunBackLeft" + this.zoneName).transform;
		this.anchorRight = new GameObject("Hidden/Post FX/Builtin Debug Views" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("IdleStand").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("IX").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1876f, 80f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1758f, this.runtimeDistance, 571f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(67f, 1612f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x0006822C File Offset: 0x0006642C
	private void GIIFJEJAIFF()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1642f, -this.angleView * 271f, 1142f);
			this.anchorRight.Rotate(1130f, this.angleView * 818f, 1984f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(712f, 1965f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(587f, -this.angleView * 773f, 1448f);
		this.anchorRight.Rotate(813f, this.angleView * 1741f, 1942f);
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x000683F0 File Offset: 0x000665F0
	private void ICGCIECHPKA()
	{
		if (Application.isPlaying)
		{
			this.HODGGMPGBAK();
		}
		float num = this.angleView * 1694f;
		Transform transform = new GameObject("Level load event").transform;
		Transform transform2 = new GameObject("404040").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 368f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 885f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00068508 File Offset: 0x00066708
	private void HOBKACMDPOI()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 200f);
			Gizmos.DrawWireSphere(base.transform.position, 473f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.HGIHOEJPEPI();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x000685B5 File Offset: 0x000667B5
	private void ILCOPJPEKEC()
	{
		this.colorBack = this.color;
		this.GAOKKHEMOOJ();
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x000685CC File Offset: 0x000667CC
	private void ACAKEFIPKBO()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 856f);
			Gizmos.DrawWireSphere(base.transform.position, 283f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.JOGKNAFEHAC();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x0006867C File Offset: 0x0006687C
	private void GNOOKMHAGLM()
	{
		if (Application.isPlaying)
		{
			this.PMGHMAMIBCK();
		}
		float num = this.angleView * 460f;
		Transform transform = new GameObject("firsStartMovePanel").transform;
		Transform transform2 = new GameObject("WizardNeoBlock").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1015f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1099f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00068794 File Offset: 0x00066994
	private void FNAKEIHKDEM()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 986f);
			Gizmos.DrawWireSphere(base.transform.position, 1269f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.PFFLCBJDDPO();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00068844 File Offset: 0x00066A44
	private void AMGGPBPDKLK()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1773f);
			Gizmos.DrawWireSphere(base.transform.position, 237f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.HGIHOEJPEPI();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x000688F4 File Offset: 0x00066AF4
	private void PLGIAGCICOD()
	{
		if (Application.isPlaying)
		{
			this.MEKBOFINHOB();
		}
		float num = this.angleView * 466f;
		Transform transform = new GameObject("double: ").transform;
		Transform transform2 = new GameObject("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 820f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1940f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00068A0C File Offset: 0x00066C0C
	private void MEKBOFINHOB()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1657f, -this.angleView * 463f, 1777f);
			this.anchorRight.Rotate(417f, this.angleView * 778f, 1916f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1242f, 643f, this.runtimeDistance), Space.Self);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1722f, -this.angleView * 1785f, 1839f);
		this.anchorRight.Rotate(836f, this.angleView * 1823f, 751f);
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00068BD0 File Offset: 0x00066DD0
	private void DKOKIKIJCIJ()
	{
		this.anchorLeft = new GameObject("_Direction" + this.zoneName).transform;
		this.anchorRight = new GameObject("cash.ogg" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.HideInHierarchy);
		this.anchorTarget = new GameObject("silence").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("usr_inf_a1").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 1553f, 598f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(38f, this.runtimeDistance, 1363f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1376f, 1937f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = ~HideFlags.DontSaveInBuild;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00068DC8 File Offset: 0x00066FC8
	private void PFFLCBJDDPO()
	{
		if (Application.isPlaying)
		{
			this.FPLAIKGOOLD();
		}
		float num = this.angleView * 1776f;
		Transform transform = new GameObject("error.wav").transform;
		Transform transform2 = new GameObject("_NeighbourMaxTex").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 373f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 102f);
			Gizmos.DrawLine(position2, transform.position);
			num3 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00068EE0 File Offset: 0x000670E0
	private void HKPALJNKAJA()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1063f);
			Gizmos.DrawWireSphere(base.transform.position, 958f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.HGIHOEJPEPI();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00068F90 File Offset: 0x00067190
	private void LDECMBKLCMA()
	{
		if (Application.isPlaying)
		{
			this.DGDMJDEHJKL();
		}
		float num = this.angleView * 311f;
		Transform transform = new GameObject("").transform;
		Transform transform2 = new GameObject("Fire Breath").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 155f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 131f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x000690A8 File Offset: 0x000672A8
	private void FCMCELHHCNA()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1079f, -this.angleView * 286f, 12f);
			this.anchorRight.Rotate(1395f, this.angleView * 1864f, 683f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(35f, 1548f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(1058f, -this.angleView * 148f, 1949f);
		this.anchorRight.Rotate(1039f, this.angleView * 1669f, 218f);
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x0006926C File Offset: 0x0006746C
	private void HGIHOEJPEPI()
	{
		if (Application.isPlaying)
		{
			this.INCNMJBEFCK();
		}
		float num = this.angleView * 1483f;
		Transform transform = new GameObject("WorkerHammer").transform;
		Transform transform2 = new GameObject("_WaveScale").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1048f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 1;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1314f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00069382 File Offset: 0x00067582
	private void AKCHFCLCEHG()
	{
		if (this.NDLBHDAFBDL)
		{
			this.EJGFOPBIKKC();
		}
		this.NDLBHDAFBDL = !this.NDLBHDAFBDL;
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x000693A4 File Offset: 0x000675A4
	private void PFAJCPAEFOB()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1754f);
			Gizmos.DrawWireSphere(base.transform.position, 745f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.LDECMBKLCMA();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00069451 File Offset: 0x00067651
	private void ANHOOJFEJJE()
	{
		this.colorBack = this.color;
		this.CICNOFOLPNF();
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00069468 File Offset: 0x00067668
	private void BNBJBDIBNJH()
	{
		this.anchorLeft = new GameObject("Right Hand Effector needs a Target in this demo." + this.zoneName).transform;
		this.anchorRight = new GameObject("gi_um_6" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("locData not found").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.HideInHierarchy;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("HookPoint").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 489f, 1929f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(1566f, this.runtimeDistance, 1107f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1899f, 1172f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00069660 File Offset: 0x00067860
	private void AHDMGNJIFFP()
	{
		if (Application.isPlaying)
		{
			this.FKNOHDLGPJM();
		}
		float num = this.angleView * 792f;
		Transform transform = new GameObject("1HandSwordJabFootPush").transform;
		Transform transform2 = new GameObject("1HSwordStrafeRunRight").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 0;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 1538f);
			Gizmos.DrawLine(position, transform.position);
			num2 += 0;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 1536f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x00069778 File Offset: 0x00067978
	private void IEMNIEEFDPL()
	{
		if (Application.isPlaying)
		{
			this.FPLAIKGOOLD();
		}
		float num = this.angleView * 786f;
		Transform transform = new GameObject("_ScratchOffsetScale").transform;
		Transform transform2 = new GameObject("").transform;
		transform.position = base.transform.position;
		transform2.position = this.holder.transform.position;
		transform2.LookAt(transform);
		transform.parent = transform2;
		Quaternion rotation = transform2.rotation;
		int num2 = 1;
		while ((float)num2 < num)
		{
			Vector3 position = transform.position;
			transform2.Rotate(Vector3.up, 110f);
			Gizmos.DrawLine(position, transform.position);
			num2++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		transform2.rotation = rotation;
		int num3 = 0;
		while ((float)num3 < num)
		{
			Vector3 position2 = transform.position;
			transform2.Rotate(Vector3.up, 814f);
			Gizmos.DrawLine(position2, transform.position);
			num3++;
		}
		Gizmos.DrawLine(transform2.position, transform.position);
		UnityEngine.Object.DestroyImmediate(transform2);
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00069890 File Offset: 0x00067A90
	private void DIFMGLJEPOH()
	{
		this.anchorLeft = new GameObject("BowInstant" + this.zoneName).transform;
		this.anchorRight = new GameObject("_HalfResolution" + this.zoneName).transform;
		this.anchorLeft.hideFlags = (this.anchorRight.hideFlags = HideFlags.None);
		this.anchorTarget = new GameObject("IceHockeyGoalieReady").transform;
		this.anchorTarget.gameObject.hideFlags = HideFlags.None;
		this.anchorLeft.position = (this.anchorRight.position = (this.anchorTarget.position = this.holder.transform.position));
		if (this.parentTransform)
		{
			this.HEJMCNNIJKC = new GameObject("_TexelOffsetScale").transform;
			this.HEJMCNNIJKC.position = this.parentTransform.position;
			this.runtimeDistance = Vector3.Distance(base.transform.position, this.parentTransform.position);
			switch (this.parentTransformLookAtAxis)
			{
			case AI_RangeMarker.CBDINGKBNEP.X:
				this.HEJMCNNIJKC.Translate(new Vector3(this.runtimeDistance, 222f, 1729f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Y:
				this.HEJMCNNIJKC.Translate(new Vector3(193f, this.runtimeDistance, 1679f), this.parentTransform);
				break;
			case AI_RangeMarker.CBDINGKBNEP.Z:
				this.HEJMCNNIJKC.Translate(new Vector3(1544f, 1602f, this.runtimeDistance), this.parentTransform);
				break;
			}
			this.HEJMCNNIJKC.hideFlags = (HideFlags)80;
			this.HEJMCNNIJKC.parent = this.parentTransform;
			return;
		}
		this.runtimeDistance = Vector3.Distance(base.transform.position, base.transform.parent.position);
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00069A86 File Offset: 0x00067C86
	private void BLOLJBHKGOH()
	{
		if (this.NDLBHDAFBDL)
		{
			this.BIHDAMNGLBO();
		}
		this.NDLBHDAFBDL = this.NDLBHDAFBDL;
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00069AA8 File Offset: 0x00067CA8
	private void GEAMAKMJAIC()
	{
		if (this.holder == null)
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		else
		{
			if (!this.holder.showRings)
			{
				return;
			}
			Gizmos.color = this.color;
			Gizmos.DrawSphere(base.transform.position, 1958f);
			Gizmos.DrawWireSphere(base.transform.position, 1062f);
			Gizmos.DrawLine(this.holder.transform.position, base.transform.position);
			this.PJNIBEFMPMF();
			Gizmos.color = Color.white;
			return;
		}
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00069B58 File Offset: 0x00067D58
	private void LAJMDPJHGHL()
	{
		this.anchorTarget.position = (this.anchorLeft.position = (this.anchorRight.position = this.holder.transform.position));
		if (this.parentTransform == null)
		{
			this.anchorLeft.rotation = (this.anchorRight.rotation = this.holder.transform.rotation);
			this.anchorLeft.Rotate(1902f, -this.angleView * 863f, 512f);
			this.anchorRight.Rotate(988f, this.angleView * 1940f, 290f);
			return;
		}
		base.transform.position = this.holder.transform.position;
		base.transform.LookAt(new Vector3(this.HEJMCNNIJKC.position.x, base.transform.position.y, this.HEJMCNNIJKC.position.z));
		this.anchorLeft.rotation = (this.anchorRight.rotation = base.transform.rotation);
		base.transform.parent = null;
		base.transform.Translate(new Vector3(1796f, 163f, this.runtimeDistance), Space.World);
		base.transform.parent = this.holder.transform;
		this.anchorLeft.Rotate(963f, -this.angleView * 1919f, 1368f);
		this.anchorRight.Rotate(1822f, this.angleView * 1754f, 273f);
	}

	// Token: 0x0400013D RID: 317
	public AI_Range holder;

	// Token: 0x0400013E RID: 318
	public Color color;

	// Token: 0x0400013F RID: 319
	public Color colorBack;

	// Token: 0x04000140 RID: 320
	public float angleView = 360f;

	// Token: 0x04000141 RID: 321
	public float radius;

	// Token: 0x04000142 RID: 322
	public Transform parentTransform;

	// Token: 0x04000143 RID: 323
	public AI_RangeMarker.CBDINGKBNEP parentTransformLookAtAxis = AI_RangeMarker.CBDINGKBNEP.Z;

	// Token: 0x04000144 RID: 324
	public string zoneName;

	// Token: 0x04000145 RID: 325
	public float runtimeDistance;

	// Token: 0x04000146 RID: 326
	public Transform anchorLeft;

	// Token: 0x04000147 RID: 327
	public Transform anchorRight;

	// Token: 0x04000148 RID: 328
	public Transform anchorTarget;

	// Token: 0x04000149 RID: 329
	private Transform HEJMCNNIJKC;

	// Token: 0x0400014A RID: 330
	private bool NDLBHDAFBDL;

	// Token: 0x02000030 RID: 48
	public enum CBDINGKBNEP
	{
		// Token: 0x0400014C RID: 332
		X,
		// Token: 0x0400014D RID: 333
		Y,
		// Token: 0x0400014E RID: 334
		Z
	}
}
