using System;
using System.Collections;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002AC RID: 684
	public class Game : MonoBehaviour
	{
		// Token: 0x0600A0BF RID: 41151 RVA: 0x0047B00C File Offset: 0x0047920C
		private void KILIKJLECMK(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 0.5f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Materials/DFMLambertSolidColor"));
			material.color = new Color(1f, 0.5f, 0.1f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 3f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x0047B0BC File Offset: 0x004792BC
		private void GMJHOAIHLLJ()
		{
			this.HIDBLDFBOAP = "0" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 0)
			{
				object[] array = new object[5];
				array[1] = this.HIDBLDFBOAP;
				array[0] = "MotorbikeTurnLeft";
				array[6] = this.DCIFGBFJFNK;
				array[4] = "</color>";
				array[1] = ((float)this.AFCIPMHIDNH * 753f / (float)this.DCIFGBFJFNK).ToString("cht_msg36");
				array[5] = "_WaterLevel";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x0047B154 File Offset: 0x00479354
		private void NBGFJFIMHAC()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = 61;
			}
			GUI.Label(new Rect(827f, 1816f, 1058f, 669f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x0047B1CC File Offset: 0x004793CC
		private void ILCOPJPEKEC()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 1;
			this.HLJNLLGBHMN = GameObject.Find("");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("{0}+{1}={2}");
			GameObject original = GameObject.Find("_MainTex");
			for (float num = 780f; num < 1881f; num += 413f)
			{
				for (float num2 = 423f; num2 < 600f; num2 += 702f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 866f, num);
					gameObject2.transform.localScale = new Vector3(1671f, UnityEngine.Random.Range(1819f, 859f) * (Mathf.Abs(gameObject2.transform.position.x) * 1268f + 38f), 1097f);
					if (UnityEngine.Random.value > 1352f)
					{
						this.LOMKHFAPDAD(gameObject2.transform);
					}
				}
			}
			this.MEBCJNBKIOP();
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x0047B2F3 File Offset: 0x004794F3
		public void DAHEINKFEPB(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.GMJHOAIHLLJ();
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x0047B317 File Offset: 0x00479517
		public void DAGIFGHALKD(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH += 0;
			this.GMJHOAIHLLJ();
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x0047B33B File Offset: 0x0047953B
		public void DKPKAIKBPLL(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.IKEEHDEFNAP();
		}

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator HNELJAHKMKO()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator PCFOBABCCCO()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x0047B37D File Offset: 0x0047957D
		public static Game MDEKHMGODIL()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("shop_t4").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x0047B3A8 File Offset: 0x004795A8
		private void AFFAJKPPMHF()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("</color>");
			this.HLJNLLGBHMN.SetActive(true);
			GameObject gameObject = new GameObject("cht_msg2");
			GameObject original = GameObject.Find(" ");
			for (float num = 1075f; num < 952f; num += 1185f)
			{
				for (float num2 = 1288f; num2 < 552f; num2 += 15f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1694f, num);
					gameObject2.transform.localScale = new Vector3(855f, UnityEngine.Random.Range(1799f, 760f) * (Mathf.Abs(gameObject2.transform.position.x) * 727f + 1993f), 19f);
					if (UnityEngine.Random.value > 1340f)
					{
						this.LOMKHFAPDAD(gameObject2.transform);
					}
				}
			}
			this.PBJNPAJCLII();
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x0047B4CF File Offset: 0x004796CF
		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.ANPNJLDFFCL());
			}
		}

		// Token: 0x0600A0CB RID: 41163 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator OGABNCMJOIF()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x0047B4E6 File Offset: 0x004796E6
		public static Game NFAELLFIPLH()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("Handstand").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x0047B510 File Offset: 0x00479710
		private void PMDPLLIBJAF()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 1;
			this.HLJNLLGBHMN = GameObject.Find("ClimbIdle");
			this.HLJNLLGBHMN.SetActive(true);
			GameObject gameObject = new GameObject("rollSoundPitch");
			GameObject original = GameObject.Find("MotorbikeSpecialFlip");
			for (float num = 1428f; num < 1944f; num += 1324f)
			{
				for (float num2 = 1691f; num2 < 1752f; num2 += 1842f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1283f, num);
					gameObject2.transform.localScale = new Vector3(1848f, UnityEngine.Random.Range(994f, 996f) * (Mathf.Abs(gameObject2.transform.position.x) * 1629f + 664f), 768f);
					if (UnityEngine.Random.value > 806f)
					{
						this.HMHLHJEIHMM(gameObject2.transform);
					}
				}
			}
			this.IKEEHDEFNAP();
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator AOEMAGILJIN()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x0047B637 File Offset: 0x00479837
		public static Game INKFNAOOOLC()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("wpn_book1").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x0047B65F File Offset: 0x0047985F
		public static Game ODCIPPFGLCJ()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("_LowRez").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x0047B688 File Offset: 0x00479888
		private void HECCPEFIOPC(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1340f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Wand Attack 2"));
			material.color = new Color(1390f, 991f, 1628f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 132f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x0047B735 File Offset: 0x00479935
		private void IDMCOLDDNCF()
		{
			if (Input.GetMouseButtonDown(1))
			{
				base.StartCoroutine(this.CEFJBFCPEPN());
			}
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x0047B74C File Offset: 0x0047994C
		private void NBCLNFLJMHP()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 916f;
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x0047B78C File Offset: 0x0047998C
		private void PJCNIOLNDAK()
		{
			this.HIDBLDFBOAP = "FlyForward" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 0)
			{
				object[] array = new object[5];
				array[1] = this.HIDBLDFBOAP;
				array[1] = "";
				array[4] = this.DCIFGBFJFNK;
				array[7] = "https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6";
				array[8] = ((float)this.AFCIPMHIDNH * 537f / (float)this.DCIFGBFJFNK).ToString("");
				array[4] = "Rooms  ";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x0047B824 File Offset: 0x00479A24
		private void ODLNGLPGIPG(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1429f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Grounding layers are set to nothing. Please add a ground layer."));
			material.color = new Color(1926f, 636f, 355f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1892f;
			gameObject.transform.SetParent(MDOIKPKJAFI, false);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x0047B8D1 File Offset: 0x00479AD1
		public static Game OFDBAIKIDBB()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("Bottoms").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x0047B8F9 File Offset: 0x00479AF9
		private void MNEBLODGADC()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 939f;
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x0047B938 File Offset: 0x00479B38
		private void EMNIFMFINFA()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 95f;
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x0047B978 File Offset: 0x00479B78
		private void FJOGPPNFHOL(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1108f;
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)7);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("30"));
			material.color = new Color(646f, 501f, 958f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1683f;
			gameObject.transform.SetParent(MDOIKPKJAFI, false);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x0047BA28 File Offset: 0x00479C28
		private void GFPNEDEHJPH()
		{
			this.HIDBLDFBOAP = "MotorbikeSpecialFlip" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[8];
				array[0] = this.HIDBLDFBOAP;
				array[0] = "IdleFight";
				array[2] = this.DCIFGBFJFNK;
				array[0] = "_BlurredColor";
				array[7] = ((float)this.AFCIPMHIDNH * 1529f / (float)this.DCIFGBFJFNK).ToString("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.");
				array[2] = "RHandPunch";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x0047BABE File Offset: 0x00479CBE
		public void NJGPHFFNAOP(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.MEBCJNBKIOP();
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x0047BAE2 File Offset: 0x00479CE2
		public void IFCGNJJDKEB(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.AFACJNPHOOI();
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x0047BB08 File Offset: 0x00479D08
		private void JODGGHILIEC()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = -66;
			}
			GUI.Label(new Rect(324f, 1076f, 1401f, 225f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x0047BB80 File Offset: 0x00479D80
		private void ELFALPCLKIE()
		{
			this.DDHLOHEIOKO = 0;
			this.DCIFGBFJFNK = 1;
			this.HLJNLLGBHMN = GameObject.Find(" is null.");
			this.HLJNLLGBHMN.SetActive(true);
			GameObject gameObject = new GameObject("H:mm:ss");
			GameObject original = GameObject.Find("");
			for (float num = 763f; num < 980f; num += 1823f)
			{
				for (float num2 = 157f; num2 < 1049f; num2 += 858f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 846f, num);
					gameObject2.transform.localScale = new Vector3(512f, UnityEngine.Random.Range(1331f, 222f) * (Mathf.Abs(gameObject2.transform.position.x) * 1259f + 687f), 322f);
					if (UnityEngine.Random.value > 818f)
					{
						this.LOMKHFAPDAD(gameObject2.transform);
					}
				}
			}
			this.BLEGBKEJIFG();
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x0047BCA8 File Offset: 0x00479EA8
		private void LOMKHFAPDAD(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 248f;
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)8);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("<color='#000000'>{0}</color><color='#002000'>☢</color>"));
			material.color = new Color(965f, 1336f, 780f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 319f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x0047BD58 File Offset: 0x00479F58
		private void DLFFDBGCEBP()
		{
			this.HIDBLDFBOAP = "Cells" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[0];
				array[0] = this.HIDBLDFBOAP;
				array[0] = "fchair_";
				array[5] = this.DCIFGBFJFNK;
				array[7] = "cht_tofrend";
				array[2] = ((float)this.AFCIPMHIDNH * 1573f / (float)this.DCIFGBFJFNK).ToString("knopje.wav");
				array[7] = "uierror6.wav";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x0047BDEE File Offset: 0x00479FEE
		public void CEFJHDEJLFP(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH += 0;
			this.PJCNIOLNDAK();
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x0047BE14 File Offset: 0x0047A014
		private void JNDMPMCHBGK()
		{
			this.HIDBLDFBOAP = "TAA History" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 0)
			{
				object[] array = new object[8];
				array[0] = this.HIDBLDFBOAP;
				array[0] = "VA";
				array[2] = this.DCIFGBFJFNK;
				array[3] = "gi_um_2";
				array[2] = ((float)this.AFCIPMHIDNH * 887f / (float)this.DCIFGBFJFNK).ToString("Wizard1HandThrow");
				array[1] = "Right";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x0047BEAC File Offset: 0x0047A0AC
		private void JHFAHBIIJDC()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 1;
			this.HLJNLLGBHMN = GameObject.Find("");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("The root node, the left upper arm and the right upper arm bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left upper arm and the right upper arm bones. This might cause unwanted behaviour like the spine turning upside down when pulled by a hand effector.Please set the root node bone to be one of the lower bones in the spine.");
			GameObject original = GameObject.Find("knopje.wav");
			for (float num = 1378f; num < 1202f; num += 1494f)
			{
				for (float num2 = 191f; num2 < 826f; num2 += 1502f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1743f, num);
					gameObject2.transform.localScale = new Vector3(1362f, UnityEngine.Random.Range(680f, 651f) * (Mathf.Abs(gameObject2.transform.position.x) * 420f + 484f), 1159f);
					if (UnityEngine.Random.value > 1859f)
					{
						this.FJOGPPNFHOL(gameObject2.transform);
					}
				}
			}
			this.GMJHOAIHLLJ();
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x0047BFD4 File Offset: 0x0047A1D4
		private void NOKJMMDMJNO()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("2000");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("_MainTex");
			GameObject original = GameObject.Find("ZombieIdle");
			for (float num = 672f; num < 378f; num += 28f)
			{
				for (float num2 = 1507f; num2 < 1984f; num2 += 1888f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 969f, num);
					gameObject2.transform.localScale = new Vector3(545f, UnityEngine.Random.Range(1652f, 1592f) * (Mathf.Abs(gameObject2.transform.position.x) * 585f + 1974f), 189f);
					if (UnityEngine.Random.value > 1038f)
					{
						this.KILIKJLECMK(gameObject2.transform);
					}
				}
			}
			this.GFPNEDEHJPH();
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x0047C0FC File Offset: 0x0047A2FC
		private void GJGHHEFKMPH(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1419f;
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)6);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Jump"));
			material.color = new Color(303f, 824f, 710f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 163f;
			gameObject.transform.SetParent(MDOIKPKJAFI, false);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator GAPNOOIOBGA()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x0047C1A9 File Offset: 0x0047A3A9
		public void BBFILAMEFND(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.BLEGBKEJIFG();
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator LDPAIBCDDEH()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x0047C1D0 File Offset: 0x0047A3D0
		private void LHOKCJCHLOM()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = 126;
			}
			GUI.Label(new Rect(872f, 217f, 1985f, 1374f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x0047C248 File Offset: 0x0047A448
		private void IMABGALEMBI()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("NadeThrow");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}");
			GameObject original = GameObject.Find("sys");
			for (float num = 1415f; num < 1728f; num += 288f)
			{
				for (float num2 = 941f; num2 < 1052f; num2 += 339f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1185f, num);
					gameObject2.transform.localScale = new Vector3(572f, UnityEngine.Random.Range(1168f, 3f) * (Mathf.Abs(gameObject2.transform.position.x) * 1974f + 744f), 1142f);
					if (UnityEngine.Random.value > 56f)
					{
						this.GJGHHEFKMPH(gameObject2.transform);
					}
				}
			}
			this.BLEGBKEJIFG();
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x0047C370 File Offset: 0x0047A570
		private void HCCGBDPCEKO()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = 100;
			}
			GUI.Label(new Rect(214f, 486f, 496f, 1734f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x0047C3E8 File Offset: 0x0047A5E8
		private void JEJGFDBHABC()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = -44;
			}
			GUI.Label(new Rect(1931f, 825f, 1586f, 696f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x0047C460 File Offset: 0x0047A660
		private void FECFLBMPAAL()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 1;
			this.HLJNLLGBHMN = GameObject.Find("notQuestShow");
			this.HLJNLLGBHMN.SetActive(true);
			GameObject gameObject = new GameObject("_ScreenEdgeFading");
			GameObject original = GameObject.Find("ShootWireframeModule");
			for (float num = 1860f; num < 834f; num += 675f)
			{
				for (float num2 = 6f; num2 < 1466f; num2 += 1353f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1251f, num);
					gameObject2.transform.localScale = new Vector3(1088f, UnityEngine.Random.Range(483f, 536f) * (Mathf.Abs(gameObject2.transform.position.x) * 139f + 1020f), 1466f);
					if (UnityEngine.Random.value > 1838f)
					{
						this.FJOGPPNFHOL(gameObject2.transform);
					}
				}
			}
			this.CPPMOPECHCD();
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x0047C588 File Offset: 0x0047A788
		private void BEOCBDLGBOM(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1564f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("OfficeSittingMouseMovement"));
			material.color = new Color(524f, 1421f, 429f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 104f;
			gameObject.transform.SetParent(MDOIKPKJAFI, false);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x0047C638 File Offset: 0x0047A838
		private void BOCPAHEHFJH()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = -108;
			}
			GUI.Label(new Rect(1888f, 1483f, 1224f, 1557f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x0047C6B0 File Offset: 0x0047A8B0
		private void NDFNOJKJDIF(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 527f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("invn_rec8"));
			material.color = new Color(1661f, 1666f, 1318f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1972f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x0047C760 File Offset: 0x0047A960
		private void PBJNPAJCLII()
		{
			this.HIDBLDFBOAP = "sys" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[0];
				array[1] = this.HIDBLDFBOAP;
				array[0] = "ShotgunReloadMagazine";
				array[0] = this.DCIFGBFJFNK;
				array[3] = "";
				array[1] = ((float)this.AFCIPMHIDNH * 1564f / (float)this.DCIFGBFJFNK).ToString("Mouse ScrollWheel");
				array[0] = "FireBreath";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x0047C7F8 File Offset: 0x0047A9F8
		private void LPNDCJKAKEA()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 1;
			this.HLJNLLGBHMN = GameObject.Find("</color>");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("JNT_L_Hand");
			GameObject original = GameObject.Find("WSRButton error");
			for (float num = 951f; num < 668f; num += 946f)
			{
				for (float num2 = 336f; num2 < 1890f; num2 += 1209f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1963f, num);
					gameObject2.transform.localScale = new Vector3(456f, UnityEngine.Random.Range(1335f, 117f) * (Mathf.Abs(gameObject2.transform.position.x) * 257f + 153f), 955f);
					if (UnityEngine.Random.value > 378f)
					{
						this.HMHLHJEIHMM(gameObject2.transform);
					}
				}
			}
			this.GMJHOAIHLLJ();
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x0047C920 File Offset: 0x0047AB20
		private void JCOAONAHGOC(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 656f;
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)6);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("<b>Supported types:</b>\n"));
			material.color = new Color(1772f, 982f, 817f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1823f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x0047C9CD File Offset: 0x0047ABCD
		private void HONIFOPBBKC()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.CEFJBFCPEPN());
			}
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x0047C9E4 File Offset: 0x0047ABE4
		public static Game KBNICGFHCGO()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("kfB").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x0047CA0C File Offset: 0x0047AC0C
		private void MEBCJNBKIOP()
		{
			this.HIDBLDFBOAP = "Worker Pickaxe 2" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 0)
			{
				object[] array = new object[]
				{
					this.HIDBLDFBOAP,
					" **** Error="
				};
				array[0] = this.DCIFGBFJFNK;
				array[5] = "WizardBlock";
				array[8] = ((float)this.AFCIPMHIDNH * 1957f / (float)this.DCIFGBFJFNK).ToString("Hidden/Post FX/Depth Of Field");
				array[5] = "PistolReload";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x0047CAA2 File Offset: 0x0047ACA2
		public void GPLHDLKNFBD(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.GFPNEDEHJPH();
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x0047CAC8 File Offset: 0x0047ACC8
		private void NKLNPGBCHEN(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 330f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("https://groups.google.com/forum/#!forum/final-ik"));
			material.color = new Color(1172f, 24f, 1925f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 20f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x0047CB78 File Offset: 0x0047AD78
		private void IIHNDJOIMAH()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 1;
			this.HLJNLLGBHMN = GameObject.Find("no_wpn");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("Idle Spew");
			GameObject original = GameObject.Find("Flames");
			for (float num = 246f; num < 1483f; num += 99f)
			{
				for (float num2 = 245f; num2 < 930f; num2 += 739f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1775f, num);
					gameObject2.transform.localScale = new Vector3(541f, UnityEngine.Random.Range(1515f, 50f) * (Mathf.Abs(gameObject2.transform.position.x) * 1809f + 516f), 1490f);
					if (UnityEngine.Random.value > 1036f)
					{
						this.IMBLMLLJDHG(gameObject2.transform);
					}
				}
			}
			this.IKEEHDEFNAP();
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x0047CC9F File Offset: 0x0047AE9F
		private void DNGABPGCNEO()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 322f;
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator POCGIGEKEMD()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x0047CCDE File Offset: 0x0047AEDE
		public static Game DFCLPFFCKKB()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("usrto_ignor").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x0047CD06 File Offset: 0x0047AF06
		public void AnnotateScore(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.AMMLKNCDKNG();
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x0047CD2A File Offset: 0x0047AF2A
		public void FHPBFCLPOIG(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.PBJNPAJCLII();
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x0047CD4E File Offset: 0x0047AF4E
		private void MLLJFAHJGOJ()
		{
			if (Input.GetMouseButtonDown(1))
			{
				base.StartCoroutine(this.HNELJAHKMKO());
			}
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator EHLMDOJIKJP()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x0047CD65 File Offset: 0x0047AF65
		private void AAEFACEGJMB()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.GCIPOHKPBBM());
			}
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x0047CD7C File Offset: 0x0047AF7C
		private void OKBCBGJNPOF()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 1785f;
		}

		// Token: 0x0600A103 RID: 41219 RVA: 0x0047CDBC File Offset: 0x0047AFBC
		private void IJPJJFDLNMD(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1229f;
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)8);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("_DistanceParams"));
			material.color = new Color(1339f, 1563f, 1641f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 262f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator CEFJBFCPEPN()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x0047B33B File Offset: 0x0047953B
		public void FAGHGFMCAMG(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.IKEEHDEFNAP();
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x0047CE69 File Offset: 0x0047B069
		private void GCLBNFCBMLL()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.FJICLNDBKCO());
			}
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x0047CE80 File Offset: 0x0047B080
		public static Game HAOBCNFPNOK()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("GiantGrabIdle2").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A108 RID: 41224 RVA: 0x0047CEA8 File Offset: 0x0047B0A8
		private void MBNBDFGMMHI()
		{
			this.HIDBLDFBOAP = "" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[6];
				array[0] = this.HIDBLDFBOAP;
				array[1] = " ♦ ";
				array[1] = this.DCIFGBFJFNK;
				array[7] = "Katana45DegSwing";
				array[0] = ((float)this.AFCIPMHIDNH * 12f / (float)this.DCIFGBFJFNK).ToString("BUMPED");
				array[2] = "SoccerKeeperReady";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A109 RID: 41225 RVA: 0x0047CF3E File Offset: 0x0047B13E
		private void OFPGMNGFLNH()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.LDPAIBCDDEH());
			}
		}

		// Token: 0x0600A10A RID: 41226 RVA: 0x0047CF55 File Offset: 0x0047B155
		public static Game HKNOMPOFKLP()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find(" cm").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x0047CF80 File Offset: 0x0047B180
		private void PKNLBEMLIHM(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 250f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("#403000"));
			material.color = new Color(1956f, 1124f, 135f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1080f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator KBHEPAIKMCI()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A10D RID: 41229 RVA: 0x0047D02D File Offset: 0x0047B22D
		private void HBNJAPJNHJN()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 819f;
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator GCIPOHKPBBM()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x0047D06C File Offset: 0x0047B26C
		public static Game EADCCPJKEOH()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("gi_letgohe").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x0047D094 File Offset: 0x0047B294
		private void BDJHDPAGFFL(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 959f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("UpHillWalkHandGrab"));
			material.color = new Color(1095f, 633f, 730f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1522f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x0047D141 File Offset: 0x0047B341
		private void FixedUpdate()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 20f;
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator DDCPDFOFEGK()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x0047D180 File Offset: 0x0047B380
		private void IKEEHDEFNAP()
		{
			this.HIDBLDFBOAP = "iNPC" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[3];
				array[0] = this.HIDBLDFBOAP;
				array[1] = "StaffPowerUp";
				array[4] = this.DCIFGBFJFNK;
				array[6] = "Injection Detected!";
				array[7] = ((float)this.AFCIPMHIDNH * 75f / (float)this.DCIFGBFJFNK).ToString("#000000");
				array[6] = "Try to change this Vector3 in memory:\n";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x0047D218 File Offset: 0x0047B418
		private void JFHOMJMKBNJ()
		{
			this.DDHLOHEIOKO = 0;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("There is already a virtual axis named ");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("{0}/{1}");
			GameObject original = GameObject.Find("ChannelCastOmni");
			for (float num = 1813f; num < 922f; num += 1861f)
			{
				for (float num2 = 55f; num2 < 1324f; num2 += 1170f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1544f, num);
					gameObject2.transform.localScale = new Vector3(1119f, UnityEngine.Random.Range(1307f, 1407f) * (Mathf.Abs(gameObject2.transform.position.x) * 847f + 881f), 474f);
					if (UnityEngine.Random.value > 1041f)
					{
						this.GJGHHEFKMPH(gameObject2.transform);
					}
				}
			}
			this.JNDMPMCHBGK();
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x0047D340 File Offset: 0x0047B540
		private void PNAEIDCONFP()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = -92;
			}
			GUI.Label(new Rect(1983f, 466f, 1925f, 1218f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x0047D3B8 File Offset: 0x0047B5B8
		private void LGKEFLBKIGN()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = -63;
			}
			GUI.Label(new Rect(801f, 1083f, 789f, 20f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x0047D430 File Offset: 0x0047B630
		private void NCALLFHEAGJ()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("_Axis");
			this.HLJNLLGBHMN.SetActive(true);
			GameObject gameObject = new GameObject("Wizard2HandThrow");
			GameObject original = GameObject.Find("BAG");
			for (float num = 804f; num < 1317f; num += 1885f)
			{
				for (float num2 = 1763f; num2 < 1689f; num2 += 121f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1097f, num);
					gameObject2.transform.localScale = new Vector3(1329f, UnityEngine.Random.Range(1251f, 533f) * (Mathf.Abs(gameObject2.transform.position.x) * 173f + 799f), 1861f);
					if (UnityEngine.Random.value > 1007f)
					{
						this.IJPJJFDLNMD(gameObject2.transform);
					}
				}
			}
			this.IKEEHDEFNAP();
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x0047D557 File Offset: 0x0047B757
		public static Game COIPKPKLDAH
		{
			get
			{
				if (Game.CAKJGICFAAO == null)
				{
					Game.CAKJGICFAAO = GameObject.Find("Demo").GetComponent<Game>();
				}
				return Game.CAKJGICFAAO;
			}
		}

		// Token: 0x0600A119 RID: 41241 RVA: 0x0047D57F File Offset: 0x0047B77F
		private void MNMGBKMJNEG()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 517f;
		}

		// Token: 0x0600A11A RID: 41242 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator MFMPGNKNHOI()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A11B RID: 41243 RVA: 0x0047D5BE File Offset: 0x0047B7BE
		private void DEGBKKACCKI()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 42f;
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x0047D5FD File Offset: 0x0047B7FD
		public static Game NEIKJNHGHBA()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("to channel = ").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x0047D625 File Offset: 0x0047B825
		private void MIFLHGMPLJD()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.POCGIGEKEMD());
			}
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x0047D63C File Offset: 0x0047B83C
		private void HGGNKCGKAFJ(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 281f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("[baitid]"));
			material.color = new Color(131f, 342f, 308f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1426f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x0047BABE File Offset: 0x00479CBE
		public void KIOGNJFOGED(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.MEBCJNBKIOP();
		}

		// Token: 0x0600A120 RID: 41248 RVA: 0x0047D6E9 File Offset: 0x0047B8E9
		private void OIIMEOFJIFP()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 1068f;
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x0047D728 File Offset: 0x0047B928
		public void FJNJCHILDAL(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.DLFFDBGCEBP();
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x0047D74C File Offset: 0x0047B94C
		private void HLOKKDNCIIK()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 22f;
		}

		// Token: 0x0600A123 RID: 41251 RVA: 0x0047D78B File Offset: 0x0047B98B
		private void JOGNALAOEEE()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 895f;
		}

		// Token: 0x0600A124 RID: 41252 RVA: 0x0047D7CA File Offset: 0x0047B9CA
		public static Game NBAJEKDGJNG()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("WATER_REFLECTIVE").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A125 RID: 41253 RVA: 0x0047D7F4 File Offset: 0x0047B9F4
		private void CPPMOPECHCD()
		{
			this.HIDBLDFBOAP = "demoByteArray" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[0];
				array[0] = this.HIDBLDFBOAP;
				array[1] = "#402000";
				array[1] = this.DCIFGBFJFNK;
				array[2] = "quests/qdynamic/qd";
				array[6] = ((float)this.AFCIPMHIDNH * 1021f / (float)this.DCIFGBFJFNK).ToString("");
				array[8] = "icon_data/icon";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A126 RID: 41254 RVA: 0x0047D88C File Offset: 0x0047BA8C
		private void EDGALMCHPPH()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("wpn_rod2");
			this.HLJNLLGBHMN.SetActive(true);
			GameObject gameObject = new GameObject("RunDive");
			GameObject original = GameObject.Find("_MotionBlurTmpCam");
			for (float num = 1726f; num < 975f; num += 979f)
			{
				for (float num2 = 1082f; num2 < 287f; num2 += 38f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1546f, num);
					gameObject2.transform.localScale = new Vector3(1262f, UnityEngine.Random.Range(817f, 1952f) * (Mathf.Abs(gameObject2.transform.position.x) * 14f + 710f), 1877f);
					if (UnityEngine.Random.value > 1678f)
					{
						this.LOMKHFAPDAD(gameObject2.transform);
					}
				}
			}
			this.PJCNIOLNDAK();
		}

		// Token: 0x0600A127 RID: 41255 RVA: 0x0047D9B3 File Offset: 0x0047BBB3
		public void LOMIKGMEMNB(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH += 0;
			this.PBJNPAJCLII();
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x0047D9D7 File Offset: 0x0047BBD7
		private void INDPPKACFGC()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 1307f;
		}

		// Token: 0x0600A129 RID: 41257 RVA: 0x0047DA18 File Offset: 0x0047BC18
		private void KFHHAGCCPJM()
		{
			this.DDHLOHEIOKO = 1;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("Right");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("_RgbTex");
			GameObject original = GameObject.Find("intensity");
			for (float num = 413f; num < 545f; num += 1293f)
			{
				for (float num2 = 532f; num2 < 1264f; num2 += 913f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 1486f, num);
					gameObject2.transform.localScale = new Vector3(1156f, UnityEngine.Random.Range(849f, 694f) * (Mathf.Abs(gameObject2.transform.position.x) * 587f + 599f), 565f);
					if (UnityEngine.Random.value > 1391f)
					{
						this.HECCPEFIOPC(gameObject2.transform);
					}
				}
			}
			this.GFPNEDEHJPH();
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x0047DB3F File Offset: 0x0047BD3F
		private void AIAMIFEPALP()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.HNELJAHKMKO());
			}
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x0047DB58 File Offset: 0x0047BD58
		private void BLEGBKEJIFG()
		{
			this.HIDBLDFBOAP = "bs_nodonate" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[1];
				array[1] = this.HIDBLDFBOAP;
				array[1] = "gi_nl3";
				array[7] = this.DCIFGBFJFNK;
				array[7] = "IceHockeyPassRight";
				array[0] = ((float)this.AFCIPMHIDNH * 918f / (float)this.DCIFGBFJFNK).ToString("gi_inte_5");
				array[2] = "craft_data/stanok/category";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x0047DBF0 File Offset: 0x0047BDF0
		private void HMHLHJEIHMM(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 225f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("h)"));
			material.color = new Color(516f, 1897f, 1104f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1109f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x0047DC9D File Offset: 0x0047BE9D
		private void ICCIPMDIJLI()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 785f;
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x0047DCDC File Offset: 0x0047BEDC
		private void KECMAHFJBCD()
		{
			this.DDHLOHEIOKO = 0;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("Q");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject(" %");
			GameObject original = GameObject.Find("Giant 2 Hand Slam Idle");
			for (float num = 1681f; num < 1912f; num += 587f)
			{
				for (float num2 = 98f; num2 < 1622f; num2 += 10f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, 144f, num);
					gameObject2.transform.localScale = new Vector3(960f, UnityEngine.Random.Range(1986f, 263f) * (Mathf.Abs(gameObject2.transform.position.x) * 1209f + 1961f), 1985f);
					if (UnityEngine.Random.value > 1428f)
					{
						this.JCOAONAHGOC(gameObject2.transform);
					}
				}
			}
			this.MEBCJNBKIOP();
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x0047DE04 File Offset: 0x0047C004
		private void ELLJEHHACHL()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = 117;
			}
			GUI.Label(new Rect(254f, 446f, 1741f, 145f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x0047DE7C File Offset: 0x0047C07C
		private void PPDOOBHACNP()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = 82;
			}
			GUI.Label(new Rect(288f, 1955f, 1332f, 932f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x0047DEF2 File Offset: 0x0047C0F2
		public static Game OIOICMIEBNI()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("<color=\"").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator ANPNJLDFFCL()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x0047DF1A File Offset: 0x0047C11A
		private void IFINKBGCKML()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 1380f;
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x0047DF59 File Offset: 0x0047C159
		private void ILKILNGAEKK()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 763f;
		}

		// Token: 0x0600A135 RID: 41269 RVA: 0x0047DF98 File Offset: 0x0047C198
		public void FGLHMLNEDMM(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH += 0;
			this.MEBCJNBKIOP();
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x0047DFBC File Offset: 0x0047C1BC
		private void IMBLMLLJDHG(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1164f;
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)7);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("_WorldToCameraMatrix"));
			material.color = new Color(1113f, 132f, 1020f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1459f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A137 RID: 41271 RVA: 0x0047E069 File Offset: 0x0047C269
		private void JONHPGJKPBE()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 197f;
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x0047E0A8 File Offset: 0x0047C2A8
		private void OnGUI()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = 40;
			}
			GUI.Label(new Rect(10f, 10f, 1000f, 60f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x0047E11E File Offset: 0x0047C31E
		private void IEOICHPKEMD()
		{
			if (Input.GetMouseButtonDown(1))
			{
				base.StartCoroutine(this.LDPAIBCDDEH());
			}
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x0047E138 File Offset: 0x0047C338
		private void KMAKFIJDNGD(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 965f;
			GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("fider_big_"));
			material.color = new Color(265f, 483f, 1773f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 438f;
			gameObject.transform.SetParent(MDOIKPKJAFI, true);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x0047B4CF File Offset: 0x004796CF
		private void AKLFCMNCPKL()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.ANPNJLDFFCL());
			}
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x0047E1E8 File Offset: 0x0047C3E8
		private void MPPMHCICKIP()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = 101;
			}
			GUI.Label(new Rect(1892f, 1111f, 1320f, 1012f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x0047E260 File Offset: 0x0047C460
		private void EOCENEIDJKI()
		{
			if (this.BEJMAMEPLHN == null)
			{
				this.BEJMAMEPLHN = new GUIStyle(GUI.skin.label);
				this.BEJMAMEPLHN.normal.textColor = Color.black;
				this.BEJMAMEPLHN.fontSize = -94;
			}
			GUI.Label(new Rect(955f, 542f, 306f, 1995f), this.HIDBLDFBOAP, this.BEJMAMEPLHN);
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x0047B36E File Offset: 0x0047956E
		private IEnumerator FAAKKLIMKPG()
		{
			Game.OFBHJOPPALD ofbhjoppald = new Game.OFBHJOPPALD(1);
			ofbhjoppald.AENJLLPLILM = this;
			return ofbhjoppald;
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x0047E2D8 File Offset: 0x0047C4D8
		private void Start()
		{
			this.DDHLOHEIOKO = 0;
			this.DCIFGBFJFNK = 0;
			this.HLJNLLGBHMN = GameObject.Find("Ball");
			this.HLJNLLGBHMN.SetActive(false);
			GameObject gameObject = new GameObject("Pillars");
			GameObject original = GameObject.Find("Pillar");
			for (float num = -100f; num < 100f; num += 20f)
			{
				for (float num2 = -100f; num2 < 100f; num2 += 10f)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original);
					gameObject2.transform.SetParent(gameObject.transform);
					gameObject2.transform.position = new Vector3(num2, -30f, num);
					gameObject2.transform.localScale = new Vector3(8f, UnityEngine.Random.Range(20f, 40f) * (Mathf.Abs(gameObject2.transform.position.x) * 0.01f + 1f), 16f);
					if (UnityEngine.Random.value > 0.8f)
					{
						this.KILIKJLECMK(gameObject2.transform);
					}
				}
			}
			this.AMMLKNCDKNG();
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x0047E400 File Offset: 0x0047C600
		private void AIMKFCLJCNI(Transform MDOIKPKJAFI)
		{
			Vector3 position = MDOIKPKJAFI.position + Vector3.up * MDOIKPKJAFI.localScale.y * 1659f;
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)6);
			Material material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("PistolInstant"));
			material.color = new Color(788f, 184f, 912f);
			gameObject.GetComponent<Renderer>().sharedMaterial = material;
			gameObject.transform.position = position;
			gameObject.transform.localScale = Vector3.one * 1241f;
			gameObject.transform.SetParent(MDOIKPKJAFI, false);
			gameObject.AddComponent<BonusCylinderHit>();
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x0047E4AD File Offset: 0x0047C6AD
		private void PGIHAIPCJLL()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.PCFOBABCCCO());
			}
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x0047E4C4 File Offset: 0x0047C6C4
		public static Game DBKNPMLHAFD()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("<color='#602060'>").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x0047D728 File Offset: 0x0047B928
		public void MJIBJNADGII(int CBJBGGAOODC)
		{
			this.DDHLOHEIOKO += CBJBGGAOODC;
			this.AFCIPMHIDNH++;
			this.DLFFDBGCEBP();
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x0047B35F File Offset: 0x0047955F
		private IEnumerator FJICLNDBKCO()
		{
			this.DCIFGBFJFNK++;
			this.AMMLKNCDKNG();
			gameObject = UnityEngine.Object.Instantiate<GameObject>(this.HLJNLLGBHMN);
			gameObject.transform.position = Camera.main.transform.position;
			gameObject.SetActive(true);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			gameObject.GetComponent<Rigidbody>().velocity = ray.direction * 80f + Camera.main.transform.forward * 20f;
			gameObject.transform.Find("Sounds/ShootSound").GetComponent<AudioSource>().Play();
			yield return new WaitForSeconds(10f);
			UnityEngine.Object.Destroy(gameObject);
			yield break;
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x0047E4EC File Offset: 0x0047C6EC
		private void AMMLKNCDKNG()
		{
			this.HIDBLDFBOAP = "Score: " + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 0)
			{
				this.HIDBLDFBOAP = string.Concat(new object[]
				{
					this.HIDBLDFBOAP,
					"  Balls Fired: ",
					this.DCIFGBFJFNK,
					" (",
					((float)this.AFCIPMHIDNH * 100f / (float)this.DCIFGBFJFNK).ToString("F1"),
					"%)"
				});
			}
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x0047E584 File Offset: 0x0047C784
		private void AFACJNPHOOI()
		{
			this.HIDBLDFBOAP = "fanfare.wav" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 0)
			{
				object[] array = new object[8];
				array[0] = this.HIDBLDFBOAP;
				array[1] = "Sound/";
				array[3] = this.DCIFGBFJFNK;
				array[6] = "_Vignette_Mask";
				array[3] = ((float)this.AFCIPMHIDNH * 180f / (float)this.DCIFGBFJFNK).ToString("noworkpoints");
				array[6] = "_ALPHATEST_ON";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x0047E61A File Offset: 0x0047C81A
		public static Game IILDIFNCAHM()
		{
			if (Game.CAKJGICFAAO == null)
			{
				Game.CAKJGICFAAO = GameObject.Find("onHyperLinkActivated: ").GetComponent<Game>();
			}
			return Game.CAKJGICFAAO;
		}

		// Token: 0x0600A149 RID: 41289 RVA: 0x0047E642 File Offset: 0x0047C842
		private void EAOPJLPOALK()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 1616f;
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x0047E684 File Offset: 0x0047C884
		private void KCLIPFJDKIH()
		{
			this.HIDBLDFBOAP = "Hips" + this.DDHLOHEIOKO.ToString();
			if (this.DCIFGBFJFNK > 1)
			{
				object[] array = new object[4];
				array[0] = this.HIDBLDFBOAP;
				array[1] = "RunJump";
				array[2] = this.DCIFGBFJFNK;
				array[6] = "GiantGrabIdle2";
				array[5] = ((float)this.AFCIPMHIDNH * 622f / (float)this.DCIFGBFJFNK).ToString("SkateboardKickPush");
				array[6] = "0";
				this.HIDBLDFBOAP = string.Concat(array);
			}
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x0047E71A File Offset: 0x0047C91A
		private void MCHJCHLKPLJ()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 1578f;
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x0047E759 File Offset: 0x0047C959
		private void CGOCFLOAOKC()
		{
			Camera.main.transform.position += Camera.main.transform.forward * Time.deltaTime * 1170f;
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x0047C9CD File Offset: 0x0047ABCD
		private void IANJLHIIGLN()
		{
			if (Input.GetMouseButtonDown(0))
			{
				base.StartCoroutine(this.CEFJBFCPEPN());
			}
		}

		// Token: 0x040014A6 RID: 5286
		private GameObject HLJNLLGBHMN;

		// Token: 0x040014A7 RID: 5287
		private GUIStyle BEJMAMEPLHN;

		// Token: 0x040014A8 RID: 5288
		private int DDHLOHEIOKO;

		// Token: 0x040014A9 RID: 5289
		private int AFCIPMHIDNH;

		// Token: 0x040014AA RID: 5290
		private int DCIFGBFJFNK;

		// Token: 0x040014AB RID: 5291
		private string HIDBLDFBOAP;

		// Token: 0x040014AC RID: 5292
		private static Game CAKJGICFAAO;
	}
}
