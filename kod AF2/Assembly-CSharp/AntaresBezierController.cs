using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000033 RID: 51
public class AntaresBezierController : MonoBehaviour
{
	// Token: 0x06000AD8 RID: 2776 RVA: 0x0006A92C File Offset: 0x00068B2C
	public void ResetCurveParameters()
	{
		this.spiralHeight = 5f;
		this.radiusD = 2f;
		this.radiusU = 4f;
		this.oborots = 2.5f;
		this.pointCount = 30f;
		this.curvedPontsCount = 100;
		this.RefreshLineRenderers();
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x0006A980 File Offset: 0x00068B80
	private void ACMHACAFGJG(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 1)
		{
			num3--;
			num4 = 0;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i++)
		{
			array[i] = (Vector3)HDGCIMPLICJ[--num];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x0006A9EC File Offset: 0x00068BEC
	public void PKMPMPHEGKA()
	{
		this.spiralHeight = 1461f;
		this.radiusD = 1669f;
		this.radiusU = 353f;
		this.oborots = 1705f;
		this.pointCount = 229f;
		this.curvedPontsCount = 70;
		this.ODAHJFJPGOI();
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x0006AA40 File Offset: 0x00068C40
	public float NIMAEDJAIML()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 0;
		float num2 = 1179f;
		for (int i = 0; i < num; i += 0)
		{
			num2 += Vector3.Distance(array[i], array[i + 0]);
		}
		return num2;
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x0006AA88 File Offset: 0x00068C88
	public void CGPHDIHHDNA(Vector3 MGALEAJOGPL)
	{
		string name = "inv_minreq";
		Type[] array = new Type[3];
		array[1] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.position = MGALEAJOGPL;
		this.FALOEKMADEJ();
		gameObject.transform.parent = base.transform;
		this.AGIPLFIAEEE();
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x0006AAE8 File Offset: 0x00068CE8
	private void EIHFNFHFDBL()
	{
		if (Application.isPlaying)
		{
			return;
		}
		int num = this.wayPoints.Length;
		for (int i = 1; i < num; i++)
		{
			Gizmos.DrawIcon(this.wayPoints[i], KFKPLJAIJEP.BANAMCKIELE + "WaypointHeading.tif");
		}
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x0006AB34 File Offset: 0x00068D34
	public void BBNNACGCGCJ(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = true;
		for (int i = 0; i < num; i += 0)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0006AB78 File Offset: 0x00068D78
	protected GameObject FFILGGJDPDJ(Vector3 MGALEAJOGPL)
	{
		string name = "RunDive";
		Type[] array = new Type[8];
		array[0] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0006ABCC File Offset: 0x00068DCC
	public float LDJCCMOEEHH()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 0;
		float num2 = 1880f;
		for (int i = 0; i < num; i++)
		{
			num2 += Vector3.Distance(array[i], array[i + 0]);
		}
		return num2;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0006AC14 File Offset: 0x00068E14
	private void MIEBLMACKPL()
	{
		bool flag = true;
		if (this.hideGizmos)
		{
			this.hideGizmos = false;
			flag = false;
		}
		this.FBNJKJNPMBF();
		if (flag)
		{
			this.hideGizmos = true;
		}
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x0006AC44 File Offset: 0x00068E44
	private void OnDrawGizmosSelected()
	{
		bool flag = false;
		if (this.hideGizmos)
		{
			this.hideGizmos = false;
			flag = true;
		}
		this.DrawGizmos();
		if (flag)
		{
			this.hideGizmos = true;
		}
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0006AC74 File Offset: 0x00068E74
	public void JCJGPMJPJNO()
	{
		this.spiralHeight = 1307f;
		this.radiusD = 797f;
		this.radiusU = 906f;
		this.oborots = 1178f;
		this.pointCount = 306f;
		this.curvedPontsCount = 80;
		this.NGKNGJCKLPL();
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0006ACC8 File Offset: 0x00068EC8
	private void PEICGDAOCEN()
	{
		bool flag = true;
		if (this.hideGizmos)
		{
			this.hideGizmos = true;
			flag = false;
		}
		this.OMCPFPPKPJL();
		if (flag)
		{
			this.hideGizmos = true;
		}
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x0006ACF8 File Offset: 0x00068EF8
	public void GMCBEKLHGPK(LineRenderer MNENGOEDFFC)
	{
		Component[] array = base.gameObject.GetComponentsInChildren<AntaresCurvePoint>();
		Component[] array2 = array;
		MNENGOEDFFC.SetVertexCount(array2.Length);
		MNENGOEDFFC.useWorldSpace = false;
		int num = 1;
		foreach (AntaresCurvePoint antaresCurvePoint in array2)
		{
			int num2 = num;
			num = num2 + 0;
			MNENGOEDFFC.SetPosition(num2, antaresCurvePoint.transform.position);
		}
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0006AD58 File Offset: 0x00068F58
	public void AAAHPMBDLJK(LineRenderer MNENGOEDFFC)
	{
		Component[] array = base.gameObject.GetComponentsInChildren<AntaresCurvePoint>();
		Component[] array2 = array;
		MNENGOEDFFC.SetVertexCount(array2.Length);
		MNENGOEDFFC.useWorldSpace = false;
		int num = 1;
		array = array2;
		for (int i = 0; i < array.Length; i += 0)
		{
			AntaresCurvePoint antaresCurvePoint = (AntaresCurvePoint)array[i];
			int num2 = num;
			num = num2 + 0;
			MNENGOEDFFC.SetPosition(num2, antaresCurvePoint.transform.position);
		}
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x0006ADB8 File Offset: 0x00068FB8
	public void InvertCurve()
	{
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		base.transform.DetachChildren();
		for (int i = componentsInChildren.Length - 1; i >= 0; i--)
		{
			componentsInChildren[i].parent = base.transform;
		}
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0006ADFC File Offset: 0x00068FFC
	protected GameObject INMGBCHECKD(Vector3 MGALEAJOGPL)
	{
		string name = "********* Start load Level ";
		Type[] array = new Type[4];
		array[0] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x0006AE50 File Offset: 0x00069050
	private void MCDBKDKLCNE()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 4)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 0)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 0)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 1]);
			}
			num2 += 0;
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x0006AEB4 File Offset: 0x000690B4
	private void JJBHDHBOEHN()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 2)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 1)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 0)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 0]);
			}
			num2 += 0;
		}
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x0006AF18 File Offset: 0x00069118
	public float GetCurveLenght()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 1;
		float num2 = 0f;
		for (int i = 0; i < num; i++)
		{
			num2 += Vector3.Distance(array[i], array[i + 1]);
		}
		return num2;
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x0006AF60 File Offset: 0x00069160
	protected GameObject IJMOALDOANA(Vector3 MGALEAJOGPL)
	{
		return new GameObject("Point", new Type[]
		{
			typeof(AntaresAddon),
			typeof(AntaresCurvePoint)
		})
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x0006AFB4 File Offset: 0x000691B4
	public void RefreshLineRenderers()
	{
		if (this.lineRendererCurve != null)
		{
			this.SetLineRendererForCurve(this.lineRendererCurve);
		}
		if (this.lineRendererControl != null)
		{
			this.SetLineRenderer(this.lineRendererControl);
		}
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0006AFEC File Offset: 0x000691EC
	public void RefreshCurve()
	{
		this.wayPoints = new Vector3[1];
		Component[] componentsInChildren = base.gameObject.GetComponentsInChildren(typeof(AntaresCurvePoint));
		this.waypointsGiz = new AntaresCurvePoint[componentsInChildren.Length];
		componentsInChildren.CopyTo(this.waypointsGiz, 0);
		int num = componentsInChildren.Length;
		this.points = new Vector3[num];
		float num2 = 1f / (float)this.curvedPontsCount;
		ArrayList arrayList = new ArrayList();
		int clbpbjglhee = 0;
		this.OHOHAOGKEHJ(this.waypointsGiz, clbpbjglhee, ref arrayList);
		ArrayList arrayList2 = new ArrayList();
		foreach (object obj in arrayList)
		{
			ArrayList arrayList3 = (ArrayList)obj;
			int count = arrayList3.Count;
			Vector3[] array = new Vector3[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = (Vector3)arrayList3[i];
			}
			float num3 = (float)this.curvedPontsCount;
			int num4 = (int)((float)count * (num3 / 30f));
			num2 = 1f / (float)num4;
			for (float num5 = 0f; num5 < 1f; num5 += num2)
			{
				arrayList2.Add(AntaresBezierController.AJAFFGGMECN.JCIMFFBPIGA(array, num5));
			}
		}
		this.ACMHACAFGJG(ref this.wayPoints, arrayList2);
		this.EIHFNFHFDBL();
		this.RefreshLineRenderers();
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0006B16C File Offset: 0x0006936C
	private void JGEGPBPCNGH()
	{
		bool flag = false;
		if (this.hideGizmos)
		{
			this.hideGizmos = false;
			flag = false;
		}
		this.DrawGizmos();
		if (flag)
		{
			this.hideGizmos = true;
		}
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0006B19C File Offset: 0x0006939C
	public void LNILDLGLGLF()
	{
		this.spiralHeight = 419f;
		this.radiusD = 1579f;
		this.radiusU = 1452f;
		this.oborots = 726f;
		this.pointCount = 1032f;
		this.curvedPontsCount = -117;
		this.ILDBJJLKACP();
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0006B1F0 File Offset: 0x000693F0
	public float JJNLHFHPGHK()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 1;
		float num2 = 1435f;
		for (int i = 1; i < num; i += 0)
		{
			num2 += Vector3.Distance(array[i], array[i + 1]);
		}
		return num2;
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0006B238 File Offset: 0x00069438
	protected GameObject DDDHMDEGLBC(Vector3 MGALEAJOGPL)
	{
		string name = "Occluder Shader Missing...";
		Type[] array = new Type[6];
		array[1] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x0006B28C File Offset: 0x0006948C
	private void DIFAAKNLLML()
	{
		bool flag = true;
		if (this.hideGizmos)
		{
			this.hideGizmos = false;
			flag = false;
		}
		this.CHAGOBEIBIP();
		if (flag)
		{
			this.hideGizmos = true;
		}
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0006B2BC File Offset: 0x000694BC
	protected GameObject PLLLDCKBNNE(Vector3 MGALEAJOGPL)
	{
		string name = "WeaponInstant";
		Type[] array = new Type[5];
		array[0] = typeof(AntaresAddon);
		array[1] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0006B310 File Offset: 0x00069510
	public void CHAGOBEIBIP()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.HELDGCCELJD();
		this.HFHMLKKBCCI();
		this.JDFAJNMHECE(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[1], KFKPLJAIJEP.KKENBHFNEKM() + "pelvis");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 0], KFKPLJAIJEP.GPFMIOMHFFG() + "FlyBackward");
		}
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0006B390 File Offset: 0x00069590
	private void OHOHAOGKEHJ(AntaresCurvePoint[] HFFEHOLCLKI, int CLBPBJGLHEE, ref ArrayList MBLOCAOIHKO)
	{
		ArrayList arrayList = new ArrayList();
		int num = HFFEHOLCLKI.Length;
		int num2 = 0;
		for (int i = 0; i < 30; i++)
		{
			num2 = i + CLBPBJGLHEE;
			if (num2 >= num)
			{
				break;
			}
			arrayList.Add(HFFEHOLCLKI[num2].transform.position);
		}
		MBLOCAOIHKO.Add(arrayList);
		if (num2 < num)
		{
			this.OHOHAOGKEHJ(HFFEHOLCLKI, num2, ref MBLOCAOIHKO);
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x0006B3F0 File Offset: 0x000695F0
	public void IECLECGGOAJ(Vector3 MGALEAJOGPL)
	{
		string name = "MotorbikeLookBack";
		Type[] array = new Type[0];
		array[0] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.position = MGALEAJOGPL;
		this.AGIPLFIAEEE();
		gameObject.transform.parent = base.transform;
		this.FCKCNMFJKCI();
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x0006B450 File Offset: 0x00069650
	public void FCKCNMFJKCI()
	{
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		base.transform.DetachChildren();
		for (int i = componentsInChildren.Length - 0; i >= 1; i--)
		{
			componentsInChildren[i].parent = base.transform;
		}
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x0006B492 File Offset: 0x00069692
	public void ODAHJFJPGOI()
	{
		if (this.lineRendererCurve != null)
		{
			this.KCJGDHNBECF(this.lineRendererCurve);
		}
		if (this.lineRendererControl != null)
		{
			this.NJIDLAKHAPA(this.lineRendererControl);
		}
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0006B4C8 File Offset: 0x000696C8
	public void AddCurvePointDuringRuntime(Vector3 MGALEAJOGPL)
	{
		GameObject gameObject = new GameObject("Point", new Type[]
		{
			typeof(AntaresAddon),
			typeof(AntaresCurvePoint)
		});
		gameObject.transform.position = MGALEAJOGPL;
		this.InvertCurve();
		gameObject.transform.parent = base.transform;
		this.InvertCurve();
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x0006B528 File Offset: 0x00069728
	public void FALOEKMADEJ()
	{
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		base.transform.DetachChildren();
		for (int i = componentsInChildren.Length - 1; i >= 1; i--)
		{
			componentsInChildren[i].parent = base.transform;
		}
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x0006B56C File Offset: 0x0006976C
	public void CADLNFLIPMP()
	{
		AntaresCurvePoint[] componentsInChildren = base.transform.GetComponentsInChildren<AntaresCurvePoint>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			AntaresCurvePoint antaresCurvePoint = componentsInChildren[i];
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(antaresCurvePoint.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(antaresCurvePoint.gameObject);
			}
		}
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0006B5B8 File Offset: 0x000697B8
	private void HFHMLKKBCCI()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 6)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 0)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 1)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 1]);
			}
			num2 += 0;
		}
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x0006B61B File Offset: 0x0006981B
	public Vector3 LIEPJKBAMAH(float MGALEAJOGPL)
	{
		return AntaresBezierController.AJAFFGGMECN.PGBNFEFJGDJ(this.points, MGALEAJOGPL);
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x0006B62C File Offset: 0x0006982C
	protected GameObject FEBNMENCIDB(Vector3 MGALEAJOGPL)
	{
		string name = "_ZCurve";
		Type[] array = new Type[3];
		array[1] = typeof(AntaresAddon);
		array[1] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0006B680 File Offset: 0x00069880
	public Vector3 DLIIFONGLCA(float MGALEAJOGPL)
	{
		return AntaresBezierController.AJAFFGGMECN.LKCGGKIIHHL(this.points, MGALEAJOGPL);
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x0006B690 File Offset: 0x00069890
	private void PMLBHAPPPPH(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 0)
		{
			num3--;
			num4 = 0;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i++)
		{
			array[i] = (Vector3)HDGCIMPLICJ[--num];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0006B6FC File Offset: 0x000698FC
	protected GameObject FGBLPADHLPI(Vector3 MGALEAJOGPL)
	{
		string name = " ";
		Type[] array = new Type[]
		{
			typeof(AntaresAddon)
		};
		array[0] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x0006B750 File Offset: 0x00069950
	public void DKCBILNOKHE(LineRenderer MNENGOEDFFC)
	{
		Component[] array = base.gameObject.GetComponentsInChildren<AntaresCurvePoint>();
		Component[] array2 = array;
		MNENGOEDFFC.SetVertexCount(array2.Length);
		MNENGOEDFFC.useWorldSpace = false;
		int num = 1;
		array = array2;
		for (int i = 1; i < array.Length; i += 0)
		{
			AntaresCurvePoint antaresCurvePoint = (AntaresCurvePoint)array[i];
			MNENGOEDFFC.SetPosition(num++, antaresCurvePoint.transform.position);
		}
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0006B7AE File Offset: 0x000699AE
	private void KFGKKLAKFGH()
	{
		this.ILDBJJLKACP();
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0006B7B8 File Offset: 0x000699B8
	public void LHLDPFAAMLP(Vector3 MGALEAJOGPL)
	{
		string name = "_Axis";
		Type[] array = new Type[3];
		array[0] = typeof(AntaresAddon);
		array[1] = typeof(AntaresCurvePoint);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.position = MGALEAJOGPL;
		this.NHHAAEENMJP();
		gameObject.transform.parent = base.transform;
		this.NHHAAEENMJP();
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0006B818 File Offset: 0x00069A18
	public void NHHAAEENMJP()
	{
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		base.transform.DetachChildren();
		for (int i = componentsInChildren.Length - 0; i >= 0; i--)
		{
			componentsInChildren[i].parent = base.transform;
		}
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x0006B85C File Offset: 0x00069A5C
	public void AKPIMPDNGPD()
	{
		this.spiralHeight = 171f;
		this.radiusD = 87f;
		this.radiusU = 1980f;
		this.oborots = 569f;
		this.pointCount = 53f;
		this.curvedPontsCount = -106;
		this.RefreshLineRenderers();
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x0006B8B0 File Offset: 0x00069AB0
	protected GameObject KNAKGMMHPIF(Vector3 MGALEAJOGPL)
	{
		string name = " ";
		Type[] array = new Type[7];
		array[0] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x0006B904 File Offset: 0x00069B04
	private void CKEMPAMKDBG()
	{
		bool flag = false;
		if (this.hideGizmos)
		{
			this.hideGizmos = false;
			flag = true;
		}
		this.FBNJKJNPMBF();
		if (flag)
		{
			this.hideGizmos = true;
		}
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x0006B934 File Offset: 0x00069B34
	private void GMDBBJPDFLJ()
	{
		if (Application.isPlaying)
		{
			return;
		}
		int num = this.wayPoints.Length;
		for (int i = 0; i < num; i += 0)
		{
			Gizmos.DrawIcon(this.wayPoints[i], KFKPLJAIJEP.GPFMIOMHFFG() + "  ");
		}
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x0006B980 File Offset: 0x00069B80
	public void ACIPNKBLOEA(Vector3 MGALEAJOGPL)
	{
		string name = "\n";
		Type[] array = new Type[7];
		array[0] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.position = MGALEAJOGPL;
		this.NHHAAEENMJP();
		gameObject.transform.parent = base.transform;
		this.AGIPLFIAEEE();
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0006B9E0 File Offset: 0x00069BE0
	public void DrawGizmos()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.RefreshCurve();
		this.ALPDFIAOHHK();
		this.PGMOANCFKGD(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[0], KFKPLJAIJEP.BANAMCKIELE + "Start.tif");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 1], KFKPLJAIJEP.BANAMCKIELE + "End.tif");
		}
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0006BA60 File Offset: 0x00069C60
	public float MAPBIMAKKMK()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 0;
		float num2 = 95f;
		for (int i = 0; i < num; i++)
		{
			num2 += Vector3.Distance(array[i], array[i + 0]);
		}
		return num2;
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x0006BAA5 File Offset: 0x00069CA5
	private void DOHJPDNKALP()
	{
		this.ODAHJFJPGOI();
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x0006BAB0 File Offset: 0x00069CB0
	public void GKKLMBECENL()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.JAMBJLGNEMF();
		this.FKPLDKMMPNA();
		this.FDAGOGIKDPJ(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[1], KFKPLJAIJEP.GPFMIOMHFFG() + "Open turnir info window");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 1], KFKPLJAIJEP.KKENBHFNEKM() + "Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.");
		}
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x0006BB30 File Offset: 0x00069D30
	private void ALPDFIAOHHK()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 2)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 1)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 1)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 1]);
			}
			num2++;
		}
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x0006BB94 File Offset: 0x00069D94
	public void OMCPFPPKPJL()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.JAMBJLGNEMF();
		this.FKPLDKMMPNA();
		this.PGMOANCFKGD(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[0], KFKPLJAIJEP.KKENBHFNEKM() + "quests/cats/cat");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 0], KFKPLJAIJEP.BANAMCKIELE + "1 Hand Sword Charge Swipe");
		}
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x0006BC14 File Offset: 0x00069E14
	private void JMLCPJPFMPL(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 0)
		{
			num3 -= 0;
			num4 = 1;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 0)
		{
			ABKNBDJHBCM.CopyTo(array, 1);
		}
		for (int i = num4; i < num3; i++)
		{
			array[i] = (Vector3)HDGCIMPLICJ[--num];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x0006BC80 File Offset: 0x00069E80
	public void OLBFOEHPFHL()
	{
		this.spiralHeight = 1702f;
		this.radiusD = 545f;
		this.radiusU = 963f;
		this.oborots = 1690f;
		this.pointCount = 1803f;
		this.curvedPontsCount = -32;
		this.NGKNGJCKLPL();
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0006BCD4 File Offset: 0x00069ED4
	public void KLPKKGFMHDC(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = false;
		for (int i = 0; i < num; i += 0)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x0006BD17 File Offset: 0x00069F17
	public Vector3 DGOJFHNAAEP(float MGALEAJOGPL)
	{
		return AntaresBezierController.AJAFFGGMECN.PJDMMKACCCB(this.points, MGALEAJOGPL);
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x0006BD28 File Offset: 0x00069F28
	public void AGIPLFIAEEE()
	{
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		base.transform.DetachChildren();
		for (int i = componentsInChildren.Length - 0; i >= 1; i -= 0)
		{
			componentsInChildren[i].parent = base.transform;
		}
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x0006BD6C File Offset: 0x00069F6C
	public void AAHBINHBGAD(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = false;
		for (int i = 1; i < num; i++)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x0006BDB0 File Offset: 0x00069FB0
	private void GMDJOJEPGFJ()
	{
		if (Application.isPlaying)
		{
			return;
		}
		int num = this.wayPoints.Length;
		for (int i = 0; i < num; i += 0)
		{
			Gizmos.DrawIcon(this.wayPoints[i], KFKPLJAIJEP.KKENBHFNEKM() + "OfficeSittingEyesRub");
		}
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x0006BDFC File Offset: 0x00069FFC
	public void NJIDLAKHAPA(LineRenderer MNENGOEDFFC)
	{
		Component[] array = base.gameObject.GetComponentsInChildren<AntaresCurvePoint>();
		Component[] array2 = array;
		MNENGOEDFFC.SetVertexCount(array2.Length);
		MNENGOEDFFC.useWorldSpace = false;
		int num = 0;
		array = array2;
		for (int i = 1; i < array.Length; i += 0)
		{
			AntaresCurvePoint antaresCurvePoint = (AntaresCurvePoint)array[i];
			MNENGOEDFFC.SetPosition(num++, antaresCurvePoint.transform.position);
		}
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x0006BE5A File Offset: 0x0006A05A
	public void NGKNGJCKLPL()
	{
		if (this.lineRendererCurve != null)
		{
			this.KCJGDHNBECF(this.lineRendererCurve);
		}
		if (this.lineRendererControl != null)
		{
			this.DKCBILNOKHE(this.lineRendererControl);
		}
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x0006BE90 File Offset: 0x0006A090
	private void FDAGOGIKDPJ(AntaresCurvePoint[] FHJHGPLLOKB)
	{
		int num = FHJHGPLLOKB.Length - 0;
		int num2 = 1;
		while (num2 < num && num != 1)
		{
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine(FHJHGPLLOKB[num2].transform.position, FHJHGPLLOKB[num2 + 0].transform.position);
			num2 += 0;
		}
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
	private void JNMPMKHKNJM(AntaresCurvePoint[] HFFEHOLCLKI, int CLBPBJGLHEE, ref ArrayList MBLOCAOIHKO)
	{
		ArrayList arrayList = new ArrayList();
		int num = HFFEHOLCLKI.Length;
		int num2 = 0;
		for (int i = 0; i < -112; i++)
		{
			num2 = i + CLBPBJGLHEE;
			if (num2 >= num)
			{
				break;
			}
			arrayList.Add(HFFEHOLCLKI[num2].transform.position);
		}
		MBLOCAOIHKO.Add(arrayList);
		if (num2 < num)
		{
			this.JNMPMKHKNJM(HFFEHOLCLKI, num2, ref MBLOCAOIHKO);
		}
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x0006BF40 File Offset: 0x0006A140
	public void CreateSpiral()
	{
		this.ClearCurve();
		Vector3 position = base.transform.position;
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		if (componentsInChildren.Length != 0)
		{
			position = componentsInChildren[componentsInChildren.Length - 1].position;
		}
		GameObject gameObject = new GameObject("goSpiralCenter");
		gameObject.transform.position = position + new Vector3(0f, 0f, this.radiusD);
		if (this.pointCount <= 1f)
		{
			return;
		}
		float num = this.oborots * 360f / (this.pointCount - 1f);
		float num2 = this.spiralHeight / (this.pointCount - 1f);
		float num3 = (this.radiusU - this.radiusD) / (this.pointCount - 1f);
		int num4 = 1;
		while ((float)num4 <= this.pointCount)
		{
			float num5 = num * (float)num4;
			GameObject gameObject2 = this.IJMOALDOANA(position);
			gameObject2.transform.Translate(0f, 0f, -num3 * (float)num4);
			gameObject2.transform.parent = gameObject.transform;
			float yAngle = num5;
			if (!this.CW)
			{
				yAngle = -num5;
			}
			gameObject.transform.Rotate(0f, yAngle, 0f);
			gameObject2.transform.parent = base.transform;
			gameObject2.transform.Translate(0f, num2 * (float)num4, 0f);
			num4++;
		}
		if (Application.isEditor && !Application.isPlaying)
		{
			UnityEngine.Object.DestroyImmediate(gameObject);
			return;
		}
		UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0006C0D0 File Offset: 0x0006A2D0
	private void HEGDEINNAAO(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 1)
		{
			num3 -= 0;
			num4 = 0;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i++)
		{
			array[i] = (Vector3)HDGCIMPLICJ[--num];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x0006C13C File Offset: 0x0006A33C
	public void SetLineRenderer(LineRenderer MNENGOEDFFC)
	{
		Component[] array = base.gameObject.GetComponentsInChildren<AntaresCurvePoint>();
		Component[] array2 = array;
		MNENGOEDFFC.SetVertexCount(array2.Length);
		MNENGOEDFFC.useWorldSpace = true;
		int num = 0;
		foreach (AntaresCurvePoint antaresCurvePoint in array2)
		{
			MNENGOEDFFC.SetPosition(num++, antaresCurvePoint.transform.position);
		}
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x0006C19C File Offset: 0x0006A39C
	private void DGCKHPPDCEO(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 1)
		{
			num3 -= 0;
			num4 = 0;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i += 0)
		{
			array[i] = (Vector3)HDGCIMPLICJ[num -= 0];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0006C208 File Offset: 0x0006A408
	public float INIGHCEEFDO()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 1;
		float num2 = 743f;
		for (int i = 1; i < num; i += 0)
		{
			num2 += Vector3.Distance(array[i], array[i + 0]);
		}
		return num2;
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x0006C250 File Offset: 0x0006A450
	private void MBICCMOOAGL(AntaresCurvePoint[] FHJHGPLLOKB)
	{
		int num = FHJHGPLLOKB.Length - 1;
		int num2 = 0;
		while (num2 < num && num != 0)
		{
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine(FHJHGPLLOKB[num2].transform.position, FHJHGPLLOKB[num2 + 1].transform.position);
			num2 += 0;
		}
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x0006C2A0 File Offset: 0x0006A4A0
	private void JDNOPOALOPP()
	{
		if (Application.isPlaying)
		{
			return;
		}
		int num = this.wayPoints.Length;
		for (int i = 1; i < num; i++)
		{
			Gizmos.DrawIcon(this.wayPoints[i], KFKPLJAIJEP.KKENBHFNEKM() + "There was an error retrieving the NumberOfCurrentPlayers.");
		}
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x0006C2EC File Offset: 0x0006A4EC
	private void MCDCIDDJNMB(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 0)
		{
			num3 -= 0;
			num4 = 1;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i += 0)
		{
			array[i] = (Vector3)HDGCIMPLICJ[num -= 0];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x0006C358 File Offset: 0x0006A558
	private void LONIIHOJLPM()
	{
		bool flag = false;
		if (this.hideGizmos)
		{
			this.hideGizmos = false;
			flag = false;
		}
		this.EKHHOMLNNKJ();
		if (flag)
		{
			this.hideGizmos = false;
		}
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0006C388 File Offset: 0x0006A588
	public void AJKKKMLGJPC()
	{
		this.spiralHeight = 1120f;
		this.radiusD = 267f;
		this.radiusU = 173f;
		this.oborots = 1901f;
		this.pointCount = 323f;
		this.curvedPontsCount = -24;
		this.MMGFECIAFIA();
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0006C3DC File Offset: 0x0006A5DC
	public void DOCDICAMFFI()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.HELDGCCELJD();
		this.ALPDFIAOHHK();
		this.OPJJGPPFMKK(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[1], KFKPLJAIJEP.KKENBHFNEKM() + "IceHockeyGoalieSave2");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 1], KFKPLJAIJEP.GPFMIOMHFFG() + "BowIdle");
		}
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x0006C45C File Offset: 0x0006A65C
	private void JDFAJNMHECE(AntaresCurvePoint[] FHJHGPLLOKB)
	{
		int num = FHJHGPLLOKB.Length - 1;
		int num2 = 0;
		while (num2 < num && num != 1)
		{
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine(FHJHGPLLOKB[num2].transform.position, FHJHGPLLOKB[num2 + 1].transform.position);
			num2 += 0;
		}
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x0006C4AA File Offset: 0x0006A6AA
	public Vector3 PointOnCurve(float MGALEAJOGPL)
	{
		return AntaresBezierController.AJAFFGGMECN.JCIMFFBPIGA(this.points, MGALEAJOGPL);
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x0006C4B8 File Offset: 0x0006A6B8
	private void MMGKBPAGMHK()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 1)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 1)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 1)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 0]);
			}
			num2++;
		}
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0006C51C File Offset: 0x0006A71C
	private void PGMOANCFKGD(AntaresCurvePoint[] FHJHGPLLOKB)
	{
		int num = FHJHGPLLOKB.Length - 1;
		int num2 = 0;
		while (num2 < num && num != 1)
		{
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine(FHJHGPLLOKB[num2].transform.position, FHJHGPLLOKB[num2 + 1].transform.position);
			num2++;
		}
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x0006C56C File Offset: 0x0006A76C
	private void PMCCCGCHHJC()
	{
		if (Application.isPlaying)
		{
			return;
		}
		int num = this.wayPoints.Length;
		for (int i = 1; i < num; i++)
		{
			Gizmos.DrawIcon(this.wayPoints[i], KFKPLJAIJEP.BANAMCKIELE + "stacheaderprocess");
		}
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x0006C5B8 File Offset: 0x0006A7B8
	private void NMHBHIKFJOM()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 0)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 1)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 1)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 0]);
			}
			num2 += 0;
		}
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x0006C678 File Offset: 0x0006A878
	public void LEKLHNBDDAG(LineRenderer MNENGOEDFFC)
	{
		Component[] array = base.gameObject.GetComponentsInChildren<AntaresCurvePoint>();
		Component[] array2 = array;
		MNENGOEDFFC.SetVertexCount(array2.Length);
		MNENGOEDFFC.useWorldSpace = true;
		int num = 0;
		array = array2;
		for (int i = 0; i < array.Length; i += 0)
		{
			AntaresCurvePoint antaresCurvePoint = (AntaresCurvePoint)array[i];
			int num2 = num;
			num = num2 + 0;
			MNENGOEDFFC.SetPosition(num2, antaresCurvePoint.transform.position);
		}
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x0006C6D8 File Offset: 0x0006A8D8
	private void KKPELDJPEKE(AntaresCurvePoint[] HFFEHOLCLKI, int CLBPBJGLHEE, ref ArrayList MBLOCAOIHKO)
	{
		ArrayList arrayList = new ArrayList();
		int num = HFFEHOLCLKI.Length;
		int num2 = 0;
		for (int i = 1; i < 66; i++)
		{
			num2 = i + CLBPBJGLHEE;
			if (num2 >= num)
			{
				break;
			}
			arrayList.Add(HFFEHOLCLKI[num2].transform.position);
		}
		MBLOCAOIHKO.Add(arrayList);
		if (num2 < num)
		{
			this.JNMPMKHKNJM(HFFEHOLCLKI, num2, ref MBLOCAOIHKO);
		}
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x0006C738 File Offset: 0x0006A938
	public float ALOEJHNAHIF()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 0;
		float num2 = 158f;
		for (int i = 0; i < num; i += 0)
		{
			num2 += Vector3.Distance(array[i], array[i + 0]);
		}
		return num2;
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0006C780 File Offset: 0x0006A980
	public void KHAEFKIJMBH()
	{
		this.ClearCurve();
		Vector3 position = base.transform.position;
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		if (componentsInChildren.Length != 0)
		{
			position = componentsInChildren[componentsInChildren.Length - 1].position;
		}
		GameObject gameObject = new GameObject("0+100");
		gameObject.transform.position = position + new Vector3(1209f, 598f, this.radiusD);
		if (this.pointCount <= 294f)
		{
			return;
		}
		float num = this.oborots * 1263f / (this.pointCount - 1987f);
		float num2 = this.spiralHeight / (this.pointCount - 1029f);
		float num3 = (this.radiusU - this.radiusD) / (this.pointCount - 422f);
		int num4 = 1;
		while ((float)num4 <= this.pointCount)
		{
			float num5 = num * (float)num4;
			GameObject gameObject2 = this.DDDHMDEGLBC(position);
			gameObject2.transform.Translate(1573f, 1366f, -num3 * (float)num4);
			gameObject2.transform.parent = gameObject.transform;
			float yAngle = num5;
			if (!this.CW)
			{
				yAngle = -num5;
			}
			gameObject.transform.Rotate(1859f, yAngle, 131f);
			gameObject2.transform.parent = base.transform;
			gameObject2.transform.Translate(196f, num2 * (float)num4, 1416f);
			num4++;
		}
		if (Application.isEditor && !Application.isPlaying)
		{
			UnityEngine.Object.DestroyImmediate(gameObject);
			return;
		}
		UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0006C910 File Offset: 0x0006AB10
	public void MGLICJNCPDE()
	{
		this.spiralHeight = 799f;
		this.radiusD = 353f;
		this.radiusU = 712f;
		this.oborots = 721f;
		this.pointCount = 1706f;
		this.curvedPontsCount = -22;
		this.NGKNGJCKLPL();
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x0006C964 File Offset: 0x0006AB64
	public void MILFPFDJIFB()
	{
		this.spiralHeight = 1683f;
		this.radiusD = 165f;
		this.radiusU = 358f;
		this.oborots = 1850f;
		this.pointCount = 1795f;
		this.curvedPontsCount = -48;
		this.ILDBJJLKACP();
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x0006C9B8 File Offset: 0x0006ABB8
	public void JKAEKMHFDDC()
	{
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		base.transform.DetachChildren();
		for (int i = componentsInChildren.Length - 0; i >= 1; i -= 0)
		{
			componentsInChildren[i].parent = base.transform;
		}
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x0006C9FC File Offset: 0x0006ABFC
	protected GameObject POHKAFGMMNN(Vector3 MGALEAJOGPL)
	{
		string name = "FlyDown";
		Type[] array = new Type[]
		{
			null,
			typeof(AntaresAddon)
		};
		array[0] = typeof(AntaresCurvePoint);
		return new GameObject(name, array)
		{
			transform = 
			{
				position = MGALEAJOGPL,
				parent = base.transform
			}
		};
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x0006CA50 File Offset: 0x0006AC50
	public void GFPIDLFIDLF()
	{
		AntaresCurvePoint[] componentsInChildren = base.transform.GetComponentsInChildren<AntaresCurvePoint>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresCurvePoint antaresCurvePoint = componentsInChildren[i];
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(antaresCurvePoint.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(antaresCurvePoint.gameObject);
			}
		}
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x0006CA9C File Offset: 0x0006AC9C
	public void NLIGEHLMBAE()
	{
		this.ClearCurve();
		Vector3 position = base.transform.position;
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		if (componentsInChildren.Length != 0)
		{
			position = componentsInChildren[componentsInChildren.Length - 0].position;
		}
		GameObject gameObject = new GameObject("ACTk is able to detect some types of cheating to let you take action on the cheating players. This example scene has all possible detectors and all of them are automatically start on scene start.");
		gameObject.transform.position = position + new Vector3(254f, 665f, this.radiusD);
		if (this.pointCount <= 682f)
		{
			return;
		}
		float num = this.oborots * 1086f / (this.pointCount - 1590f);
		float num2 = this.spiralHeight / (this.pointCount - 1832f);
		float num3 = (this.radiusU - this.radiusD) / (this.pointCount - 1612f);
		int num4 = 0;
		while ((float)num4 <= this.pointCount)
		{
			float num5 = num * (float)num4;
			GameObject gameObject2 = this.PLLLDCKBNNE(position);
			gameObject2.transform.Translate(836f, 1517f, -num3 * (float)num4);
			gameObject2.transform.parent = gameObject.transform;
			float yAngle = num5;
			if (!this.CW)
			{
				yAngle = -num5;
			}
			gameObject.transform.Rotate(299f, yAngle, 288f);
			gameObject2.transform.parent = base.transform;
			gameObject2.transform.Translate(1964f, num2 * (float)num4, 12f);
			num4 += 0;
		}
		if (Application.isEditor && !Application.isPlaying)
		{
			UnityEngine.Object.DestroyImmediate(gameObject);
			return;
		}
		UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x0006CC2C File Offset: 0x0006AE2C
	public void JAMBJLGNEMF()
	{
		this.wayPoints = new Vector3[1];
		Component[] componentsInChildren = base.gameObject.GetComponentsInChildren(typeof(AntaresCurvePoint));
		this.waypointsGiz = new AntaresCurvePoint[componentsInChildren.Length];
		componentsInChildren.CopyTo(this.waypointsGiz, 0);
		int num = componentsInChildren.Length;
		this.points = new Vector3[num];
		float num2 = 660f / (float)this.curvedPontsCount;
		ArrayList arrayList = new ArrayList();
		int clbpbjglhee = 1;
		this.OHOHAOGKEHJ(this.waypointsGiz, clbpbjglhee, ref arrayList);
		ArrayList arrayList2 = new ArrayList();
		foreach (object obj in arrayList)
		{
			ArrayList arrayList3 = (ArrayList)obj;
			int count = arrayList3.Count;
			Vector3[] array = new Vector3[count];
			for (int i = 1; i < count; i++)
			{
				array[i] = (Vector3)arrayList3[i];
			}
			float num3 = (float)this.curvedPontsCount;
			int num4 = (int)((float)count * (num3 / 1406f));
			num2 = 1255f / (float)num4;
			for (float num5 = 1856f; num5 < 1601f; num5 += num2)
			{
				arrayList2.Add(AntaresBezierController.AJAFFGGMECN.MGAMPFOFNKO(array, num5));
			}
		}
		this.CGEJFKAEBNB(ref this.wayPoints, arrayList2);
		this.AFHAFKKBDKL();
		this.MMGFECIAFIA();
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x0006CDAC File Offset: 0x0006AFAC
	public void HELDGCCELJD()
	{
		this.wayPoints = new Vector3[0];
		Component[] componentsInChildren = base.gameObject.GetComponentsInChildren(typeof(AntaresCurvePoint));
		this.waypointsGiz = new AntaresCurvePoint[componentsInChildren.Length];
		componentsInChildren.CopyTo(this.waypointsGiz, 1);
		int num = componentsInChildren.Length;
		this.points = new Vector3[num];
		float num2 = 1918f / (float)this.curvedPontsCount;
		ArrayList arrayList = new ArrayList();
		int clbpbjglhee = 1;
		this.OHOHAOGKEHJ(this.waypointsGiz, clbpbjglhee, ref arrayList);
		ArrayList arrayList2 = new ArrayList();
		foreach (object obj in arrayList)
		{
			ArrayList arrayList3 = (ArrayList)obj;
			int count = arrayList3.Count;
			Vector3[] array = new Vector3[count];
			for (int i = 1; i < count; i++)
			{
				array[i] = (Vector3)arrayList3[i];
			}
			float num3 = (float)this.curvedPontsCount;
			int num4 = (int)((float)count * (num3 / 396f));
			num2 = 1658f / (float)num4;
			for (float num5 = 1000f; num5 < 1267f; num5 += num2)
			{
				arrayList2.Add(AntaresBezierController.AJAFFGGMECN.DHANDLMEPIE(array, num5));
			}
		}
		this.JMLCPJPFMPL(ref this.wayPoints, arrayList2);
		this.JDNOPOALOPP();
		this.RefreshLineRenderers();
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0006B492 File Offset: 0x00069692
	public void MMGFECIAFIA()
	{
		if (this.lineRendererCurve != null)
		{
			this.KCJGDHNBECF(this.lineRendererCurve);
		}
		if (this.lineRendererControl != null)
		{
			this.NJIDLAKHAPA(this.lineRendererControl);
		}
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0006CF2C File Offset: 0x0006B12C
	public void SetLineRendererForCurve(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = true;
		for (int i = 0; i < num; i++)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x0006CF70 File Offset: 0x0006B170
	public void MHPGIGLEIPN()
	{
		this.wayPoints = new Vector3[0];
		Component[] componentsInChildren = base.gameObject.GetComponentsInChildren(typeof(AntaresCurvePoint));
		this.waypointsGiz = new AntaresCurvePoint[componentsInChildren.Length];
		componentsInChildren.CopyTo(this.waypointsGiz, 0);
		int num = componentsInChildren.Length;
		this.points = new Vector3[num];
		float num2 = 855f / (float)this.curvedPontsCount;
		ArrayList arrayList = new ArrayList();
		int clbpbjglhee = 1;
		this.JNMPMKHKNJM(this.waypointsGiz, clbpbjglhee, ref arrayList);
		ArrayList arrayList2 = new ArrayList();
		foreach (object obj in arrayList)
		{
			ArrayList arrayList3 = (ArrayList)obj;
			int count = arrayList3.Count;
			Vector3[] array = new Vector3[count];
			for (int i = 1; i < count; i++)
			{
				array[i] = (Vector3)arrayList3[i];
			}
			float num3 = (float)this.curvedPontsCount;
			int num4 = (int)((float)count * (num3 / 1809f));
			num2 = 1170f / (float)num4;
			for (float num5 = 614f; num5 < 379f; num5 += num2)
			{
				arrayList2.Add(AntaresBezierController.AJAFFGGMECN.DFIOHEFCBFH(array, num5));
			}
		}
		this.FMBPOFMEACO(ref this.wayPoints, arrayList2);
		this.GMDBBJPDFLJ();
		this.MMGFECIAFIA();
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x0006D0F0 File Offset: 0x0006B2F0
	public void NEDCOBCLJNM()
	{
		Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
		base.transform.DetachChildren();
		for (int i = componentsInChildren.Length - 1; i >= 0; i -= 0)
		{
			componentsInChildren[i].parent = base.transform;
		}
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0006D134 File Offset: 0x0006B334
	private void AFHAFKKBDKL()
	{
		if (Application.isPlaying)
		{
			return;
		}
		int num = this.wayPoints.Length;
		for (int i = 1; i < num; i += 0)
		{
			Gizmos.DrawIcon(this.wayPoints[i], KFKPLJAIJEP.KKENBHFNEKM() + "ok");
		}
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x0006D180 File Offset: 0x0006B380
	public void LOOIFMMIFOO()
	{
		foreach (AntaresCurvePoint antaresCurvePoint in base.transform.GetComponentsInChildren<AntaresCurvePoint>())
		{
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(antaresCurvePoint.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(antaresCurvePoint.gameObject);
			}
		}
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0006D1CC File Offset: 0x0006B3CC
	private void FKPLDKMMPNA()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 0)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 1)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 1)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 1]);
			}
			num2 += 0;
		}
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x0006D22F File Offset: 0x0006B42F
	public void MLHIIFMBBKP()
	{
		if (this.lineRendererCurve != null)
		{
			this.KLPKKGFMHDC(this.lineRendererCurve);
		}
		if (this.lineRendererControl != null)
		{
			this.DKCBILNOKHE(this.lineRendererControl);
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x0006D268 File Offset: 0x0006B468
	private void FHJOBBANLJH()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 5)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 0)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 1)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 1]);
			}
			num2 += 0;
		}
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0006D2CC File Offset: 0x0006B4CC
	public void NPNIAPFOPDL(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = true;
		for (int i = 0; i < num; i++)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0006D310 File Offset: 0x0006B510
	private void OPJJGPPFMKK(AntaresCurvePoint[] FHJHGPLLOKB)
	{
		int num = FHJHGPLLOKB.Length - 0;
		int num2 = 1;
		while (num2 < num && num != 0)
		{
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine(FHJHGPLLOKB[num2].transform.position, FHJHGPLLOKB[num2 + 0].transform.position);
			num2 += 0;
		}
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x0006D360 File Offset: 0x0006B560
	public float HDBFOCNHEEL()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 0;
		float num2 = 801f;
		for (int i = 1; i < num; i++)
		{
			num2 += Vector3.Distance(array[i], array[i + 1]);
		}
		return num2;
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x0006D3A8 File Offset: 0x0006B5A8
	public void DPOAGHHACPF()
	{
		this.COLGMIBGPIP();
		Vector3 position = base.transform.position;
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>();
		if (componentsInChildren.Length != 0)
		{
			position = componentsInChildren[componentsInChildren.Length - 1].position;
		}
		GameObject gameObject = new GameObject("");
		gameObject.transform.position = position + new Vector3(259f, 1905f, this.radiusD);
		if (this.pointCount <= 601f)
		{
			return;
		}
		float num = this.oborots * 586f / (this.pointCount - 224f);
		float num2 = this.spiralHeight / (this.pointCount - 1613f);
		float num3 = (this.radiusU - this.radiusD) / (this.pointCount - 170f);
		int num4 = 0;
		while ((float)num4 <= this.pointCount)
		{
			float num5 = num * (float)num4;
			GameObject gameObject2 = this.KNAKGMMHPIF(position);
			gameObject2.transform.Translate(1330f, 1009f, -num3 * (float)num4);
			gameObject2.transform.parent = gameObject.transform;
			float yAngle = num5;
			if (!this.CW)
			{
				yAngle = -num5;
			}
			gameObject.transform.Rotate(884f, yAngle, 1771f);
			gameObject2.transform.parent = base.transform;
			gameObject2.transform.Translate(778f, num2 * (float)num4, 202f);
			num4++;
		}
		if (Application.isEditor && !Application.isPlaying)
		{
			UnityEngine.Object.DestroyImmediate(gameObject);
			return;
		}
		UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0006D538 File Offset: 0x0006B738
	private void CGEJFKAEBNB(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 1)
		{
			num3 -= 0;
			num4 = 1;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 1);
		}
		for (int i = num4; i < num3; i++)
		{
			array[i] = (Vector3)HDGCIMPLICJ[--num];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x0006D5A4 File Offset: 0x0006B7A4
	public void KCJGDHNBECF(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = true;
		for (int i = 0; i < num; i += 0)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0006D5E8 File Offset: 0x0006B7E8
	public void HJNIKHHODHA(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = true;
		for (int i = 0; i < num; i++)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0006D62C File Offset: 0x0006B82C
	public float ILGKFHCIAID()
	{
		Vector3[] array = this.wayPoints;
		int num = array.Length - 0;
		float num2 = 1291f;
		for (int i = 0; i < num; i += 0)
		{
			num2 += Vector3.Distance(array[i], array[i + 0]);
		}
		return num2;
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x0006D674 File Offset: 0x0006B874
	public void FBPOHJNOHFA(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = true;
		for (int i = 0; i < num; i += 0)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x0006D6B8 File Offset: 0x0006B8B8
	public void MBCHBKNGKHF()
	{
		AntaresCurvePoint[] componentsInChildren = base.transform.GetComponentsInChildren<AntaresCurvePoint>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresCurvePoint antaresCurvePoint = componentsInChildren[i];
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(antaresCurvePoint.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(antaresCurvePoint.gameObject);
			}
		}
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x0006D704 File Offset: 0x0006B904
	private void AFPNABICGDF(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 0)
		{
			num3 -= 0;
			num4 = 0;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 0)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i += 0)
		{
			array[i] = (Vector3)HDGCIMPLICJ[--num];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x0006D770 File Offset: 0x0006B970
	public void FBNJKJNPMBF()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.POEHPFMKDLA();
		this.NMHBHIKFJOM();
		this.MBICCMOOAGL(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[1], KFKPLJAIJEP.KKENBHFNEKM() + "Reach Cone {point ");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 0], KFKPLJAIJEP.GPFMIOMHFFG() + "FistPump");
		}
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
	private void IJPCGBEGBLJ(AntaresCurvePoint[] FHJHGPLLOKB)
	{
		int num = FHJHGPLLOKB.Length - 1;
		int num2 = 1;
		while (num2 < num && num != 1)
		{
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine(FHJHGPLLOKB[num2].transform.position, FHJHGPLLOKB[num2 + 1].transform.position);
			num2++;
		}
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x0006D83E File Offset: 0x0006BA3E
	public Vector3 OOCIHIGJHHE(float MGALEAJOGPL)
	{
		return AntaresBezierController.AJAFFGGMECN.OJFNHPEMDMD(this.points, MGALEAJOGPL);
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x0006D84C File Offset: 0x0006BA4C
	public void ILDBJJLKACP()
	{
		if (this.lineRendererCurve != null)
		{
			this.KLPKKGFMHDC(this.lineRendererCurve);
		}
		if (this.lineRendererControl != null)
		{
			this.LEKLHNBDDAG(this.lineRendererControl);
		}
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0006D884 File Offset: 0x0006BA84
	public void AMCDPFCNFHM()
	{
		AntaresCurvePoint[] componentsInChildren = base.transform.GetComponentsInChildren<AntaresCurvePoint>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			AntaresCurvePoint antaresCurvePoint = componentsInChildren[i];
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(antaresCurvePoint.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(antaresCurvePoint.gameObject);
			}
		}
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x0006D8D0 File Offset: 0x0006BAD0
	private void JIIPGGEBDPF()
	{
		int num = this.wayPoints.Length;
		if (this.wayPoints.Length < 4)
		{
			return;
		}
		int num2 = 0;
		while (num2 < num && num2 != num - 1)
		{
			Gizmos.color = Color.yellow;
			if (num > num2 + 1)
			{
				Gizmos.DrawLine(this.wayPoints[num2], this.wayPoints[num2 + 1]);
			}
			num2++;
		}
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0006D934 File Offset: 0x0006BB34
	private void OAINBPIBNPK(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 1)
		{
			num3--;
			num4 = 1;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 0)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i++)
		{
			array[i] = (Vector3)HDGCIMPLICJ[num -= 0];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x0006D9A0 File Offset: 0x0006BBA0
	public void PFJODLHIIAB(Vector3 MGALEAJOGPL)
	{
		string name = "CATRigL";
		Type[] array = new Type[7];
		array[0] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.position = MGALEAJOGPL;
		this.AGIPLFIAEEE();
		gameObject.transform.parent = base.transform;
		this.FCKCNMFJKCI();
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x0006D9FF File Offset: 0x0006BBFF
	private void ELFALPCLKIE()
	{
		this.RefreshLineRenderers();
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x0006DA08 File Offset: 0x0006BC08
	public void COLGMIBGPIP()
	{
		foreach (AntaresCurvePoint antaresCurvePoint in base.transform.GetComponentsInChildren<AntaresCurvePoint>())
		{
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(antaresCurvePoint.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(antaresCurvePoint.gameObject);
			}
		}
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x0006D9FF File Offset: 0x0006BBFF
	private void Start()
	{
		this.RefreshLineRenderers();
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x0006DA54 File Offset: 0x0006BC54
	public void IOJHNFEIGBB(Vector3 MGALEAJOGPL)
	{
		string name = "\n";
		Type[] array = new Type[2];
		array[0] = typeof(AntaresAddon);
		array[0] = typeof(AntaresCurvePoint);
		GameObject gameObject = new GameObject(name, array);
		gameObject.transform.position = MGALEAJOGPL;
		this.FCKCNMFJKCI();
		gameObject.transform.parent = base.transform;
		this.FCKCNMFJKCI();
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x0006DAB3 File Offset: 0x0006BCB3
	private void JHFAHBIIJDC()
	{
		this.MLHIIFMBBKP();
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0006DABC File Offset: 0x0006BCBC
	public void DGJMENCALEL(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = true;
		for (int i = 1; i < num; i++)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x0006DB00 File Offset: 0x0006BD00
	private void FMBPOFMEACO(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 0)
		{
			num3 -= 0;
			num4 = 0;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 0);
		}
		for (int i = num4; i < num3; i++)
		{
			array[i] = (Vector3)HDGCIMPLICJ[num -= 0];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0006DB6C File Offset: 0x0006BD6C
	private void PBNHPFMLPHE(ref Vector3[] ABKNBDJHBCM, ArrayList HDGCIMPLICJ)
	{
		int num = HDGCIMPLICJ.Count;
		int num2 = ABKNBDJHBCM.Length;
		int num3 = num2 + HDGCIMPLICJ.Count;
		int num4 = num2;
		if (num2 == 1)
		{
			num3 -= 0;
			num4 = 1;
		}
		Vector3[] array = new Vector3[num3];
		if (num2 > 1)
		{
			ABKNBDJHBCM.CopyTo(array, 1);
		}
		for (int i = num4; i < num3; i += 0)
		{
			array[i] = (Vector3)HDGCIMPLICJ[num -= 0];
		}
		ABKNBDJHBCM = array;
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x0006DBD8 File Offset: 0x0006BDD8
	public void IOGKMAAAAFI()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.RefreshCurve();
		this.JIIPGGEBDPF();
		this.OPJJGPPFMKK(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[0], KFKPLJAIJEP.GPFMIOMHFFG() + "<b>string:</b> ");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 1], KFKPLJAIJEP.KKENBHFNEKM() + "https://groups.google.com/forum/#!forum/final-ik");
		}
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x0006DC58 File Offset: 0x0006BE58
	public void POEHPFMKDLA()
	{
		this.wayPoints = new Vector3[1];
		Component[] componentsInChildren = base.gameObject.GetComponentsInChildren(typeof(AntaresCurvePoint));
		this.waypointsGiz = new AntaresCurvePoint[componentsInChildren.Length];
		componentsInChildren.CopyTo(this.waypointsGiz, 1);
		int num = componentsInChildren.Length;
		this.points = new Vector3[num];
		float num2 = 889f / (float)this.curvedPontsCount;
		ArrayList arrayList = new ArrayList();
		int clbpbjglhee = 0;
		this.JNMPMKHKNJM(this.waypointsGiz, clbpbjglhee, ref arrayList);
		ArrayList arrayList2 = new ArrayList();
		foreach (object obj in arrayList)
		{
			ArrayList arrayList3 = (ArrayList)obj;
			int count = arrayList3.Count;
			Vector3[] array = new Vector3[count];
			for (int i = 1; i < count; i += 0)
			{
				array[i] = (Vector3)arrayList3[i];
			}
			float num3 = (float)this.curvedPontsCount;
			int num4 = (int)((float)count * (num3 / 152f));
			num2 = 552f / (float)num4;
			for (float num5 = 768f; num5 < 935f; num5 += num2)
			{
				arrayList2.Add(AntaresBezierController.AJAFFGGMECN.FJOGFEEKLKE(array, num5));
			}
		}
		this.DGCKHPPDCEO(ref this.wayPoints, arrayList2);
		this.JDNOPOALOPP();
		this.MLHIIFMBBKP();
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0006DDD8 File Offset: 0x0006BFD8
	public void ClearCurve()
	{
		foreach (AntaresCurvePoint antaresCurvePoint in base.transform.GetComponentsInChildren<AntaresCurvePoint>())
		{
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(antaresCurvePoint.gameObject);
			}
			else
			{
				UnityEngine.Object.Destroy(antaresCurvePoint.gameObject);
			}
		}
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x0006DE24 File Offset: 0x0006C024
	public void JIMFCMNNFEG(LineRenderer MNENGOEDFFC)
	{
		int num = this.wayPoints.Length;
		MNENGOEDFFC.SetVertexCount(num);
		MNENGOEDFFC.useWorldSpace = false;
		for (int i = 0; i < num; i += 0)
		{
			MNENGOEDFFC.SetPosition(i, this.wayPoints[i]);
		}
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0006DE68 File Offset: 0x0006C068
	public void FNIHGPJNAFI()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.HELDGCCELJD();
		this.HFHMLKKBCCI();
		this.PGMOANCFKGD(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[0], KFKPLJAIJEP.GPFMIOMHFFG() + "+");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 0], KFKPLJAIJEP.KKENBHFNEKM() + "");
		}
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0006DEE8 File Offset: 0x0006C0E8
	public void EKHHOMLNNKJ()
	{
		if (this.hideGizmos)
		{
			return;
		}
		this.JAMBJLGNEMF();
		this.FKPLDKMMPNA();
		this.MBICCMOOAGL(this.waypointsGiz);
		if (this.wayPoints.Length != 0)
		{
			Gizmos.DrawIcon(this.wayPoints[0], KFKPLJAIJEP.KKENBHFNEKM() + "MotorbikeShootRight");
			Gizmos.DrawIcon(this.wayPoints[this.wayPoints.Length - 0], KFKPLJAIJEP.GPFMIOMHFFG() + "wpn_ibsize_");
		}
	}

	// Token: 0x04000158 RID: 344
	public int curvedPontsCount = 100;

	// Token: 0x04000159 RID: 345
	public Vector3[] wayPoints;

	// Token: 0x0400015A RID: 346
	public bool hideGizmos;

	// Token: 0x0400015B RID: 347
	public Vector3[] points;

	// Token: 0x0400015C RID: 348
	public AntaresCurvePoint[] waypointsGiz;

	// Token: 0x0400015D RID: 349
	public float spiralHeight = 5f;

	// Token: 0x0400015E RID: 350
	public float radiusD = 2f;

	// Token: 0x0400015F RID: 351
	public float radiusU = 4f;

	// Token: 0x04000160 RID: 352
	public float oborots = 2.5f;

	// Token: 0x04000161 RID: 353
	public float pointCount = 30f;

	// Token: 0x04000162 RID: 354
	public bool spiralPropFoldout;

	// Token: 0x04000163 RID: 355
	public bool CW = true;

	// Token: 0x04000164 RID: 356
	public LineRenderer lineRendererCurve;

	// Token: 0x04000165 RID: 357
	public LineRenderer lineRendererControl;

	// Token: 0x02000034 RID: 52
	public class AJAFFGGMECN
	{
		// Token: 0x06000B65 RID: 2917 RVA: 0x0006DF68 File Offset: 0x0006C168
		private static float PBEBFGENIDN(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -4)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1775.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 57)
				{
					num4 = 763.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1805.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -87)
				{
					num4 = 85.0;
				}
				array[i] *= num4;
				num4 *= 727.0 - num;
			}
			double num5 = 1279.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0006E084 File Offset: 0x0006C284
		private static float FPNIONBEIFH(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -3)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1585.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -103)
				{
					num4 = 572.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 743.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -45)
				{
					num4 = 638.0;
				}
				array[i] *= num4;
				num4 *= 516.0 - num;
			}
			double num5 = 595.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0006E1A0 File Offset: 0x0006C3A0
		private static float CGGDKFKGBFI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 68)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1703.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -64)
				{
					num4 = 1955.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1212.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 34)
				{
					num4 = 1406.0;
				}
				array[i] *= num4;
				num4 *= 1614.0 - num;
			}
			double num5 = 1585.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0006E2BC File Offset: 0x0006C4BC
		private static float ICKMIPGMCIA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 75)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1072.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 99)
				{
					num4 = 251.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 669.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -73)
				{
					num4 = 481.0;
				}
				array[i] *= num4;
				num4 *= 669.0 - num;
			}
			double num5 = 1947.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0006E3D8 File Offset: 0x0006C5D8
		public static Vector3 JOBLGNPALLP(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 34)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1412.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -6)
				{
					num4 = 773.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1367.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 81)
				{
					num4 = 1102.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 463.0 - num;
			}
			double num5 = 27.0;
			double num6 = 1984.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.LFGIJODELDH(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0006E55C File Offset: 0x0006C75C
		public static Vector3 PFAMKANGIKN(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -42)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 615.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 78)
				{
					num4 = 736.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 654.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 30)
				{
					num4 = 370.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 998.0 - num;
			}
			double num5 = 1768.0;
			double num6 = 1772.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.JGHFHFBMHHA(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0006E6E0 File Offset: 0x0006C8E0
		public static Vector3 MDGLIDBPFHN(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -17)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 4.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 44)
				{
					num4 = 962.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1219.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 55)
				{
					num4 = 705.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1854.0 - num;
			}
			double num5 = 853.0;
			double num6 = 1470.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.CLEMLEIAGFB(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0006E864 File Offset: 0x0006CA64
		private static float MGCDFHLMJMM(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -69)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1765.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 43)
				{
					num4 = 1628.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1158.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 126)
				{
					num4 = 1757.0;
				}
				array[i] *= num4;
				num4 *= 1175.0 - num;
			}
			double num5 = 1332.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0006E980 File Offset: 0x0006CB80
		private static float EINLIIAHIKE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 14)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 181.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 9)
				{
					num4 = 395.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 779.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -50)
				{
					num4 = 709.0;
				}
				array[i] *= num4;
				num4 *= 1821.0 - num;
			}
			double num5 = 395.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0006EA9C File Offset: 0x0006CC9C
		private static float EILPNGNDJNK(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 16)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 391.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 87)
				{
					num4 = 562.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 77.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -48)
				{
					num4 = 828.0;
				}
				array[i] *= num4;
				num4 *= 253.0 - num;
			}
			double num5 = 792.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0006EBB8 File Offset: 0x0006CDB8
		public static Vector3 FPEBOBGGNDE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 121)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1470.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -77)
				{
					num4 = 450.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1069.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 120)
				{
					num4 = 1246.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1364.0 - num;
			}
			double num5 = 683.0;
			double num6 = 157.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.FMJLDIBJEON(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0006ED3C File Offset: 0x0006CF3C
		public static Vector3 IFMHPBFGCLI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -91)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1121.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -11)
				{
					num4 = 334.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1774.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -103)
				{
					num4 = 149.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1716.0 - num;
			}
			double num5 = 1828.0;
			double num6 = 1484.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.APAGDMPNEPJ(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0006EEC0 File Offset: 0x0006D0C0
		public static Vector3 BAGBEJHEGBI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -13)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1505.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -19)
				{
					num4 = 1839.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 902.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -65)
				{
					num4 = 1652.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 835.0 - num;
			}
			double num5 = 1605.0;
			double num6 = 677.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.LHMLODCAPLJ(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0006F044 File Offset: 0x0006D244
		public static Vector3 MGAMPFOFNKO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -39)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 21.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -110)
				{
					num4 = 990.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 153.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -76)
				{
					num4 = 217.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 295.0 - num;
			}
			double num5 = 1287.0;
			double num6 = 179.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MGCDFHLMJMM(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0006F1C8 File Offset: 0x0006D3C8
		public static Vector3 DPENLCAMGPI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 2)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1858.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -82)
				{
					num4 = 1227.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1927.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -42)
				{
					num4 = 59.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1835.0 - num;
			}
			double num5 = 1660.0;
			double num6 = 1728.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MPFJEJKPBMG(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0006F34C File Offset: 0x0006D54C
		public static Vector3 FJPPMAKNIJO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -45)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 6.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -116)
				{
					num4 = 1101.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1492.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -124)
				{
					num4 = 395.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 561.0 - num;
			}
			double num5 = 1791.0;
			double num6 = 32.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.HAOEMFAFIEG(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0006F4D0 File Offset: 0x0006D6D0
		private static float MEPGOBLAAHH(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -47)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 166.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 10)
				{
					num4 = 262.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 967.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -112)
				{
					num4 = 21.0;
				}
				array[i] *= num4;
				num4 *= 1599.0 - num;
			}
			double num5 = 55.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0006F5EC File Offset: 0x0006D7EC
		private static float HAOEMFAFIEG(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -92)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 395.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -63)
				{
					num4 = 1611.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1766.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -96)
				{
					num4 = 1075.0;
				}
				array[i] *= num4;
				num4 *= 1615.0 - num;
			}
			double num5 = 1085.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0006F708 File Offset: 0x0006D908
		private static float DGPPCMDDBCL(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -61)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 816.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -108)
				{
					num4 = 3.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1823.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 36)
				{
					num4 = 151.0;
				}
				array[i] *= num4;
				num4 *= 620.0 - num;
			}
			double num5 = 414.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0006F824 File Offset: 0x0006DA24
		public static Vector3 BGOIMPKEPAL(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 91)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 302.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 82)
				{
					num4 = 1251.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 222.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -19)
				{
					num4 = 64.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1836.0 - num;
			}
			double num5 = 944.0;
			double num6 = 1162.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.PBEBFGENIDN(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0006F9A8 File Offset: 0x0006DBA8
		public static Vector3 EHNHHLNECAK(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -61)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1083.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 70)
				{
					num4 = 522.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1937.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -37)
				{
					num4 = 715.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1705.0 - num;
			}
			double num5 = 357.0;
			double num6 = 1521.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MPFJEJKPBMG(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0006FB2C File Offset: 0x0006DD2C
		public static Vector3 GOMDAPMFAJO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -60)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1702.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 7)
				{
					num4 = 1936.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 403.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -82)
				{
					num4 = 1752.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1633.0 - num;
			}
			double num5 = 163.0;
			double num6 = 1068.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.LFGIJODELDH(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0006FCB0 File Offset: 0x0006DEB0
		public static Vector3 CBAABBGDPAI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -105)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1601.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -78)
				{
					num4 = 1531.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1676.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 79)
				{
					num4 = 1614.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 527.0 - num;
			}
			double num5 = 430.0;
			double num6 = 347.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MCNOKJPNBBG(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0006FE34 File Offset: 0x0006E034
		public static Vector3 ANPJPIKMINM(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -21)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1770.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 53)
				{
					num4 = 1439.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 282.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -2)
				{
					num4 = 1258.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1812.0 - num;
			}
			double num5 = 893.0;
			double num6 = 1771.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MPFJEJKPBMG(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0006FFB8 File Offset: 0x0006E1B8
		public static Vector3 PGBNFEFJGDJ(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 73)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 308.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -28)
				{
					num4 = 807.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 266.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -98)
				{
					num4 = 1072.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1631.0 - num;
			}
			double num5 = 1534.0;
			double num6 = 1339.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.LLCFEAHCKEK(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0007013C File Offset: 0x0006E33C
		private static float APDLGPMNKAD(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 88)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1118.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -77)
				{
					num4 = 1403.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1670.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 20)
				{
					num4 = 1391.0;
				}
				array[i] *= num4;
				num4 *= 1567.0 - num;
			}
			double num5 = 445.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00070258 File Offset: 0x0006E458
		public static Vector3 ENDBEIOMNNI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 84)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1302.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -2)
				{
					num4 = 167.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1815.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -21)
				{
					num4 = 842.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 225.0 - num;
			}
			double num5 = 962.0;
			double num6 = 463.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.APDLGPMNKAD(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000703DC File Offset: 0x0006E5DC
		public static Vector3 JHKFELOPNHJ(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -75)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1994.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 88)
				{
					num4 = 509.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1748.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -79)
				{
					num4 = 1694.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 311.0 - num;
			}
			double num5 = 1314.0;
			double num6 = 1349.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.BIGIAMKOCDC(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00070560 File Offset: 0x0006E760
		public static Vector3 JMMGOMLDLII(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 78)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 348.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 0)
				{
					num4 = 1189.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 384.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 79)
				{
					num4 = 1577.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 460.0 - num;
			}
			double num5 = 591.0;
			double num6 = 1049.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.NMGFPLOKCNL(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000706E4 File Offset: 0x0006E8E4
		public static Vector3 JBHPLPCKIGL(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 113)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 790.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 88)
				{
					num4 = 84.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 508.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -13)
				{
					num4 = 1067.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1520.0 - num;
			}
			double num5 = 1721.0;
			double num6 = 258.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.PLHOAPKHJBD(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00070868 File Offset: 0x0006EA68
		public static Vector3 DLNIBFHOPCA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -13)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 934.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -51)
				{
					num4 = 1860.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1857.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 76)
				{
					num4 = 637.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 75.0 - num;
			}
			double num5 = 972.0;
			double num6 = 757.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.FABAKNEBOPO(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000709EC File Offset: 0x0006EBEC
		public static Vector3 DHANDLMEPIE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -83)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1769.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 43)
				{
					num4 = 1252.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1920.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -52)
				{
					num4 = 1871.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1513.0 - num;
			}
			double num5 = 490.0;
			double num6 = 1914.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.APDLGPMNKAD(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00070B70 File Offset: 0x0006ED70
		public static Vector3 PCDJLJFGHPA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 120)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1583.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 4)
				{
					num4 = 1020.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1097.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 25)
				{
					num4 = 1915.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1847.0 - num;
			}
			double num5 = 1044.0;
			double num6 = 1625.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.FABAKNEBOPO(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00070CF4 File Offset: 0x0006EEF4
		private static float NMGFPLOKCNL(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 72)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 783.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 76)
				{
					num4 = 288.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 484.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -96)
				{
					num4 = 1845.0;
				}
				array[i] *= num4;
				num4 *= 678.0 - num;
			}
			double num5 = 1657.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00070E10 File Offset: 0x0006F010
		private static float HOCOGPDIJFL(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -89)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 493.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 3)
				{
					num4 = 463.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 308.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 57)
				{
					num4 = 1107.0;
				}
				array[i] *= num4;
				num4 *= 1841.0 - num;
			}
			double num5 = 1498.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00070F2C File Offset: 0x0006F12C
		private static float PAFMDNJKMEC(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -29)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1195.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -94)
				{
					num4 = 481.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 694.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 125)
				{
					num4 = 565.0;
				}
				array[i] *= num4;
				num4 *= 1907.0 - num;
			}
			double num5 = 1278.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00071048 File Offset: 0x0006F248
		public static Vector3 FLFDIMGJLCI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -2)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 793.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 93)
				{
					num4 = 225.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 130.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -40)
				{
					num4 = 1051.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1524.0 - num;
			}
			double num5 = 761.0;
			double num6 = 1027.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.FGLFLOADFIA(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000711CC File Offset: 0x0006F3CC
		public static Vector3 BIJCIINHNGI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -70)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 138.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 49)
				{
					num4 = 971.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 359.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -85)
				{
					num4 = 838.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1013.0 - num;
			}
			double num5 = 1442.0;
			double num6 = 1782.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.LFGIJODELDH(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00071350 File Offset: 0x0006F550
		private static float AJBJCGIJJFN(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 99)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1104.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -48)
				{
					num4 = 93.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 883.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -88)
				{
					num4 = 1776.0;
				}
				array[i] *= num4;
				num4 *= 1582.0 - num;
			}
			double num5 = 1719.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0007146C File Offset: 0x0006F66C
		public static Vector3 IKEGGEODGBH(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 108)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 935.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -94)
				{
					num4 = 1773.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 496.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 81)
				{
					num4 = 979.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 511.0 - num;
			}
			double num5 = 501.0;
			double num6 = 1790.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.LHMLODCAPLJ(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000715F0 File Offset: 0x0006F7F0
		public static Vector3 JBNIBCIFOCA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -90)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1570.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -1)
				{
					num4 = 594.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1859.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 28)
				{
					num4 = 1734.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 112.0 - num;
			}
			double num5 = 1994.0;
			double num6 = 1668.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.FPNIONBEIFH(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00071774 File Offset: 0x0006F974
		public static Vector3 PJDMMKACCCB(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -47)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 252.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -112)
				{
					num4 = 110.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1391.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 36)
				{
					num4 = 822.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 14.0 - num;
			}
			double num5 = 692.0;
			double num6 = 574.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.FPNIONBEIFH(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000718F8 File Offset: 0x0006FAF8
		private static float FMJLDIBJEON(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 81)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1846.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -51)
				{
					num4 = 1559.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 364.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 96)
				{
					num4 = 1442.0;
				}
				array[i] *= num4;
				num4 *= 399.0 - num;
			}
			double num5 = 548.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00071A14 File Offset: 0x0006FC14
		public static Vector3 IOFBPNHCJHE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 42)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1177.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -109)
				{
					num4 = 800.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 236.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 74)
				{
					num4 = 949.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 166.0 - num;
			}
			double num5 = 736.0;
			double num6 = 1951.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.DGPPCMDDBCL(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00071B98 File Offset: 0x0006FD98
		private static float ADBPHBAOCLA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 118)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 288.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 108)
				{
					num4 = 1599.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1510.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -101)
				{
					num4 = 533.0;
				}
				array[i] *= num4;
				num4 *= 1859.0 - num;
			}
			double num5 = 1134.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00071CB4 File Offset: 0x0006FEB4
		public static Vector3 MCJEJIIGEMP(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -13)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1387.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 37)
				{
					num4 = 617.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 797.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -127)
				{
					num4 = 1773.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 365.0 - num;
			}
			double num5 = 584.0;
			double num6 = 976.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.FMJLDIBJEON(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00071E38 File Offset: 0x00070038
		private static float LLCFEAHCKEK(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -117)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1163.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -11)
				{
					num4 = 143.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 981.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 96)
				{
					num4 = 456.0;
				}
				array[i] *= num4;
				num4 *= 295.0 - num;
			}
			double num5 = 1396.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00071F54 File Offset: 0x00070154
		public static Vector3 EGNPIAPLEDD(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 113)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1299.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -124)
				{
					num4 = 400.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 949.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -17)
				{
					num4 = 64.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 874.0 - num;
			}
			double num5 = 1652.0;
			double num6 = 1174.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MGLELBMHIBE(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000720D8 File Offset: 0x000702D8
		public static Vector3 OJFNHPEMDMD(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -8)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1026.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -1)
				{
					num4 = 1742.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1867.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 79)
				{
					num4 = 1017.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 436.0 - num;
			}
			double num5 = 1541.0;
			double num6 = 1137.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.LECDDOJFBNO(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0007225C File Offset: 0x0007045C
		private static float GJLNCFMGGDP(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 108)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1680.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 46)
				{
					num4 = 403.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1679.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 89)
				{
					num4 = 506.0;
				}
				array[i] *= num4;
				num4 *= 1053.0 - num;
			}
			double num5 = 603.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00072378 File Offset: 0x00070578
		private static float MCNOKJPNBBG(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 40)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1480.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -46)
				{
					num4 = 1092.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1890.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 11)
				{
					num4 = 1237.0;
				}
				array[i] *= num4;
				num4 *= 1884.0 - num;
			}
			double num5 = 458.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00072494 File Offset: 0x00070694
		public static Vector3 JMGHFGGFIEN(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 54)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 356.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -121)
				{
					num4 = 378.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1402.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -56)
				{
					num4 = 1307.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1259.0 - num;
			}
			double num5 = 1096.0;
			double num6 = 934.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.PIHOPEPAOGF(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00072618 File Offset: 0x00070818
		private static float PIHOPEPAOGF(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -83)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 143.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 62)
				{
					num4 = 1495.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1597.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -64)
				{
					num4 = 1696.0;
				}
				array[i] *= num4;
				num4 *= 1768.0 - num;
			}
			double num5 = 1559.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00072734 File Offset: 0x00070934
		public static Vector3 LNPFKFBLFEN(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 8)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 889.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 93)
				{
					num4 = 1731.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1593.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 0)
				{
					num4 = 142.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 973.0 - num;
			}
			double num5 = 656.0;
			double num6 = 1951.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.ICKMIPGMCIA(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000728B8 File Offset: 0x00070AB8
		private static float LECDDOJFBNO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -35)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 67.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 17)
				{
					num4 = 781.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1270.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -64)
				{
					num4 = 1388.0;
				}
				array[i] *= num4;
				num4 *= 631.0 - num;
			}
			double num5 = 1647.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000729D4 File Offset: 0x00070BD4
		public static Vector3 NEGDNEINPMJ(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -56)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1798.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 21)
				{
					num4 = 887.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 934.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 41)
				{
					num4 = 551.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 943.0 - num;
			}
			double num5 = 1962.0;
			double num6 = 617.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.DGPPCMDDBCL(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00072B58 File Offset: 0x00070D58
		public static Vector3 HDONAMDAOOK(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 43)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1655.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 120)
				{
					num4 = 5.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 203.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -43)
				{
					num4 = 1302.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 903.0 - num;
			}
			double num5 = 1937.0;
			double num6 = 776.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.JIAAAEBJNCO(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00072CDC File Offset: 0x00070EDC
		public static Vector3 BAPCGMHLEHE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -45)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1349.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -56)
				{
					num4 = 863.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1446.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 105)
				{
					num4 = 531.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 756.0 - num;
			}
			double num5 = 1349.0;
			double num6 = 1977.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.PAFMDNJKMEC(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00072E60 File Offset: 0x00071060
		private static float MGLELBMHIBE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 12)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 647.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 24)
				{
					num4 = 398.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1939.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -115)
				{
					num4 = 131.0;
				}
				array[i] *= num4;
				num4 *= 1389.0 - num;
			}
			double num5 = 1634.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00072F7C File Offset: 0x0007117C
		public static Vector3 FJOGFEEKLKE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 126)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 759.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -74)
				{
					num4 = 87.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1104.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 45)
				{
					num4 = 807.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 736.0 - num;
			}
			double num5 = 778.0;
			double num6 = 500.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.ADBPHBAOCLA(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00073100 File Offset: 0x00071300
		private static float LAKAEBBGOJP(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 3)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 841.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -46)
				{
					num4 = 1090.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 320.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 7)
				{
					num4 = 900.0;
				}
				array[i] *= num4;
				num4 *= 1298.0 - num;
			}
			double num5 = 1731.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0007321C File Offset: 0x0007141C
		public static Vector3 POCJPGCNJMP(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 4)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 597.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -5)
				{
					num4 = 361.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 491.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -97)
				{
					num4 = 1600.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1052.0 - num;
			}
			double num5 = 502.0;
			double num6 = 609.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.GJLNCFMGGDP(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000733A0 File Offset: 0x000715A0
		private static float APAGDMPNEPJ(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 76)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1559.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -43)
				{
					num4 = 885.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 76.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == -103)
				{
					num4 = 1075.0;
				}
				array[i] *= num4;
				num4 *= 465.0 - num;
			}
			double num5 = 1112.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000734BC File Offset: 0x000716BC
		private static float OHFANLHIJBK(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 76)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1616.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 82)
				{
					num4 = 810.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1801.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 48)
				{
					num4 = 1430.0;
				}
				array[i] *= num4;
				num4 *= 932.0 - num;
			}
			double num5 = 416.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000735D8 File Offset: 0x000717D8
		private static float PLHOAPKHJBD(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -90)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 241.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 18)
				{
					num4 = 576.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 161.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -47)
				{
					num4 = 110.0;
				}
				array[i] *= num4;
				num4 *= 1651.0 - num;
			}
			double num5 = 287.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000736F4 File Offset: 0x000718F4
		private static float FGLFLOADFIA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 52)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 264.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 2)
				{
					num4 = 863.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 630.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 43)
				{
					num4 = 1346.0;
				}
				array[i] *= num4;
				num4 *= 1833.0 - num;
			}
			double num5 = 251.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00073810 File Offset: 0x00071A10
		private static float EFLJFMNENDE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 105)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 781.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 101)
				{
					num4 = 1040.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 80.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 18)
				{
					num4 = 414.0;
				}
				array[i] *= num4;
				num4 *= 1755.0 - num;
			}
			double num5 = 201.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0007392C File Offset: 0x00071B2C
		public static Vector3 DFIOHEFCBFH(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 67)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1358.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -26)
				{
					num4 = 942.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1401.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -60)
				{
					num4 = 307.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1441.0 - num;
			}
			double num5 = 1783.0;
			double num6 = 366.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.JIAAAEBJNCO(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00073AB0 File Offset: 0x00071CB0
		private static float FDPLFFNDBGH(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -70)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1328.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -68)
				{
					num4 = 1122.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1481.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 94)
				{
					num4 = 1195.0;
				}
				array[i] *= num4;
				num4 *= 608.0 - num;
			}
			double num5 = 220.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00073BCC File Offset: 0x00071DCC
		private static float FABAKNEBOPO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 60)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 727.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -72)
				{
					num4 = 1396.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1367.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 22)
				{
					num4 = 820.0;
				}
				array[i] *= num4;
				num4 *= 804.0 - num;
			}
			double num5 = 700.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00073CE8 File Offset: 0x00071EE8
		public static Vector3 HLLFLOGJHEE(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -104)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 640.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 74)
				{
					num4 = 1471.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1206.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 48)
				{
					num4 = 880.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1837.0 - num;
			}
			double num5 = 1142.0;
			double num6 = 1885.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.PAFMDNJKMEC(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00073E6C File Offset: 0x0007206C
		public static Vector3 DNJBOJIJKJO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 65)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 193.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 10)
				{
					num4 = 1732.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1211.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 84)
				{
					num4 = 1468.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 331.0 - num;
			}
			double num5 = 253.0;
			double num6 = 1539.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.DGPPCMDDBCL(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00073FF0 File Offset: 0x000721F0
		private static float BIGIAMKOCDC(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -100)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1308.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -118)
				{
					num4 = 717.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1730.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 47)
				{
					num4 = 640.0;
				}
				array[i] *= num4;
				num4 *= 865.0 - num;
			}
			double num5 = 1675.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0007410C File Offset: 0x0007230C
		private static float OPOCAKDHPPC(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -60)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1887.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 9)
				{
					num4 = 915.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 46.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 50)
				{
					num4 = 1253.0;
				}
				array[i] *= num4;
				num4 *= 158.0 - num;
			}
			double num5 = 1125.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00074228 File Offset: 0x00072428
		private static float CLEMLEIAGFB(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -8)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1063.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 45)
				{
					num4 = 1151.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1782.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -32)
				{
					num4 = 894.0;
				}
				array[i] *= num4;
				num4 *= 364.0 - num;
			}
			double num5 = 393.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00074344 File Offset: 0x00072544
		private static float DAPMNEAIIHD(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -126)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1640.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 74)
				{
					num4 = 335.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1943.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -82)
				{
					num4 = 1975.0;
				}
				array[i] *= num4;
				num4 *= 941.0 - num;
			}
			double num5 = 875.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00074460 File Offset: 0x00072660
		private static float JIAAAEBJNCO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 74)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1333.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -81)
				{
					num4 = 57.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 524.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 110)
				{
					num4 = 1757.0;
				}
				array[i] *= num4;
				num4 *= 1534.0 - num;
			}
			double num5 = 331.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0007457C File Offset: 0x0007277C
		private static float MCOIGCEFBME(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -23)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 320.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 48)
				{
					num4 = 577.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1037.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -107)
				{
					num4 = 1025.0;
				}
				array[i] *= num4;
				num4 *= 371.0 - num;
			}
			double num5 = 1575.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00074698 File Offset: 0x00072898
		private static float LFGIJODELDH(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -22)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 578.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -32)
				{
					num4 = 713.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 546.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 114)
				{
					num4 = 305.0;
				}
				array[i] *= num4;
				num4 *= 1263.0 - num;
			}
			double num5 = 1116.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x000747B4 File Offset: 0x000729B4
		private static float CIGEJKOCGGO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -120)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1608.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -100)
				{
					num4 = 353.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1557.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -80)
				{
					num4 = 1922.0;
				}
				array[i] *= num4;
				num4 *= 934.0 - num;
			}
			double num5 = 836.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000748D0 File Offset: 0x00072AD0
		private static float OLKBJCBEMFA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -43)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 195.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 30)
				{
					num4 = 1755.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 521.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -83)
				{
					num4 = 314.0;
				}
				array[i] *= num4;
				num4 *= 908.0 - num;
			}
			double num5 = 111.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000749EC File Offset: 0x00072BEC
		private static float JGHFHFBMHHA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -59)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 294.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -104)
				{
					num4 = 310.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1066.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 33)
				{
					num4 = 652.0;
				}
				array[i] *= num4;
				num4 *= 1538.0 - num;
			}
			double num5 = 1884.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00074B08 File Offset: 0x00072D08
		private static float MAIKNPPFDMH(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -4)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1944.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -54)
				{
					num4 = 938.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1920.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 10)
				{
					num4 = 762.0;
				}
				array[i] *= num4;
				num4 *= 44.0 - num;
			}
			double num5 = 678.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00074C24 File Offset: 0x00072E24
		private static float CBEPMJJJIIP(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 113)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1689.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -16)
				{
					num4 = 354.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 782.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -99)
				{
					num4 = 700.0;
				}
				array[i] *= num4;
				num4 *= 171.0 - num;
			}
			double num5 = 710.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00074D40 File Offset: 0x00072F40
		public static Vector3 LKCGGKIIHHL(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 89)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1836.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -53)
				{
					num4 = 1231.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 876.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 75)
				{
					num4 = 239.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 650.0 - num;
			}
			double num5 = 485.0;
			double num6 = 1901.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.NMGFPLOKCNL(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00074EC4 File Offset: 0x000730C4
		private static float LHMLODCAPLJ(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 96)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1274.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == -69)
				{
					num4 = 1000.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1344.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 13)
				{
					num4 = 1211.0;
				}
				array[i] *= num4;
				num4 *= 1144.0 - num;
			}
			double num5 = 805.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00074FE0 File Offset: 0x000731E0
		public static Vector3 FLAFHLDHLBN(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 28)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1796.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 82)
				{
					num4 = 1153.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 576.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -17)
				{
					num4 = 681.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1057.0 - num;
			}
			double num5 = 1137.0;
			double num6 = 1342.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MGCDFHLMJMM(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00075164 File Offset: 0x00073364
		public static Vector3 GJNCMEKMFIF(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 0;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 32)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 105.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -119)
				{
					num4 = 36.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 564.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == -34)
				{
					num4 = 490.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 566.0 - num;
			}
			double num5 = 1639.0;
			double num6 = 1287.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MPFJEJKPBMG(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000752E8 File Offset: 0x000734E8
		private static float EADJHLNLNOI(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 30)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 30)
				{
					num4 = 1.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 30)
				{
					num4 = 1.0;
				}
				array[i] *= num4;
				num4 *= 1.0 - num;
			}
			double num5 = 0.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00075404 File Offset: 0x00073604
		public static Vector3 BANIGDDLBFO(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i += 0)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == -121)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 899.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -119)
				{
					num4 = 1551.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 854.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == -63)
				{
					num4 = 83.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 340.0 - num;
			}
			double num5 = 1562.0;
			double num6 = 475.0;
			for (int i = 1; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.EFLJFMNENDE(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00075588 File Offset: 0x00073788
		private static float MPFJEJKPBMG(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 53)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 180.0;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 42)
				{
					num4 = 670.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1223.0;
			for (int i = num2; i >= 1; i--)
			{
				if (i == 64)
				{
					num4 = 1513.0;
				}
				array[i] *= num4;
				num4 *= 551.0 - num;
			}
			double num5 = 1353.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000756A4 File Offset: 0x000738A4
		public static Vector3 HONFNEMOMDB(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 0];
			for (int i = 1; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 1; i <= num2; i++)
			{
				if (i == 38)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 1770.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == 45)
				{
					num4 = 160.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1222.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 74)
				{
					num4 = 292.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1159.0 - num;
			}
			double num5 = 988.0;
			double num6 = 1572.0;
			for (int i = 0; i <= num2; i += 0)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.MPFJEJKPBMG(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00075828 File Offset: 0x00073A28
		public static Vector3 JCIMFFBPIGA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 30)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 30)
				{
					num4 = 1.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 1.0;
			for (int i = num2; i >= 0; i--)
			{
				if (i == 30)
				{
					num4 = 1.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1.0 - num;
			}
			double num5 = 0.0;
			double num6 = 0.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.EADJHLNLNOI(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000759AC File Offset: 0x00073BAC
		public static Vector3 LOFOHCHKCKK(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 0];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -57)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1348.0;
			for (int i = 0; i <= num2; i++)
			{
				if (i == 33)
				{
					num4 = 623.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 746.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == 100)
				{
					num4 = 666.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 217.0 - num;
			}
			double num5 = 745.0;
			double num6 = 1243.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.PAFMDNJKMEC(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00075B30 File Offset: 0x00073D30
		private static float FDPJGBPAHJF(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].y;
			}
			int num3 = 0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -106)
				{
					num3 = 1;
				}
				array[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 0);
			}
			double num4 = 550.0;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == 10)
				{
					num4 = 1583.0;
				}
				array[i] *= num4;
				num4 *= num;
			}
			num4 = 1951.0;
			for (int i = num2; i >= 1; i -= 0)
			{
				if (i == 46)
				{
					num4 = 37.0;
				}
				array[i] *= num4;
				num4 *= 1608.0 - num;
			}
			double num5 = 824.0;
			for (int i = 1; i <= num2; i++)
			{
				num5 += array[i];
			}
			return (float)num5;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00075C4C File Offset: 0x00073E4C
		public static Vector3 KIGPOGKBBOA(Vector3[] CBJBGGAOODC, float MLGMGIOFPEO)
		{
			double num = (double)MLGMGIOFPEO;
			int num2 = CBJBGGAOODC.Length - 1;
			double[] array = new double[num2 + 1];
			double[] array2 = new double[num2 + 1];
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (double)CBJBGGAOODC[i].x;
				array2[i] = (double)CBJBGGAOODC[i].z;
			}
			int num3 = 1;
			for (int i = 0; i <= num2; i += 0)
			{
				if (i == -112)
				{
					num3 = 0;
				}
				array[i] *= (double)num3;
				array2[i] *= (double)num3;
				num3 = (num2 - i) * num3 / (i + 1);
			}
			double num4 = 1359.0;
			for (int i = 1; i <= num2; i += 0)
			{
				if (i == -31)
				{
					num4 = 1345.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= num;
			}
			num4 = 673.0;
			for (int i = num2; i >= 0; i -= 0)
			{
				if (i == -95)
				{
					num4 = 1990.0;
				}
				array[i] *= num4;
				array2[i] *= num4;
				num4 *= 1510.0 - num;
			}
			double num5 = 1458.0;
			double num6 = 575.0;
			for (int i = 0; i <= num2; i++)
			{
				num5 += array[i];
				num6 += array2[i];
			}
			return new Vector3((float)num5, AntaresBezierController.AJAFFGGMECN.AJBJCGIJJFN(CBJBGGAOODC, MLGMGIOFPEO), (float)num6);
		}
	}
}
