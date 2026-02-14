using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000196 RID: 406
public class ItemBase : Dropdown.OptionData
{
	// Token: 0x06005A76 RID: 23158 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void KHLEDAHPPBM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A77 RID: 23159 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int PPJDDEJPOBL(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005A78 RID: 23160 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void PLBKGJMPJEM()
	{
	}

	// Token: 0x06005A79 RID: 23161 RVA: 0x002AC8CC File Offset: 0x002AAACC
	public virtual void PKJNOAKJGOD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 870f;
		if (this.PBHPIGPDCJA() != null)
		{
			Texture texture = this.HHOBCJNGCEL().EIMNFFAAHLI();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 476f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.StretchToFill);
			num = num + num3 + 1517f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1178f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1046f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005A7A RID: 23162 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void KGLHEEOHIEO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A7B RID: 23163 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int JMPAIFNGBLM(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005A7C RID: 23164 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void CEMKNAMBMGE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A7D RID: 23165 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH BHPAALLBMHL()
	{
		return this.ibimage;
	}

	// Token: 0x06005A7E RID: 23166 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void FMGOHKJEOLD(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A7F RID: 23167 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH MFKHIBOFIFI()
	{
		return this.ibimage;
	}

	// Token: 0x06005A80 RID: 23168 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void FOMFEBJINLG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A81 RID: 23169 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int HGFLLGHHJML(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005A82 RID: 23170 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int OKJGDAHOCBG(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005A83 RID: 23171 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void NGMJONALOHB()
	{
	}

	// Token: 0x06005A84 RID: 23172 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string GAPOIDIICOL()
	{
		return this.itemName;
	}

	// Token: 0x06005A85 RID: 23173 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH ENCJNMNEANC()
	{
		return this.ibimage;
	}

	// Token: 0x06005A86 RID: 23174 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH FMMNICCENPF()
	{
		return this.ibimage;
	}

	// Token: 0x06005A87 RID: 23175 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int IOBNJAEOGMJ(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005A88 RID: 23176 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int JEPMFGLBAAP(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005A89 RID: 23177 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH HFAGADCJACL()
	{
		return this.ibimage;
	}

	// Token: 0x06005A8A RID: 23178 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public override string ToString()
	{
		return this.itemName;
	}

	// Token: 0x06005A8B RID: 23179 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void MIODOGNABKL()
	{
	}

	// Token: 0x06005A8C RID: 23180 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void ALJCGCBNDHL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A8D RID: 23181 RVA: 0x002AC994 File Offset: 0x002AAB94
	public virtual void HBOFDBKHMHC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 614f;
		if (this.PBHPIGPDCJA() != null)
		{
			Texture texture = this.PDJBFPOAPBA().DPBCBCLJHAJ();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1310f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1006f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 704f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 600f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005A8E RID: 23182 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void AGNBOCOGEAM()
	{
	}

	// Token: 0x06005A8F RID: 23183 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string JGAHPHMADKC()
	{
		return this.itemName;
	}

	// Token: 0x06005A90 RID: 23184 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void NEOLJLGEAHN()
	{
	}

	// Token: 0x06005A91 RID: 23185 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH PBHPIGPDCJA()
	{
		return this.ibimage;
	}

	// Token: 0x06005A92 RID: 23186 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int JBGONEKPPLB(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005A93 RID: 23187 RVA: 0x002ACA48 File Offset: 0x002AAC48
	public virtual void AGFLCAGCFBC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1209f;
		if (this.PDJBFPOAPBA() != null)
		{
			Texture texture = this.GKPOPMAAGIJ().MMKLLFCKCAG();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 502f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 194f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1687f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1168f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005A94 RID: 23188 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void IMKNNCCFOCK()
	{
	}

	// Token: 0x06005A95 RID: 23189 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int MCGGBEBAIJO(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005A96 RID: 23190 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void INPBLGAKPFF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A97 RID: 23191 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string DIJJDHMMGCA()
	{
		return this.itemName;
	}

	// Token: 0x06005A98 RID: 23192 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void IHAJPJJLFNG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A99 RID: 23193 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void AAJMALCKJHE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005A9A RID: 23194 RVA: 0x002ACAFC File Offset: 0x002AACFC
	public virtual void LGNFBDKJPIJ(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 675f;
		if (this.JGBOJNELADG() != null)
		{
			Texture texture = this.PPJOPGPEFGI().ANLLGCICOPP();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1017f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1862f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1062f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 394f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005A9B RID: 23195 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int AHEKGDLAOIN(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005A9C RID: 23196 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH GKPOPMAAGIJ()
	{
		return this.ibimage;
	}

	// Token: 0x06005A9D RID: 23197 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void EONLGIDCOGN()
	{
	}

	// Token: 0x06005A9E RID: 23198 RVA: 0x002ACBB0 File Offset: 0x002AADB0
	public virtual void GGFPEBNLLEG(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1687f;
		if (this.BHPAALLBMHL() != null)
		{
			Texture texture = this.BHPAALLBMHL().IOMNHBMOGLG();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 618f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1103f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 639f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 197f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005A9F RID: 23199 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void INFJMKDHGJA()
	{
	}

	// Token: 0x06005AA0 RID: 23200 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int LMNIKNJBFCH(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AA1 RID: 23201 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void CLOEOBIEGKM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AA2 RID: 23202 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void PIHHDONHBKF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AA3 RID: 23203 RVA: 0x002ACC64 File Offset: 0x002AAE64
	public virtual void GHNCDFCOADD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 710f;
		if (this.PBEMPJOBKKI() != null)
		{
			Texture texture = this.JGBOJNELADG().AEIIBNOFLCM();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1092f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1710f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1552f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 916f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AA4 RID: 23204 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH PBEMPJOBKKI()
	{
		return this.ibimage;
	}

	// Token: 0x06005AA5 RID: 23205 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void KOOKFCJGJPH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AA6 RID: 23206 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void NNKKDHFGIGM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AA7 RID: 23207 RVA: 0x002ACD18 File Offset: 0x002AAF18
	public virtual void LKLDEGJIJAC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1118f;
		if (this.PDJBFPOAPBA() != null)
		{
			Texture texture = this.HEFAGFMDAEE().IOMNHBMOGLG();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1718f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1495f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1957f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 435f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AA8 RID: 23208 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string OOLIOFBGDKC()
	{
		return this.itemName;
	}

	// Token: 0x06005AA9 RID: 23209 RVA: 0x002ACDCC File Offset: 0x002AAFCC
	public virtual void PFECLGBDGNH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 963f;
		if (this.MFKHIBOFIFI() != null)
		{
			Texture texture = this.GKPOPMAAGIJ().HONJOFFBOPH();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 174f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1244f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1703f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 238f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AAA RID: 23210 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void GAMABKGAFHO()
	{
	}

	// Token: 0x06005AAB RID: 23211 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int EEIMGILODKM(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AAC RID: 23212 RVA: 0x002ACE80 File Offset: 0x002AB080
	public virtual void BOHKFACPFIJ(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 439f;
		if (this.HFAGADCJACL() != null)
		{
			Texture texture = this.BHPAALLBMHL().IOMNHBMOGLG();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1004f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1682f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1409f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 597f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AAD RID: 23213 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void IPJOFCMCKIG()
	{
	}

	// Token: 0x06005AAE RID: 23214 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH APLAAOCGECL()
	{
		return this.ibimage;
	}

	// Token: 0x06005AAF RID: 23215 RVA: 0x002ACF34 File Offset: 0x002AB134
	public ItemBase()
	{
		this.itemName = "";
		this.ibimage = null;
	}

	// Token: 0x06005AB0 RID: 23216 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH PPJOPGPEFGI()
	{
		return this.ibimage;
	}

	// Token: 0x06005AB1 RID: 23217 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void IIBOLKLPAIN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AB2 RID: 23218 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void IKJDGKPPMLN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AB3 RID: 23219 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string EDBCGCIHHKA()
	{
		return this.itemName;
	}

	// Token: 0x06005AB4 RID: 23220 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int HFCKNENEKKP(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005AB5 RID: 23221 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string KJFKHMONBLB()
	{
		return this.itemName;
	}

	// Token: 0x06005AB6 RID: 23222 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void JIMHFFKPNKP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AB7 RID: 23223 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int HIMMOKHIHAN(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005AB8 RID: 23224 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string PCCOHCNHMKN()
	{
		return this.itemName;
	}

	// Token: 0x06005AB9 RID: 23225 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int KBDEBDDDCBG(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005ABA RID: 23226 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string BACHFNMDOLO()
	{
		return this.itemName;
	}

	// Token: 0x06005ABB RID: 23227 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string PGJOHGFNAPC()
	{
		return this.itemName;
	}

	// Token: 0x06005ABC RID: 23228 RVA: 0x002ACF58 File Offset: 0x002AB158
	public virtual void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 0f;
		if (this.EJJAGEFMHCO() != null)
		{
			Texture texture = this.EJJAGEFMHCO().KEDGAOBCNJG;
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 8f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.StretchToFill);
			num = num + num3 + 5f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005ABD RID: 23229 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void LCPACGLIHPL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005ABE RID: 23230 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int NFIELNGAOGP(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005ABF RID: 23231 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH JGBOJNELADG()
	{
		return this.ibimage;
	}

	// Token: 0x06005AC0 RID: 23232 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string IBLEHFEBIMG()
	{
		return this.itemName;
	}

	// Token: 0x06005AC1 RID: 23233 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int IOCPBFFNIDK(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005AC2 RID: 23234 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void ICMBPAGMHHL()
	{
	}

	// Token: 0x06005AC3 RID: 23235 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void IOJIPCHOIGC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AC4 RID: 23236 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int LCOMDAFAFIP(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AC5 RID: 23237 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string CJMFHLIBCBM()
	{
		return this.itemName;
	}

	// Token: 0x06005AC6 RID: 23238 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void MPKKGIFDKMD(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AC7 RID: 23239 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void CKADOMCIDCN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AC8 RID: 23240 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void CPPPOHJPMPH()
	{
	}

	// Token: 0x06005AC9 RID: 23241 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void OLBEMJAJCGN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005ACA RID: 23242 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void OIBMJLCALOJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005ACB RID: 23243 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH HHOBCJNGCEL()
	{
		return this.ibimage;
	}

	// Token: 0x06005ACC RID: 23244 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void EBLHNDAHHKP()
	{
	}

	// Token: 0x06005ACD RID: 23245 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int BEMOONHEIOE(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005ACE RID: 23246 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string DJDAGAEMEDD()
	{
		return this.itemName;
	}

	// Token: 0x06005ACF RID: 23247 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string BFOFMHGHALI()
	{
		return this.itemName;
	}

	// Token: 0x06005AD0 RID: 23248 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void NKPPMGOBEHH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AD1 RID: 23249 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int NAKPJJPCNDP(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AD2 RID: 23250 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void ACMOMALBEDF()
	{
	}

	// Token: 0x06005AD3 RID: 23251 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string CFMPFLJDLHI()
	{
		return this.itemName;
	}

	// Token: 0x06005AD4 RID: 23252 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void MLCFJPPIOJG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AD5 RID: 23253 RVA: 0x002AD00C File Offset: 0x002AB20C
	public virtual void EDFHDCOPKKL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1588f;
		if (this.PDJBFPOAPBA() != null)
		{
			Texture texture = this.APLAAOCGECL().EIMNFFAAHLI();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1984f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1453f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1459f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1670f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AD6 RID: 23254 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void LNNKALCBECI()
	{
	}

	// Token: 0x06005AD7 RID: 23255 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void MHCKDOFEEJM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AD8 RID: 23256 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void LBIPECNEDGE()
	{
	}

	// Token: 0x06005AD9 RID: 23257 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void DBHFEAJJGKP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005ADA RID: 23258 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void GCKNDPNKGPD(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005ADB RID: 23259 RVA: 0x002AD0C0 File Offset: 0x002AB2C0
	public virtual void HJDLKEIIODM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1976f;
		if (this.HFAGADCJACL() != null)
		{
			Texture texture = this.PDJBFPOAPBA().KEDGAOBCNJG;
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 230f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1631f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1559f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 430f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005ADC RID: 23260 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
	{
		return this.ibimage;
	}

	// Token: 0x06005ADD RID: 23261 RVA: 0x002AD174 File Offset: 0x002AB374
	public ItemBase(string ONDBNOFCOKA)
	{
		this.itemName = ONDBNOFCOKA;
		this.ibimage = null;
		base.text = ONDBNOFCOKA;
	}

	// Token: 0x06005ADE RID: 23262 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH PDJBFPOAPBA()
	{
		return this.ibimage;
	}

	// Token: 0x06005ADF RID: 23263 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int CAGEGAFLKMG(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005AE0 RID: 23264 RVA: 0x002AD198 File Offset: 0x002AB398
	public virtual void HHGEJJFKPOK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 777f;
		if (this.HEFAGFMDAEE() != null)
		{
			Texture texture = this.BHPAALLBMHL().AEIIBNOFLCM();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 123f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 814f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 390f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 203f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AE1 RID: 23265 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void LLIFNPFHHAK()
	{
	}

	// Token: 0x06005AE2 RID: 23266 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void FBBCBBGJIMC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AE3 RID: 23267 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int CKFDODHLGEL(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005AE4 RID: 23268 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string CGGKJFBHOMJ()
	{
		return this.itemName;
	}

	// Token: 0x06005AE5 RID: 23269 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void ACMKDMDGDKI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AE6 RID: 23270 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int BLCCPFGCANC(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AE7 RID: 23271 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void FJBBDHGJKFP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AE8 RID: 23272 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void GHFIGCEOHAO()
	{
	}

	// Token: 0x06005AE9 RID: 23273 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public virtual int BDHHIKEEAEB(ItemBase MBKPMBPLIJN)
	{
		return 1;
	}

	// Token: 0x06005AEA RID: 23274 RVA: 0x002AD24C File Offset: 0x002AB44C
	public virtual void IHNEGGJADMO(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 514f;
		if (this.HHOBCJNGCEL() != null)
		{
			Texture texture = this.HHOBCJNGCEL().EIMNFFAAHLI();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 66f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.ScaleAndCrop);
			num = num + num3 + 1375f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1225f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1973f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AEB RID: 23275 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH KHIDJHKNNFC()
	{
		return this.ibimage;
	}

	// Token: 0x06005AEC RID: 23276 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int LNINMFONEAK(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AED RID: 23277 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string IGJFJGKAFIE()
	{
		return this.itemName;
	}

	// Token: 0x06005AEE RID: 23278 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void HEHDGADCBCB()
	{
	}

	// Token: 0x06005AEF RID: 23279 RVA: 0x002AC98C File Offset: 0x002AAB8C
	public virtual string GJCCJEINDDC()
	{
		return this.itemName;
	}

	// Token: 0x06005AF0 RID: 23280 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void NNIOKOKAMHG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AF1 RID: 23281 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int NBCAEJHKLMG(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AF2 RID: 23282 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void INCOCIBKJMH()
	{
	}

	// Token: 0x06005AF3 RID: 23283 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void EJCKHJGJGLF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AF4 RID: 23284 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void DLLGOOMIOMG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AF5 RID: 23285 RVA: 0x002AD300 File Offset: 0x002AB500
	public ItemBase(string ONDBNOFCOKA, CKNLPGEPGGF.IAPCJOBDCEH MAFKEMNJODG)
	{
		this.itemName = ONDBNOFCOKA;
		this.ibimage = MAFKEMNJODG;
	}

	// Token: 0x06005AF6 RID: 23286 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int DPAPDKMLFCB(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AF7 RID: 23287 RVA: 0x002AD320 File Offset: 0x002AB520
	public virtual void DNLOFIPAEBD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 959f;
		if (this.APLAAOCGECL() != null)
		{
			Texture texture = this.ENCJNMNEANC().IOMNHBMOGLG();
			float num2 = COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float height = (float)texture.height * num2;
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 462f, COAGIAMOCIA.y, num3, height), texture, ScaleMode.StretchToFill);
			num = num + num3 + 1354f;
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1243f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 870f, COAGIAMOCIA.height), this.ToString(), OFPNEDEAMAB);
	}

	// Token: 0x06005AF8 RID: 23288 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void OMBICACBIFH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AF9 RID: 23289 RVA: 0x000EB372 File Offset: 0x000E9572
	public virtual int NJAEENLKEAB(ItemBase MBKPMBPLIJN)
	{
		return 0;
	}

	// Token: 0x06005AFA RID: 23290 RVA: 0x002AC988 File Offset: 0x002AAB88
	public virtual void ELDBGAOKMPC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x06005AFB RID: 23291 RVA: 0x002AC980 File Offset: 0x002AAB80
	public virtual CKNLPGEPGGF.IAPCJOBDCEH HEFAGFMDAEE()
	{
		return this.ibimage;
	}

	// Token: 0x06005AFC RID: 23292 RVA: 0x00022FCC File Offset: 0x000211CC
	public virtual void HCFDLMBIEGC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
	{
	}

	// Token: 0x04000D88 RID: 3464
	protected string itemName;

	// Token: 0x04000D89 RID: 3465
	protected CKNLPGEPGGF.IAPCJOBDCEH ibimage;

	// Token: 0x04000D8A RID: 3466
	public bool isVisible = true;

	// Token: 0x04000D8B RID: 3467
	public long tag;

	// Token: 0x04000D8C RID: 3468
	public ItemBase.OOALOMPKIKK onRender;

	// Token: 0x02000197 RID: 407
	// (Invoke) Token: 0x06005AFE RID: 23294
	public delegate void OOALOMPKIKK(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM);
}
