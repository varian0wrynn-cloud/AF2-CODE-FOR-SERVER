using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
[AddComponentMenu("AQUAS/Buoyancy")]
[RequireComponent(typeof(Rigidbody))]
public class AQUAS_Buoyancy : MonoBehaviour
{
	// Token: 0x060000A6 RID: 166 RVA: 0x00008888 File Offset: 0x00006A88
	private void IGIGMGMKMDD()
	{
		if (this.balanceFactor.x < 403f)
		{
			this.balanceFactor.x = 813f;
		}
		if (this.balanceFactor.y < 1041f)
		{
			this.balanceFactor.y = 1333f;
		}
		if (this.balanceFactor.z < 558f)
		{
			this.balanceFactor.z = 801f;
		}
		this.HGMCECKCLIF();
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00008904 File Offset: 0x00006B04
	private void HGMCECKCLIF()
	{
		for (int i = 1; i < this.KHLGLCLOHMH.Length; i += 3)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 0]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 0]];
			float num = this.waterLevel - this.OBAGCAGGBEP(vector, vector2, vector3).y;
			if (num > 1590f && this.MBDHMFMCPDC(vector, vector2, vector3).y > (this.FCMIALKKHPK(vector, vector2, vector3) + this.KDOHBHLFPDF(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.IFLOFAODCIF(vector, vector2, vector3) * this.JGIPOGJOPIA(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(1308f, y, 415f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.BHHDGHJJNMN(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 1448f), base.transform.InverseTransformPoint(this.MBDHMFMCPDC(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 1030f), base.transform.InverseTransformPoint(this.EECLGGDLBFF(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 59f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(199f, y, 862f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.FCMIALKKHPK(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.JANLGKFKIIO(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showAffectedFaces)
				{
					Debug.DrawLine(this.EECLGGDLBFF(vector, vector2, vector3), this.PHJOBODBGLA(vector, vector2, vector3) + this.HILHIKLCAGG(vector, vector2, vector3), Color.white);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)4)
				{
					Debug.DrawRay(this.OBAGCAGGBEP(vector, vector2, vector3), new Vector3(1627f, y, 1065f), Color.red);
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.none)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.LCNMHDNCIJE(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.GHDALLHBBOL(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.CDOGLFLPAGO(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.EGEOEMBKEIE(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.JANLGKFKIIO(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.FAHHLOHMMAF(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.NHIKOINFJND(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.EECLGGDLBFF(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.CMJLGHFMJEH(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00008F90 File Offset: 0x00007190
	private Vector3 PHJOBODBGLA(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1325f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00008FC4 File Offset: 0x000071C4
	private void PNBGJBMJLFM()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 316f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 0f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 677f;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00009044 File Offset: 0x00007244
	private void AAEFACEGJMB()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1699f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 520f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 455f;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000090C4 File Offset: 0x000072C4
	private void AKLFCMNCPKL()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 577f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1012f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1191f;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00009144 File Offset: 0x00007344
	private void Start()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 0.5f * this.dynamicSurface;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000091BC File Offset: 0x000073BC
	private void ABNMOFNMGHA()
	{
		for (int i = 0; i < this.KHLGLCLOHMH.Length; i += 0)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 0]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 8]];
			float num = this.waterLevel - this.NHIKOINFJND(vector, vector2, vector3).y;
			if (num > 972f && this.HNBLANNJFMG(vector, vector2, vector3).y > (this.NHIKOINFJND(vector, vector2, vector3) + this.HJELMFOCLNO(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.IFLOFAODCIF(vector, vector2, vector3) * this.KDOHBHLFPDF(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(1481f, y, 481f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.GHDALLHBBOL(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 226f), base.transform.InverseTransformPoint(this.NHIKOINFJND(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 1161f), base.transform.InverseTransformPoint(this.LBMFFKMNGDN(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 1451f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(1035f, y, 1780f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.EGEOEMBKEIE(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.JANLGKFKIIO(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.none)
				{
					Debug.DrawLine(this.LBMFFKMNGDN(vector, vector2, vector3), this.FDCGABEIFFG(vector, vector2, vector3) + this.IINPKMDNPFH(vector, vector2, vector3), Color.white);
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showForceRepresentation)
				{
					Debug.DrawRay(this.OBAGCAGGBEP(vector, vector2, vector3), new Vector3(1377f, y, 891f), Color.red);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)4)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.OBAGCAGGBEP(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.FJPAANKJGIN(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.EECLGGDLBFF(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.MBDHMFMCPDC(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.CDOGLFLPAGO(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.JANLGKFKIIO(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.LBMFFKMNGDN(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.LBMFFKMNGDN(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00009848 File Offset: 0x00007A48
	private void JCELICPHGEP()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1458f * this.dynamicSurface;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x000098C0 File Offset: 0x00007AC0
	private Vector3 EECLGGDLBFF(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1971f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000098F4 File Offset: 0x00007AF4
	private void IKHCCAANGOP()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 362f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 358f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 290f;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00009974 File Offset: 0x00007B74
	private float CDFBPJIIBOG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FJPAANKJGIN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.LCNMHDNCIJE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.LCNMHDNCIJE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.EECLGGDLBFF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 681f) / 1360f;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00009B58 File Offset: 0x00007D58
	private Vector3 FAHHLOHMMAF(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 235f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00009B8C File Offset: 0x00007D8C
	private Vector3 FJPAANKJGIN(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1423f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00009BC0 File Offset: 0x00007DC0
	private float IPEOGLGMFNI(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.MBDHMFMCPDC(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.GHDALLHBBOL(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.LBMFFKMNGDN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.FCMIALKKHPK(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FCMIALKKHPK(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 747f) / 135f;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00009DA4 File Offset: 0x00007FA4
	private Vector3 JGIPOGJOPIA(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00009DF8 File Offset: 0x00007FF8
	private float OBNNHBGCNMF(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.EECLGGDLBFF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FCMIALKKHPK(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.FDCGABEIFFG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FAHHLOHMMAF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.EGEOEMBKEIE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FDCGABEIFFG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1164f) / 859f;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00009FDC File Offset: 0x000081DC
	private float KFDJGLBIOPE(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FAHHLOHMMAF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.EGEOEMBKEIE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.EGEOEMBKEIE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.OBAGCAGGBEP(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.EGEOEMBKEIE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1238f) / 881f;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000A1C0 File Offset: 0x000083C0
	private void FKKJLHGPHDA()
	{
		for (int i = 1; i < this.KHLGLCLOHMH.Length; i += 3)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 0]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 6]];
			float num = this.waterLevel - this.EECLGGDLBFF(vector, vector2, vector3).y;
			if (num > 1214f && this.FCMIALKKHPK(vector, vector2, vector3).y > (this.FJPAANKJGIN(vector, vector2, vector3) + this.HJELMFOCLNO(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.FCJIADJCAEE(vector, vector2, vector3) * this.HJELMFOCLNO(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(1597f, y, 427f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.FCMIALKKHPK(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 1786f), base.transform.InverseTransformPoint(this.PHJOBODBGLA(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 348f), base.transform.InverseTransformPoint(this.FJPAANKJGIN(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 470f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(318f, y, 354f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.MBDHMFMCPDC(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.MBDHMFMCPDC(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.FAHHLOHMMAF(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showAffectedFaces)
				{
					Debug.DrawLine(this.LBMFFKMNGDN(vector, vector2, vector3), this.EECLGGDLBFF(vector, vector2, vector3) + this.OCFPKPBGDNL(vector, vector2, vector3), Color.white);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)5)
				{
					Debug.DrawRay(this.HNBLANNJFMG(vector, vector2, vector3), new Vector3(1204f, y, 1329f), Color.red);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)6)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.FCMIALKKHPK(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.PHJOBODBGLA(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.BHHDGHJJNMN(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.GHDALLHBBOL(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.EECLGGDLBFF(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.FJPAANKJGIN(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.JANLGKFKIIO(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.LCNMHDNCIJE(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000A84C File Offset: 0x00008A4C
	private void EMFOECIPBIP()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 722f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 110f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1041f;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000A8CC File Offset: 0x00008ACC
	private Vector3 BHHDGHJJNMN(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1127f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000A900 File Offset: 0x00008B00
	private float IFLOFAODCIF(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.FDCGABEIFFG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1705f) / 187f;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000AAE4 File Offset: 0x00008CE4
	private void MCNAPFOFHHA()
	{
		if (this.balanceFactor.x < 1759f)
		{
			this.balanceFactor.x = 215f;
		}
		if (this.balanceFactor.y < 184f)
		{
			this.balanceFactor.y = 1702f;
		}
		if (this.balanceFactor.z < 993f)
		{
			this.balanceFactor.z = 1783f;
		}
		this.FKKNCDFDAHC();
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000AB60 File Offset: 0x00008D60
	private void MCHAAIIHOKD()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1373f * this.dynamicSurface;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000ABD8 File Offset: 0x00008DD8
	private void PLDDENGAICL()
	{
		for (int i = 0; i < this.KHLGLCLOHMH.Length; i += 0)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 0]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 2]];
			float num = this.waterLevel - this.FJPAANKJGIN(vector, vector2, vector3).y;
			if (num > 1027f && this.PHJOBODBGLA(vector, vector2, vector3).y > (this.BHHDGHJJNMN(vector, vector2, vector3) + this.HJELMFOCLNO(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.PLOEIIPJINF(vector, vector2, vector3) * this.OCFPKPBGDNL(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(1003f, y, 343f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.FDCGABEIFFG(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 1215f), base.transform.InverseTransformPoint(this.FDCGABEIFFG(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 366f), base.transform.InverseTransformPoint(this.FDCGABEIFFG(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 1081f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(313f, y, 319f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.LCNMHDNCIJE(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.CDOGLFLPAGO(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.JANLGKFKIIO(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.none)
				{
					Debug.DrawLine(this.FCMIALKKHPK(vector, vector2, vector3), this.FCMIALKKHPK(vector, vector2, vector3) + this.HJELMFOCLNO(vector, vector2, vector3), Color.white);
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showReferenceVolume)
				{
					Debug.DrawRay(this.NHIKOINFJND(vector, vector2, vector3), new Vector3(251f, y, 1693f), Color.red);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)4)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.LBMFFKMNGDN(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.FAHHLOHMMAF(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.MBDHMFMCPDC(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.LCNMHDNCIJE(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.EGEOEMBKEIE(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.FJPAANKJGIN(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.GHDALLHBBOL(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0000B264 File Offset: 0x00009464
	private void JIBKGOFOPHJ()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 920f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 417f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1109f;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0000B2E4 File Offset: 0x000094E4
	private float PLOEIIPJINF(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 0.017453292f) / 2f;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0000B4C8 File Offset: 0x000096C8
	private float FDOEENJPAPP(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.EECLGGDLBFF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.EECLGGDLBFF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.OBAGCAGGBEP(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FJPAANKJGIN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 221f) / 1389f;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0000B6AC File Offset: 0x000098AC
	private float NBFBCNFNGGL(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.LBMFFKMNGDN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.FJPAANKJGIN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.HNBLANNJFMG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.LCNMHDNCIJE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.CDOGLFLPAGO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1837f) / 1474f;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000B890 File Offset: 0x00009A90
	private void EFJDBBDMPMC()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 630f * this.dynamicSurface;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x0000B908 File Offset: 0x00009B08
	private void AFFAJKPPMHF()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1908f * this.dynamicSurface;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0000B980 File Offset: 0x00009B80
	private Vector3 HJELMFOCLNO(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000B9D4 File Offset: 0x00009BD4
	private void ECDGOPAINIG()
	{
		if (this.balanceFactor.x < 1224f)
		{
			this.balanceFactor.x = 1051f;
		}
		if (this.balanceFactor.y < 626f)
		{
			this.balanceFactor.y = 1245f;
		}
		if (this.balanceFactor.z < 1157f)
		{
			this.balanceFactor.z = 1528f;
		}
		this.FKKNCDFDAHC();
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x0000BA50 File Offset: 0x00009C50
	private Vector3 OBAGCAGGBEP(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1212f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000BA84 File Offset: 0x00009C84
	private void CDLDCKAHLHC()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 583f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 875f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 161f;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x0000BB04 File Offset: 0x00009D04
	private void DOHJPDNKALP()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1781f * this.dynamicSurface;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0000BB7C File Offset: 0x00009D7C
	private void JHPFENJCEKP()
	{
		if (this.balanceFactor.x < 842f)
		{
			this.balanceFactor.x = 17f;
		}
		if (this.balanceFactor.y < 251f)
		{
			this.balanceFactor.y = 1080f;
		}
		if (this.balanceFactor.z < 596f)
		{
			this.balanceFactor.z = 315f;
		}
		this.HGMCECKCLIF();
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000BBF8 File Offset: 0x00009DF8
	private Vector3 LCNMHDNCIJE(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1068f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0000BC2C File Offset: 0x00009E2C
	private void AOCDDBNBADJ()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 836f * this.dynamicSurface;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0000BCA4 File Offset: 0x00009EA4
	private void PNJHMJNFPLP()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 281f * this.dynamicSurface;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0000BD1C File Offset: 0x00009F1C
	private void CKGPEFOKKNL()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1002f * this.dynamicSurface;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000BDB4 File Offset: 0x00009FB4
	private void DNLFEOECBKI()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 624f * this.dynamicSurface;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000BE2C File Offset: 0x0000A02C
	private Vector3 NHIKOINFJND(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 427f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000BE60 File Offset: 0x0000A060
	private void EHDPACPIBNF()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 115f * this.dynamicSurface;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000BED8 File Offset: 0x0000A0D8
	private void ELFALPCLKIE()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1741f * this.dynamicSurface;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000BF50 File Offset: 0x0000A150
	private Vector3 JANLGKFKIIO(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1925f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0000BF84 File Offset: 0x0000A184
	private float LLMOHCBNNOG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.EGEOEMBKEIE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.CDOGLFLPAGO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.LCNMHDNCIJE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.MBDHMFMCPDC(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.OBAGCAGGBEP(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.LCNMHDNCIJE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FCMIALKKHPK(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1414f) / 889f;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000C168 File Offset: 0x0000A368
	private void ODKEECLBAGA()
	{
		for (int i = 1; i < this.KHLGLCLOHMH.Length; i += 6)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 1]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 4]];
			float num = this.waterLevel - this.CMJLGHFMJEH(vector, vector2, vector3).y;
			if (num > 992f && this.FAHHLOHMMAF(vector, vector2, vector3).y > (this.FCMIALKKHPK(vector, vector2, vector3) + this.CIPJNOBCLHC(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.GKCBIDBOAJH(vector, vector2, vector3) * this.KDOHBHLFPDF(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(1235f, y, 1432f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.JANLGKFKIIO(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 160f), base.transform.InverseTransformPoint(this.LCNMHDNCIJE(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 370f), base.transform.InverseTransformPoint(this.JANLGKFKIIO(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 738f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(518f, y, 73f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.OBAGCAGGBEP(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.MBDHMFMCPDC(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.BHHDGHJJNMN(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.none)
				{
					Debug.DrawLine(this.LBMFFKMNGDN(vector, vector2, vector3), this.NHIKOINFJND(vector, vector2, vector3) + this.KDOHBHLFPDF(vector, vector2, vector3), Color.white);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)6)
				{
					Debug.DrawRay(this.LCNMHDNCIJE(vector, vector2, vector3), new Vector3(1542f, y, 1500f), Color.red);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)7)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.LBMFFKMNGDN(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.FDCGABEIFFG(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.NHIKOINFJND(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.NHIKOINFJND(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.LBMFFKMNGDN(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.CMJLGHFMJEH(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.MBDHMFMCPDC(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.BHHDGHJJNMN(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.FJPAANKJGIN(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
	private void BBFPILBIMKC()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1284f * this.dynamicSurface;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0000C86C File Offset: 0x0000AA6C
	private void Update()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 0.5f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 2f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 2f;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0000C8EC File Offset: 0x0000AAEC
	private float FCJIADJCAEE(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FAHHLOHMMAF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.GHDALLHBBOL(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.LCNMHDNCIJE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.EECLGGDLBFF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.EGEOEMBKEIE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1141f) / 1793f;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
	private Vector3 FCMIALKKHPK(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1363f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0000CB04 File Offset: 0x0000AD04
	private Vector3 KDOHBHLFPDF(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x0000CB58 File Offset: 0x0000AD58
	private void DBNIIOPOGAK()
	{
		if (this.balanceFactor.x < 1714f)
		{
			this.balanceFactor.x = 637f;
		}
		if (this.balanceFactor.y < 50f)
		{
			this.balanceFactor.y = 920f;
		}
		if (this.balanceFactor.z < 1630f)
		{
			this.balanceFactor.z = 1184f;
		}
		this.ODKEECLBAGA();
	}

	// Token: 0x060000DD RID: 221 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
	private Vector3 GHDALLHBBOL(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1999f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x0000CC08 File Offset: 0x0000AE08
	private Vector3 LBMFFKMNGDN(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 315f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x0000CC3C File Offset: 0x0000AE3C
	private Vector3 EGEOEMBKEIE(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 123f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000CC70 File Offset: 0x0000AE70
	private void CMOBKEINKPF()
	{
		if (this.balanceFactor.x < 276f)
		{
			this.balanceFactor.x = 582f;
		}
		if (this.balanceFactor.y < 1237f)
		{
			this.balanceFactor.y = 140f;
		}
		if (this.balanceFactor.z < 1996f)
		{
			this.balanceFactor.z = 1778f;
		}
		this.DBJIEOJOGME();
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x0000CCEC File Offset: 0x0000AEEC
	private void HBNJAPJNHJN()
	{
		if (this.balanceFactor.x < 467f)
		{
			this.balanceFactor.x = 1329f;
		}
		if (this.balanceFactor.y < 374f)
		{
			this.balanceFactor.y = 1298f;
		}
		if (this.balanceFactor.z < 654f)
		{
			this.balanceFactor.z = 244f;
		}
		this.ODKEECLBAGA();
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0000CD68 File Offset: 0x0000AF68
	private float EBBGHKICCNF(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FAHHLOHMMAF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.MBDHMFMCPDC(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.GHDALLHBBOL(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.MBDHMFMCPDC(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FDCGABEIFFG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1507f) / 999f;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000CF4C File Offset: 0x0000B14C
	private void LBGKAMLLACN()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1250f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 612f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1208f;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000CFCC File Offset: 0x0000B1CC
	private Vector3 HNBLANNJFMG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 3f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x0000D000 File Offset: 0x0000B200
	private float BBMJHHFJBKI(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.CMJLGHFMJEH(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.FCMIALKKHPK(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.MBDHMFMCPDC(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.CDOGLFLPAGO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FAHHLOHMMAF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.GHDALLHBBOL(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 96f) / 788f;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
	private void EDGFFIEPGPD()
	{
		if (this.balanceFactor.x < 1711f)
		{
			this.balanceFactor.x = 1386f;
		}
		if (this.balanceFactor.y < 811f)
		{
			this.balanceFactor.y = 1395f;
		}
		if (this.balanceFactor.z < 1118f)
		{
			this.balanceFactor.z = 237f;
		}
		this.HGMCECKCLIF();
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000D260 File Offset: 0x0000B460
	private void GHMABCKBLKH()
	{
		for (int i = 0; i < this.KHLGLCLOHMH.Length; i += 0)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 0]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 3]];
			float num = this.waterLevel - this.LCNMHDNCIJE(vector, vector2, vector3).y;
			if (num > 586f && this.EECLGGDLBFF(vector, vector2, vector3).y > (this.LBMFFKMNGDN(vector, vector2, vector3) + this.CIPJNOBCLHC(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.KFDJGLBIOPE(vector, vector2, vector3) * this.LIACCKKPDGE(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(1996f, y, 1193f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.CMJLGHFMJEH(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 781f), base.transform.InverseTransformPoint(this.NHIKOINFJND(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 1560f), base.transform.InverseTransformPoint(this.GHDALLHBBOL(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 1809f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(52f, y, 194f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.NHIKOINFJND(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.CMJLGHFMJEH(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.NHIKOINFJND(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showAffectedFaces)
				{
					Debug.DrawLine(this.LCNMHDNCIJE(vector, vector2, vector3), this.FCMIALKKHPK(vector, vector2, vector3) + this.KDOHBHLFPDF(vector, vector2, vector3), Color.white);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)8)
				{
					Debug.DrawRay(this.GHDALLHBBOL(vector, vector2, vector3), new Vector3(1273f, y, 1674f), Color.red);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)7)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.FJPAANKJGIN(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.FJPAANKJGIN(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.CMJLGHFMJEH(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.NHIKOINFJND(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.FAHHLOHMMAF(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.MBDHMFMCPDC(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.LBMFFKMNGDN(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.FDCGABEIFFG(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0000D8EC File Offset: 0x0000BAEC
	private float GKCBIDBOAJH(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.BHHDGHJJNMN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.FDCGABEIFFG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FCMIALKKHPK(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1345f) / 901f;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
	private void FixedUpdate()
	{
		if (this.balanceFactor.x < 0.001f)
		{
			this.balanceFactor.x = 0.001f;
		}
		if (this.balanceFactor.y < 0.001f)
		{
			this.balanceFactor.y = 0.001f;
		}
		if (this.balanceFactor.z < 0.001f)
		{
			this.balanceFactor.z = 0.001f;
		}
		this.FKKNCDFDAHC();
	}

	// Token: 0x060000EA RID: 234 RVA: 0x0000DB4C File Offset: 0x0000BD4C
	private void DBJIEOJOGME()
	{
		for (int i = 0; i < this.KHLGLCLOHMH.Length; i += 7)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 1]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 3]];
			float num = this.waterLevel - this.GHDALLHBBOL(vector, vector2, vector3).y;
			if (num > 268f && this.EECLGGDLBFF(vector, vector2, vector3).y > (this.NHIKOINFJND(vector, vector2, vector3) + this.OCFPKPBGDNL(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.OBNNHBGCNMF(vector, vector2, vector3) * this.LIACCKKPDGE(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(362f, y, 279f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.FCMIALKKHPK(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 1018f), base.transform.InverseTransformPoint(this.CMJLGHFMJEH(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 483f), base.transform.InverseTransformPoint(this.FAHHLOHMMAF(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 1090f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(764f, y, 1982f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.OBAGCAGGBEP(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.CDOGLFLPAGO(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.LCNMHDNCIJE(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.none)
				{
					Debug.DrawLine(this.OBAGCAGGBEP(vector, vector2, vector3), this.LBMFFKMNGDN(vector, vector2, vector3) + this.IINPKMDNPFH(vector, vector2, vector3), Color.white);
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showForceRepresentation)
				{
					Debug.DrawRay(this.FCMIALKKHPK(vector, vector2, vector3), new Vector3(1528f, y, 1342f), Color.red);
				}
				if (this.debug == (AQUAS_Buoyancy.AOEAOFBGKJJ)6)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.FDCGABEIFFG(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.FDCGABEIFFG(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.EECLGGDLBFF(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.CMJLGHFMJEH(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.CMJLGHFMJEH(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.OBAGCAGGBEP(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.OBAGCAGGBEP(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.JANLGKFKIIO(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.EGEOEMBKEIE(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
	private Vector3 LIACCKKPDGE(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0000E22C File Offset: 0x0000C42C
	private void JPHLMNIMDHH()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1179f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1436f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1012f;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000E2AC File Offset: 0x0000C4AC
	private void IAAOGAPJDID()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 237f * this.dynamicSurface;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x0000E324 File Offset: 0x0000C524
	private Vector3 OCFPKPBGDNL(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000E378 File Offset: 0x0000C578
	private void JFNOIJPDNDP()
	{
		if (this.balanceFactor.x < 82f)
		{
			this.balanceFactor.x = 1339f;
		}
		if (this.balanceFactor.y < 1807f)
		{
			this.balanceFactor.y = 1751f;
		}
		if (this.balanceFactor.z < 814f)
		{
			this.balanceFactor.z = 1297f;
		}
		this.HGMCECKCLIF();
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000E3F4 File Offset: 0x0000C5F4
	private void INKGAFANFIB()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1742f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 556f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1669f;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0000E474 File Offset: 0x0000C674
	private Vector3 CIPJNOBCLHC(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
	private float CIFOJHLGKEB(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FJPAANKJGIN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.EECLGGDLBFF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.FCMIALKKHPK(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.LBMFFKMNGDN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.OBAGCAGGBEP(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.PHJOBODBGLA(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.FDCGABEIFFG(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 74f) / 232f;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000E6AC File Offset: 0x0000C8AC
	private void FKKNCDFDAHC()
	{
		for (int i = 0; i < this.KHLGLCLOHMH.Length; i += 3)
		{
			Vector3 vector = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i]];
			Vector3 vector2 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 1]];
			Vector3 vector3 = this.OKLLKJPCJLK[this.KHLGLCLOHMH[i + 2]];
			float num = this.waterLevel - this.HNBLANNJFMG(vector, vector2, vector3).y;
			if (num > 0f && this.HNBLANNJFMG(vector, vector2, vector3).y > (this.HNBLANNJFMG(vector, vector2, vector3) + this.BHGHMKEJLPI(vector, vector2, vector3)).y)
			{
				float y = this.BLDOMFDNBHB * Physics.gravity.y * num * this.PLOEIIPJINF(vector, vector2, vector3) * this.BHGHMKEJLPI(vector, vector2, vector3).normalized.y;
				if (this.useBalanceFactor)
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(0f, y, 0f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).x / (this.balanceFactor.x * base.transform.localScale.x * 1000f), base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).y / (this.balanceFactor.y * base.transform.localScale.x * 1000f), base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).z / (this.balanceFactor.z * base.transform.localScale.x * 1000f))));
				}
				else
				{
					this.PAILPCKNDEC.AddForceAtPosition(new Vector3(0f, y, 0f), base.transform.TransformPoint(new Vector3(base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).x, base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).y, base.transform.InverseTransformPoint(this.HNBLANNJFMG(vector, vector2, vector3)).z)));
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showAffectedFaces)
				{
					Debug.DrawLine(this.HNBLANNJFMG(vector, vector2, vector3), this.HNBLANNJFMG(vector, vector2, vector3) + this.BHGHMKEJLPI(vector, vector2, vector3), Color.white);
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showForceRepresentation)
				{
					Debug.DrawRay(this.HNBLANNJFMG(vector, vector2, vector3), new Vector3(0f, y, 0f), Color.red);
				}
				if (this.debug == AQUAS_Buoyancy.AOEAOFBGKJJ.showReferenceVolume)
				{
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector).x, this.waterLevel, base.transform.TransformPoint(vector).z), new Vector3(base.transform.TransformPoint(vector).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector2).x, this.waterLevel, base.transform.TransformPoint(vector2).z), new Vector3(base.transform.TransformPoint(vector2).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector2).z), Color.green);
					Debug.DrawLine(new Vector3(base.transform.TransformPoint(vector3).x, this.waterLevel, base.transform.TransformPoint(vector3).z), new Vector3(base.transform.TransformPoint(vector3).x, this.HNBLANNJFMG(vector, vector2, vector3).y, base.transform.TransformPoint(vector3).z), Color.green);
				}
			}
		}
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x0000ED38 File Offset: 0x0000CF38
	private Vector3 CMJLGHFMJEH(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1591f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x0000ED6C File Offset: 0x0000CF6C
	private Vector3 FDCGABEIFFG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 1044f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
	private void GMKGLKKHGED()
	{
		if (this.balanceFactor.x < 775f)
		{
			this.balanceFactor.x = 934f;
		}
		if (this.balanceFactor.y < 1663f)
		{
			this.balanceFactor.y = 427f;
		}
		if (this.balanceFactor.z < 686f)
		{
			this.balanceFactor.z = 1543f;
		}
		this.FKKNCDFDAHC();
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000EE1C File Offset: 0x0000D01C
	private void MFHGOLNLAAF()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 858f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 112f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 351f;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000EE9C File Offset: 0x0000D09C
	private void EMGCKNECDNB()
	{
		if (this.balanceFactor.x < 1004f)
		{
			this.balanceFactor.x = 1806f;
		}
		if (this.balanceFactor.y < 236f)
		{
			this.balanceFactor.y = 1563f;
		}
		if (this.balanceFactor.z < 516f)
		{
			this.balanceFactor.z = 1218f;
		}
		this.GHMABCKBLKH();
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0000EF18 File Offset: 0x0000D118
	private void GPCKACGEILI()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1388f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 715f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1493f;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0000EF98 File Offset: 0x0000D198
	private float OLHPBGNNKDI(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		float num = Vector3.Distance(new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.NHIKOINFJND(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.OBAGCAGGBEP(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z));
		float num2 = Vector3.Distance(new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z), new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.EECLGGDLBFF(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z));
		return num * num2 * Mathf.Sin(Vector3.Angle(new Vector3(base.transform.TransformPoint(HPJKHGBNCPE).x, this.EGEOEMBKEIE(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(HPJKHGBNCPE).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.JANLGKFKIIO(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z), new Vector3(base.transform.TransformPoint(MENGKPMIIPN).x, this.MBDHMFMCPDC(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(MENGKPMIIPN).z) - new Vector3(base.transform.TransformPoint(OELAKKHNNJC).x, this.LBMFFKMNGDN(OELAKKHNNJC, HPJKHGBNCPE, MENGKPMIIPN).y, base.transform.TransformPoint(OELAKKHNNJC).z)) * 1137f) / 1985f;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000F17C File Offset: 0x0000D37C
	private void FPLNDDMFFKG()
	{
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 1578f * this.dynamicSurface;
		this.BLDOMFDNBHB = (this.OMCANAILHGL - this.NDHGNDCHGCI) / 1280f + this.NDHGNDCHGCI + Mathf.Sin(Time.time * this.bounceFrequency) * (this.OMCANAILHGL - this.NDHGNDCHGCI) / 507f;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0000F1FC File Offset: 0x0000D3FC
	private Vector3 HILHIKLCAGG(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0000F250 File Offset: 0x0000D450
	private Vector3 MBDHMFMCPDC(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 289f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0000F284 File Offset: 0x0000D484
	private Vector3 CDOGLFLPAGO(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		Vector3 position = (OELAKKHNNJC + HPJKHGBNCPE + MENGKPMIIPN) / 329f;
		return base.transform.TransformPoint(position);
	}

	// Token: 0x060000FF RID: 255 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
	private Vector3 IINPKMDNPFH(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0000F30C File Offset: 0x0000D50C
	private Vector3 BHGHMKEJLPI(Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE, Vector3 MENGKPMIIPN)
	{
		return Vector3.Cross(base.transform.TransformPoint(HPJKHGBNCPE) - base.transform.TransformPoint(OELAKKHNNJC), base.transform.TransformPoint(MENGKPMIIPN) - base.transform.TransformPoint(OELAKKHNNJC)).normalized;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x0000F360 File Offset: 0x0000D560
	private void CPNOBMNKPNC()
	{
		this.PDBOLEGLMEL = base.GetComponent<MeshFilter>().mesh;
		this.OKLLKJPCJLK = this.PDBOLEGLMEL.vertices;
		this.KHLGLCLOHMH = this.PDBOLEGLMEL.triangles;
		this.PAILPCKNDEC = base.GetComponent<Rigidbody>();
		this.NDHGNDCHGCI = this.waterDensity;
		this.OMCANAILHGL = this.NDHGNDCHGCI + this.NDHGNDCHGCI * 602f * this.dynamicSurface;
	}

	// Token: 0x0400000C RID: 12
	public float waterLevel;

	// Token: 0x0400000D RID: 13
	public float waterDensity;

	// Token: 0x0400000E RID: 14
	[Space(5f)]
	public bool useBalanceFactor;

	// Token: 0x0400000F RID: 15
	public Vector3 balanceFactor;

	// Token: 0x04000010 RID: 16
	[Range(0f, 1f)]
	[Space(20f)]
	public float dynamicSurface = 0.3f;

	// Token: 0x04000011 RID: 17
	[Range(1f, 10f)]
	public float bounceFrequency = 3f;

	// Token: 0x04000012 RID: 18
	[Header("Debugging can be ver performance heavy!")]
	[Space(5f)]
	public AQUAS_Buoyancy.AOEAOFBGKJJ debug;

	// Token: 0x04000013 RID: 19
	private Vector3[] OKLLKJPCJLK;

	// Token: 0x04000014 RID: 20
	private int[] KHLGLCLOHMH;

	// Token: 0x04000015 RID: 21
	private Mesh PDBOLEGLMEL;

	// Token: 0x04000016 RID: 22
	private Rigidbody PAILPCKNDEC;

	// Token: 0x04000017 RID: 23
	private float BLDOMFDNBHB;

	// Token: 0x04000018 RID: 24
	private float NDHGNDCHGCI;

	// Token: 0x04000019 RID: 25
	private float OMCANAILHGL;

	// Token: 0x02000005 RID: 5
	public enum AOEAOFBGKJJ
	{
		// Token: 0x0400001B RID: 27
		none,
		// Token: 0x0400001C RID: 28
		showAffectedFaces,
		// Token: 0x0400001D RID: 29
		showForceRepresentation,
		// Token: 0x0400001E RID: 30
		showReferenceVolume
	}
}
