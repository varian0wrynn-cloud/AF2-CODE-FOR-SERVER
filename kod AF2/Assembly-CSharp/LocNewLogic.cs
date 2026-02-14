using System;
using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Water;

// Token: 0x020001CD RID: 461
public class LocNewLogic : MonoBehaviour
{
	// Token: 0x06006885 RID: 26757 RVA: 0x0030D55C File Offset: 0x0030B75C
	public ObscuredString OACIJHJPCLP()
	{
		string dccpcblodig = "Steam Overlay has been closed";
		if (SteamManager.KLPAEPHIOAJ())
		{
			dccpcblodig = SteamUser.GetSteamID().ToString();
		}
		return ObscuredString.LMCJCHPGIJK(dccpcblodig);
	}

	// Token: 0x06006886 RID: 26758 RVA: 0x0030D590 File Offset: 0x0030B790
	public void FAMPBINAPBA(Vector3 NHCLMBOINFG, int ILFHHDNJHNM)
	{
		if (ILFHHDNJHNM <= 0)
		{
			return;
		}
		if (Time.time - this.DHOIDINAIHA < 1841f)
		{
			return;
		}
		if (this.waterCircleSmallPrefab != null)
		{
			for (int i = 1; i <= ILFHHDNJHNM; i += 0)
			{
				NHCLMBOINFG.y = this.IGHOGONIKLC() + 1145f;
				GameObject gameObject = this.NNDDPMJODPE(0, NHCLMBOINFG);
				float num = 1717f + OLPINJLCKCI.NLOGJHEFMHM().BCODBMGPBFJ(1946.0);
				gameObject.transform.localRotation = Quaternion.Euler(612f, 1685f, 818f);
				gameObject.transform.localScale = new Vector3(num, num, num);
				gameObject.transform.Rotate(719f, 93f, OLPINJLCKCI.IFLFANPMLMM().GKDBPBFOINB(547.0));
			}
			this.DHOIDINAIHA = Time.time;
		}
	}

