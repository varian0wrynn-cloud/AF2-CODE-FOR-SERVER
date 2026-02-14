using System;
using UnityEngine;

// Token: 0x020001A7 RID: 423
public class HKIEEHBCMNJ : ONKDCGNBALK
{
	// Token: 0x06005E81 RID: 24193 RVA: 0x002C1B74 File Offset: 0x002BFD74
	public virtual void HCHJHBGEGMP(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1226f;
		float num2 = 1993f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 782f;
			ochcodjiphj.y += 1784f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "harvestmsg2", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OHHMBDOICNG(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("MotorbikeShootRight", 1213f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E82 RID: 24194 RVA: 0x002C1CDC File Offset: 0x002BFEDC
	public virtual void FDCOFCOIHEH(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1104f;
		float num2 = 164f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 285f;
			ochcodjiphj.y += 1976f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "rait_3", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Inventory manager is init", 830f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E83 RID: 24195 RVA: 0x002C1E44 File Offset: 0x002C0044
	public virtual void BLGIOPMGMPG(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1273f;
		float num2 = 1545f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1068f;
			ochcodjiphj.y += 9f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "WorkerShovel2", GUIStyle.none))
		{
			JDCEFOFMGHB.JFIDAGABKID().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Keeper Strafe Dive Far Left", 1942f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E84 RID: 24196 RVA: 0x002C1FAC File Offset: 0x002C01AC
	public virtual void KNCJKEEICGO(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1153f;
		float num2 = 433f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1974f;
			ochcodjiphj.y += 51f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, " гр ", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().FFMGKOIMOPE(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("IdleSandCover", 655f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E85 RID: 24197 RVA: 0x002C2114 File Offset: 0x002C0314
	public virtual void CBGMHNELDIA(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 759f;
		float num2 = 1836f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1789f;
			ochcodjiphj.y += 1443f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("MENU.WAV", 153f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E86 RID: 24198 RVA: 0x002C227C File Offset: 0x002C047C
	public virtual void OECNEDDNMGC(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1470f;
		float num2 = 1436f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1173f;
			ochcodjiphj.y += 1321f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Giant3HitCombo", GUIStyle.none))
		{
			JDCEFOFMGHB.JFIDAGABKID().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("", 328f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E87 RID: 24199 RVA: 0x002C23E4 File Offset: 0x002C05E4
	public virtual void CGKPGCLLJHJ(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 366f;
		float num2 = 506f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1039f;
			ochcodjiphj.y += 517f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "UnityEngine.GameObject", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("MotorbikeShootBack", 561f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E88 RID: 24200 RVA: 0x002C254C File Offset: 0x002C074C
	public virtual void HADLKLNMMNC(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1656f;
		float num2 = 707f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1226f;
			ochcodjiphj.y += 1681f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("<color='#804020'>", 1571f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E89 RID: 24201 RVA: 0x002C26B4 File Offset: 0x002C08B4
	public virtual void EGKHIENICMJ(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1101f;
		float num2 = 616f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 734f;
			ochcodjiphj.y += 1715f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "offsets", GUIStyle.none))
		{
			JDCEFOFMGHB.JFIDAGABKID().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("no assemblies", 422f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E8A RID: 24202 RVA: 0x002C281C File Offset: 0x002C0A1C
	public virtual void FMBBLFIGPGL(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1845f;
		float num2 = 1876f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 666f;
			ochcodjiphj.y += 1998f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "newHour", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("RollerBladeStop", 430f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E8B RID: 24203 RVA: 0x002C2984 File Offset: 0x002C0B84
	public virtual void AMEAHFNAHDC(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1781f;
		float num2 = 1791f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 512f;
			ochcodjiphj.y += 721f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "400000", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_Offsets", 1235f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E8C RID: 24204 RVA: 0x002C2AEC File Offset: 0x002C0CEC
	public virtual void APOPIOPIFMP(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1225f;
		float num2 = 396f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1138f;
			ochcodjiphj.y += 1198f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "{0}.{1}.{2}", GUIStyle.none))
		{
			JDCEFOFMGHB.JFIDAGABKID().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("MidBlendLut", 259f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E8D RID: 24205 RVA: 0x002C2C54 File Offset: 0x002C0E54
	public virtual void NEHJDJAAMEO(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 726f;
		float num2 = 378f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1512f;
			ochcodjiphj.y += 1107f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, " l ", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("_Threshold", 956f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E8E RID: 24206 RVA: 0x002C2DBC File Offset: 0x002C0FBC
	public virtual void OLHEECEMJDD(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1333f;
		float num2 = 1926f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1730f;
			ochcodjiphj.y += 874f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "MotorbikeWheely", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("ObscuredString:", 435f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E8F RID: 24207 RVA: 0x002C2F24 File Offset: 0x002C1124
	public virtual void LMIIDBOCFPI(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 49f;
		float num2 = 1757f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 656f;
			ochcodjiphj.y += 1867f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "user.standFlag ok", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("OfficeSittingLegCross", 743f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E90 RID: 24208 RVA: 0x002C308C File Offset: 0x002C128C
	public virtual void CMNHIIEFOHJ(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 955f;
		float num2 = 969f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1741f;
			ochcodjiphj.y += 383f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "wpn_add/base", GUIStyle.none))
		{
			JDCEFOFMGHB.JFIDAGABKID().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Failed parsing atlas group.  Setting to group 0", 1582f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E91 RID: 24209 RVA: 0x002C31F4 File Offset: 0x002C13F4
	public virtual void GHGLBEBFGAP(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1346f;
		float num2 = 1454f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 617f;
			ochcodjiphj.y += 1163f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "__WaterReflection", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_Gamma", 1114f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E92 RID: 24210 RVA: 0x002C335C File Offset: 0x002C155C
	public virtual void BFHPJCKICCE(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 819f;
		float num2 = 124f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 139f;
			ochcodjiphj.y += 1962f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Giant3HitCombo2", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("IdleStun", 63f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E93 RID: 24211 RVA: 0x002C34C4 File Offset: 0x002C16C4
	public virtual void CMECHJMLPGD(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 811f;
		float num2 = 703f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 415f;
			ochcodjiphj.y += 664f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "fishStamKF=", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("", 1525f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E94 RID: 24212 RVA: 0x002C362C File Offset: 0x002C182C
	public virtual void DBHACAENJOE(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 85f;
		float num2 = 1758f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1331f;
			ochcodjiphj.y += 161f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Post Process Scatter Shader Missing...", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL = true;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_ChannelMixerRed", 1636f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E95 RID: 24213 RVA: 0x002C3794 File Offset: 0x002C1994
	public virtual void JOBPKNNNEAD(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1471f;
		float num2 = 51f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 612f;
			ochcodjiphj.y += 1613f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "gi_inte_3", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("1 Hand Sword Jab Foot Push", 322f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E96 RID: 24214 RVA: 0x002C38FC File Offset: 0x002C1AFC
	public virtual void BIJMKMEPBIC(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 397f;
		float num2 = 1071f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 808f;
			ochcodjiphj.y += 1654f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "UnityEngine.GameObject", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL = true;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("Bone 3 of a BipedReferences limb is null.", 543f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E97 RID: 24215 RVA: 0x002C3A64 File Offset: 0x002C1C64
	public virtual void ILHLJFHLJIH(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 698f;
		float num2 = 1197f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 547f;
			ochcodjiphj.y += 1427f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "FlyUp", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("wpn_hook1", 1786f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E98 RID: 24216 RVA: 0x002C3BCC File Offset: 0x002C1DCC
	public virtual void OEGEMMPIIPC(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 162f;
		float num2 = 1212f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1680f;
			ochcodjiphj.y += 1420f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "lifeBar", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", 1869f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E99 RID: 24217 RVA: 0x002C3D34 File Offset: 0x002C1F34
	public virtual void LNEKEJJIHHP(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1914f;
		float num2 = 1935f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1953f;
			ochcodjiphj.y += 962f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Suicide Head Shot", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("IdleFight", 30f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E9A RID: 24218 RVA: 0x002C3E9C File Offset: 0x002C209C
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 0f;
		float num2 = 0f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 1f;
			ochcodjiphj.y += 1f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("button.wav", 1f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E9B RID: 24219 RVA: 0x002C4004 File Offset: 0x002C2204
	public virtual void BNBECPLPKGM(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1078f;
		float num2 = 1388f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1189f;
			ochcodjiphj.y += 1393f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "iNPC", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("FlyUp", 766f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E9C RID: 24220 RVA: 0x002C416C File Offset: 0x002C236C
	public virtual void OOKDJBCNEBH(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 156f;
		float num2 = 316f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 249f;
			ochcodjiphj.y += 1425f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "FactoryTempTexture", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("OfficeSittingMouseMovement", 1692f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E9D RID: 24221 RVA: 0x002C42D4 File Offset: 0x002C24D4
	public virtual void FJNDHHDAGCI(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1925f;
		float num2 = 686f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 222f;
			ochcodjiphj.y += 109f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, " ", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.OHHMBDOICNG(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("help", 1594f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E9E RID: 24222 RVA: 0x002C443C File Offset: 0x002C263C
	public virtual void LCOKOEMNPEL(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 596f;
		float num2 = 55f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1686f;
			ochcodjiphj.y += 584f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "fanfare.wav", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("isMove", 110f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005E9F RID: 24223 RVA: 0x002C45A4 File Offset: 0x002C27A4
	public virtual void PHJEFJPDDDI(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 156f;
		float num2 = 1210f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 235f;
			ochcodjiphj.y += 1449f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "SAMPLES_MEDIUM", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("{not_found}", 86f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA0 RID: 24224 RVA: 0x002C470C File Offset: 0x002C290C
	public virtual void OAPAJJAJPEK(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1748f;
		float num2 = 408f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 411f;
			ochcodjiphj.y += 1074f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Giant3HitCombo", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("ThinWall", 1727f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA1 RID: 24225 RVA: 0x002C4874 File Offset: 0x002C2A74
	public virtual void DDLPNGBNMED(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1554f;
		float num2 = 1141f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 19f;
			ochcodjiphj.y += 1f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "crunch.ogg", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_InternalLutParams", 1783f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA2 RID: 24226 RVA: 0x002C49DC File Offset: 0x002C2BDC
	public virtual void JIAOONGONPM(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1917f;
		float num2 = 1868f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 840f;
			ochcodjiphj.y += 28f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "_CameraWS", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_FogSkyColor", 847f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA3 RID: 24227 RVA: 0x002C4B44 File Offset: 0x002C2D44
	public virtual void MBABINJIPDF(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 834f;
		float num2 = 201f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 694f;
			ochcodjiphj.y += 20f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "ShotgunReloadMagazine", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.OHHMBDOICNG(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("reputaion/fractions/fraction", 1734f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA4 RID: 24228 RVA: 0x002C4CAC File Offset: 0x002C2EAC
	public virtual void KCHEILEJGPL(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1362f;
		float num2 = 767f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 485f;
			ochcodjiphj.y += 1541f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Horizontal", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("StrafeRunRight", 820f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA5 RID: 24229 RVA: 0x002C4E14 File Offset: 0x002C3014
	public virtual void LNNEOFFJJJA(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 966f;
		float num2 = 1496f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1929f;
			ochcodjiphj.y += 38f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Open turnir info window", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("_Histogram", 1611f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA6 RID: 24230 RVA: 0x002C4F7C File Offset: 0x002C317C
	public HKIEEHBCMNJ(ONKDCGNBALK OCBAOFLJBGP, float OCNGPCPMCPM, float ADMFAEOOOHD, int ODFEKBJCFMN, Texture KCHECDJCBKA, int FEGIOKLMDDI, int AHDCDEOGGPH, int CLBPBJGLHEE, ONKDCGNBALK.CMMHGMILOIM LJIEPIPIAJC) : base(OCBAOFLJBGP, OCNGPCPMCPM, ADMFAEOOOHD, (float)(KCHECDJCBKA.width / FEGIOKLMDDI), (float)(KCHECDJCBKA.height / AHDCDEOGGPH), "", ODFEKBJCFMN, 3)
	{
		this.KNIOGNKKINO = 3;
		this.CKEIHEEMLIL = KCHECDJCBKA;
		this.JOFMGAMJEOP = FEGIOKLMDDI;
		this.NINNMLINGMB = AHDCDEOGGPH;
		this.CLBPBJGLHEE = CLBPBJGLHEE;
		this.LJIEPIPIAJC = LJIEPIPIAJC;
	}

	// Token: 0x06005EA7 RID: 24231 RVA: 0x002C4FE0 File Offset: 0x002C31E0
	public virtual void LPPKKCCKLJF(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 748f;
		float num2 = 416f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 611f;
			ochcodjiphj.y += 1299f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "wpn_eat4", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("_CurrentMipLevel", 1116f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA8 RID: 24232 RVA: 0x002C5148 File Offset: 0x002C3348
	public virtual void LCIKLFLKPEE(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1500f;
		float num2 = 1070f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 169f;
			ochcodjiphj.y += 1341f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "UIChat_channel", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Arm Flex 4", 315f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EA9 RID: 24233 RVA: 0x002C52B0 File Offset: 0x002C34B0
	public virtual void FCCFIHJKFNK(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1584f;
		float num2 = 812f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1516f;
			ochcodjiphj.y += 414f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "null", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("true", 145f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EAA RID: 24234 RVA: 0x002C5418 File Offset: 0x002C3618
	public virtual void GMLICBKPPCC(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 7f;
		float num2 = 700f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 474f;
			ochcodjiphj.y += 752f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "MotorbikeLookBack", GUIStyle.none))
		{
			JDCEFOFMGHB.JFIDAGABKID().OHHMBDOICNG(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("IdleTurns", 1364f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EAB RID: 24235 RVA: 0x002C5580 File Offset: 0x002C3780
	public virtual void FOGCOMNGOFB(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1062f;
		float num2 = 906f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 862f;
			ochcodjiphj.y += 303f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "fider_Medium_", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("https://www.youtube.com/watch?v=tgRMsTphjJo", 1522f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EAC RID: 24236 RVA: 0x002C56E8 File Offset: 0x002C38E8
	public virtual void OCCJHOPJHLG(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 852f;
		float num2 = 666f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 952f;
			ochcodjiphj.y += 565f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "repair.ogg", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL = true;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("x {0}/{1}", 1743f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EAD RID: 24237 RVA: 0x002C5850 File Offset: 0x002C3A50
	public virtual void DLBGNLEIMPB(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 683f;
		float num2 = 1854f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 742f;
			ochcodjiphj.y += 104f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("", 467f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EAE RID: 24238 RVA: 0x002C59B8 File Offset: 0x002C3BB8
	public virtual void OFCJAMLCEPB(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1616f;
		float num2 = 464f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1070f;
			ochcodjiphj.y += 1050f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "\n", GUIStyle.none))
		{
			JDCEFOFMGHB.JFIDAGABKID().FFMGKOIMOPE(false);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", 28f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EAF RID: 24239 RVA: 0x002C5B20 File Offset: 0x002C3D20
	public virtual void JIGDBPIJDHE(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1056f;
		float num2 = 657f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1159f;
			ochcodjiphj.y += 655f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "Закрыть", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_BlurDirectionPacked", 1201f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EB0 RID: 24240 RVA: 0x002C5C88 File Offset: 0x002C3E88
	public virtual void ENCCJFKCHIE(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1861f;
		float num2 = 190f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 1336f;
			ochcodjiphj.y += 955f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "OnTriggerExit", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("DealerIdle", 1011f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EB1 RID: 24241 RVA: 0x002C5DF0 File Offset: 0x002C3FF0
	public virtual void JBBGCIICJIH(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1534f;
		float num2 = 214f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(1))
		{
			ochcodjiphj.x += 894f;
			ochcodjiphj.y += 380f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "ZombieWalk", GUIStyle.none))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("chnam1", 119f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EB2 RID: 24242 RVA: 0x002C5F58 File Offset: 0x002C4158
	public virtual void ECLJBBPGNPA(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 1155f;
		float num2 = 772f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 191f;
			ochcodjiphj.y += 1809f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "uierror6.wav", GUIStyle.none))
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OHHMBDOICNG(true);
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("#000000", 538f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005EB3 RID: 24243 RVA: 0x002C60C0 File Offset: 0x002C42C0
	public virtual void DKOEJJHKMHI(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		float num = 789f;
		float num2 = 1753f;
		for (ONKDCGNBALK ocbaofljbgp = this.OCBAOFLJBGP; ocbaofljbgp != null; ocbaofljbgp = this.OCBAOFLJBGP.OCBAOFLJBGP)
		{
			num += ocbaofljbgp.OCHCODJIPHJ.x;
			num2 += ocbaofljbgp.OCHCODJIPHJ.y;
		}
		if (this.OHNAHKMBABD && CFMPGCJMHJM && Input.GetMouseButton(0))
		{
			ochcodjiphj.x += 933f;
			ochcodjiphj.y += 1769f;
		}
		Vector2 point = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		new Rect(num + this.OCHCODJIPHJ.x, num2 + this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height).Contains(point);
		GUI.DrawTextureWithTexCoords(ochcodjiphj, this.CKEIHEEMLIL, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.CLBPBJGLHEE, this.JOFMGAMJEOP, this.NINNMLINGMB));
		if (GUI.Button(ochcodjiphj, "DITHER_ON", GUIStyle.none))
		{
			JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("GiantGrabThrow2", 62f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x04000DD1 RID: 3537
	private readonly Texture CKEIHEEMLIL;

	// Token: 0x04000DD2 RID: 3538
	private readonly int JOFMGAMJEOP;

	// Token: 0x04000DD3 RID: 3539
	private readonly int NINNMLINGMB;

	// Token: 0x04000DD4 RID: 3540
	private readonly int CLBPBJGLHEE;
}
