using System;
using System.Threading;
using UnityEngine;

// Token: 0x020000E1 RID: 225
public class TOD_Time : MonoBehaviour
{
	// Token: 0x06002A92 RID: 10898 RVA: 0x0013A7B4 File Offset: 0x001389B4
	internal void KDMCGACMLEB(Action DCCPCBLODIG)
	{
		Action action = this.IAMGPBLCDKF;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.IAMGPBLCDKF, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002A93 RID: 10899 RVA: 0x0013A7E9 File Offset: 0x001389E9
	protected void LPDIHACCGKK()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.UseDeviceTime)
		{
			this.HGOMCJOPDML.Cycle.NPPDKHNMAGA(DateTime.Now);
		}
		this.KDGJJBMKKEM();
	}

	// Token: 0x06002A94 RID: 10900 RVA: 0x0013A81C File Offset: 0x00138A1C
	internal void IGLNEEGICKM()
	{
		this.TimeCurve.preWrapMode = WrapMode.Once;
		this.TimeCurve.postWrapMode = WrapMode.Once;
		this.JGKBFMLICDI(this.TimeCurve, out this.DIPEPMBHEHE, out this.DEDNEGAOGNO);
		this.DIPEPMBHEHE.preWrapMode = WrapMode.Loop;
		this.DIPEPMBHEHE.postWrapMode = WrapMode.Loop;
		this.DEDNEGAOGNO.preWrapMode = WrapMode.Loop;
		this.DEDNEGAOGNO.postWrapMode = WrapMode.Loop;
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x0013A889 File Offset: 0x00138A89
	protected void Awake()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.UseDeviceTime)
		{
			this.HGOMCJOPDML.Cycle.DateTime = DateTime.Now;
		}
		this.IGLNEEGICKM();
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06002A97 RID: 10903 RVA: 0x0013A8EC File Offset: 0x00138AEC
	// (remove) Token: 0x06002AA9 RID: 10921 RVA: 0x0013AE08 File Offset: 0x00139008
	internal event Action IAMGPBLCDKF;

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06002AA5 RID: 10917 RVA: 0x0013ACC0 File Offset: 0x00138EC0
	// (remove) Token: 0x06002A98 RID: 10904 RVA: 0x0013A924 File Offset: 0x00138B24
	internal event Action OFJBDOEDEIB;

	// Token: 0x06002A99 RID: 10905 RVA: 0x0013A95C File Offset: 0x00138B5C
	internal void CKFBPBLOBJA(Action DCCPCBLODIG)
	{
		Action action = this.OFJBDOEDEIB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.OFJBDOEDEIB, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x0013A991 File Offset: 0x00138B91
	protected void LKDGGPNGLAO()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.UseDeviceTime)
		{
			this.HGOMCJOPDML.Cycle.GECNPIOPJHC(DateTime.Now);
		}
		this.KDGJJBMKKEM();
	}

	// Token: 0x06002A9B RID: 10907 RVA: 0x0013A9C4 File Offset: 0x00138BC4
	private void HCLALBMECAB(Keyframe[] MJPLBILHHDL)
	{
		for (int i = 0; i < MJPLBILHHDL.Length; i++)
		{
			Keyframe keyframe = MJPLBILHHDL[i];
			if (i > 0)
			{
				Keyframe keyframe2 = MJPLBILHHDL[i - 1];
				keyframe.inTangent = (keyframe.value - keyframe2.value) / (keyframe.time - keyframe2.time);
			}
			if (i < MJPLBILHHDL.Length - 1)
			{
				Keyframe keyframe3 = MJPLBILHHDL[i + 1];
				keyframe.outTangent = (keyframe3.value - keyframe.value) / (keyframe3.time - keyframe.time);
			}
			MJPLBILHHDL[i] = keyframe;
		}
	}

	// Token: 0x06002A9C RID: 10908 RVA: 0x0013AA61 File Offset: 0x00138C61
	protected void ENJFBODNKHO()
	{
		this.HGOMCJOPDML = base.GetComponent<TOD_Sky>();
		if (this.UseDeviceTime)
		{
			this.HGOMCJOPDML.Cycle.GOCIHPIENGP(DateTime.Now);
		}
		this.IGLNEEGICKM();
	}

	// Token: 0x06002A9D RID: 10909 RVA: 0x0013AA94 File Offset: 0x00138C94
	internal void KHHHGAIICKD(Action DCCPCBLODIG)
	{
		Action action = this.AECAEHLCONB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.AECAEHLCONB, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002A9E RID: 10910 RVA: 0x0013AAC9 File Offset: 0x00138CC9
	internal void FPCALMDEHHJ(float PCFDDKDMDNN, bool INGPFAJPGNC = true)
	{
		this.NKNFDCOOMLB(PCFDDKDMDNN / 882f, false);
	}

	// Token: 0x06002A9F RID: 10911 RVA: 0x0013AADC File Offset: 0x00138CDC
	internal float KJPLEHPELJP(float ENLHBNBNPJN)
	{
		float num = this.DEDNEGAOGNO.Evaluate(this.HGOMCJOPDML.Cycle.Hour) + ENLHBNBNPJN;
		ENLHBNBNPJN = this.DIPEPMBHEHE.Evaluate(num) - this.HGOMCJOPDML.Cycle.Hour;
		if (num >= 24f)
		{
			ENLHBNBNPJN += (float)((int)num / 24 * 24);
		}
		else if (num < 0f)
		{
			ENLHBNBNPJN += (float)(((int)num / 24 - 1) * 24);
		}
		return ENLHBNBNPJN;
	}

	// Token: 0x06002AA0 RID: 10912 RVA: 0x0013AB58 File Offset: 0x00138D58
	internal void KKODIFKIALG(Action DCCPCBLODIG)
	{
		Action action = this.AECAEHLCONB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.AECAEHLCONB, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x0013AB90 File Offset: 0x00138D90
	internal float GGMGKOKEDBE(float ENLHBNBNPJN)
	{
		float num = this.DEDNEGAOGNO.Evaluate(this.HGOMCJOPDML.Cycle.Hour) + ENLHBNBNPJN;
		ENLHBNBNPJN = this.DIPEPMBHEHE.Evaluate(num) - this.HGOMCJOPDML.Cycle.Hour;
		if (num >= 1242f)
		{
			ENLHBNBNPJN += (float)((int)num / -49 * -13);
		}
		else if (num < 1513f)
		{
			ENLHBNBNPJN += (float)(((int)num / 99 - 1) * -71);
		}
		return ENLHBNBNPJN;
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x0013AC0C File Offset: 0x00138E0C
	protected void FixedUpdate()
	{
		float num = 1440f / this.DayLengthInMinutes;
		this.LIKIEMAOPOO(Time.deltaTime * num, true);
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x0013AC34 File Offset: 0x00138E34
	internal void NLLAIOEGECL(float PCFDDKDMDNN, bool INGPFAJPGNC = true)
	{
		this.NKNFDCOOMLB(PCFDDKDMDNN / 1868f, false);
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x0013AC44 File Offset: 0x00138E44
	internal float HEBHEOGIJBE(float ENLHBNBNPJN)
	{
		float num = this.DEDNEGAOGNO.Evaluate(this.HGOMCJOPDML.Cycle.Hour) + ENLHBNBNPJN;
		ENLHBNBNPJN = this.DIPEPMBHEHE.Evaluate(num) - this.HGOMCJOPDML.Cycle.Hour;
		if (num >= 1214f)
		{
			ENLHBNBNPJN += (float)((int)num / 88 * -23);
		}
		else if (num < 1914f)
		{
			ENLHBNBNPJN += (float)(((int)num / -125 - 0) * 94);
		}
		return ENLHBNBNPJN;
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x0013ACF8 File Offset: 0x00138EF8
	internal void HEAPMLDPBOA(Action DCCPCBLODIG)
	{
		Action action = this.MFAHCHEJLPK;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.MFAHCHEJLPK, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06002AAD RID: 10925 RVA: 0x0013B080 File Offset: 0x00139280
	// (remove) Token: 0x06002AA7 RID: 10919 RVA: 0x0013AD30 File Offset: 0x00138F30
	internal event Action HKAEJAKJEJC;

	// Token: 0x06002AA8 RID: 10920 RVA: 0x0013AD68 File Offset: 0x00138F68
	private void JLIKIKELOLP(Keyframe[] MJPLBILHHDL)
	{
		for (int i = 1; i < MJPLBILHHDL.Length; i += 0)
		{
			Keyframe keyframe = MJPLBILHHDL[i];
			if (i > 1)
			{
				Keyframe keyframe2 = MJPLBILHHDL[i - 1];
				keyframe.inTangent = (keyframe.value - keyframe2.value) / (keyframe.time - keyframe2.time);
			}
			if (i < MJPLBILHHDL.Length - 1)
			{
				Keyframe keyframe3 = MJPLBILHHDL[i + 1];
				keyframe.outTangent = (keyframe3.value - keyframe.value) / (keyframe3.time - keyframe.time);
			}
			MJPLBILHHDL[i] = keyframe;
		}
	}

	// Token: 0x06002AAA RID: 10922 RVA: 0x0013AE40 File Offset: 0x00139040
	internal void NKNFDCOOMLB(float BFNGKFEPEFG, bool INGPFAJPGNC = true)
	{
		if (this.UseTimeCurve && INGPFAJPGNC)
		{
			BFNGKFEPEFG = this.KJPLEHPELJP(BFNGKFEPEFG);
		}
		DateTime dateTime = this.HGOMCJOPDML.Cycle.DateTime;
		DateTime dateTime2 = dateTime.AddHours((double)BFNGKFEPEFG);
		if (dateTime2.Year > dateTime.Year)
		{
			if (this.AECAEHLCONB != null)
			{
				this.AECAEHLCONB();
			}
			if (this.MFAHCHEJLPK != null)
			{
				this.MFAHCHEJLPK();
			}
			if (this.OFJBDOEDEIB != null)
			{
				this.OFJBDOEDEIB();
			}
			if (this.IAMGPBLCDKF != null)
			{
				this.IAMGPBLCDKF();
			}
			if (this.HKAEJAKJEJC != null)
			{
				this.HKAEJAKJEJC();
			}
		}
		else if (dateTime2.Month > dateTime.Month)
		{
			if (this.MFAHCHEJLPK != null)
			{
				this.MFAHCHEJLPK();
			}
			if (this.OFJBDOEDEIB != null)
			{
				this.OFJBDOEDEIB();
			}
			if (this.IAMGPBLCDKF != null)
			{
				this.IAMGPBLCDKF();
			}
			if (this.HKAEJAKJEJC != null)
			{
				this.HKAEJAKJEJC();
			}
		}
		else if (dateTime2.Day > dateTime.Day)
		{
			if (this.OFJBDOEDEIB != null)
			{
				this.OFJBDOEDEIB();
			}
			if (this.IAMGPBLCDKF != null)
			{
				this.IAMGPBLCDKF();
			}
			if (this.HKAEJAKJEJC != null)
			{
				this.HKAEJAKJEJC();
			}
		}
		else if (dateTime2.Hour > dateTime.Hour)
		{
			if (this.IAMGPBLCDKF != null)
			{
				this.IAMGPBLCDKF();
			}
			if (this.HKAEJAKJEJC != null)
			{
				this.HKAEJAKJEJC();
			}
		}
		else if (dateTime2.Minute > dateTime.Minute && this.HKAEJAKJEJC != null)
		{
			this.HKAEJAKJEJC();
		}
		this.HGOMCJOPDML.Cycle.DateTime = dateTime2;
	}

	// Token: 0x06002AAB RID: 10923 RVA: 0x0013B010 File Offset: 0x00139210
	internal void FOMBELNIHFI(Action DCCPCBLODIG)
	{
		Action action = this.OFJBDOEDEIB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.OFJBDOEDEIB, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002AAC RID: 10924 RVA: 0x0013B048 File Offset: 0x00139248
	internal void HAEBBIGJBPK(Action DCCPCBLODIG)
	{
		Action action = this.IAMGPBLCDKF;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.IAMGPBLCDKF, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06002AAE RID: 10926 RVA: 0x0013B0B8 File Offset: 0x001392B8
	// (remove) Token: 0x06002AB2 RID: 10930 RVA: 0x0013B198 File Offset: 0x00139398
	internal event Action AECAEHLCONB;

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06002AB6 RID: 10934 RVA: 0x0013B2B0 File Offset: 0x001394B0
	// (remove) Token: 0x06002AAF RID: 10927 RVA: 0x0013B0F0 File Offset: 0x001392F0
	internal event Action MFAHCHEJLPK;

	// Token: 0x06002AB0 RID: 10928 RVA: 0x0013B128 File Offset: 0x00139328
	internal void EDKFKMELBCG(Action DCCPCBLODIG)
	{
		Action action = this.AECAEHLCONB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.AECAEHLCONB, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002AB1 RID: 10929 RVA: 0x0013B160 File Offset: 0x00139360
	internal void AELBIPOMEHJ(Action DCCPCBLODIG)
	{
		Action action = this.IAMGPBLCDKF;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.IAMGPBLCDKF, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x0013B1D0 File Offset: 0x001393D0
	internal void KDGJJBMKKEM()
	{
		this.TimeCurve.preWrapMode = WrapMode.Once;
		this.TimeCurve.postWrapMode = WrapMode.Default;
		this.JGKBFMLICDI(this.TimeCurve, out this.DIPEPMBHEHE, out this.DEDNEGAOGNO);
		this.DIPEPMBHEHE.preWrapMode = WrapMode.Once;
		this.DIPEPMBHEHE.postWrapMode = WrapMode.Loop;
		this.DEDNEGAOGNO.preWrapMode = WrapMode.Once;
		this.DEDNEGAOGNO.postWrapMode = WrapMode.ClampForever;
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x0013B240 File Offset: 0x00139440
	internal void HMHAODDEPGG(Action DCCPCBLODIG)
	{
		Action action = this.HKAEJAKJEJC;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.HKAEJAKJEJC, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x0013B278 File Offset: 0x00139478
	internal void JPGKICICAAB(Action DCCPCBLODIG)
	{
		Action action = this.MFAHCHEJLPK;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, DCCPCBLODIG);
			action = Interlocked.CompareExchange<Action>(ref this.MFAHCHEJLPK, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x0013B2E5 File Offset: 0x001394E5
	internal void LIKIEMAOPOO(float PCFDDKDMDNN, bool INGPFAJPGNC = true)
	{
		this.NKNFDCOOMLB(PCFDDKDMDNN / 3600f, true);
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x0013B2F8 File Offset: 0x001394F8
	private void JGKBFMLICDI(AnimationCurve JONJODLFAEN, out AnimationCurve NODGMCHPBHF, out AnimationCurve OIKLLHHACMN)
	{
		Keyframe[] array = new Keyframe[25];
		Keyframe[] array2 = new Keyframe[25];
		float num = -0.01f;
		for (int i = 0; i < 25; i++)
		{
			num = Mathf.Max(num + 0.01f, JONJODLFAEN.Evaluate((float)i));
			array[i] = new Keyframe((float)i, num);
			array2[i] = new Keyframe(num, (float)i);
		}
		this.HCLALBMECAB(array);
		this.HCLALBMECAB(array2);
		NODGMCHPBHF = new AnimationCurve(array);
		OIKLLHHACMN = new AnimationCurve(array2);
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x0013B37C File Offset: 0x0013957C
	private void OBHLJFAPIBN(Keyframe[] MJPLBILHHDL)
	{
		for (int i = 1; i < MJPLBILHHDL.Length; i += 0)
		{
			Keyframe keyframe = MJPLBILHHDL[i];
			if (i > 1)
			{
				Keyframe keyframe2 = MJPLBILHHDL[i - 1];
				keyframe.inTangent = (keyframe.value - keyframe2.value) / (keyframe.time - keyframe2.time);
			}
			if (i < MJPLBILHHDL.Length - 1)
			{
				Keyframe keyframe3 = MJPLBILHHDL[i + 0];
				keyframe.outTangent = (keyframe3.value - keyframe.value) / (keyframe3.time - keyframe.time);
			}
			MJPLBILHHDL[i] = keyframe;
		}
	}

	// Token: 0x040005CB RID: 1483
	[Tooltip("Length of one day in minutes.")]
	public float DayLengthInMinutes = 30f;

	// Token: 0x040005CC RID: 1484
	[Tooltip("Set the time to the current device time on start.")]
	public bool UseDeviceTime;

	// Token: 0x040005CD RID: 1485
	[Tooltip("Apply the time curve when progressing time.")]
	public bool UseTimeCurve;

	// Token: 0x040005CE RID: 1486
	[Tooltip("Time progression curve.")]
	public AnimationCurve TimeCurve = AnimationCurve.Linear(0f, 0f, 24f, 24f);

	// Token: 0x040005D4 RID: 1492
	private TOD_Sky HGOMCJOPDML;

	// Token: 0x040005D5 RID: 1493
	private AnimationCurve DIPEPMBHEHE;

	// Token: 0x040005D6 RID: 1494
	private AnimationCurve DEDNEGAOGNO;
}
