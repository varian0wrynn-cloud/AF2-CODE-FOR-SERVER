using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000FD RID: 253
public class ActiveObject : MonoBehaviour
{
	// Token: 0x06002F59 RID: 12121 RVA: 0x001559D4 File Offset: 0x00153BD4
	private void JBGGMKEKOAN()
	{
		if (JDCEFOFMGHB.HMJJPNDEKPP().NKJEEHEODBF())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.PENBJPBKNJJ())
		{
			string text = JNBICAJIJMM.IMLLGEMPHAP().IPHGEPDFCJL("error.wav", "Sunshine Cascade Camera {0}" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "SoccerKeeperDiveStrafeFarLeft")
			{
				float num = Input.mousePosition.x + 781f;
				float num2 = Input.mousePosition.y - 1278f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -119,
					wordWrap = false,
					normal = 
					{
						textColor = new Color(1333f, 141f, 1985f, 325f)
					},
					alignment = TextAnchor.UpperRight
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "_ReflectionTexture0" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 143f, num2 - 223f, x + 332f, 1877f);
				HFIINBICCLO.IKGFHGKKCPG.IFCLDNHAIGB(rect, new Color(1996f, 1352f, 1230f, 102f));
				HFIINBICCLO.JFNBEACKGKI().IIBIJPNJABF(rect, new Color(1237f, 1934f, 63f, 1293f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x00155B55 File Offset: 0x00153D55
	private void CFMACGHDAEH()
	{
		this.HPFNOLEHCBH(false);
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x00155B60 File Offset: 0x00153D60
	public void EHNGNBPCDMB(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				foreach (Material material in renderer.materials)
				{
					material.EnableKeyword("");
					material.SetColor(this.isU5StandartShader ? "_BlurDistance" : "Mouse Y", value);
				}
			}
		}
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool ABDBLLLMAFA()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x00155C18 File Offset: 0x00153E18
	private void OFHMLOLOGMK()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.DOIONOCKOLD(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 717f)
		{
			this.GMABAHMMJIN(false);
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 0)
		{
			this.ENBMFIHLBPJ(true);
		}
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x00155C8C File Offset: 0x00153E8C
	private void OnGUI()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.DFMGCLDOKIG)
		{
			string text = JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("INTERFACE", "active_obj_" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "")
			{
				float num = Input.mousePosition.x + 5f;
				float num2 = Input.mousePosition.y - 25f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = 11,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(0.8f, 0.8f, 0.8f, 1f)
					},
					alignment = TextAnchor.MiddleCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + " " + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 6f, num2 - 6f, x + 32f, 30f);
				HFIINBICCLO.IKGFHGKKCPG.OFOFJOLCFMD(rect, new Color(0.2f, 0.2f, 0.15f, 1f));
				HFIINBICCLO.IKGFHGKKCPG.LONEPNCDEOK(rect, new Color(0f, 0f, 0f, 1f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F5F RID: 12127 RVA: 0x00155E10 File Offset: 0x00154010
	private void FPOBDDHEPOE()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.IBHLHMJNNAG(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 846f)
		{
			this.OOPIINIEJHG(true);
		}
		if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 1)
		{
			this.DFMGCLDOKIG = true;
		}
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x00155E84 File Offset: 0x00154084
	public void ENKKMHCGMLP(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 0; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					material.EnableKeyword("OnStatusChanged UNKNOW ");
					material.SetColor(this.isU5StandartShader ? "bag" : "", value);
				}
			}
		}
	}

	// Token: 0x06002F61 RID: 12129 RVA: 0x00155F34 File Offset: 0x00154134
	private void GHCMIKGJPJD()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			foreach (Renderer renderer in array)
			{
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("req.text=");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("ClimbIdle"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("TOD_SpaceTiling");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("WallSit"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x00156000 File Offset: 0x00154200
	private void MGOJFCOBDPI()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.GGCLOKODHEG())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.AIINCFAHIAN())
		{
			string text = JNBICAJIJMM.LPHMKPDBMPP().CAFEIHBPIJB("cntx_use", "\n" + this.obj_type);
			text = this.iName;
			if (text.Trim() != " <color='#60ff60'>Бонус от `{0}` +{1}%</color>")
			{
				float num = Input.mousePosition.x + 1942f;
				float num2 = Input.mousePosition.y - 1178f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -9,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(87f, 121f, 133f, 1850f)
					},
					alignment = TextAnchor.MiddleRight
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "StaffStand" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 209f, num2 - 1301f, x + 920f, 376f);
				HFIINBICCLO.GDDAGIILGGM().GCALFLOEPKI(rect, new Color(815f, 737f, 1279f, 503f));
				HFIINBICCLO.IKGFHGKKCPG.LONEPNCDEOK(rect, new Color(2f, 280f, 519f, 1444f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F63 RID: 12131 RVA: 0x00156184 File Offset: 0x00154384
	public void ANEKGOLMNPN()
	{
		Debug.Log("_WrinkleNormalMap2");
		this.JPGGOACIOGC(true);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.NPIEJELJPIM().MKOPHEAGIGE(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.JHJHHBLGMPJ(this.ActivateSound[num], base.transform.position, 1860f, 1840f, 944f, 1517f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "HDR")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.AAHBHCMKGJD((long)this.addId);
				epmphjgalbe.MFPECHIKBCO(0L);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(75, epmphjgalbe.HDEKHFOKCKI());
				return;
			}
			finally
			{
				epmphjgalbe.PMIGGJHLIDO();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.LHLOOIDHGMA(this.addId);
				epmphjgalbe2.NEHCMOODKIN(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-181, epmphjgalbe2.HDEKHFOKCKI());
				return;
			}
			finally
			{
				epmphjgalbe2.HDKBMLOJLLC();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 0;
				}
				epmphjgalbe3.LHLOOIDHGMA(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(169, epmphjgalbe3.JOCJNOBBELJ());
				return;
			}
			finally
			{
				epmphjgalbe3.PMIGGJHLIDO();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(108, this.addId);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(84, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("ProneLocomotion" + this.addInfo).MFHCGLHGAID();
		if (list.Count != 0)
		{
			LocBaseManager.EDKKJNHDBPF().toGlobalMap = list[1];
			LocBaseManager.CHFPAOGEMEM().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.NPCAKEGNBHD().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.EIMEKHOFIEA(iibeekcaahk.KMIOLLENCOL());
					epmphjgalbe4.DEHJNGMHGAJ(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.PDEFLCIEMFF(iibeekcaahk.NFCDJLJNDLO());
				}
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-162, epmphjgalbe4.JOCJNOBBELJ());
			}
			finally
			{
				epmphjgalbe4.OGPGOEJFIBO();
			}
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.JDOLCNDNFGP(iibeekcaahk2.KEHIFGILLJA());
			epmphjgalbe5.JIIKLOKAGIC(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.PDEFLCIEMFF(iibeekcaahk2.CJKILDPJCFJ());
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(146, epmphjgalbe5.HDEKHFOKCKI());
			return;
		}
		finally
		{
			epmphjgalbe5.OGPGOEJFIBO();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("gi_uinf_2", 650f);
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(130, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.PDEFLCIEMFF(0);
			epmphjgalbe6.DEHJNGMHGAJ(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(75, epmphjgalbe6.JOCJNOBBELJ());
			return;
		}
		finally
		{
			epmphjgalbe6.PMIGGJHLIDO();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(22, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		return;
		IL_3BC:
		JDCEFOFMGHB.IKGFHGKKCPG.POIPOBBIDPM("textAsset is NULL! Path: Cells", "IdleSpew");
	}

	// Token: 0x06002F64 RID: 12132 RVA: 0x001565BC File Offset: 0x001547BC
	public void OOPIINIEJHG(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i++)
				{
					Material material = materials[i];
					material.EnableKeyword("{0} / {1}");
					material.SetColor(this.isU5StandartShader ? "Q" : ", ", value);
				}
			}
		}
	}

	// Token: 0x06002F65 RID: 12133 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool CKEGKAGKFNG()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F66 RID: 12134 RVA: 0x0015666C File Offset: 0x0015486C
	public void KIBPOMCEEDL()
	{
		Debug.Log("Mirror Refl Camera id");
		this.GMABAHMMJIN(false);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.IKGFHGKKCPG.EFGDDAPIKBH(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.NBMHEPNPHFP(this.ActivateSound[num], base.transform.position, 1342f, 916f, 1096f, 1045f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "BlackSmithHammer")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.MFPECHIKBCO((long)this.addId);
				epmphjgalbe.AAHBHCMKGJD(1L);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(43, epmphjgalbe.PBOPEDMCKDD());
				return;
			}
			finally
			{
				epmphjgalbe.HDKBMLOJLLC();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.JDOLCNDNFGP(this.addId);
				epmphjgalbe2.NMPPIONANIB(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(31, epmphjgalbe2.LAFILAEOPAJ());
				return;
			}
			finally
			{
				epmphjgalbe2.PMIGGJHLIDO();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 5;
				}
				epmphjgalbe3.FLLJONHPLNA(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(75, epmphjgalbe3.PBOPEDMCKDD());
				return;
			}
			finally
			{
				epmphjgalbe3.OGPGOEJFIBO();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(169, this.addId);
			JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(25, this.addId);
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("" + this.addInfo).GDOEONNNHKL();
		if (list.Count != 0)
		{
			LocBaseManager.GJACINHCABC().toGlobalMap = list[1];
			LocBaseManager.FJLCHDGLMMK().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.NPCAKEGNBHD().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.JIIKLOKAGIC(iibeekcaahk.KMIOLLENCOL());
					epmphjgalbe4.EAOGDKDBENC(iibeekcaahk.NLHKFMMDMMK());
					epmphjgalbe4.JIIKLOKAGIC(iibeekcaahk.CJKILDPJCFJ());
				}
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(130, epmphjgalbe4.NNEAJJNCGMK());
			}
			finally
			{
				epmphjgalbe4.PGLFHABMJPO();
			}
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.ALNEALEKFNB(iibeekcaahk2.KEHIFGILLJA());
			epmphjgalbe5.GOMLLPFFPNP(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.FLLJONHPLNA(iibeekcaahk2.NFCDJLJNDLO());
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(24, epmphjgalbe5.NNEAJJNCGMK());
			return;
		}
		finally
		{
			epmphjgalbe5.PGLFHABMJPO();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("openQuest", 1643f);
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-161, 0);
		return;
		IL_30B:
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.LHLOOIDHGMA(1);
			epmphjgalbe6.JDOLCNDNFGP(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(160, epmphjgalbe6.IEJLLFECFHF());
			return;
		}
		finally
		{
			epmphjgalbe6.LMBPNFHKNGA();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-25, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
		return;
		IL_3BC:
		JDCEFOFMGHB.HMJJPNDEKPP().NODOOHPCCCB("SoccerSprint", "IdleSlide");
	}

	// Token: 0x06002F67 RID: 12135 RVA: 0x00156AA4 File Offset: 0x00154CA4
	private void FLDMAFHJLNB()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.BPFBFBLIHDP())
		{
			string text = JNBICAJIJMM.DBMJJPBOPEK().JDBGNILGMDO("Text:", "1 H Sword Charge Heavy Bash" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "forFishes")
			{
				float num = Input.mousePosition.x + 1234f;
				float num2 = Input.mousePosition.y - 653f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = 114,
					wordWrap = false,
					normal = 
					{
						textColor = new Color(1175f, 395f, 999f, 852f)
					},
					alignment = TextAnchor.UpperCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + ".unity3d" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 786f, num2 - 255f, x + 842f, 1860f);
				HFIINBICCLO.KPGHCNPGAGL().JDOKDJDLPBL(rect, new Color(259f, 424f, 1012f, 382f));
				HFIINBICCLO.ENNAAFEOFAH().ABHJNIEJOGD(rect, new Color(137f, 1595f, 804f, 1058f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F68 RID: 12136 RVA: 0x00156C28 File Offset: 0x00154E28
	public void HPFNOLEHCBH(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i++)
				{
					Material material = materials[i];
					material.EnableKeyword("SkateboardIdle");
					material.SetColor(this.isU5StandartShader ? "Only Hinge Rotation Limits should be used on 2D IK solvers." : "WandAttack", value);
				}
			}
		}
	}

	// Token: 0x06002F69 RID: 12137 RVA: 0x00156CD8 File Offset: 0x00154ED8
	private void MFHHLKFIEIF()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.OEBKEEMGFCE(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1784f)
		{
			this.GMABAHMMJIN(false);
		}
		if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 0)
		{
			this.GEGGIKIIMKM(true);
		}
	}

	// Token: 0x06002F6A RID: 12138 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool AIINCFAHIAN()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x00156D4C File Offset: 0x00154F4C
	private void FECFLBMPAAL()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			foreach (Renderer renderer in array)
			{
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("MotorbikeHeadstand");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("isRodOpen"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("?");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty(" "))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x00156E18 File Offset: 0x00155018
	public void DOIONOCKOLD(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					material.EnableKeyword("[AmplifyColor] ");
					material.SetColor(this.isU5StandartShader ? "{0:F2}, {1:F2}" : "_ReflectionBlur", value);
				}
			}
		}
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x00156EC8 File Offset: 0x001550C8
	public void IBHLHMJNNAG(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				foreach (Material material in renderer.materials)
				{
					material.EnableKeyword("MotorbikeLassoBack");
					material.SetColor(this.isU5StandartShader ? "" : "Office", value);
				}
			}
		}
	}

	// Token: 0x06002F6E RID: 12142 RVA: 0x00156F78 File Offset: 0x00155178
	private void KIEIPFFEDHC()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword(" x");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("Arm Flex 2"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("MotorbikeWheelyNoHands");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty(" is not supported on this platform!"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F6F RID: 12143 RVA: 0x00157044 File Offset: 0x00155244
	public void OAGEKPOGAJK(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i++)
				{
					Material material = materials[i];
					material.EnableKeyword("/");
					material.SetColor(this.isU5StandartShader ? "GestureCrowdPump" : "fire off", value);
				}
			}
		}
	}

