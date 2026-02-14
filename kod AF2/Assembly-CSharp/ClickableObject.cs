using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000235 RID: 565
public class ClickableObject : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x06008240 RID: 33344 RVA: 0x003D809F File Offset: 0x003D629F
	public void DKIGOEHDDFD(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)7)
			{
				Debug.Log("Textures/Bases/");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008241 RID: 33345 RVA: 0x003D80D9 File Offset: 0x003D62D9
	public void HJMBMPIIEDK(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Middle)
			{
				Debug.Log("_Newitem.wav");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008242 RID: 33346 RVA: 0x003D8113 File Offset: 0x003D6313
	public void JHEDALDOPEB(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)8)
			{
				Debug.Log("SexyDance");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008243 RID: 33347 RVA: 0x003D814D File Offset: 0x003D634D
	public void FLGAKOOGILC(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left)
			{
				Debug.Log("\n");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008244 RID: 33348 RVA: 0x003D8187 File Offset: 0x003D6387
	public void OFEPGDMKAEN(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Middle)
			{
				Debug.Log("Hidden/Amplify Color/BlendCache");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008245 RID: 33349 RVA: 0x003D81C1 File Offset: 0x003D63C1
	public void OPPPEENIHLB(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Middle)
			{
				Debug.Log("_GrainOffsetScale");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008246 RID: 33350 RVA: 0x003D81FB File Offset: 0x003D63FB
	public void PMGPDHCEHDH(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)4)
			{
				Debug.Log("IdleMouthWipe");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008247 RID: 33351 RVA: 0x003D8235 File Offset: 0x003D6435
	public void LHDJEGKNAKL(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Middle)
			{
				Debug.Log("WRINKLE_MAPS");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008248 RID: 33352 RVA: 0x003D826F File Offset: 0x003D646F
	public void DNKIJHNGMBF(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)5)
			{
				Debug.Log("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_aim_i_k.html");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x06008249 RID: 33353 RVA: 0x003D82A9 File Offset: 0x003D64A9
	public void OnPointerClick(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Middle)
			{
				Debug.Log("Middle click");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x0600824A RID: 33354 RVA: 0x003D82E3 File Offset: 0x003D64E3
	public void DCEJANNKOLG(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)6)
			{
				Debug.Log("inventoryOpen");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Left && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x0600824B RID: 33355 RVA: 0x003D831D File Offset: 0x003D651D
	public void CPHPNADAHJG(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right)
			{
				Debug.Log("OneHandSwordBackSwing");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x0600824C RID: 33356 RVA: 0x003D8357 File Offset: 0x003D6557
	public void LCFNDMENIMC(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)7)
			{
				Debug.Log("spinbreak.ogg");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x0600824D RID: 33357 RVA: 0x003D8391 File Offset: 0x003D6591
	public void FGCKJGFKLJC(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)4)
			{
				Debug.Log("IdleStrafeRight");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x0600824F RID: 33359 RVA: 0x003D83DE File Offset: 0x003D65DE
	public void OCFGBKBNHMK(PointerEventData CAKNKPPGGIK)
	{
		if (CAKNKPPGGIK.button != PointerEventData.InputButton.Left)
		{
			if (CAKNKPPGGIK.button == (PointerEventData.InputButton)8)
			{
				Debug.Log("gi_inte_1");
				return;
			}
			if (CAKNKPPGGIK.button == PointerEventData.InputButton.Right && this.RClickEvent != null)
			{
				this.RClickEvent.Invoke();
			}
		}
	}

	// Token: 0x04001295 RID: 4757
	public Button.ButtonClickedEvent RClickEvent = new Button.ButtonClickedEvent();
}
