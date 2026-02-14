using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000415 RID: 1045
	public class UserControlInteractions : UserControlThirdPerson
	{
		// Token: 0x0600E0B9 RID: 57529 RVA: 0x0066A498 File Offset: 0x00668698
		private void IPFNFHPFAOE()
		{
			if (!this.character.NFEOLKHFKCI())
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("ObscuredUShort:", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-40)))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(num))
			{
				return;
			}
			GUILayout.Label("OfficeSitting", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)67))
			{
				this.interactionSystem.TriggerInteraction(num, true);
			}
		}

		// Token: 0x0600E0BA RID: 57530 RVA: 0x0066A538 File Offset: 0x00668738
		protected virtual void OHKHOAKCENL()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.IsPaused()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 294f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.LMMDHJJJNJO();
		}

		// Token: 0x0600E0BB RID: 57531 RVA: 0x0066A5B8 File Offset: 0x006687B8
		private void KBEOAOKBHEK()
		{
			if (!this.character.BHCCJCNDPKG())
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("_Rand", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)10))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(num))
			{
				return;
			}
			GUILayout.Label("__b", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.M))
			{
				this.interactionSystem.BALGINKLGFF(num, true);
			}
		}

		// Token: 0x0600E0BC RID: 57532 RVA: 0x0066A658 File Offset: 0x00668858
		protected virtual void JIFOELPAEHG()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 1230f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.JPHLMNIMDHH();
		}

		// Token: 0x0600E0BD RID: 57533 RVA: 0x0066A6D8 File Offset: 0x006688D8
		protected virtual void IGEICBNMPAD()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 1007f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.AIAMIFEPALP();
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x0066A758 File Offset: 0x00668958
		protected virtual void BEDAJLJFAFO()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IsPaused()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 208f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.OPDCJCFMIPE();
		}

		// Token: 0x0600E0BF RID: 57535 RVA: 0x0066A7D8 File Offset: 0x006689D8
		protected virtual void DEGCCLNOEKJ()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IMABGAJEMDD()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 1415f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.Update();
		}

		// Token: 0x0600E0C0 RID: 57536 RVA: 0x0066A858 File Offset: 0x00668A58
		private void MJDKGMEPMHK()
		{
			if (!this.character.HGMPPHMFHJP())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("PLANE_REFLECTION_CHEAPER", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-101)))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(num))
			{
				return;
			}
			GUILayout.Label("", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.B))
			{
				this.interactionSystem.TriggerInteraction(num, true);
			}
		}

		// Token: 0x0600E0C2 RID: 57538 RVA: 0x0066A914 File Offset: 0x00668B14
		protected virtual void KBMKHLDOIKP()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IMABGAJEMDD()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 1099f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.LMMDHJJJNJO();
		}

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x0066A994 File Offset: 0x00668B94
		protected virtual void GDBBAMFMKII()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 1395f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.Update();
		}

		// Token: 0x0600E0C4 RID: 57540 RVA: 0x0066AA14 File Offset: 0x00668C14
		protected virtual void BOAJJAKEMLH()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 99f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.BJOICAKCPLI();
		}

		// Token: 0x0600E0C5 RID: 57541 RVA: 0x0066AA94 File Offset: 0x00668C94
		private void BHALJCJOPGD()
		{
			if (!this.character.BHCCJCNDPKG())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("USE_DEPTH", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-33)))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("WeaponStrafeRunRight", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)10))
			{
				this.interactionSystem.BALGINKLGFF(closestTriggerIndex, false);
			}
		}

		// Token: 0x0600E0C6 RID: 57542 RVA: 0x0066AB34 File Offset: 0x00668D34
		private void NOBANMDHKNK()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("FlyRight", Array.Empty<GUILayoutOption>());
				if (Input.GetKey(KeyCode.K))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("OfficeSittingReadingLeanBack", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-44)))
			{
				this.interactionSystem.BALGINKLGFF(closestTriggerIndex, true);
			}
		}

		// Token: 0x0600E0C7 RID: 57543 RVA: 0x0066ABD4 File Offset: 0x00668DD4
		protected virtual void IOGAKGCADBL()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IMABGAJEMDD()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 1863f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.KJJBBLDJHPD();
		}

		// Token: 0x0600E0C8 RID: 57544 RVA: 0x0066AC54 File Offset: 0x00668E54
		private void AHEAJPNHBBB()
		{
			if (!this.character.BJHMHPJDJIB)
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)77))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("Left", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-80)))
			{
				this.interactionSystem.TriggerInteraction(closestTriggerIndex, true);
			}
		}

		// Token: 0x0600E0C9 RID: 57545 RVA: 0x0066ACF4 File Offset: 0x00668EF4
		private void BGJFLKLBOPK()
		{
			if (!this.character.HKFLKEHPDFD())
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("Fly Backward", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)20))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("WeaponFire", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)89))
			{
				this.interactionSystem.BALGINKLGFF(closestTriggerIndex, false);
			}
		}

		// Token: 0x0600E0CA RID: 57546 RVA: 0x0066AD94 File Offset: 0x00668F94
		protected override void JPHLMNIMDHH()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IsPaused()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 1413f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.LMMDHJJJNJO();
		}

		// Token: 0x0600E0CB RID: 57547 RVA: 0x0066AE14 File Offset: 0x00669014
		private void HMPFJEPODEL()
		{
			if (!this.character.BHCCJCNDPKG())
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("IdleFly", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-66)))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("progress=", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-89)))
			{
				this.interactionSystem.TriggerInteraction(num, true);
			}
		}

		// Token: 0x0600E0CC RID: 57548 RVA: 0x0066AEB4 File Offset: 0x006690B4
		private void JLMDLHCNGBE()
		{
			if (!this.character.BJHMHPJDJIB)
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-40)))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("_Offsets", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-86)))
			{
				this.interactionSystem.BALGINKLGFF(closestTriggerIndex, false);
			}
		}

		// Token: 0x0600E0CD RID: 57549 RVA: 0x0066AF54 File Offset: 0x00669154
		private void OLBPGOGCCMP()
		{
			if (!this.character.NFEOLKHFKCI())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("EventSystem", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)28))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(num))
			{
				return;
			}
			GUILayout.Label("*** PODSEK", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)24))
			{
				this.interactionSystem.TriggerInteraction(num, false);
			}
		}

		// Token: 0x0600E0CE RID: 57550 RVA: 0x0066AFF4 File Offset: 0x006691F4
		private void OnGUI()
		{
			if (!this.character.BJHMHPJDJIB)
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("Press E to resume interaction", Array.Empty<GUILayoutOption>());
				if (Input.GetKey(KeyCode.E))
				{
					this.interactionSystem.ResumeAll();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("Press E to start interaction", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.E))
			{
				this.interactionSystem.TriggerInteraction(closestTriggerIndex, false);
			}
		}

		// Token: 0x0600E0CF RID: 57551 RVA: 0x0066B094 File Offset: 0x00669294
		private void EILPHLEBEJP()
		{
			if (!this.character.BJHMHPJDJIB)
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("vSyncCount", Array.Empty<GUILayoutOption>());
				if (Input.GetKey(KeyCode.I))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("linebreak.ogg", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.LeftCurlyBracket))
			{
				this.interactionSystem.BALGINKLGFF(closestTriggerIndex, true);
			}
		}

		// Token: 0x0600E0D0 RID: 57552 RVA: 0x0066B134 File Offset: 0x00669334
		protected override void DFFOEGHGPGP()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 0f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.CBBLGEDCJBF();
		}

		// Token: 0x0600E0D1 RID: 57553 RVA: 0x0066B1B4 File Offset: 0x006693B4
		protected virtual void FOHLAIIMNFB()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 1095f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.OPDCJCFMIPE();
		}

		// Token: 0x0600E0D2 RID: 57554 RVA: 0x0066B234 File Offset: 0x00669434
		protected virtual void MFHGOLNLAAF()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.IMABGAJEMDD()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 1480f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.BJOICAKCPLI();
		}

		// Token: 0x0600E0D3 RID: 57555 RVA: 0x0066B2B4 File Offset: 0x006694B4
		private void ELFMPDIGDLJ()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("UIChat_alfa", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-102)))
				{
					this.interactionSystem.ResumeAll();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("restype_", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-33)))
			{
				this.interactionSystem.BALGINKLGFF(num, false);
			}
		}

		// Token: 0x0600E0D4 RID: 57556 RVA: 0x0066B354 File Offset: 0x00669554
		private void NCFLINGBFJG()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("isiznos", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-53)))
				{
					this.interactionSystem.ResumeAll();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("TOD_MoonDirection", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.D))
			{
				this.interactionSystem.TriggerInteraction(num, true);
			}
		}

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x0066B3F4 File Offset: 0x006695F4
		protected override void Update()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IsPaused()))
			{
				float minActiveProgress = this.interactionSystem.GetMinActiveProgress();
				if (minActiveProgress > 0f && minActiveProgress < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.Update();
		}

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x0066B474 File Offset: 0x00669674
		protected virtual void LBOONMDONCF()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 1584f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.AIAMIFEPALP();
		}

		// Token: 0x0600E0D7 RID: 57559 RVA: 0x0066B4F4 File Offset: 0x006696F4
		protected virtual void PNBGJBMJLFM()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IsPaused()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 1909f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.LIOCDEICIFD();
		}

		// Token: 0x0600E0D8 RID: 57560 RVA: 0x0066B574 File Offset: 0x00669774
		private void JEJGFDBHABC()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-67)))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("IdleStand", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-58)))
			{
				this.interactionSystem.BALGINKLGFF(num, false);
			}
		}

		// Token: 0x0600E0D9 RID: 57561 RVA: 0x0066B614 File Offset: 0x00669814
		protected virtual void FPLNDDMFFKG()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.IsPaused()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 1016f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.LMMDHJJJNJO();
		}

		// Token: 0x0600E0DA RID: 57562 RVA: 0x0066B694 File Offset: 0x00669894
		private void PNJNNNJEBGA()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("Apply 5", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-122)))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("error", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-14)))
			{
				this.interactionSystem.BALGINKLGFF(closestTriggerIndex, true);
			}
		}

		// Token: 0x0600E0DB RID: 57563 RVA: 0x0066B734 File Offset: 0x00669934
		protected override void LIOCDEICIFD()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 681f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.JPHLMNIMDHH();
		}

		// Token: 0x0600E0DC RID: 57564 RVA: 0x0066B7B4 File Offset: 0x006699B4
		protected override void OPDCJCFMIPE()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IMABGAJEMDD()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 1838f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.CBBLGEDCJBF();
		}

		// Token: 0x0600E0DD RID: 57565 RVA: 0x0066B834 File Offset: 0x00669A34
		protected override void AKLFCMNCPKL()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 1085f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.OPDCJCFMIPE();
		}

		// Token: 0x0600E0DE RID: 57566 RVA: 0x0066B8B4 File Offset: 0x00669AB4
		private void ELLJEHHACHL()
		{
			if (!this.character.HKFLKEHPDFD())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("<color=blue>$&</color>", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-88)))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("Ready Crouch", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.S))
			{
				this.interactionSystem.TriggerInteraction(num, false);
			}
		}

		// Token: 0x0600E0DF RID: 57567 RVA: 0x0066B954 File Offset: 0x00669B54
		private void AEFGOFJAKDO()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("FOG_HAZE_ON", Array.Empty<GUILayoutOption>());
				if (Input.GetKey(KeyCode.Alpha7))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("WizardBlock", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-82)))
			{
				this.interactionSystem.TriggerInteraction(closestTriggerIndex, false);
			}
		}

		// Token: 0x0600E0E0 RID: 57568 RVA: 0x0066B9F4 File Offset: 0x00669BF4
		protected virtual void HMLNMHOMMNO()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.IsPaused()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 600f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.AKLFCMNCPKL();
		}

		// Token: 0x0600E0E1 RID: 57569 RVA: 0x0066BA74 File Offset: 0x00669C74
		protected virtual void KMLNBHIIGKH()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.IMABGAJEMDD()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 50f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.LMMDHJJJNJO();
		}

		// Token: 0x0600E0E2 RID: 57570 RVA: 0x0066BAF4 File Offset: 0x00669CF4
		private void JBGGMKEKOAN()
		{
			if (!this.character.NFEOLKHFKCI())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)10))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("MotorbikeLassoLeft", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)73))
			{
				this.interactionSystem.BALGINKLGFF(num, true);
			}
		}

		// Token: 0x0600E0E3 RID: 57571 RVA: 0x0066BB94 File Offset: 0x00669D94
		private void BCJFDHBDAHD()
		{
			if (!this.character.BHCCJCNDPKG())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("http://www.root-motion.com/finalikdox/html/page11.html", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)20))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-84)))
			{
				this.interactionSystem.BALGINKLGFF(num, true);
			}
		}

		// Token: 0x0600E0E4 RID: 57572 RVA: 0x0066BC34 File Offset: 0x00669E34
		private void POFHKNCEHKF()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("Right arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-24)))
				{
					this.interactionSystem.ResumeAll();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("minimalLevel", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-39)))
			{
				this.interactionSystem.BALGINKLGFF(closestTriggerIndex, false);
			}
		}

		// Token: 0x0600E0E5 RID: 57573 RVA: 0x0066BCD4 File Offset: 0x00669ED4
		protected virtual void PGIHAIPCJLL()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.IsPaused()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 1727f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.LIOCDEICIFD();
		}

		// Token: 0x0600E0E6 RID: 57574 RVA: 0x0066BD54 File Offset: 0x00669F54
		private void BBGAONKBIPJ()
		{
			if (!this.character.BHCCJCNDPKG())
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("fshop_hd4", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)86))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("{0:0} ч{1}, ", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-11)))
			{
				this.interactionSystem.TriggerInteraction(closestTriggerIndex, true);
			}
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x0066BDF4 File Offset: 0x00669FF4
		protected virtual void AMDMCKIFBPA()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 1713f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.OFPGMNGFLNH();
		}

		// Token: 0x0600E0E8 RID: 57576 RVA: 0x0066BE74 File Offset: 0x0066A074
		protected override void CBBLGEDCJBF()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 1288f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.JPHLMNIMDHH();
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x0066BEF4 File Offset: 0x0066A0F4
		protected override void AIAMIFEPALP()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.FLAMHJDPBAE();
				if (num > 463f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.DFFOEGHGPGP();
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x0066BF74 File Offset: 0x0066A174
		private void JGDDEOALNOG()
		{
			if (!this.character.AMPBDOAELJM())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("BackPackSearch", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)75))
				{
					this.interactionSystem.AEGOFPPDLGJ();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label("FOG_SCATTERING_ON", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-94)))
			{
				this.interactionSystem.TriggerInteraction(num, true);
			}
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x0066C014 File Offset: 0x0066A214
		private void KBAJMMCHDOC()
		{
			if (!this.character.NFEOLKHFKCI())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("cntx_close", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-75)))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(num))
			{
				return;
			}
			GUILayout.Label("_Source", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-72)))
			{
				this.interactionSystem.TriggerInteraction(num, false);
			}
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x0066C0B4 File Offset: 0x0066A2B4
		protected virtual void JIBKGOFOPHJ()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.PLNGLCGADOG();
				if (num > 13f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.JPHLMNIMDHH();
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x0066C134 File Offset: 0x0066A334
		private void JCMGHHKALDM()
		{
			if (!this.character.HKFLKEHPDFD())
			{
				return;
			}
			if (this.interactionSystem.EGAFEANDAAG() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("Cloth_01.wav", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)26))
				{
					this.interactionSystem.ResumeAll();
				}
				return;
			}
			int closestTriggerIndex = this.interactionSystem.GetClosestTriggerIndex();
			if (closestTriggerIndex == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(closestTriggerIndex))
			{
				return;
			}
			GUILayout.Label("Transform is null.", Array.Empty<GUILayoutOption>());
			if (Input.GetKey((KeyCode)(-10)))
			{
				this.interactionSystem.TriggerInteraction(closestTriggerIndex, true);
			}
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x0066C1D4 File Offset: 0x0066A3D4
		protected virtual void GCNGEFBKMNC()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.NEPDDPPAGEF() || this.interactionSystem.IsPaused()))
			{
				float minActiveProgress = this.interactionSystem.GetMinActiveProgress();
				if (minActiveProgress > 1639f && minActiveProgress < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = false;
					return;
				}
			}
			base.Update();
		}

		// Token: 0x0600E0EF RID: 57583 RVA: 0x0066C254 File Offset: 0x0066A454
		private void OLBDOHCILKO()
		{
			if (!this.character.HKFLKEHPDFD())
			{
				return;
			}
			if (this.interactionSystem.IsPaused() && this.interactionSystem.IsInSync())
			{
				GUILayout.Label("", Array.Empty<GUILayoutOption>());
				if (Input.GetKey((KeyCode)(-39)))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.FPFEEINEGGK(num))
			{
				return;
			}
			GUILayout.Label(".unity3d", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.R))
			{
				this.interactionSystem.BALGINKLGFF(num, true);
			}
		}

		// Token: 0x0600E0F0 RID: 57584 RVA: 0x0066C2F4 File Offset: 0x0066A4F4
		protected virtual void JLFBDOPFDDJ()
		{
			if (this.disableInputInInteraction && this.interactionSystem != null && (this.interactionSystem.CPHGPFGNNEH || this.interactionSystem.EGAFEANDAAG()))
			{
				float num = this.interactionSystem.EAKCAEGIJLA();
				if (num > 1489f && num < this.enableInputAtProgress)
				{
					this.state.ANPGPHIAMDM = Vector3.zero;
					this.state.IELMDLPINAH = true;
					return;
				}
			}
			base.HMEAENGBFKC();
		}

		// Token: 0x0600E0F1 RID: 57585 RVA: 0x0066C374 File Offset: 0x0066A574
		private void MPPMHCICKIP()
		{
			if (!this.character.NFEOLKHFKCI())
			{
				return;
			}
			if (this.interactionSystem.IMABGAJEMDD() && this.interactionSystem.IJDLGMLMHLG())
			{
				GUILayout.Label("PistolFire", Array.Empty<GUILayoutOption>());
				if (Input.GetKey(KeyCode.Equals))
				{
					this.interactionSystem.FEGPDLHOPKD();
				}
				return;
			}
			int num = this.interactionSystem.MNANBKIACDF();
			if (num == -1)
			{
				return;
			}
			if (!this.interactionSystem.TriggerEffectorsReady(num))
			{
				return;
			}
			GUILayout.Label("Gesture Hand Up", Array.Empty<GUILayoutOption>());
			if (Input.GetKey(KeyCode.Backspace))
			{
				this.interactionSystem.TriggerInteraction(num, true);
			}
		}

		// Token: 0x04001D8F RID: 7567
		[SerializeField]
		private CharacterThirdPerson character;

		// Token: 0x04001D90 RID: 7568
		[SerializeField]
		private InteractionSystem interactionSystem;

		// Token: 0x04001D91 RID: 7569
		[SerializeField]
		private bool disableInputInInteraction = true;

		// Token: 0x04001D92 RID: 7570
		public float enableInputAtProgress = 0.8f;
	}
}
