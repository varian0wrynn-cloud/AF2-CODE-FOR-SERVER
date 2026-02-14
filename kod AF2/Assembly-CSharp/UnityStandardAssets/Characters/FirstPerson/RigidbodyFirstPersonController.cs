using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020003A6 RID: 934
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		// Token: 0x0600CA3B RID: 51771 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 MMPMODKGDDC()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool JHCLBAFPIGL()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600CA3D RID: 51773 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool FMDLJFIKPKB
		{
			get
			{
				return this.OJMEFBNHGIM;
			}
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x005A81CC File Offset: 0x005A63CC
		private void DLKJAKIAFMN()
		{
			this.KBEPCKICBAL();
			Vector2 vector = this.JKLNKKMFFCB();
			if ((Mathf.Abs(vector.x) > 316f || Mathf.Abs(vector.y) > 992f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.AFOPGGHLFFB(), ForceMode.Force);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 277f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 769f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 1607f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(1994f, this.movementSettings.JumpForce, 279f), ForceMode.Force);
					this.NEGCOGOMKOI = false;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 442f && Mathf.Abs(vector.y) < 1020f && this.CAOKHDEKMMJ.velocity.magnitude < 1043f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 358f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.OEHNCGNGGCL();
				}
			}
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600CA3F RID: 51775 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool GEOPIGHCMAO()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x005A841C File Offset: 0x005A661C
		private float GPAJAIBGONN()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA41 RID: 51777 RVA: 0x005A844C File Offset: 0x005A664C
		private float ICGKHDDLHNL()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA42 RID: 51778 RVA: 0x005A847C File Offset: 0x005A667C
		private void MCEPHOLPPJE()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 533f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 773f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA43 RID: 51779 RVA: 0x005A8515 File Offset: 0x005A6715
		private void BLMBPFIJJBP()
		{
			this.COPBHGKBOLL();
			if (CELBHNONENJ.LEPAIPLBDGL("stacheaderprocess") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = true;
			}
		}

		// Token: 0x0600CA44 RID: 51780 RVA: 0x005A8538 File Offset: 0x005A6738
		private void NBMEALDCCMM()
		{
			this.CGGCCAMKAOL();
			Vector2 vector = this.GIPNEEEFHII();
			if ((Mathf.Abs(vector.x) > 756f || Mathf.Abs(vector.y) > 1310f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.OBLGIHDPPFC(), ForceMode.Force);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 659f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 485f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 1543f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(1365f, this.movementSettings.JumpForce, 928f), ForceMode.Force);
					this.NEGCOGOMKOI = true;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 608f && Mathf.Abs(vector.y) < 1757f && this.CAOKHDEKMMJ.velocity.magnitude < 227f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 1912f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.JIPJLHKACLN();
				}
			}
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x005A8788 File Offset: 0x005A6988
		private void PNKFIEIBKHJ()
		{
			if (Mathf.Abs(Time.timeScale) < 1329f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.DDILLBAABKK(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x005A8824 File Offset: 0x005A6A24
		private void OEHNCGNGGCL()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1236f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 18f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA47 RID: 51783 RVA: 0x005A88C0 File Offset: 0x005A6AC0
		private void COPBHGKBOLL()
		{
			if (Mathf.Abs(Time.timeScale) < 1882f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.EHMKEILENNB(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA48 RID: 51784 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool FNJEGPJPCGJ()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA49 RID: 51785 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool ENEFBEPEGPC()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x005A8964 File Offset: 0x005A6B64
		private float KNDOLBIJNLH()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA4B RID: 51787 RVA: 0x005A8994 File Offset: 0x005A6B94
		private void DFAMPKKBEPO()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1155f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 309f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x005A8A30 File Offset: 0x005A6C30
		private void EHEEBOIMJGN()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1109f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 1407f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool IFHFIAMGPLD()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA4E RID: 51790 RVA: 0x005A8ACC File Offset: 0x005A6CCC
		private float DCBNJMKLMOP()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x005A8AFC File Offset: 0x005A6CFC
		private void GFGMFGCCAEB()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 578f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 1149f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA50 RID: 51792 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool MPJCOANBFOG()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA51 RID: 51793 RVA: 0x005A8B98 File Offset: 0x005A6D98
		private void KJGPKCLBLJA()
		{
			this.OMNFJINILND();
			Vector2 vector = this.BJGBMBNLKCB();
			if ((Mathf.Abs(vector.x) > 1513f || Mathf.Abs(vector.y) > 783f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.NNOGJODHEII(), ForceMode.Force);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 1188f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 539f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 1655f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(1970f, this.movementSettings.JumpForce, 1251f), ForceMode.Force);
					this.NEGCOGOMKOI = false;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 243f && Mathf.Abs(vector.y) < 1526f && this.CAOKHDEKMMJ.velocity.magnitude < 1697f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 1913f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.BDLPBDJINLB();
				}
			}
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600CA52 RID: 51794 RVA: 0x005A8DE6 File Offset: 0x005A6FE6
		private void LBEFOABPMFG()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.BBCINJAGHEP(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x005A8E1C File Offset: 0x005A701C
		private void DOHJPDNKALP()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.PBDMAGJEBEJ(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA54 RID: 51796 RVA: 0x005A8E54 File Offset: 0x005A7054
		private void CADAJFAMDFL()
		{
			if (Mathf.Abs(Time.timeScale) < 165f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.EHMKEILENNB(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x005A8EF0 File Offset: 0x005A70F0
		private float PAPJJMPCDLK()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA56 RID: 51798 RVA: 0x005A8F20 File Offset: 0x005A7120
		private Vector2 BELOFLNGMCJ()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("Occluder Shader Missing..."),
				y = CELBHNONENJ.LBBLPMHONLE("move")
			};
			this.movementSettings.OPEMDPPHGOD(vector);
			return vector;
		}

		// Token: 0x0600CA57 RID: 51799 RVA: 0x005A8F66 File Offset: 0x005A7166
		private void PNOHGOJEJKL()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.HCJHJBAKBBP(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x005A8F9C File Offset: 0x005A719C
		private void PKKFAFLPJKK()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1609f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = false;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = true;
			}
		}

		// Token: 0x0600CA59 RID: 51801 RVA: 0x005A9049 File Offset: 0x005A7249
		private void IDMCOLDDNCF()
		{
			this.CFEKFAAPCGN();
			if (CELBHNONENJ.LEPAIPLBDGL("_FogAlpha") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = true;
			}
		}

		// Token: 0x0600CA5A RID: 51802 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 EENLEHMJMDA()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CA5B RID: 51803 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool KHHGKNKPHEO()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA5C RID: 51804 RVA: 0x005A906C File Offset: 0x005A726C
		private float DEFMLKNINDB()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA5D RID: 51805 RVA: 0x005A909C File Offset: 0x005A729C
		private void HHBADMMIFHK()
		{
			this.DGMKCOKLAKO();
			Vector2 vector = this.KLBBCDHNHPF();
			if ((Mathf.Abs(vector.x) > 5f || Mathf.Abs(vector.y) > 461f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.JJJGBBPAKEM(), ForceMode.Impulse);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 1337f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 104f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 269f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(323f, this.movementSettings.JumpForce, 1748f), ForceMode.Impulse);
					this.NEGCOGOMKOI = true;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 752f && Mathf.Abs(vector.y) < 1226f && this.CAOKHDEKMMJ.velocity.magnitude < 1698f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 1929f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.OOPMMEIPJNI();
				}
			}
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600CA5E RID: 51806 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool PKKLAFDHJCB()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA5F RID: 51807 RVA: 0x005A92EA File Offset: 0x005A74EA
		private void Start()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.PINLMCCKKNA(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA60 RID: 51808 RVA: 0x005A9320 File Offset: 0x005A7520
		private void BAIKCLKJPAA()
		{
			this.PDFKDENACEO();
			if (CELBHNONENJ.LEPAIPLBDGL("[LH &]") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = false;
			}
		}

		// Token: 0x0600CA61 RID: 51809 RVA: 0x005A9344 File Offset: 0x005A7544
		private float JJJGBBPAKEM()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA62 RID: 51810 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool OBMNCNDFOBG()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA63 RID: 51811 RVA: 0x005A9374 File Offset: 0x005A7574
		private void GOLJBPNEPAO()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 636f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 1118f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x005A9410 File Offset: 0x005A7610
		private void DGMKCOKLAKO()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1095f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = false;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = false;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = true;
			}
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x005A94BD File Offset: 0x005A76BD
		private void LMGBKHCHPHO()
		{
			this.KMCJMBPJCHD();
			if (CELBHNONENJ.LEPAIPLBDGL("\n") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = true;
			}
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 ABGICPOBPDC()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x005A94E0 File Offset: 0x005A76E0
		private void JPHBPEAMNHB()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.KMICLAAHOLM(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool JHFINANLCEC()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x005A9518 File Offset: 0x005A7718
		private void CEKFGIDCBHJ()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1760f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = false;
			}
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x005A95C8 File Offset: 0x005A77C8
		private void KGFCEEKCLHE()
		{
			this.CGGCCAMKAOL();
			Vector2 vector = this.JKLNKKMFFCB();
			if ((Mathf.Abs(vector.x) > 209f || Mathf.Abs(vector.y) > 1024f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.DEFMLKNINDB(), ForceMode.Force);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 665f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 401f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 763f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(1234f, this.movementSettings.JumpForce, 779f), ForceMode.Impulse);
					this.NEGCOGOMKOI = true;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 210f && Mathf.Abs(vector.y) < 1548f && this.CAOKHDEKMMJ.velocity.magnitude < 1541f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 1569f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.MCEPHOLPPJE();
				}
			}
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x005A9818 File Offset: 0x005A7A18
		private float AFOPGGHLFFB()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x005A9847 File Offset: 0x005A7A47
		private void HHGGCBLOJGB()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.NBNPGNFKHMF(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x005A9880 File Offset: 0x005A7A80
		private Vector2 BJGBMBNLKCB()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("Fog Areas should be created on runtime."),
				y = CELBHNONENJ.LBBLPMHONLE("_ChromaticAberration")
			};
			this.movementSettings.JFIBNHKBHBN(vector);
			return vector;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600CA6E RID: 51822 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool KBOPEIEHGCB
		{
			get
			{
				return this.NEGCOGOMKOI;
			}
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x005A98C6 File Offset: 0x005A7AC6
		private void AIAMIFEPALP()
		{
			this.PDFKDENACEO();
			if (CELBHNONENJ.LEPAIPLBDGL("https://groups.google.com/forum/#!forum/final-ik") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = true;
			}
		}

		// Token: 0x0600CA70 RID: 51824 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool JMCKOBCHEKK()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x005A98EC File Offset: 0x005A7AEC
		private Vector2 KLBBCDHNHPF()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("gi_uinf_8"),
				y = CELBHNONENJ.LBBLPMHONLE("Hidden/Image Effects/Cinematic/AmbientOcclusion")
			};
			this.movementSettings.GIGIJLKDMNN(vector);
			return vector;
		}

		// Token: 0x0600CA72 RID: 51826 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool DLGJBAFGCFI()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA73 RID: 51827 RVA: 0x005A9932 File Offset: 0x005A7B32
		public bool KHKODMIBJMF()
		{
			return this.movementSettings.LHLKMDJPIOB();
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x005A9940 File Offset: 0x005A7B40
		private void MDBKDDCKBND()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1665f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = true;
			}
		}

		// Token: 0x0600CA75 RID: 51829 RVA: 0x005A99F0 File Offset: 0x005A7BF0
		private void KGHPCLMMFLG()
		{
			if (Mathf.Abs(Time.timeScale) < 1286f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.EGMOGFFEMDN(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA76 RID: 51830 RVA: 0x005A9A8C File Offset: 0x005A7C8C
		private Vector2 MDOMEJHLNLA()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("AFCServer"),
				y = CELBHNONENJ.LBBLPMHONLE("Card Player Look")
			};
			this.movementSettings.KCGJCAPODGP(vector);
			return vector;
		}

		// Token: 0x0600CA77 RID: 51831 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 EKOLAGAJOOA()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CA78 RID: 51832 RVA: 0x005A9AD4 File Offset: 0x005A7CD4
		private void KMCJMBPJCHD()
		{
			if (Mathf.Abs(Time.timeScale) < 1217f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.HEMJEIADKDD(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA79 RID: 51833 RVA: 0x005A9B6E File Offset: 0x005A7D6E
		private void INDGOHJGCFN()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.OBGCHDDFNCF(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA7A RID: 51834 RVA: 0x005A9BA4 File Offset: 0x005A7DA4
		private void LCBIFGKANMD()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.EAONEAGNPCD(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA7B RID: 51835 RVA: 0x005A9BDA File Offset: 0x005A7DDA
		private void OBJCOJEHLBE()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.DFHGBNABLEC(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA7C RID: 51836 RVA: 0x005A9C10 File Offset: 0x005A7E10
		private void BDLPBDJINLB()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1576f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 1360f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA7D RID: 51837 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 CICNMKHCHMF()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CA7E RID: 51838 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool OAFCLDHEEMH()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA7F RID: 51839 RVA: 0x005A9CAC File Offset: 0x005A7EAC
		private Vector2 JKLNKKMFFCB()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("IdleReadyCrouch"),
				y = CELBHNONENJ.LBBLPMHONLE("DITHERING")
			};
			this.movementSettings.FJKLMJDCMEO(vector);
			return vector;
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x005A9CF2 File Offset: 0x005A7EF2
		public bool GOCMOBELFIB()
		{
			return this.movementSettings.ENALKPADCKH();
		}

		// Token: 0x0600CA81 RID: 51841 RVA: 0x005A9D00 File Offset: 0x005A7F00
		private void OMNFJINILND()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1852f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = false;
			}
		}

		// Token: 0x0600CA82 RID: 51842 RVA: 0x005A9DB0 File Offset: 0x005A7FB0
		private void MMFOJOOPLFK()
		{
			if (Mathf.Abs(Time.timeScale) < 1E-45f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.CMDMHNNKPME(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x005A9E4C File Offset: 0x005A804C
		private Vector2 OIAFCAMPOGC()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("JumpCurve"),
				y = CELBHNONENJ.LBBLPMHONLE("<color='#300030'>{0}</color>")
			};
			this.movementSettings.BJMEBBHKAPD(vector);
			return vector;
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool NDIAEBCMKFA()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA85 RID: 51845 RVA: 0x005A9E94 File Offset: 0x005A8094
		private void ENCEJLPKFMI()
		{
			if (Mathf.Abs(Time.timeScale) < 609f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.JNGJHKKECCE(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA86 RID: 51846 RVA: 0x005A9F2E File Offset: 0x005A812E
		public bool HKJIMAFEEHN()
		{
			return this.movementSettings.AJDKHBBLNHJ();
		}

		// Token: 0x0600CA87 RID: 51847 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool BJCFMFLLMOO()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA88 RID: 51848 RVA: 0x005A9F3C File Offset: 0x005A813C
		private void OOPMMEIPJNI()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 2f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 85f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA89 RID: 51849 RVA: 0x005A9FD5 File Offset: 0x005A81D5
		private void BOAJJAKEMLH()
		{
			this.GEGOCODLDAH();
			if (CELBHNONENJ.LEPAIPLBDGL("isBrag") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = false;
			}
		}

		// Token: 0x0600CA8A RID: 51850 RVA: 0x005A9FF8 File Offset: 0x005A81F8
		private void LKCKIDJMDGJ()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 935f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 246f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x005AA094 File Offset: 0x005A8294
		private void DNCEJPOHOID()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1034f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 1350f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x005AA12D File Offset: 0x005A832D
		public bool KGEBCMFLOOB()
		{
			return this.movementSettings.KNLONIDMIFA();
		}

		// Token: 0x0600CA8D RID: 51853 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool DHBAFPCCLIK()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA8E RID: 51854 RVA: 0x005A92EA File Offset: 0x005A74EA
		private void ELCNJDNCAEP()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.PINLMCCKKNA(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA8F RID: 51855 RVA: 0x005AA13C File Offset: 0x005A833C
		private void EAOPJLPOALK()
		{
			this.MDBKDDCKBND();
			Vector2 vector = this.BELOFLNGMCJ();
			if ((Mathf.Abs(vector.x) > 127f || Mathf.Abs(vector.y) > 476f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.LKNKCDGGLMI(), ForceMode.Force);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 1005f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 1765f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 463f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(1870f, this.movementSettings.JumpForce, 915f), ForceMode.Force);
					this.NEGCOGOMKOI = false;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 258f && Mathf.Abs(vector.y) < 1211f && this.CAOKHDEKMMJ.velocity.magnitude < 1749f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 471f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.MCEPHOLPPJE();
				}
			}
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600CA90 RID: 51856 RVA: 0x005AA38C File Offset: 0x005A858C
		private void HLKJKCKBELP()
		{
			this.MDBKDDCKBND();
			Vector2 vector = this.BJGBMBNLKCB();
			if ((Mathf.Abs(vector.x) > 552f || Mathf.Abs(vector.y) > 1906f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.DCBNJMKLMOP(), ForceMode.Force);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 911f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 1843f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 1003f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(1079f, this.movementSettings.JumpForce, 541f), ForceMode.Impulse);
					this.NEGCOGOMKOI = false;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 31f && Mathf.Abs(vector.y) < 686f && this.CAOKHDEKMMJ.velocity.magnitude < 1409f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 1783f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.EHEEBOIMJGN();
				}
			}
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x005AA5DC File Offset: 0x005A87DC
		private void PDFKDENACEO()
		{
			if (Mathf.Abs(Time.timeScale) < 1888f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.EHMKEILENNB(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x005AA678 File Offset: 0x005A8878
		private void BPEHAKHHMKN()
		{
			if (Mathf.Abs(Time.timeScale) < 1004f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.NFDNGJJADCM(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x005AA73C File Offset: 0x005A893C
		private void NHGGADIJIED()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 2f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = false;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = false;
			}
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x005AA7EC File Offset: 0x005A89EC
		private float NBEAFKECCDE()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA96 RID: 51862 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool JEFNLDHGNHF()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool EBEHIJDMDBM()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x005AA81C File Offset: 0x005A8A1C
		private float JNCICHCNFKG()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA99 RID: 51865 RVA: 0x005AA84C File Offset: 0x005A8A4C
		private float NNOGJODHEII()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x005AA87B File Offset: 0x005A8A7B
		private void CKIGGCAHAFD()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.NCMPGDLDPJG(base.transform, this.cam.transform);
		}

		// Token: 0x0600CA9B RID: 51867 RVA: 0x005AA8B4 File Offset: 0x005A8AB4
		private float LKNKCDGGLMI()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA9C RID: 51868 RVA: 0x005AA8E4 File Offset: 0x005A8AE4
		private float CEADAIHOMND()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CA9D RID: 51869 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool KIEOCKKNOAJ()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 KBKJBOEGGEM
		{
			get
			{
				return this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CA9F RID: 51871 RVA: 0x005AA914 File Offset: 0x005A8B14
		private void KBEPCKICBAL()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 114f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = false;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = false;
			}
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 MIGPEFMOJAD()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CAA1 RID: 51873 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool FMEIPJGKKOO()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CAA2 RID: 51874 RVA: 0x005AA9C4 File Offset: 0x005A8BC4
		private float OBLGIHDPPFC()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool ELODMHNIPCF()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x005AA9F4 File Offset: 0x005A8BF4
		private float IOENOMCCMNB()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CAA5 RID: 51877 RVA: 0x005AAA24 File Offset: 0x005A8C24
		private void JOGNALAOEEE()
		{
			this.CEKFGIDCBHJ();
			Vector2 vector = this.MDOMEJHLNLA();
			if ((Mathf.Abs(vector.x) > 1837f || Mathf.Abs(vector.y) > 1522f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.CEADAIHOMND(), ForceMode.Force);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 1215f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 1307f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 308f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(1552f, this.movementSettings.JumpForce, 1512f), ForceMode.Force);
					this.NEGCOGOMKOI = false;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 1576f && Mathf.Abs(vector.y) < 1384f && this.CAOKHDEKMMJ.velocity.magnitude < 1932f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 70f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.LKCKIDJMDGJ();
				}
			}
			this.EHLNFFBJFEL = true;
		}

		// Token: 0x0600CAA6 RID: 51878 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool NJNNDNIAHJB()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CAA7 RID: 51879 RVA: 0x005AAC72 File Offset: 0x005A8E72
		private void Update()
		{
			this.MMFOJOOPLFK();
			if (CELBHNONENJ.LEPAIPLBDGL("Jump") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = true;
			}
		}

		// Token: 0x0600CAA8 RID: 51880 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool HNEAIHHCBHF()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CAA9 RID: 51881 RVA: 0x005A81C2 File Offset: 0x005A63C2
		public bool ACEBLDAKKOK()
		{
			return this.OJMEFBNHGIM;
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 JJPMBBLHNML()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CAAB RID: 51883 RVA: 0x005AAC98 File Offset: 0x005A8E98
		private void CGGCCAMKAOL()
		{
			this.LFMADIAIKDM = this.OJMEFBNHGIM;
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 1582f - this.FAEMFNCJNKD.radius + this.advancedSettings.groundCheckDistance))
			{
				this.OJMEFBNHGIM = true;
				this.INNBDALCCJH = raycastHit.normal;
			}
			else
			{
				this.OJMEFBNHGIM = false;
				this.INNBDALCCJH = Vector3.up;
			}
			if (!this.LFMADIAIKDM && this.OJMEFBNHGIM && this.NEGCOGOMKOI)
			{
				this.NEGCOGOMKOI = true;
			}
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x005AAD48 File Offset: 0x005A8F48
		private Vector2 ANAKHNPBFDD()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("Horizontal"),
				y = CELBHNONENJ.LBBLPMHONLE("Vertical")
			};
			this.movementSettings.LIIGJNBAPGJ(vector);
			return vector;
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool LPKKKOBDDHL()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CAAE RID: 51886 RVA: 0x005AAD90 File Offset: 0x005A8F90
		private float BPMMPMJFEKM()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CAAF RID: 51887 RVA: 0x005AADC0 File Offset: 0x005A8FC0
		private void NNBDNBEGBCK()
		{
			if (Mathf.Abs(Time.timeScale) < 1461f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.HOHECFACKAM(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x005AAE5A File Offset: 0x005A905A
		public bool NGAFIECHICL()
		{
			return this.movementSettings.NFJAACDBKKJ();
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x005AAE67 File Offset: 0x005A9067
		public bool MFBDMNPCJMK()
		{
			return this.movementSettings.HDHJGMMIDCI();
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x005AAE74 File Offset: 0x005A9074
		private void DPGECEOMHNM()
		{
			this.BPEHAKHHMKN();
			if (CELBHNONENJ.LEPAIPLBDGL("</color>") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = true;
			}
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x005AAE98 File Offset: 0x005A9098
		private void FBCBGKMJAJL()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 988f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 1131f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x005AAF31 File Offset: 0x005A9131
		private void FECFLBMPAAL()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.FLHHEEAEPHJ(base.transform, this.cam.transform);
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x005AAF67 File Offset: 0x005A9167
		public bool BBFBGIGALHP()
		{
			return this.movementSettings.JBLPEOFAFHK();
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x005AAF74 File Offset: 0x005A9174
		public bool BNDOIAMADJN()
		{
			return this.movementSettings.Running;
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x005AAF81 File Offset: 0x005A9181
		private void AFFAJKPPMHF()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.JONEKLKPPJA(base.transform, this.cam.transform);
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x005AAFB7 File Offset: 0x005A91B7
		private void HDFCIACDDEK()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.FPPGDHJOPKH(base.transform, this.cam.transform);
		}

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x005AAFED File Offset: 0x005A91ED
		private void BOJJIJICHBK()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.MAENOCDHJMB(base.transform, this.cam.transform);
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x005AB024 File Offset: 0x005A9224
		private void FixedUpdate()
		{
			this.NHGGADIJIED();
			Vector2 vector = this.ANAKHNPBFDD();
			if ((Mathf.Abs(vector.x) > 1E-45f || Mathf.Abs(vector.y) > 1E-45f) && (this.advancedSettings.airControl || this.OJMEFBNHGIM))
			{
				Vector3 vector2 = this.cam.transform.forward * vector.y + this.cam.transform.right * vector.x;
				vector2 = Vector3.ProjectOnPlane(vector2, this.INNBDALCCJH).normalized;
				vector2.x *= this.movementSettings.CurrentTargetSpeed;
				vector2.z *= this.movementSettings.CurrentTargetSpeed;
				vector2.y *= this.movementSettings.CurrentTargetSpeed;
				if (this.CAOKHDEKMMJ.velocity.sqrMagnitude < this.movementSettings.CurrentTargetSpeed * this.movementSettings.CurrentTargetSpeed)
				{
					this.CAOKHDEKMMJ.AddForce(vector2 * this.NBEAFKECCDE(), ForceMode.Impulse);
				}
			}
			if (this.OJMEFBNHGIM)
			{
				this.CAOKHDEKMMJ.drag = 5f;
				if (this.EHLNFFBJFEL)
				{
					this.CAOKHDEKMMJ.drag = 0f;
					this.CAOKHDEKMMJ.velocity = new Vector3(this.CAOKHDEKMMJ.velocity.x, 0f, this.CAOKHDEKMMJ.velocity.z);
					this.CAOKHDEKMMJ.AddForce(new Vector3(0f, this.movementSettings.JumpForce, 0f), ForceMode.Impulse);
					this.NEGCOGOMKOI = true;
				}
				if (!this.NEGCOGOMKOI && Mathf.Abs(vector.x) < 1E-45f && Mathf.Abs(vector.y) < 1E-45f && this.CAOKHDEKMMJ.velocity.magnitude < 1f)
				{
					this.CAOKHDEKMMJ.Sleep();
				}
			}
			else
			{
				this.CAOKHDEKMMJ.drag = 0f;
				if (this.LFMADIAIKDM && !this.NEGCOGOMKOI)
				{
					this.OOPMMEIPJNI();
				}
			}
			this.EHLNFFBJFEL = false;
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x005AB274 File Offset: 0x005A9474
		private void HEAIFCDFONA()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 512f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 95f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x005AB310 File Offset: 0x005A9510
		private void GEGOCODLDAH()
		{
			if (Mathf.Abs(Time.timeScale) < 330f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.HEMJEIADKDD(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x005AB3AC File Offset: 0x005A95AC
		private float HFOIJGJFCKD()
		{
			float time = Vector3.Angle(this.INNBDALCCJH, Vector3.up);
			return this.movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		// Token: 0x0600CABE RID: 51902 RVA: 0x005AB3DB File Offset: 0x005A95DB
		private void PFNOEACNHON()
		{
			this.BPEHAKHHMKN();
			if (CELBHNONENJ.LEPAIPLBDGL("invn_rec16") && !this.EHLNFFBJFEL)
			{
				this.EHLNFFBJFEL = false;
			}
		}

		// Token: 0x0600CABF RID: 51903 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 NEKOHBMFNPN()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CAC0 RID: 51904 RVA: 0x005A895A File Offset: 0x005A6B5A
		public bool BOMHEGDNKBP()
		{
			return this.NEGCOGOMKOI;
		}

		// Token: 0x0600CAC1 RID: 51905 RVA: 0x005AB400 File Offset: 0x005A9600
		private void JIPJLHKACLN()
		{
			RaycastHit raycastHit;
			if (Physics.SphereCast(base.transform.position, this.FAEMFNCJNKD.radius, Vector3.down, out raycastHit, this.FAEMFNCJNKD.height / 562f - this.FAEMFNCJNKD.radius + this.advancedSettings.stickToGroundHelperDistance) && Mathf.Abs(Vector3.Angle(raycastHit.normal, Vector3.up)) < 1961f)
			{
				this.CAOKHDEKMMJ.velocity = Vector3.ProjectOnPlane(this.CAOKHDEKMMJ.velocity, raycastHit.normal);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600CAC2 RID: 51906 RVA: 0x005AAF74 File Offset: 0x005A9174
		public bool OINAFHGLNEG
		{
			get
			{
				return this.movementSettings.Running;
			}
		}

		// Token: 0x0600CAC3 RID: 51907 RVA: 0x005AAF67 File Offset: 0x005A9167
		public bool PEPELEHPMJJ()
		{
			return this.movementSettings.JBLPEOFAFHK();
		}

		// Token: 0x0600CAC4 RID: 51908 RVA: 0x005AB49C File Offset: 0x005A969C
		private Vector2 GIPNEEEFHII()
		{
			Vector2 vector = new Vector2
			{
				x = CELBHNONENJ.LBBLPMHONLE("Sitting Reading Lean Back"),
				y = CELBHNONENJ.LBBLPMHONLE("'UniqueShadowSun.instance' is already null when disabling '{0}'!")
			};
			this.movementSettings.ENNICEKJOCI(vector);
			return vector;
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x005A81B5 File Offset: 0x005A63B5
		public Vector3 LIBCKAONFEB()
		{
			return this.CAOKHDEKMMJ.velocity;
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x005AB4E4 File Offset: 0x005A96E4
		private void CFEKFAAPCGN()
		{
			if (Mathf.Abs(Time.timeScale) < 525f)
			{
				return;
			}
			float y = base.transform.eulerAngles.y;
			this.mouseLook.LLJOKNFKPLL(base.transform, this.cam.transform);
			if (this.OJMEFBNHGIM || this.advancedSettings.airControl)
			{
				Quaternion rotation = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
				this.CAOKHDEKMMJ.velocity = rotation * this.CAOKHDEKMMJ.velocity;
			}
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x005AAE5A File Offset: 0x005A905A
		public bool IBKHAHBGCLP()
		{
			return this.movementSettings.NFJAACDBKKJ();
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x005A9847 File Offset: 0x005A7A47
		private void BFBBJILCKAK()
		{
			this.CAOKHDEKMMJ = base.GetComponent<Rigidbody>();
			this.FAEMFNCJNKD = base.GetComponent<CapsuleCollider>();
			this.mouseLook.NBNPGNFKHMF(base.transform, this.cam.transform);
		}

		// Token: 0x04001AD2 RID: 6866
		public Camera cam;

		// Token: 0x04001AD3 RID: 6867
		public RigidbodyFirstPersonController.MovementSettings movementSettings = new RigidbodyFirstPersonController.MovementSettings();

		// Token: 0x04001AD4 RID: 6868
		public MouseLook mouseLook = new MouseLook();

		// Token: 0x04001AD5 RID: 6869
		public RigidbodyFirstPersonController.AdvancedSettings advancedSettings = new RigidbodyFirstPersonController.AdvancedSettings();

		// Token: 0x04001AD6 RID: 6870
		private Rigidbody CAOKHDEKMMJ;

		// Token: 0x04001AD7 RID: 6871
		private CapsuleCollider FAEMFNCJNKD;

		// Token: 0x04001AD8 RID: 6872
		private float LGIGNLLIJCP;

		// Token: 0x04001AD9 RID: 6873
		private Vector3 INNBDALCCJH;

		// Token: 0x04001ADA RID: 6874
		private bool EHLNFFBJFEL;

		// Token: 0x04001ADB RID: 6875
		private bool LFMADIAIKDM;

		// Token: 0x04001ADC RID: 6876
		private bool NEGCOGOMKOI;

		// Token: 0x04001ADD RID: 6877
		private bool OJMEFBNHGIM;

		// Token: 0x020003A7 RID: 935
		[Serializable]
		public class MovementSettings
		{
			// Token: 0x0600CAC9 RID: 51913 RVA: 0x005AB580 File Offset: 0x005A9780
			public void NBCJAEEKNBG(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1065f || NFKFMIIAKFN.x < 1476f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 980f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 180f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CACA RID: 51914 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool HDHJGMMIDCI()
			{
				return this.m_Running;
			}

			// Token: 0x0600CACB RID: 51915 RVA: 0x005AB62C File Offset: 0x005A982C
			public void JFIBNHKBHBN(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 922f || NFKFMIIAKFN.x < 1141f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 77f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1332f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CACC RID: 51916 RVA: 0x005AB6D0 File Offset: 0x005A98D0
			public void CIADFIBLKJK(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1463f || NFKFMIIAKFN.x < 557f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1816f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1485f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CACD RID: 51917 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool PDLGKCJOIPL()
			{
				return this.m_Running;
			}

			// Token: 0x0600CACE RID: 51918 RVA: 0x005AB774 File Offset: 0x005A9974
			public void DILHIKADOMC(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1364f || NFKFMIIAKFN.x < 1658f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1932f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1237f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CACF RID: 51919 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool CMNPAHHAPJD()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD0 RID: 51920 RVA: 0x005AB818 File Offset: 0x005A9A18
			public void LIIGJNBAPGJ(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 0f || NFKFMIIAKFN.x < 0f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 0f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 0f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAD1 RID: 51921 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool BHGJNCELPKN()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD2 RID: 51922 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool FCGMBABFLLE()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD3 RID: 51923 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool MGDMAICBOHD()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD4 RID: 51924 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool GNDGNNGJCDP()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD6 RID: 51926 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool PNGBMKMGKHJ()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD7 RID: 51927 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool FOKGAODEOBO()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD8 RID: 51928 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool BEDJJMJMCJP()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAD9 RID: 51929 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool FMCDMLNKHKK()
			{
				return this.m_Running;
			}

			// Token: 0x0600CADA RID: 51930 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool GIBBBDGEIEP()
			{
				return this.m_Running;
			}

			// Token: 0x0600CADB RID: 51931 RVA: 0x005AB970 File Offset: 0x005A9B70
			public void HHNEAPGMABJ(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1534f || NFKFMIIAKFN.x < 1223f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1310f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 551f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CADC RID: 51932 RVA: 0x005ABA14 File Offset: 0x005A9C14
			public void OPEMDPPHGOD(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 790f || NFKFMIIAKFN.x < 1642f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 731f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 853f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CADD RID: 51933 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool JCIIMCPGGNB()
			{
				return this.m_Running;
			}

			// Token: 0x0600CADE RID: 51934 RVA: 0x005ABAB8 File Offset: 0x005A9CB8
			public void BAPGEDLMFJE(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 971f || NFKFMIIAKFN.x < 153f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 509f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 190f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CADF RID: 51935 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool CPFFCJNKPNP()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAE0 RID: 51936 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool LHLKMDJPIOB()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAE1 RID: 51937 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool JBLPEOFAFHK()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAE2 RID: 51938 RVA: 0x005ABB5C File Offset: 0x005A9D5C
			public void LFINKMBAAFH(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1779f || NFKFMIIAKFN.x < 271f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1211f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 760f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAE3 RID: 51939 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool DCHPMMOIFOK()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAE4 RID: 51940 RVA: 0x005ABC00 File Offset: 0x005A9E00
			public void BJMEBBHKAPD(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 175f || NFKFMIIAKFN.x < 675f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1462f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1121f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAE5 RID: 51941 RVA: 0x005ABCA4 File Offset: 0x005A9EA4
			public void LPNIECEGCMP(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1795f || NFKFMIIAKFN.x < 1448f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1881f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 603f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAE6 RID: 51942 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool OFNAGHICHPI()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAE7 RID: 51943 RVA: 0x005ABD48 File Offset: 0x005A9F48
			public void HCKFDNCDPFO(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1939f || NFKFMIIAKFN.x < 1981f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1678f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1826f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAE8 RID: 51944 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool MAKFBPDIHLF()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAE9 RID: 51945 RVA: 0x005ABDEC File Offset: 0x005A9FEC
			public void ICFOFCCBBFM(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1206f || NFKFMIIAKFN.x < 1128f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1473f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1086f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAEA RID: 51946 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool PDNMCAPOJGJ()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAEB RID: 51947 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool AJDKHBBLNHJ()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAEC RID: 51948 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool KNLONIDMIFA()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAED RID: 51949 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool HMPKBMBKDLN()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAEE RID: 51950 RVA: 0x005ABE90 File Offset: 0x005AA090
			public void AADDOMNNDBB(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1159f || NFKFMIIAKFN.x < 17f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1529f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1014f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAEF RID: 51951 RVA: 0x005ABF34 File Offset: 0x005AA134
			public void ENNICEKJOCI(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1415f || NFKFMIIAKFN.x < 1403f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 710f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1992f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAF0 RID: 51952 RVA: 0x005ABFD8 File Offset: 0x005AA1D8
			public void NPEAPFOBKOK(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1475f || NFKFMIIAKFN.x < 403f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1479f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 338f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAF1 RID: 51953 RVA: 0x005AC07C File Offset: 0x005AA27C
			public void GDLGNIANCNB(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1326f || NFKFMIIAKFN.x < 454f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1048f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 365f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAF2 RID: 51954 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool ENALKPADCKH()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAF3 RID: 51955 RVA: 0x005AC120 File Offset: 0x005AA320
			public void KMEEBEGJCKE(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 313f || NFKFMIIAKFN.x < 505f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1685f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1747f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAF4 RID: 51956 RVA: 0x005AC1C4 File Offset: 0x005AA3C4
			public void LGFCKACKJNK(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 675f || NFKFMIIAKFN.x < 996f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1349f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1280f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAF5 RID: 51957 RVA: 0x005AC268 File Offset: 0x005AA468
			public void HIPMMEMEBCK(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1110f || NFKFMIIAKFN.x < 1886f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1756f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1823f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAF6 RID: 51958 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool DIBPOMOOCIM()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAF7 RID: 51959 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool EKNBFNEANNC()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAF8 RID: 51960 RVA: 0x005AC30C File Offset: 0x005AA50C
			public void MLKLKLDJOAE(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 138f || NFKFMIIAKFN.x < 198f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 927f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 219f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CAF9 RID: 51961 RVA: 0x005AC3B0 File Offset: 0x005AA5B0
			public void GMAPFLBHHKG(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1604f || NFKFMIIAKFN.x < 1756f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 703f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1590f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAFA RID: 51962 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool CKLDDCEAGJP()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAFB RID: 51963 RVA: 0x005AC454 File Offset: 0x005AA654
			public void MICLOAEOFOK(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 318f || NFKFMIIAKFN.x < 635f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1991f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1045f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAFC RID: 51964 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool NCDDHIJILFC()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAFD RID: 51965 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool CGKGPIGBLCL()
			{
				return this.m_Running;
			}

			// Token: 0x0600CAFE RID: 51966 RVA: 0x005AC4F8 File Offset: 0x005AA6F8
			public void IJIBEIBOOFL(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 35f || NFKFMIIAKFN.x < 584f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1289f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1503f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CAFF RID: 51967 RVA: 0x005AC59C File Offset: 0x005AA79C
			public void FJKLMJDCMEO(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1052f || NFKFMIIAKFN.x < 496f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 818f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 5f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CB00 RID: 51968 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool CPFPLFIODHC()
			{
				return this.m_Running;
			}

			// Token: 0x0600CB01 RID: 51969 RVA: 0x005AC640 File Offset: 0x005AA840
			public void PEOFENGEFGK(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 514f || NFKFMIIAKFN.x < 1837f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1332f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1750f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CB02 RID: 51970 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool PALLKNKIHFE()
			{
				return this.m_Running;
			}

			// Token: 0x0600CB03 RID: 51971 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool NFJAACDBKKJ()
			{
				return this.m_Running;
			}

			// Token: 0x0600CB04 RID: 51972 RVA: 0x005AC6E4 File Offset: 0x005AA8E4
			public void KCGJCAPODGP(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 645f || NFKFMIIAKFN.x < 817f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1834f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1193f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CB05 RID: 51973 RVA: 0x005AC788 File Offset: 0x005AA988
			public void INCJGEMCCIL(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1369f || NFKFMIIAKFN.x < 216f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 676f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 128f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = true;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x0600CB06 RID: 51974 RVA: 0x005AC82C File Offset: 0x005AAA2C
			public void GIGIJLKDMNN(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 581f || NFKFMIIAKFN.x < 637f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1713f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1650f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x0600CB07 RID: 51975 RVA: 0x005AC8D0 File Offset: 0x005AAAD0
			public void LPFKGPCMMBA(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 1898f || NFKFMIIAKFN.x < 534f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 1670f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 1806f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = false;
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x0600CB08 RID: 51976 RVA: 0x005AB622 File Offset: 0x005A9822
			public bool Running
			{
				get
				{
					return this.m_Running;
				}
			}

			// Token: 0x0600CB09 RID: 51977 RVA: 0x005AC974 File Offset: 0x005AAB74
			public void HIBGKENEELC(Vector2 NFKFMIIAKFN)
			{
				if (NFKFMIIAKFN == Vector2.zero)
				{
					return;
				}
				if (NFKFMIIAKFN.x > 330f || NFKFMIIAKFN.x < 709f)
				{
					this.CurrentTargetSpeed = this.StrafeSpeed;
				}
				if (NFKFMIIAKFN.y < 640f)
				{
					this.CurrentTargetSpeed = this.BackwardSpeed;
				}
				if (NFKFMIIAKFN.y > 828f)
				{
					this.CurrentTargetSpeed = this.ForwardSpeed;
				}
				if (Input.GetKey(this.RunKey))
				{
					this.CurrentTargetSpeed *= this.RunMultiplier;
					this.m_Running = false;
					return;
				}
				this.m_Running = true;
			}

			// Token: 0x04001ADE RID: 6878
			public float ForwardSpeed = 8f;

			// Token: 0x04001ADF RID: 6879
			public float BackwardSpeed = 4f;

			// Token: 0x04001AE0 RID: 6880
			public float StrafeSpeed = 4f;

			// Token: 0x04001AE1 RID: 6881
			public float RunMultiplier = 2f;

			// Token: 0x04001AE2 RID: 6882
			public KeyCode RunKey = KeyCode.LeftShift;

			// Token: 0x04001AE3 RID: 6883
			public float JumpForce = 30f;

			// Token: 0x04001AE4 RID: 6884
			public AnimationCurve SlopeCurveModifier = new AnimationCurve(new Keyframe[]
			{
				new Keyframe(-90f, 1f),
				new Keyframe(0f, 1f),
				new Keyframe(90f, 0f)
			});

			// Token: 0x04001AE5 RID: 6885
			[HideInInspector]
			public float CurrentTargetSpeed = 8f;

			// Token: 0x04001AE6 RID: 6886
			private bool m_Running;
		}

		// Token: 0x020003A8 RID: 936
		[Serializable]
		public class AdvancedSettings
		{
			// Token: 0x04001AE7 RID: 6887
			public float groundCheckDistance = 0.01f;

			// Token: 0x04001AE8 RID: 6888
			public float stickToGroundHelperDistance = 0.5f;

			// Token: 0x04001AE9 RID: 6889
			public float slowDownRate = 20f;

			// Token: 0x04001AEA RID: 6890
			public bool airControl;
		}
	}
}
