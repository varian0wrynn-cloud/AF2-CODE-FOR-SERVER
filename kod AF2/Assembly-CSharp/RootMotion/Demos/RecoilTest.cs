using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200040C RID: 1036
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		// Token: 0x0600DDED RID: 56813 RVA: 0x0065CB58 File Offset: 0x0065AD58
		private void OnGUI()
		{
			GUILayout.Label("Press R or LMB for procedural recoil.", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDEF RID: 56815 RVA: 0x0065CB7C File Offset: 0x0065AD7C
		private void BLCDCEHNNNC()
		{
			GUILayout.Label("WeaponStrafeRunRight", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDF0 RID: 56816 RVA: 0x0065CB8D File Offset: 0x0065AD8D
		private void OBDAPPLCPMD()
		{
			GUILayout.Label("inWater", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDF1 RID: 56817 RVA: 0x0065CB9E File Offset: 0x0065AD9E
		private void BOAJJAKEMLH()
		{
			if (Input.GetKeyDown((KeyCode)1) || Input.GetMouseButtonDown(0))
			{
				this.DOMGPKKKOHB.KKHDKNHKEJF(this.magnitude);
			}
		}

		// Token: 0x0600DDF2 RID: 56818 RVA: 0x0065CBC2 File Offset: 0x0065ADC2
		private void AKLFCMNCPKL()
		{
			if (Input.GetKeyDown((KeyCode)(-74)) || Input.GetMouseButtonDown(0))
			{
				this.DOMGPKKKOHB.IIFBGNJAEIC(this.magnitude);
			}
		}

		// Token: 0x0600DDF3 RID: 56819 RVA: 0x0065CBE6 File Offset: 0x0065ADE6
		private void JPHLMNIMDHH()
		{
			if (Input.GetKeyDown(KeyCode.Clear) || Input.GetMouseButtonDown(1))
			{
				this.DOMGPKKKOHB.KBGHDNDJBCE(this.magnitude);
			}
		}

		// Token: 0x0600DDF4 RID: 56820 RVA: 0x0065CC0A File Offset: 0x0065AE0A
		private void FIJKDFIMELM()
		{
			this.DOMGPKKKOHB = base.GetComponent<Recoil>();
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x0065CC18 File Offset: 0x0065AE18
		private void LDDIGEMBDNF()
		{
			if (Input.GetKeyDown(KeyCode.Minus) || Input.GetMouseButtonDown(1))
			{
				this.DOMGPKKKOHB.BLEMIHOCBNO(this.magnitude);
			}
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x0065CC0A File Offset: 0x0065AE0A
		private void HHGGCBLOJGB()
		{
			this.DOMGPKKKOHB = base.GetComponent<Recoil>();
		}

		// Token: 0x0600DDF7 RID: 56823 RVA: 0x0065CC3C File Offset: 0x0065AE3C
		private void BCJFDHBDAHD()
		{
			GUILayout.Label(" on effect ", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDF8 RID: 56824 RVA: 0x0065CC0A File Offset: 0x0065AE0A
		private void KEMGOLACEHI()
		{
			this.DOMGPKKKOHB = base.GetComponent<Recoil>();
		}

		// Token: 0x0600DDF9 RID: 56825 RVA: 0x0065CC4D File Offset: 0x0065AE4D
		private void OHKHOAKCENL()
		{
			if (Input.GetKeyDown((KeyCode)75) || Input.GetMouseButtonDown(1))
			{
				this.DOMGPKKKOHB.KBGHDNDJBCE(this.magnitude);
			}
		}

		// Token: 0x0600DDFA RID: 56826 RVA: 0x0065CC0A File Offset: 0x0065AE0A
		private void Start()
		{
			this.DOMGPKKKOHB = base.GetComponent<Recoil>();
		}

		// Token: 0x0600DDFB RID: 56827 RVA: 0x0065CC0A File Offset: 0x0065AE0A
		private void CPNOBMNKPNC()
		{
			this.DOMGPKKKOHB = base.GetComponent<Recoil>();
		}

		// Token: 0x0600DDFC RID: 56828 RVA: 0x0065CC71 File Offset: 0x0065AE71
		private void BMCKJEBCEPA()
		{
			GUILayout.Label("ObscuredInt vs int, ", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600DDFD RID: 56829 RVA: 0x0065CC82 File Offset: 0x0065AE82
		private void PJHEGHHOJHJ()
		{
			if (Input.GetKeyDown((KeyCode)(-16)) || Input.GetMouseButtonDown(1))
			{
				this.DOMGPKKKOHB.BMJOLODJDHL(this.magnitude);
			}
		}

		// Token: 0x0600DDFE RID: 56830 RVA: 0x0065CC0A File Offset: 0x0065AE0A
		private void EDGALMCHPPH()
		{
			this.DOMGPKKKOHB = base.GetComponent<Recoil>();
		}

		// Token: 0x0600DDFF RID: 56831 RVA: 0x0065CC0A File Offset: 0x0065AE0A
		private void ANHOOJFEJJE()
		{
			this.DOMGPKKKOHB = base.GetComponent<Recoil>();
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x0065CCA6 File Offset: 0x0065AEA6
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.R) || Input.GetMouseButtonDown(0))
			{
				this.DOMGPKKKOHB.Fire(this.magnitude);
			}
		}

		// Token: 0x04001D61 RID: 7521
		public float magnitude = 1f;

		// Token: 0x04001D62 RID: 7522
		private Recoil DOMGPKKKOHB;
	}
}
