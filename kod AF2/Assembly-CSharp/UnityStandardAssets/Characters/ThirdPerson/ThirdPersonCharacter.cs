using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
	// Token: 0x020003A1 RID: 929
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		// Token: 0x0600C87C RID: 51324 RVA: 0x005989BC File Offset: 0x00596BBC
		private void BNMIKNDCBHA()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 140f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C87D RID: 51325 RVA: 0x00598A3C File Offset: 0x00596C3C
		public void KBIIGMABBFO()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1959f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C87E RID: 51326 RVA: 0x00598AA4 File Offset: 0x00596CA4
		private void NOLDLPIFGLH(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).IsName("trn_reg"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 910f;
			}
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x00598B28 File Offset: 0x00596D28
		private void GGCFHIJNAOJ(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("wpn_tank2", this.AOFIKPCPDJN, 987f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("cht_msg32", this.AFHKGMCAPBI, 301f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("ClimbRight", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("Error!", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("_Direction", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 346f) < 999f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("C", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 43f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 364f;
		}

		// Token: 0x0600C880 RID: 51328 RVA: 0x00598C54 File Offset: 0x00596E54
		private void CBCANCCHHLO()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 1788f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = true;
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x00598CD4 File Offset: 0x00596ED4
		private void ELLPAOJABMB()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 827f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 538f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 1575f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x00598D60 File Offset: 0x00596F60
		public void HPGBIANDJPO(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1186f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.BNOHNOMKCNF();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.GMOKGJAJHIK();
			if (this.OJMEFBNHGIM)
			{
				this.JKKLNNNHNND(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.HLPJMCJHBMN();
			}
			this.HMJCNIEGDKF(MGCOIPEBMIF);
			this.NHFGGGHHHDH();
			this.BPENNILMDIN(ANPGPHIAMDM);
		}

		// Token: 0x0600C883 RID: 51331 RVA: 0x00598DFC File Offset: 0x00596FFC
		private void NKODNPMPFNJ(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("ingredients", this.AOFIKPCPDJN, 1849f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("_Radius2", this.AFHKGMCAPBI, 1891f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("reel_type2", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("INTERFACE", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("IdleDie2", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 798f) < 1333f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("ScubaSwim", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1306f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 293f;
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x00598F28 File Offset: 0x00597128
		private void CCHPGLGEGHM()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 1820f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = false;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = true;
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x00598FA8 File Offset: 0x005971A8
		public void ONGLOCLINIM(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1769f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.IOEEKEOAAKL();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.DEEEJJAPPAB();
			if (this.OJMEFBNHGIM)
			{
				this.GKBOOMAJJME(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.BEHPKEMGDMA();
			}
			this.JBJOHCIJPLC(MGCOIPEBMIF);
			this.FOBIIBJPADA();
			this.BJLJBJHLLMC(ANPGPHIAMDM);
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x00599044 File Offset: 0x00597244
		private void CKECHMLGMOI()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 194f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = true;
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x005990C4 File Offset: 0x005972C4
		public void DBGDNKOAGPJ(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 392f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.EKGLJDLBHJM();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.DEEEJJAPPAB();
			if (this.OJMEFBNHGIM)
			{
				this.LANONPDPOIH(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.HLPJMCJHBMN();
			}
			this.GDPKLODJJHD(MGCOIPEBMIF);
			this.NHFGGGHHHDH();
			this.BJLJBJHLLMC(ANPGPHIAMDM);
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x00599160 File Offset: 0x00597360
		private void IJOKGFHGBIH()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(1882f, this.AFHKGMCAPBI * num * Time.deltaTime, 1426f);
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x005991A8 File Offset: 0x005973A8
		private void DDNPHLJGKEL(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName("Cloth_01.wav"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 1329f;
			}
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x0059922C File Offset: 0x0059742C
		public void JFGLHCAHGKH()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 792f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x00599294 File Offset: 0x00597494
		private void EDPGGLOJEFL(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("WeaponStrafeRunRight", this.AOFIKPCPDJN, 1001f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("crft_to", this.AFHKGMCAPBI, 970f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("crft_konstr", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("cht_msg10", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("ALP=", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 541f) < 1583f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("Zombie Walk", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1878f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1457f;
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x005993C0 File Offset: 0x005975C0
		private void DBMOLPBAGAL(bool MGCOIPEBMIF)
		{
			if (this.OJMEFBNHGIM && MGCOIPEBMIF)
			{
				if (this.NOGFABGPJNB)
				{
					return;
				}
				this.FAEMFNCJNKD.height = this.FAEMFNCJNKD.height / 2f;
				this.FAEMFNCJNKD.center = this.FAEMFNCJNKD.center / 2f;
				this.NOGFABGPJNB = true;
				return;
			}
			else
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 0.5f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 0.5f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 0.5f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
					return;
				}
				this.FAEMFNCJNKD.height = this.FEOIIDEPMHM;
				this.FAEMFNCJNKD.center = this.JFEGEEAOBGC;
				this.NOGFABGPJNB = false;
				return;
			}
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x005994C4 File Offset: 0x005976C4
		public void HCHGCEMICOH()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1274f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x0059952C File Offset: 0x0059772C
		private void AOHANGNHCDL(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat(" ms", this.AOFIKPCPDJN, 794f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("_EmissionColor", this.AFHKGMCAPBI, 154f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("IdleKeepBack", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("<<", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 732f) < 1825f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("level", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1499f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 566f;
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x00599658 File Offset: 0x00597858
		private void CGPEIDKCLBI()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 0.1f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = false;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x005996D8 File Offset: 0x005978D8
		private void EMHONAEFOCP()
		{
			Vector3 force = Physics.gravity * this.m_GravityMultiplier - Physics.gravity;
			this.JMKPNAOICPE.AddForce(force);
			this.m_GroundCheckDistance = ((this.JMKPNAOICPE.velocity.y < 1820f) ? this.MNPJDAPIFGB : 1945f);
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x00599738 File Offset: 0x00597938
		private void KIEIPFFEDHC()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)(-8);
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C892 RID: 51346 RVA: 0x005997A4 File Offset: 0x005979A4
		private void DEEEJJAPPAB()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(855f, this.AFHKGMCAPBI * num * Time.deltaTime, 886f);
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x005997EC File Offset: 0x005979EC
		private void HHGBLLNPDFN()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(1137f, this.AFHKGMCAPBI * num * Time.deltaTime, 412f);
		}

		// Token: 0x0600C895 RID: 51349 RVA: 0x005998A0 File Offset: 0x00597AA0
		public void ALHMBIHFLJH()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 884f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C896 RID: 51350 RVA: 0x00599908 File Offset: 0x00597B08
		private void HHHCJDMJFFM()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 971f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = false;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = true;
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x00599988 File Offset: 0x00597B88
		private void OAAPBOIOPIE()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(662f, this.AFHKGMCAPBI * num * Time.deltaTime, 1855f);
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x005999D0 File Offset: 0x00597BD0
		private void IPKFIJONIMI(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("Mouse Y", this.AOFIKPCPDJN, 800f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("exitmsg_2", this.AFHKGMCAPBI, 1359f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("_InvGamma", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("Curve", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("м</color>", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 1728f) < 13f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("+ EXP for FISH=", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1631f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 931f;
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x00599AFC File Offset: 0x00597CFC
		private void BNDKIDDEJHL(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).IsName("Loading "))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = false;
				this.m_GroundCheckDistance = 1518f;
			}
		}

		// Token: 0x0600C89A RID: 51354 RVA: 0x00599B80 File Offset: 0x00597D80
		private void LANONPDPOIH(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = false;
				this.m_GroundCheckDistance = 0.1f;
			}
		}

		// Token: 0x0600C89B RID: 51355 RVA: 0x00599C04 File Offset: 0x00597E04
		private void KJDDEOBPIPK()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(11f, this.AFHKGMCAPBI * num * Time.deltaTime, 282f);
		}

		// Token: 0x0600C89C RID: 51356 RVA: 0x00599C4C File Offset: 0x00597E4C
		private void IOEEKEOAAKL()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 1576f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = false;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C89D RID: 51357 RVA: 0x00599CCC File Offset: 0x00597ECC
		private void FJGIBCHABIG()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)(-42);
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C89E RID: 51358 RVA: 0x00599D38 File Offset: 0x00597F38
		private void NLJALIJMKGB()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 336f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 579f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 1724f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = false;
				}
			}
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x00599DC4 File Offset: 0x00597FC4
		public void OnAnimatorMove()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 0f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x00599E2C File Offset: 0x0059802C
		private void AFLMGAMIGCO(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).IsName("RollerBladeTurnLeft"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = false;
				this.m_GroundCheckDistance = 76f;
			}
		}

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x00599EB0 File Offset: 0x005980B0
		private void BNOHNOMKCNF()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 1128f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = false;
				return;
			}
			this.OJMEFBNHGIM = false;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = true;
		}

		// Token: 0x0600C8A2 RID: 51362 RVA: 0x00599F30 File Offset: 0x00598130
		private void EEMMPGONCFB(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName("error: already initialized"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 1028f;
			}
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x00599FB4 File Offset: 0x005981B4
		private void GMOKGJAJHIK()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(1933f, this.AFHKGMCAPBI * num * Time.deltaTime, 554f);
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x00599FFC File Offset: 0x005981FC
		private void ENLHDMLIOKM()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1606f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 558f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 1261f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x0059A088 File Offset: 0x00598288
		private void CHDJGEOFHEE()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)27;
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x0059A0F4 File Offset: 0x005982F4
		private void FOBIIBJPADA()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1579f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1755f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 979f, maxDistance, -1, QueryTriggerInteraction.UseGlobal))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x0059A180 File Offset: 0x00598380
		private void ONINLKBKNNK(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName(""))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 1662f;
			}
		}

		// Token: 0x0600C8A8 RID: 51368 RVA: 0x0059A204 File Offset: 0x00598404
		private void DLFAHLDDLPL(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("_BlurFilterDistance", this.AOFIKPCPDJN, 902f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("cntx_resauk", this.AFHKGMCAPBI, 870f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("CATRigR", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("#400000", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).normalizedTime + this.m_RunCycleLegOffset, 730f) < 1561f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("</i></color>", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 596f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1932f;
		}

		// Token: 0x0600C8A9 RID: 51369 RVA: 0x0059A330 File Offset: 0x00598530
		private void OKADPGHOMJO()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 210f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = false;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C8AA RID: 51370 RVA: 0x0059A3B0 File Offset: 0x005985B0
		private void CMBKNHFPIEM()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 258f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = true;
		}

		// Token: 0x0600C8AB RID: 51371 RVA: 0x0059A430 File Offset: 0x00598630
		private void Start()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = RigidbodyConstraints.FreezeRotation;
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8AC RID: 51372 RVA: 0x0059A49C File Offset: 0x0059869C
		public void MDNFBAPDNME()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 735f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8AD RID: 51373 RVA: 0x0059A504 File Offset: 0x00598704
		public void FNDHBBMJGON()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1727f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8AE RID: 51374 RVA: 0x0059A56C File Offset: 0x0059876C
		public void Move(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.CGPEIDKCLBI();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.KMAGBHFCILL();
			if (this.OJMEFBNHGIM)
			{
				this.LANONPDPOIH(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.BJIAAGHEOHM();
			}
			this.DBMOLPBAGAL(MGCOIPEBMIF);
			this.FBDHOPFMBIA();
			this.IAFHEFLJJIK(ANPGPHIAMDM);
		}

		// Token: 0x0600C8AF RID: 51375 RVA: 0x0059A608 File Offset: 0x00598808
		public void LLBLGDJGIMP(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1562f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.CBCANCCHHLO();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.OAAPBOIOPIE();
			if (this.OJMEFBNHGIM)
			{
				this.ONINLKBKNNK(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.ANHCNONHBGC();
			}
			this.JJKLDEBEIFN(MGCOIPEBMIF);
			this.JONNDOLKCAL();
			this.DGPPDFBIEPG(ANPGPHIAMDM);
		}

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x0059A6A4 File Offset: 0x005988A4
		private void COOHGDDCEHN()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 59f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x0059A724 File Offset: 0x00598924
		private void NJMJAMBGDEL()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(240f, this.AFHKGMCAPBI * num * Time.deltaTime, 1404f);
		}

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x0059A76C File Offset: 0x0059896C
		private void GDPKLODJJHD(bool MGCOIPEBMIF)
		{
			if (this.OJMEFBNHGIM && MGCOIPEBMIF)
			{
				if (this.NOGFABGPJNB)
				{
					return;
				}
				this.FAEMFNCJNKD.height = this.FAEMFNCJNKD.height / 108f;
				this.FAEMFNCJNKD.center = this.FAEMFNCJNKD.center / 434f;
				this.NOGFABGPJNB = true;
				return;
			}
			else
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 403f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1728f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 442f, maxDistance, -1, QueryTriggerInteraction.UseGlobal))
				{
					this.NOGFABGPJNB = true;
					return;
				}
				this.FAEMFNCJNKD.height = this.FEOIIDEPMHM;
				this.FAEMFNCJNKD.center = this.JFEGEEAOBGC;
				this.NOGFABGPJNB = true;
				return;
			}
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x0059A870 File Offset: 0x00598A70
		public void EEOOFIFAJOD()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1802f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x0059A8D8 File Offset: 0x00598AD8
		private void FJPCCAKCNIJ(bool MGCOIPEBMIF)
		{
			if (this.OJMEFBNHGIM && MGCOIPEBMIF)
			{
				if (this.NOGFABGPJNB)
				{
					return;
				}
				this.FAEMFNCJNKD.height = this.FAEMFNCJNKD.height / 1129f;
				this.FAEMFNCJNKD.center = this.FAEMFNCJNKD.center / 1892f;
				this.NOGFABGPJNB = false;
				return;
			}
			else
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1811f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 30f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 640f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
					return;
				}
				this.FAEMFNCJNKD.height = this.FEOIIDEPMHM;
				this.FAEMFNCJNKD.center = this.JFEGEEAOBGC;
				this.NOGFABGPJNB = true;
				return;
			}
		}

		// Token: 0x0600C8B5 RID: 51381 RVA: 0x0059A9DC File Offset: 0x00598BDC
		private void JHCAEGPPOBL()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 786f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = true;
		}

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x0059AA5C File Offset: 0x00598C5C
		private void OKDNAPPDCFG(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName("shop_bccost"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = false;
				this.m_GroundCheckDistance = 1777f;
			}
		}

		// Token: 0x0600C8B7 RID: 51383 RVA: 0x0059AAE0 File Offset: 0x00598CE0
		private void EFCCCKGCOCB()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = RigidbodyConstraints.FreezeRotationY;
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8B8 RID: 51384 RVA: 0x0059AB4C File Offset: 0x00598D4C
		private void BLDPMIDPGDI()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 149f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 207f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 296f, maxDistance, -1, QueryTriggerInteraction.UseGlobal))
				{
					this.NOGFABGPJNB = false;
				}
			}
		}

		// Token: 0x0600C8B9 RID: 51385 RVA: 0x0059ABD8 File Offset: 0x00598DD8
		private void MEHHJGMDLEE()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(91f, this.AFHKGMCAPBI * num * Time.deltaTime, 1365f);
		}

		// Token: 0x0600C8BA RID: 51386 RVA: 0x0059AC20 File Offset: 0x00598E20
		public void LOIHEBEJOMI(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1355f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.CKECHMLGMOI();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.MEHHJGMDLEE();
			if (this.OJMEFBNHGIM)
			{
				this.JKKLNNNHNND(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.BEHPKEMGDMA();
			}
			this.JBJOHCIJPLC(MGCOIPEBMIF);
			this.ENLHDMLIOKM();
			this.AOHANGNHCDL(ANPGPHIAMDM);
		}

		// Token: 0x0600C8BB RID: 51387 RVA: 0x0059ACBC File Offset: 0x00598EBC
		private void JONNDOLKCAL()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 712f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 463f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 1844f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C8BC RID: 51388 RVA: 0x0059AD48 File Offset: 0x00598F48
		private void NHFGGGHHHDH()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1512f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1141f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 100f, maxDistance, -1, QueryTriggerInteraction.UseGlobal))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C8BD RID: 51389 RVA: 0x0059ADD4 File Offset: 0x00598FD4
		private void LPNDCJKAKEA()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)(-43);
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8BE RID: 51390 RVA: 0x0059AE40 File Offset: 0x00599040
		private void JJHBMJHDEDH(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).IsName("wpn_rec2"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 73f;
			}
		}

		// Token: 0x0600C8BF RID: 51391 RVA: 0x0059AEC4 File Offset: 0x005990C4
		private void CMFJBEKFPBA()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(1370f, this.AFHKGMCAPBI * num * Time.deltaTime, 1667f);
		}

		// Token: 0x0600C8C0 RID: 51392 RVA: 0x0059AF0C File Offset: 0x0059910C
		private void KKCFKEDABLB()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)(-51);
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8C1 RID: 51393 RVA: 0x0059AF78 File Offset: 0x00599178
		private void JKKLNNNHNND(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName(""))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 912f;
			}
		}

		// Token: 0x0600C8C2 RID: 51394 RVA: 0x0059AFFC File Offset: 0x005991FC
		private void ANHCNONHBGC()
		{
			Vector3 force = Physics.gravity * this.m_GravityMultiplier - Physics.gravity;
			this.JMKPNAOICPE.AddForce(force);
			this.m_GroundCheckDistance = ((this.JMKPNAOICPE.velocity.y < 1852f) ? this.MNPJDAPIFGB : 1919f);
		}

		// Token: 0x0600C8C3 RID: 51395 RVA: 0x0059B05C File Offset: 0x0059925C
		public void PEGCCIJGGDP(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1017f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.COOHGDDCEHN();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.EIDFJHLMNDL();
			if (this.OJMEFBNHGIM)
			{
				this.BNDKIDDEJHL(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.EMHONAEFOCP();
			}
			this.FJPCCAKCNIJ(MGCOIPEBMIF);
			this.JGLOKPMEKOJ();
			this.IPKFIJONIMI(ANPGPHIAMDM);
		}

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x0059B0F8 File Offset: 0x005992F8
		private void BNAEJNEDKCL()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(308f, this.AFHKGMCAPBI * num * Time.deltaTime, 662f);
		}

		// Token: 0x0600C8C5 RID: 51397 RVA: 0x0059B140 File Offset: 0x00599340
		private void JBJOHCIJPLC(bool MGCOIPEBMIF)
		{
			if (this.OJMEFBNHGIM && MGCOIPEBMIF)
			{
				if (this.NOGFABGPJNB)
				{
					return;
				}
				this.FAEMFNCJNKD.height = this.FAEMFNCJNKD.height / 483f;
				this.FAEMFNCJNKD.center = this.FAEMFNCJNKD.center / 1877f;
				this.NOGFABGPJNB = false;
				return;
			}
			else
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 732f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1286f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 1517f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
					return;
				}
				this.FAEMFNCJNKD.height = this.FEOIIDEPMHM;
				this.FAEMFNCJNKD.center = this.JFEGEEAOBGC;
				this.NOGFABGPJNB = true;
				return;
			}
		}

		// Token: 0x0600C8C6 RID: 51398 RVA: 0x0059B244 File Offset: 0x00599444
		private void BPENNILMDIN(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("category", this.AOFIKPCPDJN, 1895f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("#> _Planar Reflection Camera < ", this.AFHKGMCAPBI, 1868f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("inner_craft_wpn", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("HDR", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("wpn_add/use_effect/effect", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).normalizedTime + this.m_RunCycleLegOffset, 810f) < 1553f) ? 1 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("RollerBladeBackFlip", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 778f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1503f;
		}

		// Token: 0x0600C8C7 RID: 51399 RVA: 0x0059B370 File Offset: 0x00599570
		private void HMJCNIEGDKF(bool MGCOIPEBMIF)
		{
			if (this.OJMEFBNHGIM && MGCOIPEBMIF)
			{
				if (this.NOGFABGPJNB)
				{
					return;
				}
				this.FAEMFNCJNKD.height = this.FAEMFNCJNKD.height / 282f;
				this.FAEMFNCJNKD.center = this.FAEMFNCJNKD.center / 782f;
				this.NOGFABGPJNB = false;
				return;
			}
			else
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1886f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1835f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 1253f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = false;
					return;
				}
				this.FAEMFNCJNKD.height = this.FEOIIDEPMHM;
				this.FAEMFNCJNKD.center = this.JFEGEEAOBGC;
				this.NOGFABGPJNB = false;
				return;
			}
		}

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x0059B474 File Offset: 0x00599674
		public void OMDDECIKHGN()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1016f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x0059B4DC File Offset: 0x005996DC
		private void LCBIFGKANMD()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)52;
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8CA RID: 51402 RVA: 0x0059B548 File Offset: 0x00599748
		private void DBKMAIBBNBA()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(648f, this.AFHKGMCAPBI * num * Time.deltaTime, 1816f);
		}

		// Token: 0x0600C8CB RID: 51403 RVA: 0x0059B590 File Offset: 0x00599790
		public void IKCBCJKKNLI()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 215f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x0059B5F8 File Offset: 0x005997F8
		private void NCBLFNKNEDK()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)84;
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8CD RID: 51405 RVA: 0x0059B664 File Offset: 0x00599864
		private void DLIEMOBJGCG()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(1557f, this.AFHKGMCAPBI * num * Time.deltaTime, 1066f);
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x0059B6AC File Offset: 0x005998AC
		private void OGDPOABLGCG(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("IceHockeyPassLeft", this.AOFIKPCPDJN, 1123f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("SoccerKeeperStrafeRight", this.AFHKGMCAPBI, 427f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("wpn_bait1", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("USER_LUT", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("DragObject", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).normalizedTime + this.m_RunCycleLegOffset, 669f) < 1111f) ? 1 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("close", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1459f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 405f;
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x0059B7D8 File Offset: 0x005999D8
		public void LLNGHJLJCGJ()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1026f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x0059B840 File Offset: 0x00599A40
		private void CKALCDPKMEA(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("double:", this.AOFIKPCPDJN, 1402f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("demoByteArray", this.AFHKGMCAPBI, 1530f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("walk", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("{not_found}", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("_FogColor", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 1862f) < 1568f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("_Offsets", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1171f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 601f;
		}

		// Token: 0x0600C8D1 RID: 51409 RVA: 0x0059B96C File Offset: 0x00599B6C
		private void BHGFKMGDPHP()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1445f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1585f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 1132f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C8D2 RID: 51410 RVA: 0x0059B9F8 File Offset: 0x00599BF8
		private void DFAOCAPIJKA(bool MGCOIPEBMIF)
		{
			if (this.OJMEFBNHGIM && MGCOIPEBMIF)
			{
				if (this.NOGFABGPJNB)
				{
					return;
				}
				this.FAEMFNCJNKD.height = this.FAEMFNCJNKD.height / 1638f;
				this.FAEMFNCJNKD.center = this.FAEMFNCJNKD.center / 1298f;
				this.NOGFABGPJNB = true;
				return;
			}
			else
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1099f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 97f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 537f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = false;
					return;
				}
				this.FAEMFNCJNKD.height = this.FEOIIDEPMHM;
				this.FAEMFNCJNKD.center = this.JFEGEEAOBGC;
				this.NOGFABGPJNB = false;
				return;
			}
		}

		// Token: 0x0600C8D3 RID: 51411 RVA: 0x0059BAFC File Offset: 0x00599CFC
		private void BMNJGPIPKLL()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)105;
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8D4 RID: 51412 RVA: 0x0059BB68 File Offset: 0x00599D68
		public void OHCDJPJFHGD()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1215f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8D5 RID: 51413 RVA: 0x0059BBD0 File Offset: 0x00599DD0
		private void GKBOOMAJJME(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).IsName("}"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 1972f;
			}
		}

		// Token: 0x0600C8D6 RID: 51414 RVA: 0x0059BC54 File Offset: 0x00599E54
		private void EKGLJDLBHJM()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 192f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = false;
				return;
			}
			this.OJMEFBNHGIM = false;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C8D7 RID: 51415 RVA: 0x0059BCD4 File Offset: 0x00599ED4
		private void JLLJJKIBLJF(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).IsName("cht_msg38"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 1932f;
			}
		}

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x0059BD58 File Offset: 0x00599F58
		private void CLGGAPONDHF(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).IsName("StaffHeal"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = false;
				this.m_GroundCheckDistance = 596f;
			}
		}

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x0059BDDC File Offset: 0x00599FDC
		private void EIDFJHLMNDL()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(734f, this.AFHKGMCAPBI * num * Time.deltaTime, 907f);
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x0059BE24 File Offset: 0x0059A024
		public void CKKABCEOIJK()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1073f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x0059BE8C File Offset: 0x0059A08C
		private void IAFHEFLJJIK(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("Forward", this.AOFIKPCPDJN, 0.1f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("Turn", this.AFHKGMCAPBI, 0.1f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("Crouch", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("OnGround", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("Jump", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 1f) < 0.5f) ? 1 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("JumpLeg", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 0f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1f;
		}

		// Token: 0x0600C8DC RID: 51420 RVA: 0x0059BFB8 File Offset: 0x0059A1B8
		private void HLPJMCJHBMN()
		{
			Vector3 force = Physics.gravity * this.m_GravityMultiplier - Physics.gravity;
			this.JMKPNAOICPE.AddForce(force);
			this.m_GroundCheckDistance = ((this.JMKPNAOICPE.velocity.y < 1820f) ? this.MNPJDAPIFGB : 1281f);
		}

		// Token: 0x0600C8DD RID: 51421 RVA: 0x0059C018 File Offset: 0x0059A218
		private void CJNBMPCNKHP()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)51;
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8DE RID: 51422 RVA: 0x0059C084 File Offset: 0x0059A284
		public void MKEMPIEPDGK(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1633f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.BGPIBBKKFBO();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.HHGBLLNPDFN();
			if (this.OJMEFBNHGIM)
			{
				this.DDNPHLJGKEL(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.KIDBPLHJPJJ();
			}
			this.DBMOLPBAGAL(MGCOIPEBMIF);
			this.POLCJIEFGLA();
			this.NKODNPMPFNJ(ANPGPHIAMDM);
		}

		// Token: 0x0600C8DF RID: 51423 RVA: 0x0059C120 File Offset: 0x0059A320
		public void FEDBMMIJFDC()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 815f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x0059C188 File Offset: 0x0059A388
		private void OIMBHELAJPC(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("Pistol", this.AOFIKPCPDJN, 944f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("buykey", this.AFHKGMCAPBI, 608f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("wpn_rod2", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool(" шт.", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("******** nextMusicCrt lng=", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).normalizedTime + this.m_RunCycleLegOffset, 541f) < 1719f) ? 1 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("Fishing", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1977f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1639f;
		}

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x0059C2B4 File Offset: 0x0059A4B4
		private void FAJCKGEJDCH(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName("Toggle"))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 1608f;
			}
		}

		// Token: 0x0600C8E2 RID: 51426 RVA: 0x0059C338 File Offset: 0x0059A538
		public void OPPGCGKACMN()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 418f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8E3 RID: 51427 RVA: 0x0059C3A0 File Offset: 0x0059A5A0
		private void BONBHLCEFKE()
		{
			Vector3 force = Physics.gravity * this.m_GravityMultiplier - Physics.gravity;
			this.JMKPNAOICPE.AddForce(force);
			this.m_GroundCheckDistance = ((this.JMKPNAOICPE.velocity.y < 193f) ? this.MNPJDAPIFGB : 1130f);
		}

		// Token: 0x0600C8E4 RID: 51428 RVA: 0x0059C400 File Offset: 0x0059A600
		private void BJIAAGHEOHM()
		{
			Vector3 force = Physics.gravity * this.m_GravityMultiplier - Physics.gravity;
			this.JMKPNAOICPE.AddForce(force);
			this.m_GroundCheckDistance = ((this.JMKPNAOICPE.velocity.y < 0f) ? this.MNPJDAPIFGB : 0.01f);
		}

		// Token: 0x0600C8E5 RID: 51429 RVA: 0x0059C460 File Offset: 0x0059A660
		private void BJLJBJHLLMC(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("post_msg6", this.AOFIKPCPDJN, 1017f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("\n", this.AFHKGMCAPBI, 882f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("Move around with WASD or cursor keys, space to jump", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 697f) < 0f) ? 1 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("invn_rec6", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1679f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 390f;
		}

		// Token: 0x0600C8E6 RID: 51430 RVA: 0x0059C58C File Offset: 0x0059A78C
		private void BEHPKEMGDMA()
		{
			Vector3 force = Physics.gravity * this.m_GravityMultiplier - Physics.gravity;
			this.JMKPNAOICPE.AddForce(force);
			this.m_GroundCheckDistance = ((this.JMKPNAOICPE.velocity.y < 939f) ? this.MNPJDAPIFGB : 175f);
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x0059C5EC File Offset: 0x0059A7EC
		private void POLCJIEFGLA()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1271f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 276f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 948f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = false;
				}
			}
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x0059C678 File Offset: 0x0059A878
		public void KKIINLKKDFD()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 583f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8E9 RID: 51433 RVA: 0x0059C6E0 File Offset: 0x0059A8E0
		private void BGCLAKJHAFK()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)(-69);
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x0059C74C File Offset: 0x0059A94C
		private void KIDBPLHJPJJ()
		{
			Vector3 force = Physics.gravity * this.m_GravityMultiplier - Physics.gravity;
			this.JMKPNAOICPE.AddForce(force);
			this.m_GroundCheckDistance = ((this.JMKPNAOICPE.velocity.y < 145f) ? this.MNPJDAPIFGB : 143f);
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x0059C7AC File Offset: 0x0059A9AC
		private void NCNECDKLPDA()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(1810f, this.AFHKGMCAPBI * num * Time.deltaTime, 934f);
		}

		// Token: 0x0600C8EC RID: 51436 RVA: 0x0059C7F4 File Offset: 0x0059A9F4
		private void FBDHOPFMBIA()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 0.5f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 0.5f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 0.5f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C8ED RID: 51437 RVA: 0x0059C880 File Offset: 0x0059AA80
		private void BHFMGBNIAMC()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)(-49);
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8EE RID: 51438 RVA: 0x0059C8EC File Offset: 0x0059AAEC
		private void BGPIBBKKFBO()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 744f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = false;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C8EF RID: 51439 RVA: 0x0059C96C File Offset: 0x0059AB6C
		private void DGPPDFBIEPG(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("RunBackward", this.AOFIKPCPDJN, 1056f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("______________________________", this.AFHKGMCAPBI, 654f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("gi_nlheader2", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("author", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 1723f) < 925f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 1410f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1260f;
		}

		// Token: 0x0600C8F0 RID: 51440 RVA: 0x0059CA98 File Offset: 0x0059AC98
		private void PKHEKOPMALP()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 1134f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x0059CB18 File Offset: 0x0059AD18
		public void APPNFODHEAG()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 44f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x0059CB80 File Offset: 0x0059AD80
		private void CFDICCPCLAA(bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (IELMDLPINAH && !MGCOIPEBMIF && this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).IsName(""))
			{
				this.JMKPNAOICPE.velocity = new Vector3(this.JMKPNAOICPE.velocity.x, this.m_JumpPower, this.JMKPNAOICPE.velocity.z);
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = true;
				this.m_GroundCheckDistance = 1218f;
			}
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x0059CC04 File Offset: 0x0059AE04
		private void LIEBMOMGHHC()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1886f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1017f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 723f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = true;
				}
			}
		}

		// Token: 0x0600C8F4 RID: 51444 RVA: 0x0059CC90 File Offset: 0x0059AE90
		private void OPNFFJGNMAK(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("removed", this.AOFIKPCPDJN, 1231f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("Hip", this.AFHKGMCAPBI, 312f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k_root.html", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("RollerBladeCrossoverLeft", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(0).normalizedTime + this.m_RunCycleLegOffset, 332f) < 1362f) ? 0 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("gi_letgoshe", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 253f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1975f;
		}

		// Token: 0x0600C8F5 RID: 51445 RVA: 0x0059CDBC File Offset: 0x0059AFBC
		private void JMLMIGGODCC()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(1610f, this.AFHKGMCAPBI * num * Time.deltaTime, 263f);
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x0059CE04 File Offset: 0x0059B004
		private void EINAMCHPPCP()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 613f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = true;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = false;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C8F7 RID: 51447 RVA: 0x0059CE84 File Offset: 0x0059B084
		private void IBPGMFNDPHH()
		{
			this.KOFLCDBIKPF = base.GetComponent<Animator>();
			this.JMKPNAOICPE = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.FEOIIDEPMHM = this.FAEMFNCJNKD.height;
			this.JFEGEEAOBGC = this.FAEMFNCJNKD.center;
			this.JMKPNAOICPE.constraints = (RigidbodyConstraints)(-116);
			this.MNPJDAPIFGB = this.m_GroundCheckDistance;
		}

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x0059CEF0 File Offset: 0x0059B0F0
		private void AAPAPILBJOE(Vector3 ANPGPHIAMDM)
		{
			this.KOFLCDBIKPF.SetFloat("Keeper Strafe Dive Close Right", this.AOFIKPCPDJN, 1215f, Time.deltaTime);
			this.KOFLCDBIKPF.SetFloat("wpn_hook2", this.AFHKGMCAPBI, 640f, Time.deltaTime);
			this.KOFLCDBIKPF.SetBool("<b>ObscuredInt:</b> ", this.NOGFABGPJNB);
			this.KOFLCDBIKPF.SetBool("", this.OJMEFBNHGIM);
			if (!this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("SUNSHINE_FILTER_PCF_4x4", this.JMKPNAOICPE.velocity.y);
			}
			float value = (float)((Mathf.Repeat(this.KOFLCDBIKPF.GetCurrentAnimatorStateInfo(1).normalizedTime + this.m_RunCycleLegOffset, 19f) < 1830f) ? 1 : -1) * this.AOFIKPCPDJN;
			if (this.OJMEFBNHGIM)
			{
				this.KOFLCDBIKPF.SetFloat("wpn_hookf", value);
			}
			if (this.OJMEFBNHGIM && ANPGPHIAMDM.magnitude > 747f)
			{
				this.KOFLCDBIKPF.speed = this.m_AnimSpeedMultiplier;
				return;
			}
			this.KOFLCDBIKPF.speed = 1032f;
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x0059D01C File Offset: 0x0059B21C
		private void KMAGBHFCILL()
		{
			float num = Mathf.Lerp(this.m_StationaryTurnSpeed, this.m_MovingTurnSpeed, this.AOFIKPCPDJN);
			base.transform.Rotate(0f, this.AFHKGMCAPBI * num * Time.deltaTime, 0f);
		}

		// Token: 0x0600C8FA RID: 51450 RVA: 0x0059D064 File Offset: 0x0059B264
		private void JGLOKPMEKOJ()
		{
			if (!this.NOGFABGPJNB)
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 1676f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1888f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 116f, maxDistance, -1, QueryTriggerInteraction.UseGlobal))
				{
					this.NOGFABGPJNB = false;
				}
			}
		}

		// Token: 0x0600C8FB RID: 51451 RVA: 0x0059D0F0 File Offset: 0x0059B2F0
		public void GHOHCNIHCIL()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1923f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8FC RID: 51452 RVA: 0x0059D158 File Offset: 0x0059B358
		public void OIDMFKFKGMJ()
		{
			if (this.OJMEFBNHGIM && Time.deltaTime > 1844f)
			{
				Vector3 velocity = this.KOFLCDBIKPF.deltaPosition * this.m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = this.JMKPNAOICPE.velocity.y;
				this.JMKPNAOICPE.velocity = velocity;
			}
		}

		// Token: 0x0600C8FD RID: 51453 RVA: 0x0059D1C0 File Offset: 0x0059B3C0
		public void BCBPAJDGBJD(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 837f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.EKGLJDLBHJM();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.DBKMAIBBNBA();
			if (this.OJMEFBNHGIM)
			{
				this.ONINLKBKNNK(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.KIDBPLHJPJJ();
			}
			this.HMJCNIEGDKF(MGCOIPEBMIF);
			this.JONNDOLKCAL();
			this.NKODNPMPFNJ(ANPGPHIAMDM);
		}

		// Token: 0x0600C8FE RID: 51454 RVA: 0x0059D25C File Offset: 0x0059B45C
		private void JJKLDEBEIFN(bool MGCOIPEBMIF)
		{
			if (this.OJMEFBNHGIM && MGCOIPEBMIF)
			{
				if (this.NOGFABGPJNB)
				{
					return;
				}
				this.FAEMFNCJNKD.height = this.FAEMFNCJNKD.height / 1011f;
				this.FAEMFNCJNKD.center = this.FAEMFNCJNKD.center / 927f;
				this.NOGFABGPJNB = false;
				return;
			}
			else
			{
				Ray ray = new Ray(this.JMKPNAOICPE.position + Vector3.up * this.FAEMFNCJNKD.radius * 2f, Vector3.up);
				float maxDistance = this.FEOIIDEPMHM - this.FAEMFNCJNKD.radius * 1944f;
				if (Physics.SphereCast(ray, this.FAEMFNCJNKD.radius * 46f, maxDistance, -1, QueryTriggerInteraction.Ignore))
				{
					this.NOGFABGPJNB = false;
					return;
				}
				this.FAEMFNCJNKD.height = this.FEOIIDEPMHM;
				this.FAEMFNCJNKD.center = this.JFEGEEAOBGC;
				this.NOGFABGPJNB = true;
				return;
			}
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x0059D360 File Offset: 0x0059B560
		private void APBLHDPMIHF()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position + Vector3.up * 1526f, Vector3.down, out raycastHit, this.m_GroundCheckDistance))
			{
				this.FNIGOHGLGEI = raycastHit.normal;
				this.OJMEFBNHGIM = false;
				this.KOFLCDBIKPF.applyRootMotion = true;
				return;
			}
			this.OJMEFBNHGIM = true;
			this.FNIGOHGLGEI = Vector3.up;
			this.KOFLCDBIKPF.applyRootMotion = false;
		}

		// Token: 0x0600C900 RID: 51456 RVA: 0x0059D3E0 File Offset: 0x0059B5E0
		public void HMMKAGPJEAC(Vector3 ANPGPHIAMDM, bool MGCOIPEBMIF, bool IELMDLPINAH)
		{
			if (ANPGPHIAMDM.magnitude > 1887f)
			{
				ANPGPHIAMDM.Normalize();
			}
			ANPGPHIAMDM = base.transform.InverseTransformDirection(ANPGPHIAMDM);
			this.BNMIKNDCBHA();
			ANPGPHIAMDM = Vector3.ProjectOnPlane(ANPGPHIAMDM, this.FNIGOHGLGEI);
			this.AFHKGMCAPBI = Mathf.Atan2(ANPGPHIAMDM.x, ANPGPHIAMDM.z);
			this.AOFIKPCPDJN = ANPGPHIAMDM.z;
			this.IJOKGFHGBIH();
			if (this.OJMEFBNHGIM)
			{
				this.CFDICCPCLAA(MGCOIPEBMIF, IELMDLPINAH);
			}
			else
			{
				this.HLPJMCJHBMN();
			}
			this.JJKLDEBEIFN(MGCOIPEBMIF);
			this.LIEBMOMGHHC();
			this.IPKFIJONIMI(ANPGPHIAMDM);
		}

		// Token: 0x04001A8A RID: 6794
		[SerializeField]
		private float m_MovingTurnSpeed = 360f;

		// Token: 0x04001A8B RID: 6795
		[SerializeField]
		private float m_StationaryTurnSpeed = 180f;

		// Token: 0x04001A8C RID: 6796
		[SerializeField]
		private float m_JumpPower = 12f;

		// Token: 0x04001A8D RID: 6797
		[Range(1f, 4f)]
		[SerializeField]
		private float m_GravityMultiplier = 2f;

		// Token: 0x04001A8E RID: 6798
		[SerializeField]
		private float m_RunCycleLegOffset = 0.2f;

		// Token: 0x04001A8F RID: 6799
		[SerializeField]
		private float m_MoveSpeedMultiplier = 1f;

		// Token: 0x04001A90 RID: 6800
		[SerializeField]
		private float m_AnimSpeedMultiplier = 1f;

		// Token: 0x04001A91 RID: 6801
		[SerializeField]
		private float m_GroundCheckDistance = 0.1f;

		// Token: 0x04001A92 RID: 6802
		private Rigidbody JMKPNAOICPE;

		// Token: 0x04001A93 RID: 6803
		private Animator KOFLCDBIKPF;

		// Token: 0x04001A94 RID: 6804
		private bool OJMEFBNHGIM;

		// Token: 0x04001A95 RID: 6805
		private float MNPJDAPIFGB;

		// Token: 0x04001A96 RID: 6806
		private const float AMIKAJPKCBM = 0.5f;

		// Token: 0x04001A97 RID: 6807
		private float AFHKGMCAPBI;

		// Token: 0x04001A98 RID: 6808
		private float AOFIKPCPDJN;

		// Token: 0x04001A99 RID: 6809
		private Vector3 FNIGOHGLGEI;

		// Token: 0x04001A9A RID: 6810
		private float FEOIIDEPMHM;

		// Token: 0x04001A9B RID: 6811
		private Vector3 JFEGEEAOBGC;

		// Token: 0x04001A9C RID: 6812
		private CapsuleCollider FAEMFNCJNKD;

		// Token: 0x04001A9D RID: 6813
		private bool NOGFABGPJNB;
	}
}
