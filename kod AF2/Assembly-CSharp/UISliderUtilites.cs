using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000187 RID: 391
[RequireComponent(typeof(Slider))]
public class UISliderUtilites : MonoBehaviour
{
	// Token: 0x060056DB RID: 22235 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HONIFOPBBKC()
	{
	}

	// Token: 0x060056DC RID: 22236 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void JPHBPEAMNHB()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x060056DD RID: 22237 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void AddValueToSlider(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x060056DE RID: 22238 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x060056DF RID: 22239 RVA: 0x0028FDF4 File Offset: 0x0028DFF4
	public void IICKEBHECMN(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "knopje.wav";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1744f, 40f, this.PBECPENLMON.value * this.rotScale, 1603f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clacSound, 535f);
	}

	// Token: 0x060056E0 RID: 22240 RVA: 0x0028FF28 File Offset: 0x0028E128
	public void IAMNFNIHONC(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "IceHockeyIdle";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(762f, 275f, this.PBECPENLMON.value * this.rotScale, 1717f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.clacSound, 572f);
	}

	// Token: 0x060056E1 RID: 22241 RVA: 0x0029005C File Offset: 0x0028E25C
	public void LHIIFFIFGHE(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "SYS";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1300f, 901f, this.PBECPENLMON.value * this.rotScale, 1934f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 1204f);
	}

	// Token: 0x060056E2 RID: 22242 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDANNBFJHIK()
	{
	}

	// Token: 0x060056E3 RID: 22243 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BEDAJLJFAFO()
	{
	}

	// Token: 0x060056E4 RID: 22244 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void PAKEDOFHPEJ(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x060056E5 RID: 22245 RVA: 0x00290190 File Offset: 0x0028E390
	public void PLFOLIPCEFI(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "IdleDodgeRight";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(83f, 335f, this.PBECPENLMON.value * this.rotScale, 897f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clacSound, 529f);
	}

	// Token: 0x060056E6 RID: 22246 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void BMNJGPIPKLL()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x060056E7 RID: 22247 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KMLNBHIIGKH()
	{
	}

	// Token: 0x060056E8 RID: 22248 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void PCHFKMDPBAJ(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x060056E9 RID: 22249 RVA: 0x002902C4 File Offset: 0x0028E4C4
	public void DCAABFFAEPL(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "_Threshhold";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(323f, 1008f, this.PBECPENLMON.value * this.rotScale, 335f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clacSound, 1646f);
	}

	// Token: 0x060056EA RID: 22250 RVA: 0x002903F8 File Offset: 0x0028E5F8
	public void NDOCIPGNKMM(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "H ";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1380f, 1155f, this.PBECPENLMON.value * this.rotScale, 488f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.clacSound, 80f);
	}

	// Token: 0x060056EB RID: 22251 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CBBLGEDCJBF()
	{
	}

	// Token: 0x060056EC RID: 22252 RVA: 0x0029052C File Offset: 0x0028E72C
	public void CJGOBECDHFC(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "_NeutralTonemapperParams2";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1897f, 101f, this.PBECPENLMON.value * this.rotScale, 143f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clacSound, 48f);
	}

	// Token: 0x060056ED RID: 22253 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void GDIMBBBPIHI()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x060056EE RID: 22254 RVA: 0x00290660 File Offset: 0x0028E860
	public void GKJNALELFGH(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "DataSize ";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1629f, 1526f, this.PBECPENLMON.value * this.rotScale, 480f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.clacSound, 1558f);
	}

	// Token: 0x060056EF RID: 22255 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void MMACLBBMDLA()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x060056F0 RID: 22256 RVA: 0x00290794 File Offset: 0x0028E994
	public void JILGFDFHHJC(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1463f, 1125f, this.PBECPENLMON.value * this.rotScale, 130f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clacSound, 412f);
	}

	// Token: 0x060056F1 RID: 22257 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void BBFPILBIMKC()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x060056F2 RID: 22258 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DEGCCLNOEKJ()
	{
	}

	// Token: 0x060056F3 RID: 22259 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void EDGALMCHPPH()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x060056F4 RID: 22260 RVA: 0x002908C8 File Offset: 0x0028EAC8
	public void ANIHDAABNMD(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "u_email";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(756f, 237f, this.PBECPENLMON.value * this.rotScale, 1517f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.clacSound, 1117f);
	}

	// Token: 0x060056F5 RID: 22261 RVA: 0x002909FC File Offset: 0x0028EBFC
	public void MJBKEDCDJNF(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "Prone Locomotion";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(125f, 88f, this.PBECPENLMON.value * this.rotScale, 1800f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.clacSound, 777f);
	}

	// Token: 0x060056F6 RID: 22262 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void LOLNNEOIPFF(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x060056F7 RID: 22263 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HMLNMHOMMNO()
	{
	}

	// Token: 0x060056F8 RID: 22264 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PFPPDNHLCCA()
	{
	}

	// Token: 0x060056F9 RID: 22265 RVA: 0x00290B30 File Offset: 0x0028ED30
	public void FLKMFNAAHKO(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "1";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1054f, 919f, this.PBECPENLMON.value * this.rotScale, 1420f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.clacSound, 406f);
	}

	// Token: 0x060056FA RID: 22266 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JLFBDOPFDDJ()
	{
	}

	// Token: 0x060056FB RID: 22267 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LACNPNKHCAA()
	{
	}

	// Token: 0x060056FC RID: 22268 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EMFOECIPBIP()
	{
	}

	// Token: 0x060056FD RID: 22269 RVA: 0x00290C64 File Offset: 0x0028EE64
	public void KIFKFCHKGHI(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "wpn_rod1";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1433f, 1813f, this.PBECPENLMON.value * this.rotScale, 626f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.clacSound, 665f);
	}

	// Token: 0x060056FE RID: 22270 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void FEGGNGJJNBD(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x060056FF RID: 22271 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void LMEJKAEIDCO()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005700 RID: 22272 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void LOPCKCBPNBM(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06005701 RID: 22273 RVA: 0x00290D98 File Offset: 0x0028EF98
	public void BFOOMNFOPND(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "wpn_add/base";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1631f, 1417f, this.PBECPENLMON.value * this.rotScale, 390f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clacSound, 23f);
	}

	// Token: 0x06005702 RID: 22274 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x06005703 RID: 22275 RVA: 0x00290ECC File Offset: 0x0028F0CC
	public void FDEFBOGDJCI(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "Error";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(600f, 1131f, this.PBECPENLMON.value * this.rotScale, 260f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clacSound, 990f);
	}

	// Token: 0x06005704 RID: 22276 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IDMCOLDDNCF()
	{
	}

	// Token: 0x06005705 RID: 22277 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void CLHGHANANNL()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005706 RID: 22278 RVA: 0x00291000 File Offset: 0x0028F200
	public void FJCNFDCEFJN(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "_RampTex";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(916f, 1332f, this.PBECPENLMON.value * this.rotScale, 75f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clacSound, 581f);
	}

	// Token: 0x06005707 RID: 22279 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void ADLHNBEDHMJ()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005708 RID: 22280 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void CPNOBMNKPNC()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005709 RID: 22281 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void PKIKFICBMEO(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x0600570A RID: 22282 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void ILLCGOPKOKN(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x0600570B RID: 22283 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void EDLFACFNHHA(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x0600570C RID: 22284 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void LMLNAENGPKD(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x0600570E RID: 22286 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void Start()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x0600570F RID: 22287 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void KFCPHLCKMBA(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06005710 RID: 22288 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void HDFCIACDDEK()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005711 RID: 22289 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void AFFAJKPPMHF()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005712 RID: 22290 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DFFOEGHGPGP()
	{
	}

	// Token: 0x06005713 RID: 22291 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void KMOIJIAMNEB(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06005714 RID: 22292 RVA: 0x00291150 File Offset: 0x0028F350
	public void IJNACJDOJEF(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = " ";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(275f, 578f, this.PBECPENLMON.value * this.rotScale, 1545f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 1617f);
	}

	// Token: 0x06005715 RID: 22293 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HJCLNJLADKL()
	{
	}

	// Token: 0x06005716 RID: 22294 RVA: 0x00291284 File Offset: 0x0028F484
	public void JHKKAMFOJJJ(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "H:mm:ss";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1869f, 951f, this.PBECPENLMON.value * this.rotScale, 1054f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 757f);
	}

	// Token: 0x06005717 RID: 22295 RVA: 0x002913B8 File Offset: 0x0028F5B8
	public void OnChange(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "OFF";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(0f, 0f, this.PBECPENLMON.value * this.rotScale, 0f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 0.5f);
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void JCELICPHGEP()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005719 RID: 22297 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void NCALLFHEAGJ()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x0600571A RID: 22298 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void HJJJGPCCDMB(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x0600571B RID: 22299 RVA: 0x002914EC File Offset: 0x0028F6EC
	public void DOFMDKJIEDE(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(367f, 1208f, this.PBECPENLMON.value * this.rotScale, 554f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 1251f);
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x00291620 File Offset: 0x0028F820
	public void AHEPFBJLEPO(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "RotationLimitPolygonal reach cones are invalid.";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(556f, 1677f, this.PBECPENLMON.value * this.rotScale, 461f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.clacSound, 588f);
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void AIFIEAGFIMM()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x00291754 File Offset: 0x0028F954
	public void OABLEEDIGFC(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "repair.ogg";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1368f, 1041f, this.PBECPENLMON.value * this.rotScale, 196f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 1953f);
	}

	// Token: 0x0600571F RID: 22303 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void PFNPOHMMJDN()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005720 RID: 22304 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void GEEPPLMPCMJ(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06005721 RID: 22305 RVA: 0x00291888 File Offset: 0x0028FA88
	public void JOOKJJKMFDF(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "_ScreenEdgeFading";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(880f, 1964f, this.PBECPENLMON.value * this.rotScale, 1595f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clacSound, 424f);
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void KMOFKMNAKFD(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06005723 RID: 22307 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void BJHGPFGBFKF()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005724 RID: 22308 RVA: 0x002919BC File Offset: 0x0028FBBC
	public void AGJOIGDHAOE(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "crft_crft";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1538f, 1188f, this.PBECPENLMON.value * this.rotScale, 993f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 1580f);
	}

	// Token: 0x06005725 RID: 22309 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void INMBHOJNPDC(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06005726 RID: 22310 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FKHAKIKPFFO()
	{
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void ONIHHFLOJMN()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void MKJIAMMIDCI(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void PNAAHEFHPCL()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void CGBKECOCFME(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x00291AF0 File Offset: 0x0028FCF0
	public void KEAODDIPOJD(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "Mouse ScrollWheel";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(366f, 886f, this.PBECPENLMON.value * this.rotScale, 1063f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clacSound, 159f);
	}

	// Token: 0x0600572C RID: 22316 RVA: 0x0028FDC8 File Offset: 0x0028DFC8
	private void DDEBDCGNCPC()
	{
		this.PBECPENLMON = base.GetComponent<Slider>();
	}

	// Token: 0x0600572D RID: 22317 RVA: 0x00291C24 File Offset: 0x0028FE24
	public void LHHMOGLMMOO(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "_MaxRadiusOrKInPaper";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1845f, 781f, this.PBECPENLMON.value * this.rotScale, 737f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.clacSound, 670f);
	}

	// Token: 0x0600572E RID: 22318 RVA: 0x0028FDD6 File Offset: 0x0028DFD6
	public void AJHADBJIDEL(int FEAGDHLLLOI)
	{
		this.PBECPENLMON.value = this.PBECPENLMON.value + (float)FEAGDHLLLOI;
	}

	// Token: 0x0600572F RID: 22319 RVA: 0x00291D58 File Offset: 0x0028FF58
	public void PMMGMFJINCO(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 0 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "KatanaVerticalSwing";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(647f, 1087f, this.PBECPENLMON.value * this.rotScale, 546f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.clacSound, 1467f);
	}

	// Token: 0x06005730 RID: 22320 RVA: 0x00291E8C File Offset: 0x0029008C
	public void HJNLKMNPLMA(float FEAGDHLLLOI)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (this.PBECPENLMON == null)
		{
			return;
		}
		if (this.bumText != null)
		{
			this.bumText.text = (this.isKgText ? JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)Mathf.RoundToInt(this.PBECPENLMON.value)) : string.Concat(Mathf.RoundToInt(this.PBECPENLMON.value)));
		}
		if (this.minimalOff > 1 && this.PBECPENLMON.value < (float)this.minimalOff)
		{
			this.bumText.text = "subtype";
		}
		if (this.rotateObject != null)
		{
			this.rotateObject.rotation = new Quaternion(1233f, 263f, this.PBECPENLMON.value * this.rotScale, 655f);
		}
		if (Mathf.Abs(this.PBECPENLMON.value - this.KHIEABMLEFK) <= this.soundStep)
		{
			return;
		}
		this.KHIEABMLEFK = this.PBECPENLMON.value;
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clacSound, 1125f);
	}

	// Token: 0x04000D1C RID: 3356
	public AudioClip clacSound;

	// Token: 0x04000D1D RID: 3357
	public RectTransform rotateObject;

	// Token: 0x04000D1E RID: 3358
	public float rotScale;

	// Token: 0x04000D1F RID: 3359
	public Text bumText;

	// Token: 0x04000D20 RID: 3360
	public bool isKgText;

	// Token: 0x04000D21 RID: 3361
	public int minimalOff = 100;

	// Token: 0x04000D22 RID: 3362
	public float soundStep = 10f;

	// Token: 0x04000D23 RID: 3363
	private Slider PBECPENLMON;

	// Token: 0x04000D24 RID: 3364
	private float KHIEABMLEFK;
}
