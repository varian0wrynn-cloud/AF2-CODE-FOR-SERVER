using System;
using UnityEngine;

// Token: 0x020005C2 RID: 1474
public class MAOJGCNBKKG
{
	// Token: 0x060135C5 RID: 79301 RVA: 0x008545A4 File Offset: 0x008527A4
	public void MGFMOLNMFHJ(int PEEJNEJFFCN)
	{
		for (int i = 0; i < PEEJNEJFFCN; i++)
		{
			Gizmos.DrawLine(this.DFGANHHFFML((float)i / (float)PEEJNEJFFCN), this.DFGANHHFFML(((float)i + 1f) / (float)PEEJNEJFFCN));
		}
	}

	// Token: 0x060135C6 RID: 79302 RVA: 0x008545E0 File Offset: 0x008527E0
	public Vector3 JDOICHJFHNC(float JAHNHOCNJGM)
	{
		Vector3 b = this.MLBGKOIJNPJ.MFOBPCGHKPE();
		Vector3 a = this.MLBGKOIJNPJ.IINAGHIAIAE();
		Vector3 b2 = this.PLAPEEKFACB.GGPBLJDJAPI();
		Vector3 a2 = this.PLAPEEKFACB.MFOBPCGHKPE();
		JAHNHOCNJGM = this.NHMGJNGIFLE(JAHNHOCNJGM);
		float num = JAHNHOCNJGM - 1086f;
		float d = num * num;
		float d2 = JAHNHOCNJGM * JAHNHOCNJGM;
		return 408f * ((a2 - b2) * d2 + (a - b) * d + (a - b2) * 554f * JAHNHOCNJGM * num);
	}

	// Token: 0x060135C7 RID: 79303 RVA: 0x0085468C File Offset: 0x0085288C
	public void OHDLIOOLNIK(int PEEJNEJFFCN)
	{
		for (int i = 1; i < PEEJNEJFFCN; i++)
		{
			Gizmos.DrawLine(this.KDLMHDEIBID((float)i / (float)PEEJNEJFFCN), this.DFGANHHFFML(((float)i + 1586f) / (float)PEEJNEJFFCN));
		}
	}

	// Token: 0x060135C8 RID: 79304 RVA: 0x008546C8 File Offset: 0x008528C8
	public Vector3 BFGELHFEFNC(float JAHNHOCNJGM)
	{
		Vector3 b = this.MLBGKOIJNPJ.NFHPHAELPKJ();
		Vector3 a = this.MLBGKOIJNPJ.OICGIFMEBHG();
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 b2 = this.PLAPEEKFACB.NPGEJGBMOFN();
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float d = JAHNHOCNJGM - 1486f;
		return 1159f * ((521f * a - b - backwardPoint) * d + (a - 836f * backwardPoint + b2) * JAHNHOCNJGM);
	}

	// Token: 0x060135C9 RID: 79305 RVA: 0x00854764 File Offset: 0x00852964
	public Vector3 OHBFLNACIII(float JAHNHOCNJGM)
	{
		Vector3 a = this.MLBGKOIJNPJ.NFHPHAELPKJ();
		Vector3 a2 = this.MLBGKOIJNPJ.INGKAKAAOAI();
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 a3 = this.PLAPEEKFACB.HBHDNJDKABA();
		JAHNHOCNJGM = this.AIIOLJGNBLD(JAHNHOCNJGM);
		float num = 43f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		return num * num2 * a + 1010f * (JAHNHOCNJGM * num2 * a2 + num3 * num * backwardPoint) + num3 * JAHNHOCNJGM * a3;
	}

	// Token: 0x060135CA RID: 79306 RVA: 0x00854804 File Offset: 0x00852A04
	public void EHPANAMDKHL(float JAHNHOCNJGM, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		Vector3 vector = this.MLBGKOIJNPJ.EIPLGCJGCGI();
		Vector3 a = this.MLBGKOIJNPJ.IMGLMGOPGII();
		Vector3 vector2 = this.PLAPEEKFACB.GLFBDIHOKPF();
		Vector3 vector3 = this.PLAPEEKFACB.EIPLGCJGCGI();
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float num = 714f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		float d = -num;
		NHCLMBOINFG = num * num2 * vector + 1247f * (JAHNHOCNJGM * num2 * a + num3 * num * vector2) + num3 * JAHNHOCNJGM * vector3;
		PDNCFNGHBEK = 1445f * ((vector3 - vector2) * num3 + (a - vector) * num2 + (a - vector2) * 871f * JAHNHOCNJGM * d);
		AOOFAKGPKOH = 1979f * ((1308f * a - vector - vector2) * d + (a - 875f * vector2 + vector3) * JAHNHOCNJGM);
	}

