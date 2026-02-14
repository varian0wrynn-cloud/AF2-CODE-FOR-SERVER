using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002C RID: 44
public class AntaresBezierCurve : MonoBehaviour
{
	// Token: 0x060008C5 RID: 2245 RVA: 0x000573C0 File Offset: 0x000555C0
	public void OKGHBFLBDHC(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 286f;
		while (DPIDNFHGCEP >= this.GEHLCDGLAPA())
		{
			DPIDNFHGCEP -= this.JKFFKELJICD();
		}
		while (DPIDNFHGCEP < 493f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].HKIGBPMBEBG(801f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x0005746F File Offset: 0x0005566F
	public float EJJNDELAOLK()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00057478 File Offset: 0x00055678
	public Vector3[] GEFFLNKHIGL()
	{
		List<Vector3> list = new List<Vector3>();
		this.DLKHCIMECOF();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.GEHLCDGLAPA() / (float)num;
		for (int i = 1; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.DGJGFFKGBJI(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(45f);
		}
		return list.ToArray();
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00057504 File Offset: 0x00055704
	public void JBNLHEMFJMD(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 332f;
		while (DPIDNFHGCEP >= this.CPJLNEBJFCH())
		{
			DPIDNFHGCEP -= this.JKFFKELJICD();
		}
		while (DPIDNFHGCEP < 752f)
		{
			DPIDNFHGCEP += this.GEHLCDGLAPA();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1838f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x000575B0 File Offset: 0x000557B0
	public void JPOMBDNGFMP(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 931f;
		while (DPIDNFHGCEP >= this.LCDAHPCNDAP())
		{
			DPIDNFHGCEP -= this.KEBBDJGFJGN();
		}
		while (DPIDNFHGCEP < 423f)
		{
			DPIDNFHGCEP += this.DBAGFMKHDAM();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(933f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0005765C File Offset: 0x0005585C
	private void FDOONECGOGD()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 5)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.KAJHGHDGDGK();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 0)];
		this.IGLAPKIPAII = 1025f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = -175;
			this.Segments[i].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].OHDLIOOLNIK(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].OHDLIOOLNIK(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.JPOMBDNGFMP(this.TestValue * this.MFNLLPEBKIE(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 1058f);
		Gizmos.color = Color.white;
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00057814 File Offset: 0x00055A14
	public void DOFJHGGFJAA()
	{
		this.IGLAPKIPAII = 272f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 5)
		{
			throw new Exception("RollerBladeBackFlip");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00057950 File Offset: 0x00055B50
	public void CKDFNHHCBDO()
	{
		this.IGLAPKIPAII = 963f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 2)
		{
			throw new Exception("ENABLE_COLOR_GRADING");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 1; i < this.GHLIJIGGGJH.Length - 1; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00057A8C File Offset: 0x00055C8C
	private void IPGGLFINCFD()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 3)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.KLAMBFPFAAN();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 906f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = -185;
			this.Segments[i].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].DLAGINHHEHC(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].MGFMOLNMFHJ(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.OAANAOICPED(this.TestValue * this.COFAEFFHLFJ, out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 1996f);
		Gizmos.color = Color.white;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00057C44 File Offset: 0x00055E44
	public Vector3 DACFDJJIEPE(float DPIDNFHGCEP)
	{
		float num = 1103f;
		while (DPIDNFHGCEP >= this.KEBBDJGFJGN())
		{
			DPIDNFHGCEP -= this.KNBOKGCMKIE();
		}
		while (DPIDNFHGCEP < 443f)
		{
			DPIDNFHGCEP += this.EKGBNODNDIP();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1637f);
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00057CEC File Offset: 0x00055EEC
	public Vector3 PFLNGJOABEN(float DPIDNFHGCEP)
	{
		float num = 395f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.IHGDCPKPBGF();
		}
		while (DPIDNFHGCEP < 185f)
		{
			DPIDNFHGCEP += this.KEBBDJGFJGN();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].OHBFLNACIII(536f);
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00057D94 File Offset: 0x00055F94
	public void EIOJNDFFENC(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 174f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.IHGDCPKPBGF();
		}
		while (DPIDNFHGCEP < 1023f)
		{
			DPIDNFHGCEP += this.KEBBDJGFJGN();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(887f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00057E40 File Offset: 0x00056040
	public void JDJIKEGKCFP(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 555f;
		while (DPIDNFHGCEP >= this.DKAAMFEMEMN())
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 534f)
		{
			DPIDNFHGCEP += this.DBAGFMKHDAM();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].DKCGNPMLNAP(855f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00057EEC File Offset: 0x000560EC
	public void HHJHFCLKGAA(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 1948f;
		while (DPIDNFHGCEP >= this.IHGDCPKPBGF())
		{
			DPIDNFHGCEP -= this.DKAAMFEMEMN();
		}
		while (DPIDNFHGCEP < 1106f)
		{
			DPIDNFHGCEP += this.KEBBDJGFJGN();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].DKCGNPMLNAP(96f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00057F98 File Offset: 0x00056198
	private void LFCCJDBNICH()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 3)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.ECKNNODFNGJ();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 0)];
		this.IGLAPKIPAII = 1773f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = -147;
			this.Segments[i].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].DLAGINHHEHC(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].DLAGINHHEHC(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.EPJPFICLNFA(this.TestValue * this.EJJNDELAOLK(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 415f);
		Gizmos.color = Color.white;
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00058150 File Offset: 0x00056350
	public void JPLLFJKKEMP(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 752f;
		while (DPIDNFHGCEP >= this.LCDAHPCNDAP())
		{
			DPIDNFHGCEP -= this.NDOGOHFBALH();
		}
		while (DPIDNFHGCEP < 879f)
		{
			DPIDNFHGCEP += this.DBAGFMKHDAM();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1326f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x000581FC File Offset: 0x000563FC
	public void DDGIEKDAPOK()
	{
		this.IGLAPKIPAII = 618f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 3)
		{
			throw new Exception("IceHockey Shot Right");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00058338 File Offset: 0x00056538
	public void Smooth()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				if (i < componentsInChildren.Length - 1)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 1)
			{
				antaresBezierTriple3 = componentsInChildren[i + 1];
				if (i > 0)
				{
					antaresBezierTriple2 = componentsInChildren[i - 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 1];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.GMKPNPFIHFP, antaresBezierTriple2.GMKPNPFIHFP, 0.33333334f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.GMKPNPFIHFP, antaresBezierTriple3.GMKPNPFIHFP, 0.33333334f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.GMKPNPFIHFP - b;
				Vector3 vector4 = antaresBezierTriple.GMKPNPFIHFP - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.GMKPNPFIHFP + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.GMKPNPFIHFP - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.FAFBEDFHHGF = Vector3.Lerp(antaresBezierTriple.GMKPNPFIHFP, antaresBezierTriple2.GMKPNPFIHFP, 0.33333334f);
				antaresBezierTriple.NAEJBMCIPGB = Vector3.Lerp(antaresBezierTriple.GMKPNPFIHFP, antaresBezierTriple3.GMKPNPFIHFP, 0.33333334f);
			}
		}
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x000584E8 File Offset: 0x000566E8
	public Vector3[] IOHAEINMJJD()
	{
		List<Vector3> list = new List<Vector3>();
		this.HLKMNAGCFOM();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.IHGDCPKPBGF() / (float)num;
		for (int i = 0; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.GetInterpolatedPoint(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 0].OHBFLNACIII(1787f);
		}
		return list.ToArray();
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00058574 File Offset: 0x00056774
	public Vector3[] DFEJPLFGPDN()
	{
		List<Vector3> list = new List<Vector3>();
		this.NEDPNIAFOIC();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.GEBEJFFHINA() / (float)num;
		for (int i = 0; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.MDNGLFKDGKE(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 0].OHBFLNACIII(464f);
		}
		return list.ToArray();
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00058600 File Offset: 0x00056800
	public Vector3[] CPDHGBNPJAB()
	{
		List<Vector3> list = new List<Vector3>();
		this.NEDPNIAFOIC();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.MFNLLPEBKIE() / (float)num;
		for (int i = 1; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.KCPPFGEPOMM(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].OHBFLNACIII(1048f);
		}
		return list.ToArray();
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x0005746F File Offset: 0x0005566F
	public float DKAAMFEMEMN()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x0005868C File Offset: 0x0005688C
	public Vector3 LKDKKJKKCOA(float DPIDNFHGCEP)
	{
		float num = 782f;
		while (DPIDNFHGCEP >= this.IHGDCPKPBGF())
		{
			DPIDNFHGCEP -= this.NNHNDAIFHPH();
		}
		while (DPIDNFHGCEP < 360f)
		{
			DPIDNFHGCEP += this.NNHNDAIFHPH();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].OHBFLNACIII(1440f);
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x0005746F File Offset: 0x0005566F
	public float GEHLCDGLAPA()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00058734 File Offset: 0x00056934
	public Vector3 ENFHJGAMDMP(float DPIDNFHGCEP)
	{
		float num = 1145f;
		while (DPIDNFHGCEP >= this.NNHNDAIFHPH())
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 102f)
		{
			DPIDNFHGCEP += this.MFNLLPEBKIE();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].OHBFLNACIII(1281f);
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x000587DC File Offset: 0x000569DC
	public Vector3 KCPPFGEPOMM(float DPIDNFHGCEP)
	{
		float num = 995f;
		while (DPIDNFHGCEP >= this.MFNLLPEBKIE())
		{
			DPIDNFHGCEP -= this.KNBOKGCMKIE();
		}
		while (DPIDNFHGCEP < 1851f)
		{
			DPIDNFHGCEP += this.IHGDCPKPBGF();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(392f);
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00058884 File Offset: 0x00056A84
	public Vector3 JICDKGBNGGD(float DPIDNFHGCEP)
	{
		float num = 836f;
		while (DPIDNFHGCEP >= this.DBAGFMKHDAM())
		{
			DPIDNFHGCEP -= this.MFNLLPEBKIE();
		}
		while (DPIDNFHGCEP < 371f)
		{
			DPIDNFHGCEP += this.GEHLCDGLAPA();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(330f);
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x0005892C File Offset: 0x00056B2C
	private void AGKGALHDCBJ()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 1)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.ECKNNODFNGJ();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 1369f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = 82;
			this.Segments[i].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].DLAGINHHEHC(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].MGFMOLNMFHJ(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.OAANAOICPED(this.TestValue * this.NNHNDAIFHPH(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 1378f);
		Gizmos.color = Color.white;
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00058AE4 File Offset: 0x00056CE4
	public Vector3 BGFPEFHPJOJ(float DPIDNFHGCEP)
	{
		float num = 915f;
		while (DPIDNFHGCEP >= this.EKGBNODNDIP())
		{
			DPIDNFHGCEP -= this.LCDAHPCNDAP();
		}
		while (DPIDNFHGCEP < 1368f)
		{
			DPIDNFHGCEP += this.IHGDCPKPBGF();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].OHBFLNACIII(1352f);
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00058B8C File Offset: 0x00056D8C
	public Vector3 OHBFLNACIII(float DPIDNFHGCEP)
	{
		float num = 1148f;
		while (DPIDNFHGCEP >= this.CPJLNEBJFCH())
		{
			DPIDNFHGCEP -= this.GEBEJFFHINA();
		}
		while (DPIDNFHGCEP < 910f)
		{
			DPIDNFHGCEP += this.IHGDCPKPBGF();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].OHBFLNACIII(451f);
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00058C34 File Offset: 0x00056E34
	public void Init()
	{
		this.IGLAPKIPAII = 0f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 2)
		{
			throw new Exception("Bezier curve must have two or more control points!");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00058D70 File Offset: 0x00056F70
	public void PMNDPLOIJLJ(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1802f;
		while (DPIDNFHGCEP >= this.KNBOKGCMKIE())
		{
			DPIDNFHGCEP -= this.GEHLCDGLAPA();
		}
		while (DPIDNFHGCEP < 1015f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].EHPANAMDKHL(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].EHPANAMDKHL(1013f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00058E20 File Offset: 0x00057020
	public void KODEPNBMJGE()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 1)
				{
					antaresBezierTriple3 = componentsInChildren[i + 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[1];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 0)
			{
				antaresBezierTriple3 = componentsInChildren[i + 0];
				if (i > 0)
				{
					antaresBezierTriple2 = componentsInChildren[i - 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 0];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.EFBOCCHFBLP(), antaresBezierTriple2.NPGEJGBMOFN(), 990f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.LJCNPPLAHLK(), antaresBezierTriple3.LJCNPPLAHLK(), 1542f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.PJDAFMKJENM() - b;
				Vector3 vector4 = antaresBezierTriple.OLPDKOHDPOB() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.GMKPNPFIHFP + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MMNAPHKJAFH() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.CAFPOAGHHFN(Vector3.Lerp(antaresBezierTriple.MFOBPCGHKPE(), antaresBezierTriple2.HLPCIMNKCMP(), 1624f));
				antaresBezierTriple.AKHGFJMPKFL(Vector3.Lerp(antaresBezierTriple.NFHPHAELPKJ(), antaresBezierTriple3.EFBOCCHFBLP(), 1659f));
			}
		}
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00058FD0 File Offset: 0x000571D0
	public void LCGLNMDPOHI(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 1114f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.JKFFKELJICD();
		}
		while (DPIDNFHGCEP < 1479f)
		{
			DPIDNFHGCEP += this.CPJLNEBJFCH();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].DKCGNPMLNAP(1350f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0005746F File Offset: 0x0005566F
	public float COFAEFFHLFJ
	{
		get
		{
			return this.IGLAPKIPAII;
		}
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x0005907C File Offset: 0x0005727C
	public void AECIDHJBFPC()
	{
		this.IGLAPKIPAII = 882f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 6)
		{
			throw new Exception("cht_msg38");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x000591B8 File Offset: 0x000573B8
	public Vector3 PKKMJMABODL(float DPIDNFHGCEP)
	{
		float num = 1383f;
		while (DPIDNFHGCEP >= this.GEHLCDGLAPA())
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 982f)
		{
			DPIDNFHGCEP += this.LCDAHPCNDAP();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1261f);
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x0005746F File Offset: 0x0005566F
	public float LCDAHPCNDAP()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00059260 File Offset: 0x00057460
	public void KGFNBHIFKBG()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 1)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 0)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 1)
			{
				antaresBezierTriple3 = componentsInChildren[i + 1];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 0];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.HBHDNJDKABA(), antaresBezierTriple2.MMNAPHKJAFH(), 1920f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.MEKIEDAHIMJ(), antaresBezierTriple3.HBHDNJDKABA(), 1701f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.MBABDAOAEKE() - b;
				Vector3 vector4 = antaresBezierTriple.EIPLGCJGCGI() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MMNAPHKJAFH() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MFOBPCGHKPE() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.PEFIKBEIOAF(Vector3.Lerp(antaresBezierTriple.EFBOCCHFBLP(), antaresBezierTriple2.NPGEJGBMOFN(), 331f));
				antaresBezierTriple.HFBPHBDJIIJ(Vector3.Lerp(antaresBezierTriple.HBHDNJDKABA(), antaresBezierTriple3.PJDAFMKJENM(), 1740f));
			}
		}
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00059410 File Offset: 0x00057610
	public void GetInterpolatedValues(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 0f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 0f)
		{
			DPIDNFHGCEP += this.COFAEFFHLFJ;
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x0005746F File Offset: 0x0005566F
	public float NNHNDAIFHPH()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x000594BC File Offset: 0x000576BC
	public void PIACFHCPPMA(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1872f;
		while (DPIDNFHGCEP >= this.DBAGFMKHDAM())
		{
			DPIDNFHGCEP -= this.JKFFKELJICD();
		}
		while (DPIDNFHGCEP < 794f)
		{
			DPIDNFHGCEP += this.IHGDCPKPBGF();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].EHPANAMDKHL(1684f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x0005956C File Offset: 0x0005776C
	public Vector3[] GCDHNHIJBJH()
	{
		List<Vector3> list = new List<Vector3>();
		this.CKDFNHHCBDO();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.GEBEJFFHINA() / (float)num;
		for (int i = 0; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.DACFDJJIEPE(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 0] = this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1241f);
		}
		return list.ToArray();
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x000595F8 File Offset: 0x000577F8
	public void DONMKBAAMKK()
	{
		this.IGLAPKIPAII = 1734f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 4)
		{
			throw new Exception("[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 0)];
		for (int i = 1; i < this.GHLIJIGGGJH.Length - 0; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00059734 File Offset: 0x00057934
	public void CNLBLEEHDFN()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 1)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 0)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[1];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 1)
			{
				antaresBezierTriple3 = componentsInChildren[i + 1];
				if (i > 0)
				{
					antaresBezierTriple2 = componentsInChildren[i - 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 1];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.EIPLGCJGCGI(), antaresBezierTriple2.GMKPNPFIHFP, 1098f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.MMNAPHKJAFH(), antaresBezierTriple3.GMKPNPFIHFP, 170f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.MBABDAOAEKE() - b;
				Vector3 vector4 = antaresBezierTriple.MFOBPCGHKPE() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.HBHDNJDKABA() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MBABDAOAEKE() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.OJBLKOJOGJJ(Vector3.Lerp(antaresBezierTriple.MEKIEDAHIMJ(), antaresBezierTriple2.OLPDKOHDPOB(), 1811f));
				antaresBezierTriple.HFBPHBDJIIJ(Vector3.Lerp(antaresBezierTriple.MEKIEDAHIMJ(), antaresBezierTriple3.GMKPNPFIHFP, 1299f));
			}
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x000598E4 File Offset: 0x00057AE4
	public void GFNMMLFFGOP()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 1)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 0)
			{
				antaresBezierTriple3 = componentsInChildren[i + 0];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 1];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 0];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.OLPDKOHDPOB(), antaresBezierTriple2.MFOBPCGHKPE(), 1298f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.EFBOCCHFBLP(), antaresBezierTriple3.MBABDAOAEKE(), 1716f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.MEKIEDAHIMJ() - b;
				Vector3 vector4 = antaresBezierTriple.MMNAPHKJAFH() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.HLPCIMNKCMP() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MEKIEDAHIMJ() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.DGEHOHKBMGO(Vector3.Lerp(antaresBezierTriple.EFBOCCHFBLP(), antaresBezierTriple2.EIPLGCJGCGI(), 630f));
				antaresBezierTriple.MPGCJLAEGNK(Vector3.Lerp(antaresBezierTriple.MFOBPCGHKPE(), antaresBezierTriple3.MFOBPCGHKPE(), 550f));
			}
		}
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00059A91 File Offset: 0x00057C91
	private void Start()
	{
		this.Init();
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00059A9C File Offset: 0x00057C9C
	public void BIKNKOENMLP(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 1338f;
		while (DPIDNFHGCEP >= this.JKFFKELJICD())
		{
			DPIDNFHGCEP -= this.NDOGOHFBALH();
		}
		while (DPIDNFHGCEP < 952f)
		{
			DPIDNFHGCEP += this.MFNLLPEBKIE();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(571f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00059B47 File Offset: 0x00057D47
	private void FJGIBCHABIG()
	{
		this.NBNPGNFKHMF();
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00059B50 File Offset: 0x00057D50
	public void MKHDIDMDBBG(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1571f;
		while (DPIDNFHGCEP >= this.GEHLCDGLAPA())
		{
			DPIDNFHGCEP -= this.LCDAHPCNDAP();
		}
		while (DPIDNFHGCEP < 970f)
		{
			DPIDNFHGCEP += this.NDOGOHFBALH();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].DKCGNPMLNAP(1414f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00059C00 File Offset: 0x00057E00
	public void AFJKKLBAIJE()
	{
		this.IGLAPKIPAII = 1896f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 8)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00059D39 File Offset: 0x00057F39
	private void LHMNFJBJBJM()
	{
		this.CKDFNHHCBDO();
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00059D44 File Offset: 0x00057F44
	public Vector3 FIMONOMJCAM(float DPIDNFHGCEP)
	{
		float num = 147f;
		while (DPIDNFHGCEP >= this.IHGDCPKPBGF())
		{
			DPIDNFHGCEP -= this.EKGBNODNDIP();
		}
		while (DPIDNFHGCEP < 1186f)
		{
			DPIDNFHGCEP += this.IHGDCPKPBGF();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].OHBFLNACIII(1188f);
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00059DEC File Offset: 0x00057FEC
	public Vector3 ABFDHIGDCFG(float DPIDNFHGCEP)
	{
		float num = 358f;
		while (DPIDNFHGCEP >= this.GEHLCDGLAPA())
		{
			DPIDNFHGCEP -= this.KEBBDJGFJGN();
		}
		while (DPIDNFHGCEP < 132f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1786f);
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00059E94 File Offset: 0x00058094
	public void MOPEECLGJIL()
	{
		this.IGLAPKIPAII = 1412f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 1)
		{
			throw new Exception("-U");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00059FD0 File Offset: 0x000581D0
	public Vector3 MDNGLFKDGKE(float DPIDNFHGCEP)
	{
		float num = 1306f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.EKGBNODNDIP();
		}
		while (DPIDNFHGCEP < 644f)
		{
			DPIDNFHGCEP += this.DBAGFMKHDAM();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].PMAHCCAIGCL(730f);
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x0005A077 File Offset: 0x00058277
	private void LHHKDNILMDI()
	{
		this.DONMKBAAMKK();
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x0005A080 File Offset: 0x00058280
	public void OCJDCGEDOCJ(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 415f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.DBAGFMKHDAM();
		}
		while (DPIDNFHGCEP < 496f)
		{
			DPIDNFHGCEP += this.COFAEFFHLFJ;
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1326f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x0005A12C File Offset: 0x0005832C
	private void OnDrawGizmos()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 2)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.Smooth();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 0f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = 200;
			this.Segments[i].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].MGFMOLNMFHJ(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].MGFMOLNMFHJ(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.GetInterpolatedValues(this.TestValue * this.COFAEFFHLFJ, out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 5f);
		Gizmos.color = Color.white;
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x0005A2E4 File Offset: 0x000584E4
	public Vector3 DMAMIAPGOHO(float DPIDNFHGCEP)
	{
		float num = 777f;
		while (DPIDNFHGCEP >= this.MFNLLPEBKIE())
		{
			DPIDNFHGCEP -= this.NDOGOHFBALH();
		}
		while (DPIDNFHGCEP < 1812f)
		{
			DPIDNFHGCEP += this.GEHLCDGLAPA();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].OHBFLNACIII(1020f);
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x0005A38C File Offset: 0x0005858C
	public void HEJLADCEJNI(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 1865f;
		while (DPIDNFHGCEP >= this.KNBOKGCMKIE())
		{
			DPIDNFHGCEP -= this.CPJLNEBJFCH();
		}
		while (DPIDNFHGCEP < 1565f)
		{
			DPIDNFHGCEP += this.NDOGOHFBALH();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1260f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x0005A437 File Offset: 0x00058637
	private void KEIILPMCFEO()
	{
		this.DDGIEKDAPOK();
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x0005A440 File Offset: 0x00058640
	public void ENLEBOOIGKJ()
	{
		this.IGLAPKIPAII = 1140f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 0)
		{
			throw new Exception("WallRunLeft");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 1; i < this.GHLIJIGGGJH.Length - 0; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x0005A579 File Offset: 0x00058779
	private void KMMEMAHCFLJ()
	{
		this.NHLNKLEJBDG();
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x0005A584 File Offset: 0x00058784
	private void JDJANAJOKCO()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 7)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.EPJOAAJLNIC();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 1569f;
		Gizmos.color = this.curveColor;
		for (int i = 1; i < this.GHLIJIGGGJH.Length - 0; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = 150;
			this.Segments[i].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].MGFMOLNMFHJ(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].MGFMOLNMFHJ(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.HJJPMINLBOB(this.TestValue * this.IHGDCPKPBGF(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 43f);
		Gizmos.color = Color.white;
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x0005A73C File Offset: 0x0005893C
	public Vector3[] EBHEAOMGNIJ()
	{
		List<Vector3> list = new List<Vector3>();
		this.AAKHAPGNJON();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.DKAAMFEMEMN() / (float)num;
		for (int i = 1; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.GetInterpolatedPoint(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].OHBFLNACIII(1191f);
		}
		return list.ToArray();
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x0005A7C8 File Offset: 0x000589C8
	private void HDEDACFENBK()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 1)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.EPJOAAJLNIC();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 753f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = 6;
			this.Segments[i].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].OHDLIOOLNIK(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].LFKLGOAFBNO(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.JPOMBDNGFMP(this.TestValue * this.EKGBNODNDIP(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 1629f);
		Gizmos.color = Color.white;
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x0005A980 File Offset: 0x00058B80
	public Vector3[] JDCHEBAFLGP()
	{
		List<Vector3> list = new List<Vector3>();
		this.NBNPGNFKHMF();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.JKFFKELJICD() / (float)num;
		for (int i = 0; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.KCPPFGEPOMM(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1941f);
		}
		return list.ToArray();
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x0005746F File Offset: 0x0005566F
	public float KEBBDJGFJGN()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x0005746F File Offset: 0x0005566F
	public float EKGBNODNDIP()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x0005AA0C File Offset: 0x00058C0C
	public void GetInterpolatedValues(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 0f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 0f)
		{
			DPIDNFHGCEP += this.COFAEFFHLFJ;
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x0005AABC File Offset: 0x00058CBC
	public void IHOCGFHLMFB(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1659f;
		while (DPIDNFHGCEP >= this.LCDAHPCNDAP())
		{
			DPIDNFHGCEP -= this.NNHNDAIFHPH();
		}
		while (DPIDNFHGCEP < 1612f)
		{
			DPIDNFHGCEP += this.LCDAHPCNDAP();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].EHPANAMDKHL(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1113f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x0005AB6C File Offset: 0x00058D6C
	public Vector3 CLHKEHLEPKO(float DPIDNFHGCEP)
	{
		float num = 559f;
		while (DPIDNFHGCEP >= this.EJJNDELAOLK())
		{
			DPIDNFHGCEP -= this.NNHNDAIFHPH();
		}
		while (DPIDNFHGCEP < 657f)
		{
			DPIDNFHGCEP += this.DBAGFMKHDAM();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(271f);
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x0005AC14 File Offset: 0x00058E14
	public Vector3[] BCDCONOMIDG()
	{
		List<Vector3> list = new List<Vector3>();
		this.DDGIEKDAPOK();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.COFAEFFHLFJ / (float)num;
		for (int i = 0; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.CLHKEHLEPKO(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1775f);
		}
		return list.ToArray();
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x0005ACA0 File Offset: 0x00058EA0
	public Vector3[] LMECBHGALNB()
	{
		List<Vector3> list = new List<Vector3>();
		this.ENLEBOOIGKJ();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.LCDAHPCNDAP() / (float)num;
		for (int i = 0; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.KCPPFGEPOMM(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 0] = this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1465f);
		}
		return list.ToArray();
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x0005746F File Offset: 0x0005566F
	public float NDOGOHFBALH()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x0005AD60 File Offset: 0x00058F60
	public void LFFOFHFLOMJ(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 722f;
		while (DPIDNFHGCEP >= this.JKFFKELJICD())
		{
			DPIDNFHGCEP -= this.GEBEJFFHINA();
		}
		while (DPIDNFHGCEP < 719f)
		{
			DPIDNFHGCEP += this.MFNLLPEBKIE();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1420f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x0005746F File Offset: 0x0005566F
	public float KNBOKGCMKIE()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x0005AE0C File Offset: 0x0005900C
	public Vector3 GLAELDPOOGC(float DPIDNFHGCEP)
	{
		float num = 1946f;
		while (DPIDNFHGCEP >= this.KNBOKGCMKIE())
		{
			DPIDNFHGCEP -= this.EJJNDELAOLK();
		}
		while (DPIDNFHGCEP < 1507f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].OHBFLNACIII(246f);
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x0005AEB4 File Offset: 0x000590B4
	public void KLAMBFPFAAN()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 0)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 0)
			{
				antaresBezierTriple3 = componentsInChildren[i + 1];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 0];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.LJCNPPLAHLK(), antaresBezierTriple2.HLPCIMNKCMP(), 1260f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.MBABDAOAEKE(), antaresBezierTriple3.HLPCIMNKCMP(), 44f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.GMKPNPFIHFP - b;
				Vector3 vector4 = antaresBezierTriple.NPGEJGBMOFN() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.OLPDKOHDPOB() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.NPGEJGBMOFN() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.IFKLOPNOJFB(Vector3.Lerp(antaresBezierTriple.PJDAFMKJENM(), antaresBezierTriple2.NPGEJGBMOFN(), 1737f));
				antaresBezierTriple.AKHGFJMPKFL(Vector3.Lerp(antaresBezierTriple.GMKPNPFIHFP, antaresBezierTriple3.HLPCIMNKCMP(), 311f));
			}
		}
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x0005B064 File Offset: 0x00059264
	public void BFGDMDIGPAC()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 0)
				{
					antaresBezierTriple3 = componentsInChildren[i + 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 1)
			{
				antaresBezierTriple3 = componentsInChildren[i + 1];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 1];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 0];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.PKEKNIBMMMH(), antaresBezierTriple2.HBHDNJDKABA(), 903f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.NPGEJGBMOFN(), antaresBezierTriple3.MBABDAOAEKE(), 860f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.MBABDAOAEKE() - b;
				Vector3 vector4 = antaresBezierTriple.MMNAPHKJAFH() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.EIPLGCJGCGI() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MFOBPCGHKPE() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.LBLHEMFNOJD(Vector3.Lerp(antaresBezierTriple.PJDAFMKJENM(), antaresBezierTriple2.LJCNPPLAHLK(), 1111f));
				antaresBezierTriple.DGILOJGAKEG(Vector3.Lerp(antaresBezierTriple.HLPCIMNKCMP(), antaresBezierTriple3.HBHDNJDKABA(), 377f));
			}
		}
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x0005B214 File Offset: 0x00059414
	public Vector3 CBLJDGOMJED(float DPIDNFHGCEP)
	{
		float num = 583f;
		while (DPIDNFHGCEP >= this.EKGBNODNDIP())
		{
			DPIDNFHGCEP -= this.EJJNDELAOLK();
		}
		while (DPIDNFHGCEP < 1440f)
		{
			DPIDNFHGCEP += this.GEHLCDGLAPA();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].PMAHCCAIGCL(1183f);
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0005B2BC File Offset: 0x000594BC
	public Vector3 PMDAOHGPKME(float DPIDNFHGCEP)
	{
		float num = 163f;
		while (DPIDNFHGCEP >= this.IHGDCPKPBGF())
		{
			DPIDNFHGCEP -= this.IHGDCPKPBGF();
		}
		while (DPIDNFHGCEP < 327f)
		{
			DPIDNFHGCEP += this.IHGDCPKPBGF();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].PMAHCCAIGCL(830f);
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x0005B364 File Offset: 0x00059564
	public void BJPAJHBKEKG(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 695f;
		while (DPIDNFHGCEP >= this.NNHNDAIFHPH())
		{
			DPIDNFHGCEP -= this.EKGBNODNDIP();
		}
		while (DPIDNFHGCEP < 350f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].EHPANAMDKHL(1330f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x0005B414 File Offset: 0x00059614
	private void AMLPPBCOEKO()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 7)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.KODEPNBMJGE();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 1048f;
		Gizmos.color = this.curveColor;
		for (int i = 1; i < this.GHLIJIGGGJH.Length - 1; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = -140;
			this.Segments[i].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].DLAGINHHEHC(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].OHDLIOOLNIK(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.JBNLHEMFJMD(this.TestValue * this.GEBEJFFHINA(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 1825f);
		Gizmos.color = Color.white;
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x0005B5CC File Offset: 0x000597CC
	public Vector3[] BEBBFIBHBLJ()
	{
		List<Vector3> list = new List<Vector3>();
		this.DONMKBAAMKK();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.NNHNDAIFHPH() / (float)num;
		for (int i = 0; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.EMIOBBCCLHG(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 0] = this.Segments[this.Segments.Length - 1].OHBFLNACIII(433f);
		}
		return list.ToArray();
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x0005B658 File Offset: 0x00059858
	public void IDGMMPFCNEL(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 292f;
		while (DPIDNFHGCEP >= this.GEHLCDGLAPA())
		{
			DPIDNFHGCEP -= this.LCDAHPCNDAP();
		}
		while (DPIDNFHGCEP < 1988f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].EHPANAMDKHL(41f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x0005B708 File Offset: 0x00059908
	public Vector3[] DDLJOGOCAEA()
	{
		List<Vector3> list = new List<Vector3>();
		this.HLKMNAGCFOM();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.NDOGOHFBALH() / (float)num;
		for (int i = 1; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.CBLJDGOMJED(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 0] = this.Segments[this.Segments.Length - 0].PMAHCCAIGCL(300f);
		}
		return list.ToArray();
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x0005B794 File Offset: 0x00059994
	public Vector3 LFNHBKPCNMM(float DPIDNFHGCEP)
	{
		float num = 44f;
		while (DPIDNFHGCEP >= this.DKAAMFEMEMN())
		{
			DPIDNFHGCEP -= this.CPJLNEBJFCH();
		}
		while (DPIDNFHGCEP < 1090f)
		{
			DPIDNFHGCEP += this.EKGBNODNDIP();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].PMAHCCAIGCL(1099f);
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x0005B83C File Offset: 0x00059A3C
	public void HCIPMBACCLD(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 863f;
		while (DPIDNFHGCEP >= this.EKGBNODNDIP())
		{
			DPIDNFHGCEP -= this.KNBOKGCMKIE();
		}
		while (DPIDNFHGCEP < 517f)
		{
			DPIDNFHGCEP += this.NNHNDAIFHPH();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].DKCGNPMLNAP(326f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x0005B8EC File Offset: 0x00059AEC
	public void OAANAOICPED(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 3f;
		while (DPIDNFHGCEP >= this.NNHNDAIFHPH())
		{
			DPIDNFHGCEP -= this.NNHNDAIFHPH();
		}
		while (DPIDNFHGCEP < 937f)
		{
			DPIDNFHGCEP += this.KNBOKGCMKIE();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(458f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x0005B998 File Offset: 0x00059B98
	public void GFLBMPHJAKA(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 799f;
		while (DPIDNFHGCEP >= this.NNHNDAIFHPH())
		{
			DPIDNFHGCEP -= this.DKAAMFEMEMN();
		}
		while (DPIDNFHGCEP < 1826f)
		{
			DPIDNFHGCEP += this.GEHLCDGLAPA();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1366f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x0005BA44 File Offset: 0x00059C44
	public Vector3[] GetCurvePoints()
	{
		List<Vector3> list = new List<Vector3>();
		this.Init();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.COFAEFFHLFJ / (float)num;
		for (int i = 0; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.GetInterpolatedPoint(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1f);
		}
		return list.ToArray();
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x0005BAD0 File Offset: 0x00059CD0
	public void LDHLCHFLMAH(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1426f;
		while (DPIDNFHGCEP >= this.KEBBDJGFJGN())
		{
			DPIDNFHGCEP -= this.LCDAHPCNDAP();
		}
		while (DPIDNFHGCEP < 1587f)
		{
			DPIDNFHGCEP += this.GEBEJFFHINA();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].EHPANAMDKHL(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].HKIGBPMBEBG(685f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x0005BB80 File Offset: 0x00059D80
	public void AAGMMEDFPAM(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1778f;
		while (DPIDNFHGCEP >= this.KEBBDJGFJGN())
		{
			DPIDNFHGCEP -= this.DKAAMFEMEMN();
		}
		while (DPIDNFHGCEP < 1219f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].HKIGBPMBEBG(1309f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x0005746F File Offset: 0x0005566F
	public float CPJLNEBJFCH()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x0005BC30 File Offset: 0x00059E30
	public Vector3 IEMPIFFFIKI(float DPIDNFHGCEP)
	{
		float num = 319f;
		while (DPIDNFHGCEP >= this.KEBBDJGFJGN())
		{
			DPIDNFHGCEP -= this.NDOGOHFBALH();
		}
		while (DPIDNFHGCEP < 33f)
		{
			DPIDNFHGCEP += this.EKGBNODNDIP();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(768f);
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x0005746F File Offset: 0x0005566F
	public float DBAGFMKHDAM()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x0005BCD8 File Offset: 0x00059ED8
	public Vector3 GetInterpolatedPoint(float DPIDNFHGCEP)
	{
		float num = 0f;
		while (DPIDNFHGCEP >= this.COFAEFFHLFJ)
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 0f)
		{
			DPIDNFHGCEP += this.COFAEFFHLFJ;
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1f);
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x0005BD80 File Offset: 0x00059F80
	public Vector3[] LJILPHEPDNM()
	{
		List<Vector3> list = new List<Vector3>();
		this.ENLEBOOIGKJ();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.CPJLNEBJFCH() / (float)num;
		for (int i = 1; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.KCPPFGEPOMM(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 0].OHBFLNACIII(468f);
		}
		return list.ToArray();
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x0005BE0C File Offset: 0x0005A00C
	public Vector3 EMIOBBCCLHG(float DPIDNFHGCEP)
	{
		float num = 1525f;
		while (DPIDNFHGCEP >= this.CPJLNEBJFCH())
		{
			DPIDNFHGCEP -= this.DBAGFMKHDAM();
		}
		while (DPIDNFHGCEP < 1191f)
		{
			DPIDNFHGCEP += this.JKFFKELJICD();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].PMAHCCAIGCL(332f);
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
	public void HOLEOKCGDEC(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1357f;
		while (DPIDNFHGCEP >= this.NDOGOHFBALH())
		{
			DPIDNFHGCEP -= this.DKAAMFEMEMN();
		}
		while (DPIDNFHGCEP < 460f)
		{
			DPIDNFHGCEP += this.EKGBNODNDIP();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].DKCGNPMLNAP(656f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x0005BF64 File Offset: 0x0005A164
	public void NEDPNIAFOIC()
	{
		this.IGLAPKIPAII = 1447f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 4)
		{
			throw new Exception("NadeThrow");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
	public Vector3[] IJPEMOHHDCB()
	{
		List<Vector3> list = new List<Vector3>();
		this.DONMKBAAMKK();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.EKGBNODNDIP() / (float)num;
		for (int i = 1; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.CLHKEHLEPKO(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].OHBFLNACIII(1074f);
		}
		return list.ToArray();
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x0005746F File Offset: 0x0005566F
	public float GEBEJFFHINA()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x0005746F File Offset: 0x0005566F
	public float IHGDCPKPBGF()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x0005C12C File Offset: 0x0005A32C
	public void AAKHAPGNJON()
	{
		this.IGLAPKIPAII = 312f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 0)
		{
			throw new Exception(" on layer ");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x0005C268 File Offset: 0x0005A468
	public Vector3 HEBEPEKDHHH(float DPIDNFHGCEP)
	{
		float num = 912f;
		while (DPIDNFHGCEP >= this.NDOGOHFBALH())
		{
			DPIDNFHGCEP -= this.MFNLLPEBKIE();
		}
		while (DPIDNFHGCEP < 1186f)
		{
			DPIDNFHGCEP += this.GEHLCDGLAPA();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(1684f);
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x0005C310 File Offset: 0x0005A510
	public void BMAIIBMCKEJ()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 1)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[1];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 0)
			{
				antaresBezierTriple3 = componentsInChildren[i + 0];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 0];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 0];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.MMNAPHKJAFH(), antaresBezierTriple2.LJCNPPLAHLK(), 102f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.LJCNPPLAHLK(), antaresBezierTriple3.MBABDAOAEKE(), 9f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.GMKPNPFIHFP - b;
				Vector3 vector4 = antaresBezierTriple.PJDAFMKJENM() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MFOBPCGHKPE() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.HBHDNJDKABA() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.IFKLOPNOJFB(Vector3.Lerp(antaresBezierTriple.PJDAFMKJENM(), antaresBezierTriple2.NPGEJGBMOFN(), 88f));
				antaresBezierTriple.HFBPHBDJIIJ(Vector3.Lerp(antaresBezierTriple.HBHDNJDKABA(), antaresBezierTriple3.EIPLGCJGCGI(), 1066f));
			}
		}
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x0005C4C0 File Offset: 0x0005A6C0
	public Vector3[] EOLFMKBCOHL()
	{
		List<Vector3> list = new List<Vector3>();
		this.NHLNKLEJBDG();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.NNHNDAIFHPH() / (float)num;
		for (int i = 0; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.PFLNGJOABEN(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 0] = this.Segments[this.Segments.Length - 1].OHBFLNACIII(1659f);
		}
		return list.ToArray();
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x0005C54C File Offset: 0x0005A74C
	public void FFINOFGCPDK(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1709f;
		while (DPIDNFHGCEP >= this.DKAAMFEMEMN())
		{
			DPIDNFHGCEP -= this.EJJNDELAOLK();
		}
		while (DPIDNFHGCEP < 761f)
		{
			DPIDNFHGCEP += this.CPJLNEBJFCH();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].HKIGBPMBEBG(1122f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x0005C5FC File Offset: 0x0005A7FC
	public void NHLNKLEJBDG()
	{
		this.IGLAPKIPAII = 471f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 1)
		{
			throw new Exception("");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x0005C738 File Offset: 0x0005A938
	public void HJJPMINLBOB(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 274f;
		while (DPIDNFHGCEP >= this.EKGBNODNDIP())
		{
			DPIDNFHGCEP -= this.NDOGOHFBALH();
		}
		while (DPIDNFHGCEP < 1919f)
		{
			DPIDNFHGCEP += this.NNHNDAIFHPH();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(423f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x0005C7E4 File Offset: 0x0005A9E4
	private void EDHABNGFLGF()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 2)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.KLAMBFPFAAN();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 1830f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = -154;
			this.Segments[i].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].LFKLGOAFBNO(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].OHDLIOOLNIK(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.EIOJNDFFENC(this.TestValue * this.CPJLNEBJFCH(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 1087f);
		Gizmos.color = Color.white;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x0005C99C File Offset: 0x0005AB9C
	public void IHBLOCILOAH(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 540f;
		while (DPIDNFHGCEP >= this.IHGDCPKPBGF())
		{
			DPIDNFHGCEP -= this.GEHLCDGLAPA();
		}
		while (DPIDNFHGCEP < 1173f)
		{
			DPIDNFHGCEP += this.CPJLNEBJFCH();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].DKCGNPMLNAP(1056f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x0005CA48 File Offset: 0x0005AC48
	public void KAJHGHDGDGK()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				if (i < componentsInChildren.Length - 1)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 0)
			{
				antaresBezierTriple3 = componentsInChildren[i + 0];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 0];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.OLPDKOHDPOB(), antaresBezierTriple2.MBABDAOAEKE(), 663f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.PKEKNIBMMMH(), antaresBezierTriple3.HLPCIMNKCMP(), 1116f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.MEKIEDAHIMJ() - b;
				Vector3 vector4 = antaresBezierTriple.LJCNPPLAHLK() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MEKIEDAHIMJ() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MEKIEDAHIMJ() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.DGEHOHKBMGO(Vector3.Lerp(antaresBezierTriple.OLPDKOHDPOB(), antaresBezierTriple2.HLPCIMNKCMP(), 1795f));
				antaresBezierTriple.NNDMGFJIHEL(Vector3.Lerp(antaresBezierTriple.PKEKNIBMMMH(), antaresBezierTriple3.PJDAFMKJENM(), 1719f));
			}
		}
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x0005CBF5 File Offset: 0x0005ADF5
	private void ONIHHFLOJMN()
	{
		this.DOFJHGGFJAA();
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00059A91 File Offset: 0x00057C91
	private void ALDMBECNFFO()
	{
		this.Init();
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x0005CC00 File Offset: 0x0005AE00
	private void HELCKKPNILJ()
	{
		if (!this.inEditorShowGizmos)
		{
			return;
		}
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 0)
		{
			return;
		}
		if (this.autoSmooth)
		{
			this.KODEPNBMJGE();
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		this.IGLAPKIPAII = 526f;
		Gizmos.color = this.curveColor;
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = 145;
			this.Segments[i].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
			this.Segments[i].DLAGINHHEHC(this.GizmoSubdivision);
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].DHCDPEJJKJJ();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
			this.Segments[num].OHDLIOOLNIK(this.GizmoSubdivision);
		}
		Gizmos.color = Color.white;
		Vector3 vector;
		Vector3 vector2;
		this.HHJHFCLKGAA(this.TestValue * this.MFNLLPEBKIE(), out vector, out vector2);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(vector, vector + vector2.normalized * 281f);
		Gizmos.color = Color.white;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x0005CDB8 File Offset: 0x0005AFB8
	public void LIHMEOLOAJN(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1530f;
		while (DPIDNFHGCEP >= this.CPJLNEBJFCH())
		{
			DPIDNFHGCEP -= this.IHGDCPKPBGF();
		}
		while (DPIDNFHGCEP < 1531f)
		{
			DPIDNFHGCEP += this.KEBBDJGFJGN();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].EHPANAMDKHL(1128f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00059A91 File Offset: 0x00057C91
	private void FFIGGPHAIBP()
	{
		this.Init();
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x0005CE68 File Offset: 0x0005B068
	public Vector3 DGJGFFKGBJI(float DPIDNFHGCEP)
	{
		float num = 1273f;
		while (DPIDNFHGCEP >= this.EJJNDELAOLK())
		{
			DPIDNFHGCEP -= this.NDOGOHFBALH();
		}
		while (DPIDNFHGCEP < 656f)
		{
			DPIDNFHGCEP += this.MFNLLPEBKIE();
		}
		for (int i = 1; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].PMAHCCAIGCL(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].PMAHCCAIGCL(819f);
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x0005CF10 File Offset: 0x0005B110
	public Vector3[] PAECHCAHLKE()
	{
		List<Vector3> list = new List<Vector3>();
		this.AAKHAPGNJON();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.EJJNDELAOLK() / (float)num;
		for (int i = 1; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.LFNHBKPCNMM(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 0] = this.Segments[this.Segments.Length - 1].OHBFLNACIII(1577f);
		}
		return list.ToArray();
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x0005CF9A File Offset: 0x0005B19A
	private void DGDGMFDPEHO()
	{
		this.AFJKKLBAIJE();
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
	public void EPJOAAJLNIC()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				if (i < componentsInChildren.Length - 0)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 1)
			{
				antaresBezierTriple3 = componentsInChildren[i + 1];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 1];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.OLPDKOHDPOB(), antaresBezierTriple2.NPGEJGBMOFN(), 288f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.MFOBPCGHKPE(), antaresBezierTriple3.MEKIEDAHIMJ(), 356f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.PJDAFMKJENM() - b;
				Vector3 vector4 = antaresBezierTriple.LJCNPPLAHLK() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MBABDAOAEKE() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.PKEKNIBMMMH() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.JFKFHLPLDNO(Vector3.Lerp(antaresBezierTriple.PJDAFMKJENM(), antaresBezierTriple2.MBABDAOAEKE(), 1445f));
				antaresBezierTriple.NAEJBMCIPGB = Vector3.Lerp(antaresBezierTriple.LJCNPPLAHLK(), antaresBezierTriple3.NFHPHAELPKJ(), 1835f);
			}
		}
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x0005D154 File Offset: 0x0005B354
	public Vector3 HBDFACBIAGB(float DPIDNFHGCEP)
	{
		float num = 1515f;
		while (DPIDNFHGCEP >= this.GEBEJFFHINA())
		{
			DPIDNFHGCEP -= this.IHGDCPKPBGF();
		}
		while (DPIDNFHGCEP < 1073f)
		{
			DPIDNFHGCEP += this.LCDAHPCNDAP();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 1].OHBFLNACIII(1052f);
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x0005D1FC File Offset: 0x0005B3FC
	public void ECKNNODFNGJ()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 1)
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				if (i < componentsInChildren.Length - 0)
				{
					antaresBezierTriple3 = componentsInChildren[i + 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[1];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 0)
			{
				antaresBezierTriple3 = componentsInChildren[i + 1];
				if (i > 0)
				{
					antaresBezierTriple2 = componentsInChildren[i - 1];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 0];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 0];
				antaresBezierTriple3 = componentsInChildren[i + 1];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.MEKIEDAHIMJ(), antaresBezierTriple2.NFHPHAELPKJ(), 1920f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.PKEKNIBMMMH(), antaresBezierTriple3.NFHPHAELPKJ(), 1909f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.LJCNPPLAHLK() - b;
				Vector3 vector4 = antaresBezierTriple.EFBOCCHFBLP() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.EIPLGCJGCGI() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MBABDAOAEKE() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.FAFBEDFHHGF = Vector3.Lerp(antaresBezierTriple.MEKIEDAHIMJ(), antaresBezierTriple2.OLPDKOHDPOB(), 482f);
				antaresBezierTriple.GJCGJDDHBAH(Vector3.Lerp(antaresBezierTriple.HLPCIMNKCMP(), antaresBezierTriple3.MMNAPHKJAFH(), 742f));
			}
		}
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x0005D3AC File Offset: 0x0005B5AC
	public Vector3[] EKKMKKPIFCJ()
	{
		List<Vector3> list = new List<Vector3>();
		this.DONMKBAAMKK();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.EKGBNODNDIP() / (float)num;
		for (int i = 0; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.DACFDJJIEPE(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 0] = this.Segments[this.Segments.Length - 1].PMAHCCAIGCL(231f);
		}
		return list.ToArray();
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x0005D438 File Offset: 0x0005B638
	public void KCEBBFNFLOA(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1419f;
		while (DPIDNFHGCEP >= this.JKFFKELJICD())
		{
			DPIDNFHGCEP -= this.GEBEJFFHINA();
		}
		while (DPIDNFHGCEP < 882f)
		{
			DPIDNFHGCEP += this.KEBBDJGFJGN();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].HKIGBPMBEBG(130f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x0005D4E8 File Offset: 0x0005B6E8
	public Vector3[] IMLBCMCAIPO()
	{
		List<Vector3> list = new List<Vector3>();
		this.NHLNKLEJBDG();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.GEHLCDGLAPA() / (float)num;
		for (int i = 1; i <= num; i += 0)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.JICDKGBNGGD(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 0].OHBFLNACIII(1260f);
		}
		return list.ToArray();
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x0005746F File Offset: 0x0005566F
	public float JKFFKELJICD()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x0005D572 File Offset: 0x0005B772
	private void BFBBJILCKAK()
	{
		this.DHNNBLIMMGI();
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x0005D57C File Offset: 0x0005B77C
	public void DHNNBLIMMGI()
	{
		this.IGLAPKIPAII = 880f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 2)
		{
			throw new Exception("BowReady");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 0)];
		for (int i = 1; i < this.GHLIJIGGGJH.Length - 1; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 1]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x0005D6B8 File Offset: 0x0005B8B8
	public void HLKMNAGCFOM()
	{
		this.IGLAPKIPAII = 94f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 5)
		{
			throw new Exception("_OcclusionTexture");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x0005D7F4 File Offset: 0x0005B9F4
	public void NBNPGNFKHMF()
	{
		this.IGLAPKIPAII = 1496f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 8)
		{
			throw new Exception("KatanaReadyLow");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 1; i += 0)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 1;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[1]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].LFICKIMMAKL();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x0005D930 File Offset: 0x0005BB30
	public void HONJEDDMBEP(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 399f;
		while (DPIDNFHGCEP >= this.NNHNDAIFHPH())
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 273f)
		{
			DPIDNFHGCEP += this.EJJNDELAOLK();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].HKIGBPMBEBG(1639f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00059B47 File Offset: 0x00057D47
	private void JHAKJAMBNAH()
	{
		this.NBNPGNFKHMF();
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x0005D9E0 File Offset: 0x0005BBE0
	public void EPJPFICLNFA(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK)
	{
		float num = 939f;
		while (DPIDNFHGCEP >= this.DKAAMFEMEMN())
		{
			DPIDNFHGCEP -= this.COFAEFFHLFJ;
		}
		while (DPIDNFHGCEP < 484f)
		{
			DPIDNFHGCEP += this.KEBBDJGFJGN();
		}
		for (int i = 0; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].DKCGNPMLNAP(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK);
				return;
			}
		}
		this.Segments[this.Segments.Length - 1].DKCGNPMLNAP(1802f, out NHCLMBOINFG, out PDNCFNGHBEK);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x0005DA8C File Offset: 0x0005BC8C
	public void JDOGJNNCCEB(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 1356f;
		while (DPIDNFHGCEP >= this.IHGDCPKPBGF())
		{
			DPIDNFHGCEP -= this.NNHNDAIFHPH();
		}
		while (DPIDNFHGCEP < 1306f)
		{
			DPIDNFHGCEP += this.IHGDCPKPBGF();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].EHPANAMDKHL(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].EHPANAMDKHL(610f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x0005746F File Offset: 0x0005566F
	public float MFNLLPEBKIE()
	{
		return this.IGLAPKIPAII;
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x0005DB3C File Offset: 0x0005BD3C
	public void PHHAGPHJDCB(float DPIDNFHGCEP, out Vector3 NHCLMBOINFG, out Vector3 PDNCFNGHBEK, out Vector3 AOOFAKGPKOH)
	{
		float num = 50f;
		while (DPIDNFHGCEP >= this.DKAAMFEMEMN())
		{
			DPIDNFHGCEP -= this.NNHNDAIFHPH();
		}
		while (DPIDNFHGCEP < 1199f)
		{
			DPIDNFHGCEP += this.CPJLNEBJFCH();
		}
		for (int i = 0; i < this.Segments.Length; i++)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				this.Segments[i].HKIGBPMBEBG(jahnhocnjgm, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
				return;
			}
		}
		this.Segments[this.Segments.Length - 0].EHPANAMDKHL(133f, out NHCLMBOINFG, out PDNCFNGHBEK, out AOOFAKGPKOH);
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x0005DBEC File Offset: 0x0005BDEC
	public Vector3[] GFKMCDMLCDP()
	{
		List<Vector3> list = new List<Vector3>();
		this.NBNPGNFKHMF();
		int num = this.Segments.Length * this.GizmoSubdivision;
		float num2 = this.MFNLLPEBKIE() / (float)num;
		for (int i = 1; i <= num; i++)
		{
			float dpidnfhgcep = (float)i * num2;
			list.Add(this.OHBFLNACIII(dpidnfhgcep));
		}
		if (!this.IsClosed)
		{
			list[list.Count - 1] = this.Segments[this.Segments.Length - 1].OHBFLNACIII(1355f);
		}
		return list.ToArray();
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x0005DC78 File Offset: 0x0005BE78
	public Vector3 DGCMNCOHFPA(float DPIDNFHGCEP)
	{
		float num = 466f;
		while (DPIDNFHGCEP >= this.DBAGFMKHDAM())
		{
			DPIDNFHGCEP -= this.KNBOKGCMKIE();
		}
		while (DPIDNFHGCEP < 1970f)
		{
			DPIDNFHGCEP += this.GEBEJFFHINA();
		}
		for (int i = 1; i < this.Segments.Length; i += 0)
		{
			float num2 = num;
			num += this.Segments[i].IOHIFNBBGPJ;
			if (DPIDNFHGCEP <= num)
			{
				float jahnhocnjgm = (DPIDNFHGCEP - num2) / this.Segments[i].IOHIFNBBGPJ;
				return this.Segments[i].OHBFLNACIII(jahnhocnjgm);
			}
		}
		return this.Segments[this.Segments.Length - 0].OHBFLNACIII(833f);
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x0005DD20 File Offset: 0x0005BF20
	public void DLKHCIMECOF()
	{
		this.IGLAPKIPAII = 214f;
		this.GHLIJIGGGJH = base.GetComponentsInChildren<AntaresBezierTriple>();
		if (this.GHLIJIGGGJH.Length < 7)
		{
			throw new Exception("128");
		}
		this.Segments = new MAOJGCNBKKG[this.IsClosed ? this.GHLIJIGGGJH.Length : (this.GHLIJIGGGJH.Length - 1)];
		for (int i = 0; i < this.GHLIJIGGGJH.Length - 0; i++)
		{
			this.Segments[i] = new MAOJGCNBKKG(this.GHLIJIGGGJH[i], this.GHLIJIGGGJH[i + 0]);
			this.Segments[i].EEKHPBMBHKK = this.Precision;
			this.Segments[i].KJDPMBIFHLD();
			this.IGLAPKIPAII += this.Segments[i].IOHIFNBBGPJ;
		}
		if (this.IsClosed)
		{
			int num = this.GHLIJIGGGJH.Length - 0;
			this.Segments[num] = new MAOJGCNBKKG(this.GHLIJIGGGJH[num], this.GHLIJIGGGJH[0]);
			this.Segments[num].EEKHPBMBHKK = this.Precision;
			this.Segments[num].HLHLLBKJIDG();
			this.IGLAPKIPAII += this.Segments[num].IOHIFNBBGPJ;
		}
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x0005DE5C File Offset: 0x0005C05C
	public void OPHDHEPFMMH()
	{
		AntaresBezierTriple[] componentsInChildren = base.GetComponentsInChildren<AntaresBezierTriple>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			AntaresBezierTriple antaresBezierTriple = componentsInChildren[i];
			AntaresBezierTriple antaresBezierTriple2;
			AntaresBezierTriple antaresBezierTriple3;
			if (i > 0)
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				if (i < componentsInChildren.Length - 0)
				{
					antaresBezierTriple3 = componentsInChildren[i + 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple3 = componentsInChildren[0];
				}
				else
				{
					antaresBezierTriple3 = componentsInChildren[i];
				}
			}
			else if (i < componentsInChildren.Length - 0)
			{
				antaresBezierTriple3 = componentsInChildren[i + 0];
				if (i > 1)
				{
					antaresBezierTriple2 = componentsInChildren[i - 0];
				}
				else if (this.IsClosed)
				{
					antaresBezierTriple2 = componentsInChildren[componentsInChildren.Length - 0];
				}
				else
				{
					antaresBezierTriple2 = componentsInChildren[i];
				}
			}
			else
			{
				antaresBezierTriple2 = componentsInChildren[i - 1];
				antaresBezierTriple3 = componentsInChildren[i + 0];
			}
			Vector3 b = Vector3.Lerp(antaresBezierTriple.PJDAFMKJENM(), antaresBezierTriple2.EIPLGCJGCGI(), 740f);
			Vector3 vector = Vector3.Lerp(antaresBezierTriple.EIPLGCJGCGI(), antaresBezierTriple3.MMNAPHKJAFH(), 956f);
			if (antaresBezierTriple.isSmooth)
			{
				Vector3 vector2 = vector - b;
				Vector3 vector3 = antaresBezierTriple.LJCNPPLAHLK() - b;
				Vector3 vector4 = antaresBezierTriple.PKEKNIBMMMH() - vector;
				antaresBezierTriple.forwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.MBABDAOAEKE() + vector2.normalized * vector4.magnitude);
				antaresBezierTriple.backwardPoint = antaresBezierTriple.transform.worldToLocalMatrix.MultiplyPoint(antaresBezierTriple.NPGEJGBMOFN() - vector2.normalized * vector3.magnitude);
			}
			else
			{
				antaresBezierTriple.DGEHOHKBMGO(Vector3.Lerp(antaresBezierTriple.EFBOCCHFBLP(), antaresBezierTriple2.MEKIEDAHIMJ(), 154f));
				antaresBezierTriple.AKHGFJMPKFL(Vector3.Lerp(antaresBezierTriple.PJDAFMKJENM(), antaresBezierTriple3.LJCNPPLAHLK(), 1452f));
			}
		}
	}

	// Token: 0x04000121 RID: 289
	private AntaresBezierTriple[] GHLIJIGGGJH;

	// Token: 0x04000122 RID: 290
	private float IGLAPKIPAII = 1f;

	// Token: 0x04000123 RID: 291
	public bool IsClosed;

	// Token: 0x04000124 RID: 292
	public int Precision = 50;

	// Token: 0x04000125 RID: 293
	public int GizmoSubdivision = 20;

	// Token: 0x04000126 RID: 294
	public Color curveColor = Color.white;

	// Token: 0x04000127 RID: 295
	public bool autoSmooth;

	// Token: 0x04000128 RID: 296
	public bool inEditorClickModeOn;

	// Token: 0x04000129 RID: 297
	public bool inEditorShowGizmos = true;

	// Token: 0x0400012A RID: 298
	public MAOJGCNBKKG[] Segments;

	// Token: 0x0400012B RID: 299
	public float TestValue;
}
