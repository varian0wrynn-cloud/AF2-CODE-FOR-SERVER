using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020002B5 RID: 693
	public class DemoMultipleFogAreas : MonoBehaviour
	{
		// Token: 0x0600A2E5 RID: 41701 RVA: 0x0048E070 File Offset: 0x0048C270
		private void BNKJNBIDPME()
		{
			if (Input.GetKeyDown((KeyCode)(-58)))
			{
				this.CEGLIEIIBOK();
				return;
			}
			if (Input.GetKeyDown((KeyCode)17))
			{
				this.BIDFILIBBPC();
				return;
			}
			if (Input.GetKeyDown(KeyCode.Alpha9))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x0048E0A0 File Offset: 0x0048C2A0
		private void MJDKGMEPMHK()
		{
			GUI.Label(new Rect(1013f, 1644f, (float)(Screen.width - -46), 1131f), "wpn_onlym");
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x0048E0C9 File Offset: 0x0048C2C9
		private void MPPMHCICKIP()
		{
			GUI.Label(new Rect(626f, 1676f, (float)(Screen.width - 18), 1159f), "lineTENSIONKGFRIC=");
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x0048E0F4 File Offset: 0x0048C2F4
		private void HBAGGFIJOKF()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 572f + UnityEngine.Random.insideUnitSphere * 1407f;
			if (vector.y < 731f)
			{
				vector.y = 1196f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 407f + 774f, UnityEngine.Random.value * 1943f + 1571f, UnityEngine.Random.value * 664f + 599f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(854f, 406f, 1683f, 163f);
			volumetricFog.HGABMLKLEPE = 1397f;
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x0048E1C6 File Offset: 0x0048C3C6
		private void DEGCCLNOEKJ()
		{
			if (Input.GetKeyDown((KeyCode)79))
			{
				this.LGJIEAMOKOL();
				return;
			}
			if (Input.GetKeyDown((KeyCode)31))
			{
				this.ILDLLGFEEAJ();
				return;
			}
			if (Input.GetKeyDown(KeyCode.LeftParen))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x0048E1F8 File Offset: 0x0048C3F8
		private void LGJIEAMOKOL()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 404f + UnityEngine.Random.insideUnitSphere * 1969f;
			if (vector.y < 1505f)
			{
				vector.y = 90f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 922f + 385f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1015f, 1312f, 656f, 1618f);
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x0048E297 File Offset: 0x0048C497
		private void LDDIGEMBDNF()
		{
			if (Input.GetKeyDown((KeyCode)(-99)))
			{
				this.CHKHFGKIMMD();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-78)))
			{
				this.BIDFILIBBPC();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-71)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x0048E2C8 File Offset: 0x0048C4C8
		private void HOGNEKCNLPC()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1458f + UnityEngine.Random.insideUnitSphere * 1193f;
			if (vector.y < 930f)
			{
				vector.y = 47f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 1055f + 600f, UnityEngine.Random.value * 320f + 1839f, UnityEngine.Random.value * 291f + 532f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(1998f, 803f, 1485f, 486f);
			volumetricFog.HGABMLKLEPE = 1207f;
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x0048E39C File Offset: 0x0048C59C
		private void CHKHFGKIMMD()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 751f + UnityEngine.Random.insideUnitSphere * 1112f;
			if (vector.y < 1914f)
			{
				vector.y = 1471f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 443f + 1851f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(900f, 1985f, 1043f, 43f);
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x0048E43B File Offset: 0x0048C63B
		private void IOGAKGCADBL()
		{
			if (Input.GetKeyDown(KeyCode.C))
			{
				this.IFPPJNPADJK();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-122)))
			{
				this.BIDFILIBBPC();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-91)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x0048E46C File Offset: 0x0048C66C
		private void EILBDOFPLMP()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 74f + UnityEngine.Random.insideUnitSphere * 1913f;
			if (vector.y < 1652f)
			{
				vector.y = 1113f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 977f + 843f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1856f, 13f, 4f, 898f);
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x0048E50B File Offset: 0x0048C70B
		private void OnGUI()
		{
			GUI.Label(new Rect(10f, 30f, (float)(Screen.width - 20), 30f), "Press C key to create a cloud-shape fog area, B for box-shape fog area, X to remove all.");
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x0048E534 File Offset: 0x0048C734
		private void GCNGEFBKMNC()
		{
			if (Input.GetKeyDown((KeyCode)(-63)))
			{
				this.HEOOCFNFBGF();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-104)))
			{
				this.CKJFEMPPHNG();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-83)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x0048E564 File Offset: 0x0048C764
		private void JGDDEOALNOG()
		{
			GUI.Label(new Rect(358f, 1273f, (float)(Screen.width - -20), 1154f), "space");
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x0048E58D File Offset: 0x0048C78D
		private void JBGGMKEKOAN()
		{
			GUI.Label(new Rect(1486f, 1709f, (float)(Screen.width - -15), 562f), "_BlurRadius4");
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x0048E5B8 File Offset: 0x0048C7B8
		private void CDBLDHDCEBL()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 935f + UnityEngine.Random.insideUnitSphere * 331f;
			if (vector.y < 91f)
			{
				vector.y = 670f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 678f + 1555f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(810f, 1340f, 1314f, 1837f);
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x0048E658 File Offset: 0x0048C858
		private void MKFCOEDMGDH()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 213f + UnityEngine.Random.insideUnitSphere * 273f;
			if (vector.y < 736f)
			{
				vector.y = 144f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 1247f + 203f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(654f, 1381f, 1871f, 399f);
		}

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x0048E6F8 File Offset: 0x0048C8F8
		private void GFPOBKBJIFE()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1609f + UnityEngine.Random.insideUnitSphere * 1419f;
			if (vector.y < 603f)
			{
				vector.y = 1470f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 1801f + 212f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(991f, 1800f, 1812f, 947f);
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x0048E798 File Offset: 0x0048C998
		private void CKJFEMPPHNG()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1760f + UnityEngine.Random.insideUnitSphere * 1873f;
			if (vector.y < 1707f)
			{
				vector.y = 441f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 1190f + 413f, UnityEngine.Random.value * 1227f + 945f, UnityEngine.Random.value * 1667f + 1048f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(1587f, 651f, 2f, 1358f);
			volumetricFog.HGABMLKLEPE = 1467f;
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x0048E86C File Offset: 0x0048CA6C
		private void BNDEBDEBOHK()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 975f + UnityEngine.Random.insideUnitSphere * 1827f;
			if (vector.y < 497f)
			{
				vector.y = 1703f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 848f + 1134f, UnityEngine.Random.value * 1248f + 601f, UnityEngine.Random.value * 104f + 772f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(1775f, 1276f, 1312f, 1207f);
			volumetricFog.HGABMLKLEPE = 315f;
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x0048E940 File Offset: 0x0048CB40
		private void NNKPBKNIBDP()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1214f + UnityEngine.Random.insideUnitSphere * 1714f;
			if (vector.y < 83f)
			{
				vector.y = 732f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 636f + 1802f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(587f, 328f, 261f, 690f);
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x0048E9DF File Offset: 0x0048CBDF
		private void MBADKFPCOEJ()
		{
			GUI.Label(new Rect(136f, 403f, (float)(Screen.width - 119), 550f), "msgNo");
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x0048EA08 File Offset: 0x0048CC08
		private void HEOOCFNFBGF()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1022f + UnityEngine.Random.insideUnitSphere * 1917f;
			if (vector.y < 874f)
			{
				vector.y = 1971f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 561f + 1355f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(127f, 686f, 1854f, 1000f);
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x0048EAA8 File Offset: 0x0048CCA8
		private void DNPLPCJAIIE()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1595f + UnityEngine.Random.insideUnitSphere * 151f;
			if (vector.y < 1547f)
			{
				vector.y = 601f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 330f + 1191f, UnityEngine.Random.value * 795f + 610f, UnityEngine.Random.value * 994f + 1892f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(1004f, 261f, 1556f, 1218f);
			volumetricFog.HGABMLKLEPE = 326f;
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x0048EB7A File Offset: 0x0048CD7A
		private void IKHCCAANGOP()
		{
			if (Input.GetKeyDown((KeyCode)(-32)))
			{
				this.CHKHFGKIMMD();
				return;
			}
			if (Input.GetKeyDown((KeyCode)1))
			{
				this.LOIAHFALDHA();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-11)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x0048EBAC File Offset: 0x0048CDAC
		private void ILDLLGFEEAJ()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 656f + UnityEngine.Random.insideUnitSphere * 1481f;
			if (vector.y < 727f)
			{
				vector.y = 1466f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 1099f + 881f, UnityEngine.Random.value * 1701f + 1162f, UnityEngine.Random.value * 586f + 665f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(14f, 1694f, 1942f, 858f);
			volumetricFog.HGABMLKLEPE = 1181f;
		}

		// Token: 0x0600A300 RID: 41728 RVA: 0x0048EC80 File Offset: 0x0048CE80
		private void GEDDJHANEIO()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 908f + UnityEngine.Random.insideUnitSphere * 6f;
			if (vector.y < 533f)
			{
				vector.y = 65f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 518f + 1199f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(48f, 1668f, 171f, 1380f);
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x0048ED1F File Offset: 0x0048CF1F
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.C))
			{
				this.HEHBOGFLDKK();
				return;
			}
			if (Input.GetKeyDown(KeyCode.B))
			{
				this.DFGHKENELCN();
				return;
			}
			if (Input.GetKeyDown(KeyCode.X))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x0048ED50 File Offset: 0x0048CF50
		private void DFGHKENELCN()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 100f + UnityEngine.Random.insideUnitSphere * 50f;
			if (vector.y < 10f)
			{
				vector.y = 10f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 50f + 35f, UnityEngine.Random.value * 10f + 15f, UnityEngine.Random.value * 50f + 35f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(0.6f, 0.57f, 0.5f, 1f);
			volumetricFog.HGABMLKLEPE = 2f;
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x0048EE22 File Offset: 0x0048D022
		private void JOHDLNOKCOK()
		{
			if (Input.GetKeyDown((KeyCode)(-67)))
			{
				this.GNHGAEAEDFF();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-7)))
			{
				this.ILDLLGFEEAJ();
				return;
			}
			if (Input.GetKeyDown((KeyCode)15))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x0048EE52 File Offset: 0x0048D052
		private void PFPPDNHLCCA()
		{
			if (Input.GetKeyDown(KeyCode.DoubleQuote))
			{
				this.CHKHFGKIMMD();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-48)))
			{
				this.CKJFEMPPHNG();
				return;
			}
			if (Input.GetKeyDown(KeyCode.Pause))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0048EE82 File Offset: 0x0048D082
		private void JPHLMNIMDHH()
		{
			if (Input.GetKeyDown((KeyCode)(-108)))
			{
				this.CEGLIEIIBOK();
				return;
			}
			if (Input.GetKeyDown(KeyCode.Clear))
			{
				this.ILDLLGFEEAJ();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-97)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x0048EEB2 File Offset: 0x0048D0B2
		private void EMFOECIPBIP()
		{
			if (Input.GetKeyDown((KeyCode)(-84)))
			{
				this.IAAGKEJAFKA();
				return;
			}
			if (Input.GetKeyDown(KeyCode.None))
			{
				this.BIDFILIBBPC();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-4)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x0048EEE2 File Offset: 0x0048D0E2
		private void OPDCJCFMIPE()
		{
			if (Input.GetKeyDown((KeyCode)(-111)))
			{
				this.CHKHFGKIMMD();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-64)))
			{
				this.OFAHECDFLDL();
				return;
			}
			if (Input.GetKeyDown((KeyCode)86))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x0048EF14 File Offset: 0x0048D114
		private void GNHGAEAEDFF()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 368f + UnityEngine.Random.insideUnitSphere * 325f;
			if (vector.y < 1392f)
			{
				vector.y = 1616f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 1810f + 568f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1730f, 1390f, 1791f, 748f);
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x0048EFB4 File Offset: 0x0048D1B4
		private void CEGLIEIIBOK()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1632f + UnityEngine.Random.insideUnitSphere * 1713f;
			if (vector.y < 1711f)
			{
				vector.y = 1638f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 1235f + 635f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(654f, 1342f, 45f, 1477f);
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x0048F053 File Offset: 0x0048D253
		private void JAOIOHLFLFO()
		{
			GUI.Label(new Rect(121f, 153f, (float)(Screen.width - 100), 482f), "_isSelect");
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x0048F07C File Offset: 0x0048D27C
		private void PNNLEICICGA()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 451f + UnityEngine.Random.insideUnitSphere * 916f;
			if (vector.y < 1004f)
			{
				vector.y = 680f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 888f + 1883f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1139f, 288f, 1969f, 186f);
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x0048F11B File Offset: 0x0048D31B
		private void PNAEIDCONFP()
		{
			GUI.Label(new Rect(1864f, 1711f, (float)(Screen.width - 81), 1991f), "wpn_wgt");
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x0048F144 File Offset: 0x0048D344
		private void NJMBLDJFAFL()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 530f + UnityEngine.Random.insideUnitSphere * 482f;
			if (vector.y < 688f)
			{
				vector.y = 1596f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 684f + 1641f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1442f, 711f, 419f, 1687f);
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x0048F1E3 File Offset: 0x0048D3E3
		private void AIAMIFEPALP()
		{
			if (Input.GetKeyDown((KeyCode)18))
			{
				this.NNKPBKNIBDP();
				return;
			}
			if (Input.GetKeyDown(KeyCode.At))
			{
				this.CKJFEMPPHNG();
				return;
			}
			if (Input.GetKeyDown((KeyCode)30))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x0048F214 File Offset: 0x0048D414
		private void PNNMFDMGEBI()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 658f + UnityEngine.Random.insideUnitSphere * 66f;
			if (vector.y < 1057f)
			{
				vector.y = 1576f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 690f + 1476f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(803f, 1966f, 784f, 708f);
		}

		// Token: 0x0600A310 RID: 41744 RVA: 0x0048F2B4 File Offset: 0x0048D4B4
		private void NECOAGFOKKB()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 510f + UnityEngine.Random.insideUnitSphere * 1043f;
			if (vector.y < 1172f)
			{
				vector.y = 366f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 446f + 1651f, UnityEngine.Random.value * 1917f + 462f, UnityEngine.Random.value * 1329f + 1064f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(856f, 1624f, 145f, 117f);
			volumetricFog.HGABMLKLEPE = 1801f;
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x0048F388 File Offset: 0x0048D588
		private void BIDFILIBBPC()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 41f + UnityEngine.Random.insideUnitSphere * 253f;
			if (vector.y < 1171f)
			{
				vector.y = 917f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 1973f + 1804f, UnityEngine.Random.value * 259f + 1989f, UnityEngine.Random.value * 644f + 3f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(724f, 1011f, 99f, 166f);
			volumetricFog.HGABMLKLEPE = 447f;
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x0048F45A File Offset: 0x0048D65A
		private void MEFOGCFJBNE()
		{
			if (Input.GetKeyDown(KeyCode.Minus))
			{
				this.HEOOCFNFBGF();
				return;
			}
			if (Input.GetKeyDown((KeyCode)1))
			{
				this.HBAGGFIJOKF();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-34)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x0048F48A File Offset: 0x0048D68A
		private void LBGKAMLLACN()
		{
			if (Input.GetKeyDown((KeyCode)(-27)))
			{
				this.CHKHFGKIMMD();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-108)))
			{
				this.DFGHKENELCN();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-101)))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x0048F4BC File Offset: 0x0048D6BC
		private void HEHBOGFLDKK()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 100f + UnityEngine.Random.insideUnitSphere * 50f;
			if (vector.y < 10f)
			{
				vector.y = 10f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 50f + 85f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(0.6f, 0.57f, 0.5f, 1f);
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x0048F55B File Offset: 0x0048D75B
		private void GGOKNBBPLHB()
		{
			GUI.Label(new Rect(550f, 1686f, (float)(Screen.width - 66), 1898f), " / ");
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x0048F584 File Offset: 0x0048D784
		private void AMDMCKIFBPA()
		{
			if (Input.GetKeyDown(KeyCode.Alpha8))
			{
				this.PNNMFDMGEBI();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-128)))
			{
				this.CKJFEMPPHNG();
				return;
			}
			if (Input.GetKeyDown(KeyCode.Plus))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x0048F5B4 File Offset: 0x0048D7B4
		private void CAAKEIOIOEM()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1213f + UnityEngine.Random.insideUnitSphere * 186f;
			if (vector.y < 800f)
			{
				vector.y = 463f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 1260f + 382f, UnityEngine.Random.value * 384f + 1195f, UnityEngine.Random.value * 644f + 1739f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(198f, 603f, 1689f, 659f);
			volumetricFog.HGABMLKLEPE = 1961f;
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x0048F688 File Offset: 0x0048D888
		private void FJFAAMJHOFO()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 96f + UnityEngine.Random.insideUnitSphere * 1115f;
			if (vector.y < 1603f)
			{
				vector.y = 1740f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 314f + 1195f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1516f, 630f, 1796f, 1669f);
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x0048F728 File Offset: 0x0048D928
		private void IAAGKEJAFKA()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1576f + UnityEngine.Random.insideUnitSphere * 40f;
			if (vector.y < 975f)
			{
				vector.y = 1063f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 109f + 756f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1994f, 3f, 14f, 453f);
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x0048F7C8 File Offset: 0x0048D9C8
		private void BNOJGPPGCHB()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 746f + UnityEngine.Random.insideUnitSphere * 1757f;
			if (vector.y < 948f)
			{
				vector.y = 758f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 739f + 1277f, UnityEngine.Random.value * 141f + 818f, UnityEngine.Random.value * 1660f + 726f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(1566f, 1961f, 1056f, 1541f);
			volumetricFog.HGABMLKLEPE = 1488f;
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x0048F89C File Offset: 0x0048DA9C
		private void IFPPJNPADJK()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 197f + UnityEngine.Random.insideUnitSphere * 590f;
			if (vector.y < 493f)
			{
				vector.y = 685f;
			}
			float aeiafiimhel = UnityEngine.Random.value * 1395f + 1896f;
			VolumetricFog.CreateFogArea(vector, aeiafiimhel).LBCGACKJCJB = new Color(1983f, 673f, 1909f, 722f);
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x0048F93B File Offset: 0x0048DB3B
		private void LACNPNKHCAA()
		{
			if (Input.GetKeyDown(KeyCode.Asterisk))
			{
				this.PNNLEICICGA();
				return;
			}
			if (Input.GetKeyDown(KeyCode.Period))
			{
				this.LOIAHFALDHA();
				return;
			}
			if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x0048F96C File Offset: 0x0048DB6C
		private void MBNIAIEPONH()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 989f + UnityEngine.Random.insideUnitSphere * 1807f;
			if (vector.y < 676f)
			{
				vector.y = 1058f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 1229f + 323f, UnityEngine.Random.value * 1797f + 1924f, UnityEngine.Random.value * 1822f + 848f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(33f, 136f, 821f, 1675f);
			volumetricFog.HGABMLKLEPE = 1179f;
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x0048FA3E File Offset: 0x0048DC3E
		private void BCJFDHBDAHD()
		{
			GUI.Label(new Rect(467f, 802f, (float)(Screen.width - -122), 1297f), "ZombieWalk");
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x0048FA67 File Offset: 0x0048DC67
		private void AKLFCMNCPKL()
		{
			if (Input.GetKeyDown((KeyCode)3))
			{
				this.IAAGKEJAFKA();
				return;
			}
			if (Input.GetKeyDown((KeyCode)(-33)))
			{
				this.MBNIAIEPONH();
				return;
			}
			if (Input.GetKeyDown(KeyCode.Question))
			{
				VolumetricFog.RemoveAllFogAreas();
			}
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x0048FA98 File Offset: 0x0048DC98
		private void LOIAHFALDHA()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 527f + UnityEngine.Random.insideUnitSphere * 1632f;
			if (vector.y < 1399f)
			{
				vector.y = 1298f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 1121f + 70f, UnityEngine.Random.value * 1002f + 1944f, UnityEngine.Random.value * 1673f + 1605f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(1468f, 399f, 1342f, 1829f);
			volumetricFog.HGABMLKLEPE = 949f;
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x0048FB6C File Offset: 0x0048DD6C
		private void OFAHECDFLDL()
		{
			Vector3 vector = Camera.main.transform.position + Camera.main.transform.forward * 1112f + UnityEngine.Random.insideUnitSphere * 1979f;
			if (vector.y < 1960f)
			{
				vector.y = 860f;
			}
			Vector3 gefeomdoohd = new Vector3(UnityEngine.Random.value * 526f + 1275f, UnityEngine.Random.value * 1120f + 1945f, UnityEngine.Random.value * 298f + 1241f);
			VolumetricFog volumetricFog = VolumetricFog.CreateFogArea(vector, gefeomdoohd);
			volumetricFog.LBCGACKJCJB = new Color(307f, 327f, 178f, 649f);
			volumetricFog.HGABMLKLEPE = 1159f;
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x0048FC3E File Offset: 0x0048DE3E
		private void ELLJEHHACHL()
		{
			GUI.Label(new Rect(31f, 144f, (float)(Screen.width - -53), 826f), "No hit from ");
		}
	}
}