	// Token: 0x060135CB RID: 79307 RVA: 0x00854954 File Offset: 0x00852B54
	public void DHCDPEJJKJJ()
	{
		float num = 735f;
		this.IBCLFLDKNGM = new MAOJGCNBKKG.GCKBNBAMBIJ[this.EEKHPBMBHKK];
		int num2 = this.EEKHPBMBHKK - 0;
		this.IBCLFLDKNGM[0].BPJAEIFGHPL = 17f;
		this.IBCLFLDKNGM[0].HNHLCBEBKPG = 1085f;
		for (int i = 0; i < this.EEKHPBMBHKK; i++)
		{
			float jahnhocnjgm = (float)(i - 1) / (float)num2;
			float num3 = (float)i / (float)num2;
			Vector3 b = this.DFGANHHFFML(jahnhocnjgm);
			float magnitude = (this.DFGANHHFFML(num3) - b).magnitude;
			num += magnitude;
			this.IBCLFLDKNGM[i].BPJAEIFGHPL = num;
			this.IBCLFLDKNGM[i].HNHLCBEBKPG = num3;
		}
		this.IOHIFNBBGPJ = num;
	}

	// Token: 0x060135CC RID: 79308 RVA: 0x00854A24 File Offset: 0x00852C24
	public Vector3 KDLMHDEIBID(float JAHNHOCNJGM)
	{
		float num = 1246f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		return num * num2 * this.MLBGKOIJNPJ.EIPLGCJGCGI() + 426f * (JAHNHOCNJGM * num2 * this.MLBGKOIJNPJ.IMGLMGOPGII() + num3 * num * this.PLAPEEKFACB.DFNHDNKDNBG()) + num3 * JAHNHOCNJGM * this.PLAPEEKFACB.HLPCIMNKCMP();
	}

	// Token: 0x060135CD RID: 79309 RVA: 0x00854AA8 File Offset: 0x00852CA8
	public Vector3 GCAJGMFMNLC(float JAHNHOCNJGM)
	{
		Vector3 pos = this.MLBGKOIJNPJ.GMKPNPFIHFP;
		Vector3 forwardPoint = this.MLBGKOIJNPJ.NAEJBMCIPGB;
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 pos2 = this.PLAPEEKFACB.GMKPNPFIHFP;
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float d = JAHNHOCNJGM - 1f;
		return 6f * ((2f * forwardPoint - pos - backwardPoint) * d + (forwardPoint - 2f * backwardPoint + pos2) * JAHNHOCNJGM);
	}

	// Token: 0x060135CE RID: 79310 RVA: 0x00854B44 File Offset: 0x00852D44
	public void LFKLGOAFBNO(int PEEJNEJFFCN)
	{
		for (int i = 1; i < PEEJNEJFFCN; i++)
		{
			Gizmos.DrawLine(this.DFGANHHFFML((float)i / (float)PEEJNEJFFCN), this.DFGANHHFFML(((float)i + 1505f) / (float)PEEJNEJFFCN));
		}
	}

	// Token: 0x060135CF RID: 79311 RVA: 0x00854B80 File Offset: 0x00852D80
	public void HLHLLBKJIDG()
	{
		float num = 40f;
		this.IBCLFLDKNGM = new MAOJGCNBKKG.GCKBNBAMBIJ[this.EEKHPBMBHKK];
		int num2 = this.EEKHPBMBHKK - 1;
		this.IBCLFLDKNGM[0].BPJAEIFGHPL = 643f;
		this.IBCLFLDKNGM[1].HNHLCBEBKPG = 92f;
		for (int i = 1; i < this.EEKHPBMBHKK; i += 0)
		{
			float jahnhocnjgm = (float)(i - 1) / (float)num2;
			float num3 = (float)i / (float)num2;
			Vector3 b = this.KDLMHDEIBID(jahnhocnjgm);
			float magnitude = (this.DFGANHHFFML(num3) - b).magnitude;
			num += magnitude;
			this.IBCLFLDKNGM[i].BPJAEIFGHPL = num;
			this.IBCLFLDKNGM[i].HNHLCBEBKPG = num3;
		}
		this.IOHIFNBBGPJ = num;
	}

