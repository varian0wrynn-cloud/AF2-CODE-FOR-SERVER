using System;
using UnityEngine;

// Token: 0x02000134 RID: 308
[ExecuteInEditMode]
public class RollParams : MonoBehaviour
{
	// Token: 0x06003FB1 RID: 16305 RVA: 0x001D310A File Offset: 0x001D130A
	public void BDOMFMNFFGK()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x001D3146 File Offset: 0x001D1346
	private void Awake()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.IKGFHGKKCPG.reelTensionCurve;
		}
	}

	// Token: 0x06003FB3 RID: 16307 RVA: 0x001D3160 File Offset: 0x001D1360
	private void NOLKOIHEICD()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FB4 RID: 16308 RVA: 0x001D310A File Offset: 0x001D130A
	public void KNONHACOBJN()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FB5 RID: 16309 RVA: 0x001D31AD File Offset: 0x001D13AD
	public float OJHKCMLHOIF(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1467f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 92f, 936f));
	}

	// Token: 0x06003FB7 RID: 16311 RVA: 0x001D3248 File Offset: 0x001D1448
	private void KBMKHLDOIKP()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FB8 RID: 16312 RVA: 0x001D3295 File Offset: 0x001D1495
	public float JKEBJEOECAI(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 868f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 896f, 115f));
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x001D32C1 File Offset: 0x001D14C1
	public float FJBJHMIGLPF(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1666f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 621f, 1395f));
	}

	// Token: 0x06003FBA RID: 16314 RVA: 0x001D32ED File Offset: 0x001D14ED
	private void DMCOCNPIHCG()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.PLGADNLAEGN().reelTensionCurve;
		}
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x001D3307 File Offset: 0x001D1507
	private void MBDOEDLGJGF()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x06003FBC RID: 16316 RVA: 0x001D3321 File Offset: 0x001D1521
	public float LABJNLPBANG(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1717f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 609f, 667f));
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x001D3350 File Offset: 0x001D1550
	private void OHKHOAKCENL()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x001D33A0 File Offset: 0x001D15A0
	private void KCBECEFNGMO()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x001D310A File Offset: 0x001D130A
	public void CHBIBACMIKC()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FC0 RID: 16320 RVA: 0x001D33F0 File Offset: 0x001D15F0
	private void GDPMOMHBIFN()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FC1 RID: 16321 RVA: 0x001D343D File Offset: 0x001D163D
	public float IHCKGJMCCFE(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 124f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1897f, 134f));
	}

	// Token: 0x06003FC2 RID: 16322 RVA: 0x001D3469 File Offset: 0x001D1669
	public float GMNHLEKFKBI(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1893f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 643f, 611f));
	}

	// Token: 0x06003FC3 RID: 16323 RVA: 0x001D310A File Offset: 0x001D130A
	public void JCPENBOEKDO()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FC4 RID: 16324 RVA: 0x001D3495 File Offset: 0x001D1695
	public float EJCJOBHOJEH(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1149f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1381f, 905f));
	}

	// Token: 0x06003FC5 RID: 16325 RVA: 0x001D3146 File Offset: 0x001D1346
	private void MJMMOFELPBM()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.IKGFHGKKCPG.reelTensionCurve;
		}
	}

	// Token: 0x06003FC6 RID: 16326 RVA: 0x001D310A File Offset: 0x001D130A
	public void JMOMIODJCJC()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FC7 RID: 16327 RVA: 0x001D34C1 File Offset: 0x001D16C1
	public float NKKKDJBNPKK(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1228f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 942f, 45f));
	}

	// Token: 0x06003FC8 RID: 16328 RVA: 0x001D34F0 File Offset: 0x001D16F0
	private void IANJLHIIGLN()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FC9 RID: 16329 RVA: 0x001D353D File Offset: 0x001D173D
	public float FKJOGLAFLPM(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 51f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1407f, 739f));
	}

	// Token: 0x06003FCA RID: 16330 RVA: 0x001D356C File Offset: 0x001D176C
	private void Update()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FCB RID: 16331 RVA: 0x001D35B9 File Offset: 0x001D17B9
	public float MNGMJLHGEBH(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1829f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1102f, 1326f));
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x001D35E5 File Offset: 0x001D17E5
	public float EHEBBHDCFHH(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 47f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1022f, 195f));
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x001D3146 File Offset: 0x001D1346
	private void COOHBKKNOLG()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.IKGFHGKKCPG.reelTensionCurve;
		}
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x001D310A File Offset: 0x001D130A
	public void MBMFHPHLGFD()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x001D310A File Offset: 0x001D130A
	public void MMLLMJLPKHA()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x001D310A File Offset: 0x001D130A
	public void KEHCGKCGJOC()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FD1 RID: 16337 RVA: 0x001D3611 File Offset: 0x001D1811
	public float JNKDLHKPLAI(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 494f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1067f, 1013f));
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x001D363D File Offset: 0x001D183D
	private void LPDIHACCGKK()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x06003FD3 RID: 16339 RVA: 0x001D310A File Offset: 0x001D130A
	public void LDMGPOEBFBF()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FD4 RID: 16340 RVA: 0x001D3657 File Offset: 0x001D1857
	public float POGNOMCDIPB(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 289f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 524f, 587f));
	}

	// Token: 0x06003FD5 RID: 16341 RVA: 0x001D310A File Offset: 0x001D130A
	public void DNIKPLLKALO()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FD6 RID: 16342 RVA: 0x001D310A File Offset: 0x001D130A
	public void NPBIJDPDHNM()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FD7 RID: 16343 RVA: 0x001D3683 File Offset: 0x001D1883
	public float GGPLIDMMKLH(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 123f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1549f, 1540f));
	}

	// Token: 0x06003FD8 RID: 16344 RVA: 0x001D32ED File Offset: 0x001D14ED
	private void OGKKCIOKGJE()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.PLGADNLAEGN().reelTensionCurve;
		}
	}

	// Token: 0x06003FD9 RID: 16345 RVA: 0x001D310A File Offset: 0x001D130A
	public void NGMBBKOMLOG()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FDA RID: 16346 RVA: 0x001D36AF File Offset: 0x001D18AF
	public float NANGEDNOKJL(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 973f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 148f, 1369f));
	}

	// Token: 0x06003FDB RID: 16347 RVA: 0x001D3146 File Offset: 0x001D1346
	private void BJDEMJIEKGD()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.IKGFHGKKCPG.reelTensionCurve;
		}
	}

	// Token: 0x06003FDC RID: 16348 RVA: 0x001D36DB File Offset: 0x001D18DB
	public float PPPBDNFGHBH(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 204f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 301f, 453f));
	}

	// Token: 0x06003FDD RID: 16349 RVA: 0x001D3307 File Offset: 0x001D1507
	private void NPKEBODNBAI()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x06003FDE RID: 16350 RVA: 0x001D3708 File Offset: 0x001D1908
	private void HMLNMHOMMNO()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FDF RID: 16351 RVA: 0x001D310A File Offset: 0x001D130A
	public void MOAEFEONJCN()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FE0 RID: 16352 RVA: 0x001D3755 File Offset: 0x001D1955
	public float INAJECPEEKL(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 805f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 615f, 243f));
	}

	// Token: 0x06003FE1 RID: 16353 RVA: 0x001D3784 File Offset: 0x001D1984
	private void EMFOECIPBIP()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FE2 RID: 16354 RVA: 0x001D310A File Offset: 0x001D130A
	public void BMFKCAMANOL()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FE3 RID: 16355 RVA: 0x001D37D4 File Offset: 0x001D19D4
	private void EDEODHDFANE()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x001D3824 File Offset: 0x001D1A24
	private void JFGGBEGNAFP()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FE5 RID: 16357 RVA: 0x001D3871 File Offset: 0x001D1A71
	public float PMGBFMKHDOD(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1450f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1255f, 952f));
	}

	// Token: 0x06003FE6 RID: 16358 RVA: 0x001D389D File Offset: 0x001D1A9D
	public float CGINCIJEBMG(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1399f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 598f, 36f));
	}

	// Token: 0x06003FE7 RID: 16359 RVA: 0x001D310A File Offset: 0x001D130A
	public void MFKDLOMGFEL()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FE8 RID: 16360 RVA: 0x001D38CC File Offset: 0x001D1ACC
	private void ACEODGIJKFH()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FE9 RID: 16361 RVA: 0x001D3919 File Offset: 0x001D1B19
	public float BGEDJNCNEFL(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 525f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1961f, 1756f));
	}

	// Token: 0x06003FEA RID: 16362 RVA: 0x001D3945 File Offset: 0x001D1B45
	public float GICPJLIGALL(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1207f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1203f, 1439f));
	}

	// Token: 0x06003FEB RID: 16363 RVA: 0x001D310A File Offset: 0x001D130A
	public void AMCPNKBAAFA()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FEC RID: 16364 RVA: 0x001D3146 File Offset: 0x001D1346
	private void OGKOHLPFBED()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.IKGFHGKKCPG.reelTensionCurve;
		}
	}

	// Token: 0x06003FED RID: 16365 RVA: 0x001D310A File Offset: 0x001D130A
	public void HPBEHCFNKOA()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FEE RID: 16366 RVA: 0x001D3974 File Offset: 0x001D1B74
	private void HONIFOPBBKC()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FEF RID: 16367 RVA: 0x001D310A File Offset: 0x001D130A
	public void BPGNEBEIHID()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FF0 RID: 16368 RVA: 0x001D39C4 File Offset: 0x001D1BC4
	private void KLFPOILLKDF()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FF1 RID: 16369 RVA: 0x001D3A11 File Offset: 0x001D1C11
	public float CIMNBELFMJB(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 103f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 311f, 1095f));
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x001D3146 File Offset: 0x001D1346
	private void IJHHOLCHNNP()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.IKGFHGKKCPG.reelTensionCurve;
		}
	}

	// Token: 0x06003FF3 RID: 16371 RVA: 0x001D363D File Offset: 0x001D183D
	private void KKBJCEMFEEI()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x06003FF4 RID: 16372 RVA: 0x001D3A3D File Offset: 0x001D1C3D
	public float DEPDEIHOJHG(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1326f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 252f, 1331f));
	}

	// Token: 0x06003FF5 RID: 16373 RVA: 0x001D310A File Offset: 0x001D130A
	public void FMNNPJNGGBA()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FF6 RID: 16374 RVA: 0x001D3A6C File Offset: 0x001D1C6C
	private void EGAEDOHFAJE()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FF7 RID: 16375 RVA: 0x001D363D File Offset: 0x001D183D
	private void CFGOEFIKLJB()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x06003FF8 RID: 16376 RVA: 0x001D3AB9 File Offset: 0x001D1CB9
	public float CEBFCBGBHHG(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 922f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 741f, 629f));
	}

	// Token: 0x06003FF9 RID: 16377 RVA: 0x001D310A File Offset: 0x001D130A
	[ContextMenu("*** init components")]
	public void InitPos()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FFA RID: 16378 RVA: 0x001D3AE8 File Offset: 0x001D1CE8
	private void MIFLHGMPLJD()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FFB RID: 16379 RVA: 0x001D310A File Offset: 0x001D130A
	public void KIPNJPIGLEE()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06003FFC RID: 16380 RVA: 0x001D3B35 File Offset: 0x001D1D35
	public float GDBGAKKOOCA(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1578f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1724f, 1212f));
	}

	// Token: 0x06003FFD RID: 16381 RVA: 0x001D363D File Offset: 0x001D183D
	private void FKLDKPEDDDM()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x06003FFE RID: 16382 RVA: 0x001D3B64 File Offset: 0x001D1D64
	private void LFJHDHPJOPE()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06003FFF RID: 16383 RVA: 0x001D32ED File Offset: 0x001D14ED
	private void DIENOIPCCDE()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.PLGADNLAEGN().reelTensionCurve;
		}
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x001D3BB4 File Offset: 0x001D1DB4
	private void BLMBPFIJJBP()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004001 RID: 16385 RVA: 0x001D3307 File Offset: 0x001D1507
	private void EBNINOBOAII()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x06004002 RID: 16386 RVA: 0x001D3307 File Offset: 0x001D1507
	private void AKGBDJDMOLC()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x06004003 RID: 16387 RVA: 0x001D3C01 File Offset: 0x001D1E01
	public float HDFJHALGEHP(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1464f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1232f, 1206f));
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x001D3C2D File Offset: 0x001D1E2D
	public float EHNEMLBBHAP(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 340f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 369f, 64f));
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x001D3C5C File Offset: 0x001D1E5C
	private void HJCLNJLADKL()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x001D3CAC File Offset: 0x001D1EAC
	private void KMPEBHIPKJH()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004007 RID: 16391 RVA: 0x001D3CF9 File Offset: 0x001D1EF9
	public float speedEvalute(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 0f, 1f));
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x001D3D25 File Offset: 0x001D1F25
	public float KBJEJDJDCPC(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 785f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1141f, 393f));
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x001D3D54 File Offset: 0x001D1F54
	private void PMKOAHMNBBG()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x001D3DA1 File Offset: 0x001D1FA1
	public float PIHEABDMJJG(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 774f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1204f, 1232f));
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x001D3DD0 File Offset: 0x001D1FD0
	private void GDBBAMFMKII()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x0600400C RID: 16396 RVA: 0x001D3307 File Offset: 0x001D1507
	private void EIOCCLJPLHN()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x001D3E1D File Offset: 0x001D201D
	public float ELNDGAABMML(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 495f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1213f, 432f));
	}

	// Token: 0x0600400E RID: 16398 RVA: 0x001D363D File Offset: 0x001D183D
	private void HHOACKALPHC()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x001D3E4C File Offset: 0x001D204C
	private void HFPPENPGGAI()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x001D3E99 File Offset: 0x001D2099
	public float PFMELNBHDDK(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1272f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 596f, 1165f));
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x001D3307 File Offset: 0x001D1507
	private void PPNOJNBFHAP()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x001D3EC5 File Offset: 0x001D20C5
	public float FCADJCNNPKC(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 805f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1702f, 417f));
	}

	// Token: 0x06004013 RID: 16403 RVA: 0x001D3EF1 File Offset: 0x001D20F1
	public float FJNOMPGCBON(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1145f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 1864f, 1179f));
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x001D3F20 File Offset: 0x001D2120
	private void KEBDEJIAODF()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x001D310A File Offset: 0x001D130A
	public void LFEENJNPHAB()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x001D3F6D File Offset: 0x001D216D
	public float PAEIBAIJOKF(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 386f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 660f, 1329f));
	}

	// Token: 0x06004017 RID: 16407 RVA: 0x001D310A File Offset: 0x001D130A
	public void LCMABGFFJAL()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004018 RID: 16408 RVA: 0x001D310A File Offset: 0x001D130A
	public void DPIEPMCJBMD()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x001D310A File Offset: 0x001D130A
	public void KBOLBBPDFCP()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x0600401A RID: 16410 RVA: 0x001D363D File Offset: 0x001D183D
	private void MEFNEIGMKJO()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x0600401B RID: 16411 RVA: 0x001D3F9C File Offset: 0x001D219C
	private void LBOONMDONCF()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x0600401C RID: 16412 RVA: 0x001D3FEC File Offset: 0x001D21EC
	private void BEDAJLJFAFO()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x0600401D RID: 16413 RVA: 0x001D32ED File Offset: 0x001D14ED
	private void JCMBBMFDBAI()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.PLGADNLAEGN().reelTensionCurve;
		}
	}

	// Token: 0x0600401E RID: 16414 RVA: 0x001D403C File Offset: 0x001D223C
	private void LACNPNKHCAA()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x0600401F RID: 16415 RVA: 0x001D310A File Offset: 0x001D130A
	public void IAIOHAINBJO()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004020 RID: 16416 RVA: 0x001D310A File Offset: 0x001D130A
	public void IJIMHEOKBBH()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004021 RID: 16417 RVA: 0x001D363D File Offset: 0x001D183D
	private void HIBOODJBCIE()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x06004022 RID: 16418 RVA: 0x001D310A File Offset: 0x001D130A
	public void NMHPNOIPPLB()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004023 RID: 16419 RVA: 0x001D363D File Offset: 0x001D183D
	private void OKCPKBGDFJH()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x001D310A File Offset: 0x001D130A
	public void OHEKIDEMNEE()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x001D408C File Offset: 0x001D228C
	private void HMGBHPPNEMP()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x001D363D File Offset: 0x001D183D
	private void IMHFPANDMNN()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x001D40DC File Offset: 0x001D22DC
	private void AKLFCMNCPKL()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x001D412C File Offset: 0x001D232C
	private void EINLCOFCLLC()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x001D3307 File Offset: 0x001D1507
	private void FDGKKBGHNIN()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x0600402A RID: 16426 RVA: 0x001D363D File Offset: 0x001D183D
	private void FLHMNMBHIDD()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.NKOEAPCIBKO().reelTensionCurve;
		}
	}

	// Token: 0x0600402B RID: 16427 RVA: 0x001D310A File Offset: 0x001D130A
	public void NFLMCIKCCFC()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x0600402C RID: 16428 RVA: 0x001D417C File Offset: 0x001D237C
	private void KJJEEMEHGBF()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x0600402D RID: 16429 RVA: 0x001D41CC File Offset: 0x001D23CC
	private void PNBGJBMJLFM()
	{
		if (this.spulaRollPoint != null)
		{
			this.spulaRollPoint.transform.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, this.shpulaPositionCurve.Evaluate(this.shpulaRange));
		}
	}

	// Token: 0x0600402E RID: 16430 RVA: 0x001D310A File Offset: 0x001D130A
	public void EBMBNGHJKDD()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x0600402F RID: 16431 RVA: 0x001D4219 File Offset: 0x001D2419
	public float HBJHIHDDINN(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 1268f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 573f, 417f));
	}

	// Token: 0x06004030 RID: 16432 RVA: 0x001D3307 File Offset: 0x001D1507
	private void AEJLGHDKHHE()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x06004031 RID: 16433 RVA: 0x001D4245 File Offset: 0x001D2445
	public float KMFGMBDPJGD(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 11f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 870f, 1005f));
	}

	// Token: 0x06004032 RID: 16434 RVA: 0x001D310A File Offset: 0x001D130A
	public void IPFJLMBBOKB()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004033 RID: 16435 RVA: 0x001D310A File Offset: 0x001D130A
	public void PPECPCFFPIB()
	{
		if (this.spulaRollPoint != null)
		{
			this.startPosition = this.spulaRollPoint.transform.localPosition;
			this.endPosition = this.spulaRollPoint.transform.localPosition;
		}
	}

	// Token: 0x06004034 RID: 16436 RVA: 0x001D3307 File Offset: 0x001D1507
	private void KDMCOLGDFLD()
	{
		if (!this.isCurveInit)
		{
			this.rollSpeedCurve = GuiProcessor.BBLINJLBAIL().reelTensionCurve;
		}
	}

	// Token: 0x06004035 RID: 16437 RVA: 0x001D4271 File Offset: 0x001D2471
	public float FHFOEPJGFCL(float BCFNIMCEEAG)
	{
		if (float.IsNaN(BCFNIMCEEAG))
		{
			BCFNIMCEEAG = 603f;
		}
		return this.rollSpeedCurve.Evaluate(Mathf.Clamp(BCFNIMCEEAG, 156f, 169f));
	}

	// Token: 0x04000944 RID: 2372
	public GameObject linePoint;

	// Token: 0x04000945 RID: 2373
	public GameObject linePointEnd;

	// Token: 0x04000946 RID: 2374
	public GameObject rollPoint;

	// Token: 0x04000947 RID: 2375
	public GameObject handPoint;

	// Token: 0x04000948 RID: 2376
	public GameObject barabanRollPoint;

	// Token: 0x04000949 RID: 2377
	public GameObject spulaRollPoint;

	// Token: 0x0400094A RID: 2378
	public GameObject lineBaraban;

	// Token: 0x0400094B RID: 2379
	public Vector3 barEuler = new Vector3(1f, 0f, 0f);

	// Token: 0x0400094C RID: 2380
	public Vector3 rollEuler = new Vector3(1f, 0f, 0f);

	// Token: 0x0400094D RID: 2381
	public Vector3 shpulaEuler = new Vector3(1f, 0f, 0f);

	// Token: 0x0400094E RID: 2382
	[Range(0f, 1f)]
	public float shpulaRange;

	// Token: 0x0400094F RID: 2383
	public AnimationCurve shpulaPositionCurve;

	// Token: 0x04000950 RID: 2384
	public Vector3 startPosition;

	// Token: 0x04000951 RID: 2385
	public Vector3 endPosition;

	// Token: 0x04000952 RID: 2386
	public AnimationCurve rollSpeedCurve;

	// Token: 0x04000953 RID: 2387
	public bool isCurveInit;

	// Token: 0x04000954 RID: 2388
	public float barabanSpeed = 1f;
}
