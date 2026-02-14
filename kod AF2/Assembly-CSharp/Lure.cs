using System;
using UnityEngine;

// Token: 0x0200011E RID: 286
[ExecuteInEditMode]
public class Lure : MonoBehaviour
{
	// Token: 0x06003ABB RID: 15035 RVA: 0x001A8C64 File Offset: 0x001A6E64
	[ContextMenu("*** init components")]
	public void InitPos()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003ABC RID: 15036 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FCCAIANLEFE()
	{
	}

	// Token: 0x06003ABD RID: 15037 RVA: 0x001A8CBC File Offset: 0x001A6EBC
	public void PDMNGJINGEI()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1390f;
			this.audioSrc.pitch = 852f + OLPINJLCKCI.ODDOIHEPICE().JNFGOGFFLKK((double)num) - num / 1576f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y) < 1251f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
	}

	// Token: 0x06003ABE RID: 15038 RVA: 0x001A8D58 File Offset: 0x001A6F58
	private void MEFOGCFJBNE()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(1698f * this.minRotation.x * this.animTime, 1842f * this.minRotation.y * this.animTime, 1526f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003ABF RID: 15039 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ONIHHFLOJMN()
	{
	}

	// Token: 0x06003AC0 RID: 15040 RVA: 0x001A8E1C File Offset: 0x001A701C
	private void LMGBKHCHPHO()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(1363f * this.minRotation.x * this.animTime, 603f * this.minRotation.y * this.animTime, 1479f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003AC1 RID: 15041 RVA: 0x001A8EE0 File Offset: 0x001A70E0
	public void ACFPLAMNCDH()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1945f;
			this.audioSrc.pitch = 1653f + OLPINJLCKCI.IKGFHGKKCPG.GCGEHNMEDIL((double)num) - num / 56f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y) < 825f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
	}

	// Token: 0x06003AC2 RID: 15042 RVA: 0x001A8F7C File Offset: 0x001A717C
	public void OLINLPMFFBD(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AC3 RID: 15043 RVA: 0x001A8FA8 File Offset: 0x001A71A8
	public void BGKGFBEPPPJ()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x001A9000 File Offset: 0x001A7200
	public void playEvent()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 0.1f;
			this.audioSrc.pitch = 1f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)num) - num / 2f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y) < 0.05f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
	}

	// Token: 0x06003AC5 RID: 15045 RVA: 0x001A909C File Offset: 0x001A729C
	public void PFHOFKIHPBA()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 680f;
			this.audioSrc.pitch = 260f + OLPINJLCKCI.IKGFHGKKCPG.LLNEEEJIDGI((double)num) - num / 756f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 919f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
	}

	// Token: 0x06003AC6 RID: 15046 RVA: 0x001A9138 File Offset: 0x001A7338
	public void LBAOHDONHAB()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AC7 RID: 15047 RVA: 0x001A9190 File Offset: 0x001A7390
	public void DNHEGAIOMAA(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AC8 RID: 15048 RVA: 0x001A91BC File Offset: 0x001A73BC
	public void IGECOAEBNOF()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1368f;
			this.audioSrc.pitch = 481f + OLPINJLCKCI.OBDBAABBAKB().JJPHLJNMPHC((double)num) - num / 1676f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 1027f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
	}

	// Token: 0x06003AC9 RID: 15049 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AOCDDBNBADJ()
	{
	}

	// Token: 0x06003ACA RID: 15050 RVA: 0x001A9258 File Offset: 0x001A7458
	public void OOOOLIJAHAD()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1162f;
			this.audioSrc.pitch = 1495f + OLPINJLCKCI.NLOGJHEFMHM().LLNEEEJIDGI((double)num) - num / 729f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y) < 1363f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
	}

	// Token: 0x06003ACB RID: 15051 RVA: 0x001A92F4 File Offset: 0x001A74F4
	public void MMPPANHNKKE(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003ACC RID: 15052 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDGALMCHPPH()
	{
	}

	// Token: 0x06003ACD RID: 15053 RVA: 0x001A9320 File Offset: 0x001A7520
	public void NOIAKMBJADC()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 754f;
			this.audioSrc.pitch = 1037f + OLPINJLCKCI.NLOGJHEFMHM().JNFGOGFFLKK((double)num) - num / 248f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y) < 1289f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
	}

	// Token: 0x06003ACE RID: 15054 RVA: 0x001A93BC File Offset: 0x001A75BC
	public void KKBCFGELBAD(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003ACF RID: 15055 RVA: 0x001A93E8 File Offset: 0x001A75E8
	public void PAPOGDDMJPL(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AD0 RID: 15056 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JFFPLABGMNF()
	{
	}

	// Token: 0x06003AD1 RID: 15057 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x06003AD2 RID: 15058 RVA: 0x001A9414 File Offset: 0x001A7614
	public void DGKPLHEPIGN(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AD3 RID: 15059 RVA: 0x001A9440 File Offset: 0x001A7640
	public void PKOIJDBNGGM()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AD4 RID: 15060 RVA: 0x001A9498 File Offset: 0x001A7698
	public void JOJPDDACCCO()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 99f;
			this.audioSrc.pitch = 546f + OLPINJLCKCI.NPIEJELJPIM().JNFGOGFFLKK((double)num) - num / 682f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y) < 657f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
	}

	// Token: 0x06003AD5 RID: 15061 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OPNPODKLOJK()
	{
	}

	// Token: 0x06003AD6 RID: 15062 RVA: 0x001A9534 File Offset: 0x001A7734
	public void MBPKJMOLOIF(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AD7 RID: 15063 RVA: 0x001A9560 File Offset: 0x001A7760
	public void BFLGNBKNOPH()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AD8 RID: 15064 RVA: 0x001A95B8 File Offset: 0x001A77B8
	public void AEMMCLLJMBE()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 493f;
			this.audioSrc.pitch = 809f + OLPINJLCKCI.NPIEJELJPIM().JJKCBOPPOHJ((double)num) - num / 1721f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 559f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
	}

	// Token: 0x06003AD9 RID: 15065 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PLBDELOIINH()
	{
	}

	// Token: 0x06003ADA RID: 15066 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DGEIACONKCJ()
	{
	}

	// Token: 0x06003ADB RID: 15067 RVA: 0x001A9654 File Offset: 0x001A7854
	public void DHGKBIDLIIH()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003ADC RID: 15068 RVA: 0x001A96AC File Offset: 0x001A78AC
	private void HONIFOPBBKC()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(1111f * this.minRotation.x * this.animTime, 182f * this.minRotation.y * this.animTime, 1330f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003ADD RID: 15069 RVA: 0x001A9770 File Offset: 0x001A7970
	public void GAOMFGPOAPP()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1677f;
			this.audioSrc.pitch = 1737f + OLPINJLCKCI.NPIEJELJPIM().JJKCBOPPOHJ((double)num) - num / 114f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.CDBIEPGNONF() - base.transform.position.y) < 1516f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
	}

	// Token: 0x06003ADE RID: 15070 RVA: 0x001A980C File Offset: 0x001A7A0C
	public void ILDFACNPMBJ()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 653f;
			this.audioSrc.pitch = 1736f + OLPINJLCKCI.BMALMDIBLDP().FFDDAGJJOOM((double)num) - num / 723f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y) < 326f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
	}

	// Token: 0x06003ADF RID: 15071 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BHFMGBNIAMC()
	{
	}

	// Token: 0x06003AE0 RID: 15072 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CPNOBMNKPNC()
	{
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CKGPEFOKKNL()
	{
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x001A98A8 File Offset: 0x001A7AA8
	private void IANJLHIIGLN()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(995f * this.minRotation.x * this.animTime, 1322f * this.minRotation.y * this.animTime, 176f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003AE3 RID: 15075 RVA: 0x001A996C File Offset: 0x001A7B6C
	public void DFAGFKGIPHC()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AE4 RID: 15076 RVA: 0x001A99C4 File Offset: 0x001A7BC4
	public void DGKKJCHJAFK(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AE5 RID: 15077 RVA: 0x001A99F0 File Offset: 0x001A7BF0
	private void Update()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(360f * this.minRotation.x * this.animTime, 360f * this.minRotation.y * this.animTime, 360f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003AE6 RID: 15078 RVA: 0x001A9AB4 File Offset: 0x001A7CB4
	public void CFCDDKGDAFC(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AE7 RID: 15079 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ADLHNBEDHMJ()
	{
	}

	// Token: 0x06003AE8 RID: 15080 RVA: 0x001A9AE0 File Offset: 0x001A7CE0
	public void KOPJHJHHNIB()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AE9 RID: 15081 RVA: 0x001A9B38 File Offset: 0x001A7D38
	public void JJBFHMFNIDK()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1403f;
			this.audioSrc.pitch = 59f + OLPINJLCKCI.IKGFHGKKCPG.JJPHLJNMPHC((double)num) - num / 53f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y) < 469f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
	}

	// Token: 0x06003AEA RID: 15082 RVA: 0x001A9BD4 File Offset: 0x001A7DD4
	public void DGPGAHLOKOO(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AEB RID: 15083 RVA: 0x001A9C00 File Offset: 0x001A7E00
	public void IJIGLBINGCM()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1362f;
			this.audioSrc.pitch = 1997f + OLPINJLCKCI.IKGFHGKKCPG.JJPHLJNMPHC((double)num) - num / 214f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y) < 364f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
	}

	// Token: 0x06003AEC RID: 15084 RVA: 0x001A9C9C File Offset: 0x001A7E9C
	public void LAEAONJOLAE()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AED RID: 15085 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DMAOHJDKMNN()
	{
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x001A9CF4 File Offset: 0x001A7EF4
	public void CBBEEAFGHMC()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1020f;
			this.audioSrc.pitch = 993f + OLPINJLCKCI.BMALMDIBLDP().LLNEEEJIDGI((double)num) - num / 854f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y) < 1743f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 0);
		}
	}

	// Token: 0x06003AEF RID: 15087 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LPNDCJKAKEA()
	{
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x001A9D90 File Offset: 0x001A7F90
	public void FKIHJALPLJK(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AF1 RID: 15089 RVA: 0x001A9DBC File Offset: 0x001A7FBC
	private void PAKOHKKBKHD()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(1024f * this.minRotation.x * this.animTime, 1541f * this.minRotation.y * this.animTime, 117f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003AF2 RID: 15090 RVA: 0x001A9E80 File Offset: 0x001A8080
	public void MJCGLLAKHJO()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AF3 RID: 15091 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EFCCCKGCOCB()
	{
	}

	// Token: 0x06003AF4 RID: 15092 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FFIGGPHAIBP()
	{
	}

	// Token: 0x06003AF5 RID: 15093 RVA: 0x001A9ED8 File Offset: 0x001A80D8
	private void IOGAKGCADBL()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(1952f * this.minRotation.x * this.animTime, 1561f * this.minRotation.y * this.animTime, 1696f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003AF6 RID: 15094 RVA: 0x001A9F9C File Offset: 0x001A819C
	private void EDANNBFJHIK()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(977f * this.minRotation.x * this.animTime, 1003f * this.minRotation.y * this.animTime, 597f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003AF7 RID: 15095 RVA: 0x001AA060 File Offset: 0x001A8260
	public void OCNDDDCJINJ()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003AF8 RID: 15096 RVA: 0x001AA0B8 File Offset: 0x001A82B8
	public void DBFEJHHEDAC()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 182f;
			this.audioSrc.pitch = 723f + OLPINJLCKCI.ODDOIHEPICE().GCGEHNMEDIL((double)num) - num / 577f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 1597f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
	}

	// Token: 0x06003AF9 RID: 15097 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KEMGOLACEHI()
	{
	}

	// Token: 0x06003AFA RID: 15098 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HHGGCBLOJGB()
	{
	}

	// Token: 0x06003AFB RID: 15099 RVA: 0x001AA154 File Offset: 0x001A8354
	public void EBHEDMBMDKL(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003AFC RID: 15100 RVA: 0x001AA180 File Offset: 0x001A8380
	public void PHIDGLLJLFK()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1192f;
			this.audioSrc.pitch = 538f + OLPINJLCKCI.IFLFANPMLMM().FFDDAGJJOOM((double)num) - num / 785f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y) < 1159f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
	}

	// Token: 0x06003AFD RID: 15101 RVA: 0x001AA21C File Offset: 0x001A841C
	private void JMNNAPNJDNK()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(9f * this.minRotation.x * this.animTime, 521f * this.minRotation.y * this.animTime, 1537f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003AFE RID: 15102 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FIJKDFIMELM()
	{
	}

	// Token: 0x06003B00 RID: 15104 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ELADFDNPOOI()
	{
	}

	// Token: 0x06003B01 RID: 15105 RVA: 0x001AA2F4 File Offset: 0x001A84F4
	public void HGCGHJDIJJG(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BGCLAKJHAFK()
	{
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x001AA320 File Offset: 0x001A8520
	public void MGHHJHKIEAG()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1439f;
			this.audioSrc.pitch = 881f + OLPINJLCKCI.OBDBAABBAKB().BCODBMGPBFJ((double)num) - num / 1686f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 1159f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x001AA3BC File Offset: 0x001A85BC
	public void MODKJPBNKOD()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1783f;
			this.audioSrc.pitch = 810f + OLPINJLCKCI.BMALMDIBLDP().JNFGOGFFLKK((double)num) - num / 410f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 594f)
		{
			LocNewLogic.getI.createWaterCircleSmall(base.transform.position, 1);
		}
	}

	// Token: 0x06003B05 RID: 15109 RVA: 0x001AA458 File Offset: 0x001A8658
	public void DAJEPLGENOC(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003B06 RID: 15110 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CGMHGDEKDEP()
	{
	}

	// Token: 0x06003B07 RID: 15111 RVA: 0x001AA484 File Offset: 0x001A8684
	private void BEDAJLJFAFO()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(123f * this.minRotation.x * this.animTime, 1276f * this.minRotation.y * this.animTime, 1213f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003B08 RID: 15112 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NOKJMMDMJNO()
	{
	}

	// Token: 0x06003B09 RID: 15113 RVA: 0x001AA548 File Offset: 0x001A8748
	private void MPLCAGFGEBO()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(1436f * this.minRotation.x * this.animTime, 1095f * this.minRotation.y * this.animTime, 50f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003B0A RID: 15114 RVA: 0x001AA60C File Offset: 0x001A880C
	public void IAIOHAINBJO()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003B0B RID: 15115 RVA: 0x001AA664 File Offset: 0x001A8864
	public void IJEGDNGJJCA()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003B0C RID: 15116 RVA: 0x001AA6BC File Offset: 0x001A88BC
	public void ECACICEPICG()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 1554f;
			this.audioSrc.pitch = 783f + OLPINJLCKCI.NPIEJELJPIM().BCODBMGPBFJ((double)num) - num / 1833f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 1501f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 1);
		}
	}

	// Token: 0x06003B0D RID: 15117 RVA: 0x001AA758 File Offset: 0x001A8958
	public void MJNHLHBPEKG()
	{
		if (this.audioSrc != null && !this.audioSrc.isPlaying)
		{
			float num = 669f;
			this.audioSrc.pitch = 440f + OLPINJLCKCI.IKGFHGKKCPG.GKDBPBFOINB((double)num) - num / 775f;
			this.audioSrc.Play();
		}
		if (Mathf.Abs(LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y) < 1226f)
		{
			LocNewLogic.getI.FAMPBINAPBA(base.transform.position, 0);
		}
	}

	// Token: 0x06003B0E RID: 15118 RVA: 0x001AA7F4 File Offset: 0x001A89F4
	public void LCMABGFFJAL()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003B0F RID: 15119 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NCALLFHEAGJ()
	{
	}

	// Token: 0x06003B10 RID: 15120 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IJOCHELLKJH()
	{
	}

	// Token: 0x06003B11 RID: 15121 RVA: 0x001AA84C File Offset: 0x001A8A4C
	public void HDFBJNOCCFM(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003B12 RID: 15122 RVA: 0x001AA878 File Offset: 0x001A8A78
	public void MNFKMKIFCAH()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003B13 RID: 15123 RVA: 0x001AA8D0 File Offset: 0x001A8AD0
	public void JALNBDJCJPO(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x001AA8FC File Offset: 0x001A8AFC
	public void CELCBNKPEFO()
	{
		if (this.lureObject != null)
		{
			this.minRotation = this.lureObject.transform.localRotation.eulerAngles;
			this.maxRotation = this.lureObject.transform.localRotation.eulerAngles;
		}
	}

	// Token: 0x06003B15 RID: 15125 RVA: 0x001AA954 File Offset: 0x001A8B54
	public void setAnimationTime(float MLEAOHDPMPC, float FNLIGABBMFB)
	{
		float num = Mathf.Abs(MLEAOHDPMPC * this.animScaleTime);
		this.animTime = num - Mathf.Floor(num);
	}

	// Token: 0x06003B16 RID: 15126 RVA: 0x001AA980 File Offset: 0x001A8B80
	private void AIAMIFEPALP()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(6f * this.minRotation.x * this.animTime, 1004f * this.minRotation.y * this.animTime, 525f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x06003B17 RID: 15127 RVA: 0x001AAA44 File Offset: 0x001A8C44
	private void HABONMJNDAL()
	{
		if (this.lureObject != null)
		{
			Quaternion a = Quaternion.Euler(this.minRotation);
			Quaternion b = Quaternion.Euler(this.maxRotation);
			if (this.fullRotate)
			{
				this.lureObject.transform.localRotation = Quaternion.Euler(1148f * this.minRotation.x * this.animTime, 238f * this.minRotation.y * this.animTime, 381f * this.minRotation.z * this.animTime);
				return;
			}
			this.lureObject.transform.localRotation = Quaternion.LerpUnclamped(a, b, this.animCrv.Evaluate(this.animTime));
		}
	}

	// Token: 0x04000832 RID: 2098
	public AudioSource audioSrc;

	// Token: 0x04000833 RID: 2099
	public Lure.AKCCILPKJMN lureType;

	// Token: 0x04000834 RID: 2100
	public Transform linePoint;

	// Token: 0x04000835 RID: 2101
	public Transform fishHookPoint;

	// Token: 0x04000836 RID: 2102
	public Transform trailPoint;

	// Token: 0x04000837 RID: 2103
	public Transform lureObject;

	// Token: 0x04000838 RID: 2104
	public AnimationCurve animCrv;

	// Token: 0x04000839 RID: 2105
	public float animScaleTime = 1f;

	// Token: 0x0400083A RID: 2106
	[Range(0f, 1f)]
	public float animTime;

	// Token: 0x0400083B RID: 2107
	public Vector3 minRotation;

	// Token: 0x0400083C RID: 2108
	public Vector3 maxRotation;

	// Token: 0x0400083D RID: 2109
	public bool fullRotate;

	// Token: 0x0200011F RID: 287
	public enum AKCCILPKJMN
	{
		// Token: 0x0400083F RID: 2111
		Simple,
		// Token: 0x04000840 RID: 2112
		Vib,
		// Token: 0x04000841 RID: 2113
		Jig,
		// Token: 0x04000842 RID: 2114
		Vob,
		// Token: 0x04000843 RID: 2115
		CRL,
		// Token: 0x04000844 RID: 2116
		Wacky,
		// Token: 0x04000845 RID: 2117
		JigWorm,
		// Token: 0x04000846 RID: 2118
		Popper,
		// Token: 0x04000847 RID: 2119
		Walker,
		// Token: 0x04000848 RID: 2120
		Cranck,
		// Token: 0x04000849 RID: 2121
		DryFly,
		// Token: 0x0400084A RID: 2122
		Fly,
		// Token: 0x0400084B RID: 2123
		Vertical,
		// Token: 0x0400084C RID: 2124
		Mormysh
	}
}
