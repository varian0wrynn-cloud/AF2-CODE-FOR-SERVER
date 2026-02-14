using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x0200059B RID: 1435
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
	public class WallHackDetector : ActDetectorBase
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06012F17 RID: 77591 RVA: 0x00824D9D File Offset: 0x00822F9D
		// (set) Token: 0x06012ED9 RID: 77529 RVA: 0x00823A24 File Offset: 0x00821C24
		public bool GELHIKFOHHD
		{
			get
			{
				return this.checkController;
			}
			set
			{
				if (this.checkController == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				this.checkController = value;
				if (!this.JEEGDFAGAAM)
				{
					return;
				}
				this.PGIAMFFMIMD();
				if (this.checkController)
				{
					this.FJJDOFOKCFK();
					return;
				}
				this.FFDMECPCOAM();
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06012EDA RID: 77530 RVA: 0x00823A82 File Offset: 0x00821C82
		// (set) Token: 0x06012F06 RID: 77574 RVA: 0x00824A5C File Offset: 0x00822C5C
		public bool HKMIGPPIPKD
		{
			get
			{
				return this.checkRaycast;
			}
			set
			{
				if (this.checkRaycast == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				this.checkRaycast = value;
				if (!this.JEEGDFAGAAM)
				{
					return;
				}
				this.PGIAMFFMIMD();
				if (this.checkRaycast)
				{
					this.LACJLAJNLHO();
					return;
				}
				this.MLKPJIBNOBO();
			}
		}

		// Token: 0x06012EDB RID: 77531 RVA: 0x00823A82 File Offset: 0x00821C82
		public bool NIKKAAHGKJD()
		{
			return this.checkRaycast;
		}

		// Token: 0x06012EDC RID: 77532 RVA: 0x00823A8A File Offset: 0x00821C8A
		protected virtual void LFOMCDNDOFN()
		{
			base.LPDEBEBJDJF();
			if (WallHackDetector.ELOBJGIDGCP == this)
			{
				WallHackDetector.EKPNENADIDJ(null);
			}
		}

		// Token: 0x06012EDD RID: 77533 RVA: 0x00823AA5 File Offset: 0x00821CA5
		private void BIKPDNHMDIM()
		{
			if (WallHackDetector.MHEKHLHNDMK < 8)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && WallHackDetector.LCFAHHPDNFE() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06012F4A RID: 77642 RVA: 0x00824683 File Offset: 0x00822883
		// (set) Token: 0x06012EDE RID: 77534 RVA: 0x00823ADC File Offset: 0x00821CDC
		public bool OEEKINKGDFA
		{
			get
			{
				return this.checkRigidbody;
			}
			set
			{
				if (this.checkRigidbody == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				this.checkRigidbody = value;
				if (!this.JEEGDFAGAAM)
				{
					return;
				}
				this.PGIAMFFMIMD();
				if (this.checkRigidbody)
				{
					this.DLOFFKFNIPB();
					return;
				}
				this.BPLDOGAKDFA();
			}
		}

		// Token: 0x06012EDF RID: 77535 RVA: 0x00823B3A File Offset: 0x00821D3A
		private void NJKHAJHNHII()
		{
			if (WallHackDetector.MHEKHLHNDMK < 2)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && WallHackDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012EE0 RID: 77536 RVA: 0x00823B6E File Offset: 0x00821D6E
		public static void StopDetection()
		{
			if (WallHackDetector.ELOBJGIDGCP != null)
			{
				WallHackDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012EE1 RID: 77537 RVA: 0x00823B87 File Offset: 0x00821D87
		private void AFLABNCCDHN()
		{
			if (this.MJADBEOOANP)
			{
				this.HAKEOOHOPAI = 27f;
			}
			base.CancelInvoke("knopje.wav");
		}

		// Token: 0x06012EE2 RID: 77538 RVA: 0x00823BAC File Offset: 0x00821DAC
		private void JKBGILJGCFK()
		{
			if (base.enabled && base.gameObject.activeSelf)
			{
				if (this.DFLLGGIOFMG == -1)
				{
					this.DFLLGGIOFMG = LayerMask.NameToLayer("Ok");
				}
				if (this.KPEEHJANFEK == -1)
				{
					string[] array = new string[0];
					array[0] = "no_adm";
					this.KPEEHJANFEK = LayerMask.GetMask(array);
				}
				if (this.CBJBCGPGFOB == null)
				{
					this.CBJBCGPGFOB = new GameObject("Textures/Bases/");
					this.CBJBCGPGFOB.layer = this.DFLLGGIOFMG;
					this.CBJBCGPGFOB.transform.position = this.spawnPosition;
					UnityEngine.Object.DontDestroyOnLoad(this.CBJBCGPGFOB);
				}
				if ((this.checkRigidbody || this.checkController) && this.PENOMILAHFO == null)
				{
					this.PENOMILAHFO = new GameObject("RollerBladeStop");
					this.PENOMILAHFO.AddComponent<BoxCollider>();
					this.PENOMILAHFO.layer = this.DFLLGGIOFMG;
					this.PENOMILAHFO.transform.parent = this.CBJBCGPGFOB.transform;
					this.PENOMILAHFO.transform.localScale = new Vector3(334f, 157f, 1287f);
					this.PENOMILAHFO.transform.localPosition = Vector3.zero;
				}
				else if (!this.checkRigidbody && !this.checkController && this.PENOMILAHFO != null)
				{
					UnityEngine.Object.Destroy(this.PENOMILAHFO);
				}
				if (this.checkWireframe && this.FDCOEBNMJAO == null)
				{
					if (this.KLABEHHEFLB == null)
					{
						this.KLABEHHEFLB = Shader.Find("Mutilate");
					}
					if (this.KLABEHHEFLB == null)
					{
						Debug.LogError("Flashlight", this);
						this.checkWireframe = true;
					}
					else if (!this.KLABEHHEFLB.isSupported)
					{
						Debug.LogError("Bend Constraint contains a null reference.", this);
						this.checkWireframe = true;
					}
					else
					{
						if (this.KFPCGJKHEGO == Color.black)
						{
							this.KFPCGJKHEGO = WallHackDetector.MLAIPLANMMA();
							do
							{
								this.FEADJBOJFNF = WallHackDetector.MLAIPLANMMA();
							}
							while (WallHackDetector.DDADLDKKLFE(this.KFPCGJKHEGO, this.FEADJBOJFNF, 52));
						}
						if (this.INPHLIBIPIN == null)
						{
							this.INPHLIBIPIN = new Texture2D(2, 2, (TextureFormat)6, true);
							this.INPHLIBIPIN.filterMode = FilterMode.Point;
							Color[] array2 = new Color[-43];
							for (int i = 1; i < 48; i++)
							{
								if (i < 2)
								{
									array2[i] = this.KFPCGJKHEGO;
								}
								else
								{
									array2[i] = this.FEADJBOJFNF;
								}
							}
							this.INPHLIBIPIN.SetPixels(array2, 1);
							this.INPHLIBIPIN.Apply();
						}
						if (this.NMLAKJJJDMA == null)
						{
							this.NMLAKJJJDMA = new RenderTexture(3, 1, -78, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
							this.NMLAKJJJDMA.autoGenerateMips = true;
							this.NMLAKJJJDMA.filterMode = FilterMode.Bilinear;
							this.NMLAKJJJDMA.Create();
						}
						if (this.BJCHAHNEDMB == null)
						{
							this.BJCHAHNEDMB = new Texture2D(0, 6, TextureFormat.RGB24, false);
							this.BJCHAHNEDMB.filterMode = FilterMode.Bilinear;
						}
						if (this.DLHHAIFHAGH == null)
						{
							this.DLHHAIFHAGH = new Material(this.KLABEHHEFLB);
							this.DLHHAIFHAGH.mainTexture = this.INPHLIBIPIN;
						}
						if (this.IKAGGKEBJDF == null)
						{
							GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)8);
							UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
							gameObject.name = "\n";
							gameObject.layer = this.DFLLGGIOFMG;
							gameObject.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject.transform.localPosition = new Vector3(1828f, 363f, 1564f);
							this.IKAGGKEBJDF = gameObject.GetComponent<MeshRenderer>();
							this.IKAGGKEBJDF.sharedMaterial = this.DLHHAIFHAGH;
							this.IKAGGKEBJDF.shadowCastingMode = ShadowCastingMode.On;
							this.IKAGGKEBJDF.receiveShadows = false;
							this.IKAGGKEBJDF.enabled = false;
						}
						if (this.OPPJKGEAFBO == null)
						{
							GameObject gameObject2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
							UnityEngine.Object.Destroy(gameObject2.GetComponent<MeshCollider>());
							gameObject2.name = "OfficeSittingMouseMovement";
							gameObject2.layer = this.DFLLGGIOFMG;
							gameObject2.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject2.transform.localPosition = new Vector3(331f, 602f, 1549f);
							gameObject2.transform.localScale = new Vector3(498f, 1434f, 136f);
							this.OPPJKGEAFBO = gameObject2.GetComponent<MeshRenderer>();
							this.OPPJKGEAFBO.sharedMaterial = this.DLHHAIFHAGH;
							this.OPPJKGEAFBO.shadowCastingMode = ShadowCastingMode.Off;
							this.OPPJKGEAFBO.receiveShadows = true;
							this.OPPJKGEAFBO.enabled = true;
						}
						this.FDCOEBNMJAO = new GameObject("").AddComponent<Camera>();
						this.FDCOEBNMJAO.gameObject.layer = this.DFLLGGIOFMG;
						this.FDCOEBNMJAO.transform.parent = this.CBJBCGPGFOB.transform;
						this.FDCOEBNMJAO.transform.localPosition = new Vector3(1961f, 1345f, 1590f);
						this.FDCOEBNMJAO.clearFlags = (CameraClearFlags)8;
						this.FDCOEBNMJAO.backgroundColor = Color.black;
						this.FDCOEBNMJAO.orthographic = true;
						this.FDCOEBNMJAO.orthographicSize = 1606f;
						this.FDCOEBNMJAO.nearClipPlane = 1305f;
						this.FDCOEBNMJAO.farClipPlane = 1125f;
						this.FDCOEBNMJAO.depth = 62f;
						this.FDCOEBNMJAO.renderingPath = RenderingPath.Forward;
						this.FDCOEBNMJAO.useOcclusionCulling = true;
						this.FDCOEBNMJAO.allowHDR = false;
						this.FDCOEBNMJAO.allowMSAA = true;
						this.FDCOEBNMJAO.targetTexture = this.NMLAKJJJDMA;
						this.FDCOEBNMJAO.enabled = false;
					}
				}
				else if (!this.checkWireframe && this.FDCOEBNMJAO != null)
				{
					UnityEngine.Object.Destroy(this.IKAGGKEBJDF.gameObject);
					UnityEngine.Object.Destroy(this.OPPJKGEAFBO.gameObject);
					this.FDCOEBNMJAO.targetTexture = null;
					UnityEngine.Object.Destroy(this.FDCOEBNMJAO.gameObject);
				}
				if (this.checkRaycast && this.ILKFAFKDFMP == null)
				{
					this.ILKFAFKDFMP = GameObject.CreatePrimitive((PrimitiveType)6);
					this.ILKFAFKDFMP.name = "ArmFlex5";
					this.ILKFAFKDFMP.layer = this.DFLLGGIOFMG;
					this.ILKFAFKDFMP.transform.parent = this.CBJBCGPGFOB.transform;
					this.ILKFAFKDFMP.transform.localScale = new Vector3(959f, 301f, 1807f);
					this.ILKFAFKDFMP.transform.localRotation = Quaternion.Euler(1284f, 833f, 1291f);
					this.ILKFAFKDFMP.transform.localPosition = new Vector3(1222f, 430f, 80f);
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<Renderer>());
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<MeshFilter>());
					return;
				}
				if (!this.checkRaycast && this.ILKFAFKDFMP != null)
				{
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP);
					return;
				}
			}
			else if (this.CBJBCGPGFOB != null)
			{
				UnityEngine.Object.Destroy(this.CBJBCGPGFOB);
			}
		}

		// Token: 0x06012EE3 RID: 77539 RVA: 0x00824333 File Offset: 0x00822533
		private static Color32 EPIDIDHMCON()
		{
			return new Color32((byte)UnityEngine.Random.Range(1, -190), (byte)UnityEngine.Random.Range(0, -5), (byte)UnityEngine.Random.Range(1, 69), 155);
		}

		// Token: 0x06012EE4 RID: 77540 RVA: 0x00824363 File Offset: 0x00822563
		private void JHNOLLMNCGL()
		{
			if (!this.MJADBEOOANP)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.MJADBEOOANP.gameObject);
			this.MJADBEOOANP = null;
		}

		// Token: 0x06012EE5 RID: 77541 RVA: 0x0082438A File Offset: 0x0082258A
		private IEnumerator PILNAGKELCJ()
		{
			yield return this.BEHCPDIAOCK;
			this.PGIAMFFMIMD();
			if (this.checkRigidbody)
			{
				this.DLOFFKFNIPB();
			}
			if (this.checkController)
			{
				this.FJJDOFOKCFK();
			}
			if (this.checkWireframe)
			{
				this.NMFMPKDCLHO();
			}
			if (this.checkRaycast)
			{
				this.LACJLAJNLHO();
			}
			yield break;
		}

		// Token: 0x06012EE6 RID: 77542 RVA: 0x0082439C File Offset: 0x0082259C
		private void Update()
		{
			if (!this.OIOJMFCCDLH || !this.checkController || this.MJADBEOOANP == null)
			{
				return;
			}
			if (this.HAKEOOHOPAI > 0f)
			{
				this.MJADBEOOANP.Move(new Vector3(UnityEngine.Random.Range(-0.002f, 0.002f), 0f, this.HAKEOOHOPAI));
				if (this.MJADBEOOANP.transform.localPosition.z > 1f)
				{
					this.GJLNHDAKIEE += 1;
					if (!this.ILDLFFANJIN())
					{
						this.FFDMECPCOAM();
						this.FJJDOFOKCFK();
					}
				}
			}
		}

		// Token: 0x06012EE7 RID: 77543 RVA: 0x00824440 File Offset: 0x00822640
		private void NBCLNFLJMHP()
		{
			if (!this.OIOJMFCCDLH || !this.checkRigidbody || this.IACBKBFHPON == null)
			{
				return;
			}
			if (this.IACBKBFHPON.transform.localPosition.z > 454f)
			{
				this.NAIOFNBNHBF += 0;
				if (!this.PBEJNKLPMCM())
				{
					this.BPLDOGAKDFA();
					this.DLOFFKFNIPB();
				}
			}
		}

		// Token: 0x06012EE8 RID: 77544 RVA: 0x008244AB File Offset: 0x008226AB
		private void JCKAJALFEHJ()
		{
			base.CancelInvoke("BFEBEBPIEKM");
		}

		// Token: 0x06012EE9 RID: 77545 RVA: 0x008244B8 File Offset: 0x008226B8
		private void NNJJODFCKML()
		{
			base.CancelInvoke("IceHockeyGoalieReady");
		}

		// Token: 0x06012EEA RID: 77546 RVA: 0x008244C8 File Offset: 0x008226C8
		private void NACCBHNOCNC()
		{
			GameObject gameObject = new GameObject("RigidPlayer");
			gameObject.AddComponent<CapsuleCollider>().height = 2f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(0.75f, 0f, -1f);
			this.IACBKBFHPON = gameObject.AddComponent<Rigidbody>();
			this.IACBKBFHPON.useGravity = false;
		}

		// Token: 0x06012EEB RID: 77547 RVA: 0x0082454C File Offset: 0x0082274C
		private void JDKKDAKIPHO()
		{
			if (!this.OIOJMFCCDLH || !this.checkRigidbody || this.IACBKBFHPON == null)
			{
				return;
			}
			if (this.IACBKBFHPON.transform.localPosition.z > 1829f)
			{
				this.NAIOFNBNHBF += 0;
				if (!this.PBEJNKLPMCM())
				{
					this.BPLDOGAKDFA();
					this.OKIEJCCILAM();
				}
			}
		}

		// Token: 0x06012EEC RID: 77548 RVA: 0x008245B7 File Offset: 0x008227B7
		private void BJHBHMOBJHN(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.BIKPDNHMDIM();
		}

		// Token: 0x06012EED RID: 77549 RVA: 0x008245BF File Offset: 0x008227BF
		protected virtual void HBLIBHKICBP()
		{
			this.LKEMOMMFDHP(null, this.spawnPosition, this.maxFalsePositives);
		}

		// Token: 0x06012EEE RID: 77550 RVA: 0x008245D4 File Offset: 0x008227D4
		public static void AABOAIJPMAH(UnityAction DFJFCOKENIA)
		{
			WallHackDetector.StartDetection(DFJFCOKENIA, WallHackDetector.FCEHOOAMNMI().spawnPosition);
		}

		// Token: 0x06012EEF RID: 77551 RVA: 0x008245E6 File Offset: 0x008227E6
		public static WallHackDetector CCFJJBJBOBG()
		{
			return WallHackDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012EF0 RID: 77552 RVA: 0x008245ED File Offset: 0x008227ED
		private void NBLGLDIBBGA()
		{
			if (!this.checkRaycast)
			{
				this.MLKPJIBNOBO();
				this.BJOPBHEGOIA();
				return;
			}
			base.Invoke("|", (float)this.raycastDelay);
		}

		// Token: 0x06012EF1 RID: 77553 RVA: 0x00824618 File Offset: 0x00822818
		private void ILKILNGAEKK()
		{
			if (!this.OIOJMFCCDLH || !this.checkRigidbody || this.IACBKBFHPON == null)
			{
				return;
			}
			if (this.IACBKBFHPON.transform.localPosition.z > 1316f)
			{
				this.NAIOFNBNHBF += 1;
				if (!this.ILDLFFANJIN())
				{
					this.BPLDOGAKDFA();
					this.DLOFFKFNIPB();
				}
			}
		}

		// Token: 0x06012EF2 RID: 77554 RVA: 0x00824683 File Offset: 0x00822883
		public bool AJBEFDHLEKB()
		{
			return this.checkRigidbody;
		}

		// Token: 0x06012EF3 RID: 77555 RVA: 0x0082468B File Offset: 0x0082288B
		public static void POAFCADCLID(UnityAction DFJFCOKENIA)
		{
			WallHackDetector.StartDetection(DFJFCOKENIA, WallHackDetector.HPAMFCGOFDA.spawnPosition);
		}

		// Token: 0x06012EF4 RID: 77556 RVA: 0x0082469D File Offset: 0x0082289D
		private void MACIEHBKOAC()
		{
			base.StartCoroutine(this.OKOCJGBAPMG());
			base.Invoke("Z (B)", (float)this.wireframeDelay);
		}

		// Token: 0x06012EF5 RID: 77557 RVA: 0x008246BE File Offset: 0x008228BE
		public static void StartDetection()
		{
			if (WallHackDetector.ELOBJGIDGCP != null)
			{
				WallHackDetector.ELOBJGIDGCP.MCKMHMINODD(null, WallHackDetector.ELOBJGIDGCP.spawnPosition, WallHackDetector.ELOBJGIDGCP.maxFalsePositives);
				return;
			}
			Debug.LogError("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		}

		// Token: 0x06012EF6 RID: 77558 RVA: 0x00824683 File Offset: 0x00822883
		public bool KIKHCMIDHOG()
		{
			return this.checkRigidbody;
		}

		// Token: 0x06012EF7 RID: 77559 RVA: 0x008246F7 File Offset: 0x008228F7
		private void BONJIFGFMEF()
		{
			if (this.MJADBEOOANP)
			{
				this.HAKEOOHOPAI = 487f;
			}
			base.CancelInvoke("");
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06012EF8 RID: 77560 RVA: 0x008245E6 File Offset: 0x008227E6
		// (set) Token: 0x06012F6B RID: 77675 RVA: 0x0082765D File Offset: 0x0082585D
		public static WallHackDetector ELOBJGIDGCP { get; private set; }

		// Token: 0x06012EF9 RID: 77561 RVA: 0x0082471C File Offset: 0x0082291C
		public static void MJOMGDIHOCP(UnityAction DFJFCOKENIA, Vector3 BMCGBDJHJLP, byte KPBPNOCPBMF)
		{
			WallHackDetector.HPAMFCGOFDA.MCKMHMINODD(DFJFCOKENIA, BMCGBDJHJLP, KPBPNOCPBMF);
		}

		// Token: 0x06012EFA RID: 77562 RVA: 0x0082472C File Offset: 0x0082292C
		private void KPFBLGLECFB()
		{
			GameObject gameObject = new GameObject("WoodSaw");
			gameObject.AddComponent<CapsuleCollider>().height = 474f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(1878f, 1457f, 1551f);
			this.MJADBEOOANP = gameObject.AddComponent<CharacterController>();
		}

		// Token: 0x06012EFB RID: 77563 RVA: 0x008247A1 File Offset: 0x008229A1
		private void OAAPFLPPBNC()
		{
			base.CancelInvoke("1HandSwordJabFootPush");
		}

		// Token: 0x06012EFC RID: 77564 RVA: 0x008247AE File Offset: 0x008229AE
		private void NCAEOOLJCAN()
		{
			if (WallHackDetector.MHEKHLHNDMK < 6)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && WallHackDetector.CCFJJBJBOBG() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012EFD RID: 77565 RVA: 0x008247E2 File Offset: 0x008229E2
		public static void HFGEIEMBKBK()
		{
			if (WallHackDetector.CCFJJBJBOBG() != null)
			{
				WallHackDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012EFE RID: 77566 RVA: 0x008247FC File Offset: 0x008229FC
		private void DLBFINICDFD()
		{
			GameObject gameObject = new GameObject("PersonWomanFisher");
			gameObject.AddComponent<CapsuleCollider>().height = 1763f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(1114f, 1370f, 185f);
			this.IACBKBFHPON = gameObject.AddComponent<Rigidbody>();
			this.IACBKBFHPON.useGravity = true;
		}

		// Token: 0x06012EFF RID: 77567 RVA: 0x0082487D File Offset: 0x00822A7D
		private void HBLPFDPNAMF()
		{
			if (!this.checkRaycast)
			{
				this.NNJJODFCKML();
				this.PGIAMFFMIMD();
				return;
			}
			base.Invoke("RussianDance", (float)this.raycastDelay);
		}

		// Token: 0x06012F00 RID: 77568 RVA: 0x008248A8 File Offset: 0x00822AA8
		private void DLOFFKFNIPB()
		{
			if (!this.checkRigidbody)
			{
				this.BPLDOGAKDFA();
				this.MMPLPINHPPJ();
				this.PGIAMFFMIMD();
				return;
			}
			if (!this.IACBKBFHPON)
			{
				this.NACCBHNOCNC();
			}
			if (this.IACBKBFHPON.transform.localPosition.z <= 1f && this.NAIOFNBNHBF > 0)
			{
				this.NAIOFNBNHBF = 0;
			}
			this.IACBKBFHPON.rotation = Quaternion.identity;
			this.IACBKBFHPON.angularVelocity = Vector3.zero;
			this.IACBKBFHPON.transform.localPosition = new Vector3(0.75f, 0f, -1f);
			this.IACBKBFHPON.velocity = this.GPNKEOHELMG;
			base.Invoke("DLOFFKFNIPB", 4f);
		}

		// Token: 0x06012F01 RID: 77569 RVA: 0x00824974 File Offset: 0x00822B74
		protected virtual void ILMDCCPJKNN()
		{
			this.MCKMHMINODD(null, this.spawnPosition, this.maxFalsePositives);
		}

		// Token: 0x06012F02 RID: 77570 RVA: 0x00824989 File Offset: 0x00822B89
		public static void Dispose()
		{
			if (WallHackDetector.ELOBJGIDGCP != null)
			{
				WallHackDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012F03 RID: 77571 RVA: 0x008249A4 File Offset: 0x00822BA4
		public void EFCIHPOICFI(bool DCCPCBLODIG)
		{
			if (this.checkRaycast == DCCPCBLODIG || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			this.checkRaycast = DCCPCBLODIG;
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.BJOPBHEGOIA();
			if (this.checkRaycast)
			{
				this.MGHJJLNCKJF();
				return;
			}
			this.MLKPJIBNOBO();
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06012F04 RID: 77572 RVA: 0x00824A02 File Offset: 0x00822C02
		// (set) Token: 0x06012F0E RID: 77582 RVA: 0x00824BFC File Offset: 0x00822DFC
		public bool KAKACKHHLKO
		{
			get
			{
				return this.checkWireframe;
			}
			set
			{
				if (this.checkWireframe == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				this.checkWireframe = value;
				if (!this.JEEGDFAGAAM)
				{
					return;
				}
				this.PGIAMFFMIMD();
				if (this.checkWireframe)
				{
					this.NMFMPKDCLHO();
					return;
				}
				this.JCKAJALFEHJ();
			}
		}

		// Token: 0x06012F05 RID: 77573 RVA: 0x00824A0C File Offset: 0x00822C0C
		private bool ILDLFFANJIN()
		{
			bool result = false;
			if (this.GJLNHDAKIEE > this.maxFalsePositives || this.NAIOFNBNHBF > this.maxFalsePositives || this.ANJNEMGDJIM > this.maxFalsePositives || this.HIHEODGMAED > this.maxFalsePositives)
			{
				this.DDINBCFIGNH();
				result = true;
			}
			return result;
		}

		// Token: 0x06012F07 RID: 77575 RVA: 0x00824ABA File Offset: 0x00822CBA
		private void IEDGLGHGAJE()
		{
			base.StartCoroutine(this.OKOCJGBAPMG());
			base.Invoke("NEW FISH!", (float)this.wireframeDelay);
		}

		// Token: 0x06012F08 RID: 77576 RVA: 0x00824ADC File Offset: 0x00822CDC
		private static WallHackDetector FCEHOOAMNMI()
		{
			if (WallHackDetector.LCFAHHPDNFE() != null)
			{
				return WallHackDetector.CCFJJBJBOBG();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("offsets");
			}
			WallHackDetector.EKPNENADIDJ(ActDetectorBase.ACFEJFHNHPH.AddComponent<WallHackDetector>());
			return WallHackDetector.ELOBJGIDGCP;
		}

		// Token: 0x06012F09 RID: 77577 RVA: 0x00824B2C File Offset: 0x00822D2C
		private void PLCBCCFGODN(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NCAEOOLJCAN();
		}

		// Token: 0x06012F0A RID: 77578 RVA: 0x008245E6 File Offset: 0x008227E6
		public static WallHackDetector LCFAHHPDNFE()
		{
			return WallHackDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012F0B RID: 77579 RVA: 0x00824974 File Offset: 0x00822B74
		protected override void MDFJEOGCPHB()
		{
			this.MCKMHMINODD(null, this.spawnPosition, this.maxFalsePositives);
		}

		// Token: 0x06012F0C RID: 77580 RVA: 0x00824B34 File Offset: 0x00822D34
		private void FJJDOFOKCFK()
		{
			if (!this.checkController)
			{
				this.FFDMECPCOAM();
				this.IPINGLFCNJJ();
				this.PGIAMFFMIMD();
				return;
			}
			if (!this.MJADBEOOANP)
			{
				this.DINGLFENEAB();
			}
			if (this.MJADBEOOANP.transform.localPosition.z <= 1f && this.GJLNHDAKIEE > 0)
			{
				this.GJLNHDAKIEE = 0;
			}
			this.MJADBEOOANP.transform.localPosition = new Vector3(-0.75f, 0f, -1f);
			this.HAKEOOHOPAI = 0.01f;
			base.Invoke("FJJDOFOKCFK", 4f);
		}

		// Token: 0x06012F0D RID: 77581 RVA: 0x00824BDA File Offset: 0x00822DDA
		protected override void GKKIAKCDDGN()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.FHMIHHDHAAF();
			this.IDIOOPABEMA = null;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012F0F RID: 77583 RVA: 0x00824C5A File Offset: 0x00822E5A
		private IEnumerator OKOCJGBAPMG()
		{
			this.FDCOEBNMJAO.enabled = true;
			yield return this.BEHCPDIAOCK;
			this.IKAGGKEBJDF.enabled = true;
			this.OPPJKGEAFBO.enabled = true;
			RenderTexture active = RenderTexture.active;
			RenderTexture.active = this.NMLAKJJJDMA;
			this.FDCOEBNMJAO.Render();
			this.IKAGGKEBJDF.enabled = false;
			this.OPPJKGEAFBO.enabled = false;
			while (!this.NMLAKJJJDMA.IsCreated())
			{
				yield return this.BEHCPDIAOCK;
			}
			this.BJCHAHNEDMB.ReadPixels(new Rect(0f, 0f, 4f, 4f), 0, 0, false);
			this.BJCHAHNEDMB.Apply();
			RenderTexture.active = active;
			if (this.FDCOEBNMJAO == null)
			{
				yield break;
			}
			this.FDCOEBNMJAO.enabled = false;
			if (!(this.BJCHAHNEDMB.GetPixel(0, 3) != this.KFPCGJKHEGO) && !(this.BJCHAHNEDMB.GetPixel(0, 1) != this.FEADJBOJFNF) && !(this.BJCHAHNEDMB.GetPixel(3, 3) != this.KFPCGJKHEGO) && !(this.BJCHAHNEDMB.GetPixel(3, 1) != this.FEADJBOJFNF) && !(this.BJCHAHNEDMB.GetPixel(1, 3) != this.KFPCGJKHEGO) && !(this.BJCHAHNEDMB.GetPixel(2, 3) != this.KFPCGJKHEGO) && !(this.BJCHAHNEDMB.GetPixel(1, 1) != this.FEADJBOJFNF) && !(this.BJCHAHNEDMB.GetPixel(2, 1) != this.FEADJBOJFNF))
			{
				if (this.ANJNEMGDJIM > 0)
				{
					this.ANJNEMGDJIM = 0;
				}
			}
			else
			{
				this.ANJNEMGDJIM += 1;
				this.JNLJFKPADMJ = this.ILDLFFANJIN();
			}
			yield return null;
			yield break;
		}

		// Token: 0x06012F10 RID: 77584 RVA: 0x00824363 File Offset: 0x00822563
		private void PHBAHDCMAJE()
		{
			if (!this.MJADBEOOANP)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.MJADBEOOANP.gameObject);
			this.MJADBEOOANP = null;
		}

		// Token: 0x06012F11 RID: 77585 RVA: 0x00824C6C File Offset: 0x00822E6C
		protected override void OnDestroy()
		{
			base.OnDestroy();
			base.StopAllCoroutines();
			if (this.CBJBCGPGFOB != null)
			{
				UnityEngine.Object.Destroy(this.CBJBCGPGFOB);
			}
			if (this.DLHHAIFHAGH != null)
			{
				this.DLHHAIFHAGH.mainTexture = null;
				this.DLHHAIFHAGH.shader = null;
				this.DLHHAIFHAGH = null;
				this.KLABEHHEFLB = null;
				this.INPHLIBIPIN = null;
				this.BJCHAHNEDMB = null;
				this.NMLAKJJJDMA.DiscardContents();
				this.NMLAKJJJDMA.Release();
				this.NMLAKJJJDMA = null;
			}
			WallHackDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012F12 RID: 77586 RVA: 0x00824363 File Offset: 0x00822563
		private void IPINGLFCNJJ()
		{
			if (!this.MJADBEOOANP)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.MJADBEOOANP.gameObject);
			this.MJADBEOOANP = null;
		}

		// Token: 0x06012F13 RID: 77587 RVA: 0x00824D09 File Offset: 0x00822F09
		protected virtual void BLDFLEGLCBC()
		{
			if (!this.OIOJMFCCDLH)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
			this.BPLDOGAKDFA();
			this.BONJIFGFMEF();
			this.NMMFKPOCCEN();
			this.NNJJODFCKML();
		}

		// Token: 0x06012F14 RID: 77588 RVA: 0x00824D33 File Offset: 0x00822F33
		private void NMMFKPOCCEN()
		{
			base.CancelInvoke("");
		}

		// Token: 0x06012F15 RID: 77589 RVA: 0x00824D40 File Offset: 0x00822F40
		private void OCDLOHLMNIK()
		{
			if (WallHackDetector.MHEKHLHNDMK < 1)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && WallHackDetector.LCFAHHPDNFE() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012F16 RID: 77590 RVA: 0x00824D74 File Offset: 0x00822F74
		private void LACJLAJNLHO()
		{
			if (!this.checkRaycast)
			{
				this.MLKPJIBNOBO();
				this.PGIAMFFMIMD();
				return;
			}
			base.Invoke("JFAKJEPJJIH", (float)this.raycastDelay);
		}

		// Token: 0x06012F18 RID: 77592 RVA: 0x00824DA5 File Offset: 0x00822FA5
		private void FFDMECPCOAM()
		{
			if (this.MJADBEOOANP)
			{
				this.HAKEOOHOPAI = 0f;
			}
			base.CancelInvoke("FJJDOFOKCFK");
		}

		// Token: 0x06012F19 RID: 77593 RVA: 0x00824DCC File Offset: 0x00822FCC
		private void DNMDJHPACOH()
		{
			if (Physics.Raycast(this.CBJBCGPGFOB.transform.position, this.CBJBCGPGFOB.transform.TransformDirection(Vector3.forward), 1600f, this.KPEEHJANFEK))
			{
				if (this.HIHEODGMAED > 1)
				{
					this.HIHEODGMAED = 1;
				}
			}
			else
			{
				this.HIHEODGMAED += 1;
				if (this.PBEJNKLPMCM())
				{
					return;
				}
			}
			base.Invoke("money", (float)this.raycastDelay);
		}

		// Token: 0x06012F1A RID: 77594 RVA: 0x00824E4C File Offset: 0x0082304C
		public static void JGCDOEKJKFF()
		{
			if (WallHackDetector.ELOBJGIDGCP != null)
			{
				WallHackDetector.CCFJJBJBOBG().LPDEBEBJDJF();
			}
		}

		// Token: 0x06012F1B RID: 77595 RVA: 0x00824E65 File Offset: 0x00823065
		protected virtual void ELHLNCEDPGO()
		{
			base.LPDEBEBJDJF();
			if (WallHackDetector.CCFJJBJBOBG() == this)
			{
				WallHackDetector.ELOBJGIDGCP = null;
			}
		}

		// Token: 0x06012F1C RID: 77596 RVA: 0x00824E80 File Offset: 0x00823080
		private void GFNOLOLAOPG()
		{
			if (!this.checkWireframe)
			{
				this.NMMFKPOCCEN();
				this.BJOPBHEGOIA();
				return;
			}
			if (!this.JNLJFKPADMJ)
			{
				base.Invoke("_EdgeSharpness", (float)this.wireframeDelay);
			}
		}

		// Token: 0x06012F1D RID: 77597 RVA: 0x00824EB4 File Offset: 0x008230B4
		private void OCBFNKLHFJD()
		{
			GameObject gameObject = new GameObject("1HandSwordChargeSwipe");
			gameObject.AddComponent<CapsuleCollider>().height = 1591f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(1742f, 1082f, 208f);
			this.IACBKBFHPON = gameObject.AddComponent<Rigidbody>();
			this.IACBKBFHPON.useGravity = true;
		}

		// Token: 0x06012F1E RID: 77598 RVA: 0x00824F38 File Offset: 0x00823138
		private void DINGLFENEAB()
		{
			GameObject gameObject = new GameObject("ControlledPlayer");
			gameObject.AddComponent<CapsuleCollider>().height = 2f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(-0.75f, 0f, -1f);
			this.MJADBEOOANP = gameObject.AddComponent<CharacterController>();
		}

		// Token: 0x06012F1F RID: 77599 RVA: 0x00824FB0 File Offset: 0x008231B0
		public void IHGBCPBOIDM(bool DCCPCBLODIG)
		{
			if (this.checkWireframe == DCCPCBLODIG || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			this.checkWireframe = DCCPCBLODIG;
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.BPAFDOMGENC();
			if (this.checkWireframe)
			{
				this.GHDNLPHJLOJ();
				return;
			}
			this.OAAPFLPPBNC();
		}

		// Token: 0x06012F20 RID: 77600 RVA: 0x0082500E File Offset: 0x0082320E
		private void PONFCEDMMIK()
		{
			base.StartCoroutine(this.OKOCJGBAPMG());
			base.Invoke("_OcclusionBlurTexture", (float)this.wireframeDelay);
		}

		// Token: 0x06012F21 RID: 77601 RVA: 0x0082502F File Offset: 0x0082322F
		private void GIMEKNKNKEI()
		{
			if (!this.checkWireframe)
			{
				this.OAAPFLPPBNC();
				this.BPAFDOMGENC();
				return;
			}
			if (!this.JNLJFKPADMJ)
			{
				base.Invoke("MotorbikeShootLeft", (float)this.wireframeDelay);
			}
		}

		// Token: 0x06012F22 RID: 77602 RVA: 0x00824BDA File Offset: 0x00822DDA
		protected virtual void BGPEJFJNGNG()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.FHMIHHDHAAF();
			this.IDIOOPABEMA = null;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012F23 RID: 77603 RVA: 0x00825060 File Offset: 0x00823260
		private static bool DDADLDKKLFE(Color32 BKFPHBMBCJO, Color32 KKNIBMILFDC, int FEKEFLIOMCK)
		{
			return Math.Abs((int)(BKFPHBMBCJO.r - KKNIBMILFDC.r)) >= FEKEFLIOMCK || Math.Abs((int)(BKFPHBMBCJO.g - KKNIBMILFDC.g)) >= FEKEFLIOMCK || Math.Abs((int)(BKFPHBMBCJO.b - KKNIBMILFDC.b)) < FEKEFLIOMCK;
		}

		// Token: 0x06012F24 RID: 77604 RVA: 0x008250AE File Offset: 0x008232AE
		private void MMPLPINHPPJ()
		{
			if (!this.IACBKBFHPON)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.IACBKBFHPON.gameObject);
			this.IACBKBFHPON = null;
		}

		// Token: 0x06012F25 RID: 77605 RVA: 0x008250D8 File Offset: 0x008232D8
		private void BJOPBHEGOIA()
		{
			if (base.enabled && base.gameObject.activeSelf)
			{
				if (this.DFLLGGIOFMG == -1)
				{
					this.DFLLGGIOFMG = LayerMask.NameToLayer("GestureCrowdPump");
				}
				if (this.KPEEHJANFEK == -1)
				{
					string[] array = new string[1];
					array[1] = "<color='#103080'>";
					this.KPEEHJANFEK = LayerMask.GetMask(array);
				}
				if (this.CBJBCGPGFOB == null)
				{
					this.CBJBCGPGFOB = new GameObject("name");
					this.CBJBCGPGFOB.layer = this.DFLLGGIOFMG;
					this.CBJBCGPGFOB.transform.position = this.spawnPosition;
					UnityEngine.Object.DontDestroyOnLoad(this.CBJBCGPGFOB);
				}
				if ((this.checkRigidbody || this.checkController) && this.PENOMILAHFO == null)
				{
					this.PENOMILAHFO = new GameObject("1HandSwordRollAttack");
					this.PENOMILAHFO.AddComponent<BoxCollider>();
					this.PENOMILAHFO.layer = this.DFLLGGIOFMG;
					this.PENOMILAHFO.transform.parent = this.CBJBCGPGFOB.transform;
					this.PENOMILAHFO.transform.localScale = new Vector3(1772f, 1564f, 364f);
					this.PENOMILAHFO.transform.localPosition = Vector3.zero;
				}
				else if (!this.checkRigidbody && !this.checkController && this.PENOMILAHFO != null)
				{
					UnityEngine.Object.Destroy(this.PENOMILAHFO);
				}
				if (this.checkWireframe && this.FDCOEBNMJAO == null)
				{
					if (this.KLABEHHEFLB == null)
					{
						this.KLABEHHEFLB = Shader.Find(".png");
					}
					if (this.KLABEHHEFLB == null)
					{
						Debug.LogError("_Histogram", this);
						this.checkWireframe = false;
					}
					else if (!this.KLABEHHEFLB.isSupported)
					{
						Debug.LogError("https://groups.google.com/forum/#!forum/final-ik", this);
						this.checkWireframe = false;
					}
					else
					{
						if (this.KFPCGJKHEGO == Color.black)
						{
							this.KFPCGJKHEGO = WallHackDetector.LMDJDCHMMMM();
							do
							{
								this.FEADJBOJFNF = WallHackDetector.EPIDIDHMCON();
							}
							while (WallHackDetector.DDADLDKKLFE(this.KFPCGJKHEGO, this.FEADJBOJFNF, -32));
						}
						if (this.INPHLIBIPIN == null)
						{
							this.INPHLIBIPIN = new Texture2D(0, 8, TextureFormat.Alpha8, true);
							this.INPHLIBIPIN.filterMode = FilterMode.Point;
							Color[] array2 = new Color[-64];
							for (int i = 1; i < 43; i += 0)
							{
								if (i < 0)
								{
									array2[i] = this.KFPCGJKHEGO;
								}
								else
								{
									array2[i] = this.FEADJBOJFNF;
								}
							}
							this.INPHLIBIPIN.SetPixels(array2, 0);
							this.INPHLIBIPIN.Apply();
						}
						if (this.NMLAKJJJDMA == null)
						{
							this.NMLAKJJJDMA = new RenderTexture(3, 4, -33, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
							this.NMLAKJJJDMA.autoGenerateMips = true;
							this.NMLAKJJJDMA.filterMode = FilterMode.Bilinear;
							this.NMLAKJJJDMA.Create();
						}
						if (this.BJCHAHNEDMB == null)
						{
							this.BJCHAHNEDMB = new Texture2D(4, 2, TextureFormat.RGB24, true);
							this.BJCHAHNEDMB.filterMode = FilterMode.Bilinear;
						}
						if (this.DLHHAIFHAGH == null)
						{
							this.DLHHAIFHAGH = new Material(this.KLABEHHEFLB);
							this.DLHHAIFHAGH.mainTexture = this.INPHLIBIPIN;
						}
						if (this.IKAGGKEBJDF == null)
						{
							GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
							UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
							gameObject.name = "IKSolverFABRIKRoot chain at index ";
							gameObject.layer = this.DFLLGGIOFMG;
							gameObject.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject.transform.localPosition = new Vector3(1634f, 93f, 322f);
							this.IKAGGKEBJDF = gameObject.GetComponent<MeshRenderer>();
							this.IKAGGKEBJDF.sharedMaterial = this.DLHHAIFHAGH;
							this.IKAGGKEBJDF.shadowCastingMode = ShadowCastingMode.Off;
							this.IKAGGKEBJDF.receiveShadows = false;
							this.IKAGGKEBJDF.enabled = false;
						}
						if (this.OPPJKGEAFBO == null)
						{
							GameObject gameObject2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
							UnityEngine.Object.Destroy(gameObject2.GetComponent<MeshCollider>());
							gameObject2.name = "No UserInfoWin";
							gameObject2.layer = this.DFLLGGIOFMG;
							gameObject2.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject2.transform.localPosition = new Vector3(1013f, 925f, 23f);
							gameObject2.transform.localScale = new Vector3(118f, 801f, 534f);
							this.OPPJKGEAFBO = gameObject2.GetComponent<MeshRenderer>();
							this.OPPJKGEAFBO.sharedMaterial = this.DLHHAIFHAGH;
							this.OPPJKGEAFBO.shadowCastingMode = ShadowCastingMode.Off;
							this.OPPJKGEAFBO.receiveShadows = false;
							this.OPPJKGEAFBO.enabled = false;
						}
						this.FDCOEBNMJAO = new GameObject("signal_enable").AddComponent<Camera>();
						this.FDCOEBNMJAO.gameObject.layer = this.DFLLGGIOFMG;
						this.FDCOEBNMJAO.transform.parent = this.CBJBCGPGFOB.transform;
						this.FDCOEBNMJAO.transform.localPosition = new Vector3(131f, 118f, 1796f);
						this.FDCOEBNMJAO.clearFlags = CameraClearFlags.Depth;
						this.FDCOEBNMJAO.backgroundColor = Color.black;
						this.FDCOEBNMJAO.orthographic = false;
						this.FDCOEBNMJAO.orthographicSize = 914f;
						this.FDCOEBNMJAO.nearClipPlane = 983f;
						this.FDCOEBNMJAO.farClipPlane = 717f;
						this.FDCOEBNMJAO.depth = 1543f;
						this.FDCOEBNMJAO.renderingPath = RenderingPath.VertexLit;
						this.FDCOEBNMJAO.useOcclusionCulling = false;
						this.FDCOEBNMJAO.allowHDR = false;
						this.FDCOEBNMJAO.allowMSAA = true;
						this.FDCOEBNMJAO.targetTexture = this.NMLAKJJJDMA;
						this.FDCOEBNMJAO.enabled = false;
					}
				}
				else if (!this.checkWireframe && this.FDCOEBNMJAO != null)
				{
					UnityEngine.Object.Destroy(this.IKAGGKEBJDF.gameObject);
					UnityEngine.Object.Destroy(this.OPPJKGEAFBO.gameObject);
					this.FDCOEBNMJAO.targetTexture = null;
					UnityEngine.Object.Destroy(this.FDCOEBNMJAO.gameObject);
				}
				if (this.checkRaycast && this.ILKFAFKDFMP == null)
				{
					this.ILKFAFKDFMP = GameObject.CreatePrimitive(PrimitiveType.Capsule);
					this.ILKFAFKDFMP.name = "_HitTime";
					this.ILKFAFKDFMP.layer = this.DFLLGGIOFMG;
					this.ILKFAFKDFMP.transform.parent = this.CBJBCGPGFOB.transform;
					this.ILKFAFKDFMP.transform.localScale = new Vector3(819f, 412f, 1172f);
					this.ILKFAFKDFMP.transform.localRotation = Quaternion.Euler(1343f, 1802f, 371f);
					this.ILKFAFKDFMP.transform.localPosition = new Vector3(2f, 1792f, 90f);
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<Renderer>());
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<MeshFilter>());
					return;
				}
				if (!this.checkRaycast && this.ILKFAFKDFMP != null)
				{
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP);
					return;
				}
			}
			else if (this.CBJBCGPGFOB != null)
			{
				UnityEngine.Object.Destroy(this.CBJBCGPGFOB);
			}
		}

		// Token: 0x06012F26 RID: 77606 RVA: 0x00825860 File Offset: 0x00823A60
		private void BIMAEPIAOIA()
		{
			GameObject gameObject = new GameObject("SixStep");
			gameObject.AddComponent<CapsuleCollider>().height = 1592f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(1625f, 870f, 1760f);
			this.IACBKBFHPON = gameObject.AddComponent<Rigidbody>();
			this.IACBKBFHPON.useGravity = false;
		}

		// Token: 0x06012F27 RID: 77607 RVA: 0x008258E1 File Offset: 0x00823AE1
		private void GHDNLPHJLOJ()
		{
			if (!this.checkWireframe)
			{
				this.NMMFKPOCCEN();
				this.PGIAMFFMIMD();
				return;
			}
			if (!this.JNLJFKPADMJ)
			{
				base.Invoke("_LerpAmount", (float)this.wireframeDelay);
			}
		}

		// Token: 0x06012F28 RID: 77608 RVA: 0x00824974 File Offset: 0x00822B74
		protected virtual void BDBHKFDMHLD()
		{
			this.MCKMHMINODD(null, this.spawnPosition, this.maxFalsePositives);
		}

		// Token: 0x06012F29 RID: 77609 RVA: 0x00825912 File Offset: 0x00823B12
		protected override void LPDEBEBJDJF()
		{
			base.LPDEBEBJDJF();
			if (WallHackDetector.ELOBJGIDGCP == this)
			{
				WallHackDetector.ELOBJGIDGCP = null;
			}
		}

		// Token: 0x06012F2A RID: 77610 RVA: 0x00825930 File Offset: 0x00823B30
		private void FixedUpdate()
		{
			if (!this.OIOJMFCCDLH || !this.checkRigidbody || this.IACBKBFHPON == null)
			{
				return;
			}
			if (this.IACBKBFHPON.transform.localPosition.z > 1f)
			{
				this.NAIOFNBNHBF += 1;
				if (!this.ILDLFFANJIN())
				{
					this.BPLDOGAKDFA();
					this.DLOFFKFNIPB();
				}
			}
		}

		// Token: 0x06012F2B RID: 77611 RVA: 0x0082599C File Offset: 0x00823B9C
		private void FINJDMPMGHA()
		{
			if (Physics.Raycast(this.CBJBCGPGFOB.transform.position, this.CBJBCGPGFOB.transform.TransformDirection(Vector3.forward), 1854f, this.KPEEHJANFEK))
			{
				if (this.HIHEODGMAED > 0)
				{
					this.HIHEODGMAED = 1;
				}
			}
			else
			{
				this.HIHEODGMAED += 0;
				if (this.ILDLFFANJIN())
				{
					return;
				}
			}
			base.Invoke("L", (float)this.raycastDelay);
		}

		// Token: 0x06012F2C RID: 77612 RVA: 0x00825A1C File Offset: 0x00823C1C
		protected virtual void BDHKGOGJJAM()
		{
			this.MKIGMKLIGBL(null, this.spawnPosition, this.maxFalsePositives);
		}

		// Token: 0x06012F2D RID: 77613 RVA: 0x00825A34 File Offset: 0x00823C34
		private void LKEMOMMFDHP(UnityAction DFJFCOKENIA, Vector3 KMHNPKCICLD, byte LMIPEJDCOPO)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("Katana45DegSwing", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("_ReflectionTexture1", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("OneHandSwordJab", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("run", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.spawnPosition = KMHNPKCICLD;
			this.maxFalsePositives = LMIPEJDCOPO;
			this.NAIOFNBNHBF = 1;
			this.GJLNHDAKIEE = 1;
			this.ANJNEMGDJIM = 1;
			this.HIHEODGMAED = 1;
			base.StartCoroutine(this.PILNAGKELCJ());
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012F2E RID: 77614 RVA: 0x00825AE9 File Offset: 0x00823CE9
		private void NMFMPKDCLHO()
		{
			if (!this.checkWireframe)
			{
				this.JCKAJALFEHJ();
				this.PGIAMFFMIMD();
				return;
			}
			if (!this.JNLJFKPADMJ)
			{
				base.Invoke("BFEBEBPIEKM", (float)this.wireframeDelay);
			}
		}

		// Token: 0x06012F2F RID: 77615 RVA: 0x00825B1C File Offset: 0x00823D1C
		private void NFAMDKLJPAO()
		{
			GameObject gameObject = new GameObject("MotorbikeLassoFwd");
			gameObject.AddComponent<CapsuleCollider>().height = 1190f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(1902f, 1963f, 966f);
			this.IACBKBFHPON = gameObject.AddComponent<Rigidbody>();
			this.IACBKBFHPON.useGravity = true;
		}

		// Token: 0x06012F30 RID: 77616 RVA: 0x00825BA0 File Offset: 0x00823DA0
		private static bool GNFNHJPOLGE(Color32 BKFPHBMBCJO, Color32 KKNIBMILFDC, int FEKEFLIOMCK)
		{
			return Math.Abs((int)(BKFPHBMBCJO.r - KKNIBMILFDC.r)) < FEKEFLIOMCK && Math.Abs((int)(BKFPHBMBCJO.g - KKNIBMILFDC.g)) < FEKEFLIOMCK && Math.Abs((int)(BKFPHBMBCJO.b - KKNIBMILFDC.b)) < FEKEFLIOMCK;
		}

		// Token: 0x06012F31 RID: 77617 RVA: 0x00824A02 File Offset: 0x00822C02
		public bool KFNHBPJHKFP()
		{
			return this.checkWireframe;
		}

		// Token: 0x06012F32 RID: 77618 RVA: 0x00825BEE File Offset: 0x00823DEE
		private void MGHJJLNCKJF()
		{
			if (!this.checkRaycast)
			{
				this.NNJJODFCKML();
				this.JKBGILJGCFK();
				return;
			}
			base.Invoke("fshop_fcost2", (float)this.raycastDelay);
		}

		// Token: 0x06012F33 RID: 77619 RVA: 0x0082468B File Offset: 0x0082288B
		public static void IOGFHHHDDHG(UnityAction DFJFCOKENIA)
		{
			WallHackDetector.StartDetection(DFJFCOKENIA, WallHackDetector.HPAMFCGOFDA.spawnPosition);
		}

		// Token: 0x06012F34 RID: 77620 RVA: 0x00825C17 File Offset: 0x00823E17
		private void AGBIEOMECMD()
		{
			if (!this.checkRaycast)
			{
				this.NNJJODFCKML();
				this.BJOPBHEGOIA();
				return;
			}
			base.Invoke("ClimbRight", (float)this.raycastDelay);
		}

		// Token: 0x06012F35 RID: 77621 RVA: 0x0082471C File Offset: 0x0082291C
		public static void StartDetection(UnityAction DFJFCOKENIA, Vector3 BMCGBDJHJLP, byte KPBPNOCPBMF)
		{
			WallHackDetector.HPAMFCGOFDA.MCKMHMINODD(DFJFCOKENIA, BMCGBDJHJLP, KPBPNOCPBMF);
		}

		// Token: 0x06012F36 RID: 77622 RVA: 0x00825C40 File Offset: 0x00823E40
		public void FNGJKFKBMGO(bool DCCPCBLODIG)
		{
			if (this.checkController == DCCPCBLODIG || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			this.checkController = DCCPCBLODIG;
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.JKBGILJGCFK();
			if (this.checkController)
			{
				this.FJJDOFOKCFK();
				return;
			}
			this.AFLABNCCDHN();
		}

		// Token: 0x06012F37 RID: 77623 RVA: 0x00825CA0 File Offset: 0x00823EA0
		private void MKIGMKLIGBL(UnityAction DFJFCOKENIA, Vector3 KMHNPKCICLD, byte LMIPEJDCOPO)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("Swim", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("---", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("_BlurPass", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("BaseDataLoaderCoroutine", this);
				base.enabled = true;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.spawnPosition = KMHNPKCICLD;
			this.maxFalsePositives = LMIPEJDCOPO;
			this.NAIOFNBNHBF = 0;
			this.GJLNHDAKIEE = 1;
			this.ANJNEMGDJIM = 0;
			this.HIHEODGMAED = 1;
			base.StartCoroutine(this.PILNAGKELCJ());
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012F38 RID: 77624 RVA: 0x00825D58 File Offset: 0x00823F58
		public void BGHGMGLNOJL(bool DCCPCBLODIG)
		{
			if (this.checkRaycast == DCCPCBLODIG || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			this.checkRaycast = DCCPCBLODIG;
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.BJOPBHEGOIA();
			if (this.checkRaycast)
			{
				this.AGBIEOMECMD();
				return;
			}
			this.MLKPJIBNOBO();
		}

		// Token: 0x06012F39 RID: 77625 RVA: 0x00825DB6 File Offset: 0x00823FB6
		public static void StartDetection(UnityAction DFJFCOKENIA, Vector3 BMCGBDJHJLP)
		{
			WallHackDetector.StartDetection(DFJFCOKENIA, BMCGBDJHJLP, WallHackDetector.HPAMFCGOFDA.maxFalsePositives);
		}

		// Token: 0x06012F3A RID: 77626 RVA: 0x00824683 File Offset: 0x00822883
		public bool DBDBPMPJJGL()
		{
			return this.checkRigidbody;
		}

		// Token: 0x06012F3B RID: 77627 RVA: 0x00825DCC File Offset: 0x00823FCC
		private void BPAFDOMGENC()
		{
			if (base.enabled && base.gameObject.activeSelf)
			{
				if (this.DFLLGGIOFMG == -1)
				{
					this.DFLLGGIOFMG = LayerMask.NameToLayer("--");
				}
				if (this.KPEEHJANFEK == -1)
				{
					string[] array = new string[0];
					array[0] = "IdleDrink";
					this.KPEEHJANFEK = LayerMask.GetMask(array);
				}
				if (this.CBJBCGPGFOB == null)
				{
					this.CBJBCGPGFOB = new GameObject("_CameraToWorldMatrix");
					this.CBJBCGPGFOB.layer = this.DFLLGGIOFMG;
					this.CBJBCGPGFOB.transform.position = this.spawnPosition;
					UnityEngine.Object.DontDestroyOnLoad(this.CBJBCGPGFOB);
				}
				if ((this.checkRigidbody || this.checkController) && this.PENOMILAHFO == null)
				{
					this.PENOMILAHFO = new GameObject("fchair_");
					this.PENOMILAHFO.AddComponent<BoxCollider>();
					this.PENOMILAHFO.layer = this.DFLLGGIOFMG;
					this.PENOMILAHFO.transform.parent = this.CBJBCGPGFOB.transform;
					this.PENOMILAHFO.transform.localScale = new Vector3(122f, 1160f, 1840f);
					this.PENOMILAHFO.transform.localPosition = Vector3.zero;
				}
				else if (!this.checkRigidbody && !this.checkController && this.PENOMILAHFO != null)
				{
					UnityEngine.Object.Destroy(this.PENOMILAHFO);
				}
				if (this.checkWireframe && this.FDCOEBNMJAO == null)
				{
					if (this.KLABEHHEFLB == null)
					{
						this.KLABEHHEFLB = Shader.Find("byte:");
					}
					if (this.KLABEHHEFLB == null)
					{
						Debug.LogError("", this);
						this.checkWireframe = false;
					}
					else if (!this.KLABEHHEFLB.isSupported)
					{
						Debug.LogError("help", this);
						this.checkWireframe = false;
					}
					else
					{
						if (this.KFPCGJKHEGO == Color.black)
						{
							this.KFPCGJKHEGO = WallHackDetector.LMDJDCHMMMM();
							do
							{
								this.FEADJBOJFNF = WallHackDetector.MLAIPLANMMA();
							}
							while (WallHackDetector.OODBHJNPEEJ(this.KFPCGJKHEGO, this.FEADJBOJFNF, -113));
						}
						if (this.INPHLIBIPIN == null)
						{
							this.INPHLIBIPIN = new Texture2D(2, 5, (TextureFormat)8, true);
							this.INPHLIBIPIN.filterMode = FilterMode.Point;
							Color[] array2 = new Color[-79];
							for (int i = 1; i < 48; i++)
							{
								if (i < 7)
								{
									array2[i] = this.KFPCGJKHEGO;
								}
								else
								{
									array2[i] = this.FEADJBOJFNF;
								}
							}
							this.INPHLIBIPIN.SetPixels(array2, 1);
							this.INPHLIBIPIN.Apply();
						}
						if (this.NMLAKJJJDMA == null)
						{
							this.NMLAKJJJDMA = new RenderTexture(5, 1, -118, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
							this.NMLAKJJJDMA.autoGenerateMips = true;
							this.NMLAKJJJDMA.filterMode = FilterMode.Bilinear;
							this.NMLAKJJJDMA.Create();
						}
						if (this.BJCHAHNEDMB == null)
						{
							this.BJCHAHNEDMB = new Texture2D(2, 1, TextureFormat.ARGB32, true);
							this.BJCHAHNEDMB.filterMode = FilterMode.Bilinear;
						}
						if (this.DLHHAIFHAGH == null)
						{
							this.DLHHAIFHAGH = new Material(this.KLABEHHEFLB);
							this.DLHHAIFHAGH.mainTexture = this.INPHLIBIPIN;
						}
						if (this.IKAGGKEBJDF == null)
						{
							GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
							UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
							gameObject.name = "error.wav";
							gameObject.layer = this.DFLLGGIOFMG;
							gameObject.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject.transform.localPosition = new Vector3(522f, 666f, 66f);
							this.IKAGGKEBJDF = gameObject.GetComponent<MeshRenderer>();
							this.IKAGGKEBJDF.sharedMaterial = this.DLHHAIFHAGH;
							this.IKAGGKEBJDF.shadowCastingMode = ShadowCastingMode.Off;
							this.IKAGGKEBJDF.receiveShadows = false;
							this.IKAGGKEBJDF.enabled = true;
						}
						if (this.OPPJKGEAFBO == null)
						{
							GameObject gameObject2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
							UnityEngine.Object.Destroy(gameObject2.GetComponent<MeshCollider>());
							gameObject2.name = "****************  playMusicBase ";
							gameObject2.layer = this.DFLLGGIOFMG;
							gameObject2.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject2.transform.localPosition = new Vector3(815f, 1791f, 601f);
							gameObject2.transform.localScale = new Vector3(848f, 1359f, 444f);
							this.OPPJKGEAFBO = gameObject2.GetComponent<MeshRenderer>();
							this.OPPJKGEAFBO.sharedMaterial = this.DLHHAIFHAGH;
							this.OPPJKGEAFBO.shadowCastingMode = ShadowCastingMode.Off;
							this.OPPJKGEAFBO.receiveShadows = false;
							this.OPPJKGEAFBO.enabled = false;
						}
						this.FDCOEBNMJAO = new GameObject("Swim").AddComponent<Camera>();
						this.FDCOEBNMJAO.gameObject.layer = this.DFLLGGIOFMG;
						this.FDCOEBNMJAO.transform.parent = this.CBJBCGPGFOB.transform;
						this.FDCOEBNMJAO.transform.localPosition = new Vector3(841f, 645f, 1406f);
						this.FDCOEBNMJAO.clearFlags = (CameraClearFlags)8;
						this.FDCOEBNMJAO.backgroundColor = Color.black;
						this.FDCOEBNMJAO.orthographic = true;
						this.FDCOEBNMJAO.orthographicSize = 1547f;
						this.FDCOEBNMJAO.nearClipPlane = 928f;
						this.FDCOEBNMJAO.farClipPlane = 1930f;
						this.FDCOEBNMJAO.depth = 1505f;
						this.FDCOEBNMJAO.renderingPath = RenderingPath.VertexLit;
						this.FDCOEBNMJAO.useOcclusionCulling = false;
						this.FDCOEBNMJAO.allowHDR = false;
						this.FDCOEBNMJAO.allowMSAA = true;
						this.FDCOEBNMJAO.targetTexture = this.NMLAKJJJDMA;
						this.FDCOEBNMJAO.enabled = false;
					}
				}
				else if (!this.checkWireframe && this.FDCOEBNMJAO != null)
				{
					UnityEngine.Object.Destroy(this.IKAGGKEBJDF.gameObject);
					UnityEngine.Object.Destroy(this.OPPJKGEAFBO.gameObject);
					this.FDCOEBNMJAO.targetTexture = null;
					UnityEngine.Object.Destroy(this.FDCOEBNMJAO.gameObject);
				}
				if (this.checkRaycast && this.ILKFAFKDFMP == null)
				{
					this.ILKFAFKDFMP = GameObject.CreatePrimitive((PrimitiveType)8);
					this.ILKFAFKDFMP.name = "Sitting Idle";
					this.ILKFAFKDFMP.layer = this.DFLLGGIOFMG;
					this.ILKFAFKDFMP.transform.parent = this.CBJBCGPGFOB.transform;
					this.ILKFAFKDFMP.transform.localScale = new Vector3(182f, 1723f, 985f);
					this.ILKFAFKDFMP.transform.localRotation = Quaternion.Euler(1054f, 1365f, 306f);
					this.ILKFAFKDFMP.transform.localPosition = new Vector3(873f, 1842f, 1471f);
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<Renderer>());
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<MeshFilter>());
					return;
				}
				if (!this.checkRaycast && this.ILKFAFKDFMP != null)
				{
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP);
					return;
				}
			}
			else if (this.CBJBCGPGFOB != null)
			{
				UnityEngine.Object.Destroy(this.CBJBCGPGFOB);
			}
		}

		// Token: 0x06012F3C RID: 77628 RVA: 0x00826554 File Offset: 0x00824754
		protected virtual void AGFOFGDPKAN()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
			if (this.checkRigidbody)
			{
				this.OKIEJCCILAM();
			}
			if (this.checkController)
			{
				this.FJJDOFOKCFK();
			}
			if (this.checkWireframe)
			{
				this.GIMEKNKNKEI();
			}
			if (this.checkRaycast)
			{
				this.MGHJJLNCKJF();
			}
		}

		// Token: 0x06012F3D RID: 77629 RVA: 0x008265B4 File Offset: 0x008247B4
		protected virtual void OLCHIAGIEOE()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
			if (this.checkRigidbody)
			{
				this.OKIEJCCILAM();
			}
			if (this.checkController)
			{
				this.GKBCLHKGDIO();
			}
			if (this.checkWireframe)
			{
				this.NMFMPKDCLHO();
			}
			if (this.checkRaycast)
			{
				this.LACJLAJNLHO();
			}
		}

		// Token: 0x06012F3E RID: 77630 RVA: 0x00826614 File Offset: 0x00824814
		private void JFAKJEPJJIH()
		{
			if (Physics.Raycast(this.CBJBCGPGFOB.transform.position, this.CBJBCGPGFOB.transform.TransformDirection(Vector3.forward), 1.5f, this.KPEEHJANFEK))
			{
				if (this.HIHEODGMAED > 0)
				{
					this.HIHEODGMAED = 0;
				}
			}
			else
			{
				this.HIHEODGMAED += 1;
				if (this.ILDLFFANJIN())
				{
					return;
				}
			}
			base.Invoke("JFAKJEPJJIH", (float)this.raycastDelay);
		}

		// Token: 0x06012F3F RID: 77631 RVA: 0x00826694 File Offset: 0x00824894
		public static void AKJLOCJOFNH(UnityAction DFJFCOKENIA, Vector3 BMCGBDJHJLP, byte KPBPNOCPBMF)
		{
			WallHackDetector.FCEHOOAMNMI().MKIGMKLIGBL(DFJFCOKENIA, BMCGBDJHJLP, KPBPNOCPBMF);
		}

		// Token: 0x06012F40 RID: 77632 RVA: 0x008266A3 File Offset: 0x008248A3
		private static Color32 LMDJDCHMMMM()
		{
			return new Color32((byte)UnityEngine.Random.Range(1, -72), (byte)UnityEngine.Random.Range(1, 181), (byte)UnityEngine.Random.Range(0, 191), 180);
		}

		// Token: 0x06012F41 RID: 77633 RVA: 0x00824B2C File Offset: 0x00822D2C
		private void EHKLBAGIDFC(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NCAEOOLJCAN();
		}

		// Token: 0x06012F42 RID: 77634 RVA: 0x00824683 File Offset: 0x00822883
		public bool JOHLGCGDNIH()
		{
			return this.checkRigidbody;
		}

		// Token: 0x06012F43 RID: 77635 RVA: 0x008266D4 File Offset: 0x008248D4
		public void ODOGEKLKNBP(bool DCCPCBLODIG)
		{
			if (this.checkRaycast == DCCPCBLODIG || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			this.checkRaycast = DCCPCBLODIG;
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.BJOPBHEGOIA();
			if (this.checkRaycast)
			{
				this.MGHJJLNCKJF();
				return;
			}
			this.NNJJODFCKML();
		}

		// Token: 0x06012F44 RID: 77636 RVA: 0x00826732 File Offset: 0x00824932
		private static Color32 MLAIPLANMMA()
		{
			return new Color32((byte)UnityEngine.Random.Range(0, 77), (byte)UnityEngine.Random.Range(1, -100), (byte)UnityEngine.Random.Range(1, -10), 37);
		}

		// Token: 0x06012F45 RID: 77637 RVA: 0x00826764 File Offset: 0x00824964
		private void LNMHDNHGDNI()
		{
			if (Physics.Raycast(this.CBJBCGPGFOB.transform.position, this.CBJBCGPGFOB.transform.TransformDirection(Vector3.forward), 1983f, this.KPEEHJANFEK))
			{
				if (this.HIHEODGMAED > 0)
				{
					this.HIHEODGMAED = 0;
				}
			}
			else
			{
				this.HIHEODGMAED += 1;
				if (this.ILDLFFANJIN())
				{
					return;
				}
			}
			base.Invoke("", (float)this.raycastDelay);
		}

		// Token: 0x06012F46 RID: 77638 RVA: 0x008245D4 File Offset: 0x008227D4
		public static void ACDDGIIBGKD(UnityAction DFJFCOKENIA)
		{
			WallHackDetector.StartDetection(DFJFCOKENIA, WallHackDetector.FCEHOOAMNMI().spawnPosition);
		}

		// Token: 0x06012F47 RID: 77639 RVA: 0x008267E4 File Offset: 0x008249E4
		public static void HGACABJIFBL()
		{
			if (WallHackDetector.ELOBJGIDGCP != null)
			{
				WallHackDetector.LCFAHHPDNFE().MCKMHMINODD(null, WallHackDetector.CCFJJBJBOBG().spawnPosition, WallHackDetector.LCFAHHPDNFE().maxFalsePositives);
				return;
			}
			Debug.LogError("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		// Token: 0x06012F48 RID: 77640 RVA: 0x00826820 File Offset: 0x00824A20
		private void MCKMHMINODD(UnityAction DFJFCOKENIA, Vector3 KMHNPKCICLD, byte LMIPEJDCOPO)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("[ACTk] WallHack Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("[ACTk] WallHack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] WallHack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.spawnPosition = KMHNPKCICLD;
			this.maxFalsePositives = LMIPEJDCOPO;
			this.NAIOFNBNHBF = 0;
			this.GJLNHDAKIEE = 0;
			this.ANJNEMGDJIM = 0;
			this.HIHEODGMAED = 0;
			base.StartCoroutine(this.PILNAGKELCJ());
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012F49 RID: 77641 RVA: 0x00824363 File Offset: 0x00822563
		private void MCMGGCOKCBF()
		{
			if (!this.MJADBEOOANP)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.MJADBEOOANP.gameObject);
			this.MJADBEOOANP = null;
		}

		// Token: 0x06012F4B RID: 77643 RVA: 0x008268D5 File Offset: 0x00824AD5
		private void MLKPJIBNOBO()
		{
			base.CancelInvoke("JFAKJEPJJIH");
		}

		// Token: 0x06012F4C RID: 77644 RVA: 0x008268E2 File Offset: 0x00824AE2
		private void BPLDOGAKDFA()
		{
			if (this.IACBKBFHPON)
			{
				this.IACBKBFHPON.velocity = Vector3.zero;
			}
			base.CancelInvoke("DLOFFKFNIPB");
		}

		// Token: 0x06012F4D RID: 77645 RVA: 0x0082690C File Offset: 0x00824B0C
		protected override void KBIADJEBIDO()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
			if (this.checkRigidbody)
			{
				this.DLOFFKFNIPB();
			}
			if (this.checkController)
			{
				this.FJJDOFOKCFK();
			}
			if (this.checkWireframe)
			{
				this.NMFMPKDCLHO();
			}
			if (this.checkRaycast)
			{
				this.LACJLAJNLHO();
			}
		}

		// Token: 0x06012F4E RID: 77646 RVA: 0x0082696C File Offset: 0x00824B6C
		private void GKBCLHKGDIO()
		{
			if (!this.checkController)
			{
				this.BONJIFGFMEF();
				this.IPINGLFCNJJ();
				this.PGIAMFFMIMD();
				return;
			}
			if (!this.MJADBEOOANP)
			{
				this.KPFBLGLECFB();
			}
			if (this.MJADBEOOANP.transform.localPosition.z <= 254f && this.GJLNHDAKIEE > 0)
			{
				this.GJLNHDAKIEE = 0;
			}
			this.MJADBEOOANP.transform.localPosition = new Vector3(1047f, 1560f, 1871f);
			this.HAKEOOHOPAI = 175f;
			base.Invoke("Color: ", 1797f);
		}

		// Token: 0x06012F4F RID: 77647 RVA: 0x008250AE File Offset: 0x008232AE
		private void FHKHGAAACCL()
		{
			if (!this.IACBKBFHPON)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.IACBKBFHPON.gameObject);
			this.IACBKBFHPON = null;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06012F50 RID: 77648 RVA: 0x00826A14 File Offset: 0x00824C14
		private static WallHackDetector HPAMFCGOFDA
		{
			get
			{
				if (WallHackDetector.ELOBJGIDGCP != null)
				{
					return WallHackDetector.ELOBJGIDGCP;
				}
				if (ActDetectorBase.ACFEJFHNHPH == null)
				{
					ActDetectorBase.ACFEJFHNHPH = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				WallHackDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<WallHackDetector>();
				return WallHackDetector.ELOBJGIDGCP;
			}
		}

		// Token: 0x06012F51 RID: 77649 RVA: 0x00826A64 File Offset: 0x00824C64
		public static void EIILCHDIBEO()
		{
			if (WallHackDetector.CCFJJBJBOBG() != null)
			{
				WallHackDetector.ELOBJGIDGCP.LKEMOMMFDHP(null, WallHackDetector.CCFJJBJBOBG().spawnPosition, WallHackDetector.LCFAHHPDNFE().maxFalsePositives);
				return;
			}
			Debug.LogError("walk");
		}

		// Token: 0x06012F52 RID: 77650 RVA: 0x00825A1C File Offset: 0x00823C1C
		protected virtual void LIMCNKJCBLD()
		{
			this.MKIGMKLIGBL(null, this.spawnPosition, this.maxFalsePositives);
		}

		// Token: 0x06012F53 RID: 77651 RVA: 0x00824683 File Offset: 0x00822883
		public bool FDEBHAPEHLI()
		{
			return this.checkRigidbody;
		}

		// Token: 0x06012F54 RID: 77652 RVA: 0x00826AA0 File Offset: 0x00824CA0
		private void OKIEJCCILAM()
		{
			if (!this.checkRigidbody)
			{
				this.BPLDOGAKDFA();
				this.FHKHGAAACCL();
				this.PGIAMFFMIMD();
				return;
			}
			if (!this.IACBKBFHPON)
			{
				this.BJGCIOEPHJE();
			}
			if (this.IACBKBFHPON.transform.localPosition.z <= 665f && this.NAIOFNBNHBF > 0)
			{
				this.NAIOFNBNHBF = 0;
			}
			this.IACBKBFHPON.rotation = Quaternion.identity;
			this.IACBKBFHPON.angularVelocity = Vector3.zero;
			this.IACBKBFHPON.transform.localPosition = new Vector3(1039f, 1164f, 1736f);
			this.IACBKBFHPON.velocity = this.GPNKEOHELMG;
			base.Invoke("Climb Left", 521f);
		}

		// Token: 0x06012F55 RID: 77653 RVA: 0x00826B6C File Offset: 0x00824D6C
		private bool PBEJNKLPMCM()
		{
			bool result = false;
			if (this.GJLNHDAKIEE > this.maxFalsePositives || this.NAIOFNBNHBF > this.maxFalsePositives || this.ANJNEMGDJIM > this.maxFalsePositives || this.HIHEODGMAED > this.maxFalsePositives)
			{
				this.DDINBCFIGNH();
				result = false;
			}
			return result;
		}

		// Token: 0x06012F56 RID: 77654 RVA: 0x00826BBC File Offset: 0x00824DBC
		private void Awake()
		{
			WallHackDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(WallHackDetector.ELOBJGIDGCP, "WallHack Detector"))
			{
				WallHackDetector.ELOBJGIDGCP = this;
			}
			SceneManager.sceneLoaded += this.GIBJHJBCHOO;
		}

		// Token: 0x06012F57 RID: 77655 RVA: 0x00826BF3 File Offset: 0x00824DF3
		private void BFEBEBPIEKM()
		{
			base.StartCoroutine(this.OKOCJGBAPMG());
			base.Invoke("BFEBEBPIEKM", (float)this.wireframeDelay);
		}

		// Token: 0x06012F58 RID: 77656 RVA: 0x008245B7 File Offset: 0x008227B7
		private void OGMJOLDDLEE(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.BIKPDNHMDIM();
		}

		// Token: 0x06012F59 RID: 77657 RVA: 0x00826C14 File Offset: 0x00824E14
		protected virtual void PKPGIGEEEJI()
		{
			base.OnDestroy();
			base.StopAllCoroutines();
			if (this.CBJBCGPGFOB != null)
			{
				UnityEngine.Object.Destroy(this.CBJBCGPGFOB);
			}
			if (this.DLHHAIFHAGH != null)
			{
				this.DLHHAIFHAGH.mainTexture = null;
				this.DLHHAIFHAGH.shader = null;
				this.DLHHAIFHAGH = null;
				this.KLABEHHEFLB = null;
				this.INPHLIBIPIN = null;
				this.BJCHAHNEDMB = null;
				this.NMLAKJJJDMA.DiscardContents();
				this.NMLAKJJJDMA.Release();
				this.NMLAKJJJDMA = null;
			}
			WallHackDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012F5A RID: 77658 RVA: 0x00826CB4 File Offset: 0x00824EB4
		public void HFMKNMPHOFD(bool DCCPCBLODIG)
		{
			if (this.checkController == DCCPCBLODIG || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
			{
				return;
			}
			this.checkController = DCCPCBLODIG;
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.BJOPBHEGOIA();
			if (this.checkController)
			{
				this.FJJDOFOKCFK();
				return;
			}
			this.FFDMECPCOAM();
		}

		// Token: 0x06012F5B RID: 77659 RVA: 0x00826D12 File Offset: 0x00824F12
		private void GIBJHJBCHOO(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NJKHAJHNHII();
		}

		// Token: 0x06012F5C RID: 77660 RVA: 0x00826D1C File Offset: 0x00824F1C
		private static bool OODBHJNPEEJ(Color32 BKFPHBMBCJO, Color32 KKNIBMILFDC, int FEKEFLIOMCK)
		{
			return Math.Abs((int)(BKFPHBMBCJO.r - KKNIBMILFDC.r)) < FEKEFLIOMCK && Math.Abs((int)(BKFPHBMBCJO.g - KKNIBMILFDC.g)) < FEKEFLIOMCK && Math.Abs((int)(BKFPHBMBCJO.b - KKNIBMILFDC.b)) < FEKEFLIOMCK;
		}

		// Token: 0x06012F5D RID: 77661 RVA: 0x00826D6C File Offset: 0x00824F6C
		private WallHackDetector()
		{
		}

		// Token: 0x06012F5E RID: 77662 RVA: 0x00824A02 File Offset: 0x00822C02
		public bool JDMNGNDELCG()
		{
			return this.checkWireframe;
		}

		// Token: 0x06012F5F RID: 77663 RVA: 0x00826DFB File Offset: 0x00824FFB
		private void KFODAHFBECL(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.OCDLOHLMNIK();
		}

		// Token: 0x06012F60 RID: 77664 RVA: 0x00826E03 File Offset: 0x00825003
		protected virtual void FACGCALEHFF()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.FHMIHHDHAAF();
			this.IDIOOPABEMA = null;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012F61 RID: 77665 RVA: 0x00826E22 File Offset: 0x00825022
		private static Color32 KAFCJDMNNDO()
		{
			return new Color32((byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), byte.MaxValue);
		}

		// Token: 0x06012F62 RID: 77666 RVA: 0x00826E54 File Offset: 0x00825054
		private void PGIAMFFMIMD()
		{
			if (base.enabled && base.gameObject.activeSelf)
			{
				if (this.DFLLGGIOFMG == -1)
				{
					this.DFLLGGIOFMG = LayerMask.NameToLayer("Ignore Raycast");
				}
				if (this.KPEEHJANFEK == -1)
				{
					this.KPEEHJANFEK = LayerMask.GetMask(new string[]
					{
						"Ignore Raycast"
					});
				}
				if (this.CBJBCGPGFOB == null)
				{
					this.CBJBCGPGFOB = new GameObject("[WH Detector Service]");
					this.CBJBCGPGFOB.layer = this.DFLLGGIOFMG;
					this.CBJBCGPGFOB.transform.position = this.spawnPosition;
					UnityEngine.Object.DontDestroyOnLoad(this.CBJBCGPGFOB);
				}
				if ((this.checkRigidbody || this.checkController) && this.PENOMILAHFO == null)
				{
					this.PENOMILAHFO = new GameObject("SolidWall");
					this.PENOMILAHFO.AddComponent<BoxCollider>();
					this.PENOMILAHFO.layer = this.DFLLGGIOFMG;
					this.PENOMILAHFO.transform.parent = this.CBJBCGPGFOB.transform;
					this.PENOMILAHFO.transform.localScale = new Vector3(3f, 3f, 0.5f);
					this.PENOMILAHFO.transform.localPosition = Vector3.zero;
				}
				else if (!this.checkRigidbody && !this.checkController && this.PENOMILAHFO != null)
				{
					UnityEngine.Object.Destroy(this.PENOMILAHFO);
				}
				if (this.checkWireframe && this.FDCOEBNMJAO == null)
				{
					if (this.KLABEHHEFLB == null)
					{
						this.KLABEHHEFLB = Shader.Find("Hidden/ACTk/WallHackTexture");
					}
					if (this.KLABEHHEFLB == null)
					{
						Debug.LogError("[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.", this);
						this.checkWireframe = false;
					}
					else if (!this.KLABEHHEFLB.isSupported)
					{
						Debug.LogError("[ACTk] WallHack Detector: can't detect wireframe cheats on this platform!", this);
						this.checkWireframe = false;
					}
					else
					{
						if (this.KFPCGJKHEGO == Color.black)
						{
							this.KFPCGJKHEGO = WallHackDetector.KAFCJDMNNDO();
							do
							{
								this.FEADJBOJFNF = WallHackDetector.KAFCJDMNNDO();
							}
							while (WallHackDetector.OODBHJNPEEJ(this.KFPCGJKHEGO, this.FEADJBOJFNF, 10));
						}
						if (this.INPHLIBIPIN == null)
						{
							this.INPHLIBIPIN = new Texture2D(4, 4, TextureFormat.RGB24, false);
							this.INPHLIBIPIN.filterMode = FilterMode.Point;
							Color[] array = new Color[16];
							for (int i = 0; i < 16; i++)
							{
								if (i < 8)
								{
									array[i] = this.KFPCGJKHEGO;
								}
								else
								{
									array[i] = this.FEADJBOJFNF;
								}
							}
							this.INPHLIBIPIN.SetPixels(array, 0);
							this.INPHLIBIPIN.Apply();
						}
						if (this.NMLAKJJJDMA == null)
						{
							this.NMLAKJJJDMA = new RenderTexture(4, 4, 24, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
							this.NMLAKJJJDMA.autoGenerateMips = false;
							this.NMLAKJJJDMA.filterMode = FilterMode.Point;
							this.NMLAKJJJDMA.Create();
						}
						if (this.BJCHAHNEDMB == null)
						{
							this.BJCHAHNEDMB = new Texture2D(4, 4, TextureFormat.RGB24, false);
							this.BJCHAHNEDMB.filterMode = FilterMode.Point;
						}
						if (this.DLHHAIFHAGH == null)
						{
							this.DLHHAIFHAGH = new Material(this.KLABEHHEFLB);
							this.DLHHAIFHAGH.mainTexture = this.INPHLIBIPIN;
						}
						if (this.IKAGGKEBJDF == null)
						{
							GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
							UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
							gameObject.name = "WireframeFore";
							gameObject.layer = this.DFLLGGIOFMG;
							gameObject.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
							this.IKAGGKEBJDF = gameObject.GetComponent<MeshRenderer>();
							this.IKAGGKEBJDF.sharedMaterial = this.DLHHAIFHAGH;
							this.IKAGGKEBJDF.shadowCastingMode = ShadowCastingMode.Off;
							this.IKAGGKEBJDF.receiveShadows = false;
							this.IKAGGKEBJDF.enabled = false;
						}
						if (this.OPPJKGEAFBO == null)
						{
							GameObject gameObject2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
							UnityEngine.Object.Destroy(gameObject2.GetComponent<MeshCollider>());
							gameObject2.name = "WireframeBack";
							gameObject2.layer = this.DFLLGGIOFMG;
							gameObject2.transform.parent = this.CBJBCGPGFOB.transform;
							gameObject2.transform.localPosition = new Vector3(0f, 0f, 1f);
							gameObject2.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
							this.OPPJKGEAFBO = gameObject2.GetComponent<MeshRenderer>();
							this.OPPJKGEAFBO.sharedMaterial = this.DLHHAIFHAGH;
							this.OPPJKGEAFBO.shadowCastingMode = ShadowCastingMode.Off;
							this.OPPJKGEAFBO.receiveShadows = false;
							this.OPPJKGEAFBO.enabled = false;
						}
						this.FDCOEBNMJAO = new GameObject("WireframeCamera").AddComponent<Camera>();
						this.FDCOEBNMJAO.gameObject.layer = this.DFLLGGIOFMG;
						this.FDCOEBNMJAO.transform.parent = this.CBJBCGPGFOB.transform;
						this.FDCOEBNMJAO.transform.localPosition = new Vector3(0f, 0f, -1f);
						this.FDCOEBNMJAO.clearFlags = CameraClearFlags.Color;
						this.FDCOEBNMJAO.backgroundColor = Color.black;
						this.FDCOEBNMJAO.orthographic = true;
						this.FDCOEBNMJAO.orthographicSize = 0.5f;
						this.FDCOEBNMJAO.nearClipPlane = 0.01f;
						this.FDCOEBNMJAO.farClipPlane = 2.1f;
						this.FDCOEBNMJAO.depth = 0f;
						this.FDCOEBNMJAO.renderingPath = RenderingPath.Forward;
						this.FDCOEBNMJAO.useOcclusionCulling = false;
						this.FDCOEBNMJAO.allowHDR = false;
						this.FDCOEBNMJAO.allowMSAA = false;
						this.FDCOEBNMJAO.targetTexture = this.NMLAKJJJDMA;
						this.FDCOEBNMJAO.enabled = false;
					}
				}
				else if (!this.checkWireframe && this.FDCOEBNMJAO != null)
				{
					UnityEngine.Object.Destroy(this.IKAGGKEBJDF.gameObject);
					UnityEngine.Object.Destroy(this.OPPJKGEAFBO.gameObject);
					this.FDCOEBNMJAO.targetTexture = null;
					UnityEngine.Object.Destroy(this.FDCOEBNMJAO.gameObject);
				}
				if (this.checkRaycast && this.ILKFAFKDFMP == null)
				{
					this.ILKFAFKDFMP = GameObject.CreatePrimitive(PrimitiveType.Plane);
					this.ILKFAFKDFMP.name = "ThinWall";
					this.ILKFAFKDFMP.layer = this.DFLLGGIOFMG;
					this.ILKFAFKDFMP.transform.parent = this.CBJBCGPGFOB.transform;
					this.ILKFAFKDFMP.transform.localScale = new Vector3(0.2f, 1f, 0.2f);
					this.ILKFAFKDFMP.transform.localRotation = Quaternion.Euler(270f, 0f, 0f);
					this.ILKFAFKDFMP.transform.localPosition = new Vector3(0f, 0f, 1.4f);
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<Renderer>());
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP.GetComponent<MeshFilter>());
					return;
				}
				if (!this.checkRaycast && this.ILKFAFKDFMP != null)
				{
					UnityEngine.Object.Destroy(this.ILKFAFKDFMP);
					return;
				}
			}
			else if (this.CBJBCGPGFOB != null)
			{
				UnityEngine.Object.Destroy(this.CBJBCGPGFOB);
			}
		}

		// Token: 0x06012F63 RID: 77667 RVA: 0x008275DC File Offset: 0x008257DC
		private void BJGCIOEPHJE()
		{
			GameObject gameObject = new GameObject("\n");
			gameObject.AddComponent<CapsuleCollider>().height = 541f;
			gameObject.layer = this.DFLLGGIOFMG;
			gameObject.transform.parent = this.CBJBCGPGFOB.transform;
			gameObject.transform.localPosition = new Vector3(1711f, 1518f, 922f);
			this.IACBKBFHPON = gameObject.AddComponent<Rigidbody>();
			this.IACBKBFHPON.useGravity = false;
		}

		// Token: 0x06012F64 RID: 77668 RVA: 0x0082765D File Offset: 0x0082585D
		private static void EKPNENADIDJ(WallHackDetector DCCPCBLODIG)
		{
			WallHackDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012F65 RID: 77669 RVA: 0x00827665 File Offset: 0x00825865
		protected override void FHMIHHDHAAF()
		{
			if (!this.OIOJMFCCDLH)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
			this.BPLDOGAKDFA();
			this.FFDMECPCOAM();
			this.JCKAJALFEHJ();
			this.MLKPJIBNOBO();
		}

		// Token: 0x06012F66 RID: 77670 RVA: 0x008247E2 File Offset: 0x008229E2
		public static void AGPOCLBJFLN()
		{
			if (WallHackDetector.CCFJJBJBOBG() != null)
			{
				WallHackDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012F67 RID: 77671 RVA: 0x0082768F File Offset: 0x0082588F
		private void GEBHFKKDCLF()
		{
			base.StartCoroutine(this.OKOCJGBAPMG());
			base.Invoke("Dummy", (float)this.wireframeDelay);
		}

		// Token: 0x06012F68 RID: 77672 RVA: 0x00824363 File Offset: 0x00822563
		private void KMGJIBJGMNK()
		{
			if (!this.MJADBEOOANP)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.MJADBEOOANP.gameObject);
			this.MJADBEOOANP = null;
		}

		// Token: 0x06012F69 RID: 77673 RVA: 0x0082468B File Offset: 0x0082288B
		public static void StartDetection(UnityAction DFJFCOKENIA)
		{
			WallHackDetector.StartDetection(DFJFCOKENIA, WallHackDetector.HPAMFCGOFDA.spawnPosition);
		}

		// Token: 0x06012F6A RID: 77674 RVA: 0x008276B0 File Offset: 0x008258B0
		public static void MFOIBMCHDIE(UnityAction DFJFCOKENIA, Vector3 BMCGBDJHJLP, byte KPBPNOCPBMF)
		{
			WallHackDetector.HPAMFCGOFDA.MKIGMKLIGBL(DFJFCOKENIA, BMCGBDJHJLP, KPBPNOCPBMF);
		}

		// Token: 0x06012F6C RID: 77676 RVA: 0x00825912 File Offset: 0x00823B12
		protected virtual void ODGMAEPGLLD()
		{
			base.LPDEBEBJDJF();
			if (WallHackDetector.ELOBJGIDGCP == this)
			{
				WallHackDetector.ELOBJGIDGCP = null;
			}
		}

		// Token: 0x040026B4 RID: 9908
		private const int PAJKKOGMLBB = 4;

		// Token: 0x040026B5 RID: 9909
		private const int BFPHHLLEMGP = 4;

		// Token: 0x040026B6 RID: 9910
		private readonly Vector3 GPNKEOHELMG = new Vector3(0f, 0f, 1f);

		// Token: 0x040026B7 RID: 9911
		private static int MHEKHLHNDMK;

		// Token: 0x040026B8 RID: 9912
		private readonly WaitForEndOfFrame BEHCPDIAOCK = new WaitForEndOfFrame();

		// Token: 0x040026B9 RID: 9913
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
		[SerializeField]
		private bool checkRigidbody = true;

		// Token: 0x040026BA RID: 9914
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
		[SerializeField]
		private bool checkController = true;

		// Token: 0x040026BB RID: 9915
		[Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
		[SerializeField]
		private bool checkWireframe = true;

		// Token: 0x040026BC RID: 9916
		[Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
		[SerializeField]
		private bool checkRaycast = true;

		// Token: 0x040026BD RID: 9917
		[Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int wireframeDelay = 10;

		// Token: 0x040026BE RID: 9918
		[Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int raycastDelay = 10;

		// Token: 0x040026BF RID: 9919
		[Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
		public Vector3 spawnPosition;

		// Token: 0x040026C0 RID: 9920
		[Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
		public byte maxFalsePositives = 3;

		// Token: 0x040026C1 RID: 9921
		private GameObject CBJBCGPGFOB;

		// Token: 0x040026C2 RID: 9922
		private GameObject PENOMILAHFO;

		// Token: 0x040026C3 RID: 9923
		private GameObject ILKFAFKDFMP;

		// Token: 0x040026C4 RID: 9924
		private Camera FDCOEBNMJAO;

		// Token: 0x040026C5 RID: 9925
		private MeshRenderer IKAGGKEBJDF;

		// Token: 0x040026C6 RID: 9926
		private MeshRenderer OPPJKGEAFBO;

		// Token: 0x040026C7 RID: 9927
		private Color KFPCGJKHEGO = Color.black;

		// Token: 0x040026C8 RID: 9928
		private Color FEADJBOJFNF = Color.black;

		// Token: 0x040026C9 RID: 9929
		private Shader KLABEHHEFLB;

		// Token: 0x040026CA RID: 9930
		private Material DLHHAIFHAGH;

		// Token: 0x040026CB RID: 9931
		private Texture2D INPHLIBIPIN;

		// Token: 0x040026CC RID: 9932
		private Texture2D BJCHAHNEDMB;

		// Token: 0x040026CD RID: 9933
		private RenderTexture NMLAKJJJDMA;

		// Token: 0x040026CE RID: 9934
		private int DFLLGGIOFMG = -1;

		// Token: 0x040026CF RID: 9935
		private int KPEEHJANFEK = -1;

		// Token: 0x040026D0 RID: 9936
		private Rigidbody IACBKBFHPON;

		// Token: 0x040026D1 RID: 9937
		private CharacterController MJADBEOOANP;

		// Token: 0x040026D2 RID: 9938
		private float HAKEOOHOPAI;

		// Token: 0x040026D3 RID: 9939
		private byte NAIOFNBNHBF;

		// Token: 0x040026D4 RID: 9940
		private byte GJLNHDAKIEE;

		// Token: 0x040026D5 RID: 9941
		private byte ANJNEMGDJIM;

		// Token: 0x040026D6 RID: 9942
		private byte HIHEODGMAED;

		// Token: 0x040026D7 RID: 9943
		private bool JNLJFKPADMJ;

		// Token: 0x040026D9 RID: 9945
		internal static string NOHECDAMLMH = "WallHack Detector";

		// Token: 0x040026DA RID: 9946
		internal static string DCFKMNDDJCJ = "[ACTk] WallHack Detector: ";

		// Token: 0x040026DB RID: 9947
		private static string AIKOOIGJODN = "[WH Detector Service]";

		// Token: 0x040026DC RID: 9948
		private static string JDKOMMGPLLF = "Hidden/ACTk/WallHackTexture";
	}
}
