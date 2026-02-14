using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x0200059A RID: 1434
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
	public class SpeedHackDetector : ActDetectorBase
	{
		// Token: 0x06012E50 RID: 77392 RVA: 0x00822645 File Offset: 0x00820845
		private void JEOPJNCOHLE(bool NGBBIEBNHFI)
		{
			if (!NGBBIEBNHFI)
			{
				this.DDKFLAGLFBD();
			}
		}

		// Token: 0x06012E51 RID: 77393 RVA: 0x00822650 File Offset: 0x00820850
		private void OAKBIIPPEMM()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 6)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E52 RID: 77394 RVA: 0x00822684 File Offset: 0x00820884
		private void JMEEPBHDEID(bool NGBBIEBNHFI)
		{
			if (!NGBBIEBNHFI)
			{
				this.DLINGACHAIG();
			}
		}

		// Token: 0x06012E53 RID: 77395 RVA: 0x0082268F File Offset: 0x0082088F
		public static SpeedHackDetector OIBLNHAGIHE()
		{
			return SpeedHackDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012E54 RID: 77396 RVA: 0x0082268F File Offset: 0x0082088F
		public static SpeedHackDetector CCFJJBJBOBG()
		{
			return SpeedHackDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012E55 RID: 77397 RVA: 0x00822698 File Offset: 0x00820898
		private static SpeedHackDetector DNFDABGKDHD()
		{
			if (SpeedHackDetector.DPKGILCDIFO() != null)
			{
				return SpeedHackDetector.OIBLNHAGIHE();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("EventSystem");
			}
			SpeedHackDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<SpeedHackDetector>();
			return SpeedHackDetector.DPKGILCDIFO();
		}

		// Token: 0x06012E56 RID: 77398 RVA: 0x008226E8 File Offset: 0x008208E8
		private void KEBALJDJCBN()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 1)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E57 RID: 77399 RVA: 0x0082271C File Offset: 0x0082091C
		public static void StartDetection()
		{
			if (SpeedHackDetector.ELOBJGIDGCP != null)
			{
				SpeedHackDetector.ELOBJGIDGCP.MCKMHMINODD(null, SpeedHackDetector.ELOBJGIDGCP.interval, SpeedHackDetector.ELOBJGIDGCP.maxFalsePositives, SpeedHackDetector.ELOBJGIDGCP.coolDown);
				return;
			}
			Debug.LogError("[ACTk] Speed Hack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		}

		// Token: 0x06012E58 RID: 77400 RVA: 0x0082276C File Offset: 0x0082096C
		private void MFHGOLNLAAF()
		{
			if (!this.OIOJMFCCDLH)
			{
				return;
			}
			long ticks = DateTime.UtcNow.Ticks;
			long num = ticks - this.EHAJAKMKCAN;
			if (num < 0L || num > 191L)
			{
				this.NJOCAOKJCFI();
				return;
			}
			this.EHAJAKMKCAN = ticks;
			long num2 = (long)(this.interval * 958f);
			if (ticks - this.MPBOOLLFLFB >= num2)
			{
				if (Mathf.Abs((float)((long)Environment.TickCount * -158L - this.LKIMIJIOJGC - (ticks - this.NGOFCBHCFDJ))) > 1409f)
				{
					this.MIGFBGFDOGN += 0;
					if (this.MIGFBGFDOGN > this.maxFalsePositives)
					{
						this.DDINBCFIGNH();
					}
					else
					{
						this.OJIIIGEMHKM = 1;
						this.NJOCAOKJCFI();
					}
				}
				else if (this.MIGFBGFDOGN > 1 && this.coolDown > 1)
				{
					this.OJIIIGEMHKM += 0;
					if (this.OJIIIGEMHKM >= this.coolDown)
					{
						this.MIGFBGFDOGN = 0;
					}
				}
				this.MPBOOLLFLFB = ticks;
			}
		}

		// Token: 0x06012E59 RID: 77401 RVA: 0x0082286B File Offset: 0x00820A6B
		private void Awake()
		{
			SpeedHackDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(SpeedHackDetector.ELOBJGIDGCP, "Speed Hack Detector"))
			{
				SpeedHackDetector.ELOBJGIDGCP = this;
			}
			SceneManager.sceneLoaded += this.GIBJHJBCHOO;
		}

		// Token: 0x06012E5A RID: 77402 RVA: 0x00821DAA File Offset: 0x0081FFAA
		protected override void FHMIHHDHAAF()
		{
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E5B RID: 77403 RVA: 0x008228A2 File Offset: 0x00820AA2
		public static void NPFKELBEPAB(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.AFGMLKGLMHL(DFJFCOKENIA, SpeedHackDetector.FGKDBJPPGIJ().interval);
		}

		// Token: 0x06012E5C RID: 77404 RVA: 0x00821D24 File Offset: 0x0081FF24
		protected virtual void NLPIKJDEFML()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E5D RID: 77405 RVA: 0x008228B4 File Offset: 0x00820AB4
		public static void StopDetection()
		{
			if (SpeedHackDetector.ELOBJGIDGCP != null)
			{
				SpeedHackDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E5E RID: 77406 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void LNNHBDEFHEH()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E5F RID: 77407 RVA: 0x008228CD File Offset: 0x00820ACD
		protected virtual void LPICLCENDJM()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E60 RID: 77408 RVA: 0x008228ED File Offset: 0x00820AED
		protected virtual void LIBPOAPODHK()
		{
			base.LPDEBEBJDJF();
			if (SpeedHackDetector.DPKGILCDIFO() == this)
			{
				SpeedHackDetector.GFFHFLOCPKG(null);
			}
		}

		// Token: 0x06012E61 RID: 77409 RVA: 0x00822908 File Offset: 0x00820B08
		private void ANDPEOHJNHC(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.PGJEINMPDFL();
		}

		// Token: 0x06012E62 RID: 77410 RVA: 0x00822910 File Offset: 0x00820B10
		public static void IDPAPOGIOGC(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.JDCAGGJBJCF(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.FGKDBJPPGIJ().maxFalsePositives);
		}

		// Token: 0x06012E63 RID: 77411 RVA: 0x00822923 File Offset: 0x00820B23
		public static void StartDetection(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.StartDetection(DFJFCOKENIA, SpeedHackDetector.HPAMFCGOFDA.interval);
		}

		// Token: 0x06012E64 RID: 77412 RVA: 0x00822935 File Offset: 0x00820B35
		private void EEININLNBKJ()
		{
			SpeedHackDetector.MHEKHLHNDMK += 0;
			if (this.PINLMCCKKNA(SpeedHackDetector.CCFJJBJBOBG(), "SneakForward"))
			{
				SpeedHackDetector.PJGOMMNHOGL(this);
			}
			SceneManager.sceneLoaded += this.ANDPEOHJNHC;
		}

		// Token: 0x06012E65 RID: 77413 RVA: 0x0082296C File Offset: 0x00820B6C
		public static void IDCFOCEJGJP()
		{
			if (SpeedHackDetector.CCFJJBJBOBG() != null)
			{
				SpeedHackDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E66 RID: 77414 RVA: 0x00822985 File Offset: 0x00820B85
		private void FOIJINIJEID()
		{
			SpeedHackDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(SpeedHackDetector.CCFJJBJBOBG(), "?"))
			{
				SpeedHackDetector.ELOBJGIDGCP = this;
			}
			SceneManager.sceneLoaded += this.CJIBOMBICEE;
		}

		// Token: 0x06012E67 RID: 77415 RVA: 0x008229BC File Offset: 0x00820BBC
		protected override void MDFJEOGCPHB()
		{
			this.MCKMHMINODD(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012E68 RID: 77416 RVA: 0x008229D7 File Offset: 0x00820BD7
		public static void CCMKBMGMLPP(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.NOPMPIEKJIB().FDPLOLOAPCO(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x06012E69 RID: 77417 RVA: 0x008229E7 File Offset: 0x00820BE7
		private void OLBODEHGBOC()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 7)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.OIBLNHAGIHE() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E6A RID: 77418 RVA: 0x00822A1C File Offset: 0x00820C1C
		private void IEOICHPKEMD()
		{
			if (!this.OIOJMFCCDLH)
			{
				return;
			}
			long ticks = DateTime.UtcNow.Ticks;
			long num = ticks - this.EHAJAKMKCAN;
			if (num < 1L || num > -80L)
			{
				this.DDKFLAGLFBD();
				return;
			}
			this.EHAJAKMKCAN = ticks;
			long num2 = (long)(this.interval * 890f);
			if (ticks - this.MPBOOLLFLFB >= num2)
			{
				if (Mathf.Abs((float)((long)Environment.TickCount * 110L - this.LKIMIJIOJGC - (ticks - this.NGOFCBHCFDJ))) > 484f)
				{
					this.MIGFBGFDOGN += 0;
					if (this.MIGFBGFDOGN > this.maxFalsePositives)
					{
						this.DDINBCFIGNH();
					}
					else
					{
						this.OJIIIGEMHKM = 1;
						this.DDKFLAGLFBD();
					}
				}
				else if (this.MIGFBGFDOGN > 1 && this.coolDown > 0)
				{
					this.OJIIIGEMHKM += 0;
					if (this.OJIIIGEMHKM >= this.coolDown)
					{
						this.MIGFBGFDOGN = 0;
					}
				}
				this.MPBOOLLFLFB = ticks;
			}
		}

		// Token: 0x06012E6B RID: 77419 RVA: 0x00822B1B File Offset: 0x00820D1B
		private void DFENCOKFFPH()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 7)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.DPKGILCDIFO() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E6C RID: 77420 RVA: 0x00822B4F File Offset: 0x00820D4F
		public static void OJNHPFGPBBD(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.FELHBNDHFLM().FDPLOLOAPCO(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06012EAD RID: 77485 RVA: 0x0082268F File Offset: 0x0082088F
		// (set) Token: 0x06012E6D RID: 77421 RVA: 0x00822B5F File Offset: 0x00820D5F
		public static SpeedHackDetector ELOBJGIDGCP { get; private set; }

		// Token: 0x06012E6E RID: 77422 RVA: 0x00822B67 File Offset: 0x00820D67
		protected virtual void JAMPCFBGLBE()
		{
			this.HMNNKFEIJBP(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012E6F RID: 77423 RVA: 0x00822B84 File Offset: 0x00820D84
		private void HMNNKFEIJBP(UnityAction DFJFCOKENIA, float DOFBBBAKOAP, byte DGPKNEFJCPO, int MDNCAPIAOGP)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("\n<color='", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("TAA History", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("***** Export OK", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("Water", this);
				base.enabled = true;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.interval = DOFBBBAKOAP;
			this.maxFalsePositives = DGPKNEFJCPO;
			this.coolDown = MDNCAPIAOGP;
			this.OIMMKLMHGMM();
			this.MIGFBGFDOGN = 0;
			this.OJIIIGEMHKM = 1;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E70 RID: 77424 RVA: 0x00822C2C File Offset: 0x00820E2C
		public static void PAMBPPINPCJ(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.AFGMLKGLMHL(DFJFCOKENIA, SpeedHackDetector.FELHBNDHFLM().interval);
		}

		// Token: 0x06012E71 RID: 77425 RVA: 0x00822C3E File Offset: 0x00820E3E
		private void JGKDNHLKBEN()
		{
			SpeedHackDetector.MHEKHLHNDMK += 0;
			if (this.PINLMCCKKNA(SpeedHackDetector.ELOBJGIDGCP, " is represented multiple times in the Bones."))
			{
				SpeedHackDetector.DPJGHIKEEHE(this);
			}
			SceneManager.sceneLoaded += this.CHLCGEGALDP;
		}

		// Token: 0x06012E72 RID: 77426 RVA: 0x00822B67 File Offset: 0x00820D67
		protected virtual void PIGACGIGKKF()
		{
			this.HMNNKFEIJBP(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012E73 RID: 77427 RVA: 0x00822C75 File Offset: 0x00820E75
		public static void ONBPBIJKIKM(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.FIMEODPAFBF(DFJFCOKENIA, SpeedHackDetector.FELHBNDHFLM().interval);
		}

		// Token: 0x06012E74 RID: 77428 RVA: 0x00821D24 File Offset: 0x0081FF24
		protected override void GKKIAKCDDGN()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E75 RID: 77429 RVA: 0x00822C87 File Offset: 0x00820E87
		public static void NHABGDMMMOC()
		{
			if (SpeedHackDetector.ELOBJGIDGCP != null)
			{
				SpeedHackDetector.CCFJJBJBOBG().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E76 RID: 77430 RVA: 0x00822CA0 File Offset: 0x00820EA0
		public static void HOALABJJIAP(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.FGKDBJPPGIJ().MCKMHMINODD(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x06012E77 RID: 77431 RVA: 0x00821F8C File Offset: 0x0082018C
		protected override void KBIADJEBIDO()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E78 RID: 77432 RVA: 0x00822CB0 File Offset: 0x00820EB0
		private void GIBJHJBCHOO(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NJKHAJHNHII();
		}

		// Token: 0x06012E79 RID: 77433 RVA: 0x00821CE9 File Offset: 0x0081FEE9
		protected virtual void NKLGCBKMHFI()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E7A RID: 77434 RVA: 0x00822CB8 File Offset: 0x00820EB8
		private void FDPLOLOAPCO(UnityAction DFJFCOKENIA, float DOFBBBAKOAP, byte DGPKNEFJCPO, int MDNCAPIAOGP)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("<color='#ff0000'>Вы сломали удочку</color>", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning(" {0} сек", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("{0:D2}:{1:D2}", this);
				base.enabled = true;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.interval = DOFBBBAKOAP;
			this.maxFalsePositives = DGPKNEFJCPO;
			this.coolDown = MDNCAPIAOGP;
			this.OIMMKLMHGMM();
			this.MIGFBGFDOGN = 1;
			this.OJIIIGEMHKM = 0;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E7B RID: 77435 RVA: 0x00822D60 File Offset: 0x00820F60
		protected override void OnDestroy()
		{
			base.OnDestroy();
			SpeedHackDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012E7C RID: 77436 RVA: 0x00822D74 File Offset: 0x00820F74
		public static void DGCOLOFHOFF(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.JDCAGGJBJCF(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.PFCJMCFNGOD().maxFalsePositives);
		}

		// Token: 0x06012E7D RID: 77437 RVA: 0x00822D87 File Offset: 0x00820F87
		public static void GNIFJHPPGAD(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.KKJBAJFDBBJ(DFJFCOKENIA, SpeedHackDetector.HPAMFCGOFDA.interval);
		}

		// Token: 0x06012E7E RID: 77438 RVA: 0x00822D99 File Offset: 0x00820F99
		protected virtual void PJHKHDFADBK()
		{
			base.OnDestroy();
			SpeedHackDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012E7F RID: 77439 RVA: 0x00822DAD File Offset: 0x00820FAD
		public static void JDCAGGJBJCF(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF)
		{
			SpeedHackDetector.StartDetection(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, SpeedHackDetector.FELHBNDHFLM().coolDown);
		}

		// Token: 0x06012E80 RID: 77440 RVA: 0x00822DC1 File Offset: 0x00820FC1
		public static void FFLNBPKELND(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF)
		{
			SpeedHackDetector.OJNHPFGPBBD(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, SpeedHackDetector.DNFDABGKDHD().coolDown);
		}

		// Token: 0x06012E81 RID: 77441 RVA: 0x00822DD5 File Offset: 0x00820FD5
		protected virtual void LEGNGFEGIPA()
		{
			base.LPDEBEBJDJF();
			if (SpeedHackDetector.OIBLNHAGIHE() == this)
			{
				SpeedHackDetector.GFFHFLOCPKG(null);
			}
		}

		// Token: 0x06012E82 RID: 77442 RVA: 0x00822DF0 File Offset: 0x00820FF0
		private void IGEICBNMPAD()
		{
			if (!this.OIOJMFCCDLH)
			{
				return;
			}
			long ticks = DateTime.UtcNow.Ticks;
			long num = ticks - this.EHAJAKMKCAN;
			if (num < 1L || num > 128L)
			{
				this.NJOCAOKJCFI();
				return;
			}
			this.EHAJAKMKCAN = ticks;
			long num2 = (long)(this.interval * 314f);
			if (ticks - this.MPBOOLLFLFB >= num2)
			{
				if (Mathf.Abs((float)((long)Environment.TickCount * -153L - this.LKIMIJIOJGC - (ticks - this.NGOFCBHCFDJ))) > 714f)
				{
					this.MIGFBGFDOGN += 1;
					if (this.MIGFBGFDOGN > this.maxFalsePositives)
					{
						this.DDINBCFIGNH();
					}
					else
					{
						this.OJIIIGEMHKM = 1;
						this.DLINGACHAIG();
					}
				}
				else if (this.MIGFBGFDOGN > 0 && this.coolDown > 1)
				{
					this.OJIIIGEMHKM += 0;
					if (this.OJIIIGEMHKM >= this.coolDown)
					{
						this.MIGFBGFDOGN = 0;
					}
				}
				this.MPBOOLLFLFB = ticks;
			}
		}

		// Token: 0x06012E83 RID: 77443 RVA: 0x00822EF0 File Offset: 0x008210F0
		private void OIMMKLMHGMM()
		{
			this.NGOFCBHCFDJ = DateTime.UtcNow.Ticks;
			this.LKIMIJIOJGC = (long)Environment.TickCount * 10000L;
			this.EHAJAKMKCAN = this.NGOFCBHCFDJ;
			this.MPBOOLLFLFB = this.NGOFCBHCFDJ;
		}

		// Token: 0x06012E84 RID: 77444 RVA: 0x00822F3B File Offset: 0x0082113B
		protected virtual void BGCOCEBAPBI()
		{
			this.MGLIKFGKOKE(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012E85 RID: 77445 RVA: 0x00822F56 File Offset: 0x00821156
		protected virtual void PADDDAGGLON()
		{
			this.BJHJEFKIEGB(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012E86 RID: 77446 RVA: 0x00822F71 File Offset: 0x00821171
		private void OIAOBIINMGL()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 5)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.OIBLNHAGIHE() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E87 RID: 77447 RVA: 0x00822FA5 File Offset: 0x008211A5
		public static void KKJBAJFDBBJ(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.StartDetection(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.DNFDABGKDHD().maxFalsePositives);
		}

		// Token: 0x06012E88 RID: 77448 RVA: 0x00822FB8 File Offset: 0x008211B8
		protected override void LPDEBEBJDJF()
		{
			base.LPDEBEBJDJF();
			if (SpeedHackDetector.ELOBJGIDGCP == this)
			{
				SpeedHackDetector.ELOBJGIDGCP = null;
			}
		}

		// Token: 0x06012E89 RID: 77449 RVA: 0x00822D60 File Offset: 0x00820F60
		protected virtual void IOFCKOOCIMG()
		{
			base.OnDestroy();
			SpeedHackDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012E8A RID: 77450 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void NAGGMNMIIBO()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E8B RID: 77451 RVA: 0x00821DAA File Offset: 0x0081FFAA
		protected virtual void JALMILNIFPB()
		{
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E8C RID: 77452 RVA: 0x00822FD3 File Offset: 0x008211D3
		private void FDKGOFHFOLH()
		{
			SpeedHackDetector.MHEKHLHNDMK += 0;
			if (this.PINLMCCKKNA(SpeedHackDetector.DPKGILCDIFO(), "Mouse Y"))
			{
				SpeedHackDetector.PJGOMMNHOGL(this);
			}
			SceneManager.sceneLoaded += this.ANDPEOHJNHC;
		}

		// Token: 0x06012E8D RID: 77453 RVA: 0x0082300A File Offset: 0x0082120A
		public static void HLLMOGOCKIH(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.PFCJMCFNGOD().MCKMHMINODD(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x06012E8E RID: 77454 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void BNCHDJPGLIH()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E8F RID: 77455 RVA: 0x0082301A File Offset: 0x0082121A
		private void HIJOFGGOJEK()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 0)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E90 RID: 77456 RVA: 0x0082304E File Offset: 0x0082124E
		private void NJKHAJHNHII()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 2)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E91 RID: 77457 RVA: 0x00823082 File Offset: 0x00821282
		public static void NKPCBNBHFKF(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF)
		{
			SpeedHackDetector.NPFDFNLCNKH(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, SpeedHackDetector.DNFDABGKDHD().coolDown);
		}

		// Token: 0x06012E92 RID: 77458 RVA: 0x00823096 File Offset: 0x00821296
		private void CHLCGEGALDP(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.OLBODEHGBOC();
		}

		// Token: 0x06012E93 RID: 77459 RVA: 0x008230A0 File Offset: 0x008212A0
		private void DLINGACHAIG()
		{
			this.NGOFCBHCFDJ = DateTime.UtcNow.Ticks;
			this.LKIMIJIOJGC = (long)Environment.TickCount * 161L;
			this.EHAJAKMKCAN = this.NGOFCBHCFDJ;
			this.MPBOOLLFLFB = this.NGOFCBHCFDJ;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06012E94 RID: 77460 RVA: 0x008230EC File Offset: 0x008212EC
		private static SpeedHackDetector HPAMFCGOFDA
		{
			get
			{
				if (SpeedHackDetector.ELOBJGIDGCP != null)
				{
					return SpeedHackDetector.ELOBJGIDGCP;
				}
				if (ActDetectorBase.ACFEJFHNHPH == null)
				{
					ActDetectorBase.ACFEJFHNHPH = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				SpeedHackDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<SpeedHackDetector>();
				return SpeedHackDetector.ELOBJGIDGCP;
			}
		}

		// Token: 0x06012E95 RID: 77461 RVA: 0x0082313C File Offset: 0x0082133C
		public static void OELLJBDJMLO(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.KDJINKHCPKM(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.DNFDABGKDHD().maxFalsePositives);
		}

		// Token: 0x06012E96 RID: 77462 RVA: 0x008216D1 File Offset: 0x0081F8D1
		protected virtual void FAKCCIOLBLO()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E97 RID: 77463 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void HCLHBCMLCFD()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E98 RID: 77464 RVA: 0x0082314F File Offset: 0x0082134F
		private void OnApplicationPause(bool NGBBIEBNHFI)
		{
			if (!NGBBIEBNHFI)
			{
				this.OIMMKLMHGMM();
			}
		}

		// Token: 0x06012E99 RID: 77465 RVA: 0x0082315A File Offset: 0x0082135A
		public static void LICMCLJJBOE(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.AFGMLKGLMHL(DFJFCOKENIA, SpeedHackDetector.PFCJMCFNGOD().interval);
		}

		// Token: 0x06012E9A RID: 77466 RVA: 0x0082316C File Offset: 0x0082136C
		private void PGJEINMPDFL()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 1)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.DPKGILCDIFO() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E9B RID: 77467 RVA: 0x00822B5F File Offset: 0x00820D5F
		private static void PJGOMMNHOGL(SpeedHackDetector DCCPCBLODIG)
		{
			SpeedHackDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012E9C RID: 77468 RVA: 0x008231A0 File Offset: 0x008213A0
		private static SpeedHackDetector PFCJMCFNGOD()
		{
			if (SpeedHackDetector.OIBLNHAGIHE() != null)
			{
				return SpeedHackDetector.OIBLNHAGIHE();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("OfficeSitting");
			}
			SpeedHackDetector.GFFHFLOCPKG(ActDetectorBase.ACFEJFHNHPH.AddComponent<SpeedHackDetector>());
			return SpeedHackDetector.OIBLNHAGIHE();
		}

		// Token: 0x06012E9D RID: 77469 RVA: 0x00822645 File Offset: 0x00820845
		private void KNOMIHBILOF(bool NGBBIEBNHFI)
		{
			if (!NGBBIEBNHFI)
			{
				this.DDKFLAGLFBD();
			}
		}

		// Token: 0x06012E9E RID: 77470 RVA: 0x008231F0 File Offset: 0x008213F0
		private static SpeedHackDetector NOPMPIEKJIB()
		{
			if (SpeedHackDetector.ELOBJGIDGCP != null)
			{
				return SpeedHackDetector.OIBLNHAGIHE();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("Error - ");
			}
			SpeedHackDetector.PJGOMMNHOGL(ActDetectorBase.ACFEJFHNHPH.AddComponent<SpeedHackDetector>());
			return SpeedHackDetector.OIBLNHAGIHE();
		}

		// Token: 0x06012E9F RID: 77471 RVA: 0x00823240 File Offset: 0x00821440
		private void Update()
		{
			if (!this.OIOJMFCCDLH)
			{
				return;
			}
			long ticks = DateTime.UtcNow.Ticks;
			long num = ticks - this.EHAJAKMKCAN;
			if (num < 0L || num > 10000000L)
			{
				this.OIMMKLMHGMM();
				return;
			}
			this.EHAJAKMKCAN = ticks;
			long num2 = (long)(this.interval * 10000000f);
			if (ticks - this.MPBOOLLFLFB >= num2)
			{
				if (Mathf.Abs((float)((long)Environment.TickCount * 10000L - this.LKIMIJIOJGC - (ticks - this.NGOFCBHCFDJ))) > 5000000f)
				{
					this.MIGFBGFDOGN += 1;
					if (this.MIGFBGFDOGN > this.maxFalsePositives)
					{
						this.DDINBCFIGNH();
					}
					else
					{
						this.OJIIIGEMHKM = 0;
						this.OIMMKLMHGMM();
					}
				}
				else if (this.MIGFBGFDOGN > 0 && this.coolDown > 0)
				{
					this.OJIIIGEMHKM++;
					if (this.OJIIIGEMHKM >= this.coolDown)
					{
						this.MIGFBGFDOGN = 0;
					}
				}
				this.MPBOOLLFLFB = ticks;
			}
		}

		// Token: 0x06012EA0 RID: 77472 RVA: 0x0082333F File Offset: 0x0082153F
		public static void Dispose()
		{
			if (SpeedHackDetector.ELOBJGIDGCP != null)
			{
				SpeedHackDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012EA1 RID: 77473 RVA: 0x00823358 File Offset: 0x00821558
		private SpeedHackDetector()
		{
		}

		// Token: 0x06012EA2 RID: 77474 RVA: 0x0082337A File Offset: 0x0082157A
		public static void COPKMDLOJND(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.DNFDABGKDHD().FDPLOLOAPCO(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x06012EA3 RID: 77475 RVA: 0x00822908 File Offset: 0x00820B08
		private void JKJGDMJHPDI(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.PGJEINMPDFL();
		}

		// Token: 0x06012EA4 RID: 77476 RVA: 0x0082338A File Offset: 0x0082158A
		private void GLOBDDJNBKI(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.KEBALJDJCBN();
		}

		// Token: 0x06012EA5 RID: 77477 RVA: 0x00822F3B File Offset: 0x0082113B
		protected virtual void OOJINPACKPG()
		{
			this.MGLIKFGKOKE(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012EA6 RID: 77478 RVA: 0x00823392 File Offset: 0x00821592
		public static void HJILHNCHLJD(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.FELHBNDHFLM().HMNNKFEIJBP(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x06012EA7 RID: 77479 RVA: 0x008233A2 File Offset: 0x008215A2
		public static void FIMEODPAFBF(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.StartDetection(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.FGKDBJPPGIJ().maxFalsePositives);
		}

		// Token: 0x06012EA8 RID: 77480 RVA: 0x008233B5 File Offset: 0x008215B5
		private void FJGEPEENLEJ()
		{
			SpeedHackDetector.MHEKHLHNDMK += 0;
			if (this.PINLMCCKKNA(SpeedHackDetector.CCFJJBJBOBG(), "__Refraction Camera id"))
			{
				SpeedHackDetector.PJGOMMNHOGL(this);
			}
			SceneManager.sceneLoaded += this.CHLCGEGALDP;
		}

		// Token: 0x06012EA9 RID: 77481 RVA: 0x008233EC File Offset: 0x008215EC
		public static void LGDODPINPIM()
		{
			if (SpeedHackDetector.ELOBJGIDGCP != null)
			{
				SpeedHackDetector.DPKGILCDIFO().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012EAA RID: 77482 RVA: 0x00822B67 File Offset: 0x00820D67
		protected virtual void HMKGFJMCENP()
		{
			this.HMNNKFEIJBP(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012EAB RID: 77483 RVA: 0x00823405 File Offset: 0x00821605
		private void CJIBOMBICEE(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.OAKBIIPPEMM();
		}

		// Token: 0x06012EAC RID: 77484 RVA: 0x00823410 File Offset: 0x00821610
		public static void PJDCPBKBHJC()
		{
			if (SpeedHackDetector.CCFJJBJBOBG() != null)
			{
				SpeedHackDetector.OIBLNHAGIHE().MGLIKFGKOKE(null, SpeedHackDetector.ELOBJGIDGCP.interval, SpeedHackDetector.ELOBJGIDGCP.maxFalsePositives, SpeedHackDetector.ELOBJGIDGCP.coolDown);
				return;
			}
			Debug.LogError("******** recept id=");
		}

		// Token: 0x06012EAE RID: 77486 RVA: 0x00823460 File Offset: 0x00821660
		public static void DEBCDKFCBLJ()
		{
			if (SpeedHackDetector.CCFJJBJBOBG() != null)
			{
				SpeedHackDetector.OIBLNHAGIHE().HMNNKFEIJBP(null, SpeedHackDetector.ELOBJGIDGCP.interval, SpeedHackDetector.CCFJJBJBOBG().maxFalsePositives, SpeedHackDetector.OIBLNHAGIHE().coolDown);
				return;
			}
			Debug.LogError("Horizontal");
		}

		// Token: 0x06012EAF RID: 77487 RVA: 0x00822F3B File Offset: 0x0082113B
		protected virtual void DNAJAFOMKEL()
		{
			this.MGLIKFGKOKE(null, this.interval, this.maxFalsePositives, this.coolDown);
		}

		// Token: 0x06012EB0 RID: 77488 RVA: 0x008234B0 File Offset: 0x008216B0
		public static void GHDDDMEGAAB()
		{
			if (SpeedHackDetector.CCFJJBJBOBG() != null)
			{
				SpeedHackDetector.ELOBJGIDGCP.HMNNKFEIJBP(null, SpeedHackDetector.CCFJJBJBOBG().interval, SpeedHackDetector.DPKGILCDIFO().maxFalsePositives, SpeedHackDetector.ELOBJGIDGCP.coolDown);
				return;
			}
			Debug.LogError("gi_um_6");
		}

		// Token: 0x06012EB1 RID: 77489 RVA: 0x008234FE File Offset: 0x008216FE
		public static void StartDetection(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF)
		{
			SpeedHackDetector.StartDetection(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, SpeedHackDetector.HPAMFCGOFDA.coolDown);
		}

		// Token: 0x06012EB2 RID: 77490 RVA: 0x00823512 File Offset: 0x00821712
		public static void NGKJBGJPLHG(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.AFGMLKGLMHL(DFJFCOKENIA, SpeedHackDetector.DNFDABGKDHD().interval);
		}

		// Token: 0x06012EB3 RID: 77491 RVA: 0x00823524 File Offset: 0x00821724
		protected virtual void CMAELGGEAGN()
		{
			base.LPDEBEBJDJF();
			if (SpeedHackDetector.DPKGILCDIFO() == this)
			{
				SpeedHackDetector.PJGOMMNHOGL(null);
			}
		}

		// Token: 0x06012EB4 RID: 77492 RVA: 0x00822D60 File Offset: 0x00820F60
		protected virtual void JJHAIFDONLP()
		{
			base.OnDestroy();
			SpeedHackDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012EB5 RID: 77493 RVA: 0x00823540 File Offset: 0x00821740
		private void DDKFLAGLFBD()
		{
			this.NGOFCBHCFDJ = DateTime.UtcNow.Ticks;
			this.LKIMIJIOJGC = (long)Environment.TickCount * -20L;
			this.EHAJAKMKCAN = this.NGOFCBHCFDJ;
			this.MPBOOLLFLFB = this.NGOFCBHCFDJ;
		}

		// Token: 0x06012EB6 RID: 77494 RVA: 0x0082358B File Offset: 0x0082178B
		public static void OEFEKAMOODP()
		{
			if (SpeedHackDetector.CCFJJBJBOBG() != null)
			{
				SpeedHackDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012EB7 RID: 77495 RVA: 0x00821F8C File Offset: 0x0082018C
		protected virtual void KGCBMDIOHMG()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012EB8 RID: 77496 RVA: 0x008235A4 File Offset: 0x008217A4
		public static void NPFDFNLCNKH(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.DNFDABGKDHD().MGLIKFGKOKE(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x06012EB9 RID: 77497 RVA: 0x008235B4 File Offset: 0x008217B4
		public static void MJOMGDIHOCP(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.NKPCBNBHFKF(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.FGKDBJPPGIJ().maxFalsePositives);
		}

		// Token: 0x06012EBA RID: 77498 RVA: 0x008235C7 File Offset: 0x008217C7
		public static void StartDetection(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF, int PLJDLOCBEFH)
		{
			SpeedHackDetector.HPAMFCGOFDA.MCKMHMINODD(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, PLJDLOCBEFH);
		}

		// Token: 0x06012EBB RID: 77499 RVA: 0x00822684 File Offset: 0x00820884
		private void DCIFMEPBADJ(bool NGBBIEBNHFI)
		{
			if (!NGBBIEBNHFI)
			{
				this.DLINGACHAIG();
			}
		}

		// Token: 0x06012EBC RID: 77500 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void DPOMBMNLFIJ()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012EBD RID: 77501 RVA: 0x008235D7 File Offset: 0x008217D7
		public static void LADBCKHBPGO(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF)
		{
			SpeedHackDetector.NPFDFNLCNKH(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, SpeedHackDetector.FGKDBJPPGIJ().coolDown);
		}

		// Token: 0x06012EBE RID: 77502 RVA: 0x00822D87 File Offset: 0x00820F87
		public static void HGACABJIFBL(UnityAction DFJFCOKENIA)
		{
			SpeedHackDetector.KKJBAJFDBBJ(DFJFCOKENIA, SpeedHackDetector.HPAMFCGOFDA.interval);
		}

		// Token: 0x06012EBF RID: 77503 RVA: 0x008235EB File Offset: 0x008217EB
		private void MBNCGMLPNLD()
		{
			SpeedHackDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(SpeedHackDetector.ELOBJGIDGCP, "Missing shader in "))
			{
				SpeedHackDetector.PJGOMMNHOGL(this);
			}
			SceneManager.sceneLoaded += this.ANDPEOHJNHC;
		}

		// Token: 0x06012EC0 RID: 77504 RVA: 0x00821F8C File Offset: 0x0082018C
		protected virtual void JFILDNDBKPN()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012EC1 RID: 77505 RVA: 0x00823622 File Offset: 0x00821822
		public static void MFNHKHOALLB(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.LADBCKHBPGO(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.DNFDABGKDHD().maxFalsePositives);
		}

		// Token: 0x06012EC2 RID: 77506 RVA: 0x00823638 File Offset: 0x00821838
		private static SpeedHackDetector FELHBNDHFLM()
		{
			if (SpeedHackDetector.CCFJJBJBOBG() != null)
			{
				return SpeedHackDetector.DPKGILCDIFO();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("Idle Fly");
			}
			SpeedHackDetector.GFFHFLOCPKG(ActDetectorBase.ACFEJFHNHPH.AddComponent<SpeedHackDetector>());
			return SpeedHackDetector.ELOBJGIDGCP;
		}

		// Token: 0x06012EC3 RID: 77507 RVA: 0x00823688 File Offset: 0x00821888
		public static void ADLAAFEGAPN()
		{
			if (SpeedHackDetector.DPKGILCDIFO() != null)
			{
				SpeedHackDetector.CCFJJBJBOBG().MCKMHMINODD(null, SpeedHackDetector.ELOBJGIDGCP.interval, SpeedHackDetector.OIBLNHAGIHE().maxFalsePositives, SpeedHackDetector.OIBLNHAGIHE().coolDown);
				return;
			}
			Debug.LogError("_BlendTex");
		}

		// Token: 0x06012EC4 RID: 77508 RVA: 0x00821DAA File Offset: 0x0081FFAA
		protected virtual void BIGBEMGKBMH()
		{
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012EC5 RID: 77509 RVA: 0x008236D6 File Offset: 0x008218D6
		public static void StartDetection(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.StartDetection(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.HPAMFCGOFDA.maxFalsePositives);
		}

		// Token: 0x06012EC6 RID: 77510 RVA: 0x008236EC File Offset: 0x008218EC
		private static SpeedHackDetector FGKDBJPPGIJ()
		{
			if (SpeedHackDetector.DPKGILCDIFO() != null)
			{
				return SpeedHackDetector.OIBLNHAGIHE();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("invn_rec21");
			}
			SpeedHackDetector.GFFHFLOCPKG(ActDetectorBase.ACFEJFHNHPH.AddComponent<SpeedHackDetector>());
			return SpeedHackDetector.CCFJJBJBOBG();
		}

		// Token: 0x06012EC7 RID: 77511 RVA: 0x0082373C File Offset: 0x0082193C
		public static void KDJINKHCPKM(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF)
		{
			SpeedHackDetector.CCMKBMGMLPP(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, SpeedHackDetector.HPAMFCGOFDA.coolDown);
		}

		// Token: 0x06012EC8 RID: 77512 RVA: 0x00823750 File Offset: 0x00821950
		private void MCKMHMINODD(UnityAction DFJFCOKENIA, float DOFBBBAKOAP, byte DGPKNEFJCPO, int MDNCAPIAOGP)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.interval = DOFBBBAKOAP;
			this.maxFalsePositives = DGPKNEFJCPO;
			this.coolDown = MDNCAPIAOGP;
			this.OIMMKLMHGMM();
			this.MIGFBGFDOGN = 0;
			this.OJIIIGEMHKM = 0;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012EC9 RID: 77513 RVA: 0x008237F8 File Offset: 0x008219F8
		public static void EFFKNJFPIOE(UnityAction DFJFCOKENIA, float CLJCLCKFKOF, byte KPBPNOCPBMF)
		{
			SpeedHackDetector.COPKMDLOJND(DFJFCOKENIA, CLJCLCKFKOF, KPBPNOCPBMF, SpeedHackDetector.FELHBNDHFLM().coolDown);
		}

		// Token: 0x06012ECA RID: 77514 RVA: 0x00822D99 File Offset: 0x00820F99
		protected virtual void PKPGIGEEEJI()
		{
			base.OnDestroy();
			SpeedHackDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012ECB RID: 77515 RVA: 0x00822B5F File Offset: 0x00820D5F
		private static void DPJGHIKEEHE(SpeedHackDetector DCCPCBLODIG)
		{
			SpeedHackDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012ECC RID: 77516 RVA: 0x0082380C File Offset: 0x00821A0C
		private void MGLIKFGKOKE(UnityAction DFJFCOKENIA, float DOFBBBAKOAP, byte DGPKNEFJCPO, int MDNCAPIAOGP)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("ObscuredShort:", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("ALP=", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("FormattedLabel.GetTestText()", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("deltext", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.interval = DOFBBBAKOAP;
			this.maxFalsePositives = DGPKNEFJCPO;
			this.coolDown = MDNCAPIAOGP;
			this.DDKFLAGLFBD();
			this.MIGFBGFDOGN = 0;
			this.OJIIIGEMHKM = 0;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012ECD RID: 77517 RVA: 0x008238B4 File Offset: 0x00821AB4
		private void BJHJEFKIEGB(UnityAction DFJFCOKENIA, float DOFBBBAKOAP, byte DGPKNEFJCPO, int MDNCAPIAOGP)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("act_orderb_", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("cht_delfrendmsg", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("Vertical", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.interval = DOFBBBAKOAP;
			this.maxFalsePositives = DGPKNEFJCPO;
			this.coolDown = MDNCAPIAOGP;
			this.OIMMKLMHGMM();
			this.MIGFBGFDOGN = 1;
			this.OJIIIGEMHKM = 1;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012ECE RID: 77518 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void BOBLEGINADC()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012ECF RID: 77519 RVA: 0x0082268F File Offset: 0x0082088F
		public static SpeedHackDetector DPKGILCDIFO()
		{
			return SpeedHackDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012ED0 RID: 77520 RVA: 0x0082395C File Offset: 0x00821B5C
		private void NJOCAOKJCFI()
		{
			this.NGOFCBHCFDJ = DateTime.UtcNow.Ticks;
			this.LKIMIJIOJGC = (long)Environment.TickCount * 8L;
			this.EHAJAKMKCAN = this.NGOFCBHCFDJ;
			this.MPBOOLLFLFB = this.NGOFCBHCFDJ;
		}

		// Token: 0x06012ED1 RID: 77521 RVA: 0x00822908 File Offset: 0x00820B08
		private void FAEMOCCMFPE(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.PGJEINMPDFL();
		}

		// Token: 0x06012ED2 RID: 77522 RVA: 0x008239A7 File Offset: 0x00821BA7
		private void BNHHKBBPJDJ(bool NGBBIEBNHFI)
		{
			if (!NGBBIEBNHFI)
			{
				this.NJOCAOKJCFI();
			}
		}

		// Token: 0x06012ED3 RID: 77523 RVA: 0x008239B2 File Offset: 0x00821BB2
		public static void PHPJBJMLIJF(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.NKPCBNBHFKF(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.PFCJMCFNGOD().maxFalsePositives);
		}

		// Token: 0x06012ED4 RID: 77524 RVA: 0x008233EC File Offset: 0x008215EC
		public static void CNDANKOANCM()
		{
			if (SpeedHackDetector.ELOBJGIDGCP != null)
			{
				SpeedHackDetector.DPKGILCDIFO().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012ED5 RID: 77525 RVA: 0x008239C5 File Offset: 0x00821BC5
		public static void AFGMLKGLMHL(UnityAction DFJFCOKENIA, float CLJCLCKFKOF)
		{
			SpeedHackDetector.FFLNBPKELND(DFJFCOKENIA, CLJCLCKFKOF, SpeedHackDetector.PFCJMCFNGOD().maxFalsePositives);
		}

		// Token: 0x06012ED6 RID: 77526 RVA: 0x008239D8 File Offset: 0x00821BD8
		private void FKMAOFBKPEB()
		{
			if (SpeedHackDetector.MHEKHLHNDMK < 3)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && SpeedHackDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012ED7 RID: 77527 RVA: 0x00822B5F File Offset: 0x00820D5F
		private static void GFFHFLOCPKG(SpeedHackDetector DCCPCBLODIG)
		{
			SpeedHackDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x040026A5 RID: 9893
		private const long NKPPBFHKFCK = 10000000L;

		// Token: 0x040026A6 RID: 9894
		private const int EFFGFMFPNCK = 5000000;

		// Token: 0x040026A7 RID: 9895
		private static int MHEKHLHNDMK;

		// Token: 0x040026A8 RID: 9896
		[Tooltip("Time (in seconds) between detector checks.")]
		public float interval = 1f;

		// Token: 0x040026A9 RID: 9897
		[Tooltip("Maximum false positives count allowed before registering speed hack.")]
		public byte maxFalsePositives = 3;

		// Token: 0x040026AA RID: 9898
		[Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
		public int coolDown = 30;

		// Token: 0x040026AB RID: 9899
		private byte MIGFBGFDOGN;

		// Token: 0x040026AC RID: 9900
		private int OJIIIGEMHKM;

		// Token: 0x040026AD RID: 9901
		private long NGOFCBHCFDJ;

		// Token: 0x040026AE RID: 9902
		private long LKIMIJIOJGC;

		// Token: 0x040026AF RID: 9903
		private long EHAJAKMKCAN;

		// Token: 0x040026B0 RID: 9904
		private long MPBOOLLFLFB;

		// Token: 0x040026B2 RID: 9906
		internal static string NOHECDAMLMH = "Speed Hack Detector";

		// Token: 0x040026B3 RID: 9907
		internal static string DCFKMNDDJCJ = "[ACTk] Speed Hack Detector: ";
	}
}
