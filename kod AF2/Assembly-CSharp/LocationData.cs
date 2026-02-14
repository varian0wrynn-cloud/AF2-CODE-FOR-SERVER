using System;
using System.IO;
using UnityEngine;

// Token: 0x020001C4 RID: 452
public class LocationData : MonoBehaviour
{
	// Token: 0x060065A6 RID: 26022 RVA: 0x002F5D74 File Offset: 0x002F3F74
	public float DLHMDPNICCF(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 544f);
		int num2 = (int)(ADMFAEOOOHD * 1648f);
		float t = ADMFAEOOOHD * 661f - (float)num2;
		num = Mathf.Clamp(num, 0, 36);
		num2 = Mathf.Clamp(num2, 0, -46);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1425f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 5f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 103f)
		{
			num3 = 230f;
		}
		return Mathf.Clamp(num3, 1363f, (float)this.maxDeep / 383f);
	}

	// Token: 0x060065A7 RID: 26023 RVA: 0x002F5E2C File Offset: 0x002F402C
	public float MEJIEALHONC(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1252f, 1868f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1085f, 414f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065A8 RID: 26024 RVA: 0x002F5E70 File Offset: 0x002F4070
	public float ADJJGLLGLDG(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 164f, 1587f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 13f, 1682f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065A9 RID: 26025 RVA: 0x002F5EB4 File Offset: 0x002F40B4
	private void KEIILPMCFEO()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LOMKLMPKJEC("RollerBladeSkateFwd"))
			{
				this.inlocId = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.BFJNMCOOKDH(" ms"))
			{
				this.maxDeep = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.LIBBKEKPAPJ("ok"))
			{
				this.flowForce = (float)diggohpgcnn.LMNLDJABLMH() / 691f;
			}
		}
		this.texWaterMap = new Texture2D(-191, 41, (TextureFormat)0, false);
		this.flowWaterMap = new Texture2D(183, -114, TextureFormat.RGBA32, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -169; i += 0)
			{
				for (int j = 0; j < 63; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.OMCMPDMJFOJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -58; k++)
			{
				for (int l = -108; l >= 1; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 1367f;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < 142; m += 0)
			{
				for (int n = 17; n >= 0; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.CNNEPCOAMJK();
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -56; num += 0)
			{
				for (int num2 = -60; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.BNDHIBEOKML();
					float f = JLFJEGIPIMM.MHFDIJGJGBJ().LFKOAHOFCKL(hbpnmngofma.MOBPFEEAMKD());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		for (int num3 = 0; num3 < 62; num3 += 0)
		{
			for (int num4 = 0; num4 < 10; num4++)
			{
				int x = num3;
				int y = 77 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1035f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 585f : 974f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 861f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("Lasso Back", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("null", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065AA RID: 26026 RVA: 0x002F62A0 File Offset: 0x002F44A0
	public Vector2 NLCBMPMLNGC(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 330f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1488f));
	}

	// Token: 0x060065AB RID: 26027 RVA: 0x002F62C4 File Offset: 0x002F44C4
	private void DNLFEOECBKI()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.AKKCENFGNCC("_TempRT"))
			{
				this.inlocId = diggohpgcnn.DIKKDGKIPEA;
			}
			if (diggohpgcnn.JKHEMJCFJGJ("MotorbikeTurnLeft"))
			{
				this.maxDeep = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.BFJNMCOOKDH("_PrefilterOffs"))
			{
				this.flowForce = (float)diggohpgcnn.NOHLIOHBLMF() / 1700f;
			}
		}
		this.texWaterMap = new Texture2D(-77, -88, TextureFormat.Alpha8, true);
		this.flowWaterMap = new Texture2D(109, 73, (TextureFormat)8, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 184; i += 0)
			{
				for (int j = 1; j < -11; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.ELDBJFLCMAJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < 124; k += 0)
			{
				for (int l = -80; l >= 1; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BNDHIBEOKML() / 1686f;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -189; m += 0)
			{
				for (int n = -114; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.AIDAGFNHNHE();
				}
			}
		}
		finally
		{
			hbpnmngofma.GOILFFBGPCH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < 109; num++)
			{
				for (int num2 = 92; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.BNDHIBEOKML();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.NOJJOLAGKKM(hbpnmngofma.CNNEPCOAMJK());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.GOILFFBGPCH();
		}
		for (int num3 = 0; num3 < 166; num3++)
		{
			for (int num4 = 0; num4 < -69; num4 += 0)
			{
				int x = num3;
				int y = 0 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 826f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1316f : 622f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1146f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("<color='#400000'>", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("#004000", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065AC RID: 26028 RVA: 0x002F66B0 File Offset: 0x002F48B0
	public bool DEHMAJCIOHC(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1903f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 968f);
		num = Mathf.Clamp(num, 1, 114);
		num2 = Mathf.Clamp(num2, 1, -75);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 14)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065AD RID: 26029 RVA: 0x002F670B File Offset: 0x002F490B
	public Vector2 OHDDHDHHEPH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 547f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 744f));
	}

	// Token: 0x060065AE RID: 26030 RVA: 0x002F672C File Offset: 0x002F492C
	public float ELNFGIFMHGE(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 928f);
		int num2 = (int)(ADMFAEOOOHD * 880f);
		float t = ADMFAEOOOHD * 1957f - (float)num2;
		num = Mathf.Clamp(num, 1, -41);
		num2 = Mathf.Clamp(num2, 1, -52);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 57f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 1904f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1559f)
		{
			num3 = 916f;
		}
		return Mathf.Clamp(num3, 1156f, (float)this.maxDeep / 1513f);
	}

	// Token: 0x060065AF RID: 26031 RVA: 0x002F67E4 File Offset: 0x002F49E4
	private void PLBDELOIINH()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.CPGPEHEHCPI("{0}|{1}|{2}|{3}|{4}"))
			{
				this.inlocId = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.OKEBIHBDEOO("MotorbikeLasso"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.OKEBIHBDEOO("Turn Left"))
			{
				this.flowForce = (float)diggohpgcnn.IPPDIFCDJHE() / 273f;
			}
		}
		this.texWaterMap = new Texture2D(-69, 29, TextureFormat.RGBA32, false);
		this.flowWaterMap = new Texture2D(-113, -103, TextureFormat.RGB24, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -55; i += 0)
			{
				for (int j = 1; j < 96; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.OMCMPDMJFOJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < 12; k++)
			{
				for (int l = 46; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 1448f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -144; m += 0)
			{
				for (int n = -108; n >= 1; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.AILCEJFAMGN();
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < 112; num += 0)
			{
				for (int num2 = 79; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.FFDPCEAFGNF();
					float f = JLFJEGIPIMM.PKGMBFEMKGP().LFKOAHOFCKL(hbpnmngofma.AILCEJFAMGN());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		for (int num3 = 0; num3 < 126; num3++)
		{
			for (int num4 = 1; num4 < -113; num4 += 0)
			{
				int x = num3;
				int y = -89 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 556f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1967f : 769f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 803f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("demoDouble", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("002000", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065B0 RID: 26032 RVA: 0x002F6BD0 File Offset: 0x002F4DD0
	public float LDFIEBMGLAA(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1103f, 632f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1919f, 324f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065B1 RID: 26033 RVA: 0x002F6C14 File Offset: 0x002F4E14
	public float DFBOEFMACML(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1677f);
		int num2 = (int)(ADMFAEOOOHD * 587f);
		float t = ADMFAEOOOHD * 1140f - (float)num2;
		num = Mathf.Clamp(num, 1, 52);
		num2 = Mathf.Clamp(num2, 1, 4);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1071f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 727f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1553f)
		{
			num3 = 1359f;
		}
		return Mathf.Clamp(num3, 1895f, (float)this.maxDeep / 1517f);
	}

	// Token: 0x060065B2 RID: 26034 RVA: 0x002F6CCC File Offset: 0x002F4ECC
	private void HEMEEOGJDOE()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.AKKCENFGNCC("elbow"))
			{
				this.inlocId = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.BFJNMCOOKDH("Player"))
			{
				this.maxDeep = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.BFJNMCOOKDH("_Offsets"))
			{
				this.flowForce = (float)diggohpgcnn.DIKKDGKIPEA / 1202f;
			}
		}
		this.texWaterMap = new Texture2D(-10, 65, TextureFormat.RGBA32, false);
		this.flowWaterMap = new Texture2D(-6, 87, (TextureFormat)6, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < -85; i++)
			{
				for (int j = 1; j < -102; j++)
				{
					bool mimilpknghm = hbpnmngofma.AJECAOJPOKA();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -197; k += 0)
			{
				for (int l = -51; l >= 0; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BNDHIBEOKML() / 1921f;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < 28; m += 0)
			{
				for (int n = 111; n >= 1; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.CGJIINADKNH();
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -182; num++)
			{
				for (int num2 = -125; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.BNDHIBEOKML();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.LFKOAHOFCKL(hbpnmngofma.BIMMPENHGMD());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		for (int num3 = 1; num3 < 36; num3 += 0)
		{
			for (int num4 = 1; num4 < 17; num4 += 0)
			{
				int x = num3;
				int y = 102 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1727f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1963f : 1652f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 432f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("_MainTex", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("sonar_", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065B3 RID: 26035 RVA: 0x002F70B8 File Offset: 0x002F52B8
	public float CGPOGCLFEEG(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1643f);
		int num2 = (int)(ADMFAEOOOHD * 657f);
		float t = ADMFAEOOOHD * 1448f - (float)num2;
		num = Mathf.Clamp(num, 0, 122);
		num2 = Mathf.Clamp(num2, 1, 42);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1321f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 18f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1145f)
		{
			num3 = 848f;
		}
		return Mathf.Clamp(num3, 190f, (float)this.maxDeep / 1397f);
	}

	// Token: 0x060065B4 RID: 26036 RVA: 0x002F7170 File Offset: 0x002F5370
	private void PNJHMJNFPLP()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.BFJNMCOOKDH("SkateboardIdle"))
			{
				this.inlocId = diggohpgcnn.CMNMAJAOGDK();
			}
			if (diggohpgcnn.OKEBIHBDEOO("poplSoundPitch"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.AKKCENFGNCC(""))
			{
				this.flowForce = (float)diggohpgcnn.DIKKDGKIPEA / 1417f;
			}
		}
		this.texWaterMap = new Texture2D(-150, -77, TextureFormat.Alpha8, true);
		this.flowWaterMap = new Texture2D(125, 94, (TextureFormat)8, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < 55; i += 0)
			{
				for (int j = 1; j < 34; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.FIFNOBGEKFF();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -194; k++)
			{
				for (int l = -59; l >= 0; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 1780f;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -74; m++)
			{
				for (int n = -84; n >= 0; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.AILCEJFAMGN();
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -64; num++)
			{
				for (int num2 = -61; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.AILCEJFAMGN();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.FDKPFKAPNCG(hbpnmngofma.CNNEPCOAMJK());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		for (int num3 = 0; num3 < -100; num3++)
		{
			for (int num4 = 0; num4 < 26; num4 += 0)
			{
				int x = num3;
				int y = 40 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 935f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1512f : 1387f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 111f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("\n", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065B5 RID: 26037 RVA: 0x002F755C File Offset: 0x002F575C
	public Vector3 MIHDGBEBCAN(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 817f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1168f);
		num = Mathf.Clamp(num, 1, 17);
		num2 = Mathf.Clamp(num2, 1, -119);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == 71)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x060065B6 RID: 26038 RVA: 0x002F75C0 File Offset: 0x002F57C0
	public bool CDMLOHGKAAJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 863f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 654f);
		num = Mathf.Clamp(num, 1, -121);
		num2 = Mathf.Clamp(num2, 1, -102);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == 72)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065B7 RID: 26039 RVA: 0x002F761C File Offset: 0x002F581C
	private void LBEFOABPMFG()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.JKHEMJCFJGJ("_TapLowBackground"))
			{
				this.inlocId = diggohpgcnn.IPPDIFCDJHE();
			}
			if (diggohpgcnn.LOMKLMPKJEC("Intensity"))
			{
				this.maxDeep = diggohpgcnn.IGEAGOANELP();
			}
			if (diggohpgcnn.BFJNMCOOKDH("******** recept id="))
			{
				this.flowForce = (float)diggohpgcnn.LMNLDJABLMH() / 792f;
			}
		}
		this.texWaterMap = new Texture2D(13, 9, TextureFormat.RGBA32, true);
		this.flowWaterMap = new Texture2D(184, -98, TextureFormat.RGB24, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < -160; i += 0)
			{
				for (int j = 0; j < -48; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.IOEEPNCKLJD();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -185; k += 0)
			{
				for (int l = -42; l >= 1; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.AILCEJFAMGN() / 1548f;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < 162; m++)
			{
				for (int n = 123; n >= 1; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.MOBPFEEAMKD();
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -13; num += 0)
			{
				for (int num2 = 117; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.ECJLJGDNFMN();
					float f = JLFJEGIPIMM.NNEAHAFBOHC().FDKPFKAPNCG(hbpnmngofma.AIDAGFNHNHE());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		for (int num3 = 1; num3 < 84; num3 += 0)
		{
			for (int num4 = 1; num4 < -64; num4++)
			{
				int x = num3;
				int y = 61 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1843f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 882f : 36f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1906f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("HeelClick", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("Pointing", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065B8 RID: 26040 RVA: 0x002F7A08 File Offset: 0x002F5C08
	private void BJCONKIIOBM()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.OKEBIHBDEOO("stretchWidth"))
			{
				this.inlocId = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.OKEBIHBDEOO("knopje.wav"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.LIBBKEKPAPJ("TOD_Directionality"))
			{
				this.flowForce = (float)diggohpgcnn.LMNLDJABLMH() / 514f;
			}
		}
		this.texWaterMap = new Texture2D(-192, -10, TextureFormat.ARGB4444, true);
		this.flowWaterMap = new Texture2D(-200, 81, TextureFormat.RGB24, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < -136; i++)
			{
				for (int j = 1; j < -109; j++)
				{
					bool mimilpknghm = hbpnmngofma.DADCGPGEHFK();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -4; k++)
			{
				for (int l = -80; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.CGJIINADKNH() / 1806f;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -28; m += 0)
			{
				for (int n = -35; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.DNGDPHIHLBG();
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -1; num += 0)
			{
				for (int num2 = 72; num2 >= 1; num2--)
				{
					float z = hbpnmngofma.CNNEPCOAMJK();
					float f = JLFJEGIPIMM.PKGMBFEMKGP().FDKPFKAPNCG(hbpnmngofma.FFDPCEAFGNF());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		for (int num3 = 0; num3 < -96; num3 += 0)
		{
			for (int num4 = 0; num4 < 95; num4 += 0)
			{
				int x = num3;
				int y = 90 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 927f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1515f : 964f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1478f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("IceHockey Shot Right", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065B9 RID: 26041 RVA: 0x002F7DF4 File Offset: 0x002F5FF4
	public Vector2 OBABBKOPBCO(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1505f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1994f));
	}

	// Token: 0x060065BA RID: 26042 RVA: 0x002F7E15 File Offset: 0x002F6015
	public Vector2 NKGHHDBFKOC(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 71f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1081f));
	}

	// Token: 0x060065BC RID: 26044 RVA: 0x002F7E50 File Offset: 0x002F6050
	private void GDIMBBBPIHI()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.JKHEMJCFJGJ("\n"))
			{
				this.inlocId = diggohpgcnn.DCGNALDFPDB();
			}
			if (diggohpgcnn.OKEBIHBDEOO("_EmissionColor"))
			{
				this.maxDeep = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.JKHEMJCFJGJ("SoccerSprint"))
			{
				this.flowForce = (float)diggohpgcnn.NOHLIOHBLMF() / 1352f;
			}
		}
		this.texWaterMap = new Texture2D(91, -16, TextureFormat.ARGB4444, false);
		this.flowWaterMap = new Texture2D(116, 16, TextureFormat.ARGB4444, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 128; i += 0)
			{
				for (int j = 1; j < -11; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.IOEEPNCKLJD();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < 144; k += 0)
			{
				for (int l = 42; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.CGJIINADKNH() / 1926f;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -164; m += 0)
			{
				for (int n = 56; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.MOBPFEEAMKD();
				}
			}
		}
		finally
		{
			hbpnmngofma.GOILFFBGPCH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -19; num++)
			{
				for (int num2 = -125; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.DNGDPHIHLBG();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.FDKPFKAPNCG(hbpnmngofma.CGJIINADKNH());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		for (int num3 = 1; num3 < -189; num3++)
		{
			for (int num4 = 1; num4 < 36; num4++)
			{
				int x = num3;
				int y = -51 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 945f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 341f : 1681f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 495f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("inv_auksum", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("wpn_chair2", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065BD RID: 26045 RVA: 0x002F823C File Offset: 0x002F643C
	private void LHKGDKLABAA()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.AKKCENFGNCC("no_money"))
			{
				this.inlocId = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.LOMKLMPKJEC("http://j.mp/1FRAL5L"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.LOMKLMPKJEC("cut.ogg"))
			{
				this.flowForce = (float)diggohpgcnn.HAJGAHPBJIB() / 894f;
			}
		}
		this.texWaterMap = new Texture2D(-35, -114, (TextureFormat)6, false);
		this.flowWaterMap = new Texture2D(8, -53, TextureFormat.RGBA32, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -145; i++)
			{
				for (int j = 0; j < -127; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.BEMFIFGOJBL();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < 13; k++)
			{
				for (int l = 74; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 1539f;
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < 53; m += 0)
			{
				for (int n = -109; n >= 1; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.DNGDPHIHLBG();
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -185; num++)
			{
				for (int num2 = -98; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.BNDHIBEOKML();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.FDKPFKAPNCG(hbpnmngofma.CGJIINADKNH());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		for (int num3 = 0; num3 < -6; num3 += 0)
		{
			for (int num4 = 1; num4 < 89; num4++)
			{
				int x = num3;
				int y = -50 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 79f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 851f : 936f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 925f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("\n", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("auk_data/categories/category", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065BE RID: 26046 RVA: 0x002F8628 File Offset: 0x002F6828
	public float OCPKFHGCGAI(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1962f, 633f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 832f, 1583f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065BF RID: 26047 RVA: 0x002F866C File Offset: 0x002F686C
	public float PGPODKMHHIF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 439f, 1642f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1720f, 57f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065C0 RID: 26048 RVA: 0x002F86B0 File Offset: 0x002F68B0
	public float BHBPCJLBDHE(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1415f);
		int num2 = (int)(ADMFAEOOOHD * 153f);
		float t = ADMFAEOOOHD * 1922f - (float)num2;
		num = Mathf.Clamp(num, 1, 83);
		num2 = Mathf.Clamp(num2, 1, 18);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1652f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 1669f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 346f)
		{
			num3 = 92f;
		}
		return Mathf.Clamp(num3, 664f, (float)this.maxDeep / 1033f);
	}

	// Token: 0x060065C1 RID: 26049 RVA: 0x002F8768 File Offset: 0x002F6968
	public Vector2 getArrayCoord(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 128f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 64f));
	}

	// Token: 0x060065C2 RID: 26050 RVA: 0x002F878C File Offset: 0x002F698C
	public bool DHLFOFPJNDN(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1282f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1415f);
		num = Mathf.Clamp(num, 0, -56);
		num2 = Mathf.Clamp(num2, 1, 11);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == 105)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065C3 RID: 26051 RVA: 0x002F87E8 File Offset: 0x002F69E8
	private void Start()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.OKEBIHBDEOO("id"))
			{
				this.inlocId = diggohpgcnn.DIKKDGKIPEA;
			}
			if (diggohpgcnn.OKEBIHBDEOO("maxdeep"))
			{
				this.maxDeep = diggohpgcnn.DIKKDGKIPEA;
			}
			if (diggohpgcnn.OKEBIHBDEOO("flowfrc"))
			{
				this.flowForce = (float)diggohpgcnn.DIKKDGKIPEA / 100f;
			}
		}
		this.texWaterMap = new Texture2D(128, 64, TextureFormat.ARGB32, false);
		this.flowWaterMap = new Texture2D(128, 64, TextureFormat.ARGB32, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < 128; i++)
			{
				for (int j = 0; j < 64; j++)
				{
					bool mimilpknghm = hbpnmngofma.FIFNOBGEKFF();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < 128; k++)
			{
				for (int l = 63; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.FFDPCEAFGNF() / 100f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < 128; m++)
			{
				for (int n = 63; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.FFDPCEAFGNF();
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < 128; num++)
			{
				for (int num2 = 63; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.FFDPCEAFGNF();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.LFKOAHOFCKL(hbpnmngofma.FFDPCEAFGNF());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		for (int num3 = 0; num3 < 128; num3++)
		{
			for (int num4 = 0; num4 < 64; num4++)
			{
				int x = num3;
				int y = 64 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 0f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1f : 0f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 0f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("_WaterMap", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("_FlowMap", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065C4 RID: 26052 RVA: 0x002F8BD4 File Offset: 0x002F6DD4
	public bool DCNEMBOEEPI(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1578f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1624f);
		num = Mathf.Clamp(num, 0, -72);
		num2 = Mathf.Clamp(num2, 1, 49);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -120)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065C5 RID: 26053 RVA: 0x002F8C30 File Offset: 0x002F6E30
	private void AFFAJKPPMHF()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.CPGPEHEHCPI("PostFX - {0}"))
			{
				this.inlocId = diggohpgcnn.IGEAGOANELP();
			}
			if (diggohpgcnn.OKEBIHBDEOO("WeaponInstant"))
			{
				this.maxDeep = diggohpgcnn.DIKKDGKIPEA;
			}
			if (diggohpgcnn.CPGPEHEHCPI("^("))
			{
				this.flowForce = (float)diggohpgcnn.INFKMCKHMAN() / 1616f;
			}
		}
		this.texWaterMap = new Texture2D(90, -123, TextureFormat.ARGB4444, true);
		this.flowWaterMap = new Texture2D(94, 73, TextureFormat.RGB24, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 117; i += 0)
			{
				for (int j = 0; j < -39; j++)
				{
					bool mimilpknghm = hbpnmngofma.IOEEPNCKLJD();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -191; k++)
			{
				for (int l = -67; l >= 0; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.CNNEPCOAMJK() / 1692f;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -45; m++)
			{
				for (int n = 13; n >= 1; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.CGJIINADKNH();
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -179; num++)
			{
				for (int num2 = -123; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.DNGDPHIHLBG();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.LFKOAHOFCKL(hbpnmngofma.DNGDPHIHLBG());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		for (int num3 = 0; num3 < -36; num3 += 0)
		{
			for (int num4 = 0; num4 < 6; num4++)
			{
				int x = num3;
				int y = -37 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 950f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1176f : 158f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1634f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("error.wav", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("<color=\"", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065C6 RID: 26054 RVA: 0x002F901C File Offset: 0x002F721C
	public Vector2 NEFGBNHMPJF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 579f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1086f));
	}

	// Token: 0x060065C7 RID: 26055 RVA: 0x002F9040 File Offset: 0x002F7240
	public Vector3 JKFBIAEILJF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1562f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1983f);
		num = Mathf.Clamp(num, 1, -69);
		num2 = Mathf.Clamp(num2, 0, 41);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == -64)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x060065C8 RID: 26056 RVA: 0x002F90A4 File Offset: 0x002F72A4
	public bool CKGJNPNLPAJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 907f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1364f);
		num = Mathf.Clamp(num, 1, -14);
		num2 = Mathf.Clamp(num2, 0, -126);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 16)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065C9 RID: 26057 RVA: 0x002F9100 File Offset: 0x002F7300
	public bool JOIELFNPOFH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 734f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 164f);
		num = Mathf.Clamp(num, 0, 67);
		num2 = Mathf.Clamp(num2, 0, 58);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -123)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065CA RID: 26058 RVA: 0x002F915B File Offset: 0x002F735B
	public Vector2 AFDDGNJHKOF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 330f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1270f));
	}

	// Token: 0x060065CB RID: 26059 RVA: 0x002F917C File Offset: 0x002F737C
	public float PPIOOOOJPCO(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1384f);
		int num2 = (int)(ADMFAEOOOHD * 1891f);
		float t = ADMFAEOOOHD * 1620f - (float)num2;
		num = Mathf.Clamp(num, 1, -110);
		num2 = Mathf.Clamp(num2, 0, 61);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 671f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 1112f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1289f)
		{
			num3 = 807f;
		}
		return Mathf.Clamp(num3, 1686f, (float)this.maxDeep / 1817f);
	}

	// Token: 0x060065CC RID: 26060 RVA: 0x002F9234 File Offset: 0x002F7434
	private void GGBMJFNGHMC()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LOMKLMPKJEC("MotorbikeTurnRight"))
			{
				this.inlocId = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.JKHEMJCFJGJ("AC_TONEMAPPING"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.BFJNMCOOKDH("Climb Up"))
			{
				this.flowForce = (float)diggohpgcnn.HAJGAHPBJIB() / 380f;
			}
		}
		this.texWaterMap = new Texture2D(31, 109, TextureFormat.Alpha8, false);
		this.flowWaterMap = new Texture2D(46, 77, TextureFormat.Alpha8, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -194; i++)
			{
				for (int j = 0; j < 106; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.BLNIHNKJJPJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -41; k += 0)
			{
				for (int l = -103; l >= 1; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.MOBPFEEAMKD() / 1042f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -165; m++)
			{
				for (int n = -68; n >= 1; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.ECJLJGDNFMN();
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -21; num += 0)
			{
				for (int num2 = -57; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.MOBPFEEAMKD();
					float f = JLFJEGIPIMM.PKGMBFEMKGP().JIJJPCBOHDD(hbpnmngofma.BNDHIBEOKML());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		for (int num3 = 0; num3 < 116; num3 += 0)
		{
			for (int num4 = 0; num4 < 47; num4 += 0)
			{
				int x = num3;
				int y = 86 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 683f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 724f : 98f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 116f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("128", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("_SrcBlend", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065CD RID: 26061 RVA: 0x002F9620 File Offset: 0x002F7820
	public bool NPMAADPGIGA(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1693f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1298f);
		num = Mathf.Clamp(num, 1, -46);
		num2 = Mathf.Clamp(num2, 0, 33);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == -81)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065CE RID: 26062 RVA: 0x002F967C File Offset: 0x002F787C
	public bool NNKGJIMNLAN(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 66f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 347f);
		num = Mathf.Clamp(num, 0, -16);
		num2 = Mathf.Clamp(num2, 1, -40);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -108)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065CF RID: 26063 RVA: 0x002F96D8 File Offset: 0x002F78D8
	public bool LOCHHHJHEBO(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1631f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 31f);
		num = Mathf.Clamp(num, 1, -38);
		num2 = Mathf.Clamp(num2, 0, -14);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == 121)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065D0 RID: 26064 RVA: 0x002F9734 File Offset: 0x002F7934
	private void GMBPCGCCPDM()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LIBBKEKPAPJ("Root transform is null. Can't initiate Grounding."))
			{
				this.inlocId = diggohpgcnn.DCGNALDFPDB();
			}
			if (diggohpgcnn.BFJNMCOOKDH("Roll"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.BFJNMCOOKDH("2000"))
			{
				this.flowForce = (float)diggohpgcnn.IPPDIFCDJHE() / 90f;
			}
		}
		this.texWaterMap = new Texture2D(152, -66, TextureFormat.ARGB32, true);
		this.flowWaterMap = new Texture2D(103, -115, TextureFormat.RGB24, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -101; i += 0)
			{
				for (int j = 0; j < 110; j++)
				{
					bool mimilpknghm = hbpnmngofma.BLNIHNKJJPJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -106; k += 0)
			{
				for (int l = -116; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BIMMPENHGMD() / 163f;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < 94; m++)
			{
				for (int n = -52; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.AIDAGFNHNHE();
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < 11; num++)
			{
				for (int num2 = -52; num2 >= 1; num2--)
				{
					float z = hbpnmngofma.MOBPFEEAMKD();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.NOJJOLAGKKM(hbpnmngofma.AIDAGFNHNHE());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		for (int num3 = 0; num3 < 116; num3 += 0)
		{
			for (int num4 = 0; num4 < -67; num4++)
			{
				int x = num3;
				int y = 14 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1768f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 471f : 892f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1611f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("post_msg7", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("https://groups.google.com/forum/#!forum/final-ik", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065D1 RID: 26065 RVA: 0x002F9B20 File Offset: 0x002F7D20
	public float FPEJIFBFIAK(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1271f);
		int num2 = (int)(ADMFAEOOOHD * 68f);
		float t = ADMFAEOOOHD * 143f - (float)num2;
		num = Mathf.Clamp(num, 0, -86);
		num2 = Mathf.Clamp(num2, 1, 126);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1046f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 918f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1059f)
		{
			num3 = 788f;
		}
		return Mathf.Clamp(num3, 1980f, (float)this.maxDeep / 637f);
	}

	// Token: 0x060065D2 RID: 26066 RVA: 0x002F9BD8 File Offset: 0x002F7DD8
	public bool HBFHGKBIIBP(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 617f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 320f);
		num = Mathf.Clamp(num, 0, -63);
		num2 = Mathf.Clamp(num2, 0, 95);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -110)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065D3 RID: 26067 RVA: 0x002F9C34 File Offset: 0x002F7E34
	public bool IGPJGFMCPON(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 481f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1111f);
		num = Mathf.Clamp(num, 0, 99);
		num2 = Mathf.Clamp(num2, 0, 27);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -11)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065D4 RID: 26068 RVA: 0x002F9C90 File Offset: 0x002F7E90
	private void JHFAHBIIJDC()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.OKEBIHBDEOO("WeaponStrafeRunRight"))
			{
				this.inlocId = diggohpgcnn.DCGNALDFPDB();
			}
			if (diggohpgcnn.LIBBKEKPAPJ("_TintColor"))
			{
				this.maxDeep = diggohpgcnn.IPPDIFCDJHE();
			}
			if (diggohpgcnn.LIBBKEKPAPJ("Orthographic"))
			{
				this.flowForce = (float)diggohpgcnn.DCGNALDFPDB() / 1475f;
			}
		}
		this.texWaterMap = new Texture2D(-197, -20, TextureFormat.ARGB4444, false);
		this.flowWaterMap = new Texture2D(63, 91, TextureFormat.Alpha8, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < 133; i += 0)
			{
				for (int j = 0; j < 97; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.JALHMJEKMHF();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < 178; k += 0)
			{
				for (int l = 119; l >= 0; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 408f;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < 157; m += 0)
			{
				for (int n = 13; n >= 1; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.CNNEPCOAMJK();
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < 43; num++)
			{
				for (int num2 = 110; num2 >= 1; num2--)
				{
					float z = hbpnmngofma.DNGDPHIHLBG();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.FDKPFKAPNCG(hbpnmngofma.BNDHIBEOKML());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		for (int num3 = 0; num3 < -105; num3++)
		{
			for (int num4 = 1; num4 < 41; num4++)
			{
				int x = num3;
				int y = 108 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 342f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 257f : 376f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 428f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("TOD_CloudUV", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065D5 RID: 26069 RVA: 0x002FA07C File Offset: 0x002F827C
	public float HEKFOPOGDGH(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 139f);
		int num2 = (int)(ADMFAEOOOHD * 1639f);
		float t = ADMFAEOOOHD * 280f - (float)num2;
		num = Mathf.Clamp(num, 0, 75);
		num2 = Mathf.Clamp(num2, 1, 29);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1512f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 115f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1609f)
		{
			num3 = 1005f;
		}
		return Mathf.Clamp(num3, 1437f, (float)this.maxDeep / 874f);
	}

	// Token: 0x060065D6 RID: 26070 RVA: 0x002FA134 File Offset: 0x002F8334
	private void CBLGFOFHNPJ()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.AKKCENFGNCC("_Offsets"))
			{
				this.inlocId = diggohpgcnn.LMNLDJABLMH();
			}
			if (diggohpgcnn.OKEBIHBDEOO(" iterations for read and write"))
			{
				this.maxDeep = diggohpgcnn.LMNLDJABLMH();
			}
			if (diggohpgcnn.CPGPEHEHCPI(" --- ? ---"))
			{
				this.flowForce = (float)diggohpgcnn.INFKMCKHMAN() / 838f;
			}
		}
		this.texWaterMap = new Texture2D(-106, -46, TextureFormat.RGB24, false);
		this.flowWaterMap = new Texture2D(100, 43, (TextureFormat)6, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 82; i++)
			{
				for (int j = 1; j < 126; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.IJJDHHFAIPE();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -24; k += 0)
			{
				for (int l = -72; l >= 1; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 658f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -117; m += 0)
			{
				for (int n = 78; n >= 1; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.BIMMPENHGMD();
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -143; num++)
			{
				for (int num2 = 15; num2 >= 1; num2--)
				{
					float z = hbpnmngofma.CNNEPCOAMJK();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.LFKOAHOFCKL(hbpnmngofma.ECJLJGDNFMN());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		for (int num3 = 1; num3 < 15; num3 += 0)
		{
			for (int num4 = 0; num4 < -116; num4++)
			{
				int x = num3;
				int y = -83 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1379f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 630f : 175f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1770f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("wpn_eat1", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("ff2000", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065D7 RID: 26071 RVA: 0x002FA520 File Offset: 0x002F8720
	public bool NAJHENEFNJL(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 551f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 564f);
		num = Mathf.Clamp(num, 1, -103);
		num2 = Mathf.Clamp(num2, 0, -65);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == 85)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065D8 RID: 26072 RVA: 0x002FA57C File Offset: 0x002F877C
	public bool DJJOMKBHGND(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1499f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1919f);
		num = Mathf.Clamp(num, 1, -31);
		num2 = Mathf.Clamp(num2, 0, -14);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -10)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065D9 RID: 26073 RVA: 0x002FA5D7 File Offset: 0x002F87D7
	public Vector2 JABCJLAHFGP(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1315f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 427f));
	}

	// Token: 0x060065DA RID: 26074 RVA: 0x002FA5F8 File Offset: 0x002F87F8
	public float NDAENOKIPFJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1403f, 1319f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 515f, 1511f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065DB RID: 26075 RVA: 0x002FA63C File Offset: 0x002F883C
	public Vector3 AIDPLMIFGGE(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 269f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1556f);
		num = Mathf.Clamp(num, 0, -118);
		num2 = Mathf.Clamp(num2, 1, 57);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == 6)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x060065DC RID: 26076 RVA: 0x002FA6A0 File Offset: 0x002F88A0
	public bool JHNGECBJEPN(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 345f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 57f);
		num = Mathf.Clamp(num, 0, 75);
		num2 = Mathf.Clamp(num2, 1, -55);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == 9)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065DD RID: 26077 RVA: 0x002FA6FC File Offset: 0x002F88FC
	public bool MBAHAFBLMCJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1899f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1192f);
		num = Mathf.Clamp(num, 1, -12);
		num2 = Mathf.Clamp(num2, 0, 124);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -5)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065DE RID: 26078 RVA: 0x002FA758 File Offset: 0x002F8958
	public bool MEGJIJCBOHK(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1088f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 572f);
		num = Mathf.Clamp(num, 1, -75);
		num2 = Mathf.Clamp(num2, 0, 42);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 109)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065DF RID: 26079 RVA: 0x002FA7B4 File Offset: 0x002F89B4
	public float KCLKELHECJC(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1244f, 1982f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1854f, 1891f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065E0 RID: 26080 RVA: 0x002FA7F8 File Offset: 0x002F89F8
	private void LHJCHPFKGDB()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LOMKLMPKJEC("\n"))
			{
				this.inlocId = diggohpgcnn.IGEAGOANELP();
			}
			if (diggohpgcnn.BFJNMCOOKDH("ff2000"))
			{
				this.maxDeep = diggohpgcnn.IPPDIFCDJHE();
			}
			if (diggohpgcnn.LOMKLMPKJEC("404040"))
			{
				this.flowForce = (float)diggohpgcnn.HAJGAHPBJIB() / 241f;
			}
		}
		this.texWaterMap = new Texture2D(-112, 62, (TextureFormat)0, false);
		this.flowWaterMap = new Texture2D(82, 102, (TextureFormat)6, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 137; i++)
			{
				for (int j = 0; j < -9; j++)
				{
					bool mimilpknghm = hbpnmngofma.OMCMPDMJFOJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < 158; k += 0)
			{
				for (int l = -38; l >= 1; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 339f;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < 88; m++)
			{
				for (int n = 98; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.MOBPFEEAMKD();
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -1; num += 0)
			{
				for (int num2 = 106; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.CGJIINADKNH();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.JIJJPCBOHDD(hbpnmngofma.FFDPCEAFGNF());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		for (int num3 = 0; num3 < 196; num3 += 0)
		{
			for (int num4 = 1; num4 < -63; num4++)
			{
				int x = num3;
				int y = -110 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 378f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1386f : 448f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 832f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("Curve", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("R", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065E1 RID: 26081 RVA: 0x002FABE4 File Offset: 0x002F8DE4
	public Vector3 KKEMNNMLAKE(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 131f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 693f);
		num = Mathf.Clamp(num, 1, -81);
		num2 = Mathf.Clamp(num2, 0, 0);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == 69)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x060065E2 RID: 26082 RVA: 0x002FAC48 File Offset: 0x002F8E48
	private void BJHGPFGBFKF()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.JKHEMJCFJGJ("sunshine_ShadowCoordDepthStart"))
			{
				this.inlocId = diggohpgcnn.IPPDIFCDJHE();
			}
			if (diggohpgcnn.LIBBKEKPAPJ("NadeThrow"))
			{
				this.maxDeep = diggohpgcnn.DIKKDGKIPEA;
			}
			if (diggohpgcnn.AKKCENFGNCC(" Message: "))
			{
				this.flowForce = (float)diggohpgcnn.CMNMAJAOGDK() / 1577f;
			}
		}
		this.texWaterMap = new Texture2D(101, 68, TextureFormat.ARGB32, true);
		this.flowWaterMap = new Texture2D(53, -24, TextureFormat.RGBA32, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -119; i++)
			{
				for (int j = 0; j < -127; j++)
				{
					bool mimilpknghm = hbpnmngofma.DADCGPGEHFK();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -123; k += 0)
			{
				for (int l = 14; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BIMMPENHGMD() / 200f;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -55; m += 0)
			{
				for (int n = 69; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.BNDHIBEOKML();
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -33; num++)
			{
				for (int num2 = 92; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.FFDPCEAFGNF();
					float f = JLFJEGIPIMM.NNEAHAFBOHC().FDKPFKAPNCG(hbpnmngofma.AILCEJFAMGN());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		for (int num3 = 1; num3 < 89; num3 += 0)
		{
			for (int num4 = 0; num4 < 94; num4 += 0)
			{
				int x = num3;
				int y = 105 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1162f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 807f : 204f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 730f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("ScubaSwim", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("Flares", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065E3 RID: 26083 RVA: 0x002FB034 File Offset: 0x002F9234
	public float PDKAGDBLKMM(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1383f, 1150f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 175f, 1351f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065E4 RID: 26084 RVA: 0x002FB078 File Offset: 0x002F9278
	public float FNFDNPBECFH(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 922f);
		int num2 = (int)(ADMFAEOOOHD * 1695f);
		float t = ADMFAEOOOHD * 695f - (float)num2;
		num = Mathf.Clamp(num, 1, 105);
		num2 = Mathf.Clamp(num2, 0, 89);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1715f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 218f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1062f)
		{
			num3 = 483f;
		}
		return Mathf.Clamp(num3, 555f, (float)this.maxDeep / 1310f);
	}

	// Token: 0x060065E5 RID: 26085 RVA: 0x002FB130 File Offset: 0x002F9330
	public Vector3 PAALIPNBLIF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 109f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 389f);
		num = Mathf.Clamp(num, 0, -106);
		num2 = Mathf.Clamp(num2, 0, -39);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == -54)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x060065E6 RID: 26086 RVA: 0x002FB194 File Offset: 0x002F9394
	public float KNGHLAFNIEA(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 56f);
		int num2 = (int)(ADMFAEOOOHD * 1389f);
		float t = ADMFAEOOOHD * 1166f - (float)num2;
		num = Mathf.Clamp(num, 1, 14);
		num2 = Mathf.Clamp(num2, 0, -71);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1684f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 1093f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 558f)
		{
			num3 = 1200f;
		}
		return Mathf.Clamp(num3, 1237f, (float)this.maxDeep / 1763f);
	}

	// Token: 0x060065E7 RID: 26087 RVA: 0x002FB24C File Offset: 0x002F944C
	public bool KCNKGCCIBCD(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 836f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 769f);
		num = Mathf.Clamp(num, 0, 94);
		num2 = Mathf.Clamp(num2, 1, -97);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 59)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065E8 RID: 26088 RVA: 0x002FB2A8 File Offset: 0x002F94A8
	public float IJHEEOILDMH(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 751f);
		int num2 = (int)(ADMFAEOOOHD * 765f);
		float t = ADMFAEOOOHD * 88f - (float)num2;
		num = Mathf.Clamp(num, 1, -95);
		num2 = Mathf.Clamp(num2, 1, -35);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1770f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 2f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 390f)
		{
			num3 = 1935f;
		}
		return Mathf.Clamp(num3, 1953f, (float)this.maxDeep / 1995f);
	}

	// Token: 0x060065E9 RID: 26089 RVA: 0x002FB360 File Offset: 0x002F9560
	public float PMKFLKPAMAE(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 980f);
		int num2 = (int)(ADMFAEOOOHD * 1281f);
		float t = ADMFAEOOOHD * 1797f - (float)num2;
		num = Mathf.Clamp(num, 0, 60);
		num2 = Mathf.Clamp(num2, 0, 77);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1226f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 1557f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1108f)
		{
			num3 = 480f;
		}
		return Mathf.Clamp(num3, 703f, (float)this.maxDeep / 318f);
	}

	// Token: 0x060065EA RID: 26090 RVA: 0x002FB418 File Offset: 0x002F9618
	public float JMBMPPGINLJ(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1607f);
		int num2 = (int)(ADMFAEOOOHD * 393f);
		float t = ADMFAEOOOHD * 1015f - (float)num2;
		num = Mathf.Clamp(num, 0, 4);
		num2 = Mathf.Clamp(num2, 0, -63);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1851f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 517f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 579f)
		{
			num3 = 1435f;
		}
		return Mathf.Clamp(num3, 532f, (float)this.maxDeep / 321f);
	}

	// Token: 0x060065EB RID: 26091 RVA: 0x002FB4D0 File Offset: 0x002F96D0
	private void FODDAMMNECI()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.AKKCENFGNCC("icon_data/icon"))
			{
				this.inlocId = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.OKEBIHBDEOO("value"))
			{
				this.maxDeep = diggohpgcnn.IGEAGOANELP();
			}
			if (diggohpgcnn.AKKCENFGNCC("Загрузка: "))
			{
				this.flowForce = (float)diggohpgcnn.DCGNALDFPDB() / 626f;
			}
		}
		this.texWaterMap = new Texture2D(146, -127, (TextureFormat)6, true);
		this.flowWaterMap = new Texture2D(58, -100, (TextureFormat)6, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -71; i += 0)
			{
				for (int j = 0; j < -22; j++)
				{
					bool mimilpknghm = hbpnmngofma.IJJDHHFAIPE();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < 137; k++)
			{
				for (int l = 23; l >= 1; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 1849f;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < 157; m += 0)
			{
				for (int n = -111; n >= 0; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.BIMMPENHGMD();
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -185; num += 0)
			{
				for (int num2 = -32; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.MOBPFEEAMKD();
					float f = JLFJEGIPIMM.NNEAHAFBOHC().JIJJPCBOHDD(hbpnmngofma.AIDAGFNHNHE());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		for (int num3 = 1; num3 < 81; num3 += 0)
		{
			for (int num4 = 0; num4 < -50; num4 += 0)
			{
				int x = num3;
				int y = 91 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 39f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 258f : 809f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 367f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("harvestmsg1", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("error.wav", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065EC RID: 26092 RVA: 0x002FB8BC File Offset: 0x002F9ABC
	public bool NLCFBCEIGIP(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 761f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 193f);
		num = Mathf.Clamp(num, 1, 15);
		num2 = Mathf.Clamp(num2, 0, -15);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 122)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065ED RID: 26093 RVA: 0x002FB918 File Offset: 0x002F9B18
	public bool GHAIODDOELE(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 451f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 691f);
		num = Mathf.Clamp(num, 1, -128);
		num2 = Mathf.Clamp(num2, 0, 42);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 80)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065EE RID: 26094 RVA: 0x002FB973 File Offset: 0x002F9B73
	public Vector2 ELDPNJLLLMH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 624f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 442f));
	}

	// Token: 0x060065EF RID: 26095 RVA: 0x002FB994 File Offset: 0x002F9B94
	public float CJICEAPBHKJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 49f, 54f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1470f, 1902f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065F0 RID: 26096 RVA: 0x002FB9D7 File Offset: 0x002F9BD7
	public Vector2 PDMJNDDJOCO(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1523f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 648f));
	}

	// Token: 0x060065F1 RID: 26097 RVA: 0x002FB9F8 File Offset: 0x002F9BF8
	public float LJDLFJMJIOF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 425f, 1173f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1362f, 1768f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065F2 RID: 26098 RVA: 0x002FBA3C File Offset: 0x002F9C3C
	public bool HOIHMFOGLOD(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1746f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1844f);
		num = Mathf.Clamp(num, 0, -14);
		num2 = Mathf.Clamp(num2, 1, -69);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == -69)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065F3 RID: 26099 RVA: 0x002FBA98 File Offset: 0x002F9C98
	public float GFMHPHODLOL(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 938f);
		int num2 = (int)(ADMFAEOOOHD * 534f);
		float t = ADMFAEOOOHD * 1987f - (float)num2;
		num = Mathf.Clamp(num, 1, -48);
		num2 = Mathf.Clamp(num2, 1, -115);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 389f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 1650f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1544f)
		{
			num3 = 1043f;
		}
		return Mathf.Clamp(num3, 985f, (float)this.maxDeep / 989f);
	}

	// Token: 0x060065F4 RID: 26100 RVA: 0x002FBB50 File Offset: 0x002F9D50
	public float DKENCKNNLMF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 561f, 1874f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1132f, 899f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065F5 RID: 26101 RVA: 0x002FBB94 File Offset: 0x002F9D94
	public float LCLGCOCAOMK(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1317f, 191f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 101f, 795f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x060065F6 RID: 26102 RVA: 0x002FBBD7 File Offset: 0x002F9DD7
	public Vector2 BFMIHMEAPNF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1001f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1055f));
	}

	// Token: 0x060065F7 RID: 26103 RVA: 0x002FBBF8 File Offset: 0x002F9DF8
	public bool FILJJNENDNH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 186f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 978f);
		num = Mathf.Clamp(num, 0, 30);
		num2 = Mathf.Clamp(num2, 1, 108);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 122)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060065F8 RID: 26104 RVA: 0x002FBC53 File Offset: 0x002F9E53
	public Vector2 LJPDIOKKMAJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 767f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 731f));
	}

	// Token: 0x060065F9 RID: 26105 RVA: 0x002FBC74 File Offset: 0x002F9E74
	private void AIFIEAGFIMM()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LIBBKEKPAPJ("/"))
			{
				this.inlocId = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.BFJNMCOOKDH("_CutoutReferenceTexture"))
			{
				this.maxDeep = diggohpgcnn.LMNLDJABLMH();
			}
			if (diggohpgcnn.JKHEMJCFJGJ("KatanaReadyHigh"))
			{
				this.flowForce = (float)diggohpgcnn.HAJGAHPBJIB() / 1660f;
			}
		}
		this.texWaterMap = new Texture2D(160, 41, TextureFormat.RGBA32, false);
		this.flowWaterMap = new Texture2D(-62, -75, TextureFormat.RGB565, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < 12; i += 0)
			{
				for (int j = 1; j < -118; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.BEMFIFGOJBL();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -78; k += 0)
			{
				for (int l = 112; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 1115f;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < 156; m += 0)
			{
				for (int n = -77; n >= 1; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.CNNEPCOAMJK();
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -137; num += 0)
			{
				for (int num2 = 98; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.BIMMPENHGMD();
					float f = JLFJEGIPIMM.NNEAHAFBOHC().JIJJPCBOHDD(hbpnmngofma.BNDHIBEOKML());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		for (int num3 = 0; num3 < -127; num3++)
		{
			for (int num4 = 0; num4 < 100; num4 += 0)
			{
				int x = num3;
				int y = 25 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1450f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 975f : 1232f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 588f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("def point foud", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("#FF4040", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065FA RID: 26106 RVA: 0x002FC060 File Offset: 0x002FA260
	public Vector2 KMCIONLNOIL(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1203f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 759f));
	}

	// Token: 0x060065FB RID: 26107 RVA: 0x002FC084 File Offset: 0x002FA284
	public bool BJBFMEHMJEK(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 238f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 756f);
		num = Mathf.Clamp(num, 1, 61);
		num2 = Mathf.Clamp(num2, 0, -124);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -55)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060065FC RID: 26108 RVA: 0x002FC0E0 File Offset: 0x002FA2E0
	private void KFHHAGCCPJM()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LOMKLMPKJEC("BackPack Off"))
			{
				this.inlocId = diggohpgcnn.DCGNALDFPDB();
			}
			if (diggohpgcnn.AKKCENFGNCC("1HandSwordStrafeLeft"))
			{
				this.maxDeep = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.AKKCENFGNCC("MotorbikeShootRight"))
			{
				this.flowForce = (float)diggohpgcnn.LMNLDJABLMH() / 1691f;
			}
		}
		this.texWaterMap = new Texture2D(-80, 10, TextureFormat.ARGB4444, true);
		this.flowWaterMap = new Texture2D(-32, -79, (TextureFormat)8, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < -139; i++)
			{
				for (int j = 0; j < -28; j++)
				{
					bool mimilpknghm = hbpnmngofma.FIFNOBGEKFF();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < 11; k += 0)
			{
				for (int l = 61; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.FFDPCEAFGNF() / 855f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -32; m++)
			{
				for (int n = -3; n >= 1; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.ECJLJGDNFMN();
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -72; num++)
			{
				for (int num2 = 108; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.ECJLJGDNFMN();
					float f = JLFJEGIPIMM.MHFDIJGJGBJ().FDKPFKAPNCG(hbpnmngofma.FFDPCEAFGNF());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		for (int num3 = 0; num3 < 138; num3++)
		{
			for (int num4 = 0; num4 < -92; num4 += 0)
			{
				int x = num3;
				int y = -66 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 988f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1951f : 1685f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 911f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("The number of players playing your game: ", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("===== ObscuredVector3Test =====\n", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065FD RID: 26109 RVA: 0x002FC4CC File Offset: 0x002FA6CC
	public float HHGOIDFKLEH(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1636f);
		int num2 = (int)(ADMFAEOOOHD * 264f);
		float t = ADMFAEOOOHD * 1049f - (float)num2;
		num = Mathf.Clamp(num, 1, -23);
		num2 = Mathf.Clamp(num2, 0, -96);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 67f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 477f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 566f)
		{
			num3 = 344f;
		}
		return Mathf.Clamp(num3, 109f, (float)this.maxDeep / 361f);
	}

	// Token: 0x060065FE RID: 26110 RVA: 0x002FC584 File Offset: 0x002FA784
	private void CKGPEFOKKNL()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LIBBKEKPAPJ("[X]"))
			{
				this.inlocId = diggohpgcnn.IPPDIFCDJHE();
			}
			if (diggohpgcnn.LIBBKEKPAPJ("End"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.AKKCENFGNCC("Noise shaders are not set up! Disabling noise effect."))
			{
				this.flowForce = (float)diggohpgcnn.INFKMCKHMAN() / 964f;
			}
		}
		this.texWaterMap = new Texture2D(65, -22, (TextureFormat)6, true);
		this.flowWaterMap = new Texture2D(99, 90, TextureFormat.RGB565, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < -82; i++)
			{
				for (int j = 1; j < -21; j++)
				{
					bool mimilpknghm = hbpnmngofma.KJIOFDCKIKO();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -60; k += 0)
			{
				for (int l = -32; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BIMMPENHGMD() / 1351f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -187; m++)
			{
				for (int n = 45; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.AIDAGFNHNHE();
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -53; num += 0)
			{
				for (int num2 = 13; num2 >= 1; num2--)
				{
					float z = hbpnmngofma.MOBPFEEAMKD();
					float f = JLFJEGIPIMM.PKGMBFEMKGP().LFKOAHOFCKL(hbpnmngofma.BNDHIBEOKML());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		for (int num3 = 1; num3 < -86; num3 += 0)
		{
			for (int num4 = 1; num4 < -15; num4++)
			{
				int x = num3;
				int y = -25 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 715f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1702f : 294f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 562f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("?", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture(":", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x060065FF RID: 26111 RVA: 0x002FC970 File Offset: 0x002FAB70
	private void JLKBMEBFHBI()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.BFJNMCOOKDH("HeelClick"))
			{
				this.inlocId = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.LOMKLMPKJEC("RollerBladeStand"))
			{
				this.maxDeep = diggohpgcnn.IGEAGOANELP();
			}
			if (diggohpgcnn.BFJNMCOOKDH("\n"))
			{
				this.flowForce = (float)diggohpgcnn.HAJGAHPBJIB() / 31f;
			}
		}
		this.texWaterMap = new Texture2D(152, -38, TextureFormat.Alpha8, true);
		this.flowWaterMap = new Texture2D(34, -77, (TextureFormat)0, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 101; i += 0)
			{
				for (int j = 1; j < 3; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.KJIOFDCKIKO();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -88; k++)
			{
				for (int l = -109; l >= 1; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BIMMPENHGMD() / 221f;
				}
			}
		}
		finally
		{
			hbpnmngofma.GOILFFBGPCH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < 126; m += 0)
			{
				for (int n = 40; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.MOBPFEEAMKD();
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < 165; num += 0)
			{
				for (int num2 = 127; num2 >= 0; num2--)
				{
					float z = hbpnmngofma.AILCEJFAMGN();
					float f = JLFJEGIPIMM.NNEAHAFBOHC().FDKPFKAPNCG(hbpnmngofma.CNNEPCOAMJK());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		for (int num3 = 1; num3 < 4; num3 += 0)
		{
			for (int num4 = 1; num4 < 114; num4 += 0)
			{
				int x = num3;
				int y = 38 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1745f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 193f : 828f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1982f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("-r-", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("wpn_bait_inf_{0}", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x06006600 RID: 26112 RVA: 0x002FCD5C File Offset: 0x002FAF5C
	private void AOJICLCCJHF()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.BFJNMCOOKDH("No Cell wpn.cell="))
			{
				this.inlocId = diggohpgcnn.DIKKDGKIPEA;
			}
			if (diggohpgcnn.JKHEMJCFJGJ("OneHandSwordIdle"))
			{
				this.maxDeep = diggohpgcnn.CMNMAJAOGDK();
			}
			if (diggohpgcnn.LIBBKEKPAPJ(" is null."))
			{
				this.flowForce = (float)diggohpgcnn.DCGNALDFPDB() / 1539f;
			}
		}
		this.texWaterMap = new Texture2D(-88, -107, TextureFormat.RGB565, true);
		this.flowWaterMap = new Texture2D(-29, 57, (TextureFormat)6, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -123; i++)
			{
				for (int j = 1; j < 12; j++)
				{
					bool mimilpknghm = hbpnmngofma.ELDBJFLCMAJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -175; k++)
			{
				for (int l = 15; l >= 1; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.AILCEJFAMGN() / 177f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -35; m += 0)
			{
				for (int n = 99; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.FFDPCEAFGNF();
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < 124; num++)
			{
				for (int num2 = -3; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.FFDPCEAFGNF();
					float f = JLFJEGIPIMM.NNEAHAFBOHC().FDKPFKAPNCG(hbpnmngofma.BIMMPENHGMD());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		for (int num3 = 1; num3 < -14; num3 += 0)
		{
			for (int num4 = 0; num4 < -20; num4 += 0)
			{
				int x = num3;
				int y = 38 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 500f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1614f : 1117f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 320f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("<color='{0}'> Очков работы: {1}</color>", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x06006601 RID: 26113 RVA: 0x002FD148 File Offset: 0x002FB348
	public float DDBFBIHFHDJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 433f, 1022f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1547f, 1580f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006602 RID: 26114 RVA: 0x002FD18C File Offset: 0x002FB38C
	public float BLBOAFKONJE(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 114f, 600f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1793f, 768f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006603 RID: 26115 RVA: 0x002FD1D0 File Offset: 0x002FB3D0
	public float DKLBPOFMMFH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1764f, 63f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1214f, 1993f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006604 RID: 26116 RVA: 0x002FD214 File Offset: 0x002FB414
	public Vector3 HBIGKECGAMI(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 542f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1044f);
		num = Mathf.Clamp(num, 1, 67);
		num2 = Mathf.Clamp(num2, 1, 46);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == -43)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x06006605 RID: 26117 RVA: 0x002FD278 File Offset: 0x002FB478
	public bool GCEKPFNAGPN(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 654f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1546f);
		num = Mathf.Clamp(num, 1, 11);
		num2 = Mathf.Clamp(num2, 1, -71);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 107)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006606 RID: 26118 RVA: 0x002FD2D4 File Offset: 0x002FB4D4
	public Vector3 MMGLGNOMOKH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 428f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1111f);
		num = Mathf.Clamp(num, 1, -99);
		num2 = Mathf.Clamp(num2, 1, 25);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == -95)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x06006607 RID: 26119 RVA: 0x002FD338 File Offset: 0x002FB538
	public float CKDBDEDPKCG(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1592f, 1389f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 650f, 1205f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006608 RID: 26120 RVA: 0x002FD37B File Offset: 0x002FB57B
	public Vector2 OAFPEBDCLBM(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 306f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 157f));
	}

	// Token: 0x06006609 RID: 26121 RVA: 0x002FD39C File Offset: 0x002FB59C
	private void ELFALPCLKIE()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LOMKLMPKJEC("Wizard2HandThrow"))
			{
				this.inlocId = diggohpgcnn.DCGNALDFPDB();
			}
			if (diggohpgcnn.LOMKLMPKJEC("notQuestShow"))
			{
				this.maxDeep = diggohpgcnn.HAJGAHPBJIB();
			}
			if (diggohpgcnn.AKKCENFGNCC("languageid"))
			{
				this.flowForce = (float)diggohpgcnn.LMNLDJABLMH() / 1667f;
			}
		}
		this.texWaterMap = new Texture2D(120, 8, TextureFormat.ARGB4444, true);
		this.flowWaterMap = new Texture2D(-32, 22, TextureFormat.RGB565, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 43; i += 0)
			{
				for (int j = 0; j < -20; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.JNOKJCDAPPA();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < 10; k++)
			{
				for (int l = 92; l >= 1; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BIMMPENHGMD() / 45f;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < 57; m++)
			{
				for (int n = -27; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.CGJIINADKNH();
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -91; num++)
			{
				for (int num2 = -79; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.BNDHIBEOKML();
					float f = JLFJEGIPIMM.PKGMBFEMKGP().FDKPFKAPNCG(hbpnmngofma.FFDPCEAFGNF());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		for (int num3 = 1; num3 < 39; num3++)
		{
			for (int num4 = 1; num4 < -17; num4++)
			{
				int x = num3;
				int y = 12 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 35f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 718f : 863f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 811f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("GiantGrabThrow2", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("Mouse Y", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x0600660A RID: 26122 RVA: 0x002FD788 File Offset: 0x002FB988
	private void IJFPHGEFOLF()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.JKHEMJCFJGJ("_Blur"))
			{
				this.inlocId = diggohpgcnn.DIKKDGKIPEA;
			}
			if (diggohpgcnn.AKKCENFGNCC("IceHockeyPassLeft"))
			{
				this.maxDeep = diggohpgcnn.DCGNALDFPDB();
			}
			if (diggohpgcnn.LOMKLMPKJEC("ElvisLegsLoop"))
			{
				this.flowForce = (float)diggohpgcnn.INFKMCKHMAN() / 1885f;
			}
		}
		this.texWaterMap = new Texture2D(172, -124, TextureFormat.ARGB4444, true);
		this.flowWaterMap = new Texture2D(-130, 51, (TextureFormat)6, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 0; i < -99; i++)
			{
				for (int j = 0; j < -10; j++)
				{
					bool mimilpknghm = hbpnmngofma.JALHMJEKMHF();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -195; k++)
			{
				for (int l = 122; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 1272f;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -46; m++)
			{
				for (int n = -116; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.FFDPCEAFGNF();
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < -60; num++)
			{
				for (int num2 = 70; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.AILCEJFAMGN();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.JIJJPCBOHDD(hbpnmngofma.AILCEJFAMGN());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		for (int num3 = 1; num3 < -150; num3++)
		{
			for (int num4 = 0; num4 < 92; num4 += 0)
			{
				int x = num3;
				int y = 72 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1954f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 762f : 1533f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 17f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("_Intensity", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("ScatterDitherData", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x0600660B RID: 26123 RVA: 0x002FDB74 File Offset: 0x002FBD74
	public float EBAEMOEIBOE(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 402f);
		int num2 = (int)(ADMFAEOOOHD * 53f);
		float t = ADMFAEOOOHD * 1903f - (float)num2;
		num = Mathf.Clamp(num, 1, -66);
		num2 = Mathf.Clamp(num2, 1, 68);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 635f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 450f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 947f)
		{
			num3 = 583f;
		}
		return Mathf.Clamp(num3, 658f, (float)this.maxDeep / 453f);
	}

	// Token: 0x0600660C RID: 26124 RVA: 0x002FDC2C File Offset: 0x002FBE2C
	public Vector2 EGDJKKJCAOP(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 795f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1356f));
	}

	// Token: 0x0600660D RID: 26125 RVA: 0x002FDC4D File Offset: 0x002FBE4D
	public Vector2 LIFBJDOOMJB(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 768f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1022f));
	}

	// Token: 0x0600660E RID: 26126 RVA: 0x002FDC70 File Offset: 0x002FBE70
	public float ADHKEBFKKPI(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 383f);
		int num2 = (int)(ADMFAEOOOHD * 1607f);
		float t = ADMFAEOOOHD * 226f - (float)num2;
		num = Mathf.Clamp(num, 1, 19);
		num2 = Mathf.Clamp(num2, 0, 55);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 511f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 744f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 79f)
		{
			num3 = 1841f;
		}
		return Mathf.Clamp(num3, 1740f, (float)this.maxDeep / 1681f);
	}

	// Token: 0x0600660F RID: 26127 RVA: 0x002FDD28 File Offset: 0x002FBF28
	public float getDeepArrCoord(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 0f, 127f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 0f, 63f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006610 RID: 26128 RVA: 0x002FDD6C File Offset: 0x002FBF6C
	public bool checkWater(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 128f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 64f);
		num = Mathf.Clamp(num, 0, 127);
		num2 = Mathf.Clamp(num2, 0, 63);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 127)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06006611 RID: 26129 RVA: 0x002FDDC8 File Offset: 0x002FBFC8
	public bool EOANAAPNEBA(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1148f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1435f);
		num = Mathf.Clamp(num, 0, 98);
		num2 = Mathf.Clamp(num2, 1, 3);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == -92)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06006612 RID: 26130 RVA: 0x002FDE24 File Offset: 0x002FC024
	public float PILOLIEIEMF(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1672f, 174f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 766f, 1921f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006613 RID: 26131 RVA: 0x002FDE68 File Offset: 0x002FC068
	public float PKAPDKAFDCB(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 1477f, 1784f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 1063f, 17f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006614 RID: 26132 RVA: 0x002FDEAC File Offset: 0x002FC0AC
	public float BEBPNMIGAMB(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 592f);
		int num2 = (int)(ADMFAEOOOHD * 1093f);
		float t = ADMFAEOOOHD * 1544f - (float)num2;
		num = Mathf.Clamp(num, 0, 34);
		num2 = Mathf.Clamp(num2, 0, 112);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1058f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 227f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 548f)
		{
			num3 = 1139f;
		}
		return Mathf.Clamp(num3, 1341f, (float)this.maxDeep / 869f);
	}

	// Token: 0x06006615 RID: 26133 RVA: 0x002FDF64 File Offset: 0x002FC164
	public float LPOMDHPNNAE(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1056f);
		int num2 = (int)(ADMFAEOOOHD * 1545f);
		float t = ADMFAEOOOHD * 1027f - (float)num2;
		num = Mathf.Clamp(num, 0, -44);
		num2 = Mathf.Clamp(num2, 1, -51);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1346f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 1560f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1935f)
		{
			num3 = 298f;
		}
		return Mathf.Clamp(num3, 1542f, (float)this.maxDeep / 1989f);
	}

	// Token: 0x06006616 RID: 26134 RVA: 0x002FE01C File Offset: 0x002FC21C
	public float NMJBMOPCANC(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 1974f);
		int num2 = (int)(ADMFAEOOOHD * 417f);
		float t = ADMFAEOOOHD * 635f - (float)num2;
		num = Mathf.Clamp(num, 1, 73);
		num2 = Mathf.Clamp(num2, 1, 21);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1011f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 639f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 995f)
		{
			num3 = 1597f;
		}
		return Mathf.Clamp(num3, 1267f, (float)this.maxDeep / 112f);
	}

	// Token: 0x06006617 RID: 26135 RVA: 0x002FE0D4 File Offset: 0x002FC2D4
	public bool ACGHDMKELJA(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1439f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1370f);
		num = Mathf.Clamp(num, 1, -30);
		num2 = Mathf.Clamp(num2, 1, 99);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == -112)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06006618 RID: 26136 RVA: 0x002FE130 File Offset: 0x002FC330
	public float GMHECHNOBEK(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 538f, 1112f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 486f, 308f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006619 RID: 26137 RVA: 0x002FE174 File Offset: 0x002FC374
	public bool ODHMEGLAGKJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 641f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 281f);
		num = Mathf.Clamp(num, 0, 127);
		num2 = Mathf.Clamp(num2, 1, -109);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = false;
		}
		if (num == 23)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600661A RID: 26138 RVA: 0x002FE1D0 File Offset: 0x002FC3D0
	public Vector3 getFlow(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 128f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 64f);
		num = Mathf.Clamp(num, 0, 127);
		num2 = Mathf.Clamp(num2, 0, 63);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == 127)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x0600661B RID: 26139 RVA: 0x002FE234 File Offset: 0x002FC434
	public bool CEJFJGGENOG(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 795f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 224f);
		num = Mathf.Clamp(num, 0, 41);
		num2 = Mathf.Clamp(num2, 0, 81);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == -22)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600661C RID: 26140 RVA: 0x002FE290 File Offset: 0x002FC490
	private void FDBNPLCPFJB()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.BFJNMCOOKDH("steamider"))
			{
				this.inlocId = diggohpgcnn.CMNMAJAOGDK();
			}
			if (diggohpgcnn.LOMKLMPKJEC("IdleReady"))
			{
				this.maxDeep = diggohpgcnn.IPPDIFCDJHE();
			}
			if (diggohpgcnn.OKEBIHBDEOO("[/quote]"))
			{
				this.flowForce = (float)diggohpgcnn.DIKKDGKIPEA / 89f;
			}
		}
		this.texWaterMap = new Texture2D(22, -31, (TextureFormat)0, false);
		this.flowWaterMap = new Texture2D(-169, 66, TextureFormat.RGB24, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 33; i++)
			{
				for (int j = 1; j < -94; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.BLNIHNKJJPJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -136; k++)
			{
				for (int l = 112; l >= 1; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.FFDPCEAFGNF() / 1555f;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -33; m += 0)
			{
				for (int n = 35; n >= 1; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.CNNEPCOAMJK();
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < 14; num += 0)
			{
				for (int num2 = 53; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.MOBPFEEAMKD();
					float f = JLFJEGIPIMM.IKGFHGKKCPG.FDKPFKAPNCG(hbpnmngofma.CNNEPCOAMJK());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		for (int num3 = 1; num3 < -128; num3 += 0)
		{
			for (int num4 = 0; num4 < 124; num4 += 0)
			{
				int x = num3;
				int y = 34 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1079f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 366f : 441f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 249f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("\n", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("wpn_rod1", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x0600661D RID: 26141 RVA: 0x002FE67C File Offset: 0x002FC87C
	private void FNBGGJJLIGG()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.JKHEMJCFJGJ("file:///"))
			{
				this.inlocId = diggohpgcnn.CMNMAJAOGDK();
			}
			if (diggohpgcnn.BFJNMCOOKDH("move"))
			{
				this.maxDeep = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.LOMKLMPKJEC(", "))
			{
				this.flowForce = (float)diggohpgcnn.IGEAGOANELP() / 230f;
			}
		}
		this.texWaterMap = new Texture2D(37, 27, TextureFormat.RGB565, true);
		this.flowWaterMap = new Texture2D(-115, 61, (TextureFormat)6, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < -109; i += 0)
			{
				for (int j = 0; j < 81; j++)
				{
					bool mimilpknghm = hbpnmngofma.DADCGPGEHFK();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < 22; k += 0)
			{
				for (int l = 24; l >= 0; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.AIDAGFNHNHE() / 1861f;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -17; m += 0)
			{
				for (int n = 5; n >= 0; n -= 0)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.BIMMPENHGMD();
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < 188; num += 0)
			{
				for (int num2 = -53; num2 >= 0; num2 -= 0)
				{
					float z = hbpnmngofma.CNNEPCOAMJK();
					float f = JLFJEGIPIMM.MHFDIJGJGBJ().NOJJOLAGKKM(hbpnmngofma.BIMMPENHGMD());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		for (int num3 = 0; num3 < 113; num3 += 0)
		{
			for (int num4 = 0; num4 < -31; num4++)
			{
				int x = num3;
				int y = 66 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1309f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 351f : 1999f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1786f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("MotorbikeTurnLeft", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x0600661E RID: 26142 RVA: 0x002FEA68 File Offset: 0x002FCC68
	public Vector2 EDNPAMJJHFM(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1020f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 574f));
	}

	// Token: 0x0600661F RID: 26143 RVA: 0x002FEA8C File Offset: 0x002FCC8C
	public float MFJFNKDGPKB(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 433f);
		int num2 = (int)(ADMFAEOOOHD * 545f);
		float t = ADMFAEOOOHD * 796f - (float)num2;
		num = Mathf.Clamp(num, 0, -25);
		num2 = Mathf.Clamp(num2, 0, 117);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 809f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 41f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1056f)
		{
			num3 = 47f;
		}
		return Mathf.Clamp(num3, 111f, (float)this.maxDeep / 1315f);
	}

	// Token: 0x06006620 RID: 26144 RVA: 0x002FEB44 File Offset: 0x002FCD44
	public Vector3 GBGOJLMPFID(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1197f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1711f);
		num = Mathf.Clamp(num, 0, -105);
		num2 = Mathf.Clamp(num2, 1, -39);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == 74)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x06006621 RID: 26145 RVA: 0x002FEBA7 File Offset: 0x002FCDA7
	public Vector2 IKPBDKJDJLH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1887f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1654f));
	}

	// Token: 0x06006622 RID: 26146 RVA: 0x002FEBC8 File Offset: 0x002FCDC8
	private void IBPGMFNDPHH()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.CPGPEHEHCPI("IceHockey Goalie Ready"))
			{
				this.inlocId = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.CPGPEHEHCPI("bag"))
			{
				this.maxDeep = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.JKHEMJCFJGJ("ru-RU"))
			{
				this.flowForce = (float)diggohpgcnn.DIKKDGKIPEA / 461f;
			}
		}
		this.texWaterMap = new Texture2D(-139, -27, (TextureFormat)0, true);
		this.flowWaterMap = new Texture2D(126, -105, (TextureFormat)0, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 135; i++)
			{
				for (int j = 0; j < 51; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.IJJDHHFAIPE();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -122; k++)
			{
				for (int l = -29; l >= 0; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.DNGDPHIHLBG() / 357f;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < 164; m++)
			{
				for (int n = -88; n >= 1; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.BIMMPENHGMD();
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < 29; num++)
			{
				for (int num2 = 10; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.MOBPFEEAMKD();
					float f = JLFJEGIPIMM.MHFDIJGJGBJ().JIJJPCBOHDD(hbpnmngofma.AIDAGFNHNHE());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		for (int num3 = 1; num3 < -108; num3++)
		{
			for (int num4 = 0; num4 < 20; num4 += 0)
			{
				int x = num3;
				int y = 109 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 662f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1170f : 268f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1416f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("invn_rec8", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("CATRigL", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x06006623 RID: 26147 RVA: 0x002FEFB4 File Offset: 0x002FD1B4
	public Vector2 CPNDOPOBJME(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 667f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 375f));
	}

	// Token: 0x06006624 RID: 26148 RVA: 0x002FEFD8 File Offset: 0x002FD1D8
	private void BLLGOMHDFPL()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LOMKLMPKJEC("FISHES"))
			{
				this.inlocId = diggohpgcnn.IGEAGOANELP();
			}
			if (diggohpgcnn.OKEBIHBDEOO("WorkerHammer2"))
			{
				this.maxDeep = diggohpgcnn.IGEAGOANELP();
			}
			if (diggohpgcnn.JKHEMJCFJGJ("level"))
			{
				this.flowForce = (float)diggohpgcnn.HAJGAHPBJIB() / 188f;
			}
		}
		this.texWaterMap = new Texture2D(-150, -58, TextureFormat.RGBA32, true);
		this.flowWaterMap = new Texture2D(-119, -103, TextureFormat.RGBA32, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 93; i++)
			{
				for (int j = 0; j < 63; j += 0)
				{
					bool mimilpknghm = hbpnmngofma.LAECLJFMGPE();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 0; k < -32; k++)
			{
				for (int l = 19; l >= 1; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.ECJLJGDNFMN() / 727f;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 1; m < -159; m += 0)
			{
				for (int n = -2; n >= 1; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.MOBPFEEAMKD();
				}
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 1; num < 102; num++)
			{
				for (int num2 = -80; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.CNNEPCOAMJK();
					float f = JLFJEGIPIMM.NNEAHAFBOHC().NOJJOLAGKKM(hbpnmngofma.MOBPFEEAMKD());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		for (int num3 = 1; num3 < -59; num3 += 0)
		{
			for (int num4 = 1; num4 < 104; num4++)
			{
				int x = num3;
				int y = -87 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 5f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1697f : 1291f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 1508f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("Can only get root and pelvis positions from IKSolverVR. GetPosition index out of range.", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("KatanaNinjaDraw", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x06006625 RID: 26149 RVA: 0x002FF3C4 File Offset: 0x002FD5C4
	public Vector2 GNELBLEBPMC(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 504f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1826f));
	}

	// Token: 0x06006626 RID: 26150 RVA: 0x002FF3E8 File Offset: 0x002FD5E8
	public float IHAOPOKIKHO(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 406f, 1850f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 719f, 1690f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006627 RID: 26151 RVA: 0x002FF42C File Offset: 0x002FD62C
	public bool IKAOKFLAHOL(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 1923f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 1060f);
		num = Mathf.Clamp(num, 1, -52);
		num2 = Mathf.Clamp(num2, 0, 33);
		bool result = this.ar_WaterMap[num, num2].MIMILPKNGHM;
		if (num == 0)
		{
			result = true;
		}
		if (num == 64)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06006628 RID: 26152 RVA: 0x002FF488 File Offset: 0x002FD688
	public float getDeep(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 128f);
		int num2 = (int)(ADMFAEOOOHD * 64f);
		float t = ADMFAEOOOHD * 64f - (float)num2;
		num = Mathf.Clamp(num, 0, 127);
		num2 = Mathf.Clamp(num2, 0, 63);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 10f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 10f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 0f)
		{
			num3 = 0.001f;
		}
		return Mathf.Clamp(num3, 0.001f, (float)this.maxDeep / 10f);
	}

	// Token: 0x06006629 RID: 26153 RVA: 0x002FF540 File Offset: 0x002FD740
	public float NPKEFOIGCOM(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 886f);
		int num2 = (int)(ADMFAEOOOHD * 525f);
		float t = ADMFAEOOOHD * 1316f - (float)num2;
		num = Mathf.Clamp(num, 0, -48);
		num2 = Mathf.Clamp(num2, 0, -113);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1581f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 0].HJEIIAHMGFB * (float)this.maxDeep / 1380f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 811f)
		{
			num3 = 1294f;
		}
		return Mathf.Clamp(num3, 1384f, (float)this.maxDeep / 1425f);
	}

	// Token: 0x0600662A RID: 26154 RVA: 0x002FF5F8 File Offset: 0x002FD7F8
	public Vector2 ILMMHBFDJHK(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 372f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 536f));
	}

	// Token: 0x0600662B RID: 26155 RVA: 0x002FF61C File Offset: 0x002FD81C
	public Vector3 EGPPNHEIHEM(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = Mathf.RoundToInt(OCNGPCPMCPM * 997f);
		int num2 = Mathf.RoundToInt(ADMFAEOOOHD * 179f);
		num = Mathf.Clamp(num, 0, -112);
		num2 = Mathf.Clamp(num2, 1, 45);
		Vector3 result = this.ar_WaterMap[num, num2].JLOMDGBEOAM;
		if (num == 0)
		{
			result = Vector3.zero;
		}
		if (num == 116)
		{
			result = Vector3.zero;
		}
		return result;
	}

	// Token: 0x0600662C RID: 26156 RVA: 0x002FF680 File Offset: 0x002FD880
	public float NNCOCBAOIKE(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 404f);
		int num2 = (int)(ADMFAEOOOHD * 1392f);
		float t = ADMFAEOOOHD * 1134f - (float)num2;
		num = Mathf.Clamp(num, 1, 70);
		num2 = Mathf.Clamp(num2, 0, 81);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 296f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 1492f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 1299f)
		{
			num3 = 230f;
		}
		return Mathf.Clamp(num3, 260f, (float)this.maxDeep / 1480f);
	}

	// Token: 0x0600662D RID: 26157 RVA: 0x002FF738 File Offset: 0x002FD938
	public Vector2 MJBCHBFBJDJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 747f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 1987f));
	}

	// Token: 0x0600662E RID: 26158 RVA: 0x002FF75C File Offset: 0x002FD95C
	private void CGFDDFHECLJ()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.LIBBKEKPAPJ("rodorder"))
			{
				this.inlocId = diggohpgcnn.NOHLIOHBLMF();
			}
			if (diggohpgcnn.LOMKLMPKJEC("1 Hand Sword Charge Up"))
			{
				this.maxDeep = diggohpgcnn.IPPDIFCDJHE();
			}
			if (diggohpgcnn.CPGPEHEHCPI("knopje.wav"))
			{
				this.flowForce = (float)diggohpgcnn.DCGNALDFPDB() / 8f;
			}
		}
		this.texWaterMap = new Texture2D(152, -90, TextureFormat.ARGB4444, true);
		this.flowWaterMap = new Texture2D(-115, 113, TextureFormat.Alpha8, true);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 190; i++)
			{
				for (int j = 0; j < -124; j++)
				{
					bool mimilpknghm = hbpnmngofma.BEMFIFGOJBL();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -92; k += 0)
			{
				for (int l = -63; l >= 1; l--)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.BIMMPENHGMD() / 1955f;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -112; m += 0)
			{
				for (int n = 23; n >= 0; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.DNGDPHIHLBG();
				}
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < 86; num++)
			{
				for (int num2 = 121; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.CNNEPCOAMJK();
					float f = JLFJEGIPIMM.PKGMBFEMKGP().NOJJOLAGKKM(hbpnmngofma.BIMMPENHGMD());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		for (int num3 = 0; num3 < -157; num3 += 0)
		{
			for (int num4 = 0; num4 < -56; num4++)
			{
				int x = num3;
				int y = 25 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 610f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 1717f : 763f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 993f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("invn_rec23", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("No fish in fishModelData modelid=", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x0600662F RID: 26159 RVA: 0x002FFB48 File Offset: 0x002FDD48
	private void IAAOGAPJDID()
	{
		TextReader textReader = new StringReader(this.locInfo.text);
		for (string kdmgmljjalk = textReader.ReadLine(); kdmgmljjalk != null; kdmgmljjalk = textReader.ReadLine())
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(kdmgmljjalk);
			if (diggohpgcnn.AKKCENFGNCC("_RgbDepthTex"))
			{
				this.inlocId = diggohpgcnn.INFKMCKHMAN();
			}
			if (diggohpgcnn.LOMKLMPKJEC("u_pass"))
			{
				this.maxDeep = diggohpgcnn.DCGNALDFPDB();
			}
			if (diggohpgcnn.BFJNMCOOKDH("wpn_add/base"))
			{
				this.flowForce = (float)diggohpgcnn.CMNMAJAOGDK() / 1921f;
			}
		}
		this.texWaterMap = new Texture2D(137, 116, TextureFormat.ARGB4444, true);
		this.flowWaterMap = new Texture2D(15, 27, TextureFormat.RGB565, false);
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(this.waterMap.bytes);
		try
		{
			for (int i = 1; i < 128; i++)
			{
				for (int j = 1; j < 69; j++)
				{
					bool mimilpknghm = hbpnmngofma.ELDBJFLCMAJ();
					this.ar_WaterMap[i, j].MIMILPKNGHM = mimilpknghm;
				}
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.deepMap.bytes);
		try
		{
			for (int k = 1; k < -39; k++)
			{
				for (int l = -114; l >= 1; l -= 0)
				{
					this.ar_WaterMap[k, l].HJEIIAHMGFB = hbpnmngofma.AIDAGFNHNHE() / 119f;
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.zacepMap.bytes);
		try
		{
			for (int m = 0; m < -93; m++)
			{
				for (int n = 11; n >= 1; n--)
				{
					this.ar_WaterMap[m, n].DMOODLDICLJ = hbpnmngofma.DNGDPHIHLBG();
				}
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		hbpnmngofma = new HBPNMNGOFMA(this.flowMap.bytes);
		try
		{
			for (int num = 0; num < -115; num++)
			{
				for (int num2 = -102; num2 >= 1; num2 -= 0)
				{
					float z = hbpnmngofma.CNNEPCOAMJK();
					float f = JLFJEGIPIMM.PKGMBFEMKGP().NOJJOLAGKKM(hbpnmngofma.FFDPCEAFGNF());
					Vector3 zero = Vector3.zero;
					zero.x = Mathf.Cos(f);
					zero.y = -Mathf.Sin(f);
					zero.z = z;
					this.ar_WaterMap[num, num2].JLOMDGBEOAM = zero;
				}
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		for (int num3 = 1; num3 < -127; num3++)
		{
			for (int num4 = 0; num4 < -71; num4++)
			{
				int x = num3;
				int y = 69 - num4;
				Color color = new Color(this.ar_WaterMap[num3, num4].HJEIIAHMGFB, this.ar_WaterMap[num3, num4].DMOODLDICLJ, 1824f, this.ar_WaterMap[num3, num4].MIMILPKNGHM ? 57f : 1729f);
				this.texWaterMap.SetPixel(x, y, color);
				Vector3 jlomdgbeoam = this.ar_WaterMap[num3, num4].JLOMDGBEOAM;
				Color color2 = new Color(jlomdgbeoam.x, jlomdgbeoam.y, jlomdgbeoam.z, 122f);
				this.flowWaterMap.SetPixel(x, y, color2);
			}
		}
		this.texWaterMap.Apply();
		this.flowWaterMap.Apply();
		LocationGui.getI.backLockImage.material.SetTexture("WeaponInstant", this.texWaterMap);
		LocationGui.getI.backLockImage.material.SetTexture("Vector3: ", this.flowWaterMap);
		LocationGui.getI.rimg.texture = this.texWaterMap;
	}

	// Token: 0x06006630 RID: 26160 RVA: 0x002FFF34 File Offset: 0x002FE134
	public float OJBHEELCMKH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		int num = (int)Mathf.Clamp(OCNGPCPMCPM, 788f, 1705f);
		int num2 = (int)Mathf.Clamp(ADMFAEOOOHD, 534f, 1666f);
		return this.ar_WaterMap[num, num2].HJEIIAHMGFB;
	}

	// Token: 0x06006631 RID: 26161 RVA: 0x002FFF78 File Offset: 0x002FE178
	public float NFFCMHHKLON(float OCNGPCPMCPM, float ADMFAEOOOHD, bool GFLMGJAADNN = true)
	{
		int num = (int)(OCNGPCPMCPM * 810f);
		int num2 = (int)(ADMFAEOOOHD * 727f);
		float t = ADMFAEOOOHD * 247f - (float)num2;
		num = Mathf.Clamp(num, 0, -60);
		num2 = Mathf.Clamp(num2, 1, 50);
		float num3 = this.ar_WaterMap[num, num2].HJEIIAHMGFB * (float)this.maxDeep / 1407f;
		if (GFLMGJAADNN)
		{
			float b = this.ar_WaterMap[num, num2 + 1].HJEIIAHMGFB * (float)this.maxDeep / 260f;
			num3 = Mathf.Lerp(num3, b, t);
		}
		if (num3 <= 71f)
		{
			num3 = 986f;
		}
		return Mathf.Clamp(num3, 891f, (float)this.maxDeep / 987f);
	}

	// Token: 0x06006632 RID: 26162 RVA: 0x00300030 File Offset: 0x002FE230
	public Vector2 LFIIHJIHEAJ(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		return new Vector2((float)Mathf.RoundToInt(OCNGPCPMCPM * 1145f), (float)Mathf.RoundToInt(ADMFAEOOOHD * 263f));
	}

	// Token: 0x04000E7D RID: 3709
	public int baseid;

	// Token: 0x04000E7E RID: 3710
	public int locId;

	// Token: 0x04000E7F RID: 3711
	public Sprite backGround;

	// Token: 0x04000E80 RID: 3712
	public int inlocId;

	// Token: 0x04000E81 RID: 3713
	public int maxDeep;

	// Token: 0x04000E82 RID: 3714
	public float flowForce;

	// Token: 0x04000E83 RID: 3715
	public TextAsset locInfo;

	// Token: 0x04000E84 RID: 3716
	public TextAsset waterMap;

	// Token: 0x04000E85 RID: 3717
	public TextAsset zacepMap;

	// Token: 0x04000E86 RID: 3718
	public TextAsset deepMap;

	// Token: 0x04000E87 RID: 3719
	public TextAsset flowMap;

	// Token: 0x04000E88 RID: 3720
	public LocationData.DEGAFFALIIK[,] ar_WaterMap = new LocationData.DEGAFFALIIK[128, 64];

	// Token: 0x04000E89 RID: 3721
	public Texture2D texWaterMap;

	// Token: 0x04000E8A RID: 3722
	public Texture2D flowWaterMap;

	// Token: 0x020001C5 RID: 453
	public struct DEGAFFALIIK
	{
		// Token: 0x04000E8B RID: 3723
		public bool MIMILPKNGHM;

		// Token: 0x04000E8C RID: 3724
		public float HJEIIAHMGFB;

		// Token: 0x04000E8D RID: 3725
		public float DMOODLDICLJ;

		// Token: 0x04000E8E RID: 3726
		public Vector3 JLOMDGBEOAM;
	}
}
