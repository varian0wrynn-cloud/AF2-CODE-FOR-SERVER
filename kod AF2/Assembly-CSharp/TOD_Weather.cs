using System;
using UnityEngine;

// Token: 0x020000E3 RID: 227
public class TOD_Weather : MonoBehaviour
{
	// Token: 0x06002ABE RID: 10942 RVA: 0x0013B500 File Offset: 0x00139700
	protected void HDFCIACDDEK()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x0013B58C File Offset: 0x0013978C
	protected void BEDAJLJFAFO()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 689f;
			this.OGCBDPNLJJN = 288f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 651f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 949f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 269f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 136f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1087f;
			this.BPHLPMJJCOP = 79f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1744f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 805f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x0013B7F0 File Offset: 0x001399F0
	protected void OPNPODKLOJK()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x0013B87C File Offset: 0x00139A7C
	protected void HABONMJNDAL()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1883f;
			this.OGCBDPNLJJN = 360f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 166f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1858f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1015f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 208f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 508f;
			this.BPHLPMJJCOP = 1603f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1261f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1551f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x0013BAE0 File Offset: 0x00139CE0
	protected void FJEEADNCKAG()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1192f;
			this.OGCBDPNLJJN = 863f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1951f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1098f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 466f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1112f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1996f;
			this.BPHLPMJJCOP = 1043f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 424f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 721f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x0013BD44 File Offset: 0x00139F44
	protected void LPNDCJKAKEA()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x0013BDD0 File Offset: 0x00139FD0
	protected void OLBDJCFPKFG()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x0013BE5C File Offset: 0x0013A05C
	protected void PGIHAIPCJLL()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 335f;
			this.OGCBDPNLJJN = 1071f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 702f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1572f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 406f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 43f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1421f;
			this.BPHLPMJJCOP = 1450f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 439f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1344f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x0013C0C0 File Offset: 0x0013A2C0
	protected void FIJKDFIMELM()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x0013C14C File Offset: 0x0013A34C
	protected void CGNGBFFGGBP()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x0013C1D8 File Offset: 0x0013A3D8
	protected void MEFOGCFJBNE()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 899f;
			this.OGCBDPNLJJN = 721f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 102f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 200f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 230f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 93f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1141f;
			this.BPHLPMJJCOP = 498f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 48f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 772f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x0013C43C File Offset: 0x0013A63C
	protected void EMFOECIPBIP()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1518f;
			this.OGCBDPNLJJN = 629f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 710f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1419f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1452f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1740f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1049f;
			this.BPHLPMJJCOP = 836f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1630f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1698f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x0013C6A0 File Offset: 0x0013A8A0
	protected void MODJFGGIAHD()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x0013C72C File Offset: 0x0013A92C
	protected void IMABGALEMBI()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x0013C7B8 File Offset: 0x0013A9B8
	protected void AFFAJKPPMHF()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x0013C844 File Offset: 0x0013AA44
	protected void AAEFACEGJMB()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1090f;
			this.OGCBDPNLJJN = 1260f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 758f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 389f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 830f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 146f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 409f;
			this.BPHLPMJJCOP = 1019f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1579f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 850f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x0013CAA8 File Offset: 0x0013ACA8
	protected void KJJBBLDJHPD()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1770f;
			this.OGCBDPNLJJN = 117f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 511f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 384f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1469f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 839f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1948f;
			this.BPHLPMJJCOP = 270f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1811f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1465f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x0013CD0C File Offset: 0x0013AF0C
	protected void GDBBAMFMKII()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 17f;
			this.OGCBDPNLJJN = 1442f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 917f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 807f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 927f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1276f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 370f;
			this.BPHLPMJJCOP = 1892f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1572f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 27f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x0013CF70 File Offset: 0x0013B170
	protected void Update()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 0f;
			this.OGCBDPNLJJN = 1f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 5f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 3f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 0.1f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 0.3f;
			this.BPHLPMJJCOP = 1f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 0.5f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x0013D1D4 File Offset: 0x0013B3D4
	protected void DGEIACONKCJ()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x0013D260 File Offset: 0x0013B460
	protected void OFPGMNGFLNH()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1128f;
			this.OGCBDPNLJJN = 926f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 637f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 607f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1604f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1902f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 134f;
			this.BPHLPMJJCOP = 1231f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 415f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1873f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x0013D4C4 File Offset: 0x0013B6C4
	protected void PMDPLLIBJAF()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x0013D550 File Offset: 0x0013B750
	protected void GCNGEFBKMNC()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 108f;
			this.OGCBDPNLJJN = 44f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 209f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 789f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1485f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1708f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 68f;
			this.BPHLPMJJCOP = 464f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1467f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 650f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x0013D7B4 File Offset: 0x0013B9B4
	protected void CGMHGDEKDEP()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x0013D840 File Offset: 0x0013BA40
	protected void HONIFOPBBKC()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1918f;
			this.OGCBDPNLJJN = 660f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1473f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1744f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 895f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 770f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 155f;
			this.BPHLPMJJCOP = 1085f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 59f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1027f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x0013DAA4 File Offset: 0x0013BCA4
	protected void IJOCHELLKJH()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x0013DB30 File Offset: 0x0013BD30
	protected void PBFKCKCHEAC()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1905f;
			this.OGCBDPNLJJN = 714f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 620f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1041f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 961f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1547f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1517f;
			this.BPHLPMJJCOP = 347f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 728f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 110f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x0013DD94 File Offset: 0x0013BF94
	protected void JIKGIJEHGAP()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1150f;
			this.OGCBDPNLJJN = 779f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1899f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 245f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 29f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1603f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1882f;
			this.BPHLPMJJCOP = 1401f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1585f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1058f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x0013DFF8 File Offset: 0x0013C1F8
	protected void DFFOEGHGPGP()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 454f;
			this.OGCBDPNLJJN = 449f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1733f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1122f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 483f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 182f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1557f;
			this.BPHLPMJJCOP = 1382f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1641f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1095f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x0013E25C File Offset: 0x0013C45C
	protected void MFHGOLNLAAF()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 820f;
			this.OGCBDPNLJJN = 1501f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1231f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1086f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1358f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 364f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1868f;
			this.BPHLPMJJCOP = 1667f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 505f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 321f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x0013E4C0 File Offset: 0x0013C6C0
	protected void LHHKDNILMDI()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x0013E54C File Offset: 0x0013C74C
	protected void NOKJMMDMJNO()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x0013E5D8 File Offset: 0x0013C7D8
	protected void KIEIPFFEDHC()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x0013E664 File Offset: 0x0013C864
	protected void EHDPACPIBNF()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x0013E6F0 File Offset: 0x0013C8F0
	protected void BNKJNBIDPME()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 77f;
			this.OGCBDPNLJJN = 1240f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 867f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 86f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 707f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1885f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1592f;
			this.BPHLPMJJCOP = 1804f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1243f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1634f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x0013E954 File Offset: 0x0013CB54
	protected void PJHEGHHOJHJ()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 446f;
			this.OGCBDPNLJJN = 960f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 633f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1550f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 573f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1651f;
			this.BPHLPMJJCOP = 617f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 345f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 399f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x0013EBB8 File Offset: 0x0013CDB8
	protected void DHJDMKLBLEF()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x0013EC44 File Offset: 0x0013CE44
	protected void IGEICBNMPAD()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 728f;
			this.OGCBDPNLJJN = 861f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 55f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1139f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1683f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 903f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 882f;
			this.BPHLPMJJCOP = 1233f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 546f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 197f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AE4 RID: 10980 RVA: 0x0013EEA8 File Offset: 0x0013D0A8
	protected void JIBKGOFOPHJ()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1520f;
			this.OGCBDPNLJJN = 191f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1066f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 685f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 453f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 624f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 240f;
			this.BPHLPMJJCOP = 1548f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 768f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1901f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x0013F10C File Offset: 0x0013D30C
	protected void IOGAKGCADBL()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 378f;
			this.OGCBDPNLJJN = 900f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1409f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 366f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1123f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 34f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 756f;
			this.BPHLPMJJCOP = 1208f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1999f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1986f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AE7 RID: 10983 RVA: 0x0013F384 File Offset: 0x0013D584
	protected void FOHLAIIMNFB()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 44f;
			this.OGCBDPNLJJN = 1097f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1480f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1277f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1932f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1693f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 941f;
			this.BPHLPMJJCOP = 578f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1782f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1409f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AE8 RID: 10984 RVA: 0x0013F5E8 File Offset: 0x0013D7E8
	protected void DPGECEOMHNM()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1528f;
			this.OGCBDPNLJJN = 946f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1779f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 298f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1932f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 855f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 385f;
			this.BPHLPMJJCOP = 108f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1976f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1002f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AE9 RID: 10985 RVA: 0x0013F84C File Offset: 0x0013DA4C
	protected void HAIMGCDKPDC()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 868f;
			this.OGCBDPNLJJN = 538f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1430f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1846f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 148f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 500f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 515f;
			this.BPHLPMJJCOP = 171f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1759f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1855f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AEA RID: 10986 RVA: 0x0013FAB0 File Offset: 0x0013DCB0
	protected void JIFOELPAEHG()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 905f;
			this.OGCBDPNLJJN = 1171f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 655f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1810f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 147f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 51f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1864f;
			this.BPHLPMJJCOP = 916f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 234f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 33f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x0013FD14 File Offset: 0x0013DF14
	protected void LIOCDEICIFD()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 102f;
			this.OGCBDPNLJJN = 516f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1750f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1789f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1342f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 524f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 554f;
			this.BPHLPMJJCOP = 1806f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 920f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1278f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x0013FF78 File Offset: 0x0013E178
	protected void OBJCOJEHLBE()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x00140004 File Offset: 0x0013E204
	protected void CPNOBMNKPNC()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AEE RID: 10990 RVA: 0x00140090 File Offset: 0x0013E290
	protected void PNJHMJNFPLP()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AEF RID: 10991 RVA: 0x0014011C File Offset: 0x0013E31C
	protected void EDGALMCHPPH()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AF0 RID: 10992 RVA: 0x001401A8 File Offset: 0x0013E3A8
	protected void ONIHHFLOJMN()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AF1 RID: 10993 RVA: 0x00140234 File Offset: 0x0013E434
	protected void AIAMIFEPALP()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1167f;
			this.OGCBDPNLJJN = 1617f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1930f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 52f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 879f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 375f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1008f;
			this.BPHLPMJJCOP = 794f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1591f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 639f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AF2 RID: 10994 RVA: 0x00140498 File Offset: 0x0013E698
	protected void BJOICAKCPLI()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1344f;
			this.OGCBDPNLJJN = 161f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 644f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1269f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 133f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1681f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1841f;
			this.BPHLPMJJCOP = 222f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 900f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1562f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AF3 RID: 10995 RVA: 0x001406FC File Offset: 0x0013E8FC
	protected void ELADFDNPOOI()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AF4 RID: 10996 RVA: 0x00140788 File Offset: 0x0013E988
	protected void JOHDLNOKCOK()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 664f;
			this.OGCBDPNLJJN = 1388f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1288f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 253f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 622f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 709f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 99f;
			this.BPHLPMJJCOP = 1599f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 982f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1283f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AF5 RID: 10997 RVA: 0x001409EC File Offset: 0x0013EBEC
	protected void AIFIEAGFIMM()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AF6 RID: 10998 RVA: 0x00140A78 File Offset: 0x0013EC78
	protected void LMMDHJJJNJO()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1516f;
			this.OGCBDPNLJJN = 1894f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 495f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 413f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 769f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1201f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1392f;
			this.BPHLPMJJCOP = 324f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1297f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1721f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x00140CDC File Offset: 0x0013EEDC
	protected void CBBLGEDCJBF()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1907f;
			this.OGCBDPNLJJN = 1000f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 311f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 253f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1450f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1603f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 982f;
			this.BPHLPMJJCOP = 773f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1166f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1455f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AF8 RID: 11000 RVA: 0x00140F40 File Offset: 0x0013F140
	protected void OFGMIEJKMGC()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x00140FCC File Offset: 0x0013F1CC
	protected void PNAAHEFHPCL()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AFA RID: 11002 RVA: 0x00141058 File Offset: 0x0013F258
	protected void EHFPLKEINFO()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AFB RID: 11003 RVA: 0x001410E4 File Offset: 0x0013F2E4
	protected void Start()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AFC RID: 11004 RVA: 0x00141170 File Offset: 0x0013F370
	protected void LBGKAMLLACN()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 1862f;
			this.OGCBDPNLJJN = 1640f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 845f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1016f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1508f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1014f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 269f;
			this.BPHLPMJJCOP = 1258f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1266f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1171f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AFD RID: 11005 RVA: 0x001413D4 File Offset: 0x0013F5D4
	protected void PFNOEACNHON()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 165f;
			this.OGCBDPNLJJN = 1972f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1291f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1279f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 632f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 813f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1637f;
			this.BPHLPMJJCOP = 160f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1908f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1125f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x06002AFE RID: 11006 RVA: 0x00141638 File Offset: 0x0013F838
	protected void FGJCIEDDFGN()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		this.KJHOCDJJNME = (this.BCDKMPOMLHO = this.HGOMCJOPDML.Clouds.Brightness);
		this.CGGHBNNCMDF = (this.EOJPBHFANGD = this.HGOMCJOPDML.Clouds.Density);
		this.BPHLPMJJCOP = (this.LJIKJINIKEI = this.HGOMCJOPDML.Atmosphere.Fogginess);
		this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
	}

	// Token: 0x06002AFF RID: 11007 RVA: 0x001416C4 File Offset: 0x0013F8C4
	protected void AMDMCKIFBPA()
	{
		if (this.Clouds == MCDCEIKHCND.Custom && this.Weather == JPFPFIFAEKJ.Custom)
		{
			return;
		}
		switch (this.Clouds)
		{
		case MCDCEIKHCND.Custom:
			this.CGGHBNNCMDF = this.HGOMCJOPDML.Clouds.Density;
			this.OGCBDPNLJJN = this.HGOMCJOPDML.Clouds.Sharpness;
			break;
		case MCDCEIKHCND.None:
			this.CGGHBNNCMDF = 507f;
			this.OGCBDPNLJJN = 1655f;
			break;
		case MCDCEIKHCND.Few:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1499f;
			break;
		case MCDCEIKHCND.Scattered:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 663f;
			break;
		case MCDCEIKHCND.Broken:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 744f;
			break;
		case MCDCEIKHCND.Overcast:
			this.CGGHBNNCMDF = this.EOJPBHFANGD;
			this.OGCBDPNLJJN = 1586f;
			break;
		}
		switch (this.Weather)
		{
		case JPFPFIFAEKJ.Custom:
			this.KJHOCDJJNME = this.HGOMCJOPDML.Clouds.Brightness;
			this.BPHLPMJJCOP = this.HGOMCJOPDML.Atmosphere.Fogginess;
			break;
		case JPFPFIFAEKJ.Clear:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = this.LJIKJINIKEI;
			break;
		case JPFPFIFAEKJ.Storm:
			this.KJHOCDJJNME = 1038f;
			this.BPHLPMJJCOP = 114f;
			break;
		case JPFPFIFAEKJ.Dust:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 1649f;
			break;
		case JPFPFIFAEKJ.Fog:
			this.KJHOCDJJNME = this.BCDKMPOMLHO;
			this.BPHLPMJJCOP = 419f;
			break;
		}
		float t = Time.deltaTime / this.FadeTime;
		this.HGOMCJOPDML.Clouds.Brightness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Brightness, this.KJHOCDJJNME, t);
		this.HGOMCJOPDML.Clouds.Density = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Density, this.CGGHBNNCMDF, t);
		this.HGOMCJOPDML.Clouds.Sharpness = Mathf.Lerp(this.HGOMCJOPDML.Clouds.Sharpness, this.OGCBDPNLJJN, t);
		this.HGOMCJOPDML.Atmosphere.Fogginess = Mathf.Lerp(this.HGOMCJOPDML.Atmosphere.Fogginess, this.BPHLPMJJCOP, t);
	}

	// Token: 0x040005D7 RID: 1495
	[Tooltip("Time to fade from one weather type to the other.")]
	public float FadeTime = 10f;

	// Token: 0x040005D8 RID: 1496
	[Tooltip("Currently selected cloud type.")]
	public MCDCEIKHCND Clouds;

	// Token: 0x040005D9 RID: 1497
	[Tooltip("Currently selected weather type.")]
	public JPFPFIFAEKJ Weather;

	// Token: 0x040005DA RID: 1498
	private float BCDKMPOMLHO;

	// Token: 0x040005DB RID: 1499
	private float EOJPBHFANGD;

	// Token: 0x040005DC RID: 1500
	private float LJIKJINIKEI;

	// Token: 0x040005DD RID: 1501
	private float KJHOCDJJNME;

	// Token: 0x040005DE RID: 1502
	private float CGGHBNNCMDF;

	// Token: 0x040005DF RID: 1503
	private float BPHLPMJJCOP;

	// Token: 0x040005E0 RID: 1504
	private float OGCBDPNLJJN;

	// Token: 0x040005E1 RID: 1505
	private TOD_Sky HGOMCJOPDML;
}
