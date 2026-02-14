using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
	// Token: 0x020003A2 RID: 930
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		// Token: 0x0600C901 RID: 51457 RVA: 0x0059D479 File Offset: 0x0059B679
		private void ONIHHFLOJMN()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning(": ");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C902 RID: 51458 RVA: 0x0059D4B0 File Offset: 0x0059B6B0
		private void HDFCIACDDEK()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("demoDouble");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C903 RID: 51459 RVA: 0x0059D4E8 File Offset: 0x0059B6E8
		private void DLKJAKIAFMN()
		{
			float d = CELBHNONENJ.LBBLPMHONLE(" ms");
			float d2 = CELBHNONENJ.LBBLPMHONLE("FOG_VOID_SPHERE");
			bool key = Input.GetKey((KeyCode)(-51));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1326f, 730f, 1624f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)137))
			{
				this.JAKNNOCCOPF *= 1078f;
			}
			this.LGPEMMJGNCD.ONGLOCLINIM(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600C904 RID: 51460 RVA: 0x0059D5E0 File Offset: 0x0059B7E0
		private void CNOKLKPLEKP()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("_OcclusionColor");
			float d2 = CELBHNONENJ.LBBLPMHONLE("componentD");
			bool key = Input.GetKey((KeyCode)87);
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(501f, 896f, 755f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey(KeyCode.X))
			{
				this.JAKNNOCCOPF *= 1890f;
			}
			this.LGPEMMJGNCD.MKEMPIEPDGK(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600C905 RID: 51461 RVA: 0x0059D6D8 File Offset: 0x0059B8D8
		private void KHAEPCKACBD()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("invn_rec14");
			float d2 = CELBHNONENJ.LBBLPMHONLE("CP1");
			bool key = Input.GetKey((KeyCode)(-22));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1556f, 1438f, 521f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)(-108)))
			{
				this.JAKNNOCCOPF *= 1340f;
			}
			this.LGPEMMJGNCD.BCBPAJDGBJD(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600C906 RID: 51462 RVA: 0x0059D7CF File Offset: 0x0059B9CF
		private void KEMGOLACEHI()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("TOD_Fogginess");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C907 RID: 51463 RVA: 0x0059D806 File Offset: 0x0059BA06
		private void CGMHGDEKDEP()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("MotorbikeSeatStand");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C908 RID: 51464 RVA: 0x0059D83D File Offset: 0x0059BA3D
		private void CBBLGEDCJBF()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("_BaseTex");
			}
		}

		// Token: 0x0600C909 RID: 51465 RVA: 0x0059D857 File Offset: 0x0059BA57
		private void IGEICBNMPAD()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("</color>\n");
			}
		}

		// Token: 0x0600C90A RID: 51466 RVA: 0x0059D871 File Offset: 0x0059BA71
		private void JLFBDOPFDDJ()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("\n");
			}
		}

		// Token: 0x0600C90B RID: 51467 RVA: 0x0059D88B File Offset: 0x0059BA8B
		private void BNKJNBIDPME()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("Collapse");
			}
		}

		// Token: 0x0600C90C RID: 51468 RVA: 0x0059D8A5 File Offset: 0x0059BAA5
		private void CAJLCEPLKJG()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("</color>");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C90D RID: 51469 RVA: 0x0059D8DC File Offset: 0x0059BADC
		private void EHFPLKEINFO()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("IdleMonster");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C90E RID: 51470 RVA: 0x0059D913 File Offset: 0x0059BB13
		private void KJJBBLDJHPD()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("droplinemsg1");
			}
		}

		// Token: 0x0600C90F RID: 51471 RVA: 0x0059D930 File Offset: 0x0059BB30
		private void EDGFFIEPGPD()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("<color='#003000'>");
			float d2 = CELBHNONENJ.LBBLPMHONLE(" ");
			bool key = Input.GetKey((KeyCode)(-45));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1061f, 323f, 225f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)155))
			{
				this.JAKNNOCCOPF *= 1365f;
			}
			this.LGPEMMJGNCD.LOIHEBEJOMI(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600C910 RID: 51472 RVA: 0x0059DA28 File Offset: 0x0059BC28
		private void BGLIJMGAHLP()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("Trying to solve uninitiated FABRIK chain.");
			float d2 = CELBHNONENJ.LBBLPMHONLE("_Radius");
			bool key = Input.GetKey((KeyCode)(-16));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1081f, 1998f, 942f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)(-49)))
			{
				this.JAKNNOCCOPF *= 1429f;
			}
			this.LGPEMMJGNCD.LOIHEBEJOMI(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600C911 RID: 51473 RVA: 0x0059DB20 File Offset: 0x0059BD20
		private void GPNKIPJNFNF()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("pf2m");
			float d2 = CELBHNONENJ.LBBLPMHONLE(".");
			bool key = Input.GetKey(KeyCode.Ampersand);
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1703f, 45f, 561f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)(-147)))
			{
				this.JAKNNOCCOPF *= 260f;
			}
			this.LGPEMMJGNCD.HPGBIANDJPO(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600C912 RID: 51474 RVA: 0x0059DC18 File Offset: 0x0059BE18
		private void JFNOIJPDNDP()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("#FF4040");
			float d2 = CELBHNONENJ.LBBLPMHONLE("The shader ");
			bool key = Input.GetKey((KeyCode)(-127));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(554f, 1147f, 842f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)183))
			{
				this.JAKNNOCCOPF *= 442f;
			}
			this.LGPEMMJGNCD.MKEMPIEPDGK(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x0059DD0F File Offset: 0x0059BF0F
		private void MEFOGCFJBNE()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("31");
			}
		}

		// Token: 0x0600C914 RID: 51476 RVA: 0x0059DD2C File Offset: 0x0059BF2C
		private void FixedUpdate()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("Horizontal");
			float d2 = CELBHNONENJ.LBBLPMHONLE("Vertical");
			bool key = Input.GetKey(KeyCode.C);
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1f, 0f, 1f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey(KeyCode.LeftShift))
			{
				this.JAKNNOCCOPF *= 0.5f;
			}
			this.LGPEMMJGNCD.Move(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600C915 RID: 51477 RVA: 0x0059DE24 File Offset: 0x0059C024
		private void JGHJFFPIOGN()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("DepthMaskBlendMaterial");
			float d2 = CELBHNONENJ.LBBLPMHONLE("Brake");
			bool key = Input.GetKey((KeyCode)(-126));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1322f, 339f, 345f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)(-78)))
			{
				this.JAKNNOCCOPF *= 1045f;
			}
			this.LGPEMMJGNCD.LLBLGDJGIMP(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600C916 RID: 51478 RVA: 0x0059DF1B File Offset: 0x0059C11B
		private void HMEAENGBFKC()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("cut.ogg");
			}
		}

		// Token: 0x0600C917 RID: 51479 RVA: 0x0059DF35 File Offset: 0x0059C135
		private void Update()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("Jump");
			}
		}

		// Token: 0x0600C918 RID: 51480 RVA: 0x0059DF50 File Offset: 0x0059C150
		private void INFDDDBIPAB()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("Run Back Right");
			float d2 = CELBHNONENJ.LBBLPMHONLE("WandAttack2");
			bool key = Input.GetKey((KeyCode)(-32));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(691f, 86f, 369f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)(-121)))
			{
				this.JAKNNOCCOPF *= 1516f;
			}
			this.LGPEMMJGNCD.PEGCCIJGGDP(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600C919 RID: 51481 RVA: 0x0059E047 File Offset: 0x0059C247
		private void KKCFKEDABLB()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("Apply 2");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C91A RID: 51482 RVA: 0x0059E07E File Offset: 0x0059C27E
		private void PMKOAHMNBBG()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("inv_invheader");
			}
		}

		// Token: 0x0600C91C RID: 51484 RVA: 0x0059E098 File Offset: 0x0059C298
		private void EFJDBBDMPMC()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("RollerBladeRoll");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C91D RID: 51485 RVA: 0x0059E0CF File Offset: 0x0059C2CF
		private void MCHAAIIHOKD()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("Flap_07.wav");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C91E RID: 51486 RVA: 0x0059E106 File Offset: 0x0059C306
		private void Start()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C91F RID: 51487 RVA: 0x0059E13D File Offset: 0x0059C33D
		private void BMNJGPIPKLL()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("ff2000");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C920 RID: 51488 RVA: 0x0059E174 File Offset: 0x0059C374
		private void ANHOOJFEJJE()
		{
			if (Camera.main != null)
			{
				this.JGKJBAJLKLI = Camera.main.transform;
			}
			else
			{
				Debug.LogWarning("");
			}
			this.LGPEMMJGNCD = base.GetComponent<ThirdPersonCharacter>();
		}

		// Token: 0x0600C921 RID: 51489 RVA: 0x0059E1AC File Offset: 0x0059C3AC
		private void LJDGIHMLNLL()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("_EmissionColor");
			float d2 = CELBHNONENJ.LBBLPMHONLE("spinbreak.ogg");
			bool key = Input.GetKey((KeyCode)14);
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1725f, 1150f, 1485f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)(-119)))
			{
				this.JAKNNOCCOPF *= 728f;
			}
			this.LGPEMMJGNCD.ONGLOCLINIM(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600C922 RID: 51490 RVA: 0x0059E2A4 File Offset: 0x0059C4A4
		private void JGCOLIFLHLP()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("IdleSad");
			float d2 = CELBHNONENJ.LBBLPMHONLE("IdleSpew");
			bool key = Input.GetKey((KeyCode)82);
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(1296f, 127f, 1139f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)(-90)))
			{
				this.JAKNNOCCOPF *= 332f;
			}
			this.LGPEMMJGNCD.HMMKAGPJEAC(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600C923 RID: 51491 RVA: 0x0059E39C File Offset: 0x0059C59C
		private void JDKKDAKIPHO()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("selColor");
			float d2 = CELBHNONENJ.LBBLPMHONLE("MotorbikeBackwardStand");
			bool key = Input.GetKey((KeyCode)(-15));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(278f, 1066f, 1849f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)133))
			{
				this.JAKNNOCCOPF *= 1239f;
			}
			this.LGPEMMJGNCD.Move(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600C924 RID: 51492 RVA: 0x0059E493 File Offset: 0x0059C693
		private void BJOICAKCPLI()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("toFishPoint");
			}
		}

		// Token: 0x0600C925 RID: 51493 RVA: 0x0059E4AD File Offset: 0x0059C6AD
		private void OHKHOAKCENL()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("_Texture");
			}
		}

		// Token: 0x0600C926 RID: 51494 RVA: 0x0059E4C8 File Offset: 0x0059C6C8
		private void EAOPJLPOALK()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("PistolInstant");
			float d2 = CELBHNONENJ.LBBLPMHONLE("[ACTk] WallHack Detector: can't detect wireframe cheats on this platform!");
			bool key = Input.GetKey((KeyCode)(-104));
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(342f, 1202f, 560f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)133))
			{
				this.JAKNNOCCOPF *= 604f;
			}
			this.LGPEMMJGNCD.ONGLOCLINIM(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600C927 RID: 51495 RVA: 0x0059E5BF File Offset: 0x0059C7BF
		private void PNBGJBMJLFM()
		{
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("{0}{1}{2}{3}");
			}
		}

		// Token: 0x0600C928 RID: 51496 RVA: 0x0059E5DC File Offset: 0x0059C7DC
		private void DCKNNIMDPMP()
		{
			float d = CELBHNONENJ.LBBLPMHONLE("_NAME");
			float d2 = CELBHNONENJ.LBBLPMHONLE("Road Points Marker Left");
			bool key = Input.GetKey(KeyCode.Z);
			if (this.JGKJBAJLKLI != null)
			{
				this.GCJFFKELIBB = Vector3.Scale(this.JGKJBAJLKLI.forward, new Vector3(372f, 230f, 909f)).normalized;
				this.JAKNNOCCOPF = d2 * this.GCJFFKELIBB + d * this.JGKJBAJLKLI.right;
			}
			else
			{
				this.JAKNNOCCOPF = d2 * Vector3.forward + d * Vector3.right;
			}
			if (Input.GetKey((KeyCode)160))
			{
				this.JAKNNOCCOPF *= 976f;
			}
			this.LGPEMMJGNCD.PEGCCIJGGDP(this.JAKNNOCCOPF, key, this.EHLNFFBJFEL);
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x04001A9E RID: 6814
		private ThirdPersonCharacter LGPEMMJGNCD;

		// Token: 0x04001A9F RID: 6815
		private Transform JGKJBAJLKLI;

		// Token: 0x04001AA0 RID: 6816
		private Vector3 GCJFFKELIBB;

		// Token: 0x04001AA1 RID: 6817
		private Vector3 JAKNNOCCOPF;

		// Token: 0x04001AA2 RID: 6818
		private bool EHLNFFBJFEL;
	}
}
