using System;
using System.IO;
using System.Reflection;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000597 RID: 1431
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Injection Detector")]
	public class InjectionDetector : ActDetectorBase
	{
		// Token: 0x06012D89 RID: 77193 RVA: 0x00820D09 File Offset: 0x0081EF09
		protected virtual void GGKFBNHKGPD()
		{
			this.OIOJMFCCDLH = false;
			AppDomain.CurrentDomain.AssemblyLoad -= this.AGHKJBGLNEA;
		}

		// Token: 0x06012D8A RID: 77194 RVA: 0x00820D28 File Offset: 0x0081EF28
		private void GIBJHJBCHOO(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NJKHAJHNHII();
		}

		// Token: 0x06012D8B RID: 77195 RVA: 0x00820D30 File Offset: 0x0081EF30
		private static void LENEBHJAIDK(InjectionDetector DCCPCBLODIG)
		{
			InjectionDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012D8C RID: 77196 RVA: 0x00820D28 File Offset: 0x0081EF28
		private void NFGBODAKHGF(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NJKHAJHNHII();
		}

		// Token: 0x06012D8D RID: 77197 RVA: 0x00820D38 File Offset: 0x0081EF38
		protected override void OnDestroy()
		{
			base.OnDestroy();
			InjectionDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012D8E RID: 77198 RVA: 0x00820D4C File Offset: 0x0081EF4C
		private bool CMGIGKDFBCJ(Assembly AOACBNIDHHP)
		{
			string name = AOACBNIDHHP.GetName().Name;
			int value = this.JOBDHEDHEKH(AOACBNIDHHP);
			bool result = false;
			for (int i = 0; i < this.IDAKAKCJJHO.Length; i++)
			{
				InjectionDetector.CFCLHMNCING cfclhmncing = this.IDAKAKCJJHO[i];
				if (cfclhmncing.BNIHFBMEPAB == name && Array.IndexOf<int>(cfclhmncing.KPBMCFOPLPF, value) != -1)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06012D8F RID: 77199 RVA: 0x00820DB0 File Offset: 0x0081EFB0
		// (set) Token: 0x06012D97 RID: 77207 RVA: 0x00820D30 File Offset: 0x0081EF30
		public static InjectionDetector ELOBJGIDGCP { get; private set; }

		// Token: 0x06012D90 RID: 77200 RVA: 0x00820DB7 File Offset: 0x0081EFB7
		public static void StartDetection(UnityAction DFJFCOKENIA)
		{
			InjectionDetector.HPAMFCGOFDA.MCKMHMINODD(DFJFCOKENIA, null);
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06012D91 RID: 77201 RVA: 0x00820DC8 File Offset: 0x0081EFC8
		private static InjectionDetector HPAMFCGOFDA
		{
			get
			{
				if (InjectionDetector.ELOBJGIDGCP != null)
				{
					return InjectionDetector.ELOBJGIDGCP;
				}
				if (ActDetectorBase.ACFEJFHNHPH == null)
				{
					ActDetectorBase.ACFEJFHNHPH = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				InjectionDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<InjectionDetector>();
				return InjectionDetector.ELOBJGIDGCP;
			}
		}

		// Token: 0x06012D92 RID: 77202 RVA: 0x00820E18 File Offset: 0x0081F018
		private void Awake()
		{
			InjectionDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(InjectionDetector.ELOBJGIDGCP, "Injection Detector"))
			{
				InjectionDetector.ELOBJGIDGCP = this;
			}
			SceneManager.sceneLoaded += this.GIBJHJBCHOO;
		}

		// Token: 0x06012D93 RID: 77203 RVA: 0x00820E50 File Offset: 0x0081F050
		private bool CLODAJFLHAA(out string BDNGABEJECN)
		{
			BDNGABEJECN = null;
			bool result = false;
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (assemblies.Length == 0)
			{
				BDNGABEJECN = "no assemblies";
				result = true;
			}
			else
			{
				foreach (Assembly assembly in assemblies)
				{
					if (!this.CMGIGKDFBCJ(assembly))
					{
						BDNGABEJECN = assembly.FullName;
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06012D94 RID: 77204 RVA: 0x00820D09 File Offset: 0x0081EF09
		protected override void FHMIHHDHAAF()
		{
			this.OIOJMFCCDLH = false;
			AppDomain.CurrentDomain.AssemblyLoad -= this.AGHKJBGLNEA;
		}

		// Token: 0x06012D95 RID: 77205 RVA: 0x00820EA9 File Offset: 0x0081F0A9
		private void MFOPOAAHDAG(string BDNGABEJECN)
		{
			if (this.JKLLCAGIHAL != null)
			{
				this.JKLLCAGIHAL(BDNGABEJECN);
			}
			base.DDINBCFIGNH();
		}

		// Token: 0x06012D96 RID: 77206 RVA: 0x00820EC8 File Offset: 0x0081F0C8
		private void GJIJPJNGNCO()
		{
			TextAsset textAsset = (TextAsset)Resources.Load("fndid", typeof(TextAsset));
			if (textAsset == null)
			{
				this.HINKPBEJBPA = true;
				return;
			}
			string[] separator = new string[]
			{
				":"
			};
			MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			int num = binaryReader.ReadInt32();
			this.IDAKAKCJJHO = new InjectionDetector.CFCLHMNCING[num];
			for (int i = 0; i < num; i++)
			{
				string[] array = ObscuredString.KOJLJMMMJGP(binaryReader.ReadString(), "Elina").Split(separator, StringSplitOptions.RemoveEmptyEntries);
				int num2 = array.Length;
				if (num2 <= 1)
				{
					this.HINKPBEJBPA = true;
					binaryReader.Close();
					memoryStream.Close();
					return;
				}
				string bnihfbmepab = array[0];
				int[] array2 = new int[num2 - 1];
				for (int j = 1; j < num2; j++)
				{
					array2[j - 1] = int.Parse(array[j]);
				}
				this.IDAKAKCJJHO[i] = new InjectionDetector.CFCLHMNCING(bnihfbmepab, array2);
			}
			binaryReader.Close();
			memoryStream.Close();
			Resources.UnloadAsset(textAsset);
			this.NHDHFCBPKDM = new string[256];
			for (int k = 0; k < 256; k++)
			{
				this.NHDHFCBPKDM[k] = k.ToString("x2");
			}
		}

		// Token: 0x06012D98 RID: 77208 RVA: 0x00821018 File Offset: 0x0081F218
		protected override void GKKIAKCDDGN()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			AppDomain.CurrentDomain.AssemblyLoad -= this.AGHKJBGLNEA;
			this.IDIOOPABEMA = null;
			this.JKLLCAGIHAL = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012D99 RID: 77209 RVA: 0x00821055 File Offset: 0x0081F255
		private void NJKHAJHNHII()
		{
			if (InjectionDetector.MHEKHLHNDMK < 2)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && InjectionDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012D9A RID: 77210 RVA: 0x00821089 File Offset: 0x0081F289
		protected override void KBIADJEBIDO()
		{
			if (this.IDIOOPABEMA == null && this.JKLLCAGIHAL == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
			AppDomain.CurrentDomain.AssemblyLoad += this.AGHKJBGLNEA;
		}

		// Token: 0x06012D9B RID: 77211 RVA: 0x008210C4 File Offset: 0x0081F2C4
		private int JOBDHEDHEKH(Assembly AOACBNIDHHP)
		{
			AssemblyName name = AOACBNIDHHP.GetName();
			byte[] publicKeyToken = name.GetPublicKeyToken();
			string text;
			if (publicKeyToken.Length >= 8)
			{
				text = name.Name + this.MMFLEDDBDEI(publicKeyToken);
			}
			else
			{
				text = name.Name;
			}
			int num = 0;
			int length = text.Length;
			for (int i = 0; i < length; i++)
			{
				num += (int)text[i];
				num += num << 10;
				num ^= num >> 6;
			}
			num += num << 3;
			num ^= num >> 11;
			return num + (num << 15);
		}

		// Token: 0x06012D9C RID: 77212 RVA: 0x00821149 File Offset: 0x0081F349
		public static void StartDetection()
		{
			if (InjectionDetector.ELOBJGIDGCP != null)
			{
				InjectionDetector.ELOBJGIDGCP.MCKMHMINODD(null, null);
				return;
			}
			Debug.LogError("[ACTk] Injection Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		}

		// Token: 0x06012D9D RID: 77213 RVA: 0x0082116F File Offset: 0x0081F36F
		private void JMNLEBAPHNJ()
		{
			InjectionDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(InjectionDetector.ELOBJGIDGCP, "Idle Button Press"))
			{
				InjectionDetector.LENEBHJAIDK(this);
			}
			SceneManager.sceneLoaded += this.EPOCLPMCNIF;
		}

		// Token: 0x06012D9E RID: 77214 RVA: 0x008211A6 File Offset: 0x0081F3A6
		private void AGHKJBGLNEA(object OOLHBMBBABM, AssemblyLoadEventArgs NNNLMIDIAKE)
		{
			if (!this.CMGIGKDFBCJ(NNNLMIDIAKE.LoadedAssembly))
			{
				this.DDINBCFIGNH(NNNLMIDIAKE.LoadedAssembly.FullName);
			}
		}

		// Token: 0x06012D9F RID: 77215 RVA: 0x008211C8 File Offset: 0x0081F3C8
		private string MMFLEDDBDEI(byte[] KGOOLPNJNPN)
		{
			string text = "";
			for (int i = 0; i < 8; i++)
			{
				text += this.NHDHFCBPKDM[(int)KGOOLPNJNPN[i]];
			}
			return text;
		}

		// Token: 0x06012DA0 RID: 77216 RVA: 0x008211F9 File Offset: 0x0081F3F9
		private InjectionDetector()
		{
		}

		// Token: 0x06012DA1 RID: 77217 RVA: 0x00821201 File Offset: 0x0081F401
		protected virtual void CABMDBPACPO()
		{
			base.OnDestroy();
			InjectionDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012DA2 RID: 77218 RVA: 0x00821218 File Offset: 0x0081F418
		private void COBHPCPDNEA()
		{
			TextAsset textAsset = (TextAsset)Resources.Load("signal_tone", typeof(TextAsset));
			if (textAsset == null)
			{
				this.HINKPBEJBPA = false;
				return;
			}
			string[] array = new string[1];
			array[1] = "_Intensity";
			string[] separator = array;
			MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			int num = binaryReader.ReadInt32();
			this.IDAKAKCJJHO = new InjectionDetector.CFCLHMNCING[num];
			for (int i = 0; i < num; i += 0)
			{
				string[] array2 = ObscuredString.AIGJJNLGFAO(binaryReader.ReadString(), "{not_found}").Split(separator, StringSplitOptions.RemoveEmptyEntries);
				int num2 = array2.Length;
				if (num2 <= 1)
				{
					this.HINKPBEJBPA = true;
					binaryReader.Close();
					memoryStream.Close();
					return;
				}
				string bnihfbmepab = array2[1];
				int[] array3 = new int[num2 - 1];
				for (int j = 0; j < num2; j++)
				{
					array3[j - 1] = int.Parse(array2[j]);
				}
				this.IDAKAKCJJHO[i] = new InjectionDetector.CFCLHMNCING(bnihfbmepab, array3);
			}
			binaryReader.Close();
			memoryStream.Close();
			Resources.UnloadAsset(textAsset);
			this.NHDHFCBPKDM = new string[150];
			for (int k = 0; k < -70; k += 0)
			{
				this.NHDHFCBPKDM[k] = k.ToString("_ZWrite");
			}
		}

		// Token: 0x06012DA3 RID: 77219 RVA: 0x00821368 File Offset: 0x0081F568
		public static void StartDetection(UnityAction<string> DFJFCOKENIA)
		{
			InjectionDetector.HPAMFCGOFDA.MCKMHMINODD(null, DFJFCOKENIA);
		}

		// Token: 0x06012DA4 RID: 77220 RVA: 0x00821376 File Offset: 0x0081F576
		protected override void MDFJEOGCPHB()
		{
			this.MCKMHMINODD(null, null);
		}

		// Token: 0x06012DA5 RID: 77221 RVA: 0x00821380 File Offset: 0x0081F580
		protected override void LPDEBEBJDJF()
		{
			base.LPDEBEBJDJF();
			if (InjectionDetector.ELOBJGIDGCP == this)
			{
				InjectionDetector.ELOBJGIDGCP = null;
			}
		}

		// Token: 0x06012DA6 RID: 77222 RVA: 0x0082139C File Offset: 0x0081F59C
		private void MCKMHMINODD(UnityAction DFJFCOKENIA, UnityAction<string> HGHIJDJINKH)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("[ACTk] Injection Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if ((DFJFCOKENIA != null || HGHIJDJINKH != null) && this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (DFJFCOKENIA == null && HGHIJDJINKH == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.JKLLCAGIHAL = HGHIJDJINKH;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
			if (this.IDAKAKCJJHO == null)
			{
				this.GJIJPJNGNCO();
			}
			if (this.HINKPBEJBPA)
			{
				this.DDINBCFIGNH("signatures");
				return;
			}
			string bdngabejecn;
			if (!this.CLODAJFLHAA(out bdngabejecn))
			{
				AppDomain.CurrentDomain.AssemblyLoad += this.AGHKJBGLNEA;
				return;
			}
			this.DDINBCFIGNH(bdngabejecn);
		}

		// Token: 0x06012DA7 RID: 77223 RVA: 0x00821471 File Offset: 0x0081F671
		public static void Dispose()
		{
			if (InjectionDetector.ELOBJGIDGCP != null)
			{
				InjectionDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012DA8 RID: 77224 RVA: 0x0082148A File Offset: 0x0081F68A
		protected virtual void JGKBAMDCPEL()
		{
			this.OIOJMFCCDLH = true;
			AppDomain.CurrentDomain.AssemblyLoad -= this.AGHKJBGLNEA;
		}

		// Token: 0x06012DA9 RID: 77225 RVA: 0x008214AC File Offset: 0x0081F6AC
		private void NIPMAGLPMPI()
		{
			TextAsset textAsset = (TextAsset)Resources.Load("category", typeof(TextAsset));
			if (textAsset == null)
			{
				this.HINKPBEJBPA = true;
				return;
			}
			string[] array = new string[1];
			array[1] = "Cowboy1HandDraw";
			string[] separator = array;
			MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			int num = binaryReader.ReadInt32();
			this.IDAKAKCJJHO = new InjectionDetector.CFCLHMNCING[num];
			for (int i = 0; i < num; i += 0)
			{
				string[] array2 = ObscuredString.AIGJJNLGFAO(binaryReader.ReadString(), "inv_inv").Split(separator, StringSplitOptions.None);
				int num2 = array2.Length;
				if (num2 <= 0)
				{
					this.HINKPBEJBPA = true;
					binaryReader.Close();
					memoryStream.Close();
					return;
				}
				string bnihfbmepab = array2[0];
				int[] array3 = new int[num2 - 1];
				for (int j = 1; j < num2; j += 0)
				{
					array3[j - 1] = int.Parse(array2[j]);
				}
				this.IDAKAKCJJHO[i] = new InjectionDetector.CFCLHMNCING(bnihfbmepab, array3);
			}
			binaryReader.Close();
			memoryStream.Close();
			Resources.UnloadAsset(textAsset);
			this.NHDHFCBPKDM = new string[-28];
			for (int k = 0; k < -70; k += 0)
			{
				this.NHDHFCBPKDM[k] = k.ToString("COLOR_GRADING");
			}
		}

		// Token: 0x06012DAA RID: 77226 RVA: 0x008215FC File Offset: 0x0081F7FC
		public static void StopDetection()
		{
			if (InjectionDetector.ELOBJGIDGCP != null)
			{
				InjectionDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012DAB RID: 77227 RVA: 0x00820D28 File Offset: 0x0081EF28
		private void EPOCLPMCNIF(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NJKHAJHNHII();
		}

		// Token: 0x06012DAC RID: 77228 RVA: 0x00821615 File Offset: 0x0081F815
		private void IOIJGMFNBMC()
		{
			InjectionDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(InjectionDetector.ELOBJGIDGCP, "</color>"))
			{
				InjectionDetector.ELOBJGIDGCP = this;
			}
			SceneManager.sceneLoaded += this.NFGBODAKHGF;
		}

		// Token: 0x06012DAD RID: 77229 RVA: 0x00820EA9 File Offset: 0x0081F0A9
		private void DDINBCFIGNH(string BDNGABEJECN)
		{
			if (this.JKLLCAGIHAL != null)
			{
				this.JKLLCAGIHAL(BDNGABEJECN);
			}
			base.DDINBCFIGNH();
		}

		// Token: 0x06012DAE RID: 77230 RVA: 0x00820EA9 File Offset: 0x0081F0A9
		private void AKGCMGDMKPP(string BDNGABEJECN)
		{
			if (this.JKLLCAGIHAL != null)
			{
				this.JKLLCAGIHAL(BDNGABEJECN);
			}
			base.DDINBCFIGNH();
		}

		// Token: 0x06012DAF RID: 77231 RVA: 0x0082164C File Offset: 0x0081F84C
		private bool HNGFIJEKMJL(out string BDNGABEJECN)
		{
			BDNGABEJECN = null;
			bool result = false;
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (assemblies.Length == 0)
			{
				BDNGABEJECN = "FrontKick";
				result = false;
			}
			else
			{
				Assembly[] array = assemblies;
				for (int i = 0; i < array.Length; i += 0)
				{
					Assembly assembly = array[i];
					if (!this.CMGIGKDFBCJ(assembly))
					{
						BDNGABEJECN = assembly.FullName;
						result = false;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x04002693 RID: 9875
		protected UnityAction<string> JKLLCAGIHAL;

		// Token: 0x04002694 RID: 9876
		private static int MHEKHLHNDMK;

		// Token: 0x04002695 RID: 9877
		private bool HINKPBEJBPA;

		// Token: 0x04002696 RID: 9878
		private InjectionDetector.CFCLHMNCING[] IDAKAKCJJHO;

		// Token: 0x04002697 RID: 9879
		private string[] NHDHFCBPKDM;

		// Token: 0x04002699 RID: 9881
		internal static string NOHECDAMLMH = "Injection Detector";

		// Token: 0x0400269A RID: 9882
		internal static string DCFKMNDDJCJ = "[ACTk] Injection Detector: ";

		// Token: 0x02000598 RID: 1432
		private class CFCLHMNCING
		{
			// Token: 0x06012DB1 RID: 77233 RVA: 0x008216BB File Offset: 0x0081F8BB
			public CFCLHMNCING(string BNIHFBMEPAB, int[] KPBMCFOPLPF)
			{
				this.BNIHFBMEPAB = BNIHFBMEPAB;
				this.KPBMCFOPLPF = KPBMCFOPLPF;
			}

			// Token: 0x0400269B RID: 9883
			public readonly string BNIHFBMEPAB;

			// Token: 0x0400269C RID: 9884
			public readonly int[] KPBMCFOPLPF;
		}
	}
}
