using System;
using UnityEngine;

// Token: 0x020000AF RID: 175
public class DemoUI : MonoBehaviour
{
	// Token: 0x0600255F RID: 9567 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void EHFPLKEINFO()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x00104D8C File Offset: 0x00102F8C
	private void EILPHLEBEJP()
	{
		GUI.Box(new Rect(301f, 1662f, 154f, 955f), "wpn_onlyw");
		GUI.BeginGroup(new Rect(535f, 1479f, 609f, 146f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "Idle Sand Cover", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "userForceMagnitude=", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)7;
		flag = GUILayout.Toggle(flag, "usercntinfo", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)5) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1456f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "Internal Curves Texture", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.High);
		flag2 = GUILayout.Toggle(flag2, "cash.ogg", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)8) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)4);
		flag2 = GUILayout.Toggle(flag2, "{0:00} m", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)8) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x00104F58 File Offset: 0x00103158
	private void KBEOAOKBHEK()
	{
		GUI.Box(new Rect(1375f, 1456f, 374f, 223f), "OfficeSittingHandRestFingerTap");
		GUI.BeginGroup(new Rect(250f, 411f, 1042f, 1524f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "</color></i>", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "_End", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.None;
		flag = GUILayout.Toggle(flag, "MotorbikeShootLeft", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? SSAOPro.GGFPOCFCJFG.Gaussian : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1827f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "onHyperlinkEnter: ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "?", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)5);
		flag2 = GUILayout.Toggle(flag2, "Player", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "MotorbikeBackwardStand", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)6) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x00105124 File Offset: 0x00103324
	private void OBDAPPLCPMD()
	{
		GUI.Box(new Rect(1426f, 1368f, 1575f, 681f), "#ffffff");
		GUI.BeginGroup(new Rect(641f, 183f, 1381f, 633f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "********* Start load Level ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "crft_crft", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)6;
		flag = GUILayout.Toggle(flag, "http://www.root-motion.com/finalikdox/html/page8.html", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)4) : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(116f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "bool: ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "[baitid]", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)4);
		flag2 = GUILayout.Toggle(flag2, "No Way points!", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)4);
		flag2 = GUILayout.Toggle(flag2, "error.wav", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.High : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void CGMHGDEKDEP()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x001052F0 File Offset: 0x001034F0
	private void BGJFLKLBOPK()
	{
		GUI.Box(new Rect(709f, 1275f, 755f, 220f), "PrimaryCausticsProjector");
		GUI.BeginGroup(new Rect(1525f, 1262f, 1920f, 315f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "Head", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "SoccerSprint", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.Gaussian;
		flag = GUILayout.Toggle(flag, "#", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)8) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1336f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "Vertical", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "auc_wcswcp", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "7", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.High : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)7);
		flag2 = GUILayout.Toggle(flag2, "\n", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)6) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x001054BC File Offset: 0x001036BC
	private void BCJFDHBDAHD()
	{
		GUI.Box(new Rect(1263f, 181f, 1512f, 494f), "error.wav");
		GUI.BeginGroup(new Rect(521f, 434f, 322f, 705f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "Climb to the top of the mountain to see the clouds (WASD keys to move).", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)7;
		flag = GUILayout.Toggle(flag, "TOD_LocalMoonDirection", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)4) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1999f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "\n", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "BlackSmithHammer", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)4);
		flag2 = GUILayout.Toggle(flag2, "upRod", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)7) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "upRod", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void BMNJGPIPKLL()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void NCALLFHEAGJ()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void OBJCOJEHLBE()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void KEMGOLACEHI()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void MODJFGGIAHD()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void AFFAJKPPMHF()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void OFGMIEJKMGC()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x00105688 File Offset: 0x00103888
	private void AGBEEDOOOHA()
	{
		GUI.Box(new Rect(976f, 964f, 892f, 1632f), "priceCr");
		GUI.BeginGroup(new Rect(705f, 1891f, 332f, 295f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "Vertical", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "wpn_eat4", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)7;
		flag = GUILayout.Toggle(flag, "LINEAR", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)8) : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(363f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "lineTENSIONKG=", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "wpn_bait_typ_{0}", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)6);
		flag2 = GUILayout.Toggle(flag2, "RollerBladeStop", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)4);
		flag2 = GUILayout.Toggle(flag2, "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void IMABGALEMBI()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void BJHGPFGBFKF()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x00105854 File Offset: 0x00103A54
	private void JCMGHHKALDM()
	{
		GUI.Box(new Rect(1724f, 1037f, 826f, 734f), "kill");
		GUI.BeginGroup(new Rect(1808f, 1487f, 1049f, 394f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "Gesture Wonderful", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "RunningDance", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)3;
		flag = GUILayout.Toggle(flag, "Resume Interaction With ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)6) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1256f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "money", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "UNIQUE_SHADOW_LIGHT_COOKIE", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "Нечего отпускать!", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)7);
		flag2 = GUILayout.Toggle(flag2, "FrontKick", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)6) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void JLKBMEBFHBI()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void LPNDCJKAKEA()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void FPLHODJCJDO()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x00105A20 File Offset: 0x00103C20
	private void BLCDCEHNNNC()
	{
		GUI.Box(new Rect(489f, 1899f, 867f, 1368f), "gi_usei");
		GUI.BeginGroup(new Rect(1323f, 438f, 1088f, 1683f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "harvestmsg3", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "_w", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)3;
		flag = GUILayout.Toggle(flag, "Forward", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)7) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(360f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "rbon", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)8);
		flag2 = GUILayout.Toggle(flag2, "#02C85F", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Medium : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)5);
		flag2 = GUILayout.Toggle(flag2, "_InternalLutParams", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)5) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void FIJKDFIMELM()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x00105BEC File Offset: 0x00103DEC
	private void HMPFJEPODEL()
	{
		GUI.Box(new Rect(885f, 67f, 574f, 1935f), "hellost");
		GUI.BeginGroup(new Rect(1617f, 426f, 849f, 89f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "t_bottom", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, " iterations for read and write", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.Gaussian;
		flag = GUILayout.Toggle(flag, "Mouse ScrollWheel", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)5) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1342f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "#url Sound ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)5);
		flag2 = GUILayout.Toggle(flag2, "UnityEngine.Vector3", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)6);
		flag2 = GUILayout.Toggle(flag2, "wpn_eat6", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)7) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void ONIHHFLOJMN()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void AOCDDBNBADJ()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x00105DB8 File Offset: 0x00103FB8
	private void HKGCKLBHNPJ()
	{
		GUI.Box(new Rect(1805f, 1036f, 1252f, 6f), "_Source");
		GUI.BeginGroup(new Rect(672f, 1098f, 688f, 1561f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "IdleStrafeLeft", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)5;
		flag = GUILayout.Toggle(flag, "_AxialAberration", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)7) : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(646f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "\n", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "Hidden/FXAA3", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)6);
		flag2 = GUILayout.Toggle(flag2, "_NAME", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)5) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)6);
		flag2 = GUILayout.Toggle(flag2, "ExposureIBL", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)5) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x00105F84 File Offset: 0x00104184
	private void NCFLINGBFJG()
	{
		GUI.Box(new Rect(264f, 780f, 1758f, 423f), "");
		GUI.BeginGroup(new Rect(1748f, 1819f, 104f, 1332f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "IceHockeyShotLeft", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.Gaussian;
		flag = GUILayout.Toggle(flag, "\n", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)3) : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(1333f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "isDownOnWater ok", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "Cowboy1HandDraw", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "\"{0}\"", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)8) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "wgt=", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Medium : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void DGEIACONKCJ()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x00106150 File Offset: 0x00104350
	private void MPPMHCICKIP()
	{
		GUI.Box(new Rect(1221f, 538f, 1610f, 79f), "IdleStrafeLeft");
		GUI.BeginGroup(new Rect(1159f, 813f, 1291f, 990f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "?", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, ".unity3d", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.None;
		flag = GUILayout.Toggle(flag, "IK", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? SSAOPro.GGFPOCFCJFG.Bilateral : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1193f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "\n", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "_CameraClipInfo", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.High);
		flag2 = GUILayout.Toggle(flag2, "t_hair", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Medium : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)4);
		flag2 = GUILayout.Toggle(flag2, "MaskMaterial", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.High : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x0010631C File Offset: 0x0010451C
	private void JBGGMKEKOAN()
	{
		GUI.Box(new Rect(1944f, 74f, 598f, 1239f), "Roller Blade Stop");
		GUI.BeginGroup(new Rect(1559f, 1284f, 1204f, 1423f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "_r_", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "isKeyPress", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.Gaussian;
		flag = GUILayout.Toggle(flag, "BlurDepthTollerance", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)7) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1839f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "RollerBladeJump", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "_LutParams", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "IdleRun", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)6);
		flag2 = GUILayout.Toggle(flag2, "_camScale", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)7) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void HDFCIACDDEK()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void KKCFKEDABLB()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void PFNPOHMMJDN()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void CPNOBMNKPNC()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x001064E8 File Offset: 0x001046E8
	private void LPNFGGAKGID()
	{
		GUI.Box(new Rect(215f, 325f, 1077f, 1103f), "+");
		GUI.BeginGroup(new Rect(345f, 287f, 717f, 700f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "IdleTurns", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "_SSAOTex", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)3;
		flag = GUILayout.Toggle(flag, "Fire1", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)5) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(896f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "__a", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "ClimbIdle", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.High);
		flag2 = GUILayout.Toggle(flag2, "Hidden/Post FX/Screen Space Reflection", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)7) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)5);
		flag2 = GUILayout.Toggle(flag2, "wpn_rod1", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x001066B4 File Offset: 0x001048B4
	private void ENCHIIJEJDL()
	{
		GUI.Box(new Rect(1722f, 1026f, 1748f, 1114f), "Select");
		GUI.BeginGroup(new Rect(999f, 173f, 1639f, 1365f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "RollerBladeStop", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "OfficeSitting1LegStraight", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)6;
		flag = GUILayout.Toggle(flag, "_", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)6) : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(1280f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "ScubaOK", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "<b>Injection Detector</b>", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)8);
		flag2 = GUILayout.Toggle(flag2, "StrafeRunRight", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)5) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)5);
		flag2 = GUILayout.Toggle(flag2, "IdleWalk", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void Start()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void CBLGFOFHNPJ()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x00106880 File Offset: 0x00104A80
	private void OnGUI()
	{
		GUI.Box(new Rect(10f, 10f, 130f, 176f), "");
		GUI.BeginGroup(new Rect(20f, 15f, 200f, 200f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "Enable SSAO", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "Show AO Only", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.Bilateral;
		flag = GUILayout.Toggle(flag, "Bilateral Blur", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? SSAOPro.GGFPOCFCJFG.Bilateral : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(10f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "4 samples", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "8 samples", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Medium);
		flag2 = GUILayout.Toggle(flag2, "12 samples", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Medium : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.High);
		flag2 = GUILayout.Toggle(flag2, "16 samples", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.High : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x00106A4C File Offset: 0x00104C4C
	private void AEFGOFJAKDO()
	{
		GUI.Box(new Rect(1138f, 1943f, 610f, 334f), "|");
		GUI.BeginGroup(new Rect(154f, 858f, 936f, 182f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "bs_nodonate", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "Jump", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)8;
		flag = GUILayout.Toggle(flag, "_LerpRgbTex", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)3) : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(1445f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "_MaxSteps", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "_RgbTex", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.High);
		flag2 = GUILayout.Toggle(flag2, "ArmFlex6", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)6) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void ELADFDNPOOI()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void JFFPLABGMNF()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x00106C18 File Offset: 0x00104E18
	private void KIEFPGLDOCD()
	{
		GUI.Box(new Rect(252f, 1908f, 1993f, 629f), "RunDive");
		GUI.BeginGroup(new Rect(886f, 40f, 1600f, 447f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "error", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "_Params3", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.None;
		flag = GUILayout.Toggle(flag, "ClimbUp", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)7) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(1169f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "cash.ogg", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "[[", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)5);
		flag2 = GUILayout.Toggle(flag2, "Vertical", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "Wizard2HandThrow", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)4) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void PNAAHEFHPCL()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x00106DE4 File Offset: 0x00104FE4
	private void MJDKGMEPMHK()
	{
		GUI.Box(new Rect(578f, 1339f, 1293f, 1609f), "<color=\"");
		GUI.BeginGroup(new Rect(1099f, 407f, 195f, 1081f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "System.Boolean", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "x", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)6;
		flag = GUILayout.Toggle(flag, "wpn_wgt", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)3) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(542f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "_BlurTexture", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "int: ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)5);
		flag2 = GUILayout.Toggle(flag2, "TOD_MoonSkyColor", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Medium : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)6);
		flag2 = GUILayout.Toggle(flag2, "Near", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)6) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x00104D7C File Offset: 0x00102F7C
	private void IAAOGAPJDID()
	{
		this.AKLIDCMNOKK = base.GetComponent<SSAOPro>();
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x00106FB0 File Offset: 0x001051B0
	private void BHALJCJOPGD()
	{
		GUI.Box(new Rect(1600f, 291f, 1341f, 651f), "SoccerKeeperStrafeLeft");
		GUI.BeginGroup(new Rect(937f, 1343f, 1686f, 448f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "</color>\n", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "paper.wav", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == SSAOPro.GGFPOCFCJFG.Bilateral;
		flag = GUILayout.Toggle(flag, "DecalMesh", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? SSAOPro.GGFPOCFCJFG.Gaussian : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(917f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "Drop ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "jamp", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)7);
		flag2 = GUILayout.Toggle(flag2, "_Grain_Params1", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)5) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Medium);
		flag2 = GUILayout.Toggle(flag2, "Wall hack Detected!", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)7) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x0010717C File Offset: 0x0010537C
	private void BBGAONKBIPJ()
	{
		GUI.Box(new Rect(215f, 294f, 1339f, 383f), "OfficeSittingReadingLeanBack");
		GUI.BeginGroup(new Rect(1824f, 1093f, 1467f, 489f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "UnityEngine.Color", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "double: ", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)7;
		flag = GUILayout.Toggle(flag, " assetbundle(s) in memory before unloading ", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)4) : SSAOPro.GGFPOCFCJFG.Gaussian);
		GUILayout.Space(1553f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow;
		flag2 = GUILayout.Toggle(flag2, "_Offsets", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "_BilateralUpsampling", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)6);
		flag2 = GUILayout.Toggle(flag2, "UpHillWalk", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)7) : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.VeryLow);
		flag2 = GUILayout.Toggle(flag2, "Try to change this int in memory:\n", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? ((SSAOPro.GPEHFPFDJAF)7) : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x00107348 File Offset: 0x00105548
	private void GGOKNBBPLHB()
	{
		GUI.Box(new Rect(472f, 1587f, 1421f, 1111f), "wpn_add/req/reqPerk");
		GUI.BeginGroup(new Rect(1897f, 1760f, 1005f, 1521f));
		this.AKLIDCMNOKK.enabled = GUILayout.Toggle(this.AKLIDCMNOKK.enabled, "_SelectColor", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.DebugAO = GUILayout.Toggle(this.AKLIDCMNOKK.DebugAO, "1=", Array.Empty<GUILayoutOption>());
		bool flag = this.AKLIDCMNOKK.Blur == (SSAOPro.GGFPOCFCJFG)7;
		flag = GUILayout.Toggle(flag, "[ACTk] WallHack Detector: already running!", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Blur = (flag ? ((SSAOPro.GGFPOCFCJFG)8) : SSAOPro.GGFPOCFCJFG.None);
		GUILayout.Space(584f);
		bool flag2 = this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low;
		flag2 = GUILayout.Toggle(flag2, "t_much", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.Low);
		flag2 = GUILayout.Toggle(flag2, "cnt_dstall", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == (SSAOPro.GPEHFPFDJAF)8);
		flag2 = GUILayout.Toggle(flag2, "KatanaReadyHigh", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.VeryLow : this.AKLIDCMNOKK.Samples);
		flag2 = (this.AKLIDCMNOKK.Samples == SSAOPro.GPEHFPFDJAF.High);
		flag2 = GUILayout.Toggle(flag2, "Mouse ScrollWheel", Array.Empty<GUILayoutOption>());
		this.AKLIDCMNOKK.Samples = (flag2 ? SSAOPro.GPEHFPFDJAF.Low : this.AKLIDCMNOKK.Samples);
		GUI.EndGroup();
	}

	// Token: 0x0400042F RID: 1071
	protected SSAOPro AKLIDCMNOKK;
}
