using System;
using UnityEngine;

// Token: 0x020001AC RID: 428
public class KLIKIJOLPPJ : ONKDCGNBALK
{
	// Token: 0x06005FBA RID: 24506 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void HACFJGOGHNE(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06005FCE RID: 24526 RVA: 0x002CB948 File Offset: 0x002C9B48
	// (set) Token: 0x06005FBB RID: 24507 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public bool JACCONMLOOE
	{
		get
		{
			return this.IPEGPEDKGGK;
		}
		set
		{
			this.IPEGPEDKGGK = value;
		}
	}

	// Token: 0x06005FBC RID: 24508 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void LLCDJFFMMDL(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FBD RID: 24509 RVA: 0x002CB868 File Offset: 0x002C9A68
	public virtual void NEHJDJAAMEO(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1845f)
			{
				Vector2 vector = GUI.skin.GetStyle("<color='#a0ff30'>F: {0}</color>").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("</color>", 307f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("\n");
		}
	}

	// Token: 0x06005FBE RID: 24510 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool IONONCOJNMD()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FBF RID: 24511 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool FPAMHHEFGDO()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FC0 RID: 24512 RVA: 0x002CB950 File Offset: 0x002C9B50
	public virtual void OLHEECEMJDD(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 658f)
			{
				Vector2 vector = GUI.skin.GetStyle("WATER_REFLECTIVE").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("BlurXY", 23f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("maxWgtBait");
		}
	}

	// Token: 0x06005FC1 RID: 24513 RVA: 0x002CBA30 File Offset: 0x002C9C30
	public virtual void EGKHIENICMJ(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1714f)
			{
				Vector2 vector = GUI.skin.GetStyle("crft_btn2").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("DragObject", 1564f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("auk_wavg");
		}
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool OAPMLECNPGE()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FC3 RID: 24515 RVA: 0x002CBB10 File Offset: 0x002C9D10
	public KLIKIJOLPPJ(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, string DPANHMGCBNL, int ODFEKBJCFMN, bool IJHNKCHCCOA) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, 1f, 1f, DPANHMGCBNL, ODFEKBJCFMN, 8)
	{
		this.KNIOGNKKINO = 7;
		this.IPEGPEDKGGK = IJHNKCHCCOA;
	}

