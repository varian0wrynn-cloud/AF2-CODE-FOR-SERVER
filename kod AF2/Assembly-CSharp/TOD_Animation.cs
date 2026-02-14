using System;
using UnityEngine;

// Token: 0x020000BA RID: 186
public class TOD_Animation : MonoBehaviour
{
	// Token: 0x060027A2 RID: 10146 RVA: 0x00116C8C File Offset: 0x00114E8C
	protected void HHGGCBLOJGB()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.BCCNKOBKDDI(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 968f);
		}
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x00116CCB File Offset: 0x00114ECB
	protected void FECFLBMPAAL()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.IOGANOENFIF(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 523f);
		}
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 NAGANMEGMFI()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x00116D14 File Offset: 0x00114F14
	protected void PFPPDNHLCCA()
	{
		Vector2 vector = new Vector2(Mathf.Cos(126f * (this.WindDegrees + 1966f)), Mathf.Sin(1542f * (this.WindDegrees + 1581f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1519f * (this.WindDegrees - 1252f)), Mathf.Sin(199f * (this.WindDegrees - 1009f)));
		Vector4 a = this.WindSpeed / 4f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.BMIJKKHHEFG(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(1999f, Time.deltaTime * this.WindSpeed / 563f, 1410f);
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x00116E04 File Offset: 0x00115004
	internal Vector4 BDPCLFLGFHF()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 667f, position.z / lossyScale.z);
		vector = Quaternion.Euler(1155f, -base.transform.rotation.eulerAngles.y, 221f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void IBPGHLGAMAJ(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x00116EB4 File Offset: 0x001150B4
	protected void HFPPENPGGAI()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1714f * (this.WindDegrees + 1965f)), Mathf.Sin(1249f * (this.WindDegrees + 666f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(357f * (this.WindDegrees - 830f)), Mathf.Sin(448f * (this.WindDegrees - 1476f)));
		Vector4 a = this.WindSpeed / 492f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.KBKINLFAKHP(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(1945f, Time.deltaTime * this.WindSpeed / 1106f, 1215f);
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060027A9 RID: 10153 RVA: 0x00116FA4 File Offset: 0x001151A4
	internal Vector4 AOKPPLJABKC
	{
		get
		{
			if (!this.WorldSpaceCloudUV)
			{
				return Vector4.zero;
			}
			Vector3 position = base.transform.position;
			Vector3 lossyScale = base.transform.lossyScale;
			Vector3 vector = new Vector3(position.x / lossyScale.x, 0f, position.z / lossyScale.z);
			vector = Quaternion.Euler(0f, -base.transform.rotation.eulerAngles.y, 0f) * vector;
			return new Vector4(vector.x, vector.z, vector.x, vector.z);
		}
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void HDBBEKIOPEN(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x0011704C File Offset: 0x0011524C
	internal Vector4 MDGDNHFMAME()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 971f, position.z / lossyScale.z);
		vector = Quaternion.Euler(1493f, -base.transform.rotation.eulerAngles.y, 935f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x001170F1 File Offset: 0x001152F1
	protected void BMNJGPIPKLL()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.AEAPKBCLDCD(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 1501f);
		}
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void LEALHLAOJGM(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x00117130 File Offset: 0x00115330
	protected void IOGAKGCADBL()
	{
		Vector2 vector = new Vector2(Mathf.Cos(548f * (this.WindDegrees + 1222f)), Mathf.Sin(507f * (this.WindDegrees + 961f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(905f * (this.WindDegrees - 1433f)), Mathf.Sin(408f * (this.WindDegrees - 979f)));
		Vector4 a = this.WindSpeed / 112f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.LFLFDOJMPJH(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(1486f, Time.deltaTime * this.WindSpeed / 1884f, 438f);
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 PCKGDJPAKBF()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 BBKPJJKELBP()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00116D0A File Offset: 0x00114F0A
	// (set) Token: 0x0600280A RID: 10250 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal Vector4 AAHOIGIDEOI { get; set; }

	// Token: 0x060027B2 RID: 10162 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 HEPAFNPCEAM()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void FNDECHBJAEM(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void FMIMIPIOIPG(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x00117220 File Offset: 0x00115420
	private void BMIJKKHHEFG(Vector4 PCLAMFIICMF)
	{
		this.AAHOIGIDEOI += PCLAMFIICMF;
		this.AAHOIGIDEOI = new Vector4(this.AAHOIGIDEOI.x % this.HGOMCJOPDML.Clouds.Scale1.x, this.AAHOIGIDEOI.y % this.HGOMCJOPDML.Clouds.Scale1.y, this.AAHOIGIDEOI.z % this.HGOMCJOPDML.Clouds.Scale2.x, this.AAHOIGIDEOI.w % this.HGOMCJOPDML.Clouds.Scale2.y);
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x001172D0 File Offset: 0x001154D0
	private void IOGANOENFIF(Vector4 PCLAMFIICMF)
	{
		this.LHCLOKPFFJH(this.HEPAFNPCEAM() + PCLAMFIICMF);
		this.LPAADKBPHGJ(new Vector4(this.PPOKPAHDMBP().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.AAHOIGIDEOI.y % this.HGOMCJOPDML.Clouds.Scale1.y, this.AFDJIHBLCMK().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.PCKGDJPAKBF().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 GAAJOIMBFLM()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x00117380 File Offset: 0x00115580
	private void MPCFHCJFPFL(Vector4 PCLAMFIICMF)
	{
		this.JFHNPIIOKEJ(this.ECOKNDCNGLN() + PCLAMFIICMF);
		this.FNDECHBJAEM(new Vector4(this.IJFBLJHEFLG().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.OIKEJGMFADN().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.DFOMPGBGIAI().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.HEPAFNPCEAM().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x0011742E File Offset: 0x0011562E
	protected void IIKDDILLGLF()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.NOAAACBAPHJ(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 72f);
		}
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x00117470 File Offset: 0x00115670
	private void KBKINLFAKHP(Vector4 PCLAMFIICMF)
	{
		this.IKBAIEEKIJN(this.PKCNOIKJOBB() + PCLAMFIICMF);
		this.ALJCDCFEBKN(new Vector4(this.DHADDEFIIHJ().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.DHADDEFIIHJ().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.AAAOFJCNKJA().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.KJPPEKCECDG().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x00117520 File Offset: 0x00115720
	protected void ECPECFPNLKP()
	{
		Vector2 vector = new Vector2(Mathf.Cos(912f * (this.WindDegrees + 447f)), Mathf.Sin(246f * (this.WindDegrees + 642f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(831f * (this.WindDegrees - 200f)), Mathf.Sin(1427f * (this.WindDegrees - 78f)));
		Vector4 a = this.WindSpeed / 1479f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.KBKINLFAKHP(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(1966f, Time.deltaTime * this.WindSpeed / 889f, 1127f);
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x00117610 File Offset: 0x00115810
	protected void BNKJNBIDPME()
	{
		Vector2 vector = new Vector2(Mathf.Cos(317f * (this.WindDegrees + 118f)), Mathf.Sin(1526f * (this.WindDegrees + 508f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(975f * (this.WindDegrees - 1473f)), Mathf.Sin(1361f * (this.WindDegrees - 1472f)));
		Vector4 a = this.WindSpeed / 1385f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.AEAPKBCLDCD(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(46f, Time.deltaTime * this.WindSpeed / 1209f, 1062f);
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x00117700 File Offset: 0x00115900
	protected void JIKGIJEHGAP()
	{
		Vector2 vector = new Vector2(Mathf.Cos(428f * (this.WindDegrees + 1388f)), Mathf.Sin(1529f * (this.WindDegrees + 159f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(466f * (this.WindDegrees - 1828f)), Mathf.Sin(500f * (this.WindDegrees - 595f)));
		Vector4 a = this.WindSpeed / 1603f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.KBKINLFAKHP(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(1944f, Time.deltaTime * this.WindSpeed / 114f, 444f);
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x001177ED File Offset: 0x001159ED
	protected void JPHBPEAMNHB()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.AEAPKBCLDCD(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 1351f);
		}
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 DHADDEFIIHJ()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x0011782C File Offset: 0x00115A2C
	internal Vector4 MKEHODDKGFO()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 4f, position.z / lossyScale.z);
		vector = Quaternion.Euler(621f, -base.transform.rotation.eulerAngles.y, 466f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 FJJBHMINDOH()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void CHNELCFOHLM(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x001178D4 File Offset: 0x00115AD4
	protected void JIFOELPAEHG()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1125f * (this.WindDegrees + 929f)), Mathf.Sin(1918f * (this.WindDegrees + 479f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1231f * (this.WindDegrees - 954f)), Mathf.Sin(1276f * (this.WindDegrees - 187f)));
		Vector4 a = this.WindSpeed / 422f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.GBHKPMHABDJ(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(803f, Time.deltaTime * this.WindSpeed / 1378f, 234f);
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void GBOGGEDNEFN(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x001179C4 File Offset: 0x00115BC4
	private void JCABMHFIGDH(Vector4 PCLAMFIICMF)
	{
		this.IKBAIEEKIJN(this.PKCNOIKJOBB() + PCLAMFIICMF);
		this.LPAADKBPHGJ(new Vector4(this.IPABPHLCMLI().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.AGBBCJEIFFJ().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.DHADDEFIIHJ().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.MHADIGOLCAI().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x00117A74 File Offset: 0x00115C74
	internal Vector4 NEEIGGPGLED()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 1680f, position.z / lossyScale.z);
		vector = Quaternion.Euler(1085f, -base.transform.rotation.eulerAngles.y, 1646f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x00117B1C File Offset: 0x00115D1C
	internal Vector4 MEFLPDMHNBN()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 26f, position.z / lossyScale.z);
		vector = Quaternion.Euler(1416f, -base.transform.rotation.eulerAngles.y, 1526f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x00117BC4 File Offset: 0x00115DC4
	private void EIEFJPGEJDA(Vector4 PCLAMFIICMF)
	{
		this.LPAADKBPHGJ(this.PKCNOIKJOBB() + PCLAMFIICMF);
		this.FNDECHBJAEM(new Vector4(this.PPOKPAHDMBP().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.POLBBEDNGMF().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.AFDJIHBLCMK().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.AGBBCJEIFFJ().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 KJPPEKCECDG()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x00117C74 File Offset: 0x00115E74
	private void OPBJEBDKNCG(Vector4 PCLAMFIICMF)
	{
		this.ALJCDCFEBKN(this.AGBBCJEIFFJ() + PCLAMFIICMF);
		this.CHNELCFOHLM(new Vector4(this.IPABPHLCMLI().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.IJFBLJHEFLG().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.KJPPEKCECDG().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.AGBBCJEIFFJ().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 IPABPHLCMLI()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x00117D24 File Offset: 0x00115F24
	private void ODPNJNKHFCH(Vector4 PCLAMFIICMF)
	{
		this.JFHNPIIOKEJ(this.PMMAEJCPCMB() + PCLAMFIICMF);
		this.LPAADKBPHGJ(new Vector4(this.DFOMPGBGIAI().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.POLBBEDNGMF().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.DFOMPGBGIAI().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.DHADDEFIIHJ().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void JEHADPHBCDF(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x00117DD2 File Offset: 0x00115FD2
	protected void LBEFOABPMFG()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.BMIJKKHHEFG(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 598f);
		}
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void CFONLCLADJI(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x00117E14 File Offset: 0x00116014
	protected void LBGKAMLLACN()
	{
		Vector2 vector = new Vector2(Mathf.Cos(61f * (this.WindDegrees + 1867f)), Mathf.Sin(1578f * (this.WindDegrees + 744f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1035f * (this.WindDegrees - 619f)), Mathf.Sin(613f * (this.WindDegrees - 1819f)));
		Vector4 a = this.WindSpeed / 1791f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.ODPNJNKHFCH(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(29f, Time.deltaTime * this.WindSpeed / 1892f, 513f);
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x00117F04 File Offset: 0x00116104
	internal Vector4 LFKNGLHKELG()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 931f, position.z / lossyScale.z);
		vector = Quaternion.Euler(72f, -base.transform.rotation.eulerAngles.y, 1888f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x00117FAC File Offset: 0x001161AC
	protected void DEGCCLNOEKJ()
	{
		Vector2 vector = new Vector2(Mathf.Cos(276f * (this.WindDegrees + 1476f)), Mathf.Sin(177f * (this.WindDegrees + 1136f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1243f * (this.WindDegrees - 48f)), Mathf.Sin(230f * (this.WindDegrees - 1549f)));
		Vector4 a = this.WindSpeed / 1072f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.BMIJKKHHEFG(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(802f, Time.deltaTime * this.WindSpeed / 695f, 1398f);
	}

	// Token: 0x060027D3 RID: 10195 RVA: 0x0011809C File Offset: 0x0011629C
	protected void Update()
	{
		Vector2 vector = new Vector2(Mathf.Cos(0.017453292f * (this.WindDegrees + 15f)), Mathf.Sin(0.017453292f * (this.WindDegrees + 15f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(0.017453292f * (this.WindDegrees - 15f)), Mathf.Sin(0.017453292f * (this.WindDegrees - 15f)));
		Vector4 a = this.WindSpeed / 100f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.BMIJKKHHEFG(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(0f, Time.deltaTime * this.WindSpeed / 10f, 0f);
	}

	// Token: 0x060027D4 RID: 10196 RVA: 0x0011818C File Offset: 0x0011638C
	private void AEAPKBCLDCD(Vector4 PCLAMFIICMF)
	{
		this.IBPGHLGAMAJ(this.IJFBLJHEFLG() + PCLAMFIICMF);
		this.AAHOIGIDEOI = new Vector4(this.DFOMPGBGIAI().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.GAAJOIMBFLM().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.DHADDEFIIHJ().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.KJPPEKCECDG().w % this.HGOMCJOPDML.Clouds.Scale2.y);
	}

	// Token: 0x060027D5 RID: 10197 RVA: 0x0011823C File Offset: 0x0011643C
	protected void JIBKGOFOPHJ()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1688f * (this.WindDegrees + 23f)), Mathf.Sin(1658f * (this.WindDegrees + 1469f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1543f * (this.WindDegrees - 878f)), Mathf.Sin(1006f * (this.WindDegrees - 495f)));
		Vector4 a = this.WindSpeed / 791f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.JKFOKFDNNHP(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(1654f, Time.deltaTime * this.WindSpeed / 1710f, 1079f);
	}

	// Token: 0x060027D6 RID: 10198 RVA: 0x0011832C File Offset: 0x0011652C
	private void MGABFGMILLA(Vector4 PCLAMFIICMF)
	{
		this.FMIMIPIOIPG(this.IPABPHLCMLI() + PCLAMFIICMF);
		this.CFONLCLADJI(new Vector4(this.PMMAEJCPCMB().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.BBKPJJKELBP().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.IJFBLJHEFLG().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.KJPPEKCECDG().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027D7 RID: 10199 RVA: 0x001183DA File Offset: 0x001165DA
	protected void Start()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.BMIJKKHHEFG(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 1000f);
		}
	}

	// Token: 0x060027D8 RID: 10200 RVA: 0x0011841C File Offset: 0x0011661C
	internal Vector4 PJBFJPBOOOH()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 1153f, position.z / lossyScale.z);
		vector = Quaternion.Euler(1244f, -base.transform.rotation.eulerAngles.y, 1886f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027D9 RID: 10201 RVA: 0x001184C4 File Offset: 0x001166C4
	internal Vector4 JNBFGOBJCMC()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 21f, position.z / lossyScale.z);
		vector = Quaternion.Euler(1783f, -base.transform.rotation.eulerAngles.y, 1911f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027DA RID: 10202 RVA: 0x0011856C File Offset: 0x0011676C
	protected void JPHLMNIMDHH()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1437f * (this.WindDegrees + 547f)), Mathf.Sin(1008f * (this.WindDegrees + 718f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(88f * (this.WindDegrees - 1757f)), Mathf.Sin(251f * (this.WindDegrees - 1061f)));
		Vector4 a = this.WindSpeed / 851f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.MGABFGMILLA(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(227f, Time.deltaTime * this.WindSpeed / 841f, 733f);
	}

	// Token: 0x060027DB RID: 10203 RVA: 0x0011865C File Offset: 0x0011685C
	private void CFLHJPMNKJN(Vector4 PCLAMFIICMF)
	{
		this.CFONLCLADJI(this.KDDJDJKMALG() + PCLAMFIICMF);
		this.JFHNPIIOKEJ(new Vector4(this.GAAJOIMBFLM().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.GAAJOIMBFLM().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.PMMAEJCPCMB().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.FJJBHMINDOH().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void JFHNPIIOKEJ(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x0011870C File Offset: 0x0011690C
	internal Vector4 MECMKHDCHPO()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 628f, position.z / lossyScale.z);
		vector = Quaternion.Euler(367f, -base.transform.rotation.eulerAngles.y, 201f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 PKCNOIKJOBB()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027DF RID: 10207 RVA: 0x001187B4 File Offset: 0x001169B4
	private void FGFBMJPMPGN(Vector4 PCLAMFIICMF)
	{
		this.JFHNPIIOKEJ(this.HEPAFNPCEAM() + PCLAMFIICMF);
		this.LPAADKBPHGJ(new Vector4(this.AFDJIHBLCMK().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.POLBBEDNGMF().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.IPABPHLCMLI().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.AFDJIHBLCMK().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027E0 RID: 10208 RVA: 0x00118864 File Offset: 0x00116A64
	private void JKFOKFDNNHP(Vector4 PCLAMFIICMF)
	{
		this.FMIMIPIOIPG(this.PCKGDJPAKBF() + PCLAMFIICMF);
		this.GBOGGEDNEFN(new Vector4(this.IPABPHLCMLI().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.MHADIGOLCAI().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.DFOMPGBGIAI().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.DFOMPGBGIAI().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027E1 RID: 10209 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 AGBBCJEIFFJ()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027E2 RID: 10210 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 IJFBLJHEFLG()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027E3 RID: 10211 RVA: 0x00118914 File Offset: 0x00116B14
	internal Vector4 FLGNCGALJPI()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 790f, position.z / lossyScale.z);
		vector = Quaternion.Euler(983f, -base.transform.rotation.eulerAngles.y, 1232f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x001189BC File Offset: 0x00116BBC
	internal Vector4 MIFMCFABMLO()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 1071f, position.z / lossyScale.z);
		vector = Quaternion.Euler(1236f, -base.transform.rotation.eulerAngles.y, 1696f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 DFOMPGBGIAI()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027E6 RID: 10214 RVA: 0x00118A64 File Offset: 0x00116C64
	internal Vector4 KMFHELFPHBM()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 1367f, position.z / lossyScale.z);
		vector = Quaternion.Euler(155f, -base.transform.rotation.eulerAngles.y, 482f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027E7 RID: 10215 RVA: 0x00118B0C File Offset: 0x00116D0C
	internal Vector4 EFAHFJCKIBE()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 1085f, position.z / lossyScale.z);
		vector = Quaternion.Euler(29f, -base.transform.rotation.eulerAngles.y, 257f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027E8 RID: 10216 RVA: 0x00118BB4 File Offset: 0x00116DB4
	private void BCCNKOBKDDI(Vector4 PCLAMFIICMF)
	{
		this.HDBBEKIOPEN(this.AAHOIGIDEOI + PCLAMFIICMF);
		this.OAACOMOIHOD(new Vector4(this.AAHOIGIDEOI.x % this.HGOMCJOPDML.Clouds.Scale1.x, this.ECOKNDCNGLN().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.OIKEJGMFADN().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.PCKGDJPAKBF().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027E9 RID: 10217 RVA: 0x00118C62 File Offset: 0x00116E62
	protected void IIHNDJOIMAH()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.PHFNIIMEDCA(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 700f);
		}
	}

	// Token: 0x060027EA RID: 10218 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 ECOKNDCNGLN()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027EB RID: 10219 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 AFDJIHBLCMK()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void IKBAIEEKIJN(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027ED RID: 10221 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 KDDJDJKMALG()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027EE RID: 10222 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 AAAOFJCNKJA()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x00118CA4 File Offset: 0x00116EA4
	private void NOAAACBAPHJ(Vector4 PCLAMFIICMF)
	{
		this.CHNELCFOHLM(this.DHADDEFIIHJ() + PCLAMFIICMF);
		this.IBPGHLGAMAJ(new Vector4(this.PKCNOIKJOBB().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.AFDJIHBLCMK().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.PKCNOIKJOBB().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.KDDJDJKMALG().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027F0 RID: 10224 RVA: 0x00118D52 File Offset: 0x00116F52
	protected void JLKBMEBFHBI()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.IOGANOENFIF(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 1909f);
		}
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x00118D91 File Offset: 0x00116F91
	protected void ELFALPCLKIE()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.MPCFHCJFPFL(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 653f);
		}
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x00118DD0 File Offset: 0x00116FD0
	private void BFEKAFLOJDF(Vector4 PCLAMFIICMF)
	{
		this.HDBBEKIOPEN(this.GAAJOIMBFLM() + PCLAMFIICMF);
		this.OAACOMOIHOD(new Vector4(this.AGBBCJEIFFJ().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.HEPAFNPCEAM().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.AGBBCJEIFFJ().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.POLBBEDNGMF().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void LPAADKBPHGJ(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x00118E80 File Offset: 0x00117080
	private void NDHOBJAJPCL(Vector4 PCLAMFIICMF)
	{
		this.LEALHLAOJGM(this.DHADDEFIIHJ() + PCLAMFIICMF);
		this.GBOGGEDNEFN(new Vector4(this.GAAJOIMBFLM().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.BBKPJJKELBP().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.GAAJOIMBFLM().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.ECOKNDCNGLN().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x00118F2E File Offset: 0x0011712E
	protected void MMACLBBMDLA()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.RandomInitialCloudUV)
		{
			this.JKFOKFDNNHP(new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value) * 992f);
		}
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x00118F70 File Offset: 0x00117170
	internal Vector4 MLMBIIFDPDH()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 1706f, position.z / lossyScale.z);
		vector = Quaternion.Euler(287f, -base.transform.rotation.eulerAngles.y, 1132f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x060027F7 RID: 10231 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 PPOKPAHDMBP()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void ALJCDCFEBKN(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x00119018 File Offset: 0x00117218
	protected void KMLNBHIIGKH()
	{
		Vector2 vector = new Vector2(Mathf.Cos(446f * (this.WindDegrees + 552f)), Mathf.Sin(1007f * (this.WindDegrees + 1282f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1498f * (this.WindDegrees - 912f)), Mathf.Sin(688f * (this.WindDegrees - 1184f)));
		Vector4 a = this.WindSpeed / 1443f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.NOAAACBAPHJ(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(1468f, Time.deltaTime * this.WindSpeed / 959f, 706f);
	}

	// Token: 0x060027FA RID: 10234 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void LHCLOKPFFJH(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x00119108 File Offset: 0x00117308
	protected void BOAJJAKEMLH()
	{
		Vector2 vector = new Vector2(Mathf.Cos(717f * (this.WindDegrees + 124f)), Mathf.Sin(730f * (this.WindDegrees + 1535f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1342f * (this.WindDegrees - 458f)), Mathf.Sin(435f * (this.WindDegrees - 1522f)));
		Vector4 a = this.WindSpeed / 834f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.JCABMHFIGDH(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(1649f, Time.deltaTime * this.WindSpeed / 96f, 750f);
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 PMMAEJCPCMB()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x060027FD RID: 10237 RVA: 0x001191F8 File Offset: 0x001173F8
	private void LFLFDOJMPJH(Vector4 PCLAMFIICMF)
	{
		this.AAHOIGIDEOI = this.DFOMPGBGIAI() + PCLAMFIICMF;
		this.ALJCDCFEBKN(new Vector4(this.POLBBEDNGMF().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.ECOKNDCNGLN().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.KDDJDJKMALG().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.MHADIGOLCAI().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x060027FE RID: 10238 RVA: 0x001192A8 File Offset: 0x001174A8
	protected void AKLFCMNCPKL()
	{
		Vector2 vector = new Vector2(Mathf.Cos(316f * (this.WindDegrees + 531f)), Mathf.Sin(856f * (this.WindDegrees + 1568f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(730f * (this.WindDegrees - 1178f)), Mathf.Sin(1664f * (this.WindDegrees - 1671f)));
		Vector4 a = this.WindSpeed / 1945f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.OPBJEBDKNCG(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(1958f, Time.deltaTime * this.WindSpeed / 1644f, 386f);
	}

	// Token: 0x060027FF RID: 10239 RVA: 0x00119398 File Offset: 0x00117598
	private void PHFNIIMEDCA(Vector4 PCLAMFIICMF)
	{
		this.FMIMIPIOIPG(this.AGBBCJEIFFJ() + PCLAMFIICMF);
		this.OAACOMOIHOD(new Vector4(this.PCKGDJPAKBF().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.BBKPJJKELBP().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.AAAOFJCNKJA().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.PMMAEJCPCMB().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x06002800 RID: 10240 RVA: 0x00119448 File Offset: 0x00117648
	private void OLEHAEOCNII(Vector4 PCLAMFIICMF)
	{
		this.ALJCDCFEBKN(this.FJJBHMINDOH() + PCLAMFIICMF);
		this.JEHADPHBCDF(new Vector4(this.AAHOIGIDEOI.x % this.HGOMCJOPDML.Clouds.Scale1.x, this.KJPPEKCECDG().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.KDDJDJKMALG().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.KDDJDJKMALG().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x06002802 RID: 10242 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 POLBBEDNGMF()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x06002803 RID: 10243 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 MHADIGOLCAI()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x06002804 RID: 10244 RVA: 0x00119518 File Offset: 0x00117718
	protected void GDPMOMHBIFN()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1232f * (this.WindDegrees + 489f)), Mathf.Sin(1503f * (this.WindDegrees + 1739f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1845f * (this.WindDegrees - 1822f)), Mathf.Sin(1900f * (this.WindDegrees - 828f)));
		Vector4 a = this.WindSpeed / 1310f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.FGFBMJPMPGN(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(1016f, Time.deltaTime * this.WindSpeed / 342f, 912f);
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x00119608 File Offset: 0x00117808
	internal Vector4 HLMOELCMCIM()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 1980f, position.z / lossyScale.z);
		vector = Quaternion.Euler(520f, -base.transform.rotation.eulerAngles.y, 1493f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x06002806 RID: 10246 RVA: 0x001196B0 File Offset: 0x001178B0
	protected void BEDAJLJFAFO()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1409f * (this.WindDegrees + 772f)), Mathf.Sin(1848f * (this.WindDegrees + 456f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(573f * (this.WindDegrees - 759f)), Mathf.Sin(105f * (this.WindDegrees - 1178f)));
		Vector4 a = this.WindSpeed / 237f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.MGABFGMILLA(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(588f, Time.deltaTime * this.WindSpeed / 1602f, 819f);
	}

	// Token: 0x06002807 RID: 10247 RVA: 0x001197A0 File Offset: 0x001179A0
	protected void CDLDCKAHLHC()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1860f * (this.WindDegrees + 1699f)), Mathf.Sin(1046f * (this.WindDegrees + 1761f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1175f * (this.WindDegrees - 482f)), Mathf.Sin(1365f * (this.WindDegrees - 1471f)));
		Vector4 a = this.WindSpeed / 1949f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.EIEFJPGEJDA(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(1456f, Time.deltaTime * this.WindSpeed / 363f, 1499f);
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x00119890 File Offset: 0x00117A90
	protected void JMNNAPNJDNK()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1702f * (this.WindDegrees + 1893f)), Mathf.Sin(1068f * (this.WindDegrees + 394f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1417f * (this.WindDegrees - 1366f)), Mathf.Sin(1355f * (this.WindDegrees - 511f)));
		Vector4 a = this.WindSpeed / 1625f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.NOAAACBAPHJ(Time.deltaTime * a);
		this.HGOMCJOPDML.KMBOELAHKHL().Billboards.transform.Rotate(783f, Time.deltaTime * this.WindSpeed / 37f, 1139f);
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x00119980 File Offset: 0x00117B80
	private void HDOHHNBELGO(Vector4 PCLAMFIICMF)
	{
		this.FNDECHBJAEM(this.NAGANMEGMFI() + PCLAMFIICMF);
		this.HDBBEKIOPEN(new Vector4(this.PPOKPAHDMBP().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.PPOKPAHDMBP().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.KJPPEKCECDG().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.MHADIGOLCAI().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x00116D0A File Offset: 0x00114F0A
	internal Vector4 OIKEJGMFADN()
	{
		return this.<AEBFMHNJFFA>k__BackingField;
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x00119A30 File Offset: 0x00117C30
	internal Vector4 HECODBGOEIL()
	{
		if (!this.WorldSpaceCloudUV)
		{
			return Vector4.zero;
		}
		Vector3 position = base.transform.position;
		Vector3 lossyScale = base.transform.lossyScale;
		Vector3 vector = new Vector3(position.x / lossyScale.x, 334f, position.z / lossyScale.z);
		vector = Quaternion.Euler(60f, -base.transform.rotation.eulerAngles.y, 1627f) * vector;
		return new Vector4(vector.x, vector.z, vector.x, vector.z);
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x00116EA9 File Offset: 0x001150A9
	internal void OAACOMOIHOD(Vector4 DCCPCBLODIG)
	{
		this.<AEBFMHNJFFA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x00119AD8 File Offset: 0x00117CD8
	private void GBHKPMHABDJ(Vector4 PCLAMFIICMF)
	{
		this.LPAADKBPHGJ(this.AAHOIGIDEOI + PCLAMFIICMF);
		this.HDBBEKIOPEN(new Vector4(this.MHADIGOLCAI().x % this.HGOMCJOPDML.Clouds.Scale1.x, this.PKCNOIKJOBB().y % this.HGOMCJOPDML.Clouds.Scale1.y, this.MHADIGOLCAI().z % this.HGOMCJOPDML.Clouds.Scale2.x, this.NAGANMEGMFI().w % this.HGOMCJOPDML.Clouds.Scale2.y));
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x00119B88 File Offset: 0x00117D88
	protected void DAFJMNMFOON()
	{
		Vector2 vector = new Vector2(Mathf.Cos(1949f * (this.WindDegrees + 496f)), Mathf.Sin(1054f * (this.WindDegrees + 72f)));
		Vector2 vector2 = new Vector2(Mathf.Cos(1197f * (this.WindDegrees - 482f)), Mathf.Sin(996f * (this.WindDegrees - 1975f)));
		Vector4 a = this.WindSpeed / 473f * new Vector4(vector.x, vector.y, vector2.x, vector2.y);
		this.CFLHJPMNKJN(Time.deltaTime * a);
		this.HGOMCJOPDML.NINFILJKEFA.Billboards.transform.Rotate(1369f, Time.deltaTime * this.WindSpeed / 978f, 601f);
	}

	// Token: 0x04000480 RID: 1152
	[Tooltip("Wind direction in degrees.")]
	public float WindDegrees;

	// Token: 0x04000481 RID: 1153
	[Tooltip("Speed of the wind that is acting on the clouds.")]
	public float WindSpeed = 1f;

	// Token: 0x04000482 RID: 1154
	[Tooltip("Adjust the cloud coordinates when the sky dome moves.")]
	public bool WorldSpaceCloudUV = true;

	// Token: 0x04000483 RID: 1155
	[Tooltip("Randomize the cloud coordinates at startup.")]
	public bool RandomInitialCloudUV = true;

	// Token: 0x04000485 RID: 1157
	private TOD_Sky HGOMCJOPDML;
}
