using System;
using UnityEngine;

// Token: 0x02000325 RID: 805
public class GPKKABMNMNJ
{
	// Token: 0x0600B839 RID: 47161 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void MPEKBBHCMMP(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B83A RID: 47162 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void CBOPHABMCJA(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B83B RID: 47163 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void ECCOBKJOFMJ(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B83C RID: 47164 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void MKFPPJBJFFO(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B83D RID: 47165 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void PDDMDMMJFGP(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B83E RID: 47166 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void EJLBPAFPIGL(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B83F RID: 47167 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void PIALAGDLIBP(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B840 RID: 47168 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
	public static void AHJMEFGGOLK(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B841 RID: 47169 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void POGCDBILNBA(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B842 RID: 47170 RVA: 0x0051EA60 File Offset: 0x0051CC60
	public static void LJABENLNGDM(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 502f)
		{
			DNFHBMGCELC.y = 1079f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1320f, 303f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("WeaponStrafeRunLeft", value);
		MHNAJNGGDFJ.SetVector("MotorbikeLassoRight", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("_DayToNight", NEPBPMGGPKM * 1935f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B843 RID: 47171 RVA: 0x0051EB0C File Offset: 0x0051CD0C
	public static void AIIKPMGHIBE(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 1447f)
		{
			DNFHBMGCELC.y = 431f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1491f, 130f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("wpn_line1", value);
		MHNAJNGGDFJ.SetVector("reputaion/levels/replevels", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("Keeper Strafe Dive Far Right", NEPBPMGGPKM * 1015f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B844 RID: 47172 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void CHDHDGOBACE(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B845 RID: 47173 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void JIDMFGFELJJ(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B846 RID: 47174 RVA: 0x0051EBB8 File Offset: 0x0051CDB8
	public static void JJKIPDJEIJF(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 127f)
		{
			DNFHBMGCELC.y = 1129f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1591f, 1634f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("wpn_bait_typ_{0}", value);
		MHNAJNGGDFJ.SetVector("rollSoundIndex", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("OneHandSwordSwing", NEPBPMGGPKM * 1738f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B847 RID: 47175 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void DHCKHMABGGJ(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B848 RID: 47176 RVA: 0x0051EC64 File Offset: 0x0051CE64
	public static void JBDKKKGELGB(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 161f)
		{
			DNFHBMGCELC.y = 682f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1089f, 549f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("Cowboy1HandDraw", value);
		MHNAJNGGDFJ.SetVector("</color>", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("IdleReadyLook", NEPBPMGGPKM * 726f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B849 RID: 47177 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void LFDJEGFPOJO(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B84A RID: 47178 RVA: 0x0051ED10 File Offset: 0x0051CF10
	public static void MJGFLJPJIHA(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 7f)
		{
			DNFHBMGCELC.y = 1758f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1178f, 387f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("", value);
		MHNAJNGGDFJ.SetVector("' does not exist within Assets/Resources/Fonts/", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("Приватный", NEPBPMGGPKM * 1490f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B84B RID: 47179 RVA: 0x0051EDBC File Offset: 0x0051CFBC
	public static void FAHGFPAPLHL(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 1832f)
		{
			DNFHBMGCELC.y = 1094f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(644f, 355f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("Wizard 1 Hand Throw", value);
		MHNAJNGGDFJ.SetVector("", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("replev_", NEPBPMGGPKM * 1858f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B84C RID: 47180 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void JIPLNFFBLIM(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B84D RID: 47181 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void ENLBGOAJLNH(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B84E RID: 47182 RVA: 0x0051EE68 File Offset: 0x0051D068
	public static void MOHIKOINCDD(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 187f)
		{
			DNFHBMGCELC.y = 1641f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(748f, 669f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("close", value);
		MHNAJNGGDFJ.SetVector("<<", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("wpn_dress1", NEPBPMGGPKM * 158f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B84F RID: 47183 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void BGMLHDGMAMM(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B850 RID: 47184 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void EBDPJHCADLN(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B851 RID: 47185 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void EMOGBLIBMKL(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B852 RID: 47186 RVA: 0x0051EF14 File Offset: 0x0051D114
	public static void NLJFAJPKAGE(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 1379f)
		{
			DNFHBMGCELC.y = 1380f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(338f, 1972f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("WalkBackward", value);
		MHNAJNGGDFJ.SetVector(".unity3d", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("Noise shaders are not set up! Disabling noise effect.", NEPBPMGGPKM * 1539f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B853 RID: 47187 RVA: 0x0051EFC0 File Offset: 0x0051D1C0
	public static void IOIBBDPMIFL(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 131f)
		{
			DNFHBMGCELC.y = 1535f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1121f, 1494f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("Transforms is null.", value);
		MHNAJNGGDFJ.SetVector("SoccerWalk", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("Player", NEPBPMGGPKM * 436f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B854 RID: 47188 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void MDDCCEPBPMB(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B855 RID: 47189 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void AIJBFIJAPBM(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B856 RID: 47190 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void DIBAFBACGGB(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B857 RID: 47191 RVA: 0x0051F06C File Offset: 0x0051D26C
	public static void CHDFLJBGFHJ(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 1090f)
		{
			DNFHBMGCELC.y = 1686f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(944f, 1577f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("ControlledPlayer", value);
		MHNAJNGGDFJ.SetVector("RollerBladeCrossoverRight", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("OfficeSitting45DegLeg", NEPBPMGGPKM * 1674f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B858 RID: 47192 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void LKMFNEMMHJK(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B859 RID: 47193 RVA: 0x0051F118 File Offset: 0x0051D318
	public static void HNENMMIAPOM(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 983f)
		{
			DNFHBMGCELC.y = 1553f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(985f, 1840f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("invn_rec24", value);
		MHNAJNGGDFJ.SetVector("_TempRT", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("Near", NEPBPMGGPKM * 472f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B85A RID: 47194 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void ANHKALILOCG(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B85B RID: 47195 RVA: 0x0051F1C4 File Offset: 0x0051D3C4
	public static void ODCCNNOPFCA(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 1531f)
		{
			DNFHBMGCELC.y = 385f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1858f, 840f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("_Offsets", value);
		MHNAJNGGDFJ.SetVector("gi_usei", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("Handstand", NEPBPMGGPKM * 818f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B85C RID: 47196 RVA: 0x0051F270 File Offset: 0x0051D470
	public static void CIMMGAOLDFM(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 182f)
		{
			DNFHBMGCELC.y = 634f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1964f, 1927f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("human_move_2.wav", value);
		MHNAJNGGDFJ.SetVector("</b>\n : ", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("Superman", NEPBPMGGPKM * 1502f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B85D RID: 47197 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void CJJJFKDMGDN(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B85E RID: 47198 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void BNGHLCHDDLC(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B85F RID: 47199 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void MHMJLGCLCLL(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B860 RID: 47200 RVA: 0x0051F31C File Offset: 0x0051D51C
	public static void GCOPHAGBIBB(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 992f)
		{
			DNFHBMGCELC.y = 69f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(551f, 1609f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("ProneIdle", value);
		MHNAJNGGDFJ.SetVector("Can't use reflection here, sorry :(", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat(",", NEPBPMGGPKM * 1403f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B861 RID: 47201 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void JICLNFAFBDL(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B862 RID: 47202 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void IMPDFCCOJGC(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B863 RID: 47203 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void CGDKCJCPMLP(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B864 RID: 47204 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void MALFDAIKHMF(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B865 RID: 47205 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void KEBLPFENOHF(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B867 RID: 47207 RVA: 0x0051EA56 File Offset: 0x0051CC56
	[Obsolete("Use Graphics.Blit(source,dest) instead")]
	public static void OFGPPIJMEID(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B868 RID: 47208 RVA: 0x0051F3C8 File Offset: 0x0051D5C8
	public static void IHKOFKIEKKB(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 0f)
		{
			DNFHBMGCELC.y = 1f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("_RotationMatrix", value);
		MHNAJNGGDFJ.SetVector("_CenterRadius", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("_Angle", NEPBPMGGPKM * 0.017453292f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B869 RID: 47209 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void KKMMEIEIDJD(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B86A RID: 47210 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void GAMIBBFLGBL(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}

	// Token: 0x0600B86B RID: 47211 RVA: 0x0051F474 File Offset: 0x0051D674
	public static void IDJAFJPKNPN(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 1646f)
		{
			DNFHBMGCELC.y = 187f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1740f, 1361f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("cht_msg21", value);
		MHNAJNGGDFJ.SetVector("", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat(" ", NEPBPMGGPKM * 1875f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B86C RID: 47212 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void ILEMKENGEFO(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B86D RID: 47213 RVA: 0x0051F520 File Offset: 0x0051D720
	public static void KCNHHAIAOAP(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, float NEPBPMGGPKM, Vector2 DNFHBMGCELC, Vector2 AEIAFIIMHEL)
	{
		if (JONJODLFAEN.texelSize.y < 266f)
		{
			DNFHBMGCELC.y = 396f - DNFHBMGCELC.y;
			NEPBPMGGPKM = -NEPBPMGGPKM;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1826f, 1352f, NEPBPMGGPKM), Vector3.one);
		MHNAJNGGDFJ.SetMatrix("Wall Sit", value);
		MHNAJNGGDFJ.SetVector("active_obj_", new Vector4(DNFHBMGCELC.x, DNFHBMGCELC.y, AEIAFIIMHEL.x, AEIAFIIMHEL.y));
		MHNAJNGGDFJ.SetFloat("bag", NEPBPMGGPKM * 988f);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ);
	}

	// Token: 0x0600B86E RID: 47214 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void NLEBCJALNAF(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B86F RID: 47215 RVA: 0x0051EA56 File Offset: 0x0051CC56
	public static void IGBGECGAFBH(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC);
	}

	// Token: 0x0600B870 RID: 47216 RVA: 0x0051EA4C File Offset: 0x0051CC4C
	public static void EMGCHCGGDMD(Material MHNAJNGGDFJ, RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC)
	{
		Graphics.Blit(JONJODLFAEN, OLFKAHHACBC, MHNAJNGGDFJ);
	}
}
