using System;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020003A3 RID: 931
	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(AudioSource))]
	public class FirstPersonController : MonoBehaviour
	{
		// Token: 0x0600C929 RID: 51497 RVA: 0x0059E6D4 File Offset: 0x0059C8D4
		private void EDGFFIEPGPD()
		{
			float num;
			this.CBFEMOCBADK(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1198f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.IMFEMMDCKHD();
					this.EHLNFFBJFEL = true;
					this.NEGCOGOMKOI = false;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.BPNFMLOHHOP(num);
			this.BHAJAKDBLAP(num);
		}

		// Token: 0x0600C92A RID: 51498 RVA: 0x0059E840 File Offset: 0x0059CA40
		private void NFCKDBNGBKP(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 1011f && (this.MDFEKJFKBKE.x != 1719f || this.MDFEKJFKBKE.y != 1738f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 66f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.LDEMOEKFODC();
		}

		// Token: 0x0600C92B RID: 51499 RVA: 0x0059E8F4 File Offset: 0x0059CAF4
		private void MNMPOCMFPAM(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 677f && (this.MDFEKJFKBKE.x != 980f || this.MDFEKJFKBKE.y != 218f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 112f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.AIIIJGFFHJF();
		}

		// Token: 0x0600C92C RID: 51500 RVA: 0x0059E9A8 File Offset: 0x0059CBA8
		private void AIIIJGFFHJF()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(0, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[0];
			this.m_FootstepSounds[0] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C92D RID: 51501 RVA: 0x0059EA20 File Offset: 0x0059CC20
		private void HFOHPLNOFKC()
		{
			float num;
			this.DEECHFHNOGI(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1782f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.MDKICEMFLKO();
					this.EHLNFFBJFEL = false;
					this.NEGCOGOMKOI = false;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.JFGDCFJBNMO(num);
			this.HLLNAECJPHE(num);
		}

		// Token: 0x0600C92E RID: 51502 RVA: 0x0059EB8C File Offset: 0x0059CD8C
		private void AIILFFCEKKM()
		{
			this.BEPHCOJFIBH();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("_RcpMaxCoC");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.FOMPFMIEGBJ());
				this.NAFGGOPPJKB();
				this.BLDJHOPAFAG.y = 1210f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1227f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C92F RID: 51503 RVA: 0x0059EC3C File Offset: 0x0059CE3C
		private void GDIMBBBPIHI()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.MIPCGIJHNEL(this.MPCEHPBGHII);
			this.m_HeadBob.MDNHIOEIBKO(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 743f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 1999f;
			this.NEGCOGOMKOI = true;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.HKNHBOEFHGG(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C930 RID: 51504 RVA: 0x0059ECEA File Offset: 0x0059CEEA
		private void NAFGGOPPJKB()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 1112f;
		}

		// Token: 0x0600C931 RID: 51505 RVA: 0x0059ED1C File Offset: 0x0059CF1C
		private void JMNOJDHPJAH(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 1675f && (this.MDFEKJFKBKE.x != 1411f || this.MDFEKJFKBKE.y != 1574f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1836f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.LDEMOEKFODC();
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x0059EDD0 File Offset: 0x0059CFD0
		private void MIFLHGMPLJD()
		{
			this.ONOGJDNOCID();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("Calf");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.HHOGGHKFEEH());
				this.JDCALGBECKB();
				this.BLDJHOPAFAG.y = 704f;
				this.NEGCOGOMKOI = false;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1805f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C933 RID: 51507 RVA: 0x0059EE80 File Offset: 0x0059D080
		private void NAPILBBKJMJ()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(1, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[1];
			this.m_FootstepSounds[0] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C934 RID: 51508 RVA: 0x0059EEF6 File Offset: 0x0059D0F6
		private void IAFPPNHDIEP()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 811f;
		}

		// Token: 0x0600C935 RID: 51509 RVA: 0x0059EF28 File Offset: 0x0059D128
		private void LCLMMHJGFAL(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 1714f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.FHLOCJHCAKJ(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1705f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.CJIKHNEOMFD();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.NEDLIEPEJEI();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C936 RID: 51510 RVA: 0x0059F02C File Offset: 0x0059D22C
		private void CBFEMOCBADK(out float AIFIJJADKHN)
		{
			float x = CELBHNONENJ.LBBLPMHONLE("LINEAR");
			float y = CELBHNONENJ.LBBLPMHONLE("<color='#ff0000'>Вы сломали удочку</color>");
			bool isWalking = this.m_IsWalking;
			this.m_IsWalking = Input.GetKey((KeyCode)73);
			AIFIJJADKHN = (this.m_IsWalking ? this.m_WalkSpeed : this.m_RunSpeed);
			this.MDFEKJFKBKE = new Vector2(x, y);
			if (this.MDFEKJFKBKE.sqrMagnitude > 1636f)
			{
				this.MDFEKJFKBKE.Normalize();
			}
			if (this.m_IsWalking != isWalking && this.m_UseFovKick && this.LJKCHIKFFAB.velocity.sqrMagnitude > 1922f)
			{
				base.StopAllCoroutines();
				base.StartCoroutine((!this.m_IsWalking) ? this.m_FovKick.GPKNIPGIPFK() : this.m_FovKick.PCLJNODCOPC());
			}
		}

		// Token: 0x0600C937 RID: 51511 RVA: 0x0059F103 File Offset: 0x0059D303
		private void AHHHIBJAODN()
		{
			this.m_MouseLook.DLDEJFLMENN(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C938 RID: 51512 RVA: 0x0059F124 File Offset: 0x0059D324
		private void CFAJEGHKJDB(ControllerColliderHit CGAFKGPDBAD)
		{
			Rigidbody attachedRigidbody = CGAFKGPDBAD.collider.attachedRigidbody;
			if (this.AEHBOAOCDJL == (CollisionFlags)8)
			{
				return;
			}
			if (attachedRigidbody == null || attachedRigidbody.isKinematic)
			{
				return;
			}
			attachedRigidbody.AddForceAtPosition(this.LJKCHIKFFAB.velocity * 1745f, CGAFKGPDBAD.point, ForceMode.Force);
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x0059F17C File Offset: 0x0059D37C
		private void JFGDCFJBNMO(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 1813f && (this.MDFEKJFKBKE.x != 1299f || this.MDFEKJFKBKE.y != 1230f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 486f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.JCKFMKEGOGI();
		}

		// Token: 0x0600C93A RID: 51514 RVA: 0x0059F22D File Offset: 0x0059D42D
		private void KMCJMBPJCHD()
		{
			this.m_MouseLook.FBAAGDOLLEK(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C93B RID: 51515 RVA: 0x0059F24C File Offset: 0x0059D44C
		private void LOIPNCCDMLM()
		{
			float num;
			this.ANAKHNPBFDD(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1179f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.NPFIKIDPJMA();
					this.EHLNFFBJFEL = true;
					this.NEGCOGOMKOI = true;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.BPNFMLOHHOP(num);
			this.KBHKJMPMCFO(num);
		}

		// Token: 0x0600C93C RID: 51516 RVA: 0x0059F3B8 File Offset: 0x0059D5B8
		private void GPCLLAAJKHA()
		{
			float num;
			this.ANAKHNPBFDD(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1864f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.AGFPLBJKEJP();
					this.EHLNFFBJFEL = false;
					this.NEGCOGOMKOI = false;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.LBLCLLMHJOJ(num);
			this.BMMHAHJLPGB(num);
		}

		// Token: 0x0600C93D RID: 51517 RVA: 0x0059F524 File Offset: 0x0059D724
		private void OnControllerColliderHit(ControllerColliderHit CGAFKGPDBAD)
		{
			Rigidbody attachedRigidbody = CGAFKGPDBAD.collider.attachedRigidbody;
			if (this.AEHBOAOCDJL == CollisionFlags.Below)
			{
				return;
			}
			if (attachedRigidbody == null || attachedRigidbody.isKinematic)
			{
				return;
			}
			attachedRigidbody.AddForceAtPosition(this.LJKCHIKFFAB.velocity * 0.1f, CGAFKGPDBAD.point, ForceMode.Impulse);
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x0059F57C File Offset: 0x0059D77C
		private void JFNOIJPDNDP()
		{
			float num;
			this.GCIJDBMMCEN(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 310f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.AGFPLBJKEJP();
					this.EHLNFFBJFEL = false;
					this.NEGCOGOMKOI = true;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.GGAIGNDCNJE(num);
			this.FPMOCDEEHMF(num);
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void MDCAOGPJOAP()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void AGFPLBJKEJP()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x0059F704 File Offset: 0x0059D904
		private void BPNFMLOHHOP(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 363f && (this.MDFEKJFKBKE.x != 992f || this.MDFEKJFKBKE.y != 1852f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1303f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.OICEMBNNLIB();
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x0059F7B8 File Offset: 0x0059D9B8
		private void LDEMOEKFODC()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(1, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[0];
			this.m_FootstepSounds[0] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x0059F82E File Offset: 0x0059DA2E
		private void JDCOMLHKABF()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 294f;
		}

		// Token: 0x0600C944 RID: 51524 RVA: 0x0059F860 File Offset: 0x0059DA60
		private void INPDCPOIAAG(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 92f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.FHLOCJHCAKJ(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 288f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.FBPMDMLOCGD();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.FEHLBEIOPJJ();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C945 RID: 51525 RVA: 0x0059F964 File Offset: 0x0059DB64
		private void JPDAEDLKAPM(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 0f && (this.MDFEKJFKBKE.x != 0f || this.MDFEKJFKBKE.y != 0f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.LDEMOEKFODC();
		}

		// Token: 0x0600C946 RID: 51526 RVA: 0x0059FA18 File Offset: 0x0059DC18
		private void FPMOCDEEHMF(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 0f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.CMCKNLNPEFA(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.MFHOGHFEPAN();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.MFHOGHFEPAN();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C947 RID: 51527 RVA: 0x0059FB1C File Offset: 0x0059DD1C
		private void CMBJFKCLIEG(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 1072f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.FKNMNOKJCEN(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1009f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.AAHPOBCGKKD();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.NEDLIEPEJEI();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C948 RID: 51528 RVA: 0x0059FC20 File Offset: 0x0059DE20
		private void JPHLMNIMDHH()
		{
			this.AHHHIBJAODN();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("UnityEngine.Vector2");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.ACOCAHDKDGJ());
				this.NAFGGOPPJKB();
				this.BLDJHOPAFAG.y = 1524f;
				this.NEGCOGOMKOI = false;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 402f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C949 RID: 51529 RVA: 0x0059FCD0 File Offset: 0x0059DED0
		private void FEBIICIMLHA()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.NEOEMKKKOGM(this.MPCEHPBGHII);
			this.m_HeadBob.MNPJDDMFKNK(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 796f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 1622f;
			this.NEGCOGOMKOI = true;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.BBCINJAGHEP(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C94A RID: 51530 RVA: 0x0059FD80 File Offset: 0x0059DF80
		private void MFNADCNFBMD(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 265f && (this.MDFEKJFKBKE.x != 1662f || this.MDFEKJFKBKE.y != 1165f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 446f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.OICEMBNNLIB();
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x0059FE31 File Offset: 0x0059E031
		private void FNFLKPCHPEJ()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 1502f;
		}

		// Token: 0x0600C94C RID: 51532 RVA: 0x0059FE61 File Offset: 0x0059E061
		private void BCFBPGPMHAH()
		{
			this.m_MouseLook.BOOBKMJJDPP(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C94D RID: 51533 RVA: 0x0059FE80 File Offset: 0x0059E080
		private void BMMHAHJLPGB(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 189f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.HMHGHNBEGNC(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1102f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.GLCJECIKMFB();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.HHCOPPICJDB();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C94E RID: 51534 RVA: 0x0059FF84 File Offset: 0x0059E184
		private void MAGJOJDOGKH()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.NEOEMKKKOGM(this.MPCEHPBGHII);
			this.m_HeadBob.BPOMBPLNIBD(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 1796f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 465f;
			this.NEGCOGOMKOI = true;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.HDOMBPAKEPC(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C94F RID: 51535 RVA: 0x005A0032 File Offset: 0x0059E232
		private void MCDKKAPGBLL()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 0.5f;
		}

		// Token: 0x0600C950 RID: 51536 RVA: 0x005A0062 File Offset: 0x0059E262
		private void MLOGAALPCCM()
		{
			this.m_MouseLook.NFDNGJJADCM(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C951 RID: 51537 RVA: 0x005A0080 File Offset: 0x0059E280
		private void LBLCLLMHJOJ(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 475f && (this.MDFEKJFKBKE.x != 1444f || this.MDFEKJFKBKE.y != 1111f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1413f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.OICEMBNNLIB();
		}

		// Token: 0x0600C952 RID: 51538 RVA: 0x005A0134 File Offset: 0x0059E334
		private void HHGGCBLOJGB()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.DMCJONHPAHC(this.MPCEHPBGHII);
			this.m_HeadBob.LLGMFFDPIHI(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 1419f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 1470f;
			this.NEGCOGOMKOI = true;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.NHHKCKOKKOP(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C953 RID: 51539 RVA: 0x005A01E4 File Offset: 0x0059E3E4
		private void KLFPOILLKDF()
		{
			this.AHHHIBJAODN();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("_Bloom_DirtIntensity");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.FEPGJMLCHAN());
				this.ECGMAJLOBEJ();
				this.BLDJHOPAFAG.y = 1695f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1835f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C954 RID: 51540 RVA: 0x005A0294 File Offset: 0x0059E494
		private void BBFCMCAFOMH()
		{
			this.KMCJMBPJCHD();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("Android");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.FOMPFMIEGBJ());
				this.JDCOMLHKABF();
				this.BLDJHOPAFAG.y = 1612f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 53f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C955 RID: 51541 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void MDKICEMFLKO()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C956 RID: 51542 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void EGMKIOGALIL()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C957 RID: 51543 RVA: 0x005A0344 File Offset: 0x0059E544
		private void MGKEEPMDANL()
		{
			float num;
			this.ANAKHNPBFDD(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1983f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.EGMKIOGALIL();
					this.EHLNFFBJFEL = true;
					this.NEGCOGOMKOI = true;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.GAJICDHCPHN(num);
			this.FMMCGIDLDJG(num);
		}

		// Token: 0x0600C958 RID: 51544 RVA: 0x005A04B0 File Offset: 0x0059E6B0
		private void DBNIIOPOGAK()
		{
			float num;
			this.CBFEMOCBADK(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1019f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.AGFPLBJKEJP();
					this.EHLNFFBJFEL = true;
					this.NEGCOGOMKOI = true;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.GGAIGNDCNJE(num);
			this.KAFCIDACEHN(num);
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x005A061C File Offset: 0x0059E81C
		private void GGAIGNDCNJE(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 440f && (this.MDFEKJFKBKE.x != 463f || this.MDFEKJFKBKE.y != 1415f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1350f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.KKGDIDLHMLN();
		}

		// Token: 0x0600C95A RID: 51546 RVA: 0x005A06D0 File Offset: 0x0059E8D0
		private void JFGGBEGNAFP()
		{
			this.BCFBPGPMHAH();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("X");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.JICCNBDCINH());
				this.CKKIPBIMDIK();
				this.BLDJHOPAFAG.y = 1039f;
				this.NEGCOGOMKOI = false;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1133f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C95C RID: 51548 RVA: 0x005A07B4 File Offset: 0x0059E9B4
		private void MPLCAGFGEBO()
		{
			this.AHHHIBJAODN();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL(" l ");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.DDJDDGJJFCG());
				this.FNFLKPCHPEJ();
				this.BLDJHOPAFAG.y = 737f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1515f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C95D RID: 51549 RVA: 0x005A0861 File Offset: 0x0059EA61
		private void ONOGJDNOCID()
		{
			this.m_MouseLook.KDEJHPNAAGJ(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C95E RID: 51550 RVA: 0x005A0880 File Offset: 0x0059EA80
		private void ILKILNGAEKK()
		{
			float num;
			this.BKEKBBCJIAB(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 789f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.EGMKIOGALIL();
					this.EHLNFFBJFEL = true;
					this.NEGCOGOMKOI = true;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.MNMPOCMFPAM(num);
			this.BMMHAHJLPGB(num);
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x005A09E9 File Offset: 0x0059EBE9
		private void JDCALGBECKB()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 1289f;
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x005A0A19 File Offset: 0x0059EC19
		private void MMFOJOOPLFK()
		{
			this.m_MouseLook.CMDMHNNKPME(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C961 RID: 51553 RVA: 0x005A0A37 File Offset: 0x0059EC37
		private void CKKIPBIMDIK()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 1435f;
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x005A0A68 File Offset: 0x0059EC68
		private void AGOHEEDECKH(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 1500f && (this.MDFEKJFKBKE.x != 1996f || this.MDFEKJFKBKE.y != 347f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1944f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.KKGDIDLHMLN();
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void NPFIKIDPJMA()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C964 RID: 51556 RVA: 0x005A0B19 File Offset: 0x0059ED19
		private void MIALAHANPPM()
		{
			this.m_MouseLook.JNGJHKKECCE(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x005A0B37 File Offset: 0x0059ED37
		private void LHDEJHBPJAC()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 1039f;
		}

		// Token: 0x0600C966 RID: 51558 RVA: 0x005A0B68 File Offset: 0x0059ED68
		private void INMBEEPOFFB(ControllerColliderHit CGAFKGPDBAD)
		{
			Rigidbody attachedRigidbody = CGAFKGPDBAD.collider.attachedRigidbody;
			if (this.AEHBOAOCDJL == (CollisionFlags)7)
			{
				return;
			}
			if (attachedRigidbody == null || attachedRigidbody.isKinematic)
			{
				return;
			}
			attachedRigidbody.AddForceAtPosition(this.LJKCHIKFFAB.velocity * 1993f, CGAFKGPDBAD.point, ForceMode.Impulse);
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x005A0BC0 File Offset: 0x0059EDC0
		private void CHBCOJCFIKN(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 540f && (this.MDFEKJFKBKE.x != 843f || this.MDFEKJFKBKE.y != 1373f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1559f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.NAPILBBKJMJ();
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x005A0C74 File Offset: 0x0059EE74
		private void JFNODGDKBOG(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 173f && (this.MDFEKJFKBKE.x != 1724f || this.MDFEKJFKBKE.y != 703f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 334f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.JCKFMKEGOGI();
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x005A0D25 File Offset: 0x0059EF25
		private void LHLFDIKOFCJ()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 814f;
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x005A0D55 File Offset: 0x0059EF55
		private void JJCMIGNGDGF()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 481f;
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x005A0D88 File Offset: 0x0059EF88
		private void LJCCACFAAEN(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 479f && (this.MDFEKJFKBKE.x != 910f || this.MDFEKJFKBKE.y != 80f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1138f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.ANPGAGNCOIF();
		}

		// Token: 0x0600C96C RID: 51564 RVA: 0x005A0E3C File Offset: 0x0059F03C
		private void GAJICDHCPHN(float AIFIJJADKHN)
		{
			if (this.LJKCHIKFFAB.velocity.sqrMagnitude > 1929f && (this.MDFEKJFKBKE.x != 1818f || this.MDFEKJFKBKE.y != 261f))
			{
				this.GBOEDMJNBBO += (this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 850f : this.m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (this.GBOEDMJNBBO <= this.GDOOPFALHEA)
			{
				return;
			}
			this.GDOOPFALHEA = this.GBOEDMJNBBO + this.m_StepInterval;
			this.IDMNNKJADCB();
		}

		// Token: 0x0600C96D RID: 51565 RVA: 0x005A0EF0 File Offset: 0x0059F0F0
		private void ANAKHNPBFDD(out float AIFIJJADKHN)
		{
			float x = CELBHNONENJ.LBBLPMHONLE("Horizontal");
			float y = CELBHNONENJ.LBBLPMHONLE("Vertical");
			bool isWalking = this.m_IsWalking;
			this.m_IsWalking = !Input.GetKey(KeyCode.LeftShift);
			AIFIJJADKHN = (this.m_IsWalking ? this.m_WalkSpeed : this.m_RunSpeed);
			this.MDFEKJFKBKE = new Vector2(x, y);
			if (this.MDFEKJFKBKE.sqrMagnitude > 1f)
			{
				this.MDFEKJFKBKE.Normalize();
			}
			if (this.m_IsWalking != isWalking && this.m_UseFovKick && this.LJKCHIKFFAB.velocity.sqrMagnitude > 0f)
			{
				base.StopAllCoroutines();
				base.StartCoroutine((!this.m_IsWalking) ? this.m_FovKick.JOKACCPPCNI() : this.m_FovKick.JFOIDJDDGIN());
			}
		}

		// Token: 0x0600C96E RID: 51566 RVA: 0x005A0FC7 File Offset: 0x0059F1C7
		private void ODNKBMNPNEC()
		{
			this.m_MouseLook.EBDDHJAGIGD(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C96F RID: 51567 RVA: 0x005A0FE5 File Offset: 0x0059F1E5
		private void EDGDEMBFLHI()
		{
			this.m_MouseLook.DGMONPPHMEN(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C970 RID: 51568 RVA: 0x005A1004 File Offset: 0x0059F204
		private void OICEMBNNLIB()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(1, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[0];
			this.m_FootstepSounds[1] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C971 RID: 51569 RVA: 0x005A107A File Offset: 0x0059F27A
		private void BEPHCOJFIBH()
		{
			this.m_MouseLook.NCGIALPJKFI(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C972 RID: 51570 RVA: 0x005A1098 File Offset: 0x0059F298
		private void KGICJDGIIJK()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.MIPCGIJHNEL(this.MPCEHPBGHII);
			this.m_HeadBob.MDNHIOEIBKO(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 1923f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 1497f;
			this.NEGCOGOMKOI = false;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.JONEKLKPPJA(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C973 RID: 51571 RVA: 0x005A1148 File Offset: 0x0059F348
		private void KBHKJMPMCFO(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 579f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.KMPEPHLMLAH(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1422f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.NACADKBKKDD();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.NNMNFBACNEN();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C974 RID: 51572 RVA: 0x005A124C File Offset: 0x0059F44C
		private void IDMNNKJADCB()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(1, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[1];
			this.m_FootstepSounds[0] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C975 RID: 51573 RVA: 0x005A12C4 File Offset: 0x0059F4C4
		private void JCKFMKEGOGI()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(1, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[0];
			this.m_FootstepSounds[0] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C976 RID: 51574 RVA: 0x005A133C File Offset: 0x0059F53C
		private void DEECHFHNOGI(out float AIFIJJADKHN)
		{
			float x = CELBHNONENJ.LBBLPMHONLE("enable");
			float y = CELBHNONENJ.LBBLPMHONLE("Heart Attack");
			bool isWalking = this.m_IsWalking;
			this.m_IsWalking = Input.GetKey((KeyCode)(-190));
			AIFIJJADKHN = (this.m_IsWalking ? this.m_WalkSpeed : this.m_RunSpeed);
			this.MDFEKJFKBKE = new Vector2(x, y);
			if (this.MDFEKJFKBKE.sqrMagnitude > 1713f)
			{
				this.MDFEKJFKBKE.Normalize();
			}
			if (this.m_IsWalking != isWalking && this.m_UseFovKick && this.LJKCHIKFFAB.velocity.sqrMagnitude > 1155f)
			{
				base.StopAllCoroutines();
				base.StartCoroutine((!this.m_IsWalking) ? this.m_FovKick.AJDHANIHKGD() : this.m_FovKick.CKCCJFJIIPF());
			}
		}

		// Token: 0x0600C977 RID: 51575 RVA: 0x005A1414 File Offset: 0x0059F614
		private void FKHAKIKPFFO()
		{
			this.MMFOJOOPLFK();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("_ALPHABLEND_ON");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.FEPGJMLCHAN());
				this.JDCOMLHKABF();
				this.BLDJHOPAFAG.y = 1045f;
				this.NEGCOGOMKOI = false;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 6f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C978 RID: 51576 RVA: 0x005A14C4 File Offset: 0x0059F6C4
		private void FixedUpdate()
		{
			float num;
			this.ANAKHNPBFDD(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 2f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.NPFIKIDPJMA();
					this.EHLNFFBJFEL = false;
					this.NEGCOGOMKOI = true;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.JPDAEDLKAPM(num);
			this.FPMOCDEEHMF(num);
		}

		// Token: 0x0600C979 RID: 51577 RVA: 0x005A1630 File Offset: 0x0059F830
		private void INFDDDBIPAB()
		{
			float num;
			this.BKEKBBCJIAB(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 699f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.FOAFMBALDJN();
					this.EHLNFFBJFEL = false;
					this.NEGCOGOMKOI = false;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.JMNOJDHPJAH(num);
			this.HLLNAECJPHE(num);
		}

		// Token: 0x0600C97A RID: 51578 RVA: 0x005A179C File Offset: 0x0059F99C
		private void HBHMFMLCDJO(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 31f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.PEJBDDGKGMO(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 966f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.PKOKGKOHLAH();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.MCFCOGJOBNK();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C97B RID: 51579 RVA: 0x005A18A0 File Offset: 0x0059FAA0
		private void LBOONMDONCF()
		{
			this.ODNKBMNPNEC();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("CheerKnees");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.JLAJDPEPHHN());
				this.EKJLLLNHANL();
				this.BLDJHOPAFAG.y = 1762f;
				this.NEGCOGOMKOI = false;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1575f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C97C RID: 51580 RVA: 0x005A1950 File Offset: 0x0059FB50
		private void DEGCCLNOEKJ()
		{
			this.MMFOJOOPLFK();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("_MainTex");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.OHJFJDALFAG());
				this.EKJLLLNHANL();
				this.BLDJHOPAFAG.y = 320f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1476f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C97D RID: 51581 RVA: 0x005A1A00 File Offset: 0x0059FC00
		private void EDGALMCHPPH()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.MCOFACCIGPN(this.MPCEHPBGHII);
			this.m_HeadBob.JAACHGMDGPI(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 126f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 438f;
			this.NEGCOGOMKOI = false;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.GEBDJPNLKAG(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C97E RID: 51582 RVA: 0x005A1AB0 File Offset: 0x0059FCB0
		private void BKEKBBCJIAB(out float AIFIJJADKHN)
		{
			float x = CELBHNONENJ.LBBLPMHONLE("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
			float y = CELBHNONENJ.LBBLPMHONLE("exitmsg_2");
			bool isWalking = this.m_IsWalking;
			this.m_IsWalking = Input.GetKey((KeyCode)(-160));
			AIFIJJADKHN = (this.m_IsWalking ? this.m_WalkSpeed : this.m_RunSpeed);
			this.MDFEKJFKBKE = new Vector2(x, y);
			if (this.MDFEKJFKBKE.sqrMagnitude > 1767f)
			{
				this.MDFEKJFKBKE.Normalize();
			}
			if (this.m_IsWalking != isWalking && this.m_UseFovKick && this.LJKCHIKFFAB.velocity.sqrMagnitude > 846f)
			{
				base.StopAllCoroutines();
				base.StartCoroutine((!this.m_IsWalking) ? this.m_FovKick.JGBNNBLEJOA() : this.m_FovKick.IEIDACGOLIL());
			}
		}

		// Token: 0x0600C97F RID: 51583 RVA: 0x005A1B88 File Offset: 0x0059FD88
		private void AJFLNIDDMFK(ControllerColliderHit CGAFKGPDBAD)
		{
			Rigidbody attachedRigidbody = CGAFKGPDBAD.collider.attachedRigidbody;
			if (this.AEHBOAOCDJL == (CollisionFlags)6)
			{
				return;
			}
			if (attachedRigidbody == null || attachedRigidbody.isKinematic)
			{
				return;
			}
			attachedRigidbody.AddForceAtPosition(this.LJKCHIKFFAB.velocity * 212f, CGAFKGPDBAD.point, ForceMode.Impulse);
		}

		// Token: 0x0600C980 RID: 51584 RVA: 0x005A1BE0 File Offset: 0x0059FDE0
		private void PHMEBJBMHIN(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 1886f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.CMCKNLNPEFA(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 813f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.JGKNHPONEFA();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.ABKKODINNNB();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C981 RID: 51585 RVA: 0x005A1CE4 File Offset: 0x0059FEE4
		private void ECDGOPAINIG()
		{
			float num;
			this.GCIJDBMMCEN(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1140f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.ANDFGNCOJMH();
					this.EHLNFFBJFEL = false;
					this.NEGCOGOMKOI = false;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.CHBCOJCFIKN(num);
			this.FMMCGIDLDJG(num);
		}

		// Token: 0x0600C982 RID: 51586 RVA: 0x005A1E50 File Offset: 0x005A0050
		private void HLLNAECJPHE(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 1866f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.MKLOILLONGN(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1399f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.LIACKFEKDKC();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.MFHOGHFEPAN();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C983 RID: 51587 RVA: 0x005A1F54 File Offset: 0x005A0154
		private void IKHCCAANGOP()
		{
			this.MLOGAALPCCM();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("invn_rec14");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.MKNLNBEEACC());
				this.ECGMAJLOBEJ();
				this.BLDJHOPAFAG.y = 676f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1928f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C984 RID: 51588 RVA: 0x005A2001 File Offset: 0x005A0201
		private void HMLBPBLGJKN()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 434f;
		}

		// Token: 0x0600C985 RID: 51589 RVA: 0x005A2034 File Offset: 0x005A0234
		private void Update()
		{
			this.MMFOJOOPLFK();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("Jump");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.FNOPJLIAFKO());
				this.MCDKKAPGBLL();
				this.BLDJHOPAFAG.y = 0f;
				this.NEGCOGOMKOI = false;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 0f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C986 RID: 51590 RVA: 0x005A20E4 File Offset: 0x005A02E4
		private void KMPEBHIPKJH()
		{
			this.MMFOJOOPLFK();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("FistPump2");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.GHFEELIGDGE());
				this.JDCOMLHKABF();
				this.BLDJHOPAFAG.y = 293f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1683f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C987 RID: 51591 RVA: 0x005A2194 File Offset: 0x005A0394
		private void LEHBKPPGHPC()
		{
			this.AHHHIBJAODN();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("RunBackLeft");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.FNOPJLIAFKO());
				this.LHLFDIKOFCJ();
				this.BLDJHOPAFAG.y = 485f;
				this.NEGCOGOMKOI = false;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 1369f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C988 RID: 51592 RVA: 0x005A2244 File Offset: 0x005A0444
		private void MLKBEDPOPOD(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 260f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.IMIIKHFCCIE(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 922f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.IAJDIAPFDPN();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.IHLOCDJDEKJ();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C989 RID: 51593 RVA: 0x005A2348 File Offset: 0x005A0548
		private void BHAJAKDBLAP(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 1408f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.JHGPBFKHIIJ(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 954f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.LMBLMIJPEBA();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.LIACKFEKDKC();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C98A RID: 51594 RVA: 0x005A244C File Offset: 0x005A064C
		private void EKJLLLNHANL()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 1415f;
		}

		// Token: 0x0600C98B RID: 51595 RVA: 0x005A247C File Offset: 0x005A067C
		private void FKMPEJPGAPC()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 108f;
		}

		// Token: 0x0600C98C RID: 51596 RVA: 0x005A24AC File Offset: 0x005A06AC
		private void PIHDNPAMDGD()
		{
			this.m_MouseLook.EHMKEILENNB(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void ANDFGNCOJMH()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C98E RID: 51598 RVA: 0x005A24CC File Offset: 0x005A06CC
		private void KKGDIDLHMLN()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(0, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[1];
			this.m_FootstepSounds[0] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C98F RID: 51599 RVA: 0x005A2544 File Offset: 0x005A0744
		private void KAFCIDACEHN(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 761f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.KBCHCKLLFCC(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 758f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.PKOKGKOHLAH();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.AAHPOBCGKKD();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C990 RID: 51600 RVA: 0x005A2648 File Offset: 0x005A0848
		private void KIEIPFFEDHC()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.PMGFDBHCFLK(this.MPCEHPBGHII);
			this.m_HeadBob.NDPBPPGLILN(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 492f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 1341f;
			this.NEGCOGOMKOI = false;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.KKIGGCNACOG(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C991 RID: 51601 RVA: 0x005A26F6 File Offset: 0x005A08F6
		private void ECGMAJLOBEJ()
		{
			this.HOCFIIGOLED.clip = this.m_LandSound;
			this.HOCFIIGOLED.Play();
			this.GDOOPFALHEA = this.GBOEDMJNBBO + 1922f;
		}

		// Token: 0x0600C992 RID: 51602 RVA: 0x005A2728 File Offset: 0x005A0928
		private void Start()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.NBDIALKKHOE(this.MPCEHPBGHII);
			this.m_HeadBob.NBDIALKKHOE(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 0f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 2f;
			this.NEGCOGOMKOI = false;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.PINLMCCKKNA(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C993 RID: 51603 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void FOAFMBALDJN()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C994 RID: 51604 RVA: 0x005A27D8 File Offset: 0x005A09D8
		private void JJFHPGDPHGB()
		{
			this.BEPHCOJFIBH();
			if (!this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = CELBHNONENJ.LEPAIPLBDGL("No valid adaptive tonemapper type found!");
			}
			if (!this.LFMADIAIKDM && this.LJKCHIKFFAB.isGrounded)
			{
				base.StartCoroutine(this.m_JumpBob.ODCGEKBDEKG());
				this.EKJLLLNHANL();
				this.BLDJHOPAFAG.y = 30f;
				this.NEGCOGOMKOI = true;
			}
			if (!this.LJKCHIKFFAB.isGrounded && !this.NEGCOGOMKOI && this.LFMADIAIKDM)
			{
				this.BLDJHOPAFAG.y = 820f;
			}
			this.LFMADIAIKDM = this.LJKCHIKFFAB.isGrounded;
		}

		// Token: 0x0600C995 RID: 51605 RVA: 0x005A2888 File Offset: 0x005A0A88
		private void JPHBPEAMNHB()
		{
			this.LJKCHIKFFAB = base.GetComponent<CharacterController>();
			this.MPCEHPBGHII = Camera.main;
			this.MIOLLFJGDOH = this.MPCEHPBGHII.transform.localPosition;
			this.m_FovKick.PAHCPCICOBN(this.MPCEHPBGHII);
			this.m_HeadBob.ECHPNEIALGB(this.MPCEHPBGHII, this.m_StepInterval);
			this.GBOEDMJNBBO = 573f;
			this.GDOOPFALHEA = this.GBOEDMJNBBO / 1619f;
			this.NEGCOGOMKOI = false;
			this.HOCFIIGOLED = base.GetComponent<AudioSource>();
			this.m_MouseLook.IOPLEEHGNJK(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C996 RID: 51606 RVA: 0x005A2938 File Offset: 0x005A0B38
		private void ANPGAGNCOIF()
		{
			if (!this.LJKCHIKFFAB.isGrounded)
			{
				return;
			}
			int num = UnityEngine.Random.Range(1, this.m_FootstepSounds.Length);
			this.HOCFIIGOLED.clip = this.m_FootstepSounds[num];
			this.HOCFIIGOLED.PlayOneShot(this.HOCFIIGOLED.clip);
			this.m_FootstepSounds[num] = this.m_FootstepSounds[1];
			this.m_FootstepSounds[1] = this.HOCFIIGOLED.clip;
		}

		// Token: 0x0600C997 RID: 51607 RVA: 0x0059F6E5 File Offset: 0x0059D8E5
		private void IMFEMMDCKHD()
		{
			this.HOCFIIGOLED.clip = this.m_JumpSound;
			this.HOCFIIGOLED.Play();
		}

		// Token: 0x0600C998 RID: 51608 RVA: 0x0059F103 File Offset: 0x0059D303
		private void OKHADLCLKEG()
		{
			this.m_MouseLook.DLDEJFLMENN(base.transform, this.MPCEHPBGHII.transform);
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x005A29B0 File Offset: 0x005A0BB0
		private void FMMCGIDLDJG(float AIFIJJADKHN)
		{
			if (!this.m_UseHeadBob)
			{
				return;
			}
			Vector3 localPosition;
			if (this.LJKCHIKFFAB.velocity.magnitude > 100f && this.LJKCHIKFFAB.isGrounded)
			{
				this.MPCEHPBGHII.transform.localPosition = this.m_HeadBob.KBCHCKLLFCC(this.LJKCHIKFFAB.velocity.magnitude + AIFIJJADKHN * (this.m_IsWalking ? 1982f : this.m_RunstepLenghten));
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MPCEHPBGHII.transform.localPosition.y - this.m_JumpBob.PPOLOKFLGGN();
			}
			else
			{
				localPosition = this.MPCEHPBGHII.transform.localPosition;
				localPosition.y = this.MIOLLFJGDOH.y - this.m_JumpBob.CJIKHNEOMFD();
			}
			this.MPCEHPBGHII.transform.localPosition = localPosition;
		}

		// Token: 0x0600C99A RID: 51610 RVA: 0x005A2AB4 File Offset: 0x005A0CB4
		private void GCIJDBMMCEN(out float AIFIJJADKHN)
		{
			float x = CELBHNONENJ.LBBLPMHONLE("");
			float y = CELBHNONENJ.LBBLPMHONLE("id");
			bool isWalking = this.m_IsWalking;
			this.m_IsWalking = Input.GetKey((KeyCode)(-131));
			AIFIJJADKHN = (this.m_IsWalking ? this.m_WalkSpeed : this.m_RunSpeed);
			this.MDFEKJFKBKE = new Vector2(x, y);
			if (this.MDFEKJFKBKE.sqrMagnitude > 150f)
			{
				this.MDFEKJFKBKE.Normalize();
			}
			if (this.m_IsWalking != isWalking && this.m_UseFovKick && this.LJKCHIKFFAB.velocity.sqrMagnitude > 284f)
			{
				base.StopAllCoroutines();
				base.StartCoroutine((!this.m_IsWalking) ? this.m_FovKick.AJKCIMPLHAP() : this.m_FovKick.MPKBIICHDAA());
			}
		}

		// Token: 0x0600C99B RID: 51611 RVA: 0x005A2B8C File Offset: 0x005A0D8C
		private void KMHBOLLCJHO()
		{
			float num;
			this.ANAKHNPBFDD(out num);
			Vector3 vector = base.transform.forward * this.MDFEKJFKBKE.y + base.transform.right * this.MDFEKJFKBKE.x;
			RaycastHit raycastHit;
			Physics.SphereCast(base.transform.position, this.LJKCHIKFFAB.radius, Vector3.down, out raycastHit, this.LJKCHIKFFAB.height / 1742f);
			vector = Vector3.ProjectOnPlane(vector, raycastHit.normal).normalized;
			this.BLDJHOPAFAG.x = vector.x * num;
			this.BLDJHOPAFAG.z = vector.z * num;
			if (this.LJKCHIKFFAB.isGrounded)
			{
				this.BLDJHOPAFAG.y = -this.m_StickToGroundForce;
				if (this.EHLNFFBJFEL)
				{
					this.BLDJHOPAFAG.y = this.m_JumpSpeed;
					this.MDCAOGPJOAP();
					this.EHLNFFBJFEL = false;
					this.NEGCOGOMKOI = false;
				}
			}
			else
			{
				this.BLDJHOPAFAG += Physics.gravity * this.m_GravityMultiplier * Time.fixedDeltaTime;
			}
			this.AEHBOAOCDJL = this.LJKCHIKFFAB.Move(this.BLDJHOPAFAG * Time.fixedDeltaTime);
			this.BPNFMLOHHOP(num);
			this.FPMOCDEEHMF(num);
		}

		// Token: 0x04001AA3 RID: 6819
		[SerializeField]
		private bool m_IsWalking;

		// Token: 0x04001AA4 RID: 6820
		[SerializeField]
		private float m_WalkSpeed;

		// Token: 0x04001AA5 RID: 6821
		[SerializeField]
		private float m_RunSpeed;

		// Token: 0x04001AA6 RID: 6822
		[Range(0f, 1f)]
		[SerializeField]
		private float m_RunstepLenghten;

		// Token: 0x04001AA7 RID: 6823
		[SerializeField]
		private float m_JumpSpeed;

		// Token: 0x04001AA8 RID: 6824
		[SerializeField]
		private float m_StickToGroundForce;

		// Token: 0x04001AA9 RID: 6825
		[SerializeField]
		private float m_GravityMultiplier;

		// Token: 0x04001AAA RID: 6826
		[SerializeField]
		private MouseLook m_MouseLook;

		// Token: 0x04001AAB RID: 6827
		[SerializeField]
		private bool m_UseFovKick;

		// Token: 0x04001AAC RID: 6828
		[SerializeField]
		private FOVKick m_FovKick = new FOVKick();

		// Token: 0x04001AAD RID: 6829
		[SerializeField]
		private bool m_UseHeadBob;

		// Token: 0x04001AAE RID: 6830
		[SerializeField]
		private CurveControlledBob m_HeadBob = new CurveControlledBob();

		// Token: 0x04001AAF RID: 6831
		[SerializeField]
		private LerpControlledBob m_JumpBob = new LerpControlledBob();

		// Token: 0x04001AB0 RID: 6832
		[SerializeField]
		private float m_StepInterval;

		// Token: 0x04001AB1 RID: 6833
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		// Token: 0x04001AB2 RID: 6834
		[SerializeField]
		private AudioClip m_JumpSound;

		// Token: 0x04001AB3 RID: 6835
		[SerializeField]
		private AudioClip m_LandSound;

		// Token: 0x04001AB4 RID: 6836
		private Camera MPCEHPBGHII;

		// Token: 0x04001AB5 RID: 6837
		private bool EHLNFFBJFEL;

		// Token: 0x04001AB6 RID: 6838
		private float LGIGNLLIJCP;

		// Token: 0x04001AB7 RID: 6839
		private Vector2 MDFEKJFKBKE;

		// Token: 0x04001AB8 RID: 6840
		private Vector3 BLDJHOPAFAG = Vector3.zero;

		// Token: 0x04001AB9 RID: 6841
		private CharacterController LJKCHIKFFAB;

		// Token: 0x04001ABA RID: 6842
		private CollisionFlags AEHBOAOCDJL;

		// Token: 0x04001ABB RID: 6843
		private bool LFMADIAIKDM;

		// Token: 0x04001ABC RID: 6844
		private Vector3 MIOLLFJGDOH;

		// Token: 0x04001ABD RID: 6845
		private float GBOEDMJNBBO;

		// Token: 0x04001ABE RID: 6846
		private float GDOOPFALHEA;

		// Token: 0x04001ABF RID: 6847
		private bool NEGCOGOMKOI;

		// Token: 0x04001AC0 RID: 6848
		private AudioSource HOCFIIGOLED;
	}
}
