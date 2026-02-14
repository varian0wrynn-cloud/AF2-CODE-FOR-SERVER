using System;
using UnityEngine;

// Token: 0x020001BD RID: 445
public class KJPFDOGHGOD : ONKDCGNBALK
{
	// Token: 0x06006357 RID: 25431 RVA: 0x002E2690 File Offset: 0x002E0890
	public virtual void HKCJANIJJDL(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "id");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 40
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 922f, this.OCHCODJIPHJ.y + 685f, this.OCHCODJIPHJ.width - 940f, 1134f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1825f, this.OCHCODJIPHJ.y + 1594f, 864f, 1596f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1422f;
				position.y += 692f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(2, 3, 2));
		if (GUI.Button(position, "ok", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE(" ms", 1038f);
			this.GAJHGCPBGME -= 355f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1772f, this.OCHCODJIPHJ.y + 1068f, 935f, 888f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 84f;
				position.y += 622f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(1, 4, 8));
		if (GUI.Button(position, "AmbientOcclusion", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Trail", 867f);
			this.GAJHGCPBGME += 296f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1650f, this.OCHCODJIPHJ.y + 122f, this.OCHCODJIPHJ.width - 1501f, 1175f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006358 RID: 25432 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float APLJCIKJBGA()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x06006359 RID: 25433 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void LGBJCCANCOI(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600635A RID: 25434 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void GBOODNGANBG(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600635B RID: 25435 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float OODDPMHMCOP()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x0600635C RID: 25436 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void IIIGNEAHCKK(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600635D RID: 25437 RVA: 0x002E2A3C File Offset: 0x002E0C3C
	public virtual void IAEINLKLOCP(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "FOG_EXP");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -46
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 843f, this.OCHCODJIPHJ.y + 371f, this.OCHCODJIPHJ.width - 1931f, 1019f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 975f, this.OCHCODJIPHJ.y + 1317f, 1006f, 1833f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 707f;
				position.y += 1244f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(3, 1, 2));
		if (GUI.Button(position, "_NormalAndRoughnessTexture", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("body", 1908f);
			this.GAJHGCPBGME -= 1520f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1334f, this.OCHCODJIPHJ.y + 376f, 1682f, 302f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1205f;
				position.y += 117f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(1, 7, 4));
		if (GUI.Button(position, "_Offsets", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("ragulaFider", 1089f);
			this.GAJHGCPBGME += 625f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1404f, this.OCHCODJIPHJ.y + 1988f, this.OCHCODJIPHJ.width - 185f, 625f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600635E RID: 25438 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void HJIMELCMIOK(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x0600635F RID: 25439 RVA: 0x002E2DE0 File Offset: 0x002E0FE0
	public virtual void NEJHDECOINE(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "gi_um_9");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 56
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1707f, this.OCHCODJIPHJ.y + 1532f, this.OCHCODJIPHJ.width - 385f, 361f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 761f, this.OCHCODJIPHJ.y + 5f, 615f, 1945f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 11f;
				position.y += 420f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(6, 5, 1));
		if (GUI.Button(position, "WeaponStrafeRunLeft", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("preservePlayerPrefs", 1385f);
			this.GAJHGCPBGME -= 1521f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 848f, this.OCHCODJIPHJ.y + 1513f, 65f, 611f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1588f;
				position.y += 1381f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(0, 5, 2));
		if (GUI.Button(position, "CrouchWalkBackward", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("<color=\"", 869f);
			this.GAJHGCPBGME += 420f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 584f, this.OCHCODJIPHJ.y + 24f, this.OCHCODJIPHJ.width - 258f, 1412f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006360 RID: 25440 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void OFHHOHCJIDK(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006361 RID: 25441 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void INKIFMDGOAB(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x06006362 RID: 25442 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void OEMPOLAJLCK(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x06006363 RID: 25443 RVA: 0x002E317A File Offset: 0x002E137A
	public int HMLOOANPHKM()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006364 RID: 25444 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void EPDMCNOCEOH(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006365 RID: 25445 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void JPPDKJCIAKN(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x06006366 RID: 25446 RVA: 0x002E3184 File Offset: 0x002E1384
	public virtual void JIGDBPIJDHE(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "big_count");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 73
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 421f, this.OCHCODJIPHJ.y + 1418f, this.OCHCODJIPHJ.width - 1463f, 1607f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1260f, this.OCHCODJIPHJ.y + 437f, 111f, 379f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1655f;
				position.y += 1416f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(2, 5, 2));
		if (GUI.Button(position, "MotorbikeLookBack", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_", 1661f);
			this.GAJHGCPBGME -= 1557f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1750f, this.OCHCODJIPHJ.y + 889f, 42f, 951f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1642f;
				position.y += 1454f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 2, 8));
		if (GUI.Button(position, "{0:0.0%}", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("[userfish]", 1117f);
			this.GAJHGCPBGME += 1993f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1306f, this.OCHCODJIPHJ.y + 1463f, this.OCHCODJIPHJ.width - 924f, 256f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006367 RID: 25447 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void JJNNKGAGFND(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006368 RID: 25448 RVA: 0x002E3520 File Offset: 0x002E1720
	public virtual void ENCCJFKCHIE(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "v {0}.{1}.{2}");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 125
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1114f, this.OCHCODJIPHJ.y + 1970f, this.OCHCODJIPHJ.width - 1329f, 691f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 51f, this.OCHCODJIPHJ.y + 744f, 514f, 457f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1595f;
				position.y += 1149f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 5, 5));
		if (GUI.Button(position, "PistolFire", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("WallSit", 668f);
			this.GAJHGCPBGME -= 1968f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1325f, this.OCHCODJIPHJ.y + 176f, 67f, 586f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1867f;
				position.y += 942f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(1, 5, 2));
		if (GUI.Button(position, "cht_ach2", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Lasso Right", 826f);
			this.GAJHGCPBGME += 1474f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 835f, this.OCHCODJIPHJ.y + 918f, this.OCHCODJIPHJ.width - 180f, 1182f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void LHPMNPNNGHL(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void NHMEEAGHOEJ(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x002E38BC File Offset: 0x002E1ABC
	public virtual void JMFKFIHDLBG(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 46
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1572f, this.OCHCODJIPHJ.y + 272f, this.OCHCODJIPHJ.width - 1084f, 1296f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 541f, this.OCHCODJIPHJ.y + 1820f, 74f, 332f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1362f;
				position.y += 1488f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(6, 7, 2));
		if (GUI.Button(position, "DealerIdle", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("_BlurRadius4", 822f);
			this.GAJHGCPBGME -= 224f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1177f, this.OCHCODJIPHJ.y + 330f, 669f, 1111f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 423f;
				position.y += 1861f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(0, 3, 7));
		if (GUI.Button(position, "IdleReadyLook", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("\\n", 427f);
			this.GAJHGCPBGME += 600f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 439f, this.OCHCODJIPHJ.y + 1545f, this.OCHCODJIPHJ.width - 1863f, 1134f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float AOLHLLBADMI()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x0600636D RID: 25453 RVA: 0x002E3C58 File Offset: 0x002E1E58
	public virtual void KCHEILEJGPL(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 97
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 569f, this.OCHCODJIPHJ.y + 128f, this.OCHCODJIPHJ.width - 358f, 652f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 346f, this.OCHCODJIPHJ.y + 1832f, 155f, 343f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1002f;
				position.y += 1816f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(3, 7, 1));
		if (GUI.Button(position, "ItemsData", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA(" iterations for read and write", 387f);
			this.GAJHGCPBGME -= 171f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1510f, this.OCHCODJIPHJ.y + 642f, 1384f, 1367f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 941f;
				position.y += 166f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(1, 6, 7));
		if (GUI.Button(position, "#000040", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("harvestmsg2", 1445f);
			this.GAJHGCPBGME += 65f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1792f, this.OCHCODJIPHJ.y + 1652f, this.OCHCODJIPHJ.width - 1364f, 914f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600636E RID: 25454 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void EDGAJJGNOLC(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x0600636F RID: 25455 RVA: 0x002E317A File Offset: 0x002E137A
	public int MFABPNBBICL()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006370 RID: 25456 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void PIFGINKGJHL(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x06006371 RID: 25457 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float KCPOIFLIFKD()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x06006372 RID: 25458 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float LJNCCMPFPLG()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x06006373 RID: 25459 RVA: 0x002E3FF4 File Offset: 0x002E21F4
	public virtual void POICNHBNPDL(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "'>");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -89
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1307f, this.OCHCODJIPHJ.y + 1358f, this.OCHCODJIPHJ.width - 1580f, 994f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 106f, this.OCHCODJIPHJ.y + 384f, 51f, 526f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 235f;
				position.y += 559f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(4, 6, 3));
		if (GUI.Button(position, "</color>", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(" has been disabled as it's not supported on the current platform.", 1833f);
			this.GAJHGCPBGME -= 341f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1066f, this.OCHCODJIPHJ.y + 1462f, 1966f, 945f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 194f;
				position.y += 1473f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(1, 3, 8));
		if (GUI.Button(position, "h)", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Mouse Y", 646f);
			this.GAJHGCPBGME += 1177f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 407f, this.OCHCODJIPHJ.y + 83f, this.OCHCODJIPHJ.width - 287f, 821f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006374 RID: 25460 RVA: 0x002E317A File Offset: 0x002E137A
	public int PBBFDAPEACF()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006375 RID: 25461 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void BOMGJDOGAAM(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006376 RID: 25462 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void DPFALHEGCHH(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006377 RID: 25463 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void LFEFKGLEKJI(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006378 RID: 25464 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float IKPCDDLGKNL()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x002E4390 File Offset: 0x002E2590
	public virtual void OPAJOHMJIJJ(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "SoccerKeeperDiveStrafeFarRight");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 2
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1484f, this.OCHCODJIPHJ.y + 1924f, this.OCHCODJIPHJ.width - 1690f, 1420f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 925f, this.OCHCODJIPHJ.y + 794f, 1873f, 1905f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1894f;
				position.y += 1503f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(3, 7, 8));
		if (GUI.Button(position, "CM", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("_name", 231f);
			this.GAJHGCPBGME -= 48f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 616f, this.OCHCODJIPHJ.y + 1575f, 1382f, 1443f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 116f;
				position.y += 1377f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 1, 2));
		if (GUI.Button(position, "***DropPointerEvnt", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k.html", 1030f);
			this.GAJHGCPBGME += 179f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 298f, this.OCHCODJIPHJ.y + 228f, this.OCHCODJIPHJ.width - 1144f, 1177f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600637A RID: 25466 RVA: 0x002E472C File Offset: 0x002E292C
	public virtual void LBMNPGFIJBK(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "post_msg1");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 117
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1695f, this.OCHCODJIPHJ.y + 1258f, this.OCHCODJIPHJ.width - 975f, 1373f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 673f, this.OCHCODJIPHJ.y + 1868f, 1375f, 881f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 833f;
				position.y += 46f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(5, 1, 8));
		if (GUI.Button(position, "Only Hinge Rotation Limits should be used on 2D IK solvers.", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("kfB", 248f);
			this.GAJHGCPBGME -= 1430f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 192f, this.OCHCODJIPHJ.y + 907f, 1435f, 1407f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 153f;
				position.y += 1149f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(1, 6, 3));
		if (GUI.Button(position, "Hand ", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("linebreak.ogg", 410f);
			this.GAJHGCPBGME += 185f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 570f, this.OCHCODJIPHJ.y + 1619f, this.OCHCODJIPHJ.width - 114f, 1206f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600637B RID: 25467 RVA: 0x002E4AC8 File Offset: 0x002E2CC8
	public virtual void BBHMAPMJCKJ(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "************ isChangedRod *********");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -123
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 784f, this.OCHCODJIPHJ.y + 1472f, this.OCHCODJIPHJ.width - 226f, 1651f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1185f, this.OCHCODJIPHJ.y + 1740f, 1925f, 893f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1442f;
				position.y += 1072f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(4, 6, 4));
		if (GUI.Button(position, "Rooms SET", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ(" Категория ", 980f);
			this.GAJHGCPBGME -= 102f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 683f, this.OCHCODJIPHJ.y + 22f, 1619f, 1194f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1999f;
				position.y += 942f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(1, 0, 4));
		if (GUI.Button(position, "no_model_fish ", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("_Offsets", 809f);
			this.GAJHGCPBGME += 1597f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1257f, this.OCHCODJIPHJ.y + 26f, this.OCHCODJIPHJ.width - 1827f, 737f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600637C RID: 25468 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void CCMFFPDKIGH(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600637D RID: 25469 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float NKNHMDFFAHJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x0600637E RID: 25470 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void JLHNCIDFOLA(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x0600637F RID: 25471 RVA: 0x002E317A File Offset: 0x002E137A
	public int POEAFGMAJCL()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006380 RID: 25472 RVA: 0x002E317A File Offset: 0x002E137A
	public int PKEJPHHHFMN()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006381 RID: 25473 RVA: 0x002E317A File Offset: 0x002E137A
	public int HMFBNENJCDM()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006382 RID: 25474 RVA: 0x002E4E64 File Offset: 0x002E3064
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 12
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 10f, this.OCHCODJIPHJ.y + 6f, this.OCHCODJIPHJ.width - 20f, 18f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 10f, this.OCHCODJIPHJ.y + 23f, 16f, 16f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1f;
				position.y += 1f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(2, 2, 4));
		if (GUI.Button(position, "", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
			this.GAJHGCPBGME -= 1f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 26f, this.OCHCODJIPHJ.y + 23f, 16f, 16f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1f;
				position.y += 1f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 2, 4));
		if (GUI.Button(position, "", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
			this.GAJHGCPBGME += 1f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 28f, this.OCHCODJIPHJ.y + 25f, this.OCHCODJIPHJ.width - 56f, 14f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006383 RID: 25475 RVA: 0x002E5200 File Offset: 0x002E3400
	public virtual void OEGEMMPIIPC(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "knopje.wav");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -74
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 437f, this.OCHCODJIPHJ.y + 1943f, this.OCHCODJIPHJ.width - 1421f, 1918f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 387f, this.OCHCODJIPHJ.y + 978f, 599f, 1515f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1069f;
				position.y += 300f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(2, 3, 4));
		if (GUI.Button(position, "KatanaReady", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("OneHandSwordReady", 640f);
			this.GAJHGCPBGME -= 1264f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 247f, this.OCHCODJIPHJ.y + 847f, 1316f, 189f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 755f;
				position.y += 1945f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(1, 3, 4));
		if (GUI.Button(position, "", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("chnam3", 237f);
			this.GAJHGCPBGME += 593f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 768f, this.OCHCODJIPHJ.y + 379f, this.OCHCODJIPHJ.width - 985f, 255f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06006384 RID: 25476 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	// (set) Token: 0x060063DD RID: 25565 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public float AHJFJJHLDEO
	{
		get
		{
			return this.GAJHGCPBGME;
		}
		set
		{
			this.GAJHGCPBGME = value;
		}
	}

	// Token: 0x06006385 RID: 25477 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float LANKCCJPLJM()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x06006386 RID: 25478 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float KEOHICLIEJJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x06006387 RID: 25479 RVA: 0x002E559C File Offset: 0x002E379C
	public virtual void BMJHKNBKINK(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "DealerFan");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -97
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1536f, this.OCHCODJIPHJ.y + 1783f, this.OCHCODJIPHJ.width - 94f, 747f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 424f, this.OCHCODJIPHJ.y + 1562f, 1851f, 851f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 792f;
				position.y += 844f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(3, 7, 3));
		if (GUI.Button(position, "shop_t8", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Try Goscurry! Or better buy it!", 48f);
			this.GAJHGCPBGME -= 112f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1442f, this.OCHCODJIPHJ.y + 515f, 1914f, 1516f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1533f;
				position.y += 250f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(1, 8, 6));
		if (GUI.Button(position, "[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("IdleMonster", 781f);
			this.GAJHGCPBGME += 208f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1770f, this.OCHCODJIPHJ.y + 706f, this.OCHCODJIPHJ.width - 1951f, 1558f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006388 RID: 25480 RVA: 0x002E5938 File Offset: 0x002E3B38
	public virtual void KJFNHNJEADK(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "wpn_sost");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -101
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 885f, this.OCHCODJIPHJ.y + 538f, this.OCHCODJIPHJ.width - 365f, 840f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 390f, this.OCHCODJIPHJ.y + 737f, 590f, 1103f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 91f;
				position.y += 723f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(7, 2, 6));
		if (GUI.Button(position, "GiantGrabIdle", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("", 162f);
			this.GAJHGCPBGME -= 31f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1302f, this.OCHCODJIPHJ.y + 1726f, 1385f, 1272f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1909f;
				position.y += 756f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(0, 3, 7));
		if (GUI.Button(position, "_Bloom_DirtTex", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO(" ", 812f);
			this.GAJHGCPBGME += 484f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1971f, this.OCHCODJIPHJ.y + 149f, this.OCHCODJIPHJ.width - 541f, 681f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006389 RID: 25481 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void HGOENFIDAIA(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600638A RID: 25482 RVA: 0x002E5CD4 File Offset: 0x002E3ED4
	public virtual void OCCJHOPJHLG(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "WalkBackward");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -69
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1716f, this.OCHCODJIPHJ.y + 1076f, this.OCHCODJIPHJ.width - 1184f, 1181f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1972f, this.OCHCODJIPHJ.y + 667f, 1067f, 227f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1671f;
				position.y += 1260f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(2, 2, 6));
		if (GUI.Button(position, "CrouchWalk", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("1 Hand Sword Ready", 286f);
			this.GAJHGCPBGME -= 1290f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1455f, this.OCHCODJIPHJ.y + 895f, 1294f, 1152f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 515f;
				position.y += 1212f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(0, 2, 4));
		if (GUI.Button(position, "_AdditiveReflection", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("wpn_rem3", 1803f);
			this.GAJHGCPBGME += 318f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1207f, this.OCHCODJIPHJ.y + 1170f, this.OCHCODJIPHJ.width - 1015f, 1179f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600638B RID: 25483 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void ONJDFINLOMN(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x0600638C RID: 25484 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float OMBPGPNJNKJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x0600638D RID: 25485 RVA: 0x002E317A File Offset: 0x002E137A
	public int PBOJPOOAINN()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x0600638E RID: 25486 RVA: 0x002E317A File Offset: 0x002E137A
	public int JDCFHFGBPHC()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void JHGJPLAENEH(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x06006390 RID: 25488 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void MIPFENDMPIA(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006391 RID: 25489 RVA: 0x002E317A File Offset: 0x002E137A
	public int CMFKKPMGPFM()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006392 RID: 25490 RVA: 0x002E317A File Offset: 0x002E137A
	public int HGHNICIBNNA()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x06006393 RID: 25491 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void EGFGCCJKGFJ(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x06006394 RID: 25492 RVA: 0x002E6070 File Offset: 0x002E4270
	public virtual void BNBECPLPKGM(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "PaperTurn.wav");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -59
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 700f, this.OCHCODJIPHJ.y + 1156f, this.OCHCODJIPHJ.width - 654f, 41f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1902f, this.OCHCODJIPHJ.y + 4f, 451f, 970f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1491f;
				position.y += 491f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(2, 8, 2));
		if (GUI.Button(position, "{0}:{1}:{2}:{3}", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(".", 1749f);
			this.GAJHGCPBGME -= 733f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1464f, this.OCHCODJIPHJ.y + 33f, 1121f, 782f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1675f;
				position.y += 1441f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(0, 4, 6));
		if (GUI.Button(position, "fchair_", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("", 807f);
			this.GAJHGCPBGME += 1423f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 199f, this.OCHCODJIPHJ.y + 1524f, this.OCHCODJIPHJ.width - 1886f, 774f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006395 RID: 25493 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void MBJJBNBGGFN(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x06006396 RID: 25494 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void DDOBNBKKGOM(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x06006397 RID: 25495 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void LOCFBHEJEIB(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06006398 RID: 25496 RVA: 0x002E317A File Offset: 0x002E137A
	// (set) Token: 0x060063D1 RID: 25553 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public int LPBLKNELCLO
	{
		get
		{
			return (int)this.GAJHGCPBGME;
		}
		set
		{
			this.GAJHGCPBGME = (float)value;
		}
	}

	// Token: 0x06006399 RID: 25497 RVA: 0x002E640C File Offset: 0x002E460C
	public virtual void JJOAFJPOLMA(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "Dealer Shuffle");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 110
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 57f, this.OCHCODJIPHJ.y + 13f, this.OCHCODJIPHJ.width - 658f, 253f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 620f, this.OCHCODJIPHJ.y + 1694f, 610f, 848f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 257f;
				position.y += 422f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(0, 3, 5));
		if (GUI.Button(position, "RollerBladeJump", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("pinky", 277f);
			this.GAJHGCPBGME -= 318f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 11f, this.OCHCODJIPHJ.y + 16f, 1069f, 1212f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 954f;
				position.y += 1488f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(1, 7, 2));
		if (GUI.Button(position, "wpn_wgt", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("", 1742f);
			this.GAJHGCPBGME += 507f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 559f, this.OCHCODJIPHJ.y + 1615f, this.OCHCODJIPHJ.width - 1718f, 280f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600639A RID: 25498 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void HIKHEKGHLCM(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600639B RID: 25499 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void MEOFBPLCEAK(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x0600639C RID: 25500 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void JDLPGINBECN(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x0600639D RID: 25501 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void LLGDHACFICE(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x0600639E RID: 25502 RVA: 0x002E67A8 File Offset: 0x002E49A8
	public virtual void LKNFIMJJPPO(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "FOG_SCATTERING_ON");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -63
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 337f, this.OCHCODJIPHJ.y + 1027f, this.OCHCODJIPHJ.width - 824f, 930f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 977f, this.OCHCODJIPHJ.y + 1843f, 1813f, 244f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 784f;
				position.y += 913f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(7, 4, 8));
		if (GUI.Button(position, "gi_inte_5", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Hidden/Post FX/Builtin Debug Views", 856f);
			this.GAJHGCPBGME -= 965f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1911f, this.OCHCODJIPHJ.y + 1370f, 434f, 1477f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 294f;
				position.y += 1235f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(0, 6, 8));
		if (GUI.Button(position, "SneakIdle", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Flap_08.wav", 1572f);
			this.GAJHGCPBGME += 1700f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 671f, this.OCHCODJIPHJ.y + 1612f, this.OCHCODJIPHJ.width - 643f, 1346f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600639F RID: 25503 RVA: 0x002E317A File Offset: 0x002E137A
	public int BJIPJGINOID()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063A0 RID: 25504 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void NPBDKNGKPPF(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063A1 RID: 25505 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float KIJIDPHOGLE()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063A2 RID: 25506 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float EOJODCMPOOP()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063A3 RID: 25507 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float ALMFCKNEGPP()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063A4 RID: 25508 RVA: 0x002E317A File Offset: 0x002E137A
	public int EOFLIINIEDG()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063A5 RID: 25509 RVA: 0x002E6B44 File Offset: 0x002E4D44
	public virtual void LEGEOJAFGLJ(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "' is not a valid integer");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 60
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1374f, this.OCHCODJIPHJ.y + 1965f, this.OCHCODJIPHJ.width - 1155f, 1845f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1406f, this.OCHCODJIPHJ.y + 1017f, 1122f, 1846f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1668f;
				position.y += 1759f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(4, 2, 4));
		if (GUI.Button(position, "WateringCan", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("<color='#206000'>", 988f);
			this.GAJHGCPBGME -= 1407f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1401f, this.OCHCODJIPHJ.y + 485f, 1019f, 949f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 852f;
				position.y += 658f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 4, 4));
		if (GUI.Button(position, "MotorbikeWheelyNoHands", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI(" This is not possible to be called for standalone input. Please check your platform and code where this is called", 1681f);
			this.GAJHGCPBGME += 793f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1994f, this.OCHCODJIPHJ.y + 1498f, this.OCHCODJIPHJ.width - 317f, 743f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063A6 RID: 25510 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float ALGKCHGOMME()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063A7 RID: 25511 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void FKJBJPICMOO(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063A8 RID: 25512 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float GDGHJGDJNGD()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063A9 RID: 25513 RVA: 0x002E317A File Offset: 0x002E137A
	public int BICKFLPGBAC()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063AA RID: 25514 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float AMMBOLHDLCG()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063AB RID: 25515 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void FINPBFOEFKC(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063AC RID: 25516 RVA: 0x002E317A File Offset: 0x002E137A
	public int EBPMCGGBNIK()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063AD RID: 25517 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float PKGNCONGNPJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063AE RID: 25518 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void DNGCBDPMJIN(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063AF RID: 25519 RVA: 0x002E6EE0 File Offset: 0x002E50E0
	public virtual void FJNDHHDAGCI(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "PistolFire");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 115
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 256f, this.OCHCODJIPHJ.y + 960f, this.OCHCODJIPHJ.width - 65f, 360f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 651f, this.OCHCODJIPHJ.y + 1915f, 145f, 624f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1879f;
				position.y += 1829f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(5, 5, 1));
		if (GUI.Button(position, "name", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("move", 1973f);
			this.GAJHGCPBGME -= 954f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 286f, this.OCHCODJIPHJ.y + 1548f, 137f, 1686f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1706f;
				position.y += 1707f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(0, 0, 8));
		if (GUI.Button(position, "BowFire2", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("signal_enable", 877f);
			this.GAJHGCPBGME += 12f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 545f, this.OCHCODJIPHJ.y + 1416f, this.OCHCODJIPHJ.width - 1933f, 1043f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063B0 RID: 25520 RVA: 0x002E727C File Offset: 0x002E547C
	public virtual void IPGKLMEDNME(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "_ProjInfo");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 4
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1974f, this.OCHCODJIPHJ.y + 289f, this.OCHCODJIPHJ.width - 922f, 1046f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1892f, this.OCHCODJIPHJ.y + 782f, 89f, 1223f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1353f;
				position.y += 1943f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(8, 8, 8));
		if (GUI.Button(position, "level", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("WeaponReload", 1545f);
			this.GAJHGCPBGME -= 617f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1220f, this.OCHCODJIPHJ.y + 1520f, 54f, 131f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 678f;
				position.y += 841f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(1, 8, 2));
		if (GUI.Button(position, "Elvis Legs", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("<color='#000000'>--------------------------------------------------------</color>", 374f);
			this.GAJHGCPBGME += 103f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1050f, this.OCHCODJIPHJ.y + 817f, this.OCHCODJIPHJ.width - 12f, 676f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063B1 RID: 25521 RVA: 0x002E7618 File Offset: 0x002E5818
	public virtual void ADKOHIFEBIN(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "twist");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 59
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1549f, this.OCHCODJIPHJ.y + 780f, this.OCHCODJIPHJ.width - 1135f, 1222f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 417f, this.OCHCODJIPHJ.y + 1477f, 851f, 796f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 458f;
				position.y += 589f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(7, 3, 5));
		if (GUI.Button(position, "RollerBladeTurnRight", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("", 646f);
			this.GAJHGCPBGME -= 1791f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1700f, this.OCHCODJIPHJ.y + 272f, 93f, 1583f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1290f;
				position.y += 1815f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(1, 1, 4));
		if (GUI.Button(position, "", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("x", 698f);
			this.GAJHGCPBGME += 1553f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 970f, this.OCHCODJIPHJ.y + 1691f, this.OCHCODJIPHJ.width - 709f, 1547f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063B2 RID: 25522 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float PEOIDBDLLJI()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063B3 RID: 25523 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void KKCBPNIGPBB(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063B4 RID: 25524 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void LEFDEFGJDCH(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063B5 RID: 25525 RVA: 0x002E79B4 File Offset: 0x002E5BB4
	public KJPFDOGHGOD(ONKDCGNBALK OCBAOFLJBGP, string DPANHMGCBNL, float POFBHAEFJNE, float AIIFDJADHJP, float KCCBNOLCFFG, float CMBDBNPCPMF, float EJBJCJJMOPJ, float EBLHAJDINBH, bool JIIMKFJNKEO, int ODFEKBJCFMN = 0) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, KCCBNOLCFFG, 45f, DPANHMGCBNL, ODFEKBJCFMN, 7)
	{
		this.JIIMKFJNKEO = JIIMKFJNKEO;
		this.CMBDBNPCPMF = CMBDBNPCPMF;
		this.EJBJCJJMOPJ = EJBJCJJMOPJ;
		this.GAJHGCPBGME = EBLHAJDINBH;
		this.KNIOGNKKINO = 10;
	}

	// Token: 0x060063B6 RID: 25526 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float CJGAEFIHAPJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063B7 RID: 25527 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void EKIGFJMNKOE(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063B8 RID: 25528 RVA: 0x002E7A00 File Offset: 0x002E5C00
	public virtual void NDEKHNDALJJ(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -29
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1420f, this.OCHCODJIPHJ.y + 1240f, this.OCHCODJIPHJ.width - 1026f, 1355f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1819f, this.OCHCODJIPHJ.y + 1099f, 220f, 1561f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1374f;
				position.y += 189f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(8, 7, 7));
		if (GUI.Button(position, "Speed hack detected!", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Apply 7", 1573f);
			this.GAJHGCPBGME -= 43f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 899f, this.OCHCODJIPHJ.y + 361f, 1426f, 1219f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 864f;
				position.y += 1324f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(0, 6, 3));
		if (GUI.Button(position, "StaffPowerUp", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("CraftProf.xml", 1464f);
			this.GAJHGCPBGME += 1433f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1696f, this.OCHCODJIPHJ.y + 796f, this.OCHCODJIPHJ.width - 1962f, 202f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063B9 RID: 25529 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void MPKNEJCDFGH(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063BA RID: 25530 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float PLADBLLGJPB()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063BB RID: 25531 RVA: 0x002E7D9C File Offset: 0x002E5F9C
	public virtual void NJCFBDPPKOB(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), " ");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 55
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1653f, this.OCHCODJIPHJ.y + 1427f, this.OCHCODJIPHJ.width - 1348f, 1616f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 651f, this.OCHCODJIPHJ.y + 1162f, 89f, 248f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 609f;
				position.y += 568f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 1, 7));
		if (GUI.Button(position, "RunBackLeft", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("SneakBackward", 708f);
			this.GAJHGCPBGME -= 1988f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1657f, this.OCHCODJIPHJ.y + 976f, 11f, 728f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1475f;
				position.y += 1710f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 5, 2));
		if (GUI.Button(position, "Steam Overlay has been activated", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("OnChatMessage", 629f);
			this.GAJHGCPBGME += 1101f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1355f, this.OCHCODJIPHJ.y + 187f, this.OCHCODJIPHJ.width - 1541f, 1714f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063BC RID: 25532 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float FINEOCOMLJB()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063BD RID: 25533 RVA: 0x002E8138 File Offset: 0x002E6338
	public virtual void JAGNNAKCJMK(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "IdleStandingJump");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 83
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 701f, this.OCHCODJIPHJ.y + 823f, this.OCHCODJIPHJ.width - 873f, 1480f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 874f, this.OCHCODJIPHJ.y + 1680f, 1627f, 45f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 175f;
				position.y += 1561f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(4, 1, 0));
		if (GUI.Button(position, "MotorbikeShootBack", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Wizard2HandThrow", 497f);
			this.GAJHGCPBGME -= 1306f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1730f, this.OCHCODJIPHJ.y + 437f, 948f, 1457f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 635f;
				position.y += 1029f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(0, 3, 7));
		if (GUI.Button(position, "360SpinDeath", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("IdleStand", 1799f);
			this.GAJHGCPBGME += 1878f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 624f, this.OCHCODJIPHJ.y + 258f, this.OCHCODJIPHJ.width - 814f, 421f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063BE RID: 25534 RVA: 0x002E317A File Offset: 0x002E137A
	public int IDGBGCIIPNE()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063BF RID: 25535 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void LLNJILOGBML(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063C0 RID: 25536 RVA: 0x002E84D4 File Offset: 0x002E66D4
	public virtual void AGFPCNIBKFN(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "WallSit");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 36
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1877f, this.OCHCODJIPHJ.y + 338f, this.OCHCODJIPHJ.width - 1496f, 230f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 965f, this.OCHCODJIPHJ.y + 540f, 295f, 725f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1074f;
				position.y += 1589f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(8, 1, 3));
		if (GUI.Button(position, "_BlurVector", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE(" has been disabled as it requires a depth texture.", 1408f);
			this.GAJHGCPBGME -= 249f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 265f, this.OCHCODJIPHJ.y + 1251f, 1983f, 1209f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 418f;
				position.y += 1582f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(1, 5, 2));
		if (GUI.Button(position, "_Offsets", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("IdleFight", 1479f);
			this.GAJHGCPBGME += 1410f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 695f, this.OCHCODJIPHJ.y + 295f, this.OCHCODJIPHJ.width - 774f, 751f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063C1 RID: 25537 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float AOJAACCAGJJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063C2 RID: 25538 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void GONABEIBOHP(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063C3 RID: 25539 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void NJBHJDBMGJF(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063C4 RID: 25540 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void EFLHBFEGMKE(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063C5 RID: 25541 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void EPFCJHPFJPC(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063C6 RID: 25542 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float OGEKMHAFGME()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063C7 RID: 25543 RVA: 0x002E317A File Offset: 0x002E137A
	public int LHCNNMAMICC()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063C8 RID: 25544 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void BECDGGJLJAB(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063C9 RID: 25545 RVA: 0x002E317A File Offset: 0x002E137A
	public int ILIIFPLDIIA()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063CA RID: 25546 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void LGGKLJKJDMD(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063CB RID: 25547 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void HMCACHFHPNN(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063CC RID: 25548 RVA: 0x002E8870 File Offset: 0x002E6A70
	public virtual void OECNEDDNMGC(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 15
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 740f, this.OCHCODJIPHJ.y + 1716f, this.OCHCODJIPHJ.width - 1137f, 1445f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1761f, this.OCHCODJIPHJ.y + 527f, 1546f, 729f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1200f;
				position.y += 827f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(7, 7, 2));
		if (GUI.Button(position, "UNIQUE_SHADOW_LIGHT_COOKIE", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("OfficeSittingReadingPageFlip", 1972f);
			this.GAJHGCPBGME -= 914f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1264f, this.OCHCODJIPHJ.y + 510f, 1278f, 239f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 409f;
				position.y += 810f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 2, 0));
		if (GUI.Button(position, "?", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("Move around with WASD keys. Press C to enable free look camera", 944f);
			this.GAJHGCPBGME += 1652f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 971f, this.OCHCODJIPHJ.y + 1814f, this.OCHCODJIPHJ.width - 1168f, 1039f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063CD RID: 25549 RVA: 0x002E8C0C File Offset: 0x002E6E0C
	public virtual void INJPGBJBOGM(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "IdleSpew");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -68
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1326f, this.OCHCODJIPHJ.y + 849f, this.OCHCODJIPHJ.width - 1791f, 369f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1932f, this.OCHCODJIPHJ.y + 951f, 200f, 172f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1115f;
				position.y += 1300f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(3, 1, 4));
		if (GUI.Button(position, "isRodInWater", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("myrec", 1409f);
			this.GAJHGCPBGME -= 1770f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1090f, this.OCHCODJIPHJ.y + 392f, 1594f, 179f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1958f;
				position.y += 27f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(0, 6, 1));
		if (GUI.Button(position, "#000000", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("TOD_SunSkyColor", 921f);
			this.GAJHGCPBGME += 1827f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1411f, this.OCHCODJIPHJ.y + 1495f, this.OCHCODJIPHJ.width - 1092f, 732f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063CE RID: 25550 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void JDKPDEHEGMO(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063CF RID: 25551 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float EDJFKCMAOOL()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063D0 RID: 25552 RVA: 0x002E8FA8 File Offset: 0x002E71A8
	public virtual void FDJAIBCFHLL(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "_Axis");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -80
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 830f, this.OCHCODJIPHJ.y + 947f, this.OCHCODJIPHJ.width - 1017f, 853f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1401f, this.OCHCODJIPHJ.y + 297f, 1902f, 1421f);
		if (Input.GetMouseButton(0))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 636f;
				position.y += 1107f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(2, 1, 1));
		if (GUI.Button(position, "_parent", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_Params3", 856f);
			this.GAJHGCPBGME -= 511f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 671f, this.OCHCODJIPHJ.y + 546f, 898f, 1979f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 554f;
				position.y += 395f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(0, 3, 5));
		if (GUI.Button(position, "GestureNoFear", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("CrawlIdle", 1391f);
			this.GAJHGCPBGME += 461f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 808f, this.OCHCODJIPHJ.y + 692f, this.OCHCODJIPHJ.width - 105f, 1940f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063D2 RID: 25554 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void BHLIDPGLNGP(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063D3 RID: 25555 RVA: 0x002E9344 File Offset: 0x002E7544
	public virtual void CMFNGMOCPKE(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), ".lng");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			richText = true,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 80
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 1911f, this.OCHCODJIPHJ.y + 1013f, this.OCHCODJIPHJ.width - 1594f, 659f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 1351f, this.OCHCODJIPHJ.y + 928f, 1893f, 632f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 503f;
				position.y += 1072f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(2, 1, 8));
		if (GUI.Button(position, "OfficeSitting45DegLeg", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Apply 2", 864f);
			this.GAJHGCPBGME -= 19f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 148f, this.OCHCODJIPHJ.y + 1501f, 1848f, 1987f);
		if (Input.GetMouseButton(0))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 1041f;
				position.y += 1114f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(0, 7, 1));
		if (GUI.Button(position, "Jump", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("_AdaptTex", 27f);
			this.GAJHGCPBGME += 394f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1611f, this.OCHCODJIPHJ.y + 1317f, this.OCHCODJIPHJ.width - 92f, 1839f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063D4 RID: 25556 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void OADKFOFHBNG(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063D5 RID: 25557 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float OHJCOFCAENP()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063D6 RID: 25558 RVA: 0x002E317A File Offset: 0x002E137A
	public int HGOHBCOPGDP()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063D7 RID: 25559 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void GGMCDGKJKLK(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063D8 RID: 25560 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void INICFDCBAHG(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063D9 RID: 25561 RVA: 0x002E96E0 File Offset: 0x002E78E0
	public virtual void DLBGNLEIMPB(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height), "ExceptionOnConnect PROCEDURE ");
		GUIStyle style = new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			richText = false,
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -99
		};
		GUI.Label(new Rect(this.OCHCODJIPHJ.x + 771f, this.OCHCODJIPHJ.y + 1322f, this.OCHCODJIPHJ.width - 928f, 1078f), this.DPANHMGCBNL + this.GAJHGCPBGME, style);
		Rect position = new Rect(this.OCHCODJIPHJ.x + 743f, this.OCHCODJIPHJ.y + 1939f, 636f, 1806f);
		if (Input.GetMouseButton(1))
		{
			Rect rect = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 468f;
				position.y += 1790f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(8, 2, 8));
		if (GUI.Button(position, "</color>\n", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("PER_VERTEX", 243f);
			this.GAJHGCPBGME -= 51f;
		}
		position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width - 1407f, this.OCHCODJIPHJ.y + 1631f, 732f, 256f);
		if (Input.GetMouseButton(1))
		{
			Rect rect2 = new Rect(this.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, this.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF) && CFMPGCJMHJM)
			{
				position.x += 641f;
				position.y += 1788f;
			}
		}
		GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(1, 4, 6));
		if (GUI.Button(position, "isKeyPress", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("BAG", 1952f);
			this.GAJHGCPBGME += 577f;
		}
		this.GAJHGCPBGME = GUI.HorizontalSlider(new Rect(this.OCHCODJIPHJ.x + 1195f, this.OCHCODJIPHJ.y + 10f, this.OCHCODJIPHJ.width - 972f, 1087f), this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		if (this.JIIMKFJNKEO)
		{
			this.GAJHGCPBGME = Mathf.Round(this.GAJHGCPBGME);
		}
		this.GAJHGCPBGME = Mathf.Clamp(this.GAJHGCPBGME, this.CMBDBNPCPMF, this.EJBJCJJMOPJ);
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060063DA RID: 25562 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void LOEMBDBBHJL(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063DB RID: 25563 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float OMJFHNILHBJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063DC RID: 25564 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float ACJABPBBODA()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063DE RID: 25566 RVA: 0x002E317A File Offset: 0x002E137A
	public int LCLDBOMJPCH()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063DF RID: 25567 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float PKEFBFNALFO()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063E0 RID: 25568 RVA: 0x002E317A File Offset: 0x002E137A
	public int OFBACMIELFB()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063E1 RID: 25569 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float EDNPGPBEBFN()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063E2 RID: 25570 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void IOBOIONDEAA(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063E3 RID: 25571 RVA: 0x002E317A File Offset: 0x002E137A
	public int CABIPCDKKPD()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063E4 RID: 25572 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void MGKPCIHHNMM(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063E5 RID: 25573 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void DEAPCGPCJEO(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063E6 RID: 25574 RVA: 0x002E2DD6 File Offset: 0x002E0FD6
	public void BCNPEHBJOEI(float DCCPCBLODIG)
	{
		this.GAJHGCPBGME = DCCPCBLODIG;
	}

	// Token: 0x060063E7 RID: 25575 RVA: 0x002E2A32 File Offset: 0x002E0C32
	public void FOLNEEMIGLJ(int DCCPCBLODIG)
	{
		this.GAJHGCPBGME = (float)DCCPCBLODIG;
	}

	// Token: 0x060063E8 RID: 25576 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float MLLJGAHJDAP()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063E9 RID: 25577 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float EDKFHMJHPEJ()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063EA RID: 25578 RVA: 0x002E2A2A File Offset: 0x002E0C2A
	public float FFEPLEHJPNF()
	{
		return this.GAJHGCPBGME;
	}

	// Token: 0x060063EB RID: 25579 RVA: 0x002E317A File Offset: 0x002E137A
	public int CKADLMFJHAJ()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x060063EC RID: 25580 RVA: 0x002E317A File Offset: 0x002E137A
	public int BCFIPDJPPCJ()
	{
		return (int)this.GAJHGCPBGME;
	}

	// Token: 0x04000E61 RID: 3681
	private readonly bool JIIMKFJNKEO;

	// Token: 0x04000E62 RID: 3682
	private readonly float CMBDBNPCPMF;

	// Token: 0x04000E63 RID: 3683
	private readonly float EJBJCJJMOPJ;

	// Token: 0x04000E64 RID: 3684
	private float GAJHGCPBGME;
}