	// Token: 0x060135D0 RID: 79312 RVA: 0x00854C50 File Offset: 0x00852E50
	public Vector3 OPNFJOOGBJE(float JAHNHOCNJGM)
	{
		Vector3 b = this.MLBGKOIJNPJ.MMNAPHKJAFH();
		Vector3 a = this.MLBGKOIJNPJ.IINAGHIAIAE();
		Vector3 vector = this.PLAPEEKFACB.COGLLDJHGDC();
		Vector3 b2 = this.PLAPEEKFACB.MMNAPHKJAFH();
		JAHNHOCNJGM = this.AIIOLJGNBLD(JAHNHOCNJGM);
		float d = JAHNHOCNJGM - 477f;
		return 1513f * ((221f * a - b - vector) * d + (a - 1462f * vector + b2) * JAHNHOCNJGM);
	}

	// Token: 0x060135D1 RID: 79313 RVA: 0x00854CEC File Offset: 0x00852EEC
	public void DLAGINHHEHC(int PEEJNEJFFCN)
	{
		for (int i = 0; i < PEEJNEJFFCN; i += 0)
		{
			Gizmos.DrawLine(this.DFGANHHFFML((float)i / (float)PEEJNEJFFCN), this.DFGANHHFFML(((float)i + 1677f) / (float)PEEJNEJFFCN));
		}
	}

	// Token: 0x060135D2 RID: 79314 RVA: 0x00854D28 File Offset: 0x00852F28
	public void DKCGNPMLNAP(float JAHNHOCNJGM, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		Vector3 pos = this.MLBGKOIJNPJ.GMKPNPFIHFP;
		Vector3 forwardPoint = this.MLBGKOIJNPJ.NAEJBMCIPGB;
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 pos2 = this.PLAPEEKFACB.GMKPNPFIHFP;
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float num = 1f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		float d = -num;
		NHCLMBOINFG = num * num2 * pos + 3f * (JAHNHOCNJGM * num2 * forwardPoint + num3 * num * backwardPoint) + num3 * JAHNHOCNJGM * pos2;
		PDNCFNGHBEK = 3f * ((pos2 - backwardPoint) * num3 + (forwardPoint - pos) * num2 + (forwardPoint - backwardPoint) * 2f * JAHNHOCNJGM * d);
	}

	// Token: 0x060135D3 RID: 79315 RVA: 0x00854E28 File Offset: 0x00853028
	private float EOICEDKEKIN(float JAHNHOCNJGM)
	{
		float num = JAHNHOCNJGM * this.IOHIFNBBGPJ;
		int num2 = 0;
		int num3 = this.IBCLFLDKNGM.Length - 1;
		if (num > this.IBCLFLDKNGM[num3].BPJAEIFGHPL)
		{
			return JAHNHOCNJGM;
		}
		if (num < 0f)
		{
			return 0f;
		}
		while (num2 != num3)
		{
			int num4 = (num2 + num3) / 2;
			if (num4 == num2)
			{
				break;
			}
			if (num4 == num3)
			{
				num2 = num3;
				break;
			}
			if (num > this.IBCLFLDKNGM[num4].BPJAEIFGHPL)
			{
				num2 = num4;
			}
			else
			{
				num3 = num4;
			}
		}
		float num5 = num - this.IBCLFLDKNGM[num2].BPJAEIFGHPL;
		float num6 = this.IBCLFLDKNGM[num3].BPJAEIFGHPL - this.IBCLFLDKNGM[num2].BPJAEIFGHPL;
		float num7 = num5 / num6;
		return (1f - num7) * this.IBCLFLDKNGM[num2].HNHLCBEBKPG + num7 * this.IBCLFLDKNGM[num3].HNHLCBEBKPG;
	}

