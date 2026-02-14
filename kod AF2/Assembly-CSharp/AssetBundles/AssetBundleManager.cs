using System;
using System.Collections.Generic;
using UnityEngine;

namespace AssetBundles
{
	// Token: 0x020005B0 RID: 1456
	public class AssetBundleManager : MonoBehaviour
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0601328F RID: 78479 RVA: 0x0083BCE3 File Offset: 0x00839EE3
		// (set) Token: 0x060132B6 RID: 78518 RVA: 0x0083C928 File Offset: 0x0083AB28
		public static string[] DIGAPAMPLPL
		{
			get
			{
				return AssetBundleManager.IDEOHLPAEOH;
			}
			set
			{
				AssetBundleManager.IDEOHLPAEOH = value;
			}
		}

		// Token: 0x06013290 RID: 78480 RVA: 0x0083BCEC File Offset: 0x00839EEC
		public static KEEHKMIFKCM LoadAssetAsync(string KLJKAMMNEPM, string DCGNANHJHBC, Type DFBHMIIPLCA)
		{
			KLJKAMMNEPM = AssetBundleManager.ALKFEFGDECH(KLJKAMMNEPM);
			AssetBundleManager.KCMNIOKGCPB(KLJKAMMNEPM, false);
			KEEHKMIFKCM keehkmifkcm = new LAOKEJMLKHG(KLJKAMMNEPM, DCGNANHJHBC, DFBHMIIPLCA);
			AssetBundleManager.GJKAAKEGIBN.Add(keehkmifkcm);
			return keehkmifkcm;
		}