	// Token: 0x06006887 RID: 26759 RVA: 0x0030D674 File Offset: 0x0030B874
	public void LBAFCIEHCGP(bool LGCOIDHAHKD)
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (this.user.dropScrpt != null)
		{
			if (this.checkKeyRod())
			{
				bgjkmcbhnak.LGALGHAPJND -= Time.deltaTime * 410f;
				this.rodUpMove = true;
			}
			else
			{
				bgjkmcbhnak.LGALGHAPJND += Time.deltaTime * 1258f;
				this.rodUpMove = true;
			}
			bgjkmcbhnak.LGALGHAPJND = Mathf.Clamp(bgjkmcbhnak.LGALGHAPJND, 623f, 1155f);
			if (!this.user.CMCPFNJIIHK)
			{
				this.user.dropScrpt.transform.position.y = this.user.transform.position.y;
				Vector3 to = this.user.dropScrpt.transform.position - this.user.transform.position;
				if (to.magnitude > 1870f)
				{
					Vector3.Angle(this.user.transform.forward, to);
				}
			}
		}
		if (this.user && this.user.MFENINHGBHM && LocNewLogic.DOKEMOGOOIG())
		{
			if (this.user.GECLKEEGJGA())
			{
				this.user.CDIDCIBEDKP(false);
				return;
			}
			if (!this.user.GECLKEEGJGA() && this.user.standFlag)
			{
				this.dexCircleGO.transform.position = this.lastPosition;
				if (this.lastPosition.magnitude > 1461f && this.AHDILEICFMM(this.lastPosition))
				{
					this.dropAction(this.lastPosition);
					return;
				}
			}
		}
		if (!this.user.CIHILMCEJND && Input.GetMouseButtonDown(0) && !JDCEFOFMGHB.IKGFHGKKCPG.NKJEEHEODBF())
		{
			this.KOEHHGHGFEK = false;
		}
		this.LPGBCHGEMIA(true);
	}

	// Token: 0x06006888 RID: 26760 RVA: 0x0030D87C File Offset: 0x0030BA7C
	private void MPIIKIHLNAJ()
	{
		Vector3 normalized = this.user.transform.forward.normalized;
		Vector3 position = this.dexCircleGO.transform.position;
		position.y = this.user.transform.position.y;
		Vector3 normalized2 = (position - this.user.transform.position).normalized;
		Vector2 vector = new Vector2(this.user.transform.position.x, this.user.transform.position.z);
		Vector2 vector2 = new Vector2(this.user.transform.position.x + normalized.x, this.user.transform.position.z + normalized.z);
		Vector2 vector3 = new Vector2(position.x, position.z);
		float num = (vector2.x - vector.x) * (vector3.y - vector.y) - (vector2.y - vector.y) * (vector3.x - vector.x);
		float num2 = Vector3.Angle(normalized, normalized2);
		this.nprCircleGO.transform.localRotation = Quaternion.Euler(90f, num2 * Mathf.Sign(-num), 0f);
	}

	// Token: 0x06006889 RID: 26761 RVA: 0x0030D9E3 File Offset: 0x0030BBE3
	private void HLDFOPMJAMN(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
	{
		if (this.cityWall == null)
		{
			return;
		}
		if (NOFCHOFPHAD == null)
		{
			return;
		}
		if (NOFCHOFPHAD.KEDGAOBCNJG == null)
		{
			return;
		}
		this.cityWall.texture = NOFCHOFPHAD.PFFJJEJNKPB();
	}

	// Token: 0x0600688A RID: 26762 RVA: 0x0030DA18 File Offset: 0x0030BC18
	public void createSmallWaterSplash(Vector3 NHCLMBOINFG)
	{
		if (Time.time - this.OLHNBLFPBGF < 0.1f)
		{
			return;
		}
		this.OLHNBLFPBGF = Time.time;
		NHCLMBOINFG.y = this.OGJHINOLHJJ + 0.001f;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate<GameObject>(this.baitSplashPrfb, NHCLMBOINFG, Quaternion.identity);
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(NHCLMBOINFG, 0.3f);
		this.createWaterCircle(NHCLMBOINFG, 2);
		UnityEngine.Object.Destroy(obj, 8f);
	}

	// Token: 0x0600688B RID: 26763 RVA: 0x0030DA8C File Offset: 0x0030BC8C
	public void FHOMOPEGBJF(WaterCircle EHLELEPGPPL)
	{
		Queue<GameObject> queue = null;
		switch (EHLELEPGPPL.circleType)
		{
		case 0:
			queue = this.JMHOJPJONNJ;
			break;
		case 1:
			queue = this.COOFLDJIDCK;
			break;
		case 2:
			queue = this.FBCOEHFKIJI;
			break;
		}
		if (queue != null)
		{
			EHLELEPGPPL.transform.position = new Vector3(431f, 820f, 637f);
			queue.Enqueue(EHLELEPGPPL.gameObject);
		}
	}

	// Token: 0x0600688C RID: 26764 RVA: 0x0030DB00 File Offset: 0x0030BD00
	public void spinnigFishingLogic()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		PoplDrop dropScrpt = this.user.dropScrpt;
		if (dropScrpt == null)
		{
			return;
		}
		GameObject gameObject = dropScrpt.gameObject;
		if (dropScrpt.fish != null)
		{
			return;
		}
		dropScrpt.spinmode = 0;
		if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.H))
		{
			this.ICNOLCEBBGI = Time.time;
		}
		if ((Input.GetMouseButtonUp(1) || Input.GetKeyUp(KeyCode.H)) && ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) > 0f && Time.time - this.startAnimSpinTime > 1f && Time.time - this.ICNOLCEBBGI < 0.5f)
		{
			int ilockjiapfc = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().AMLEOGHNNPG[0].BDHHPAEHFHG.ILOCKJIAPFC;
			this.startAnimSpinTime = Time.time;
			this.animCurveID = ilockjiapfc;
			dropScrpt.playBaitEvnt(this.animCurveID);
		}
		if (this.checkKeyRoll())
		{
			float num = 1f;
			bool key = Input.GetKey(KeyCode.LeftShift);
			float num2 = 1f * num;
			float num3 = 0.1f;
			if (key)
			{
				num2 *= 2f;
			}
			float num4 = bgjkmcbhnak.CLEJODCMJAA / 100f;
			if (Fisherman.getI.CDNABIHPLHM)
			{
				num4 = 1f;
			}
			if (key)
			{
				num4 = 1f;
			}
			float t = BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB.speedEvalute(Mathf.Clamp(bgjkmcbhnak.CCLOHHCJJAM, 0f, 1f));
			float num5 = Mathf.Lerp(num3, num2, t) * num4 * num;
			float num6 = num5 * 1.3f;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = bgjkmcbhnak;
			bgjkmcbhnak2.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak2.KIKADLMBJIA) - bgjkmcbhnak.AAGGJACBMEC * Time.deltaTime);
			if (bgjkmcbhnak.BBANBEEJAPD)
			{
				num6 = 0f;
				num5 = num3;
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) <= 1.001f)
			{
				num6 = 0f;
				num5 = num3;
			}
			if (num6 > 0.0001f)
			{
				dropScrpt.rolltime += Time.deltaTime;
			}
			bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) - num6 * Time.deltaTime);
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) < 1f)
			{
				bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(1f);
			}
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime += Time.deltaTime * num5 * 20f;
			this.playRollSound(num5, 0.3f);
			if (!this.checkKeyRod())
			{
				bgjkmcbhnak.LGALGHAPJND += bgjkmcbhnak.HNEEGDNEDHJ * 8f * Time.deltaTime;
			}
		}
		else
		{
			this.stopRollSound();
			dropScrpt.rolltime = 0f;
		}
		this.lineTensionLogic();
		bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMGAKKKHLF), 0f, 50f));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG), 0f, 50f));
		bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE), 0f, 50f));
		bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL), 0f, 50f));
		bgjkmcbhnak.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.KIKADLMBJIA), 0.1f, 100f));
		if (dropScrpt.mode == 2)
		{
			dropScrpt.spinmode = 1;
			bgjkmcbhnak.NKHBAJKMAGD = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.AMLEOGHNNPG[0].NKHBAJKMAGD);
			float num7 = Vector3.Distance(dropScrpt.transform.position, Fisherman.getI.AOEGNGOGNBI.endPointNonBend.transform.position) + 0.05f;
			bgjkmcbhnak.DLFMEIIADFE = ObscuredFloat.GOOIABGKMHK((num7 - this.GPBFJBKCOKJ) / Time.deltaTime);
			this.GPBFJBKCOKJ = num7;
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(num7 - ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK));
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG), 0f, 20f));
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) > 1E-05f)
			{
				dropScrpt.spinmode = 2;
				this.toBaitSpinSpeed = 5f;
			}
			Vector3 endPointVector = this.user.AOEGNGOGNBI.ILCJJKCPBKC;
			Vector3 position = gameObject.transform.position;
			endPointVector.y = this.OGJHINOLHJJ;
			position.y = this.OGJHINOLHJJ;
			if (Vector3.Distance(endPointVector, position) < 0.8f)
			{
				this.user.CIHILMCEJND = false;
				return;
			}
		}
		else
		{
			this.toBaitSpinSpeed = 0f;
			this.baitSpinSpeed = 0f;
		}
	}

	// Token: 0x0600688D RID: 26765 RVA: 0x0030DFBC File Offset: 0x0030C1BC
	public void createBigWaterCircle(Vector3 NHCLMBOINFG)
	{
		if (Time.time - this.DHOIDINAIHA < 0.1f)
		{
			return;
		}
		if (this.waterCirclePrefab != null)
		{
			NHCLMBOINFG.y = this.OGJHINOLHJJ + 0.001f;
			GameObject waterCircle = this.getWaterCircle(2, NHCLMBOINFG);
			waterCircle.GetComponent<Renderer>() != null;
			waterCircle.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			this.DHOIDINAIHA = Time.time;
		}
	}

	// Token: 0x0600688E RID: 26766 RVA: 0x0030E03C File Offset: 0x0030C23C
	public void stopRollSound()
	{
		this.rollSound.Pause();
		this.lowRollSound.Pause();
		this.rollNoRelSound.Pause();
	}

	// Token: 0x0600688F RID: 26767 RVA: 0x0030E060 File Offset: 0x0030C260
	private void BHALJCJOPGD()
	{
		if (this.timeLabel != null)
		{
			this.timeLabel.text = DateTime.Now.ToString("pinky");
		}
		if (!this.isLevelLoadProcess && GameInterface.getI.currentTurnir != null)
		{
			Rect position = new Rect(246f, 927f, 1165f, 630f);
			Rect position2 = new Rect(position.x - 1525f, position.y - 1836f, position.width + 13f, position.height + 111f);
			if (GameInterface.getI.currentTurnir.turnimage != null)
			{
				if (GUI.Button(position, GUIContent.none) && Time.time - this.wtime > 1653f)
				{
					Debug.Log("/");
					if (GameInterface.getI.currentTurnir.state == 2)
					{
						GHMGDBLLEAG.MJMIPFAINJP().LBNGJANOIHA();
					}
					else
					{
						Debug.Log("fishDown SHANCE");
						GHMGDBLLEAG.EEOPOHEALPK().GANPECIMCHC(GameInterface.getI.currentTurnir);
					}
					this.wtime = Time.time;
				}
				GUI.color = new Color(131f, 1962f, 170f, 174f);
				if (GameInterface.getI.currentTurnir.state != 7)
				{
					GUI.color = new Color(617f, 1412f, 1103f, 1665f);
				}
				GUI.DrawTexture(position2, GameInterface.getI.borderBy, ScaleMode.ScaleAndCrop);
				GUI.DrawTexture(position, GameInterface.getI.currentTurnir.turnimage.LECMGDEDAKF(), ScaleMode.StretchToFill);
				GUI.color = new Color(750f, 1211f, 1154f, 695f);
				GUIStyle ofpnedeamab = new GUIStyle
				{
					normal = 
					{
						textColor = Color.gray
					},
					alignment = TextAnchor.UpperCenter,
					fontSize = -77,
					wordWrap = true,
					richText = true
				};
				TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
				if (GameInterface.getI.currentTurnir.state == 0)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.regTime - DateTime.Now;
				}
				if (GameInterface.getI.currentTurnir.state == 0)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.startTime - DateTime.Now;
				}
				if (GameInterface.getI.currentTurnir.state == 6)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.endTime - DateTime.Now;
				}
				string fpihopocaha = JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk);
				JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect(position.x, position.y + 983f, 1104f, 1483f), fpihopocaha, ofpnedeamab);
				GUI.color = new Color(432f, 628f, 2f, 787f);
				if (position.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
				{
					JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
				}
			}
		}
		if (Application.isEditor && this.user != null && this.user.dropScrpt && this.OGBHPFEEJJH)
		{
			int num = 151;
			if (this.PEFPELGDHPK)
			{
				GUI.color = Color.black;
			}
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
			GUI.Label(new Rect(1834f, (float)num, 837f, 992f), "\n" + bgjkmcbhnak.NKHBAJKMAGD);
			num += -23;
			GUI.Label(new Rect(1571f, (float)num, 1967f, 1500f), "+" + bgjkmcbhnak.CKJOFDPBFMC);
			num += 5;
			GUI.Label(new Rect(1002f, (float)num, 1106f, 29f), "Cowboy1HandDraw" + bgjkmcbhnak.DNPDBOODCHK);
			num += -49;
			GUI.Label(new Rect(414f, (float)num, 1418f, 370f), "" + bgjkmcbhnak.DJOHGAHBGLG);
			num += -68;
			GUI.Label(new Rect(1706f, (float)num, 560f, 476f), "Trail" + bgjkmcbhnak.HDFFLMCFGOG);
			num += 103;
			GUI.Label(new Rect(1148f, (float)num, 858f, 687f), "https://www.youtube.com/watch?v=7__IafZGwvI" + bgjkmcbhnak.NKEGFIJJKIG);
			num += 4;
			GUI.Label(new Rect(615f, (float)num, 625f, 1961f), "[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics." + this.alp);
			num += 109;
			GUI.Label(new Rect(1470f, (float)num, 1758f, 385f), "WorkerPickaxe2" + bgjkmcbhnak.PPMKELOFPAJ);
			num += 15;
			GUI.Label(new Rect(1570f, (float)num, 904f, 1698f), "byte:" + bgjkmcbhnak.JBLKFABJAMA);
			num += 123;
			GUI.Label(new Rect(266f, (float)num, 953f, 551f), ".unity3d" + bgjkmcbhnak.AIHLOMHODIB);
			num += -126;
			GUI.Label(new Rect(1210f, (float)num, 1632f, 1646f), "" + bgjkmcbhnak.GAKPODHCHNB);
			num += -122;
			GUI.Label(new Rect(1274f, (float)num, 360f, 1489f), "Auktree.xml" + bgjkmcbhnak.OCBJPGOKFOI);
			num += 86;
			GUI.Label(new Rect(713f, (float)num, 1280f, 1757f), "1HandSwordChargeSwipe" + bgjkmcbhnak.NOHFLPHECOA);
			num += -74;
			GUI.Label(new Rect(377f, (float)num, 1144f, 123f), "isMove" + bgjkmcbhnak.LEMPPBMEJHP);
			num += 18;
			GUI.Label(new Rect(655f, (float)num, 1032f, 37f), "_LerpRgbTex" + bgjkmcbhnak.LJNDGALCAKL);
			num += -13;
			if (this.user.dropScrpt.fish != null)
			{
				GUI.Label(new Rect(801f, (float)num, 862f, 513f), "Mouse X" + this.user.dropScrpt.fish.speed);
				num += 69;
				GUI.Label(new Rect(194f, (float)num, 307f, 1823f), "Mouse X" + this.user.dropScrpt.fish.toSpeed);
				num += 105;
				GUI.Label(new Rect(982f, (float)num, 978f, 1294f), "Shaders/EyeHistogram" + this.user.dropScrpt.fish.stamKf);
				num += -54;
				GUI.Label(new Rect(1110f, (float)num, 268f, 1368f), "move" + bgjkmcbhnak.HAEABJICCCP);
				num += -76;
				GUI.Label(new Rect(289f, (float)num, 1147f, 1341f), string.Format("FOVKick Increase curve is null, please define the curve for the field of view kicks", this.user.dropScrpt.fish.klevMode, this.user.dropScrpt.fish.toKlevMode));
				num += 75;
			}
			GUI.color = Color.white;
		}
	}

	// Token: 0x06006890 RID: 26768 RVA: 0x0030E8B4 File Offset: 0x0030CAB4
	public float getAnimForceState()
	{
		float num = Time.time - this.startAnimSpinTime;
		if (num > 1f)
		{
			return 0f;
		}
		if (this.user.CDNABIHPLHM)
		{
			return 0f;
		}
		if (!this.user.CIHILMCEJND)
		{
			return 0f;
		}
		if (this.user.dropScrpt == null)
		{
			return 0f;
		}
		if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG) < 0.001f)
		{
			return 0f;
		}
		float num2 = Mathf.Lerp(1f, 2f, BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.NKHBAJKMAGD / 20f);
		return this.addForceSpinningUpRod[this.animCurveID].Evaluate(num) * num2 * 10f;
	}

	// Token: 0x06006891 RID: 26769 RVA: 0x0030E97C File Offset: 0x0030CB7C
	public void openHotRod(int DHGDDBCCIOJ)
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		if (Fisherman.getI.MFENINHGBHM && DHGDDBCCIOJ == this.BCEGLBCCGEN)
		{
			Debug.Log("Close rod");
			Fisherman.getI.MFENINHGBHM = false;
			this.BCEGLBCCGEN = 0;
			return;
		}
		if (!Fisherman.getI.MFENINHGBHM)
		{
			this.openRod(DHGDDBCCIOJ);
		}
		this.BCEGLBCCGEN = DHGDDBCCIOJ;
		bool changeWork = DownPanelLogic.getI.changeWork;
	}

	// Token: 0x06006892 RID: 26770 RVA: 0x0030E9F0 File Offset: 0x0030CBF0
	public void HALCKEHLBLM(Vector3 NHCLMBOINFG)
	{
		if (Time.time - this.DHOIDINAIHA < 205f)
		{
			return;
		}
		if (this.waterCirclePrefab != null)
		{
			NHCLMBOINFG.y = this.OGJHINOLHJJ + 756f;
			GameObject gameObject = this.HBOLDAJOJOO(4, NHCLMBOINFG);
			gameObject.GetComponent<Renderer>() != null;
			gameObject.transform.localScale = new Vector3(316f, 577f, 593f);
			this.DHOIDINAIHA = Time.time;
		}
	}

	// Token: 0x06006893 RID: 26771 RVA: 0x0030EA70 File Offset: 0x0030CC70
	private IEnumerator INPIIDNILBP()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		yield return new WaitForSeconds(2f);
		if (this.isBase)
		{
			this.NNLDGOGODAK(null);
		}
		else
		{
			LocBaseManager.IKGFHGKKCPG.getLevel(this.baseid, new LocBaseManager.HHIFOAIHHNC(this.NNLDGOGODAK));
		}
		yield break;
	}

	// Token: 0x06006894 RID: 26772 RVA: 0x0030EA80 File Offset: 0x0030CC80
	public void ICBABCJLCLI(bool ECCECBJDEIF)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC = ECCECBJDEIF;
		HPGKIJLKCIH.IKGFHGKKCPG.NLOGADGCOGO();
		this.wcam.enabled = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		this.mouseLook.enabled = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num = this.wcam.currentDistance;
			if (num < 421f)
			{
				num = 408f;
			}
			HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN = num;
			HPGKIJLKCIH.IKGFHGKKCPG.FGJIMICPKNL = this.wcam.transform.position;
			HPGKIJLKCIH.IKGFHGKKCPG.JIJMJDDLMJC = this.wcam.transform.rotation;
			this.wcam.enabled = false;
			this.toFieldView = 1045f;
			if (this.user)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1216f;
				Camera.main.transform.position = this.toCamPos;
				Camera.main.fieldOfView = this.toFieldView;
				if (this.EMELPGGLMDM())
				{
					Camera.main.transform.LookAt(this.toCamLook);
				}
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.LCANAPDPIPP > 1620f)
			{
				this.zoom = HPGKIJLKCIH.IKGFHGKKCPG.LCANAPDPIPP;
				Camera.main.fieldOfView = HPGKIJLKCIH.IKGFHGKKCPG.EHNCFIPOPCK;
			}
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.LCANAPDPIPP = this.zoom;
			HPGKIJLKCIH.IKGFHGKKCPG.EHNCFIPOPCK = Camera.main.fieldOfView;
			if (HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN > 1298f)
			{
				this.wcam.distance = HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN;
				this.wcam.currentDistance = HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN;
				this.wcam.desiredDistance = HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN;
				this.wcam.transform.position = HPGKIJLKCIH.IKGFHGKKCPG.FGJIMICPKNL;
				this.wcam.transform.rotation = HPGKIJLKCIH.IKGFHGKKCPG.JIJMJDDLMJC;
				Camera.main.fieldOfView = 708f;
			}
			this.wcam.enabled = false;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.wcam.distance = 1007f;
			this.wcam.desiredDistance = 1030f;
			this.wcam.currentDistance = 1314f;
			this.wcam.enabled = false;
			this.mouseLook.enabled = true;
			this.mouseLook.isFreeze = !this.GAAPDLNHCDA();
		}
	}

	// Token: 0x06006895 RID: 26773 RVA: 0x0030ED71 File Offset: 0x0030CF71
	public void OEPAPLJEHPB(float DCCPCBLODIG)
	{
		this.minDistanceGO.transform.localScale = new Vector3(DCCPCBLODIG * 1128f, DCCPCBLODIG * 744f, DCCPCBLODIG * 781f);
	}

	// Token: 0x06006896 RID: 26774 RVA: 0x0030EDA0 File Offset: 0x0030CFA0
	private void PBAGIKEAENH()
	{
		Vector3 normalized = this.user.transform.forward.normalized;
		Vector3 position = this.dexCircleGO.transform.position;
		position.y = this.user.transform.position.y;
		Vector3 normalized2 = (position - this.user.transform.position).normalized;
		Vector2 vector = new Vector2(this.user.transform.position.x, this.user.transform.position.z);
		Vector2 vector2 = new Vector2(this.user.transform.position.x + normalized.x, this.user.transform.position.z + normalized.z);
		Vector2 vector3 = new Vector2(position.x, position.z);
		float num = (vector2.x - vector.x) * (vector3.y - vector.y) - (vector2.y - vector.y) * (vector3.x - vector.x);
		float num2 = Vector3.Angle(normalized, normalized2);
		this.nprCircleGO.transform.localRotation = Quaternion.Euler(330f, num2 * Mathf.Sign(-num), 1781f);
	}

	// Token: 0x06006897 RID: 26775 RVA: 0x0030EF08 File Offset: 0x0030D108
	public void podsekOkAction()
	{
		this.user.isPodsek = true;
		this.user.PodsekType = 2;
		this.user.CDNABIHPLHM = true;
		this.JCKKMKECMFA = 15f;
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB != null)
		{
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.IKGFHGKKCPG.BLJKHILCCDL(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
			float num = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD);
			if (num >= iibeekcaahk.JLLJFKOGLHJ && num <= iibeekcaahk.OBEOJCGHOGL)
			{
				this.JCKKMKECMFA = 5f;
			}
			if (num > iibeekcaahk.OBEOJCGHOGL)
			{
				this.JCKKMKECMFA = 15f + num / (iibeekcaahk.OBEOJCGHOGL + 0.1f) * 8f;
			}
		}
		this.user.podsek();
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM = true;
		float num2 = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD);
		this.closePoplCamera();
		this.NANKIDAJFJF = true;
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(num2 / (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 1000f + 0.01f), 0f, 0.5f) * 100f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(num2 / (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ * 1000f + 0.01f), 0f, 0.5f) * 100f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(0f);
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(0f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1125, "!");
	}

	// Token: 0x06006898 RID: 26776 RVA: 0x0030F100 File Offset: 0x0030D300
	public void EBICNBADKCD()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x17000179 RID: 377
	// (set) Token: 0x06006899 RID: 26777 RVA: 0x0030F12C File Offset: 0x0030D32C
	public float AMMHKJECEID
	{
		set
		{
			float num = value * 2f;
			float z = Mathf.Clamp(num, 1.5f, 3.5f);
			this.dexCircleGO.transform.localScale = new Vector3(num, num, z);
			this.dexLDObj.transform.position = this.dexCircleGO.transform.position;
			LineRenderer component = this.dexLDObj.GetComponent<LineRenderer>();
			if (component != null)
			{
				component.SetPosition(0, this.dexCircleGO.transform.position);
				Vector3 position = Fisherman.getI.transform.position;
				position.y = this.dexCircleGO.transform.position.y;
				component.SetPosition(1, position);
				component.startWidth = num * 0.9f;
				component.endWidth = 0.2f;
			}
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x0600689A RID: 26778 RVA: 0x0030F202 File Offset: 0x0030D402
	public float OGJHINOLHJJ
	{
		get
		{
			if (this.water != null)
			{
				return this.water.transform.position.y;
			}
			return 0f;
		}
	}

	// Token: 0x0600689B RID: 26779 RVA: 0x0030F230 File Offset: 0x0030D430
	public void OFDEDAMGDBB()
	{
		if (this.CNOLCNDBLJE == null)
		{
			return;
		}
		Debug.Log(" x");
		if (this.rollSound != null)
		{
			this.rollSound.clip = SoundSamplesStorage.getI.rollSounds[HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG];
		}
		Debug.Log("NadeThrow");
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().FAJIJEIJJJH(this.CNOLCNDBLJE, "wpn_add/base");
		if (gameObject != null)
		{
			WindZone component = gameObject.GetComponent<WindZone>();
			if (component != null)
			{
				component.windMain = 1457f;
			}
		}
		Debug.Log("Wait");
		Terrain terrain = UnityEngine.Object.FindObjectOfType<Terrain>();
		float num = 1243f;
		if (terrain != null)
		{
			terrain.heightmapPixelError = 786f;
			terrain.basemapDistance = Mathf.Clamp(1103f * num, 1515f, 1272f);
			terrain.treeDistance = 137f * num;
			terrain.treeBillboardDistance = 96f + 244f * num;
			terrain.treeMaximumFullLODCount = (int)(863f * num);
			terrain.detailObjectDistance = Mathf.Clamp(771f * num, 1164f, 1474f);
			terrain.detailObjectDensity = Mathf.Clamp(num, 1245f, 1781f);
			terrain.collectDetailPatches = true;
		}
		Debug.Log("useSrcAlphaAsMask");
		this.staticLight.gameObject.SetActive(true);
		this.dinamycLight.gameObject.SetActive(true);
		Debug.Log("TOD_kBetaMie");
		this.sd = this.CNOLCNDBLJE.GetComponent<SceneData>();
		if (this.sd != null)
		{
			TimeController.EPCKOOOGNGK().currentLUTBank = this.sd.lutIndex;
			base.StartCoroutine(this.NFBIPHFGDGF(this.sd));
			RenderSettings.fog = false;
			this.sd.getSpawnPoint(this.locid, this.pointid);
			GameObject[] array = GameObject.FindGameObjectsWithTag("Hyperlink_");
			if (array != null)
			{
				GameObject[] array2 = array;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].AddComponent<FishZone>();
				}
			}
			TimeController.EPCKOOOGNGK().lightKF = this.sd.lightKF;
			this.todSky.Day.LightIntensity = this.todSky.Day.LightIntensity * this.sd.lightKF;
			GradientColorKey[] colorKeys = this.todSky.Day.AmbientColor.colorKeys;
			for (int j = 0; j < colorKeys.Length; j += 0)
			{
				colorKeys[j].color = colorKeys[j].color * this.sd.lightKF;
			}
			this.todSky.Day.AmbientColor.SetKeys(colorKeys, this.todSky.Day.AmbientColor.alphaKeys);
			Debug.Log("_SpawnHeuristic");
			if (this.sd != null)
			{
				this.water = this.sd.water;
				if (this.water != null)
				{
					Debug.Log("http://www.root-motion.com/finalikdox/html/page3.html");
					SpecularLighting component2 = this.water.GetComponent<SpecularLighting>();
					if (component2 != null)
					{
						component2.specularLight = this.todSkySun;
					}
				}
			}
		}
		Debug.Log("inv_invheader");
		if (this.effector != null)
		{
			this.effector.CHLPELCJCAF();
		}
		Debug.Log("Turn");
	}

	// Token: 0x0600689C RID: 26780 RVA: 0x0030F5A0 File Offset: 0x0030D7A0
	public float getDeepInPointSM(Vector3 NHCLMBOINFG)
	{
		float deepInPoint = this.getDeepInPoint(NHCLMBOINFG);
		return (this.OGJHINOLHJJ - deepInPoint) * 100f;
	}

	// Token: 0x0600689D RID: 26781 RVA: 0x0030F5C4 File Offset: 0x0030D7C4
	public void MOIPGIMIJPK()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (!bgjkmcbhnak.IKKPFPJLPOL)
		{
			return;
		}
		if (ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.JDFKFMDPCDH) >= 1161f)
		{
			bgjkmcbhnak.IFNNBJDJBNA = Mathf.Lerp(bgjkmcbhnak.IFELKILNKFP(), ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.JDFKFMDPCDH), Time.deltaTime * 690f);
			if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && Mathf.RoundToInt(bgjkmcbhnak.IFNNBJDJBNA) != Mathf.RoundToInt(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JDFKFMDPCDH)) && this.ws.gameObject.activeSelf)
			{
				this.ws.HKJMHHOJNFE(846f, bgjkmcbhnak.KKLEBEEGGDG(), bgjkmcbhnak.IFNNBJDJBNA);
			}
		}
		bgjkmcbhnak.BBANBEEJAPD = false;
		float num = GuiProcessor.IKGFHGKKCPG.lineTensionCurve.Evaluate(bgjkmcbhnak.AEFAHEMNOCH / (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.CLAEAFMCDMP() * 1295f));
		float num2 = GuiProcessor.BBLINJLBAIL().rodTensionCurve.Evaluate(bgjkmcbhnak.AEFAHEMNOCH / (bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.CLAEAFMCDMP() * 463f));
		float num3 = OLPINJLCKCI.NPIEJELJPIM().GKDBPBFOINB(1312.0) - 772f;
		if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.GIMFIFECPGL) >= num2 * 1762f)
		{
			bgjkmcbhnak.BBANBEEJAPD = false;
			bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(num2 * 719f - num3);
			bgjkmcbhnak.LCKEJCDPBIO(ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.MPKJDFOMBLI()), 1446f, num2 * 1986f)));
		}
		if (ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.OGLIEFLNLLE) >= num * 1804f)
		{
			bgjkmcbhnak.BBANBEEJAPD = false;
			bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.AJMPAOCEPCA(num * 470f - num3);
			bgjkmcbhnak.BBMNOEDOFDJ(ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.OGLIEFLNLLE), 1230f, num * 1428f)));
		}
		if (bgjkmcbhnak.BBANBEEJAPD)
		{
			this.playLowFricSound(true);
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x0600689E RID: 26782 RVA: 0x0030F7BA File Offset: 0x0030D9BA
	public GameObject JDHBGNOOBHK
	{
		get
		{
			return this._poplCameraInst;
		}
	}

	// Token: 0x0600689F RID: 26783 RVA: 0x0030F7C4 File Offset: 0x0030D9C4
	private GameObject IGFNBPOFIOH(SpawnPoint JJNHJKFMFLJ)
	{
		if (JBEHMPDDMME.BOKIOJFHNLD().PEKHEALPHLD && ObscuredString.HDFJOKAGNJC(this.getSteamID(), JBEHMPDDMME.IKGFHGKKCPG.IDAGBNBFHAB))
		{
			Application.Quit();
		}
		string hojhbmnihba = "HeelClick";
		byte[] array = null;
		if (JBEHMPDDMME.PFOLNEGNIPP() != null && JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "Moon reference not set.";
			}
			array = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 jjnhjkfmflj = JJNHJKFMFLJ.transform.position;
		if (EDLNGHBMJBL.JMHOODFAGAM() != null && EDLNGHBMJBL.FEJILBICKGG().KFDGOOIPOFN() != null && EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA.NKHJGGDFJID.magnitude > 126f)
		{
			jjnhjkfmflj = EDLNGHBMJBL.FEJILBICKGG().JBANCCFMOCE().NKHJGGDFJID;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(hojhbmnihba, jjnhjkfmflj, null);
		gameObject.transform.position = JJNHJKFMFLJ.transform.position;
		gameObject.transform.rotation = JJNHJKFMFLJ.transform.rotation;
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE == EDLNGHBMJBL.IKGFHGKKCPG.CGDPJKBODBA().LLJPFPFPKKG)
		{
			Debug.Log("usrfrom_ignor" + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE);
		}
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			Character component = this.user.gameObject.GetComponent<Character>();
			if (component != null && array != null)
			{
				component.IIKNAKNILFF(array);
			}
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GIDJODKDJGD();
			this.user.ONDOHGBIDHO(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HHAHKJPGOLK);
		}
		object[] array2 = new object[7];
		array2[0] = " %\n";
		array2[1] = gameObject.transform.position;
		array2[3] = "1HandSwordChargeHeavyBash";
		array2[7] = JJNHJKFMFLJ.transform.position;
		Debug.Log(string.Concat(array2));
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		DownPanelLogic.getI.IBNDBFBPHMK();
		this.AHNFPBKGDPA(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL());
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.wcam != null)
		{
			this.wcam.enabled = true;
			this.mouseLook.enabled = false;
			this.wcam.currentDistance = 797f;
			this.wcam.desiredDistance = 694f;
			this.zoom = 244f;
		}
		return gameObject;
	}

	// Token: 0x060068A0 RID: 26784 RVA: 0x0030FA38 File Offset: 0x0030DC38
	public void NGPCFHKEOAI(float DCCPCBLODIG)
	{
		float num = DCCPCBLODIG * 1043f;
		float z = Mathf.Clamp(num, 148f, 906f);
		this.dexCircleGO.transform.localScale = new Vector3(num, num, z);
		this.dexLDObj.transform.position = this.dexCircleGO.transform.position;
		LineRenderer component = this.dexLDObj.GetComponent<LineRenderer>();
		if (component != null)
		{
			component.SetPosition(1, this.dexCircleGO.transform.position);
			Vector3 position = Fisherman.getI.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			component.SetPosition(1, position);
			component.startWidth = num * 1267f;
			component.endWidth = 858f;
		}
	}

	// Token: 0x060068A1 RID: 26785 RVA: 0x0030FB0E File Offset: 0x0030DD0E
	public float IGHOGONIKLC()
	{
		if (this.water != null)
		{
			return this.water.transform.position.y;
		}
		return 1845f;
	}

	// Token: 0x060068A2 RID: 26786 RVA: 0x0030FB3C File Offset: 0x0030DD3C
	public GameObject getWaterCircle(int DFBHMIIPLCA, Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = null;
		GameObject gameObject2 = null;
		Queue<GameObject> queue = null;
		switch (DFBHMIIPLCA)
		{
		case 0:
			gameObject2 = this.waterCircleSmallPrefab;
			queue = this.JMHOJPJONNJ;
			break;
		case 1:
			gameObject2 = this.waterCircleFishPrefab;
			queue = this.COOFLDJIDCK;
			break;
		case 2:
			gameObject2 = this.waterCirclePrefab;
			queue = this.FBCOEHFKIJI;
			break;
		}
		if (queue != null && queue.Count > 0)
		{
			gameObject = queue.Dequeue();
			WaterCircle component = gameObject.GetComponent<WaterCircle>();
			gameObject.transform.position = NHCLMBOINFG;
			if (component != null)
			{
				component.reStart();
			}
			return gameObject;
		}
		if (gameObject2 != null)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(gameObject2, NHCLMBOINFG, Quaternion.identity);
			gameObject.transform.parent = this.WaterCircleCatalog.transform;
		}
		return gameObject;
	}

	// Token: 0x060068A3 RID: 26787 RVA: 0x0030FBF8 File Offset: 0x0030DDF8
	public void dropAction(Vector3 DOFMILIDKGH)
	{
		if (!this.checkPosition(DOFMILIDKGH))
		{
			if (Application.isEditor)
			{
				Debug.Log("** dropAction checkPosition break");
			}
			return;
		}
		EKBAPCMPANI nkncnhgdmlf = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKNCNHGDMLF;
		if (nkncnhgdmlf == null)
		{
			return;
		}
		if ((float)nkncnhgdmlf.FJJEAMJNLIO >= JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PMOJDCHIAHE)
		{
			FlyMessageManager.getI.clearMessages();
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("ust_msg"), Color.red, 0, 0);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		int jgniddbnggp = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF();
		EKBAPCMPANI ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(jgniddbnggp, 20);
		if (num == 102 && ekbapcmpani == null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		this.toDropPoint = DOFMILIDKGH;
		this.lastPosition = this.toDropPoint;
		this.user.CIHILMCEJND = true;
		if (LineRope.getI != null)
		{
			LineRope.getI.reBuild(this.toDropPoint);
		}
		if (num == 100)
		{
			this.user.DropType = 0;
			if (this.getPointerDistance() > BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(1, nkncnhgdmlf.LODGJCMEGAI, 1))
			{
				this.user.DropType = 2;
			}
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak != null)
		{
			bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
			bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(0f);
			bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(0f);
			bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
		}
	}

	// Token: 0x060068A4 RID: 26788 RVA: 0x0030FD9C File Offset: 0x0030DF9C
	public GameObject NNDDPMJODPE(int DFBHMIIPLCA, Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = null;
		GameObject gameObject2 = null;
		Queue<GameObject> queue = null;
		switch (DFBHMIIPLCA)
		{
		case 0:
			gameObject2 = this.waterCircleSmallPrefab;
			queue = this.JMHOJPJONNJ;
			break;
		case 1:
			gameObject2 = this.waterCircleFishPrefab;
			queue = this.COOFLDJIDCK;
			break;
		case 2:
			gameObject2 = this.waterCirclePrefab;
			queue = this.FBCOEHFKIJI;
			break;
		}
		if (queue != null && queue.Count > 1)
		{
			gameObject = queue.Dequeue();
			WaterCircle component = gameObject.GetComponent<WaterCircle>();
			gameObject.transform.position = NHCLMBOINFG;
			if (component != null)
			{
				component.BFCCJCEFPGJ();
			}
			return gameObject;
		}
		if (gameObject2 != null)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(gameObject2, NHCLMBOINFG, Quaternion.identity);
			gameObject.transform.parent = this.WaterCircleCatalog.transform;
		}
		return gameObject;
	}

	// Token: 0x060068A5 RID: 26789 RVA: 0x0030FE58 File Offset: 0x0030E058
	public bool HCADFNPFDPG()
	{
		bool mouseButtonDown = Input.GetMouseButtonDown(0);
		if (ChatPanelLogic.getI.DGGGOGNMEJL())
		{
			return mouseButtonDown;
		}
		return mouseButtonDown | Input.GetKeyDown((KeyCode)(-99));
	}

	// Token: 0x060068A6 RID: 26790 RVA: 0x0030FE88 File Offset: 0x0030E088
	public void openSettings()
	{
		if (this.user == null)
		{
			return;
		}
		if (!this.user.MFENINHGBHM)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("human_move_2.wav", 1f);
		switch (bgjkmcbhnak.DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			this.ws.setParamsDeep(30f, bgjkmcbhnak.KFEPCNBDMIH, bgjkmcbhnak.IFNNBJDJBNA);
			this.ws.setParamsFric(0f, 21f, bgjkmcbhnak.CJLKGICPCAJ);
			this.ws.updatePosition();
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.ws.setParamsDeep(10f, 70f, bgjkmcbhnak.CLEJODCMJAA);
			this.ws.setParamsFric(0f, 21f, bgjkmcbhnak.CJLKGICPCAJ);
			this.ws.updatePosition();
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			this.ws.setParamsFric(0f, 21f, bgjkmcbhnak.CJLKGICPCAJ);
			this.ws.updatePosition();
			break;
		}
		this.ws.gameObject.SetActive(!this.ws.gameObject.activeSelf);
	}

	// Token: 0x060068A7 RID: 26791 RVA: 0x0030FFC3 File Offset: 0x0030E1C3
	private static bool FADEIIFNODD()
	{
		return !ChatPanelLogic.getI.isChatEnter() && !LocNewLogic.getI.GFWin.gameObject.activeSelf && (Input.GetKeyDown(KeyCode.T) || Input.GetMouseButtonDown(2));
	}

	// Token: 0x060068A8 RID: 26792 RVA: 0x0030FFFC File Offset: 0x0030E1FC
	public void FNAJBAKNKOO()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		PoplDrop dropScrpt = this.user.dropScrpt;
		if (dropScrpt == null)
		{
			return;
		}
		GameObject gameObject = dropScrpt.gameObject;
		if (dropScrpt.fish != null)
		{
			return;
		}
		dropScrpt.spinmode = 1;
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown((KeyCode)26))
		{
			this.ICNOLCEBBGI = Time.time;
		}
		if ((Input.GetMouseButtonUp(0) || Input.GetKeyUp((KeyCode)(-122))) && ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.BNKBCOAANNG) > 1298f && Time.time - this.startAnimSpinTime > 1458f && Time.time - this.ICNOLCEBBGI < 1122f)
		{
			int ilockjiapfc = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().AMLEOGHNNPG[1].BDHHPAEHFHG.ILOCKJIAPFC;
			this.startAnimSpinTime = Time.time;
			this.animCurveID = ilockjiapfc;
			dropScrpt.HDNFPHBIDOL(this.animCurveID);
		}
		if (this.FGGGOAHFNCD())
		{
			float num = 128f;
			bool key = Input.GetKey((KeyCode)(-143));
			float num2 = 1836f * num;
			float num3 = 1143f;
			if (key)
			{
				num2 *= 1692f;
			}
			float num4 = bgjkmcbhnak.CLEJODCMJAA / 1182f;
			if (Fisherman.getI.AEMBDHALFNG())
			{
				num4 = 1980f;
			}
			if (key)
			{
				num4 = 1635f;
			}
			float t = BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB.JKEBJEOECAI(Mathf.Clamp(bgjkmcbhnak.EDNAPPHHHPI(), 1281f, 173f));
			float num5 = Mathf.Lerp(num3, num2, t) * num4 * num;
			float num6 = num5 * 172f;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = bgjkmcbhnak;
			bgjkmcbhnak2.KIKADLMBJIA = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak2.KIKADLMBJIA) - bgjkmcbhnak.AAGGJACBMEC * Time.deltaTime);
			if (bgjkmcbhnak.BBANBEEJAPD)
			{
				num6 = 660f;
				num5 = num3;
			}
			if (ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.DNPDBOODCHK) <= 1165f)
			{
				num6 = 759f;
				num5 = num3;
			}
			if (num6 > 1907f)
			{
				dropScrpt.rolltime += Time.deltaTime;
			}
			bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DNPDBOODCHK) - num6 * Time.deltaTime);
			if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DNPDBOODCHK) < 1071f)
			{
				bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.AJMPAOCEPCA(975f);
			}
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime += Time.deltaTime * num5 * 838f;
			this.playRollSound(num5, 542f);
			if (!this.checkKeyRod())
			{
				bgjkmcbhnak.LGALGHAPJND += bgjkmcbhnak.HNEEGDNEDHJ * 672f * Time.deltaTime;
			}
		}
		else
		{
			this.stopRollSound();
			dropScrpt.rolltime = 1595f;
		}
		this.lineTensionLogic();
		bgjkmcbhnak.AAINFMALAEN(ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.GIMGAKKKHLF), 182f, 1709f)));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.EALPPCJHPKG), 810f, 1489f));
		bgjkmcbhnak.CDBLOADCDAA(ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.OGLIEFLNLLE), 1256f, 1855f)));
		bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.MPKJDFOMBLI()), 1350f, 702f));
		bgjkmcbhnak.KIKADLMBJIA = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.KIKADLMBJIA), 283f, 97f));
		if (dropScrpt.mode == 0)
		{
			dropScrpt.spinmode = 1;
			bgjkmcbhnak.NKHBAJKMAGD = ObscuredFloat.AJMPAOCEPCA(bgjkmcbhnak.AMLEOGHNNPG[0].NKHBAJKMAGD);
			float num7 = Vector3.Distance(dropScrpt.transform.position, Fisherman.getI.AOEGNGOGNBI.endPointNonBend.transform.position) + 186f;
			bgjkmcbhnak.DLFMEIIADFE = ObscuredFloat.HLEMAJBAAEO((num7 - this.GPBFJBKCOKJ) / Time.deltaTime);
			this.GPBFJBKCOKJ = num7;
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(num7 - ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DNPDBOODCHK));
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG), 1353f, 138f));
			if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.BNKBCOAANNG) > 746f)
			{
				dropScrpt.spinmode = 7;
				this.toBaitSpinSpeed = 372f;
			}
			Vector3 endPointVector = this.user.EACGPPOMFLH().ILCJJKCPBKC;
			Vector3 position = gameObject.transform.position;
			endPointVector.y = this.IGHOGONIKLC();
			position.y = this.OGJHINOLHJJ;
			if (Vector3.Distance(endPointVector, position) < 1936f)
			{
				this.user.CIHILMCEJND = false;
				return;
			}
		}
		else
		{
			this.toBaitSpinSpeed = 1628f;
			this.baitSpinSpeed = 1836f;
		}
	}

	// Token: 0x060068A9 RID: 26793 RVA: 0x003104B8 File Offset: 0x0030E6B8
	public float ICDLJOAIOHG()
	{
		float num = Time.time - this.startAnimSpinTime;
		if (num > 1307f)
		{
			return 726f;
		}
		if (this.user.AEMBDHALFNG())
		{
			return 1105f;
		}
		if (!this.user.KNMMOLKNLNL())
		{
			return 1597f;
		}
		if (this.user.dropScrpt == null)
		{
			return 477f;
		}
		if (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BNKBCOAANNG) < 1090f)
		{
			return 1524f;
		}
		float num2 = Mathf.Lerp(1991f, 1870f, BOIKJDICEMF.IKGFHGKKCPG.KBNMKAMMOKM().NKHBAJKMAGD / 1078f);
		return this.addForceSpinningUpRod[this.animCurveID].Evaluate(num) * num2 * 396f;
	}

	// Token: 0x060068AA RID: 26794 RVA: 0x00310580 File Offset: 0x0030E780
	public bool PAPBFCANMFA()
	{
		bool flag = Input.GetMouseButtonDown(0) & JDCEFOFMGHB.HMJJPNDEKPP().NKJEEHEODBF();
		if (ChatPanelLogic.getI.isChatEnter())
		{
			return flag;
		}
		return flag | Input.GetKeyDown(KeyCode.U);
	}

	// Token: 0x060068AB RID: 26795 RVA: 0x003105BC File Offset: 0x0030E7BC
	public List<LocNewLogic.OMHDHFKKIIL> getDeepCircle(Vector3 PNNFJEMKLGH, float EHIKLLJBKHF)
	{
		List<LocNewLogic.OMHDHFKKIIL> list = new List<LocNewLogic.OMHDHFKKIIL>();
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != j || i != 0)
				{
					Vector3 pnnfjemklgh = new Vector3(PNNFJEMKLGH.x + (float)i * EHIKLLJBKHF, this.OGJHINOLHJJ - 0.01f, PNNFJEMKLGH.z + (float)j * EHIKLLJBKHF);
					LocNewLogic.OMHDHFKKIIL item = this.JDKJONHLLBE(pnnfjemklgh);
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x060068AC RID: 26796 RVA: 0x0031062C File Offset: 0x0030E82C
	public void AGDBNHCPFHK(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.EBICNBADKCD();
			return;
		}
		bool flag = false;
		switch (JLJJKMLJBAK.DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			this.wpnCells[0].weapon = JLJJKMLJBAK.PFNCHEEEBKD;
			this.wpnCells[1].weapon = JLJJKMLJBAK.CBLCFLENIJL[1];
			this.wpnCells[8].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[8].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[6].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[5].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[5].weapon = JLJJKMLJBAK.CKBGHMMOAEM;
			flag = true;
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.wpnCells[0].weapon = null;
			this.wpnCells[2].weapon = JLJJKMLJBAK.PFNCHEEEBKD;
			this.wpnCells[6].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[1].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[7].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[4].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[2].weapon = null;
			flag = true;
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			this.wpnCells[0].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[6].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[4].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[0].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[5].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[5].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[6].weapon = JLJJKMLJBAK.CKBGHMMOAEM;
			flag = true;
			break;
		}
		if (flag)
		{
			this.EBICNBADKCD();
		}
	}

	// Token: 0x060068AD RID: 26797 RVA: 0x00310810 File Offset: 0x0030EA10
	private void IEOHNFKDABK()
	{
		Vector3 normalized = this.user.transform.forward.normalized;
		Vector3 position = this.dexCircleGO.transform.position;
		position.y = this.user.transform.position.y;
		Vector3 normalized2 = (position - this.user.transform.position).normalized;
		Vector2 vector = new Vector2(this.user.transform.position.x, this.user.transform.position.z);
		Vector2 vector2 = new Vector2(this.user.transform.position.x + normalized.x, this.user.transform.position.z + normalized.z);
		Vector2 vector3 = new Vector2(position.x, position.z);
		float num = (vector2.x - vector.x) * (vector3.y - vector.y) - (vector2.y - vector.y) * (vector3.x - vector.x);
		float num2 = Vector3.Angle(normalized, normalized2);
		this.nprCircleGO.transform.localRotation = Quaternion.Euler(579f, num2 * Mathf.Sign(-num), 378f);
	}

	// Token: 0x060068AE RID: 26798 RVA: 0x00310977 File Offset: 0x0030EB77
	private void OnDestroy()
	{
		if (this.user != null)
		{
			UnityEngine.Object.Destroy(this.user.gameObject);
		}
		Debug.Log("OnDestroy");
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	// Token: 0x060068AF RID: 26799 RVA: 0x003109B0 File Offset: 0x0030EBB0
	public void openPrikormWindow()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(0);
			epmphjgalbe.GOMLLPFFPNP(9);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1700, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x060068B0 RID: 26800 RVA: 0x00310A0C File Offset: 0x0030EC0C
	private IEnumerator AJEAGEJBDNM()
	{
		LocNewLogic.DGDDHKIOJBA dgddhkiojba = new LocNewLogic.DGDDHKIOJBA(1);
		dgddhkiojba.AENJLLPLILM = this;
		return dgddhkiojba;
	}

	// Token: 0x060068B1 RID: 26801 RVA: 0x00310A1C File Offset: 0x0030EC1C
	private void OnGUI()
	{
		if (this.timeLabel != null)
		{
			this.timeLabel.text = DateTime.Now.ToString("HH:mm");
		}
		if (!this.isLevelLoadProcess && GameInterface.getI.currentTurnir != null)
		{
			Rect position = new Rect(10f, 155f, 80f, 40f);
			Rect position2 = new Rect(position.x - 2f, position.y - 2f, position.width + 4f, position.height + 4f);
			if (GameInterface.getI.currentTurnir.turnimage != null)
			{
				if (GUI.Button(position, GUIContent.none) && Time.time - this.wtime > 3f)
				{
					Debug.Log("Open turnir info window");
					if (GameInterface.getI.currentTurnir.state == 2)
					{
						GHMGDBLLEAG.IKGFHGKKCPG.JDPEDEKFEGE();
					}
					else
					{
						Debug.Log("Open tinfo");
						GHMGDBLLEAG.IKGFHGKKCPG.AIOPMEMEBHI(GameInterface.getI.currentTurnir);
					}
					this.wtime = Time.time;
				}
				GUI.color = new Color(1f, 1f, 1f, 1f);
				if (GameInterface.getI.currentTurnir.state != 2)
				{
					GUI.color = new Color(0.5f, 0.5f, 0.5f, 1f);
				}
				GUI.DrawTexture(position2, GameInterface.getI.borderBy, ScaleMode.StretchToFill);
				GUI.DrawTexture(position, GameInterface.getI.currentTurnir.turnimage.KEDGAOBCNJG, ScaleMode.StretchToFill);
				GUI.color = new Color(1f, 1f, 1f, 1f);
				GUIStyle ofpnedeamab = new GUIStyle
				{
					normal = 
					{
						textColor = Color.gray
					},
					alignment = TextAnchor.UpperLeft,
					fontSize = 12,
					wordWrap = true,
					richText = true
				};
				TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
				if (GameInterface.getI.currentTurnir.state == 0)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.regTime - DateTime.Now;
				}
				if (GameInterface.getI.currentTurnir.state == 1)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.startTime - DateTime.Now;
				}
				if (GameInterface.getI.currentTurnir.state == 2)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.endTime - DateTime.Now;
				}
				string fpihopocaha = JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk);
				JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(position.x, position.y + 46f, 200f, 22f), fpihopocaha, ofpnedeamab);
				GUI.color = new Color(1f, 1f, 1f, 1f);
				if (position.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
				{
					JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
				}
			}
		}
		if (Application.isEditor && this.user != null && this.user.dropScrpt && this.OGBHPFEEJJH)
		{
			int num = 240;
			if (this.PEFPELGDHPK)
			{
				GUI.color = Color.black;
			}
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "wgt=" + bgjkmcbhnak.NKHBAJKMAGD);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "fishFACTROR=" + bgjkmcbhnak.CKJOFDPBFMC);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "lineDistance=" + bgjkmcbhnak.DNPDBOODCHK);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "lineOverDistanc=" + bgjkmcbhnak.DJOHGAHBGLG);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "Bait VELO=" + bgjkmcbhnak.HDFFLMCFGOG);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "ANGLE=" + bgjkmcbhnak.NKEGFIJJKIG);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "ALP=" + this.alp);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "lineTENSIONKG=" + bgjkmcbhnak.PPMKELOFPAJ);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "lineTENSIONKGFRIC=" + bgjkmcbhnak.JBLKFABJAMA);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "rollTENSION=" + bgjkmcbhnak.AIHLOMHODIB);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "rollTENSIONKG=" + bgjkmcbhnak.GAKPODHCHNB);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "fishRSPEED=" + bgjkmcbhnak.OCBJPGOKFOI);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "fishSTOPTMR=" + bgjkmcbhnak.NOHFLPHECOA);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "rodUpDelta=" + bgjkmcbhnak.LEMPPBMEJHP);
			num += 20;
			GUI.Label(new Rect(10f, (float)num, 700f, 20f), "rodDwDelta=" + bgjkmcbhnak.LJNDGALCAKL);
			num += 20;
			if (this.user.dropScrpt.fish != null)
			{
				GUI.Label(new Rect(10f, (float)num, 700f, 20f), "fishSPEED=" + this.user.dropScrpt.fish.speed);
				num += 20;
				GUI.Label(new Rect(10f, (float)num, 700f, 20f), "fishToSPEED=" + this.user.dropScrpt.fish.toSpeed);
				num += 20;
				GUI.Label(new Rect(10f, (float)num, 700f, 20f), "fishStamKF=" + this.user.dropScrpt.fish.stamKf);
				num += 20;
				GUI.Label(new Rect(10f, (float)num, 700f, 20f), "userForceMagnitude=" + bgjkmcbhnak.HAEABJICCCP);
				num += 20;
				GUI.Label(new Rect(10f, (float)num, 700f, 20f), string.Format("KA: {0}->{1}", this.user.dropScrpt.fish.klevMode, this.user.dropScrpt.fish.toKlevMode));
				num += 20;
			}
			GUI.color = Color.white;
		}
	}

	// Token: 0x060068B2 RID: 26802 RVA: 0x00311270 File Offset: 0x0030F470
	private void LPGBCHGEMIA(bool KLOLLKKIDJC = true)
	{
		if (!JDCEFOFMGHB.JFIDAGABKID().GMCOPAMLIPL)
		{
			if (this.user && this.user.MFENINHGBHM)
			{
				if (!this.user.CIHILMCEJND)
				{
					if (Input.GetMouseButtonUp(0))
					{
						if (Application.isEditor)
						{
							if (this.KOEHHGHGFEK)
							{
								Debug.Log("Office");
							}
							if (this.user.standFlag)
							{
								Debug.Log("WeaponStrafeRunLeft");
							}
							if (this.checkMousePosition())
							{
								Debug.Log("_LumTex");
							}
						}
						if (this.KOEHHGHGFEK && this.user.standFlag && this.checkMousePosition())
						{
							Vector3 position = this.dexCircleGO.transform.position;
							position.y = this.OGJHINOLHJJ;
							this.dropAction(position);
						}
					}
					if (Input.GetMouseButton(1) && this.KOEHHGHGFEK)
					{
						if (this.user != null)
						{
							if (this.user.standFlag)
							{
								this.circles.SetActive(true);
							}
							this.user.LGAHCAIKGHN(this.dexCircleGO.transform.position + Vector3.up * 1532f);
						}
					}
					else
					{
						this.circles.SetActive(false);
						this.user.cursorPoint = Vector3.zero;
						if (this.user != null)
						{
							this.user.NLLFPLBFFAE();
						}
					}
				}
				else
				{
					this.circles.SetActive(false);
					this.user.cursorPoint = Vector3.zero;
					if (KLOLLKKIDJC)
					{
						this.RodInWaterLogic();
					}
				}
			}
			else
			{
				this.circles.SetActive(true);
				this.user.cursorPoint = Vector3.zero;
			}
		}
		if (!Input.GetMouseButton(0))
		{
			this.circles.SetActive(true);
		}
		float num = this.IEPIKEGEADO();
		this.AMMHKJECEID = BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(num);
		this.dexCircleGO.gameObject.SetActive(num > BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP());
		this.dexLDObj.SetActive(this.circles.activeSelf);
		Color faodpfdpclh = this.AHDILEICFMM(Input.mousePosition) ? this.okZabros : this.noZabros;
		JLFJEGIPIMM.IKGFHGKKCPG.FAKEIBOBCGO(this.dexCircleGO.gameObject, "_Intensity", faodpfdpclh);
		if (this.user != null)
		{
			Vector3 position2 = this.user.transform.position;
			position2.y = this.OGJHINOLHJJ + 831f;
			this.circles.transform.position = position2;
			this.circles.transform.rotation = this.user.transform.rotation;
			this.MHHOOOEJGFM = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP();
			this.OEPAPLJEHPB(BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL);
			Vector2 v = Input.mousePosition;
			if (!this.GAAPDLNHCDA())
			{
				v = new Vector2((float)Screen.width / 1113f, (float)Screen.height / 812f);
			}
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 94f, this.waterCheckRay))
			{
				Vector3 point = raycastHit.point;
				point.y = this.HKBNODJBGEL() + 188f;
				this.calculateTerrainSpecies((this.user.dropScrpt == null) ? point : this.user.dropScrpt.transform.position);
				this.dexCircleGO.transform.position = point;
				this.IEOHNFKDABK();
			}
		}
		if (Input.GetMouseButtonUp(1))
		{
			this.KOEHHGHGFEK = false;
		}
	}

	// Token: 0x060068B3 RID: 26803 RVA: 0x00311624 File Offset: 0x0030F824
	public float NEPOFBNILML(Vector3 NHCLMBOINFG)
	{
		float deepInPoint = this.getDeepInPoint(NHCLMBOINFG);
		return (this.HKBNODJBGEL() - deepInPoint) * 265f;
	}

	// Token: 0x060068B4 RID: 26804 RVA: 0x00311648 File Offset: 0x0030F848
	public void userStaySpinnigLogic(bool LGCOIDHAHKD)
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (this.user.dropScrpt != null)
		{
			if (this.checkKeyRod())
			{
				bgjkmcbhnak.LGALGHAPJND -= Time.deltaTime * 200f;
				this.rodUpMove = true;
			}
			else
			{
				bgjkmcbhnak.LGALGHAPJND += Time.deltaTime * 200f;
				this.rodUpMove = false;
			}
			bgjkmcbhnak.LGALGHAPJND = Mathf.Clamp(bgjkmcbhnak.LGALGHAPJND, 0f, 100f);
			if (!this.user.CMCPFNJIIHK)
			{
				this.user.dropScrpt.transform.position.y = this.user.transform.position.y;
				Vector3 to = this.user.dropScrpt.transform.position - this.user.transform.position;
				if (to.magnitude > 5f)
				{
					Vector3.Angle(this.user.transform.forward, to);
				}
			}
		}
		if (this.user && this.user.MFENINHGBHM && LocNewLogic.FADEIIFNODD())
		{
			if (this.user.CIHILMCEJND)
			{
				this.user.CIHILMCEJND = false;
				return;
			}
			if (!this.user.CIHILMCEJND && this.user.standFlag)
			{
				this.dexCircleGO.transform.position = this.lastPosition;
				if (this.lastPosition.magnitude > 0.1f && this.checkPosition(this.lastPosition))
				{
					this.dropAction(this.lastPosition);
					return;
				}
			}
		}
		if (!this.user.CIHILMCEJND && Input.GetMouseButtonDown(0) && !JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			this.KOEHHGHGFEK = true;
		}
		this.EKMGJGNMCOA(false);
	}

	// Token: 0x060068B5 RID: 26805 RVA: 0x00311850 File Offset: 0x0030FA50
	public ObscuredString getSteamID()
	{
		string dccpcblodig = "";
		if (SteamManager.FPAKOLIPIND)
		{
			dccpcblodig = SteamUser.GetSteamID().ToString();
		}
		return ObscuredString.GOOIABGKMHK(dccpcblodig);
	}

	// Token: 0x060068B6 RID: 26806 RVA: 0x00311884 File Offset: 0x0030FA84
	private IEnumerator NFBIPHFGDGF(SceneData FENIGMBIDGD)
	{
		RenderSettings.fog = false;
		yield return new WaitForSeconds(0.2f);
		int num;
		for (int i = 0; i < 3; i = num + 1)
		{
			RenderSettings.fog = true;
			yield return new WaitForSeconds(0.1f);
			num = i;
		}
		yield break;
	}

	// Token: 0x060068B7 RID: 26807 RVA: 0x0031188C File Offset: 0x0030FA8C
	public bool JAGDAFDFNCP()
	{
		Vector2 v = Input.mousePosition;
		if (!this.EMELPGGLMDM())
		{
			v = new Vector2((float)Screen.width / 665f, (float)Screen.height / 1836f);
		}
		RaycastHit raycastHit;
		return !Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 933f, this.waterCheckRay) || raycastHit.collider.tag != "http://www.root-motion.com/finalikdox/html/page10.html" || this.checkPosition(raycastHit.point);
	}

	// Token: 0x060068B8 RID: 26808 RVA: 0x00311920 File Offset: 0x0030FB20
	private GameObject GNADNACKNNF(SpawnPoint JJNHJKFMFLJ)
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD && ObscuredString.AOHNEBPMOEK(this.getSteamID(), JBEHMPDDMME.BOKIOJFHNLD().IDAGBNBFHAB))
		{
			Application.Quit();
		}
		string hojhbmnihba = "WateringCan";
		byte[] array = null;
		if (JBEHMPDDMME.PLGADNLAEGN() != null && JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GDJMBFGEMFJ == 0)
			{
				hojhbmnihba = "";
			}
			array = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 jjnhjkfmflj = JJNHJKFMFLJ.transform.position;
		if (EDLNGHBMJBL.JMHOODFAGAM() != null && EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA != null && EDLNGHBMJBL.JMHOODFAGAM().CGDPJKBODBA().NKHJGGDFJID.magnitude > 840f)
		{
			jjnhjkfmflj = EDLNGHBMJBL.IKGFHGKKCPG.KFDGOOIPOFN().NKHJGGDFJID;
		}
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().DAJFMBBDJIC(hojhbmnihba, jjnhjkfmflj, null);
		gameObject.transform.position = JJNHJKFMFLJ.transform.position;
		gameObject.transform.rotation = JJNHJKFMFLJ.transform.rotation;
		if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == EDLNGHBMJBL.IKGFHGKKCPG.KFDGOOIPOFN().LLJPFPFPKKG)
		{
			Debug.Log("takeToFrend" + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE);
		}
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			Character component = this.user.gameObject.GetComponent<Character>();
			if (component != null && array != null)
			{
				component.BOOCBLKDAPP(array);
			}
			JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GIDJODKDJGD();
			this.user.EDCNMAAMCAB(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HHAHKJPGOLK);
		}
		object[] array2 = new object[6];
		array2[0] = "_CoCTex";
		array2[0] = gameObject.transform.position;
		array2[8] = "\n";
		array2[3] = JJNHJKFMFLJ.transform.position;
		Debug.Log(string.Concat(array2));
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		DownPanelLogic.getI.setSnastImages();
		this.AHNFPBKGDPA(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL());
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.wcam != null)
		{
			this.wcam.enabled = false;
			this.mouseLook.enabled = false;
			this.wcam.currentDistance = 1844f;
			this.wcam.desiredDistance = 729f;
			this.zoom = 610f;
		}
		return gameObject;
	}

	// Token: 0x060068B9 RID: 26809 RVA: 0x00311B94 File Offset: 0x0030FD94
	public void AELNCKAKNLM(int NHOGJBABJKN)
	{
		if (this.sonar != null)
		{
			UnityEngine.Object.Destroy(this.sonar);
			this.sonar = null;
			return;
		}
		EKBAPCMPANI ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.KIFEKEONBOL(97, 5);
		if (ekbapcmpani == null)
		{
			if (NHOGJBABJKN > 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("NprPhysPoint", 429f);
			}
			return;
		}
		this.sonar = JLFJEGIPIMM.PKGMBFEMKGP().IKBFBDCNOCH("</color>" + ekbapcmpani.HHOLFABGDJA);
		if (NHOGJBABJKN > 1)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Open tinfo", 1323f);
		}
	}

	// Token: 0x060068BA RID: 26810 RVA: 0x00311C2C File Offset: 0x0030FE2C
	public void BEHGLKFJLPM()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (!bgjkmcbhnak.IKKPFPJLPOL)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		float num = 1790f;
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null)
		{
			num = ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.CKJOFDPBFMC);
		}
		if (bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC < 1171f && this.user.CDNABIHPLHM)
		{
			float num2 = Mathf.Abs(bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC) * bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.OAAKPMLGJJH() * 735f;
			if (num2 > ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) / 1392f)
			{
				num2 = ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.CKJOFDPBFMC) / 747f;
			}
			num -= num2;
		}
		float num3 = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 420f;
		float num4 = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.ELBKLOECINC) / 1212f;
		bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.HLEMAJBAAEO(248f);
		bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.GOOIABGKMHK(1133f);
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) > 1437f)
		{
			float num5 = ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.DNPDBOODCHK);
			num5 = Mathf.Clamp(num5, 1269f, 1835f);
			bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK((num5 + ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) * 1097f) / num5 - 1527f);
			bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.BNKBCOAANNG), 191f, 221f));
		}
		this.alp = 1784f;
		bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.HLEMAJBAAEO(1981f);
		float num6 = 919f;
		if (this.user.dropScrpt != null)
		{
			Vector3 vector = this.user.IJMGCKIOBPP().transform.forward * this.user.AOEGNGOGNBI.actualRodLength;
			Vector3 to = this.user.IJMGCKIOBPP().transform.position + vector - this.user.dropScrpt.transform.position;
			this.alp = Mathf.Abs(Mathf.Sin(Vector3.Angle(vector, to) * 380f / 427f));
			vector.y = 1817f;
			to.y = 21f;
			bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(Vector3.Angle(-vector, to));
			if ((this.user.transform.position - this.user.dropScrpt.transform.position).magnitude < 1946f)
			{
				bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NKEGFIJJKIG), 238f, 863f));
			}
			if (!this.user.JIBGPKCOLML())
			{
				bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NKEGFIJJKIG), 1761f, 679f));
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG) > 1695f)
			{
				this.alp = 264f;
				num6 = 1948f + (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKEGFIJJKIG) - 1882f) / 1697f;
			}
		}
		bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(Mathf.LerpUnclamped(564f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.PHLLHDNNOMB(), ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.BNKBCOAANNG) / (348f + bgjkmcbhnak.MADFPIIFGEA())));
		if (this.user.JIBGPKCOLML() && ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) > 949f && ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.PPMKELOFPAJ) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 901f)
		{
			bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ) + ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) / 1488f);
		}
		float num7 = Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) / num6, 1744f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.EIHMJDCOOCC() * 1310f);
		if (num7 < ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LODEKEHKOKP))
		{
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.GOOIABGKMHK(num7);
		}
		else
		{
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.GOOIABGKMHK(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LODEKEHKOKP), num7, bgjkmcbhnak.EFEJJFGGMOF));
		}
		if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.DJOHGAHBGLG) < 1401f)
		{
			if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NKHBAJKMAGD) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.PHLLHDNNOMB() * 401f)
			{
				bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.GOOIABGKMHK(312f + Mathf.Max(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) / 374f * 512f, ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) * 225f));
				bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ), 1998f, ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NOMLJIMHFIL)));
			}
			else if (ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.NKHBAJKMAGD) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.NAHLEJDLCNF() * 447f)
			{
				bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.AJMPAOCEPCA(1591f * ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.NKHBAJKMAGD) / 370f + ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.CKJOFDPBFMC) * 988f);
				bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.PPMKELOFPAJ), 1224f, ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.NOMLJIMHFIL)));
			}
		}
		float num8 = Mathf.Lerp(1767f, 825f, 625f - this.alp);
		float num9 = Mathf.Lerp(1972f, 1149f, this.alp);
		float num10 = num8 * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) / bgjkmcbhnak.IIOHPBENEFI.MIMANMPNLPE.FDCKJDDOJPB();
		float num11 = num9 * ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ) / bgjkmcbhnak.NKNCNHGDMLF.EMBKDHKGIEL().EIHMJDCOOCC();
		bgjkmcbhnak.JBLKFABJAMA = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ) * num8);
		bgjkmcbhnak.DMEINKBOACF = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) * num9);
		if (bgjkmcbhnak.BBANBEEJAPD)
		{
			bgjkmcbhnak.JBLKFABJAMA = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.JBLKFABJAMA), 788f, bgjkmcbhnak.KDHENOMNPHK));
			bgjkmcbhnak.DMEINKBOACF = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.DMEINKBOACF), 1154f, bgjkmcbhnak.KDHENOMNPHK));
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.LODEKEHKOKP), 1884f, bgjkmcbhnak.PFDMMPFBCJA()));
		}
		this.torodproc = ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.EALPPCJHPKG);
		if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.BNKBCOAANNG) > 658f)
		{
			if (!this.user.AEMBDHALFNG())
			{
				bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.HLEMAJBAAEO(CurvesCntr.getI.lineTensionBait.Evaluate(Mathf.Max(533f, num10 * 552f) / 868f) * 1489f);
				bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.AJMPAOCEPCA(CurvesCntr.getI.lineTensionBait.Evaluate(Mathf.Max(1386f, num11 * 137f) / 532f) * 1178f);
			}
			else
			{
				bgjkmcbhnak.MIHODKKEDMK(ObscuredFloat.GOOIABGKMHK(GuiProcessor.NKOEAPCIBKO().lineTensionCurve.Evaluate(Mathf.Max(1241f, num10 * 1319f) / 296f) * 237f));
				bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(num6 * GuiProcessor.BBLINJLBAIL().rodTensionCurve.Evaluate(Mathf.Max(1609f, num11 * 979f) / 26f) * 1504f);
			}
		}
		else
		{
			bgjkmcbhnak.MIHODKKEDMK(ObscuredFloat.HLEMAJBAAEO(1647f));
			bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(1434f);
		}
		float num12 = 12f;
		float mfmlchfnalc = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC;
		if (mfmlchfnalc > 864f)
		{
			num12 = 1314f;
		}
		num12 = Mathf.Clamp(num12, 1087f, 1325f);
		float num13 = 1276f + Mathf.Clamp(723f - bgjkmcbhnak.LGALGHAPJND, 115f, 872f) * 1938f;
		float num14 = 375f - Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.LJNDGALCAKL), 1799f, 112f) / 334f;
		float num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH;
		if (mfmlchfnalc > 1860f)
		{
			num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH * 651f;
		}
		if (mfmlchfnalc < 868f)
		{
			num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH * 1848f;
		}
		float num16 = num13 * num14 * num12 * ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.JBLKFABJAMA) / (bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.CLAEAFMCDMP() * 1444f + 885f + num15);
		if (this.user.CDNABIHPLHM)
		{
			num16 = GuiProcessor.NKOEAPCIBKO().reelTnsTensionCurve.Evaluate(num16);
		}
		bgjkmcbhnak.JFGJKGJODEG(num16);
		bgjkmcbhnak.AIHLOMHODIB = ObscuredFloat.AJMPAOCEPCA(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.AIHLOMHODIB), bgjkmcbhnak.EDNAPPHHHPI(), Time.deltaTime * 1125f));
		bgjkmcbhnak.GAKPODHCHNB = ObscuredFloat.HLEMAJBAAEO(bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.JLLJFKOGLHJ * bgjkmcbhnak.EDNAPPHHHPI());
	}

	// Token: 0x060068BB RID: 26811 RVA: 0x003125C0 File Offset: 0x003107C0
	public void GGFKGJACBPM(float MMJELGIIKMO, float HMJNNIOPOMB)
	{
		if (MMJELGIIKMO <= 1677f)
		{
			this.stopRollSound();
			return;
		}
		float volume = 514f;
		if (HMJNNIOPOMB > 218f)
		{
			float t = (HMJNNIOPOMB - 24f) * 1147f;
			volume = Mathf.Lerp(1596f, HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK, t);
		}
		this.rollSound.pitch = 891f + (HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH - 870f) * 0f + 1053f * MMJELGIIKMO;
		this.rollSound.volume = volume;
		this.lowRollSound.volume = 113f * HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
		this.lowRollSound.pitch = 1955f + 1350f * MMJELGIIKMO;
		if (!this.lowRollSound.isPlaying)
		{
			this.lowRollSound.Play();
		}
		if (!this.rollSound.isPlaying)
		{
			this.rollSound.time = OLPINJLCKCI.NPIEJELJPIM().JJKCBOPPOHJ((double)this.rollSound.clip.length);
			this.rollSound.Play();
		}
	}

	// Token: 0x060068BC RID: 26812 RVA: 0x003126DC File Offset: 0x003108DC
	private void OFPGMNGFLNH()
	{
		BOIKJDICEMF.IKGFHGKKCPG.MKOJMJKKEBE();
		this.WLighterProcess();
		if (!Input.GetMouseButton(0))
		{
			this.circles.SetActive(false);
		}
		this.toBaitSpinSpeed = 898f;
		if (Application.isEditor)
		{
			if (Input.GetKeyDown((KeyCode)197))
			{
				this.PEFPELGDHPK = this.PEFPELGDHPK;
			}
			if (Input.GetKeyDown((KeyCode)66))
			{
				this.OGBHPFEEJJH = this.OGBHPFEEJJH;
			}
			if (Input.GetKeyDown(KeyCode.Delete))
			{
				this.isDebugMode = !this.isDebugMode;
			}
		}
		this.toCamLookObject.SetActive(this.isDebugMode);
		if (Fisherman.getI != null && DownPanelLogic.getI != null && ChatPanelLogic.getI != null && !ChatPanelLogic.getI.DJEPDONBBIM())
		{
			if (Input.GetKeyDown(KeyCode.Comma))
			{
				if (this.user.MFENINHGBHM)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ() == 0)
					{
						this.user.MFENINHGBHM = false;
					}
					else
					{
						DownPanelLogic.getI.EODNMBBBEDI(-97);
					}
				}
				else
				{
					DownPanelLogic.getI.GKBNAKPBOAG(-113);
					this.openHotRod(29);
				}
			}
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				if (this.user.MFENINHGBHM)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ() == 1)
					{
						this.user.NEFHFADILLJ(true);
					}
					else
					{
						DownPanelLogic.getI.DDJHLFEEEDI(-109);
					}
				}
				else
				{
					DownPanelLogic.getI.AKPFJEDNIOE(-43);
					this.openHotRod(49);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-98)))
			{
				if (this.user.MFENINHGBHM)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ() == 4)
					{
						this.user.MFENINHGBHM = false;
					}
					else
					{
						DownPanelLogic.getI.EODNMBBBEDI(37);
					}
				}
				else
				{
					DownPanelLogic.getI.FGLJAIFHALA(-84);
					this.openHotRod(-34);
				}
			}
			if (Input.GetKeyDown((KeyCode)182) && this.user.AEMBDHALFNG())
			{
				this.fishDown(false, true);
			}
			if (Input.GetKeyDown(KeyCode.RightParen) && !this.user.KNMMOLKNLNL())
			{
				this.WpnCellClick(6, true);
			}
			if (Input.GetKeyDown(KeyCode.Alpha0))
			{
				GameInterface.getI.ABBDLICDJEK(0, true);
			}
			if (Input.GetKeyDown((KeyCode)71))
			{
				DownPanelLogic.getI.NFKLLICOGJD(true);
			}
			if (Input.GetKeyDown(KeyCode.L))
			{
				DownPanelLogic.getI.OpenBaseMap(true);
			}
			if (Input.GetKeyDown((KeyCode)(-184)) || Input.GetKeyDown((KeyCode)(-61)))
			{
				this.OCFJLOGPMNI = !this.GAAPDLNHCDA();
				HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC = true;
				this.wcam.distance = 917f;
				this.wcam.desiredDistance = 297f;
				this.wcam.currentDistance = 80f;
				this.wcam.enabled = false;
				this.mouseLook.enabled = false;
				this.mouseLook.isFreeze = !this.GAAPDLNHCDA();
			}
		}
		this.mouseLook.isFreeze = false;
		if (!this.mouseLook.enabled)
		{
			this.JCALABLAOND(true);
		}
		HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = (this.OCFJLOGPMNI | this.mouseLook.enabled);
		if (JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count >= 7 && JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN[JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count - 0].GENHHJPGOFK)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = false;
		}
		if (this.GFWin != null && this.GFWin.gameObject.activeSelf)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = true;
		}
		if (ChatPanelLogic.getI && DownPanelLogic.getI)
		{
			if (ChatPanelLogic.getI.DJEPDONBBIM())
			{
				HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = true;
			}
			if (DownPanelLogic.getI.baseMapObj != null)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = true;
			}
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			this.mouseLook.isFreeze = true;
			if (this.user)
			{
				bool flag = false;
				if (this.user.KNMMOLKNLNL())
				{
					flag = true;
				}
				if (this.user.isFishGet)
				{
					flag = false;
				}
				if (this.user.CMCPFNJIIHK)
				{
					flag = true;
				}
				if (this.user.dropScrpt != null)
				{
					flag = true;
				}
				if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
				{
					flag = false;
				}
				if (!Input.GetMouseButton(1))
				{
					flag = true;
				}
				this.mouseLook.isFreeze = flag;
				if (!flag)
				{
					this.user.APNAPCPDCFP(Camera.main.transform.forward);
				}
			}
		}
		else
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.Locked;
			this.mouseLook.isFreeze = true;
			this.user.rotateToNpr(Camera.main.transform.forward);
		}
		float fieldOfView = Camera.main.fieldOfView;
		float t = (Camera.main.fieldOfView - 389f) / 586f;
		float num = Mathf.Lerp(this.MinMaxSent.x, this.MinMaxSent.y, t);
		this.mouseLook.sensitivityX = num;
		this.mouseLook.sensitivityY = num;
		this.hidePanelReal.gameObject.SetActive(this.GAAPDLNHCDA());
		if (Fisherman.getI != null)
		{
			Fisherman.getI.character.catNewItems.SetActive(!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
			if (Fisherman.getI.fchair != null)
			{
				Fisherman.getI.fchair.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
			}
			this.lineRope.gameObject.SetActive(this.user.dropScrpt != null);
		}
		this.staticLight.color = this.dinamycLight.color;
		this.staticLight.intensity = this.dinamycLight.intensity;
		this.staticLight.shadowStrength = this.dinamycLight.shadowStrength;
		if (Mathf.Clamp(this.staticLight.intensity, 1062f, 1786f) > 996f)
		{
			this.wlintens -= Time.deltaTime * 269f;
		}
		else
		{
			this.wlintens += Time.deltaTime * 593f;
		}
		this.wlintens = Mathf.Clamp(this.wlintens, 1172f, 265f);
		this.rodTmr = Mathf.Clamp(this.rodTmr - Time.deltaTime, 1184f, 266f);
		this.lineTmr = Mathf.Clamp(this.lineTmr - Time.deltaTime, 9f, 1914f);
		if (LocBaseManager.EDKKJNHDBPF().isLoadProcess && LocBaseManager.GJACINHCABC().isInstanceProcess)
		{
			this.loadPb.textHeader.text = "Cowboy1HandDraw";
		}
		if (Fisherman.getI != null)
		{
			if (this.user.dropScrpt != null)
			{
				if (this.evntsText1 != null)
				{
					this.evntsText1.text = this.user.dropScrpt.getBaitInfo();
				}
				if (this.evntsText2 != null)
				{
					this.evntsText2.text = this.evntsText1.text;
				}
			}
			else
			{
				if (this.evntsText1 != null)
				{
					this.evntsText1.text = "offsets";
				}
				if (this.evntsText2 != null)
				{
					this.evntsText2.text = "Katana Ready Low";
				}
			}
			if (Fisherman.getI.MFENINHGBHM && !ChatPanelLogic.getI.DJEPDONBBIM())
			{
				BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
				if (Input.GetKeyUp((KeyCode)(-153)) || Input.GetKeyUp(KeyCode.G) || Input.GetKeyUp((KeyCode)(-158)) || Input.GetKeyUp((KeyCode)(-21)))
				{
					this.MCLCCJKPMBF = 663f;
				}
				if (Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown((KeyCode)(-75)) || Input.GetKeyDown((KeyCode)7) || Input.GetKeyDown((KeyCode)(-2)))
				{
					this.CNIBLMMFPEI = Time.time;
				}
				bool flag2 = this.MCLCCJKPMBF < Time.time;
				bool flag3 = Input.GetKey((KeyCode)23) | Input.GetKey(KeyCode.Escape);
				bool flag4 = Input.GetKey((KeyCode)(-124)) | Input.GetKey((KeyCode)(-22));
				if (Input.GetKeyDown((KeyCode)(-23)))
				{
					this.deepPanel.EADLDDPGLII();
					this.speedPanel.OFF();
					this.fricPanel.DGHLOGDDFOK();
				}
				float axis = Input.GetAxis("wpn_rod2");
				bool flag5 = true;
				if (this.fricPanel.MGAMBBLEHBP())
				{
					flag5 = true;
				}
				GuiProcessor.IKGFHGKKCPG.isPanelParamActive = true;
				if (!flag5)
				{
					int num2 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE();
					if (flag3 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ += 138f;
					}
					if (flag4 && flag2)
					{
						BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
						bgjkmcbhnak.ALIOGHFOFHO(bgjkmcbhnak.ENMACOFAHKG() - 950f);
					}
					float num3 = axis * 81f;
					BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ += num3;
					if (Mathf.Abs(num3) > 1533f)
					{
						this.fricPanel.DGHLOGDDFOK();
					}
					if ((flag3 || flag4) && flag2)
					{
						this.MCLCCJKPMBF = Time.time + ((Time.time - this.CNIBLMMFPEI > 608f) ? 325f : 1367f);
						this.fricPanel.CDKOLOEJMGB();
					}
					if (num2 != BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CMKFMNBBPNE())
					{
						this.ws.playSoundFric();
					}
					GuiProcessor.BBLINJLBAIL().isPanelParamActive = false;
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && flag5)
				{
					if (flag3 && flag5 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JCIMMJOIBJJ(0);
					}
					if (flag4 && flag5 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JCIMMJOIBJJ(-1);
					}
					if ((flag3 || flag4) && flag5 && flag2)
					{
						this.MCLCCJKPMBF = Time.time + ((Time.time - this.CNIBLMMFPEI > 648f) ? 1264f : 1919f);
						this.speedPanel.EKJJCKINJFK();
					}
					if (this.speedPanel.MGAMBBLEHBP())
					{
						GuiProcessor.NKOEAPCIBKO().isPanelParamActive = false;
						float num4 = axis * 191f;
						BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
						bgjkmcbhnak2.GLKEIPMPKAH(bgjkmcbhnak2.CLEJODCMJAA + num4);
						if (Mathf.Abs(num4) > 1740f)
						{
							this.speedPanel.PCDIPOEEFMB();
						}
					}
					if (Input.GetKeyDown(KeyCode.Alpha5))
					{
						this.fricPanel.KGGLGPBAMLN();
						this.speedPanel.KLICGOFAICB();
					}
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning && flag5)
				{
					if (flag3 && flag5 && flag2)
					{
						BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak3 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
						bgjkmcbhnak3.IFNNBJDJBNA = bgjkmcbhnak3.IFELKILNKFP() + 1172f;
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA);
					}
					if (flag4 && flag5 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFNNBJDJBNA -= 1548f;
						BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDFKFMDPCDH = ObscuredFloat.HLEMAJBAAEO(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IFELKILNKFP());
					}
					if ((flag3 || flag4) && flag5 && flag2)
					{
						this.MCLCCJKPMBF = Time.time + ((Time.time - this.CNIBLMMFPEI > 1922f) ? 1407f : 1277f);
						this.deepPanel.KNKDNGBKAGH();
					}
					if (this.deepPanel.HKPAEGGJNGG)
					{
						GuiProcessor.IKGFHGKKCPG.isPanelParamActive = false;
						float num5 = axis * 797f;
						BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak4 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
						bgjkmcbhnak4.IFNNBJDJBNA = bgjkmcbhnak4.IFELKILNKFP() + num5;
						BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
						if (Mathf.Abs(num5) > 1877f)
						{
							this.deepPanel.BCGBHIKCCLI();
						}
					}
					if (Input.GetKeyDown((KeyCode)7))
					{
						this.fricPanel.DFKDBEHLPOL();
						this.deepPanel.JNIFLLMCEMG();
					}
				}
				if (Input.GetKeyDown((KeyCode)(-101)))
				{
					this.fricPanel.NDKIHKAMDLB();
				}
			}
		}
		if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Alpha8))
		{
			this.NANKIDAJFJF = false;
		}
		if (this.waterMaterial != null)
		{
			this.waterMaterial.SetFloat("Method called requires VPaint Object to be dynamic. Set VPaintObject.isDynamic to true before calling this method.", TimeController.KOJCECHBHLO().currentWaterColorSlider);
		}
		if (this.user)
		{
			this.user.lineControl(false, false, (this.user.dropScrpt != null) ? this.user.dropScrpt.transform : null);
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				Camera.main.transform.position = this.user.eyeCamPoint.transform.position;
				bool flag6 = this.OCFJLOGPMNI | !this.mouseLook.enabled;
				if (this.user.MFENINHGBHM)
				{
					this.wcam.enabled = false;
					if (this.user.dropScrpt != null)
					{
						this.EBFJDEHAABL();
					}
					else if (this.user.MFENINHGBHM)
					{
						this.KPIDPCLBJFL();
					}
					else
					{
						this.KPIDPCLBJFL();
					}
					if (this.zoom < 90f)
					{
						this.zoom = 705f;
						this.wcam.distance = 1197f;
						this.wcam.currentDistance = 847f;
						this.wcam.desiredDistance = 516f;
						this.ICBABCJLCLI(false);
						return;
					}
					if (this.getKeyFlipView())
					{
						this.flipView(false);
					}
				}
				else
				{
					if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && !GuiProcessor.BBLINJLBAIL().isPanelParamActive)
					{
						this.wcam.currentDistance -= Input.GetAxis("_AdaptionSpeed") * Time.deltaTime * 389f;
					}
					if (this.wcam.currentDistance < 1069f)
					{
						this.wcam.currentDistance = 1854f;
					}
					if (this.wcam.currentDistance > 724f)
					{
						this.ICBABCJLCLI(false);
					}
					if (this.getKeyFlipView())
					{
						this.ICBABCJLCLI(true);
					}
				}
			}
			else if (this.user.MFENINHGBHM)
			{
				if (this.wcam.currentDistance < 1405f)
				{
					this.ICBABCJLCLI(false);
				}
				if (this.getKeyFlipView())
				{
					this.ICBABCJLCLI(false);
				}
			}
			else
			{
				if (this.wcam.currentDistance < 1468f)
				{
					this.ICBABCJLCLI(true);
				}
				if (this.getKeyFlipView())
				{
					this.ICBABCJLCLI(false);
				}
			}
		}
		if (LocBaseManager.NPCAKEGNBHD().isLoadProcess)
		{
			this.loadPb.position = LocBaseManager.GJACINHCABC().BNBBLDJDDLP();
		}
		bool isShow = true;
		if (this.user != null)
		{
			isShow = this.user.MFENINHGBHM;
		}
		this.panelRoll.isShow = isShow;
		this.user = Fisherman.getI;
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak5 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak5 != null && this.user != null)
		{
			this.PBar_Up.position = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak5.MPKJDFOMBLI());
			this.PBar_Down.position = ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak5.OGLIEFLNLLE);
			this.PBarAdd_Up.position = bgjkmcbhnak5.LGALGHAPJND;
			this.PBarAdd_Down.position = ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak5.KIKADLMBJIA);
			this.PBarRollCat.position = bgjkmcbhnak5.CCLOHHCJJAM * 57f;
			this.PBarStamina.max = ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak5.PLIPAKGHPBE);
			float a = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak5.GIMFIFECPGL);
			float b = ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak5.OGLIEFLNLLE);
			this.PBarResult.max = 735f;
			float position = Mathf.Max(a, b);
			this.PBarResult.position = position;
			if (this.user && this.user.dropScrpt && this.user.dropScrpt.fish)
			{
				this.PBarStamina.position = ObscuredFloat.GOOIABGKMHK(this.user.dropScrpt.fish.currStamina);
			}
			else
			{
				this.PBarStamina.position = 731f;
			}
			bool flag7 = false;
			if (this.user.isPodsek)
			{
				if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak5.OGLIEFLNLLE) < 113f)
				{
					flag7 = true;
				}
				if (flag7)
				{
					flag7 = (Mathf.Sin(Time.time * 1230f) < 346f);
				}
			}
			if (this.freeLine1 != null)
			{
				this.freeLine1.gameObject.SetActive(flag7);
			}
			if (this.freeLine2 != null)
			{
				this.freeLine2.gameObject.SetActive(flag7);
			}
		}
		if (this.user != null)
		{
			Vector3 position2 = this.user.transform.position;
			position2.y = this.CDBIEPGNONF() + 51f;
			this.getPosGO.transform.position = position2;
			this.minLineDistanceGO.transform.position = position2;
			this.getPosGO.transform.rotation = this.user.transform.rotation;
			this.minLineDistanceGO.transform.rotation = this.user.transform.rotation;
			this.minLineDistanceGO.transform.Rotate(927f, 486f, 250f);
			this.getPosGO.transform.Rotate(1565f, 1650f, 709f);
			this.getPosGO.gameObject.SetActive(this.user.LPENNEOLCCP() & this.user.isPodsek);
			this.minLineDistanceGO.gameObject.SetActive(this.user.MFENINHGBHM);
			if (BOIKJDICEMF.IKGFHGKKCPG != null && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
			{
				Vector3 fishGettingPosition = this.user.getFishGettingPosition();
				Vector3 position3 = this.user.transform.position;
				position3.y = fishGettingPosition.y;
				float num6 = Vector3.Distance(fishGettingPosition, position3) * 733f;
				this.getPosGO.transform.localScale = new Vector3(num6, num6, num6);
			}
			if (bgjkmcbhnak5 != null && this.user.MFENINHGBHM)
			{
				if (this.lineDstTxt != null)
				{
					float num7 = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak5.DNPDBOODCHK);
					float num8 = BOIKJDICEMF.IKGFHGKKCPG.CHCJILPBABD();
					this.lineDstTxt.text = string.Format(JNBICAJIJMM.CELEPPAEKAB("CrouchStrafeLeft"), num7, num8);
					if (this.lineDstTxt2 != null)
					{
						this.lineDstTxt2.text = this.lineDstTxt.text;
					}
				}
				if (this.FricTxt1 != null)
				{
					string text = string.Format("invn_rec4", this.ws.getFricText());
					this.FricTxt1.text = text;
					this.FricTxt2.text = text;
				}
			}
			float num9 = Mathf.Lerp(1506f, 370f, this.user.upRodState);
			this.BCOMJHNGOHH += Input.GetAxis("Failed parsing default rotation values.  Using defaults.") * this.sensitivityBlendRod * num9;
			this.BCOMJHNGOHH = Mathf.Clamp(this.BCOMJHNGOHH, 1634f, 1728f);
			float b2 = this.blendRodDirCurve.Evaluate(this.BCOMJHNGOHH);
			this.user.blendRodDirection = Mathf.Lerp(this.user.blendRodDirection, b2, Time.deltaTime * 23f);
			this.user.KNMMOLKNLNL();
			if (this.getKeySidDwn())
			{
				if (this.user.isSitEnable)
				{
					this.user.CMCPFNJIIHK = !this.user.OHKDFALEMNL();
				}
				else
				{
					this.user.CMCPFNJIIHK = false;
				}
			}
			switch (this.user.usermode)
			{
			case Fisherman.NHOCKOJNFFJ.Stay:
				if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() != null)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
					{
						this.HGEJLKDPBGP(false);
						if (Fisherman.getI.AOEGNGOGNBI != null)
						{
							Fisherman.getI.AOEGNGOGNBI.EIANPDPMNKJ(1665f);
						}
						if (this.user.dropScrpt != null)
						{
							Fisherman.getI.forceControl(this.user.dropScrpt.transform);
						}
						this.user.cursorPoint = this.dexCircleGO.transform.position;
						return;
					}
					this.stopRollSound();
					this.user.cursorPoint = this.dexCircleGO.transform.position;
					this.PMDJPDBDCFK();
					return;
				}
				break;
			case Fisherman.NHOCKOJNFFJ.Fishing:
				if (this.user.dropScrpt != null)
				{
					this.user.cursorPoint = this.user.dropScrpt.transform.position;
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.user.dropScrpt != null)
				{
					this.FNAJBAKNKOO();
					this.userStaySpinnigLogic(true);
					Fisherman.getI.CMNELOCJPOD(this.user.dropScrpt.transform);
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)7 && this.user.dropScrpt != null)
				{
					this.RodInWaterLogic();
					Fisherman.getI.OEABGNPEIDH(this.user.dropScrpt.transform);
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.user.dropScrpt != null)
				{
					this.PFEHDPGMIJL();
					Fisherman.getI.forceControl(this.user.dropScrpt.transform);
					return;
				}
				break;
			case Fisherman.NHOCKOJNFFJ.FishOnRod:
				if (this.user.fishRod != null)
				{
					this.user.cursorPoint = this.user.fishRod.transform.position;
				}
				this.fishOnRodLogic();
				return;
			case Fisherman.NHOCKOJNFFJ.FishGet:
				if (this.rollSound.isPlaying)
				{
					this.stopRollSound();
				}
				this.user.cursorPoint = Vector3.zero;
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x060068BD RID: 26813 RVA: 0x00313D28 File Offset: 0x00311F28
	public void changeBait(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (this.PHFFFJIKHNJ == null)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG < 0)
		{
			return;
		}
		if (this.PHFFFJIKHNJ.IHEILFHMLAG >= this.PHFFFJIKHNJ.LACAJHOHACK.Count)
		{
			return;
		}
		if (this.IIPDNDLKOKN == 3)
		{
			this.ws.gameObject.SetActive(false);
		}
		EKBAPCMPANI ekbapcmpani = null;
		if (HEABEPINGED.tag >= 0L)
		{
			ekbapcmpani = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[this.PHFFFJIKHNJ.IHEILFHMLAG];
		}
		if (this.LGEIAMMMJOF != null && ekbapcmpani != null)
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.LGEIAMMMJOF.LPFKFNLHGBI);
				epmphjgalbe.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(184, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			int jgniddbnggp = this.LGEIAMMMJOF.JGNIDDBNGGP;
			int dmamopgjock = this.LGEIAMMMJOF.DMAMOPGJOCK;
			this.LGEIAMMMJOF.JGNIDDBNGGP = ekbapcmpani.JGNIDDBNGGP;
			this.LGEIAMMMJOF.DMAMOPGJOCK = ekbapcmpani.DMAMOPGJOCK;
			ekbapcmpani.JGNIDDBNGGP = jgniddbnggp;
			ekbapcmpani.DMAMOPGJOCK = dmamopgjock;
		}
		if (this.LGEIAMMMJOF == null && ekbapcmpani != null)
		{
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
				epmphjgalbe2.GOMLLPFFPNP(this.PAIPILKFEDC);
				epmphjgalbe2.GOMLLPFFPNP(this.IIPDNDLKOKN);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(182, epmphjgalbe2.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe2.LMBPNFHKNGA();
			}
			ekbapcmpani.JGNIDDBNGGP = this.PAIPILKFEDC;
			ekbapcmpani.DMAMOPGJOCK = this.IIPDNDLKOKN;
		}
		if (this.LGEIAMMMJOF != null && ekbapcmpani == null)
		{
			EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe3.OBCCLNMPGEJ(this.LGEIAMMMJOF.LPFKFNLHGBI);
				epmphjgalbe3.GOMLLPFFPNP(-1);
				epmphjgalbe3.GOMLLPFFPNP(100);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(182, epmphjgalbe3.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe3.LMBPNFHKNGA();
			}
			this.LGEIAMMMJOF.JGNIDDBNGGP = -1;
			this.LGEIAMMMJOF.DMAMOPGJOCK = 100;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("crunch.ogg", 0.3f);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		if (!BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IKKPFPJLPOL)
		{
			Fisherman.getI.MFENINHGBHM = false;
		}
		this.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x060068BE RID: 26814 RVA: 0x00313FB4 File Offset: 0x003121B4
	public GameObject HBOLDAJOJOO(int DFBHMIIPLCA, Vector3 NHCLMBOINFG)
	{
		GameObject gameObject = null;
		GameObject gameObject2 = null;
		Queue<GameObject> queue = null;
		switch (DFBHMIIPLCA)
		{
		case 0:
			gameObject2 = this.waterCircleSmallPrefab;
			queue = this.JMHOJPJONNJ;
			break;
		case 1:
			gameObject2 = this.waterCircleFishPrefab;
			queue = this.COOFLDJIDCK;
			break;
		case 2:
			gameObject2 = this.waterCirclePrefab;
			queue = this.FBCOEHFKIJI;
			break;
		}
		if (queue != null && queue.Count > 1)
		{
			gameObject = queue.Dequeue();
			WaterCircle component = gameObject.GetComponent<WaterCircle>();
			gameObject.transform.position = NHCLMBOINFG;
			if (component != null)
			{
				component.HHIEPGGCFKH();
			}
			return gameObject;
		}
		if (gameObject2 != null)
		{
			gameObject = UnityEngine.Object.Instantiate<GameObject>(gameObject2, NHCLMBOINFG, Quaternion.identity);
			gameObject.transform.parent = this.WaterCircleCatalog.transform;
		}
		return gameObject;
	}

	// Token: 0x060068BF RID: 26815 RVA: 0x00314070 File Offset: 0x00312270
	public bool AHDILEICFMM(Vector3 NHCLMBOINFG)
	{
		float num = 1590f;
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			num = 941f;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)5)
		{
			num = 193f;
		}
		float pointerDistance = this.getPointerDistance();
		if (pointerDistance <= BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL)
		{
			return false;
		}
		if (pointerDistance > BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP())
		{
			return true;
		}
		if (this.user != null)
		{
			Vector3 forward = this.user.transform.forward;
			Vector3 position = this.user.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			Vector3 to = this.dexCircleGO.transform.position - position;
			if (Mathf.Abs(Vector3.Angle(forward, to)) > num)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060068C0 RID: 26816 RVA: 0x0031414C File Offset: 0x0031234C
	private void KBAJMMCHDOC()
	{
		if (this.timeLabel != null)
		{
			this.timeLabel.text = DateTime.Now.ToString("<color='{2}'>{0}: {1}</color>");
		}
		if (!this.isLevelLoadProcess && GameInterface.getI.currentTurnir != null)
		{
			Rect position = new Rect(123f, 1989f, 217f, 1664f);
			Rect position2 = new Rect(position.x - 1631f, position.y - 1983f, position.width + 480f, position.height + 998f);
			if (GameInterface.getI.currentTurnir.turnimage != null)
			{
				if (GUI.Button(position, GUIContent.none) && Time.time - this.wtime > 408f)
				{
					Debug.Log("_FogDensity");
					if (GameInterface.getI.currentTurnir.state == 7)
					{
						GHMGDBLLEAG.GALDNPBIINC().KPIJDCNCOGC();
					}
					else
					{
						Debug.Log("Transforms is null.");
						GHMGDBLLEAG.EEOPOHEALPK().PHMPFGKCLNK(GameInterface.getI.currentTurnir);
					}
					this.wtime = Time.time;
				}
				GUI.color = new Color(520f, 1000f, 1462f, 1312f);
				if (GameInterface.getI.currentTurnir.state != 3)
				{
					GUI.color = new Color(515f, 1505f, 1115f, 555f);
				}
				GUI.DrawTexture(position2, GameInterface.getI.borderBy, ScaleMode.ScaleAndCrop);
				GUI.DrawTexture(position, GameInterface.getI.currentTurnir.turnimage.KEDGAOBCNJG, ScaleMode.ScaleAndCrop);
				GUI.color = new Color(1304f, 44f, 629f, 866f);
				GUIStyle ofpnedeamab = new GUIStyle
				{
					normal = 
					{
						textColor = Color.gray
					},
					alignment = TextAnchor.UpperLeft,
					fontSize = 44,
					wordWrap = false,
					richText = true
				};
				TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
				if (GameInterface.getI.currentTurnir.state == 0)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.regTime - DateTime.Now;
				}
				if (GameInterface.getI.currentTurnir.state == 0)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.startTime - DateTime.Now;
				}
				if (GameInterface.getI.currentTurnir.state == 2)
				{
					makoioidpjk = GameInterface.getI.currentTurnir.endTime - DateTime.Now;
				}
				string fpihopocaha = JLFJEGIPIMM.PKGMBFEMKGP().CLDPDFPGMBP(makoioidpjk);
				JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(position.x, position.y + 1263f, 674f, 966f), fpihopocaha, ofpnedeamab);
				GUI.color = new Color(644f, 787f, 154f, 365f);
				if (position.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
				{
					JDCEFOFMGHB.HMJJPNDEKPP().OHHMBDOICNG(true);
				}
			}
		}
		if (Application.isEditor && this.user != null && this.user.dropScrpt && this.OGBHPFEEJJH)
		{
			int num = 157;
			if (this.PEFPELGDHPK)
			{
				GUI.color = Color.black;
			}
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			GUI.Label(new Rect(841f, (float)num, 44f, 552f), "float: " + bgjkmcbhnak.NKHBAJKMAGD);
			num += -122;
			GUI.Label(new Rect(1086f, (float)num, 962f, 590f), "wpn_popl1" + bgjkmcbhnak.CKJOFDPBFMC);
			num += -118;
			GUI.Label(new Rect(773f, (float)num, 1094f, 238f), "BlackSmithForge" + bgjkmcbhnak.DNPDBOODCHK);
			num += -50;
			GUI.Label(new Rect(912f, (float)num, 1619f, 1002f), "]" + bgjkmcbhnak.DJOHGAHBGLG);
			num += 107;
			GUI.Label(new Rect(1647f, (float)num, 293f, 377f), "0" + bgjkmcbhnak.HDFFLMCFGOG);
			num += 33;
			GUI.Label(new Rect(1256f, (float)num, 326f, 496f), "jamp" + bgjkmcbhnak.NKEGFIJJKIG);
			num += 120;
			GUI.Label(new Rect(361f, (float)num, 1139f, 1901f), "inv_pcs1" + this.alp);
			num += 11;
			GUI.Label(new Rect(1332f, (float)num, 751f, 105f), "[ProBuilder Attachments] A pb_Object is missing, this is normally caused by pb_Objects being stripped." + bgjkmcbhnak.PPMKELOFPAJ);
			num += 99;
			GUI.Label(new Rect(1681f, (float)num, 760f, 1293f), "repair.ogg" + bgjkmcbhnak.JBLKFABJAMA);
			num += 49;
			GUI.Label(new Rect(1350f, (float)num, 1025f, 477f), "MotorbikeIdle" + bgjkmcbhnak.AIHLOMHODIB);
			num += 93;
			GUI.Label(new Rect(1167f, (float)num, 1151f, 1248f), "" + bgjkmcbhnak.GAKPODHCHNB);
			num += -110;
			GUI.Label(new Rect(547f, (float)num, 1667f, 1086f), "droplinemsg1" + bgjkmcbhnak.OCBJPGOKFOI);
			num += -27;
			GUI.Label(new Rect(759f, (float)num, 466f, 1921f), "-none-" + bgjkmcbhnak.NOHFLPHECOA);
			num += 92;
			GUI.Label(new Rect(1634f, (float)num, 1193f, 1471f), "C" + bgjkmcbhnak.LEMPPBMEJHP);
			num += 35;
			GUI.Label(new Rect(161f, (float)num, 1514f, 423f), "  locid=" + bgjkmcbhnak.LJNDGALCAKL);
			num += -109;
			if (this.user.dropScrpt.fish != null)
			{
				GUI.Label(new Rect(886f, (float)num, 999f, 1306f), "_CosPower" + this.user.dropScrpt.fish.speed);
				num += 116;
				GUI.Label(new Rect(231f, (float)num, 1849f, 142f), "_rcIn.ogg" + this.user.dropScrpt.fish.toSpeed);
				num += -29;
				GUI.Label(new Rect(1209f, (float)num, 1890f, 523f), "TOD_Directionality" + this.user.dropScrpt.fish.stamKf);
				num += -60;
				GUI.Label(new Rect(1665f, (float)num, 1664f, 1429f), "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html" + bgjkmcbhnak.HAEABJICCCP);
				num += 2;
				GUI.Label(new Rect(1215f, (float)num, 839f, 417f), string.Format("cht_msg21", this.user.dropScrpt.fish.klevMode, this.user.dropScrpt.fish.toKlevMode));
				num += 96;
			}
			GUI.color = Color.white;
		}
	}

	// Token: 0x060068C1 RID: 26817 RVA: 0x003149A0 File Offset: 0x00312BA0
	public void PMDJPDBDCFK()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (this.user != null && this.user.AOEGNGOGNBI != null && !BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP)
		{
			this.user.IJMGCKIOBPP().FDLCJBFDIEM(45f);
		}
		if (Input.GetMouseButtonDown(0) && !JDCEFOFMGHB.MNJNNDHCDGG().JBMEDLAFJNI())
		{
			this.KOEHHGHGFEK = false;
		}
		if (this.user && this.user.MFENINHGBHM && LocNewLogic.DOKEMOGOOIG())
		{
			if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				if (this.user.KNMMOLKNLNL())
				{
					this.user.CDIDCIBEDKP(true);
				}
				else if (!this.user.GECLKEEGJGA() && this.user.standFlag)
				{
					this.dexCircleGO.transform.position = this.lastPosition;
					if (this.lastPosition.magnitude > 1957f && this.checkPosition(this.lastPosition))
					{
						this.dropAction(this.lastPosition);
					}
				}
			}
			else if (!this.user.KNMMOLKNLNL() && this.user.standFlag)
			{
				this.dexCircleGO.transform.position = this.lastPosition;
				if (this.lastPosition.magnitude > 1026f && this.checkPosition(this.lastPosition))
				{
					this.dropAction(this.lastPosition);
				}
			}
		}
		this.LPGBCHGEMIA(true);
	}

	// Token: 0x060068C2 RID: 26818 RVA: 0x00314B38 File Offset: 0x00312D38
	public void RodInWaterLogic()
	{
		this.user.UserLookAtOn(this.toDropPoint + Vector3.up * 0.2f);
		if (!this.user.DJPEBFMNLIC)
		{
			this.user.aimCntrl.FBFAJEGEIKM();
		}
		bool flag = Input.GetMouseButtonDown(0);
		if (JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			flag = false;
		}
		if (!flag)
		{
			flag = LocNewLogic.NNAOPOEGILO();
		}
		if (flag)
		{
			this.user.PodsekType = 0;
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM)
			{
				if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null)
				{
					float num = this.user.dropScrpt.fish.podsekShanceVer;
					if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB != null)
					{
						num *= 1f + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.JLLJFKOGLHJ / 100f;
					}
					if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num))
					{
						Debug.Log("Podsek action 1");
						this.podsekOkAction();
						return;
					}
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					Debug.Log("Podsek action 2");
					this.user.PodsekType = 1;
					this.user.isPodsek = false;
					this.user.CIHILMCEJND = false;
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1127, "!");
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
				{
					Debug.Log("Podsek action 2");
					this.user.PodsekType = 1;
					this.user.isPodsek = false;
					this.user.CIHILMCEJND = false;
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1127, "!");
				}
				BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA;
				return;
			}
			Debug.Log("Podsek action 3");
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				this.user.CIHILMCEJND = false;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
			{
				this.user.CIHILMCEJND = false;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
			{
				this.user.CIHILMCEJND = false;
			}
		}
	}

	// Token: 0x060068C3 RID: 26819 RVA: 0x00314D83 File Offset: 0x00312F83
	public bool EMELPGGLMDM()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.OCFJLOGPMNI;
	}

	// Token: 0x060068C4 RID: 26820 RVA: 0x00314D90 File Offset: 0x00312F90
	private void Awake()
	{
		LocNewLogic.getI = this;
		TimeController.IKGFHGKKCPG.isActive = !this.isBase;
		if (this.shine != null)
		{
			this.shine.gameObject.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.JCBDMHFPDPJ[4]);
		}
		TimeController.IKGFHGKKCPG.startNewScene(this.todSky, this.shine);
	}

	// Token: 0x060068C5 RID: 26821 RVA: 0x00314DF8 File Offset: 0x00312FF8
	public void createWaterCircle(Vector3 NHCLMBOINFG, int ILFHHDNJHNM)
	{
		if (Time.time - this.DHOIDINAIHA < 1.5f)
		{
			return;
		}
		if (this.waterCirclePrefab != null)
		{
			for (int i = 1; i <= ILFHHDNJHNM; i++)
			{
				NHCLMBOINFG.y = this.OGJHINOLHJJ + 0.001f;
				GameObject waterCircle = this.getWaterCircle(2, NHCLMBOINFG);
				float num = 0.03f * (float)(1 + i) + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(0.05);
				waterCircle.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
				waterCircle.transform.localScale = new Vector3(num, num, num);
				waterCircle.transform.Rotate(0f, 0f, OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(180.0));
			}
			this.DHOIDINAIHA = Time.time;
		}
	}

	// Token: 0x060068C6 RID: 26822 RVA: 0x00314EDC File Offset: 0x003130DC
	public void AAMKFMGGMFJ(Vector3 NHCLMBOINFG, float BPJCIKFGOMM)
	{
		if (BPJCIKFGOMM < 1730f)
		{
			this.AMBEOENMJJO(NHCLMBOINFG, BPJCIKFGOMM);
			return;
		}
		NHCLMBOINFG.y = this.OGJHINOLHJJ + 624f;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate<GameObject>(this.mediumSplashPrfb, NHCLMBOINFG, Quaternion.identity);
		FBFJFAKAGJG.IKGFHGKKCPG.AJFODOCHBNH(NHCLMBOINFG, 389f);
		this.createBigWaterCircle(NHCLMBOINFG);
		UnityEngine.Object.Destroy(obj, 478f);
	}

	// Token: 0x060068C7 RID: 26823 RVA: 0x00314F40 File Offset: 0x00313140
	private void KPIDPCLBJFL()
	{
		this.camToPplOn = false;
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, this.toFieldView, Time.deltaTime);
		if (!this.wcam.enabled)
		{
			if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && !GuiProcessor.IKGFHGKKCPG.isPanelParamActive)
			{
				this.zoom += Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 100f;
			}
			this.toFieldView = this.toFVUser;
			this.toCamPos = this.user.eyeCamPoint.transform.position;
			this.toCamLook = this.user.transform.position + this.user.transform.forward * BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 0.8f;
			this.toCamLook.y = this.OGJHINOLHJJ;
			if (this.user.dropScrpt && this.user.dropScrpt.fish)
			{
				this.toCamLook = ((this.user.dropScrpt.fish.hookPoint != null) ? this.user.dropScrpt.fish.hookPoint.transform.position : this.user.dropScrpt.fish.transform.position);
			}
			bool flag = false;
			if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && (ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isPodsek) || this.user.isFishGet || ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isGetFromWater)))
			{
				flag = true;
			}
			if (this.user.bragfish != null)
			{
				this.toCamLook = this.user.bragfish.transform.position - Vector3.up * 0.15f + this.user.transform.right * 0.15f;
			}
			if (JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
			{
				flag = true;
			}
			if (flag)
			{
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 0f, Time.deltaTime * 1f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 0f, Time.deltaTime * 1f);
			}
			else if (Input.GetMouseButton(1))
			{
				this.EEJPCEBHELM += Input.GetAxis("Mouse X");
				this.FPJLHGKJCFA += Input.GetAxis("Mouse Y");
				this.EEJPCEBHELM = Mathf.Clamp(this.EEJPCEBHELM, -15f, 15f);
				this.FPJLHGKJCFA = Mathf.Clamp(this.FPJLHGKJCFA, -6f, 6f);
				this.toCamLook += this.EEJPCEBHELM * this.user.transform.right * 0.7f;
				this.toCamLook += this.FPJLHGKJCFA * this.user.transform.up;
			}
			else
			{
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 0f, Time.deltaTime * 3f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 0f, Time.deltaTime * 3f);
			}
			if (this.mouseLook.enabled & !this.OCFJLOGPMNI)
			{
				this.toCamLook = Camera.main.transform.position + Camera.main.transform.forward * 10f;
			}
			Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toCamPos, Time.deltaTime);
			Quaternion b = Quaternion.LookRotation(this.toCamLook - Camera.main.transform.position);
			Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toCamPos, Time.deltaTime * 5f);
			Quaternion localRotation = Quaternion.Lerp(Camera.main.transform.localRotation, b, Time.deltaTime);
			if (this.mouseLook.isFreeze)
			{
				Camera.main.transform.localRotation = localRotation;
			}
			this.toCamLookObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 10f;
			return;
		}
		this.toFieldView = this.toFVNormal;
	}

	// Token: 0x060068C8 RID: 26824 RVA: 0x00315456 File Offset: 0x00313656
	private static bool NNAOPOEGILO()
	{
		return !ChatPanelLogic.getI.isChatEnter() && Input.GetKey(KeyCode.Space);
	}

	// Token: 0x060068C9 RID: 26825 RVA: 0x00315470 File Offset: 0x00313670
	public void OHPICKEKNKC()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (this.user.dropScrpt == null)
		{
			return;
		}
		if (this.user.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = this.user.dropScrpt.fish;
		fish.transform.position.y = this.user.transform.position.y;
		this.user.NADDOPFKIAC(fish.transform.position + Vector3.up * 448f);
		if (this.JCKKMKECMFA > 769f)
		{
			this.JCKKMKECMFA -= Time.deltaTime;
		}
		float num = Mathf.Clamp(this.JCKKMKECMFA, 1536f, 1650f) / 688f;
		float num2 = 1556f;
		if (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().OGLIEFLNLLE) <= 207f)
		{
			num2 = 643f;
		}
		float num3 = num2 * Time.deltaTime + ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().HFPNHGGIKHP) * num * Time.deltaTime;
		EKBAPCMPANI bckecoendlb = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB;
		if (bckecoendlb != null)
		{
			num3 *= (455f - bckecoendlb.LODGJCMEGAI.NAHLEJDLCNF()) / 1102f;
		}
		if (OLPINJLCKCI.NPIEJELJPIM().BKKLJJLDFDO(num3))
		{
			Debug.Log("IdleStandingJump");
			this.fishDown(true, true);
			return;
		}
		Vector3 vector = this.user.MOCNPMIACDL();
		float num4 = BOIKJDICEMF.IKGFHGKKCPG.CHCJILPBABD();
		if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.ALKAGOMNNOK) >= num4)
		{
			this.fishDown(false, true);
			return;
		}
		Vector3 position = this.user.transform.position;
		position.y = vector.y;
		float num5 = Vector3.Distance(vector, position);
		Vector3 position2 = fish.hookPoint.position;
		position2.y = vector.y;
		bool flag = fish.hookPoint.position.y - this.CDBIEPGNONF() > 1124f;
		float num6 = 756f;
		if (fish.hookPoint.position.y > this.CDBIEPGNONF())
		{
			num6 = 1291f;
		}
		bool flag2 = Vector3.Distance(position2, vector) < num6;
		if (!ObscuredBool.LPDGJCGPEBD(fish.isGetFromWater) && ((Vector3.Distance(position, position2) > num5 * 918f || flag2) && flag))
		{
			fish.fishGet();
			this.panelRoll.isShow = true;
			this.user.getFishAction();
			FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(fish.transform.position, 1712f);
			return;
		}
		bool flag3 = true;
		bool flag4 = true;
		this.rodUpMove = false;
		this.BEHGLKFJLPM();
		float num7 = bgjkmcbhnak.LGALGHAPJND;
		if (this.checkKeyRoll())
		{
			flag4 = false;
			float mfmlchfnalc = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC;
			float num8 = 1667f;
			float num9 = 845f;
			if (mfmlchfnalc > 1088f)
			{
				num8 = 538f;
				num9 = 583f;
			}
			if (mfmlchfnalc < 1617f)
			{
				num8 *= 1570f;
				num9 = 1762f;
			}
			if (Input.GetKeyDown((KeyCode)79))
			{
				num8 *= 1959f;
			}
			if (num8 < num9)
			{
				num8 = num9 * 1074f;
			}
			AnimationCurve animationCurve = GuiProcessor.PLGADNLAEGN().reelTensionCurve;
			if (mfmlchfnalc > 1549f)
			{
				animationCurve = GuiProcessor.NKOEAPCIBKO().reelSpdTensionCurve;
			}
			if (mfmlchfnalc < 1046f)
			{
				animationCurve = GuiProcessor.IKGFHGKKCPG.reelFrcTensionCurve;
			}
			float num10 = Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JBLKFABJAMA) / 865f, 200f, 97f);
			float t = animationCurve.Evaluate(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.AIHLOMHODIB) * 589f + num10, 114f, 1092f));
			float num11 = Mathf.Lerp(num9, num8, t) * 1719f;
			float num12 = Mathf.Lerp(878f, 523f, (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.JBLKFABJAMA) - mfmlchfnalc * 1152f) / 1905f);
			num11 *= num12;
			if (bgjkmcbhnak.BBANBEEJAPD)
			{
				num11 = num9;
			}
			if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DNPDBOODCHK) <= 558f)
			{
				num11 = 947f;
			}
			float num13 = num11 * 336f;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = bgjkmcbhnak;
			bgjkmcbhnak2.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak2.KIKADLMBJIA) - bgjkmcbhnak.AAGGJACBMEC * Time.deltaTime);
			bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) - num13 * Time.deltaTime);
			if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.DNPDBOODCHK) < 1396f)
			{
				bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.AJMPAOCEPCA(1589f);
			}
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime += Time.deltaTime * num11 * 735f;
			this.GGFKGJACBPM(num11, Mathf.Clamp(bgjkmcbhnak.EDNAPPHHHPI() * 793f, 315f, 1642f));
			num7 += bgjkmcbhnak.HNEEGDNEDHJ * 1974f * Time.deltaTime;
		}
		else
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak3 = bgjkmcbhnak;
			bgjkmcbhnak3.KIKADLMBJIA = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak3.KIKADLMBJIA) + bgjkmcbhnak.EFIGLGEEMHG() * Time.deltaTime);
			if (this.checkKeyRod())
			{
				BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak4 = bgjkmcbhnak;
				bgjkmcbhnak4.KIKADLMBJIA = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak4.KIKADLMBJIA) + bgjkmcbhnak.EFIGLGEEMHG() * 1889f * Time.deltaTime);
			}
			this.stopRollSound();
		}
		if (this.checkKeyRod())
		{
			flag3 = true;
			num7 -= bgjkmcbhnak.MKPBNPLJEDL * Time.deltaTime * 1555f;
		}
		else
		{
			num7 += bgjkmcbhnak.HNEEGDNEDHJ * Time.deltaTime;
			this.FGGGOAHFNCD();
		}
		bgjkmcbhnak.LGALGHAPJND = Mathf.Clamp(num7, 1917f, 519f);
		bgjkmcbhnak.KIKADLMBJIA = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.KIKADLMBJIA), 909f, 9f));
		fish.staminaProcess(flag3 || flag4);
		this.user.isKeyPress = (flag3 || flag4);
	}

	// Token: 0x060068CA RID: 26826 RVA: 0x00315A81 File Offset: 0x00313C81
	public void ABEFPMCIICH()
	{
		this._poplCameraGUI.gameObject.SetActive(false);
		this.JDHBGNOOBHK.SetActive(true);
	}

	// Token: 0x060068CB RID: 26827 RVA: 0x00315AA0 File Offset: 0x00313CA0
	public void CDAJLDPIHMA(float DCCPCBLODIG)
	{
		float num = DCCPCBLODIG * 571f;
		float z = Mathf.Clamp(num, 87f, 424f);
		this.dexCircleGO.transform.localScale = new Vector3(num, num, z);
		this.dexLDObj.transform.position = this.dexCircleGO.transform.position;
		LineRenderer component = this.dexLDObj.GetComponent<LineRenderer>();
		if (component != null)
		{
			component.SetPosition(1, this.dexCircleGO.transform.position);
			Vector3 position = Fisherman.getI.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			component.SetPosition(1, position);
			component.startWidth = num * 596f;
			component.endWidth = 278f;
		}
	}

	// Token: 0x060068CC RID: 26828 RVA: 0x00315B76 File Offset: 0x00313D76
	private void MCIJGNDJODM()
	{
		if (this.user != null)
		{
			UnityEngine.Object.Destroy(this.user.gameObject);
		}
		Debug.Log("Giant2HandGrab");
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	// Token: 0x060068CD RID: 26829 RVA: 0x00315BAC File Offset: 0x00313DAC
	public void playRollSound(float MMJELGIIKMO, float HMJNNIOPOMB)
	{
		if (MMJELGIIKMO <= 0.1f)
		{
			this.stopRollSound();
			return;
		}
		float volume = 0f;
		if (HMJNNIOPOMB > 0.7f)
		{
			float t = (HMJNNIOPOMB - 0.5f) * 2f;
			volume = Mathf.Lerp(0f, HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK, t);
		}
		this.rollSound.pitch = 0.7f + (HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH - 0.5f) * 0.3f + 0.2f * MMJELGIIKMO;
		this.rollSound.volume = volume;
		this.lowRollSound.volume = 0.5f * HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
		this.lowRollSound.pitch = 1f + 0.4f * MMJELGIIKMO;
		if (!this.lowRollSound.isPlaying)
		{
			this.lowRollSound.Play();
		}
		if (!this.rollSound.isPlaying)
		{
			this.rollSound.time = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)this.rollSound.clip.length);
			this.rollSound.Play();
		}
	}

	// Token: 0x060068CE RID: 26830 RVA: 0x00315CC8 File Offset: 0x00313EC8
	public float getPointerDistance()
	{
		if (this.user != null)
		{
			Vector3 position = this.user.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			return Vector3.Distance(position, this.dexCircleGO.transform.position);
		}
		return 1f;
	}

	// Token: 0x060068CF RID: 26831 RVA: 0x00315D2C File Offset: 0x00313F2C
	public float getAnimRUpState()
	{
		float num = Time.time - this.startAnimSpinTime;
		if (num > 1f)
		{
			return 0f;
		}
		if (this.user.CDNABIHPLHM)
		{
			return 0f;
		}
		if (!this.user.CIHILMCEJND)
		{
			return 0f;
		}
		if (this.user.dropScrpt == null)
		{
			return 0f;
		}
		float num2 = Mathf.Lerp(2f, 3f, BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.NKHBAJKMAGD / 20f);
		return Mathf.Clamp(this.animSpinningUpRod[this.animCurveID].Evaluate(num) * num2, -1f, 1f);
	}

	// Token: 0x060068D0 RID: 26832 RVA: 0x00315DDC File Offset: 0x00313FDC
	public bool checkKeyRoll()
	{
		if (Input.GetMouseButton(0) && JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			return false;
		}
		if (this.NANKIDAJFJF)
		{
			return false;
		}
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.G))
		{
			this.rodTmr = 1f;
			if (Fisherman.getI != null)
			{
				Fisherman fisherman = Fisherman.getI;
				fisherman.keyCount = ObscuredInt.HIBLFIAPCJE(fisherman.keyCount);
			}
		}
		return Input.GetMouseButton(0) | Input.GetKey(KeyCode.G);
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x060068D1 RID: 26833 RVA: 0x00314D83 File Offset: 0x00312F83
	// (set) Token: 0x060068EE RID: 26862 RVA: 0x003172E7 File Offset: 0x003154E7
	public bool OCFJLOGPMNI
	{
		get
		{
			return HPGKIJLKCIH.IKGFHGKKCPG.OCFJLOGPMNI;
		}
		set
		{
			HPGKIJLKCIH.IKGFHGKKCPG.OCFJLOGPMNI = value;
		}
	}

	// Token: 0x060068D2 RID: 26834 RVA: 0x00315E58 File Offset: 0x00314058
	public void createWaterCircleFish(Vector3 NHCLMBOINFG, float HALCDOBHLAF = 1f, bool HIMLCNPEEDM = false)
	{
		if (!HIMLCNPEEDM && Time.time - this.EBOCMLKGHKH < 0.1f)
		{
			return;
		}
		if (this.waterCircleFishPrefab != null)
		{
			NHCLMBOINFG.y = this.OGJHINOLHJJ + 0.001f;
			GameObject waterCircle = this.getWaterCircle(1, NHCLMBOINFG);
			float num = 0.03f * OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(0.05) * HALCDOBHLAF;
			waterCircle.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
			waterCircle.transform.localScale = new Vector3(num, num, num);
			waterCircle.transform.Rotate(0f, 0f, OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(180.0));
			this.EBOCMLKGHKH = Time.time;
		}
	}

	// Token: 0x060068D3 RID: 26835 RVA: 0x00315F28 File Offset: 0x00314128
	public float getDeepInPoint(Vector3 NHCLMBOINFG)
	{
		NHCLMBOINFG.y = this.OGJHINOLHJJ;
		if (Terrain.activeTerrain.SampleHeight(NHCLMBOINFG) + Terrain.activeTerrain.transform.position.y > this.OGJHINOLHJJ)
		{
			return this.OGJHINOLHJJ + 0.1f;
		}
		Vector3 vector = new Vector3(NHCLMBOINFG.x, this.OGJHINOLHJJ - 0.01f, NHCLMBOINFG.z);
		float num = 0f;
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(vector, Vector3.down), out raycastHit, 100f, this.fishCollisionMask))
		{
			num = raycastHit.distance;
			return raycastHit.point.y;
		}
		return vector.y - num;
	}

	// Token: 0x060068D4 RID: 26836 RVA: 0x00315FE0 File Offset: 0x003141E0
	public float DNEOIPONBDH(Vector3 NHCLMBOINFG)
	{
		float deepInPoint = this.getDeepInPoint(NHCLMBOINFG);
		return (this.HKBNODJBGEL() - deepInPoint) * 463f;
	}

	// Token: 0x060068D5 RID: 26837 RVA: 0x00316004 File Offset: 0x00314204
	public void createWaterCircleSmall(Vector3 NHCLMBOINFG, int ILFHHDNJHNM)
	{
		if (ILFHHDNJHNM <= 0)
		{
			return;
		}
		if (Time.time - this.DHOIDINAIHA < 1.5f)
		{
			return;
		}
		if (this.waterCircleSmallPrefab != null)
		{
			for (int i = 1; i <= ILFHHDNJHNM; i++)
			{
				NHCLMBOINFG.y = this.OGJHINOLHJJ + 0.001f;
				GameObject waterCircle = this.getWaterCircle(0, NHCLMBOINFG);
				float num = 0.05f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(0.05);
				waterCircle.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
				waterCircle.transform.localScale = new Vector3(num, num, num);
				waterCircle.transform.Rotate(0f, 0f, OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(360.0));
			}
			this.DHOIDINAIHA = Time.time;
		}
	}

	// Token: 0x060068D6 RID: 26838 RVA: 0x003160E8 File Offset: 0x003142E8
	public bool checkKeyRod()
	{
		if (Input.GetMouseButton(1) && JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			return false;
		}
		if (this.NANKIDAJFJF)
		{
			return false;
		}
		if (ChatPanelLogic.getI.isChatEnter())
		{
			return false;
		}
		if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.H))
		{
			this.lineTmr = 1f;
			if (Fisherman.getI != null)
			{
				Fisherman fisherman = Fisherman.getI;
				fisherman.keyCount = ObscuredInt.HIBLFIAPCJE(fisherman.keyCount);
			}
		}
		return Input.GetMouseButton(1) || Input.GetKey(KeyCode.H);
	}

	// Token: 0x060068D7 RID: 26839 RVA: 0x00316174 File Offset: 0x00314374
	public void lineTensionLogic()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (!bgjkmcbhnak.IKKPFPJLPOL)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		float num = 1f;
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null)
		{
			num = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC);
		}
		if (bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC < 0f && this.user.CDNABIHPLHM)
		{
			float num2 = Mathf.Abs(bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC) * bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.OBEOJCGHOGL * 0.5f;
			if (num2 > ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) / 4f)
			{
				num2 = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) / 4f;
			}
			num -= num2;
		}
		float num3 = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.EDICLBDIPGG) / 80f;
		float num4 = (float)ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.ELBKLOECINC) / 80f;
		bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(0f);
		bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.GOOIABGKMHK(2f);
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) > 0f)
		{
			float num5 = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK);
			num5 = Mathf.Clamp(num5, 2f, 5f);
			bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK((num5 + ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) * 1f) / num5 - 1f);
			bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG), 0.01f, 4f));
		}
		this.alp = 0.5f;
		bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(0f);
		float num6 = 1f;
		if (this.user.dropScrpt != null)
		{
			Vector3 vector = this.user.AOEGNGOGNBI.transform.forward * this.user.AOEGNGOGNBI.actualRodLength;
			Vector3 to = this.user.AOEGNGOGNBI.transform.position + vector - this.user.dropScrpt.transform.position;
			this.alp = Mathf.Abs(Mathf.Sin(Vector3.Angle(vector, to) * 3.1415927f / 180f));
			vector.y = 0f;
			to.y = 0f;
			bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(Vector3.Angle(-vector, to));
			if ((this.user.transform.position - this.user.dropScrpt.transform.position).magnitude < 15f)
			{
				bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG), 0f, 100f));
			}
			if (!this.user.CDNABIHPLHM)
			{
				bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG), 0f, 100f));
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG) > 100f)
			{
				this.alp = 1f;
				num6 = 1f + (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG) - 100f) / 10f;
			}
		}
		bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(Mathf.LerpUnclamped(0f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ, ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) / (0.001f + bgjkmcbhnak.DNGEAIGBDIJ())));
		if (this.user.CDNABIHPLHM && ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) > 0f && ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 0.3f)
		{
			bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) + ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / 800f);
		}
		float num7 = Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) / num6, 0f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 2f);
		if (num7 < ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LODEKEHKOKP))
		{
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.GOOIABGKMHK(num7);
		}
		else
		{
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.GOOIABGKMHK(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LODEKEHKOKP), num7, bgjkmcbhnak.EFEJJFGGMOF));
		}
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) < 3f)
		{
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 800f)
			{
				bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.GOOIABGKMHK(0.1f + Mathf.Max(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / 1000f * 2f, ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) * 1.8f));
				bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ), 0f, ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NOMLJIMHFIL)));
			}
			else if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 1200f)
			{
				bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.GOOIABGKMHK(0.5f * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / 1000f + ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) * 3f);
				bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ), 0f, ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NOMLJIMHFIL)));
			}
		}
		float num8 = Mathf.Lerp(0.5f, 1f, 1f - this.alp);
		float num9 = Mathf.Lerp(0f, 0.7f, this.alp);
		float num10 = num8 * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) / bgjkmcbhnak.IIOHPBENEFI.MIMANMPNLPE.JLLJFKOGLHJ;
		float num11 = num9 * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) / bgjkmcbhnak.NKNCNHGDMLF.MIMANMPNLPE.JLLJFKOGLHJ;
		bgjkmcbhnak.JBLKFABJAMA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) * num8);
		bgjkmcbhnak.DMEINKBOACF = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) * num9);
		if (bgjkmcbhnak.BBANBEEJAPD)
		{
			bgjkmcbhnak.JBLKFABJAMA = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JBLKFABJAMA), 0f, bgjkmcbhnak.KDHENOMNPHK));
			bgjkmcbhnak.DMEINKBOACF = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DMEINKBOACF), 0f, bgjkmcbhnak.KDHENOMNPHK));
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LODEKEHKOKP), 0f, bgjkmcbhnak.KDHENOMNPHK));
		}
		this.torodproc = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG);
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) > 0.01f)
		{
			if (!this.user.CDNABIHPLHM)
			{
				bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(CurvesCntr.getI.lineTensionBait.Evaluate(Mathf.Max(10f, num10 * 100f) / 100f) * 100f);
				bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(CurvesCntr.getI.lineTensionBait.Evaluate(Mathf.Max(10f, num11 * 100f) / 100f) * 100f);
			}
			else
			{
				bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(GuiProcessor.IKGFHGKKCPG.lineTensionCurve.Evaluate(Mathf.Max(15f, num10 * 100f) / 100f) * 100f);
				bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(num6 * GuiProcessor.IKGFHGKKCPG.rodTensionCurve.Evaluate(Mathf.Max(15f, num11 * 100f) / 100f) * 100f);
			}
		}
		else
		{
			bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(0f);
			bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(0f);
		}
		float num12 = 1f;
		float mfmlchfnalc = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC;
		if (mfmlchfnalc > 0.1f)
		{
			num12 = 1.2f;
		}
		num12 = Mathf.Clamp(num12, 1f, 2f);
		float num13 = 1f + Mathf.Clamp(20f - bgjkmcbhnak.LGALGHAPJND, 0f, 20f) * 0.05f;
		float num14 = 1f - Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LJNDGALCAKL), 0f, 20f) / 50f;
		float num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH;
		if (mfmlchfnalc > 0.1f)
		{
			num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH * 0.7f;
		}
		if (mfmlchfnalc < -0.1f)
		{
			num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH * 1.3f;
		}
		float num16 = num13 * num14 * num12 * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JBLKFABJAMA) / (bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.JLLJFKOGLHJ * 1f + 0.1f + num15);
		if (this.user.CDNABIHPLHM)
		{
			num16 = GuiProcessor.IKGFHGKKCPG.reelTnsTensionCurve.Evaluate(num16);
		}
		bgjkmcbhnak.CCLOHHCJJAM = num16;
		bgjkmcbhnak.AIHLOMHODIB = ObscuredFloat.GOOIABGKMHK(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.AIHLOMHODIB), bgjkmcbhnak.CCLOHHCJJAM, Time.deltaTime * 1.5f));
		bgjkmcbhnak.GAKPODHCHNB = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.JLLJFKOGLHJ * bgjkmcbhnak.CCLOHHCJJAM);
	}

	// Token: 0x060068D8 RID: 26840 RVA: 0x00316B08 File Offset: 0x00314D08
	public void WpnCellClick(int PPJJJAGNADB, bool HMOOIHDFIKC)
	{
		if (!HMOOIHDFIKC && !Input.GetMouseButtonUp(0))
		{
			Debug.Log("GetMouseButtonUp reboot");
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("human_move_2.wav", 0.5f);
		List<int> list = new List<int>();
		this.PAIPILKFEDC = 100;
		this.IIPDNDLKOKN = 20;
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF();
		bool flag = false;
		switch (bgjkmcbhnak.DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			switch (PPJJJAGNADB)
			{
			case 1:
				list.Add(9);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 4;
				break;
			case 2:
				list.Add(6);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 10;
				break;
			case 3:
				list.Add(10);
				list.Add(11);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 20;
				flag = true;
				break;
			case 6:
				list.Add(5);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 3;
				break;
			case 7:
				list.Add(38);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 5;
				flag = true;
				break;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			switch (PPJJJAGNADB)
			{
			case 2:
				list.Add(8);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 4;
				break;
			case 3:
				list.Add(12);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 20;
				break;
			case 6:
				list.Add(5);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 3;
				break;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			switch (PPJJJAGNADB)
			{
			case 1:
				list.Add(10);
				list.Add(11);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 22;
				flag = true;
				break;
			case 2:
				list.Add(10);
				list.Add(11);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 21;
				flag = true;
				break;
			case 3:
				list.Add(10);
				list.Add(11);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 20;
				flag = true;
				break;
			case 6:
				list.Add(5);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 3;
				break;
			case 7:
				list.Add(38);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 5;
				flag = true;
				break;
			}
			break;
		}
		if (list.Count <= 0)
		{
			return;
		}
		this.LGEIAMMMJOF = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(this.PAIPILKFEDC, this.IIPDNDLKOKN);
		if (HMOOIHDFIKC && JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.ILCOIIBDOCI) != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.ILCOIIBDOCI);
			return;
		}
		Fisherman.getI.CIHILMCEJND = false;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.ILCOIIBDOCI);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(300f, 350f, "", true);
		this.ILCOIIBDOCI = onkdcgnbalk.LPFKFNLHGBI;
		Vector2 ojoepeadbaf = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
		if (HMOOIHDFIKC)
		{
			ojoepeadbaf = new Vector2((float)(Screen.width - 334), (float)(Screen.height - 50));
		}
		onkdcgnbalk.OCHCODJIPHJ.x = ojoepeadbaf.x - 50f;
		onkdcgnbalk.OCHCODJIPHJ.y = ojoepeadbaf.y - 20f - onkdcgnbalk.OCHCODJIPHJ.height;
		onkdcgnbalk.OCHCODJIPHJ.x = Mathf.Clamp(onkdcgnbalk.OCHCODJIPHJ.x, 0f, (float)Screen.width - onkdcgnbalk.OCHCODJIPHJ.width - 20f);
		this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 15f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 30f, onkdcgnbalk.OCHCODJIPHJ.height - 70f, 0);
		if (flag)
		{
			ItemBase itemBase = new ItemBase("--" + JNBICAJIJMM.LEBHCLDODNI("crft_none") + "--");
			itemBase.tag = -1L;
			this.PHFFFJIKHNJ.LACAJHOHACK.Add(itemBase);
		}
		foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP != 52 && ekbapcmpani.IMDLBJICHOE() && !ekbapcmpani.MJHGLLIJMIM && ekbapcmpani.JGNIDDBNGGP != num && (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE > 5 || ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA == bgjkmcbhnak.AANHBNICFDL) && JLFJEGIPIMM.IKGFHGKKCPG.EHEMCMKMECH(ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE, list))
			{
				this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
			}
		}
		this.PHFFFJIKHNJ.MGNDPEIFKAN();
		int dccpcblodig = 0;
		if (this.LGEIAMMMJOF != null)
		{
			for (int i = 0; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i++)
			{
				if (this.PHFFFJIKHNJ.LACAJHOHACK[i].tag >= 0L)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.LGEIAMMMJOF.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
		}
		this.PHFFFJIKHNJ.IHEILFHMLAG = dccpcblodig;
		this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.changeBait);
		JDCEFOFMGHB.IKGFHGKKCPG.NMOBAMMPLGP = -3f;
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x060068D9 RID: 26841 RVA: 0x003170BC File Offset: 0x003152BC
	private void HMGADNEOKAI()
	{
		if (this.user != null)
		{
			UnityEngine.Object.Destroy(this.user.gameObject);
		}
		Debug.Log("Giant 3 Hit Combo");
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	// Token: 0x060068DA RID: 26842 RVA: 0x003170F4 File Offset: 0x003152F4
	public float HACGLNGIMPG()
	{
		float num = Time.time - this.startAnimSpinTime;
		if (num > 317f)
		{
			return 1665f;
		}
		if (this.user.JIBGPKCOLML())
		{
			return 1936f;
		}
		if (!this.user.KNMMOLKNLNL())
		{
			return 775f;
		}
		if (this.user.dropScrpt == null)
		{
			return 69f;
		}
		if (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BNKBCOAANNG) < 1769f)
		{
			return 194f;
		}
		float num2 = Mathf.Lerp(1600f, 1783f, BOIKJDICEMF.IKGFHGKKCPG.KBNMKAMMOKM().NKHBAJKMAGD / 540f);
		return this.addForceSpinningUpRod[this.animCurveID].Evaluate(num) * num2 * 708f;
	}

	// Token: 0x060068DB RID: 26843 RVA: 0x003171BC File Offset: 0x003153BC
	public bool checkMousePosition()
	{
		Vector2 v = Input.mousePosition;
		if (!this.OCFJLOGPMNI)
		{
			v = new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f);
		}
		RaycastHit raycastHit;
		return Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 200f, this.waterCheckRay) && !(raycastHit.collider.tag != "Water") && this.checkPosition(raycastHit.point);
	}

	// Token: 0x060068DC RID: 26844 RVA: 0x00317250 File Offset: 0x00315450
	public bool getKeySidDwn()
	{
		bool mouseButtonDown = Input.GetMouseButtonDown(4);
		if (ChatPanelLogic.getI.isChatEnter())
		{
			return mouseButtonDown;
		}
		return mouseButtonDown | Input.GetKeyDown(KeyCode.Q);
	}

	// Token: 0x060068DD RID: 26845 RVA: 0x00317280 File Offset: 0x00315480
	public void playHiFricSound(bool EBFJFABFILO)
	{
		if (!EBFJFABFILO)
		{
			if (this.lowFrikcSound.isPlaying)
			{
				this.lowFrikcSound.Pause();
			}
			return;
		}
		if (!this.lowFrikcSound.isPlaying)
		{
			this.lowFrikcSound.time = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)this.lowFrikcSound.clip.length);
			this.lowFrikcSound.Play();
		}
	}

	// Token: 0x060068DE RID: 26846 RVA: 0x003172E7 File Offset: 0x003154E7
	public void JCALABLAOND(bool DCCPCBLODIG)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.OCFJLOGPMNI = DCCPCBLODIG;
	}

	// Token: 0x060068DF RID: 26847 RVA: 0x00314D83 File Offset: 0x00312F83
	public bool GAAPDLNHCDA()
	{
		return HPGKIJLKCIH.IKGFHGKKCPG.OCFJLOGPMNI;
	}

	// Token: 0x060068E0 RID: 26848 RVA: 0x003172F4 File Offset: 0x003154F4
	public void createWaterSplash(Vector3 NHCLMBOINFG, float BPJCIKFGOMM)
	{
		if (BPJCIKFGOMM < 100f)
		{
			return;
		}
		if (Time.time - this.OLHNBLFPBGF < 0.1f)
		{
			return;
		}
		this.OLHNBLFPBGF = Time.time;
		NHCLMBOINFG.y = this.OGJHINOLHJJ + 0.001f;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate<GameObject>(this.mediumSplashPrfb, NHCLMBOINFG, Quaternion.identity);
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(NHCLMBOINFG, 0.3f);
		this.createBigWaterCircle(NHCLMBOINFG);
		UnityEngine.Object.Destroy(obj, 8f);
	}

	// Token: 0x060068E1 RID: 26849 RVA: 0x00317370 File Offset: 0x00315570
	public void userStayLogic()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (this.user != null && this.user.AOEGNGOGNBI != null && !BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP)
		{
			this.user.AOEGNGOGNBI.PGEDLDMLBBE = 0f;
		}
		if (Input.GetMouseButtonDown(0) && !JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			this.KOEHHGHGFEK = true;
		}
		if (this.user && this.user.MFENINHGBHM && LocNewLogic.FADEIIFNODD())
		{
			if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
			{
				if (this.user.CIHILMCEJND)
				{
					this.user.CIHILMCEJND = false;
				}
				else if (!this.user.CIHILMCEJND && this.user.standFlag)
				{
					this.dexCircleGO.transform.position = this.lastPosition;
					if (this.lastPosition.magnitude > 0.1f && this.checkPosition(this.lastPosition))
					{
						this.dropAction(this.lastPosition);
					}
				}
			}
			else if (!this.user.CIHILMCEJND && this.user.standFlag)
			{
				this.dexCircleGO.transform.position = this.lastPosition;
				if (this.lastPosition.magnitude > 0.1f && this.checkPosition(this.lastPosition))
				{
					this.dropAction(this.lastPosition);
				}
			}
		}
		this.EKMGJGNMCOA(true);
	}

	// Token: 0x17000177 RID: 375
	// (set) Token: 0x060068E2 RID: 26850 RVA: 0x00317505 File Offset: 0x00315705
	public float PBCADOCADPC
	{
		set
		{
			this.minDistanceGO.transform.localScale = new Vector3(value * 2f, value * 2f, value * 2f);
		}
	}

	// Token: 0x060068E3 RID: 26851 RVA: 0x00317534 File Offset: 0x00315734
	public void DJBBECFDLAA(Vector3 NHCLMBOINFG, float BPJCIKFGOMM)
	{
		if (BPJCIKFGOMM < 468f)
		{
			return;
		}
		if (Time.time - this.OLHNBLFPBGF < 1502f)
		{
			return;
		}
		this.OLHNBLFPBGF = Time.time;
		NHCLMBOINFG.y = this.OGJHINOLHJJ + 1354f;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate<GameObject>(this.mediumSplashPrfb, NHCLMBOINFG, Quaternion.identity);
		FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(NHCLMBOINFG, 1141f);
		this.FHKKPOKKJDO(NHCLMBOINFG);
		UnityEngine.Object.Destroy(obj, 1019f);
	}

	// Token: 0x060068E4 RID: 26852 RVA: 0x003175B0 File Offset: 0x003157B0
	private void DIMLDFJICLI()
	{
		if (this.wcam.enabled)
		{
			return;
		}
		this.camToPplOn = true;
		if (this.user.dropScrpt == null)
		{
			this.KPIDPCLBJFL();
			return;
		}
		if (this.user.dropScrpt.fish != null && ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isGetFromWater))
		{
			this.KPIDPCLBJFL();
			return;
		}
		this.toCamLook = this.user.transform.position + this.user.transform.forward * 5f;
		if (this.user.dropScrpt.transform.position.y > this.OGJHINOLHJJ + 0.1f)
		{
			this.toCamLook = this.user.dropScrpt.toPos;
		}
		BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL;
		if (this.user.dropScrpt.fishPointer != null)
		{
			this.toCamLook = this.user.dropScrpt.transform.position;
		}
		this.toFieldView = this.toFVUser;
		float b = 20f;
		if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Fider)
		{
			b = 30f;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			b = this.toFVUserSpin;
		}
		this.toFieldView = Mathf.Lerp(this.toFVUser, b, this.zoom);
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isPodsek))
		{
			this.toFieldView = this.toFVUser;
		}
		if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && !GuiProcessor.IKGFHGKKCPG.isPanelParamActive)
		{
			this.zoom += Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 30f;
		}
		this.zoom = Mathf.Clamp(this.zoom, -0.5f, 1f);
		bool flag = true;
		if (this.user.dropScrpt.fishPointer != null)
		{
			this.toCamPos = this.user.eyeCamPoint.transform.position;
		}
		else
		{
			this.toCamPos = this.user.eyeCamPoint.transform.position;
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Spinning)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * 5f;
				if (this.user.dropScrpt != null)
				{
					this.toCamLook = this.user.dropScrpt.transform.position;
					this.toCamLook.y = this.OGJHINOLHJJ + 0.5f;
				}
				this.EEJPCEBHELM = 0f;
				this.FPJLHGKJCFA = 0f;
				flag = false;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				if (this.user.dropScrpt.poplavok != null && this.user.dropScrpt.transform.position.y < this.OGJHINOLHJJ + 0.1f)
				{
					this.toCamLook = this.user.dropScrpt.poplavok.transform.position;
				}
				this.toCamLook.y = this.OGJHINOLHJJ + 0.5f;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Fider)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * 5f;
				if (this.user.dropScrpt != null)
				{
					this.toCamLook = this.user.dropScrpt.transform.position + this.user.transform.up * 0.5f;
					this.toCamLook.y = this.OGJHINOLHJJ + 0.5f;
					if (!this.user.DJPEBFMNLIC)
					{
						if (this.user.dropScrpt.mode == 2)
						{
							this.toCamLook = this.user.transform.position + this.user.transform.forward * 3f + this.user.transform.up * 1.6f;
						}
						if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP)
						{
							this.toCamLook = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC + this.user.transform.forward * 3f - this.user.transform.up * 0.6f;
						}
						else
						{
							this.toFieldView = this.toFVUser;
						}
					}
				}
			}
		}
		bool flag2 = false;
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && (ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isPodsek) || this.user.isFishGet || ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isGetFromWater)))
		{
			flag2 = true;
		}
		if (this.OCFJLOGPMNI)
		{
			if (flag2)
			{
				this.toCamLook = this.user.dropScrpt.transform.position;
				this.toCamLook.y = this.OGJHINOLHJJ + 0.3f;
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 0f, Time.deltaTime * 1f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 0f, Time.deltaTime * 1f);
			}
			else if (Input.GetMouseButton(1) && flag)
			{
				if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
				{
					this.EEJPCEBHELM += Input.GetAxis("Mouse X");
					this.FPJLHGKJCFA += Input.GetAxis("Mouse Y");
				}
				this.EEJPCEBHELM = Mathf.Clamp(this.EEJPCEBHELM, -12f, 12f);
				this.FPJLHGKJCFA = Mathf.Clamp(this.FPJLHGKJCFA, -2.5f, 2.5f);
			}
			else
			{
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 0f, Time.deltaTime * 2f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 0f, Time.deltaTime * 2f);
			}
			this.toCamLook += this.EEJPCEBHELM * this.user.transform.right * 0.4f;
			this.toCamLook += this.FPJLHGKJCFA * this.user.transform.up * 0.6f;
		}
		Quaternion b2 = Quaternion.LookRotation(this.toCamLook - Camera.main.transform.position);
		Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toCamPos, Time.deltaTime * 1f);
		Quaternion localRotation = Quaternion.Lerp(Camera.main.transform.localRotation, b2, Time.deltaTime * 1f);
		if (this.mouseLook.isFreeze)
		{
			Camera.main.transform.localRotation = localRotation;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, this.toFieldView, Time.deltaTime * 1f);
		this.toCamLookObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 10f;
	}

	// Token: 0x060068E5 RID: 26853 RVA: 0x00317E58 File Offset: 0x00316058
	public bool getKeyFlipView()
	{
		bool mouseButtonDown = Input.GetMouseButtonDown(3);
		if (ChatPanelLogic.getI.isChatEnter())
		{
			return mouseButtonDown;
		}
		return mouseButtonDown | Input.GetKeyDown(KeyCode.LeftControl);
	}

	// Token: 0x060068E6 RID: 26854 RVA: 0x00317E88 File Offset: 0x00316088
	public bool CJOEMCDMADC()
	{
		Vector2 v = Input.mousePosition;
		if (!this.EMELPGGLMDM())
		{
			v = new Vector2((float)Screen.width / 1856f, (float)Screen.height / 555f);
		}
		RaycastHit raycastHit;
		return Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 185f, this.waterCheckRay) && !(raycastHit.collider.tag != "GiantGrabThrow2") && this.checkPosition(raycastHit.point);
	}

	// Token: 0x060068E7 RID: 26855 RVA: 0x00317F1C File Offset: 0x0031611C
	public void openRod(int PJHNBLMHOHH)
	{
		if (this.user.MFENINHGBHM && this.user.dropScrpt != null && this.user.dropScrpt.fish != null)
		{
			this.fishDown(false, false);
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		if (!this.user.MFENINHGBHM && ActorMgr.getI.minActorDistance(this.user.transform.position) < 1.5f)
		{
			FlyMessageManager.getI.clearMessages();
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("msg_other"), Color.red, 0, 0);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		if (FlyMessageManager.getI.checkFlyIcon(2))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ());
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("human_move_2.wav", 1f);
		if (bgjkmcbhnak != null && bgjkmcbhnak.IKKPFPJLPOL)
		{
			this.user.MFENINHGBHM = !this.user.MFENINHGBHM;
			if (this.user.MFENINHGBHM)
			{
				this.openSonar(-1);
				return;
			}
			if (this.sonar != null)
			{
				UnityEngine.Object.Destroy(this.sonar);
				this.sonar = null;
			}
		}
	}

	// Token: 0x060068E8 RID: 26856 RVA: 0x00318090 File Offset: 0x00316290
	public void frikcionWorkProcess()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (!bgjkmcbhnak.IKKPFPJLPOL)
		{
			return;
		}
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JDFKFMDPCDH) >= 0f)
		{
			bgjkmcbhnak.IFNNBJDJBNA = Mathf.Lerp(bgjkmcbhnak.IFNNBJDJBNA, ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JDFKFMDPCDH), Time.deltaTime * 3f);
			if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && Mathf.RoundToInt(bgjkmcbhnak.IFNNBJDJBNA) != Mathf.RoundToInt(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JDFKFMDPCDH)) && this.ws.gameObject.activeSelf)
			{
				this.ws.setParamsDeep(30f, bgjkmcbhnak.KFEPCNBDMIH, bgjkmcbhnak.IFNNBJDJBNA);
			}
		}
		bgjkmcbhnak.BBANBEEJAPD = false;
		float num = GuiProcessor.IKGFHGKKCPG.lineTensionCurve.Evaluate(bgjkmcbhnak.AEFAHEMNOCH / (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 1000f));
		float num2 = GuiProcessor.IKGFHGKKCPG.rodTensionCurve.Evaluate(bgjkmcbhnak.AEFAHEMNOCH / (bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ * 1000f));
		float num3 = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(2.0) - 3f;
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL) >= num2 * 100f)
		{
			bgjkmcbhnak.BBANBEEJAPD = true;
			bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(num2 * 100f - num3);
			bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL), 0f, num2 * 100f));
		}
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE) >= num * 100f)
		{
			bgjkmcbhnak.BBANBEEJAPD = true;
			bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(num * 100f - num3);
			bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE), 0f, num * 100f));
		}
		if (bgjkmcbhnak.BBANBEEJAPD)
		{
			this.playLowFricSound(true);
		}
	}

	// Token: 0x060068E9 RID: 26857 RVA: 0x00318288 File Offset: 0x00316488
	public void FHKKPOKKJDO(Vector3 NHCLMBOINFG)
	{
		if (Time.time - this.DHOIDINAIHA < 1290f)
		{
			return;
		}
		if (this.waterCirclePrefab != null)
		{
			NHCLMBOINFG.y = this.IGHOGONIKLC() + 1299f;
			GameObject waterCircle = this.getWaterCircle(5, NHCLMBOINFG);
			waterCircle.GetComponent<Renderer>() != null;
			waterCircle.transform.localScale = new Vector3(1077f, 460f, 916f);
			this.DHOIDINAIHA = Time.time;
		}
	}

	// Token: 0x060068EA RID: 26858 RVA: 0x00318308 File Offset: 0x00316508
	public int BIGNCFOAKGC()
	{
		if (this.sd == null)
		{
			return 1;
		}
		if (Fisherman.getI == null)
		{
			return 1;
		}
		int result = 1;
		float num = 415f;
		foreach (SpawnPoint spawnPoint in this.sd.locations)
		{
			if (spawnPoint.locId == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE && !spawnPoint.isHidden)
			{
				float num2 = Vector3.Distance(Fisherman.getI.transform.position, spawnPoint.transform.position);
				if (num2 < num)
				{
					num = num2;
					result = spawnPoint.pointId;
				}
			}
		}
		return result;
	}

	// Token: 0x060068EB RID: 26859 RVA: 0x003183D0 File Offset: 0x003165D0
	public void PKJKEDPOOIB()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (!bgjkmcbhnak.IKKPFPJLPOL)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		float num = 704f;
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null)
		{
			num = ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.CKJOFDPBFMC);
		}
		if (bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC < 626f && this.user.CDNABIHPLHM)
		{
			float num2 = Mathf.Abs(bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC) * bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.OAAKPMLGJJH() * 1812f;
			if (num2 > ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.CKJOFDPBFMC) / 775f)
			{
				num2 = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) / 871f;
			}
			num -= num2;
		}
		float num3 = (float)ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.EDICLBDIPGG) / 50f;
		float num4 = (float)ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.ELBKLOECINC) / 1923f;
		bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.AJMPAOCEPCA(1784f);
		bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.AJMPAOCEPCA(1156f);
		if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DJOHGAHBGLG) > 812f)
		{
			float num5 = ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.DNPDBOODCHK);
			num5 = Mathf.Clamp(num5, 1731f, 1818f);
			bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.AJMPAOCEPCA((num5 + ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.DJOHGAHBGLG) * 1275f) / num5 - 1071f);
			bgjkmcbhnak.BNKBCOAANNG = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.BNKBCOAANNG), 521f, 1804f));
		}
		this.alp = 742f;
		bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.HLEMAJBAAEO(1420f);
		float num6 = 1063f;
		if (this.user.dropScrpt != null)
		{
			Vector3 vector = this.user.EACGPPOMFLH().transform.forward * this.user.EACGPPOMFLH().actualRodLength;
			Vector3 to = this.user.AOEGNGOGNBI.transform.position + vector - this.user.dropScrpt.transform.position;
			this.alp = Mathf.Abs(Mathf.Sin(Vector3.Angle(vector, to) * 1182f / 1777f));
			vector.y = 1460f;
			to.y = 1585f;
			bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.HLEMAJBAAEO(Vector3.Angle(-vector, to));
			if ((this.user.transform.position - this.user.dropScrpt.transform.position).magnitude < 485f)
			{
				bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG), 1923f, 632f));
			}
			if (!this.user.LPENNEOLCCP())
			{
				bgjkmcbhnak.NKEGFIJJKIG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.NKEGFIJJKIG), 37f, 774f));
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG) > 1897f)
			{
				this.alp = 313f;
				num6 = 734f + (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKEGFIJJKIG) - 993f) / 920f;
			}
		}
		bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.GOOIABGKMHK(Mathf.LerpUnclamped(1141f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.NAHLEJDLCNF(), ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.BNKBCOAANNG) / (52f + bgjkmcbhnak.DNGEAIGBDIJ())));
		if (this.user.JIBGPKCOLML() && ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DJOHGAHBGLG) > 383f && ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.FDCKJDDOJPB() * 504f)
		{
			bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) + ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / 1802f);
		}
		float num7 = Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ) / num6, 1721f, bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.PHLLHDNNOMB() * 1705f);
		if (num7 < ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.LODEKEHKOKP))
		{
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.HLEMAJBAAEO(num7);
		}
		else
		{
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.HLEMAJBAAEO(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.LODEKEHKOKP), num7, bgjkmcbhnak.EFEJJFGGMOF));
		}
		if (ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.DJOHGAHBGLG) < 350f)
		{
			if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NKHBAJKMAGD) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.EIHMJDCOOCC() * 840f)
			{
				bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.GOOIABGKMHK(1911f + Mathf.Max(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) / 1332f * 407f, ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.CKJOFDPBFMC) * 646f));
				bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ), 570f, ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.NOMLJIMHFIL)));
			}
			else if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.NKHBAJKMAGD) < bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.JLLJFKOGLHJ * 1673f)
			{
				bgjkmcbhnak.NOMLJIMHFIL = ObscuredFloat.AJMPAOCEPCA(195f * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.NKHBAJKMAGD) / 98f + ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.CKJOFDPBFMC) * 1895f);
				bgjkmcbhnak.PPMKELOFPAJ = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ), 560f, ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.NOMLJIMHFIL)));
			}
		}
		float num8 = Mathf.Lerp(1809f, 618f, 1286f - this.alp);
		float num9 = Mathf.Lerp(1243f, 1040f, this.alp);
		float num10 = num8 * ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PPMKELOFPAJ) / bgjkmcbhnak.IIOHPBENEFI.MIMANMPNLPE.EIHMJDCOOCC();
		float num11 = num9 * ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.PPMKELOFPAJ) / bgjkmcbhnak.NKNCNHGDMLF.MIMANMPNLPE.EIHMJDCOOCC();
		bgjkmcbhnak.JBLKFABJAMA = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ) * num8);
		bgjkmcbhnak.DMEINKBOACF = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.PPMKELOFPAJ) * num9);
		if (bgjkmcbhnak.BBANBEEJAPD)
		{
			bgjkmcbhnak.JBLKFABJAMA = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.JBLKFABJAMA), 1327f, bgjkmcbhnak.PFDMMPFBCJA()));
			bgjkmcbhnak.DMEINKBOACF = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.DMEINKBOACF), 851f, bgjkmcbhnak.PFDMMPFBCJA()));
			bgjkmcbhnak.LODEKEHKOKP = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.LODEKEHKOKP), 239f, bgjkmcbhnak.PFDMMPFBCJA()));
		}
		this.torodproc = ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.EALPPCJHPKG);
		if (ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.BNKBCOAANNG) > 12f)
		{
			if (!this.user.LPENNEOLCCP())
			{
				bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.HLEMAJBAAEO(CurvesCntr.getI.lineTensionBait.Evaluate(Mathf.Max(1149f, num10 * 1886f) / 842f) * 77f);
				bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.AJMPAOCEPCA(CurvesCntr.getI.lineTensionBait.Evaluate(Mathf.Max(738f, num11 * 898f) / 133f) * 1018f);
			}
			else
			{
				bgjkmcbhnak.MIHODKKEDMK(ObscuredFloat.GOOIABGKMHK(GuiProcessor.BBLINJLBAIL().lineTensionCurve.Evaluate(Mathf.Max(137f, num10 * 1300f) / 940f) * 1699f));
				bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(num6 * GuiProcessor.PLGADNLAEGN().rodTensionCurve.Evaluate(Mathf.Max(1357f, num11 * 832f) / 937f) * 1549f);
			}
		}
		else
		{
			bgjkmcbhnak.MIHODKKEDMK(ObscuredFloat.GOOIABGKMHK(253f));
			bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.AJMPAOCEPCA(77f);
		}
		float num12 = 1277f;
		float mfmlchfnalc = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC;
		if (mfmlchfnalc > 61f)
		{
			num12 = 363f;
		}
		num12 = Mathf.Clamp(num12, 578f, 1799f);
		float num13 = 417f + Mathf.Clamp(174f - bgjkmcbhnak.LGALGHAPJND, 1184f, 301f) * 1854f;
		float num14 = 809f - Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.LJNDGALCAKL), 1343f, 1176f) / 951f;
		float num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH;
		if (mfmlchfnalc > 1481f)
		{
			num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH * 1693f;
		}
		if (mfmlchfnalc < 1200f)
		{
			num15 = BOIKJDICEMF.IKGFHGKKCPG.JEJMHADHCLH * 953f;
		}
		float num16 = num13 * num14 * num12 * ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.JBLKFABJAMA) / (bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.CLAEAFMCDMP() * 1068f + 1254f + num15);
		if (this.user.JIBGPKCOLML())
		{
			num16 = GuiProcessor.NKOEAPCIBKO().reelTnsTensionCurve.Evaluate(num16);
		}
		bgjkmcbhnak.JFGJKGJODEG(num16);
		bgjkmcbhnak.AIHLOMHODIB = ObscuredFloat.GOOIABGKMHK(Mathf.Lerp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.AIHLOMHODIB), bgjkmcbhnak.EDNAPPHHHPI(), Time.deltaTime * 1669f));
		bgjkmcbhnak.GAKPODHCHNB = ObscuredFloat.AJMPAOCEPCA(bgjkmcbhnak.LJCLFFINEHJ.LODGJCMEGAI.NAHLEJDLCNF() * bgjkmcbhnak.CCLOHHCJJAM);
	}

	// Token: 0x060068EC RID: 26860 RVA: 0x00318D64 File Offset: 0x00316F64
	private void HEEEJPLOMAN()
	{
		if (this.wcam.enabled)
		{
			return;
		}
		this.camToPplOn = true;
		if (this.user.dropScrpt == null)
		{
			this.KPIDPCLBJFL();
			return;
		}
		if (this.user.dropScrpt.fish != null && ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isGetFromWater))
		{
			this.ONLKFOFFHCJ();
			return;
		}
		this.toCamLook = this.user.transform.position + this.user.transform.forward * 989f;
		if (this.user.dropScrpt.transform.position.y > this.IGHOGONIKLC() + 1304f)
		{
			this.toCamLook = this.user.dropScrpt.toPos;
		}
		BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL;
		if (this.user.dropScrpt.fishPointer != null)
		{
			this.toCamLook = this.user.dropScrpt.transform.position;
		}
		this.toFieldView = this.toFVUser;
		float b = 666f;
		if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == (BOIKJDICEMF.JGHABIPEEEO)5)
		{
			b = 110f;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			b = this.toFVUserSpin;
		}
		this.toFieldView = Mathf.Lerp(this.toFVUser, b, this.zoom);
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && ObscuredBool.HLEMAJBAAEO(this.user.dropScrpt.fish.isPodsek))
		{
			this.toFieldView = this.toFVUser;
		}
		if (!JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL && !GuiProcessor.PLGADNLAEGN().isPanelParamActive)
		{
			this.zoom += Input.GetAxis("KEyeHistogram") * Time.deltaTime * 319f;
		}
		this.zoom = Mathf.Clamp(this.zoom, 842f, 7f);
		bool flag = true;
		if (this.user.dropScrpt.fishPointer != null)
		{
			this.toCamPos = this.user.eyeCamPoint.transform.position;
		}
		else
		{
			this.toCamPos = this.user.eyeCamPoint.transform.position;
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * 794f;
				if (this.user.dropScrpt != null)
				{
					this.toCamLook = this.user.dropScrpt.transform.position;
					this.toCamLook.y = this.IGHOGONIKLC() + 1458f;
				}
				this.EEJPCEBHELM = 1073f;
				this.FPJLHGKJCFA = 1568f;
				flag = false;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				if (this.user.dropScrpt.poplavok != null && this.user.dropScrpt.transform.position.y < this.HKBNODJBGEL() + 1593f)
				{
					this.toCamLook = this.user.dropScrpt.poplavok.transform.position;
				}
				this.toCamLook.y = this.IGHOGONIKLC() + 284f;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == (BOIKJDICEMF.JGHABIPEEEO)5)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * 966f;
				if (this.user.dropScrpt != null)
				{
					this.toCamLook = this.user.dropScrpt.transform.position + this.user.transform.up * 405f;
					this.toCamLook.y = this.HKBNODJBGEL() + 673f;
					if (!this.user.DJPEBFMNLIC)
					{
						if (this.user.dropScrpt.mode == 4)
						{
							this.toCamLook = this.user.transform.position + this.user.transform.forward * 1885f + this.user.transform.up * 427f;
						}
						if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP)
						{
							this.toCamLook = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB() + this.user.transform.forward * 1255f - this.user.transform.up * 1616f;
						}
						else
						{
							this.toFieldView = this.toFVUser;
						}
					}
				}
			}
		}
		bool flag2 = false;
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && (ObscuredBool.CINIKOHABJJ(this.user.dropScrpt.fish.isPodsek) || this.user.isFishGet || ObscuredBool.HLEMAJBAAEO(this.user.dropScrpt.fish.isGetFromWater)))
		{
			flag2 = false;
		}
		if (this.OCFJLOGPMNI)
		{
			if (flag2)
			{
				this.toCamLook = this.user.dropScrpt.transform.position;
				this.toCamLook.y = this.IGHOGONIKLC() + 1763f;
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 1368f, Time.deltaTime * 1477f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 1582f, Time.deltaTime * 310f);
			}
			else if (Input.GetMouseButton(1) && flag)
			{
				if (!JDCEFOFMGHB.JFIDAGABKID().GGCLOKODHEG())
				{
					this.EEJPCEBHELM += Input.GetAxis("id");
					this.FPJLHGKJCFA += Input.GetAxis("txt");
				}
				this.EEJPCEBHELM = Mathf.Clamp(this.EEJPCEBHELM, 207f, 46f);
				this.FPJLHGKJCFA = Mathf.Clamp(this.FPJLHGKJCFA, 191f, 262f);
			}
			else
			{
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 1112f, Time.deltaTime * 324f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 267f, Time.deltaTime * 1971f);
			}
			this.toCamLook += this.EEJPCEBHELM * this.user.transform.right * 1687f;
			this.toCamLook += this.FPJLHGKJCFA * this.user.transform.up * 1609f;
		}
		Quaternion b2 = Quaternion.LookRotation(this.toCamLook - Camera.main.transform.position);
		Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toCamPos, Time.deltaTime * 293f);
		Quaternion localRotation = Quaternion.Lerp(Camera.main.transform.localRotation, b2, Time.deltaTime * 1556f);
		if (this.mouseLook.isFreeze)
		{
			Camera.main.transform.localRotation = localRotation;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, this.toFieldView, Time.deltaTime * 392f);
		this.toCamLookObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 386f;
	}

	// Token: 0x060068ED RID: 26861 RVA: 0x0031960C File Offset: 0x0031780C
	public void PFEHDPGMIJL()
	{
		this.user.FHFBFHGCNCK(this.toDropPoint + Vector3.up * 1299f);
		if (!this.user.DJPEBFMNLIC)
		{
			this.user.aimCntrl.BAOPAIOMEKB();
		}
		bool flag = Input.GetMouseButtonDown(0);
		if (JDCEFOFMGHB.IKGFHGKKCPG.BHBCONNDEBA())
		{
			flag = false;
		}
		if (!flag)
		{
			flag = LocNewLogic.NNAOPOEGILO();
		}
		if (flag)
		{
			this.user.PodsekType = 1;
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM)
			{
				if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null)
				{
					float num = this.user.dropScrpt.fish.podsekShanceVer;
					if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB != null)
					{
						num *= 683f + BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.FDCKJDDOJPB() / 1216f;
					}
					if (OLPINJLCKCI.NPIEJELJPIM().BFKNOBCGLOK(num))
					{
						Debug.Log("norefine");
						this.podsekOkAction();
						return;
					}
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
				{
					Debug.Log("error baseid: ");
					this.user.PodsekType = 1;
					this.user.isPodsek = false;
					this.user.CDIDCIBEDKP(true);
					NJMHLCGIAJI.EAJGHMMBAFP().GDNKCAOHEPL(144, "BackPackOff");
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)3)
				{
					Debug.Log("");
					this.user.PodsekType = 1;
					this.user.isPodsek = true;
					this.user.CIHILMCEJND = true;
					NJMHLCGIAJI.IKGFHGKKCPG.BNJEMPKFNLA(-160, "USE_PREDICATION");
				}
				BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA;
				return;
			}
			Debug.Log("");
			if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				this.user.CDIDCIBEDKP(true);
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
			{
				this.user.CIHILMCEJND = true;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA == (BOIKJDICEMF.JGHABIPEEEO)7)
			{
				this.user.CDIDCIBEDKP(true);
			}
		}
	}

	// Token: 0x060068EF RID: 26863 RVA: 0x00319858 File Offset: 0x00317A58
	public void createWaterJampSplash(Vector3 NHCLMBOINFG, float BPJCIKFGOMM)
	{
		if (BPJCIKFGOMM < 1000f)
		{
			this.createWaterSplash(NHCLMBOINFG, BPJCIKFGOMM);
			return;
		}
		NHCLMBOINFG.y = this.OGJHINOLHJJ + 0.012f;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate<GameObject>(this.mediumSplashPrfb, NHCLMBOINFG, Quaternion.identity);
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(NHCLMBOINFG, 0.5f);
		this.createBigWaterCircle(NHCLMBOINFG);
		UnityEngine.Object.Destroy(obj, 8f);
	}

	// Token: 0x060068F1 RID: 26865 RVA: 0x003199E4 File Offset: 0x00317BE4
	public void FFFDBEICPMO()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		PoplDrop dropScrpt = this.user.dropScrpt;
		if (dropScrpt == null)
		{
			return;
		}
		GameObject gameObject = dropScrpt.gameObject;
		if (dropScrpt.fish != null)
		{
			return;
		}
		dropScrpt.spinmode = 0;
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown((KeyCode)(-58)))
		{
			this.ICNOLCEBBGI = Time.time;
		}
		if ((Input.GetMouseButtonUp(0) || Input.GetKeyUp((KeyCode)(-99))) && ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) > 1168f && Time.time - this.startAnimSpinTime > 169f && Time.time - this.ICNOLCEBBGI < 736f)
		{
			int ilockjiapfc = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().AMLEOGHNNPG[0].BDHHPAEHFHG.ILOCKJIAPFC;
			this.startAnimSpinTime = Time.time;
			this.animCurveID = ilockjiapfc;
			dropScrpt.GEFBKCLGGDI(this.animCurveID);
		}
		if (this.checkKeyRoll())
		{
			float num = 554f;
			bool key = Input.GetKey((KeyCode)174);
			float num2 = 915f * num;
			float num3 = 1116f;
			if (key)
			{
				num2 *= 527f;
			}
			float num4 = bgjkmcbhnak.CLEJODCMJAA / 564f;
			if (Fisherman.getI.AEMBDHALFNG())
			{
				num4 = 51f;
			}
			if (key)
			{
				num4 = 1528f;
			}
			float t = BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB.ELNDGAABMML(Mathf.Clamp(bgjkmcbhnak.EDNAPPHHHPI(), 1205f, 1637f));
			float num5 = Mathf.Lerp(num3, num2, t) * num4 * num;
			float num6 = num5 * 1214f;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = bgjkmcbhnak;
			bgjkmcbhnak2.KIKADLMBJIA = ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak2.KIKADLMBJIA) - bgjkmcbhnak.GGONBDIICLP() * Time.deltaTime);
			if (bgjkmcbhnak.BBANBEEJAPD)
			{
				num6 = 1162f;
				num5 = num3;
			}
			if (ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DNPDBOODCHK) <= 666f)
			{
				num6 = 241f;
				num5 = num3;
			}
			if (num6 > 772f)
			{
				dropScrpt.rolltime += Time.deltaTime;
			}
			bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DNPDBOODCHK) - num6 * Time.deltaTime);
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) < 1112f)
			{
				bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.HLEMAJBAAEO(1092f);
			}
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime += Time.deltaTime * num5 * 1233f;
			this.LEHLNLJPNFO(num5, 1045f);
			if (!this.checkKeyRod())
			{
				bgjkmcbhnak.LGALGHAPJND += bgjkmcbhnak.HNEEGDNEDHJ * 1306f * Time.deltaTime;
			}
		}
		else
		{
			this.stopRollSound();
			dropScrpt.rolltime = 1950f;
		}
		this.PKJKEDPOOIB();
		bgjkmcbhnak.AAINFMALAEN(ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.GIMGAKKKHLF), 629f, 1760f)));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.EALPPCJHPKG), 1853f, 1325f));
		bgjkmcbhnak.OGLIEFLNLLE = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.OGLIEFLNLLE), 496f, 718f));
		bgjkmcbhnak.GIMFIFECPGL = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.GIMFIFECPGL), 745f, 239f));
		bgjkmcbhnak.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.KIKADLMBJIA), 847f, 1291f));
		if (dropScrpt.mode == 3)
		{
			dropScrpt.spinmode = 1;
			bgjkmcbhnak.NKHBAJKMAGD = ObscuredFloat.AJMPAOCEPCA(bgjkmcbhnak.AMLEOGHNNPG[1].NKHBAJKMAGD);
			float num7 = Vector3.Distance(dropScrpt.transform.position, Fisherman.getI.EACGPPOMFLH().endPointNonBend.transform.position) + 1391f;
			bgjkmcbhnak.DLFMEIIADFE = ObscuredFloat.AJMPAOCEPCA((num7 - this.GPBFJBKCOKJ) / Time.deltaTime);
			this.GPBFJBKCOKJ = num7;
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(num7 - ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.DNPDBOODCHK));
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.DJOHGAHBGLG), 707f, 109f));
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) > 537f)
			{
				dropScrpt.spinmode = 8;
				this.toBaitSpinSpeed = 762f;
			}
			Vector3 a = this.user.EACGPPOMFLH().CNDKCPLCGAB();
			Vector3 position = gameObject.transform.position;
			a.y = this.HKBNODJBGEL();
			position.y = this.OGJHINOLHJJ;
			if (Vector3.Distance(a, position) < 578f)
			{
				this.user.CDIDCIBEDKP(true);
				return;
			}
		}
		else
		{
			this.toBaitSpinSpeed = 1792f;
			this.baitSpinSpeed = 438f;
		}
	}

	// Token: 0x060068F2 RID: 26866 RVA: 0x00319EA0 File Offset: 0x003180A0
	public void HGEJLKDPBGP(bool LGCOIDHAHKD)
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (this.user.dropScrpt != null)
		{
			if (this.checkKeyRod())
			{
				bgjkmcbhnak.LGALGHAPJND -= Time.deltaTime * 1445f;
				this.rodUpMove = true;
			}
			else
			{
				bgjkmcbhnak.LGALGHAPJND += Time.deltaTime * 1591f;
				this.rodUpMove = false;
			}
			bgjkmcbhnak.LGALGHAPJND = Mathf.Clamp(bgjkmcbhnak.LGALGHAPJND, 1271f, 1265f);
			if (!this.user.CMCPFNJIIHK)
			{
				this.user.dropScrpt.transform.position.y = this.user.transform.position.y;
				Vector3 to = this.user.dropScrpt.transform.position - this.user.transform.position;
				if (to.magnitude > 593f)
				{
					Vector3.Angle(this.user.transform.forward, to);
				}
			}
		}
		if (this.user && this.user.MFENINHGBHM && LocNewLogic.FADEIIFNODD())
		{
			if (this.user.GECLKEEGJGA())
			{
				this.user.CIHILMCEJND = true;
				return;
			}
			if (!this.user.KNMMOLKNLNL() && this.user.standFlag)
			{
				this.dexCircleGO.transform.position = this.lastPosition;
				if (this.lastPosition.magnitude > 1206f && this.checkPosition(this.lastPosition))
				{
					this.dropAction(this.lastPosition);
					return;
				}
			}
		}
		if (!this.user.KNMMOLKNLNL() && Input.GetMouseButtonDown(1) && !JDCEFOFMGHB.HMJJPNDEKPP().GMCOPAMLIPL)
		{
			this.KOEHHGHGFEK = false;
		}
		this.DPEODHBKGAG(false);
	}

	// Token: 0x060068F3 RID: 26867 RVA: 0x0031A0A8 File Offset: 0x003182A8
	public void CAHONDGOHFB(Vector3 NHCLMBOINFG)
	{
		if (Time.time - this.DHOIDINAIHA < 267f)
		{
			return;
		}
		if (this.waterCirclePrefab != null)
		{
			NHCLMBOINFG.y = this.OGJHINOLHJJ + 1790f;
			GameObject gameObject = this.NNDDPMJODPE(2, NHCLMBOINFG);
			gameObject.GetComponent<Renderer>() != null;
			gameObject.transform.localScale = new Vector3(992f, 693f, 525f);
			this.DHOIDINAIHA = Time.time;
		}
	}

	// Token: 0x060068F4 RID: 26868 RVA: 0x0031A128 File Offset: 0x00318328
	private void MKHMJJHKEDP()
	{
		Vector3 normalized = this.user.transform.forward.normalized;
		Vector3 position = this.dexCircleGO.transform.position;
		position.y = this.user.transform.position.y;
		Vector3 normalized2 = (position - this.user.transform.position).normalized;
		Vector2 vector = new Vector2(this.user.transform.position.x, this.user.transform.position.z);
		Vector2 vector2 = new Vector2(this.user.transform.position.x + normalized.x, this.user.transform.position.z + normalized.z);
		Vector2 vector3 = new Vector2(position.x, position.z);
		float num = (vector2.x - vector.x) * (vector3.y - vector.y) - (vector2.y - vector.y) * (vector3.x - vector.x);
		float num2 = Vector3.Angle(normalized, normalized2);
		this.nprCircleGO.transform.localRotation = Quaternion.Euler(1284f, num2 * Mathf.Sign(-num), 218f);
	}

	// Token: 0x060068F5 RID: 26869 RVA: 0x0031A28F File Offset: 0x0031848F
	private static bool DOKEMOGOOIG()
	{
		return ChatPanelLogic.getI.DGGGOGNMEJL() || (!LocNewLogic.getI.GFWin.gameObject.activeSelf && !Input.GetKeyDown((KeyCode)6) && Input.GetMouseButtonDown(3));
	}

	// Token: 0x060068F6 RID: 26870 RVA: 0x0031A2C8 File Offset: 0x003184C8
	public float OBOPPHLNFJM()
	{
		if (this.user != null)
		{
			Vector3 position = this.user.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			return Vector3.Distance(position, this.dexCircleGO.transform.position);
		}
		return 879f;
	}

	// Token: 0x060068F7 RID: 26871 RVA: 0x0031A32C File Offset: 0x0031852C
	public void AHNFPBKGDPA(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.clearImages();
			return;
		}
		bool flag = false;
		switch (JLJJKMLJBAK.DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			this.wpnCells[1].weapon = JLJJKMLJBAK.PFNCHEEEBKD;
			this.wpnCells[8].weapon = JLJJKMLJBAK.CBLCFLENIJL[1];
			this.wpnCells[5].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			this.wpnCells[7].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[6].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[1].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[6].weapon = JLJJKMLJBAK.CKBGHMMOAEM;
			flag = true;
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.wpnCells[1].weapon = null;
			this.wpnCells[7].weapon = JLJJKMLJBAK.PFNCHEEEBKD;
			this.wpnCells[8].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			this.wpnCells[3].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[7].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[8].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = null;
			flag = true;
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			this.wpnCells[1].weapon = JLJJKMLJBAK.AMLEOGHNNPG[3];
			this.wpnCells[7].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[2].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[0].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[5].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[7].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = JLJJKMLJBAK.CKBGHMMOAEM;
			flag = true;
			break;
		}
		if (flag)
		{
			this.clearImages();
		}
	}

	// Token: 0x060068F8 RID: 26872 RVA: 0x0031A510 File Offset: 0x00318710
	public void clearImages()
	{
		WpnImageObj[] array = this.wpnCells;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].weapon = null;
		}
	}

	// Token: 0x060068F9 RID: 26873 RVA: 0x0031A53C File Offset: 0x0031873C
	private LocNewLogic.OMHDHFKKIIL JDKJONHLLBE(Vector3 PNNFJEMKLGH)
	{
		LocNewLogic.OMHDHFKKIIL result = default(LocNewLogic.OMHDHFKKIIL);
		Vector3 vector = new Vector3(PNNFJEMKLGH.x, this.OGJHINOLHJJ - 0.01f, PNNFJEMKLGH.z);
		if (Terrain.activeTerrain.SampleHeight(vector) + Terrain.activeTerrain.transform.position.y > this.OGJHINOLHJJ)
		{
			result.KGMLACLJGAC = -1f;
			return result;
		}
		float kgmlacljgac = 0f;
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(vector, Vector3.down), out raycastHit, 500f, this.fishCollisionMask))
		{
			kgmlacljgac = raycastHit.distance;
		}
		result.KGMLACLJGAC = kgmlacljgac;
		return result;
	}

	// Token: 0x060068FA RID: 26874 RVA: 0x0031A5E4 File Offset: 0x003187E4
	public void AMBEOENMJJO(Vector3 NHCLMBOINFG, float BPJCIKFGOMM)
	{
		if (BPJCIKFGOMM < 1654f)
		{
			return;
		}
		if (Time.time - this.OLHNBLFPBGF < 1520f)
		{
			return;
		}
		this.OLHNBLFPBGF = Time.time;
		NHCLMBOINFG.y = this.OGJHINOLHJJ + 976f;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate<GameObject>(this.mediumSplashPrfb, NHCLMBOINFG, Quaternion.identity);
		FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(NHCLMBOINFG, 1951f);
		this.HALCKEHLBLM(NHCLMBOINFG);
		UnityEngine.Object.Destroy(obj, 421f);
	}

	// Token: 0x060068FB RID: 26875 RVA: 0x0031A660 File Offset: 0x00318860
	public void KEOIMAEMMOD()
	{
		this.user.isPodsek = false;
		this.user.PodsekType = 5;
		this.user.CDNABIHPLHM = false;
		this.JCKKMKECMFA = 982f;
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB != null)
		{
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.NNEAHAFBOHC().NHHPCBNKCPO(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.BDHHPAEHFHG.MIMANMPNLPE.NLHKFMMDMMK());
			float num = ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD);
			if (num >= iibeekcaahk.FDCKJDDOJPB() && num <= iibeekcaahk.OAAKPMLGJJH())
			{
				this.JCKKMKECMFA = 1972f;
			}
			if (num > iibeekcaahk.DOFNAOOCDDB())
			{
				this.JCKKMKECMFA = 563f + num / (iibeekcaahk.LOIBCMBMLEC() + 38f) * 1376f;
			}
		}
		this.user.podsek();
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = true;
		float num2 = ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD);
		this.closePoplCamera();
		this.NANKIDAJFJF = false;
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GIMGAKKKHLF = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(num2 / (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IIOHPBENEFI.LODGJCMEGAI.CLAEAFMCDMP() * 522f + 1582f), 352f, 20f) * 1663f);
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(num2 / (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKNCNHGDMLF.LODGJCMEGAI.JLLJFKOGLHJ * 1719f + 159f), 1580f, 1012f) * 1629f);
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BBMNOEDOFDJ(ObscuredFloat.GOOIABGKMHK(737f));
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().EPIPCOHGJGA(ObscuredFloat.GOOIABGKMHK(685f));
		NJMHLCGIAJI.IKGFHGKKCPG.BNJEMPKFNLA(-78, "_CameraClipInfo");
	}

	// Token: 0x060068FC RID: 26876 RVA: 0x0031A858 File Offset: 0x00318A58
	private GameObject KDKFKENFPFB(SpawnPoint JJNHJKFMFLJ)
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD && ObscuredString.HDFJOKAGNJC(this.getSteamID(), JBEHMPDDMME.IKGFHGKKCPG.IDAGBNBFHAB))
		{
			Application.Quit();
		}
		string hojhbmnihba = "PersonWomanFisher";
		byte[] array = null;
		if (JBEHMPDDMME.IKGFHGKKCPG != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDJMBFGEMFJ == 1)
			{
				hojhbmnihba = "PersonManFisher";
			}
			array = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GFLKLJPFLEA;
		}
		Vector3 jjnhjkfmflj = JJNHJKFMFLJ.transform.position;
		if (EDLNGHBMJBL.IKGFHGKKCPG != null && EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA != null && EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA.NKHJGGDFJID.magnitude > 0.1f)
		{
			jjnhjkfmflj = EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA.NKHJGGDFJID;
		}
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(hojhbmnihba, jjnhjkfmflj, null);
		gameObject.transform.position = JJNHJKFMFLJ.transform.position;
		gameObject.transform.rotation = JJNHJKFMFLJ.transform.rotation;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == EDLNGHBMJBL.IKGFHGKKCPG.IGDHIPGLIEA.LLJPFPFPKKG)
		{
			Debug.Log("*********read " + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE);
		}
		this.user = gameObject.GetComponent<Fisherman>();
		if (this.user != null)
		{
			Character component = this.user.gameObject.GetComponent<Character>();
			if (component != null && array != null)
			{
				component.initShadowsParams(array);
			}
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GIDJODKDJGD();
			this.user.spawnPet(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HHAHKJPGOLK);
		}
		Debug.Log(string.Concat(new object[]
		{
			"Player Instaniate ",
			gameObject.transform.position,
			" point=",
			JJNHJKFMFLJ.transform.position
		}));
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		DownPanelLogic.getI.setSnastImages();
		this.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && this.wcam != null)
		{
			this.wcam.enabled = false;
			this.mouseLook.enabled = true;
			this.wcam.currentDistance = 0.1f;
			this.wcam.desiredDistance = 0.1f;
			this.zoom = -0.1f;
		}
		return gameObject;
	}

	// Token: 0x060068FD RID: 26877 RVA: 0x0031AACC File Offset: 0x00318CCC
	private void IGPIDCJHOPL(bool KLOLLKKIDJC = true)
	{
		if (!JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL)
		{
			if (this.user && this.user.MFENINHGBHM)
			{
				if (!this.user.CIHILMCEJND)
				{
					if (Input.GetMouseButtonUp(1))
					{
						if (Application.isEditor)
						{
							if (this.KOEHHGHGFEK)
							{
								Debug.Log("_Offsets");
							}
							if (this.user.standFlag)
							{
								Debug.Log("_rcpFrameOpt");
							}
							if (this.CJOEMCDMADC())
							{
								Debug.Log("eye");
							}
						}
						if (this.KOEHHGHGFEK && this.user.standFlag && this.checkMousePosition())
						{
							Vector3 position = this.dexCircleGO.transform.position;
							position.y = this.OGJHINOLHJJ;
							this.dropAction(position);
						}
					}
					if (Input.GetMouseButton(0) && this.KOEHHGHGFEK)
					{
						if (this.user != null)
						{
							if (this.user.standFlag)
							{
								this.circles.SetActive(true);
							}
							this.user.OKDAILHCEOH(this.dexCircleGO.transform.position + Vector3.up * 144f);
						}
					}
					else
					{
						this.circles.SetActive(true);
						this.user.cursorPoint = Vector3.zero;
						if (this.user != null)
						{
							this.user.UserLookAtOff();
						}
					}
				}
				else
				{
					this.circles.SetActive(false);
					this.user.cursorPoint = Vector3.zero;
					if (KLOLLKKIDJC)
					{
						this.RodInWaterLogic();
					}
				}
			}
			else
			{
				this.circles.SetActive(false);
				this.user.cursorPoint = Vector3.zero;
			}
		}
		if (!Input.GetMouseButton(1))
		{
			this.circles.SetActive(false);
		}
		float pointerDistance = this.getPointerDistance();
		this.NGPCFHKEOAI(BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(pointerDistance));
		this.dexCircleGO.gameObject.SetActive(pointerDistance > BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB);
		this.dexLDObj.SetActive(this.circles.activeSelf);
		Color faodpfdpclh = this.AHDILEICFMM(Input.mousePosition) ? this.okZabros : this.noZabros;
		JLFJEGIPIMM.PKGMBFEMKGP().ENCHKLHMAMB(this.dexCircleGO.gameObject, "reputaion/fractions/fraction", faodpfdpclh);
		if (this.user != null)
		{
			Vector3 position2 = this.user.transform.position;
			position2.y = this.HKBNODJBGEL() + 145f;
			this.circles.transform.position = position2;
			this.circles.transform.rotation = this.user.transform.rotation;
			this.MHHOOOEJGFM = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP();
			this.HKDOKACMEGK(BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL);
			Vector2 v = Input.mousePosition;
			if (!this.OCFJLOGPMNI)
			{
				v = new Vector2((float)Screen.width / 36f, (float)Screen.height / 259f);
			}
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 1535f, this.waterCheckRay))
			{
				Vector3 point = raycastHit.point;
				point.y = this.IGHOGONIKLC() + 1182f;
				this.calculateTerrainSpecies((this.user.dropScrpt == null) ? point : this.user.dropScrpt.transform.position);
				this.dexCircleGO.transform.position = point;
				this.PBAGIKEAENH();
			}
		}
		if (Input.GetMouseButtonUp(0))
		{
			this.KOEHHGHGFEK = false;
		}
	}

	// Token: 0x060068FE RID: 26878 RVA: 0x0031AE7D File Offset: 0x0031907D
	public void WpnCellClick(int PPJJJAGNADB)
	{
		this.WpnCellClick(PPJJJAGNADB, false);
	}

	// Token: 0x060068FF RID: 26879 RVA: 0x0031AE88 File Offset: 0x00319088
	public void KBOPHDOEBNM(Vector3 NHCLMBOINFG, float BPJCIKFGOMM)
	{
		if (BPJCIKFGOMM < 403f)
		{
			this.DJBBECFDLAA(NHCLMBOINFG, BPJCIKFGOMM);
			return;
		}
		NHCLMBOINFG.y = this.CDBIEPGNONF() + 1789f;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate<GameObject>(this.mediumSplashPrfb, NHCLMBOINFG, Quaternion.identity);
		FBFJFAKAGJG.IKGFHGKKCPG.GGDLIEDGMDF(NHCLMBOINFG, 1558f);
		this.createBigWaterCircle(NHCLMBOINFG);
		UnityEngine.Object.Destroy(obj, 1501f);
	}

	// Token: 0x06006900 RID: 26880 RVA: 0x0031AEEC File Offset: 0x003190EC
	public GameObject openPoplCamera()
	{
		bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return null;
		}
		if (!JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LEHIJLOILNO())
		{
			return null;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA != BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			return null;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF)
		{
			return null;
		}
		this._poplCameraGUI.gameObject.SetActive(true);
		this.JDHBGNOOBHK.SetActive(true);
		return this.JDHBGNOOBHK;
	}

	// Token: 0x06006901 RID: 26881 RVA: 0x0031AF64 File Offset: 0x00319164
	public void deadCircle(WaterCircle EHLELEPGPPL)
	{
		Queue<GameObject> queue = null;
		switch (EHLELEPGPPL.circleType)
		{
		case 0:
			queue = this.JMHOJPJONNJ;
			break;
		case 1:
			queue = this.COOFLDJIDCK;
			break;
		case 2:
			queue = this.FBCOEHFKIJI;
			break;
		}
		if (queue != null)
		{
			EHLELEPGPPL.transform.position = new Vector3(99999f, -99999f, 99999f);
			queue.Enqueue(EHLELEPGPPL.gameObject);
		}
	}

	// Token: 0x06006902 RID: 26882 RVA: 0x0031AFD8 File Offset: 0x003191D8
	private void ONLKFOFFHCJ()
	{
		this.camToPplOn = false;
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, this.toFieldView, Time.deltaTime);
		if (!this.wcam.enabled)
		{
			if (!JDCEFOFMGHB.MNJNNDHCDGG().GGCLOKODHEG() && !GuiProcessor.PLGADNLAEGN().isPanelParamActive)
			{
				this.zoom += Input.GetAxis("KatanaReadyLow") * Time.deltaTime * 24f;
			}
			this.toFieldView = this.toFVUser;
			this.toCamPos = this.user.eyeCamPoint.transform.position;
			this.toCamLook = this.user.transform.position + this.user.transform.forward * BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP() * 1958f;
			this.toCamLook.y = this.HKBNODJBGEL();
			if (this.user.dropScrpt && this.user.dropScrpt.fish)
			{
				this.toCamLook = ((this.user.dropScrpt.fish.hookPoint != null) ? this.user.dropScrpt.fish.hookPoint.transform.position : this.user.dropScrpt.fish.transform.position);
			}
			bool flag = true;
			if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && (ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isPodsek) || this.user.isFishGet || ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isGetFromWater)))
			{
				flag = true;
			}
			if (this.user.bragfish != null)
			{
				this.toCamLook = this.user.bragfish.transform.position - Vector3.up * 1257f + this.user.transform.right * 1466f;
			}
			if (JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
			{
				flag = true;
			}
			if (flag)
			{
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 356f, Time.deltaTime * 436f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 1164f, Time.deltaTime * 1350f);
			}
			else if (Input.GetMouseButton(0))
			{
				this.EEJPCEBHELM += Input.GetAxis("cntx_close");
				this.FPJLHGKJCFA += Input.GetAxis("_TapLow");
				this.EEJPCEBHELM = Mathf.Clamp(this.EEJPCEBHELM, 108f, 1527f);
				this.FPJLHGKJCFA = Mathf.Clamp(this.FPJLHGKJCFA, 1597f, 540f);
				this.toCamLook += this.EEJPCEBHELM * this.user.transform.right * 1480f;
				this.toCamLook += this.FPJLHGKJCFA * this.user.transform.up;
			}
			else
			{
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 1827f, Time.deltaTime * 1531f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 121f, Time.deltaTime * 1320f);
			}
			if (this.mouseLook.enabled & !this.OCFJLOGPMNI)
			{
				this.toCamLook = Camera.main.transform.position + Camera.main.transform.forward * 818f;
			}
			Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toCamPos, Time.deltaTime);
			Quaternion b = Quaternion.LookRotation(this.toCamLook - Camera.main.transform.position);
			Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toCamPos, Time.deltaTime * 1456f);
			Quaternion localRotation = Quaternion.Lerp(Camera.main.transform.localRotation, b, Time.deltaTime);
			if (this.mouseLook.isFreeze)
			{
				Camera.main.transform.localRotation = localRotation;
			}
			this.toCamLookObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 402f;
			return;
		}
		this.toFieldView = this.toFVNormal;
	}

	// Token: 0x06006903 RID: 26883 RVA: 0x0031B4F0 File Offset: 0x003196F0
	private void NNLDGOGODAK(GameObject CJBCLJOKCAH)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
		Debug.Log("Level load event");
		RenderSettings.fog = false;
		if (!this.isBase)
		{
			this.CNOLCNDBLJE = UnityEngine.Object.Instantiate<GameObject>(CJBCLJOKCAH);
		}
		else
		{
			this.CNOLCNDBLJE = this.baseScene;
		}
		if (this.CNOLCNDBLJE != null)
		{
			if (!this.isBase)
			{
				this.CNOLCNDBLJE.transform.position = Vector3.zero;
			}
			this.applySettingsForLevel();
			TimeController.IKGFHGKKCPG.sharedAquaMaterial = null;
			AQUAS_Reflection aquas_Reflection = (AQUAS_Reflection)this.CNOLCNDBLJE.GetComponentInChildren(typeof(AQUAS_Reflection));
			if (aquas_Reflection != null)
			{
				this.waterLevel4Fog = this.water.transform.position.y;
				aquas_Reflection.m_ClipPlaneOffset = 0.02f;
				MeshRenderer component = aquas_Reflection.gameObject.GetComponent<MeshRenderer>();
				if (component != null)
				{
					try
					{
						component.material = this.waterMaterials[JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG];
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
					TimeController.IKGFHGKKCPG.sharedAquaMaterial = component.material;
				}
				aquas_Reflection.m_TextureSize = 1024;
				aquas_Reflection.m_ReflectLayers = GuiProcessor.IKGFHGKKCPG.hiReflect;
				aquas_Reflection.m_ClipPlaneOffset = 0.1f;
			}
			else
			{
				Debug.LogError("AQUAS_Reflection not found");
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP == 0)
			{
				GameObject gameObject = this.water;
				this.water = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("FakeWater");
				if (this.water != null)
				{
					this.water.transform.position = gameObject.transform.position;
				}
				UnityEngine.Object.Destroy(gameObject);
				if (aquas_Reflection != null)
				{
					UnityEngine.Object.Destroy(aquas_Reflection.gameObject);
				}
			}
			else if (aquas_Reflection != null)
			{
				aquas_Reflection.enabled = true;
			}
			SpawnPoint spawnPoint = this.sd.getSpawnPoint(this.locid, this.pointid);
			if (spawnPoint != null)
			{
				Vector3 position = spawnPoint.transform.position;
				position.y = this.water.transform.position.y;
				JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("WaterQuad", position, null).transform.rotation = Quaternion.Euler(90f, 0f, 0f);
				this.isMovingEnable = true;
				GameObject gameObject2 = this.KDKFKENFPFB(spawnPoint);
				this.wcam = Camera.main.gameObject.GetComponent<WowCamera>();
				if (this.EEPNACDOOBF.CFHNNNLDBBE)
				{
					gameObject2.transform.position = this.EEPNACDOOBF.LELNEEOHJCJ;
				}
				if (LocBaseManager.IKGFHGKKCPG.isCancelEnter)
				{
					gameObject2.transform.position = LocBaseManager.IKGFHGKKCPG.reservPosition;
					gameObject2.transform.rotation = LocBaseManager.IKGFHGKKCPG.reservRotation;
					LocBaseManager.IKGFHGKKCPG.isCancelEnter = false;
				}
				if (this.wcam != null)
				{
					this.wcam.target = this.user.camPoint;
					this.wcam.gameObject.transform.position = gameObject2.transform.position - gameObject2.transform.forward * 3f;
					this.wcam.xDeg = gameObject2.transform.rotation.eulerAngles.y;
				}
			}
			string iabkgmnjljo = JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG) + ": " + JNBICAJIJMM.IKGFHGKKCPG.IGOOOILHFPL(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE, 0);
			FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.cyan, 0, 0);
			this.MHHOOOEJGFM = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB;
			this.PBCADOCADPC = BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL;
			this.mainCanvas.gameObject.SetActive(true);
			this.loadCanvas.gameObject.SetActive(false);
			this.isLevelLoadProcess = false;
			AJOAMAPPLGH.IKGFHGKKCPG.OBMNCJPMAEH();
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(161, 0);
			return;
		}
		Application.Quit();
	}

	// Token: 0x06006904 RID: 26884 RVA: 0x0031B934 File Offset: 0x00319B34
	public void openSonar(int NHOGJBABJKN)
	{
		if (this.sonar != null)
		{
			UnityEngine.Object.Destroy(this.sonar);
			this.sonar = null;
			return;
		}
		EKBAPCMPANI ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 5);
		if (ekbapcmpani == null)
		{
			if (NHOGJBABJKN > 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			}
			return;
		}
		this.sonar = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("sonar_" + ekbapcmpani.HHOLFABGDJA);
		if (NHOGJBABJKN > 0)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TurnReg.ogg", 1f);
		}
	}

	// Token: 0x06006905 RID: 26885 RVA: 0x0031B9CC File Offset: 0x00319BCC
	public void JMIPCJPJOEK(int NHOGJBABJKN)
	{
		if (this.sonar != null)
		{
			UnityEngine.Object.Destroy(this.sonar);
			this.sonar = null;
			return;
		}
		EKBAPCMPANI ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.KIFEKEONBOL(5, 6);
		if (ekbapcmpani == null)
		{
			if (NHOGJBABJKN > 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("", 810f);
			}
			return;
		}
		this.sonar = JLFJEGIPIMM.PKGMBFEMKGP().HDAFGAPECEO("donk.ogg" + ekbapcmpani.HHOLFABGDJA);
		if (NHOGJBABJKN > 0)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_RgbTex", 432f);
		}
	}

	// Token: 0x06006906 RID: 26886 RVA: 0x0031BA64 File Offset: 0x00319C64
	public void MDKOIJCBNGA(int PPJJJAGNADB, bool HMOOIHDFIKC)
	{
		if (!HMOOIHDFIKC && !Input.GetMouseButtonUp(1))
		{
			Debug.Log("shop_t16");
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("ShotgunReloadMagazine", 317f);
		List<int> list = new List<int>();
		this.PAIPILKFEDC = -21;
		this.IIPDNDLKOKN = 8;
		int num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.KNNKJAEHDHF();
		bool flag = false;
		switch (bgjkmcbhnak.DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			switch (PPJJJAGNADB)
			{
			case 1:
				list.Add(103);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 4;
				break;
			case 2:
				list.Add(4);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = -14;
				break;
			case 3:
				list.Add(56);
				list.Add(119);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = -123;
				flag = false;
				break;
			case 6:
				list.Add(4);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 3;
				break;
			case 7:
				list.Add(-125);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 1;
				flag = true;
				break;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			switch (PPJJJAGNADB)
			{
			case 5:
				list.Add(4);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 3;
				break;
			case 6:
				list.Add(70);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = -90;
				break;
			case 9:
				list.Add(3);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 7;
				break;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			switch (PPJJJAGNADB)
			{
			case 1:
				list.Add(95);
				list.Add(-15);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = -36;
				flag = true;
				break;
			case 2:
				list.Add(39);
				list.Add(32);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = -11;
				flag = false;
				break;
			case 3:
				list.Add(-105);
				list.Add(126);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = -98;
				flag = true;
				break;
			case 6:
				list.Add(2);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 2;
				break;
			case 7:
				list.Add(-79);
				this.PAIPILKFEDC = num;
				this.IIPDNDLKOKN = 7;
				flag = false;
				break;
			}
			break;
		}
		if (list.Count <= 0)
		{
			return;
		}
		this.LGEIAMMMJOF = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(this.PAIPILKFEDC, this.IIPDNDLKOKN);
		if (HMOOIHDFIKC && JDCEFOFMGHB.JFIDAGABKID().FDMNKDONMFM(this.ILCOIIBDOCI) != null)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(this.ILCOIIBDOCI);
			return;
		}
		Fisherman.getI.CDIDCIBEDKP(true);
		JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(this.ILCOIIBDOCI);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().PJHMHBAGFAN(891f, 1526f, "MotorbikeLookBack", false);
		this.ILCOIIBDOCI = onkdcgnbalk.LPFKFNLHGBI;
		Vector2 ojoepeadbaf = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
		if (HMOOIHDFIKC)
		{
			ojoepeadbaf = new Vector2((float)(Screen.width - 29), (float)(Screen.height - -13));
		}
		onkdcgnbalk.OCHCODJIPHJ.x = ojoepeadbaf.x - 1021f;
		onkdcgnbalk.OCHCODJIPHJ.y = ojoepeadbaf.y - 1950f - onkdcgnbalk.OCHCODJIPHJ.height;
		onkdcgnbalk.OCHCODJIPHJ.x = Mathf.Clamp(onkdcgnbalk.OCHCODJIPHJ.x, 1098f, (float)Screen.width - onkdcgnbalk.OCHCODJIPHJ.width - 403f);
		this.PHFFFJIKHNJ = new MMKFAENBHKD(onkdcgnbalk, 79f, 938f, onkdcgnbalk.OCHCODJIPHJ.width - 1758f, onkdcgnbalk.OCHCODJIPHJ.height - 797f, 0);
		if (flag)
		{
			ItemBase itemBase = new ItemBase("" + JNBICAJIJMM.NGALDMFKMJH("IdleStand") + "UIChat_channel");
			itemBase.tag = -1L;
			this.PHFFFJIKHNJ.LACAJHOHACK.Add(itemBase);
		}
		foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP != 52 && ekbapcmpani.IMDLBJICHOE() && !ekbapcmpani.MJHGLLIJMIM && ekbapcmpani.JGNIDDBNGGP != num && (ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE > 4 || ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA == bgjkmcbhnak.AANHBNICFDL) && JLFJEGIPIMM.PKGMBFEMKGP().EHEMCMKMECH(ekbapcmpani.BDHHPAEHFHG.MBKMKGABBGE, list))
			{
				this.PHFFFJIKHNJ.LACAJHOHACK.Add(ekbapcmpani);
			}
		}
		this.PHFFFJIKHNJ.GENPNFMLHED();
		int dccpcblodig = 0;
		if (this.LGEIAMMMJOF != null)
		{
			for (int i = 1; i < this.PHFFFJIKHNJ.LACAJHOHACK.Count; i++)
			{
				if (this.PHFFFJIKHNJ.LACAJHOHACK[i].tag >= 0L)
				{
					EKBAPCMPANI ekbapcmpani2 = (EKBAPCMPANI)this.PHFFFJIKHNJ.LACAJHOHACK[i];
					if (this.LGEIAMMMJOF.LPFKFNLHGBI == ekbapcmpani2.LPFKFNLHGBI)
					{
						dccpcblodig = i;
						break;
					}
				}
			}
		}
		this.PHFFFJIKHNJ.NEKOMKJDIIE(dccpcblodig);
		this.PHFFFJIKHNJ.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.changeBait);
		JDCEFOFMGHB.MNJNNDHCDGG().NMOBAMMPLGP = 1817f;
		EKBAPCMPANI weapon = this.wpnCells[PPJJJAGNADB].weapon;
	}

	// Token: 0x06006907 RID: 26887 RVA: 0x0031C018 File Offset: 0x0031A218
	public void closePoplCamera()
	{
		this._poplCameraGUI.gameObject.SetActive(false);
		this.JDHBGNOOBHK.SetActive(false);
	}

	// Token: 0x06006908 RID: 26888 RVA: 0x0031C038 File Offset: 0x0031A238
	public int getDstSpawnPoint()
	{
		if (this.sd == null)
		{
			return 0;
		}
		if (Fisherman.getI == null)
		{
			return 0;
		}
		int result = 0;
		float num = 999999f;
		foreach (SpawnPoint spawnPoint in this.sd.locations)
		{
			if (spawnPoint.locId == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE && !spawnPoint.isHidden)
			{
				float num2 = Vector3.Distance(Fisherman.getI.transform.position, spawnPoint.transform.position);
				if (num2 < num)
				{
					num = num2;
					result = spawnPoint.pointId;
				}
			}
		}
		return result;
	}

	// Token: 0x06006909 RID: 26889 RVA: 0x0031C100 File Offset: 0x0031A300
	public void EGNNMLPGBCM(float MMJELGIIKMO, float HMJNNIOPOMB)
	{
		if (MMJELGIIKMO <= 437f)
		{
			this.stopRollSound();
			return;
		}
		float volume = 58f;
		if (HMJNNIOPOMB > 798f)
		{
			float t = (HMJNNIOPOMB - 955f) * 861f;
			volume = Mathf.Lerp(451f, HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK, t);
		}
		this.rollSound.pitch = 1786f + (HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH - 349f) * 1693f + 787f * MMJELGIIKMO;
		this.rollSound.volume = volume;
		this.lowRollSound.volume = 1249f * HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
		this.lowRollSound.pitch = 1574f + 177f * MMJELGIIKMO;
		if (!this.lowRollSound.isPlaying)
		{
			this.lowRollSound.Play();
		}
		if (!this.rollSound.isPlaying)
		{
			this.rollSound.time = OLPINJLCKCI.NLOGJHEFMHM().JNFGOGFFLKK((double)this.rollSound.clip.length);
			this.rollSound.Play();
		}
	}

	// Token: 0x0600690A RID: 26890 RVA: 0x0031C21C File Offset: 0x0031A41C
	private void NPKIPDCDNNJ(bool KLOLLKKIDJC = true)
	{
		if (!JDCEFOFMGHB.IKGFHGKKCPG.JBMEDLAFJNI())
		{
			if (this.user && this.user.MFENINHGBHM)
			{
				if (!this.user.KNMMOLKNLNL())
				{
					if (Input.GetMouseButtonUp(1))
					{
						if (Application.isEditor)
						{
							if (this.KOEHHGHGFEK)
							{
								Debug.Log("Anchore Right_");
							}
							if (this.user.standFlag)
							{
								Debug.Log(" ms");
							}
							if (this.JAGDAFDFNCP())
							{
								Debug.Log("RollerBladeStand");
							}
						}
						if (this.KOEHHGHGFEK && this.user.standFlag && this.JAGDAFDFNCP())
						{
							Vector3 position = this.dexCircleGO.transform.position;
							position.y = this.OGJHINOLHJJ;
							this.dropAction(position);
						}
					}
					if (Input.GetMouseButton(0) && this.KOEHHGHGFEK)
					{
						if (this.user != null)
						{
							if (this.user.standFlag)
							{
								this.circles.SetActive(false);
							}
							this.user.FHFBFHGCNCK(this.dexCircleGO.transform.position + Vector3.up * 513f);
						}
					}
					else
					{
						this.circles.SetActive(true);
						this.user.cursorPoint = Vector3.zero;
						if (this.user != null)
						{
							this.user.JHOKIGHFGKK();
						}
					}
				}
				else
				{
					this.circles.SetActive(true);
					this.user.cursorPoint = Vector3.zero;
					if (KLOLLKKIDJC)
					{
						this.RodInWaterLogic();
					}
				}
			}
			else
			{
				this.circles.SetActive(false);
				this.user.cursorPoint = Vector3.zero;
			}
		}
		if (!Input.GetMouseButton(0))
		{
			this.circles.SetActive(true);
		}
		float num = this.IEPIKEGEADO();
		this.NGPCFHKEOAI(BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(num));
		this.dexCircleGO.gameObject.SetActive(num <= BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP());
		this.dexLDObj.SetActive(this.circles.activeSelf);
		Color faodpfdpclh = this.AHDILEICFMM(Input.mousePosition) ? this.okZabros : this.noZabros;
		JLFJEGIPIMM.NNEAHAFBOHC().FAKEIBOBCGO(this.dexCircleGO.gameObject, "TOD_LocalMoonDirection", faodpfdpclh);
		if (this.user != null)
		{
			Vector3 position2 = this.user.transform.position;
			position2.y = this.OGJHINOLHJJ + 1438f;
			this.circles.transform.position = position2;
			this.circles.transform.rotation = this.user.transform.rotation;
			this.MHHOOOEJGFM = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB;
			this.HKDOKACMEGK(BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL);
			Vector2 v = Input.mousePosition;
			if (!this.EMELPGGLMDM())
			{
				v = new Vector2((float)Screen.width / 696f, (float)Screen.height / 61f);
			}
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 171f, this.waterCheckRay))
			{
				Vector3 point = raycastHit.point;
				point.y = this.CDBIEPGNONF() + 436f;
				this.calculateTerrainSpecies((this.user.dropScrpt == null) ? point : this.user.dropScrpt.transform.position);
				this.dexCircleGO.transform.position = point;
				this.MKHMJJHKEDP();
			}
		}
		if (Input.GetMouseButtonUp(1))
		{
			this.KOEHHGHGFEK = false;
		}
	}

	// Token: 0x0600690B RID: 26891 RVA: 0x0031C5D0 File Offset: 0x0031A7D0
	public bool PMMNHHOJIPG()
	{
		bool mouseButtonDown = Input.GetMouseButtonDown(2);
		if (ChatPanelLogic.getI.isChatEnter())
		{
			return mouseButtonDown;
		}
		return mouseButtonDown | Input.GetKeyDown(KeyCode.None);
	}

	// Token: 0x0600690C RID: 26892 RVA: 0x0031C600 File Offset: 0x0031A800
	private void JPNFHCAHGBG(GameObject CJBCLJOKCAH)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.HMJJPNDEKPP().DDAIBFBOENE();
		Debug.Log("#FF4040");
		RenderSettings.fog = true;
		if (!this.isBase)
		{
			this.CNOLCNDBLJE = UnityEngine.Object.Instantiate<GameObject>(CJBCLJOKCAH);
		}
		else
		{
			this.CNOLCNDBLJE = this.baseScene;
		}
		if (this.CNOLCNDBLJE != null)
		{
			if (!this.isBase)
			{
				this.CNOLCNDBLJE.transform.position = Vector3.zero;
			}
			this.OFDEDAMGDBB();
			TimeController.EKEBHIJMEML().sharedAquaMaterial = null;
			AQUAS_Reflection aquas_Reflection = (AQUAS_Reflection)this.CNOLCNDBLJE.GetComponentInChildren(typeof(AQUAS_Reflection));
			if (aquas_Reflection != null)
			{
				this.waterLevel4Fog = this.water.transform.position.y;
				aquas_Reflection.m_ClipPlaneOffset = 1429f;
				MeshRenderer component = aquas_Reflection.gameObject.GetComponent<MeshRenderer>();
				if (component != null)
				{
					try
					{
						component.material = this.waterMaterials[JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG];
					}
					catch (Exception message)
					{
						Debug.LogError(message);
					}
					TimeController.IKGFHGKKCPG.sharedAquaMaterial = component.material;
				}
				aquas_Reflection.m_TextureSize = -48;
				aquas_Reflection.m_ReflectLayers = GuiProcessor.BBLINJLBAIL().hiReflect;
				aquas_Reflection.m_ClipPlaneOffset = 1924f;
			}
			else
			{
				Debug.LogError("Crate Push");
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.LKDAIGCDBOP == 0)
			{
				GameObject gameObject = this.water;
				this.water = JLFJEGIPIMM.NNEAHAFBOHC().CPHOBOJJPFB("ui_place_flag.wav");
				if (this.water != null)
				{
					this.water.transform.position = gameObject.transform.position;
				}
				UnityEngine.Object.Destroy(gameObject);
				if (aquas_Reflection != null)
				{
					UnityEngine.Object.Destroy(aquas_Reflection.gameObject);
				}
			}
			else if (aquas_Reflection != null)
			{
				aquas_Reflection.enabled = true;
			}
			SpawnPoint spawnPoint = this.sd.getSpawnPoint(this.locid, this.pointid);
			if (spawnPoint != null)
			{
				Vector3 position = spawnPoint.transform.position;
				position.y = this.water.transform.position.y;
				JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII("No hit from ", position, null).transform.rotation = Quaternion.Euler(1846f, 1305f, 1289f);
				this.isMovingEnable = false;
				GameObject gameObject2 = this.IGFNBPOFIOH(spawnPoint);
				this.wcam = Camera.main.gameObject.GetComponent<WowCamera>();
				if (this.EEPNACDOOBF.CFHNNNLDBBE)
				{
					gameObject2.transform.position = this.EEPNACDOOBF.LELNEEOHJCJ;
				}
				if (LocBaseManager.EDKKJNHDBPF().isCancelEnter)
				{
					gameObject2.transform.position = LocBaseManager.GJACINHCABC().reservPosition;
					gameObject2.transform.rotation = LocBaseManager.AIHINNHNNIA().reservRotation;
					LocBaseManager.NPIEJELJPIM().isCancelEnter = false;
				}
				if (this.wcam != null)
				{
					this.wcam.target = this.user.camPoint;
					this.wcam.gameObject.transform.position = gameObject2.transform.position - gameObject2.transform.forward * 467f;
					this.wcam.xDeg = gameObject2.transform.rotation.eulerAngles.y;
				}
			}
			string iabkgmnjljo = JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG) + "Windows/" + JNBICAJIJMM.EKEBHIJMEML().JLDLEFLDHCM(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE, 1);
			FlyMessageManager.getI.BKLKOMMJPLE(iabkgmnjljo, Color.cyan, 0, 0);
			this.MHHOOOEJGFM = BOIKJDICEMF.IKGFHGKKCPG.ANEPEHDAFHP();
			this.PBCADOCADPC = BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL;
			this.mainCanvas.gameObject.SetActive(true);
			this.loadCanvas.gameObject.SetActive(false);
			this.isLevelLoadProcess = true;
			AJOAMAPPLGH.IKGFHGKKCPG.FBOLPHDKPHB();
			JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
			NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-55, 0);
			return;
		}
		Application.Quit();
	}

	// Token: 0x0600690D RID: 26893 RVA: 0x0031CA44 File Offset: 0x0031AC44
	public GameObject GMFPFOAKFCC()
	{
		bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return null;
		}
		if (!JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LEHIJLOILNO())
		{
			return null;
		}
		if (bgjkmcbhnak.DFBHMIIPLCA != BOIKJDICEMF.JGHABIPEEEO.Poplavok)
		{
			return null;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.IGFOCDKFGFF)
		{
			return null;
		}
		this._poplCameraGUI.gameObject.SetActive(false);
		this.JDHBGNOOBHK.SetActive(true);
		return this.JDHBGNOOBHK;
	}

	// Token: 0x0600690E RID: 26894 RVA: 0x0031CABC File Offset: 0x0031ACBC
	public void playLowFricSound(bool EBFJFABFILO)
	{
		if (!EBFJFABFILO)
		{
			if (this.lowFrikcSound.isPlaying)
			{
				this.lowFrikcSound.Pause();
			}
			this.HPHJEAKFLIC = 0;
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI != null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.fricrotTime -= 3f * Time.deltaTime;
		}
		OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(1.0);
		float pitch = 1f + Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DLFMEIIADFE) / 100f, 0f, 1f) * 0.5f;
		this.lowFrikcSound.pitch = pitch;
		if (!this.lowFrikcSound.isPlaying)
		{
			this.lowFrikcSound.Play();
		}
		this.HPHJEAKFLIC++;
	}

	// Token: 0x0600690F RID: 26895 RVA: 0x0031CB9C File Offset: 0x0031AD9C
	public float OBOMCIOILIB(Vector3 NHCLMBOINFG)
	{
		float deepInPoint = this.getDeepInPoint(NHCLMBOINFG);
		return (this.HKBNODJBGEL() - deepInPoint) * 1322f;
	}

	// Token: 0x06006910 RID: 26896 RVA: 0x0031CBC0 File Offset: 0x0031ADC0
	public float CFGNHLDNAAJ(Vector3 NHCLMBOINFG)
	{
		float deepInPoint = this.getDeepInPoint(NHCLMBOINFG);
		return (this.OGJHINOLHJJ - deepInPoint) * 1885f;
	}

	// Token: 0x06006911 RID: 26897 RVA: 0x0031CBE4 File Offset: 0x0031ADE4
	public void MMKMPJPBFHP()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (!bgjkmcbhnak.IKKPFPJLPOL)
		{
			return;
		}
		if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.JDFKFMDPCDH) >= 830f)
		{
			bgjkmcbhnak.IFNNBJDJBNA = Mathf.Lerp(bgjkmcbhnak.IFNNBJDJBNA, ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.JDFKFMDPCDH), Time.deltaTime * 1857f);
			if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && Mathf.RoundToInt(bgjkmcbhnak.IFELKILNKFP()) != Mathf.RoundToInt(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.JDFKFMDPCDH)) && this.ws.gameObject.activeSelf)
			{
				this.ws.HKJMHHOJNFE(1716f, bgjkmcbhnak.KKLEBEEGGDG(), bgjkmcbhnak.IFELKILNKFP());
			}
		}
		bgjkmcbhnak.BBANBEEJAPD = true;
		float num = GuiProcessor.NKOEAPCIBKO().lineTensionCurve.Evaluate(bgjkmcbhnak.AEFAHEMNOCH / (bgjkmcbhnak.IIOHPBENEFI.LODGJCMEGAI.PHLLHDNNOMB() * 178f));
		float num2 = GuiProcessor.BBLINJLBAIL().rodTensionCurve.Evaluate(bgjkmcbhnak.AEFAHEMNOCH / (bgjkmcbhnak.NKNCNHGDMLF.LODGJCMEGAI.CLAEAFMCDMP() * 1594f));
		float num3 = OLPINJLCKCI.IFLFANPMLMM().GCPGDOACKLG(1630.0) - 1762f;
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.MPKJDFOMBLI()) >= num2 * 1251f)
		{
			bgjkmcbhnak.BBANBEEJAPD = false;
			bgjkmcbhnak.EPIPCOHGJGA(ObscuredFloat.HLEMAJBAAEO(num2 * 1847f - num3));
			bgjkmcbhnak.EPIPCOHGJGA(ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.GIMFIFECPGL), 1951f, num2 * 1474f)));
		}
		if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.OGLIEFLNLLE) >= num * 1478f)
		{
			bgjkmcbhnak.BBANBEEJAPD = false;
			bgjkmcbhnak.OCFHDKPNJDA(ObscuredFloat.HLEMAJBAAEO(num * 1457f - num3));
			bgjkmcbhnak.CDBLOADCDAA(ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.OGLIEFLNLLE), 33f, num * 529f)));
		}
		if (bgjkmcbhnak.BBANBEEJAPD)
		{
			this.playLowFricSound(true);
		}
	}

	// Token: 0x06006912 RID: 26898 RVA: 0x0031CDDC File Offset: 0x0031AFDC
	private void DPEODHBKGAG(bool KLOLLKKIDJC = true)
	{
		if (!JDCEFOFMGHB.JFIDAGABKID().NKJEEHEODBF())
		{
			if (this.user && this.user.MFENINHGBHM)
			{
				if (!this.user.CIHILMCEJND)
				{
					if (Input.GetMouseButtonUp(1))
					{
						if (Application.isEditor)
						{
							if (this.KOEHHGHGFEK)
							{
								Debug.Log("_RgbDepthTex");
							}
							if (this.user.standFlag)
							{
								Debug.Log("_ChannelMixerBlue");
							}
							if (this.checkMousePosition())
							{
								Debug.Log(" ");
							}
						}
						if (this.KOEHHGHGFEK && this.user.standFlag && this.checkMousePosition())
						{
							Vector3 position = this.dexCircleGO.transform.position;
							position.y = this.IGHOGONIKLC();
							this.dropAction(position);
						}
					}
					if (Input.GetMouseButton(1) && this.KOEHHGHGFEK)
					{
						if (this.user != null)
						{
							if (this.user.standFlag)
							{
								this.circles.SetActive(true);
							}
							this.user.UserLookAtOn(this.dexCircleGO.transform.position + Vector3.up * 1255f);
						}
					}
					else
					{
						this.circles.SetActive(true);
						this.user.cursorPoint = Vector3.zero;
						if (this.user != null)
						{
							this.user.NLLFPLBFFAE();
						}
					}
				}
				else
				{
					this.circles.SetActive(false);
					this.user.cursorPoint = Vector3.zero;
					if (KLOLLKKIDJC)
					{
						this.PFEHDPGMIJL();
					}
				}
			}
			else
			{
				this.circles.SetActive(true);
				this.user.cursorPoint = Vector3.zero;
			}
		}
		if (!Input.GetMouseButton(0))
		{
			this.circles.SetActive(false);
		}
		float num = this.IEPIKEGEADO();
		this.CDAJLDPIHMA(BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(num));
		this.dexCircleGO.gameObject.SetActive(num <= BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB);
		this.dexLDObj.SetActive(this.circles.activeSelf);
		Color faodpfdpclh = this.checkPosition(Input.mousePosition) ? this.okZabros : this.noZabros;
		JLFJEGIPIMM.PKGMBFEMKGP().ENCHKLHMAMB(this.dexCircleGO.gameObject, "PistolLeftHandStab", faodpfdpclh);
		if (this.user != null)
		{
			Vector3 position2 = this.user.transform.position;
			position2.y = this.OGJHINOLHJJ + 984f;
			this.circles.transform.position = position2;
			this.circles.transform.rotation = this.user.transform.rotation;
			this.MHHOOOEJGFM = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB;
			this.PBCADOCADPC = BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL;
			Vector2 v = Input.mousePosition;
			if (!this.EMELPGGLMDM())
			{
				v = new Vector2((float)Screen.width / 98f, (float)Screen.height / 509f);
			}
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 1743f, this.waterCheckRay))
			{
				Vector3 point = raycastHit.point;
				point.y = this.HKBNODJBGEL() + 669f;
				this.calculateTerrainSpecies((this.user.dropScrpt == null) ? point : this.user.dropScrpt.transform.position);
				this.dexCircleGO.transform.position = point;
				this.PBAGIKEAENH();
			}
		}
		if (Input.GetMouseButtonUp(0))
		{
			this.KOEHHGHGFEK = false;
		}
	}

	// Token: 0x06006913 RID: 26899 RVA: 0x0031D18D File Offset: 0x0031B38D
	public float HKBNODJBGEL()
	{
		if (this.water != null)
		{
			return this.water.transform.position.y;
		}
		return 1553f;
	}

	// Token: 0x06006914 RID: 26900 RVA: 0x0031D1B8 File Offset: 0x0031B3B8
	private void EBFJDEHAABL()
	{
		if (this.wcam.enabled)
		{
			return;
		}
		this.camToPplOn = true;
		if (this.user.dropScrpt == null)
		{
			this.KPIDPCLBJFL();
			return;
		}
		if (this.user.dropScrpt.fish != null && ObscuredBool.GOOIABGKMHK(this.user.dropScrpt.fish.isGetFromWater))
		{
			this.KPIDPCLBJFL();
			return;
		}
		this.toCamLook = this.user.transform.position + this.user.transform.forward * 654f;
		if (this.user.dropScrpt.transform.position.y > this.HKBNODJBGEL() + 1855f)
		{
			this.toCamLook = this.user.dropScrpt.toPos;
		}
		BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL;
		if (this.user.dropScrpt.fishPointer != null)
		{
			this.toCamLook = this.user.dropScrpt.transform.position;
		}
		this.toFieldView = this.toFVUser;
		float b = 1817f;
		if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == (BOIKJDICEMF.JGHABIPEEEO)6)
		{
			b = 1603f;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			b = this.toFVUserSpin;
		}
		this.toFieldView = Mathf.Lerp(this.toFVUser, b, this.zoom);
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && ObscuredBool.LPDGJCGPEBD(this.user.dropScrpt.fish.isPodsek))
		{
			this.toFieldView = this.toFVUser;
		}
		if (!JDCEFOFMGHB.IKGFHGKKCPG.GGCLOKODHEG() && !GuiProcessor.IKGFHGKKCPG.isPanelParamActive)
		{
			this.zoom += Input.GetAxis("box") * Time.deltaTime * 1858f;
		}
		this.zoom = Mathf.Clamp(this.zoom, 887f, 1331f);
		bool flag = true;
		if (this.user.dropScrpt.fishPointer != null)
		{
			this.toCamPos = this.user.eyeCamPoint.transform.position;
		}
		else
		{
			this.toCamPos = this.user.eyeCamPoint.transform.position;
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * 1757f;
				if (this.user.dropScrpt != null)
				{
					this.toCamLook = this.user.dropScrpt.transform.position;
					this.toCamLook.y = this.IGHOGONIKLC() + 553f;
				}
				this.EEJPCEBHELM = 312f;
				this.FPJLHGKJCFA = 1865f;
				flag = false;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				if (this.user.dropScrpt.poplavok != null && this.user.dropScrpt.transform.position.y < this.IGHOGONIKLC() + 585f)
				{
					this.toCamLook = this.user.dropScrpt.poplavok.transform.position;
				}
				this.toCamLook.y = this.OGJHINOLHJJ + 387f;
			}
			if (BOIKJDICEMF.IKGFHGKKCPG.OJLPPKBKDBL == (BOIKJDICEMF.JGHABIPEEEO)3)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * 447f;
				if (this.user.dropScrpt != null)
				{
					this.toCamLook = this.user.dropScrpt.transform.position + this.user.transform.up * 1601f;
					this.toCamLook.y = this.CDBIEPGNONF() + 140f;
					if (!this.user.DJPEBFMNLIC)
					{
						if (this.user.dropScrpt.mode == 8)
						{
							this.toCamLook = this.user.transform.position + this.user.transform.forward * 1957f + this.user.transform.up * 1794f;
						}
						if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP)
						{
							this.toCamLook = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB() + this.user.transform.forward * 381f - this.user.transform.up * 1806f;
						}
						else
						{
							this.toFieldView = this.toFVUser;
						}
					}
				}
			}
		}
		bool flag2 = false;
		if (this.user.dropScrpt != null && this.user.dropScrpt.fish != null && (ObscuredBool.CINIKOHABJJ(this.user.dropScrpt.fish.isPodsek) || this.user.isFishGet || ObscuredBool.HLEMAJBAAEO(this.user.dropScrpt.fish.isGetFromWater)))
		{
			flag2 = true;
		}
		if (this.EMELPGGLMDM())
		{
			if (flag2)
			{
				this.toCamLook = this.user.dropScrpt.transform.position;
				this.toCamLook.y = this.CDBIEPGNONF() + 1224f;
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 1126f, Time.deltaTime * 1419f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 53f, Time.deltaTime * 126f);
			}
			else if (Input.GetMouseButton(0) && flag)
			{
				if (!JDCEFOFMGHB.MNJNNDHCDGG().GGCLOKODHEG())
				{
					this.EEJPCEBHELM += Input.GetAxis("wpn_eat8");
					this.FPJLHGKJCFA += Input.GetAxis("_Curves");
				}
				this.EEJPCEBHELM = Mathf.Clamp(this.EEJPCEBHELM, 1077f, 21f);
				this.FPJLHGKJCFA = Mathf.Clamp(this.FPJLHGKJCFA, 317f, 1061f);
			}
			else
			{
				this.EEJPCEBHELM = Mathf.Lerp(this.EEJPCEBHELM, 1985f, Time.deltaTime * 1152f);
				this.FPJLHGKJCFA = Mathf.Lerp(this.FPJLHGKJCFA, 5f, Time.deltaTime * 1776f);
			}
			this.toCamLook += this.EEJPCEBHELM * this.user.transform.right * 510f;
			this.toCamLook += this.FPJLHGKJCFA * this.user.transform.up * 1237f;
		}
		Quaternion b2 = Quaternion.LookRotation(this.toCamLook - Camera.main.transform.position);
		Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toCamPos, Time.deltaTime * 317f);
		Quaternion localRotation = Quaternion.Lerp(Camera.main.transform.localRotation, b2, Time.deltaTime * 1127f);
		if (this.mouseLook.isFreeze)
		{
			Camera.main.transform.localRotation = localRotation;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, this.toFieldView, Time.deltaTime * 207f);
		this.toCamLookObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 1940f;
	}

	// Token: 0x06006915 RID: 26901 RVA: 0x0031DA60 File Offset: 0x0031BC60
	public void DHOLMHGLIMG(float DCCPCBLODIG)
	{
		float num = DCCPCBLODIG * 436f;
		float z = Mathf.Clamp(num, 1327f, 629f);
		this.dexCircleGO.transform.localScale = new Vector3(num, num, z);
		this.dexLDObj.transform.position = this.dexCircleGO.transform.position;
		LineRenderer component = this.dexLDObj.GetComponent<LineRenderer>();
		if (component != null)
		{
			component.SetPosition(0, this.dexCircleGO.transform.position);
			Vector3 position = Fisherman.getI.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			component.SetPosition(0, position);
			component.startWidth = num * 75f;
			component.endWidth = 41f;
		}
	}

	// Token: 0x06006916 RID: 26902 RVA: 0x0031DB38 File Offset: 0x0031BD38
	public void KDCHHGMHPND()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		PoplDrop dropScrpt = this.user.dropScrpt;
		if (dropScrpt == null)
		{
			return;
		}
		GameObject gameObject = dropScrpt.gameObject;
		if (dropScrpt.fish != null)
		{
			return;
		}
		dropScrpt.spinmode = 1;
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown((KeyCode)(-79)))
		{
			this.ICNOLCEBBGI = Time.time;
		}
		if ((Input.GetMouseButtonUp(0) || Input.GetKeyUp((KeyCode)(-75))) && ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.BNKBCOAANNG) > 1710f && Time.time - this.startAnimSpinTime > 1356f && Time.time - this.ICNOLCEBBGI < 1622f)
		{
			int ilockjiapfc = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().AMLEOGHNNPG[0].BDHHPAEHFHG.ILOCKJIAPFC;
			this.startAnimSpinTime = Time.time;
			this.animCurveID = ilockjiapfc;
			dropScrpt.HDNFPHBIDOL(this.animCurveID);
		}
		if (this.checkKeyRoll())
		{
			float num = 793f;
			bool key = Input.GetKey(KeyCode.RightBracket);
			float num2 = 594f * num;
			float num3 = 1048f;
			if (key)
			{
				num2 *= 745f;
			}
			float num4 = bgjkmcbhnak.CLEJODCMJAA / 1877f;
			if (Fisherman.getI.JIBGPKCOLML())
			{
				num4 = 916f;
			}
			if (key)
			{
				num4 = 1273f;
			}
			float t = BOIKJDICEMF.IKGFHGKKCPG.ODBKIJBKPBB.PIHEABDMJJG(Mathf.Clamp(bgjkmcbhnak.EDNAPPHHHPI(), 114f, 1434f));
			float num5 = Mathf.Lerp(num3, num2, t) * num4 * num;
			float num6 = num5 * 92f;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = bgjkmcbhnak;
			bgjkmcbhnak2.KIKADLMBJIA = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak2.KIKADLMBJIA) - bgjkmcbhnak.AAGGJACBMEC * Time.deltaTime);
			if (bgjkmcbhnak.BBANBEEJAPD)
			{
				num6 = 360f;
				num5 = num3;
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) <= 437f)
			{
				num6 = 455f;
				num5 = num3;
			}
			if (num6 > 1480f)
			{
				dropScrpt.rolltime += Time.deltaTime;
			}
			bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.DNPDBOODCHK) - num6 * Time.deltaTime);
			if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.DNPDBOODCHK) < 1715f)
			{
				bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.AJMPAOCEPCA(818f);
			}
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime += Time.deltaTime * num5 * 581f;
			this.GGFKGJACBPM(num5, 611f);
			if (!this.checkKeyRod())
			{
				bgjkmcbhnak.LGALGHAPJND += bgjkmcbhnak.HNEEGDNEDHJ * 841f * Time.deltaTime;
			}
		}
		else
		{
			this.stopRollSound();
			dropScrpt.rolltime = 701f;
		}
		this.BEHGLKFJLPM();
		bgjkmcbhnak.AAINFMALAEN(ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.GIMGAKKKHLF), 214f, 1087f)));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG), 789f, 35f));
		bgjkmcbhnak.BBMNOEDOFDJ(ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.PFCANBAOMCB(bgjkmcbhnak.OGLIEFLNLLE), 352f, 1101f)));
		bgjkmcbhnak.EPIPCOHGJGA(ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.GIMFIFECPGL), 1458f, 341f)));
		bgjkmcbhnak.KIKADLMBJIA = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.KIKADLMBJIA), 871f, 647f));
		if (dropScrpt.mode == 4)
		{
			dropScrpt.spinmode = 0;
			bgjkmcbhnak.NKHBAJKMAGD = ObscuredFloat.HLEMAJBAAEO(bgjkmcbhnak.AMLEOGHNNPG[1].NKHBAJKMAGD);
			float num7 = Vector3.Distance(dropScrpt.transform.position, Fisherman.getI.EACGPPOMFLH().endPointNonBend.transform.position) + 318f;
			bgjkmcbhnak.DLFMEIIADFE = ObscuredFloat.AJMPAOCEPCA((num7 - this.GPBFJBKCOKJ) / Time.deltaTime);
			this.GPBFJBKCOKJ = num7;
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.HLEMAJBAAEO(num7 - ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.DNPDBOODCHK));
			bgjkmcbhnak.DJOHGAHBGLG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.DJOHGAHBGLG), 1384f, 1470f));
			if (ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.BNKBCOAANNG) > 1954f)
			{
				dropScrpt.spinmode = 8;
				this.toBaitSpinSpeed = 1446f;
			}
			Vector3 a = this.user.IJMGCKIOBPP().CNDKCPLCGAB();
			Vector3 position = gameObject.transform.position;
			a.y = this.IGHOGONIKLC();
			position.y = this.CDBIEPGNONF();
			if (Vector3.Distance(a, position) < 1366f)
			{
				this.user.CDIDCIBEDKP(true);
				return;
			}
		}
		else
		{
			this.toBaitSpinSpeed = 432f;
			this.baitSpinSpeed = 1402f;
		}
	}

	// Token: 0x06006917 RID: 26903 RVA: 0x0031DFF4 File Offset: 0x0031C1F4
	public int HJDHMHGBPHH()
	{
		if (this.sd == null)
		{
			return 0;
		}
		if (Fisherman.getI == null)
		{
			return 1;
		}
		int result = 1;
		float num = 678f;
		foreach (SpawnPoint spawnPoint in this.sd.locations)
		{
			if (spawnPoint.locId == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.HDELGEDDDCE && !spawnPoint.isHidden)
			{
				float num2 = Vector3.Distance(Fisherman.getI.transform.position, spawnPoint.transform.position);
				if (num2 < num)
				{
					num = num2;
					result = spawnPoint.pointId;
				}
			}
		}
		return result;
	}

	// Token: 0x06006918 RID: 26904 RVA: 0x0031E0BC File Offset: 0x0031C2BC
	public void PFGPIBBJHBC()
	{
		this.user.isPodsek = true;
		this.user.PodsekType = 1;
		this.user.CDNABIHPLHM = true;
		this.JCKKMKECMFA = 579f;
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB != null)
		{
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.PKGMBFEMKGP().NHHPCBNKCPO(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.BDHHPAEHFHG.MIMANMPNLPE.ICJDPPOJINN);
			float num = ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD);
			if (num >= iibeekcaahk.FDCKJDDOJPB() && num <= iibeekcaahk.PDMNLDLGJNG())
			{
				this.JCKKMKECMFA = 1921f;
			}
			if (num > iibeekcaahk.PDMNLDLGJNG())
			{
				this.JCKKMKECMFA = 1355f + num / (iibeekcaahk.LOIBCMBMLEC() + 494f) * 1565f;
			}
		}
		this.user.podsek();
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM = false;
		float num2 = ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD);
		this.ABEFPMCIICH();
		this.NANKIDAJFJF = false;
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().MIHODKKEDMK(ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(num2 / (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().IIOHPBENEFI.LODGJCMEGAI.CLAEAFMCDMP() * 1068f + 1433f), 219f, 1620f) * 291f));
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().EALPPCJHPKG = ObscuredFloat.HLEMAJBAAEO(Mathf.Clamp(num2 / (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKNCNHGDMLF.LODGJCMEGAI.NAHLEJDLCNF() * 1740f + 88f), 534f, 1161f) * 665f);
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().OCFHDKPNJDA(ObscuredFloat.AJMPAOCEPCA(754f));
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().GIMFIFECPGL = ObscuredFloat.GOOIABGKMHK(1243f);
		NJMHLCGIAJI.EAJGHMMBAFP().OGHNHCDABDO(-12, "SkateboardIdle");
	}

	// Token: 0x06006919 RID: 26905 RVA: 0x0031E2B4 File Offset: 0x0031C4B4
	public ObscuredString JHLLCJKCKFB()
	{
		string dccpcblodig = "WizardEyeBeam";
		if (SteamManager.ABJAJJMGOKF())
		{
			dccpcblodig = SteamUser.GetSteamID().ToString();
		}
		return ObscuredString.DGOCFCFPKPI(dccpcblodig);
	}

	// Token: 0x0600691A RID: 26906 RVA: 0x0031E2E8 File Offset: 0x0031C4E8
	private void Update()
	{
		BOIKJDICEMF.IKGFHGKKCPG.MKOJMJKKEBE();
		this.WLighterProcess();
		if (!Input.GetMouseButton(0))
		{
			this.circles.SetActive(false);
		}
		this.toBaitSpinSpeed = 0f;
		if (Application.isEditor)
		{
			if (Input.GetKeyDown(KeyCode.F3))
			{
				this.PEFPELGDHPK = !this.PEFPELGDHPK;
			}
			if (Input.GetKeyDown(KeyCode.F4))
			{
				this.OGBHPFEEJJH = !this.OGBHPFEEJJH;
			}
			if (Input.GetKeyDown(KeyCode.F8))
			{
				this.isDebugMode = !this.isDebugMode;
			}
		}
		this.toCamLookObject.SetActive(this.isDebugMode);
		if (Fisherman.getI != null && DownPanelLogic.getI != null && ChatPanelLogic.getI != null && !ChatPanelLogic.getI.isChatEnter())
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				if (this.user.MFENINHGBHM)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ() == 0)
					{
						this.user.MFENINHGBHM = false;
					}
					else
					{
						DownPanelLogic.getI.OnRodChangeClck(100);
					}
				}
				else
				{
					DownPanelLogic.getI.OnRodChangeClck(100);
					this.openHotRod(100);
				}
			}
			if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				if (this.user.MFENINHGBHM)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ() == 1)
					{
						this.user.MFENINHGBHM = false;
					}
					else
					{
						DownPanelLogic.getI.OnRodChangeClck(102);
					}
				}
				else
				{
					DownPanelLogic.getI.OnRodChangeClck(102);
					this.openHotRod(102);
				}
			}
			if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				if (this.user.MFENINHGBHM)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ() == 2)
					{
						this.user.MFENINHGBHM = false;
					}
					else
					{
						DownPanelLogic.getI.OnRodChangeClck(101);
					}
				}
				else
				{
					DownPanelLogic.getI.OnRodChangeClck(101);
					this.openHotRod(101);
				}
			}
			if (Input.GetKeyDown(KeyCode.RightControl) && this.user.CDNABIHPLHM)
			{
				this.fishDown(false, false);
			}
			if (Input.GetKeyDown(KeyCode.B) && !this.user.CIHILMCEJND)
			{
				this.WpnCellClick(3, true);
			}
			if (Input.GetKeyDown(KeyCode.C))
			{
				GameInterface.getI.openSadok(0, true);
			}
			if (Input.GetKeyDown(KeyCode.I))
			{
				DownPanelLogic.getI.OpenInventory(true);
			}
			if (Input.GetKeyDown(KeyCode.M))
			{
				DownPanelLogic.getI.OpenBaseMap(true);
			}
			if (Input.GetKeyDown(KeyCode.KeypadPeriod) || Input.GetKeyDown(KeyCode.Delete))
			{
				this.OCFJLOGPMNI = !this.OCFJLOGPMNI;
				HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC = true;
				this.wcam.distance = 1f;
				this.wcam.desiredDistance = 1f;
				this.wcam.currentDistance = 1f;
				this.wcam.enabled = false;
				this.mouseLook.enabled = true;
				this.mouseLook.isFreeze = !this.OCFJLOGPMNI;
			}
		}
		this.mouseLook.isFreeze = false;
		if (!this.mouseLook.enabled)
		{
			this.OCFJLOGPMNI = true;
		}
		HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = (this.OCFJLOGPMNI | !this.mouseLook.enabled);
		if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count >= 2 && JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].GENHHJPGOFK)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = true;
		}
		if (this.GFWin != null && this.GFWin.gameObject.activeSelf)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = true;
		}
		if (ChatPanelLogic.getI && DownPanelLogic.getI)
		{
			if (ChatPanelLogic.getI.isChatEnter())
			{
				HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = true;
			}
			if (DownPanelLogic.getI.baseMapObj != null)
			{
				HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK = true;
			}
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.HEDFGMJCJJK)
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			this.mouseLook.isFreeze = true;
			if (this.user)
			{
				bool flag = false;
				if (this.user.CIHILMCEJND)
				{
					flag = true;
				}
				if (this.user.isFishGet)
				{
					flag = true;
				}
				if (this.user.CMCPFNJIIHK)
				{
					flag = true;
				}
				if (this.user.dropScrpt != null)
				{
					flag = true;
				}
				if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
				{
					flag = true;
				}
				if (!Input.GetMouseButton(1))
				{
					flag = true;
				}
				this.mouseLook.isFreeze = flag;
				if (!flag)
				{
					this.user.rotateToNpr(Camera.main.transform.forward);
				}
			}
		}
		else
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
			this.mouseLook.isFreeze = false;
			this.user.rotateToNpr(Camera.main.transform.forward);
		}
		float fieldOfView = Camera.main.fieldOfView;
		float t = (Camera.main.fieldOfView - 20f) / 40f;
		float num = Mathf.Lerp(this.MinMaxSent.x, this.MinMaxSent.y, t);
		this.mouseLook.sensitivityX = num;
		this.mouseLook.sensitivityY = num;
		this.hidePanelReal.gameObject.SetActive(this.OCFJLOGPMNI);
		if (Fisherman.getI != null)
		{
			Fisherman.getI.character.catNewItems.SetActive(!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
			if (Fisherman.getI.fchair != null)
			{
				Fisherman.getI.fchair.SetActive(!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
			}
			this.lineRope.gameObject.SetActive(this.user.dropScrpt != null);
		}
		this.staticLight.color = this.dinamycLight.color;
		this.staticLight.intensity = this.dinamycLight.intensity;
		this.staticLight.shadowStrength = this.dinamycLight.shadowStrength;
		if (Mathf.Clamp(this.staticLight.intensity, 0f, 1f) > 0.01f)
		{
			this.wlintens -= Time.deltaTime * 1.1f;
		}
		else
		{
			this.wlintens += Time.deltaTime * 1.1f;
		}
		this.wlintens = Mathf.Clamp(this.wlintens, 0f, 0.2f);
		this.rodTmr = Mathf.Clamp(this.rodTmr - Time.deltaTime, 0f, 1f);
		this.lineTmr = Mathf.Clamp(this.lineTmr - Time.deltaTime, 0f, 1f);
		if (LocBaseManager.IKGFHGKKCPG.isLoadProcess && LocBaseManager.IKGFHGKKCPG.isInstanceProcess)
		{
			this.loadPb.textHeader.text = "...";
		}
		if (Fisherman.getI != null)
		{
			if (this.user.dropScrpt != null)
			{
				if (this.evntsText1 != null)
				{
					this.evntsText1.text = this.user.dropScrpt.getBaitInfo();
				}
				if (this.evntsText2 != null)
				{
					this.evntsText2.text = this.evntsText1.text;
				}
			}
			else
			{
				if (this.evntsText1 != null)
				{
					this.evntsText1.text = "";
				}
				if (this.evntsText2 != null)
				{
					this.evntsText2.text = "";
				}
			}
			if (Fisherman.getI.MFENINHGBHM && !ChatPanelLogic.getI.isChatEnter())
			{
				BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
				if (Input.GetKeyUp(KeyCode.KeypadPlus) || Input.GetKeyUp(KeyCode.Plus) || Input.GetKeyUp(KeyCode.KeypadMinus) || Input.GetKeyUp(KeyCode.Minus))
				{
					this.MCLCCJKPMBF = 0f;
				}
				if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
				{
					this.CNIBLMMFPEI = Time.time;
				}
				bool flag2 = this.MCLCCJKPMBF < Time.time;
				bool flag3 = Input.GetKey(KeyCode.KeypadPlus) | Input.GetKey(KeyCode.Plus);
				bool flag4 = Input.GetKey(KeyCode.KeypadMinus) | Input.GetKey(KeyCode.Minus);
				if (Input.GetKeyDown(KeyCode.F))
				{
					this.deepPanel.OFF();
					this.speedPanel.OFF();
					this.fricPanel.paramset();
				}
				float axis = Input.GetAxis("Mouse ScrollWheel");
				bool flag5 = true;
				if (this.fricPanel.HKPAEGGJNGG)
				{
					flag5 = false;
				}
				GuiProcessor.IKGFHGKKCPG.isPanelParamActive = false;
				if (!flag5)
				{
					int num2 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL;
					if (flag3 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ += 0.25f;
					}
					if (flag4 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ -= 0.25f;
					}
					float num3 = axis * 2.5f;
					BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CJLKGICPCAJ += num3;
					if (Mathf.Abs(num3) > 0.1f)
					{
						this.fricPanel.paramset();
					}
					if ((flag3 || flag4) && flag2)
					{
						this.MCLCCJKPMBF = Time.time + ((Time.time - this.CNIBLMMFPEI > 0.5f) ? 0.15f : 0.5f);
						this.fricPanel.paramset();
					}
					if (num2 != BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().GLNFJCIJHDL)
					{
						this.ws.playSoundFric();
					}
					GuiProcessor.IKGFHGKKCPG.isPanelParamActive = true;
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning && flag5)
				{
					if (flag3 && flag5 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JCIMMJOIBJJ(1);
					}
					if (flag4 && flag5 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JCIMMJOIBJJ(-1);
					}
					if ((flag3 || flag4) && flag5 && flag2)
					{
						this.MCLCCJKPMBF = Time.time + ((Time.time - this.CNIBLMMFPEI > 0.5f) ? 0.15f : 0.5f);
						this.speedPanel.paramset();
					}
					if (this.speedPanel.HKPAEGGJNGG)
					{
						GuiProcessor.IKGFHGKKCPG.isPanelParamActive = true;
						float num4 = axis * 10f;
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CLEJODCMJAA += num4;
						if (Mathf.Abs(num4) > 0.1f)
						{
							this.speedPanel.paramset();
						}
					}
					if (Input.GetKeyDown(KeyCode.R))
					{
						this.fricPanel.OFF();
						this.speedPanel.paramset();
					}
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && flag5)
				{
					if (flag3 && flag5 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA += 1f;
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
					}
					if (flag4 && flag5 && flag2)
					{
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA -= 1f;
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
					}
					if ((flag3 || flag4) && flag5 && flag2)
					{
						this.MCLCCJKPMBF = Time.time + ((Time.time - this.CNIBLMMFPEI > 0.5f) ? 0.01f : 0.5f);
						this.deepPanel.paramset();
					}
					if (this.deepPanel.HKPAEGGJNGG)
					{
						GuiProcessor.IKGFHGKKCPG.isPanelParamActive = true;
						float num5 = axis * 60f;
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA += num5;
						BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().JDFKFMDPCDH = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IFNNBJDJBNA);
						if (Mathf.Abs(num5) > 0.1f)
						{
							this.deepPanel.paramset();
						}
					}
					if (Input.GetKeyDown(KeyCode.R))
					{
						this.fricPanel.OFF();
						this.deepPanel.paramset();
					}
				}
				if (Input.GetKeyDown(KeyCode.R))
				{
					this.fricPanel.OFF();
				}
			}
		}
		if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space))
		{
			this.NANKIDAJFJF = false;
		}
		if (this.waterMaterial != null)
		{
			this.waterMaterial.SetFloat("_DayToNight", TimeController.IKGFHGKKCPG.currentWaterColorSlider);
		}
		if (this.user)
		{
			this.user.lineControl(false, false, (this.user.dropScrpt != null) ? this.user.dropScrpt.transform : null);
			if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
			{
				Camera.main.transform.position = this.user.eyeCamPoint.transform.position;
				bool flag6 = this.OCFJLOGPMNI | !this.mouseLook.enabled;
				if (this.user.MFENINHGBHM)
				{
					this.wcam.enabled = false;
					if (this.user.dropScrpt != null)
					{
						this.DIMLDFJICLI();
					}
					else if (this.user.MFENINHGBHM)
					{
						this.KPIDPCLBJFL();
					}
					else
					{
						this.KPIDPCLBJFL();
					}
					if (this.zoom < -0.1f)
					{
						this.zoom = 0f;
						this.wcam.distance = 2f;
						this.wcam.currentDistance = 2f;
						this.wcam.desiredDistance = 2f;
						this.flipView(false);
						return;
					}
					if (this.getKeyFlipView())
					{
						this.flipView(false);
					}
				}
				else
				{
					if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && !GuiProcessor.IKGFHGKKCPG.isPanelParamActive)
					{
						this.wcam.currentDistance -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 30f;
					}
					if (this.wcam.currentDistance < 1.2f)
					{
						this.wcam.currentDistance = 1.2f;
					}
					if (this.wcam.currentDistance > 1.4f)
					{
						this.flipView(false);
					}
					if (this.getKeyFlipView())
					{
						this.flipView(false);
					}
				}
			}
			else if (this.user.MFENINHGBHM)
			{
				if (this.wcam.currentDistance < 1.3f)
				{
					this.flipView(true);
				}
				if (this.getKeyFlipView())
				{
					this.flipView(true);
				}
			}
			else
			{
				if (this.wcam.currentDistance < 1.3f)
				{
					this.flipView(true);
				}
				if (this.getKeyFlipView())
				{
					this.flipView(true);
				}
			}
		}
		if (LocBaseManager.IKGFHGKKCPG.isLoadProcess)
		{
			this.loadPb.position = LocBaseManager.IKGFHGKKCPG.CECMGBMIMLO;
		}
		bool isShow = false;
		if (this.user != null)
		{
			isShow = this.user.MFENINHGBHM;
		}
		this.panelRoll.isShow = isShow;
		this.user = Fisherman.getI;
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak != null && this.user != null)
		{
			this.PBar_Up.position = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL);
			this.PBar_Down.position = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE);
			this.PBarAdd_Up.position = bgjkmcbhnak.LGALGHAPJND;
			this.PBarAdd_Down.position = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.KIKADLMBJIA);
			this.PBarRollCat.position = bgjkmcbhnak.CCLOHHCJJAM * 100f;
			this.PBarStamina.max = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.PLIPAKGHPBE);
			float a = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMFIFECPGL);
			float b = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE);
			this.PBarResult.max = 100f;
			float position = Mathf.Max(a, b);
			this.PBarResult.position = position;
			if (this.user && this.user.dropScrpt && this.user.dropScrpt.fish)
			{
				this.PBarStamina.position = ObscuredFloat.GOOIABGKMHK(this.user.dropScrpt.fish.currStamina);
			}
			else
			{
				this.PBarStamina.position = 0f;
			}
			bool flag7 = false;
			if (this.user.isPodsek)
			{
				if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.OGLIEFLNLLE) < 0.1f)
				{
					flag7 = true;
				}
				if (flag7)
				{
					flag7 = (Mathf.Sin(Time.time * 40f) < 0f);
				}
			}
			if (this.freeLine1 != null)
			{
				this.freeLine1.gameObject.SetActive(flag7);
			}
			if (this.freeLine2 != null)
			{
				this.freeLine2.gameObject.SetActive(flag7);
			}
		}
		if (this.user != null)
		{
			Vector3 position2 = this.user.transform.position;
			position2.y = this.OGJHINOLHJJ + 0.02f;
			this.getPosGO.transform.position = position2;
			this.minLineDistanceGO.transform.position = position2;
			this.getPosGO.transform.rotation = this.user.transform.rotation;
			this.minLineDistanceGO.transform.rotation = this.user.transform.rotation;
			this.minLineDistanceGO.transform.Rotate(90f, 0f, 0f);
			this.getPosGO.transform.Rotate(90f, 0f, 0f);
			this.getPosGO.gameObject.SetActive(this.user.CDNABIHPLHM & this.user.isPodsek);
			this.minLineDistanceGO.gameObject.SetActive(this.user.MFENINHGBHM);
			if (BOIKJDICEMF.IKGFHGKKCPG != null && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
			{
				Vector3 fishGettingPosition = this.user.getFishGettingPosition();
				Vector3 position3 = this.user.transform.position;
				position3.y = fishGettingPosition.y;
				float num6 = Vector3.Distance(fishGettingPosition, position3) * 2f;
				this.getPosGO.transform.localScale = new Vector3(num6, num6, num6);
			}
			if (bgjkmcbhnak != null && this.user.MFENINHGBHM)
			{
				if (this.lineDstTxt != null)
				{
					float num7 = ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK);
					float num8 = BOIKJDICEMF.IKGFHGKKCPG.CHCJILPBABD();
					this.lineDstTxt.text = string.Format(JNBICAJIJMM.LEBHCLDODNI("cnt_dstall"), num7, num8);
					if (this.lineDstTxt2 != null)
					{
						this.lineDstTxt2.text = this.lineDstTxt.text;
					}
				}
				if (this.FricTxt1 != null)
				{
					string text = string.Format("<color='#a0ff30'>F: {0}</color>", this.ws.getFricText());
					this.FricTxt1.text = text;
					this.FricTxt2.text = text;
				}
			}
			float num9 = Mathf.Lerp(0.8f, 0.3f, this.user.upRodState);
			this.BCOMJHNGOHH += Input.GetAxis("Mouse X") * this.sensitivityBlendRod * num9;
			this.BCOMJHNGOHH = Mathf.Clamp(this.BCOMJHNGOHH, -1f, 1f);
			float b2 = this.blendRodDirCurve.Evaluate(this.BCOMJHNGOHH);
			this.user.blendRodDirection = Mathf.Lerp(this.user.blendRodDirection, b2, Time.deltaTime * 1f);
			bool isRodInWater = this.user.CIHILMCEJND;
			if (this.getKeySidDwn())
			{
				if (this.user.isSitEnable)
				{
					this.user.CMCPFNJIIHK = !this.user.CMCPFNJIIHK;
				}
				else
				{
					this.user.CMCPFNJIIHK = false;
				}
			}
			switch (this.user.usermode)
			{
			case Fisherman.NHOCKOJNFFJ.Stay:
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
				{
					if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
					{
						this.userStaySpinnigLogic(false);
						if (Fisherman.getI.AOEGNGOGNBI != null)
						{
							Fisherman.getI.AOEGNGOGNBI.PGEDLDMLBBE = 0f;
						}
						if (this.user.dropScrpt != null)
						{
							Fisherman.getI.forceControl(this.user.dropScrpt.transform);
						}
						this.user.cursorPoint = this.dexCircleGO.transform.position;
						return;
					}
					this.stopRollSound();
					this.user.cursorPoint = this.dexCircleGO.transform.position;
					this.userStayLogic();
					return;
				}
				break;
			case Fisherman.NHOCKOJNFFJ.Fishing:
				if (this.user.dropScrpt != null)
				{
					this.user.cursorPoint = this.user.dropScrpt.transform.position;
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning && this.user.dropScrpt != null)
				{
					this.spinnigFishingLogic();
					this.userStaySpinnigLogic(true);
					Fisherman.getI.forceControl(this.user.dropScrpt.transform);
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider && this.user.dropScrpt != null)
				{
					this.RodInWaterLogic();
					Fisherman.getI.forceControl(this.user.dropScrpt.transform);
				}
				if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok && this.user.dropScrpt != null)
				{
					this.RodInWaterLogic();
					Fisherman.getI.forceControl(this.user.dropScrpt.transform);
					return;
				}
				break;
			case Fisherman.NHOCKOJNFFJ.FishOnRod:
				if (this.user.fishRod != null)
				{
					this.user.cursorPoint = this.user.fishRod.transform.position;
				}
				this.fishOnRodLogic();
				return;
			case Fisherman.NHOCKOJNFFJ.FishGet:
				if (this.rollSound.isPlaying)
				{
					this.stopRollSound();
				}
				this.user.cursorPoint = Vector3.zero;
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0600691B RID: 26907 RVA: 0x0031F934 File Offset: 0x0031DB34
	public void updateImages(BOIKJDICEMF.BGJKMCBHNAK JLJJKMLJBAK)
	{
		if (JLJJKMLJBAK == null)
		{
			this.clearImages();
			return;
		}
		bool flag = true;
		switch (JLJJKMLJBAK.DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			this.wpnCells[1].weapon = JLJJKMLJBAK.PFNCHEEEBKD;
			this.wpnCells[2].weapon = JLJJKMLJBAK.CBLCFLENIJL[0];
			this.wpnCells[3].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			this.wpnCells[4].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[5].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[6].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = JLJJKMLJBAK.CKBGHMMOAEM;
			flag = false;
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.wpnCells[1].weapon = null;
			this.wpnCells[2].weapon = JLJJKMLJBAK.PFNCHEEEBKD;
			this.wpnCells[3].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			this.wpnCells[4].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[5].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[6].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = null;
			flag = false;
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			this.wpnCells[1].weapon = JLJJKMLJBAK.AMLEOGHNNPG[2];
			this.wpnCells[2].weapon = JLJJKMLJBAK.AMLEOGHNNPG[1];
			this.wpnCells[3].weapon = JLJJKMLJBAK.AMLEOGHNNPG[0];
			this.wpnCells[4].weapon = JLJJKMLJBAK.NKNCNHGDMLF;
			this.wpnCells[5].weapon = JLJJKMLJBAK.LJCLFFINEHJ;
			this.wpnCells[6].weapon = JLJJKMLJBAK.IIOHPBENEFI;
			this.wpnCells[7].weapon = JLJJKMLJBAK.CKBGHMMOAEM;
			flag = false;
			break;
		}
		if (flag)
		{
			this.clearImages();
		}
	}

	// Token: 0x0600691C RID: 26908 RVA: 0x0031FB18 File Offset: 0x0031DD18
	public float ODOLMAKHPAL(Vector3 NHCLMBOINFG)
	{
		float deepInPoint = this.getDeepInPoint(NHCLMBOINFG);
		return (this.OGJHINOLHJJ - deepInPoint) * 1906f;
	}

	// Token: 0x17000178 RID: 376
	// (set) Token: 0x0600691D RID: 26909 RVA: 0x0031FB3C File Offset: 0x0031DD3C
	public float MHHOOOEJGFM
	{
		set
		{
			this.maxDistanceGO.transform.localScale = new Vector3(value * 2f, value * 2f, value * 2f);
			float num = value * 2f;
			num = Mathf.Clamp(num, 1f, 15f);
			this.nprCircleGO.transform.localScale = new Vector3(num, num, num);
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IIOHPBENEFI != null)
			{
				float num2 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IIOHPBENEFI.LODGJCMEGAI.KGKNPAAMDJK * 2f;
				this.minLineDistanceGO.transform.localScale = new Vector3(num2, num2, num2);
			}
		}
	}

	// Token: 0x0600691E RID: 26910 RVA: 0x0031FBED File Offset: 0x0031DDED
	public float CDBIEPGNONF()
	{
		if (this.water != null)
		{
			return this.water.transform.position.y;
		}
		return 1203f;
	}

	// Token: 0x0600691F RID: 26911 RVA: 0x0031FC18 File Offset: 0x0031DE18
	public float IEPIKEGEADO()
	{
		if (this.user != null)
		{
			Vector3 position = this.user.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			return Vector3.Distance(position, this.dexCircleGO.transform.position);
		}
		return 79f;
	}

	// Token: 0x06006920 RID: 26912 RVA: 0x0031FC7C File Offset: 0x0031DE7C
	public void flipView(bool ECCECBJDEIF)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC = ECCECBJDEIF;
		HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
		this.wcam.enabled = !HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		this.mouseLook.enabled = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			float num = this.wcam.currentDistance;
			if (num < 1.3f)
			{
				num = 1.3f;
			}
			HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN = num;
			HPGKIJLKCIH.IKGFHGKKCPG.FGJIMICPKNL = this.wcam.transform.position;
			HPGKIJLKCIH.IKGFHGKKCPG.JIJMJDDLMJC = this.wcam.transform.rotation;
			this.wcam.enabled = false;
			this.toFieldView = 50f;
			if (this.user)
			{
				this.toCamPos = this.user.eyeCamPoint.transform.position;
				this.toCamLook = this.user.transform.position + this.user.transform.forward * BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 0.8f;
				Camera.main.transform.position = this.toCamPos;
				Camera.main.fieldOfView = this.toFieldView;
				if (this.OCFJLOGPMNI)
				{
					Camera.main.transform.LookAt(this.toCamLook);
				}
			}
			if (HPGKIJLKCIH.IKGFHGKKCPG.LCANAPDPIPP > 0.1f)
			{
				this.zoom = HPGKIJLKCIH.IKGFHGKKCPG.LCANAPDPIPP;
				Camera.main.fieldOfView = HPGKIJLKCIH.IKGFHGKKCPG.EHNCFIPOPCK;
			}
		}
		if (!HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			HPGKIJLKCIH.IKGFHGKKCPG.LCANAPDPIPP = this.zoom;
			HPGKIJLKCIH.IKGFHGKKCPG.EHNCFIPOPCK = Camera.main.fieldOfView;
			if (HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN > 0.1f)
			{
				this.wcam.distance = HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN;
				this.wcam.currentDistance = HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN;
				this.wcam.desiredDistance = HPGKIJLKCIH.IKGFHGKKCPG.CNLNBIIKOAN;
				this.wcam.transform.position = HPGKIJLKCIH.IKGFHGKKCPG.FGJIMICPKNL;
				this.wcam.transform.rotation = HPGKIJLKCIH.IKGFHGKKCPG.JIJMJDDLMJC;
				Camera.main.fieldOfView = 60f;
			}
			this.wcam.enabled = true;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC)
		{
			this.wcam.distance = 1f;
			this.wcam.desiredDistance = 1f;
			this.wcam.currentDistance = 1f;
			this.wcam.enabled = false;
			this.mouseLook.enabled = true;
			this.mouseLook.isFreeze = !this.OCFJLOGPMNI;
		}
	}

	// Token: 0x06006921 RID: 26913 RVA: 0x0031FF70 File Offset: 0x0031E170
	public List<LocNewLogic.OMHDHFKKIIL> MKBADIOGHPD(Vector3 PNNFJEMKLGH, float EHIKLLJBKHF)
	{
		List<LocNewLogic.OMHDHFKKIIL> list = new List<LocNewLogic.OMHDHFKKIIL>();
		for (int i = -1; i <= 1; i += 0)
		{
			for (int j = -1; j <= 0; j++)
			{
				if (i != j || i != 0)
				{
					Vector3 pnnfjemklgh = new Vector3(PNNFJEMKLGH.x + (float)i * EHIKLLJBKHF, this.HKBNODJBGEL() - 1491f, PNNFJEMKLGH.z + (float)j * EHIKLLJBKHF);
					LocNewLogic.OMHDHFKKIIL item = this.JDKJONHLLBE(pnnfjemklgh);
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06006922 RID: 26914 RVA: 0x0031FFE0 File Offset: 0x0031E1E0
	public void KOKAFPFLNEE()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		if (this.user != null && this.user.AOEGNGOGNBI != null && !BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NHNHBLLLGDP)
		{
			this.user.AOEGNGOGNBI.EIANPDPMNKJ(1850f);
		}
		if (Input.GetMouseButtonDown(0) && !JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD())
		{
			this.KOEHHGHGFEK = false;
		}
		if (this.user && this.user.MFENINHGBHM && LocNewLogic.FADEIIFNODD())
		{
			if (bgjkmcbhnak.DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Poplavok)
			{
				if (this.user.KNMMOLKNLNL())
				{
					this.user.CIHILMCEJND = false;
				}
				else if (!this.user.KNMMOLKNLNL() && this.user.standFlag)
				{
					this.dexCircleGO.transform.position = this.lastPosition;
					if (this.lastPosition.magnitude > 1663f && this.AHDILEICFMM(this.lastPosition))
					{
						this.dropAction(this.lastPosition);
					}
				}
			}
			else if (!this.user.KNMMOLKNLNL() && this.user.standFlag)
			{
				this.dexCircleGO.transform.position = this.lastPosition;
				if (this.lastPosition.magnitude > 1376f && this.AHDILEICFMM(this.lastPosition))
				{
					this.dropAction(this.lastPosition);
				}
			}
		}
		this.LPGBCHGEMIA(true);
	}

	// Token: 0x06006923 RID: 26915 RVA: 0x00320175 File Offset: 0x0031E375
	public void HKDOKACMEGK(float DCCPCBLODIG)
	{
		this.minDistanceGO.transform.localScale = new Vector3(DCCPCBLODIG * 496f, DCCPCBLODIG * 84f, DCCPCBLODIG * 639f);
	}

	// Token: 0x06006924 RID: 26916 RVA: 0x0030EA70 File Offset: 0x0030CC70
	private IEnumerator ADOONEENKEA()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		yield return new WaitForSeconds(2f);
		if (this.isBase)
		{
			this.NNLDGOGODAK(null);
		}
		else
		{
			LocBaseManager.IKGFHGKKCPG.getLevel(this.baseid, new LocBaseManager.HHIFOAIHHNC(this.NNLDGOGODAK));
		}
		yield break;
	}

	// Token: 0x06006925 RID: 26917 RVA: 0x003201A4 File Offset: 0x0031E3A4
	public void applySettingsForLevel()
	{
		if (this.CNOLCNDBLJE == null)
		{
			return;
		}
		Debug.Log("Apply 1");
		if (this.rollSound != null)
		{
			this.rollSound.clip = SoundSamplesStorage.getI.rollSounds[HPGKIJLKCIH.IKGFHGKKCPG.LGABMNDAJNG];
		}
		Debug.Log("Apply 2");
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(this.CNOLCNDBLJE, "WindZone");
		if (gameObject != null)
		{
			WindZone component = gameObject.GetComponent<WindZone>();
			if (component != null)
			{
				component.windMain = 0.03f;
			}
		}
		Debug.Log("Apply 3");
		Terrain terrain = UnityEngine.Object.FindObjectOfType<Terrain>();
		float num = 1f;
		if (terrain != null)
		{
			terrain.heightmapPixelError = 12f;
			terrain.basemapDistance = Mathf.Clamp(300f * num, 30f, 200f);
			terrain.treeDistance = 1500f * num;
			terrain.treeBillboardDistance = 30f + 100f * num;
			terrain.treeMaximumFullLODCount = (int)(80f * num);
			terrain.detailObjectDistance = Mathf.Clamp(60f * num, 20f, 100f);
			terrain.detailObjectDensity = Mathf.Clamp(num, 0.3f, 1f);
			terrain.collectDetailPatches = false;
		}
		Debug.Log("Apply 4");
		this.staticLight.gameObject.SetActive(true);
		this.dinamycLight.gameObject.SetActive(false);
		Debug.Log("Apply 5");
		this.sd = this.CNOLCNDBLJE.GetComponent<SceneData>();
		if (this.sd != null)
		{
			TimeController.IKGFHGKKCPG.currentLUTBank = this.sd.lutIndex;
			base.StartCoroutine(this.NFBIPHFGDGF(this.sd));
			RenderSettings.fog = false;
			this.sd.getSpawnPoint(this.locid, this.pointid);
			GameObject[] array = GameObject.FindGameObjectsWithTag("fishzone");
			if (array != null)
			{
				GameObject[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].AddComponent<FishZone>();
				}
			}
			TimeController.IKGFHGKKCPG.lightKF = this.sd.lightKF;
			this.todSky.Day.LightIntensity = this.todSky.Day.LightIntensity * this.sd.lightKF;
			GradientColorKey[] colorKeys = this.todSky.Day.AmbientColor.colorKeys;
			for (int j = 0; j < colorKeys.Length; j++)
			{
				colorKeys[j].color = colorKeys[j].color * this.sd.lightKF;
			}
			this.todSky.Day.AmbientColor.SetKeys(colorKeys, this.todSky.Day.AmbientColor.alphaKeys);
			Debug.Log("Apply 6");
			if (this.sd != null)
			{
				this.water = this.sd.water;
				if (this.water != null)
				{
					Debug.Log("Apply 7");
					SpecularLighting component2 = this.water.GetComponent<SpecularLighting>();
					if (component2 != null)
					{
						component2.specularLight = this.todSkySun;
					}
				}
			}
		}
		Debug.Log("Apply 10");
		if (this.effector != null)
		{
			this.effector.applyEffect();
		}
		Debug.Log("Apply 11");
	}

	// Token: 0x06006926 RID: 26918 RVA: 0x00320514 File Offset: 0x0031E714
	public void DHJFBLKEABJ(float MMJELGIIKMO, float HMJNNIOPOMB)
	{
		if (MMJELGIIKMO <= 422f)
		{
			this.stopRollSound();
			return;
		}
		float volume = 708f;
		if (HMJNNIOPOMB > 1981f)
		{
			float t = (HMJNNIOPOMB - 90f) * 647f;
			volume = Mathf.Lerp(1191f, HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK, t);
		}
		this.rollSound.pitch = 681f + (HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH - 1950f) * 1404f + 920f * MMJELGIIKMO;
		this.rollSound.volume = volume;
		this.lowRollSound.volume = 872f * HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
		this.lowRollSound.pitch = 483f + 1616f * MMJELGIIKMO;
		if (!this.lowRollSound.isPlaying)
		{
			this.lowRollSound.Play();
		}
		if (!this.rollSound.isPlaying)
		{
			this.rollSound.time = OLPINJLCKCI.OBDBAABBAKB().BCODBMGPBFJ((double)this.rollSound.clip.length);
			this.rollSound.Play();
		}
	}

	// Token: 0x06006927 RID: 26919 RVA: 0x00320630 File Offset: 0x0031E830
	public void fishOnRodLogic()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		if (this.user == null)
		{
			return;
		}
		if (this.user.dropScrpt == null)
		{
			return;
		}
		if (this.user.dropScrpt.fish == null)
		{
			return;
		}
		FishOnRod fish = this.user.dropScrpt.fish;
		fish.transform.position.y = this.user.transform.position.y;
		this.user.UserLookAtOn(fish.transform.position + Vector3.up * 0.8f);
		if (this.JCKKMKECMFA > 0f)
		{
			this.JCKKMKECMFA -= Time.deltaTime;
		}
		float num = Mathf.Clamp(this.JCKKMKECMFA, 0.001f, 10f) / 10f;
		float num2 = 0f;
		if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().OGLIEFLNLLE) <= 0.01f)
		{
			num2 = 5f;
		}
		float num3 = num2 * Time.deltaTime + ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().HFPNHGGIKHP) * num * Time.deltaTime;
		EKBAPCMPANI bckecoendlb = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB;
		if (bckecoendlb != null)
		{
			num3 *= (100f - bckecoendlb.LODGJCMEGAI.JLLJFKOGLHJ) / 100f;
		}
		if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(num3))
		{
			Debug.Log("fishDown SHANCE");
			this.fishDown(false, false);
			return;
		}
		Vector3 fishGettingPosition = this.user.getFishGettingPosition();
		float num4 = BOIKJDICEMF.IKGFHGKKCPG.CHCJILPBABD();
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.ALKAGOMNNOK) >= num4)
		{
			this.fishDown(true, false);
			return;
		}
		Vector3 position = this.user.transform.position;
		position.y = fishGettingPosition.y;
		float num5 = Vector3.Distance(fishGettingPosition, position);
		Vector3 position2 = fish.hookPoint.position;
		position2.y = fishGettingPosition.y;
		bool flag = fish.hookPoint.position.y - this.OGJHINOLHJJ > -0.18f;
		float num6 = 0.5f;
		if (fish.hookPoint.position.y > this.OGJHINOLHJJ)
		{
			num6 = 0.8f;
		}
		bool flag2 = Vector3.Distance(position2, fishGettingPosition) < num6;
		if (!ObscuredBool.GOOIABGKMHK(fish.isGetFromWater) && ((Vector3.Distance(position, position2) <= num5 * 0.8f || flag2) && flag))
		{
			fish.fishGet();
			this.panelRoll.isShow = false;
			this.user.getFishAction();
			FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(fish.transform.position, 0.5f);
			return;
		}
		bool flag3 = false;
		bool flag4 = false;
		this.rodUpMove = false;
		this.lineTensionLogic();
		float num7 = bgjkmcbhnak.LGALGHAPJND;
		if (this.checkKeyRoll())
		{
			flag4 = true;
			float mfmlchfnalc = bgjkmcbhnak.LJCLFFINEHJ.BDHHPAEHFHG.MFMLCHFNALC;
			float num8 = 0.8f;
			float num9 = 0.01f;
			if (mfmlchfnalc > 0f)
			{
				num8 = 1f;
				num9 = 0f;
			}
			if (mfmlchfnalc < 0f)
			{
				num8 *= 0.8f;
				num9 = 0.1f;
			}
			if (Input.GetKeyDown(KeyCode.LeftShift))
			{
				num8 *= 1.5f;
			}
			if (num8 < num9)
			{
				num8 = num9 * 1.1f;
			}
			AnimationCurve animationCurve = GuiProcessor.IKGFHGKKCPG.reelTensionCurve;
			if (mfmlchfnalc > 0.01f)
			{
				animationCurve = GuiProcessor.IKGFHGKKCPG.reelSpdTensionCurve;
			}
			if (mfmlchfnalc < -0.01f)
			{
				animationCurve = GuiProcessor.IKGFHGKKCPG.reelFrcTensionCurve;
			}
			float num10 = Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JBLKFABJAMA) / 80f, 0f, 0.5f);
			float t = animationCurve.Evaluate(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.AIHLOMHODIB) * 1f + num10, 0f, 1f));
			float num11 = Mathf.Lerp(num9, num8, t) * 1f;
			float num12 = Mathf.Lerp(1.2f, 0.5f, (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.JBLKFABJAMA) - mfmlchfnalc * 2f) / 7f);
			num11 *= num12;
			if (bgjkmcbhnak.BBANBEEJAPD)
			{
				num11 = num9;
			}
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) <= 1.001f)
			{
				num11 = 0f;
			}
			float num13 = num11 * 1.5f;
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = bgjkmcbhnak;
			bgjkmcbhnak2.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak2.KIKADLMBJIA) - bgjkmcbhnak.AAGGJACBMEC * Time.deltaTime);
			bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) - num13 * Time.deltaTime);
			if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.DNPDBOODCHK) < 1f)
			{
				bgjkmcbhnak.DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(1f);
			}
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.rotTime += Time.deltaTime * num11 * 20f;
			this.playRollSound(num11, Mathf.Clamp(bgjkmcbhnak.CCLOHHCJJAM * 2f, 0.3f, 1f));
			num7 += bgjkmcbhnak.HNEEGDNEDHJ * 8f * Time.deltaTime;
		}
		else
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak3 = bgjkmcbhnak;
			bgjkmcbhnak3.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak3.KIKADLMBJIA) + bgjkmcbhnak.MHHJEMDJOIK * Time.deltaTime);
			if (this.checkKeyRod())
			{
				BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak4 = bgjkmcbhnak;
				bgjkmcbhnak4.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak4.KIKADLMBJIA) + bgjkmcbhnak.MHHJEMDJOIK * 5f * Time.deltaTime);
			}
			this.stopRollSound();
		}
		if (this.checkKeyRod())
		{
			flag3 = true;
			num7 -= bgjkmcbhnak.MKPBNPLJEDL * Time.deltaTime * 3f;
		}
		else
		{
			num7 += bgjkmcbhnak.HNEEGDNEDHJ * Time.deltaTime;
			this.checkKeyRoll();
		}
		bgjkmcbhnak.LGALGHAPJND = Mathf.Clamp(num7, 0f, 100f);
		bgjkmcbhnak.KIKADLMBJIA = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.KIKADLMBJIA), 0.1f, 100f));
		fish.staminaProcess(flag3 || flag4);
		this.user.isKeyPress = (flag3 || flag4);
	}

	// Token: 0x06006928 RID: 26920 RVA: 0x00320C44 File Offset: 0x0031EE44
	public bool FGGGOAHFNCD()
	{
		if (Input.GetMouseButton(0) && JDCEFOFMGHB.MNJNNDHCDGG().BHBCONNDEBA())
		{
			return false;
		}
		if (this.NANKIDAJFJF)
		{
			return true;
		}
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.T))
		{
			this.rodTmr = 779f;
			if (Fisherman.getI != null)
			{
				Fisherman fisherman = Fisherman.getI;
				fisherman.keyCount = ObscuredInt.NDIPOJMKAJF(fisherman.keyCount);
			}
		}
		return Input.GetMouseButton(1) | Input.GetKey((KeyCode)(-4));
	}

	// Token: 0x06006929 RID: 26921 RVA: 0x00320CC0 File Offset: 0x0031EEC0
	public bool checkPosition(Vector3 NHCLMBOINFG)
	{
		float num = 57f;
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Spinning)
		{
			num = 40f;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA == BOIKJDICEMF.JGHABIPEEEO.Fider)
		{
			num = 30f;
		}
		float pointerDistance = this.getPointerDistance();
		if (pointerDistance <= BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL)
		{
			return false;
		}
		if (pointerDistance > BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB)
		{
			return false;
		}
		if (this.user != null)
		{
			Vector3 forward = this.user.transform.forward;
			Vector3 position = this.user.transform.position;
			position.y = this.dexCircleGO.transform.position.y;
			Vector3 to = this.dexCircleGO.transform.position - position;
			if (Mathf.Abs(Vector3.Angle(forward, to)) > num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600692A RID: 26922 RVA: 0x00320D9C File Offset: 0x0031EF9C
	public float OAGDOEPCBFG()
	{
		float num = Time.time - this.startAnimSpinTime;
		if (num > 581f)
		{
			return 1954f;
		}
		if (this.user.LPENNEOLCCP())
		{
			return 331f;
		}
		if (!this.user.GECLKEEGJGA())
		{
			return 1755f;
		}
		if (this.user.dropScrpt == null)
		{
			return 677f;
		}
		if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG) < 482f)
		{
			return 1068f;
		}
		float num2 = Mathf.Lerp(1367f, 1124f, BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.NKHBAJKMAGD / 481f);
		return this.addForceSpinningUpRod[this.animCurveID].Evaluate(num) * num2 * 1979f;
	}

	// Token: 0x0600692B RID: 26923 RVA: 0x00320E64 File Offset: 0x0031F064
	private void Start()
	{
		if (this.GFWin != null)
		{
			this.GFWin.gameObject.SetActive(false);
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LDGFBNOIBMB();
		Debug.Log("******* playMusicBase  LocNewLogic");
		FBFJFAKAGJG.IKGFHGKKCPG.JGOEIANIJFL(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG);
		if (JBEHMPDDMME.IKGFHGKKCPG != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			this.EEPNACDOOBF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			this.baseid = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG;
			this.locid = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE;
			this.pointid = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDNPMHOLMPN;
		}
		if (this.wcam == null)
		{
			this.wcam = Camera.main.GetComponent<WowCamera>();
		}
		if (this.mouseLook == null)
		{
			this.mouseLook = Camera.main.GetComponent<MouseLooks>();
			if (this.mouseLook == null)
			{
				Debug.LogError("mouseLook not found");
			}
		}
		this.isLevelLoadProcess = true;
		HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC = false;
		this.flipView(HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		this.mainCanvas.gameObject.SetActive(false);
		this.loadCanvas.gameObject.SetActive(true);
		this.baseName.text = JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(this.baseid);
		CKNLPGEPGGF.IKGFHGKKCPG.PPMAFOGDGAK(string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Textures/Bases/",
			this.baseid,
			".png"
		}), new CKNLPGEPGGF.FADFMDIHCIN(this.PHMMMGHEMBK), false);
		float a = this.cityWall.color.a;
		this.todSky.EDEOFJIHELL().a = a;
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		}
		this.loadPb.textHeader.text = "";
		this.panelRoll.isShow = false;
		this.circles.SetActive(false);
		this.citate.text = GHGHFBNBBFE.IKGFHGKKCPG.JCNCGBJNAKF();
		OAFJCFOGGAF.IKGFHGKKCPG.BNGIIJPLHLO();
		if (this.gameChatPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.gameChatPrefab, Vector3.zero, Quaternion.identity);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.transform.SetParent(this.mainCanvas);
		}
		base.StartCoroutine(this.INPIIDNILBP());
	}

	// Token: 0x0600692C RID: 26924 RVA: 0x00321114 File Offset: 0x0031F314
	public bool getKeyZoom()
	{
		bool flag = Input.GetMouseButtonDown(1) & !JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL;
		if (ChatPanelLogic.getI.isChatEnter())
		{
			return flag;
		}
		return flag | Input.GetKeyDown(KeyCode.Y);
	}

	// Token: 0x0600692D RID: 26925 RVA: 0x00321150 File Offset: 0x0031F350
	public void calculateTerrainSpecies(Vector3 NHCLMBOINFG)
	{
		this.terrainSpecies.Clear();
		if (Terrain.activeTerrain == null)
		{
			return;
		}
		float num = 1f;
		NHCLMBOINFG.x = (float)Mathf.RoundToInt(NHCLMBOINFG.x * num) / num;
		NHCLMBOINFG.z = (float)Mathf.RoundToInt(NHCLMBOINFG.z * num) / num;
		if (Terrain.activeTerrain.SampleHeight(NHCLMBOINFG) + Terrain.activeTerrain.transform.position.y > this.OGJHINOLHJJ)
		{
			return;
		}
		Vector3 origin = new Vector3(NHCLMBOINFG.x, this.OGJHINOLHJJ - 0.01f, NHCLMBOINFG.z);
		this.flowForce = AJOAMAPPLGH.IKGFHGKKCPG.EEPCAACPJNK(NHCLMBOINFG);
		Vector3 to = Vector3.up;
		RaycastHit raycastHit;
		if (Physics.Raycast(new Ray(origin, Vector3.down), out raycastHit, 500f, this.fishCollisionMask))
		{
			to = raycastHit.normal;
		}
		this.nangle = Vector3.Angle(Vector3.up, to);
		float num2 = 0f;
		List<LocNewLogic.OMHDHFKKIIL> deepCircle = this.getDeepCircle(NHCLMBOINFG, 0.5f);
		foreach (LocNewLogic.OMHDHFKKIIL omhdhfkkiil in deepCircle)
		{
			num2 += omhdhfkkiil.KGMLACLJGAC;
		}
		LocNewLogic.OMHDHFKKIIL omhdhfkkiil2 = this.JDKJONHLLBE(NHCLMBOINFG);
		omhdhfkkiil2.KGMLACLJGAC = num2 / (float)deepCircle.Count;
		int num3 = 0;
		if (this.nangle > 18f)
		{
			num3 = 1;
		}
		if (this.nangle > 35f)
		{
			num3 = 2;
		}
		this.terrainSpecies.Add(num3);
		List<LocNewLogic.OMHDHFKKIIL> deepCircle2 = this.getDeepCircle(NHCLMBOINFG, 3f);
		bool flag = false;
		float num4 = 0f;
		int num5 = 0;
		this.cinfo = "";
		foreach (LocNewLogic.OMHDHFKKIIL omhdhfkkiil3 in deepCircle2)
		{
			this.cinfo = this.cinfo + omhdhfkkiil3.KGMLACLJGAC + "  ";
			if (omhdhfkkiil3.KGMLACLJGAC < 0.4f)
			{
				flag = true;
			}
			else
			{
				num4 += omhdhfkkiil3.KGMLACLJGAC;
				num5++;
			}
		}
		this.ctdeep = omhdhfkkiil2.KGMLACLJGAC;
		if (flag)
		{
			this.terrainSpecies.Add(40);
		}
		float num6 = num4 / (float)num5;
		if (num3 == 0 && Mathf.Abs(num6 - omhdhfkkiil2.KGMLACLJGAC) > 0.3f)
		{
			if (num6 > omhdhfkkiil2.KGMLACLJGAC)
			{
				this.terrainSpecies.Add(4);
			}
			if (num6 < omhdhfkkiil2.KGMLACLJGAC)
			{
				this.terrainSpecies.Add(3);
			}
		}
		this.meddeep = num6;
	}

	// Token: 0x0600692E RID: 26926 RVA: 0x00321408 File Offset: 0x0031F608
	public void fishDown(bool OBODEHICCGM = false, bool DABFJOBOKOE = false)
	{
		this.user.UserLookAtOff();
		this.user.leftHandCntrl.NKHBAJKMAGD = 0f;
		this.user.leftHandCntrl.FBFAJEGEIKM();
		this.user.leftHandCntrl.FANPFKHEDPA();
		this.user.isKeyPress = false;
		this.user.bipIK.solver.leftHandEffector.target = null;
		string iabkgmnjljo = JNBICAJIJMM.LEBHCLDODNI("fishdrop_1");
		if (OBODEHICCGM)
		{
			iabkgmnjljo = JNBICAJIJMM.LEBHCLDODNI("fishdrop_2");
		}
		if (DABFJOBOKOE)
		{
			iabkgmnjljo = JNBICAJIJMM.LEBHCLDODNI("fishdrop_3");
		}
		FlyMessageManager.getI.addMessageBig(iabkgmnjljo, new Color(0.7f, 0.5f, 0f), 0, 0);
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		this.user.PodsekType = 1;
		this.user.isPodsek = false;
		this.user.CIHILMCEJND = false;
		if (this.user.dropScrpt != null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(this.user.dropScrpt.transform.position, 1f);
			this.user.dropScrpt.kill();
		}
	}

	// Token: 0x0600692F RID: 26927 RVA: 0x0032153C File Offset: 0x0031F73C
	public void WLighterProcess()
	{
		if (this.moonLight == null)
		{
			return;
		}
		float num = this.WLighterActivity.Evaluate(TimeController.IKGFHGKKCPG.BCDLMJJHJMC) * this.WLighterScalator;
		bool flag = true;
		if (num < 0f)
		{
			flag = false;
		}
		this.moonLight.intensity = num;
		this.moonLight.gameObject.SetActive(flag);
		bool active = !flag;
		this.staticLight.gameObject.SetActive(active);
	}

	// Token: 0x06006930 RID: 26928 RVA: 0x003215B4 File Offset: 0x0031F7B4
	public void LEHLNLJPNFO(float MMJELGIIKMO, float HMJNNIOPOMB)
	{
		if (MMJELGIIKMO <= 274f)
		{
			this.stopRollSound();
			return;
		}
		float volume = 1067f;
		if (HMJNNIOPOMB > 144f)
		{
			float t = (HMJNNIOPOMB - 139f) * 465f;
			volume = Mathf.Lerp(1845f, HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK, t);
		}
		this.rollSound.pitch = 744f + (HPGKIJLKCIH.IKGFHGKKCPG.ONFPGNLCIGH - 716f) * 1903f + 638f * MMJELGIIKMO;
		this.rollSound.volume = volume;
		this.lowRollSound.volume = 1980f * HPGKIJLKCIH.IKGFHGKKCPG.PFKABGELOCK;
		this.lowRollSound.pitch = 872f + 1801f * MMJELGIIKMO;
		if (!this.lowRollSound.isPlaying)
		{
			this.lowRollSound.Play();
		}
		if (!this.rollSound.isPlaying)
		{
			this.rollSound.time = OLPINJLCKCI.IKGFHGKKCPG.GCPGDOACKLG((double)this.rollSound.clip.length);
			this.rollSound.Play();
		}
	}

	// Token: 0x06006931 RID: 26929 RVA: 0x003216CE File Offset: 0x0031F8CE
	private void PHMMMGHEMBK(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
	{
		if (this.cityWall == null)
		{
			return;
		}
		if (NOFCHOFPHAD == null)
		{
			return;
		}
		if (NOFCHOFPHAD.KEDGAOBCNJG == null)
		{
			return;
		}
		this.cityWall.texture = NOFCHOFPHAD.KEDGAOBCNJG;
	}

	// Token: 0x06006932 RID: 26930 RVA: 0x00321704 File Offset: 0x0031F904
	private void EKMGJGNMCOA(bool KLOLLKKIDJC = true)
	{
		if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL)
		{
			if (this.user && this.user.MFENINHGBHM)
			{
				if (!this.user.CIHILMCEJND)
				{
					if (Input.GetMouseButtonUp(0))
					{
						if (Application.isEditor)
						{
							if (this.KOEHHGHGFEK)
							{
								Debug.Log("isDownOnWater ok");
							}
							if (this.user.standFlag)
							{
								Debug.Log("user.standFlag ok");
							}
							if (this.checkMousePosition())
							{
								Debug.Log("checkMousePosition ok");
							}
						}
						if (this.KOEHHGHGFEK && this.user.standFlag && this.checkMousePosition())
						{
							Vector3 position = this.dexCircleGO.transform.position;
							position.y = this.OGJHINOLHJJ;
							this.dropAction(position);
						}
					}
					if (Input.GetMouseButton(0) && this.KOEHHGHGFEK)
					{
						if (this.user != null)
						{
							if (this.user.standFlag)
							{
								this.circles.SetActive(true);
							}
							this.user.UserLookAtOn(this.dexCircleGO.transform.position + Vector3.up * 1f);
						}
					}
					else
					{
						this.circles.SetActive(false);
						this.user.cursorPoint = Vector3.zero;
						if (this.user != null)
						{
							this.user.UserLookAtOff();
						}
					}
				}
				else
				{
					this.circles.SetActive(false);
					this.user.cursorPoint = Vector3.zero;
					if (KLOLLKKIDJC)
					{
						this.RodInWaterLogic();
					}
				}
			}
			else
			{
				this.circles.SetActive(false);
				this.user.cursorPoint = Vector3.zero;
			}
		}
		if (!Input.GetMouseButton(0))
		{
			this.circles.SetActive(false);
		}
		float pointerDistance = this.getPointerDistance();
		this.AMMHKJECEID = BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(pointerDistance);
		this.dexCircleGO.gameObject.SetActive(pointerDistance <= BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB);
		this.dexLDObj.SetActive(this.circles.activeSelf);
		Color faodpfdpclh = this.checkPosition(Input.mousePosition) ? this.okZabros : this.noZabros;
		JLFJEGIPIMM.IKGFHGKKCPG.FAKEIBOBCGO(this.dexCircleGO.gameObject, "_TintColor", faodpfdpclh);
		if (this.user != null)
		{
			Vector3 position2 = this.user.transform.position;
			position2.y = this.OGJHINOLHJJ + 0.15f;
			this.circles.transform.position = position2;
			this.circles.transform.rotation = this.user.transform.rotation;
			this.MHHOOOEJGFM = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB;
			this.PBCADOCADPC = BOIKJDICEMF.IKGFHGKKCPG.MEPKMAFJIOL;
			Vector2 v = Input.mousePosition;
			if (!this.OCFJLOGPMNI)
			{
				v = new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f);
			}
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(v), out raycastHit, 100f, this.waterCheckRay))
			{
				Vector3 point = raycastHit.point;
				point.y = this.OGJHINOLHJJ + 0.1f;
				this.calculateTerrainSpecies((this.user.dropScrpt == null) ? point : this.user.dropScrpt.transform.position);
				this.dexCircleGO.transform.position = point;
				this.MPIIKIHLNAJ();
			}
		}
		if (Input.GetMouseButtonUp(0))
		{
			this.KOEHHGHGFEK = false;
		}
	}

	// Token: 0x04000EFD RID: 3837
	public GetFishWin GFWin;

	// Token: 0x04000EFE RID: 3838
	public float linetensionKF = 0.05f;

	// Token: 0x04000EFF RID: 3839
	public CamEffector effector;

	// Token: 0x04000F00 RID: 3840
	public float toFVUser = 50f;

	// Token: 0x04000F01 RID: 3841
	public float toFVUserSpin = 50f;

	// Token: 0x04000F02 RID: 3842
	public float toFVNormal = 60f;

	// Token: 0x04000F03 RID: 3843
	public Image freeLine1;

	// Token: 0x04000F04 RID: 3844
	public Image freeLine2;

	// Token: 0x04000F05 RID: 3845
	public bool isBase;

	// Token: 0x04000F06 RID: 3846
	public Transform baseUserInstPoint;

	// Token: 0x04000F07 RID: 3847
	public GameObject baseScene;

	// Token: 0x04000F08 RID: 3848
	public PanelParam speedPanel;

	// Token: 0x04000F09 RID: 3849
	public PanelParam deepPanel;

	// Token: 0x04000F0A RID: 3850
	public PanelParam fricPanel;

	// Token: 0x04000F0B RID: 3851
	public GameObject toCamLookObject;

	// Token: 0x04000F0C RID: 3852
	public AnimationCurve[] animSpinningUpRod;

	// Token: 0x04000F0D RID: 3853
	public AnimationCurve[] addForceSpinningUpRod;

	// Token: 0x04000F0E RID: 3854
	public AnimationCurve blendRodDirCurve;

	// Token: 0x04000F0F RID: 3855
	public AnimationCurve jampFishFactorCurve;

	// Token: 0x04000F10 RID: 3856
	public float baitSpeedDeepKF = 0.3f;

	// Token: 0x04000F11 RID: 3857
	public float vobdeepscaler = 3f;

	// Token: 0x04000F12 RID: 3858
	public float maxvoblerdeepspeed = 2f;

	// Token: 0x04000F13 RID: 3859
	public float minbaitSpeed = 0.1f;

	// Token: 0x04000F14 RID: 3860
	public RectTransform hidePanelReal;

	// Token: 0x04000F15 RID: 3861
	public Vector2 MinMaxSent;

	// Token: 0x04000F16 RID: 3862
	public float sensitivityBlendRod = 1f;

	// Token: 0x04000F17 RID: 3863
	public float toCamPosHGT = 0.01f;

	// Token: 0x04000F18 RID: 3864
	public bool isDebugMode;

	// Token: 0x04000F19 RID: 3865
	public Text timeLabel;

	// Token: 0x04000F1A RID: 3866
	public TrailRenderer voblertrail;

	// Token: 0x04000F1B RID: 3867
	public GameObject dexLDObj;

	// Token: 0x04000F1C RID: 3868
	public Color noZabros;

	// Token: 0x04000F1D RID: 3869
	public Color okZabros;

	// Token: 0x04000F1E RID: 3870
	public LineRope lineRope;

	// Token: 0x04000F1F RID: 3871
	public const float sm_pitch = 0.2f;

	// Token: 0x04000F20 RID: 3872
	public Material[] waterMaterials;

	// Token: 0x04000F21 RID: 3873
	public AudioClip fonaricOnClip;

	// Token: 0x04000F22 RID: 3874
	public Text lineDstTxt;

	// Token: 0x04000F23 RID: 3875
	public Text lineDstTxt2;

	// Token: 0x04000F24 RID: 3876
	public Text FricParTxt;

	// Token: 0x04000F25 RID: 3877
	public Text FricTxt1;

	// Token: 0x04000F26 RID: 3878
	public Text FricTxt2;

	// Token: 0x04000F27 RID: 3879
	public Light staticLight;

	// Token: 0x04000F28 RID: 3880
	public Light dinamycLight;

	// Token: 0x04000F29 RID: 3881
	public Light waterLighter;

	// Token: 0x04000F2A RID: 3882
	public Light moonLight;

	// Token: 0x04000F2B RID: 3883
	public AnimationCurve WLighterActivity;

	// Token: 0x04000F2C RID: 3884
	public float WLighterScalator = 0.3f;

	// Token: 0x04000F2D RID: 3885
	public LayerMask fishCollisionMask;

	// Token: 0x04000F2E RID: 3886
	public Texture fishRenderTexture;

	// Token: 0x04000F2F RID: 3887
	public static LocNewLogic getI;

	// Token: 0x04000F30 RID: 3888
	public Button rodOpenBtn;

	// Token: 0x04000F31 RID: 3889
	public AudioSource frikcionSound;

	// Token: 0x04000F32 RID: 3890
	public AudioSource lowFrikcSound;

	// Token: 0x04000F33 RID: 3891
	public AudioSource lowRollSound;

	// Token: 0x04000F34 RID: 3892
	public AudioSource rollSound;

	// Token: 0x04000F35 RID: 3893
	public AudioSource rollNoRelSound;

	// Token: 0x04000F36 RID: 3894
	public GameObject WaterCircleCatalog;

	// Token: 0x04000F37 RID: 3895
	public GameObject baitSplashPrfb;

	// Token: 0x04000F38 RID: 3896
	public GameObject smallSplashPrfb;

	// Token: 0x04000F39 RID: 3897
	public GameObject mediumSplashPrfb;

	// Token: 0x04000F3A RID: 3898
	public GameObject bigSplashPrfb;

	// Token: 0x04000F3B RID: 3899
	public Text citate;

	// Token: 0x04000F3C RID: 3900
	public GameObject gameChatPrefab;

	// Token: 0x04000F3D RID: 3901
	public GameObject defaultBaitModelPrefab;

	// Token: 0x04000F3E RID: 3902
	public GameObject waterCircleFishPrefab;

	// Token: 0x04000F3F RID: 3903
	public GameObject waterCirclePrefab;

	// Token: 0x04000F40 RID: 3904
	public GameObject waterCircleSmallPrefab;

	// Token: 0x04000F41 RID: 3905
	public WpnImageObj[] wpnCells;

	// Token: 0x04000F42 RID: 3906
	public GameObject _poplCameraInst;

	// Token: 0x04000F43 RID: 3907
	public RectTransform _poplCameraGUI;

	// Token: 0x04000F44 RID: 3908
	public GameObject circles;

	// Token: 0x04000F45 RID: 3909
	public Transform minDistanceGO;

	// Token: 0x04000F46 RID: 3910
	public Transform maxDistanceGO;

	// Token: 0x04000F47 RID: 3911
	public Transform minLineDistanceGO;

	// Token: 0x04000F48 RID: 3912
	public Transform zabrosNpr;

	// Token: 0x04000F49 RID: 3913
	public Transform getPosGO;

	// Token: 0x04000F4A RID: 3914
	public Transform dexCircleGO;

	// Token: 0x04000F4B RID: 3915
	public Transform nprCircleGO;

	// Token: 0x04000F4C RID: 3916
	public RectTransform mainCanvas;

	// Token: 0x04000F4D RID: 3917
	public RectTransform loadCanvas;

	// Token: 0x04000F4E RID: 3918
	public RawImage cityWall;

	// Token: 0x04000F4F RID: 3919
	public Text baseName;

	// Token: 0x04000F50 RID: 3920
	public WinSettings ws;

	// Token: 0x04000F51 RID: 3921
	public TOD_Sky todSky;

	// Token: 0x04000F52 RID: 3922
	public Sunshine shine;

	// Token: 0x04000F53 RID: 3923
	public Transform todSkySun;

	// Token: 0x04000F54 RID: 3924
	public SceneData sd;

	// Token: 0x04000F55 RID: 3925
	public ProgressBar loadPb;

	// Token: 0x04000F56 RID: 3926
	public Fisherman user;

	// Token: 0x04000F57 RID: 3927
	public GameObject water;

	// Token: 0x04000F58 RID: 3928
	public LayerMask waterCheckRay;

	// Token: 0x04000F59 RID: 3929
	public Vector3 toDropPoint;

	// Token: 0x04000F5A RID: 3930
	public ReelPanel panelRoll;

	// Token: 0x04000F5B RID: 3931
	public ProgressBar PBar_Up;

	// Token: 0x04000F5C RID: 3932
	public ProgressBar PBar_Down;

	// Token: 0x04000F5D RID: 3933
	public ProgressBar PBarAdd_Up;

	// Token: 0x04000F5E RID: 3934
	public ProgressBar PBarAdd_Down;

	// Token: 0x04000F5F RID: 3935
	public ProgressBar PBarStamina;

	// Token: 0x04000F60 RID: 3936
	public ProgressBar PBarResult;

	// Token: 0x04000F61 RID: 3937
	public ProgressBar PBarRollCat;

	// Token: 0x04000F62 RID: 3938
	public WowCamera wcam;

	// Token: 0x04000F63 RID: 3939
	public Vector3 toCamSM = Vector3.zero;

	// Token: 0x04000F64 RID: 3940
	public Material waterMaterial;

	// Token: 0x04000F65 RID: 3941
	public Text evntsText1;

	// Token: 0x04000F66 RID: 3942
	public Text evntsText2;

	// Token: 0x04000F67 RID: 3943
	public bool isMovingEnable;

	// Token: 0x04000F68 RID: 3944
	public bool isLevelLoadProcess;

	// Token: 0x04000F69 RID: 3945
	private NEBJANKNJOG EEPNACDOOBF;

	// Token: 0x04000F6A RID: 3946
	public int baseid = 1;

	// Token: 0x04000F6B RID: 3947
	public int locid = 101;

	// Token: 0x04000F6C RID: 3948
	public int pointid;

	// Token: 0x04000F6D RID: 3949
	public float alp;

	// Token: 0x04000F6E RID: 3950
	public float torodproc;

	// Token: 0x04000F6F RID: 3951
	public MouseLooks mouseLook;

	// Token: 0x04000F70 RID: 3952
	private float BCOMJHNGOHH;

	// Token: 0x04000F71 RID: 3953
	public float startAnimSpinTime;

	// Token: 0x04000F72 RID: 3954
	public int animCurveID;

	// Token: 0x04000F73 RID: 3955
	public float waterLevel4Fog;

	// Token: 0x04000F74 RID: 3956
	public float wtime;

	// Token: 0x04000F75 RID: 3957
	private MMKFAENBHKD PHFFFJIKHNJ;

	// Token: 0x04000F76 RID: 3958
	private EKBAPCMPANI LGEIAMMMJOF;

	// Token: 0x04000F77 RID: 3959
	private int PAIPILKFEDC;

	// Token: 0x04000F78 RID: 3960
	private int IIPDNDLKOKN;

	// Token: 0x04000F79 RID: 3961
	private int ILCOIIBDOCI = -1;

	// Token: 0x04000F7A RID: 3962
	private Queue<GameObject> JMHOJPJONNJ = new Queue<GameObject>();

	// Token: 0x04000F7B RID: 3963
	private Queue<GameObject> COOFLDJIDCK = new Queue<GameObject>();

	// Token: 0x04000F7C RID: 3964
	private Queue<GameObject> FBCOEHFKIJI = new Queue<GameObject>();

	// Token: 0x04000F7D RID: 3965
	private const float LNNCAENJDJN = 0.001f;

	// Token: 0x04000F7E RID: 3966
	private float OLHNBLFPBGF;

	// Token: 0x04000F7F RID: 3967
	private float EBOCMLKGHKH;

	// Token: 0x04000F80 RID: 3968
	private float DHOIDINAIHA;

	// Token: 0x04000F81 RID: 3969
	public float nangle;

	// Token: 0x04000F82 RID: 3970
	public float ctdeep;

	// Token: 0x04000F83 RID: 3971
	public float meddeep;

	// Token: 0x04000F84 RID: 3972
	public string cinfo = "";

	// Token: 0x04000F85 RID: 3973
	public List<int> terrainSpecies = new List<int>();

	// Token: 0x04000F86 RID: 3974
	public Vector3 flowForce = Vector3.zero;

	// Token: 0x04000F87 RID: 3975
	public GameObject sonar;

	// Token: 0x04000F88 RID: 3976
	public float rodTmr;

	// Token: 0x04000F89 RID: 3977
	public float lineTmr;

	// Token: 0x04000F8A RID: 3978
	public float wlintens;

	// Token: 0x04000F8B RID: 3979
	private bool PEFPELGDHPK;

	// Token: 0x04000F8C RID: 3980
	private bool OGBHPFEEJJH;

	// Token: 0x04000F8D RID: 3981
	private float MCLCCJKPMBF;

	// Token: 0x04000F8E RID: 3982
	private float CNIBLMMFPEI;

	// Token: 0x04000F8F RID: 3983
	public float bspeedkf = 0.6f;

	// Token: 0x04000F90 RID: 3984
	public float toBaitSpinSpeed;

	// Token: 0x04000F91 RID: 3985
	public float baitSpinSpeed;

	// Token: 0x04000F92 RID: 3986
	private float GPBFJBKCOKJ;

	// Token: 0x04000F93 RID: 3987
	private float ICNOLCEBBGI;

	// Token: 0x04000F94 RID: 3988
	private const float DKKOPOGHJKP = 0.5f;

	// Token: 0x04000F95 RID: 3989
	private float PDKLBDEKFOL;

	// Token: 0x04000F96 RID: 3990
	private bool KOEHHGHGFEK;

	// Token: 0x04000F97 RID: 3991
	public Vector3 lastPosition;

	// Token: 0x04000F98 RID: 3992
	public float zoom;

	// Token: 0x04000F99 RID: 3993
	public bool camToPplOn;

	// Token: 0x04000F9A RID: 3994
	public Vector3 toCamLook = Vector3.zero;

	// Token: 0x04000F9B RID: 3995
	public Vector3 toCamPos = Vector3.zero;

	// Token: 0x04000F9C RID: 3996
	public float toFieldView = 60f;

	// Token: 0x04000F9D RID: 3997
	private float EEJPCEBHELM;

	// Token: 0x04000F9E RID: 3998
	private float FPJLHGKJCFA;

	// Token: 0x04000F9F RID: 3999
	private Vector3 FHGBHFHHNAP = Vector3.zero;

	// Token: 0x04000FA0 RID: 4000
	public bool rodUpMove;

	// Token: 0x04000FA1 RID: 4001
	private bool NANKIDAJFJF;

	// Token: 0x04000FA2 RID: 4002
	private float JCKKMKECMFA;

	// Token: 0x04000FA3 RID: 4003
	private GameObject CNOLCNDBLJE;

	// Token: 0x04000FA4 RID: 4004
	private int HPHJEAKFLIC;

	// Token: 0x04000FA5 RID: 4005
	private int BCEGLBCCGEN;

	// Token: 0x020001CE RID: 462
	public struct OMHDHFKKIIL
	{
		// Token: 0x04000FA6 RID: 4006
		public float KGMLACLJGAC;

		// Token: 0x04000FA7 RID: 4007
		public float GNECCLKKHBG;
	}
}