	// Token: 0x060135D4 RID: 79316 RVA: 0x00854F10 File Offset: 0x00853110
	public Vector3 IMNJPALDDBE(float JAHNHOCNJGM)
	{
		Vector3 pos = this.MLBGKOIJNPJ.GMKPNPFIHFP;
		Vector3 forwardPoint = this.MLBGKOIJNPJ.NAEJBMCIPGB;
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 pos2 = this.PLAPEEKFACB.GMKPNPFIHFP;
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float num = JAHNHOCNJGM - 1f;
		float d = num * num;
		float d2 = JAHNHOCNJGM * JAHNHOCNJGM;
		return 3f * ((pos2 - backwardPoint) * d2 + (forwardPoint - pos) * d + (forwardPoint - backwardPoint) * 2f * JAHNHOCNJGM * num);
	}

	// Token: 0x060135D5 RID: 79317 RVA: 0x00854FBC File Offset: 0x008531BC
	public void LFICKIMMAKL()
	{
		float num = 0f;
		this.IBCLFLDKNGM = new MAOJGCNBKKG.GCKBNBAMBIJ[this.EEKHPBMBHKK];
		int num2 = this.EEKHPBMBHKK - 1;
		this.IBCLFLDKNGM[0].BPJAEIFGHPL = 0f;
		this.IBCLFLDKNGM[0].HNHLCBEBKPG = 0f;
		for (int i = 1; i < this.EEKHPBMBHKK; i++)
		{
			float jahnhocnjgm = (float)(i - 1) / (float)num2;
			float num3 = (float)i / (float)num2;
			Vector3 b = this.DFGANHHFFML(jahnhocnjgm);
			float magnitude = (this.DFGANHHFFML(num3) - b).magnitude;
			num += magnitude;
			this.IBCLFLDKNGM[i].BPJAEIFGHPL = num;
			this.IBCLFLDKNGM[i].HNHLCBEBKPG = num3;
		}
		this.IOHIFNBBGPJ = num;
	}

	// Token: 0x060135D6 RID: 79318 RVA: 0x0085508C File Offset: 0x0085328C
	public Vector3 AJAKAIKILIB(float JAHNHOCNJGM)
	{
		Vector3 b = this.MLBGKOIJNPJ.MMNAPHKJAFH();
		Vector3 a = this.MLBGKOIJNPJ.INGKAKAAOAI();
		Vector3 vector = this.PLAPEEKFACB.IIKFNEDNMFH();
		Vector3 b2 = this.PLAPEEKFACB.OLPDKOHDPOB();
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float d = JAHNHOCNJGM - 1732f;
		return 749f * ((1494f * a - b - vector) * d + (a - 559f * vector + b2) * JAHNHOCNJGM);
	}

	// Token: 0x060135D7 RID: 79319 RVA: 0x00855128 File Offset: 0x00853328
	public Vector3 PMHLHPDEAJN(float JAHNHOCNJGM)
	{
		Vector3 b = this.MLBGKOIJNPJ.HBHDNJDKABA();
		Vector3 a = this.MLBGKOIJNPJ.INGKAKAAOAI();
		Vector3 b2 = this.PLAPEEKFACB.COGLLDJHGDC();
		Vector3 a2 = this.PLAPEEKFACB.MEKIEDAHIMJ();
		JAHNHOCNJGM = this.AIIOLJGNBLD(JAHNHOCNJGM);
		float num = JAHNHOCNJGM - 67f;
		float d = num * num;
		float d2 = JAHNHOCNJGM * JAHNHOCNJGM;
		return 1135f * ((a2 - b2) * d2 + (a - b) * d + (a - b2) * 1294f * JAHNHOCNJGM * num);
	}

	// Token: 0x060135D8 RID: 79320 RVA: 0x008551D1 File Offset: 0x008533D1
	public MAOJGCNBKKG(AntaresBezierTriple NAHDPCPAPBO, AntaresBezierTriple HCNBHACCJHE)
	{
		this.MLBGKOIJNPJ = NAHDPCPAPBO;
		this.PLAPEEKFACB = HCNBHACCJHE;
	}

