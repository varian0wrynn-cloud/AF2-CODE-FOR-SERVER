using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000183 RID: 387
public class Sonar_Type1 : MonoBehaviour
{
	// Token: 0x060055C1 RID: 21953 RVA: 0x0027D1E4 File Offset: 0x0027B3E4
	private void LPCMEAOADLA()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK((double)this.GEEHILNIDFB.x, (double)this.GEEHILNIDFB.y, 0.0);
		PlayerPrefs.SetString("Sonar_pos", iibeekcaahk.ToString());
	}

	// Token: 0x060055C2 RID: 21954 RVA: 0x0027D228 File Offset: 0x0027B428
	private void FJEEADNCKAG()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA = ObscuredFloat.AJMPAOCEPCA(1182f);
		}
		this.KMILDAFOCFE = Mathf.Lerp(this.KMILDAFOCFE, ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA), Time.deltaTime);
		this.GKHENHJALBB += Time.deltaTime * this.KEJNDCKJNPI;
		Rect rect = default(Rect);
		if (this.OnOffKeyEnable)
		{
			rect = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 3));
		}
		Rect rect2 = new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width, (float)this.sonarPanel.height);
		Vector2 vector = Input.mousePosition;
		vector.y = (float)Screen.height - vector.y;
		if (rect2.Contains(vector))
		{
			bool flag = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1;
			JDCEFOFMGHB.HMJJPNDEKPP().FFMGKOIMOPE(true);
			if (!flag && Input.GetMouseButtonDown(0))
			{
				bool flag2 = true;
				if (this.OnOffKeyEnable && rect.Contains(vector))
				{
					flag2 = true;
				}
				if (this.isSelectMode)
				{
					for (int i = 0; i < this.deepSKey.Length; i += 0)
					{
						Rect rect3 = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
						if (rect3.Contains(vector))
						{
							flag2 = true;
						}
					}
				}
				if (this.IAJEMJILHIC)
				{
					flag2 = true;
				}
				if (!flag2)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("gi_uinf_3", 1090f);
					this.isDrag = false;
					this.JLANIFGJPBJ = new Vector2(vector.x - this.GEEHILNIDFB.x - 720f, vector.y - this.GEEHILNIDFB.y - 1989f);
				}
			}
		}
		if (this.isDrag)
		{
			this.GEEHILNIDFB.x = vector.x - this.JLANIFGJPBJ.x;
			this.GEEHILNIDFB.y = vector.y - this.JLANIFGJPBJ.y;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (this.isDrag)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("#000000", 896f);
			}
			this.isDrag = false;
			this.CJHLAHCDGAP();
		}
	}

	// Token: 0x060055C3 RID: 21955 RVA: 0x0027D504 File Offset: 0x0027B704
	private void OnEnable()
	{
		if (this.isSelectMode)
		{
			this.selectIndex = HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA;
			this.setSelectIndex(this.selectIndex);
		}
	}

	// Token: 0x060055C4 RID: 21956 RVA: 0x0027D52C File Offset: 0x0027B72C
	private void KNAFKLDECBJ(string DHMBNNPDPMO)
	{
		float x = this.GEEHILNIDFB.x + this.drawRect.x;
		float y = this.GEEHILNIDFB.y + this.drawRect.y;
		if (this.showDeepDigits)
		{
			GUIStyle style = new GUIStyle
			{
				normal = 
				{
					textColor = this.textColor
				},
				alignment = TextAnchor.UpperLeft,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			GUI.Label(new Rect(x, y, 100f, 20f), DHMBNNPDPMO, style);
		}
	}

	// Token: 0x060055C5 RID: 21957 RVA: 0x0027D5B7 File Offset: 0x0027B7B7
	private void LAHNGMMPPIM()
	{
		if (this.isSelectMode)
		{
			this.selectIndex = HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA;
			this.IJOEHAHCCFH(this.selectIndex);
		}
	}

	// Token: 0x060055C6 RID: 21958 RVA: 0x0027D5E0 File Offset: 0x0027B7E0
	public void setSelectIndex(int BOICDLILBDC)
	{
		if (!this.isSelectMode)
		{
			return;
		}
		this.selectIndex = BOICDLILBDC;
		HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA = this.selectIndex;
		this.maxDeep = this.deepS[BOICDLILBDC];
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
	}

	// Token: 0x060055C7 RID: 21959 RVA: 0x0027D630 File Offset: 0x0027B830
	private void EHFPLKEINFO()
	{
		this.KMILDAFOCFE = 1169f;
		this.BFMMIONNAJE = new int[this.rayCount];
		this.KEJNDCKJNPI = 1113f / (float)this.timeWait;
		base.InvokeRepeating("FishModel", (float)this.timeWait / 57f, (float)this.timeWait / 578f);
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("_SmallTex"));
		Vector2 geehilnidfb = new Vector2(iibeekcaahk.PHLLHDNNOMB(), iibeekcaahk.DOFNAOOCDDB());
		if (geehilnidfb.x <= 1835f || geehilnidfb.y <= 578f)
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.x > (float)(Screen.width - 123))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.y > (float)(Screen.height - -40))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		this.GEEHILNIDFB = geehilnidfb;
	}

	// Token: 0x060055C8 RID: 21960 RVA: 0x0027D70C File Offset: 0x0027B90C
	private void CGMHGDEKDEP()
	{
		this.KMILDAFOCFE = 432f;
		this.BFMMIONNAJE = new int[this.rayCount];
		this.KEJNDCKJNPI = 276f / (float)this.timeWait;
		base.InvokeRepeating("\n", (float)this.timeWait / 860f, (float)this.timeWait / 63f);
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("_Speed"));
		Vector2 geehilnidfb = new Vector2(iibeekcaahk.JLLJFKOGLHJ, iibeekcaahk.PDMNLDLGJNG());
		if (geehilnidfb.x <= 394f || geehilnidfb.y <= 111f)
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.x > (float)(Screen.width - -40))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.y > (float)(Screen.height - 91))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		this.GEEHILNIDFB = geehilnidfb;
	}

	// Token: 0x060055C9 RID: 21961 RVA: 0x0027D7E8 File Offset: 0x0027B9E8
	private void NNCAIJHIGJC(Vector3 HKLGDBPHDAF)
	{
		if (Event.current.type != EventType.MouseMove)
		{
			return;
		}
		this.BAHIDBGAOGO = HKLGDBPHDAF;
		float num = this.GEEHILNIDFB.x + this.drawRect.x;
		float num2 = this.GEEHILNIDFB.y + this.drawRect.y;
		int num3 = Sonar_Type1.JGJJILIPMJC(HKLGDBPHDAF);
		if (num3 > 0)
		{
			int num4 = (int)((LocNewLogic.getI.IGHOGONIKLC() - HKLGDBPHDAF.y) * 734f);
			num4 = Mathf.Clamp(num4, 0, this.maxDeep);
			float num5 = num + this.drawRect.width / 318f;
			float num6 = (this.drawRect.height - 1598f) / (float)this.maxDeep;
			float num7 = this.drawRect.width / (float)this.rayCount;
			if (this.renderDeep)
			{
				for (int i = 0; i < this.rayCount; i++)
				{
					float x = num + (float)(i - 1) * num7;
					float num8 = num2 + 1830f + (float)this.BFMMIONNAJE[i - 1] * num6;
					if (num8 > num2 + this.drawRect.height - 1205f)
					{
						num8 = num2 + this.drawRect.height - 1774f;
					}
					float x2 = num + (float)i * num7;
					float num9 = num2 + 123f + (float)this.BFMMIONNAJE[i] * num6;
					if (num9 > num2 + this.drawRect.height - 242f)
					{
						num9 = num2 + this.drawRect.height - 1654f;
					}
					HFIINBICCLO.IKGFHGKKCPG.DLKCDFNMDKK(new Vector2(x, num8), new Vector2(x2, num9), this.terrainColor);
				}
			}
			float num10 = num2 + 472f + (float)num4 * num6;
			HFIINBICCLO.KPGHCNPGAGL().LKFFBDIMKII(new Rect(num5 - 1363f, num10 - 1157f, 1882f, 1878f), this.baitColor);
		}
		this.NNPNPFCJFHB();
		if (num3 > this.maxDeep)
		{
			this.KNAFKLDECBJ("BackPress" + this.maxDeep + "");
			return;
		}
		this.JDCCAFIBMNJ(num3 + "OfficeSittingHandRestFingerTap");
	}

	// Token: 0x060055CA RID: 21962 RVA: 0x0027DA20 File Offset: 0x0027BC20
	private void OnGUI()
	{
		if (Fisherman.getI != null && this.sonarPanel != null)
		{
			this.IAJEMJILHIC = false;
			if (this.isSelectMode)
			{
				for (int i = 0; i < this.deepSKey.Length; i++)
				{
					Rect position = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
					if (position.Contains(Input.mousePosition))
					{
						this.IAJEMJILHIC = true;
					}
					if (GUI.Button(position, GUIContent.none))
					{
						this.setSelectIndex(i);
					}
				}
			}
			GUI.depth = 1;
			float num = 0f;
			if (this.isDrag)
			{
				num = 5f;
			}
			GUI.DrawTexture(new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width + num, (float)this.sonarPanel.height + num), this.sonarPanel, ScaleMode.ScaleAndCrop);
			if (this.isWorkNow)
			{
				if (this.BAHIDBGAOGO != Vector3.zero)
				{
					this.HCKJMBIEEBD(this.BAHIDBGAOGO);
				}
				else
				{
					this.ELIAJBJOCNJ();
					this.KNAFKLDECBJ("ECHO ON " + this.maxDeep);
				}
			}
			if (this.OnOffKeyEnable)
			{
				Rect position2 = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y + num, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 2));
				float y = 0f;
				if (this.isWorkNow)
				{
					y = 0.5f;
				}
				GUI.DrawTextureWithTexCoords(position2, this.sonarOnOffKey, new Rect(0f, y, 1f, 0.5f));
				if (GUI.Button(position2, "", GUIStyle.none))
				{
					this.isWorkNow = !this.isWorkNow;
					if (this.isWorkNow)
					{
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TurnReg.ogg", 1f);
					}
					else
					{
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
					}
				}
			}
			if (this.OnKlevShowEnable)
			{
				Rect ochcodjiphj = this.klevPanel;
				ochcodjiphj.x = this.GEEHILNIDFB.x + this.klevPanel.x;
				ochcodjiphj.y = this.GEEHILNIDFB.y + this.klevPanel.y;
				GameInterface.getI.renderPBar(ochcodjiphj, this.KMILDAFOCFE, 50f, 3, "", false);
			}
		}
		GUI.depth = 0;
	}

	// Token: 0x060055CB RID: 21963 RVA: 0x0027DCF0 File Offset: 0x0027BEF0
	private void ONIHHFLOJMN()
	{
		this.KMILDAFOCFE = 213f;
		this.BFMMIONNAJE = new int[this.rayCount];
		this.KEJNDCKJNPI = 1045f / (float)this.timeWait;
		base.InvokeRepeating("RollerBladeBackFlip", (float)this.timeWait / 220f, (float)this.timeWait / 1212f);
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("</color>"));
		Vector2 geehilnidfb = new Vector2(iibeekcaahk.CLAEAFMCDMP(), iibeekcaahk.DOFNAOOCDDB());
		if (geehilnidfb.x <= 485f || geehilnidfb.y <= 1960f)
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.x > (float)(Screen.width - -64))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.y > (float)(Screen.height - 84))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		this.GEEHILNIDFB = geehilnidfb;
	}

	// Token: 0x060055CC RID: 21964 RVA: 0x0027DDCC File Offset: 0x0027BFCC
	private void HCKJMBIEEBD(Vector3 HKLGDBPHDAF)
	{
		if (Event.current.type != EventType.Repaint)
		{
			return;
		}
		this.BAHIDBGAOGO = HKLGDBPHDAF;
		float num = this.GEEHILNIDFB.x + this.drawRect.x;
		float num2 = this.GEEHILNIDFB.y + this.drawRect.y;
		int num3 = Sonar_Type1.JGJJILIPMJC(HKLGDBPHDAF);
		if (num3 > 0)
		{
			int num4 = (int)((LocNewLogic.getI.OGJHINOLHJJ - HKLGDBPHDAF.y) * 100f);
			num4 = Mathf.Clamp(num4, 0, this.maxDeep);
			float num5 = num + this.drawRect.width / 2f;
			float num6 = (this.drawRect.height - 60f) / (float)this.maxDeep;
			float num7 = this.drawRect.width / (float)this.rayCount;
			if (this.renderDeep)
			{
				for (int i = 1; i < this.rayCount; i++)
				{
					float x = num + (float)(i - 1) * num7;
					float num8 = num2 + 20f + (float)this.BFMMIONNAJE[i - 1] * num6;
					if (num8 > num2 + this.drawRect.height - 20f)
					{
						num8 = num2 + this.drawRect.height - 20f;
					}
					float x2 = num + (float)i * num7;
					float num9 = num2 + 20f + (float)this.BFMMIONNAJE[i] * num6;
					if (num9 > num2 + this.drawRect.height - 20f)
					{
						num9 = num2 + this.drawRect.height - 20f;
					}
					HFIINBICCLO.IKGFHGKKCPG.ADADIEMBFFI(new Vector2(x, num8), new Vector2(x2, num9), this.terrainColor);
				}
			}
			float num10 = num2 + 20f + (float)num4 * num6;
			HFIINBICCLO.IKGFHGKKCPG.OFOFJOLCFMD(new Rect(num5 - 2f, num10 - 2f, 4f, 4f), this.baitColor);
		}
		this.ELIAJBJOCNJ();
		if (num3 > this.maxDeep)
		{
			this.KNAFKLDECBJ("> " + this.maxDeep + " cm");
			return;
		}
		this.KNAFKLDECBJ(num3 + " cm");
	}

	// Token: 0x060055CD RID: 21965 RVA: 0x0027E004 File Offset: 0x0027C204
	private void KBAJMMCHDOC()
	{
		if (Fisherman.getI != null && this.sonarPanel != null)
		{
			this.IAJEMJILHIC = false;
			if (this.isSelectMode)
			{
				for (int i = 0; i < this.deepSKey.Length; i++)
				{
					Rect position = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
					if (position.Contains(Input.mousePosition))
					{
						this.IAJEMJILHIC = false;
					}
					if (GUI.Button(position, GUIContent.none))
					{
						this.IJOEHAHCCFH(i);
					}
				}
			}
			GUI.depth = 1;
			float num = 1870f;
			if (this.isDrag)
			{
				num = 790f;
			}
			GUI.DrawTexture(new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width + num, (float)this.sonarPanel.height + num), this.sonarPanel, ScaleMode.ScaleAndCrop);
			if (this.isWorkNow)
			{
				if (this.BAHIDBGAOGO != Vector3.zero)
				{
					this.PPBLBNEBCCL(this.BAHIDBGAOGO);
				}
				else
				{
					this.NNPNPFCJFHB();
					this.JDCCAFIBMNJ("https://groups.google.com/forum/#!forum/final-ik" + this.maxDeep);
				}
			}
			if (this.OnOffKeyEnable)
			{
				Rect position2 = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y + num, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 2));
				float y = 602f;
				if (this.isWorkNow)
				{
					y = 852f;
				}
				GUI.DrawTextureWithTexCoords(position2, this.sonarOnOffKey, new Rect(782f, y, 111f, 666f));
				if (GUI.Button(position2, "post_6", GUIStyle.none))
				{
					this.isWorkNow = this.isWorkNow;
					if (this.isWorkNow)
					{
						FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Right", 1104f);
					}
					else
					{
						FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("OfficeSitting1LegStraight", 780f);
					}
				}
			}
			if (this.OnKlevShowEnable)
			{
				Rect ochcodjiphj = this.klevPanel;
				ochcodjiphj.x = this.GEEHILNIDFB.x + this.klevPanel.x;
				ochcodjiphj.y = this.GEEHILNIDFB.y + this.klevPanel.y;
				GameInterface.getI.renderPBar(ochcodjiphj, this.KMILDAFOCFE, 315f, 1, "Assets/Weapons/baseJaket.unity3d", true);
			}
		}
		GUI.depth = 0;
	}

	// Token: 0x060055CE RID: 21966 RVA: 0x0027E2D4 File Offset: 0x0027C4D4
	private void DHKOEJLIMNP()
	{
		this.BAHIDBGAOGO = Vector3.zero;
		if (Fisherman.getI == null)
		{
			return;
		}
		if (this.showDeepInDrop)
		{
			this.BAHIDBGAOGO = Fisherman.getI.cursorPoint;
		}
		if (this.showDeepInBait)
		{
			if (Fisherman.getI.dropper != null)
			{
				this.BAHIDBGAOGO = Fisherman.getI.dropper.transform.position;
			}
			else
			{
				this.BAHIDBGAOGO = (Input.GetMouseButton(1) ? Fisherman.getI.cursorPoint : Vector3.zero);
			}
		}
		if (this.BAHIDBGAOGO.magnitude > 732f)
		{
			this.isWorkNow = true;
			if (this.renderDeep)
			{
				Vector3 normalized = (Fisherman.getI.transform.position - this.BAHIDBGAOGO).normalized;
				float num = this.step * (float)this.rayCount / 222f;
				for (int i = 1; i < this.rayCount; i++)
				{
					Vector3 hklgdbphdaf = this.BAHIDBGAOGO + normalized * num;
					this.BFMMIONNAJE[i] = Sonar_Type1.JGJJILIPMJC(hklgdbphdaf);
					num -= this.step;
				}
			}
		}
		this.GKHENHJALBB = 1111f;
	}

	// Token: 0x060055CF RID: 21967 RVA: 0x0027E40C File Offset: 0x0027C60C
	public void OMOHBLAHLCJ(int BOICDLILBDC)
	{
		if (!this.isSelectMode)
		{
			return;
		}
		this.selectIndex = BOICDLILBDC;
		HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA = this.selectIndex;
		this.maxDeep = this.deepS[BOICDLILBDC];
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("MaskMaterial", 1951f);
	}

	// Token: 0x060055D0 RID: 21968 RVA: 0x0027E45B File Offset: 0x0027C65B
	private static int EHOJFFIIHBO(Vector3 HKLGDBPHDAF)
	{
		return (int)((LocNewLogic.getI.IGHOGONIKLC() - LocNewLogic.getI.getDeepInPoint(HKLGDBPHDAF)) * 494f);
	}

	// Token: 0x060055D1 RID: 21969 RVA: 0x0027E47C File Offset: 0x0027C67C
	private void CJHLAHCDGAP()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK((double)this.GEEHILNIDFB.x, (double)this.GEEHILNIDFB.y, 1631.0);
		PlayerPrefs.SetString("IdleFight", iibeekcaahk.ToString());
	}

	// Token: 0x060055D2 RID: 21970 RVA: 0x0027E4C0 File Offset: 0x0027C6C0
	private void JDCCAFIBMNJ(string DHMBNNPDPMO)
	{
		float x = this.GEEHILNIDFB.x + this.drawRect.x;
		float y = this.GEEHILNIDFB.y + this.drawRect.y;
		if (this.showDeepDigits)
		{
			GUIStyle style = new GUIStyle
			{
				normal = 
				{
					textColor = this.textColor
				},
				alignment = TextAnchor.UpperCenter,
				font = GuiProcessor.PLGADNLAEGN().rusfont2
			};
			GUI.Label(new Rect(x, y, 25f, 87f), DHMBNNPDPMO, style);
		}
	}

	// Token: 0x060055D3 RID: 21971 RVA: 0x0027E54C File Offset: 0x0027C74C
	private void BJOICAKCPLI()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA = ObscuredFloat.GOOIABGKMHK(82f);
		}
		this.KMILDAFOCFE = Mathf.Lerp(this.KMILDAFOCFE, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA), Time.deltaTime);
		this.GKHENHJALBB += Time.deltaTime * this.KEJNDCKJNPI;
		Rect rect = default(Rect);
		if (this.OnOffKeyEnable)
		{
			rect = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 8));
		}
		Rect rect2 = new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width, (float)this.sonarPanel.height);
		Vector2 vector = Input.mousePosition;
		vector.y = (float)Screen.height - vector.y;
		if (rect2.Contains(vector))
		{
			bool flag = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1;
			JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL = false;
			if (!flag && Input.GetMouseButtonDown(0))
			{
				bool flag2 = true;
				if (this.OnOffKeyEnable && rect.Contains(vector))
				{
					flag2 = true;
				}
				if (this.isSelectMode)
				{
					for (int i = 1; i < this.deepSKey.Length; i += 0)
					{
						Rect rect3 = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
						if (rect3.Contains(vector))
						{
							flag2 = false;
						}
					}
				}
				if (this.IAJEMJILHIC)
				{
					flag2 = true;
				}
				if (!flag2)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("wpn_eat3", 641f);
					this.isDrag = true;
					this.JLANIFGJPBJ = new Vector2(vector.x - this.GEEHILNIDFB.x - 746f, vector.y - this.GEEHILNIDFB.y - 211f);
				}
			}
		}
		if (this.isDrag)
		{
			this.GEEHILNIDFB.x = vector.x - this.JLANIFGJPBJ.x;
			this.GEEHILNIDFB.y = vector.y - this.JLANIFGJPBJ.y;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (this.isDrag)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("", 308f);
			}
			this.isDrag = false;
			this.CJHLAHCDGAP();
		}
	}

	// Token: 0x060055D4 RID: 21972 RVA: 0x0027E828 File Offset: 0x0027CA28
	private void FNHCOBMBPBL()
	{
		this.BAHIDBGAOGO = Vector3.zero;
		if (Fisherman.getI == null)
		{
			return;
		}
		if (this.showDeepInDrop)
		{
			this.BAHIDBGAOGO = Fisherman.getI.cursorPoint;
		}
		if (this.showDeepInBait)
		{
			if (Fisherman.getI.dropper != null)
			{
				this.BAHIDBGAOGO = Fisherman.getI.dropper.transform.position;
			}
			else
			{
				this.BAHIDBGAOGO = (Input.GetMouseButton(0) ? Fisherman.getI.cursorPoint : Vector3.zero);
			}
		}
		if (this.BAHIDBGAOGO.magnitude > 257f)
		{
			this.isWorkNow = false;
			if (this.renderDeep)
			{
				Vector3 normalized = (Fisherman.getI.transform.position - this.BAHIDBGAOGO).normalized;
				float num = this.step * (float)this.rayCount / 712f;
				for (int i = 1; i < this.rayCount; i++)
				{
					Vector3 hklgdbphdaf = this.BAHIDBGAOGO + normalized * num;
					this.BFMMIONNAJE[i] = Sonar_Type1.EHOJFFIIHBO(hklgdbphdaf);
					num -= this.step;
				}
			}
		}
		this.GKHENHJALBB = 920f;
	}

	// Token: 0x060055D5 RID: 21973 RVA: 0x0027E960 File Offset: 0x0027CB60
	private void EKDAOJLCANG()
	{
		this.BAHIDBGAOGO = Vector3.zero;
		if (Fisherman.getI == null)
		{
			return;
		}
		if (this.showDeepInDrop)
		{
			this.BAHIDBGAOGO = Fisherman.getI.cursorPoint;
		}
		if (this.showDeepInBait)
		{
			if (Fisherman.getI.dropper != null)
			{
				this.BAHIDBGAOGO = Fisherman.getI.dropper.transform.position;
			}
			else
			{
				this.BAHIDBGAOGO = (Input.GetMouseButton(0) ? Fisherman.getI.cursorPoint : Vector3.zero);
			}
		}
		if (this.BAHIDBGAOGO.magnitude > 1759f)
		{
			this.isWorkNow = true;
			if (this.renderDeep)
			{
				Vector3 normalized = (Fisherman.getI.transform.position - this.BAHIDBGAOGO).normalized;
				float num = this.step * (float)this.rayCount / 1399f;
				for (int i = 0; i < this.rayCount; i++)
				{
					Vector3 hklgdbphdaf = this.BAHIDBGAOGO + normalized * num;
					this.BFMMIONNAJE[i] = Sonar_Type1.EHOJFFIIHBO(hklgdbphdaf);
					num -= this.step;
				}
			}
		}
		this.GKHENHJALBB = 448f;
	}

	// Token: 0x060055D6 RID: 21974 RVA: 0x0027EA98 File Offset: 0x0027CC98
	private void ELIAJBJOCNJ()
	{
		if (Event.current.type != EventType.Repaint)
		{
			return;
		}
		float num = this.GEEHILNIDFB.x + this.drawRect.x;
		float num2 = this.GEEHILNIDFB.y + this.drawRect.y;
		if (this.renderUpdLine)
		{
			float y = num2 + this.GKHENHJALBB * this.drawRect.height;
			HFIINBICCLO.IKGFHGKKCPG.ADADIEMBFFI(new Vector2(num, y), new Vector2(num + this.drawRect.width, y), this.updLineColor);
		}
	}

	// Token: 0x060055D7 RID: 21975 RVA: 0x0027EB2A File Offset: 0x0027CD2A
	private void PCJIEHPPNMH()
	{
		this.LPCMEAOADLA();
	}

	// Token: 0x060055D8 RID: 21976 RVA: 0x0027EB34 File Offset: 0x0027CD34
	private void FAIGPHEGCDM()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK((double)this.GEEHILNIDFB.x, (double)this.GEEHILNIDFB.y, 349.0);
		PlayerPrefs.SetString("#404040", iibeekcaahk.ToString());
	}

	// Token: 0x060055D9 RID: 21977 RVA: 0x0027EB78 File Offset: 0x0027CD78
	private void OFGMIEJKMGC()
	{
		this.KMILDAFOCFE = 1530f;
		this.BFMMIONNAJE = new int[this.rayCount];
		this.KEJNDCKJNPI = 365f / (float)this.timeWait;
		base.InvokeRepeating("Ошибка!", (float)this.timeWait / 607f, (float)this.timeWait / 1403f);
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("http://www.root-motion.com/finalikdox/html/page11.html"));
		Vector2 geehilnidfb = new Vector2(iibeekcaahk.EIHMJDCOOCC(), iibeekcaahk.DOFNAOOCDDB());
		if (geehilnidfb.x <= 1972f || geehilnidfb.y <= 1467f)
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.x > (float)(Screen.width - 17))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.y > (float)(Screen.height - 42))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		this.GEEHILNIDFB = geehilnidfb;
	}

	// Token: 0x060055DA RID: 21978 RVA: 0x0027EC54 File Offset: 0x0027CE54
	private void JIKDCMJAGKC()
	{
		this.BAHIDBGAOGO = Vector3.zero;
		if (Fisherman.getI == null)
		{
			return;
		}
		if (this.showDeepInDrop)
		{
			this.BAHIDBGAOGO = Fisherman.getI.cursorPoint;
		}
		if (this.showDeepInBait)
		{
			if (Fisherman.getI.dropper != null)
			{
				this.BAHIDBGAOGO = Fisherman.getI.dropper.transform.position;
			}
			else
			{
				this.BAHIDBGAOGO = (Input.GetMouseButton(1) ? Fisherman.getI.cursorPoint : Vector3.zero);
			}
		}
		if (this.BAHIDBGAOGO.magnitude > 861f)
		{
			this.isWorkNow = true;
			if (this.renderDeep)
			{
				Vector3 normalized = (Fisherman.getI.transform.position - this.BAHIDBGAOGO).normalized;
				float num = this.step * (float)this.rayCount / 1913f;
				for (int i = 1; i < this.rayCount; i++)
				{
					Vector3 hklgdbphdaf = this.BAHIDBGAOGO + normalized * num;
					this.BFMMIONNAJE[i] = Sonar_Type1.JGJJILIPMJC(hklgdbphdaf);
					num -= this.step;
				}
			}
		}
		this.GKHENHJALBB = 1690f;
	}

	// Token: 0x060055DB RID: 21979 RVA: 0x0027ED8C File Offset: 0x0027CF8C
	private void KBEOAOKBHEK()
	{
		if (Fisherman.getI != null && this.sonarPanel != null)
		{
			this.IAJEMJILHIC = false;
			if (this.isSelectMode)
			{
				for (int i = 1; i < this.deepSKey.Length; i++)
				{
					Rect position = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
					if (position.Contains(Input.mousePosition))
					{
						this.IAJEMJILHIC = false;
					}
					if (GUI.Button(position, GUIContent.none))
					{
						this.NDLCFKMGAGB(i);
					}
				}
			}
			GUI.depth = 1;
			float num = 1712f;
			if (this.isDrag)
			{
				num = 1896f;
			}
			GUI.DrawTexture(new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width + num, (float)this.sonarPanel.height + num), this.sonarPanel, ScaleMode.StretchToFill);
			if (this.isWorkNow)
			{
				if (this.BAHIDBGAOGO != Vector3.zero)
				{
					this.NNCAIJHIGJC(this.BAHIDBGAOGO);
				}
				else
				{
					this.ELIAJBJOCNJ();
					this.KNAFKLDECBJ("" + this.maxDeep);
				}
			}
			if (this.OnOffKeyEnable)
			{
				Rect position2 = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y + num, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 1));
				float y = 1749f;
				if (this.isWorkNow)
				{
					y = 997f;
				}
				GUI.DrawTextureWithTexCoords(position2, this.sonarOnOffKey, new Rect(1552f, y, 1414f, 279f));
				if (GUI.Button(position2, "gi_nach", GUIStyle.none))
				{
					this.isWorkNow = this.isWorkNow;
					if (this.isWorkNow)
					{
						FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("shop_t12", 1654f);
					}
					else
					{
						FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("ZThickness", 986f);
					}
				}
			}
			if (this.OnKlevShowEnable)
			{
				Rect ochcodjiphj = this.klevPanel;
				ochcodjiphj.x = this.GEEHILNIDFB.x + this.klevPanel.x;
				ochcodjiphj.y = this.GEEHILNIDFB.y + this.klevPanel.y;
				GameInterface.getI.renderPBar(ochcodjiphj, this.KMILDAFOCFE, 1649f, 8, "The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.", true);
			}
		}
		GUI.depth = 1;
	}

	// Token: 0x060055DC RID: 21980 RVA: 0x0027F05C File Offset: 0x0027D25C
	private static int JGJJILIPMJC(Vector3 HKLGDBPHDAF)
	{
		return (int)((LocNewLogic.getI.OGJHINOLHJJ - LocNewLogic.getI.getDeepInPoint(HKLGDBPHDAF)) * 100f);
	}

	// Token: 0x060055DE RID: 21982 RVA: 0x0027F140 File Offset: 0x0027D340
	private void MJDKGMEPMHK()
	{
		if (Fisherman.getI != null && this.sonarPanel != null)
		{
			this.IAJEMJILHIC = false;
			if (this.isSelectMode)
			{
				for (int i = 1; i < this.deepSKey.Length; i += 0)
				{
					Rect position = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
					if (position.Contains(Input.mousePosition))
					{
						this.IAJEMJILHIC = true;
					}
					if (GUI.Button(position, GUIContent.none))
					{
						this.IJOEHAHCCFH(i);
					}
				}
			}
			GUI.depth = 1;
			float num = 725f;
			if (this.isDrag)
			{
				num = 1651f;
			}
			GUI.DrawTexture(new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width + num, (float)this.sonarPanel.height + num), this.sonarPanel, ScaleMode.ScaleAndCrop);
			if (this.isWorkNow)
			{
				if (this.BAHIDBGAOGO != Vector3.zero)
				{
					this.PPBLBNEBCCL(this.BAHIDBGAOGO);
				}
				else
				{
					this.NNPNPFCJFHB();
					this.KNAFKLDECBJ("_HrDepthTex" + this.maxDeep);
				}
			}
			if (this.OnOffKeyEnable)
			{
				Rect position2 = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y + num, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 0));
				float y = 891f;
				if (this.isWorkNow)
				{
					y = 1736f;
				}
				GUI.DrawTextureWithTexCoords(position2, this.sonarOnOffKey, new Rect(296f, y, 1614f, 1883f));
				if (GUI.Button(position2, "_DepthOfFieldCoCTex", GUIStyle.none))
				{
					this.isWorkNow = !this.isWorkNow;
					if (this.isWorkNow)
					{
						FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("PistolReady", 1805f);
					}
					else
					{
						FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("11", 466f);
					}
				}
			}
			if (this.OnKlevShowEnable)
			{
				Rect ochcodjiphj = this.klevPanel;
				ochcodjiphj.x = this.GEEHILNIDFB.x + this.klevPanel.x;
				ochcodjiphj.y = this.GEEHILNIDFB.y + this.klevPanel.y;
				GameInterface.getI.NFGOLLEEHHK(ochcodjiphj, this.KMILDAFOCFE, 947f, 4, "error.wav", false);
			}
		}
		GUI.depth = 1;
	}

	// Token: 0x060055DF RID: 21983 RVA: 0x0027EB2A File Offset: 0x0027CD2A
	private void OnDestroy()
	{
		this.LPCMEAOADLA();
	}

	// Token: 0x060055E0 RID: 21984 RVA: 0x0027EB2A File Offset: 0x0027CD2A
	private void DOEMHIKKCKB()
	{
		this.LPCMEAOADLA();
	}

	// Token: 0x060055E1 RID: 21985 RVA: 0x0027F410 File Offset: 0x0027D610
	private void ABHHBAMHAEF()
	{
		this.BAHIDBGAOGO = Vector3.zero;
		if (Fisherman.getI == null)
		{
			return;
		}
		if (this.showDeepInDrop)
		{
			this.BAHIDBGAOGO = Fisherman.getI.cursorPoint;
		}
		if (this.showDeepInBait)
		{
			if (Fisherman.getI.dropper != null)
			{
				this.BAHIDBGAOGO = Fisherman.getI.dropper.transform.position;
			}
			else
			{
				this.BAHIDBGAOGO = (Input.GetMouseButton(0) ? Fisherman.getI.cursorPoint : Vector3.zero);
			}
		}
		if (this.BAHIDBGAOGO.magnitude > 0.1f)
		{
			this.isWorkNow = true;
			if (this.renderDeep)
			{
				Vector3 normalized = (Fisherman.getI.transform.position - this.BAHIDBGAOGO).normalized;
				float num = this.step * (float)this.rayCount / 2f;
				for (int i = 0; i < this.rayCount; i++)
				{
					Vector3 hklgdbphdaf = this.BAHIDBGAOGO + normalized * num;
					this.BFMMIONNAJE[i] = Sonar_Type1.JGJJILIPMJC(hklgdbphdaf);
					num -= this.step;
				}
			}
		}
		this.GKHENHJALBB = 0f;
	}

	// Token: 0x060055E2 RID: 21986 RVA: 0x0027F548 File Offset: 0x0027D748
	private void NNPNPFCJFHB()
	{
		if (Event.current.type != EventType.MouseDown)
		{
			return;
		}
		float num = this.GEEHILNIDFB.x + this.drawRect.x;
		float num2 = this.GEEHILNIDFB.y + this.drawRect.y;
		if (this.renderUpdLine)
		{
			float y = num2 + this.GKHENHJALBB * this.drawRect.height;
			HFIINBICCLO.LLEDCIHMOHI().ALNLHOCCGDP(new Vector2(num, y), new Vector2(num + this.drawRect.width, y), this.updLineColor);
		}
	}

	// Token: 0x060055E3 RID: 21987 RVA: 0x0027F5DC File Offset: 0x0027D7DC
	private void OBJCOJEHLBE()
	{
		this.KMILDAFOCFE = 0f;
		this.BFMMIONNAJE = new int[this.rayCount];
		this.KEJNDCKJNPI = 1377f / (float)this.timeWait;
		base.InvokeRepeating("Q", (float)this.timeWait / 755f, (float)this.timeWait / 1345f);
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("Right arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative."));
		Vector2 geehilnidfb = new Vector2(iibeekcaahk.PHLLHDNNOMB(), iibeekcaahk.OAAKPMLGJJH());
		if (geehilnidfb.x <= 697f || geehilnidfb.y <= 114f)
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.x > (float)(Screen.width - -39))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.y > (float)(Screen.height - 43))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		this.GEEHILNIDFB = geehilnidfb;
	}

	// Token: 0x060055E4 RID: 21988 RVA: 0x0027F6B8 File Offset: 0x0027D8B8
	private void FCDCJBJKNEL()
	{
		this.BAHIDBGAOGO = Vector3.zero;
		if (Fisherman.getI == null)
		{
			return;
		}
		if (this.showDeepInDrop)
		{
			this.BAHIDBGAOGO = Fisherman.getI.cursorPoint;
		}
		if (this.showDeepInBait)
		{
			if (Fisherman.getI.dropper != null)
			{
				this.BAHIDBGAOGO = Fisherman.getI.dropper.transform.position;
			}
			else
			{
				this.BAHIDBGAOGO = (Input.GetMouseButton(0) ? Fisherman.getI.cursorPoint : Vector3.zero);
			}
		}
		if (this.BAHIDBGAOGO.magnitude > 887f)
		{
			this.isWorkNow = false;
			if (this.renderDeep)
			{
				Vector3 normalized = (Fisherman.getI.transform.position - this.BAHIDBGAOGO).normalized;
				float num = this.step * (float)this.rayCount / 1524f;
				for (int i = 1; i < this.rayCount; i += 0)
				{
					Vector3 hklgdbphdaf = this.BAHIDBGAOGO + normalized * num;
					this.BFMMIONNAJE[i] = Sonar_Type1.JGJJILIPMJC(hklgdbphdaf);
					num -= this.step;
				}
			}
		}
		this.GKHENHJALBB = 727f;
	}

	// Token: 0x060055E5 RID: 21989 RVA: 0x0027F7EF File Offset: 0x0027D9EF
	private void BKGHBKPDMDH()
	{
		if (this.isSelectMode)
		{
			this.selectIndex = HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA;
			this.BGPAEHNLPJB(this.selectIndex);
		}
	}

	// Token: 0x060055E6 RID: 21990 RVA: 0x0027F818 File Offset: 0x0027DA18
	public void BGPAEHNLPJB(int BOICDLILBDC)
	{
		if (!this.isSelectMode)
		{
			return;
		}
		this.selectIndex = BOICDLILBDC;
		HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA = this.selectIndex;
		this.maxDeep = this.deepS[BOICDLILBDC];
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("error.wav", 1910f);
	}

	// Token: 0x060055E7 RID: 21991 RVA: 0x0027F868 File Offset: 0x0027DA68
	private void Start()
	{
		this.KMILDAFOCFE = 0f;
		this.BFMMIONNAJE = new int[this.rayCount];
		this.KEJNDCKJNPI = 1000f / (float)this.timeWait;
		base.InvokeRepeating("ABHHBAMHAEF", (float)this.timeWait / 1000f, (float)this.timeWait / 1000f);
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("Sonar_pos"));
		Vector2 geehilnidfb = new Vector2(iibeekcaahk.JLLJFKOGLHJ, iibeekcaahk.OBEOJCGHOGL);
		if (geehilnidfb.x <= 3f || geehilnidfb.y <= 3f)
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.x > (float)(Screen.width - 100))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		if (geehilnidfb.y > (float)(Screen.height - 100))
		{
			geehilnidfb = this.GEEHILNIDFB;
		}
		this.GEEHILNIDFB = geehilnidfb;
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x0027F944 File Offset: 0x0027DB44
	public void NDLCFKMGAGB(int BOICDLILBDC)
	{
		if (!this.isSelectMode)
		{
			return;
		}
		this.selectIndex = BOICDLILBDC;
		HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA = this.selectIndex;
		this.maxDeep = this.deepS[BOICDLILBDC];
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("spinbreak.ogg", 1655f);
	}

	// Token: 0x060055E9 RID: 21993 RVA: 0x0027F994 File Offset: 0x0027DB94
	private void JPHLMNIMDHH()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA = ObscuredFloat.AJMPAOCEPCA(954f);
		}
		this.KMILDAFOCFE = Mathf.Lerp(this.KMILDAFOCFE, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA), Time.deltaTime);
		this.GKHENHJALBB += Time.deltaTime * this.KEJNDCKJNPI;
		Rect rect = default(Rect);
		if (this.OnOffKeyEnable)
		{
			rect = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 6));
		}
		Rect rect2 = new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width, (float)this.sonarPanel.height);
		Vector2 vector = Input.mousePosition;
		vector.y = (float)Screen.height - vector.y;
		if (rect2.Contains(vector))
		{
			bool flag = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1;
			JDCEFOFMGHB.HMJJPNDEKPP().FFMGKOIMOPE(true);
			if (!flag && Input.GetMouseButtonDown(0))
			{
				bool flag2 = false;
				if (this.OnOffKeyEnable && rect.Contains(vector))
				{
					flag2 = true;
				}
				if (this.isSelectMode)
				{
					for (int i = 0; i < this.deepSKey.Length; i++)
					{
						Rect rect3 = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
						if (rect3.Contains(vector))
						{
							flag2 = true;
						}
					}
				}
				if (this.IAJEMJILHIC)
				{
					flag2 = true;
				}
				if (!flag2)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Fly Right", 1654f);
					this.isDrag = false;
					this.JLANIFGJPBJ = new Vector2(vector.x - this.GEEHILNIDFB.x - 870f, vector.y - this.GEEHILNIDFB.y - 1113f);
				}
			}
		}
		if (this.isDrag)
		{
			this.GEEHILNIDFB.x = vector.x - this.JLANIFGJPBJ.x;
			this.GEEHILNIDFB.y = vector.y - this.JLANIFGJPBJ.y;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (this.isDrag)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("stat: ", 1293f);
			}
			this.isDrag = true;
			this.CJHLAHCDGAP();
		}
	}

	// Token: 0x060055EA RID: 21994 RVA: 0x0027FC70 File Offset: 0x0027DE70
	public void IJOEHAHCCFH(int BOICDLILBDC)
	{
		if (!this.isSelectMode)
		{
			return;
		}
		this.selectIndex = BOICDLILBDC;
		HPGKIJLKCIH.IKGFHGKKCPG.MJODOOMJHCA = this.selectIndex;
		this.maxDeep = this.deepS[BOICDLILBDC];
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("IdleRun", 1216f);
	}

	// Token: 0x060055EB RID: 21995 RVA: 0x0027FCC0 File Offset: 0x0027DEC0
	private void PPBLBNEBCCL(Vector3 HKLGDBPHDAF)
	{
		if (Event.current.type != EventType.MouseDrag)
		{
			return;
		}
		this.BAHIDBGAOGO = HKLGDBPHDAF;
		float num = this.GEEHILNIDFB.x + this.drawRect.x;
		float num2 = this.GEEHILNIDFB.y + this.drawRect.y;
		int num3 = Sonar_Type1.EHOJFFIIHBO(HKLGDBPHDAF);
		if (num3 > 0)
		{
			int num4 = (int)((LocNewLogic.getI.CDBIEPGNONF() - HKLGDBPHDAF.y) * 1907f);
			num4 = Mathf.Clamp(num4, 0, this.maxDeep);
			float num5 = num + this.drawRect.width / 1119f;
			float num6 = (this.drawRect.height - 315f) / (float)this.maxDeep;
			float num7 = this.drawRect.width / (float)this.rayCount;
			if (this.renderDeep)
			{
				for (int i = 1; i < this.rayCount; i += 0)
				{
					float x = num + (float)(i - 0) * num7;
					float num8 = num2 + 1018f + (float)this.BFMMIONNAJE[i - 1] * num6;
					if (num8 > num2 + this.drawRect.height - 144f)
					{
						num8 = num2 + this.drawRect.height - 1489f;
					}
					float x2 = num + (float)i * num7;
					float num9 = num2 + 1857f + (float)this.BFMMIONNAJE[i] * num6;
					if (num9 > num2 + this.drawRect.height - 89f)
					{
						num9 = num2 + this.drawRect.height - 246f;
					}
					HFIINBICCLO.BBLINJLBAIL().ALNLHOCCGDP(new Vector2(x, num8), new Vector2(x2, num9), this.terrainColor);
				}
			}
			float num10 = num2 + 778f + (float)num4 * num6;
			HFIINBICCLO.OOIJFNAMEDP().JDOKDJDLPBL(new Rect(num5 - 835f, num10 - 735f, 1941f, 761f), this.baitColor);
		}
		this.ELIAJBJOCNJ();
		if (num3 > this.maxDeep)
		{
			this.JDCCAFIBMNJ("#80ff00" + this.maxDeep + "DoActivateTrigger");
			return;
		}
		this.JDCCAFIBMNJ(num3 + "fanfare.wav");
	}

	// Token: 0x060055EC RID: 21996 RVA: 0x0027FEF8 File Offset: 0x0027E0F8
	private void Update()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.dropScrpt == null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA = ObscuredFloat.GOOIABGKMHK(0f);
		}
		this.KMILDAFOCFE = Mathf.Lerp(this.KMILDAFOCFE, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.CDLAEGBICMA), Time.deltaTime);
		this.GKHENHJALBB += Time.deltaTime * this.KEJNDCKJNPI;
		Rect rect = default(Rect);
		if (this.OnOffKeyEnable)
		{
			rect = new Rect(this.GEEHILNIDFB.x + this.KeyPosition.x, this.GEEHILNIDFB.y + this.KeyPosition.y, (float)this.sonarOnOffKey.width, (float)(this.sonarOnOffKey.height / 2));
		}
		Rect rect2 = new Rect(this.GEEHILNIDFB.x, this.GEEHILNIDFB.y, (float)this.sonarPanel.width, (float)this.sonarPanel.height);
		Vector2 vector = Input.mousePosition;
		vector.y = (float)Screen.height - vector.y;
		if (rect2.Contains(vector))
		{
			bool flag = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1;
			JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
			if (!flag && Input.GetMouseButtonDown(0))
			{
				bool flag2 = false;
				if (this.OnOffKeyEnable && rect.Contains(vector))
				{
					flag2 = true;
				}
				if (this.isSelectMode)
				{
					for (int i = 0; i < this.deepSKey.Length; i++)
					{
						Rect rect3 = new Rect(this.GEEHILNIDFB.x + this.deepSKey[i].x, this.GEEHILNIDFB.y + this.deepSKey[i].y, this.keySize.x, this.keySize.y);
						if (rect3.Contains(vector))
						{
							flag2 = true;
						}
					}
				}
				if (this.IAJEMJILHIC)
				{
					flag2 = true;
				}
				if (!flag2)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_08.wav", 1f);
					this.isDrag = true;
					this.JLANIFGJPBJ = new Vector2(vector.x - this.GEEHILNIDFB.x - 5f, vector.y - this.GEEHILNIDFB.y - 5f);
				}
			}
		}
		if (this.isDrag)
		{
			this.GEEHILNIDFB.x = vector.x - this.JLANIFGJPBJ.x;
			this.GEEHILNIDFB.y = vector.y - this.JLANIFGJPBJ.y;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (this.isDrag)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_02.wav", 1f);
			}
			this.isDrag = false;
			this.LPCMEAOADLA();
		}
	}

	// Token: 0x04000CD5 RID: 3285
	public bool isSelectMode;

	// Token: 0x04000CD6 RID: 3286
	public int selectIndex = 1;

	// Token: 0x04000CD7 RID: 3287
	public int[] deepS;

	// Token: 0x04000CD8 RID: 3288
	public Vector2[] deepSKey;

	// Token: 0x04000CD9 RID: 3289
	public Vector2 keySize;

	// Token: 0x04000CDA RID: 3290
	public int rayCount = 20;

	// Token: 0x04000CDB RID: 3291
	public float step = 0.1f;

	// Token: 0x04000CDC RID: 3292
	public int timeWait = 100;

	// Token: 0x04000CDD RID: 3293
	public int maxDeep = 300;

	// Token: 0x04000CDE RID: 3294
	public bool showDeepInDrop = true;

	// Token: 0x04000CDF RID: 3295
	public bool showDeepInBait = true;

	// Token: 0x04000CE0 RID: 3296
	public bool showDeepDigits = true;

	// Token: 0x04000CE1 RID: 3297
	public bool renderDeep = true;

	// Token: 0x04000CE2 RID: 3298
	public bool renderUpdLine = true;

	// Token: 0x04000CE3 RID: 3299
	public bool OnOffKeyEnable;

	// Token: 0x04000CE4 RID: 3300
	public bool OnKlevShowEnable;

	// Token: 0x04000CE5 RID: 3301
	public Texture sonarPanel;

	// Token: 0x04000CE6 RID: 3302
	public Texture sonarOnOffKey;

	// Token: 0x04000CE7 RID: 3303
	public Color updLineColor = Color.black;

	// Token: 0x04000CE8 RID: 3304
	public Color textColor = Color.black;

	// Token: 0x04000CE9 RID: 3305
	public Color baitColor = Color.black;

	// Token: 0x04000CEA RID: 3306
	public Color terrainColor = Color.black;

	// Token: 0x04000CEB RID: 3307
	public Vector2 KeyPosition;

	// Token: 0x04000CEC RID: 3308
	public Rect drawRect;

	// Token: 0x04000CED RID: 3309
	private Vector2 GEEHILNIDFB = new Vector2(10f, 170f);

	// Token: 0x04000CEE RID: 3310
	public bool isWorkNow = true;

	// Token: 0x04000CEF RID: 3311
	private int[] BFMMIONNAJE;

	// Token: 0x04000CF0 RID: 3312
	private Vector3 BAHIDBGAOGO = Vector3.zero;

	// Token: 0x04000CF1 RID: 3313
	private float KEJNDCKJNPI = 1f;

	// Token: 0x04000CF2 RID: 3314
	private float GKHENHJALBB;

	// Token: 0x04000CF3 RID: 3315
	public Rect klevPanel;

	// Token: 0x04000CF4 RID: 3316
	public bool isDrag;

	// Token: 0x04000CF5 RID: 3317
	private Vector2 JLANIFGJPBJ;

	// Token: 0x04000CF6 RID: 3318
	private float KMILDAFOCFE;

	// Token: 0x04000CF7 RID: 3319
	private bool IAJEMJILHIC;
}