	// Token: 0x06005FC4 RID: 24516 RVA: 0x002CBB44 File Offset: 0x002C9D44
	public virtual void GMLICBKPPCC(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1350f)
			{
				Vector2 vector = GUI.skin.GetStyle("Missing shader in ").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Wall hack Detected!", 1654f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("MotorbikeSpecialFlip");
		}
	}

	// Token: 0x06005FC5 RID: 24517 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void LOPMEGCLKFH(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FC6 RID: 24518 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void HDCGNFCIFMH(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FC7 RID: 24519 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void FLFFDHHJKIN(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FC8 RID: 24520 RVA: 0x002CBC24 File Offset: 0x002C9E24
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1f)
			{
				Vector2 vector = GUI.skin.GetStyle("Toggle").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("ui_default_click.wav", 0.5f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("WSRButton error");
		}
	}

	// Token: 0x06005FC9 RID: 24521 RVA: 0x002CBD04 File Offset: 0x002C9F04
	public virtual void FDCOFCOIHEH(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 56f)
			{
				Vector2 vector = GUI.skin.GetStyle("Middle click").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("1HandSwordStrafeLeft", 647f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("_BgColor");
		}
	}

	// Token: 0x06005FCA RID: 24522 RVA: 0x002CBDE4 File Offset: 0x002C9FE4
	public virtual void OAPAJJAJPEK(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 387f)
			{
				Vector2 vector = GUI.skin.GetStyle("").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Turn Right", 1088f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("u_UniqueShadowLightWidth");
		}
	}

	// Token: 0x06005FCB RID: 24523 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool HBDCKDJPCGD()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FCC RID: 24524 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void AGCNGJGEFMG(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FCD RID: 24525 RVA: 0x002CBEC4 File Offset: 0x002CA0C4
	public virtual void HADLKLNMMNC(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 416f)
			{
				Vector2 vector = GUI.skin.GetStyle("OnGround").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("KatanaReadyHigh", 139f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError(" ms");
		}
	}

	// Token: 0x06005FCF RID: 24527 RVA: 0x002CBFA4 File Offset: 0x002CA1A4
	public virtual void PHJEFJPDDDI(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1327f)
			{
				Vector2 vector = GUI.skin.GetStyle("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("<color='#000000'>{0}</color><color='#002000'>$</color>", 1034f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("********* End INSTANIATE Level  instLevelTime=");
		}
	}

	// Token: 0x06005FD0 RID: 24528 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool ENNONHMMFND()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FD1 RID: 24529 RVA: 0x002CC084 File Offset: 0x002CA284
	public virtual void DKOEJJHKMHI(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1678f)
			{
				Vector2 vector = GUI.skin.GetStyle("FOG CUTTING ON").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("_EMISSION", 14f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("invn_rec1");
		}
	}

	// Token: 0x06005FD2 RID: 24530 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void NBHBMBIEDAG(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FD3 RID: 24531 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void KAOIIIBJEFC(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FD4 RID: 24532 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool BDINGIEKAPD()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FD5 RID: 24533 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool FPIKHIBJMJP()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool BGDFCHPMFAN()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FD7 RID: 24535 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void OGCKEOIIHJO(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FD8 RID: 24536 RVA: 0x002CC164 File Offset: 0x002CA364
	public virtual void MBABINJIPDF(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1690f)
			{
				Vector2 vector = GUI.skin.GetStyle("Superman").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("__b", 1337f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("_ToneCurve");
		}
	}

	// Token: 0x06005FD9 RID: 24537 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool KOPNJJANCED()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FDA RID: 24538 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void HDILBHEAAKE(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FDB RID: 24539 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool MOHAGFLFILC()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FDC RID: 24540 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool LCIGFNMKALF()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void NOAMLACPCHM(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x002CB85F File Offset: 0x002C9A5F
	public void NBILFEDKGGA(bool DCCPCBLODIG)
	{
		this.IPEGPEDKGGK = DCCPCBLODIG;
	}

	// Token: 0x06005FDF RID: 24543 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool DHHGGCBFLOF()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FE0 RID: 24544 RVA: 0x002CC244 File Offset: 0x002CA444
	public virtual void BLGIOPMGMPG(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 1306f)
			{
				Vector2 vector = GUI.skin.GetStyle("DeadmanFloat").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("CD", 870f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError(" ");
		}
	}

	// Token: 0x06005FE1 RID: 24545 RVA: 0x002CB948 File Offset: 0x002C9B48
	public bool FKGJKAGHJHL()
	{
		return this.IPEGPEDKGGK;
	}

	// Token: 0x06005FE2 RID: 24546 RVA: 0x002CC324 File Offset: 0x002CA524
	public virtual void FCCFIHJKFNK(bool CFMPGCJMHJM)
	{
		try
		{
			if (this.OCHCODJIPHJ.width <= 758f)
			{
				Vector2 vector = GUI.skin.GetStyle("PaperTurn.wav").CalcSize(new GUIContent(this.DPANHMGCBNL));
				this.OCHCODJIPHJ.width = vector.x;
				this.OCHCODJIPHJ.height = vector.y;
			}
			bool ipegpedkggk = this.IPEGPEDKGGK;
			this.IPEGPEDKGGK = GUI.Toggle(this.OCHCODJIPHJ, this.IPEGPEDKGGK, this.DPANHMGCBNL);
			if (CFMPGCJMHJM && this.IPEGPEDKGGK != ipegpedkggk)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("sound/steps/step", 1543f);
				if (this.LJIEPIPIAJC != null)
				{
					this.LJIEPIPIAJC(this);
				}
			}
			base.HFJFBDPNCCB(CFMPGCJMHJM);
		}
		catch
		{
			Debug.LogError("LMB to shoot the Dummy, RMB to rotate the camera.");
		}
	}

	// Token: 0x04000DEC RID: 3564
	private bool IPEGPEDKGGK;
}