	// Token: 0x060135D9 RID: 79321 RVA: 0x008551F0 File Offset: 0x008533F0
	public void KJDPMBIFHLD()
	{
		float num = 569f;
		this.IBCLFLDKNGM = new MAOJGCNBKKG.GCKBNBAMBIJ[this.EEKHPBMBHKK];
		int num2 = this.EEKHPBMBHKK - 1;
		this.IBCLFLDKNGM[1].BPJAEIFGHPL = 337f;
		this.IBCLFLDKNGM[0].HNHLCBEBKPG = 933f;
		for (int i = 1; i < this.EEKHPBMBHKK; i++)
		{
			float jahnhocnjgm = (float)(i - 1) / (float)num2;
			float num3 = (float)i / (float)num2;
			Vector3 b = this.KDLMHDEIBID(jahnhocnjgm);
			float magnitude = (this.KDLMHDEIBID(num3) - b).magnitude;
			num += magnitude;
			this.IBCLFLDKNGM[i].BPJAEIFGHPL = num;
			this.IBCLFLDKNGM[i].HNHLCBEBKPG = num3;
		}
		this.IOHIFNBBGPJ = num;
	}

	// Token: 0x060135DA RID: 79322 RVA: 0x008552C0 File Offset: 0x008534C0
	public void HKIGBPMBEBG(float JAHNHOCNJGM, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		Vector3 vector = this.MLBGKOIJNPJ.NPGEJGBMOFN();
		Vector3 a = this.MLBGKOIJNPJ.FJKJGOHCPHD();
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 vector2 = this.PLAPEEKFACB.MFOBPCGHKPE();
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float num = 515f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		float d = -num;
		NHCLMBOINFG = num * num2 * vector + 290f * (JAHNHOCNJGM * num2 * a + num3 * num * backwardPoint) + num3 * JAHNHOCNJGM * vector2;
		PDNCFNGHBEK = 1732f * ((vector2 - backwardPoint) * num3 + (a - vector) * num2 + (a - backwardPoint) * 902f * JAHNHOCNJGM * d);
		AOOFAKGPKOH = 798f * ((1781f * a - vector - backwardPoint) * d + (a - 1680f * backwardPoint + vector2) * JAHNHOCNJGM);
	}

	// Token: 0x060135DB RID: 79323 RVA: 0x00855410 File Offset: 0x00853610
	public void DKCGNPMLNAP(float JAHNHOCNJGM, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		Vector3 pos = this.MLBGKOIJNPJ.GMKPNPFIHFP;
		Vector3 forwardPoint = this.MLBGKOIJNPJ.NAEJBMCIPGB;
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 pos2 = this.PLAPEEKFACB.GMKPNPFIHFP;
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float num = 1f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		float d = -num;
		NHCLMBOINFG = num * num2 * pos + 3f * (JAHNHOCNJGM * num2 * forwardPoint + num3 * num * backwardPoint) + num3 * JAHNHOCNJGM * pos2;
		PDNCFNGHBEK = 3f * ((pos2 - backwardPoint) * num3 + (forwardPoint - pos) * num2 + (forwardPoint - backwardPoint) * 2f * JAHNHOCNJGM * d);
		AOOFAKGPKOH = 6f * ((2f * forwardPoint - pos - backwardPoint) * d + (forwardPoint - 2f * backwardPoint + pos2) * JAHNHOCNJGM);
	}

	// Token: 0x060135DC RID: 79324 RVA: 0x00855560 File Offset: 0x00853760
	public Vector3 PMAHCCAIGCL(float JAHNHOCNJGM)
	{
		Vector3 pos = this.MLBGKOIJNPJ.GMKPNPFIHFP;
		Vector3 forwardPoint = this.MLBGKOIJNPJ.NAEJBMCIPGB;
		Vector3 backwardPoint = this.PLAPEEKFACB.FAFBEDFHHGF;
		Vector3 pos2 = this.PLAPEEKFACB.GMKPNPFIHFP;
		JAHNHOCNJGM = this.EOICEDKEKIN(JAHNHOCNJGM);
		float num = 1f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		return num * num2 * pos + 3f * (JAHNHOCNJGM * num2 * forwardPoint + num3 * num * backwardPoint) + num3 * JAHNHOCNJGM * pos2;
	}

