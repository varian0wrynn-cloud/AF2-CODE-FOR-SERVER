using System;
using UnityEngine;

// Token: 0x020001B5 RID: 437
public class OCLNJMKDBKB : ONKDCGNBALK
{
	// Token: 0x06006200 RID: 25088 RVA: 0x002D92D4 File Offset: 0x002D74D4
	public virtual void GHGLBEBFGAP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1616f, this.OCHCODJIPHJ.y, 1314f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle.fontSize = 30;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "INTERFACE";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "\n" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "Name: ";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "http://www.root-motion.com/finalikdox/html/page7.html" + num + "/";
					if (this.ILFHHDNJHNM > num)
					{
						text = "OneHandSwordBlock" + text + "#ff6000";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "upRod" + text + "_HitPosition";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 200f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006201 RID: 25089 RVA: 0x002D94C4 File Offset: 0x002D76C4
	public virtual void NEHJDJAAMEO(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1248f, this.OCHCODJIPHJ.y, 216f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle.fontSize = 64;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "_BlurVector";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "MotorbikeTurnLeft" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text = "";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "gi_inte_4" + num + "\n";
					if (this.ILFHHDNJHNM > num)
					{
						text = "IdleMonster" + text + "GiantGrabIdle";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "Projector reference not set." + text + "FlyLeft";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1371f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006202 RID: 25090 RVA: 0x002D96B4 File Offset: 0x002D78B4
	public virtual void KCHEILEJGPL(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 575f, this.OCHCODJIPHJ.y, 1048f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle.fontSize = 45;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "Bow Ready";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "Bias" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "_VelocityTex";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "" + num + "";
					if (this.ILFHHDNJHNM > num)
					{
						text = " " + text + "[F_KLEV]";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "_NeighbourMaxTex" + text + "_BlurRadius4";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1845f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006203 RID: 25091 RVA: 0x002D98A4 File Offset: 0x002D7AA4
	public virtual void JIGDBPIJDHE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 549f, this.OCHCODJIPHJ.y, 1075f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle.fontSize = 4;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = ": ";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "Tip" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "Missing shader in ";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "RollerBladeStand" + num + "https://www.youtube.com/watch?v=wT8fViZpLmQ";
					if (this.ILFHHDNJHNM > num)
					{
						text = "" + text + "OpenRecords";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "100" + text + "KatanaReadyLow";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1078f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006204 RID: 25092 RVA: 0x002D9A94 File Offset: 0x002D7C94
	public virtual void GMLICBKPPCC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1340f, this.OCHCODJIPHJ.y, 249f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle.fontSize = 72;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "SwimDogPaddle";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "WallRunRight" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "_Vignette_Center";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "}" + num + "+";
					if (this.ILFHHDNJHNM > num)
					{
						text = "wpn_add/base" + text + " iterations for read and write";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "\n" + text + "The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1371f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006205 RID: 25093 RVA: 0x002D9C84 File Offset: 0x002D7E84
	public virtual void LMIIDBOCFPI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1723f, this.OCHCODJIPHJ.y, 667f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle.fontSize = -14;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "wpn_add/addoptions";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "_ThirdTex" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text = "H ";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "NadeThrow" + num + "MotorbikeIdle";
					if (this.ILFHHDNJHNM > num)
					{
						text = "SPECIAL" + text + "fider_Empty.ogg";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "[ProBuilder Attachments] A pb_Object is missing, this is normally caused by pb_Objects being stripped." + text + "SoundMgr is init part 2";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 976f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006206 RID: 25094 RVA: 0x002D9E74 File Offset: 0x002D8074
	public virtual void JBBGCIICJIH(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 666f, this.OCHCODJIPHJ.y, 614f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle.fontSize = -110;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "isMoving";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "LookUp" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text = "Soccer Sprint";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = " cm" + num + "perk_";
					if (this.ILFHHDNJHNM > num)
					{
						text = "Grounded Directional" + text + "_FogParams";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "X" + text + "?";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1364f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006207 RID: 25095 RVA: 0x002DA064 File Offset: 0x002D8264
	public virtual void EGKHIENICMJ(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 243f, this.OCHCODJIPHJ.y, 253f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle.fontSize = 92;
				guistyle.wordWrap = true;
				guistyle.richText = true;
				string str = "PistolFire";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "IdleReadyLook" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text = "_ChannelMixerGreen";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "isBrag" + num + " ";
					if (this.ILFHHDNJHNM > num)
					{
						text = "Failed to load AssetBundle " + text + "_DstBlend";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "harvestmsg1" + text + "BipedReferences spine hierarchy is invalid. Bone transforms in the spine do not belong to the same ancestry. Please make sure the bones are parented to each other.";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 54f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006208 RID: 25096 RVA: 0x002DA254 File Offset: 0x002D8454
	public virtual void FCCFIHJKFNK(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 531f, this.OCHCODJIPHJ.y, 582f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperLeft
				};
				guistyle.fontSize = -67;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "[Y]";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "wpn_bait1" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text = "SneakRight";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text = "cut.ogg" + num + "_rcIn.ogg";
					if (this.ILFHHDNJHNM > num)
					{
						text = "There is already a virtual axis named " + text + "Giant Eat";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "W" + text + "Front Kick";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 783f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006209 RID: 25097 RVA: 0x002DA444 File Offset: 0x002D8644
	public virtual void LNEKEJJIHHP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 336f, this.OCHCODJIPHJ.y, 1915f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle.fontSize = -73;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "_OffsetScale";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "isKeyPress" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(false, -1);
				string text = "Idle Button Press";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "wpn_onlyw" + num + "wpn_bait_typ_{0}";
					if (this.ILFHHDNJHNM > num)
					{
						text = "str=" + text + "";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "reel_type0" + text + "[ACTk] Injection Detector: already running!";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 505f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600620A RID: 25098 RVA: 0x002DA634 File Offset: 0x002D8834
	public virtual void OEGEMMPIIPC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1208f, this.OCHCODJIPHJ.y, 1157f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle.fontSize = -71;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "bs_hilv";
				if (this.ILFHHDNJHNM > 0)
				{
					str = ".ogg" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text = "Circular parenting. ";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "isAlwaisGetFish" + num + "Titul.xml";
					if (this.ILFHHDNJHNM > num)
					{
						text = "FistPump" + text + "Brow";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "SkateboardIdle" + text + " <color='#a0a070'>Бонус от `{0}` </color>";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 738f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x002DA824 File Offset: 0x002D8A24
	public virtual void LCIKLFLKPEE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 956f, this.OCHCODJIPHJ.y, 1103f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle.fontSize = 43;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "demoDouble";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "auk_data/categories/category" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text = "\n";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "_Cull" + num + "IdleStand";
					if (this.ILFHHDNJHNM > num)
					{
						text = "(game main)" + text + "bool: ";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project." + text + "_WaveScale";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1712f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x002DAA14 File Offset: 0x002D8C14
	public virtual void HCHJHBGEGMP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1804f, this.OCHCODJIPHJ.y, 1233f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle.fontSize = 111;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "new wpn lot ";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "_WaveScale4" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text = "This method requires a mesh filter!";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "UIPCam_pos" + num + "WorkerPickaxe";
					if (this.ILFHHDNJHNM > num)
					{
						text = "isUsedPersonal" + text + "WalkBackward";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "cut.ogg" + text + "_rcIn.ogg";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 915f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x002DAC04 File Offset: 0x002D8E04
	public virtual void BIJMKMEPBIC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1009f, this.OCHCODJIPHJ.y, 1721f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle.fontSize = -73;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "Sat Night Fever";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "wplabel" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "Try to change this string in memory:\n";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "languageid" + num + "__c";
					if (this.ILFHHDNJHNM > num)
					{
						text = "" + text + "Delete";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "Speed" + text + "costwpn=";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1232f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600620E RID: 25102 RVA: 0x002DADF4 File Offset: 0x002D8FF4
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 8f, this.OCHCODJIPHJ.y, 200f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle.fontSize = 14;
				guistyle.wordWrap = true;
				guistyle.richText = true;
				string str = "";
				if (this.ILFHHDNJHNM > 0)
				{
					str = " x" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text = "";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "\nу вас есть " + num + " шт.";
					if (this.ILFHHDNJHNM > num)
					{
						text = "<color='#400000'>" + text + "</color>";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "<color='#103000'>" + text + "</color>";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 0f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600620F RID: 25103 RVA: 0x002DAFE4 File Offset: 0x002D91E4
	public virtual void LCOKOEMNPEL(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1607f, this.OCHCODJIPHJ.y, 1390f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle.fontSize = 46;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "Horizontal";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "auk_wmax" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text = "invn_rec26";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "CrouchStrafeLeft" + num + "StaffStand";
					if (this.ILFHHDNJHNM > num)
					{
						text = "System.Boolean" + text + "IdleReady";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "author" + text + "Quest langfile not found!";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1134f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x002DB1D4 File Offset: 0x002D93D4
	public virtual void ECLJBBPGNPA(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 626f, this.OCHCODJIPHJ.y, 803f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle.fontSize = 16;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = "ObscuredString:";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "_OcclusionTexture" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(false, -1);
				string text = "[fish]";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "Crouch180" + num + "#b0ffa0";
					if (this.ILFHHDNJHNM > num)
					{
						text = "_QualitySettings" + text + "Failed parsing default rotation values.  Using defaults.";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "hlp_" + text + "Explosions";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 866f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006211 RID: 25105 RVA: 0x002DB3C4 File Offset: 0x002D95C4
	public virtual void JIAOONGONPM(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 698f, this.OCHCODJIPHJ.y, 1111f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperRight
				};
				guistyle.fontSize = 55;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "Images/MouseCursor/Arrow";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "cntx_close" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "64";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "GiantGrabIdle2" + num + "https://groups.google.com/forum/#!forum/final-ik";
					if (this.ILFHHDNJHNM > num)
					{
						text = "base" + text + "";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "_HalfResolution" + text + "cancel";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 687f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x002DB5B4 File Offset: 0x002D97B4
	public virtual void FDCOFCOIHEH(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1868f, this.OCHCODJIPHJ.y, 1345f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle.fontSize = -89;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "Save";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "   " + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text = "demoByteArray";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "Assets/Weapons/" + num + "";
					if (this.ILFHHDNJHNM > num)
					{
						text = " гр " + text + "References has no spine bones assigned, can not initiate the solver.";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "crft_from" + text + "Sampling AO on ";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1414f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006213 RID: 25107 RVA: 0x002DB7A4 File Offset: 0x002D99A4
	public virtual void OAPAJJAJPEK(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1480f, this.OCHCODJIPHJ.y, 1543f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle.fontSize = -89;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = "WATERMODE";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "Level loading error Level ID=" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(false, -1);
				string text = "crft_from";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text = "WalkBackward" + num + "offsets";
					if (this.ILFHHDNJHNM > num)
					{
						text = "1 Hand Sword Jab Combo" + text + "lifeBar";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "1HSwordStrafeRunRight" + text + "SixStep";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 145f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006214 RID: 25108 RVA: 0x002DB994 File Offset: 0x002D9B94
	public virtual void PHJEFJPDDDI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 353f, this.OCHCODJIPHJ.y, 448f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle.fontSize = 20;
				guistyle.wordWrap = true;
				guistyle.richText = true;
				string str = "drag_onmousedown.wav";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "Hidden/Post FX/Temporal Anti-aliasing" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text = "Katana Ninja Draw";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "AntaresController" + num + ",";
					if (this.ILFHHDNJHNM > num)
					{
						text = "\n" + text + " - ";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "u_UniqueShadowFilterWidth" + text + "cht_msg31";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1020f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006215 RID: 25109 RVA: 0x002DBB84 File Offset: 0x002D9D84
	public virtual void APOPIOPIFMP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 28f, this.OCHCODJIPHJ.y, 114f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle.fontSize = 30;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "base";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "RollerBladeJump" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text = "priceCr";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text = "_VignetteTex" + num + "OfficeSittingBack";
					if (this.ILFHHDNJHNM > num)
					{
						text = "IdleSadHips" + text + "<color='#800000'>Вы потеряли леску: ";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "Bend Constraint is referencing to a bone '" + text + "gi_uinf_4";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 103f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006216 RID: 25110 RVA: 0x002DBD74 File Offset: 0x002D9F74
	public virtual void BLGIOPMGMPG(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1989f, this.OCHCODJIPHJ.y, 647f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle.fontSize = -67;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = "<color='#405000'>";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "GiantGrabIdle2" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text = "defDur";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "chnam2" + num + "";
					if (this.ILFHHDNJHNM > num)
					{
						text = " Collider" + text + "MotorbikeShootFwd";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "<color=blue>$&</color>" + text + "Roller Crossover Right";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1481f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006217 RID: 25111 RVA: 0x002DBF64 File Offset: 0x002DA164
	public virtual void KNCJKEEICGO(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1092f, this.OCHCODJIPHJ.y, 1710f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle.fontSize = -6;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "31";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "Проверьте правильность логина и пароля!" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(false, -1);
				string text = "PreserveDetails";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "Bases/{0}/" + num + "head";
					if (this.ILFHHDNJHNM > num)
					{
						text = "Horizontal" + text + "Bow Instant";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "No fish in fishModelData modelid=" + text + "http://af-2.ru/?q=store";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 780f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006218 RID: 25112 RVA: 0x002DC154 File Offset: 0x002DA354
	public OCLNJMKDBKB(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float BBOODPCDKAJ, BEFCHFNGOMI MEJMEKODJAE, int PPJJJAGNADB) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, BBOODPCDKAJ, BBOODPCDKAJ, "", PPJJJAGNADB, 7)
	{
		this.MBANOJNPAIC = MEJMEKODJAE;
	}

	// Token: 0x06006219 RID: 25113 RVA: 0x002DC188 File Offset: 0x002DA388
	public virtual void FJNDHHDAGCI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1106f, this.OCHCODJIPHJ.y, 653f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperLeft
				};
				guistyle.fontSize = 15;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "dir";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "SwimDogPaddle" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(false, -1);
				string text = "Collaps all foldouts";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "isMoving" + num + "ShotgunReadyFire";
					if (this.ILFHHDNJHNM > num)
					{
						text = "SoccerPassHeavy" + text + "\n";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "pf1m" + text + "wpn_eat5";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 818f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600621A RID: 25114 RVA: 0x002DC378 File Offset: 0x002DA578
	public virtual void AMEAHFNAHDC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1492f, this.OCHCODJIPHJ.y, 1001f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle.fontSize = 52;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "_r_";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "run" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text = "wpn_ibsize_";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "IdleButtonPress" + num + "WorkerShovel2";
					if (this.ILFHHDNJHNM > num)
					{
						text = "fider_Small_" + text + "demoQuaternion";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = " B:" + text + "ShotgunFire";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1770f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600621B RID: 25115 RVA: 0x002DC568 File Offset: 0x002DA768
	public virtual void LNNEOFFJJJA(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1082f, this.OCHCODJIPHJ.y, 801f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle.fontSize = 104;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = "WeaponRunBackward";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "<color='#103000'>" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "/";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "Failed parsing organizational group.  Setting to group 0" + num + "MotorbikeBackwardStand";
					if (this.ILFHHDNJHNM > num)
					{
						text = "ClimbIdle" + text + " x";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "" + text + "IKSolverLookAt spine setup is invalid. Can't initiate solver.";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1148f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600621C RID: 25116 RVA: 0x002DC758 File Offset: 0x002DA958
	public virtual void MBABINJIPDF(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 688f, this.OCHCODJIPHJ.y, 1740f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle.fontSize = -50;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = "mainmenu";
				if (this.ILFHHDNJHNM > 1)
				{
					str = " <b>®</b></color>  " + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(false, -1);
				string text = "_Histogram";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = " S:" + num + "Квест";
					if (this.ILFHHDNJHNM > num)
					{
						text = "_FogDistance" + text + "Visit docs to see where PlayerPrefs are stored";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "noresult" + text + "pricePt";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 946f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600621D RID: 25117 RVA: 0x002DC948 File Offset: 0x002DAB48
	public virtual void OOKDJBCNEBH(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 802f, this.OCHCODJIPHJ.y, 234f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle.fontSize = -11;
				guistyle.wordWrap = true;
				guistyle.richText = true;
				string str = "<color='#60e0ff'>";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "InterfaceLang.txt" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text = "DENSITY";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "BAG" + num + "Missing shader in ";
					if (this.ILFHHDNJHNM > num)
					{
						text = "_rcIn.ogg" + text + "OfficeSittingReading";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "invn_rec22" + text + "BowFire";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1964f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600621E RID: 25118 RVA: 0x002DCB38 File Offset: 0x002DAD38
	public virtual void BFHPJCKICCE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 134f, this.OCHCODJIPHJ.y, 1520f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle.fontSize = 112;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "_ReflectionTex";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "repair.ogg" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text = "crft_cnt2";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "fwgt_uniq_w" + num + "Space reference not set.";
					if (this.ILFHHDNJHNM > num)
					{
						text = "; " + text + "<size=14><color='#00d0ff'>{0}</color></size>";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "" + text + "WorkerHammer";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 650f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600621F RID: 25119 RVA: 0x002DCD28 File Offset: 0x002DAF28
	public virtual void LPPKKCCKLJF(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 182f, this.OCHCODJIPHJ.y, 1070f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle.fontSize = -47;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "FlyRight" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text = "Load costume ";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "WATER_SIMPLE" + num + "Titul";
					if (this.ILFHHDNJHNM > num)
					{
						text = "1 Hand Sword Jab" + text + "qd_refresh";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "openQuest" + text + "IdleReady";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 540f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006220 RID: 25120 RVA: 0x002DCF18 File Offset: 0x002DB118
	public virtual void CMECHJMLPGD(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1499f, this.OCHCODJIPHJ.y, 835f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle.fontSize = 114;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "Shoes";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "{0}" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text = "Roar";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "_DstBlend" + num + "t_bottom";
					if (this.ILFHHDNJHNM > num)
					{
						text = "name" + text + "readSadok error ";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = " has invalid children array. Child index is < 0." + text + "{0} x {1}";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 829f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006221 RID: 25121 RVA: 0x002DD108 File Offset: 0x002DB308
	public virtual void FOGCOMNGOFB(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 381f, this.OCHCODJIPHJ.y, 145f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle.fontSize = 19;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = "*************157 baseid=";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "' does not exist within Assets/Resources/Fonts/" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text = "IdleRun";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" + num + "componentA=";
					if (this.ILFHHDNJHNM > num)
					{
						text = "OneHandSwordJab" + text + "_ZTest";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "CardPlayerIdle" + text + "t_much";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 6f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006222 RID: 25122 RVA: 0x002DD2F8 File Offset: 0x002DB4F8
	public virtual void OFCJAMLCEPB(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 1072f, this.OCHCODJIPHJ.y, 1922f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle.fontSize = -61;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "Failed parsing scalePlacement.  Setting to \"Fixed\"";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "cht_msg29" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(false, -1);
				string text = "Middle click";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text = "\n" + num + "wpn_add/base";
					if (this.ILFHHDNJHNM > num)
					{
						text = "" + text + "</color>";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "remWpn=" + text + "_Color";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1647f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006223 RID: 25123 RVA: 0x002DD4E8 File Offset: 0x002DB6E8
	public virtual void JOBPKNNNEAD(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 432f, this.OCHCODJIPHJ.y, 1781f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle.fontSize = -58;
				guistyle.wordWrap = true;
				guistyle.richText = false;
				string str = "Quaternion: ";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "t_eye" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text = "DrawDistance";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text = "Bend Constraint contains a null reference." + num + "";
					if (this.ILFHHDNJHNM > num)
					{
						text = "IdleStand" + text + "PaperTurn.wav";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "PaperTurn.wav" + text + "RollerBladeFrontFlip";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1471f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006224 RID: 25124 RVA: 0x002DD6D8 File Offset: 0x002DB8D8
	public virtual void HADLKLNMMNC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 578f, this.OCHCODJIPHJ.y, 1863f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle.fontSize = 111;
				guistyle.wordWrap = false;
				guistyle.richText = true;
				string str = "Sewing";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "3" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text = "PLANE_REFLECTION";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text = "loc_" + num + "☰☰☰";
					if (this.ILFHHDNJHNM > num)
					{
						text = "дня" + text + "_AllowBackwardsRays";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "Flap_04.wav" + text + "IdleStand";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 402f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006225 RID: 25125 RVA: 0x002DD8C8 File Offset: 0x002DBAC8
	public virtual void DKOEJJHKMHI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(this.OCHCODJIPHJ.x + this.OCHCODJIPHJ.width + 632f, this.OCHCODJIPHJ.y, 995f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle.fontSize = 90;
				guistyle.wordWrap = false;
				guistyle.richText = false;
				string str = "IdleReady";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "fshop_msg1" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text = "BOTTOM";
				if (this.HMHBAMDBJLI)
				{
					int num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text = "PoplDrop" + num + "_DeepTex";
					if (this.ILFHHDNJHNM > num)
					{
						text = "UnityEngine.Vector2" + text + "error baseid: ";
					}
					if (this.ILFHHDNJHNM <= num)
					{
						text = "wpn_eat5" + text + "gameComplete";
					}
				}
				GUI.Label(position, str2 + str + text, guistyle);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 739f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x04000E13 RID: 3603
	public BEFCHFNGOMI MBANOJNPAIC;

	// Token: 0x04000E14 RID: 3604
	public int ILFHHDNJHNM;

	// Token: 0x04000E15 RID: 3605
	public bool MAKAFBBENPF;

	// Token: 0x04000E16 RID: 3606
	public bool HMHBAMDBJLI;

	// Token: 0x04000E17 RID: 3607
	public float KMNEOIGFPGL;

	// Token: 0x04000E18 RID: 3608
	public bool KPLMFNIFPMM = true;
}
