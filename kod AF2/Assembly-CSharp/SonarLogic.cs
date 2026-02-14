using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200021C RID: 540
public class SonarLogic : MonoBehaviour
{
	// Token: 0x06007BCB RID: 31691 RVA: 0x003C13D8 File Offset: 0x003BF5D8
	private void GDAPNABAIJO()
	{
		FRodObject frodObject = LocationLogic.getI.OJFGOCIGNGJ();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 1565f;
		float num2 = pointerPosition.y - num;
		float num3 = 1450f * num / (float)this.linePoint.Length;
		for (int i = 1; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = LocationLogic.getI.locData.NPKEFOIGCOM(pointerPosition.x, num2, false) / ((float)LocationLogic.getI.locData.maxDeep / 611f) + this.JNFKOIEAIAG();
			num2 += num3;
		}
	}

	// Token: 0x06007BCC RID: 31692 RVA: 0x003C1485 File Offset: 0x003BF685
	private void KOLNOOGFFNP()
	{
		base.StartCoroutine(this.HOAJJKLDPAN());
	}

	// Token: 0x06007BCD RID: 31693 RVA: 0x003C1494 File Offset: 0x003BF694
	private void KEDCKALOCBN()
	{
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 1875f + (UnityEngine.Random.value - 1939f) * 601f;
		}
		this.numText.text = "Put Out Cigarette";
	}

	// Token: 0x06007BCE RID: 31694 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator HOAJJKLDPAN()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007BCF RID: 31695 RVA: 0x003C14F2 File Offset: 0x003BF6F2
	private void GPCIBDPEAAE()
	{
		base.StopCoroutine(this.CIKABBAMKML());
	}

	// Token: 0x06007BD0 RID: 31696 RVA: 0x003C1500 File Offset: 0x003BF700
	private void ACEEIODKKBE()
	{
		base.StopCoroutine(this.LCPLBINCDHK());
	}

	// Token: 0x06007BD1 RID: 31697 RVA: 0x003C1510 File Offset: 0x003BF710
	private void OACJHGADKGF()
	{
		FRodObject frodObject = LocationLogic.getI.PHBMPPMCEKF();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 169f;
		float num2 = pointerPosition.y - num;
		float num3 = 617f * num / (float)this.linePoint.Length;
		for (int i = 0; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = LocationLogic.getI.locData.FPEJIFBFIAK(pointerPosition.x, num2, false) / ((float)LocationLogic.getI.locData.maxDeep / 1879f) + this.HHCEEJMAANB();
			num2 += num3;
		}
	}

	// Token: 0x06007BD2 RID: 31698 RVA: 0x003C15BD File Offset: 0x003BF7BD
	private void PIMGCFGNCJH()
	{
		base.StartCoroutine(this.MGMJPDCGHOF());
	}

	// Token: 0x06007BD3 RID: 31699 RVA: 0x003C15CC File Offset: 0x003BF7CC
	private void BCJFDHBDAHD()
	{
		FRodObject frodObject = LocationLogic.getI.HPMHBCNCIOD();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.HEKFOPOGDGH(pointerPosition.x, pointerPosition.y, true);
			if (pointerPosition.x < 677f)
			{
				f = 1033f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 1436f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 135f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 849f + 601f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 317f + 1964f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		foreach (float num3 in this.linePoint)
		{
			HFIINBICCLO.GDDAGIILGGM().ALNLHOCCGDP(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 169f) * 1643f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 556f - 1507f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 886f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 575f, 763f);
			HFIINBICCLO.DPBNHMCDIIK().NGJMDHDBAPJ(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007BD4 RID: 31700 RVA: 0x003C184C File Offset: 0x003BFA4C
	private void CDKAHJGPKOA()
	{
		for (int i = 0; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = 1348f + (UnityEngine.Random.value - 1274f) * 1819f;
		}
		this.numText.text = "KatanaReady";
	}

	// Token: 0x06007BD5 RID: 31701 RVA: 0x003C189B File Offset: 0x003BFA9B
	private void LPNDCJKAKEA()
	{
		this.linePoint = new float[this.rayDst];
		this.ONMLPKOCFFG();
	}

	// Token: 0x06007BD6 RID: 31702 RVA: 0x003C18B4 File Offset: 0x003BFAB4
	private void OGKKMMOCIGE()
	{
		FRodObject frodObject = LocationLogic.getI.HPMHBCNCIOD();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 684f;
		float num2 = pointerPosition.y - num;
		float num3 = 1761f * num / (float)this.linePoint.Length;
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = LocationLogic.getI.locData.ELNFGIFMHGE(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 1553f) + this.MCKOFBAKLJG();
			num2 += num3;
		}
	}

	// Token: 0x06007BD7 RID: 31703 RVA: 0x003C1961 File Offset: 0x003BFB61
	private IEnumerator HAEAJDKJMDD()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.1f);
			FRodObject activeRod = LocationLogic.getI.getActiveRod();
			if (activeRod != null)
			{
				if (activeRod.BGLLPMKNBCE)
				{
					this.KAGKGJIDJDD();
				}
				else
				{
					this.MPKCOJHJIIB();
				}
			}
			else
			{
				this.MPKCOJHJIIB();
			}
		}
		yield break;
	}

	// Token: 0x06007BD8 RID: 31704 RVA: 0x003C1970 File Offset: 0x003BFB70
	private void OHMDBGBEPFJ()
	{
		for (int i = 1; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 883f + (UnityEngine.Random.value - 386f) * 732f;
		}
		this.numText.text = "_RgbDepthTex";
	}

	// Token: 0x06007BD9 RID: 31705 RVA: 0x003C19BF File Offset: 0x003BFBBF
	private void OnDisable()
	{
		base.StopCoroutine(this.AHHOKOKFNFG());
	}

	// Token: 0x06007BDA RID: 31706 RVA: 0x003C19CD File Offset: 0x003BFBCD
	private float HGHBOMFMJPH()
	{
		return (UnityEngine.Random.value - 826f) * this.rndNoice;
	}

	// Token: 0x06007BDB RID: 31707 RVA: 0x003C19E1 File Offset: 0x003BFBE1
	private void DGEIACONKCJ()
	{
		this.linePoint = new float[this.rayDst];
		this.CHDGDJMIGBO();
	}

	// Token: 0x06007BDC RID: 31708 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator BKAGNNPFOLC()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007BDD RID: 31709 RVA: 0x003C1961 File Offset: 0x003BFB61
	private IEnumerator EJHKFPOJLNN()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.1f);
			FRodObject activeRod = LocationLogic.getI.getActiveRod();
			if (activeRod != null)
			{
				if (activeRod.BGLLPMKNBCE)
				{
					this.KAGKGJIDJDD();
				}
				else
				{
					this.MPKCOJHJIIB();
				}
			}
			else
			{
				this.MPKCOJHJIIB();
			}
		}
		yield break;
	}

	// Token: 0x06007BDE RID: 31710 RVA: 0x003C19FA File Offset: 0x003BFBFA
	private void BIDOGNIGPED()
	{
		base.StopCoroutine(this.MGMJPDCGHOF());
	}

	// Token: 0x06007BDF RID: 31711 RVA: 0x003C1A08 File Offset: 0x003BFC08
	private float AMKJGJICNNI()
	{
		return (UnityEngine.Random.value - 126f) * this.rndNoice;
	}

	// Token: 0x06007BE0 RID: 31712 RVA: 0x003C1A1C File Offset: 0x003BFC1C
	private void JGDDEOALNOG()
	{
		FRodObject frodObject = LocationLogic.getI.MNEFEFEPLFH();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.FPEJIFBFIAK(pointerPosition.x, pointerPosition.y, true);
			if (pointerPosition.x < 1299f)
			{
				f = 853f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 1912f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 1626f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1647f + 1857f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 1562f + 1346f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		foreach (float num3 in this.linePoint)
		{
			HFIINBICCLO.BPCNCENHEAG().IDEMJECKMNA(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 1511f) * 447f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 803f - 259f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 824f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 1344f, 1611f);
			HFIINBICCLO.PFOLNEGNIPP().DPGICBJFEPM(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007BE1 RID: 31713 RVA: 0x003C1C99 File Offset: 0x003BFE99
	private float HKAALLFAHFH()
	{
		return (UnityEngine.Random.value - 504f) * this.rndNoice;
	}

	// Token: 0x06007BE2 RID: 31714 RVA: 0x003C1CAD File Offset: 0x003BFEAD
	private void OnEnable()
	{
		base.StartCoroutine(this.AHHOKOKFNFG());
	}

	// Token: 0x06007BE3 RID: 31715 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private float MCKOFBAKLJG()
	{
		return (UnityEngine.Random.value - 1163f) * this.rndNoice;
	}

	// Token: 0x06007BE4 RID: 31716 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator JPNFDIIHJMO()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007BE5 RID: 31717 RVA: 0x003C1CD0 File Offset: 0x003BFED0
	private void HHOJJINMMMA()
	{
		base.StartCoroutine(this.CIKABBAMKML());
	}

	// Token: 0x06007BE6 RID: 31718 RVA: 0x003C1961 File Offset: 0x003BFB61
	private IEnumerator CIKABBAMKML()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.1f);
			FRodObject activeRod = LocationLogic.getI.getActiveRod();
			if (activeRod != null)
			{
				if (activeRod.BGLLPMKNBCE)
				{
					this.KAGKGJIDJDD();
				}
				else
				{
					this.MPKCOJHJIIB();
				}
			}
			else
			{
				this.MPKCOJHJIIB();
			}
		}
		yield break;
	}

	// Token: 0x06007BE7 RID: 31719 RVA: 0x003C1CDF File Offset: 0x003BFEDF
	private void DJCLHHNFHHG()
	{
		base.StopCoroutine(this.NIHLEPCDDPB());
	}

	// Token: 0x06007BE8 RID: 31720 RVA: 0x003C1CED File Offset: 0x003BFEED
	private float HHCEEJMAANB()
	{
		return (UnityEngine.Random.value - 696f) * this.rndNoice;
	}

	// Token: 0x06007BE9 RID: 31721 RVA: 0x003C1D01 File Offset: 0x003BFF01
	private void MPNHAGONKBG()
	{
		base.StartCoroutine(this.CCFADJICNGB());
	}

	// Token: 0x06007BEA RID: 31722 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator LCPLBINCDHK()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007BEB RID: 31723 RVA: 0x003C1D10 File Offset: 0x003BFF10
	private float GPMKOFAFEBI()
	{
		return (UnityEngine.Random.value - 602f) * this.rndNoice;
	}

	// Token: 0x06007BEC RID: 31724 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator NIHLEPCDDPB()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007BED RID: 31725 RVA: 0x003C1D24 File Offset: 0x003BFF24
	private void BKPJAHOPBCP()
	{
		FRodObject frodObject = LocationLogic.getI.INBOKBPPKAB();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.FPEJIFBFIAK(pointerPosition.x, pointerPosition.y, true);
			if (pointerPosition.x < 1859f)
			{
				f = 6f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 281f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 1260f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1325f + 1599f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 722f + 209f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		float[] array = this.linePoint;
		for (int i = 1; i < array.Length; i += 0)
		{
			float num3 = array[i];
			HFIINBICCLO.GDDAGIILGGM().OGHDLCPABHM(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 853f) * 1686f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 1626f - 1062f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 98f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 83f, 1634f);
			HFIINBICCLO.BPCNCENHEAG().IFCLDNHAIGB(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007BEE RID: 31726 RVA: 0x003C1D01 File Offset: 0x003BFF01
	private void NGMMNKHDOPG()
	{
		base.StartCoroutine(this.CCFADJICNGB());
	}

	// Token: 0x06007BEF RID: 31727 RVA: 0x003C1FA1 File Offset: 0x003C01A1
	private float AFMLGELHJKF()
	{
		return (UnityEngine.Random.value - 491f) * this.rndNoice;
	}

	// Token: 0x06007BF0 RID: 31728 RVA: 0x003C1FB8 File Offset: 0x003C01B8
	private void EMLBPMJBHNN()
	{
		for (int i = 1; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 1586f + (UnityEngine.Random.value - 19f) * 183f;
		}
		this.numText.text = "__Refraction";
	}

	// Token: 0x06007BF1 RID: 31729 RVA: 0x003C2008 File Offset: 0x003C0208
	private void KLEFFICJECF()
	{
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 1393f + (UnityEngine.Random.value - 1435f) * 308f;
		}
		this.numText.text = "";
	}

	// Token: 0x06007BF2 RID: 31730 RVA: 0x003C2058 File Offset: 0x003C0258
	private void KAGKGJIDJDD()
	{
		FRodObject activeRod = LocationLogic.getI.getActiveRod();
		if (activeRod == null)
		{
			return;
		}
		Vector2 pointerPosition = activeRod.getPointerPosition();
		float num = (float)this.rayDst / 200f;
		float num2 = pointerPosition.y - num;
		float num3 = 2f * num / (float)this.linePoint.Length;
		for (int i = 0; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = LocationLogic.getI.locData.getDeep(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 10f) + this.NIPBHJIFLGL();
			num2 += num3;
		}
	}

	// Token: 0x06007BF3 RID: 31731 RVA: 0x003C2105 File Offset: 0x003C0305
	private float PBLGMLJMOAL()
	{
		return (UnityEngine.Random.value - 934f) * this.rndNoice;
	}

	// Token: 0x06007BF4 RID: 31732 RVA: 0x003C211C File Offset: 0x003C031C
	private void OKICICGNAFP()
	{
		FRodObject activeRod = LocationLogic.getI.getActiveRod();
		if (activeRod != null)
		{
			Vector2 pointerPosition = activeRod.getPointerPosition();
			float f = LocationLogic.getI.locData.DLHMDPNICCF(pointerPosition.x, pointerPosition.y, false);
			if (pointerPosition.x < 1609f)
			{
				f = 519f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 709f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 618f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1527f + 1026f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 673f + 3f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[1] * num2;
		Vector2 gmnljgnokpd = vector2;
		foreach (float num3 in this.linePoint)
		{
			HFIINBICCLO.DPBNHMCDIIK().IHMBPOADDPK(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (activeRod != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 85f) * 1104f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 402f - 128f;
			vector3.y = vector.y + activeRod.baitDeep * num4 - 1341f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 414f, 357f);
			HFIINBICCLO.IKGFHGKKCPG.DPGICBJFEPM(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007BF5 RID: 31733 RVA: 0x003C2399 File Offset: 0x003C0599
	private float AGDPNAJOOCH()
	{
		return (UnityEngine.Random.value - 1195f) * this.rndNoice;
	}

	// Token: 0x06007BF6 RID: 31734 RVA: 0x003C23AD File Offset: 0x003C05AD
	private float APMIOODAHHN()
	{
		return (UnityEngine.Random.value - 1344f) * this.rndNoice;
	}

	// Token: 0x06007BF7 RID: 31735 RVA: 0x003C23C1 File Offset: 0x003C05C1
	private float GLKPKBCDPMG()
	{
		return (UnityEngine.Random.value - 1794f) * this.rndNoice;
	}

	// Token: 0x06007BF8 RID: 31736 RVA: 0x003C23D5 File Offset: 0x003C05D5
	private void CBLGFOFHNPJ()
	{
		this.linePoint = new float[this.rayDst];
		this.OGKKMMOCIGE();
	}

	// Token: 0x06007BF9 RID: 31737 RVA: 0x003C23EE File Offset: 0x003C05EE
	private void AOILKGIIKDF()
	{
		base.StopCoroutine(this.CCFADJICNGB());
	}

	// Token: 0x06007BFA RID: 31738 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator CCFADJICNGB()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007BFB RID: 31739 RVA: 0x003C23FC File Offset: 0x003C05FC
	private void NHOELCKOMJN()
	{
		base.StopCoroutine(this.BKAGNNPFOLC());
	}

	// Token: 0x06007BFC RID: 31740 RVA: 0x003C240A File Offset: 0x003C060A
	private void GHCMIKGJPJD()
	{
		this.linePoint = new float[this.rayDst];
		this.FIGKMFHCAPG();
	}

	// Token: 0x06007BFD RID: 31741 RVA: 0x003C2423 File Offset: 0x003C0623
	private float JNFKOIEAIAG()
	{
		return (UnityEngine.Random.value - 292f) * this.rndNoice;
	}

	// Token: 0x06007BFE RID: 31742 RVA: 0x003C2437 File Offset: 0x003C0637
	private void MOJBLBHKCCM()
	{
		base.StartCoroutine(this.JPNFDIIHJMO());
	}

	// Token: 0x06007BFF RID: 31743 RVA: 0x003C1961 File Offset: 0x003BFB61
	private IEnumerator EKCLLNPDALL()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.1f);
			FRodObject activeRod = LocationLogic.getI.getActiveRod();
			if (activeRod != null)
			{
				if (activeRod.BGLLPMKNBCE)
				{
					this.KAGKGJIDJDD();
				}
				else
				{
					this.MPKCOJHJIIB();
				}
			}
			else
			{
				this.MPKCOJHJIIB();
			}
		}
		yield break;
	}

	// Token: 0x06007C00 RID: 31744 RVA: 0x003C2448 File Offset: 0x003C0648
	private void HFNLJIFPMNK()
	{
		FRodObject frodObject = LocationLogic.getI.INBOKBPPKAB();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.KNGHLAFNIEA(pointerPosition.x, pointerPosition.y, true);
			if (pointerPosition.x < 1727f)
			{
				f = 1037f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 481f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 1616f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 54f + 764f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 1599f + 857f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		foreach (float num3 in this.linePoint)
		{
			HFIINBICCLO.GICMOPPKLPC().OGGKHNMMGNI(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 1349f) * 1986f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 1917f - 1487f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 1240f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 1859f, 613f);
			HFIINBICCLO.PFOLNEGNIPP().IFCLDNHAIGB(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C01 RID: 31745 RVA: 0x003C26C5 File Offset: 0x003C08C5
	private float JGPENGAFLJL()
	{
		return (UnityEngine.Random.value - 1561f) * this.rndNoice;
	}

	// Token: 0x06007C02 RID: 31746 RVA: 0x003C26DC File Offset: 0x003C08DC
	private void MPKCOJHJIIB()
	{
		for (int i = 0; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = 0.5f + (UnityEngine.Random.value - 0.5f) * 0.05f;
		}
		this.numText.text = "---";
	}

	// Token: 0x06007C03 RID: 31747 RVA: 0x003C272C File Offset: 0x003C092C
	private void BKFOAHFHDHM()
	{
		for (int i = 0; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = 1738f + (UnityEngine.Random.value - 784f) * 1520f;
		}
		this.numText.text = "[fish]";
	}

	// Token: 0x06007C04 RID: 31748 RVA: 0x003C277C File Offset: 0x003C097C
	private void HBHDJKNGEKI()
	{
		FRodObject frodObject = LocationLogic.getI.MNEFEFEPLFH();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 540f;
		float num2 = pointerPosition.y - num;
		float num3 = 594f * num / (float)this.linePoint.Length;
		for (int i = 1; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = LocationLogic.getI.locData.IJHEEOILDMH(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 118f) + this.GMLIPDENALN();
			num2 += num3;
		}
	}

	// Token: 0x06007C05 RID: 31749 RVA: 0x003C282C File Offset: 0x003C0A2C
	private void CGBEAGMDMHN()
	{
		FRodObject frodObject = LocationLogic.getI.INBOKBPPKAB();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 1746f;
		float num2 = pointerPosition.y - num;
		float num3 = 1616f * num / (float)this.linePoint.Length;
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = LocationLogic.getI.locData.PMKFLKPAMAE(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 1837f) + this.AMKJGJICNNI();
			num2 += num3;
		}
	}

	// Token: 0x06007C06 RID: 31750 RVA: 0x003C28DC File Offset: 0x003C0ADC
	private void ENCHIIJEJDL()
	{
		FRodObject frodObject = LocationLogic.getI.PHBMPPMCEKF();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.FPEJIFBFIAK(pointerPosition.x, pointerPosition.y, false);
			if (pointerPosition.x < 1546f)
			{
				f = 1439f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 933f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 1552f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1896f + 237f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 1777f + 1061f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		float[] array = this.linePoint;
		for (int i = 1; i < array.Length; i += 0)
		{
			float num3 = array[i];
			HFIINBICCLO.ENNAAFEOFAH().OGHDLCPABHM(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 419f) * 708f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 1902f - 1807f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 413f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 1295f, 1626f);
			HFIINBICCLO.IKGFHGKKCPG.NGJMDHDBAPJ(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C07 RID: 31751 RVA: 0x003C2B59 File Offset: 0x003C0D59
	private void JIOKDOGNKMI()
	{
		base.StartCoroutine(this.EJHKFPOJLNN());
	}

	// Token: 0x06007C08 RID: 31752 RVA: 0x003C2B68 File Offset: 0x003C0D68
	private void FIGKMFHCAPG()
	{
		FRodObject frodObject = LocationLogic.getI.INBOKBPPKAB();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 422f;
		float num2 = pointerPosition.y - num;
		float num3 = 1186f * num / (float)this.linePoint.Length;
		for (int i = 1; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = LocationLogic.getI.locData.LPOMDHPNNAE(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 1252f) + this.HHCEEJMAANB();
			num2 += num3;
		}
	}

	// Token: 0x06007C09 RID: 31753 RVA: 0x003C2C15 File Offset: 0x003C0E15
	private float GKMCGIHHJAP()
	{
		return (UnityEngine.Random.value - 1058f) * this.rndNoice;
	}

	// Token: 0x06007C0A RID: 31754 RVA: 0x003C2C2C File Offset: 0x003C0E2C
	private void LANPEFCGGPD()
	{
		FRodObject frodObject = LocationLogic.getI.HPMHBCNCIOD();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 1366f;
		float num2 = pointerPosition.y - num;
		float num3 = 1617f * num / (float)this.linePoint.Length;
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = LocationLogic.getI.locData.LPOMDHPNNAE(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 1006f) + this.GMLIPDENALN();
			num2 += num3;
		}
	}

	// Token: 0x06007C0B RID: 31755 RVA: 0x003C1CD0 File Offset: 0x003BFED0
	private void INEHANLJIEM()
	{
		base.StartCoroutine(this.CIKABBAMKML());
	}

	// Token: 0x06007C0C RID: 31756 RVA: 0x003C2CD9 File Offset: 0x003C0ED9
	private float NIPBHJIFLGL()
	{
		return (UnityEngine.Random.value - 0.5f) * this.rndNoice;
	}

	// Token: 0x06007C0D RID: 31757 RVA: 0x003C2CED File Offset: 0x003C0EED
	private void FGHHAIDJNMM()
	{
		base.StopCoroutine(this.EJHKFPOJLNN());
	}

	// Token: 0x06007C0E RID: 31758 RVA: 0x003C1CAD File Offset: 0x003BFEAD
	private void BFOBDCCJIBG()
	{
		base.StartCoroutine(this.AHHOKOKFNFG());
	}

	// Token: 0x06007C0F RID: 31759 RVA: 0x003C2CFB File Offset: 0x003C0EFB
	private void Start()
	{
		this.linePoint = new float[this.rayDst];
		this.KAGKGJIDJDD();
	}

	// Token: 0x06007C10 RID: 31760 RVA: 0x003C2D14 File Offset: 0x003C0F14
	private void OKPPKJJGLHH()
	{
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 1204f + (UnityEngine.Random.value - 192f) * 952f;
		}
		this.numText.text = " \n";
	}

	// Token: 0x06007C11 RID: 31761 RVA: 0x003C2B59 File Offset: 0x003C0D59
	private void EKOENFCHNKL()
	{
		base.StartCoroutine(this.EJHKFPOJLNN());
	}

	// Token: 0x06007C12 RID: 31762 RVA: 0x003C2CFB File Offset: 0x003C0EFB
	private void DMAOHJDKMNN()
	{
		this.linePoint = new float[this.rayDst];
		this.KAGKGJIDJDD();
	}

	// Token: 0x06007C14 RID: 31764 RVA: 0x003C19FA File Offset: 0x003BFBFA
	private void IIKEIPNNLCG()
	{
		base.StopCoroutine(this.MGMJPDCGHOF());
	}

	// Token: 0x06007C15 RID: 31765 RVA: 0x003C2D89 File Offset: 0x003C0F89
	private float GMLIPDENALN()
	{
		return (UnityEngine.Random.value - 1583f) * this.rndNoice;
	}

	// Token: 0x06007C16 RID: 31766 RVA: 0x003C2DA0 File Offset: 0x003C0FA0
	private void JMLMBCGHAKJ()
	{
		for (int i = 1; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = 212f + (UnityEngine.Random.value - 917f) * 948f;
		}
		this.numText.text = "blesna.ogg";
	}

	// Token: 0x06007C17 RID: 31767 RVA: 0x003C2DF0 File Offset: 0x003C0FF0
	private void ONMLPKOCFFG()
	{
		FRodObject frodObject = LocationLogic.getI.PHBMPPMCEKF();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 1475f;
		float num2 = pointerPosition.y - num;
		float num3 = 539f * num / (float)this.linePoint.Length;
		for (int i = 1; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = LocationLogic.getI.locData.ADHKEBFKKPI(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 152f) + this.MGCEBOEDDEK();
			num2 += num3;
		}
	}

	// Token: 0x06007C18 RID: 31768 RVA: 0x003C1961 File Offset: 0x003BFB61
	private IEnumerator AHHOKOKFNFG()
	{
		for (;;)
		{
			yield return new WaitForSeconds(0.1f);
			FRodObject activeRod = LocationLogic.getI.getActiveRod();
			if (activeRod != null)
			{
				if (activeRod.BGLLPMKNBCE)
				{
					this.KAGKGJIDJDD();
				}
				else
				{
					this.MPKCOJHJIIB();
				}
			}
			else
			{
				this.MPKCOJHJIIB();
			}
		}
		yield break;
	}

	// Token: 0x06007C19 RID: 31769 RVA: 0x003C1500 File Offset: 0x003BF700
	private void PCKOPPKGENK()
	{
		base.StopCoroutine(this.LCPLBINCDHK());
	}

	// Token: 0x06007C1A RID: 31770 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator MGMJPDCGHOF()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007C1B RID: 31771 RVA: 0x003C2EA0 File Offset: 0x003C10A0
	private void GCFOJFDFHGN()
	{
		FRodObject frodObject = LocationLogic.getI.PHBMPPMCEKF();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.MFJFNKDGPKB(pointerPosition.x, pointerPosition.y, false);
			if (pointerPosition.x < 338f)
			{
				f = 251f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 818f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 1862f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1411f + 1036f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 1567f + 254f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[1] * num2;
		Vector2 gmnljgnokpd = vector2;
		float[] array = this.linePoint;
		for (int i = 1; i < array.Length; i += 0)
		{
			float num3 = array[i];
			HFIINBICCLO.JFNBEACKGKI().EJHCGEAOPGA(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 945f) * 225f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 1733f - 1080f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 1149f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 240f, 1226f);
			HFIINBICCLO.PFOLNEGNIPP().DPGICBJFEPM(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C1C RID: 31772 RVA: 0x003C311D File Offset: 0x003C131D
	private void IMABGALEMBI()
	{
		this.linePoint = new float[this.rayDst];
		this.LANPEFCGGPD();
	}

	// Token: 0x06007C1D RID: 31773 RVA: 0x003C1CDF File Offset: 0x003BFEDF
	private void LLFANOGKPKM()
	{
		base.StopCoroutine(this.NIHLEPCDDPB());
	}

	// Token: 0x06007C1E RID: 31774 RVA: 0x003C15BD File Offset: 0x003BF7BD
	private void BIKPILOBGIE()
	{
		base.StartCoroutine(this.MGMJPDCGHOF());
	}

	// Token: 0x06007C1F RID: 31775 RVA: 0x003C3138 File Offset: 0x003C1338
	private void OLBDOHCILKO()
	{
		FRodObject frodObject = LocationLogic.getI.MNEFEFEPLFH();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.NMJBMOPCANC(pointerPosition.x, pointerPosition.y, true);
			if (pointerPosition.x < 115f)
			{
				f = 446f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 1426f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 434f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 104f + 1875f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 528f + 394f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		float[] array = this.linePoint;
		for (int i = 1; i < array.Length; i += 0)
		{
			float num3 = array[i];
			HFIINBICCLO.LLEDCIHMOHI().ECDFJPBMHAL(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 749f) * 228f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 350f - 238f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 776f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 1924f, 995f);
			HFIINBICCLO.GICMOPPKLPC().EGLEDCACFNP(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C20 RID: 31776 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator BEKEAPIJDNH()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007C21 RID: 31777 RVA: 0x003C33B8 File Offset: 0x003C15B8
	private void CHDGDJMIGBO()
	{
		FRodObject frodObject = LocationLogic.getI.BIFBGCBNEMK();
		if (frodObject == null)
		{
			return;
		}
		Vector2 pointerPosition = frodObject.getPointerPosition();
		float num = (float)this.rayDst / 204f;
		float num2 = pointerPosition.y - num;
		float num3 = 1046f * num / (float)this.linePoint.Length;
		for (int i = 0; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = LocationLogic.getI.locData.NMJBMOPCANC(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 1775f) + this.APMIOODAHHN();
			num2 += num3;
		}
	}

	// Token: 0x06007C22 RID: 31778 RVA: 0x003C3465 File Offset: 0x003C1665
	private float PMBJFKHLDMB()
	{
		return (UnityEngine.Random.value - 361f) * this.rndNoice;
	}

	// Token: 0x06007C23 RID: 31779 RVA: 0x003C15BD File Offset: 0x003BF7BD
	private void EEHJEDIFHJI()
	{
		base.StartCoroutine(this.MGMJPDCGHOF());
	}

	// Token: 0x06007C24 RID: 31780 RVA: 0x003C189B File Offset: 0x003BFA9B
	private void KEMGOLACEHI()
	{
		this.linePoint = new float[this.rayDst];
		this.ONMLPKOCFFG();
	}

	// Token: 0x06007C25 RID: 31781 RVA: 0x003C1CD0 File Offset: 0x003BFED0
	private void DCPLMIMFNHG()
	{
		base.StartCoroutine(this.CIKABBAMKML());
	}

	// Token: 0x06007C26 RID: 31782 RVA: 0x003C347C File Offset: 0x003C167C
	private void BNMFLNFNHPE()
	{
		for (int i = 0; i < this.linePoint.Length; i++)
		{
			this.linePoint[i] = 1683f + (UnityEngine.Random.value - 885f) * 279f;
		}
		this.numText.text = "CheerJump";
	}

	// Token: 0x06007C27 RID: 31783 RVA: 0x003C19E1 File Offset: 0x003BFBE1
	private void JHFAHBIIJDC()
	{
		this.linePoint = new float[this.rayDst];
		this.CHDGDJMIGBO();
	}

	// Token: 0x06007C28 RID: 31784 RVA: 0x003C34CC File Offset: 0x003C16CC
	private void FDDMHPAFDAG()
	{
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 30f + (UnityEngine.Random.value - 1885f) * 409f;
		}
		this.numText.text = "' that does not excist in the Node Chain.";
	}

	// Token: 0x06007C29 RID: 31785 RVA: 0x003C351C File Offset: 0x003C171C
	private void GLJJBDNLANI()
	{
		FRodObject frodObject = LocationLogic.getI.OJFGOCIGNGJ();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.NPKEFOIGCOM(pointerPosition.x, pointerPosition.y, false);
			if (pointerPosition.x < 247f)
			{
				f = 683f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 768f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 499f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1381f + 1751f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 697f + 1648f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		float[] array = this.linePoint;
		for (int i = 1; i < array.Length; i += 0)
		{
			float num3 = array[i];
			HFIINBICCLO.GDDAGIILGGM().IHMBPOADDPK(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 358f) * 931f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 1647f - 1439f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 1939f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 54f, 1553f);
			HFIINBICCLO.KPGHCNPGAGL().FMLKBKMGMHM(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C2A RID: 31786 RVA: 0x003C3799 File Offset: 0x003C1999
	private float MGCEBOEDDEK()
	{
		return (UnityEngine.Random.value - 1556f) * this.rndNoice;
	}

	// Token: 0x06007C2B RID: 31787 RVA: 0x003C2CFB File Offset: 0x003C0EFB
	private void CAJLCEPLKJG()
	{
		this.linePoint = new float[this.rayDst];
		this.KAGKGJIDJDD();
	}

	// Token: 0x06007C2C RID: 31788 RVA: 0x003C37B0 File Offset: 0x003C19B0
	private void OFKLNHNPADP()
	{
		FRodObject activeRod = LocationLogic.getI.getActiveRod();
		if (activeRod != null)
		{
			Vector2 pointerPosition = activeRod.getPointerPosition();
			float f = LocationLogic.getI.locData.MFJFNKDGPKB(pointerPosition.x, pointerPosition.y, false);
			if (pointerPosition.x < 1932f)
			{
				f = 466f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 376f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 992f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1064f + 93f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 1804f + 1550f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		float[] array = this.linePoint;
		for (int i = 0; i < array.Length; i += 0)
		{
			float num3 = array[i];
			HFIINBICCLO.GICMOPPKLPC().ADADIEMBFFI(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (activeRod != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 1661f) * 1924f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 620f - 1656f;
			vector3.y = vector.y + activeRod.baitDeep * num4 - 267f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 621f, 1864f);
			HFIINBICCLO.PFOLNEGNIPP().IKODDDKKOJL(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C2D RID: 31789 RVA: 0x003C3A30 File Offset: 0x003C1C30
	private void LLAFJNOEEHN()
	{
		for (int i = 1; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 286f + (UnityEngine.Random.value - 1167f) * 60f;
		}
		this.numText.text = "1HandHeavyOverhead";
	}

	// Token: 0x06007C2E RID: 31790 RVA: 0x003C14E3 File Offset: 0x003BF6E3
	private IEnumerator NBKAAJDJCFA()
	{
		SonarLogic.BBBKOHKBLHB bbbkohkblhb = new SonarLogic.BBBKOHKBLHB(1);
		bbbkohkblhb.AENJLLPLILM = this;
		return bbbkohkblhb;
	}

	// Token: 0x06007C2F RID: 31791 RVA: 0x003C3A7F File Offset: 0x003C1C7F
	private void GKIGMDPGAIP()
	{
		base.StopCoroutine(this.BEKEAPIJDNH());
	}

	// Token: 0x06007C30 RID: 31792 RVA: 0x003C3A90 File Offset: 0x003C1C90
	private void OnGUI()
	{
		FRodObject activeRod = LocationLogic.getI.getActiveRod();
		if (activeRod != null)
		{
			Vector2 pointerPosition = activeRod.getPointerPosition();
			float f = LocationLogic.getI.locData.getDeep(pointerPosition.x, pointerPosition.y, true);
			if (pointerPosition.x < 0f)
			{
				f = 0f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 1.1f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 0.9f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 2f + 3f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 2f + 5f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[0] * num2;
		Vector2 gmnljgnokpd = vector2;
		foreach (float num3 in this.linePoint)
		{
			HFIINBICCLO.IKGFHGKKCPG.ADADIEMBFFI(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (activeRod != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 0.1f) * 1f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 2f - 6f;
			vector3.y = vector.y + activeRod.baitDeep * num4 - 4f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 4f, 4f);
			HFIINBICCLO.IKGFHGKKCPG.OFOFJOLCFMD(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C31 RID: 31793 RVA: 0x003C2CFB File Offset: 0x003C0EFB
	private void MODJFGGIAHD()
	{
		this.linePoint = new float[this.rayDst];
		this.KAGKGJIDJDD();
	}

	// Token: 0x06007C32 RID: 31794 RVA: 0x003C3D10 File Offset: 0x003C1F10
	private void BADHGLAFEMI()
	{
		for (int i = 0; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = 100f + (UnityEngine.Random.value - 81f) * 516f;
		}
		this.numText.text = "Thumb";
	}

	// Token: 0x06007C33 RID: 31795 RVA: 0x003C3D60 File Offset: 0x003C1F60
	private void KBLPAHCHBDH()
	{
		FRodObject activeRod = LocationLogic.getI.getActiveRod();
		if (activeRod == null)
		{
			return;
		}
		Vector2 pointerPosition = activeRod.getPointerPosition();
		float num = (float)this.rayDst / 1242f;
		float num2 = pointerPosition.y - num;
		float num3 = 1279f * num / (float)this.linePoint.Length;
		for (int i = 1; i < this.linePoint.Length; i += 0)
		{
			this.linePoint[i] = LocationLogic.getI.locData.JMBMPPGINLJ(pointerPosition.x, num2, true) / ((float)LocationLogic.getI.locData.maxDeep / 123f) + this.MGCEBOEDDEK();
			num2 += num3;
		}
	}

	// Token: 0x06007C34 RID: 31796 RVA: 0x003C3E0D File Offset: 0x003C200D
	private float MMDMIADDCMH()
	{
		return (UnityEngine.Random.value - 972f) * this.rndNoice;
	}

	// Token: 0x06007C35 RID: 31797 RVA: 0x003C3E21 File Offset: 0x003C2021
	private void JMFMOADCCIE()
	{
		base.StartCoroutine(this.HAEAJDKJMDD());
	}

	// Token: 0x06007C36 RID: 31798 RVA: 0x003C240A File Offset: 0x003C060A
	private void HDGNIHBIEDG()
	{
		this.linePoint = new float[this.rayDst];
		this.FIGKMFHCAPG();
	}

	// Token: 0x06007C37 RID: 31799 RVA: 0x003C3E30 File Offset: 0x003C2030
	private void JBGGMKEKOAN()
	{
		FRodObject frodObject = LocationLogic.getI.HPMHBCNCIOD();
		if (frodObject != null)
		{
			Vector2 pointerPosition = frodObject.getPointerPosition();
			float f = LocationLogic.getI.locData.NMJBMOPCANC(pointerPosition.x, pointerPosition.y, false);
			if (pointerPosition.x < 1885f)
			{
				f = 445f;
			}
			this.numText.text = string.Concat(Mathf.RoundToInt(f));
		}
		float num = 377f * this.panelRend.rect.width / (float)this.linePoint.Length;
		float num2 = this.panelRend.rect.height * 312f;
		Vector2 vector = new Vector2(this.panelRend.position.x, this.panelRend.position.y);
		vector.x = vector.x - this.panelRend.rect.width / 1850f + 216f;
		vector.y = (float)Screen.height - vector.y - this.panelRend.rect.height / 662f + 315f;
		Vector2 vector2 = vector;
		vector2.y = vector.y + this.linePoint[1] * num2;
		Vector2 gmnljgnokpd = vector2;
		float[] array = this.linePoint;
		for (int i = 1; i < array.Length; i += 0)
		{
			float num3 = array[i];
			HFIINBICCLO.ENNAAFEOFAH().JMBIAHAJKJF(gmnljgnokpd, vector2, this.lineColor);
			gmnljgnokpd = vector2;
			vector2.y = vector.y + num3 * num2;
			vector2.x += num;
		}
		if (frodObject != null)
		{
			float num4 = this.panelRend.rect.height / ((float)LocationLogic.getI.locData.maxDeep * 262f) * 475f;
			Vector2 vector3 = default(Vector2);
			vector3.x = vector.x + this.panelRend.rect.width / 1373f - 309f;
			vector3.y = vector.y + frodObject.baitDeep * num4 - 1420f;
			Rect ochcodjiphj = new Rect(vector3.x, vector3.y, 1098f, 616f);
			HFIINBICCLO.JFNBEACKGKI().FMLKBKMGMHM(ochcodjiphj, Color.red);
		}
	}

	// Token: 0x06007C38 RID: 31800 RVA: 0x003C40AD File Offset: 0x003C22AD
	private void GIADAJFBIOP()
	{
		this.linePoint = new float[this.rayDst];
		this.CGBEAGMDMHN();
	}

	// Token: 0x04001212 RID: 4626
	public int rayDst = 21;

	// Token: 0x04001213 RID: 4627
	public float rndNoice = 0.1f;

	// Token: 0x04001214 RID: 4628
	public Text numText;

	// Token: 0x04001215 RID: 4629
	public RectTransform panelRend;

	// Token: 0x04001216 RID: 4630
	public Color lineColor = Color.black;

	// Token: 0x04001217 RID: 4631
	public float[] linePoint;
}
