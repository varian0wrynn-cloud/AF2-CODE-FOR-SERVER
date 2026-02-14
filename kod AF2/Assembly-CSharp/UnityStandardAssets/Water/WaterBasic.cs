using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x020002F0 RID: 752
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		// Token: 0x0600B059 RID: 45145 RVA: 0x004CDA50 File Offset: 0x004CBC50
		private void PJHEGHHOJHJ()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("inv_bonus");
			float @float = sharedMaterial.GetFloat("wpn_rod1");
			float num = Time.time / 126f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1409f), Mathf.Repeat(vector2.y, 849f), Mathf.Repeat(vector2.z, 1087f), Mathf.Repeat(vector2.w, 755f));
			sharedMaterial.SetVector("colorC", value);
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x004CDB08 File Offset: 0x004CBD08
		private void AMDMCKIFBPA()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("W (A)");
			float @float = sharedMaterial.GetFloat("gi_nl1");
			float num = Time.time / 1434f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 724f), Mathf.Repeat(vector2.y, 1359f), Mathf.Repeat(vector2.z, 694f), Mathf.Repeat(vector2.w, 311f));
			sharedMaterial.SetVector("MotorbikeAirWalk", value);
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x004CDBC0 File Offset: 0x004CBDC0
		private void PGIHAIPCJLL()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("ragulaEventProc");
			float @float = sharedMaterial.GetFloat("");
			float num = Time.time / 53f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1344f), Mathf.Repeat(vector2.y, 875f), Mathf.Repeat(vector2.z, 164f), Mathf.Repeat(vector2.w, 762f));
			sharedMaterial.SetVector("{not_found}", value);
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x004CDC78 File Offset: 0x004CBE78
		private void LDDIGEMBDNF()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("The InteractionTrigger in the list 'inContact' has been destroyed");
			float @float = sharedMaterial.GetFloat("Failed parsing packed.  Setting to \"false\"");
			float num = Time.time / 1534f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1966f), Mathf.Repeat(vector2.y, 1111f), Mathf.Repeat(vector2.z, 1999f), Mathf.Repeat(vector2.w, 320f));
			sharedMaterial.SetVector("", value);
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x004CDD30 File Offset: 0x004CBF30
		private void CDLDCKAHLHC()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("usrto_ignor");
			float @float = sharedMaterial.GetFloat("_EMISSION");
			float num = Time.time / 1332f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1136f), Mathf.Repeat(vector2.y, 936f), Mathf.Repeat(vector2.z, 1675f), Mathf.Repeat(vector2.w, 1672f));
			sharedMaterial.SetVector("err: rect is null", value);
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x004CDDE8 File Offset: 0x004CBFE8
		private void DFFOEGHGPGP()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("ObscuredString vs string, ");
			float @float = sharedMaterial.GetFloat("{0:0} ч{1}, ");
			float num = Time.time / 1654f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1236f), Mathf.Repeat(vector2.y, 959f), Mathf.Repeat(vector2.z, 420f), Mathf.Repeat(vector2.w, 1405f));
			sharedMaterial.SetVector("\n", value);
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x004CDEA0 File Offset: 0x004CC0A0
		private void KJJBBLDJHPD()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("");
			float @float = sharedMaterial.GetFloat("demoVector2");
			float num = Time.time / 1621f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 199f), Mathf.Repeat(vector2.y, 1429f), Mathf.Repeat(vector2.z, 1601f), Mathf.Repeat(vector2.w, 40f));
			sharedMaterial.SetVector(" on effect ", value);
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x004CDF58 File Offset: 0x004CC158
		private void HAIMGCDKPDC()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("WalkInjured");
			float @float = sharedMaterial.GetFloat("Backward Stand");
			float num = Time.time / 1504f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1450f), Mathf.Repeat(vector2.y, 1181f), Mathf.Repeat(vector2.z, 1350f), Mathf.Repeat(vector2.w, 903f));
			sharedMaterial.SetVector(" on effect ", value);
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x004CE010 File Offset: 0x004CC210
		private void PMKOAHMNBBG()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("BipedReferences limb hierarchy is invalid. Bone transforms in a limb do not belong to the same ancestry. Please make sure the bones are parented to each other. Bones: ");
			float @float = sharedMaterial.GetFloat("_ChromaticAberration_Spectrum");
			float num = Time.time / 90f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 705f), Mathf.Repeat(vector2.y, 1172f), Mathf.Repeat(vector2.z, 1713f), Mathf.Repeat(vector2.w, 1158f));
			sharedMaterial.SetVector("wpn_wgt", value);
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x004CE0C8 File Offset: 0x004CC2C8
		private void BNKJNBIDPME()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("_LerpAmount");
			float @float = sharedMaterial.GetFloat("+ ");
			float num = Time.time / 361f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 243f), Mathf.Repeat(vector2.y, 1793f), Mathf.Repeat(vector2.z, 787f), Mathf.Repeat(vector2.w, 1791f));
			sharedMaterial.SetVector(" ", value);
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x004CE180 File Offset: 0x004CC380
		private void MFHGOLNLAAF()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("sunshine_OvercastVectorsUV");
			float @float = sharedMaterial.GetFloat(" --- ? ---");
			float num = Time.time / 1839f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 568f), Mathf.Repeat(vector2.y, 1494f), Mathf.Repeat(vector2.z, 1036f), Mathf.Repeat(vector2.w, 430f));
			sharedMaterial.SetVector("; ", value);
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x004CE238 File Offset: 0x004CC438
		private void FPLNDDMFFKG()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
			float @float = sharedMaterial.GetFloat("MotorbikeBackwardSitting");
			float num = Time.time / 198f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1406f), Mathf.Repeat(vector2.y, 772f), Mathf.Repeat(vector2.z, 1228f), Mathf.Repeat(vector2.w, 59f));
			sharedMaterial.SetVector("_BlurVector", value);
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x004CE2F0 File Offset: 0x004CC4F0
		private void MEFOGCFJBNE()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("Sunshine {0}: {1}");
			float @float = sharedMaterial.GetFloat("IdleSandCover");
			float num = Time.time / 84f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 950f), Mathf.Repeat(vector2.y, 1499f), Mathf.Repeat(vector2.z, 1792f), Mathf.Repeat(vector2.w, 749f));
			sharedMaterial.SetVector("\n", value);
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x004CE3A8 File Offset: 0x004CC5A8
		private void JIFOELPAEHG()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("vSyncCount");
			float @float = sharedMaterial.GetFloat("PaperTurn.wav");
			float num = Time.time / 1082f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 445f), Mathf.Repeat(vector2.y, 376f), Mathf.Repeat(vector2.z, 1089f), Mathf.Repeat(vector2.w, 626f));
			sharedMaterial.SetVector("PistolReady", value);
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x004CE460 File Offset: 0x004CC660
		private void AKLFCMNCPKL()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("no_inventory");
			float @float = sharedMaterial.GetFloat("_FinalReflectionTexture");
			float num = Time.time / 1481f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1763f), Mathf.Repeat(vector2.y, 1044f), Mathf.Repeat(vector2.z, 871f), Mathf.Repeat(vector2.w, 1343f));
			sharedMaterial.SetVector("Mouse ScrollWheel", value);
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x004CE518 File Offset: 0x004CC718
		private void EKCKBDKEAKO()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("");
			float @float = sharedMaterial.GetFloat("F3");
			float num = Time.time / 1473f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1892f), Mathf.Repeat(vector2.y, 530f), Mathf.Repeat(vector2.z, 948f), Mathf.Repeat(vector2.w, 558f));
			sharedMaterial.SetVector("auc_wsbor", value);
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x004CE5D0 File Offset: 0x004CC7D0
		private void DPGECEOMHNM()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("FrontKick");
			float @float = sharedMaterial.GetFloat("Open turnStatus");
			float num = Time.time / 237f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 972f), Mathf.Repeat(vector2.y, 268f), Mathf.Repeat(vector2.z, 1248f), Mathf.Repeat(vector2.w, 1906f));
			sharedMaterial.SetVector("gi_inte_1", value);
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x004CE688 File Offset: 0x004CC888
		private void HMLNMHOMMNO()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("<[^>]+>");
			float @float = sharedMaterial.GetFloat("RollerBladeCrossoverLeft");
			float num = Time.time / 1313f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1191f), Mathf.Repeat(vector2.y, 639f), Mathf.Repeat(vector2.z, 1251f), Mathf.Repeat(vector2.w, 1658f));
			sharedMaterial.SetVector("https://groups.google.com/forum/#!forum/final-ik", value);
		}

		// Token: 0x0600B06B RID: 45163 RVA: 0x004CE740 File Offset: 0x004CC940
		private void HMEAENGBFKC()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("RunningDance");
			float @float = sharedMaterial.GetFloat("fshop_msg1");
			float num = Time.time / 806f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 929f), Mathf.Repeat(vector2.y, 1139f), Mathf.Repeat(vector2.z, 1342f), Mathf.Repeat(vector2.w, 1f));
			sharedMaterial.SetVector("<color='#003000'>{0} на {1}</color>", value);
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x004CE7F8 File Offset: 0x004CC9F8
		private void AIAMIFEPALP()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("Warp index out of range.");
			float @float = sharedMaterial.GetFloat("abcd");
			float num = Time.time / 1034f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1391f), Mathf.Repeat(vector2.y, 967f), Mathf.Repeat(vector2.z, 1123f), Mathf.Repeat(vector2.w, 205f));
			sharedMaterial.SetVector("FOG_SCATTERING_ON", value);
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x004CE8B0 File Offset: 0x004CCAB0
		private void IGEICBNMPAD()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("Wizard2HandThrow");
			float @float = sharedMaterial.GetFloat("https://www.youtube.com/watch?v=wT8fViZpLmQ");
			float num = Time.time / 15f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 833f), Mathf.Repeat(vector2.y, 284f), Mathf.Repeat(vector2.z, 1904f), Mathf.Repeat(vector2.w, 1278f));
			sharedMaterial.SetVector("#000040", value);
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x004CE968 File Offset: 0x004CCB68
		private void JOHDLNOKCOK()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("_Bloom_Settings");
			float @float = sharedMaterial.GetFloat("CrawlLocomotion");
			float num = Time.time / 35f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 114f), Mathf.Repeat(vector2.y, 716f), Mathf.Repeat(vector2.z, 731f), Mathf.Repeat(vector2.w, 1069f));
			sharedMaterial.SetVector("<color='#003000'>{0} на {1}</color>", value);
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x004CEA20 File Offset: 0x004CCC20
		private void IOGAKGCADBL()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("minModelScale");
			float @float = sharedMaterial.GetFloat("IdleWalk");
			float num = Time.time / 324f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1715f), Mathf.Repeat(vector2.y, 1979f), Mathf.Repeat(vector2.z, 876f), Mathf.Repeat(vector2.w, 630f));
			sharedMaterial.SetVector("M", value);
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x004CEAD8 File Offset: 0x004CCCD8
		private void IKHCCAANGOP()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("</color>\n");
			float @float = sharedMaterial.GetFloat("jamp");
			float num = Time.time / 1728f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1744f), Mathf.Repeat(vector2.y, 1644f), Mathf.Repeat(vector2.z, 1680f), Mathf.Repeat(vector2.w, 1188f));
			sharedMaterial.SetVector("SUNSHINE_FILTER_PCF_3x3", value);
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x004CEB90 File Offset: 0x004CCD90
		private void JLFBDOPFDDJ()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("_Cull");
			float @float = sharedMaterial.GetFloat(",");
			float num = Time.time / 928f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 162f), Mathf.Repeat(vector2.y, 47f), Mathf.Repeat(vector2.z, 1162f), Mathf.Repeat(vector2.w, 1716f));
			sharedMaterial.SetVector("invn_win1", value);
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x004CEC48 File Offset: 0x004CCE48
		private void BOAJJAKEMLH()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("******* playMusicBase  LocNewLogic");
			float @float = sharedMaterial.GetFloat("lifeBar");
			float num = Time.time / 1171f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 392f), Mathf.Repeat(vector2.y, 1977f), Mathf.Repeat(vector2.z, 1450f), Mathf.Repeat(vector2.w, 1531f));
			sharedMaterial.SetVector("invn_rec15", value);
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x004CED00 File Offset: 0x004CCF00
		private void OPDCJCFMIPE()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("{0} {1}\n{2}");
			float @float = sharedMaterial.GetFloat("Проверьте правильность логина и пароля!");
			float num = Time.time / 255f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1471f), Mathf.Repeat(vector2.y, 1001f), Mathf.Repeat(vector2.z, 398f), Mathf.Repeat(vector2.w, 1338f));
			sharedMaterial.SetVector("\n", value);
		}

		// Token: 0x0600B074 RID: 45172 RVA: 0x004CEDB8 File Offset: 0x004CCFB8
		private void LBGKAMLLACN()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("<color=\"#0287C8\"><b>Anti-Cheat Toolkit Sandbox</b></color>");
			float @float = sharedMaterial.GetFloat("Hidden/Post FX/Eye Adaptation");
			float num = Time.time / 1028f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 407f), Mathf.Repeat(vector2.y, 1426f), Mathf.Repeat(vector2.z, 1188f), Mathf.Repeat(vector2.w, 1467f));
			sharedMaterial.SetVector("_BlurRadius4", value);
		}

		// Token: 0x0600B075 RID: 45173 RVA: 0x004CEE70 File Offset: 0x004CD070
		private void KMLNBHIIGKH()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("WeaponReady");
			float @float = sharedMaterial.GetFloat("Shoot Forward");
			float num = Time.time / 639f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1995f), Mathf.Repeat(vector2.y, 237f), Mathf.Repeat(vector2.z, 1330f), Mathf.Repeat(vector2.w, 941f));
			sharedMaterial.SetVector("BAG", value);
		}

		// Token: 0x0600B076 RID: 45174 RVA: 0x004CEF28 File Offset: 0x004CD128
		private void AAEFACEGJMB()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("wpn_tank2");
			float @float = sharedMaterial.GetFloat("");
			float num = Time.time / 1471f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1852f), Mathf.Repeat(vector2.y, 406f), Mathf.Repeat(vector2.z, 360f), Mathf.Repeat(vector2.w, 868f));
			sharedMaterial.SetVector("Foot", value);
		}

		// Token: 0x0600B077 RID: 45175 RVA: 0x004CEFE0 File Offset: 0x004CD1E0
		private void OFPGMNGFLNH()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector(" ms");
			float @float = sharedMaterial.GetFloat("autherror");
			float num = Time.time / 114f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1317f), Mathf.Repeat(vector2.y, 142f), Mathf.Repeat(vector2.z, 848f), Mathf.Repeat(vector2.w, 1207f));
			sharedMaterial.SetVector("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", value);
		}

		// Token: 0x0600B078 RID: 45176 RVA: 0x004CF098 File Offset: 0x004CD298
		private void JPHLMNIMDHH()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("WateringCanWatering");
			float @float = sharedMaterial.GetFloat("Bilateral Blur");
			float num = Time.time / 1711f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 179f), Mathf.Repeat(vector2.y, 1200f), Mathf.Repeat(vector2.z, 846f), Mathf.Repeat(vector2.w, 621f));
			sharedMaterial.SetVector("Original lives count: ", value);
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x004CF150 File Offset: 0x004CD350
		private void LMMDHJJJNJO()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("autherror");
			float @float = sharedMaterial.GetFloat("gi_uinf_7");
			float num = Time.time / 483f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1396f), Mathf.Repeat(vector2.y, 393f), Mathf.Repeat(vector2.z, 819f), Mathf.Repeat(vector2.w, 1784f));
			sharedMaterial.SetVector("SoundData", value);
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x004CF208 File Offset: 0x004CD408
		private void Update()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
			float @float = sharedMaterial.GetFloat("_WaveScale");
			float num = Time.time / 20f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1f), Mathf.Repeat(vector2.y, 1f), Mathf.Repeat(vector2.z, 1f), Mathf.Repeat(vector2.w, 1f));
			sharedMaterial.SetVector("_WaveOffset", value);
		}

		// Token: 0x0600B07B RID: 45179 RVA: 0x004CF2C0 File Offset: 0x004CD4C0
		private void LIOCDEICIFD()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("BackPress");
			float @float = sharedMaterial.GetFloat("1HandSwordChargeUp");
			float num = Time.time / 1928f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1806f), Mathf.Repeat(vector2.y, 760f), Mathf.Repeat(vector2.z, 142f), Mathf.Repeat(vector2.w, 999f));
			sharedMaterial.SetVector("{0} is not a valid asset bundle.", value);
		}

		// Token: 0x0600B07C RID: 45180 RVA: 0x004CF378 File Offset: 0x004CD578
		private void CJHBCHBOLBI()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("Failed parsing atlas rect.  Using default.");
			float @float = sharedMaterial.GetFloat("saveTreeNodeState SV=");
			float num = Time.time / 1102f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 733f), Mathf.Repeat(vector2.y, 46f), Mathf.Repeat(vector2.z, 1432f), Mathf.Repeat(vector2.w, 1141f));
			sharedMaterial.SetVector("Yawn", value);
		}

		// Token: 0x0600B07D RID: 45181 RVA: 0x004CF430 File Offset: 0x004CD630
		private void FJEEADNCKAG()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("http://www.root-motion.com/finalikdox/html/page11.html");
			float @float = sharedMaterial.GetFloat("neck");
			float num = Time.time / 660f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 468f), Mathf.Repeat(vector2.y, 1019f), Mathf.Repeat(vector2.z, 1784f), Mathf.Repeat(vector2.w, 590f));
			sharedMaterial.SetVector("http://af-2.ru/?q=user/register", value);
		}

		// Token: 0x0600B07E RID: 45182 RVA: 0x004CF4E8 File Offset: 0x004CD6E8
		private void PFPPDNHLCCA()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("ChannelCastOmni");
			float @float = sharedMaterial.GetFloat("fishzone");
			float num = Time.time / 546f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1442f), Mathf.Repeat(vector2.y, 723f), Mathf.Repeat(vector2.z, 1914f), Mathf.Repeat(vector2.w, 636f));
			sharedMaterial.SetVector("WATER_REFLECTIVE", value);
		}

		// Token: 0x0600B07F RID: 45183 RVA: 0x004CF5A0 File Offset: 0x004CD7A0
		private void GCNGEFBKMNC()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("{0}Textures/Turnirs/{1}.png");
			float @float = sharedMaterial.GetFloat("LOC_NAMES");
			float num = Time.time / 174f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1792f), Mathf.Repeat(vector2.y, 704f), Mathf.Repeat(vector2.z, 1934f), Mathf.Repeat(vector2.w, 127f));
			sharedMaterial.SetVector("turn_state", value);
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x004CF658 File Offset: 0x004CD858
		private void OHKHOAKCENL()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("ldGo not found");
			float @float = sharedMaterial.GetFloat("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n");
			float num = Time.time / 619f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 834f), Mathf.Repeat(vector2.y, 1549f), Mathf.Repeat(vector2.z, 1733f), Mathf.Repeat(vector2.w, 1431f));
			sharedMaterial.SetVector("id", value);
		}

		// Token: 0x0600B082 RID: 45186 RVA: 0x004CF710 File Offset: 0x004CD910
		private void BJOICAKCPLI()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("http://www.root-motion.com/finalikdox/html/page5.html");
			float @float = sharedMaterial.GetFloat("cht_tofrend");
			float num = Time.time / 1344f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1196f), Mathf.Repeat(vector2.y, 1048f), Mathf.Repeat(vector2.z, 860f), Mathf.Repeat(vector2.w, 769f));
			sharedMaterial.SetVector("turn_state", value);
		}

		// Token: 0x0600B083 RID: 45187 RVA: 0x004CF7C8 File Offset: 0x004CD9C8
		private void PNBGJBMJLFM()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("byte[]: {");
			float @float = sharedMaterial.GetFloat("no_adm");
			float num = Time.time / 1930f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 364f), Mathf.Repeat(vector2.y, 633f), Mathf.Repeat(vector2.z, 1614f), Mathf.Repeat(vector2.w, 1028f));
			sharedMaterial.SetVector("post_4", value);
		}

		// Token: 0x0600B084 RID: 45188 RVA: 0x004CF880 File Offset: 0x004CDA80
		private void CBBLGEDCJBF()
		{
			Renderer component = base.GetComponent<Renderer>();
			if (!component)
			{
				return;
			}
			Material sharedMaterial = component.sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("_ColorBuffer");
			float @float = sharedMaterial.GetFloat("+{0}");
			float num = Time.time / 666f;
			Vector4 vector2 = vector * (num * @float);
			Vector4 value = new Vector4(Mathf.Repeat(vector2.x, 1529f), Mathf.Repeat(vector2.y, 1446f), Mathf.Repeat(vector2.z, 516f), Mathf.Repeat(vector2.w, 284f));
			sharedMaterial.SetVector("NadeThrow", value);
		}
	}
}
