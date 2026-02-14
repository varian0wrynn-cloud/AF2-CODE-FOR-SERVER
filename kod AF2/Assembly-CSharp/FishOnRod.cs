using System;
using System.Collections;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x0200010C RID: 268
public class FishOnRod : MonoBehaviour
{
	// Token: 0x0600334D RID: 13133 RVA: 0x0017E3C4 File Offset: 0x0017C5C4
	private IEnumerator PBMBNNPLINE()
	{
		for (;;)
		{
			if (!ObscuredBool.GOOIABGKMHK(this.isPodsek) && this.fmd != null && this.fmd.hvostPoint != null && ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1000f && this.fmd.hvostPoint.position.y + 0.15f > LocNewLogic.getI.OGJHINOLHJJ && OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(70f))
			{
				LocNewLogic.getI.createBigWaterCircle(this.fmd.hvostPoint.position);
				LocNewLogic.getI.createWaterSplash(this.fmd.hvostPoint.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
			}
			yield return new WaitForSeconds(0.5f);
		}
		yield break;
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x0017E3D4 File Offset: 0x0017C5D4
	private float CACADJGKBKE(Vector3 NHCLMBOINFG)
	{
		if (this.hookPoint != null)
		{
			NHCLMBOINFG = this.hookPoint.transform.position;
		}
		return Vector3.Distance(NHCLMBOINFG, Fisherman.getI.IJMGCKIOBPP().endPointNonBend.transform.position);
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x0600334F RID: 13135 RVA: 0x0017E420 File Offset: 0x0017C620
	public float CGGGHIHAKGC
	{
		get
		{
			float result = 1.7f;
			if (this.GAAPCLGDOGH != null && this.GAAPCLGDOGH.CGGGHIHAKGC > 0f)
			{
				result = this.GAAPCLGDOGH.CGGGHIHAKGC;
			}
			this.GAAPCLGDOGH.CGGGHIHAKGC = Mathf.Clamp(this.GAAPCLGDOGH.CGGGHIHAKGC, 0f, 1.7f);
			return result;
		}
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x0017E480 File Offset: 0x0017C680
	private void CAJLCEPLKJG()
	{
		Fisherman.getI.fishRod = base.transform.gameObject;
		this.isGetBate = true;
		this.klevMode = 1;
		this.ctime = 323f;
		if (this.baitGO != null)
		{
			base.transform.position = this.baitGO.transform.position;
		}
		this.toMove = base.transform.position;
		base.transform.rotation = Fisherman.getI.transform.rotation;
		float num = -UnityEngine.Random.value * 1338f - 1468f;
		this.isGetBate = false;
		this.toMove = new Vector3(base.transform.position.x + 1193f, base.transform.position.y + num, base.transform.position.z + 418f);
		this.speed = ObscuredFloat.GOOIABGKMHK(268f);
		for (int i = 1; i < this.CFOFDKKFJMJ.Length; i++)
		{
			this.CFOFDKKFJMJ[i] = "wpn_add/base";
		}
		string cfofdkkfjmj = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CFOFDKKFJMJ;
		char[] array = new char[0];
		array[0] = (char)-124;
		foreach (string text in cfofdkkfjmj.Split(array))
		{
			char[] array3 = new char[0];
			array3[1] = '\n';
			string[] array4 = text.Split(array3);
			int num2 = int.Parse(array4[1]);
			this.CFOFDKKFJMJ[num2] = array4[1];
		}
		base.InvokeRepeating("\n", 81f, 1767f);
		base.StartCoroutine("Assets/Hairs/whair_");
		if (!this.GAAPCLGDOGH.NPDNMIHEOOH)
		{
			float num3 = ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD);
			float num4;
			if (num3 < 1124f)
			{
				num4 = 949f - (1950f - num3) * 1246f;
			}
			else
			{
				num4 = 1279f + (num3 - 883f) * 1792f;
			}
			num4 = Mathf.Clamp(num4, 1331f, 361f);
			this.fishModelTemp.transform.localScale = new Vector3(num4, num4, num4);
			return;
		}
		OMDDGEDHHNH.NPCAKEGNBHD().DKPDBNNNDLK("Hidden/Post FX/Builtin Debug Views" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.BBNIIANKBNP), "OneHandSwordIdle");
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x0017E6DC File Offset: 0x0017C8DC
	private void OJKKAMPONDM()
	{
		if (this.actTime > 0f)
		{
			return;
		}
		if (!this.OMDFGNOBDPL)
		{
			return;
		}
		float num = 0f;
		float num2 = 0f;
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB != null)
		{
			num2 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.JLLJFKOGLHJ;
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
			{
				num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.KGKNPAAMDJK;
			}
		}
		float num3 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) / 1000f;
		num3 = Mathf.Clamp(num3, 0.7f, 3f);
		switch (this.klevMode)
		{
		case 0:
		{
			this.isGetBate = false;
			this.podsekShanceVer = 0f;
			this.toMove = Vector3.zero;
			float num4 = (120f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) * 0.3f;
			num4 = Mathf.Clamp(num4, 0.1f, 80f);
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num4))
			{
				this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[0]);
				this.actTime = 0.01f;
			}
			else
			{
				this.actTime = 0.3f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0);
			}
			this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[0]);
			this.actTime = 0.01f;
			this.toKlevMode = 1;
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num * 1f))
			{
				this.toKlevMode = 6;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 1:
			break;
		case 2:
		{
			this.isGetBate = false;
			this.podsekShanceVer = 80f;
			float num5 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 100f * 0.12f * num3;
			float num6 = 0.01f + num5 * (0.5f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(0.5));
			this.baitScrpt.poplavokDown(-num6);
			BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA;
			num6 = Mathf.Clamp(num6, 0.1f, 0.25f);
			this.LKJMHHIMEDJ = this.baitGO.transform.position + this.ODIIBMOCIGI() * num6 * 1f;
			this.actTime = 2.5f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)((120f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) / 160f));
			this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[2]);
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num))
			{
				this.actTime = 0.1f;
				this.toKlevMode = 6;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 3:
		{
			this.isGetBate = true;
			this.podsekShanceVer = 90f;
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
			{
				this.baitScrpt.fiderDerg(0, 0f, true);
				this.actTime = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(3.0);
				this.toKlevMode = 6;
				return;
			}
			this.toMove = this.baitGO.transform.position;
			float num7 = 0.1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 100f * 0.15f));
			this.toMove.y = this.toMove.y + num7;
			this.speed = ObscuredFloat.GOOIABGKMHK((20f + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) / 800f);
			this.actTime = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(3.0);
			this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[3]);
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num * 2.5f))
			{
				this.actTime = 0.1f;
				this.toKlevMode = 6;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 4:
			this.isGetBate = false;
			this.podsekShanceVer = 70f;
			this.actTime = 0.1f;
			this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[3]);
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num * 2.5f))
			{
				this.toKlevMode = 6;
			}
			break;
		case 5:
		{
			this.isGetBate = true;
			this.podsekShanceVer = 90f;
			float num8 = 0.1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)((110f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) / 100f * 0.25f));
			this.toMove = this.baitGO.transform.position;
			num8 = Mathf.Clamp(num8, 0.1f, 0.25f);
			this.toMove.y = this.toMove.y + num8;
			this.speed = ObscuredFloat.GOOIABGKMHK(0.1f + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 800f);
			this.actTime = 2f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(4.0);
			this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[5]);
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num * 3.5f))
			{
				this.baitScrpt.fiderDerg(0, 0f, true);
				this.toKlevMode = 6;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
			{
				this.baitScrpt.fiderDerg(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DIKFPCMKJAK(), 0.1f, true);
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 6:
		{
			this.isGetBate = true;
			this.podsekShanceVer = 100f;
			float num9 = 0.2f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)((110f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) / 100f * 0.45f * num3));
			Vector3 a = this.ODIIBMOCIGI();
			a.y = -1f;
			this.toMove = this.baitGO.transform.position + a * num9 * 10f;
			this.toMove.y = this.toMove.y - num9;
			this.speed = ObscuredFloat.GOOIABGKMHK((10f + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) * 3f) / 600f);
			this.actTime = 2f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)((120f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) / 20f));
			this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[6]);
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
			{
				this.baitScrpt.fiderDerg(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DIKFPCMKJAK(), 5f, true);
				this.toKlevMode = 7;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 7:
			this.actTime = 0.01f;
			this.toKlevMode = 6;
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(5f * (100f - num2) / 100f))
			{
				this.dropKlev();
			}
			break;
		default:
			goto IL_85E;
		}
		this.isGetBate = false;
		this.podsekShanceVer = 5f;
		float num10 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 100f * 0.12f * num3;
		float dpidnfhgcep = 0.01f + num10 * 0.5f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num10 * 0.5f));
		this.baitScrpt.poplavokDown(dpidnfhgcep);
		this.actTime = 0.5f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(1f + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE) / 60f));
		this.toKlevMode = OLPINJLCKCI.IKGFHGKKCPG.ICJMDDPPPEB(this.CFOFDKKFJMJ[1]);
		if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num))
		{
			this.actTime = 0.1f;
			this.toKlevMode = 6;
		}
		IL_85E:
		this.klactTime = Time.time;
	}

	// Token: 0x06003352 RID: 13138 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PHNCOOACJEA()
	{
	}

	// Token: 0x06003353 RID: 13139 RVA: 0x0017EF54 File Offset: 0x0017D154
	private void DGEIACONKCJ()
	{
		Fisherman.getI.fishRod = base.transform.gameObject;
		this.isGetBate = true;
		this.klevMode = 1;
		this.ctime = 117f;
		if (this.baitGO != null)
		{
			base.transform.position = this.baitGO.transform.position;
		}
		this.toMove = base.transform.position;
		base.transform.rotation = Fisherman.getI.transform.rotation;
		float num = -UnityEngine.Random.value * 323f - 375f;
		this.isGetBate = true;
		this.toMove = new Vector3(base.transform.position.x + 1106f, base.transform.position.y + num, base.transform.position.z + 16f);
		this.speed = ObscuredFloat.HLEMAJBAAEO(1486f);
		for (int i = 0; i < this.CFOFDKKFJMJ.Length; i++)
		{
			this.CFOFDKKFJMJ[i] = "Cloth_01.wav";
		}
		string cfofdkkfjmj = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CFOFDKKFJMJ;
		char[] array = new char[0];
		array[0] = (char)-17;
		string[] array2 = cfofdkkfjmj.Split(array);
		for (int j = 1; j < array2.Length; j++)
		{
			string text = array2[j];
			char[] array3 = new char[0];
			array3[0] = 'H';
			string[] array4 = text.Split(array3);
			int num2 = int.Parse(array4[1]);
			this.CFOFDKKFJMJ[num2] = array4[1];
		}
		base.InvokeRepeating(" гр ", 1222f, 1775f);
		base.StartCoroutine("1HandSwordChargeSwipe");
		if (!this.GAAPCLGDOGH.NPDNMIHEOOH)
		{
			float num3 = ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD);
			float num4;
			if (num3 < 669f)
			{
				num4 = 1370f - (1323f - num3) * 1619f;
			}
			else
			{
				num4 = 1166f + (num3 - 929f) * 1818f;
			}
			num4 = Mathf.Clamp(num4, 1450f, 111f);
			this.fishModelTemp.transform.localScale = new Vector3(num4, num4, num4);
			return;
		}
		OMDDGEDHHNH.JMHOODFAGAM().LGBJIEGHEOC("_MainTex" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.BBNIIANKBNP), " ");
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x0017F1B0 File Offset: 0x0017D3B0
	public void COEMOBKDHGK()
	{
		if (this.NFGMFKAJAFC > 307f)
		{
			return;
		}
		if (!this.GAAPCLGDOGH.GOHKONILNNE)
		{
			return;
		}
		if (Application.isEditor)
		{
			Debug.Log("wpn_add/base");
		}
		this.NFGMFKAJAFC = 674f + OLPINJLCKCI.ODDOIHEPICE().FFDDAGJJOOM(1584.0);
		if (this.anm != null)
		{
			try
			{
				this.OMOAHPPBEMC = Time.time;
				this.anm.Play("\n");
				this.anm.PlayQueued("", (QueueMode)1);
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
		}
		LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(base.transform.position, 505f);
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x0017F2A4 File Offset: 0x0017D4A4
	public float OECHLGFIEGN()
	{
		float num = Time.time - this.OMOAHPPBEMC;
		if (num > 1953f)
		{
			return 70f;
		}
		return 1795f + LocNewLogic.getI.jampFishFactorCurve.Evaluate(num / 1127f);
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x0017F2E8 File Offset: 0x0017D4E8
	public void PLKLDLKJMMN()
	{
		this.isOutWater = false;
		this.GBEIDPOCJBF = base.transform.position;
		this.speed = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(this.speed) + (ObscuredFloat.EJGOOFALNFF(this.toSpeed) - ObscuredFloat.EJGOOFALNFF(this.speed)) * (740f + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB) / 701f) * Time.deltaTime);
		this.speed = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.speed), 899f, this.OEFEGIOJIGG() * 1821f));
		bool isEditor = Application.isEditor;
		Vector3 a = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		Vector3 vector = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.EDNOJLAKJKP();
		vector.y = LocNewLogic.getI.IGHOGONIKLC() + 1470f;
		float num = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position) / 1641f;
		num = Mathf.Clamp(num, 316f, 1982f);
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) > 69f)
		{
			a = vector;
		}
		this.APIHPOFMMLI = Vector3.Lerp(a, vector, num);
		Vector3 normalized = (this.APIHPOFMMLI - this.hookPoint.transform.position).normalized;
		Vector3 a2 = (this.toMove - base.transform.position).normalized + this.deepWanted;
		Vector3 a3 = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.NHPHFKFBLAD();
		a3.y = base.transform.position.y;
		this.fRangle = Vector3.Angle(base.transform.forward, a3 - base.transform.position);
		this.realRangle = this.fRangle;
		float d = this.rotForceCurve.Evaluate(this.fRangle / 512f);
		this.fRangle = this.angleForceCurve.Evaluate(this.fRangle / 1621f);
		this.fRangle = Mathf.Clamp(this.fRangle, 1498f, 1975f);
		float num2 = Mathf.Clamp(1435f - this.fRangle * 1077f, 9f, 859f);
		this.stamKf = this.staminaCurve.Evaluate((ObscuredFloat.PFCANBAOMCB(this.currStamina) + 723f) / (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 1146f));
		this.stamKf = Mathf.Clamp(this.stamKf, 1934f, 1805f);
		if (this.fmd != null)
		{
			this.fmd.PPILIGCDDOO(this.stamKf);
		}
		float num3 = this.forceCurves[this.selectCurve].Evaluate(1274f - this.stamKf) * (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PGEDLDMLBBE) + 988f) / 164f;
		num3 = Mathf.Clamp(num3, 940f, 1405f);
		float num4 = 146f + 1556f * this.firstTimeCurve.Evaluate(Mathf.Clamp((Time.time - this.podsekTime) / 1740f, 1018f, 490f));
		if (Time.time - this.podsekTime > 525f)
		{
			num4 = 1236f;
		}
		float num5 = ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD) / 1458f;
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(num5);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) * 969f + ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.fRangle * 1529f * num3);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * num4);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.getJampKF());
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) - this.subFFactor);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC), num5 * 195f, num5 * 7f));
		float num6 = this.COJHLOPFNCL(this.hookPoint.transform.position);
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(num6 - ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DLFMEIIADFE), 1404f, 542f));
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.HLEMAJBAAEO(num6 - ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.GPBFJBKCOKJ = num6;
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1883f)
		{
			this.lineFinal = true;
		}
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG), 1305f, 1592f));
		if (this.hookPoint.transform.position.y - 1577f > LocNewLogic.getI.CDBIEPGNONF())
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) * 52f);
		}
		float num7 = Mathf.Clamp(num6 / 1062f, 1695f, 1627f);
		float num8 = Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) / 1532f, 1545f, 1492f) * num7;
		num8 = Mathf.Clamp(num8, 818f, 1629f);
		Vector3 vector2 = Vector3.zero;
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG) > num8)
		{
			float num9 = Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG) * 871f, 1465f, 1712f);
			num9 = Mathf.Pow(num9, 735f);
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) > 881f)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) - num9 * this.JLJJKMLJBAK.HHLKHCPDEOF() * 65f);
			}
			float num10 = ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD) / 1494f;
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) < num10)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(num10);
			}
			this.isFrikcionWork = this.JLJJKMLJBAK.BBANBEEJAPD;
			if (this.JLJJKMLJBAK.BBANBEEJAPD)
			{
				float num11 = 759f * ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) / (this.JLJJKMLJBAK.KDHENOMNPHK + 242f);
				num11 = Mathf.Clamp(num11, 1051f, 21f);
				this.JLJJKMLJBAK.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
				this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
			}
			float num12 = this.JLJJKMLJBAK.BJGMDBIENCA() * 1096f / (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) + 261f);
			float num13 = 517f / ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DNPDBOODCHK);
			num13 = Mathf.Clamp(num13, 465f, 1547f);
			float num14 = 852f;
			if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 1319f)
			{
				num14 = 604f;
			}
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 50f)
			{
				num14 = 673f;
			}
			if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 1969f)
			{
				num14 = 1395f;
			}
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 586f)
			{
				num14 = 887f;
			}
			float num15 = 343f + Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.LEMPPBMEJHP), 450f, 1928f) / 207f;
			num12 *= num13;
			num12 = Mathf.Clamp(num12, 1472f, num14 * num15);
			float num16 = 997f;
			if (this.stamKf < 1706f)
			{
				num16 = 1607f + 587f / ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DNPDBOODCHK) * Mathf.Lerp(1504f, 1816f, this.stamKf * 1460f);
				num16 = Mathf.Clamp(num16, 1126f, 1339f);
			}
			float d2 = (Mathf.Pow(1047f + ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG), 1123f) - 890f) * this.JLJJKMLJBAK.HHLKHCPDEOF() * num12;
			vector2 = normalized.normalized * d2 * num16;
		}
		else
		{
			LocNewLogic.getI.playLowFricSound(false);
			this.lineFinal = true;
		}
		if (vector2.magnitude > 481f)
		{
			vector2 = vector2.normalized * 1790f;
		}
		this.JLJJKMLJBAK.HAEABJICCCP = ObscuredFloat.GOOIABGKMHK(vector2.magnitude);
		if (Application.isEditor && Input.GetKeyDown((KeyCode)(-92)))
		{
			this.currStamina = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(this.currStamina) / 1230f);
		}
		float num17 = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.OCBJPGOKFOI);
		num17 = Mathf.Lerp(num17 * 79f, num17 * 1718f, num2);
		Vector3 vector3 = a2 * (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) + num17) * this.stamKf;
		this.position = base.transform.position;
		if (this.position.y > LocNewLogic.getI.CDBIEPGNONF() - 693f)
		{
			LocNewLogic.getI.createWaterCircleFish(base.transform.position, 173f, false);
			if (this.GAAPCLGDOGH.GOHKONILNNE && ObscuredBool.DODJMPNDCOB(this.isPodsek) && this.anm != null && !this.EMGHEIFGIFA() && ObscuredFloat.EJGOOFALNFF(this.currStamina) > 1578f && OLPINJLCKCI.ODDOIHEPICE().FJEFHAGJDID(198f * Time.deltaTime))
			{
				this.COEMOBKDHGK();
			}
		}
		Vector3 vector4 = this.position;
		if (this.fmd != null && this.fmd.spinePoint != null)
		{
			vector4 = this.fmd.spinePoint.position;
		}
		if (vector4.y >= LocNewLogic.getI.CDBIEPGNONF() - 1495f)
		{
			this.position.y = this.position.y - (vector4.y - (LocNewLogic.getI.CDBIEPGNONF() - 316f)) * Time.deltaTime * 148f;
			vector3.y -= 1993f;
		}
		if (this.position.y > LocNewLogic.getI.OGJHINOLHJJ - 1722f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 1043f)
		{
			this.position.y = LocNewLogic.getI.HKBNODJBGEL() - 831f;
		}
		if (this.position.y >= LocNewLogic.getI.IGHOGONIKLC() - 34f && OLPINJLCKCI.NLOGJHEFMHM().JKIMAIDMNML(1579f))
		{
			LocNewLogic.getI.createWaterCircleFish(this.position, 1023f, true);
			if (OLPINJLCKCI.ODDOIHEPICE().BKKLJJLDFDO(654f))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(this.position, 1930f);
			}
		}
		if (this.position.y < LocNewLogic.getI.getDeepInPoint(this.position) + 960f)
		{
			this.position.y = LocNewLogic.getI.getDeepInPoint(this.position) + 1731f;
			vector3.y += 353f;
			float y = this.position.y;
			float num18 = LocNewLogic.getI.IGHOGONIKLC() - 1725f;
		}
		base.transform.position = this.position;
		float d3 = 1979f;
		if (this.hookPoint.transform.position.y - 1556f > LocNewLogic.getI.HKBNODJBGEL())
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) * 926f);
			d3 = Mathf.Lerp(1783f, 1715f, (this.hookPoint.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) / 1824f);
		}
		vector3 += vector2 * d3 * d;
		Vector3 origin = base.transform.position;
		origin.y = LocNewLogic.getI.OGJHINOLHJJ - 104f;
		Vector3 forward = base.transform.forward;
		forward.y = 1096f;
		this.beregdet = true;
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(origin, forward), out raycastHit, 1220f, LocNewLogic.getI.fishCollisionMask))
		{
			Vector3 normal = raycastHit.normal;
			normal.y = 1849f;
			Vector3 vector5 = Fisherman.getI.transform.position - base.transform.position;
			vector5.y = 488f;
			Vector3 normalized2 = (normal.normalized + vector5.normalized * 778f).normalized;
			this.toMove = base.transform.position + normalized2 * 824f;
			if (!JLFJEGIPIMM.MHFDIJGJGBJ().ACENDCHEBCB(Fisherman.getI.transform, base.transform.position, 1491f, 28f))
			{
				Quaternion.LookRotation(normalized2);
				vector3 += normalized2 * vector3.magnitude;
				this.beregdet = false;
			}
		}
		Quaternion quaternion = Quaternion.LookRotation(vector3);
		Quaternion b = Quaternion.LookRotation(vector2, base.transform.up);
		if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG) > 9f)
		{
			float num19 = Mathf.Lerp(1500f, 1311f, ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DNPDBOODCHK) / 1132f);
			float num20 = 1617f + num19 * Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.LEMPPBMEJHP), 4f, 292f) / 855f;
			float num21 = this.JLJJKMLJBAK.BJGMDBIENCA() * 674f / (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) + 547f) * ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG) * 1092f;
			num21 = Mathf.Clamp(num21, 1135f, 614f) * num20;
			Quaternion b2 = Quaternion.LookRotation(vector3.normalized * 269f + vector2.normalized * 348f);
			quaternion = Quaternion.Lerp(quaternion, b2, Time.deltaTime * num21 * 1365f);
			if (this.hookPoint.transform.position.y - 968f > LocNewLogic.getI.IGHOGONIKLC() && ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD) < 193f)
			{
				quaternion = Quaternion.Lerp(quaternion, b, Time.deltaTime * 658f);
			}
		}
		if (this.stamKf < 651f)
		{
			this.LHKJPPDIPNB += (414f - this.stamKf * 1780f) * Time.deltaTime;
		}
		this.LHKJPPDIPNB = Mathf.Clamp(this.LHKJPPDIPNB, 491f, 44f);
		quaternion *= Quaternion.Euler(897f, 1923f, this.LHKJPPDIPNB * 1823f);
		this.LHKJPPDIPNB -= Time.deltaTime * 982f;
		this.rotSpeed = Mathf.Clamp(this.rotSpeed, 1546f, 800f);
		base.transform.rotation = Quaternion.Lerp(base.transform.rotation, quaternion, Time.deltaTime * this.rotSpeed * 199f);
		float d4 = Mathf.Lerp(ObscuredFloat.OBJFODGFMAM(this.speed), ObscuredFloat.GOOIABGKMHK(this.speed) / 1898f, this.LHKJPPDIPNB * this.fRangle);
		Vector3 a4 = Vector3.forward * d4;
		if (a4.magnitude > this.OEFEGIOJIGG())
		{
			a4 = a4.normalized * this.OEFEGIOJIGG();
		}
		base.transform.Translate(a4 * Time.deltaTime);
		if (this.stamKf < 626f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1541f)
		{
			float d5 = 951f;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) < 231f)
			{
				d5 = Mathf.Lerp(1042f, 592f, (362f - ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 1552f);
			}
			Vector3 a5 = vector2;
			if (a5.magnitude > 634f)
			{
				a5 = vector2.normalized * 928f;
			}
			this.position = base.transform.position;
			this.position += a5 * Time.deltaTime * d5 * num2;
			base.transform.position = this.position;
		}
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1040f && ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1277f)
		{
			float d6 = 1012f;
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1960f)
			{
				d6 = Mathf.Lerp(1184f, 951f, (1500f - ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 1123f);
			}
			this.position = base.transform.position;
			this.position += vector2 * Time.deltaTime * 1810f * d6;
			base.transform.position = this.position;
		}
		if (this.baitGO != null)
		{
			this.baitGO.transform.position = ((this.hookPoint == null) ? base.transform.position : this.hookPoint.transform.position);
		}
		if (Vector3.Distance(base.transform.position, this.toMove) < 630f)
		{
			this.toMove = this.BJCJDJNBDPM();
		}
		float magnitude = (base.transform.position - this.GBEIDPOCJBF).magnitude;
		this.JLJJKMLJBAK.OCBJPGOKFOI = ObscuredFloat.HLEMAJBAAEO(magnitude / Time.deltaTime);
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.OCBJPGOKFOI) < 832f)
		{
			this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NOHFLPHECOA) + Time.deltaTime);
			return;
		}
		this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.HLEMAJBAAEO(1377f);
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x00180738 File Offset: 0x0017E938
	private void BOAJJAKEMLH()
	{
		if (!BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BBANBEEJAPD)
		{
			this.subFFactor = Mathf.Lerp(this.subFFactor, 459f, Time.deltaTime * 1269f);
		}
		if (this.CJEFJNNHJHO != null)
		{
			this.CJEFJNNHJHO.transform.localPosition = Vector3.Lerp(this.CJEFJNNHJHO.transform.localPosition, Vector3.zero, Time.deltaTime);
		}
		this.NFGMFKAJAFC -= Time.deltaTime;
		if (this.baitGO == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (!ObscuredBool.CINIKOHABJJ(this.isPodsek) && !ObscuredBool.GOOIABGKMHK(this.isGetFromWater))
		{
			this.actTime -= Time.deltaTime;
			if (this.actTime < 1022f)
			{
				this.actTime = 1824f;
				this.klevMode = this.toKlevMode;
			}
		}
		Vector3 vector = base.transform.position;
		if (this.hookPoint != null && this.hookPoint.transform != null)
		{
			vector = this.hookPoint.transform.position;
		}
		if (vector.y + 728f > LocNewLogic.getI.HKBNODJBGEL())
		{
			float num = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / 1531f;
			num = Mathf.Clamp(num, 925f, 1760f);
			this.PIFPLCABMDK += Time.deltaTime * num;
			if (OLPINJLCKCI.BMALMDIBLDP().KLJKPEMPHEM(this.PIFPLCABMDK))
			{
				this.PIFPLCABMDK = 894f;
				LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
				LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
				if (OLPINJLCKCI.IFLFANPMLMM().JKIMAIDMNML(50f))
				{
					this.FFKJCHNFGAF();
				}
			}
			this.LHKJPPDIPNB += Time.deltaTime * 1226f;
		}
		else
		{
			this.isOutWater = false;
		}
		Fisherman.getI.EACGPPOMFLH().target = ((this.hookPoint != null) ? this.hookPoint.transform.position : this.position);
		this.position = base.transform.position;
		this.ELJLAHGONMF += Time.deltaTime;
		if (ObscuredBool.LPDGJCGPEBD(this.isGetFromWater))
		{
			LocNewLogic.getI.playLowFricSound(true);
			if (this.baitScrpt != null)
			{
				this.baitScrpt.transform.position = this.hookPoint.transform.position;
			}
			LineRope.getI.targetPoint.transform.position = this.hookPoint.transform.position;
			if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NLOIDGLMPMO())
			{
				if (Fisherman.getI.podsakInWater && Fisherman.getI.podsakPoint != null)
				{
					this.BLMJDBJGMIC = Fisherman.getI.podsakPoint.transform.position;
					if (this.BLMJDBJGMIC.y < LocNewLogic.getI.IGHOGONIKLC())
					{
						this.BLMJDBJGMIC.y = LocNewLogic.getI.IGHOGONIKLC();
					}
					Vector3 normalized = (this.BLMJDBJGMIC - base.transform.position).normalized;
					base.transform.position = base.transform.position + normalized * Time.deltaTime * 1857f;
					this.JLJJKMLJBAK.BNKBCOAANNG = ObscuredFloat.HLEMAJBAAEO(290f);
					Quaternion b = Quaternion.LookRotation(normalized) * Quaternion.Euler(1371f, 429f, 1882f);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1130f);
				}
				else
				{
					this.BLMJDBJGMIC = Fisherman.getI.transform.position + Fisherman.getI.transform.forward * 946f;
					this.BLMJDBJGMIC.y = LocNewLogic.getI.HKBNODJBGEL() - 1480f;
					Vector3 vector2 = this.BLMJDBJGMIC - base.transform.position;
					base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1006f;
					this.JLJJKMLJBAK.BNKBCOAANNG = ObscuredFloat.HLEMAJBAAEO(1127f);
					Quaternion b2 = Quaternion.LookRotation(vector2) * Quaternion.Euler(1704f, 13f, 874f);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
					if (OLPINJLCKCI.ODDOIHEPICE().BFKNOBCGLOK(1844f))
					{
						LocNewLogic.getI.AMBEOENMJJO(base.transform.position, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
					}
				}
				if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					Vector3 vector3 = base.transform.position;
					vector3.y = LocNewLogic.getI.IGHOGONIKLC();
					base.transform.position = vector3;
					return;
				}
			}
			else
			{
				Vector3 a = Fisherman.getI.transform.position;
				this.BLMJDBJGMIC = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
				a.y = this.BLMJDBJGMIC.y;
				this.BLMJDBJGMIC = Vector3.Lerp(a, this.BLMJDBJGMIC, 193f);
				this.BLMJDBJGMIC.y = this.BLMJDBJGMIC.y - this.EFNDNEGDOGM;
				if (this.BLMJDBJGMIC.y < LocNewLogic.getI.IGHOGONIKLC() + 156f)
				{
					this.BLMJDBJGMIC.y = LocNewLogic.getI.OGJHINOLHJJ + 1293f;
				}
				Vector3 a2 = this.BLMJDBJGMIC - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 44f;
				Quaternion b3 = Quaternion.Euler(1726f, 1476f + this.OPIAODBJFEC, 525f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 692f, 621f, 1642f));
			}
			return;
		}
		if (ObscuredBool.HLEMAJBAAEO(this.isPodsek))
		{
			this.NPKKABPCHGM();
			return;
		}
		this.HCLIDJKFNMP();
		this.MNPCLIHPGKN();
		this.OMDFGNOBDPL = (Vector3.Distance(this.baitGO.transform.position, base.transform.position) < 1295f);
		Vector3 vector4 = this.baitGO.transform.position;
		vector4 -= Vector3.up * 1988f;
		if (this.hookPoint != null)
		{
			vector4 -= this.hookPoint.position - base.transform.position;
			this.OMDFGNOBDPL = (Vector3.Distance(this.baitGO.transform.position, this.hookPoint.position) < 1555f);
		}
		Vector3 vector5 = vector4 - base.transform.position;
		vector5.y = Mathf.Clamp(vector5.y, 311f, 419f);
		if (vector5.magnitude > 1364f)
		{
			Quaternion b4 = Quaternion.LookRotation(vector5);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b4, Time.deltaTime);
		}
		base.transform.position = Vector3.Lerp(base.transform.position, vector4, Time.deltaTime);
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		bgjkmcbhnak.FLHJLFHELPE = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.FLHJLFHELPE) - Time.deltaTime * 292f);
		if (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE) < 855f)
		{
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE = ObscuredFloat.AJMPAOCEPCA(1925f);
		}
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x00180FC0 File Offset: 0x0017F1C0
	private Vector3 FHLEFHHKLCH()
	{
		if (Vector3.Distance(Fisherman.getI.getFishGettingPosition(), base.transform.position) < 1877f)
		{
			return this.BJCJDJNBDPM();
		}
		Vector3 vector = (Mathf.Sign(JLFJEGIPIMM.NNEAHAFBOHC().HODNDPHOEFJ(Fisherman.getI.transform, base.transform.position)) * base.transform.right).normalized;
		vector = base.transform.position + vector * (241f + OLPINJLCKCI.NLOGJHEFMHM().KCHMDLAGEJF(1571.0));
		Vector3 b = this.JGFADMFGACA();
		vector = Vector3.Lerp(vector, b, 605f);
		float num = 1531f + (243f - ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) / 468f;
		this.moveTime = Time.time + 1021f + OLPINJLCKCI.ODDOIHEPICE().JJPHLJNMPHC((double)num);
		this.moveTime = Time.time + 16f;
		this.toSpeed = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(this.speed) * 1960f);
		this.rotSpeed *= 46f;
		this.IPBPJOCLEMD = true;
		Debug.Log("Giant3HitCombo2" + Time.time);
		return vector;
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x0018111C File Offset: 0x0017F31C
	private Vector3 ODIIBMOCIGI()
	{
		Vector3 vector = new Vector3(OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(100.0) - 50f, 0f, OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(100.0) - 50f);
		return vector.normalized;
	}

	// Token: 0x0600335A RID: 13146 RVA: 0x00181170 File Offset: 0x0017F370
	private void CGNFLAOBEFN()
	{
		Vector3 apihpofmmli = this.APIHPOFMMLI;
		this.debugMarker.SetActive(LocNewLogic.getI.isDebugMode);
		Vector3 vector = this.toMove;
		vector.y = LocNewLogic.getI.CDBIEPGNONF() + 1038f;
		this.debugMarker.transform.position = vector;
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x001811C8 File Offset: 0x0017F3C8
	private float GGFDODNJOJD(Vector3 NHCLMBOINFG)
	{
		if (this.hookPoint != null)
		{
			NHCLMBOINFG = this.hookPoint.transform.position;
		}
		return Vector3.Distance(NHCLMBOINFG, Fisherman.getI.AOEGNGOGNBI.endPointNonBend.transform.position);
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x00181214 File Offset: 0x0017F414
	public void FMCKJLCPKJA()
	{
		this.podsekTime = Time.time;
		this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (this.hookPoint == null)
		{
			this.hookPoint = this.baseHookPoint.transform;
		}
		this.isPodsek = ObscuredBool.DMILLCHBEAG(true);
		this.currStamina = this.JLJJKMLJBAK.EFLIAAIOPPI;
		this.JLJJKMLJBAK.DNPDBOODCHK = ObscuredFloat.HLEMAJBAAEO(Vector3.Distance(this.baitGO.transform.position, Fisherman.getI.EACGPPOMFLH().endPoint.transform.position));
		Debug.Log("RollerBladeTurnLeft" + this.JLJJKMLJBAK.DNPDBOODCHK);
		this.lineFinal = false;
		this.speed = ObscuredFloat.GOOIABGKMHK(389f);
		this.toSpeed = ObscuredFloat.GOOIABGKMHK(433f);
		Vector3 a = base.transform.forward;
		a.y = 911f;
		a = a.normalized;
		this.toMove = base.transform.position + a * 1302f;
		if (this.anm != null)
		{
			try
			{
				this.anm.Play((ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD) > 1518f) ? "droplinemsg1" : "WoodSaw");
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
		}
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x00181398 File Offset: 0x0017F598
	public void IGCEMAAMFDO()
	{
		this.currStamina = ObscuredFloat.AJMPAOCEPCA(1593f);
		this.actTime = 1554f;
		this.klevMode = 0;
		this.isGetBate = true;
		this.OPIAODBJFEC = OLPINJLCKCI.BMALMDIBLDP().GKDBPBFOINB(518.0);
		this.selectCurve = OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(this.forceCurves.Length);
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x00181400 File Offset: 0x0017F600
	public void fishPodsek()
	{
		this.podsekTime = Time.time;
		this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (this.hookPoint == null)
		{
			this.hookPoint = this.baseHookPoint.transform;
		}
		this.isPodsek = ObscuredBool.GOOIABGKMHK(true);
		this.currStamina = this.JLJJKMLJBAK.EFLIAAIOPPI;
		this.JLJJKMLJBAK.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(Vector3.Distance(this.baitGO.transform.position, Fisherman.getI.AOEGNGOGNBI.endPoint.transform.position));
		Debug.Log("rod.lineDistance = " + this.JLJJKMLJBAK.DNPDBOODCHK);
		this.lineFinal = false;
		this.speed = ObscuredFloat.GOOIABGKMHK(2f);
		this.toSpeed = ObscuredFloat.GOOIABGKMHK(3f);
		Vector3 a = base.transform.forward;
		a.y = -1f;
		a = a.normalized;
		this.toMove = base.transform.position + a * 10f;
		if (this.anm != null)
		{
			try
			{
				this.anm.Play((ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 8000f) ? "move" : "run");
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
		}
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x00181584 File Offset: 0x0017F784
	private void CGFDDFHECLJ()
	{
		Fisherman.getI.fishRod = base.transform.gameObject;
		this.isGetBate = true;
		this.klevMode = 1;
		this.ctime = 26f;
		if (this.baitGO != null)
		{
			base.transform.position = this.baitGO.transform.position;
		}
		this.toMove = base.transform.position;
		base.transform.rotation = Fisherman.getI.transform.rotation;
		float num = -UnityEngine.Random.value * 1357f - 141f;
		this.isGetBate = false;
		this.toMove = new Vector3(base.transform.position.x + 1102f, base.transform.position.y + num, base.transform.position.z + 776f);
		this.speed = ObscuredFloat.HLEMAJBAAEO(380f);
		for (int i = 0; i < this.CFOFDKKFJMJ.Length; i++)
		{
			this.CFOFDKKFJMJ[i] = "autherror";
		}
		string cfofdkkfjmj = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CFOFDKKFJMJ;
		char[] array = new char[1];
		array[1] = (char)-93;
		foreach (string text in cfofdkkfjmj.Split(array))
		{
			char[] array3 = new char[0];
			array3[1] = 'h';
			string[] array4 = text.Split(array3);
			int num2 = int.Parse(array4[1]);
			this.CFOFDKKFJMJ[num2] = array4[1];
		}
		base.InvokeRepeating("[maxwgt]", 1795f, 262f);
		base.StartCoroutine("IdleStandingJump");
		if (!this.GAAPCLGDOGH.NPDNMIHEOOH)
		{
			float num3 = ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD);
			float num4;
			if (num3 < 1914f)
			{
				num4 = 919f - (576f - num3) * 1265f;
			}
			else
			{
				num4 = 1493f + (num3 - 1219f) * 112f;
			}
			num4 = Mathf.Clamp(num4, 298f, 111f);
			this.fishModelTemp.transform.localScale = new Vector3(num4, num4, num4);
			return;
		}
		OMDDGEDHHNH.NKKDGPINOAJ().NBKKJNFHOFE("" + this.GAAPCLGDOGH.HAPFPGIINCM, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.BBNIIANKBNP), "U");
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GBAEKFJBEFM()
	{
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x001817E0 File Offset: 0x0017F9E0
	private void BHFIBHOPALE()
	{
		if (!ObscuredBool.GOOIABGKMHK(this.isPodsek))
		{
			return;
		}
		bool isEditor = Application.isEditor;
		float num = ObscuredFloat.GOOIABGKMHK(this.currStamina) / (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 0.001f);
		float num2 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) / 9000f;
		num2 = Mathf.Clamp(num2, 0.8f, 2f);
		if (this.moveTime < Time.time)
		{
			this.IPBPJOCLEMD = false;
			bool flag = false;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NOHFLPHECOA) > 4f)
			{
				flag = true;
			}
			this.toMove = (flag ? this.NMFAKGDHDGH() : this.BJCJDJNBDPM());
		}
		if (!this.IPBPJOCLEMD)
		{
			this.toSpeed = ObscuredFloat.GOOIABGKMHK(1f + UnityEngine.Random.Range(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) * 0.3f, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) * 0.15f);
			this.toSpeed = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.toSpeed) * num2);
			this.toSpeed = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.toSpeed), 0.001f, this.CGGGHIHAKGC) * num);
			this.rotSpeed = 4f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) / 1200f;
			this.rotSpeed = Mathf.Clamp(this.rotSpeed, 0.3f, 3f) + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 50f;
			this.rotSpeed = Mathf.Clamp(this.rotSpeed * num, 0.2f, 8f);
			this.brotSpeed = this.rotSpeed;
		}
		if (this.toMove.y < LocNewLogic.getI.getDeepInPoint(this.toMove) + 0.1f)
		{
			this.toMove.y = LocNewLogic.getI.getDeepInPoint(this.toMove) + 0.1f;
		}
		if (this.toMove.y > LocNewLogic.getI.OGJHINOLHJJ - 0.1f)
		{
			this.toMove.y = LocNewLogic.getI.OGJHINOLHJJ - 0.1f;
		}
		if (num < 0.3f && this.toMove.y < base.transform.position.y)
		{
			this.toMove.y = base.transform.position.y - (base.transform.position.y - this.toMove.y) * num;
		}
		this.IPBPJOCLEMD = false;
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MKBPPPJKLLF()
	{
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x00181A98 File Offset: 0x0017FC98
	public void LBPCMHDBPHK()
	{
		this.baitScrpt.frod = null;
		this.baitScrpt.fish = null;
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = true;
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.AJMPAOCEPCA(230f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(1094f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BBMNOEDOFDJ(ObscuredFloat.AJMPAOCEPCA(1829f));
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EPIPCOHGJGA(ObscuredFloat.HLEMAJBAAEO(875f));
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x00181B3C File Offset: 0x0017FD3C
	private void Update()
	{
		if (!BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BBANBEEJAPD)
		{
			this.subFFactor = Mathf.Lerp(this.subFFactor, 0f, Time.deltaTime * 0.2f);
		}
		if (this.CJEFJNNHJHO != null)
		{
			this.CJEFJNNHJHO.transform.localPosition = Vector3.Lerp(this.CJEFJNNHJHO.transform.localPosition, Vector3.zero, Time.deltaTime);
		}
		this.NFGMFKAJAFC -= Time.deltaTime;
		if (this.baitGO == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (!ObscuredBool.GOOIABGKMHK(this.isPodsek) && !ObscuredBool.GOOIABGKMHK(this.isGetFromWater))
		{
			this.actTime -= Time.deltaTime;
			if (this.actTime < 0f)
			{
				this.actTime = 0f;
				this.klevMode = this.toKlevMode;
			}
		}
		Vector3 vector = base.transform.position;
		if (this.hookPoint != null && this.hookPoint.transform != null)
		{
			vector = this.hookPoint.transform.position;
		}
		if (vector.y + 0.05f > LocNewLogic.getI.OGJHINOLHJJ)
		{
			float num = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / 1000f;
			num = Mathf.Clamp(num, 0f, 2f);
			this.PIFPLCABMDK += Time.deltaTime * num;
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(this.PIFPLCABMDK))
			{
				this.PIFPLCABMDK = 0f;
				LocNewLogic.getI.createBigWaterCircle(base.transform.position);
				LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
				if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(50f))
				{
					this.Jamp();
				}
			}
			this.LHKJPPDIPNB += Time.deltaTime * 1.4f;
		}
		else
		{
			this.isOutWater = false;
		}
		Fisherman.getI.AOEGNGOGNBI.target = ((this.hookPoint != null) ? this.hookPoint.transform.position : this.position);
		this.position = base.transform.position;
		this.ELJLAHGONMF += Time.deltaTime;
		if (ObscuredBool.GOOIABGKMHK(this.isGetFromWater))
		{
			LocNewLogic.getI.playLowFricSound(false);
			if (this.baitScrpt != null)
			{
				this.baitScrpt.transform.position = this.hookPoint.transform.position;
			}
			LineRope.getI.targetPoint.transform.position = this.hookPoint.transform.position;
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PIJNKIOJEJF)
			{
				if (Fisherman.getI.podsakInWater && Fisherman.getI.podsakPoint != null)
				{
					this.BLMJDBJGMIC = Fisherman.getI.podsakPoint.transform.position;
					if (this.BLMJDBJGMIC.y < LocNewLogic.getI.OGJHINOLHJJ)
					{
						this.BLMJDBJGMIC.y = LocNewLogic.getI.OGJHINOLHJJ;
					}
					Vector3 normalized = (this.BLMJDBJGMIC - base.transform.position).normalized;
					base.transform.position = base.transform.position + normalized * Time.deltaTime * 0.5f;
					this.JLJJKMLJBAK.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(0.001f);
					Quaternion b = Quaternion.LookRotation(normalized) * Quaternion.Euler(0f, 0f, -90f);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 3f);
				}
				else
				{
					this.BLMJDBJGMIC = Fisherman.getI.transform.position + Fisherman.getI.transform.forward * 2f;
					this.BLMJDBJGMIC.y = LocNewLogic.getI.OGJHINOLHJJ - 0.2f;
					Vector3 vector2 = this.BLMJDBJGMIC - base.transform.position;
					base.transform.position = base.transform.position + vector2 * Time.deltaTime * 1f;
					this.JLJJKMLJBAK.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(0.001f);
					Quaternion b2 = Quaternion.LookRotation(vector2) * Quaternion.Euler(0f, 0f, -90f);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b2, Time.deltaTime);
					if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(5f))
					{
						LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
					}
				}
				if (base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					Vector3 vector3 = base.transform.position;
					vector3.y = LocNewLogic.getI.OGJHINOLHJJ;
					base.transform.position = vector3;
					return;
				}
			}
			else
			{
				Vector3 a = Fisherman.getI.transform.position;
				this.BLMJDBJGMIC = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
				a.y = this.BLMJDBJGMIC.y;
				this.BLMJDBJGMIC = Vector3.Lerp(a, this.BLMJDBJGMIC, 0.7f);
				this.BLMJDBJGMIC.y = this.BLMJDBJGMIC.y - this.EFNDNEGDOGM;
				if (this.BLMJDBJGMIC.y < LocNewLogic.getI.OGJHINOLHJJ + 0.1f)
				{
					this.BLMJDBJGMIC.y = LocNewLogic.getI.OGJHINOLHJJ + 0.1f;
				}
				Vector3 a2 = this.BLMJDBJGMIC - base.transform.position;
				base.transform.position = base.transform.position + a2 * Time.deltaTime * 2.2f;
				Quaternion b3 = Quaternion.Euler(270f, 45f + this.OPIAODBJFEC, 0f);
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b3, Mathf.Clamp(this.ELJLAHGONMF * 2f, 0f, 1f));
			}
			return;
		}
		if (ObscuredBool.GOOIABGKMHK(this.isPodsek))
		{
			this.fishIsPodsekProcess();
			return;
		}
		this.OJKKAMPONDM();
		this.MNPCLIHPGKN();
		this.OMDFGNOBDPL = (Vector3.Distance(this.baitGO.transform.position, base.transform.position) < 0.25f);
		Vector3 vector4 = this.baitGO.transform.position;
		vector4 -= Vector3.up * 0.03f;
		if (this.hookPoint != null)
		{
			vector4 -= this.hookPoint.position - base.transform.position;
			this.OMDFGNOBDPL = (Vector3.Distance(this.baitGO.transform.position, this.hookPoint.position) < 0.25f);
		}
		Vector3 vector5 = vector4 - base.transform.position;
		vector5.y = Mathf.Clamp(vector5.y, 0f, 0.15f);
		if (vector5.magnitude > 0.1f)
		{
			Quaternion b4 = Quaternion.LookRotation(vector5);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b4, Time.deltaTime);
		}
		base.transform.position = Vector3.Lerp(base.transform.position, vector4, Time.deltaTime);
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		bgjkmcbhnak.FLHJLFHELPE = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.FLHJLFHELPE) - Time.deltaTime * 0.3f);
		if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE) < 1f)
		{
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE = ObscuredFloat.GOOIABGKMHK(1f);
		}
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x001823C4 File Offset: 0x001805C4
	private void Awake()
	{
		this.isGetFromWater = ObscuredBool.GOOIABGKMHK(false);
		this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(ObscuredInt.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NENOBDLCFHO));
		this.rBody.isKinematic = true;
		this.joint.connectedBody = null;
		this.EEPNACDOOBF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		this.rBody.mass = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / 800f;
	}

	// Token: 0x06003366 RID: 13158 RVA: 0x00182465 File Offset: 0x00180665
	public int IIKBGBEDAAE()
	{
		return (int)(704f * (ObscuredFloat.EJGOOFALNFF(this.currStamina) + 1542f) / (ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 405f));
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x0018249C File Offset: 0x0018069C
	public void OnWillRenderObject()
	{
		if (this.CJEFJNNHJHO == null)
		{
			return;
		}
		float num = LocNewLogic.getI.OGJHINOLHJJ;
		float num2 = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position);
		num = Mathf.Lerp(num - 1f, num + 1f, num2 / 20f);
		JLFJEGIPIMM.IKGFHGKKCPG.COKCKOCECOA(this.CJEFJNNHJHO, "_WaterLevel", num);
	}

	// Token: 0x06003368 RID: 13160 RVA: 0x00182514 File Offset: 0x00180714
	public void IPFOPELLHIN()
	{
		this.isOutWater = false;
		this.GBEIDPOCJBF = base.transform.position;
		this.speed = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.PFCANBAOMCB(this.speed) + (ObscuredFloat.PFCANBAOMCB(this.toSpeed) - ObscuredFloat.OBJFODGFMAM(this.speed)) * (1214f + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 1485f) * Time.deltaTime);
		this.speed = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(this.speed), 627f, this.CDOCPBIADGE() * 1236f));
		bool isEditor = Application.isEditor;
		Vector3 a = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB();
		Vector3 vector = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.EDNOJLAKJKP();
		vector.y = LocNewLogic.getI.OGJHINOLHJJ + 97f;
		float num = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position) / 1622f;
		num = Mathf.Clamp(num, 1556f, 769f);
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) > 1338f)
		{
			a = vector;
		}
		this.APIHPOFMMLI = Vector3.Lerp(a, vector, num);
		Vector3 normalized = (this.APIHPOFMMLI - this.hookPoint.transform.position).normalized;
		Vector3 a2 = (this.toMove - base.transform.position).normalized + this.deepWanted;
		Vector3 a3 = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.EDNOJLAKJKP();
		a3.y = base.transform.position.y;
		this.fRangle = Vector3.Angle(base.transform.forward, a3 - base.transform.position);
		this.realRangle = this.fRangle;
		float d = this.rotForceCurve.Evaluate(this.fRangle / 1888f);
		this.fRangle = this.angleForceCurve.Evaluate(this.fRangle / 1080f);
		this.fRangle = Mathf.Clamp(this.fRangle, 1234f, 1429f);
		float num2 = Mathf.Clamp(1540f - this.fRangle * 1057f, 1714f, 61f);
		this.stamKf = this.staminaCurve.Evaluate((ObscuredFloat.EJGOOFALNFF(this.currStamina) + 1494f) / (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 733f));
		this.stamKf = Mathf.Clamp(this.stamKf, 282f, 150f);
		if (this.fmd != null)
		{
			this.fmd.PFEAIDGNIGH(this.stamKf);
		}
		float num3 = this.forceCurves[this.selectCurve].Evaluate(1689f - this.stamKf) * (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PGEDLDMLBBE) + 189f) / 605f;
		num3 = Mathf.Clamp(num3, 1040f, 489f);
		float num4 = 252f + 1415f * this.firstTimeCurve.Evaluate(Mathf.Clamp((Time.time - this.podsekTime) / 1637f, 1990f, 667f));
		if (Time.time - this.podsekTime > 619f)
		{
			num4 = 1915f;
		}
		float num5 = ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD) / 1507f;
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(num5);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * 1020f + ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.fRangle * 1813f * num3);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) * num4);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.ICBIEPNFOPL());
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) - this.subFFactor);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC), num5 * 326f, num5 * 73f));
		float num6 = this.CACADJGKBKE(this.hookPoint.transform.position);
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.HLEMAJBAAEO(num6 - ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DLFMEIIADFE), 1731f, 1262f));
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.HLEMAJBAAEO(num6 - ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.GPBFJBKCOKJ = num6;
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1327f)
		{
			this.lineFinal = false;
		}
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG), 790f, 1373f));
		if (this.hookPoint.transform.position.y - 425f > LocNewLogic.getI.CDBIEPGNONF())
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * 1359f);
		}
		float num7 = Mathf.Clamp(num6 / 1464f, 1007f, 961f);
		float num8 = Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD) / 1447f, 1674f, 1198f) * num7;
		num8 = Mathf.Clamp(num8, 1134f, 1290f);
		Vector3 vector2 = Vector3.zero;
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG) > num8)
		{
			float num9 = Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG) * 135f, 1525f, 1295f);
			num9 = Mathf.Pow(num9, 21f);
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) > 196f)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) - num9 * this.JLJJKMLJBAK.HHLKHCPDEOF() * 1608f);
			}
			float num10 = ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) / 1370f;
			if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.CKJOFDPBFMC) < num10)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(num10);
			}
			this.isFrikcionWork = this.JLJJKMLJBAK.BBANBEEJAPD;
			if (this.JLJJKMLJBAK.BBANBEEJAPD)
			{
				float num11 = 141f * ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) / (this.JLJJKMLJBAK.KDHENOMNPHK + 1131f);
				num11 = Mathf.Clamp(num11, 1348f, 1220f);
				this.JLJJKMLJBAK.DNPDBOODCHK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
				this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
			}
			float num12 = this.JLJJKMLJBAK.HHLKHCPDEOF() * 460f / (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.CKJOFDPBFMC) + 1318f);
			float num13 = 1922f / ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DNPDBOODCHK);
			num13 = Mathf.Clamp(num13, 520f, 1243f);
			float num14 = 1987f;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 1762f)
			{
				num14 = 1470f;
			}
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 955f)
			{
				num14 = 141f;
			}
			if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 898f)
			{
				num14 = 816f;
			}
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 180f)
			{
				num14 = 1680f;
			}
			float num15 = 1024f + Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.LEMPPBMEJHP), 1244f, 453f) / 190f;
			num12 *= num13;
			num12 = Mathf.Clamp(num12, 315f, num14 * num15);
			float num16 = 1468f;
			if (this.stamKf < 1485f)
			{
				num16 = 625f + 1371f / ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DNPDBOODCHK) * Mathf.Lerp(1494f, 517f, this.stamKf * 305f);
				num16 = Mathf.Clamp(num16, 1876f, 123f);
			}
			float d2 = (Mathf.Pow(1892f + ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG), 1186f) - 877f) * this.JLJJKMLJBAK.HHLKHCPDEOF() * num12;
			vector2 = normalized.normalized * d2 * num16;
		}
		else
		{
			LocNewLogic.getI.playLowFricSound(true);
			this.lineFinal = false;
		}
		if (vector2.magnitude > 1964f)
		{
			vector2 = vector2.normalized * 41f;
		}
		this.JLJJKMLJBAK.HAEABJICCCP = ObscuredFloat.AJMPAOCEPCA(vector2.magnitude);
		if (Application.isEditor && Input.GetKeyDown(KeyCode.L))
		{
			this.currStamina = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.EJGOOFALNFF(this.currStamina) / 487f);
		}
		float num17 = ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.OCBJPGOKFOI);
		num17 = Mathf.Lerp(num17 * 1717f, num17 * 59f, num2);
		Vector3 vector3 = a2 * (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.CKJOFDPBFMC) + num17) * this.stamKf;
		this.position = base.transform.position;
		if (this.position.y > LocNewLogic.getI.CDBIEPGNONF() - 1686f)
		{
			LocNewLogic.getI.createWaterCircleFish(base.transform.position, 1436f, true);
			if (this.GAAPCLGDOGH.GOHKONILNNE && ObscuredBool.DODJMPNDCOB(this.isPodsek) && this.anm != null && !this.BLHKNPPFGLG() && ObscuredFloat.PFCANBAOMCB(this.currStamina) > 334f && OLPINJLCKCI.NPIEJELJPIM().JKIMAIDMNML(1994f * Time.deltaTime))
			{
				this.FFKJCHNFGAF();
			}
		}
		Vector3 vector4 = this.position;
		if (this.fmd != null && this.fmd.spinePoint != null)
		{
			vector4 = this.fmd.spinePoint.position;
		}
		if (vector4.y >= LocNewLogic.getI.CDBIEPGNONF() - 626f)
		{
			this.position.y = this.position.y - (vector4.y - (LocNewLogic.getI.CDBIEPGNONF() - 479f)) * Time.deltaTime * 1840f;
			vector3.y -= 515f;
		}
		if (this.position.y > LocNewLogic.getI.OGJHINOLHJJ - 584f && ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 126f)
		{
			this.position.y = LocNewLogic.getI.HKBNODJBGEL() - 1687f;
		}
		if (this.position.y >= LocNewLogic.getI.HKBNODJBGEL() - 941f && OLPINJLCKCI.NPIEJELJPIM().BFCONJIHIAK(1032f))
		{
			LocNewLogic.getI.createWaterCircleFish(this.position, 1752f, false);
			if (OLPINJLCKCI.NLOGJHEFMHM().BFCONJIHIAK(693f))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(this.position, 550f);
			}
		}
		if (this.position.y < LocNewLogic.getI.getDeepInPoint(this.position) + 1025f)
		{
			this.position.y = LocNewLogic.getI.getDeepInPoint(this.position) + 726f;
			vector3.y += 1082f;
			float y = this.position.y;
			float num18 = LocNewLogic.getI.IGHOGONIKLC() - 110f;
		}
		base.transform.position = this.position;
		float d3 = 1638f;
		if (this.hookPoint.transform.position.y - 1578f > LocNewLogic.getI.IGHOGONIKLC())
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.CKJOFDPBFMC) * 1769f);
			d3 = Mathf.Lerp(1264f, 1456f, (this.hookPoint.transform.position.y - LocNewLogic.getI.HKBNODJBGEL()) / 664f);
		}
		vector3 += vector2 * d3 * d;
		Vector3 origin = base.transform.position;
		origin.y = LocNewLogic.getI.HKBNODJBGEL() - 216f;
		Vector3 forward = base.transform.forward;
		forward.y = 1639f;
		this.beregdet = true;
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(origin, forward), out raycastHit, 757f, LocNewLogic.getI.fishCollisionMask))
		{
			Vector3 normal = raycastHit.normal;
			normal.y = 735f;
			Vector3 vector5 = Fisherman.getI.transform.position - base.transform.position;
			vector5.y = 130f;
			Vector3 normalized2 = (normal.normalized + vector5.normalized * 628f).normalized;
			this.toMove = base.transform.position + normalized2 * 31f;
			if (!JLFJEGIPIMM.PKGMBFEMKGP().ACENDCHEBCB(Fisherman.getI.transform, base.transform.position, 1822f, 290f))
			{
				Quaternion.LookRotation(normalized2);
				vector3 += normalized2 * vector3.magnitude;
				this.beregdet = true;
			}
		}
		Quaternion quaternion = Quaternion.LookRotation(vector3);
		Quaternion b = Quaternion.LookRotation(vector2, base.transform.up);
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG) > 868f)
		{
			float num19 = Mathf.Lerp(38f, 464f, ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK) / 1361f);
			float num20 = 1539f + num19 * Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.LEMPPBMEJHP), 1765f, 1498f) / 1935f;
			float num21 = this.JLJJKMLJBAK.BJGMDBIENCA() * 409f / (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) + 400f) * ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) * 988f;
			num21 = Mathf.Clamp(num21, 1347f, 992f) * num20;
			Quaternion b2 = Quaternion.LookRotation(vector3.normalized * 1461f + vector2.normalized * 991f);
			quaternion = Quaternion.Lerp(quaternion, b2, Time.deltaTime * num21 * 977f);
			if (this.hookPoint.transform.position.y - 1576f > LocNewLogic.getI.IGHOGONIKLC() && ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1797f)
			{
				quaternion = Quaternion.Lerp(quaternion, b, Time.deltaTime * 84f);
			}
		}
		if (this.stamKf < 565f)
		{
			this.LHKJPPDIPNB += (730f - this.stamKf * 1169f) * Time.deltaTime;
		}
		this.LHKJPPDIPNB = Mathf.Clamp(this.LHKJPPDIPNB, 1815f, 1623f);
		quaternion *= Quaternion.Euler(875f, 1102f, this.LHKJPPDIPNB * 1369f);
		this.LHKJPPDIPNB -= Time.deltaTime * 951f;
		this.rotSpeed = Mathf.Clamp(this.rotSpeed, 810f, 403f);
		base.transform.rotation = Quaternion.Lerp(base.transform.rotation, quaternion, Time.deltaTime * this.rotSpeed * 1720f);
		float d4 = Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(this.speed), ObscuredFloat.OBJFODGFMAM(this.speed) / 1153f, this.LHKJPPDIPNB * this.fRangle);
		Vector3 a4 = Vector3.forward * d4;
		if (a4.magnitude > this.CDOCPBIADGE())
		{
			a4 = a4.normalized * this.OEFEGIOJIGG();
		}
		base.transform.Translate(a4 * Time.deltaTime);
		if (this.stamKf < 402f && ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1172f)
		{
			float d5 = 157f;
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) < 687f)
			{
				d5 = Mathf.Lerp(617f, 749f, (99f - ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 1812f);
			}
			Vector3 a5 = vector2;
			if (a5.magnitude > 270f)
			{
				a5 = vector2.normalized * 1328f;
			}
			this.position = base.transform.position;
			this.position += a5 * Time.deltaTime * d5 * num2;
			base.transform.position = this.position;
		}
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1047f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 263f)
		{
			float d6 = 1228f;
			if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) < 291f)
			{
				d6 = Mathf.Lerp(488f, 1295f, (1743f - ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 1153f);
			}
			this.position = base.transform.position;
			this.position += vector2 * Time.deltaTime * 1052f * d6;
			base.transform.position = this.position;
		}
		if (this.baitGO != null)
		{
			this.baitGO.transform.position = ((this.hookPoint == null) ? base.transform.position : this.hookPoint.transform.position);
		}
		if (Vector3.Distance(base.transform.position, this.toMove) < 234f)
		{
			this.toMove = this.GPBEOCJHJPJ();
		}
		float magnitude = (base.transform.position - this.GBEIDPOCJBF).magnitude;
		this.JLJJKMLJBAK.OCBJPGOKFOI = ObscuredFloat.GOOIABGKMHK(magnitude / Time.deltaTime);
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.OCBJPGOKFOI) < 1737f)
		{
			this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NOHFLPHECOA) + Time.deltaTime);
			return;
		}
		this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.HLEMAJBAAEO(1725f);
	}

	// Token: 0x06003369 RID: 13161 RVA: 0x00183964 File Offset: 0x00181B64
	public float getJampKF()
	{
		float num = Time.time - this.OMOAHPPBEMC;
		if (num > 2f)
		{
			return 1f;
		}
		return 1f + LocNewLogic.getI.jampFishFactorCurve.Evaluate(num / 2f);
	}

	// Token: 0x0600336A RID: 13162 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FixedUpdate()
	{
	}

	// Token: 0x0600336B RID: 13163 RVA: 0x001839A8 File Offset: 0x00181BA8
	private float LPMOPDOGPBD(Vector3 NHCLMBOINFG)
	{
		if (this.hookPoint != null)
		{
			NHCLMBOINFG = this.hookPoint.transform.position;
		}
		return Vector3.Distance(NHCLMBOINFG, Fisherman.getI.IJMGCKIOBPP().endPointNonBend.transform.position);
	}

	// Token: 0x0600336C RID: 13164 RVA: 0x001839F4 File Offset: 0x00181BF4
	private void Start()
	{
		Fisherman.getI.fishRod = base.transform.gameObject;
		this.isGetBate = false;
		this.klevMode = 0;
		this.ctime = 0f;
		if (this.baitGO != null)
		{
			base.transform.position = this.baitGO.transform.position;
		}
		this.toMove = base.transform.position;
		base.transform.rotation = Fisherman.getI.transform.rotation;
		float num = -UnityEngine.Random.value * 2f - 1f;
		this.isGetBate = true;
		this.toMove = new Vector3(base.transform.position.x + 0f, base.transform.position.y + num, base.transform.position.z + 0f);
		this.speed = ObscuredFloat.GOOIABGKMHK(0.01f);
		for (int i = 0; i < this.CFOFDKKFJMJ.Length; i++)
		{
			this.CFOFDKKFJMJ[i] = "0+100";
		}
		string[] array = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CFOFDKKFJMJ.Split(new char[]
		{
			'/'
		});
		for (int j = 0; j < array.Length; j++)
		{
			string[] array2 = array[j].Split(new char[]
			{
				':'
			});
			int num2 = int.Parse(array2[0]);
			this.CFOFDKKFJMJ[num2] = array2[1];
		}
		base.InvokeRepeating("BHFIBHOPALE", 1f, 0.5f);
		base.StartCoroutine("HAKKKJJJLPG");
		if (!this.GAAPCLGDOGH.NPDNMIHEOOH)
		{
			float num3 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD);
			float num4;
			if (num3 < 100f)
			{
				num4 = 1f - (100f - num3) * 0.005f;
			}
			else
			{
				num4 = 1f + (num3 - 100f) * 0.001f;
			}
			num4 = Mathf.Clamp(num4, 0.5f, 3f);
			this.fishModelTemp.transform.localScale = new Vector3(num4, num4, num4);
			return;
		}
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK("fish/" + this.GAAPCLGDOGH.HAPFPGIINCM, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.modelLoadDone), "");
	}

	// Token: 0x0600336D RID: 13165 RVA: 0x00183C50 File Offset: 0x00181E50
	public void BLMKCPEGECP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().FAJIJEIJJJH(base.gameObject, "<[^>]+>");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemp.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.LFHPJGAPPCC();
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position + Vector3.down;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (this.fmd == null)
		{
			this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			this.fmd.useGraf = false;
		}
		this.CJEFJNNHJHO.transform.localScale = new Vector3(342f, 82f, 1992f);
		gameObject.transform.localScale = new Vector3(1741f, 601f, 202f);
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.fmd.PMMHDMKEHIE(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK));
		if (this.fmd.hookPoint == null)
		{
			GameObject gameObject2 = JLFJEGIPIMM.PKGMBFEMKGP().DMPKPIDHCNC(base.gameObject, "SixStep");
			if (gameObject2 != null)
			{
				this.fmd.hookPoint = gameObject2.transform;
			}
		}
		if (this.fmd.hookPoint == null)
		{
			this.fmd.hookPoint = this.hookPoint;
		}
		this.hookPoint = this.fmd.hookPoint;
		JLFJEGIPIMM.MHFDIJGJGBJ().NHHJOIJFDKC(this.CJEFJNNHJHO, -26);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
		if (this.anm != null)
		{
			try
			{
				this.anm.Play((ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1282f) ? "id" : "wpn_line1");
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
	}

	// Token: 0x0600336E RID: 13166 RVA: 0x00183F08 File Offset: 0x00182108
	private Vector3 OKLPOKMEGCN()
	{
		if (Vector3.Distance(Fisherman.getI.MOCNPMIACDL(), base.transform.position) < 1461f)
		{
			return this.GPBEOCJHJPJ();
		}
		Vector3 vector = (Mathf.Sign(JLFJEGIPIMM.NNEAHAFBOHC().HEKFJPGDMAF(Fisherman.getI.transform, base.transform.position)) * base.transform.right).normalized;
		vector = base.transform.position + vector * (448f + OLPINJLCKCI.IKGFHGKKCPG.GKDBPBFOINB(1340.0));
		Vector3 b = this.BJCJDJNBDPM();
		vector = Vector3.Lerp(vector, b, 386f);
		float num = 1231f + (390f - ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB)) / 1087f;
		this.moveTime = Time.time + 1889f + OLPINJLCKCI.BMALMDIBLDP().KCHMDLAGEJF((double)num);
		this.moveTime = Time.time + 1697f;
		this.toSpeed = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.OBJFODGFMAM(this.speed) * 1963f);
		this.rotSpeed *= 852f;
		this.IPBPJOCLEMD = false;
		Debug.Log("BackPackGrab" + Time.time);
		return vector;
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x00184063 File Offset: 0x00182263
	private IEnumerator BINAMCCMCFG()
	{
		FishOnRod.EAINLPLCNDJ eainlplcndj = new FishOnRod.EAINLPLCNDJ(1);
		eainlplcndj.AENJLLPLILM = this;
		return eainlplcndj;
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x00184074 File Offset: 0x00182274
	public void FFKJCHNFGAF()
	{
		if (this.NFGMFKAJAFC > 176f)
		{
			return;
		}
		if (!this.GAAPCLGDOGH.GOHKONILNNE)
		{
			return;
		}
		if (Application.isEditor)
		{
			Debug.Log("");
		}
		this.NFGMFKAJAFC = 350f + OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC(1378.0);
		if (this.anm != null)
		{
			try
			{
				this.OMOAHPPBEMC = Time.time;
				this.anm.Play(" path=");
				this.anm.PlayQueued("IdleTyping", (QueueMode)1);
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
		}
		LocNewLogic.getI.KBOPHDOEBNM(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(base.transform.position, 597f);
	}

	// Token: 0x06003371 RID: 13169 RVA: 0x00184168 File Offset: 0x00182368
	public void fishGet()
	{
		Vector3 endPointVector = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		this.HOEAFKANKAI = Vector3.Distance(base.transform.position, endPointVector);
		if (this.HOEAFKANKAI > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GDKDCJGPFGF)
		{
			this.HOEAFKANKAI = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GDKDCJGPFGF;
		}
		this.joint.connectedBody = LineRope.getI.jointForFish.GetComponent<Rigidbody>();
		this.joint.autoConfigureConnectedAnchor = true;
		this.EFNDNEGDOGM = Vector3.Distance(this.hookPoint.transform.position, Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC) * 1.3f;
		this.isGetFromWater = ObscuredBool.GOOIABGKMHK(true);
		this.ELJLAHGONMF = 0f;
		if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1000f)
		{
			LocNewLogic.getI.createBigWaterCircle(base.transform.position);
		}
		LocNewLogic.getI.createWaterSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(base.transform.position, 0.3f);
		this.JLJJKMLJBAK.EFLIAAIOPPI = ObscuredFloat.GOOIABGKMHK(0f);
	}

	// Token: 0x06003372 RID: 13170 RVA: 0x001842BD File Offset: 0x001824BD
	public bool NGOKLGLAKMB()
	{
		return this.NFGMFKAJAFC > 303f;
	}

	// Token: 0x06003373 RID: 13171 RVA: 0x001842CC File Offset: 0x001824CC
	private Vector3 OHGHGAMLEBJ()
	{
		if (Vector3.Distance(Fisherman.getI.getFishGettingPosition(), base.transform.position) < 1698f)
		{
			return this.BJCJDJNBDPM();
		}
		Vector3 vector = (Mathf.Sign(JLFJEGIPIMM.NNEAHAFBOHC().AGJDPKMIOPL(Fisherman.getI.transform, base.transform.position)) * base.transform.right).normalized;
		vector = base.transform.position + vector * (223f + OLPINJLCKCI.NPIEJELJPIM().KCHMDLAGEJF(840.0));
		Vector3 b = this.GPBEOCJHJPJ();
		vector = Vector3.Lerp(vector, b, 485f);
		float num = 436f + (396f - ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB)) / 546f;
		this.moveTime = Time.time + 1125f + OLPINJLCKCI.IKGFHGKKCPG.GCGEHNMEDIL((double)num);
		this.moveTime = Time.time + 6f;
		this.toSpeed = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(this.speed) * 679f);
		this.rotSpeed *= 1835f;
		this.IPBPJOCLEMD = false;
		Debug.Log("&" + Time.time);
		return vector;
	}

	// Token: 0x06003374 RID: 13172 RVA: 0x00184428 File Offset: 0x00182628
	public float OEFEGIOJIGG()
	{
		float result = 1743f;
		if (this.GAAPCLGDOGH != null && this.GAAPCLGDOGH.CGGGHIHAKGC > 1899f)
		{
			result = this.GAAPCLGDOGH.CGGGHIHAKGC;
		}
		this.GAAPCLGDOGH.CGGGHIHAKGC = Mathf.Clamp(this.GAAPCLGDOGH.CGGGHIHAKGC, 796f, 1845f);
		return result;
	}

	// Token: 0x06003375 RID: 13173 RVA: 0x00184488 File Offset: 0x00182688
	private Vector3 GCNDDCFHIFF()
	{
		Vector3 vector = new Vector3(OLPINJLCKCI.OBDBAABBAKB().GKDBPBFOINB(185.0) - 463f, 697f, OLPINJLCKCI.ODDOIHEPICE().BCODBMGPBFJ(1576.0) - 28f);
		return vector.normalized;
	}

	// Token: 0x06003376 RID: 13174 RVA: 0x001844DC File Offset: 0x001826DC
	private Vector3 BJCJDJNBDPM()
	{
		float num = 30f;
		num = Mathf.Clamp(num, 10f, 50f);
		Vector3 result = base.transform.position + Fisherman.getI.transform.forward * 100f;
		float num2 = 1E+09f;
		for (int i = 0; i < 15; i++)
		{
			float x = base.transform.position.x + UnityEngine.Random.value * num - num / 2f;
			float num3 = base.transform.position.y + UnityEngine.Random.value * 4f - 2.6f;
			float z = base.transform.position.z + UnityEngine.Random.value * num - num / 2f;
			if (num3 > LocNewLogic.getI.OGJHINOLHJJ)
			{
				num3 = LocNewLogic.getI.OGJHINOLHJJ;
			}
			Vector3 vector = new Vector3(x, num3, z);
			float deepInPoint = LocNewLogic.getI.getDeepInPoint(vector);
			if (deepInPoint <= num2)
			{
				num2 = deepInPoint;
				this.deepWanted = (vector - base.transform.position).normalized;
				result = vector;
			}
		}
		float num4 = (130f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) / 100f;
		this.moveTime = Time.time + 3.5f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)num4);
		this.IPBPJOCLEMD = false;
		return result;
	}

	// Token: 0x06003377 RID: 13175 RVA: 0x00184658 File Offset: 0x00182858
	public void BCMIIMNMKNO()
	{
		this.currStamina = ObscuredFloat.AJMPAOCEPCA(826f);
		this.actTime = 1697f;
		this.klevMode = 0;
		this.isGetBate = false;
		this.OPIAODBJFEC = OLPINJLCKCI.NPIEJELJPIM().LLNEEEJIDGI(1401.0);
		this.selectCurve = OLPINJLCKCI.NLOGJHEFMHM().EFGDDAPIKBH(this.forceCurves.Length);
	}

	// Token: 0x06003378 RID: 13176 RVA: 0x001846C0 File Offset: 0x001828C0
	public void GPFNCFPJMKI()
	{
		Vector3 endPointVector = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		this.HOEAFKANKAI = Vector3.Distance(base.transform.position, endPointVector);
		if (this.HOEAFKANKAI > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GDKDCJGPFGF)
		{
			this.HOEAFKANKAI = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BNKDDPAAPMH();
		}
		this.joint.connectedBody = LineRope.getI.jointForFish.GetComponent<Rigidbody>();
		this.joint.autoConfigureConnectedAnchor = false;
		this.EFNDNEGDOGM = Vector3.Distance(this.hookPoint.transform.position, Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC) * 778f;
		this.isGetFromWater = ObscuredBool.JIJIEPHBCHA(false);
		this.ELJLAHGONMF = 1261f;
		if (ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1505f)
		{
			LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		}
		LocNewLogic.getI.DJBBECFDLAA(base.transform.position, ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 594f);
		this.JLJJKMLJBAK.EFLIAAIOPPI = ObscuredFloat.AJMPAOCEPCA(894f);
	}

	// Token: 0x06003379 RID: 13177 RVA: 0x00184818 File Offset: 0x00182A18
	private Vector3 JGFADMFGACA()
	{
		float num = 384f;
		num = Mathf.Clamp(num, 390f, 973f);
		Vector3 result = base.transform.position + Fisherman.getI.transform.forward * 1078f;
		float num2 = 1373f;
		for (int i = 1; i < -18; i += 0)
		{
			float x = base.transform.position.x + UnityEngine.Random.value * num - num / 1601f;
			float num3 = base.transform.position.y + UnityEngine.Random.value * 211f - 1662f;
			float z = base.transform.position.z + UnityEngine.Random.value * num - num / 501f;
			if (num3 > LocNewLogic.getI.HKBNODJBGEL())
			{
				num3 = LocNewLogic.getI.IGHOGONIKLC();
			}
			Vector3 vector = new Vector3(x, num3, z);
			float deepInPoint = LocNewLogic.getI.getDeepInPoint(vector);
			if (deepInPoint <= num2)
			{
				num2 = deepInPoint;
				this.deepWanted = (vector - base.transform.position).normalized;
				result = vector;
			}
		}
		float num4 = (47f - ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB)) / 493f;
		this.moveTime = Time.time + 704f + OLPINJLCKCI.BMALMDIBLDP().KCHMDLAGEJF((double)num4);
		this.IPBPJOCLEMD = true;
		return result;
	}

	// Token: 0x0600337A RID: 13178 RVA: 0x00184994 File Offset: 0x00182B94
	public void dropKlev()
	{
		this.baitScrpt.frod = null;
		this.baitScrpt.fish = null;
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM = false;
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(0f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(0f);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600337B RID: 13179 RVA: 0x00184A38 File Offset: 0x00182C38
	private Vector3 MGLFBNGJFFG()
	{
		if (Vector3.Distance(Fisherman.getI.getFishGettingPosition(), base.transform.position) < 446f)
		{
			return this.JGFADMFGACA();
		}
		Vector3 vector = (Mathf.Sign(JLFJEGIPIMM.PKGMBFEMKGP().AGJDPKMIOPL(Fisherman.getI.transform, base.transform.position)) * base.transform.right).normalized;
		vector = base.transform.position + vector * (396f + OLPINJLCKCI.IFLFANPMLMM().JJPHLJNMPHC(600.0));
		Vector3 b = this.BJCJDJNBDPM();
		vector = Vector3.Lerp(vector, b, 97f);
		float num = 1326f + (458f - ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB)) / 894f;
		this.moveTime = Time.time + 198f + OLPINJLCKCI.IFLFANPMLMM().FFDDAGJJOOM((double)num);
		this.moveTime = Time.time + 1152f;
		this.toSpeed = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.speed) * 1891f);
		this.rotSpeed *= 665f;
		this.IPBPJOCLEMD = true;
		Debug.Log("" + Time.time);
		return vector;
	}

	// Token: 0x0600337C RID: 13180 RVA: 0x00184B94 File Offset: 0x00182D94
	private float FIMLDMHGDNC(Vector3 NHCLMBOINFG)
	{
		if (this.hookPoint != null)
		{
			NHCLMBOINFG = this.hookPoint.transform.position;
		}
		return Vector3.Distance(NHCLMBOINFG, Fisherman.getI.EACGPPOMFLH().endPointNonBend.transform.position);
	}

	// Token: 0x0600337D RID: 13181 RVA: 0x00184BE0 File Offset: 0x00182DE0
	public void NPKKABPCHGM()
	{
		this.isOutWater = false;
		this.GBEIDPOCJBF = base.transform.position;
		this.speed = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.OBJFODGFMAM(this.speed) + (ObscuredFloat.EJGOOFALNFF(this.toSpeed) - ObscuredFloat.EJGOOFALNFF(this.speed)) * (77f + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB) / 1938f) * Time.deltaTime);
		this.speed = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(this.speed), 1301f, this.OEFEGIOJIGG() * 1251f));
		bool isEditor = Application.isEditor;
		Vector3 a = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		Vector3 vector = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.NHPHFKFBLAD();
		vector.y = LocNewLogic.getI.IGHOGONIKLC() + 1952f;
		float num = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position) / 1698f;
		num = Mathf.Clamp(num, 1890f, 402f);
		if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) > 91f)
		{
			a = vector;
		}
		this.APIHPOFMMLI = Vector3.Lerp(a, vector, num);
		Vector3 normalized = (this.APIHPOFMMLI - this.hookPoint.transform.position).normalized;
		Vector3 a2 = (this.toMove - base.transform.position).normalized + this.deepWanted;
		Vector3 a3 = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.EDNOJLAKJKP();
		a3.y = base.transform.position.y;
		this.fRangle = Vector3.Angle(base.transform.forward, a3 - base.transform.position);
		this.realRangle = this.fRangle;
		float d = this.rotForceCurve.Evaluate(this.fRangle / 1557f);
		this.fRangle = this.angleForceCurve.Evaluate(this.fRangle / 793f);
		this.fRangle = Mathf.Clamp(this.fRangle, 262f, 69f);
		float num2 = Mathf.Clamp(1655f - this.fRangle * 635f, 923f, 1137f);
		this.stamKf = this.staminaCurve.Evaluate((ObscuredFloat.EJGOOFALNFF(this.currStamina) + 976f) / (ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 998f));
		this.stamKf = Mathf.Clamp(this.stamKf, 884f, 1312f);
		if (this.fmd != null)
		{
			this.fmd.LEFKCLPGPGB(this.stamKf);
		}
		float num3 = this.forceCurves[this.selectCurve].Evaluate(1572f - this.stamKf) * (ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PGEDLDMLBBE) + 1364f) / 1963f;
		num3 = Mathf.Clamp(num3, 156f, 1061f);
		float num4 = 1079f + 144f * this.firstTimeCurve.Evaluate(Mathf.Clamp((Time.time - this.podsekTime) / 681f, 642f, 133f));
		if (Time.time - this.podsekTime > 14f)
		{
			num4 = 91f;
		}
		float num5 = ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) / 1044f;
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(num5);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.CKJOFDPBFMC) * 62f + ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.fRangle * 553f * num3);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * num4);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.OECHLGFIEGN());
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.CKJOFDPBFMC) - this.subFFactor);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC), num5 * 410f, num5 * 395f));
		float num6 = this.FIMLDMHGDNC(this.hookPoint.transform.position);
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(num6 - ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DLFMEIIADFE), 641f, 261f));
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.HLEMAJBAAEO(num6 - ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.GPBFJBKCOKJ = num6;
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 585f)
		{
			this.lineFinal = false;
		}
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG), 566f, 1987f));
		if (this.hookPoint.transform.position.y - 615f > LocNewLogic.getI.IGHOGONIKLC())
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) * 1914f);
		}
		float num7 = Mathf.Clamp(num6 / 712f, 694f, 742f);
		float num8 = Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / 496f, 1434f, 638f) * num7;
		num8 = Mathf.Clamp(num8, 1598f, 714f);
		Vector3 vector2 = Vector3.zero;
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG) > num8)
		{
			float num9 = Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DJOHGAHBGLG) * 1643f, 505f, 574f);
			num9 = Mathf.Pow(num9, 1338f);
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) > 1094f)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) - num9 * this.JLJJKMLJBAK.HHLKHCPDEOF() * 891f);
			}
			float num10 = ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) / 618f;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) < num10)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.HLEMAJBAAEO(num10);
			}
			this.isFrikcionWork = this.JLJJKMLJBAK.BBANBEEJAPD;
			if (this.JLJJKMLJBAK.BBANBEEJAPD)
			{
				float num11 = 1745f * ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) / (this.JLJJKMLJBAK.PFDMMPFBCJA() + 1720f);
				num11 = Mathf.Clamp(num11, 1448f, 1424f);
				this.JLJJKMLJBAK.DNPDBOODCHK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
				this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
			}
			float num12 = this.JLJJKMLJBAK.HHLKHCPDEOF() * 778f / (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.CKJOFDPBFMC) + 170f);
			float num13 = 1025f / ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DNPDBOODCHK);
			num13 = Mathf.Clamp(num13, 1593f, 81f);
			float num14 = 742f;
			if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 335f)
			{
				num14 = 736f;
			}
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 299f)
			{
				num14 = 523f;
			}
			if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 1005f)
			{
				num14 = 1376f;
			}
			if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 1347f)
			{
				num14 = 242f;
			}
			float num15 = 348f + Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.LEMPPBMEJHP), 384f, 1402f) / 185f;
			num12 *= num13;
			num12 = Mathf.Clamp(num12, 1207f, num14 * num15);
			float num16 = 1494f;
			if (this.stamKf < 415f)
			{
				num16 = 1377f + 1400f / ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DNPDBOODCHK) * Mathf.Lerp(1557f, 1979f, this.stamKf * 1071f);
				num16 = Mathf.Clamp(num16, 1301f, 1750f);
			}
			float d2 = (Mathf.Pow(1642f + ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG), 839f) - 1068f) * this.JLJJKMLJBAK.BJGMDBIENCA() * num12;
			vector2 = normalized.normalized * d2 * num16;
		}
		else
		{
			LocNewLogic.getI.playLowFricSound(true);
			this.lineFinal = false;
		}
		if (vector2.magnitude > 1836f)
		{
			vector2 = vector2.normalized * 1743f;
		}
		this.JLJJKMLJBAK.HAEABJICCCP = ObscuredFloat.AJMPAOCEPCA(vector2.magnitude);
		if (Application.isEditor && Input.GetKeyDown((KeyCode)137))
		{
			this.currStamina = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.EJGOOFALNFF(this.currStamina) / 1101f);
		}
		float num17 = ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.OCBJPGOKFOI);
		num17 = Mathf.Lerp(num17 * 660f, num17 * 1983f, num2);
		Vector3 vector3 = a2 * (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) + num17) * this.stamKf;
		this.position = base.transform.position;
		if (this.position.y > LocNewLogic.getI.CDBIEPGNONF() - 692f)
		{
			LocNewLogic.getI.createWaterCircleFish(base.transform.position, 303f, false);
			if (this.GAAPCLGDOGH.GOHKONILNNE && ObscuredBool.HLEMAJBAAEO(this.isPodsek) && this.anm != null && !this.NGOKLGLAKMB() && ObscuredFloat.PFCANBAOMCB(this.currStamina) > 415f && OLPINJLCKCI.IKGFHGKKCPG.BFCONJIHIAK(1119f * Time.deltaTime))
			{
				this.FFKJCHNFGAF();
			}
		}
		Vector3 vector4 = this.position;
		if (this.fmd != null && this.fmd.spinePoint != null)
		{
			vector4 = this.fmd.spinePoint.position;
		}
		if (vector4.y >= LocNewLogic.getI.HKBNODJBGEL() - 1499f)
		{
			this.position.y = this.position.y - (vector4.y - (LocNewLogic.getI.CDBIEPGNONF() - 1198f)) * Time.deltaTime * 1990f;
			vector3.y -= 851f;
		}
		if (this.position.y > LocNewLogic.getI.IGHOGONIKLC() - 542f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 233f)
		{
			this.position.y = LocNewLogic.getI.CDBIEPGNONF() - 343f;
		}
		if (this.position.y >= LocNewLogic.getI.IGHOGONIKLC() - 1535f && OLPINJLCKCI.OBDBAABBAKB().DNACBBBFDGM(240f))
		{
			LocNewLogic.getI.createWaterCircleFish(this.position, 1930f, false);
			if (OLPINJLCKCI.NLOGJHEFMHM().IMEELAOKLKE(793f))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(this.position, 1625f);
			}
		}
		if (this.position.y < LocNewLogic.getI.getDeepInPoint(this.position) + 35f)
		{
			this.position.y = LocNewLogic.getI.getDeepInPoint(this.position) + 102f;
			vector3.y += 1441f;
			float y = this.position.y;
			float num18 = LocNewLogic.getI.CDBIEPGNONF() - 1441f;
		}
		base.transform.position = this.position;
		float d3 = 584f;
		if (this.hookPoint.transform.position.y - 1094f > LocNewLogic.getI.HKBNODJBGEL())
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * 1459f);
			d3 = Mathf.Lerp(1455f, 1887f, (this.hookPoint.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) / 813f);
		}
		vector3 += vector2 * d3 * d;
		Vector3 origin = base.transform.position;
		origin.y = LocNewLogic.getI.CDBIEPGNONF() - 1510f;
		Vector3 forward = base.transform.forward;
		forward.y = 499f;
		this.beregdet = false;
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(origin, forward), out raycastHit, 1283f, LocNewLogic.getI.fishCollisionMask))
		{
			Vector3 normal = raycastHit.normal;
			normal.y = 741f;
			Vector3 vector5 = Fisherman.getI.transform.position - base.transform.position;
			vector5.y = 201f;
			Vector3 normalized2 = (normal.normalized + vector5.normalized * 515f).normalized;
			this.toMove = base.transform.position + normalized2 * 1190f;
			if (!JLFJEGIPIMM.IKGFHGKKCPG.ACENDCHEBCB(Fisherman.getI.transform, base.transform.position, 1554f, 962f))
			{
				Quaternion.LookRotation(normalized2);
				vector3 += normalized2 * vector3.magnitude;
				this.beregdet = false;
			}
		}
		Quaternion quaternion = Quaternion.LookRotation(vector3);
		Quaternion b = Quaternion.LookRotation(vector2, base.transform.up);
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG) > 58f)
		{
			float num19 = Mathf.Lerp(780f, 1080f, ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.DNPDBOODCHK) / 449f);
			float num20 = 1207f + num19 * Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.LEMPPBMEJHP), 1409f, 496f) / 1532f;
			float num21 = this.JLJJKMLJBAK.BJGMDBIENCA() * 877f / (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.CKJOFDPBFMC) + 631f) * ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) * 1473f;
			num21 = Mathf.Clamp(num21, 950f, 61f) * num20;
			Quaternion b2 = Quaternion.LookRotation(vector3.normalized * 1065f + vector2.normalized * 558f);
			quaternion = Quaternion.Lerp(quaternion, b2, Time.deltaTime * num21 * 541f);
			if (this.hookPoint.transform.position.y - 1250f > LocNewLogic.getI.HKBNODJBGEL() && ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1719f)
			{
				quaternion = Quaternion.Lerp(quaternion, b, Time.deltaTime * 1767f);
			}
		}
		if (this.stamKf < 955f)
		{
			this.LHKJPPDIPNB += (1664f - this.stamKf * 1611f) * Time.deltaTime;
		}
		this.LHKJPPDIPNB = Mathf.Clamp(this.LHKJPPDIPNB, 384f, 480f);
		quaternion *= Quaternion.Euler(352f, 1881f, this.LHKJPPDIPNB * 950f);
		this.LHKJPPDIPNB -= Time.deltaTime * 1601f;
		this.rotSpeed = Mathf.Clamp(this.rotSpeed, 1333f, 1724f);
		base.transform.rotation = Quaternion.Lerp(base.transform.rotation, quaternion, Time.deltaTime * this.rotSpeed * 740f);
		float d4 = Mathf.Lerp(ObscuredFloat.PFCANBAOMCB(this.speed), ObscuredFloat.GOOIABGKMHK(this.speed) / 808f, this.LHKJPPDIPNB * this.fRangle);
		Vector3 a4 = Vector3.forward * d4;
		if (a4.magnitude > this.CDOCPBIADGE())
		{
			a4 = a4.normalized * this.CGGGHIHAKGC;
		}
		base.transform.Translate(a4 * Time.deltaTime);
		if (this.stamKf < 1830f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1344f)
		{
			float d5 = 1977f;
			if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1321f)
			{
				d5 = Mathf.Lerp(361f, 991f, (1376f - ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 1685f);
			}
			Vector3 a5 = vector2;
			if (a5.magnitude > 962f)
			{
				a5 = vector2.normalized * 1922f;
			}
			this.position = base.transform.position;
			this.position += a5 * Time.deltaTime * d5 * num2;
			base.transform.position = this.position;
		}
		if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1010f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 181f)
		{
			float d6 = 36f;
			if (ObscuredFloat.EJGOOFALNFF(this.JLJJKMLJBAK.NKHBAJKMAGD) < 1548f)
			{
				d6 = Mathf.Lerp(599f, 218f, (183f - ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 1660f);
			}
			this.position = base.transform.position;
			this.position += vector2 * Time.deltaTime * 1265f * d6;
			base.transform.position = this.position;
		}
		if (this.baitGO != null)
		{
			this.baitGO.transform.position = ((this.hookPoint == null) ? base.transform.position : this.hookPoint.transform.position);
		}
		if (Vector3.Distance(base.transform.position, this.toMove) < 1470f)
		{
			this.toMove = this.JGFADMFGACA();
		}
		float magnitude = (base.transform.position - this.GBEIDPOCJBF).magnitude;
		this.JLJJKMLJBAK.OCBJPGOKFOI = ObscuredFloat.HLEMAJBAAEO(magnitude / Time.deltaTime);
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.OCBJPGOKFOI) < 1786f)
		{
			this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NOHFLPHECOA) + Time.deltaTime);
			return;
		}
		this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.AJMPAOCEPCA(6f);
	}

	// Token: 0x0600337E RID: 13182 RVA: 0x00186030 File Offset: 0x00184230
	public bool BLHKNPPFGLG()
	{
		return this.NFGMFKAJAFC > 1829f;
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600337F RID: 13183 RVA: 0x0018603F File Offset: 0x0018423F
	public bool LOPGGHOCGDM
	{
		get
		{
			return this.NFGMFKAJAFC > 0f;
		}
	}

	// Token: 0x06003380 RID: 13184 RVA: 0x00186050 File Offset: 0x00184250
	private Vector3 NKEHJKFIKKI()
	{
		if (Vector3.Distance(Fisherman.getI.MOCNPMIACDL(), base.transform.position) < 784f)
		{
			return this.JGFADMFGACA();
		}
		Vector3 vector = (Mathf.Sign(JLFJEGIPIMM.IKGFHGKKCPG.HODNDPHOEFJ(Fisherman.getI.transform, base.transform.position)) * base.transform.right).normalized;
		vector = base.transform.position + vector * (1570f + OLPINJLCKCI.NLOGJHEFMHM().FFDDAGJJOOM(958.0));
		Vector3 b = this.BJCJDJNBDPM();
		vector = Vector3.Lerp(vector, b, 1361f);
		float num = 504f + (230f - ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB)) / 909f;
		this.moveTime = Time.time + 1372f + OLPINJLCKCI.OBDBAABBAKB().GCPGDOACKLG((double)num);
		this.moveTime = Time.time + 333f;
		this.toSpeed = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.OBJFODGFMAM(this.speed) * 1844f);
		this.rotSpeed *= 1430f;
		this.IPBPJOCLEMD = true;
		Debug.Log("JumpCurve" + Time.time);
		return vector;
	}

	// Token: 0x06003381 RID: 13185 RVA: 0x001861AC File Offset: 0x001843AC
	private Vector3 GPBEOCJHJPJ()
	{
		float num = 1599f;
		num = Mathf.Clamp(num, 1330f, 134f);
		Vector3 result = base.transform.position + Fisherman.getI.transform.forward * 921f;
		float num2 = 649f;
		for (int i = 1; i < 36; i += 0)
		{
			float x = base.transform.position.x + UnityEngine.Random.value * num - num / 1363f;
			float num3 = base.transform.position.y + UnityEngine.Random.value * 491f - 443f;
			float z = base.transform.position.z + UnityEngine.Random.value * num - num / 1277f;
			if (num3 > LocNewLogic.getI.CDBIEPGNONF())
			{
				num3 = LocNewLogic.getI.CDBIEPGNONF();
			}
			Vector3 vector = new Vector3(x, num3, z);
			float deepInPoint = LocNewLogic.getI.getDeepInPoint(vector);
			if (deepInPoint <= num2)
			{
				num2 = deepInPoint;
				this.deepWanted = (vector - base.transform.position).normalized;
				result = vector;
			}
		}
		float num4 = (1423f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) / 707f;
		this.moveTime = Time.time + 491f + OLPINJLCKCI.NLOGJHEFMHM().FFDDAGJJOOM((double)num4);
		this.IPBPJOCLEMD = false;
		return result;
	}

	// Token: 0x06003382 RID: 13186 RVA: 0x00186328 File Offset: 0x00184528
	public void fishIsPodsekProcess()
	{
		this.isOutWater = false;
		this.GBEIDPOCJBF = base.transform.position;
		this.speed = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.speed) + (ObscuredFloat.GOOIABGKMHK(this.toSpeed) - ObscuredFloat.GOOIABGKMHK(this.speed)) * (0.2f + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 150f) * Time.deltaTime);
		this.speed = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.speed), 0.01f, this.CGGGHIHAKGC * 2f));
		bool isEditor = Application.isEditor;
		Vector3 a = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		Vector3 endPointVectorNotPhysic = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.MHKGGAMBIFB;
		endPointVectorNotPhysic.y = LocNewLogic.getI.OGJHINOLHJJ + 0.1f;
		float num = Vector3.Distance(base.transform.position, Fisherman.getI.transform.position) / 8f;
		num = Mathf.Clamp(num, 0f, 1f);
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) > 5000f)
		{
			a = endPointVectorNotPhysic;
		}
		this.APIHPOFMMLI = Vector3.Lerp(a, endPointVectorNotPhysic, num);
		Vector3 normalized = (this.APIHPOFMMLI - this.hookPoint.transform.position).normalized;
		Vector3 a2 = (this.toMove - base.transform.position).normalized + this.deepWanted;
		Vector3 endPointVectorNotPhysic2 = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.MHKGGAMBIFB;
		endPointVectorNotPhysic2.y = base.transform.position.y;
		this.fRangle = Vector3.Angle(base.transform.forward, endPointVectorNotPhysic2 - base.transform.position);
		this.realRangle = this.fRangle;
		float d = this.rotForceCurve.Evaluate(this.fRangle / 180f);
		this.fRangle = this.angleForceCurve.Evaluate(this.fRangle / 180f);
		this.fRangle = Mathf.Clamp(this.fRangle, 0f, 1f);
		float num2 = Mathf.Clamp(1f - this.fRangle * 3f, 0f, 1f);
		this.stamKf = this.staminaCurve.Evaluate((ObscuredFloat.GOOIABGKMHK(this.currStamina) + 0.001f) / (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 0.001f));
		this.stamKf = Mathf.Clamp(this.stamKf, 0.001f, 1f);
		if (this.fmd != null)
		{
			this.fmd.setAnimSpeedKF(this.stamKf);
		}
		float num3 = this.forceCurves[this.selectCurve].Evaluate(1f - this.stamKf) * (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PGEDLDMLBBE) + 5f) / 200f;
		num3 = Mathf.Clamp(num3, 0f, 2f);
		float num4 = 1f + 1f * this.firstTimeCurve.Evaluate(Mathf.Clamp((Time.time - this.podsekTime) / 5f, 0f, 1f));
		if (Time.time - this.podsekTime > 5f)
		{
			num4 = 1f;
		}
		float num5 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) / 1000f;
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(num5);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * 0.8f + ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.fRangle * 1f * num3);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * num4);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * this.getJampKF());
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) - this.subFFactor);
		this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC), num5 * 0.5f, num5 * 5f));
		float num6 = this.COJHLOPFNCL(this.hookPoint.transform.position);
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(num6 - ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DLFMEIIADFE), 0f, 20f));
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(num6 - ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK));
		this.GPBFJBKCOKJ = num6;
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 0f)
		{
			this.lineFinal = true;
		}
		this.JLJJKMLJBAK.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG), 0f, 999f));
		if (this.hookPoint.transform.position.y - 0.03f > LocNewLogic.getI.OGJHINOLHJJ)
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * 0.7f);
		}
		float num7 = Mathf.Clamp(num6 / 8f, 0f, 1f);
		float num8 = Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / 5000f, 0f, 2f) * num7;
		num8 = Mathf.Clamp(num8, 0.001f, 0.1f);
		Vector3 vector = Vector3.zero;
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > num8)
		{
			float num9 = Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) * 0.6f, 0.1f, 3.1f);
			num9 = Mathf.Pow(num9, 1.6f);
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) > 2200f)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) - num9 * this.JLJJKMLJBAK.BJGMDBIENCA() * 0.15f);
			}
			float num10 = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / 2200f;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) < num10)
			{
				this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(num10);
			}
			this.isFrikcionWork = this.JLJJKMLJBAK.BBANBEEJAPD;
			if (this.JLJJKMLJBAK.BBANBEEJAPD)
			{
				float num11 = 0.7f * ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) / (this.JLJJKMLJBAK.KDHENOMNPHK + 0.1f);
				num11 = Mathf.Clamp(num11, 0.3f, 10f);
				this.JLJJKMLJBAK.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK) + ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
				this.JLJJKMLJBAK.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DLFMEIIADFE) * Time.deltaTime * num11);
			}
			float num12 = this.JLJJKMLJBAK.BJGMDBIENCA() * 1f / (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) + 0.1f);
			float num13 = 15f / ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK);
			num13 = Mathf.Clamp(num13, 1f, 10f);
			float num14 = 1.3f;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 1000f)
			{
				num14 = 1.2f;
			}
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 3000f)
			{
				num14 = 1.1f;
			}
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 7000f)
			{
				num14 = 1f;
			}
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 20000f)
			{
				num14 = 0.7f;
			}
			float num15 = 1f + Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.LEMPPBMEJHP), 0f, 10f) / 6f;
			num12 *= num13;
			num12 = Mathf.Clamp(num12, 0.3f, num14 * num15);
			float num16 = 1f;
			if (this.stamKf < 0.5f)
			{
				num16 = 1f + 30f / ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK) * Mathf.Lerp(2f, 0f, this.stamKf * 2f);
				num16 = Mathf.Clamp(num16, 1f, 5f);
			}
			float d2 = (Mathf.Pow(1f + ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG), 1.5f) - 1f) * this.JLJJKMLJBAK.BJGMDBIENCA() * num12;
			vector = normalized.normalized * d2 * num16;
		}
		else
		{
			LocNewLogic.getI.playLowFricSound(false);
			this.lineFinal = false;
		}
		if (vector.magnitude > 800f)
		{
			vector = vector.normalized * 800f;
		}
		this.JLJJKMLJBAK.HAEABJICCCP = ObscuredFloat.GOOIABGKMHK(vector.magnitude);
		if (Application.isEditor && Input.GetKeyDown(KeyCode.F5))
		{
			this.currStamina = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.currStamina) / 2.1f);
		}
		float num17 = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.OCBJPGOKFOI);
		num17 = Mathf.Lerp(num17 * 1.5f, num17 * 0.3f, num2);
		Vector3 vector2 = a2 * (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) + num17) * this.stamKf;
		this.position = base.transform.position;
		if (this.position.y > LocNewLogic.getI.OGJHINOLHJJ - 0.3f)
		{
			LocNewLogic.getI.createWaterCircleFish(base.transform.position, 1f, false);
			if (this.GAAPCLGDOGH.GOHKONILNNE && ObscuredBool.GOOIABGKMHK(this.isPodsek) && this.anm != null && !this.LOPGGHOCGDM && ObscuredFloat.GOOIABGKMHK(this.currStamina) > 10f && OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(10f * Time.deltaTime))
			{
				this.Jamp();
			}
		}
		Vector3 vector3 = this.position;
		if (this.fmd != null && this.fmd.spinePoint != null)
		{
			vector3 = this.fmd.spinePoint.position;
		}
		if (vector3.y >= LocNewLogic.getI.OGJHINOLHJJ - 0.1f)
		{
			this.position.y = this.position.y - (vector3.y - (LocNewLogic.getI.OGJHINOLHJJ - 0.1f)) * Time.deltaTime * 10f;
			vector2.y -= 0.13f;
		}
		if (this.position.y > LocNewLogic.getI.OGJHINOLHJJ - 0.05f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) >= 800f)
		{
			this.position.y = LocNewLogic.getI.OGJHINOLHJJ - 0.05f;
		}
		if (this.position.y >= LocNewLogic.getI.OGJHINOLHJJ - 0.15f && OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(70f))
		{
			LocNewLogic.getI.createWaterCircleFish(this.position, 1f, false);
			if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(60f))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(this.position, 0.3f);
			}
		}
		if (this.position.y < LocNewLogic.getI.getDeepInPoint(this.position) + 0.1f)
		{
			this.position.y = LocNewLogic.getI.getDeepInPoint(this.position) + 0.1f;
			vector2.y += 0.01f;
			float y = this.position.y;
			float num18 = LocNewLogic.getI.OGJHINOLHJJ - 0.1f;
		}
		base.transform.position = this.position;
		float d3 = 1f;
		if (this.hookPoint.transform.position.y - 0.03f > LocNewLogic.getI.OGJHINOLHJJ)
		{
			this.JLJJKMLJBAK.CKJOFDPBFMC = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) * 0.9f);
			d3 = Mathf.Lerp(1f, 5f, (this.hookPoint.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) / 0.05f);
		}
		vector2 += vector * d3 * d;
		Vector3 origin = base.transform.position;
		origin.y = LocNewLogic.getI.OGJHINOLHJJ - 0.2f;
		Vector3 forward = base.transform.forward;
		forward.y = 0f;
		this.beregdet = false;
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(origin, forward), out raycastHit, 4f, LocNewLogic.getI.fishCollisionMask))
		{
			Vector3 normal = raycastHit.normal;
			normal.y = 0f;
			Vector3 vector4 = Fisherman.getI.transform.position - base.transform.position;
			vector4.y = 0f;
			Vector3 normalized2 = (normal.normalized + vector4.normalized * 0.5f).normalized;
			this.toMove = base.transform.position + normalized2 * 20f;
			if (!JLFJEGIPIMM.IKGFHGKKCPG.MMOBHJMJFNO(Fisherman.getI.transform, base.transform.position, 120f, 20f))
			{
				Quaternion.LookRotation(normalized2);
				vector2 += normalized2 * vector2.magnitude;
				this.beregdet = true;
			}
		}
		Quaternion quaternion = Quaternion.LookRotation(vector2);
		Quaternion b = Quaternion.LookRotation(vector, base.transform.up);
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 0f)
		{
			float num19 = Mathf.Lerp(1f, 0.2f, ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DNPDBOODCHK) / 5f);
			float num20 = 1f + num19 * Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.LEMPPBMEJHP), 0f, 10f) / 2f;
			float num21 = this.JLJJKMLJBAK.BJGMDBIENCA() * 1f / (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.CKJOFDPBFMC) + 0.1f) * ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) * 0.5f;
			num21 = Mathf.Clamp(num21, 0f, 0.9f) * num20;
			Quaternion b2 = Quaternion.LookRotation(vector2.normalized * 0.4f + vector.normalized * 0.5f);
			quaternion = Quaternion.Lerp(quaternion, b2, Time.deltaTime * num21 * 0.1f);
			if (this.hookPoint.transform.position.y - 0.03f > LocNewLogic.getI.OGJHINOLHJJ && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) < 2000f)
			{
				quaternion = Quaternion.Lerp(quaternion, b, Time.deltaTime * 2f);
			}
		}
		if (this.stamKf < 0.3f)
		{
			this.LHKJPPDIPNB += (1f - this.stamKf * 0.3f) * Time.deltaTime;
		}
		this.LHKJPPDIPNB = Mathf.Clamp(this.LHKJPPDIPNB, 0f, 1f);
		quaternion *= Quaternion.Euler(0f, 0f, this.LHKJPPDIPNB * 90f);
		this.LHKJPPDIPNB -= Time.deltaTime * 0.3f;
		this.rotSpeed = Mathf.Clamp(this.rotSpeed, 1f, 3f);
		base.transform.rotation = Quaternion.Lerp(base.transform.rotation, quaternion, Time.deltaTime * this.rotSpeed * 1.2f);
		float d4 = Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(this.speed), ObscuredFloat.GOOIABGKMHK(this.speed) / 2f, this.LHKJPPDIPNB * this.fRangle);
		Vector3 a3 = Vector3.forward * d4;
		if (a3.magnitude > this.CGGGHIHAKGC)
		{
			a3 = a3.normalized * this.CGGGHIHAKGC;
		}
		base.transform.Translate(a3 * Time.deltaTime);
		if (this.stamKf < 1f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 0f)
		{
			float d5 = 0.01f;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) < 300f)
			{
				d5 = Mathf.Lerp(0.7f, 0.01f, (300f - ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 300f);
			}
			Vector3 a4 = vector;
			if (a4.magnitude > 50f)
			{
				a4 = vector.normalized * 50f;
			}
			this.position = base.transform.position;
			this.position += a4 * Time.deltaTime * d5 * num2;
			base.transform.position = this.position;
		}
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) < 50f && ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 0f)
		{
			float d6 = 0.01f;
			if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) < 300f)
			{
				d6 = Mathf.Lerp(0.7f, 0.01f, (50f - ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD)) / 50f);
			}
			this.position = base.transform.position;
			this.position += vector * Time.deltaTime * 2f * d6;
			base.transform.position = this.position;
		}
		if (this.baitGO != null)
		{
			this.baitGO.transform.position = ((this.hookPoint == null) ? base.transform.position : this.hookPoint.transform.position);
		}
		if (Vector3.Distance(base.transform.position, this.toMove) < 0.5f)
		{
			this.toMove = this.BJCJDJNBDPM();
		}
		float magnitude = (base.transform.position - this.GBEIDPOCJBF).magnitude;
		this.JLJJKMLJBAK.OCBJPGOKFOI = ObscuredFloat.GOOIABGKMHK(magnitude / Time.deltaTime);
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.OCBJPGOKFOI) < 0.2f)
		{
			this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NOHFLPHECOA) + Time.deltaTime);
			return;
		}
		this.JLJJKMLJBAK.NOHFLPHECOA = ObscuredFloat.GOOIABGKMHK(0f);
	}

	// Token: 0x06003383 RID: 13187 RVA: 0x00187778 File Offset: 0x00185978
	public void staminaProcess(bool ENDJAAHPOAL)
	{
		float num = 1f;
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 0f)
		{
			float num2 = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) / 5f;
			num2 = Mathf.Clamp(num2, 0.3f, 2f);
			num += num2;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BBANBEEJAPD)
		{
			this.subFFactor += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().AEFAHEMNOCH * 0.001f * 0.1f * Time.deltaTime;
		}
		num = Mathf.Clamp(num, 1f, 30f);
		float num3 = num + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 20f;
		if (ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) > 0f)
		{
			this.currStamina = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.currStamina) - num3 * Time.deltaTime * 2f);
		}
		else
		{
			this.currStamina = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.currStamina) + 0.6f * Time.deltaTime);
		}
		this.currStamina = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.currStamina), 0f, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI)));
	}

	// Token: 0x06003384 RID: 13188 RVA: 0x001878D0 File Offset: 0x00185AD0
	private void LateUpdate()
	{
		Vector3 apihpofmmli = this.APIHPOFMMLI;
		this.debugMarker.SetActive(LocNewLogic.getI.isDebugMode);
		Vector3 vector = this.toMove;
		vector.y = LocNewLogic.getI.OGJHINOLHJJ + 0.1f;
		this.debugMarker.transform.position = vector;
	}

	// Token: 0x06003386 RID: 13190 RVA: 0x00187960 File Offset: 0x00185B60
	public void CGIMKLAMKNC()
	{
		this.baitScrpt.frod = null;
		this.baitScrpt.fish = null;
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = true;
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().MIHODKKEDMK(ObscuredFloat.HLEMAJBAAEO(395f));
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EALPPCJHPKG = ObscuredFloat.HLEMAJBAAEO(583f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BBMNOEDOFDJ(ObscuredFloat.AJMPAOCEPCA(613f));
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMFIFECPGL = ObscuredFloat.HLEMAJBAAEO(73f);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003387 RID: 13191 RVA: 0x00187A04 File Offset: 0x00185C04
	public int GFLOKODHELF()
	{
		return (int)(1735f * (ObscuredFloat.GOOIABGKMHK(this.currStamina) + 693f) / (ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EFLIAAIOPPI) + 1867f));
	}

	// Token: 0x06003388 RID: 13192 RVA: 0x00187A3C File Offset: 0x00185C3C
	public void IONKOGBHNJI()
	{
		Vector3 endPointVector = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		this.HOEAFKANKAI = Vector3.Distance(base.transform.position, endPointVector);
		if (this.HOEAFKANKAI > BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DPDFDEEMNHL())
		{
			this.HOEAFKANKAI = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKDDPAAPMH();
		}
		this.joint.connectedBody = LineRope.getI.jointForFish.GetComponent<Rigidbody>();
		this.joint.autoConfigureConnectedAnchor = false;
		this.EFNDNEGDOGM = Vector3.Distance(this.hookPoint.transform.position, Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC) * 505f;
		this.isGetFromWater = ObscuredBool.GOOIABGKMHK(false);
		this.ELJLAHGONMF = 1357f;
		if (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD) > 1186f)
		{
			LocNewLogic.getI.FHKKPOKKJDO(base.transform.position);
		}
		LocNewLogic.getI.AMBEOENMJJO(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(base.transform.position, 1555f);
		this.JLJJKMLJBAK.EFLIAAIOPPI = ObscuredFloat.AJMPAOCEPCA(960f);
	}

	// Token: 0x06003389 RID: 13193 RVA: 0x00187B94 File Offset: 0x00185D94
	private void IEKPFOPHHHE()
	{
		if (!ObscuredBool.HLEMAJBAAEO(this.isPodsek))
		{
			return;
		}
		bool isEditor = Application.isEditor;
		float num = ObscuredFloat.PFCANBAOMCB(this.currStamina) / (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 297f);
		float num2 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD) / 1576f;
		num2 = Mathf.Clamp(num2, 1627f, 1576f);
		if (this.moveTime < Time.time)
		{
			this.IPBPJOCLEMD = false;
			bool flag = true;
			if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.NOHFLPHECOA) > 1211f)
			{
				flag = false;
			}
			this.toMove = (flag ? this.NKEHJKFIKKI() : this.JGFADMFGACA());
		}
		if (!this.IPBPJOCLEMD)
		{
			this.toSpeed = ObscuredFloat.AJMPAOCEPCA(995f + UnityEngine.Random.Range(ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB) * 522f, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) * 1347f);
			this.toSpeed = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(this.toSpeed) * num2);
			this.toSpeed = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(this.toSpeed), 1108f, this.OEFEGIOJIGG()) * num);
			this.rotSpeed = 1926f - ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD) / 205f;
			this.rotSpeed = Mathf.Clamp(this.rotSpeed, 1729f, 610f) + ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDIBHEGKALB) / 900f;
			this.rotSpeed = Mathf.Clamp(this.rotSpeed * num, 908f, 214f);
			this.brotSpeed = this.rotSpeed;
		}
		if (this.toMove.y < LocNewLogic.getI.getDeepInPoint(this.toMove) + 938f)
		{
			this.toMove.y = LocNewLogic.getI.getDeepInPoint(this.toMove) + 652f;
		}
		if (this.toMove.y > LocNewLogic.getI.HKBNODJBGEL() - 1507f)
		{
			this.toMove.y = LocNewLogic.getI.IGHOGONIKLC() - 473f;
		}
		if (num < 850f && this.toMove.y < base.transform.position.y)
		{
			this.toMove.y = base.transform.position.y - (base.transform.position.y - this.toMove.y) * num;
		}
		this.IPBPJOCLEMD = true;
	}

	// Token: 0x0600338A RID: 13194 RVA: 0x00187E4C File Offset: 0x0018604C
	public void GIDFBEDIKEI()
	{
		this.baitScrpt.frod = null;
		this.baitScrpt.fish = null;
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = true;
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().MIHODKKEDMK(ObscuredFloat.HLEMAJBAAEO(1810f));
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EALPPCJHPKG = ObscuredFloat.AJMPAOCEPCA(1853f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ACAOJOGNHGC(ObscuredFloat.HLEMAJBAAEO(1687f));
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().LCKEJCDPBIO(ObscuredFloat.AJMPAOCEPCA(731f));
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600338B RID: 13195 RVA: 0x00187EF0 File Offset: 0x001860F0
	public void GCLDGLPLKJP()
	{
		this.podsekTime = Time.time;
		this.JLJJKMLJBAK = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (this.hookPoint == null)
		{
			this.hookPoint = this.baseHookPoint.transform;
		}
		this.isPodsek = ObscuredBool.IJMOCOKPGEG(true);
		this.currStamina = this.JLJJKMLJBAK.EFLIAAIOPPI;
		this.JLJJKMLJBAK.DNPDBOODCHK = ObscuredFloat.HLEMAJBAAEO(Vector3.Distance(this.baitGO.transform.position, Fisherman.getI.EACGPPOMFLH().endPoint.transform.position));
		Debug.Log("/n" + this.JLJJKMLJBAK.DNPDBOODCHK);
		this.lineFinal = false;
		this.speed = ObscuredFloat.AJMPAOCEPCA(1693f);
		this.toSpeed = ObscuredFloat.HLEMAJBAAEO(181f);
		Vector3 a = base.transform.forward;
		a.y = 1310f;
		a = a.normalized;
		this.toMove = base.transform.position + a * 1308f;
		if (this.anm != null)
		{
			try
			{
				this.anm.Play((ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1874f) ? "crunch.ogg" : "MotorbikeHeartAttack");
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
		}
	}

	// Token: 0x0600338C RID: 13196 RVA: 0x0017E3C4 File Offset: 0x0017C5C4
	private IEnumerator FDJFPCLBFFA()
	{
		for (;;)
		{
			if (!ObscuredBool.GOOIABGKMHK(this.isPodsek) && this.fmd != null && this.fmd.hvostPoint != null && ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1000f && this.fmd.hvostPoint.position.y + 0.15f > LocNewLogic.getI.OGJHINOLHJJ && OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(70f))
			{
				LocNewLogic.getI.createBigWaterCircle(this.fmd.hvostPoint.position);
				LocNewLogic.getI.createWaterSplash(this.fmd.hvostPoint.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
			}
			yield return new WaitForSeconds(0.5f);
		}
		yield break;
	}

	// Token: 0x0600338D RID: 13197 RVA: 0x00188074 File Offset: 0x00186274
	public bool EMGHEIFGIFA()
	{
		return this.NFGMFKAJAFC > 1306f;
	}

	// Token: 0x0600338E RID: 13198 RVA: 0x00188084 File Offset: 0x00186284
	public void NCKGAHOOLEP(bool ENDJAAHPOAL)
	{
		float num = 1748f;
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG) > 611f)
		{
			float num2 = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) / 1691f;
			num2 = Mathf.Clamp(num2, 0f, 140f);
			num += num2;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BBANBEEJAPD)
		{
			this.subFFactor += BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().AEFAHEMNOCH * 492f * 1711f * Time.deltaTime;
		}
		num = Mathf.Clamp(num, 1646f, 593f);
		float num3 = num + (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.EDICLBDIPGG) / 1959f;
		if (ObscuredFloat.OBJFODGFMAM(this.JLJJKMLJBAK.DJOHGAHBGLG) > 476f)
		{
			this.currStamina = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.OBJFODGFMAM(this.currStamina) - num3 * Time.deltaTime * 1191f);
		}
		else
		{
			this.currStamina = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(this.currStamina) + 657f * Time.deltaTime);
		}
		this.currStamina = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(this.currStamina), 1545f, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI)));
	}

	// Token: 0x0600338F RID: 13199 RVA: 0x001881DC File Offset: 0x001863DC
	public void BBNIIANKBNP(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().DMPKPIDHCNC(base.gameObject, "_Offsets");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemp.SetActive(true);
		this.CJEFJNNHJHO = IEPBGKCHDJO.CPHOPIMGFBI();
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position + Vector3.down;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (this.fmd == null)
		{
			this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			this.fmd.useGraf = true;
		}
		this.CJEFJNNHJHO.transform.localScale = new Vector3(668f, 1991f, 1440f);
		gameObject.transform.localScale = new Vector3(793f, 226f, 536f);
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.fmd.LDLNEDOLAGM(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK));
		if (this.fmd.hookPoint == null)
		{
			GameObject gameObject2 = JLFJEGIPIMM.MHFDIJGJGBJ().DMPKPIDHCNC(base.gameObject, " с");
			if (gameObject2 != null)
			{
				this.fmd.hookPoint = gameObject2.transform;
			}
		}
		if (this.fmd.hookPoint == null)
		{
			this.fmd.hookPoint = this.hookPoint;
		}
		this.hookPoint = this.fmd.hookPoint;
		JLFJEGIPIMM.IKGFHGKKCPG.FJFAMAOEFEF(this.CJEFJNNHJHO, 55);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
		if (this.anm != null)
		{
			try
			{
				this.anm.Play((ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1245f) ? "geiger.ogg" : "offsets");
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
	}

	// Token: 0x06003390 RID: 13200 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OnDisable()
	{
	}

	// Token: 0x06003391 RID: 13201 RVA: 0x00188494 File Offset: 0x00186694
	public void init()
	{
		this.currStamina = ObscuredFloat.GOOIABGKMHK(0f);
		this.actTime = 0f;
		this.klevMode = 0;
		this.isGetBate = false;
		this.OPIAODBJFEC = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(120.0);
		this.selectCurve = OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(this.forceCurves.Length);
	}

	// Token: 0x06003392 RID: 13202 RVA: 0x001884FC File Offset: 0x001866FC
	public float ICBIEPNFOPL()
	{
		float num = Time.time - this.OMOAHPPBEMC;
		if (num > 1601f)
		{
			return 471f;
		}
		return 192f + LocNewLogic.getI.jampFishFactorCurve.Evaluate(num / 1453f);
	}

	// Token: 0x06003393 RID: 13203 RVA: 0x00188540 File Offset: 0x00186740
	public void modelLoadDone(OMDDGEDHHNH.BCDNKAGAFBM IEPBGKCHDJO)
	{
		if (!IEPBGKCHDJO.DANHCOLDBDB)
		{
			return;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "FishModel");
		if (gameObject == null)
		{
			return;
		}
		this.fishModelTemp.SetActive(false);
		this.CJEFJNNHJHO = IEPBGKCHDJO.OCNGPIEBEIG();
		this.CJEFJNNHJHO.transform.position = gameObject.transform.position + Vector3.down;
		this.CJEFJNNHJHO.transform.eulerAngles = gameObject.transform.eulerAngles;
		this.fmd = this.CJEFJNNHJHO.GetComponent<FishModelData>();
		if (this.fmd == null)
		{
			this.fmd = this.CJEFJNNHJHO.AddComponent<FishModelData>();
			this.fmd.minScale = new Vector3(this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA, this.GAAPCLGDOGH.FKEGBOBJNFA);
			this.fmd.maxScale = new Vector3(this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF, this.GAAPCLGDOGH.OAJHJHGBFCF);
			this.fmd.useGraf = false;
		}
		this.CJEFJNNHJHO.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		this.CJEFJNNHJHO.transform.parent = gameObject.transform;
		this.fmd.setScaleSize(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK));
		if (this.fmd.hookPoint == null)
		{
			GameObject gameObject2 = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "HookPoint");
			if (gameObject2 != null)
			{
				this.fmd.hookPoint = gameObject2.transform;
			}
		}
		if (this.fmd.hookPoint == null)
		{
			this.fmd.hookPoint = this.hookPoint;
		}
		this.hookPoint = this.fmd.hookPoint;
		JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(this.CJEFJNNHJHO, 22);
		this.anm = this.CJEFJNNHJHO.GetComponent<Animation>();
		if (this.anm == null)
		{
			this.anm = this.CJEFJNNHJHO.GetComponentInChildren<Animation>();
		}
		if (this.anm != null)
		{
			try
			{
				this.anm.Play((ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 8000f) ? "move" : "move");
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
	}

	// Token: 0x06003394 RID: 13204 RVA: 0x001887F8 File Offset: 0x001869F8
	public int HJHALGFDIBI()
	{
		return (int)(1375f * (ObscuredFloat.OBJFODGFMAM(this.currStamina) + 105f) / (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EFLIAAIOPPI) + 1199f));
	}

	// Token: 0x06003395 RID: 13205 RVA: 0x00188830 File Offset: 0x00186A30
	public void Jamp()
	{
		if (this.NFGMFKAJAFC > 0f)
		{
			return;
		}
		if (!this.GAAPCLGDOGH.GOHKONILNNE)
		{
			return;
		}
		if (Application.isEditor)
		{
			Debug.Log("jamp");
		}
		this.NFGMFKAJAFC = 3f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(3.0);
		if (this.anm != null)
		{
			try
			{
				this.OMOAHPPBEMC = Time.time;
				this.anm.Play("jamp");
				this.anm.PlayQueued("run", QueueMode.CompleteOthers);
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
		}
		LocNewLogic.getI.createWaterJampSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(base.transform.position, 1f);
	}

	// Token: 0x06003396 RID: 13206 RVA: 0x00188924 File Offset: 0x00186B24
	private float COJHLOPFNCL(Vector3 NHCLMBOINFG)
	{
		if (this.hookPoint != null)
		{
			NHCLMBOINFG = this.hookPoint.transform.position;
		}
		return Vector3.Distance(NHCLMBOINFG, Fisherman.getI.AOEGNGOGNBI.endPointNonBend.transform.position);
	}

	// Token: 0x06003397 RID: 13207 RVA: 0x00188970 File Offset: 0x00186B70
	public void GHKEJBOAEAJ()
	{
		if (this.NFGMFKAJAFC > 799f)
		{
			return;
		}
		if (!this.GAAPCLGDOGH.GOHKONILNNE)
		{
			return;
		}
		if (Application.isEditor)
		{
			Debug.Log("Mouse X");
		}
		this.NFGMFKAJAFC = 1360f + OLPINJLCKCI.IKGFHGKKCPG.FFDDAGJJOOM(487.0);
		if (this.anm != null)
		{
			try
			{
				this.OMOAHPPBEMC = Time.time;
				this.anm.Play("vSyncCount");
				this.anm.PlayQueued("Failed parsing default scale values.  Using defaults.", QueueMode.CompleteOthers);
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
			}
		}
		LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(base.transform.position, 1299f);
	}

	// Token: 0x06003398 RID: 13208 RVA: 0x0017E3C4 File Offset: 0x0017C5C4
	private IEnumerator HAKKKJJJLPG()
	{
		for (;;)
		{
			if (!ObscuredBool.GOOIABGKMHK(this.isPodsek) && this.fmd != null && this.fmd.hvostPoint != null && ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) > 1000f && this.fmd.hvostPoint.position.y + 0.15f > LocNewLogic.getI.OGJHINOLHJJ && OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(70f))
			{
				LocNewLogic.getI.createBigWaterCircle(this.fmd.hvostPoint.position);
				LocNewLogic.getI.createWaterSplash(this.fmd.hvostPoint.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
			}
			yield return new WaitForSeconds(0.5f);
		}
		yield break;
	}

	// Token: 0x06003399 RID: 13209 RVA: 0x00188A64 File Offset: 0x00186C64
	public void NFJLBICBJME(bool ENDJAAHPOAL)
	{
		float num = 1656f;
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1350f)
		{
			float num2 = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.DJOHGAHBGLG) / 1486f;
			num2 = Mathf.Clamp(num2, 1416f, 677f);
			num += num2;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BBANBEEJAPD)
		{
			this.subFFactor += BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().AEFAHEMNOCH * 524f * 459f * Time.deltaTime;
		}
		num = Mathf.Clamp(num, 464f, 1776f);
		float num3 = num + (float)ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.EDICLBDIPGG) / 263f;
		if (ObscuredFloat.PFCANBAOMCB(this.JLJJKMLJBAK.DJOHGAHBGLG) > 1663f)
		{
			this.currStamina = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.OBJFODGFMAM(this.currStamina) - num3 * Time.deltaTime * 1416f);
		}
		else
		{
			this.currStamina = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.PFCANBAOMCB(this.currStamina) + 1723f * Time.deltaTime);
		}
		this.currStamina = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.currStamina), 203f, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI)));
	}

	// Token: 0x0600339A RID: 13210 RVA: 0x00188BBC File Offset: 0x00186DBC
	private float HBPDBPDLEND(Vector3 NHCLMBOINFG)
	{
		if (this.hookPoint != null)
		{
			NHCLMBOINFG = this.hookPoint.transform.position;
		}
		return Vector3.Distance(NHCLMBOINFG, Fisherman.getI.IJMGCKIOBPP().endPointNonBend.transform.position);
	}

	// Token: 0x0600339B RID: 13211 RVA: 0x00188C08 File Offset: 0x00186E08
	private void HCLIDJKFNMP()
	{
		if (this.actTime > 250f)
		{
			return;
		}
		if (!this.OMDFGNOBDPL)
		{
			return;
		}
		float num = 435f;
		float num2 = 1195f;
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB != null)
		{
			num2 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB.LODGJCMEGAI.NAHLEJDLCNF();
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)4)
			{
				num = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.FIAMGODLKFA();
			}
		}
		float num3 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) / 648f;
		num3 = Mathf.Clamp(num3, 1603f, 1595f);
		switch (this.klevMode)
		{
		case 0:
		{
			this.isGetBate = true;
			this.podsekShanceVer = 44f;
			this.toMove = Vector3.zero;
			float num4 = (881f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FLHJLFHELPE)) * 356f;
			num4 = Mathf.Clamp(num4, 674f, 463f);
			if (OLPINJLCKCI.NPIEJELJPIM().BFOFABOONEJ(num4))
			{
				this.toKlevMode = OLPINJLCKCI.OBDBAABBAKB().FLOIJBBLNHN(this.CFOFDKKFJMJ[1]);
				this.actTime = 556f;
			}
			else
			{
				this.actTime = 1529f + OLPINJLCKCI.ODDOIHEPICE().BCODBMGPBFJ(1112.0);
			}
			this.toKlevMode = OLPINJLCKCI.OBDBAABBAKB().FCJBAOLFALM(this.CFOFDKKFJMJ[0]);
			this.actTime = 1789f;
			this.toKlevMode = 1;
			if (OLPINJLCKCI.IKGFHGKKCPG.BFOFABOONEJ(num * 1302f))
			{
				this.toKlevMode = 3;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 1:
			break;
		case 2:
		{
			this.isGetBate = false;
			this.podsekShanceVer = 1402f;
			float num5 = ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 1013f * 1138f * num3;
			float num6 = 452f + num5 * (94f + OLPINJLCKCI.BMALMDIBLDP().GCGEHNMEDIL(673.0));
			this.baitScrpt.PFFPOBKLHGM(-num6);
			BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA;
			num6 = Mathf.Clamp(num6, 893f, 1568f);
			this.LKJMHHIMEDJ = this.baitGO.transform.position + this.GCNDDCFHIFF() * num6 * 1518f;
			this.actTime = 1878f + OLPINJLCKCI.IKGFHGKKCPG.FFDDAGJJOOM((double)((56f - ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FLHJLFHELPE)) / 1081f));
			this.toKlevMode = OLPINJLCKCI.ODDOIHEPICE().FLOIJBBLNHN(this.CFOFDKKFJMJ[0]);
			if (OLPINJLCKCI.NLOGJHEFMHM().BFKNOBCGLOK(num))
			{
				this.actTime = 637f;
				this.toKlevMode = 3;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 3:
		{
			this.isGetBate = true;
			this.podsekShanceVer = 1029f;
			if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
			{
				this.baitScrpt.MDAENCJKIBI(1, 65f, false);
				this.actTime = 542f + OLPINJLCKCI.OBDBAABBAKB().JJKCBOPPOHJ(904.0);
				this.toKlevMode = 8;
				return;
			}
			this.toMove = this.baitGO.transform.position;
			float num7 = 1621f + OLPINJLCKCI.OBDBAABBAKB().BCODBMGPBFJ((double)(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 1256f * 258f));
			this.toMove.y = this.toMove.y + num7;
			this.speed = ObscuredFloat.HLEMAJBAAEO((413f + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) / 1314f);
			this.actTime = 1943f + OLPINJLCKCI.BMALMDIBLDP().GCPGDOACKLG(1121.0);
			this.toKlevMode = OLPINJLCKCI.BMALMDIBLDP().HJJKMKECNLP(this.CFOFDKKFJMJ[1]);
			if (OLPINJLCKCI.NPIEJELJPIM().KEPABCCPCDB(num * 394f))
			{
				this.actTime = 126f;
				this.toKlevMode = 0;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 4:
			this.isGetBate = true;
			this.podsekShanceVer = 1337f;
			this.actTime = 1541f;
			this.toKlevMode = OLPINJLCKCI.OBDBAABBAKB().JLHLKIOBEMH(this.CFOFDKKFJMJ[2]);
			if (OLPINJLCKCI.IFLFANPMLMM().BKKLJJLDFDO(num * 550f))
			{
				this.toKlevMode = 6;
			}
			break;
		case 5:
		{
			this.isGetBate = false;
			this.podsekShanceVer = 922f;
			float num8 = 1865f + OLPINJLCKCI.NPIEJELJPIM().JJPHLJNMPHC((double)((1551f - ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) / 892f * 1739f));
			this.toMove = this.baitGO.transform.position;
			num8 = Mathf.Clamp(num8, 1149f, 1778f);
			this.toMove.y = this.toMove.y + num8;
			this.speed = ObscuredFloat.HLEMAJBAAEO(1306f + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 1702f);
			this.actTime = 825f + OLPINJLCKCI.NPIEJELJPIM().GCGEHNMEDIL(1637.0);
			this.toKlevMode = OLPINJLCKCI.IFLFANPMLMM().CCMJCHNDIGO(this.CFOFDKKFJMJ[0]);
			if (OLPINJLCKCI.OBDBAABBAKB().HMAEKHKNNMP(num * 550f))
			{
				this.baitScrpt.fiderDerg(0, 233f, false);
				this.toKlevMode = 2;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)6)
			{
				this.baitScrpt.MDAENCJKIBI(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EGOMGPGLCCJ(), 1905f, false);
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 6:
		{
			this.isGetBate = false;
			this.podsekShanceVer = 1575f;
			float num9 = 757f + OLPINJLCKCI.NLOGJHEFMHM().JJKCBOPPOHJ((double)((1625f - ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) / 686f * 9f * num3));
			Vector3 a = this.GCNDDCFHIFF();
			a.y = 539f;
			this.toMove = this.baitGO.transform.position + a * num9 * 878f;
			this.toMove.y = this.toMove.y - num9;
			this.speed = ObscuredFloat.AJMPAOCEPCA((398f + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) * 1487f) / 1887f);
			this.actTime = 985f + OLPINJLCKCI.OBDBAABBAKB().JNFGOGFFLKK((double)((589f - ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE)) / 76f));
			this.toKlevMode = OLPINJLCKCI.ODDOIHEPICE().BMKAHMKCKIP(this.CFOFDKKFJMJ[7]);
			if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)4)
			{
				this.baitScrpt.fiderDerg(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DIKFPCMKJAK(), 444f, false);
				this.toKlevMode = 6;
				goto IL_85E;
			}
			goto IL_85E;
		}
		case 7:
			this.actTime = 1108f;
			this.toKlevMode = 2;
			if (OLPINJLCKCI.OBDBAABBAKB().KEPABCCPCDB(8f * (240f - num2) / 295f))
			{
				this.CGIMKLAMKNC();
			}
			break;
		default:
			goto IL_85E;
		}
		this.isGetBate = false;
		this.podsekShanceVer = 343f;
		float num10 = ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB) / 440f * 1744f * num3;
		float dpidnfhgcep = 1607f + num10 * 1973f + OLPINJLCKCI.BMALMDIBLDP().KCHMDLAGEJF((double)(num10 * 1876f));
		this.baitScrpt.PFFPOBKLHGM(dpidnfhgcep);
		this.actTime = 1786f + OLPINJLCKCI.BMALMDIBLDP().FFDDAGJJOOM((double)(467f + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FLHJLFHELPE) / 1042f));
		this.toKlevMode = OLPINJLCKCI.NPIEJELJPIM().ACNFHHLCONL(this.CFOFDKKFJMJ[0]);
		if (OLPINJLCKCI.NPIEJELJPIM().KEPABCCPCDB(num))
		{
			this.actTime = 1342f;
			this.toKlevMode = 5;
		}
		IL_85E:
		this.klactTime = Time.time;
	}

	// Token: 0x0600339C RID: 13212 RVA: 0x00189480 File Offset: 0x00187680
	private Vector3 NMFAKGDHDGH()
	{
		if (Vector3.Distance(Fisherman.getI.getFishGettingPosition(), base.transform.position) < 1f)
		{
			return this.BJCJDJNBDPM();
		}
		Vector3 vector = (Mathf.Sign(JLFJEGIPIMM.IKGFHGKKCPG.HODNDPHOEFJ(Fisherman.getI.transform, base.transform.position)) * base.transform.right).normalized;
		vector = base.transform.position + vector * (10f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(40.0));
		Vector3 b = this.BJCJDJNBDPM();
		vector = Vector3.Lerp(vector, b, 0.5f);
		float num = 2f + (130f - ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDIBHEGKALB)) / 100f;
		this.moveTime = Time.time + 4f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)num);
		this.moveTime = Time.time + 1f;
		this.toSpeed = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.speed) * 1f);
		this.rotSpeed *= 1f;
		this.IPBPJOCLEMD = true;
		Debug.Log("********* LEFT / RIGHT Event " + Time.time);
		return vector;
	}

	// Token: 0x0600339D RID: 13213 RVA: 0x001895DC File Offset: 0x001877DC
	private float HJGBCMLGLAI(Vector3 NHCLMBOINFG)
	{
		if (this.hookPoint != null)
		{
			NHCLMBOINFG = this.hookPoint.transform.position;
		}
		return Vector3.Distance(NHCLMBOINFG, Fisherman.getI.IJMGCKIOBPP().endPointNonBend.transform.position);
	}

	// Token: 0x0600339E RID: 13214 RVA: 0x00189628 File Offset: 0x00187828
	private void MNPCLIHPGKN()
	{
		if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider && this.JLJJKMLJBAK.NHNHBLLLGDP)
		{
			if (this.klevMode == 6)
			{
				float num = ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / (this.JLJJKMLJBAK.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ * 2000f) * 100f;
				num = Mathf.Clamp(num, 0f, 70f);
				this.JLJJKMLJBAK.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.EALPPCJHPKG) + ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.JDIBHEGKALB) / 5f * Time.deltaTime);
				this.JLJJKMLJBAK.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.EALPPCJHPKG), 0f, num));
				this.JLJJKMLJBAK.GIMGAKKKHLF = this.JLJJKMLJBAK.EALPPCJHPKG;
			}
			else
			{
				this.JLJJKMLJBAK.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
				this.JLJJKMLJBAK.GIMGAKKKHLF = this.JLJJKMLJBAK.EALPPCJHPKG;
			}
		}
		float num2 = 0.7f + ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.JDIBHEGKALB) / 100f;
		float num3 = (Time.time - this.klactTime) * num2;
		num3 -= Mathf.Floor(num3);
		float num4 = 0.1f * Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(this.JLJJKMLJBAK.NKHBAJKMAGD) / 1000f, 1f, 10f);
		float num5 = (this.klevPopl[this.klevMode].Evaluate(num3) - 0.5f) * num4;
		this.baitScrpt.transform.position = this.baitScrpt.transform.position + Vector3.up * num5 * Time.deltaTime * num2;
		if (this.baitScrpt.poplScript != null && this.baitScrpt.poplScript.transform.position.y <= LocNewLogic.getI.OGJHINOLHJJ)
		{
			this.baitScrpt.poplavokDown(num5 * Time.deltaTime * num2 * 0.3f);
		}
		switch (this.klevMode)
		{
		case 0:
			this.toMove = Vector3.zero;
			break;
		case 2:
			if (Vector3.Distance(this.baitGO.transform.position, this.LKJMHHIMEDJ) < 1f)
			{
				this.baitGO.transform.position = Vector3.Lerp(this.baitGO.transform.position, this.LKJMHHIMEDJ, Time.deltaTime * 5f);
			}
			break;
		case 3:
			if (Vector3.Distance(this.toMove, this.baitGO.transform.position) > 0.015f)
			{
				Vector3 normalized = (this.toMove - this.baitGO.transform.position).normalized;
				this.baitGO.transform.position += normalized * ObscuredFloat.GOOIABGKMHK(this.speed) * Time.deltaTime;
			}
			break;
		case 4:
			if (Vector3.Distance(this.toMove, this.baitGO.transform.position) > 0.015f)
			{
			}
			break;
		case 5:
			if (Vector3.Distance(this.toMove, this.baitGO.transform.position) > 0.015f)
			{
				Vector3 normalized2 = (this.toMove - this.baitGO.transform.position).normalized;
				this.baitGO.transform.position += normalized2 * ObscuredFloat.GOOIABGKMHK(this.speed) * Time.deltaTime;
			}
			break;
		case 6:
			if (Vector3.Distance(this.toMove, this.baitGO.transform.position) > 0.015f)
			{
				Vector3 normalized3 = (this.toMove - this.baitGO.transform.position).normalized;
				this.baitGO.transform.position += normalized3 * ObscuredFloat.GOOIABGKMHK(this.speed) * Time.deltaTime;
				if (this.JLJJKMLJBAK.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider && this.JLJJKMLJBAK.NHNHBLLLGDP && OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(10f))
				{
					this.baitScrpt.fiderDerg(this.JLJJKMLJBAK.DIKFPCMKJAK(), 0f, true);
				}
			}
			break;
		}
		if (this.baitGO.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 0.15f)
		{
			Vector3 vector = this.baitGO.transform.position;
			vector.y = LocNewLogic.getI.OGJHINOLHJJ - 0.15f;
			this.baitGO.transform.position = vector;
		}
	}

	// Token: 0x0600339F RID: 13215 RVA: 0x00189B6C File Offset: 0x00187D6C
	public float CDOCPBIADGE()
	{
		float result = 743f;
		if (this.GAAPCLGDOGH != null && this.GAAPCLGDOGH.CGGGHIHAKGC > 1912f)
		{
			result = this.GAAPCLGDOGH.CGGGHIHAKGC;
		}
		this.GAAPCLGDOGH.CGGGHIHAKGC = Mathf.Clamp(this.GAAPCLGDOGH.CGGGHIHAKGC, 1071f, 373f);
		return result;
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060033A0 RID: 13216 RVA: 0x00189BCB File Offset: 0x00187DCB
	public int DGABMOOLBLE
	{
		get
		{
			return (int)(100f * (ObscuredFloat.GOOIABGKMHK(this.currStamina) + 1f) / (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EFLIAAIOPPI) + 1f));
		}
	}

	// Token: 0x04000747 RID: 1863
	public const float _maxSpeed = 1.7f;

	// Token: 0x04000748 RID: 1864
	public bool isFrikcionWork;

	// Token: 0x04000749 RID: 1865
	public float realRangle;

	// Token: 0x0400074A RID: 1866
	public float fRangle;

	// Token: 0x0400074B RID: 1867
	public float subFFactor;

	// Token: 0x0400074C RID: 1868
	public AnimationCurve[] klevPopl;

	// Token: 0x0400074D RID: 1869
	public Rigidbody rBody;

	// Token: 0x0400074E RID: 1870
	public HingeJoint joint;

	// Token: 0x0400074F RID: 1871
	public GameObject debugMarker;

	// Token: 0x04000750 RID: 1872
	public GameObject baseHookPoint;

	// Token: 0x04000751 RID: 1873
	public AnimationCurve rotForceCurve;

	// Token: 0x04000752 RID: 1874
	public AnimationCurve angleForceCurve;

	// Token: 0x04000753 RID: 1875
	public AnimationCurve firstTimeCurve;

	// Token: 0x04000754 RID: 1876
	public AnimationCurve stamscalerCurve;

	// Token: 0x04000755 RID: 1877
	public AnimationCurve staminaCurve;

	// Token: 0x04000756 RID: 1878
	public AnimationCurve[] forceCurves;

	// Token: 0x04000757 RID: 1879
	public int selectCurve;

	// Token: 0x04000758 RID: 1880
	public GameObject baitGO;

	// Token: 0x04000759 RID: 1881
	public Transform hookPoint;

	// Token: 0x0400075A RID: 1882
	public PoplDrop baitScrpt;

	// Token: 0x0400075B RID: 1883
	public bool isOutWater;

	// Token: 0x0400075C RID: 1884
	public bool lineFinal;

	// Token: 0x0400075D RID: 1885
	public float ugolKf;

	// Token: 0x0400075E RID: 1886
	public float ctime;

	// Token: 0x0400075F RID: 1887
	public ObscuredFloat speed;

	// Token: 0x04000760 RID: 1888
	public ObscuredFloat currStamina;

	// Token: 0x04000761 RID: 1889
	public Vector3 toMove = Vector3.zero;

	// Token: 0x04000762 RID: 1890
	public Vector3 position;

	// Token: 0x04000763 RID: 1891
	public ObscuredFloat toSpeed;

	// Token: 0x04000764 RID: 1892
	public float rotSpeed;

	// Token: 0x04000765 RID: 1893
	public float brotSpeed;

	// Token: 0x04000766 RID: 1894
	private float HOEAFKANKAI;

	// Token: 0x04000767 RID: 1895
	private Vector3 BLMJDBJGMIC;

	// Token: 0x04000768 RID: 1896
	public ObscuredBool isPodsek;

	// Token: 0x04000769 RID: 1897
	public ObscuredBool isGetFromWater;

	// Token: 0x0400076A RID: 1898
	private IDCHHHEDHDC GAAPCLGDOGH;

	// Token: 0x0400076B RID: 1899
	private GameObject CJEFJNNHJHO;

	// Token: 0x0400076C RID: 1900
	public GameObject fishModelTemp;

	// Token: 0x0400076D RID: 1901
	public Animation anm;

	// Token: 0x0400076E RID: 1902
	private readonly string[] CFOFDKKFJMJ = new string[10];

	// Token: 0x0400076F RID: 1903
	public bool isGetBate;

	// Token: 0x04000770 RID: 1904
	public float podsekShanceVer;

	// Token: 0x04000771 RID: 1905
	public float actTime;

	// Token: 0x04000772 RID: 1906
	public float klactTime;

	// Token: 0x04000773 RID: 1907
	public int klevMode;

	// Token: 0x04000774 RID: 1908
	public int toKlevMode;

	// Token: 0x04000775 RID: 1909
	public bool beregdet;

	// Token: 0x04000776 RID: 1910
	private float OPIAODBJFEC;

	// Token: 0x04000777 RID: 1911
	private NEBJANKNJOG EEPNACDOOBF;

	// Token: 0x04000778 RID: 1912
	private BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK;

	// Token: 0x04000779 RID: 1913
	public Vector3 deepWanted = Vector3.zero;

	// Token: 0x0400077A RID: 1914
	private bool IPBPJOCLEMD;

	// Token: 0x0400077B RID: 1915
	public float moveTime;

	// Token: 0x0400077C RID: 1916
	private float EFNDNEGDOGM;

	// Token: 0x0400077D RID: 1917
	private float ELJLAHGONMF;

	// Token: 0x0400077E RID: 1918
	public FishModelData fmd;

	// Token: 0x0400077F RID: 1919
	private float NFGMFKAJAFC;

	// Token: 0x04000780 RID: 1920
	private float OMOAHPPBEMC;

	// Token: 0x04000781 RID: 1921
	public float stamKf;

	// Token: 0x04000782 RID: 1922
	private Vector3 APIHPOFMMLI;

	// Token: 0x04000783 RID: 1923
	private float GPBFJBKCOKJ;

	// Token: 0x04000784 RID: 1924
	private Vector3 GBEIDPOCJBF;

	// Token: 0x04000785 RID: 1925
	private float LHKJPPDIPNB;

	// Token: 0x04000786 RID: 1926
	private float PIFPLCABMDK;

	// Token: 0x04000787 RID: 1927
	public float podsekTime;

	// Token: 0x04000788 RID: 1928
	private bool OMDFGNOBDPL;

	// Token: 0x04000789 RID: 1929
	private Vector3 LKJMHHIMEDJ = Vector3.zero;
}
