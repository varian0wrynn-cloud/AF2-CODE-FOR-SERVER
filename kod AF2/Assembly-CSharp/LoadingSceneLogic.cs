using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200011B RID: 283
public class LoadingSceneLogic : MonoBehaviour
{
	// Token: 0x060039AB RID: 14763 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator GNAENGCKPJI()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039AC RID: 14764 RVA: 0x001A3FCB File Offset: 0x001A21CB
	private void NCALLFHEAGJ()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.LCEBBHPKOHO() + "shop_t4";
		base.StartCoroutine("_Radius2");
	}

	// Token: 0x060039AD RID: 14765 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator CBBOFIECLNO()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039AE RID: 14766 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator KMPIALLPNFJ()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039AF RID: 14767 RVA: 0x001A4000 File Offset: 0x001A2200
	private void MPPMHCICKIP()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(16f, 924f, 1894f, 1091f), "_Speed" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1210f) + "cntx_teachexp");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.LoadingError)
		{
			return;
		}
		GUI.Label(new Rect(971f, 600f, (float)Screen.width, 1137f), "System.Single" + this.PFKGPFHEFPO + "Fist Pump 2" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039B0 RID: 14768 RVA: 0x001A40A4 File Offset: 0x001A22A4
	private void PDEEOGAAMBB()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(829f, 326f, 1689f, 236f), "id" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 992f) + "Mouse X");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)7)
		{
			return;
		}
		GUI.Label(new Rect(1360f, 1528f, (float)Screen.width, 278f), " point=" + this.PFKGPFHEFPO + "IdleMonster" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039B1 RID: 14769 RVA: 0x001A4148 File Offset: 0x001A2348
	private void IAAOGAPJDID()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "auk buy result: ";
		base.StartCoroutine("OneHandSwordReady");
	}

	// Token: 0x060039B2 RID: 14770 RVA: 0x001A4180 File Offset: 0x001A2380
	private void LKAMGOGAMCH()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(793f, 1689f, 662f, 1090f), "_Offsets" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 363f) + "notQuestShow");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)4)
		{
			return;
		}
		GUI.Label(new Rect(1696f, 542f, (float)Screen.width, 1381f), "OneHandSwordSwing" + this.PFKGPFHEFPO + "{not_found}" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039B3 RID: 14771 RVA: 0x001A4224 File Offset: 0x001A2424
	private void KIEFPGLDOCD()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1796f, 558f, 780f, 745f), "bag" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1355f) + "cut.ogg");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)8)
		{
			return;
		}
		GUI.Label(new Rect(202f, 684f, (float)Screen.width, 614f), "MENU.WAV" + this.PFKGPFHEFPO + "UNDERLINE" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039B4 RID: 14772 RVA: 0x001A42C8 File Offset: 0x001A24C8
	private void JEJGFDBHABC()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1708f, 265f, 137f, 1324f), "0" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 367f) + "   ");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)5)
		{
			return;
		}
		GUI.Label(new Rect(1304f, 1365f, (float)Screen.width, 138f), "crft_to" + this.PFKGPFHEFPO + "ClimbLeft" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039B5 RID: 14773 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator IHPPHMJJEIH()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039B6 RID: 14774 RVA: 0x001A437C File Offset: 0x001A257C
	private void PNAEIDCONFP()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(931f, 462f, 517f, 990f), "" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1970f) + "Bases/Base_1.unity3d");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)3)
		{
			return;
		}
		GUI.Label(new Rect(523f, 889f, (float)Screen.width, 1319f), "Mouse Y" + this.PFKGPFHEFPO + "forSex" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039B7 RID: 14775 RVA: 0x001A4420 File Offset: 0x001A2620
	private void HPDBKKOFBHN()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1980f, 1309f, 1442f, 1083f), "_Convolved_TexelSize" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 106f) + "category");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)5)
		{
			return;
		}
		GUI.Label(new Rect(82f, 1896f, (float)Screen.width, 930f), "ScatterDitherMap" + this.PFKGPFHEFPO + "MotorbikeSeatStand" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039B8 RID: 14776 RVA: 0x001A44C4 File Offset: 0x001A26C4
	private void IMABGALEMBI()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.LIOPCJFCGAF() + "cht_ach2";
		base.StartCoroutine("Current fog preset: ");
	}

	// Token: 0x060039B9 RID: 14777 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator OMKOIMGLOHN()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039BB RID: 14779 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator ILPFFHIKNOI()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039BC RID: 14780 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator EABBEOAJAGH()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039BD RID: 14781 RVA: 0x001A4516 File Offset: 0x001A2716
	private void JPHBPEAMNHB()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.BKKFFINMJBO() + "IdleKeepBack";
		base.StartCoroutine("pointBuffer");
	}

	// Token: 0x060039BE RID: 14782 RVA: 0x001A454B File Offset: 0x001A274B
	private void PLBDELOIINH()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "_History1Weight";
		base.StartCoroutine(" (");
	}

	// Token: 0x060039BF RID: 14783 RVA: 0x001A4580 File Offset: 0x001A2780
	private void CAJLCEPLKJG()
	{
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.BKKFFINMJBO() + "MotorbikeWheelyNoHands";
		base.StartCoroutine("no_task");
	}

	// Token: 0x060039C0 RID: 14784 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator MNAFBHKNEEP()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039C1 RID: 14785 RVA: 0x001A45B5 File Offset: 0x001A27B5
	private void MCHAAIIHOKD()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.LIOPCJFCGAF() + "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html";
		base.StartCoroutine("jamp");
	}

	// Token: 0x060039C2 RID: 14786 RVA: 0x001A45EA File Offset: 0x001A27EA
	private void CKIGGCAHAFD()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.NEJIPLDOMMC() + "_Exposure";
		base.StartCoroutine("Vertical");
	}

	// Token: 0x060039C3 RID: 14787 RVA: 0x001A461F File Offset: 0x001A281F
	private void BHFMGBNIAMC()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.ACOEIDGDLJC() + "</color>";
		base.StartCoroutine("/");
	}

	// Token: 0x060039C4 RID: 14788 RVA: 0x001A4654 File Offset: 0x001A2854
	private void BIOKMDIGOIA()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(294f, 173f, 1281f, 61f), "Smoking1" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1239f) + "invn_ver2");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)4)
		{
			return;
		}
		GUI.Label(new Rect(417f, 858f, (float)Screen.width, 744f), "invn_rec5" + this.PFKGPFHEFPO + "" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039C5 RID: 14789 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator EHJEHHEOOFJ()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039C6 RID: 14790 RVA: 0x001A46F8 File Offset: 0x001A28F8
	private void LHOKCJCHLOM()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(293f, 1933f, 1420f, 1413f), "SneakLeft" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 692f) + "ProneIdle");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)6)
		{
			return;
		}
		GUI.Label(new Rect(292f, 31f, (float)Screen.width, 1879f), "languageid" + this.PFKGPFHEFPO + "OneHandSwordRun" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039C7 RID: 14791 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator OAJPPMALFDF()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039C8 RID: 14792 RVA: 0x001A479C File Offset: 0x001A299C
	private void BBFPILBIMKC()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.NEJIPLDOMMC() + "Horizontal";
		base.StartCoroutine("u_pass");
	}

	// Token: 0x060039C9 RID: 14793 RVA: 0x001A47D1 File Offset: 0x001A29D1
	private void ONIHHFLOJMN()
	{
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.NEJIPLDOMMC() + "wpn_add/use_effect/effect";
		base.StartCoroutine("GiantGrabThrow2");
	}

	// Token: 0x060039CA RID: 14794 RVA: 0x001A4808 File Offset: 0x001A2A08
	private void HKGCKLBHNPJ()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(791f, 430f, 1599f, 300f), "error.wav" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1776f) + "(");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			return;
		}
		GUI.Label(new Rect(1099f, 1440f, (float)Screen.width, 1316f), "Failed parsing organizational group.  Setting to group 0" + this.PFKGPFHEFPO + "Trying to solve uninitiated FABRIK chain." + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039CB RID: 14795 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator JHAHBKJDLCF()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039CC RID: 14796 RVA: 0x001A48AC File Offset: 0x001A2AAC
	private void PNAAHEFHPCL()
	{
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.ACOEIDGDLJC() + "money";
		base.StartCoroutine("Weapon Reload");
	}

	// Token: 0x060039CD RID: 14797 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator BKNEMEOMAHG()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039CE RID: 14798 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator OPPMOGILDDO()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039CF RID: 14799 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator CKFDLHJHEEA()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039D0 RID: 14800 RVA: 0x001A48E4 File Offset: 0x001A2AE4
	private void KOFPOKABFIA()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(903f, 1742f, 32f, 1275f), ", point " + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 930f) + "");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)6)
		{
			return;
		}
		GUI.Label(new Rect(1051f, 546f, (float)Screen.width, 1187f), "Worker Pickaxe" + this.PFKGPFHEFPO + "KatanaHorizontalSwing" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039D1 RID: 14801 RVA: 0x001A4988 File Offset: 0x001A2B88
	private void HHGGCBLOJGB()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.ACOEIDGDLJC() + "wpn_add/base";
		base.StartCoroutine("");
	}

	// Token: 0x060039D2 RID: 14802 RVA: 0x001A49BD File Offset: 0x001A2BBD
	private void KIEIPFFEDHC()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.ACOEIDGDLJC() + "IdleButtonPress";
		base.StartCoroutine("PHMBCFOLEEP");
	}

	// Token: 0x060039D3 RID: 14803 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator OGNFLFDIELI()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039D4 RID: 14804 RVA: 0x001A49F2 File Offset: 0x001A2BF2
	private void LPNDCJKAKEA()
	{
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "SwimDogPaddle";
		base.StartCoroutine("WalkInjured");
	}

	// Token: 0x060039D5 RID: 14805 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator FDEANKBLLNA()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039D6 RID: 14806 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator JBCLDCAPICI()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039D7 RID: 14807 RVA: 0x001A4A28 File Offset: 0x001A2C28
	private void EEJAAPBJHOO()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1107f, 528f, 756f, 179f), "change me!" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1496f) + "MotorbikeIdle");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.GameWork)
		{
			return;
		}
		GUI.Label(new Rect(22f, 1768f, (float)Screen.width, 1137f), "OfficeSittingReadingLeanBack" + this.PFKGPFHEFPO + "wpn_add/base" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039D8 RID: 14808 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator MPAAABOKPBE()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039D9 RID: 14809 RVA: 0x001A4ACC File Offset: 0x001A2CCC
	private void ELADFDNPOOI()
	{
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.AFJFDKAGKLD() + " Категория ";
		base.StartCoroutine("IdleDrink");
	}

	// Token: 0x060039DA RID: 14810 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator IHIOHKAOBDD()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039DB RID: 14811 RVA: 0x001A4B01 File Offset: 0x001A2D01
	private void DGEIACONKCJ()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "DealerIdle";
		base.StartCoroutine(")");
	}

	// Token: 0x060039DC RID: 14812 RVA: 0x001A4B36 File Offset: 0x001A2D36
	private void JLKBMEBFHBI()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.AFJFDKAGKLD() + "act_orderb_";
		base.StartCoroutine("PaperTurn.wav");
	}

	// Token: 0x060039DD RID: 14813 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator OKOLEEGFDBH()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039DE RID: 14814 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator IMODKNMOBBM()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039DF RID: 14815 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator OFONHEONOCE()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039E0 RID: 14816 RVA: 0x001A4B6B File Offset: 0x001A2D6B
	private void Start()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "Bases/Base_1.unity3d";
		base.StartCoroutine("OAJPPMALFDF");
	}

	// Token: 0x060039E1 RID: 14817 RVA: 0x001A4BA0 File Offset: 0x001A2DA0
	private void DHJDMKLBLEF()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.AFJFDKAGKLD() + "USER_LUT";
		base.StartCoroutine("FaceHit");
	}

	// Token: 0x060039E2 RID: 14818 RVA: 0x001A4BD8 File Offset: 0x001A2DD8
	private void OBDAPPLCPMD()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1775f, 752f, 576f, 1717f), "Jump" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1354f) + "0_");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)3)
		{
			return;
		}
		GUI.Label(new Rect(20f, 98f, (float)Screen.width, 770f), "Trigger Item Has No Collider" + this.PFKGPFHEFPO + "isRealView" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039E3 RID: 14819 RVA: 0x001A4C7C File Offset: 0x001A2E7C
	private void ANHOOJFEJJE()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.NEJIPLDOMMC() + "_Histogram";
		base.StartCoroutine("V");
	}

	// Token: 0x060039E4 RID: 14820 RVA: 0x001A4CB4 File Offset: 0x001A2EB4
	private void EAOOIFBELKG()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(128f, 1556f, 23f, 163f), "IdleStun" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1649f) + "");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.LoadingError)
		{
			return;
		}
		GUI.Label(new Rect(391f, 609f, (float)Screen.width, 1443f), "sunshine_CameraVToSunVP" + this.PFKGPFHEFPO + "_Intensity" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039E5 RID: 14821 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator HFFIDNEPLLL()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039E6 RID: 14822 RVA: 0x001A4D58 File Offset: 0x001A2F58
	private void IBEHHMCBCIH()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1815f, 1423f, 673f, 861f), "_ReflectionTex" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1098f) + "IdleFight");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)7)
		{
			return;
		}
		GUI.Label(new Rect(194f, 163f, (float)Screen.width, 113f), "_HalfResolution" + this.PFKGPFHEFPO + "_NeighbourMaxTex" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039E7 RID: 14823 RVA: 0x001A4DFC File Offset: 0x001A2FFC
	private void IJILHIBFFCF()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(368f, 1795f, 1370f, 1250f), "Unable to create Lightmap" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 517f) + "http://www.root-motion.com/finalikdox/html/page2.html");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)7)
		{
			return;
		}
		GUI.Label(new Rect(509f, 614f, (float)Screen.width, 1638f), "The InteractionTrigger in the list 'inContact' has been destroyed" + this.PFKGPFHEFPO + "ObscuredString vs string, " + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039E8 RID: 14824 RVA: 0x001A4EA0 File Offset: 0x001A30A0
	private void FIJKDFIMELM()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.LCEBBHPKOHO() + "<color='#000000'>";
		base.StartCoroutine("ui_default_close.wav");
	}

	// Token: 0x060039E9 RID: 14825 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator IDFJAGKMDGC()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039EA RID: 14826 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator OAIOHJFHKIE()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039EB RID: 14827 RVA: 0x001A4ED8 File Offset: 0x001A30D8
	private void JAOIOHLFLFO()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(383f, 181f, 210f, 280f), "Delete" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1180f) + "IdleStand");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)6)
		{
			return;
		}
		GUI.Label(new Rect(1993f, 792f, (float)Screen.width, 1619f), "cht_ach3" + this.PFKGPFHEFPO + "End" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039EC RID: 14828 RVA: 0x001A4F7C File Offset: 0x001A317C
	private void EMNMOMGOBPI()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(937f, 685f, 1547f, 1560f), "auc_wcswcp" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 576f) + "act_order");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)3)
		{
			return;
		}
		GUI.Label(new Rect(257f, 1320f, (float)Screen.width, 1687f), "Scuba OK" + this.PFKGPFHEFPO + "cht_msg40" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039ED RID: 14829 RVA: 0x001A5020 File Offset: 0x001A3220
	private void NOBANMDHKNK()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(382f, 288f, 1302f, 720f), "_camRotate" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 703f) + "Failed downloading bundle {0} from {1}: {2}");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)8)
		{
			return;
		}
		GUI.Label(new Rect(1592f, 539f, (float)Screen.width, 1852f), "rait_5" + this.PFKGPFHEFPO + "CratePush" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039EE RID: 14830 RVA: 0x001A50C4 File Offset: 0x001A32C4
	private void LGKEFLBKIGN()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1667f, 1069f, 499f, 1510f), "cht_msg16" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1437f) + "UI_DynamicWindow");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.GameWork)
		{
			return;
		}
		GUI.Label(new Rect(204f, 1770f, (float)Screen.width, 1283f), " ms" + this.PFKGPFHEFPO + "isAlwaisGetFish" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039EF RID: 14831 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator ICGIHDAAPOO()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039F0 RID: 14832 RVA: 0x001A5168 File Offset: 0x001A3368
	private void JGDDEOALNOG()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(938f, 1324f, 657f, 1632f), "Bases/{0}/" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1202f) + " x");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)7)
		{
			return;
		}
		GUI.Label(new Rect(1225f, 853f, (float)Screen.width, 1137f), "rollSoundVolume" + this.PFKGPFHEFPO + "** Panel save position" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039F1 RID: 14833 RVA: 0x001A520C File Offset: 0x001A340C
	private void JFFPLABGMNF()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.NEJIPLDOMMC() + "Grounded Strafe";
		base.StartCoroutine("Mouse ScrollWheel");
	}

	// Token: 0x060039F2 RID: 14834 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator LPFDHIAKPFK()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039F3 RID: 14835 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator DGBMKPOKHPC()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x060039F4 RID: 14836 RVA: 0x001A5244 File Offset: 0x001A3444
	private void PNJNNNJEBGA()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1126f, 1154f, 409f, 1392f), "{not_found}" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1160f) + "");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)6)
		{
			return;
		}
		GUI.Label(new Rect(1749f, 319f, (float)Screen.width, 937f), "sunshine_ShadowCoordDepthStart" + this.PFKGPFHEFPO + "One of the Bones is null." + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039F5 RID: 14837 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator ABDJBDOCGLE()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039F6 RID: 14838 RVA: 0x001A52E8 File Offset: 0x001A34E8
	private void MJDKGMEPMHK()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(543f, 1915f, 1894f, 572f), "MotorbikeHeadstand" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 292f) + ":");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)4)
		{
			return;
		}
		GUI.Label(new Rect(1382f, 1267f, (float)Screen.width, 1942f), "GiantGrabIdle" + this.PFKGPFHEFPO + "" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039F7 RID: 14839 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator FMGLKGNGGDC()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x060039F8 RID: 14840 RVA: 0x001A538C File Offset: 0x001A358C
	private void NCLNNJIGFOO()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(47f, 737f, 840f, 542f), "IKSolverFABRIKRoot chain at index " + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 171f) + "Write your note here");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.GameWork)
		{
			return;
		}
		GUI.Label(new Rect(1666f, 290f, (float)Screen.width, 216f), "_info" + this.PFKGPFHEFPO + "" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039F9 RID: 14841 RVA: 0x001A5430 File Offset: 0x001A3630
	private void GDIMBBBPIHI()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "toe";
		base.StartCoroutine("Swim");
	}

	// Token: 0x060039FA RID: 14842 RVA: 0x001A5465 File Offset: 0x001A3665
	private void ACLJDJBJLCD()
	{
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.NEJIPLDOMMC() + "MotorbikeWheely";
		base.StartCoroutine("1HandSwordChargeUp");
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x001A549A File Offset: 0x001A369A
	private void FPLHODJCJDO()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.BKKFFINMJBO() + "_DistortParams";
		base.StartCoroutine("HookPoint");
	}

	// Token: 0x060039FC RID: 14844 RVA: 0x001A54D0 File Offset: 0x001A36D0
	private void NBGFJFIMHAC()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1044f, 247f, 291f, 1254f), "wpn_add/base" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 880f) + "CP0");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			return;
		}
		GUI.Label(new Rect(410f, 1548f, (float)Screen.width, 1971f), "* change" + this.PFKGPFHEFPO + "CrouchStrafeRight" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x001A5574 File Offset: 0x001A3774
	private void OnGUI()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(5f, 5f, 300f, 20f), "Загрузка: " + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 100f) + "%");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.LoadingError)
		{
			return;
		}
		GUI.Label(new Rect(5f, 5f, (float)Screen.width, 40f), "Ошибка: " + this.PFKGPFHEFPO + "\n" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039FE RID: 14846 RVA: 0x001A5618 File Offset: 0x001A3818
	private void FLDMAFHJLNB()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(270f, 1062f, 840f, 1662f), "Wizard2HandThrow" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 694f) + "");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)7)
		{
			return;
		}
		GUI.Label(new Rect(1607f, 649f, (float)Screen.width, 1576f), "_DepthFade" + this.PFKGPFHEFPO + "Hyperlink_" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator GHJEGGKACIN()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator POFDDOFMLPP()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x001A56BC File Offset: 0x001A38BC
	private void GCLIPIADIPD()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1242f, 327f, 158f, 1847f), "L" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 347f) + "CratePull");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)3)
		{
			return;
		}
		GUI.Label(new Rect(1944f, 346f, (float)Screen.width, 0f), "gi_um_1" + this.PFKGPFHEFPO + "_Position" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A02 RID: 14850 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator PHDOGPKABEO()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x06003A03 RID: 14851 RVA: 0x001A5760 File Offset: 0x001A3960
	private void AHEAJPNHBBB()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(746f, 1369f, 1337f, 1067f), "invn_rec25" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 245f) + "Trying to initiate IKSolverVR with invalid bone references.");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.GameWork)
		{
			return;
		}
		GUI.Label(new Rect(860f, 1016f, (float)Screen.width, 1085f), "WalkBackward" + this.PFKGPFHEFPO + "Vertical" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A04 RID: 14852 RVA: 0x001A5804 File Offset: 0x001A3A04
	private void CHDJGEOFHEE()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.ACOEIDGDLJC() + "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
		base.StartCoroutine("subtype");
	}

	// Token: 0x06003A05 RID: 14853 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator IFCNDOOKICL()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x06003A06 RID: 14854 RVA: 0x001A583C File Offset: 0x001A3A3C
	private void JLMDLHCNGBE()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1926f, 501f, 613f, 223f), " " + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 822f) + "Data not loaded!");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)8)
		{
			return;
		}
		GUI.Label(new Rect(1300f, 1590f, (float)Screen.width, 632f), "UnityEngine.Vector3" + this.PFKGPFHEFPO + "<b>ObscuredVector3:</b> " + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A07 RID: 14855 RVA: 0x001A58E0 File Offset: 0x001A3AE0
	private void AGBEEDOOOHA()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(274f, 1431f, 1205f, 1119f), "uierror6.wav" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1786f) + "medium");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.LoadingError)
		{
			return;
		}
		GUI.Label(new Rect(1495f, 1847f, (float)Screen.width, 879f), "threshold" + this.PFKGPFHEFPO + "ScatterDitherData" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A08 RID: 14856 RVA: 0x001A5984 File Offset: 0x001A3B84
	private void DCHAPIHINBJ()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(105f, 899f, 1451f, 1686f), "_InvScreenSize" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 444f) + "");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)5)
		{
			return;
		}
		GUI.Label(new Rect(318f, 75f, (float)Screen.width, 530f), " " + this.PFKGPFHEFPO + "SatNightFever" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A09 RID: 14857 RVA: 0x001A5A28 File Offset: 0x001A3C28
	private void IIHNDJOIMAH()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.LIOPCJFCGAF() + "; ";
		base.StartCoroutine("_GrainTex");
	}

	// Token: 0x06003A0A RID: 14858 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator IBAIFJJENAE()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x06003A0B RID: 14859 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator MJNCDAEKMGI()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x06003A0C RID: 14860 RVA: 0x001A5A60 File Offset: 0x001A3C60
	private void NCFLINGBFJG()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(104f, 1403f, 700f, 503f), "ApplePick" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1214f) + "RigidPlayer");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)6)
		{
			return;
		}
		GUI.Label(new Rect(1468f, 338f, (float)Screen.width, 600f), "crft_btn1" + this.PFKGPFHEFPO + "_OcclusionTexture2" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A0D RID: 14861 RVA: 0x001A5B04 File Offset: 0x001A3D04
	private void CKGPEFOKKNL()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "_w";
		base.StartCoroutine("ArmFlex6");
	}

	// Token: 0x06003A0E RID: 14862 RVA: 0x001A5B3C File Offset: 0x001A3D3C
	private void PBHKFPELDGF()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(50f, 108f, 469f, 1638f), "https://groups.google.com/forum/#!forum/final-ik" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 665f) + "Katana 45Deg Swing");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)5)
		{
			return;
		}
		GUI.Label(new Rect(949f, 1037f, (float)Screen.width, 983f), "Titul" + this.PFKGPFHEFPO + "BipedReferences eye bone at index " + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A0F RID: 14863 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator DHJELGOBPIM()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x06003A10 RID: 14864 RVA: 0x001A436C File Offset: 0x001A256C
	private IEnumerator KBIICMBLJKA()
	{
		Debug.Log("Loading " + this.PFKGPFHEFPO);
		this.DHFNKDOCOFK = new WWW(this.PFKGPFHEFPO);
		yield return this.DHFNKDOCOFK;
		if (this.DHFNKDOCOFK.isDone)
		{
			if (this.DHFNKDOCOFK.assetBundle != null)
			{
				UnityEngine.Object mainAsset = this.DHFNKDOCOFK.assetBundle.mainAsset;
				if (mainAsset != null)
				{
					JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
					GameObject gameObject = UnityEngine.Object.Instantiate(mainAsset, default(Vector3), default(Quaternion)) as GameObject;
					if (gameObject != null)
					{
						gameObject.name = "BaseLogic";
					}
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
					yield return new WaitForSeconds(3f);
					this.DHFNKDOCOFK.assetBundle.Unload(false);
					this.DHFNKDOCOFK = null;
					GC.Collect();
					JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
				}
				else
				{
					Debug.Log("error: mainAsset is null");
					this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
				}
			}
			else
			{
				Debug.Log("error: assetBundle is null");
				this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			}
		}
		else
		{
			this.mode = LoadingSceneLogic.DFGOPKDJDCK.LoadingError;
			Debug.Log("Loading Error");
		}
		yield break;
	}

	// Token: 0x06003A11 RID: 14865 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator AIEEHLANGFI()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x06003A12 RID: 14866 RVA: 0x001A5BE0 File Offset: 0x001A3DE0
	private void EHFPLKEINFO()
	{
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.AFJFDKAGKLD() + "Vertical";
		base.StartCoroutine("release");
	}

	// Token: 0x06003A13 RID: 14867 RVA: 0x001A5C15 File Offset: 0x001A3E15
	private void FODDAMMNECI()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.AFJFDKAGKLD() + "PLANE_REFLECTION";
		base.StartCoroutine("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
	}

	// Token: 0x06003A14 RID: 14868 RVA: 0x001A3FBC File Offset: 0x001A21BC
	private IEnumerator LEMFIEMKNNE()
	{
		LoadingSceneLogic.HGJAHJEKDEJ hgjahjekdej = new LoadingSceneLogic.HGJAHJEKDEJ(1);
		hgjahjekdej.AENJLLPLILM = this;
		return hgjahjekdej;
	}

	// Token: 0x06003A15 RID: 14869 RVA: 0x001A5C4C File Offset: 0x001A3E4C
	private void NECHJAHFOFF()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(628f, 265f, 914f, 1870f), "Ошибка создания предмета" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 887f) + "full");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)6)
		{
			return;
		}
		GUI.Label(new Rect(548f, 254f, (float)Screen.width, 1348f), "[ACTk] Injection Detector: already running!" + this.PFKGPFHEFPO + "IdleWalk" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A16 RID: 14870 RVA: 0x001A5CF0 File Offset: 0x001A3EF0
	private void CKFIKGNJCKB()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(947f, 1534f, 524f, 4f), "componentB" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 543f) + "");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)3)
		{
			return;
		}
		GUI.Label(new Rect(1592f, 1628f, (float)Screen.width, 46f), "leskaProc" + this.PFKGPFHEFPO + " гр " + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A17 RID: 14871 RVA: 0x001A5D94 File Offset: 0x001A3F94
	private void KEIILPMCFEO()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.NEJIPLDOMMC() + "PaperTurn.wav";
		base.StartCoroutine("\n(");
	}

	// Token: 0x06003A18 RID: 14872 RVA: 0x001A5DCC File Offset: 0x001A3FCC
	private void JGAMNLOICJN()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1368f, 1721f, 1868f, 1155f), "goSpiralCenter" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 1755f) + "Flashlight");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			return;
		}
		GUI.Label(new Rect(615f, 975f, (float)Screen.width, 1431f), "</color>" + this.PFKGPFHEFPO + "{" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A19 RID: 14873 RVA: 0x001A5E70 File Offset: 0x001A4070
	private void MKNPFMEMOJO()
	{
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.AFJFDKAGKLD() + "IdleStand";
		base.StartCoroutine("#ffff40");
	}

	// Token: 0x06003A1A RID: 14874 RVA: 0x001A5EA5 File Offset: 0x001A40A5
	private void FFIGGPHAIBP()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.Loading;
		this.PFKGPFHEFPO = IFPIMPMKJIB.BKKFFINMJBO() + "H:mm:ss";
		base.StartCoroutine("SoccerKeeperStrafeLeft");
	}

	// Token: 0x06003A1B RID: 14875 RVA: 0x001A5EDA File Offset: 0x001A40DA
	private void IIKDDILLGLF()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.AFJFDKAGKLD() + " ";
		base.StartCoroutine("FOG_SCATTERING_ON");
	}

	// Token: 0x06003A1C RID: 14876 RVA: 0x001A5F10 File Offset: 0x001A4110
	private void HMPFJEPODEL()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(622f, 1728f, 1678f, 1646f), "RollerBladeCrossoverRight" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 964f) + "#000000");
			return;
		}
		if (dfgopkdjdck != LoadingSceneLogic.DFGOPKDJDCK.LoadingError)
		{
			return;
		}
		GUI.Label(new Rect(353f, 1193f, (float)Screen.width, 1082f), "BowFire" + this.PFKGPFHEFPO + "Play: `{0}` {1}" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A1D RID: 14877 RVA: 0x001A5FB4 File Offset: 0x001A41B4
	private void CKLEENCFBNM()
	{
		LoadingSceneLogic.DFGOPKDJDCK dfgopkdjdck = this.mode;
		if (dfgopkdjdck == LoadingSceneLogic.DFGOPKDJDCK.Loading)
		{
			GUI.Label(new Rect(1521f, 34f, 1077f, 615f), "gi_letgoshe" + Mathf.RoundToInt(this.DHFNKDOCOFK.progress * 953f) + "PaperTurn.wav");
			return;
		}
		if (dfgopkdjdck != (LoadingSceneLogic.DFGOPKDJDCK)6)
		{
			return;
		}
		GUI.Label(new Rect(939f, 28f, (float)Screen.width, 1515f), "fishLang.txt" + this.PFKGPFHEFPO + "" + this.DHFNKDOCOFK.error);
	}

	// Token: 0x06003A1E RID: 14878 RVA: 0x001A6058 File Offset: 0x001A4258
	private void IJOCHELLKJH()
	{
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
		this.mode = LoadingSceneLogic.DFGOPKDJDCK.GameWork;
		this.PFKGPFHEFPO = IFPIMPMKJIB.BKKFFINMJBO() + "The 'hyperlink' command requires an hyperlink id parameter.";
		base.StartCoroutine("fchair");
	}

	// Token: 0x04000828 RID: 2088
	public LoadingSceneLogic.DFGOPKDJDCK mode;

	// Token: 0x04000829 RID: 2089
	private WWW DHFNKDOCOFK;

	// Token: 0x0400082A RID: 2090
	private string PFKGPFHEFPO = IFPIMPMKJIB.DIDFMAELMJD + "Bases/Base_1.unity3d";

	// Token: 0x0200011C RID: 284
	public enum DFGOPKDJDCK
	{
		// Token: 0x0400082C RID: 2092
		Loading,
		// Token: 0x0400082D RID: 2093
		GameWork,
		// Token: 0x0400082E RID: 2094
		LoadingError
	}
}