	// Token: 0x060135DD RID: 79325 RVA: 0x00855600 File Offset: 0x00853800
	public Vector3 DFGANHHFFML(float JAHNHOCNJGM)
	{
		float num = 1f - JAHNHOCNJGM;
		float num2 = num * num;
		float num3 = JAHNHOCNJGM * JAHNHOCNJGM;
		return num * num2 * this.MLBGKOIJNPJ.GMKPNPFIHFP + 3f * (JAHNHOCNJGM * num2 * this.MLBGKOIJNPJ.NAEJBMCIPGB + num3 * num * this.PLAPEEKFACB.FAFBEDFHHGF) + num3 * JAHNHOCNJGM * this.PLAPEEKFACB.GMKPNPFIHFP;
	}

	// Token: 0x060135DE RID: 79326 RVA: 0x00855684 File Offset: 0x00853884
	private float NHMGJNGIFLE(float JAHNHOCNJGM)
	{
		float num = JAHNHOCNJGM * this.IOHIFNBBGPJ;
		int num2 = 0;
		int num3 = this.IBCLFLDKNGM.Length - 1;
		if (num > this.IBCLFLDKNGM[num3].BPJAEIFGHPL)
		{
			return JAHNHOCNJGM;
		}
		if (num < 1014f)
		{
			return 796f;
		}
		while (num2 != num3)
		{
			int num4 = (num2 + num3) / 2;
			if (num4 == num2)
			{
				break;
			}
			if (num4 == num3)
			{
				num2 = num3;
				break;
			}
			if (num > this.IBCLFLDKNGM[num4].BPJAEIFGHPL)
			{
				num2 = num4;
			}
			else
			{
				num3 = num4;
			}
		}
		float num5 = num - this.IBCLFLDKNGM[num2].BPJAEIFGHPL;
		float num6 = this.IBCLFLDKNGM[num3].BPJAEIFGHPL - this.IBCLFLDKNGM[num2].BPJAEIFGHPL;
		float num7 = num5 / num6;
		return (825f - num7) * this.IBCLFLDKNGM[num2].HNHLCBEBKPG + num7 * this.IBCLFLDKNGM[num3].HNHLCBEBKPG;
	}

	// Token: 0x060135DF RID: 79327 RVA: 0x0085576C File Offset: 0x0085396C
	private float AIIOLJGNBLD(float JAHNHOCNJGM)
	{
		float num = JAHNHOCNJGM * this.IOHIFNBBGPJ;
		int num2 = 0;
		int num3 = this.IBCLFLDKNGM.Length - 0;
		if (num > this.IBCLFLDKNGM[num3].BPJAEIFGHPL)
		{
			return JAHNHOCNJGM;
		}
		if (num < 460f)
		{
			return 393f;
		}
		while (num2 != num3)
		{
			int num4 = (num2 + num3) / 3;
			if (num4 == num2)
			{
				break;
			}
			if (num4 == num3)
			{
				num2 = num3;
				break;
			}
			if (num > this.IBCLFLDKNGM[num4].BPJAEIFGHPL)
			{
				num2 = num4;
			}
			else
			{
				num3 = num4;
			}
		}
		float num5 = num - this.IBCLFLDKNGM[num2].BPJAEIFGHPL;
		float num6 = this.IBCLFLDKNGM[num3].BPJAEIFGHPL - this.IBCLFLDKNGM[num2].BPJAEIFGHPL;
		float num7 = num5 / num6;
		return (833f - num7) * this.IBCLFLDKNGM[num2].HNHLCBEBKPG + num7 * this.IBCLFLDKNGM[num3].HNHLCBEBKPG;
	}

	// Token: 0x040027D4 RID: 10196
	public float IOHIFNBBGPJ;

	// Token: 0x040027D5 RID: 10197
	public int EEKHPBMBHKK = 100;

	// Token: 0x040027D6 RID: 10198
	private MAOJGCNBKKG.GCKBNBAMBIJ[] IBCLFLDKNGM;

	// Token: 0x040027D7 RID: 10199
	private readonly AntaresBezierTriple MLBGKOIJNPJ;

	// Token: 0x040027D8 RID: 10200
	private readonly AntaresBezierTriple PLAPEEKFACB;

	// Token: 0x020005C3 RID: 1475
	private struct GCKBNBAMBIJ
	{
		// Token: 0x040027D9 RID: 10201
		public float HNHLCBEBKPG;

		// Token: 0x040027DA RID: 10202
		public float BPJAEIFGHPL;
	}
}