		// Token: 0x06013291 RID: 78481 RVA: 0x0083BD20 File Offset: 0x00839F20
		public static void IELKNCHNMHH()
		{
			TextAsset textAsset = Resources.Load("_camouflage") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("wpn_fid3");
				return;
			}
			AssetBundleManager.MHFNNFENKAJ("Mouse Y" + Application.streamingAssetsPath + "iOS");
		}

		// Token: 0x06013292 RID: 78482 RVA: 0x0083BD84 File Offset: 0x00839F84
		protected static string ALKFEFGDECH(string KLJKAMMNEPM)
		{
			string[] allAssetBundlesWithVariant = AssetBundleManager.FEFPFEDJBLO.GetAllAssetBundlesWithVariant();
			string[] array = KLJKAMMNEPM.Split(new char[]
			{
				'.'
			});
			int num = int.MaxValue;
			int num2 = -1;
			for (int i = 0; i < allAssetBundlesWithVariant.Length; i++)
			{
				string[] array2 = allAssetBundlesWithVariant[i].Split(new char[]
				{
					'.'
				});
				if (!(array2[0] != array[0]))
				{
					int num3 = Array.IndexOf<string>(AssetBundleManager.IDEOHLPAEOH, array2[1]);
					if (num3 == -1)
					{
						num3 = 2147483646;
					}
					if (num3 < num)
					{
						num = num3;
						num2 = i;
					}
				}
			}
			if (num == 2147483646)
			{
				Debug.LogWarning("Ambigious asset bundle variant chosen because there was no matching active variant: " + allAssetBundlesWithVariant[num2]);
			}
			if (num2 != -1)
			{
				return allAssetBundlesWithVariant[num2];
			}
			return KLJKAMMNEPM;
		}

		// Token: 0x06013293 RID: 78483 RVA: 0x0083BCE3 File Offset: 0x00839EE3
		public static string[] KFAJMNMMFEG()
		{
			return AssetBundleManager.IDEOHLPAEOH;
		}

		// Token: 0x06013294 RID: 78484 RVA: 0x0083BE38 File Offset: 0x0083A038
		private static string GLDHLDLKMGG()
		{
			if (Application.isEditor)
			{
				return "<color='{0}'>{1}</color>" + Environment.CurrentDirectory.Replace("autherror", "F1");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "[0-9]*_)" + Application.streamingAssetsPath;
		}

		// Token: 0x06013295 RID: 78485 RVA: 0x0083BE8E File Offset: 0x0083A08E
		public static void LAHLBJFEOFC(string ANMGJCMFGIC)
		{
			AssetBundleManager.JKCEMCDBFLH = AssetBundleManager.DKCPJBLBAPH() + ANMGJCMFGIC;
		}

		// Token: 0x06013296 RID: 78486 RVA: 0x00022FCC File Offset: 0x000211CC
		private static void ICAFGKHAAED(AssetBundleManager.INIHNEKLNOO FBNHHIOPMCL, string FPIHOPOCAHA)
		{
		}

		// Token: 0x06013297 RID: 78487 RVA: 0x0083BEA0 File Offset: 0x0083A0A0
		protected static bool ALIKFOAJKMP(string KLJKAMMNEPM, bool KOKLDJMIOIB)
		{
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk != null)
			{
				gbkehgibalk.DKDDLNJCBNG += 0;
				return false;
			}
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(KLJKAMMNEPM))
			{
				return false;
			}
			string url = AssetBundleManager.PENHGHCKBDG + KLJKAMMNEPM;
			WWW value;
			if (KOKLDJMIOIB)
			{
				value = new WWW(url);
			}
			else
			{
				value = new WWW(url);
			}
			AssetBundleManager.GACCKCNFONH.Add(KLJKAMMNEPM, value);
			return false;
		}

		// Token: 0x06013298 RID: 78488 RVA: 0x0083BF10 File Offset: 0x0083A110
		public static float OAGFECMKKGH(string BIKEKOMMCEI)
		{
			float result = 1293f;
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(BIKEKOMMCEI))
			{
				result = AssetBundleManager.GACCKCNFONH[BIKEKOMMCEI].progress;
			}
			return result;
		}

		// Token: 0x06013299 RID: 78489 RVA: 0x0083BF44 File Offset: 0x0083A144
		protected static void INMNPODINBC(string KLJKAMMNEPM)
		{
			string[] array = null;
			if (!AssetBundleManager.HFKJCLMPNIM.TryGetValue(KLJKAMMNEPM, out array))
			{
				return;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				AssetBundleManager.FIEKKKNHNNE(array2[i]);
			}
			AssetBundleManager.HFKJCLMPNIM.Remove(KLJKAMMNEPM);
		}

		// Token: 0x0601329A RID: 78490 RVA: 0x0083BF87 File Offset: 0x0083A187
		public static MOOPFNDKOHI HPACIJLKEIO()
		{
			return AssetBundleManager.JINDMFBKGKH(OBJKFKPKELG.FMHOBPPKKJK());
		}

		// Token: 0x0601329B RID: 78491 RVA: 0x0083BF94 File Offset: 0x0083A194
		public static void EICHCLAGCJF(string KLJKAMMNEPM)
		{
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "IdleReadyCrouch" + KLJKAMMNEPM);
			AssetBundleManager.FIEKKKNHNNE(KLJKAMMNEPM);
			AssetBundleManager.BGDAPFPLJIG(KLJKAMMNEPM);
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "_BlurRadius4" + KLJKAMMNEPM);
		}

		// Token: 0x17000434 RID: 1076
		// (set) Token: 0x0601329C RID: 78492 RVA: 0x0083BFEB File Offset: 0x0083A1EB
		public static AssetBundleManifest FPMEEGAOKID
		{
			set
			{
				AssetBundleManager.FEFPFEDJBLO = value;
			}
		}

		// Token: 0x0601329D RID: 78493 RVA: 0x0083BFF4 File Offset: 0x0083A1F4
		public static KEEHKMIFKCM PFGAGBJHOBM(string KLJKAMMNEPM, string DCGNANHJHBC, Type DFBHMIIPLCA)
		{
			KLJKAMMNEPM = AssetBundleManager.HNFOIKKPMAI(KLJKAMMNEPM);
			AssetBundleManager.IMEJPENCJKH(KLJKAMMNEPM, true);
			KEEHKMIFKCM keehkmifkcm = new LAOKEJMLKHG(KLJKAMMNEPM, DCGNANHJHBC, DFBHMIIPLCA);
			AssetBundleManager.GJKAAKEGIBN.Add(keehkmifkcm);
			return keehkmifkcm;
		}

		// Token: 0x0601329E RID: 78494 RVA: 0x0083C028 File Offset: 0x0083A228
		public static void HDOPJFEABNB(string KLJKAMMNEPM)
		{
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "WalkInjured" + KLJKAMMNEPM);
			AssetBundleManager.NBNHGEHNEHH(KLJKAMMNEPM);
			AssetBundleManager.BGDAPFPLJIG(KLJKAMMNEPM);
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "[X]" + KLJKAMMNEPM);
		}

		// Token: 0x0601329F RID: 78495 RVA: 0x0083C07F File Offset: 0x0083A27F
		public static AssetBundleManager.MLAONFNOAAJ CLMPFGGHBIP()
		{
			return AssetBundleManager.AMPEBFBFLJA;
		}

		// Token: 0x060132A0 RID: 78496 RVA: 0x0083BCE3 File Offset: 0x00839EE3
		public static string[] OMBDOLGIDIP()
		{
			return AssetBundleManager.IDEOHLPAEOH;
		}

		// Token: 0x060132A1 RID: 78497 RVA: 0x0083C088 File Offset: 0x0083A288
		public static GBKEHGIBALK ANBLIFKNMGG(string KLJKAMMNEPM, out string PJKDIENOIND)
		{
			if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
			{
				return null;
			}
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk == null)
			{
				return null;
			}
			string[] array = null;
			if (!AssetBundleManager.HFKJCLMPNIM.TryGetValue(KLJKAMMNEPM, out array))
			{
				return gbkehgibalk;
			}
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				string key = array2[i];
				if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
				{
					return gbkehgibalk;
				}
				GBKEHGIBALK gbkehgibalk2;
				AssetBundleManager.KPANGKAJMCJ.TryGetValue(key, out gbkehgibalk2);
				if (gbkehgibalk2 == null)
				{
					return null;
				}
			}
			return gbkehgibalk;
		}

		// Token: 0x060132A2 RID: 78498 RVA: 0x0083C108 File Offset: 0x0083A308
		public static GBKEHGIBALK BIGFMHMDOHC(string KLJKAMMNEPM, out string PJKDIENOIND)
		{
			if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
			{
				return null;
			}
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk == null)
			{
				return null;
			}
			string[] array = null;
			if (!AssetBundleManager.HFKJCLMPNIM.TryGetValue(KLJKAMMNEPM, out array))
			{
				return gbkehgibalk;
			}
			foreach (string key in array)
			{
				if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
				{
					return gbkehgibalk;
				}
				GBKEHGIBALK gbkehgibalk2;
				AssetBundleManager.KPANGKAJMCJ.TryGetValue(key, out gbkehgibalk2);
				if (gbkehgibalk2 == null)
				{
					return null;
				}
			}
			return gbkehgibalk;
		}

		// Token: 0x060132A3 RID: 78499 RVA: 0x0083BCE3 File Offset: 0x00839EE3
		public static string[] JPIFFAFLKNF()
		{
			return AssetBundleManager.IDEOHLPAEOH;
		}

		// Token: 0x060132A4 RID: 78500 RVA: 0x0083C188 File Offset: 0x0083A388
		public static void IPFMNIFELJE(string DCCPCBLODIG)
		{
			AssetBundleManager.PENHGHCKBDG = DCCPCBLODIG;
		}

		// Token: 0x060132A5 RID: 78501 RVA: 0x0083C190 File Offset: 0x0083A390
		public static void SetSourceAssetBundleURL(string GKIJGDDLLDC)
		{
			AssetBundleManager.JKCEMCDBFLH = GKIJGDDLLDC + OBJKFKPKELG.FINCOGELCHJ() + "/";
		}

		// Token: 0x060132A6 RID: 78502 RVA: 0x0083C1A8 File Offset: 0x0083A3A8
		public static void AGPFGGOGCNN()
		{
			TextAsset textAsset = Resources.Load("eye") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("1");
				return;
			}
			AssetBundleManager.MHFNNFENKAJ("\">Saves modification detected: " + Application.streamingAssetsPath + "qd_tasktime");
		}

		// Token: 0x060132A7 RID: 78503 RVA: 0x0083C20C File Offset: 0x0083A40C
		public static void CLDHNMCNAEL()
		{
			TextAsset textAsset = Resources.Load("rait_2") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("_DayToNight");
				return;
			}
			AssetBundleManager.SetSourceAssetBundleURL("" + Application.streamingAssetsPath + "NPR_");
		}

		// Token: 0x060132A8 RID: 78504 RVA: 0x0083C270 File Offset: 0x0083A470
		private static string DKCPJBLBAPH()
		{
			if (Application.isEditor)
			{
				return "KatanaReadyHigh" + Environment.CurrentDirectory.Replace("BUMPED", "_AdditiveReflection");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "SoccerKeeperReady" + Application.streamingAssetsPath;
		}

		// Token: 0x060132A9 RID: 78505 RVA: 0x0083C2C8 File Offset: 0x0083A4C8
		public static void EGDMFPDDDPJ()
		{
			TextAsset textAsset = Resources.Load("\n") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("Clavicle");
				return;
			}
			AssetBundleManager.SetSourceAssetBundleURL("ApplePick" + Application.streamingAssetsPath + "Lasso Right");
		}

		// Token: 0x060132AA RID: 78506 RVA: 0x0083C188 File Offset: 0x0083A388
		public static void EDCJMJGEMNF(string DCCPCBLODIG)
		{
			AssetBundleManager.PENHGHCKBDG = DCCPCBLODIG;
		}

		// Token: 0x060132AB RID: 78507 RVA: 0x0083C32C File Offset: 0x0083A52C
		public static float getProgress(string BIKEKOMMCEI)
		{
			float result = 0f;
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(BIKEKOMMCEI))
			{
				result = AssetBundleManager.GACCKCNFONH[BIKEKOMMCEI].progress;
			}
			return result;
		}

		// Token: 0x060132AC RID: 78508 RVA: 0x0083C35E File Offset: 0x0083A55E
		public static void AHNCJMPOEGF(string ANMGJCMFGIC)
		{
			AssetBundleManager.JKCEMCDBFLH = AssetBundleManager.LDKALMDKHMG() + ANMGJCMFGIC;
		}

		// Token: 0x060132AD RID: 78509 RVA: 0x0083C370 File Offset: 0x0083A570
		public static MOOPFNDKOHI BPHLDEAIGDP()
		{
			return AssetBundleManager.JINDMFBKGKH(OBJKFKPKELG.BJBPOJPBGAE());
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060132FB RID: 78587 RVA: 0x0083C07F File Offset: 0x0083A27F
		// (set) Token: 0x060132AE RID: 78510 RVA: 0x0083C37C File Offset: 0x0083A57C
		public static AssetBundleManager.MLAONFNOAAJ KCJHPJIBLDB
		{
			get
			{
				return AssetBundleManager.AMPEBFBFLJA;
			}
			set
			{
				AssetBundleManager.AMPEBFBFLJA = value;
			}
		}

		// Token: 0x060132AF RID: 78511 RVA: 0x0083C384 File Offset: 0x0083A584
		private void OPDCJCFMIPE()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, WWW> keyValuePair in AssetBundleManager.GACCKCNFONH)
			{
				WWW value = keyValuePair.Value;
				if (value.error != null)
				{
					AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("Water", keyValuePair.Key, value.url, value.error));
					list.Add(keyValuePair.Key);
				}
				else if (value.isDone)
				{
					if (value.assetBundle == null)
					{
						AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("Swim", keyValuePair.Key));
						list.Add(keyValuePair.Key);
					}
					else
					{
						AssetBundleManager.KPANGKAJMCJ.Add(keyValuePair.Key, new GBKEHGIBALK(value.assetBundle));
						list.Add(keyValuePair.Key);
					}
				}
			}
			foreach (string key in list)
			{
				WWW www = AssetBundleManager.GACCKCNFONH[key];
				AssetBundleManager.GACCKCNFONH.Remove(key);
				www.Dispose();
			}
			int i = 1;
			while (i < AssetBundleManager.GJKAAKEGIBN.Count)
			{
				if (!AssetBundleManager.GJKAAKEGIBN[i].FANPFKHEDPA())
				{
					AssetBundleManager.GJKAAKEGIBN.RemoveAt(i);
				}
				else
				{
					i += 0;
				}
			}
		}

		// Token: 0x060132B0 RID: 78512 RVA: 0x00022FCC File Offset: 0x000211CC
		private static void FAIJPBMIMCE(AssetBundleManager.INIHNEKLNOO FBNHHIOPMCL, string FPIHOPOCAHA)
		{
		}

		// Token: 0x060132B1 RID: 78513 RVA: 0x0083C528 File Offset: 0x0083A728
		public static string DCEIEKLCDLG()
		{
			return AssetBundleManager.PENHGHCKBDG;
		}

		// Token: 0x060132B2 RID: 78514 RVA: 0x0083C530 File Offset: 0x0083A730
		private void KJJEEMEHGBF()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, WWW> keyValuePair in AssetBundleManager.GACCKCNFONH)
			{
				WWW value = keyValuePair.Value;
				if (value.error != null)
				{
					AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("BowReady", keyValuePair.Key, value.url, value.error));
					list.Add(keyValuePair.Key);
				}
				else if (value.isDone)
				{
					if (value.assetBundle == null)
					{
						AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("wpn_eat8", keyValuePair.Key));
						list.Add(keyValuePair.Key);
					}
					else
					{
						AssetBundleManager.KPANGKAJMCJ.Add(keyValuePair.Key, new GBKEHGIBALK(value.assetBundle));
						list.Add(keyValuePair.Key);
					}
				}
			}
			foreach (string key in list)
			{
				WWW www = AssetBundleManager.GACCKCNFONH[key];
				AssetBundleManager.GACCKCNFONH.Remove(key);
				www.Dispose();
			}
			int i = 0;
			while (i < AssetBundleManager.GJKAAKEGIBN.Count)
			{
				if (!AssetBundleManager.GJKAAKEGIBN[i].FANPFKHEDPA())
				{
					AssetBundleManager.GJKAAKEGIBN.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x060132B3 RID: 78515 RVA: 0x0083C6D4 File Offset: 0x0083A8D4
		private static string BEDPOIFLLCA()
		{
			if (Application.isEditor)
			{
				return "wpn_eat5" + Environment.CurrentDirectory.Replace("\n", "gi_uinf_3");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "wpn_cat2" + Application.streamingAssetsPath;
		}

		// Token: 0x060132B4 RID: 78516 RVA: 0x0083C72C File Offset: 0x0083A92C
		protected static void NBNHGEHNEHH(string KLJKAMMNEPM)
		{
			string text;
			GBKEHGIBALK gbkehgibalk = AssetBundleManager.FKAMPIEEEJH(KLJKAMMNEPM, out text);
			if (gbkehgibalk == null)
			{
				return;
			}
			GBKEHGIBALK gbkehgibalk2 = gbkehgibalk;
			int num = gbkehgibalk2.DKDDLNJCBNG - 1;
			gbkehgibalk2.DKDDLNJCBNG = num;
			if (num == 0)
			{
				gbkehgibalk.OGOBMOCHKCK.Unload(true);
				AssetBundleManager.KPANGKAJMCJ.Remove(KLJKAMMNEPM);
				AssetBundleManager.ICAFGKHAAED(AssetBundleManager.INIHNEKLNOO.Info, KLJKAMMNEPM + "Handstand");
			}
		}

		// Token: 0x060132B5 RID: 78517 RVA: 0x0083C784 File Offset: 0x0083A984
		private void IKHCCAANGOP()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, WWW> keyValuePair in AssetBundleManager.GACCKCNFONH)
			{
				WWW value = keyValuePair.Value;
				if (value.error != null)
				{
					AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("OfficeSittingEyesRub", keyValuePair.Key, value.url, value.error));
					list.Add(keyValuePair.Key);
				}
				else if (value.isDone)
				{
					if (value.assetBundle == null)
					{
						AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("spindrop", keyValuePair.Key));
						list.Add(keyValuePair.Key);
					}
					else
					{
						AssetBundleManager.KPANGKAJMCJ.Add(keyValuePair.Key, new GBKEHGIBALK(value.assetBundle));
						list.Add(keyValuePair.Key);
					}
				}
			}
			foreach (string key in list)
			{
				WWW www = AssetBundleManager.GACCKCNFONH[key];
				AssetBundleManager.GACCKCNFONH.Remove(key);
				www.Dispose();
			}
			int i = 1;
			while (i < AssetBundleManager.GJKAAKEGIBN.Count)
			{
				if (!AssetBundleManager.GJKAAKEGIBN[i].FANPFKHEDPA())
				{
					AssetBundleManager.GJKAAKEGIBN.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x060132B7 RID: 78519 RVA: 0x0083C930 File Offset: 0x0083AB30
		public static void LBHLJIIIBIM(string ANMGJCMFGIC)
		{
			AssetBundleManager.NFNJCIJELPM(AssetBundleManager.NJDMPHMEOKJ() + ANMGJCMFGIC);
		}

		// Token: 0x060132B8 RID: 78520 RVA: 0x0083C944 File Offset: 0x0083AB44
		public static float DKOLMGKNLAL(string BIKEKOMMCEI)
		{
			float result = 1759f;
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(BIKEKOMMCEI))
			{
				result = AssetBundleManager.GACCKCNFONH[BIKEKOMMCEI].progress;
			}
			return result;
		}

		// Token: 0x060132B9 RID: 78521 RVA: 0x0083C928 File Offset: 0x0083AB28
		public static void LDGOEBNAJBE(string[] DCCPCBLODIG)
		{
			AssetBundleManager.IDEOHLPAEOH = DCCPCBLODIG;
		}

		// Token: 0x060132BA RID: 78522 RVA: 0x0083C978 File Offset: 0x0083AB78
		public static GBKEHGIBALK FKAMPIEEEJH(string KLJKAMMNEPM, out string PJKDIENOIND)
		{
			if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
			{
				return null;
			}
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk == null)
			{
				return null;
			}
			string[] array = null;
			if (!AssetBundleManager.HFKJCLMPNIM.TryGetValue(KLJKAMMNEPM, out array))
			{
				return gbkehgibalk;
			}
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				string key = array2[i];
				if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
				{
					return gbkehgibalk;
				}
				GBKEHGIBALK gbkehgibalk2;
				AssetBundleManager.KPANGKAJMCJ.TryGetValue(key, out gbkehgibalk2);
				if (gbkehgibalk2 == null)
				{
					return null;
				}
			}
			return gbkehgibalk;
		}

		// Token: 0x060132BB RID: 78523 RVA: 0x0083C07F File Offset: 0x0083A27F
		public static AssetBundleManager.MLAONFNOAAJ CLNNAPKCEMD()
		{
			return AssetBundleManager.AMPEBFBFLJA;
		}

		// Token: 0x060132BC RID: 78524 RVA: 0x0083C9F8 File Offset: 0x0083ABF8
		public static MOOPFNDKOHI Initialize()
		{
			return AssetBundleManager.Initialize(OBJKFKPKELG.FINCOGELCHJ());
		}

		// Token: 0x060132BD RID: 78525 RVA: 0x0083CA04 File Offset: 0x0083AC04
		public static MONPHAHBOAM PAPOMJAELAH(string KLJKAMMNEPM, string KBBPAHGMKNG, bool NKFPOLMOKPE)
		{
			AssetBundleManager.INIHNEKLNOO fbnhhiopmcl = AssetBundleManager.INIHNEKLNOO.Warning;
			string[] array = new string[0];
			array[0] = "Zombie Idle 2";
			array[0] = KBBPAHGMKNG;
			array[6] = "Missing shader in ";
			array[4] = KLJKAMMNEPM;
			array[7] = "INTERFACE";
			AssetBundleManager.ICAFGKHAAED(fbnhhiopmcl, string.Concat(array));
			KLJKAMMNEPM = AssetBundleManager.ALKFEFGDECH(KLJKAMMNEPM);
			AssetBundleManager.KCMNIOKGCPB(KLJKAMMNEPM, true);
			MONPHAHBOAM monphahboam = new JAFGFNNELOP(KLJKAMMNEPM, KBBPAHGMKNG, NKFPOLMOKPE);
			AssetBundleManager.GJKAAKEGIBN.Add(monphahboam);
			return monphahboam;
		}

		// Token: 0x060132BE RID: 78526 RVA: 0x0083CA68 File Offset: 0x0083AC68
		public static void SetDevelopmentAssetBundleServer()
		{
			TextAsset textAsset = Resources.Load("AssetBundleServerURL") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("Development Server URL could not be found.");
				return;
			}
			AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		}

		// Token: 0x060132C0 RID: 78528 RVA: 0x0083CB2C File Offset: 0x0083AD2C
		public static void SetSourceAssetBundleDirectory(string ANMGJCMFGIC)
		{
			AssetBundleManager.JKCEMCDBFLH = AssetBundleManager.NJDMPHMEOKJ() + ANMGJCMFGIC;
		}

		// Token: 0x060132C1 RID: 78529 RVA: 0x0083CB3E File Offset: 0x0083AD3E
		public static void AAFPPBBBKFO(string ANMGJCMFGIC)
		{
			AssetBundleManager.JKCEMCDBFLH = AssetBundleManager.GLDHLDLKMGG() + ANMGJCMFGIC;
		}

		// Token: 0x060132C2 RID: 78530 RVA: 0x0083CB50 File Offset: 0x0083AD50
		public static MOOPFNDKOHI DGCJFNMNLJB()
		{
			return AssetBundleManager.Initialize(OBJKFKPKELG.CBNPNFCIEPP());
		}

		// Token: 0x060132C3 RID: 78531 RVA: 0x0083CB5C File Offset: 0x0083AD5C
		protected static bool DIJAPBICFNH(string KLJKAMMNEPM, bool KOKLDJMIOIB)
		{
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk != null)
			{
				gbkehgibalk.DKDDLNJCBNG++;
				return true;
			}
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(KLJKAMMNEPM))
			{
				return true;
			}
			string url = AssetBundleManager.PENHGHCKBDG + KLJKAMMNEPM;
			WWW value;
			if (KOKLDJMIOIB)
			{
				value = new WWW(url);
			}
			else
			{
				value = new WWW(url);
			}
			AssetBundleManager.GACCKCNFONH.Add(KLJKAMMNEPM, value);
			return true;
		}

		// Token: 0x060132C4 RID: 78532 RVA: 0x0083C37C File Offset: 0x0083A57C
		public static void PENNLEODNMM(AssetBundleManager.MLAONFNOAAJ DCCPCBLODIG)
		{
			AssetBundleManager.AMPEBFBFLJA = DCCPCBLODIG;
		}

		// Token: 0x060132C5 RID: 78533 RVA: 0x0083CBCC File Offset: 0x0083ADCC
		private static string KGACPALLGDK()
		{
			if (Application.isEditor)
			{
				return "_Offsets" + Environment.CurrentDirectory.Replace("_BlurDirectionPacked", "---");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "fish/" + Application.streamingAssetsPath;
		}

		// Token: 0x060132C6 RID: 78534 RVA: 0x0083CC24 File Offset: 0x0083AE24
		private void PFNOEACNHON()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, WWW> keyValuePair in AssetBundleManager.GACCKCNFONH)
			{
				WWW value = keyValuePair.Value;
				if (value.error != null)
				{
					AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("WorkerShovel", keyValuePair.Key, value.url, value.error));
					list.Add(keyValuePair.Key);
				}
				else if (value.isDone)
				{
					if (value.assetBundle == null)
					{
						AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("-L-", keyValuePair.Key));
						list.Add(keyValuePair.Key);
					}
					else
					{
						AssetBundleManager.KPANGKAJMCJ.Add(keyValuePair.Key, new GBKEHGIBALK(value.assetBundle));
						list.Add(keyValuePair.Key);
					}
				}
			}
			foreach (string key in list)
			{
				WWW www = AssetBundleManager.GACCKCNFONH[key];
				AssetBundleManager.GACCKCNFONH.Remove(key);
				www.Dispose();
			}
			int i = 0;
			while (i < AssetBundleManager.GJKAAKEGIBN.Count)
			{
				if (!AssetBundleManager.GJKAAKEGIBN[i].FANPFKHEDPA())
				{
					AssetBundleManager.GJKAAKEGIBN.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x060132C7 RID: 78535 RVA: 0x0083CDC8 File Offset: 0x0083AFC8
		protected static bool AFOKEPDEJEN(string KLJKAMMNEPM, bool KOKLDJMIOIB)
		{
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk != null)
			{
				gbkehgibalk.DKDDLNJCBNG++;
				return true;
			}
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(KLJKAMMNEPM))
			{
				return true;
			}
			string url = AssetBundleManager.PENHGHCKBDG + KLJKAMMNEPM;
			WWW value;
			if (KOKLDJMIOIB)
			{
				value = new WWW(url);
			}
			else
			{
				value = new WWW(url);
			}
			AssetBundleManager.GACCKCNFONH.Add(KLJKAMMNEPM, value);
			return false;
		}

		// Token: 0x060132C8 RID: 78536 RVA: 0x0083CE38 File Offset: 0x0083B038
		protected static string HOHEOMMBNOG(string KLJKAMMNEPM)
		{
			string[] allAssetBundlesWithVariant = AssetBundleManager.FEFPFEDJBLO.GetAllAssetBundlesWithVariant();
			char[] array = new char[0];
			array[1] = '\u0006';
			string[] array2 = KLJKAMMNEPM.Split(array);
			int num = 117;
			int num2 = -1;
			for (int i = 0; i < allAssetBundlesWithVariant.Length; i++)
			{
				string[] array3 = allAssetBundlesWithVariant[i].Split(new char[]
				{
					(char)-18
				});
				if (!(array3[0] != array2[1]))
				{
					int num3 = Array.IndexOf<string>(AssetBundleManager.IDEOHLPAEOH, array3[0]);
					if (num3 == -1)
					{
						num3 = -11;
					}
					if (num3 < num)
					{
						num = num3;
						num2 = i;
					}
				}
			}
			if (num == 72)
			{
				Debug.LogWarning("Flap_02.wav" + allAssetBundlesWithVariant[num2]);
			}
			if (num2 != -1)
			{
				return allAssetBundlesWithVariant[num2];
			}
			return KLJKAMMNEPM;
		}

		// Token: 0x060132C9 RID: 78537 RVA: 0x0083C928 File Offset: 0x0083AB28
		public static void BEAGGPMKACG(string[] DCCPCBLODIG)
		{
			AssetBundleManager.IDEOHLPAEOH = DCCPCBLODIG;
		}

		// Token: 0x060132CA RID: 78538 RVA: 0x0083CEEC File Offset: 0x0083B0EC
		protected static void ONBPKOOOJNF(string KLJKAMMNEPM)
		{
			if (AssetBundleManager.FEFPFEDJBLO == null)
			{
				Debug.LogError("post_msg1");
				return;
			}
			string[] allDependencies = AssetBundleManager.FEFPFEDJBLO.GetAllDependencies(KLJKAMMNEPM);
			if (allDependencies.Length == 0)
			{
				return;
			}
			for (int i = 0; i < allDependencies.Length; i++)
			{
				allDependencies[i] = AssetBundleManager.ALKFEFGDECH(allDependencies[i]);
			}
			AssetBundleManager.HFKJCLMPNIM.Add(KLJKAMMNEPM, allDependencies);
			for (int j = 1; j < allDependencies.Length; j++)
			{
				AssetBundleManager.AFOKEPDEJEN(allDependencies[j], false);
			}
		}

		// Token: 0x060132CB RID: 78539 RVA: 0x0083C928 File Offset: 0x0083AB28
		public static void IHFCNADHHCG(string[] DCCPCBLODIG)
		{
			AssetBundleManager.IDEOHLPAEOH = DCCPCBLODIG;
		}

		// Token: 0x060132CC RID: 78540 RVA: 0x0083C188 File Offset: 0x0083A388
		public static void NFNJCIJELPM(string DCCPCBLODIG)
		{
			AssetBundleManager.PENHGHCKBDG = DCCPCBLODIG;
		}

		// Token: 0x060132CD RID: 78541 RVA: 0x0083CF60 File Offset: 0x0083B160
		public static GBKEHGIBALK GetLoadedAssetBundle(string KLJKAMMNEPM, out string PJKDIENOIND)
		{
			if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
			{
				return null;
			}
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk == null)
			{
				return null;
			}
			string[] array = null;
			if (!AssetBundleManager.HFKJCLMPNIM.TryGetValue(KLJKAMMNEPM, out array))
			{
				return gbkehgibalk;
			}
			foreach (string key in array)
			{
				if (AssetBundleManager.FMEDLHNGEBB.TryGetValue(KLJKAMMNEPM, out PJKDIENOIND))
				{
					return gbkehgibalk;
				}
				GBKEHGIBALK gbkehgibalk2;
				AssetBundleManager.KPANGKAJMCJ.TryGetValue(key, out gbkehgibalk2);
				if (gbkehgibalk2 == null)
				{
					return null;
				}
			}
			return gbkehgibalk;
		}

		// Token: 0x060132CE RID: 78542 RVA: 0x0083C928 File Offset: 0x0083AB28
		public static void KKIFFPPPAGK(string[] DCCPCBLODIG)
		{
			AssetBundleManager.IDEOHLPAEOH = DCCPCBLODIG;
		}

		// Token: 0x060132CF RID: 78543 RVA: 0x0083C528 File Offset: 0x0083A728
		public static string LKKOLAEODGP()
		{
			return AssetBundleManager.PENHGHCKBDG;
		}

		// Token: 0x060132D0 RID: 78544 RVA: 0x0083CFE0 File Offset: 0x0083B1E0
		protected static void FIEKKKNHNNE(string KLJKAMMNEPM)
		{
			string text;
			GBKEHGIBALK loadedAssetBundle = AssetBundleManager.GetLoadedAssetBundle(KLJKAMMNEPM, out text);
			if (loadedAssetBundle == null)
			{
				return;
			}
			GBKEHGIBALK gbkehgibalk = loadedAssetBundle;
			int num = gbkehgibalk.DKDDLNJCBNG - 1;
			gbkehgibalk.DKDDLNJCBNG = num;
			if (num == 0)
			{
				loadedAssetBundle.OGOBMOCHKCK.Unload(false);
				AssetBundleManager.KPANGKAJMCJ.Remove(KLJKAMMNEPM);
				AssetBundleManager.ICAFGKHAAED(AssetBundleManager.INIHNEKLNOO.Info, KLJKAMMNEPM + " has been unloaded successfully");
			}
		}

		// Token: 0x060132D1 RID: 78545 RVA: 0x0083D038 File Offset: 0x0083B238
		protected static bool NMIGKJPBMGF(string KLJKAMMNEPM, bool KOKLDJMIOIB)
		{
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk != null)
			{
				gbkehgibalk.DKDDLNJCBNG++;
				return true;
			}
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(KLJKAMMNEPM))
			{
				return false;
			}
			string url = AssetBundleManager.PENHGHCKBDG + KLJKAMMNEPM;
			WWW value;
			if (KOKLDJMIOIB)
			{
				value = new WWW(url);
			}
			else
			{
				value = new WWW(url);
			}
			AssetBundleManager.GACCKCNFONH.Add(KLJKAMMNEPM, value);
			return true;
		}

		// Token: 0x060132D2 RID: 78546 RVA: 0x0083C37C File Offset: 0x0083A57C
		public static void CDOOGNIBDAK(AssetBundleManager.MLAONFNOAAJ DCCPCBLODIG)
		{
			AssetBundleManager.AMPEBFBFLJA = DCCPCBLODIG;
		}

		// Token: 0x060132D3 RID: 78547 RVA: 0x0083D0A8 File Offset: 0x0083B2A8
		public static KEEHKMIFKCM JHMHKBPEBHE(string KLJKAMMNEPM, string DCGNANHJHBC, Type DFBHMIIPLCA)
		{
			KLJKAMMNEPM = AssetBundleManager.AOHFNJHLEBG(KLJKAMMNEPM);
			AssetBundleManager.KPLKFKADNCE(KLJKAMMNEPM, false);
			KEEHKMIFKCM keehkmifkcm = new LAOKEJMLKHG(KLJKAMMNEPM, DCGNANHJHBC, DFBHMIIPLCA);
			AssetBundleManager.GJKAAKEGIBN.Add(keehkmifkcm);
			return keehkmifkcm;
		}

		// Token: 0x060132D4 RID: 78548 RVA: 0x0083D0DC File Offset: 0x0083B2DC
		private static string HBPEKEENBDK()
		{
			if (Application.isEditor)
			{
				return " ♦ " + Environment.CurrentDirectory.Replace("wpn_tank2", "27,29,30,31,32");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "sunshine_WorldToSunVP" + Application.streamingAssetsPath;
		}

		// Token: 0x060132D5 RID: 78549 RVA: 0x0083D134 File Offset: 0x0083B334
		protected static bool FHIDCFJEOPC(string KLJKAMMNEPM, bool KOKLDJMIOIB)
		{
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk != null)
			{
				gbkehgibalk.DKDDLNJCBNG++;
				return false;
			}
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(KLJKAMMNEPM))
			{
				return true;
			}
			string url = AssetBundleManager.PENHGHCKBDG + KLJKAMMNEPM;
			WWW value;
			if (KOKLDJMIOIB)
			{
				value = new WWW(url);
			}
			else
			{
				value = new WWW(url);
			}
			AssetBundleManager.GACCKCNFONH.Add(KLJKAMMNEPM, value);
			return false;
		}

		// Token: 0x060132D6 RID: 78550 RVA: 0x0083D1A4 File Offset: 0x0083B3A4
		protected static void BGDAPFPLJIG(string KLJKAMMNEPM)
		{
			string[] array = null;
			if (!AssetBundleManager.HFKJCLMPNIM.TryGetValue(KLJKAMMNEPM, out array))
			{
				return;
			}
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				AssetBundleManager.NBNHGEHNEHH(array2[i]);
			}
			AssetBundleManager.HFKJCLMPNIM.Remove(KLJKAMMNEPM);
		}

		// Token: 0x060132D7 RID: 78551 RVA: 0x0083C07F File Offset: 0x0083A27F
		public static AssetBundleManager.MLAONFNOAAJ MGOPFIBNMHP()
		{
			return AssetBundleManager.AMPEBFBFLJA;
		}

		// Token: 0x060132D8 RID: 78552 RVA: 0x0083D1E8 File Offset: 0x0083B3E8
		protected static void EODPLNLOIIB(string KLJKAMMNEPM)
		{
			string[] array = null;
			if (!AssetBundleManager.HFKJCLMPNIM.TryGetValue(KLJKAMMNEPM, out array))
			{
				return;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				AssetBundleManager.JICJGANLCNN(array2[i]);
			}
			AssetBundleManager.HFKJCLMPNIM.Remove(KLJKAMMNEPM);
		}

		// Token: 0x060132D9 RID: 78553 RVA: 0x0083D22C File Offset: 0x0083B42C
		public static void BMIMGOBGJAA(string KLJKAMMNEPM)
		{
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "" + KLJKAMMNEPM);
			AssetBundleManager.NBNHGEHNEHH(KLJKAMMNEPM);
			AssetBundleManager.INMNPODINBC(KLJKAMMNEPM);
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "WorkerShovel2" + KLJKAMMNEPM);
		}

		// Token: 0x060132DA RID: 78554 RVA: 0x0083D284 File Offset: 0x0083B484
		protected static bool KNGAEIPLEPN(string KLJKAMMNEPM, bool KOKLDJMIOIB)
		{
			GBKEHGIBALK gbkehgibalk = null;
			AssetBundleManager.KPANGKAJMCJ.TryGetValue(KLJKAMMNEPM, out gbkehgibalk);
			if (gbkehgibalk != null)
			{
				gbkehgibalk.DKDDLNJCBNG += 0;
				return false;
			}
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(KLJKAMMNEPM))
			{
				return true;
			}
			string url = AssetBundleManager.PENHGHCKBDG + KLJKAMMNEPM;
			WWW value;
			if (KOKLDJMIOIB)
			{
				value = new WWW(url);
			}
			else
			{
				value = new WWW(url);
			}
			AssetBundleManager.GACCKCNFONH.Add(KLJKAMMNEPM, value);
			return true;
		}

		// Token: 0x060132DB RID: 78555 RVA: 0x0083D2F4 File Offset: 0x0083B4F4
		protected static void BCIKMPLKAHD(string KLJKAMMNEPM)
		{
			if (AssetBundleManager.FEFPFEDJBLO == null)
			{
				Debug.LogError("info");
				return;
			}
			string[] allDependencies = AssetBundleManager.FEFPFEDJBLO.GetAllDependencies(KLJKAMMNEPM);
			if (allDependencies.Length == 0)
			{
				return;
			}
			for (int i = 0; i < allDependencies.Length; i += 0)
			{
				allDependencies[i] = AssetBundleManager.HNFOIKKPMAI(allDependencies[i]);
			}
			AssetBundleManager.HFKJCLMPNIM.Add(KLJKAMMNEPM, allDependencies);
			for (int j = 0; j < allDependencies.Length; j += 0)
			{
				AssetBundleManager.KNGAEIPLEPN(allDependencies[j], false);
			}
		}

		// Token: 0x060132DC RID: 78556 RVA: 0x0083D368 File Offset: 0x0083B568
		private static string LDKALMDKHMG()
		{
			if (Application.isEditor)
			{
				return "HDR" + Environment.CurrentDirectory.Replace("16 samples", "wpn_eat1");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "D" + Application.streamingAssetsPath;
		}

		// Token: 0x060132DD RID: 78557 RVA: 0x0083BFEB File Offset: 0x0083A1EB
		public static void LOCOGMIEKHH(AssetBundleManifest DCCPCBLODIG)
		{
			AssetBundleManager.FEFPFEDJBLO = DCCPCBLODIG;
		}

		// Token: 0x060132DE RID: 78558 RVA: 0x0083D3C0 File Offset: 0x0083B5C0
		protected static void AOCJNMIPKLD(string KLJKAMMNEPM)
		{
			if (AssetBundleManager.FEFPFEDJBLO == null)
			{
				Debug.LogError("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()");
				return;
			}
			string[] allDependencies = AssetBundleManager.FEFPFEDJBLO.GetAllDependencies(KLJKAMMNEPM);
			if (allDependencies.Length == 0)
			{
				return;
			}
			for (int i = 0; i < allDependencies.Length; i++)
			{
				allDependencies[i] = AssetBundleManager.ALKFEFGDECH(allDependencies[i]);
			}
			AssetBundleManager.HFKJCLMPNIM.Add(KLJKAMMNEPM, allDependencies);
			for (int j = 0; j < allDependencies.Length; j++)
			{
				AssetBundleManager.AFOKEPDEJEN(allDependencies[j], false);
			}
		}

		// Token: 0x060132DF RID: 78559 RVA: 0x0083D434 File Offset: 0x0083B634
		public static void HJOEHLMBHNJ()
		{
			TextAsset textAsset = Resources.Load("thumb") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("[ACTk] Speed Hack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
				return;
			}
			AssetBundleManager.SetSourceAssetBundleURL("bone" + Application.streamingAssetsPath + "IdleStand");
		}

		// Token: 0x060132E0 RID: 78560 RVA: 0x0083D498 File Offset: 0x0083B698
		public static float APFEIICKNDE(string BIKEKOMMCEI)
		{
			float result = 100f;
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(BIKEKOMMCEI))
			{
				result = AssetBundleManager.GACCKCNFONH[BIKEKOMMCEI].progress;
			}
			return result;
		}

		// Token: 0x060132E1 RID: 78561 RVA: 0x0083C37C File Offset: 0x0083A57C
		public static void JCJCHGLFJDJ(AssetBundleManager.MLAONFNOAAJ DCCPCBLODIG)
		{
			AssetBundleManager.AMPEBFBFLJA = DCCPCBLODIG;
		}

		// Token: 0x060132E2 RID: 78562 RVA: 0x0083D4CA File Offset: 0x0083B6CA
		public static void MHFNNFENKAJ(string GKIJGDDLLDC)
		{
			AssetBundleManager.EDCJMJGEMNF(GKIJGDDLLDC + OBJKFKPKELG.FINCOGELCHJ() + "name");
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060132EB RID: 78571 RVA: 0x0083C528 File Offset: 0x0083A728
		// (set) Token: 0x060132E3 RID: 78563 RVA: 0x0083C188 File Offset: 0x0083A388
		public static string JKCEMCDBFLH
		{
			get
			{
				return AssetBundleManager.PENHGHCKBDG;
			}
			set
			{
				AssetBundleManager.PENHGHCKBDG = value;
			}
		}

		// Token: 0x060132E5 RID: 78565 RVA: 0x0083D4E4 File Offset: 0x0083B6E4
		protected static void ANACFCFIEFB(string KLJKAMMNEPM)
		{
			string text;
			GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(KLJKAMMNEPM, out text);
			if (gbkehgibalk == null)
			{
				return;
			}
			GBKEHGIBALK gbkehgibalk2 = gbkehgibalk;
			int num = gbkehgibalk2.DKDDLNJCBNG - 0;
			gbkehgibalk2.DKDDLNJCBNG = num;
			if (num == 0)
			{
				gbkehgibalk.OGOBMOCHKCK.Unload(true);
				AssetBundleManager.KPANGKAJMCJ.Remove(KLJKAMMNEPM);
				AssetBundleManager.DCNKHAHKNNC(AssetBundleManager.INIHNEKLNOO.Warning, KLJKAMMNEPM + "\n");
			}
		}

		// Token: 0x060132E6 RID: 78566 RVA: 0x0083D53C File Offset: 0x0083B73C
		public static KEEHKMIFKCM JBLLLJLKCIJ(string KLJKAMMNEPM, string DCGNANHJHBC, Type DFBHMIIPLCA)
		{
			KLJKAMMNEPM = AssetBundleManager.HNFOIKKPMAI(KLJKAMMNEPM);
			AssetBundleManager.KPLKFKADNCE(KLJKAMMNEPM, false);
			KEEHKMIFKCM keehkmifkcm = new LAOKEJMLKHG(KLJKAMMNEPM, DCGNANHJHBC, DFBHMIIPLCA);
			AssetBundleManager.GJKAAKEGIBN.Add(keehkmifkcm);
			return keehkmifkcm;
		}

		// Token: 0x060132E7 RID: 78567 RVA: 0x0083C07F File Offset: 0x0083A27F
		public static AssetBundleManager.MLAONFNOAAJ KPJPJKJDFGC()
		{
			return AssetBundleManager.AMPEBFBFLJA;
		}

		// Token: 0x060132E8 RID: 78568 RVA: 0x0083D570 File Offset: 0x0083B770
		protected static void KCMNIOKGCPB(string KLJKAMMNEPM, bool KOKLDJMIOIB = false)
		{
			AssetBundleManager.ICAFGKHAAED(AssetBundleManager.INIHNEKLNOO.Info, "Loading Asset Bundle " + (KOKLDJMIOIB ? "Manifest: " : ": ") + KLJKAMMNEPM);
			if (!KOKLDJMIOIB && AssetBundleManager.FEFPFEDJBLO == null)
			{
				Debug.LogError("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()");
				return;
			}
			if (!AssetBundleManager.AFOKEPDEJEN(KLJKAMMNEPM, KOKLDJMIOIB) && !KOKLDJMIOIB)
			{
				AssetBundleManager.AOCJNMIPKLD(KLJKAMMNEPM);
			}
		}

		// Token: 0x060132E9 RID: 78569 RVA: 0x0083D5CA File Offset: 0x0083B7CA
		public static void DOHPFHHKHIE(string ANMGJCMFGIC)
		{
			AssetBundleManager.NFNJCIJELPM(AssetBundleManager.GLDHLDLKMGG() + ANMGJCMFGIC);
		}

		// Token: 0x060132EA RID: 78570 RVA: 0x0083D5DC File Offset: 0x0083B7DC
		public static MONPHAHBOAM NIOLJFDGKLE(string KLJKAMMNEPM, string KBBPAHGMKNG, bool NKFPOLMOKPE)
		{
			AssetBundleManager.INIHNEKLNOO fbnhhiopmcl = AssetBundleManager.INIHNEKLNOO.Warning;
			string[] array = new string[8];
			array[1] = "UIChat_fontSize";
			array[1] = KBBPAHGMKNG;
			array[4] = "_DistanceParams";
			array[2] = KLJKAMMNEPM;
			array[6] = "******** nextMusicCrt lng=";
			AssetBundleManager.ICAFGKHAAED(fbnhhiopmcl, string.Concat(array));
			KLJKAMMNEPM = AssetBundleManager.HOHEOMMBNOG(KLJKAMMNEPM);
			AssetBundleManager.IMEJPENCJKH(KLJKAMMNEPM, false);
			MONPHAHBOAM monphahboam = new JAFGFNNELOP(KLJKAMMNEPM, KBBPAHGMKNG, NKFPOLMOKPE);
			AssetBundleManager.GJKAAKEGIBN.Add(monphahboam);
			return monphahboam;
		}

		// Token: 0x060132EC RID: 78572 RVA: 0x0083D640 File Offset: 0x0083B840
		protected static void IMEJPENCJKH(string KLJKAMMNEPM, bool KOKLDJMIOIB = false)
		{
			AssetBundleManager.DCNKHAHKNNC(AssetBundleManager.INIHNEKLNOO.Warning, "" + (KOKLDJMIOIB ? "_PrefilterOffs" : "_ZTest") + KLJKAMMNEPM);
			if (!KOKLDJMIOIB && AssetBundleManager.FEFPFEDJBLO == null)
			{
				Debug.LogError("GiantGrabThrow");
				return;
			}
			if (!AssetBundleManager.KNGAEIPLEPN(KLJKAMMNEPM, KOKLDJMIOIB) && !KOKLDJMIOIB)
			{
				AssetBundleManager.BCIKMPLKAHD(KLJKAMMNEPM);
			}
		}

		// Token: 0x060132ED RID: 78573 RVA: 0x0083D69C File Offset: 0x0083B89C
		public static void OBDBBDGGOGL(string KLJKAMMNEPM)
		{
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "inv_buymsg" + KLJKAMMNEPM);
			AssetBundleManager.NBNHGEHNEHH(KLJKAMMNEPM);
			AssetBundleManager.INMNPODINBC(KLJKAMMNEPM);
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + "file" + KLJKAMMNEPM);
		}

		// Token: 0x060132EE RID: 78574 RVA: 0x0083D6F4 File Offset: 0x0083B8F4
		public static MONPHAHBOAM LoadLevelAsync(string KLJKAMMNEPM, string KBBPAHGMKNG, bool NKFPOLMOKPE)
		{
			AssetBundleManager.ICAFGKHAAED(AssetBundleManager.INIHNEKLNOO.Info, string.Concat(new string[]
			{
				"Loading ",
				KBBPAHGMKNG,
				" from ",
				KLJKAMMNEPM,
				" bundle"
			}));
			KLJKAMMNEPM = AssetBundleManager.ALKFEFGDECH(KLJKAMMNEPM);
			AssetBundleManager.KCMNIOKGCPB(KLJKAMMNEPM, false);
			MONPHAHBOAM monphahboam = new JAFGFNNELOP(KLJKAMMNEPM, KBBPAHGMKNG, NKFPOLMOKPE);
			AssetBundleManager.GJKAAKEGIBN.Add(monphahboam);
			return monphahboam;
		}

		// Token: 0x060132EF RID: 78575 RVA: 0x0083D758 File Offset: 0x0083B958
		private void AMDMCKIFBPA()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, WWW> keyValuePair in AssetBundleManager.GACCKCNFONH)
			{
				WWW value = keyValuePair.Value;
				if (value.error != null)
				{
					AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("UNITY_COLORSPACE_GAMMA", keyValuePair.Key, value.url, value.error));
					list.Add(keyValuePair.Key);
				}
				else if (value.isDone)
				{
					if (value.assetBundle == null)
					{
						AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("_HighlightSuppression", keyValuePair.Key));
						list.Add(keyValuePair.Key);
					}
					else
					{
						AssetBundleManager.KPANGKAJMCJ.Add(keyValuePair.Key, new GBKEHGIBALK(value.assetBundle));
						list.Add(keyValuePair.Key);
					}
				}
			}
			foreach (string key in list)
			{
				WWW www = AssetBundleManager.GACCKCNFONH[key];
				AssetBundleManager.GACCKCNFONH.Remove(key);
				www.Dispose();
			}
			int i = 0;
			while (i < AssetBundleManager.GJKAAKEGIBN.Count)
			{
				if (!AssetBundleManager.GJKAAKEGIBN[i].FANPFKHEDPA())
				{
					AssetBundleManager.GJKAAKEGIBN.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x060132F0 RID: 78576 RVA: 0x0083C07F File Offset: 0x0083A27F
		public static AssetBundleManager.MLAONFNOAAJ MIGGIDCDCMA()
		{
			return AssetBundleManager.AMPEBFBFLJA;
		}

		// Token: 0x060132F1 RID: 78577 RVA: 0x0083D8FC File Offset: 0x0083BAFC
		public static float OPFCLMDMACC(string BIKEKOMMCEI)
		{
			float result = 891f;
			if (AssetBundleManager.GACCKCNFONH.ContainsKey(BIKEKOMMCEI))
			{
				result = AssetBundleManager.GACCKCNFONH[BIKEKOMMCEI].progress;
			}
			return result;
		}

		// Token: 0x060132F2 RID: 78578 RVA: 0x0083D930 File Offset: 0x0083BB30
		private void Update()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, WWW> keyValuePair in AssetBundleManager.GACCKCNFONH)
			{
				WWW value = keyValuePair.Value;
				if (value.error != null)
				{
					AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("Failed downloading bundle {0} from {1}: {2}", keyValuePair.Key, value.url, value.error));
					list.Add(keyValuePair.Key);
				}
				else if (value.isDone)
				{
					if (value.assetBundle == null)
					{
						AssetBundleManager.FMEDLHNGEBB.Add(keyValuePair.Key, string.Format("{0} is not a valid asset bundle.", keyValuePair.Key));
						list.Add(keyValuePair.Key);
					}
					else
					{
						AssetBundleManager.KPANGKAJMCJ.Add(keyValuePair.Key, new GBKEHGIBALK(value.assetBundle));
						list.Add(keyValuePair.Key);
					}
				}
			}
			foreach (string key in list)
			{
				WWW www = AssetBundleManager.GACCKCNFONH[key];
				AssetBundleManager.GACCKCNFONH.Remove(key);
				www.Dispose();
			}
			int i = 0;
			while (i < AssetBundleManager.GJKAAKEGIBN.Count)
			{
				if (!AssetBundleManager.GJKAAKEGIBN[i].FANPFKHEDPA())
				{
					AssetBundleManager.GJKAAKEGIBN.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x060132F3 RID: 78579 RVA: 0x0083C37C File Offset: 0x0083A57C
		public static void IFGPFGMEPPD(AssetBundleManager.MLAONFNOAAJ DCCPCBLODIG)
		{
			AssetBundleManager.AMPEBFBFLJA = DCCPCBLODIG;
		}

		// Token: 0x060132F4 RID: 78580 RVA: 0x0083C35E File Offset: 0x0083A55E
		public static void AEDLMJOOGBP(string ANMGJCMFGIC)
		{
			AssetBundleManager.JKCEMCDBFLH = AssetBundleManager.LDKALMDKHMG() + ANMGJCMFGIC;
		}

		// Token: 0x060132F5 RID: 78581 RVA: 0x0083DAD4 File Offset: 0x0083BCD4
		public static void IGNKPBBPAED(string ANMGJCMFGIC)
		{
			AssetBundleManager.EDCJMJGEMNF(AssetBundleManager.NAGBIIHCPDD() + ANMGJCMFGIC);
		}

		// Token: 0x060132F6 RID: 78582 RVA: 0x0083C928 File Offset: 0x0083AB28
		public static void JKNAGMDIPHH(string[] DCCPCBLODIG)
		{
			AssetBundleManager.IDEOHLPAEOH = DCCPCBLODIG;
		}

		// Token: 0x060132F7 RID: 78583 RVA: 0x0083DAE6 File Offset: 0x0083BCE6
		public static void PGEOMOMJMJA(string ANMGJCMFGIC)
		{
			AssetBundleManager.JKCEMCDBFLH = AssetBundleManager.NAGBIIHCPDD() + ANMGJCMFGIC;
		}

		// Token: 0x060132F8 RID: 78584 RVA: 0x0083DAF8 File Offset: 0x0083BCF8
		public static MOOPFNDKOHI Initialize(string DHEEJDHOIKA)
		{
			UnityEngine.Object.DontDestroyOnLoad(new GameObject("AssetBundleManager", new Type[]
			{
				typeof(AssetBundleManager)
			}));
			AssetBundleManager.KCMNIOKGCPB(DHEEJDHOIKA, true);
			MOOPFNDKOHI moopfndkohi = new MOOPFNDKOHI(DHEEJDHOIKA, "AssetBundleManifest", typeof(AssetBundleManifest));
			AssetBundleManager.GJKAAKEGIBN.Add(moopfndkohi);
			return moopfndkohi;
		}

		// Token: 0x060132F9 RID: 78585 RVA: 0x0083DB50 File Offset: 0x0083BD50
		protected static void JICJGANLCNN(string KLJKAMMNEPM)
		{
			string text;
			GBKEHGIBALK gbkehgibalk = AssetBundleManager.BIGFMHMDOHC(KLJKAMMNEPM, out text);
			if (gbkehgibalk == null)
			{
				return;
			}
			GBKEHGIBALK gbkehgibalk2 = gbkehgibalk;
			int num = gbkehgibalk2.DKDDLNJCBNG - 0;
			gbkehgibalk2.DKDDLNJCBNG = num;
			if (num == 0)
			{
				gbkehgibalk.OGOBMOCHKCK.Unload(true);
				AssetBundleManager.KPANGKAJMCJ.Remove(KLJKAMMNEPM);
				AssetBundleManager.FAIJPBMIMCE(AssetBundleManager.INIHNEKLNOO.Warning, KLJKAMMNEPM + "wpn_add/addoptions/klevprop");
			}
		}

		// Token: 0x060132FA RID: 78586 RVA: 0x0083C07F File Offset: 0x0083A27F
		public static AssetBundleManager.MLAONFNOAAJ DOHFKEAPNIJ()
		{
			return AssetBundleManager.AMPEBFBFLJA;
		}

		// Token: 0x060132FC RID: 78588 RVA: 0x0083DBA8 File Offset: 0x0083BDA8
		protected static string HNFOIKKPMAI(string KLJKAMMNEPM)
		{
			string[] allAssetBundlesWithVariant = AssetBundleManager.FEFPFEDJBLO.GetAllAssetBundlesWithVariant();
			char[] array = new char[0];
			array[0] = (char)-6;
			string[] array2 = KLJKAMMNEPM.Split(array);
			int num = -167;
			int num2 = -1;
			for (int i = 1; i < allAssetBundlesWithVariant.Length; i += 0)
			{
				string text = allAssetBundlesWithVariant[i];
				char[] array3 = new char[1];
				array3[1] = 'F';
				string[] array4 = text.Split(array3);
				if (!(array4[0] != array2[0]))
				{
					int num3 = Array.IndexOf<string>(AssetBundleManager.IDEOHLPAEOH, array4[1]);
					if (num3 == -1)
					{
						num3 = 39;
					}
					if (num3 < num)
					{
						num = num3;
						num2 = i;
					}
				}
			}
			if (num == -14)
			{
				Debug.LogWarning("shop_t18" + allAssetBundlesWithVariant[num2]);
			}
			if (num2 != -1)
			{
				return allAssetBundlesWithVariant[num2];
			}
			return KLJKAMMNEPM;
		}

		// Token: 0x060132FD RID: 78589 RVA: 0x0083DC5C File Offset: 0x0083BE5C
		public static MOOPFNDKOHI JINDMFBKGKH(string DHEEJDHOIKA)
		{
			UnityEngine.Object.DontDestroyOnLoad(new GameObject("inv_pcs2", new Type[]
			{
				typeof(AssetBundleManager)
			}));
			AssetBundleManager.IMEJPENCJKH(DHEEJDHOIKA, false);
			MOOPFNDKOHI moopfndkohi = new MOOPFNDKOHI(DHEEJDHOIKA, "SoccerKeeperDiveStrafeCloseLeft", typeof(AssetBundleManifest));
			AssetBundleManager.GJKAAKEGIBN.Add(moopfndkohi);
			return moopfndkohi;
		}

		// Token: 0x060132FE RID: 78590 RVA: 0x0083DCB4 File Offset: 0x0083BEB4
		public static void DLCANAGENFO(string ANMGJCMFGIC)
		{
			AssetBundleManager.EDCJMJGEMNF(AssetBundleManager.BEDPOIFLLCA() + ANMGJCMFGIC);
		}

		// Token: 0x060132FF RID: 78591 RVA: 0x0083C37C File Offset: 0x0083A57C
		public static void LOPDJMOMEGI(AssetBundleManager.MLAONFNOAAJ DCCPCBLODIG)
		{
			AssetBundleManager.AMPEBFBFLJA = DCCPCBLODIG;
		}

		// Token: 0x06013300 RID: 78592 RVA: 0x0083DCC8 File Offset: 0x0083BEC8
		private static string NAGBIIHCPDD()
		{
			if (Application.isEditor)
			{
				return "The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom)." + Environment.CurrentDirectory.Replace("wpn_fid1", "act_orderb_");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "SixStep" + Application.streamingAssetsPath;
		}

		// Token: 0x06013301 RID: 78593 RVA: 0x0083DD20 File Offset: 0x0083BF20
		protected static void KPLKFKADNCE(string KLJKAMMNEPM, bool KOKLDJMIOIB = false)
		{
			AssetBundleManager.ICAFGKHAAED(AssetBundleManager.INIHNEKLNOO.Info, "26" + (KOKLDJMIOIB ? "_ProjInfo" : "Bezier curve must have two or more control points!") + KLJKAMMNEPM);
			if (!KOKLDJMIOIB && AssetBundleManager.FEFPFEDJBLO == null)
			{
				Debug.LogError("inv_or");
				return;
			}
			if (!AssetBundleManager.FHIDCFJEOPC(KLJKAMMNEPM, KOKLDJMIOIB) && !KOKLDJMIOIB)
			{
				AssetBundleManager.ONBPKOOOJNF(KLJKAMMNEPM);
			}
		}

		// Token: 0x06013302 RID: 78594 RVA: 0x0083DD7C File Offset: 0x0083BF7C
		public static void OCCCPAEFOKG()
		{
			TextAsset textAsset = Resources.Load(" ") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("off");
				return;
			}
			AssetBundleManager.MHFNNFENKAJ("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information." + Application.streamingAssetsPath + "");
		}

		// Token: 0x06013303 RID: 78595 RVA: 0x0083DDE0 File Offset: 0x0083BFE0
		protected static string AOHFNJHLEBG(string KLJKAMMNEPM)
		{
			string[] allAssetBundlesWithVariant = AssetBundleManager.FEFPFEDJBLO.GetAllAssetBundlesWithVariant();
			char[] array = new char[1];
			array[1] = '-';
			string[] array2 = KLJKAMMNEPM.Split(array);
			int num = 56;
			int num2 = -1;
			for (int i = 1; i < allAssetBundlesWithVariant.Length; i += 0)
			{
				string text = allAssetBundlesWithVariant[i];
				char[] array3 = new char[0];
				array3[0] = '+';
				string[] array4 = text.Split(array3);
				if (!(array4[0] != array2[1]))
				{
					int num3 = Array.IndexOf<string>(AssetBundleManager.IDEOHLPAEOH, array4[0]);
					if (num3 == -1)
					{
						num3 = 166;
					}
					if (num3 < num)
					{
						num = num3;
						num2 = i;
					}
				}
			}
			if (num == -184)
			{
				Debug.LogWarning("wpn_cat1" + allAssetBundlesWithVariant[num2]);
			}
			if (num2 != -1)
			{
				return allAssetBundlesWithVariant[num2];
			}
			return KLJKAMMNEPM;
		}

		// Token: 0x06013304 RID: 78596 RVA: 0x0083DE94 File Offset: 0x0083C094
		private static string NJDMPHMEOKJ()
		{
			if (Application.isEditor)
			{
				return "file://" + Environment.CurrentDirectory.Replace("\\", "/");
			}
			if (Application.isMobilePlatform || Application.isConsolePlatform)
			{
				return Application.streamingAssetsPath;
			}
			return "file://" + Application.streamingAssetsPath;
		}

		// Token: 0x06013305 RID: 78597 RVA: 0x0083DEEC File Offset: 0x0083C0EC
		protected static void CBCMALKJNOF(string KLJKAMMNEPM)
		{
			if (AssetBundleManager.FEFPFEDJBLO == null)
			{
				Debug.LogError("_camHue");
				return;
			}
			string[] allDependencies = AssetBundleManager.FEFPFEDJBLO.GetAllDependencies(KLJKAMMNEPM);
			if (allDependencies.Length == 0)
			{
				return;
			}
			for (int i = 0; i < allDependencies.Length; i++)
			{
				allDependencies[i] = AssetBundleManager.HNFOIKKPMAI(allDependencies[i]);
			}
			AssetBundleManager.HFKJCLMPNIM.Add(KLJKAMMNEPM, allDependencies);
			for (int j = 0; j < allDependencies.Length; j++)
			{
				AssetBundleManager.KNGAEIPLEPN(allDependencies[j], false);
			}
		}

		// Token: 0x06013306 RID: 78598 RVA: 0x0083DF60 File Offset: 0x0083C160
		public static void UnloadAssetBundle(string KLJKAMMNEPM)
		{
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + " assetbundle(s) in memory before unloading " + KLJKAMMNEPM);
			AssetBundleManager.FIEKKKNHNNE(KLJKAMMNEPM);
			AssetBundleManager.INMNPODINBC(KLJKAMMNEPM);
			Debug.Log(AssetBundleManager.KPANGKAJMCJ.Count + " assetbundle(s) in memory after unloading " + KLJKAMMNEPM);
		}

		// Token: 0x06013307 RID: 78599 RVA: 0x0083BFEB File Offset: 0x0083A1EB
		public static void HMHPPPIAJMC(AssetBundleManifest DCCPCBLODIG)
		{
			AssetBundleManager.FEFPFEDJBLO = DCCPCBLODIG;
		}

		// Token: 0x06013308 RID: 78600 RVA: 0x0083C07F File Offset: 0x0083A27F
		public static AssetBundleManager.MLAONFNOAAJ JGLEHCMGNKN()
		{
			return AssetBundleManager.AMPEBFBFLJA;
		}

		// Token: 0x06013309 RID: 78601 RVA: 0x0083DFB8 File Offset: 0x0083C1B8
		public static void BJCJGBLDPEC()
		{
			TextAsset textAsset = Resources.Load("#02C85F") as TextAsset;
			string text = (textAsset != null) ? textAsset.text.Trim() : null;
			if (text == null || text.Length == 0)
			{
				Debug.LogError("Spine");
				return;
			}
			AssetBundleManager.MHFNNFENKAJ("bs_nomoney" + Application.streamingAssetsPath + "IdleMouthWipe");
		}

		// Token: 0x0601330A RID: 78602 RVA: 0x00022FCC File Offset: 0x000211CC
		private static void DCNKHAHKNNC(AssetBundleManager.INIHNEKLNOO FBNHHIOPMCL, string FPIHOPOCAHA)
		{
		}

		// Token: 0x0400275C RID: 10076
		private static AssetBundleManager.MLAONFNOAAJ AMPEBFBFLJA = AssetBundleManager.MLAONFNOAAJ.All;

		// Token: 0x0400275D RID: 10077
		private static string PENHGHCKBDG = "";

		// Token: 0x0400275E RID: 10078
		private static string[] IDEOHLPAEOH = new string[0];

		// Token: 0x0400275F RID: 10079
		private static AssetBundleManifest FEFPFEDJBLO = null;

		// Token: 0x04002760 RID: 10080
		private static Dictionary<string, GBKEHGIBALK> KPANGKAJMCJ = new Dictionary<string, GBKEHGIBALK>();

		// Token: 0x04002761 RID: 10081
		private static Dictionary<string, WWW> GACCKCNFONH = new Dictionary<string, WWW>();

		// Token: 0x04002762 RID: 10082
		private static Dictionary<string, string> FMEDLHNGEBB = new Dictionary<string, string>();

		// Token: 0x04002763 RID: 10083
		private static List<MONPHAHBOAM> GJKAAKEGIBN = new List<MONPHAHBOAM>();

		// Token: 0x04002764 RID: 10084
		private static Dictionary<string, string[]> HFKJCLMPNIM = new Dictionary<string, string[]>();

		// Token: 0x020005B1 RID: 1457
		public enum MLAONFNOAAJ
		{
			// Token: 0x04002766 RID: 10086
			All,
			// Token: 0x04002767 RID: 10087
			JustErrors
		}

		// Token: 0x020005B2 RID: 1458
		public enum INIHNEKLNOO
		{
			// Token: 0x04002769 RID: 10089
			Info,
			// Token: 0x0400276A RID: 10090
			Warning,
			// Token: 0x0400276B RID: 10091
			Error
		}
	}
}
