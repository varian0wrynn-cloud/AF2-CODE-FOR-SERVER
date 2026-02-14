using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000147 RID: 327
public class FPointer : MonoBehaviour
{
	// Token: 0x06004495 RID: 17557 RVA: 0x00201654 File Offset: 0x001FF854
	private void EINIHGNNIPF(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x06004496 RID: 17558 RVA: 0x0020169C File Offset: 0x001FF89C
	private void KKCFKEDABLB()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.NNOIPNAAJIG(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.HFHCPAKHHDK(false);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("SUNSHINE_FILTER_PCF_4x4");
	}

	// Token: 0x06004497 RID: 17559 RVA: 0x00201718 File Offset: 0x001FF918
	private void NIKPALBNKEL(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x06004498 RID: 17560 RVA: 0x00201760 File Offset: 0x001FF960
	private void JCMGHHKALDM()
	{
		if (GuiProcessor.PLGADNLAEGN() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1843f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -90
		};
		if (GuiProcessor.BBLINJLBAIL().rusfont != null)
		{
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		}
		double num = (double)(ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", num);
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -127;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 883f, vector.y - 1892f, 193f, 1127f), "GiantGrabIdle2");
			GUI.Label(new Rect(vector.x - 675f, vector.y - 472f, 816f, 1776f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1787f) / 1251f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 713f, vector.y + 1413f, 849f, 163f), "ui_default_close.wav", guistyle);
			}
		}
	}

	// Token: 0x06004499 RID: 17561 RVA: 0x00201988 File Offset: 0x001FFB88
	private void NNOIPNAAJIG(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x0600449A RID: 17562 RVA: 0x002019D0 File Offset: 0x001FFBD0
	private void OnGUI()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 0.1f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 10
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("{0:00} m", num);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 12;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 25f, vector.y - 30f, 50f, 28f), "");
			GUI.Label(new Rect(vector.x - 20f, vector.y - 25f, 40f, 18f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 100f) / 100f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 80f, vector.y + 42f, 160f, 18f), "BEREG!", guistyle);
			}
		}
	}

	// Token: 0x0600449B RID: 17563 RVA: 0x00201BF8 File Offset: 0x001FFDF8
	private void FEBIICIMLHA()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.OJDCMNJINFC(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.EGHNEHMKDDG(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("name");
	}

	// Token: 0x0600449C RID: 17564 RVA: 0x00201C74 File Offset: 0x001FFE74
	private void BHDPDDHLPOI()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.IGHOGONIKLC() - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 299f, 47f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.OGJHINOLHJJ + 1465f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 919f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 107f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1200f, num3);
		Mathf.Lerp(253f, 1343f, this.velos / 1184f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 345f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("ShootWireframeModule", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x0600449D RID: 17565 RVA: 0x00201EB4 File Offset: 0x002000B4
	private void BEGAOCGMJEK(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			foreach (Renderer renderer in this.rends)
			{
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x0600449E RID: 17566 RVA: 0x00201EFC File Offset: 0x002000FC
	private void APHJJJHNFNP()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.OGJHINOLHJJ - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1801f, 1056f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.IGHOGONIKLC() + 875f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 242f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1831f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1230f, num3);
		Mathf.Lerp(1148f, 84f, this.velos / 1187f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1951f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("\n", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x0600449F RID: 17567 RVA: 0x0020213C File Offset: 0x0020033C
	private void Update()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.OGJHINOLHJJ, base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.HIJCPJJEBEO(num2 > this.dstrender);
			}
		}
		else
		{
			this.HIJCPJJEBEO(true);
		}
		bool flag = false;
		float f = 999f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 0.1f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 0.5f)
			{
				float a = 1f * Mathf.Clamp(num * 3f, 0f, 1f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1f, 1f, 1f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1f, 1f, 1f, 0f));
		}
	}

	// Token: 0x060044A0 RID: 17568 RVA: 0x002023BC File Offset: 0x002005BC
	private void ONAEKGDNBIB()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.OGJHINOLHJJ - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 517f, 295f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.CDBIEPGNONF() + 1124f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 1876f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1643f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 918f, num3);
		Mathf.Lerp(763f, 447f, this.velos / 456f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1313f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("IceHockey Deke Middle", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x060044A1 RID: 17569 RVA: 0x002025FC File Offset: 0x002007FC
	private void CDDKOMHOELI(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044A2 RID: 17570 RVA: 0x00202644 File Offset: 0x00200844
	private void INKGAFANFIB()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.OGJHINOLHJJ, base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.HFHCPAKHHDK(num2 > this.dstrender);
			}
		}
		else
		{
			this.IGAHAGKLPAK(false);
		}
		bool flag = false;
		float f = 1449f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.HKBNODJBGEL() - 603f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 538f)
			{
				float a = 1313f * Mathf.Clamp(num * 1679f, 1896f, 404f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(848f, 935f, 1781f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1537f, 387f, 1543f, 1816f));
		}
	}

	// Token: 0x060044A3 RID: 17571 RVA: 0x002028C4 File Offset: 0x00200AC4
	private void OAGBAIECENO(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044A4 RID: 17572 RVA: 0x0020290C File Offset: 0x00200B0C
	private void CGFDDFHECLJ()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.CDDKOMHOELI(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.HIJCPJJEBEO(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor(" has no HandPoser/GenericPoser attached.");
	}

	// Token: 0x060044A5 RID: 17573 RVA: 0x00202988 File Offset: 0x00200B88
	private void GHOJCADBKEK()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1166f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -114
		};
		if (GuiProcessor.BBLINJLBAIL().rusfont != null)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("signal_tone", num);
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -120;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 344f, vector.y - 1617f, 470f, 498f), "inv_pcs1");
			GUI.Label(new Rect(vector.x - 1836f, vector.y - 1714f, 1557f, 606f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 392f) / 1306f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 599f, vector.y + 1426f, 1666f, 1881f), "KatanaReadyLow", guistyle);
			}
		}
	}

	// Token: 0x060044A6 RID: 17574 RVA: 0x00202BB0 File Offset: 0x00200DB0
	private void MHJBMBPKHLB()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.CDBIEPGNONF() - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1851f, 824f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.HKBNODJBGEL() + 202f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 759f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1276f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 202f, num3);
		Mathf.Lerp(147f, 919f, this.velos / 1602f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1735f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("post_6", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044A7 RID: 17575 RVA: 0x00202DF0 File Offset: 0x00200FF0
	private void FLDMAFHJLNB()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 273f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -105
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("15", num);
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -64;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1053f, vector.y - 1471f, 951f, 485f), "");
			GUI.Label(new Rect(vector.x - 1606f, vector.y - 272f, 1024f, 429f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1841f) / 859f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 912f, vector.y + 1293f, 1709f, 710f), ": ", guistyle);
			}
		}
	}

	// Token: 0x060044A8 RID: 17576 RVA: 0x00203018 File Offset: 0x00201218
	private void LMGBKHCHPHO()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.HKBNODJBGEL(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.NIKPALBNKEL(num2 > this.dstrender);
			}
		}
		else
		{
			this.JDDKDPONNPG(true);
		}
		bool flag = true;
		float f = 952f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 278f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 199f)
			{
				float a = 803f * Mathf.Clamp(num * 1746f, 818f, 916f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1902f, 640f, 440f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1930f, 1148f, 1023f, 1243f));
		}
	}

	// Token: 0x060044A9 RID: 17577 RVA: 0x00203298 File Offset: 0x00201498
	private void FPLNDDMFFKG()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.IGHOGONIKLC(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.LBIIOGJLHML(num2 > this.dstrender);
			}
		}
		else
		{
			this.CPAINBLCCKB(true);
		}
		bool flag = false;
		float f = 1154f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.IGHOGONIKLC() - 1053f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 367f)
			{
				float a = 1596f * Mathf.Clamp(num * 244f, 1929f, 1548f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(855f, 1259f, 561f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1242f, 274f, 203f, 1249f));
		}
	}

	// Token: 0x060044AA RID: 17578 RVA: 0x00203518 File Offset: 0x00201718
	private void PDEEOGAAMBB()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 422f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -16
		};
		if (GuiProcessor.BBLINJLBAIL().rusfont != null)
		{
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("white", num);
		guistyle.alignment = TextAnchor.UpperRight;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 84;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1002f, vector.y - 531f, 91f, 1452f), "DealerShuffle");
			GUI.Label(new Rect(vector.x - 752f, vector.y - 1150f, 1161f, 327f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1678f) / 976f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1589f, vector.y + 311f, 663f, 935f), "_rcIn.ogg", guistyle);
			}
		}
	}

	// Token: 0x060044AB RID: 17579 RVA: 0x00203740 File Offset: 0x00201940
	private void LateUpdate()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.OGJHINOLHJJ - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 0f, 100f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.OGJHINOLHJJ + 0.01f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 0.5f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 0.3f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1f, num3);
		Mathf.Lerp(0f, 1f, this.velos / 2f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 0f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("_TintColor", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044AC RID: 17580 RVA: 0x00203980 File Offset: 0x00201B80
	private void ELADFDNPOOI()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.OJDCMNJINFC(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.NNOIPNAAJIG(false);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("SneakRight");
	}

	// Token: 0x060044AD RID: 17581 RVA: 0x002039FC File Offset: 0x00201BFC
	private void HMPFJEPODEL()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1733f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -81
		};
		if (GuiProcessor.PLGADNLAEGN().rusfont != null)
		{
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		}
		double num = (double)(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("get 108 packet", num);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 76;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1722f, vector.y - 484f, 917f, 834f), "Idle180");
			GUI.Label(new Rect(vector.x - 1042f, vector.y - 1784f, 12f, 1506f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1494f) / 746f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1080f, vector.y + 1677f, 86f, 1374f), "linebreak.ogg", guistyle);
			}
		}
	}

	// Token: 0x060044AE RID: 17582 RVA: 0x00203C24 File Offset: 0x00201E24
	private void PJGBIKCDNEP(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044AF RID: 17583 RVA: 0x00203C6C File Offset: 0x00201E6C
	private void NCOJPBKLANI()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.CDBIEPGNONF() - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 874f, 1229f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.HKBNODJBGEL() + 1410f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 121f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1060f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1045f, num3);
		Mathf.Lerp(1984f, 967f, this.velos / 50f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 88f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor(" ", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x060044B0 RID: 17584 RVA: 0x00203EAC File Offset: 0x002020AC
	private void OJDCMNJINFC(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044B1 RID: 17585 RVA: 0x00203EF4 File Offset: 0x002020F4
	private void MNAHGMDDHCA()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.HKBNODJBGEL(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.OAGBAIECENO(num2 > this.dstrender);
			}
		}
		else
		{
			this.NIKPALBNKEL(true);
		}
		bool flag = false;
		float f = 218f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 523f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 1518f)
			{
				float a = 1123f * Mathf.Clamp(num * 538f, 1498f, 561f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1036f, 1376f, 1810f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1436f, 1603f, 750f, 175f));
		}
	}

	// Token: 0x060044B2 RID: 17586 RVA: 0x00204174 File Offset: 0x00202374
	private void IBPGMFNDPHH()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.HIJCPJJEBEO(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.EINIHGNNIPF(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("Crouch");
	}

	// Token: 0x060044B3 RID: 17587 RVA: 0x002041F0 File Offset: 0x002023F0
	private void DHJDMKLBLEF()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.OOJNEFGOGNB(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.GOEHPMJPDNG(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("SoccerPassLight");
	}

	// Token: 0x060044B4 RID: 17588 RVA: 0x0020426C File Offset: 0x0020246C
	private void GOEHPMJPDNG(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			foreach (Renderer renderer in this.rends)
			{
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044B5 RID: 17589 RVA: 0x002042B4 File Offset: 0x002024B4
	private void JJMGNAMFJGJ()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.OGJHINOLHJJ - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 732f, 347f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.HKBNODJBGEL() + 680f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 302f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 631f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1683f, num3);
		Mathf.Lerp(123f, 1903f, this.velos / 105f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 68f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("_FresnelFade", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044B6 RID: 17590 RVA: 0x002044F4 File Offset: 0x002026F4
	private void BOCPAHEHFJH()
	{
		if (GuiProcessor.NKOEAPCIBKO() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1417f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -18
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		}
		double num = (double)(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("buykey", num);
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 107;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1067f, vector.y - 417f, 1493f, 1658f), "WATER_EDGEBLEND_ON");
			GUI.Label(new Rect(vector.x - 570f, vector.y - 514f, 1090f, 1497f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1268f) / 1810f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1770f, vector.y + 10f, 1224f, 1824f), "Katana", guistyle);
			}
		}
	}

	// Token: 0x060044B7 RID: 17591 RVA: 0x0020471C File Offset: 0x0020291C
	private void BJOICAKCPLI()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.OGJHINOLHJJ, base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.CPAINBLCCKB(num2 > this.dstrender);
			}
		}
		else
		{
			this.NNOIPNAAJIG(true);
		}
		bool flag = false;
		float f = 976f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.HKBNODJBGEL() - 917f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 1380f)
			{
				float a = 413f * Mathf.Clamp(num * 1995f, 1333f, 1088f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(69f, 271f, 1486f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1283f, 1433f, 1815f, 891f));
		}
	}

	// Token: 0x060044B8 RID: 17592 RVA: 0x0020499C File Offset: 0x00202B9C
	private void PMDPLLIBJAF()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.LEHBHOBDFCM(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.CPAINBLCCKB(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("ScatterIntensityVolumeSky");
	}

	// Token: 0x060044B9 RID: 17593 RVA: 0x00204A18 File Offset: 0x00202C18
	private void OFKLNHNPADP()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1711f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -41
		};
		if (GuiProcessor.NKOEAPCIBKO().rusfont != null)
		{
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		}
		double num = (double)(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("Color Grading Log LUT", num);
		guistyle.alignment = TextAnchor.UpperRight;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 109;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1199f, vector.y - 686f, 1674f, 41f), "_LerpAmount");
			GUI.Label(new Rect(vector.x - 425f, vector.y - 1110f, 1126f, 395f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1911f) / 859f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 984f, vector.y + 1433f, 1471f, 531f), "StaffPowerUp", guistyle);
			}
		}
	}

	// Token: 0x060044BA RID: 17594 RVA: 0x00204C40 File Offset: 0x00202E40
	private void EEOLBBJNOJD()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 23f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 45
		};
		if (GuiProcessor.NKOEAPCIBKO().rusfont != null)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		}
		double num = (double)(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format(" ", num);
		guistyle.alignment = TextAnchor.MiddleRight;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -118;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1391f, vector.y - 1439f, 294f, 487f), "_FogAlpha");
			GUI.Label(new Rect(vector.x - 1374f, vector.y - 1471f, 1925f, 1118f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 473f) / 858f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 747f, vector.y + 554f, 1362f, 553f), " path=", guistyle);
			}
		}
	}

	// Token: 0x060044BB RID: 17595 RVA: 0x00204E68 File Offset: 0x00203068
	private void MKNDDFMIGDN()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC;
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.HKBNODJBGEL() - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1793f, 1047f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.IGHOGONIKLC() + 1631f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 364f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 978f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1219f, num3);
		Mathf.Lerp(114f, 1618f, this.velos / 261f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1636f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("_BlurVector", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x060044BC RID: 17596 RVA: 0x002050A8 File Offset: 0x002032A8
	private void NOLKOIHEICD()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.CDBIEPGNONF(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.OOJNEFGOGNB(num2 > this.dstrender);
			}
		}
		else
		{
			this.CPAINBLCCKB(false);
		}
		bool flag = false;
		float f = 1303f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.IGHOGONIKLC() - 1573f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 1238f)
			{
				float a = 999f * Mathf.Clamp(num * 1229f, 1116f, 108f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1243f, 393f, 139f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(179f, 427f, 486f, 1122f));
		}
	}

	// Token: 0x060044BD RID: 17597 RVA: 0x00205328 File Offset: 0x00203528
	private void NGHOJBOHIBA()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB();
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.CDBIEPGNONF() - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 334f, 2f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.IGHOGONIKLC() + 1377f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 397f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1447f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 47f, num3);
		Mathf.Lerp(743f, 589f, this.velos / 1097f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 142f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("CUSTOM_COLOR_ON", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044BE RID: 17598 RVA: 0x00205568 File Offset: 0x00203768
	private void JDDKDPONNPG(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044BF RID: 17599 RVA: 0x002055B0 File Offset: 0x002037B0
	private void BLMBPFIJJBP()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.IGHOGONIKLC(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.IGAHAGKLPAK(num2 > this.dstrender);
			}
		}
		else
		{
			this.GOEHPMJPDNG(true);
		}
		bool flag = true;
		float f = 11f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 933f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 1864f)
			{
				float a = 1422f * Mathf.Clamp(num * 1385f, 609f, 1357f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1304f, 1576f, 147f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1293f, 10f, 138f, 1176f));
		}
	}

	// Token: 0x060044C0 RID: 17600 RVA: 0x00205830 File Offset: 0x00203A30
	private void OOJNEFGOGNB(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			foreach (Renderer renderer in this.rends)
			{
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044C1 RID: 17601 RVA: 0x00205878 File Offset: 0x00203A78
	private void HIJCPJJEBEO(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			foreach (Renderer renderer in this.rends)
			{
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044C2 RID: 17602 RVA: 0x002058C0 File Offset: 0x00203AC0
	private void HFPPENPGGAI()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.HKBNODJBGEL(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.BEGAOCGMJEK(num2 > this.dstrender);
			}
		}
		else
		{
			this.EGHNEHMKDDG(true);
		}
		bool flag = true;
		float f = 809f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.HKBNODJBGEL() - 411f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 824f)
			{
				float a = 582f * Mathf.Clamp(num * 235f, 1059f, 1735f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(592f, 1038f, 841f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(262f, 1765f, 1619f, 1930f));
		}
	}

	// Token: 0x060044C3 RID: 17603 RVA: 0x00205B40 File Offset: 0x00203D40
	private void OHAOGONDAHA()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.EACGPPOMFLH().ILCJJKCPBKC;
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.IGHOGONIKLC() - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1478f, 179f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.CDBIEPGNONF() + 1799f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 1060f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1165f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 152f, num3);
		Mathf.Lerp(1311f, 660f, this.velos / 593f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 89f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("Yawn", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x00205D80 File Offset: 0x00203F80
	private void PNJNNNJEBGA()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1232f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 6
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("?", num);
		guistyle.alignment = TextAnchor.MiddleRight;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 112;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 613f, vector.y - 391f, 578f, 1194f), "IKSolverFABRIKRoot chain at index ");
			GUI.Label(new Rect(vector.x - 502f, vector.y - 809f, 931f, 1401f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1861f) / 1787f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 542f, vector.y + 1171f, 1547f, 751f), "DeadmanFloat", guistyle);
			}
		}
	}

	// Token: 0x060044C5 RID: 17605 RVA: 0x00205FA8 File Offset: 0x002041A8
	private void DGEIACONKCJ()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.HIJCPJJEBEO(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.OOJNEFGOGNB(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("Kernel");
	}

	// Token: 0x060044C6 RID: 17606 RVA: 0x00206024 File Offset: 0x00204224
	private void LHFBEKCIKOI()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.CDBIEPGNONF() - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1312f, 687f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.HKBNODJBGEL() + 1139f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 1103f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1447f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 790f, num3);
		Mathf.Lerp(1615f, 283f, this.velos / 1349f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1299f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor(" registered.", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044C7 RID: 17607 RVA: 0x00206264 File Offset: 0x00204464
	private void JOBINILKMAP()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 179f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -56
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		}
		double num = (double)(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("error", num);
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -86;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 915f, vector.y - 363f, 1268f, 709f), "The polygon must have at least 3 Limit Points.");
			GUI.Label(new Rect(vector.x - 1142f, vector.y - 272f, 286f, 1149f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1160f) / 1324f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1857f, vector.y + 1776f, 1006f, 489f), "LHandPunch", guistyle);
			}
		}
	}

	// Token: 0x060044C8 RID: 17608 RVA: 0x0020648C File Offset: 0x0020468C
	private void KEMGOLACEHI()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.MCIHLLDFEJI(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.NIKPALBNKEL(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("{0:F2}, {1:F2}, {2:F2}, {3:F2}");
	}

	// Token: 0x060044C9 RID: 17609 RVA: 0x00206508 File Offset: 0x00204708
	private void CPAINBLCCKB(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044CA RID: 17610 RVA: 0x00206550 File Offset: 0x00204750
	private void OOGNHIIPHBH()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.IGHOGONIKLC() - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1705f, 236f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.OGJHINOLHJJ + 43f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 542f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1477f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1362f, num3);
		Mathf.Lerp(775f, 562f, this.velos / 474f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1106f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("RHandPunch", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044CB RID: 17611 RVA: 0x00206790 File Offset: 0x00204990
	private void BJHGPFGBFKF()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.OOJNEFGOGNB(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.NIKPALBNKEL(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("<color='#300000'>{0} {1}</color>");
	}

	// Token: 0x060044CC RID: 17612 RVA: 0x0020680C File Offset: 0x00204A0C
	private void DKEJDBEFIKI(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044CD RID: 17613 RVA: 0x00206854 File Offset: 0x00204A54
	private void JGDDEOALNOG()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 213f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 25
		};
		if (GuiProcessor.PLGADNLAEGN().rusfont != null)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("\n", num);
		guistyle.alignment = TextAnchor.LowerRight;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 121;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 31f, vector.y - 1091f, 1391f, 1703f), "_EdgeSharpness");
			GUI.Label(new Rect(vector.x - 1776f, vector.y - 981f, 1594f, 170f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 998f) / 971f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 500f, vector.y + 359f, 1929f, 475f), "reel_type2", guistyle);
			}
		}
	}

	// Token: 0x060044CE RID: 17614 RVA: 0x00206A7C File Offset: 0x00204C7C
	private void DPGECEOMHNM()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.HKBNODJBGEL(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.MCIHLLDFEJI(num2 > this.dstrender);
			}
		}
		else
		{
			this.PJGBIKCDNEP(true);
		}
		bool flag = true;
		float f = 1900f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.HKBNODJBGEL() - 1293f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 1935f)
			{
				float a = 1034f * Mathf.Clamp(num * 1439f, 193f, 355f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1250f, 808f, 1083f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(784f, 1844f, 908f, 1896f));
		}
	}

	// Token: 0x060044CF RID: 17615 RVA: 0x00206CFC File Offset: 0x00204EFC
	private void FIJKDFIMELM()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.OOJNEFGOGNB(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.CPAINBLCCKB(false);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("FASTEST");
	}

	// Token: 0x060044D0 RID: 17616 RVA: 0x00206D78 File Offset: 0x00204F78
	private void OPNPODKLOJK()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.GOEHPMJPDNG(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.MCIHLLDFEJI(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("_GrainTex");
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x00206DF4 File Offset: 0x00204FF4
	private void GGBMJFNGHMC()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.EGHNEHMKDDG(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.JDDKDPONNPG(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("PaperTurn.wav");
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x00206E70 File Offset: 0x00205070
	private void KOKNJEGAKDA(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044D3 RID: 17619 RVA: 0x00206EB8 File Offset: 0x002050B8
	private void GCLIPIADIPD()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1191f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 83
		};
		if (GuiProcessor.BBLINJLBAIL().rusfont != null)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("StaffStand", num);
		guistyle.alignment = TextAnchor.LowerRight;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 117;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 675f, vector.y - 833f, 670f, 1671f), "No fish in fishModelData modelid=");
			GUI.Label(new Rect(vector.x - 353f, vector.y - 1950f, 170f, 959f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1936f) / 183f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1923f, vector.y + 981f, 1294f, 1481f), "Trail", guistyle);
			}
		}
	}

	// Token: 0x060044D4 RID: 17620 RVA: 0x002070E0 File Offset: 0x002052E0
	private void MCIHLLDFEJI(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044D5 RID: 17621 RVA: 0x00207128 File Offset: 0x00205328
	private void PBADPBBJBEJ()
	{
		if (GuiProcessor.NKOEAPCIBKO() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 430f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -8
		};
		if (GuiProcessor.BBLINJLBAIL().rusfont != null)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		}
		double num = (double)(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format(" has been disabled as it requires HDR.", num);
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -126;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 516f, vector.y - 1108f, 800f, 899f), "titul_data/p_categories/category");
			GUI.Label(new Rect(vector.x - 275f, vector.y - 1398f, 329f, 94f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1809f) / 1158f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 203f, vector.y + 373f, 1666f, 1955f), "auk_wmax", guistyle);
			}
		}
	}

	// Token: 0x060044D6 RID: 17622 RVA: 0x00207350 File Offset: 0x00205550
	private void GGOKNBBPLHB()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1763f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 20
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		}
		double num = (double)(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("Climb Left", num);
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -29;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1181f, vector.y - 589f, 813f, 1046f), "val=");
			GUI.Label(new Rect(vector.x - 1842f, vector.y - 295f, 728f, 112f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 275f) / 476f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1285f, vector.y + 36f, 1340f, 1933f), "CratePull", guistyle);
			}
		}
	}

	// Token: 0x060044D7 RID: 17623 RVA: 0x00207578 File Offset: 0x00205778
	private void DBAELJBBKKF()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB();
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.OGJHINOLHJJ - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1249f, 1785f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.CDBIEPGNONF() + 1273f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 497f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1874f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1490f, num3);
		Mathf.Lerp(1264f, 1021f, this.velos / 209f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 430f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("click Refresh currentQcat=", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044D8 RID: 17624 RVA: 0x002077B8 File Offset: 0x002059B8
	private void JDICIPNCLGJ()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.IGHOGONIKLC() - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 857f, 1042f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.OGJHINOLHJJ + 1324f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 411f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1975f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1404f, num3);
		Mathf.Lerp(1577f, 904f, this.velos / 919f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 547f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044D9 RID: 17625 RVA: 0x002079F8 File Offset: 0x00205BF8
	private void PFNOEACNHON()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.OGJHINOLHJJ, base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.KOKNJEGAKDA(num2 > this.dstrender);
			}
		}
		else
		{
			this.CDDKOMHOELI(true);
		}
		bool flag = true;
		float f = 1848f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.CDBIEPGNONF() - 754f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 556f)
			{
				float a = 28f * Mathf.Clamp(num * 1696f, 1753f, 1160f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1746f, 34f, 447f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(961f, 776f, 99f, 1081f));
		}
	}

	// Token: 0x060044DA RID: 17626 RVA: 0x00207C78 File Offset: 0x00205E78
	private void LGKEFLBKIGN()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1773f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 30
		};
		if (GuiProcessor.PLGADNLAEGN().rusfont != null)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		}
		double num = (double)(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format(" is not supported on this platform!", num);
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -36;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 119f, vector.y - 270f, 737f, 1962f), "System.Boolean");
			GUI.Label(new Rect(vector.x - 1955f, vector.y - 356f, 623f, 1463f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 637f) / 159f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1259f, vector.y + 1634f, 312f, 1438f), "' that does not excist in the Node Chain.", guistyle);
			}
		}
	}

	// Token: 0x060044DC RID: 17628 RVA: 0x00207EB8 File Offset: 0x002060B8
	private void LMEJKAEIDCO()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.CDDKOMHOELI(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.HFHCPAKHHDK(false);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("IceHockeyPassLeft");
	}

	// Token: 0x060044DD RID: 17629 RVA: 0x00207F34 File Offset: 0x00206134
	private void ONBECFGMGFF()
	{
		if (GuiProcessor.PLGADNLAEGN() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 1203f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -29
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		}
		double num = (double)(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("Swim", num);
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -60;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1299f, vector.y - 706f, 1775f, 1320f), "&");
			GUI.Label(new Rect(vector.x - 1217f, vector.y - 1883f, 1175f, 403f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 528f) / 716f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 793f, vector.y + 1817f, 1128f, 1818f), "_SrcBlend", guistyle);
			}
		}
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x0020815C File Offset: 0x0020635C
	private void GCCAPOHGAHA()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.IGHOGONIKLC(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.GOEHPMJPDNG(num2 > this.dstrender);
			}
		}
		else
		{
			this.HIJCPJJEBEO(false);
		}
		bool flag = true;
		float f = 330f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.HKBNODJBGEL() - 1588f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 886f)
			{
				float a = 148f * Mathf.Clamp(num * 1277f, 1081f, 862f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1589f, 659f, 654f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(50f, 1047f, 882f, 1556f));
		}
	}

	// Token: 0x060044DF RID: 17631 RVA: 0x002083DC File Offset: 0x002065DC
	private void PIEDGJCBCBO()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB();
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.CDBIEPGNONF() - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1890f, 824f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.HKBNODJBGEL() + 200f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 1607f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 443f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1357f, num3);
		Mathf.Lerp(825f, 1637f, this.velos / 1549f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1844f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("inv_buymsg", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x060044E0 RID: 17632 RVA: 0x0020861C File Offset: 0x0020681C
	private void AIGIILFGEPC()
	{
		if (GuiProcessor.PLGADNLAEGN() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 125f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -37
		};
		if (GuiProcessor.PLGADNLAEGN().rusfont != null)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		}
		double num = (double)(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("inner_craft_wpn", num);
		guistyle.alignment = TextAnchor.UpperRight;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 57;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1312f, vector.y - 623f, 170f, 299f), " ");
			GUI.Label(new Rect(vector.x - 1929f, vector.y - 533f, 987f, 554f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 58f) / 647f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1152f, vector.y + 862f, 1879f, 61f), "click Ok", guistyle);
			}
		}
	}

	// Token: 0x060044E1 RID: 17633 RVA: 0x00208844 File Offset: 0x00206A44
	private void EBIIDOPFJJI()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 353f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 11
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		}
		double num = (double)(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("", num);
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = 94;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1113f, vector.y - 746f, 776f, 1121f), "IdleSlide");
			GUI.Label(new Rect(vector.x - 1347f, vector.y - 1089f, 439f, 708f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 948f) / 115f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 393f, vector.y + 44f, 350f, 1464f), "KatanaReady", guistyle);
			}
		}
	}

	// Token: 0x060044E2 RID: 17634 RVA: 0x00208A6C File Offset: 0x00206C6C
	private void CGNFLAOBEFN()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.HKBNODJBGEL() - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 452f, 28f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.OGJHINOLHJJ + 310f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 701f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 751f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1510f, num3);
		Mathf.Lerp(158f, 580f, this.velos / 1649f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 1010f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("IdleButtonPress", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044E3 RID: 17635 RVA: 0x00208CAC File Offset: 0x00206EAC
	private void AGCPGBGIHOP()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(1, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.IGHOGONIKLC() - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1040f, 1622f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.OGJHINOLHJJ + 39f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 516f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1375f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 730f, num3);
		Mathf.Lerp(56f, 1340f, this.velos / 1674f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 546f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("OfficeSitting", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x060044E4 RID: 17636 RVA: 0x00208EEC File Offset: 0x002070EC
	private void DOHJPDNKALP()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.IGAHAGKLPAK(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.LBIIOGJLHML(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("StaffStand");
	}

	// Token: 0x060044E5 RID: 17637 RVA: 0x00208F68 File Offset: 0x00207168
	private void LKOLHNPIBLM()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
		this.debugLR.SetPosition(1, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.IGHOGONIKLC() - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 257f, 1362f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.IGHOGONIKLC() + 681f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 724f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 334f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 679f, num3);
		Mathf.Lerp(319f, 68f, this.velos / 239f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 901f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("Roll", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044E6 RID: 17638 RVA: 0x002091A8 File Offset: 0x002073A8
	private void MIFLHGMPLJD()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.CDBIEPGNONF(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.OAGBAIECENO(num2 > this.dstrender);
			}
		}
		else
		{
			this.IGAHAGKLPAK(true);
		}
		bool flag = false;
		float f = 1453f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.CDBIEPGNONF() - 994f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 808f)
			{
				float a = 755f * Mathf.Clamp(num * 998f, 1482f, 999f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1550f, 1219f, 1468f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1282f, 1988f, 34f, 1221f));
		}
	}

	// Token: 0x060044E7 RID: 17639 RVA: 0x00209428 File Offset: 0x00207628
	private void LBBGAADLMOM()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 endPointVector = Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = endPointVector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.OGJHINOLHJJ - fish.hookPoint.transform.position.y;
		float num = endPointVector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 203f, 405f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.IGHOGONIKLC() + 769f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 1834f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 667f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1051f, num3);
		Mathf.Lerp(923f, 774f, this.velos / 112f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 184f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("Cloth_07.wav", faodpfdpclh);
		this.trail.enabled = true;
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x00209668 File Offset: 0x00207868
	private void LEHBHOBDFCM(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044E9 RID: 17641 RVA: 0x002096B0 File Offset: 0x002078B0
	private void LBGKAMLLACN()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.IGHOGONIKLC(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.IGAHAGKLPAK(num2 > this.dstrender);
			}
		}
		else
		{
			this.JDDKDPONNPG(false);
		}
		bool flag = false;
		float f = 224f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 1593f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 325f)
			{
				float a = 1516f * Mathf.Clamp(num * 81f, 177f, 1118f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(377f, 31f, 705f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1006f, 551f, 1961f, 746f));
		}
	}

	// Token: 0x060044EA RID: 17642 RVA: 0x00209930 File Offset: 0x00207B30
	private void IGAHAGKLPAK(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			foreach (Renderer renderer in this.rends)
			{
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044EB RID: 17643 RVA: 0x00209978 File Offset: 0x00207B78
	private void ADLHNBEDHMJ()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.MCIHLLDFEJI(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.OAGBAIECENO(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned.");
	}

	// Token: 0x060044EC RID: 17644 RVA: 0x002099F4 File Offset: 0x00207BF4
	private void PMKOAHMNBBG()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.HKBNODJBGEL(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.BEGAOCGMJEK(num2 > this.dstrender);
			}
		}
		else
		{
			this.PJGBIKCDNEP(false);
		}
		bool flag = false;
		float f = 1764f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 374f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 488f)
			{
				float a = 1647f * Mathf.Clamp(num * 1770f, 1804f, 1211f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1185f, 547f, 1458f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(757f, 1273f, 136f, 854f));
		}
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x00209C74 File Offset: 0x00207E74
	private void AAOFEFNCNJC(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x00209CBC File Offset: 0x00207EBC
	private void JMNNAPNJDNK()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.CDBIEPGNONF(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.DKEJDBEFIKI(num2 > this.dstrender);
			}
		}
		else
		{
			this.PJGBIKCDNEP(true);
		}
		bool flag = false;
		float f = 866f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.CDBIEPGNONF() - 1325f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 233f)
			{
				float a = 1889f * Mathf.Clamp(num * 999f, 1598f, 1614f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1406f, 249f, 335f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(144f, 480f, 690f, 1112f));
		}
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x00209F3C File Offset: 0x0020813C
	private void EILPHLEBEJP()
	{
		if (GuiProcessor.BBLINJLBAIL() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 187f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -58
		};
		if (GuiProcessor.IKGFHGKKCPG.rusfont != null)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		}
		double num = (double)(ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("_ScratchTex", num);
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -125;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 303f, vector.y - 1733f, 740f, 702f), "error.wav");
			GUI.Label(new Rect(vector.x - 1280f, vector.y - 1321f, 660f, 192f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1935f) / 736f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 1677f, vector.y + 1383f, 121f, 359f), "stacheaderprocess", guistyle);
			}
		}
	}

	// Token: 0x060044F0 RID: 17648 RVA: 0x0020A164 File Offset: 0x00208364
	private void OBJCOJEHLBE()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.EINIHGNNIPF(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.NIKPALBNKEL(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("");
	}

	// Token: 0x060044F1 RID: 17649 RVA: 0x0020A1E0 File Offset: 0x002083E0
	private void Start()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.HIJCPJJEBEO(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.HIJCPJJEBEO(false);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("_TintColor");
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x0020A25C File Offset: 0x0020845C
	private void CAJLCEPLKJG()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.CDDKOMHOELI(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.LEHBHOBDFCM(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("isBigFish");
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x0020A2D8 File Offset: 0x002084D8
	private void OFGMIEJKMGC()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.OJDCMNJINFC(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.IGAHAGKLPAK(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("1,2,3,4,5");
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x0020A354 File Offset: 0x00208554
	private void NMMGHFDLNOE()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.OGJHINOLHJJ, base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.OJDCMNJINFC(num2 > this.dstrender);
			}
		}
		else
		{
			this.DKEJDBEFIKI(false);
		}
		bool flag = false;
		float f = 722f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.IGHOGONIKLC() - 1265f)
				{
					flag = true;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 1454f)
			{
				float a = 1401f * Mathf.Clamp(num * 1202f, 1476f, 1307f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(958f, 460f, 847f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(1838f, 985f, 283f, 573f));
		}
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x0020A5D4 File Offset: 0x002087D4
	private void KMMEMAHCFLJ()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.LBIIOGJLHML(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.CDDKOMHOELI(false);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("_Color");
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x0020A650 File Offset: 0x00208850
	private void HCDJABMBDFF()
	{
		float num = (base.transform.position - this.BAHHIKELOJP).magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.CDBIEPGNONF(), base.transform.position.z);
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num2 = Vector3.Distance(Camera.main.transform.position, base.transform.position);
			if (HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
			{
				this.OAGBAIECENO(num2 > this.dstrender);
			}
		}
		else
		{
			this.NNOIPNAAJIG(true);
		}
		bool flag = false;
		float f = 1292f;
		if (Fisherman.getI.dropScrpt != null)
		{
			if (Fisherman.getI.dropScrpt.fish != null)
			{
				f = Vector3.Distance(base.transform.position, Fisherman.getI.dropScrpt.fish.transform.position);
				if (Fisherman.getI.dropScrpt.fish.hookPoint.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 1237f)
				{
					flag = false;
				}
			}
			this.trail != null;
		}
		if (this.fishOutWater != null && this.fishOutWater.isEmitting != flag)
		{
			if (!flag)
			{
				this.fishOutWater.Stop();
			}
			if (flag)
			{
				this.fishOutWater.Play();
			}
		}
		if (this.partSys != null && this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(f) < 1391f)
			{
				float a = 1883f * Mathf.Clamp(num * 303f, 1163f, 1174f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(399f, 797f, 1764f, a));
				return;
			}
			main.startColor = new ParticleSystem.MinMaxGradient(new Color(912f, 1088f, 1954f, 1287f));
		}
	}

	// Token: 0x060044F7 RID: 17655 RVA: 0x0020A8D0 File Offset: 0x00208AD0
	private void LBIIOGJLHML(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044F8 RID: 17656 RVA: 0x0020A918 File Offset: 0x00208B18
	private void HFHCPAKHHDK(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044F9 RID: 17657 RVA: 0x0020A960 File Offset: 0x00208B60
	private void EIEKEPGNGPL()
	{
		this.debugLR.enabled = LocNewLogic.getI.isDebugMode;
		if (Fisherman.getI.dropScrpt == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = Fisherman.getI.dropScrpt.fish;
		Vector3 vector = Fisherman.getI.AOEGNGOGNBI.CNDKCPLCGAB();
		this.debugLR.SetPosition(0, base.transform.position);
		this.debugLR.SetPosition(0, fish.debugMarker.transform.position);
		this.velos = Vector3.Distance(base.transform.position, this.old) / Time.deltaTime;
		this.old = base.transform.position;
		Vector3 a = vector - fish.hookPoint.transform.position;
		float value = LocNewLogic.getI.CDBIEPGNONF() - fish.hookPoint.transform.position.y;
		float num = vector.y - fish.hookPoint.transform.position.y;
		float num2 = Mathf.Clamp(value, 1150f, 447f);
		float d = num2 / num;
		Vector3 b = a * d;
		Vector3 position = fish.hookPoint.transform.position + b;
		position.y = LocNewLogic.getI.HKBNODJBGEL() + 1138f;
		this.trail.gameObject.transform.position = position;
		float num3 = num2 * 1679f;
		this.trail.widthMultiplier = Mathf.Lerp(this.KCLBPADPHEP, 1944f, num3);
		this.trail.time = Mathf.Lerp(this.KCLBPADPHEP, 1862f, num3);
		Mathf.Lerp(1467f, 627f, this.velos / 1968f);
		Color faodpfdpclh = this.FAODPFDPCLH;
		faodpfdpclh.a = Mathf.Lerp(this.FAODPFDPCLH.a, 531f, Mathf.Max(num3, this.velos));
		this.trail.material.SetColor("", faodpfdpclh);
		this.trail.enabled = false;
	}

	// Token: 0x060044FA RID: 17658 RVA: 0x0020ABA0 File Offset: 0x00208DA0
	private void EGHNEHMKDDG(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA != this.NDIMGMFBJBM)
		{
			Renderer[] array = this.rends;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (renderer != null)
				{
					renderer.enabled = AFECKMFDAEA;
				}
			}
			this.NDIMGMFBJBM = AFECKMFDAEA;
		}
	}

	// Token: 0x060044FB RID: 17659 RVA: 0x0020ABE8 File Offset: 0x00208DE8
	private void BHFMGBNIAMC()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.PJGBIKCDNEP(true);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.NIKPALBNKEL(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("ElvisLegsLoop");
	}

	// Token: 0x060044FC RID: 17660 RVA: 0x0020AC64 File Offset: 0x00208E64
	private void FCCAIANLEFE()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.EGHNEHMKDDG(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.OJDCMNJINFC(true);
		}
		this.trail.enabled = false;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("knopje.wav");
	}

	// Token: 0x060044FD RID: 17661 RVA: 0x0020ACE0 File Offset: 0x00208EE0
	private void ONIHHFLOJMN()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.EGHNEHMKDDG(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.DKEJDBEFIKI(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("_HrDepthTex");
	}

	// Token: 0x060044FE RID: 17662 RVA: 0x0020AD5C File Offset: 0x00208F5C
	private void OKICICGNAFP()
	{
		if (GuiProcessor.IKGFHGKKCPG == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 777f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -116
		};
		if (GuiProcessor.NKOEAPCIBKO().rusfont != null)
		{
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		}
		double num = (double)(ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("_Intensity", num);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -126;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 589f, vector.y - 1665f, 1290f, 1850f), "Water Refl Camera id");
			GUI.Label(new Rect(vector.x - 449f, vector.y - 565f, 945f, 1769f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1540f) / 1004f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 398f, vector.y + 1850f, 361f, 608f), "===== ObscuredStringTest =====\n", guistyle);
			}
		}
	}

	// Token: 0x060044FF RID: 17663 RVA: 0x0020AF84 File Offset: 0x00209184
	private void OLBDOHCILKO()
	{
		if (GuiProcessor.PLGADNLAEGN() == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		position.y += 19f;
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -105
		};
		if (GuiProcessor.PLGADNLAEGN().rusfont != null)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		}
		double num = (double)(ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DJOHGAHBGLG));
		Vector3 position2 = Fisherman.getI.transform.position;
		Vector3 position3 = Fisherman.getI.dropScrpt.transform.position;
		position3.y = position2.y;
		num = (double)Vector3.Distance(position2, position3);
		string text = string.Format("crft_none", num);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.normal.textColor = Color.green;
		guistyle.fontSize = -120;
		guistyle.CalcSize(new GUIContent(text));
		if (this.NDIMGMFBJBM)
		{
			GUI.Box(new Rect(vector.x - 1163f, vector.y - 795f, 26f, 1155f), " ");
			GUI.Label(new Rect(vector.x - 1924f, vector.y - 580f, 1470f, 1241f), text, guistyle);
		}
		if (Application.isEditor)
		{
			float num2 = (float)Mathf.CeilToInt(Fisherman.getI.dropScrpt.fish.fRangle * 1940f) / 802f;
			if (!Application.isEditor && LocNewLogic.getI.isDebugMode && Fisherman.getI.dropScrpt.fish.beregdet)
			{
				GUI.Label(new Rect(vector.x - 183f, vector.y + 1686f, 907f, 1387f), "crft_from", guistyle);
			}
		}
	}

	// Token: 0x06004500 RID: 17664 RVA: 0x0020B1AC File Offset: 0x002093AC
	private void PLBDELOIINH()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.CDDKOMHOELI(false);
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.DLNBKAPMNJC)
		{
			this.OJDCMNJINFC(true);
		}
		this.trail.enabled = true;
		this.KCLBPADPHEP = this.trail.widthMultiplier;
		this.CPEAFPEJBDI = this.trail.time;
		this.FAODPFDPCLH = this.trail.material.GetColor("RollerBladeTurnRight");
	}

	// Token: 0x04000AE8 RID: 2792
	public LineRenderer debugLR;

	// Token: 0x04000AE9 RID: 2793
	public ParticleSystem fishOutWater;

	// Token: 0x04000AEA RID: 2794
	public TrailRenderer trail;

	// Token: 0x04000AEB RID: 2795
	public Trail trailEmtr;

	// Token: 0x04000AEC RID: 2796
	public ParticleSystem partSys;

	// Token: 0x04000AED RID: 2797
	public Renderer[] rends;

	// Token: 0x04000AEE RID: 2798
	private float KCLBPADPHEP;

	// Token: 0x04000AEF RID: 2799
	private float CPEAFPEJBDI;

	// Token: 0x04000AF0 RID: 2800
	private Color FAODPFDPCLH;

	// Token: 0x04000AF1 RID: 2801
	private bool NDIMGMFBJBM = true;

	// Token: 0x04000AF2 RID: 2802
	public float dstrender = 12f;

	// Token: 0x04000AF3 RID: 2803
	public Vector3 old;

	// Token: 0x04000AF4 RID: 2804
	public float velos;

	// Token: 0x04000AF5 RID: 2805
	private Vector3 BAHHIKELOJP;
}