	// Token: 0x06002F70 RID: 12144 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool CIODLFOHLGL()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x001570F4 File Offset: 0x001552F4
	public void DKGDHBLDLAO()
	{
		Debug.Log("post_msg4");
		this.EHNGNBPCDMB(false);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.IFLFANPMLMM().MIPEBCJCHNJ(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.HFGAHFGKFKL(this.ActivateSound[num], base.transform.position, 103f, 542f, 1309f, 67f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "Worker Hammer")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.AAHBHCMKGJD((long)this.addId);
				epmphjgalbe.AAHBHCMKGJD(0L);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(118, epmphjgalbe.JDPHBLHOLAD());
				return;
			}
			finally
			{
				epmphjgalbe.NCKMEIBFNGL();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.DEHJNGMHGAJ(this.addId);
				epmphjgalbe2.NMPPIONANIB(this.addInfo);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(101, epmphjgalbe2.PBOPEDMCKDD());
				return;
			}
			finally
			{
				epmphjgalbe2.OGPGOEJFIBO();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 0;
				}
				epmphjgalbe3.EIMEKHOFIEA(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(102, epmphjgalbe3.JOCJNOBBELJ());
				return;
			}
			finally
			{
				epmphjgalbe3.NCKMEIBFNGL();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(149, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-58, this.addId);
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("_ProjectToPixelMatrix" + this.addInfo).BNAMDHOMEHH();
		if (list.Count != 0)
		{
			LocBaseManager.FJLCHDGLMMK().toGlobalMap = list[0];
			LocBaseManager.GJACINHCABC().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.NPCAKEGNBHD().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.DEHJNGMHGAJ(iibeekcaahk.KEHIFGILLJA());
					epmphjgalbe4.EAOGDKDBENC(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.LHLOOIDHGMA(iibeekcaahk.NODLBGKEGPM);
				}
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(81, epmphjgalbe4.IEJLLFECFHF());
			}
			finally
			{
				epmphjgalbe4.LMBPNFHKNGA();
			}
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.GOMLLPFFPNP(iibeekcaahk2.NKEOCCKEOCE());
			epmphjgalbe5.LHLOOIDHGMA(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.FLLJONHPLNA(iibeekcaahk2.NFCDJLJNDLO());
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-40, epmphjgalbe5.PBOPEDMCKDD());
			return;
		}
		finally
		{
			epmphjgalbe5.PMIGGJHLIDO();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Apply 11", 1868f);
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-151, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.ALNEALEKFNB(1);
			epmphjgalbe6.ALNEALEKFNB(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(159, epmphjgalbe6.PBOPEDMCKDD());
			return;
		}
		finally
		{
			epmphjgalbe6.HDKBMLOJLLC();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-23, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		return;
		IL_3BC:
		JDCEFOFMGHB.JFIDAGABKID().KGHDLHHLLIC("_Cutoff", "wpn_hook3");
	}

	// Token: 0x06002F72 RID: 12146 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool MIMNEMHLJBH()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F73 RID: 12147 RVA: 0x0015752C File Offset: 0x0015572C
	public void FDBKINBECMJ()
	{
		Debug.Log("wpn_eat1");
		this.EHNGNBPCDMB(true);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.IKGFHGKKCPG.FCEGAKPPDCA(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.EIDHGLDAPFI(this.ActivateSound[num], base.transform.position, 71f, 1563f, 1782f, 1659f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "_BlurPass")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.MFPECHIKBCO((long)this.addId);
				epmphjgalbe.OBJBHBFAFEE(0L);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-108, epmphjgalbe.LAFILAEOPAJ());
				return;
			}
			finally
			{
				epmphjgalbe.PMIGGJHLIDO();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.DEHJNGMHGAJ(this.addId);
				epmphjgalbe2.BNPGKHHADEH(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(61, epmphjgalbe2.PBOPEDMCKDD());
				return;
			}
			finally
			{
				epmphjgalbe2.KNPHNLLMJKJ();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 0;
				}
				epmphjgalbe3.GOMLLPFFPNP(num2);
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(69, epmphjgalbe3.IEJLLFECFHF());
				return;
			}
			finally
			{
				epmphjgalbe3.LMBPNFHKNGA();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(6, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-65, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("t_much" + this.addInfo).BNAMDHOMEHH();
		if (list.Count != 0)
		{
			LocBaseManager.NPIEJELJPIM().toGlobalMap = list[1];
			LocBaseManager.CHFPAOGEMEM().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.EDKKJNHDBPF().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.AEMAHNDEBKJ(iibeekcaahk.KEHIFGILLJA());
					epmphjgalbe4.KPCGLGHDILI(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.DEHJNGMHGAJ(iibeekcaahk.NODLBGKEGPM);
				}
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(133, epmphjgalbe4.NNEAJJNCGMK());
			}
			finally
			{
				epmphjgalbe4.BKKEFKANGIM();
			}
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.KPCGLGHDILI(iibeekcaahk2.IBEIBAHKIAH);
			epmphjgalbe5.KPCGLGHDILI(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.EIMEKHOFIEA(iibeekcaahk2.CJKILDPJCFJ());
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-182, epmphjgalbe5.ALLANCHILCM());
			return;
		}
		finally
		{
			epmphjgalbe5.BKKEFKANGIM();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("", 526f);
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(12, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.EAOGDKDBENC(1);
			epmphjgalbe6.FLLJONHPLNA(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-173, epmphjgalbe6.PBOPEDMCKDD());
			return;
		}
		finally
		{
			epmphjgalbe6.PGLFHABMJPO();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(79, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
		return;
		IL_3BC:
		JDCEFOFMGHB.JFIDAGABKID().NODOOHPCCCB("WeaponReady", " ");
	}

	// Token: 0x06002F74 RID: 12148 RVA: 0x00157964 File Offset: 0x00155B64
	private void AFKKPKNDJLH()
	{
		this.GEGGIKIIMKM(true);
	}

	// Token: 0x06002F75 RID: 12149 RVA: 0x00157970 File Offset: 0x00155B70
	private void OLBDJCFPKFG()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("icon_data/icon");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("RollerBladeCrossoverRight"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("Hidden/FXAA3");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("wgt_kg"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x00157A3C File Offset: 0x00155C3C
	private void BMCKJEBCEPA()
	{
		if (JDCEFOFMGHB.HMJJPNDEKPP().JBMEDLAFJNI())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.BPFBFBLIHDP())
		{
			string text = JNBICAJIJMM.CLIMNFDGOEG().JDBGNILGMDO("IdleDie", "shop_t6" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "wpnend")
			{
				float num = Input.mousePosition.x + 1027f;
				float num2 = Input.mousePosition.y - 1469f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = 59,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(1932f, 1401f, 1904f, 185f)
					},
					alignment = TextAnchor.MiddleRight
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "Please select the effectors to interact with." + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 1622f, num2 - 1977f, x + 658f, 874f);
				HFIINBICCLO.KPGHCNPGAGL().MKLNHHJGGAJ(rect, new Color(1854f, 940f, 1381f, 765f));
				HFIINBICCLO.GICMOPPKLPC().LONEPNCDEOK(rect, new Color(774f, 1097f, 1078f, 1511f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x00157BC0 File Offset: 0x00155DC0
	public void OILBKCKKAIB()
	{
		Debug.Log("Worker Shovel");
		this.ENKKMHCGMLP(false);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.IKGFHGKKCPG.JKGCGMKDAHH(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.KCBPPLKKCNP(this.ActivateSound[num], base.transform.position, 390f, 972f, 1049f, 1104f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "wpn_add/base")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ((long)this.addId);
				epmphjgalbe.OACBICLGENB(0L);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(34, epmphjgalbe.ALLANCHILCM());
				return;
			}
			finally
			{
				epmphjgalbe.OGPGOEJFIBO();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.LHLOOIDHGMA(this.addId);
				epmphjgalbe2.HGCCFFKDELO(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-129, epmphjgalbe2.HDEKHFOKCKI());
				return;
			}
			finally
			{
				epmphjgalbe2.BKKEFKANGIM();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 0;
				}
				epmphjgalbe3.DEHJNGMHGAJ(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(130, epmphjgalbe3.JOCJNOBBELJ());
				return;
			}
			finally
			{
				epmphjgalbe3.KNPHNLLMJKJ();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-93, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-24, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("RightSplashPause" + this.addInfo).PBCAFLLKCAO();
		if (list.Count != 0)
		{
			LocBaseManager.FJLCHDGLMMK().toGlobalMap = list[0];
			LocBaseManager.AIHINNHNNIA().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.CHFPAOGEMEM().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.PDEFLCIEMFF(iibeekcaahk.KMIOLLENCOL());
					epmphjgalbe4.DEHJNGMHGAJ(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.AEMAHNDEBKJ(iibeekcaahk.NODLBGKEGPM);
				}
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-40, epmphjgalbe4.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe4.KNPHNLLMJKJ();
			}
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.FLLJONHPLNA(iibeekcaahk2.NKEOCCKEOCE());
			epmphjgalbe5.JDOLCNDNFGP(iibeekcaahk2.ICJDPPOJINN);
			epmphjgalbe5.JIIKLOKAGIC(iibeekcaahk2.NODLBGKEGPM);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-131, epmphjgalbe5.NNEAJJNCGMK());
			return;
		}
		finally
		{
			epmphjgalbe5.NCKMEIBFNGL();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Weapon Stand", 1778f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-194, 0);
		return;
		IL_30B:
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.JDOLCNDNFGP(1);
			epmphjgalbe6.DEHJNGMHGAJ(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(129, epmphjgalbe6.IEJLLFECFHF());
			return;
		}
		finally
		{
			epmphjgalbe6.KNPHNLLMJKJ();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-68, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
		return;
		IL_3BC:
		JDCEFOFMGHB.HMJJPNDEKPP().NODOOHPCCCB("_WaterLevel", "pelvis");
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x00157FF8 File Offset: 0x001561F8
	private void OFGMIEJKMGC()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("Reset");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("UI_DynamicWindow"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("isBrag");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("_BlurDistance"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool JKHGOOCLOCI()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x001580FC File Offset: 0x001562FC
	private void LNKPEKPECMM()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.JPGGOACIOGC(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1286f)
		{
			this.OEBKEEMGFCE(false);
		}
		if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 1)
		{
			this.OOPIINIEJHG(false);
		}
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x00158170 File Offset: 0x00156370
	public void KFIJLJNMCMI()
	{
		Debug.Log("#6000ff");
		this.HPFNOLEHCBH(false);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.NPIEJELJPIM().GHCBFLEDNFE(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.HKKKCIAJPAC(this.ActivateSound[num], base.transform.position, 22f, 851f, 1347f, 513f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "_FgOverlap")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.AAHBHCMKGJD((long)this.addId);
				epmphjgalbe.PMJPIJMHELL(1L);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-5, epmphjgalbe.IEJLLFECFHF());
				return;
			}
			finally
			{
				epmphjgalbe.PGLFHABMJPO();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.JIIKLOKAGIC(this.addId);
				epmphjgalbe2.LKNDBBGMIOE(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(74, epmphjgalbe2.PBOPEDMCKDD());
				return;
			}
			finally
			{
				epmphjgalbe2.KNPHNLLMJKJ();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 1;
				}
				epmphjgalbe3.EIMEKHOFIEA(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-4, epmphjgalbe3.JOCJNOBBELJ());
				return;
			}
			finally
			{
				epmphjgalbe3.KNPHNLLMJKJ();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-43, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(64, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("SoundMgr is init part 2" + this.addInfo).JJOPAMIHIFC();
		if (list.Count != 0)
		{
			LocBaseManager.FJLCHDGLMMK().toGlobalMap = list[1];
			LocBaseManager.GJACINHCABC().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.CHFPAOGEMEM().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.PDEFLCIEMFF(iibeekcaahk.NKEOCCKEOCE());
					epmphjgalbe4.AEMAHNDEBKJ(iibeekcaahk.NLHKFMMDMMK());
					epmphjgalbe4.PDEFLCIEMFF(iibeekcaahk.NFCDJLJNDLO());
				}
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-50, epmphjgalbe4.NNEAJJNCGMK());
			}
			finally
			{
				epmphjgalbe4.LMBPNFHKNGA();
			}
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.FLLJONHPLNA(iibeekcaahk2.IBEIBAHKIAH);
			epmphjgalbe5.DEHJNGMHGAJ(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.DEHJNGMHGAJ(iibeekcaahk2.CJKILDPJCFJ());
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(87, epmphjgalbe5.JOCJNOBBELJ());
			return;
		}
		finally
		{
			epmphjgalbe5.OGPGOEJFIBO();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("_camouflage", 74f);
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-29, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.JIIKLOKAGIC(0);
			epmphjgalbe6.LHLOOIDHGMA(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-91, epmphjgalbe6.LAFILAEOPAJ());
			return;
		}
		finally
		{
			epmphjgalbe6.PGLFHABMJPO();
		}
		IL_355:
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-64, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		return;
		IL_3BC:
		JDCEFOFMGHB.JFIDAGABKID().BEIDJANKEFD("crft_from", "Full Body IK is missing the left thigh node.");
	}

	// Token: 0x06002F7D RID: 12157 RVA: 0x001585A8 File Offset: 0x001567A8
	private void HCCGBDPCEKO()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.GGCLOKODHEG())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.AECIDPAHIDG())
		{
			string text = JNBICAJIJMM.EDKGBBIIBBC().DBPANLKEHMN("", "_BlurRadius4" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "wpn_add/base")
			{
				float num = Input.mousePosition.x + 1939f;
				float num2 = Input.mousePosition.y - 373f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -95,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(1403f, 441f, 161f, 269f)
					},
					alignment = TextAnchor.LowerCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "crft_norec2" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 1915f, num2 - 134f, x + 147f, 1159f);
				HFIINBICCLO.BPCNCENHEAG().JDOKDJDLPBL(rect, new Color(1596f, 119f, 1756f, 1125f));
				HFIINBICCLO.KPGHCNPGAGL().ABHJNIEJOGD(rect, new Color(415f, 1284f, 1504f, 247f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F7E RID: 12158 RVA: 0x0015872C File Offset: 0x0015692C
	public void FDIFNCAKENI()
	{
		Debug.Log("_WrinkleOcclusionMap1");
		this.DFMGCLDOKIG = true;
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.NPIEJELJPIM().MMKBEPHGHID(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.HKKKCIAJPAC(this.ActivateSound[num], base.transform.position, 1723f, 1725f, 158f, 1636f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "Sewing")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OACBICLGENB((long)this.addId);
				epmphjgalbe.OBJBHBFAFEE(1L);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-109, epmphjgalbe.PBOPEDMCKDD());
				return;
			}
			finally
			{
				epmphjgalbe.OGPGOEJFIBO();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.KPCGLGHDILI(this.addId);
				epmphjgalbe2.HGCCFFKDELO(this.addInfo);
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(16, epmphjgalbe2.LAFILAEOPAJ());
				return;
			}
			finally
			{
				epmphjgalbe2.PGLFHABMJPO();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 4;
				}
				epmphjgalbe3.AEMAHNDEBKJ(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(101, epmphjgalbe3.JOCJNOBBELJ());
				return;
			}
			finally
			{
				epmphjgalbe3.OGPGOEJFIBO();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-80, this.addId);
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(54, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("ApplePick" + this.addInfo).BNAMDHOMEHH();
		if (list.Count != 0)
		{
			LocBaseManager.EDKKJNHDBPF().toGlobalMap = list[0];
			LocBaseManager.FJLCHDGLMMK().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.NPCAKEGNBHD().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.ENDMKPCFKND(iibeekcaahk.IBEIBAHKIAH);
					epmphjgalbe4.ENDMKPCFKND(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.JIIKLOKAGIC(iibeekcaahk.CJKILDPJCFJ());
				}
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(145, epmphjgalbe4.NNEAJJNCGMK());
			}
			finally
			{
				epmphjgalbe4.KNPHNLLMJKJ();
			}
			JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.EIMEKHOFIEA(iibeekcaahk2.KEHIFGILLJA());
			epmphjgalbe5.ALNEALEKFNB(iibeekcaahk2.NLHKFMMDMMK());
			epmphjgalbe5.FLLJONHPLNA(iibeekcaahk2.NODLBGKEGPM);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-145, epmphjgalbe5.NNEAJJNCGMK());
			return;
		}
		finally
		{
			epmphjgalbe5.PGLFHABMJPO();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("RollerBladeGrindRoyale", 1746f);
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(10, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.ALNEALEKFNB(0);
			epmphjgalbe6.GOMLLPFFPNP(this.addId);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(100, epmphjgalbe6.NNEAJJNCGMK());
			return;
		}
		finally
		{
			epmphjgalbe6.PMIGGJHLIDO();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(148, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		return;
		IL_3BC:
		JDCEFOFMGHB.HMJJPNDEKPP().POIPOBBIDPM("Cloth_07.wav", "Turn");
	}

	// Token: 0x06002F7F RID: 12159 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool DBHKIFHOCPG()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F80 RID: 12160 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool MFBLNNFIGBE()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F81 RID: 12161 RVA: 0x00158B64 File Offset: 0x00156D64
	private void ELFALPCLKIE()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword(" ");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("IdleSlide"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("wpn_add/base"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F82 RID: 12162 RVA: 0x00158C30 File Offset: 0x00156E30
	private void EPNOADOGLJA()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.GEGGIKIIMKM(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1076f)
		{
			this.JPGGOACIOGC(true);
		}
		if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 0)
		{
			this.GEGGIKIIMKM(true);
		}
	}

	// Token: 0x06002F83 RID: 12163 RVA: 0x00158CA4 File Offset: 0x00156EA4
	public void MLFLPMFKLNF()
	{
		Debug.Log("invn_rec32");
		this.DOIONOCKOLD(false);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.IFLFANPMLMM().FCEGAKPPDCA(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.HKKKCIAJPAC(this.ActivateSound[num], base.transform.position, 182f, 1039f, 205f, 1783f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "active_obj_")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ((long)this.addId);
				epmphjgalbe.OBJBHBFAFEE(0L);
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-126, epmphjgalbe.JDPHBLHOLAD());
				return;
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.FLLJONHPLNA(this.addId);
				epmphjgalbe2.NEHCMOODKIN(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-38, epmphjgalbe2.IEJLLFECFHF());
				return;
			}
			finally
			{
				epmphjgalbe2.NCKMEIBFNGL();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 0;
				}
				epmphjgalbe3.KPCGLGHDILI(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-29, epmphjgalbe3.LAFILAEOPAJ());
				return;
			}
			finally
			{
				epmphjgalbe3.BKKEFKANGIM();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-56, this.addId);
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(9, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("IdleReadyLook" + this.addInfo).MFHCGLHGAID();
		if (list.Count != 0)
		{
			LocBaseManager.FJLCHDGLMMK().toGlobalMap = list[1];
			LocBaseManager.NPIEJELJPIM().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.NPIEJELJPIM().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.JDOLCNDNFGP(iibeekcaahk.NKEOCCKEOCE());
					epmphjgalbe4.FLLJONHPLNA(iibeekcaahk.NLHKFMMDMMK());
					epmphjgalbe4.EIMEKHOFIEA(iibeekcaahk.NFCDJLJNDLO());
				}
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(11, epmphjgalbe4.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe4.OGPGOEJFIBO();
			}
			JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.ENDMKPCFKND(iibeekcaahk2.IBEIBAHKIAH);
			epmphjgalbe5.PDEFLCIEMFF(iibeekcaahk2.NLHKFMMDMMK());
			epmphjgalbe5.DEHJNGMHGAJ(iibeekcaahk2.CJKILDPJCFJ());
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-95, epmphjgalbe5.HDEKHFOKCKI());
			return;
		}
		finally
		{
			epmphjgalbe5.PGLFHABMJPO();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("BlendDirection", 1455f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(182, 0);
		return;
		IL_30B:
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.PDEFLCIEMFF(1);
			epmphjgalbe6.GOMLLPFFPNP(this.addId);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-133, epmphjgalbe6.LAFILAEOPAJ());
			return;
		}
		finally
		{
			epmphjgalbe6.OGPGOEJFIBO();
		}
		IL_355:
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(107, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		return;
		IL_3BC:
		JDCEFOFMGHB.HMJJPNDEKPP().POIPOBBIDPM("_RampOffset", "Giant2HandSlamIdle");
	}

	// Token: 0x06002F84 RID: 12164 RVA: 0x001590DC File Offset: 0x001572DC
	private void IMABGALEMBI()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			foreach (Renderer renderer in array)
			{
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: ");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("_Position"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("G");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("cellicon"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F85 RID: 12165 RVA: 0x001591A6 File Offset: 0x001573A6
	private void ENBIKHMENJB()
	{
		this.ENBMFIHLBPJ(true);
	}

	// Token: 0x06002F86 RID: 12166 RVA: 0x001591B0 File Offset: 0x001573B0
	private void JJLABCFMMGC()
	{
		if (JDCEFOFMGHB.HMJJPNDEKPP().AMGIJECABAD())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.LHOPJCDLMIK())
		{
			string text = JNBICAJIJMM.EEOPOHEALPK().IPHGEPDFCJL("demoColor", "dummy" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "Apply 2")
			{
				float num = Input.mousePosition.x + 1652f;
				float num2 = Input.mousePosition.y - 1978f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = 97,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(1253f, 1025f, 405f, 1200f)
					},
					alignment = TextAnchor.MiddleLeft
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "wpn_chair1" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 708f, num2 - 485f, x + 1161f, 184f);
				HFIINBICCLO.BPCNCENHEAG().LKFFBDIMKII(rect, new Color(1645f, 263f, 375f, 1289f));
				HFIINBICCLO.JFNBEACKGKI().NBHJGLHKBMA(rect, new Color(981f, 182f, 343f, 1161f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F87 RID: 12167 RVA: 0x00159334 File Offset: 0x00157534
	private void ACLJDJBJLCD()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("IdleReadyCrouch");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("ThisRenderer.bones[i].name is null"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("FaceHit");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty(" / "))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F88 RID: 12168 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool BPFBFBLIHDP()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x00159400 File Offset: 0x00157600
	private void ONIHHFLOJMN()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("-U");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("123"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("sunshine_IsOrthographic");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("_SceneFogParams"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F8A RID: 12170 RVA: 0x001594CC File Offset: 0x001576CC
	private void DFEICFAJDHN()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.OAGEKPOGAJK(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1796f)
		{
			this.OOPIINIEJHG(false);
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1)
		{
			this.OOPIINIEJHG(true);
		}
	}

	// Token: 0x06002F8B RID: 12171 RVA: 0x00159540 File Offset: 0x00157740
	private void EHDFJNENCDG()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.HPFNOLEHCBH(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1351f)
		{
			this.ENBMFIHLBPJ(true);
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1)
		{
			this.GMABAHMMJIN(true);
		}
	}

	// Token: 0x06002F8C RID: 12172 RVA: 0x001595B4 File Offset: 0x001577B4
	public void GOHHBFHGIFI()
	{
		Debug.Log("SpinReel.ogg");
		this.ENBMFIHLBPJ(true);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.OBDBAABBAKB().MMKBEPHGHID(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.EBDBHKHOPMB(this.ActivateSound[num], base.transform.position, 1905f, 1580f, 568f, 1473f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "fish/")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OACBICLGENB((long)this.addId);
				epmphjgalbe.MFPECHIKBCO(0L);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(81, epmphjgalbe.NNEAJJNCGMK());
				return;
			}
			finally
			{
				epmphjgalbe.BKKEFKANGIM();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.JDOLCNDNFGP(this.addId);
				epmphjgalbe2.BNPGKHHADEH(this.addInfo);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-191, epmphjgalbe2.IEJLLFECFHF());
				return;
			}
			finally
			{
				epmphjgalbe2.PGLFHABMJPO();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 8;
				}
				epmphjgalbe3.JIIKLOKAGIC(num2);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(49, epmphjgalbe3.IEJLLFECFHF());
				return;
			}
			finally
			{
				epmphjgalbe3.OGPGOEJFIBO();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(172, this.addId);
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(125, this.addId);
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("OfficeSittingReadingCoffeeSip" + this.addInfo).HDELBIDJNOK;
		if (list.Count != 0)
		{
			LocBaseManager.CHFPAOGEMEM().toGlobalMap = list[1];
			LocBaseManager.FJLCHDGLMMK().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.FJLCHDGLMMK().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.EIMEKHOFIEA(iibeekcaahk.IBEIBAHKIAH);
					epmphjgalbe4.ENDMKPCFKND(iibeekcaahk.NLHKFMMDMMK());
					epmphjgalbe4.JDOLCNDNFGP(iibeekcaahk.NFCDJLJNDLO());
				}
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(167, epmphjgalbe4.PBOPEDMCKDD());
			}
			finally
			{
				epmphjgalbe4.BKKEFKANGIM();
			}
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.FLLJONHPLNA(iibeekcaahk2.KMIOLLENCOL());
			epmphjgalbe5.GOMLLPFFPNP(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.KPCGLGHDILI(iibeekcaahk2.CJKILDPJCFJ());
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-176, epmphjgalbe5.HDEKHFOKCKI());
			return;
		}
		finally
		{
			epmphjgalbe5.PMIGGJHLIDO();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Apply 7", 599f);
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-23, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.AEMAHNDEBKJ(1);
			epmphjgalbe6.ALNEALEKFNB(this.addId);
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(1, epmphjgalbe6.ALLANCHILCM());
			return;
		}
		finally
		{
			epmphjgalbe6.PGLFHABMJPO();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-147, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		return;
		IL_3BC:
		JDCEFOFMGHB.MNJNNDHCDGG().BEIDJANKEFD("Office", "Hidden/ACTk/WallHackTexture");
	}

	// Token: 0x06002F8D RID: 12173 RVA: 0x001599EC File Offset: 0x00157BEC
	private void HMPFJEPODEL()
	{
		if (JDCEFOFMGHB.HMJJPNDEKPP().GGCLOKODHEG())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.DFMGCLDOKIG)
		{
			string text = JNBICAJIJMM.EKEBHIJMEML().DBPANLKEHMN("fshop_hd3", "<b>ObscuredString:</b> " + this.obj_type);
			text = this.iName;
			if (text.Trim() != "USE_UV_BASED_REPROJECTION")
			{
				float num = Input.mousePosition.x + 114f;
				float num2 = Input.mousePosition.y - 616f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -62,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(10f, 1038f, 936f, 1406f)
					},
					alignment = TextAnchor.UpperCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "invn_ver3" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 1013f, num2 - 178f, x + 83f, 1594f);
				HFIINBICCLO.GICMOPPKLPC().MKLNHHJGGAJ(rect, new Color(106f, 1580f, 1578f, 1937f));
				HFIINBICCLO.GICMOPPKLPC().ABHJNIEJOGD(rect, new Color(1621f, 312f, 210f, 507f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F8E RID: 12174 RVA: 0x00159B6D File Offset: 0x00157D6D
	private void DAKDOGBKFOM()
	{
		this.OAGEKPOGAJK(true);
	}

	// Token: 0x06002F8F RID: 12175 RVA: 0x00159B76 File Offset: 0x00157D76
	private void JOIPHILFGGI()
	{
		this.DOIONOCKOLD(true);
	}

	// Token: 0x06002F90 RID: 12176 RVA: 0x00159B7F File Offset: 0x00157D7F
	private void OnMouseExit()
	{
		this.DFMGCLDOKIG = false;
	}

	// Token: 0x06002F91 RID: 12177 RVA: 0x00159B88 File Offset: 0x00157D88
	public void GMABAHMMJIN(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					material.EnableKeyword("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					material.SetColor(this.isU5StandartShader ? "[WH Detector Service]" : "WRINKLE_MAPS", value);
				}
			}
		}
	}

	// Token: 0x06002F92 RID: 12178 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool NEGNIFCNBIH()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F93 RID: 12179 RVA: 0x00159C38 File Offset: 0x00157E38
	private void LLAFCADFAGM()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.GEGGIKIIMKM(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1230f)
		{
			this.OOPIINIEJHG(false);
		}
		if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 0)
		{
			this.GMABAHMMJIN(true);
		}
	}

	// Token: 0x06002F94 RID: 12180 RVA: 0x00159CAC File Offset: 0x00157EAC
	private void DCHAPIHINBJ()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().NKJEEHEODBF())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.KNGNAOFNIID())
		{
			string text = JNBICAJIJMM.APMJBBDBOJO().JDBGNILGMDO("\n", "0" + this.obj_type);
			text = this.iName;
			if (text.Trim() != " ")
			{
				float num = Input.mousePosition.x + 696f;
				float num2 = Input.mousePosition.y - 1475f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -105,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(195f, 582f, 1901f, 1762f)
					},
					alignment = TextAnchor.MiddleRight
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "inv_auksum" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 359f, num2 - 1878f, x + 1826f, 342f);
				HFIINBICCLO.OOIJFNAMEDP().JDOKDJDLPBL(rect, new Color(770f, 645f, 1044f, 440f));
				HFIINBICCLO.KPGHCNPGAGL().MFLCFMEONPN(rect, new Color(1350f, 841f, 707f, 597f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F95 RID: 12181 RVA: 0x00159E30 File Offset: 0x00158030
	private void CGBKGPPNMNM()
	{
		if (JDCEFOFMGHB.HMJJPNDEKPP().BHBCONNDEBA())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.EOOHJKNOMBH())
		{
			string text = JNBICAJIJMM.EEOPOHEALPK().OMNMDGIGEFD("WallRunLeft", "Failed parsing atlas rect.  Using default." + this.obj_type);
			text = this.iName;
			if (text.Trim() != "Zombie Idle 2")
			{
				float num = Input.mousePosition.x + 229f;
				float num2 = Input.mousePosition.y - 1515f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -91,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(753f, 838f, 467f, 903f)
					},
					alignment = TextAnchor.MiddleLeft
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "wtype" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 1954f, num2 - 683f, x + 451f, 777f);
				HFIINBICCLO.BPCNCENHEAG().GGFPGBKPJCN(rect, new Color(32f, 1077f, 752f, 1504f));
				HFIINBICCLO.BPCNCENHEAG().PGPCLEFKLAD(rect, new Color(542f, 663f, 1995f, 1800f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F96 RID: 12182 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool LHOPJCDLMIK()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002F97 RID: 12183 RVA: 0x00159FB4 File Offset: 0x001581B4
	private void OHBANDJGNCH()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.EHNGNBPCDMB(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1383f)
		{
			this.OEBKEEMGFCE(false);
		}
		if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 1)
		{
			this.HPFNOLEHCBH(false);
		}
	}

	// Token: 0x06002F98 RID: 12184 RVA: 0x0015A028 File Offset: 0x00158228
	public void HGBFMJOPAMF()
	{
		Debug.Log("btn_cancel");
		this.DOIONOCKOLD(true);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.NLOGJHEFMHM().JKGCGMKDAHH(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.JHJHHBLGMPJ(this.ActivateSound[num], base.transform.position, 402f, 1529f, 1090f, 1130f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "Loot")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ((long)this.addId);
				epmphjgalbe.OBJBHBFAFEE(1L);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-22, epmphjgalbe.LAFILAEOPAJ());
				return;
			}
			finally
			{
				epmphjgalbe.KNPHNLLMJKJ();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.KPCGLGHDILI(this.addId);
				epmphjgalbe2.FINMMGHAHFI(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-48, epmphjgalbe2.NNEAJJNCGMK());
				return;
			}
			finally
			{
				epmphjgalbe2.PMIGGJHLIDO();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 1;
				}
				epmphjgalbe3.KPCGLGHDILI(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(57, epmphjgalbe3.JOCJNOBBELJ());
				return;
			}
			finally
			{
				epmphjgalbe3.PGLFHABMJPO();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(118, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(140, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("?" + this.addInfo).MFHCGLHGAID();
		if (list.Count != 0)
		{
			LocBaseManager.NPCAKEGNBHD().toGlobalMap = list[0];
			LocBaseManager.EDKKJNHDBPF().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.NPCAKEGNBHD().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.DEHJNGMHGAJ(iibeekcaahk.KMIOLLENCOL());
					epmphjgalbe4.KPCGLGHDILI(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.JDOLCNDNFGP(iibeekcaahk.NFCDJLJNDLO());
				}
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-185, epmphjgalbe4.LAFILAEOPAJ());
			}
			finally
			{
				epmphjgalbe4.PGLFHABMJPO();
			}
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.LHLOOIDHGMA(iibeekcaahk2.KMIOLLENCOL());
			epmphjgalbe5.ALNEALEKFNB(iibeekcaahk2.NLHKFMMDMMK());
			epmphjgalbe5.EIMEKHOFIEA(iibeekcaahk2.CJKILDPJCFJ());
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-186, epmphjgalbe5.NNEAJJNCGMK());
			return;
		}
		finally
		{
			epmphjgalbe5.NCKMEIBFNGL();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("---", 1590f);
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(23, 0);
		return;
		IL_30B:
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.ENDMKPCFKND(0);
			epmphjgalbe6.JDOLCNDNFGP(this.addId);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-73, epmphjgalbe6.JDPHBLHOLAD());
			return;
		}
		finally
		{
			epmphjgalbe6.NCKMEIBFNGL();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(85, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		return;
		IL_3BC:
		JDCEFOFMGHB.IKGFHGKKCPG.POIPOBBIDPM("_BlurVector", "__a");
	}

	// Token: 0x06002F99 RID: 12185 RVA: 0x0015A460 File Offset: 0x00158660
	private void HDGNIHBIEDG()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			foreach (Renderer renderer in array)
			{
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("IdleFly");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty(""))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("Poplavok");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("IceHockeyPassLeft"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002F9A RID: 12186 RVA: 0x0015A52C File Offset: 0x0015872C
	public void DKFDNICGEOH()
	{
		Debug.Log(" ");
		this.DOIONOCKOLD(false);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.ODDOIHEPICE().MMKBEPHGHID(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.HKKKCIAJPAC(this.ActivateSound[num], base.transform.position, 420f, 876f, 1930f, 1647f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "{0}Textures/Shop/{1}.png")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.MFPECHIKBCO((long)this.addId);
				epmphjgalbe.PMJPIJMHELL(1L);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(0, epmphjgalbe.ALLANCHILCM());
				return;
			}
			finally
			{
				epmphjgalbe.OGPGOEJFIBO();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.EIMEKHOFIEA(this.addId);
				epmphjgalbe2.FINMMGHAHFI(this.addInfo);
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(128, epmphjgalbe2.HDEKHFOKCKI());
				return;
			}
			finally
			{
				epmphjgalbe2.HDKBMLOJLLC();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 2;
				}
				epmphjgalbe3.JDOLCNDNFGP(num2);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-174, epmphjgalbe3.NNEAJJNCGMK());
				return;
			}
			finally
			{
				epmphjgalbe3.PMIGGJHLIDO();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(9, this.addId);
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(108, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("clavicle" + this.addInfo).BNAMDHOMEHH();
		if (list.Count != 0)
		{
			LocBaseManager.EDKKJNHDBPF().toGlobalMap = list[0];
			LocBaseManager.NPIEJELJPIM().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.EDKKJNHDBPF().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.FLLJONHPLNA(iibeekcaahk.NKEOCCKEOCE());
					epmphjgalbe4.GOMLLPFFPNP(iibeekcaahk.NLHKFMMDMMK());
					epmphjgalbe4.LHLOOIDHGMA(iibeekcaahk.CJKILDPJCFJ());
				}
				NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(183, epmphjgalbe4.IEJLLFECFHF());
			}
			finally
			{
				epmphjgalbe4.KNPHNLLMJKJ();
			}
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.EIMEKHOFIEA(iibeekcaahk2.KEHIFGILLJA());
			epmphjgalbe5.LHLOOIDHGMA(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.GOMLLPFFPNP(iibeekcaahk2.NODLBGKEGPM);
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-185, epmphjgalbe5.NNEAJJNCGMK());
			return;
		}
		finally
		{
			epmphjgalbe5.LMBPNFHKNGA();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("VA", 712f);
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(24, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.GOMLLPFFPNP(1);
			epmphjgalbe6.PDEFLCIEMFF(this.addId);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(115, epmphjgalbe6.IEJLLFECFHF());
			return;
		}
		finally
		{
			epmphjgalbe6.KNPHNLLMJKJ();
		}
		IL_355:
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-146, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
		return;
		IL_3BC:
		JDCEFOFMGHB.JFIDAGABKID().KGHDLHHLLIC("1HSwordStrafeRunLeft", "");
	}

	// Token: 0x06002F9B RID: 12187 RVA: 0x0015A964 File Offset: 0x00158B64
	public void JPGGOACIOGC(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 1; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					material.EnableKeyword("");
					material.SetColor(this.isU5StandartShader ? "RollerBladeRoll" : "ScatterDitherMap", value);
				}
			}
		}
	}

	// Token: 0x06002F9C RID: 12188 RVA: 0x0015AA14 File Offset: 0x00158C14
	private void OKMEMBNGKHJ()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.EHNGNBPCDMB(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1451f)
		{
			this.JPGGOACIOGC(true);
		}
		if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 1)
		{
			this.HPFNOLEHCBH(false);
		}
	}

	// Token: 0x06002F9D RID: 12189 RVA: 0x0015AA88 File Offset: 0x00158C88
	private void CEOGCNEJMJF()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.GEGGIKIIMKM(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1912f)
		{
			this.OAGEKPOGAJK(false);
		}
		if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 1)
		{
			this.EHNGNBPCDMB(true);
		}
	}

	// Token: 0x06002F9E RID: 12190 RVA: 0x0015AAFC File Offset: 0x00158CFC
	private void AEFGOFJAKDO()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().BHBCONNDEBA())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.MFBLNNFIGBE())
		{
			string text = JNBICAJIJMM.CLIMNFDGOEG().DBPANLKEHMN("wpn_dress1", "crft_cnt" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "UpHillWalkHandGrab")
			{
				float num = Input.mousePosition.x + 1233f;
				float num2 = Input.mousePosition.y - 912f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = 4,
					wordWrap = false,
					normal = 
					{
						textColor = new Color(1764f, 377f, 1566f, 736f)
					},
					alignment = TextAnchor.LowerCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "ScatterDitherData" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 310f, num2 - 516f, x + 1026f, 1284f);
				HFIINBICCLO.GDDAGIILGGM().GGFPGBKPJCN(rect, new Color(1031f, 1171f, 298f, 1068f));
				HFIINBICCLO.BPCNCENHEAG().NBHJGLHKBMA(rect, new Color(1156f, 173f, 824f, 1689f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002F9F RID: 12191 RVA: 0x0015AC7D File Offset: 0x00158E7D
	private void CPFHFNPLJJC()
	{
		this.JPGGOACIOGC(true);
	}

	// Token: 0x06002FA0 RID: 12192 RVA: 0x0015AC88 File Offset: 0x00158E88
	public void ENBMFIHLBPJ(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				foreach (Material material in renderer.materials)
				{
					material.EnableKeyword("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
					material.SetColor(this.isU5StandartShader ? "_NAME" : "ragulaFider", value);
				}
			}
		}
	}

	// Token: 0x06002FA1 RID: 12193 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool OJMCGNCOBEE()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002FA2 RID: 12194 RVA: 0x0015AD38 File Offset: 0x00158F38
	private void GKEFNBPOEPJ()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().GGCLOKODHEG())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.ABINCPLGKJB())
		{
			string text = JNBICAJIJMM.EDKGBBIIBBC().IPHGEPDFCJL("wpn_add/base", "Failed parsing rotationPlacement.  Setting to \"Fixed\"" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "VA")
			{
				float num = Input.mousePosition.x + 1909f;
				float num2 = Input.mousePosition.y - 684f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -60,
					wordWrap = false,
					normal = 
					{
						textColor = new Color(1242f, 455f, 1704f, 579f)
					},
					alignment = TextAnchor.LowerCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "<color='#300000'>{0} {1}</color>" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 1281f, num2 - 1871f, x + 457f, 196f);
				HFIINBICCLO.JFNBEACKGKI().EGLEDCACFNP(rect, new Color(448f, 1455f, 1759f, 244f));
				HFIINBICCLO.JFNBEACKGKI().MFLCFMEONPN(rect, new Color(1877f, 367f, 1609f, 1155f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002FA3 RID: 12195 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool ABINCPLGKJB()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002FA4 RID: 12196 RVA: 0x0015AEBC File Offset: 0x001590BC
	private void ADLHNBEDHMJ()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("{not_found}");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("/StreamingAssets/"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("<color='#ff8000'>- </color>");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("_FinalReflectionTexture"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FA5 RID: 12197 RVA: 0x0015AF88 File Offset: 0x00159188
	public void JCGFEPOOOFH()
	{
		Debug.Log("______________________________");
		this.OEBKEEMGFCE(true);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.ODDOIHEPICE().GHCBFLEDNFE(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.HFGAHFGKFKL(this.ActivateSound[num], base.transform.position, 640f, 723f, 831f, 1254f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "id")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.PMJPIJMHELL((long)this.addId);
				epmphjgalbe.OACBICLGENB(0L);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(95, epmphjgalbe.NNEAJJNCGMK());
				return;
			}
			finally
			{
				epmphjgalbe.NCKMEIBFNGL();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.GOMLLPFFPNP(this.addId);
				epmphjgalbe2.LKNDBBGMIOE(this.addInfo);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(103, epmphjgalbe2.JDPHBLHOLAD());
				return;
			}
			finally
			{
				epmphjgalbe2.LMBPNFHKNGA();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 2;
				}
				epmphjgalbe3.ENDMKPCFKND(num2);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-166, epmphjgalbe3.IEJLLFECFHF());
				return;
			}
			finally
			{
				epmphjgalbe3.LMBPNFHKNGA();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-182, this.addId);
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(128, this.addId);
			JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("ObscuredVector3:" + this.addInfo).DOOOBNOPPPN();
		if (list.Count != 0)
		{
			LocBaseManager.AIHINNHNNIA().toGlobalMap = list[1];
			LocBaseManager.NPIEJELJPIM().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.AIHINNHNNIA().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.EIMEKHOFIEA(iibeekcaahk.KEHIFGILLJA());
					epmphjgalbe4.ENDMKPCFKND(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.ALNEALEKFNB(iibeekcaahk.NODLBGKEGPM);
				}
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-136, epmphjgalbe4.ALLANCHILCM());
			}
			finally
			{
				epmphjgalbe4.OGPGOEJFIBO();
			}
			JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.DEHJNGMHGAJ(iibeekcaahk2.KMIOLLENCOL());
			epmphjgalbe5.JIIKLOKAGIC(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.JDOLCNDNFGP(iibeekcaahk2.CJKILDPJCFJ());
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-6, epmphjgalbe5.JOCJNOBBELJ());
			return;
		}
		finally
		{
			epmphjgalbe5.NCKMEIBFNGL();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("_RgbTex", 1969f);
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(63, 0);
		return;
		IL_30B:
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.JDOLCNDNFGP(0);
			epmphjgalbe6.ALNEALEKFNB(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-99, epmphjgalbe6.NNEAJJNCGMK());
			return;
		}
		finally
		{
			epmphjgalbe6.OGPGOEJFIBO();
		}
		IL_355:
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-39, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		return;
		IL_3BC:
		JDCEFOFMGHB.HMJJPNDEKPP().BEIDJANKEFD("PistolLeftHandStab", "Apply out GAME 1");
	}

	// Token: 0x06002FA6 RID: 12198 RVA: 0x0015B3C0 File Offset: 0x001595C0
	private void AMHKALBBLMP()
	{
		this.GMABAHMMJIN(true);
	}

	// Token: 0x06002FA7 RID: 12199 RVA: 0x0015B3CC File Offset: 0x001595CC
	private void MEGDDMDGDGI()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.DOIONOCKOLD(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1057f)
		{
			this.ENKKMHCGMLP(false);
		}
		if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 0)
		{
			this.ENKKMHCGMLP(false);
		}
	}

	// Token: 0x06002FA8 RID: 12200 RVA: 0x0015B440 File Offset: 0x00159640
	private void GKCCLKOIONL()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.ENBMFIHLBPJ(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1416f)
		{
			this.OOPIINIEJHG(true);
		}
		if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 0)
		{
			this.DFMGCLDOKIG = true;
		}
	}

	// Token: 0x06002FA9 RID: 12201 RVA: 0x0015B4B4 File Offset: 0x001596B4
	private void EEJAAPBJHOO()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.NEGNIFCNBIH())
		{
			string text = JNBICAJIJMM.DBMJJPBOPEK().JDBGNILGMDO("crunch.ogg", "signal_enable" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "OfficeSitting")
			{
				float num = Input.mousePosition.x + 180f;
				float num2 = Input.mousePosition.y - 481f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -116,
					wordWrap = true,
					normal = 
					{
						textColor = new Color(1233f, 192f, 1556f, 1419f)
					},
					alignment = TextAnchor.LowerCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "Front Kick" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 867f, num2 - 325f, x + 1268f, 1692f);
				HFIINBICCLO.GDDAGIILGGM().JDOKDJDLPBL(rect, new Color(414f, 135f, 870f, 1138f));
				HFIINBICCLO.GICMOPPKLPC().EPJMCADLJEH(rect, new Color(1128f, 700f, 1268f, 1580f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002FAA RID: 12202 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool KNGNAOFNIID()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002FAB RID: 12203 RVA: 0x0015B638 File Offset: 0x00159838
	private void MBADKFPCOEJ()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.AMGIJECABAD())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.NEGNIFCNBIH())
		{
			string text = JNBICAJIJMM.APMJBBDBOJO().JDBGNILGMDO("id", "+ACVolumeProxy" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "_DelItem.wav")
			{
				float num = Input.mousePosition.x + 1221f;
				float num2 = Input.mousePosition.y - 797f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = -101,
					wordWrap = false,
					normal = 
					{
						textColor = new Color(1711f, 1461f, 273f, 340f)
					},
					alignment = TextAnchor.LowerCenter
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "Idle Die 2" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 601f, num2 - 1837f, x + 213f, 273f);
				HFIINBICCLO.BPCNCENHEAG().GCALFLOEPKI(rect, new Color(1097f, 289f, 788f, 1467f));
				HFIINBICCLO.LLEDCIHMOHI().NBHJGLHKBMA(rect, new Color(720f, 110f, 386f, 1055f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002FAC RID: 12204 RVA: 0x0015B7BC File Offset: 0x001599BC
	private void OLCKJEJAKLD()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.DOIONOCKOLD(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 535f)
		{
			this.ENBMFIHLBPJ(false);
		}
		if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 0)
		{
			this.EHNGNBPCDMB(false);
		}
	}

	// Token: 0x06002FAD RID: 12205 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool AECIDPAHIDG()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002FAE RID: 12206 RVA: 0x0015B830 File Offset: 0x00159A30
	private void ECGEBBKAILH()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.OOPIINIEJHG(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 885f)
		{
			this.DFMGCLDOKIG = false;
		}
		if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 1)
		{
			this.HPFNOLEHCBH(true);
		}
	}

	// Token: 0x06002FAF RID: 12207 RVA: 0x0015B8A4 File Offset: 0x00159AA4
	private void GGBMJFNGHMC()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("glava");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("WoodCut"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("post_12");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("!"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FB0 RID: 12208 RVA: 0x0015B970 File Offset: 0x00159B70
	private void KBEOAOKBHEK()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().GGCLOKODHEG())
		{
			return;
		}
		if (!this.isShowInfo)
		{
			return;
		}
		if (this.MFBLNNFIGBE())
		{
			string text = JNBICAJIJMM.LPHMKPDBMPP().JDBGNILGMDO("Katana", "L" + this.obj_type);
			text = this.iName;
			if (text.Trim() != "Hyperlink_")
			{
				float num = Input.mousePosition.x + 934f;
				float num2 = Input.mousePosition.y - 1001f;
				num2 = (float)Screen.height - num2;
				GUIStyle guistyle = new GUIStyle
				{
					fontSize = 42,
					wordWrap = false,
					normal = 
					{
						textColor = new Color(1766f, 938f, 1526f, 1880f)
					},
					alignment = TextAnchor.MiddleLeft
				};
				string text2 = text;
				if (Application.isEditor)
				{
					text2 = text + "camouflage_scale" + this.addInfo;
				}
				float x = guistyle.CalcSize(new GUIContent(text2)).x;
				Rect rect = new Rect(num - 188f, num2 - 1876f, x + 222f, 111f);
				HFIINBICCLO.DPBNHMCDIIK().EGLEDCACFNP(rect, new Color(1101f, 1278f, 523f, 1166f));
				HFIINBICCLO.LLEDCIHMOHI().EPJMCADLJEH(rect, new Color(60f, 1768f, 177f, 1837f));
				GUI.Label(rect, text2, guistyle);
			}
		}
	}

	// Token: 0x06002FB1 RID: 12209 RVA: 0x00159B76 File Offset: 0x00157D76
	private void PDCOIIIDECD()
	{
		this.DOIONOCKOLD(true);
	}

	// Token: 0x06002FB2 RID: 12210 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool EOOHJKNOMBH()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002FB3 RID: 12211 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool KHPEMCEMHKC()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x0015BAF4 File Offset: 0x00159CF4
	public void processAction()
	{
		Debug.Log("process Action");
		this.DFMGCLDOKIG = false;
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.IKGFHGKKCPG.MKOPHEAGIGE(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.AKDOFKCANPE(this.ActivateSound[num], base.transform.position, 0.4f, 3f, 50f, 1f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "Actor")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ((long)this.addId);
				epmphjgalbe.OBCCLNMPGEJ(0L);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(60, epmphjgalbe.JDPHBLHOLAD());
				return;
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.GOMLLPFFPNP(this.addId);
				epmphjgalbe2.NEHCMOODKIN(this.addInfo);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1309, epmphjgalbe2.JDPHBLHOLAD());
				return;
			}
			finally
			{
				epmphjgalbe2.LMBPNFHKNGA();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 4;
				}
				epmphjgalbe3.GOMLLPFFPNP(num2);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1701, epmphjgalbe3.JDPHBLHOLAD());
				return;
			}
			finally
			{
				epmphjgalbe3.LMBPNFHKNGA();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(166, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1230, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("aa=" + this.addInfo).HDELBIDJNOK;
		if (list.Count != 0)
		{
			LocBaseManager.IKGFHGKKCPG.toGlobalMap = list[0];
			LocBaseManager.IKGFHGKKCPG.reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.IKGFHGKKCPG.reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.GOMLLPFFPNP(iibeekcaahk.IBEIBAHKIAH);
					epmphjgalbe4.GOMLLPFFPNP(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.GOMLLPFFPNP(iibeekcaahk.NODLBGKEGPM);
				}
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(134, epmphjgalbe4.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe4.LMBPNFHKNGA();
			}
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.GOMLLPFFPNP(iibeekcaahk2.IBEIBAHKIAH);
			epmphjgalbe5.GOMLLPFFPNP(iibeekcaahk2.ICJDPPOJINN);
			epmphjgalbe5.GOMLLPFFPNP(iibeekcaahk2.NODLBGKEGPM);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(138, epmphjgalbe5.JDPHBLHOLAD());
			return;
		}
		finally
		{
			epmphjgalbe5.LMBPNFHKNGA();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_rcOut.ogg", 0.3f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1600, 0);
		return;
		IL_30B:
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.GOMLLPFFPNP(0);
			epmphjgalbe6.GOMLLPFFPNP(this.addId);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1700, epmphjgalbe6.JDPHBLHOLAD());
			return;
		}
		finally
		{
			epmphjgalbe6.LMBPNFHKNGA();
		}
		IL_355:
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(700, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		return;
		IL_3BC:
		JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Ошибка", "Не реализовано");
	}

	// Token: 0x06002FB5 RID: 12213 RVA: 0x0015BF2C File Offset: 0x0015A12C
	private void DMAOHJDKMNN()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			foreach (Renderer renderer in array)
			{
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("_EmissionColor");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("pb_Object: "))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("Hidden/DepthOfField/BokehSplatting");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("Quadruped"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FB6 RID: 12214 RVA: 0x0015BFF8 File Offset: 0x0015A1F8
	private void IIKDDILLGLF()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			foreach (Renderer renderer in array)
			{
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("_RgbTex");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("_FogColor2"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("Swim Dog Paddle");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("17"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x0015C0C4 File Offset: 0x0015A2C4
	private void Start()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			foreach (Renderer renderer in array)
			{
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("_EMISSION");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("_SelectColor"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("_EMISSION");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("_SelectColor"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FB8 RID: 12216 RVA: 0x0015C190 File Offset: 0x0015A390
	private void JJGIJFMPADG()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.GMABAHMMJIN(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 1258f)
		{
			this.EHNGNBPCDMB(true);
		}
		if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 1)
		{
			this.HPFNOLEHCBH(false);
		}
	}

	// Token: 0x06002FB9 RID: 12217 RVA: 0x0015C204 File Offset: 0x0015A404
	public void NJIPHFPOFKI()
	{
		Debug.Log("_FullResolutionFiltering");
		this.ENKKMHCGMLP(true);
		if (this.ActivateSound.Length != 0)
		{
			int num = OLPINJLCKCI.OBDBAABBAKB().EFGDDAPIKBH(this.ActivateSound.Length);
			FBFJFAKAGJG.IKGFHGKKCPG.JHJHHBLGMPJ(this.ActivateSound[num], base.transform.position, 309f, 1558f, 1207f, 1031f);
		}
		switch (this.obj_type)
		{
		case ActiveObject.GDOLOFKJDEE.NPC:
		{
			if (base.gameObject.tag == "_camScale")
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OACBICLGENB((long)this.addId);
				epmphjgalbe.AAHBHCMKGJD(1L);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-14, epmphjgalbe.ALLANCHILCM());
				return;
			}
			finally
			{
				epmphjgalbe.NCKMEIBFNGL();
			}
			break;
		}
		case ActiveObject.GDOLOFKJDEE.TravelMap:
			break;
		case ActiveObject.GDOLOFKJDEE.Shop:
		{
			JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.JIIKLOKAGIC(this.addId);
				epmphjgalbe2.HBJIMCCCNJP(this.addInfo);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(65, epmphjgalbe2.HDEKHFOKCKI());
				return;
			}
			finally
			{
				epmphjgalbe2.BKKEFKANGIM();
			}
			goto IL_238;
		}
		case ActiveObject.GDOLOFKJDEE.Board:
			goto IL_355;
		case ActiveObject.GDOLOFKJDEE.Craft:
		{
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				int num2 = this.addId;
				if (num2 == 0)
				{
					num2 = 3;
				}
				epmphjgalbe3.ENDMKPCFKND(num2);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(23, epmphjgalbe3.ALLANCHILCM());
				return;
			}
			finally
			{
				epmphjgalbe3.LMBPNFHKNGA();
			}
			goto IL_30B;
		}
		case ActiveObject.GDOLOFKJDEE.Transport:
		case ActiveObject.GDOLOFKJDEE.ActiveObject:
		case ActiveObject.GDOLOFKJDEE.Biolab:
			goto IL_3BC;
		case ActiveObject.GDOLOFKJDEE.Post:
			goto IL_299;
		case ActiveObject.GDOLOFKJDEE.Holod:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-128, this.addId);
			JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
			return;
		case ActiveObject.GDOLOFKJDEE.Door:
			goto IL_238;
		case ActiveObject.GDOLOFKJDEE.Sklad:
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-131, this.addId);
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			return;
		case ActiveObject.GDOLOFKJDEE.FishCraft:
			goto IL_30B;
		default:
			goto IL_3BC;
		}
		List<IIBEEKCAAHK> list = new BNOOIOKIFJC.DIGGOHPGCNN("wpn_add/base" + this.addInfo).DOOOBNOPPPN();
		if (list.Count != 0)
		{
			LocBaseManager.GJACINHCABC().toGlobalMap = list[1];
			LocBaseManager.NPCAKEGNBHD().reservPosition = Fisherman.getI.transform.position;
			LocBaseManager.EDKKJNHDBPF().reservRotation = Fisherman.getI.transform.rotation;
			EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
			try
			{
				foreach (IIBEEKCAAHK iibeekcaahk in list)
				{
					epmphjgalbe4.LHLOOIDHGMA(iibeekcaahk.KEHIFGILLJA());
					epmphjgalbe4.LHLOOIDHGMA(iibeekcaahk.ICJDPPOJINN);
					epmphjgalbe4.JIIKLOKAGIC(iibeekcaahk.NODLBGKEGPM);
				}
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-122, epmphjgalbe4.NNEAJJNCGMK());
			}
			finally
			{
				epmphjgalbe4.PMIGGJHLIDO();
			}
			JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
			return;
		}
		return;
		IL_238:
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.addInfo);
		EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe5.EAOGDKDBENC(iibeekcaahk2.NKEOCCKEOCE());
			epmphjgalbe5.PDEFLCIEMFF(iibeekcaahk2.KMGAHCANELI());
			epmphjgalbe5.PDEFLCIEMFF(iibeekcaahk2.NFCDJLJNDLO());
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(100, epmphjgalbe5.JDPHBLHOLAD());
			return;
		}
		finally
		{
			epmphjgalbe5.BKKEFKANGIM();
		}
		IL_299:
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("offsets", 764f);
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(195, 1);
		return;
		IL_30B:
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		EPMPHJGALBE epmphjgalbe6 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe6.EIMEKHOFIEA(0);
			epmphjgalbe6.JIIKLOKAGIC(this.addId);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-100, epmphjgalbe6.HDEKHFOKCKI());
			return;
		}
		finally
		{
			epmphjgalbe6.NCKMEIBFNGL();
		}
		IL_355:
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-114, EJDGMNEEOGN.IKGFHGKKCPG.MLJGKAOMLEL);
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		return;
		IL_3BC:
		JDCEFOFMGHB.IKGFHGKKCPG.POIPOBBIDPM("crft_crft", "repair.ogg");
	}

	// Token: 0x06002FBA RID: 12218 RVA: 0x00157964 File Offset: 0x00155B64
	private void JODINGLBEJF()
	{
		this.GEGGIKIIMKM(true);
	}

	// Token: 0x06002FBB RID: 12219 RVA: 0x00155B55 File Offset: 0x00153D55
	private void JNIGNJECAGA()
	{
		this.HPFNOLEHCBH(false);
	}

	// Token: 0x06002FBC RID: 12220 RVA: 0x0015C63C File Offset: 0x0015A83C
	private void CJNBMPCNKHP()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("RollerBladeTurnRight");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("StartPhysPoint"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("wpn_rec4");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("MotorbikeIdle"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FBD RID: 12221 RVA: 0x0015C708 File Offset: 0x0015A908
	public void GEGGIKIIMKM(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 0; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					material.EnableKeyword("-S");
					material.SetColor(this.isU5StandartShader ? "RangeMarker" : "", value);
				}
			}
		}
	}

	// Token: 0x06002FBE RID: 12222 RVA: 0x0015C7B8 File Offset: 0x0015A9B8
	private void DJGGEMHMANP()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.GMABAHMMJIN(true);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 503f)
		{
			this.ENKKMHCGMLP(true);
		}
		if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count > 1)
		{
			this.ENKKMHCGMLP(true);
		}
	}

	// Token: 0x06002FBF RID: 12223 RVA: 0x0015C82C File Offset: 0x0015AA2C
	private void HFMLAKIJNIJ()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.JPGGOACIOGC(false);
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 124f)
		{
			this.ENKKMHCGMLP(false);
		}
		if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 1)
		{
			this.OAGEKPOGAJK(true);
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x00155C10 File Offset: 0x00153E10
	// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x0015C8A0 File Offset: 0x0015AAA0
	public bool DFMGCLDOKIG
	{
		get
		{
			return this.BKKIAHOIBFE;
		}
		set
		{
			this.BKKIAHOIBFE = value;
			if (this.isShowInfo)
			{
				Color value2 = this.BKKIAHOIBFE ? this.selectColor : Color.black;
				foreach (Renderer renderer in this.objectRenderer)
				{
					foreach (Material material in renderer.materials)
					{
						material.EnableKeyword("_EMISSION");
						material.SetColor(this.isU5StandartShader ? "_EmissionColor" : "_SelectColor", value2);
					}
				}
			}
		}
	}

	// Token: 0x06002FC1 RID: 12225 RVA: 0x0015C950 File Offset: 0x0015AB50
	private void CAJLCEPLKJG()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i++)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword(" %\n");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("</color>"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("OfficeSittingLegCross");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("isRealView"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FC2 RID: 12226 RVA: 0x0015CA1C File Offset: 0x0015AC1C
	private void OnMouseEnter()
	{
		if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
		{
			this.DFMGCLDOKIG = false;
			return;
		}
		if (Vector3.Distance(Camera.main.transform.position, base.transform.position) < 10f)
		{
			this.DFMGCLDOKIG = true;
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1)
		{
			this.DFMGCLDOKIG = false;
		}
	}

	// Token: 0x06002FC4 RID: 12228 RVA: 0x0015CA90 File Offset: 0x0015AC90
	private void DGEIACONKCJ()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 0; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("GetMouseButtonUp reboot");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("26"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("Katana Upper Block");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("showUsersInChat"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x06002FC5 RID: 12229 RVA: 0x00155C10 File Offset: 0x00153E10
	public bool PENBJPBKNJJ()
	{
		return this.BKKIAHOIBFE;
	}

	// Token: 0x06002FC6 RID: 12230 RVA: 0x0015CB5C File Offset: 0x0015AD5C
	public void OEBKEEMGFCE(bool DCCPCBLODIG)
	{
		this.BKKIAHOIBFE = DCCPCBLODIG;
		if (this.isShowInfo)
		{
			Color value = this.BKKIAHOIBFE ? this.selectColor : Color.black;
			foreach (Renderer renderer in this.objectRenderer)
			{
				Material[] materials = renderer.materials;
				for (int i = 0; i < materials.Length; i += 0)
				{
					Material material = materials[i];
					material.EnableKeyword("[F_KLEV]");
					material.SetColor(this.isU5StandartShader ? "OneHandSwordBackSwing" : "Speed", value);
				}
			}
		}
	}

	// Token: 0x06002FC7 RID: 12231 RVA: 0x0015CC0C File Offset: 0x0015AE0C
	private void HDFCIACDDEK()
	{
		if (this.harvestRenderers)
		{
			Renderer[] array = base.GetComponentsInChildren<MeshRenderer>();
			array = array;
			for (int i = 1; i < array.Length; i += 0)
			{
				Renderer renderer = array[i];
				if (this.isU5StandartShader)
				{
					renderer.material.EnableKeyword("1=");
					this.objectRenderer.Add(renderer);
				}
				else if (renderer.material.HasProperty("_InvGamma"))
				{
					this.objectRenderer.Add(renderer);
				}
			}
			Renderer component = base.GetComponent<MeshRenderer>();
			if (component != null)
			{
				if (this.isU5StandartShader)
				{
					component.material.EnableKeyword("MovementZ");
					this.objectRenderer.Add(component);
					return;
				}
				if (component.material.HasProperty("sunshine_ShadowCoordDepthRayV"))
				{
					this.objectRenderer.Add(component);
				}
			}
		}
	}

	// Token: 0x0400066E RID: 1646
	public bool isShowInfo = true;

	// Token: 0x0400066F RID: 1647
	public string iName;

	// Token: 0x04000670 RID: 1648
	public ActiveObject.GDOLOFKJDEE obj_type;

	// Token: 0x04000671 RID: 1649
	public int addId;

	// Token: 0x04000672 RID: 1650
	public string addInfo;

	// Token: 0x04000673 RID: 1651
	public bool isU5StandartShader;

	// Token: 0x04000674 RID: 1652
	public bool harvestRenderers = true;

	// Token: 0x04000675 RID: 1653
	public List<Renderer> objectRenderer = new List<Renderer>();

	// Token: 0x04000676 RID: 1654
	public Color selectColor;

	// Token: 0x04000677 RID: 1655
	public AudioClip[] ActivateSound;

	// Token: 0x04000678 RID: 1656
	public float volume = 1f;

	// Token: 0x04000679 RID: 1657
	private bool BKKIAHOIBFE;

	// Token: 0x0400067A RID: 1658
	private const float ENIHNBCKJOF = 10f;

	// Token: 0x0400067B RID: 1659
	public float dsta = 2.5f;

	// Token: 0x020000FE RID: 254
	public enum GDOLOFKJDEE
	{
		// Token: 0x0400067D RID: 1661
		NPC,
		// Token: 0x0400067E RID: 1662
		TravelMap,
		// Token: 0x0400067F RID: 1663
		Shop,
		// Token: 0x04000680 RID: 1664
		Board,
		// Token: 0x04000681 RID: 1665
		Craft,
		// Token: 0x04000682 RID: 1666
		Transport,
		// Token: 0x04000683 RID: 1667
		Post,
		// Token: 0x04000684 RID: 1668
		Holod,
		// Token: 0x04000685 RID: 1669
		Door,
		// Token: 0x04000686 RID: 1670
		ActiveObject,
		// Token: 0x04000687 RID: 1671
		Biolab,
		// Token: 0x04000688 RID: 1672
		Sklad,
		// Token: 0x04000689 RID: 1673
		FishCraft
	}
}
