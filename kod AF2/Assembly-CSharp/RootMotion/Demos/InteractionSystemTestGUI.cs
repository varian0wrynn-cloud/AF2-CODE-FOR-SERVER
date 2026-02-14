using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003FE RID: 1022
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		// Token: 0x0600DB53 RID: 56147 RVA: 0x006485FC File Offset: 0x006467FC
		private void CBBIADNKMLI()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB54 RID: 56148 RVA: 0x0064860C File Offset: 0x0064680C
		private void BBGAONKBIPJ()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button(" " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("_TempRT");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[0]) && GUILayout.Button("error.wav" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB55 RID: 56149 RVA: 0x006485FC File Offset: 0x006467FC
		private void FDKGOFHFOLH()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB56 RID: 56150 RVA: 0x006485FC File Offset: 0x006467FC
		private void KHKDKMMHJBK()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB57 RID: 56151 RVA: 0x006486D4 File Offset: 0x006468D4
		private void BMCKJEBCEPA()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("Zombie Idle" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("newtitul");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[1]) && GUILayout.Button("isAlwaisGetFish" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB58 RID: 56152 RVA: 0x006485FC File Offset: 0x006467FC
		private void CKPNKKFIINO()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB59 RID: 56153 RVA: 0x006485FC File Offset: 0x006467FC
		private void JIIBCGJJLND()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB5A RID: 56154 RVA: 0x0064879C File Offset: 0x0064699C
		private void HMPFJEPODEL()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("No hit from " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("wpn_bait_sz");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[1]) && GUILayout.Button("iNPC" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB5B RID: 56155 RVA: 0x006485FC File Offset: 0x006467FC
		private void AHILDBJHCKI()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB5C RID: 56156 RVA: 0x00648864 File Offset: 0x00646A64
		private void MJDKGMEPMHK()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("-?-" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("HDR");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.HCILLNOMHNJ(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.GAMAGGGGOIP(this.effectors[1]) && GUILayout.Button("\n" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB5D RID: 56157 RVA: 0x0064892C File Offset: 0x00646B2C
		private void JLMDLHCNGBE()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("Open turnir info window" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("One of the Bones is null.");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.HCILLNOMHNJ(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.GAMAGGGGOIP(this.effectors[1]) && GUILayout.Button("UnityEngine.Vector3" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB5E RID: 56158 RVA: 0x006485FC File Offset: 0x006467FC
		private void BHPGDKJHKKG()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB5F RID: 56159 RVA: 0x006485FC File Offset: 0x006467FC
		private void FJBJDFDJAMI()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB60 RID: 56160 RVA: 0x006485FC File Offset: 0x006467FC
		private void DOBFKBMGMNA()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB61 RID: 56161 RVA: 0x006489F4 File Offset: 0x00646BF4
		private void AGBEEDOOOHA()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("Flap_04.wav" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("I LOVE MY GIRLz");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.HCILLNOMHNJ(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.IsPaused(this.effectors[0]) && GUILayout.Button("#" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB62 RID: 56162 RVA: 0x006485FC File Offset: 0x006467FC
		private void DDEGPPKLAOL()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB63 RID: 56163 RVA: 0x00648ABC File Offset: 0x00646CBC
		private void BKPJAHOPBCP()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("IdleSpew" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("_NoiseTex");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.HCILLNOMHNJ(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.CHPEJJKOCGH(this.effectors[1]) && GUILayout.Button("offsets" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x006485FC File Offset: 0x006467FC
		private void HKLPGCKJEJK()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB65 RID: 56165 RVA: 0x00648B84 File Offset: 0x00646D84
		private void IPFNFHPFAOE()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("+ " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("_MotionAmount");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.IsPaused(this.effectors[1]) && GUILayout.Button(".unity3d" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB66 RID: 56166 RVA: 0x00648C4C File Offset: 0x00646E4C
		private void JAOIOHLFLFO()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("demoByteArray" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("Post Process Blur Shader Missing...");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.HCILLNOMHNJ(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.IsPaused(this.effectors[0]) && GUILayout.Button("\n<color='#406000'>------------------------------------------------------------------------------------------------------------</color>\n" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB67 RID: 56167 RVA: 0x00648D14 File Offset: 0x00646F14
		private void ENCHIIJEJDL()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("TOD_SpaceTiling" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("Images/MouseCursor/Arrow");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.GAMAGGGGOIP(this.effectors[0]) && GUILayout.Button("UI_DynamicWindow" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB68 RID: 56168 RVA: 0x00648DDC File Offset: 0x00646FDC
		private void EILPHLEBEJP()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button(" B:" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("FONT");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.HCILLNOMHNJ(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.IsPaused(this.effectors[0]) && GUILayout.Button("sunshine_CascadeRanges" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB69 RID: 56169 RVA: 0x006485FC File Offset: 0x006467FC
		private void NKHMBEDDFAJ()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB6B RID: 56171 RVA: 0x006485FC File Offset: 0x006467FC
		private void DHIJGNHBMFJ()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB6C RID: 56172 RVA: 0x006485FC File Offset: 0x006467FC
		private void Awake()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB6D RID: 56173 RVA: 0x00648EA4 File Offset: 0x006470A4
		private void PNJNNNJEBGA()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("qname_" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("{not_found}");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.CHPEJJKOCGH(this.effectors[1]) && GUILayout.Button("IdleStand" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB6E RID: 56174 RVA: 0x00648F6C File Offset: 0x0064716C
		private void BGJFLKLBOPK()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("ShotgunReloadChamber");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.IsPaused(this.effectors[1]) && GUILayout.Button("Turn Left" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x00649034 File Offset: 0x00647234
		private void AEFGOFJAKDO()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("wpn_bait_vob_1" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("+{0}");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[0]) && GUILayout.Button("MotorbikeHeadstand" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x006490FC File Offset: 0x006472FC
		private void KBAJMMCHDOC()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("{0} is not a valid asset bundle." + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("Try Goscurry! Or better buy it!");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.GAMAGGGGOIP(this.effectors[1]) && GUILayout.Button("WeaponRunBackward" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x006485FC File Offset: 0x006467FC
		private void FKLDKPEDDDM()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x006491C4 File Offset: 0x006473C4
		private void KBEOAOKBHEK()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("Lives count after few usual operations: " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("Fly Up");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[1]) && GUILayout.Button("id" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x0064928C File Offset: 0x0064748C
		private void EMNMOMGOBPI()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("wpn_rod4");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[1]) && GUILayout.Button("knopje.wav" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB74 RID: 56180 RVA: 0x006485FC File Offset: 0x006467FC
		private void CCPOIOJPKIF()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB75 RID: 56181 RVA: 0x00649354 File Offset: 0x00647554
		private void ELFMPDIGDLJ()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button(" %" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("steamno");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i++)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[0]) && GUILayout.Button("string:" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB76 RID: 56182 RVA: 0x006485FC File Offset: 0x006467FC
		private void MBNCGMLPNLD()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB77 RID: 56183 RVA: 0x006485FC File Offset: 0x006467FC
		private void MNIOJGMLIMC()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB78 RID: 56184 RVA: 0x0064941C File Offset: 0x0064761C
		private void JGDDEOALNOG()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("demoLong");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.GAMAGGGGOIP(this.effectors[0]) && GUILayout.Button("CP2" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x006485FC File Offset: 0x006467FC
		private void CEBAOOAIADJ()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB7A RID: 56186 RVA: 0x006485FC File Offset: 0x006467FC
		private void MGNGNBMMAAD()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x006485FC File Offset: 0x006467FC
		private void PFKOLCOAPCN()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB7C RID: 56188 RVA: 0x006494E4 File Offset: 0x006476E4
		private void OnGUI()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("Start Interaction With " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("Please select the effectors to interact with.");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.IsPaused(this.effectors[0]) && GUILayout.Button("Resume Interaction With " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB7D RID: 56189 RVA: 0x006485FC File Offset: 0x006467FC
		private void MBKLIKGAKJB()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB7E RID: 56190 RVA: 0x006495AC File Offset: 0x006477AC
		private void OLBDOHCILKO()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("SoccerStartKick" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("[");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[0]) && GUILayout.Button("1HandSwordJabCombo" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB7F RID: 56191 RVA: 0x00649674 File Offset: 0x00647874
		private void NJKJJNBMKHB()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("error: already initialized" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("BC ");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.CHPEJJKOCGH(this.effectors[0]) && GUILayout.Button("1 Hand Sword Back Swing" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB80 RID: 56192 RVA: 0x006485FC File Offset: 0x006467FC
		private void GDMEEIBDKLP()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB81 RID: 56193 RVA: 0x0064973C File Offset: 0x0064793C
		private void JADGLEGEDGJ()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("VaderChoke" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("fishsplash{0}.ogg");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[1]) && GUILayout.Button("ncht_ach2" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB82 RID: 56194 RVA: 0x00649804 File Offset: 0x00647A04
		private void BFOPAJGPJLK()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button(" " + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("remWpn=");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.GAMAGGGGOIP(this.effectors[0]) && GUILayout.Button("_ColorBuffer" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB83 RID: 56195 RVA: 0x006498CC File Offset: 0x00647ACC
		private void BCJFDHBDAHD()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("Hit");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i++)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.CHPEJJKOCGH(this.effectors[1]) && GUILayout.Button("foot" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB84 RID: 56196 RVA: 0x006485FC File Offset: 0x006467FC
		private void PBOBJPGKCDC()
		{
			this.NKKKJBOMCID = base.GetComponent<InteractionSystem>();
		}

		// Token: 0x0600DB85 RID: 56197 RVA: 0x00649994 File Offset: 0x00647B94
		private void GKFOFOCGPCC()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("\n" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("wpn_eat6");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.HCILLNOMHNJ(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[0]) && GUILayout.Button("PistolFire" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB86 RID: 56198 RVA: 0x00649A5C File Offset: 0x00647C5C
		private void GGOKNBBPLHB()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("x" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("dd/MM/yyyy HH:mm");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 0; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.BCNAIAIAOMF(this.effectors[1]) && GUILayout.Button("wpn_add/addoptions" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.FEGPDLHOPKD();
			}
		}

		// Token: 0x0600DB87 RID: 56199 RVA: 0x00649B24 File Offset: 0x00647D24
		private void LPNFGGAKGID()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver." + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("SkateboardIdle");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i += 0)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, true);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.GAMAGGGGOIP(this.effectors[1]) && GUILayout.Button("harvestmsg1" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x0600DB88 RID: 56200 RVA: 0x00649BEC File Offset: 0x00647DEC
		private void LHOKCJCHLOM()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("TOD_CloudUV" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("offsets");
				}
				FullBodyBipedEffector[] array = this.effectors;
				for (int i = 1; i < array.Length; i++)
				{
					FullBodyBipedEffector lpohbkjjibo = array[i];
					this.NKKKJBOMCID.DOJCIIDNKNI(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.CHPEJJKOCGH(this.effectors[0]) && GUILayout.Button("OfficeSittingReadingLeanBack" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.ResumeAll();
			}
		}

		// Token: 0x0600DB89 RID: 56201 RVA: 0x00649CB4 File Offset: 0x00647EB4
		private void NCFLINGBFJG()
		{
			if (this.NKKKJBOMCID == null)
			{
				return;
			}
			if (GUILayout.Button("BowFire" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				if (this.effectors.Length == 0)
				{
					Debug.Log("WeaponStand");
				}
				foreach (FullBodyBipedEffector lpohbkjjibo in this.effectors)
				{
					this.NKKKJBOMCID.StartInteraction(lpohbkjjibo, this.interactionObject, false);
				}
			}
			if (this.effectors.Length == 0)
			{
				return;
			}
			if (this.NKKKJBOMCID.IsPaused(this.effectors[1]) && GUILayout.Button("Q" + this.interactionObject.name, Array.Empty<GUILayoutOption>()))
			{
				this.NKKKJBOMCID.AEGOFPPDLGJ();
			}
		}

		// Token: 0x04001D1A RID: 7450
		[Tooltip("The object to interact to")]
		[SerializeField]
		private InteractionObject interactionObject;

		// Token: 0x04001D1B RID: 7451
		[Tooltip("The effectors to interact with")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		// Token: 0x04001D1C RID: 7452
		private InteractionSystem NKKKJBOMCID;
	}
}
