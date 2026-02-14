using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

// Token: 0x02000026 RID: 38
public class AntaresInterpolator : MonoBehaviour
{
	// Token: 0x060006BD RID: 1725 RVA: 0x00046E8C File Offset: 0x0004508C
	private void ANLDPONOPLE()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, ~(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.FlattenHierarchy));
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00046ECC File Offset: 0x000450CC
	private void IIGGBPLNEEP()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, ~(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic));
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00046F09 File Offset: 0x00045109
	public void NMMHIFFIFAL()
	{
		if (Application.isPlaying)
		{
			this.KFNFNGGIPAC();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00046F35 File Offset: 0x00045135
	public void ABHMIBGKGGM()
	{
		if (Application.isPlaying)
		{
			this.JAAHNFLFKOC();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00046F64 File Offset: 0x00045164
	private void OEFOJEKHGOJ()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00046FA1 File Offset: 0x000451A1
	public void DDFFBNBIACP()
	{
		if (Application.isPlaying)
		{
			this.HGKCFDJEJPM();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00046FCD File Offset: 0x000451CD
	public float GetCurrentTimeForEditor()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00046FD5 File Offset: 0x000451D5
	public float JOHFBEBFMAA(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 159f;
		}
		if (this.ADHJJILPOJB != 1189f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x0004700A File Offset: 0x0004520A
	private void EIPNBEHFGFJ()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 1994f;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00047024 File Offset: 0x00045224
	private void KGNJNMPCGEP()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, ~(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy));
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00047061 File Offset: 0x00045261
	private void JAAHNFLFKOC()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 1948f;
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00046FCD File Offset: 0x000451CD
	public float JAPOLKJPOLG()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x0004707B File Offset: 0x0004527B
	private void FDJKOJAOMPD()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = false;
		this.ADHJJILPOJB = 227f;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00047095 File Offset: 0x00045295
	public float KCKKCLMMLOO(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1998f;
		}
		if (this.ADHJJILPOJB != 1147f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x000470CA File Offset: 0x000452CA
	private void GKJNOMMAAPO()
	{
		if (this.target == null)
		{
			Debug.Log("_TrNewLider.ogg");
			return;
		}
		this.FHNPMFLPFFF();
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x000470EB File Offset: 0x000452EB
	private IEnumerator PODIIEJNMIC()
	{
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 0f;
		float num = Time.realtimeSinceStartup + this.curve.keys[this.curve.keys.Length - 1].time;
		while (Time.realtimeSinceStartup <= num)
		{
			yield return null;
			this.ADHJJILPOJB += Time.deltaTime;
		}
		this.IOJLGANNHMG = false;
		yield break;
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x000470FA File Offset: 0x000452FA
	private IEnumerator PIOKEPMBOKD()
	{
		AntaresInterpolator.NMPDNOCELMN nmpdnocelmn = new AntaresInterpolator.NMPDNOCELMN(1);
		nmpdnocelmn.AENJLLPLILM = this;
		return nmpdnocelmn;
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00047109 File Offset: 0x00045309
	public void CIBPJDHPIDH()
	{
		if (Application.isPlaying)
		{
			this.NKCEDIHPEGM();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00047135 File Offset: 0x00045335
	public float EvaluateAutomatically()
	{
		if (this.curve == null)
		{
			return 0f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 0f)
		{
			base.StartCoroutine(this.DNABAPPAGFM());
		}
		return this.Evaluate(this.ADHJJILPOJB);
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00047173 File Offset: 0x00045373
	public float PFDIPJBEFAO(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 642f;
		}
		if (this.ADHJJILPOJB != 1830f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x000470EB File Offset: 0x000452EB
	private IEnumerator LJIFDINGOMJ()
	{
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 0f;
		num = Time.realtimeSinceStartup + this.curve.keys[this.curve.keys.Length - 1].time;
		while (Time.realtimeSinceStartup <= num)
		{
			yield return null;
			this.ADHJJILPOJB += Time.deltaTime;
		}
		this.IOJLGANNHMG = false;
		yield break;
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x000471A8 File Offset: 0x000453A8
	private void ECOOMJKPKCC()
	{
		if (this.target == null)
		{
			Debug.Log("ProneIdle");
			return;
		}
		this.KGNJNMPCGEP();
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x000471CC File Offset: 0x000453CC
	private void GANCKNCHPDD()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, ~(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy));
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00046FCD File Offset: 0x000451CD
	public float FHDLPDECCNO()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00047209 File Offset: 0x00045409
	public float KLFMDKBFILF(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 795f;
		}
		if (this.ADHJJILPOJB != 101f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x000470FA File Offset: 0x000452FA
	private IEnumerator NJILCEJDFFA()
	{
		AntaresInterpolator.NMPDNOCELMN nmpdnocelmn = new AntaresInterpolator.NMPDNOCELMN(1);
		nmpdnocelmn.AENJLLPLILM = this;
		return nmpdnocelmn;
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x0004723E File Offset: 0x0004543E
	public float ELFIIJNELLB(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1669f;
		}
		if (this.ADHJJILPOJB != 248f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00047274 File Offset: 0x00045474
	private void EAKGHCJIPCG()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, ~(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy));
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x000472B1 File Offset: 0x000454B1
	private void HEBGFFJFEJJ()
	{
		if (this.target == null)
		{
			Debug.Log("WalkDehydrated");
			return;
		}
		this.JEMLMBHPBKC();
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00046FCD File Offset: 0x000451CD
	public float BLGDAHCFNGH()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x000472D2 File Offset: 0x000454D2
	public float KJAOFLJLHLI(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 110f;
		}
		if (this.ADHJJILPOJB != 316f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00047307 File Offset: 0x00045507
	public float GNJMGAGOPFI(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1755f;
		}
		if (this.ADHJJILPOJB != 158f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x0004733C File Offset: 0x0004553C
	private void LDNANDGCNBL()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00047379 File Offset: 0x00045579
	public float DAIENFMAMDJ()
	{
		if (this.curve == null)
		{
			return 246f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 847f)
		{
			base.StartCoroutine(this.LJIFDINGOMJ());
		}
		return this.Evaluate(this.ADHJJILPOJB);
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x000473B7 File Offset: 0x000455B7
	public float PCKPONHNNBI()
	{
		if (this.curve == null)
		{
			return 1582f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 1552f)
		{
			base.StartCoroutine(this.DNBAAGEAGPJ());
		}
		return this.GHEPCMJOJNO(this.ADHJJILPOJB);
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x000473F8 File Offset: 0x000455F8
	private void GAGMCPAIJEG()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00047435 File Offset: 0x00045635
	public float NHKEFHIAAFL(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 883f;
		}
		if (this.ADHJJILPOJB != 1779f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x0004746A File Offset: 0x0004566A
	private void AHILDBJHCKI()
	{
		if (this.target == null)
		{
			Debug.Log("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
			return;
		}
		this.JEMLMBHPBKC();
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x000470FA File Offset: 0x000452FA
	private IEnumerator NOICMIMAHCB()
	{
		AntaresInterpolator.NMPDNOCELMN nmpdnocelmn = new AntaresInterpolator.NMPDNOCELMN(1);
		nmpdnocelmn.AENJLLPLILM = this;
		return nmpdnocelmn;
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x000470EB File Offset: 0x000452EB
	private IEnumerator DNABAPPAGFM()
	{
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 0f;
		num = Time.realtimeSinceStartup + this.curve.keys[this.curve.keys.Length - 1].time;
		while (Time.realtimeSinceStartup <= num)
		{
			yield return null;
			this.ADHJJILPOJB += Time.deltaTime;
		}
		this.IOJLGANNHMG = false;
		yield break;
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x0004749E File Offset: 0x0004569E
	private void LBKPJAJJLBH()
	{
		if (this.target == null)
		{
			Debug.Log("Vertical");
			return;
		}
		this.OEFOJEKHGOJ();
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00046FCD File Offset: 0x000451CD
	public float AHHGHOJBHLM()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x000474BF File Offset: 0x000456BF
	public float HEMDLJEHPKP(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1022f;
		}
		if (this.ADHJJILPOJB != 1628f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x000474F4 File Offset: 0x000456F4
	private void CGCGKIFGFAO()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = false;
		this.ADHJJILPOJB = 1282f;
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x0004750E File Offset: 0x0004570E
	public float NBJMJGJINAD()
	{
		if (this.curve == null)
		{
			return 1245f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 88f)
		{
			base.StartCoroutine(this.PMHKMNNOBKE());
		}
		return this.DACMEEPLHBJ(this.ADHJJILPOJB);
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00047109 File Offset: 0x00045309
	public void EPLEHFCNKDJ()
	{
		if (Application.isPlaying)
		{
			this.NKCEDIHPEGM();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00046F09 File Offset: 0x00045109
	public void Reset()
	{
		if (Application.isPlaying)
		{
			this.KFNFNGGIPAC();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x0004754C File Offset: 0x0004574C
	private void EBNINOBOAII()
	{
		if (this.target == null)
		{
			Debug.Log("Staff Power Up");
			return;
		}
		this.GANCKNCHPDD();
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x0004756D File Offset: 0x0004576D
	public void BEOEJEGGCII()
	{
		if (Application.isPlaying)
		{
			this.GBGJLLGPDED();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00046FCD File Offset: 0x000451CD
	public float PIAMKFPINCP()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00047599 File Offset: 0x00045799
	private void COOHBKKNOLG()
	{
		if (this.target == null)
		{
			Debug.Log("2000");
			return;
		}
		this.GJDDILLKKKE();
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x000475BA File Offset: 0x000457BA
	public float HLJFEALAHDP()
	{
		if (this.curve == null)
		{
			return 99f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 1585f)
		{
			base.StartCoroutine(this.NJILCEJDFFA());
		}
		return this.Evaluate(this.ADHJJILPOJB);
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00046FCD File Offset: 0x000451CD
	public float NAMJJMJGJAP()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x000475F8 File Offset: 0x000457F8
	public float NLKOGHBDCLF()
	{
		if (this.curve == null)
		{
			return 243f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 564f)
		{
			base.StartCoroutine(this.DNABAPPAGFM());
		}
		return this.ELFIIJNELLB(this.ADHJJILPOJB);
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00047636 File Offset: 0x00045836
	public float CPMJFMKFJOO(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1138f;
		}
		if (this.ADHJJILPOJB != 285f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x000470FA File Offset: 0x000452FA
	private IEnumerator BHJONPAPBLI()
	{
		AntaresInterpolator.NMPDNOCELMN nmpdnocelmn = new AntaresInterpolator.NMPDNOCELMN(1);
		nmpdnocelmn.AENJLLPLILM = this;
		return nmpdnocelmn;
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x0004766C File Offset: 0x0004586C
	private void OOABNCNPIEE()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.NonPublic);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00046FCD File Offset: 0x000451CD
	public float HOCKCIAEOJG()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x000476A9 File Offset: 0x000458A9
	private void HGKCFDJEJPM()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = false;
		this.ADHJJILPOJB = 1878f;
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000470EB File Offset: 0x000452EB
	private IEnumerator PMHKMNNOBKE()
	{
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 0f;
		num = Time.realtimeSinceStartup + this.curve.keys[this.curve.keys.Length - 1].time;
		while (Time.realtimeSinceStartup <= num)
		{
			yield return null;
			this.ADHJJILPOJB += Time.deltaTime;
		}
		this.IOJLGANNHMG = false;
		yield break;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x000470FA File Offset: 0x000452FA
	private IEnumerator DNBAAGEAGPJ()
	{
		AntaresInterpolator.NMPDNOCELMN nmpdnocelmn = new AntaresInterpolator.NMPDNOCELMN(1);
		nmpdnocelmn.AENJLLPLILM = this;
		return nmpdnocelmn;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00046FCD File Offset: 0x000451CD
	public float PKNPKNIHFKB()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x000470EB File Offset: 0x000452EB
	private IEnumerator CHBFNLIGIGD()
	{
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 0f;
		num = Time.realtimeSinceStartup + this.curve.keys[this.curve.keys.Length - 1].time;
		while (Time.realtimeSinceStartup <= num)
		{
			yield return null;
			this.ADHJJILPOJB += Time.deltaTime;
		}
		this.IOJLGANNHMG = false;
		yield break;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x000476C3 File Offset: 0x000458C3
	private void Awake()
	{
		if (this.target == null)
		{
			Debug.Log("Interpolator has no target!");
			return;
		}
		this.PBPLJIABGAP();
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x000476E4 File Offset: 0x000458E4
	public float LGNNONFILCJ()
	{
		if (this.curve == null)
		{
			return 898f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 1689f)
		{
			base.StartCoroutine(this.DNBAAGEAGPJ());
		}
		return this.KJAOFLJLHLI(this.ADHJJILPOJB);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00046F09 File Offset: 0x00045109
	public void BPBHECJMLPN()
	{
		if (Application.isPlaying)
		{
			this.KFNFNGGIPAC();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00047724 File Offset: 0x00045924
	private void IEFHEHBIPKD()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, ~(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic));
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00047764 File Offset: 0x00045964
	private void FHNPMFLPFFF()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, ~(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000477A1 File Offset: 0x000459A1
	private void KKFKFGPMCND()
	{
		if (this.target == null)
		{
			Debug.Log("crft_konstr");
			return;
		}
		this.ANLDPONOPLE();
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x000477C4 File Offset: 0x000459C4
	private void JEMLMBHPBKC()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.IgnoreCase);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00047801 File Offset: 0x00045A01
	private void KFNFNGGIPAC()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = false;
		this.ADHJJILPOJB = 1000123f;
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x0004781B File Offset: 0x00045A1B
	public float Evaluate(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 0f;
		}
		if (this.ADHJJILPOJB != 1000123f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00046FCD File Offset: 0x000451CD
	public float EFIBJFOGPLM()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00047850 File Offset: 0x00045A50
	public float COHBEELLHAG(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 639f;
		}
		if (this.ADHJJILPOJB != 331f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00047885 File Offset: 0x00045A85
	private void JIIBCGJJLND()
	{
		if (this.target == null)
		{
			Debug.Log("[maxwgt]");
			return;
		}
		this.OOABNCNPIEE();
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x0004756D File Offset: 0x0004576D
	public void AIHEKMKAIGM()
	{
		if (Application.isPlaying)
		{
			this.GBGJLLGPDED();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x000478A6 File Offset: 0x00045AA6
	public float OPEHAHFPHNK(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1991f;
		}
		if (this.ADHJJILPOJB != 1015f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x000478DC File Offset: 0x00045ADC
	private void GJDDILLKKKE()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00047919 File Offset: 0x00045B19
	public float GHEPCMJOJNO(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1518f;
		}
		if (this.ADHJJILPOJB != 1370f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00047950 File Offset: 0x00045B50
	private void NFGEFFPLJKE()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00046FA1 File Offset: 0x000451A1
	public void PPINAGDCFNL()
	{
		if (Application.isPlaying)
		{
			this.HGKCFDJEJPM();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00047990 File Offset: 0x00045B90
	private void JIBDFDAIFDB()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00046FCD File Offset: 0x000451CD
	public float MEADPKKGELM()
	{
		return this.ABANBMKEIFE;
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x000479CD File Offset: 0x00045BCD
	public float NMJIOBMIFFE()
	{
		if (this.curve == null)
		{
			return 90f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 657f)
		{
			base.StartCoroutine(this.DNBAAGEAGPJ());
		}
		return this.COHBEELLHAG(this.ADHJJILPOJB);
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00047A0C File Offset: 0x00045C0C
	private void PBPLJIABGAP()
	{
		FieldInfo field = this.target.GetType().GetField(this.fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (field == null)
		{
			return;
		}
		field.SetValue(this.target, this);
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00047A49 File Offset: 0x00045C49
	public float DACMEEPLHBJ(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1599f;
		}
		if (this.ADHJJILPOJB != 22f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00047A7E File Offset: 0x00045C7E
	public float CJLOOINGGMD()
	{
		if (this.curve == null)
		{
			return 690f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 866f)
		{
			base.StartCoroutine(this.LJIFDINGOMJ());
		}
		return this.GFAIAKLEGGP(this.ADHJJILPOJB);
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00046F35 File Offset: 0x00045135
	public void FOFNPGIHJGD()
	{
		if (Application.isPlaying)
		{
			this.JAAHNFLFKOC();
			return;
		}
		this.target = null;
		this.sourceClip = null;
		this.curve = null;
		this.fieldName = null;
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00047ABC File Offset: 0x00045CBC
	public float GFAIAKLEGGP(float GDNOKEOLBPP)
	{
		if (this.curve == null)
		{
			return 1593f;
		}
		if (this.ADHJJILPOJB != 455f)
		{
			this.ABANBMKEIFE = this.ADHJJILPOJB;
		}
		return this.curve.Evaluate(GDNOKEOLBPP);
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00047AF1 File Offset: 0x00045CF1
	public float NKIECOGPEDD()
	{
		if (this.curve == null)
		{
			return 537f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 1026f)
		{
			base.StartCoroutine(this.DNABAPPAGFM());
		}
		return this.NHKEFHIAAFL(this.ADHJJILPOJB);
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00047B2F File Offset: 0x00045D2F
	private void NKCEDIHPEGM()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 1755f;
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00047B49 File Offset: 0x00045D49
	private void AOLBGAGHJDO()
	{
		if (this.target == null)
		{
			Debug.Log("OfficeSittingReadingPageFlip");
			return;
		}
		this.GAGMCPAIJEG();
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00047B6A File Offset: 0x00045D6A
	private void PPNOJNBFHAP()
	{
		if (this.target == null)
		{
			Debug.Log("stacheadererror");
			return;
		}
		this.IEFHEHBIPKD();
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00047B8B File Offset: 0x00045D8B
	private void GBGJLLGPDED()
	{
		base.StopAllCoroutines();
		this.IOJLGANNHMG = true;
		this.ADHJJILPOJB = 772f;
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00047BA5 File Offset: 0x00045DA5
	public float AEGPCDEEFCJ()
	{
		if (this.curve == null)
		{
			return 1859f;
		}
		if (!this.IOJLGANNHMG && this.ADHJJILPOJB > 1025f)
		{
			base.StartCoroutine(this.LJIFDINGOMJ());
		}
		return this.ELFIIJNELLB(this.ADHJJILPOJB);
	}

	// Token: 0x040000EC RID: 236
	public Component target;

	// Token: 0x040000ED RID: 237
	public AnimationClip sourceClip;

	// Token: 0x040000EE RID: 238
	public AnimationCurve curve;

	// Token: 0x040000EF RID: 239
	public string fieldName;

	// Token: 0x040000F0 RID: 240
	public float interpolationValue;

	// Token: 0x040000F1 RID: 241
	private bool IOJLGANNHMG;

	// Token: 0x040000F2 RID: 242
	private float ADHJJILPOJB = 1000123f;

	// Token: 0x040000F3 RID: 243
	private float ABANBMKEIFE;
}
