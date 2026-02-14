using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200042F RID: 1071
	public class CharacterThirdPerson : CharacterBase
	{
		// Token: 0x0600E716 RID: 59158 RVA: 0x0068DC18 File Offset: 0x0068BE18
		protected virtual bool CIEMJIHIJCK()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return true;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return true;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return true;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return true;
			}
			this.CHPCFGDANLA(true);
			this.NFMMKFHOCGC = Time.time + 729f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return true;
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x0068DCE0 File Offset: 0x0068BEE0
		private Vector3 HDJNPMEHCEP()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1382f, 916f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(479f, 41f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x0068DE08 File Offset: 0x0068C008
		private bool OGCJLGJKFFD()
		{
			return Time.time >= this.NFMMKFHOCGC - 744f && (Time.time > this.NFMMKFHOCGC - 850f + this.wallRunMaxLength || (this.PGDJEAJCGAO >= this.wallRunMinVelocityY && this.userControl.state.ANPGPHIAMDM.magnitude < this.wallRunMinMoveMag));
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x0068DE78 File Offset: 0x0068C078
		private Vector3 ECLLDHOIIEJ()
		{
			bool flag = this.userControl.state.ANPGPHIAMDM != Vector3.zero;
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
				{
					return Vector3.zero;
				}
				if (flag)
				{
					return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
			else
			{
				if (flag)
				{
					return this.userControl.state.ANPGPHIAMDM;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x0068DF5C File Offset: 0x0068C15C
		protected virtual void LMMDHJJJNJO()
		{
			this.animState.BJHMHPJDJIB = this.NFEOLKHFKCI();
			this.animState.JDFLHKMFHBJ = this.OCCIGGAGAFC();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 60f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void GEPPAOFJMEH()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x0068E004 File Offset: 0x0068C204
		protected virtual bool MDCFFLFEKNP()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return false;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return true;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return true;
			}
			this.BJHMHPJDJIB = false;
			this.NFMMKFHOCGC = Time.time + 820f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return false;
		}

		// Token: 0x0600E71D RID: 59165 RVA: 0x0068E0CC File Offset: 0x0068C2CC
		private void HEHIFPFALPG(Vector3 JJGHJJONFIA)
		{
			this.PFLCLLEAELB();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 279f);
			if (this.AMPBDOAELJM())
			{
				if (this.velocityToGroundTangentWeight > 1016f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 954f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.HKFLKEHPDFD() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1516f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1479f);
			if (this.AMPBDOAELJM() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 1043f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.HGMPPHMFHJP()) ? 600f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 922f);
		}

		// Token: 0x0600E71E RID: 59166 RVA: 0x0068E2A0 File Offset: 0x0068C4A0
		protected virtual void LateUpdate()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600E71F RID: 59167 RVA: 0x0068E308 File Offset: 0x0068C508
		// (set) Token: 0x0600E771 RID: 59249 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		public bool BJHMHPJDJIB { get; private set; }

		// Token: 0x0600E720 RID: 59168 RVA: 0x0068E310 File Offset: 0x0068C510
		private void NHGGADIJIED()
		{
			Vector3 b = Vector3.zero;
			this.EAMGKJANLCG = Vector3.zero;
			float llacndaelfa = 0f;
			this.CGAFKGPDBAD = this.PNELEAMKFFE();
			this.LJGHBOFJDBJ = base.transform.up;
			this.GIMHHECOIEA = Vector3.Project(this.AJMNDCHJPNK.position - this.CGAFKGPDBAD.point, base.transform.up).magnitude;
			if (Time.time > this.NFMMKFHOCGC && this.PGDJEAJCGAO < this.jumpPower * 0.5f)
			{
				bool onGround = this.BJHMHPJDJIB;
				this.BJHMHPJDJIB = false;
				float num = (!onGround) ? (this.airborneThreshold * 0.5f) : this.airborneThreshold;
				float magnitude = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1f).magnitude;
				if (this.GIMHHECOIEA < num)
				{
					llacndaelfa = this.groundStickyEffect * magnitude * num;
					if (this.CGAFKGPDBAD.rigidbody != null)
					{
						b = this.CGAFKGPDBAD.rigidbody.GetPointVelocity(this.CGAFKGPDBAD.point);
						this.EAMGKJANLCG = Vector3.Project(this.CGAFKGPDBAD.rigidbody.angularVelocity, base.transform.up);
					}
					this.BJHMHPJDJIB = true;
				}
			}
			this.MMEECKIOJOF = Vector3.Lerp(this.MMEECKIOJOF, b, Time.deltaTime * this.platformFriction);
			this.LLACNDAELFA = llacndaelfa;
			if (!this.BJHMHPJDJIB)
			{
				this.HNJEPIBOCFJ = Time.time;
			}
		}

		// Token: 0x0600E721 RID: 59169 RVA: 0x0068E4A8 File Offset: 0x0068C6A8
		private Vector3 OEODELAKAMB()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1403f, 150f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(1047f, 273f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E722 RID: 59170 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void BHDMIEBCINL()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E723 RID: 59171 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		private void JKDMPGMCCHL(bool DCCPCBLODIG)
		{
			this.<FCIBIGGGAAO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x0068E5DC File Offset: 0x0068C7DC
		protected virtual void IJLMODAICMN()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.JDJPDIIHCPL());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1.01f - Mathf.Abs(num) / 180f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E725 RID: 59173 RVA: 0x0068E6E4 File Offset: 0x0068C8E4
		protected virtual void GOAIDNCOCIB()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E726 RID: 59174 RVA: 0x0068E74C File Offset: 0x0068C94C
		private void IPCFMIBPFGC(Vector3 JJGHJJONFIA)
		{
			this.KNHNNOEFCOC();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 1728f);
			if (this.HKFLKEHPDFD())
			{
				if (this.velocityToGroundTangentWeight > 1892f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 1334f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.HKFLKEHPDFD() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1820f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1915f);
			if (this.HGMPPHMFHJP() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 791f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.HGMPPHMFHJP()) ? 1831f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 304f);
		}

		// Token: 0x0600E727 RID: 59175 RVA: 0x0068E920 File Offset: 0x0068CB20
		protected virtual void HGENHMIHDFB()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.ECLLDHOIIEJ());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (836f - Mathf.Abs(num) / 835f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E728 RID: 59176 RVA: 0x0068EA28 File Offset: 0x0068CC28
		protected virtual bool JLBHKKEAEPD()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return true;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return true;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.EBADCBKDPAN(true);
			this.NFMMKFHOCGC = Time.time + 232f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return false;
		}

		// Token: 0x0600E729 RID: 59177 RVA: 0x0068EAF0 File Offset: 0x0068CCF0
		private void CEKFGIDCBHJ()
		{
			Vector3 b = Vector3.zero;
			this.EAMGKJANLCG = Vector3.zero;
			float llacndaelfa = 1354f;
			this.CGAFKGPDBAD = this.PNELEAMKFFE();
			this.LJGHBOFJDBJ = base.transform.up;
			this.GIMHHECOIEA = Vector3.Project(this.AJMNDCHJPNK.position - this.CGAFKGPDBAD.point, base.transform.up).magnitude;
			if (Time.time > this.NFMMKFHOCGC && this.PGDJEAJCGAO < this.jumpPower * 1334f)
			{
				bool flag = this.HKFLKEHPDFD();
				this.JKDMPGMCCHL(true);
				float num = (!flag) ? (this.airborneThreshold * 1601f) : this.airborneThreshold;
				float magnitude = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1531f).magnitude;
				if (this.GIMHHECOIEA < num)
				{
					llacndaelfa = this.groundStickyEffect * magnitude * num;
					if (this.CGAFKGPDBAD.rigidbody != null)
					{
						b = this.CGAFKGPDBAD.rigidbody.GetPointVelocity(this.CGAFKGPDBAD.point);
						this.EAMGKJANLCG = Vector3.Project(this.CGAFKGPDBAD.rigidbody.angularVelocity, base.transform.up);
					}
					this.JKDMPGMCCHL(false);
				}
			}
			this.MMEECKIOJOF = Vector3.Lerp(this.MMEECKIOJOF, b, Time.deltaTime * this.platformFriction);
			this.LLACNDAELFA = llacndaelfa;
			if (!this.AMPBDOAELJM())
			{
				this.HNJEPIBOCFJ = Time.time;
			}
		}

		// Token: 0x0600E72A RID: 59178 RVA: 0x0068EC88 File Offset: 0x0068CE88
		protected virtual void DFNPFBONCBP()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.ECLLDHOIIEJ());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1594f - Mathf.Abs(num) / 1612f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E72B RID: 59179 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void MCOBJLHDIAP(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E72C RID: 59180 RVA: 0x0068EDB8 File Offset: 0x0068CFB8
		private void AEOPIOEJMKO()
		{
			this.LCDLOHFKEAE = base.ELMGJAAEJCM();
			this.BJKJIEJEMGE = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1023f);
			this.PGDJEAJCGAO = this.BJKJIEJEMGE.magnitude;
			if (Vector3.Dot(this.BJKJIEJEMGE, this.LCDLOHFKEAE) > 1131f)
			{
				this.PGDJEAJCGAO = -this.PGDJEAJCGAO;
			}
			if (this.KCLACNEILLB != null && this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal)
			{
				this.smoothPhysics = false;
				this.characterAnimation.smoothFollow = true;
			}
			this.AJMNDCHJPNK.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.None : RigidbodyInterpolation.Interpolate);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.FDHDLCIIICP(this.CPLNLHENAIG);
			this.CPLNLHENAIG = Vector3.zero;
			base.transform.rotation *= this.IJFHDCJKBDI;
			this.IJFHDCJKBDI = Quaternion.identity;
			this.PNKOKLGMEIB();
			this.IFBPBOKCNIH();
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero && this.GIMHHECOIEA < this.airborneThreshold * 568f)
			{
				base.MKKPLGICIGC();
			}
			else
			{
				base.KOGHHDLBDCJ();
			}
			if (this.gravityTarget != null)
			{
				this.AJMNDCHJPNK.useGravity = true;
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE);
			}
			if (this.AMPBDOAELJM())
			{
				this.animState.IELMDLPINAH = this.MDCFFLFEKNP();
			}
			else
			{
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE * this.gravityMultiplier);
			}
			base.BEAHCIFHCNP(this.userControl.state.MGCOIPEBMIF ? this.crouchCapsuleScaleMlp : 1714f);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E72D RID: 59181 RVA: 0x0068EF98 File Offset: 0x0068D198
		protected virtual void IAAOGAPJDID()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			if (this.KCLACNEILLB == null)
			{
				this.KCLACNEILLB = this.characterAnimation.GetComponent<Animator>();
			}
			this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			this.EBADCBKDPAN(false);
			this.animState.BJHMHPJDJIB = true;
			if (this.cam != null)
			{
				this.cam.enabled = false;
			}
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x0068F01C File Offset: 0x0068D21C
		private void IFBPBOKCNIH()
		{
			Vector3 b = Vector3.zero;
			this.EAMGKJANLCG = Vector3.zero;
			float llacndaelfa = 1856f;
			this.CGAFKGPDBAD = this.PNELEAMKFFE();
			this.LJGHBOFJDBJ = base.transform.up;
			this.GIMHHECOIEA = Vector3.Project(this.AJMNDCHJPNK.position - this.CGAFKGPDBAD.point, base.transform.up).magnitude;
			if (Time.time <= this.NFMMKFHOCGC || this.PGDJEAJCGAO < this.jumpPower * 389f)
			{
				bool flag = this.HKFLKEHPDFD();
				this.CHPCFGDANLA(false);
				float num = (!flag) ? (this.airborneThreshold * 347f) : this.airborneThreshold;
				float magnitude = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 743f).magnitude;
				if (this.GIMHHECOIEA < num)
				{
					llacndaelfa = this.groundStickyEffect * magnitude * num;
					if (this.CGAFKGPDBAD.rigidbody != null)
					{
						b = this.CGAFKGPDBAD.rigidbody.GetPointVelocity(this.CGAFKGPDBAD.point);
						this.EAMGKJANLCG = Vector3.Project(this.CGAFKGPDBAD.rigidbody.angularVelocity, base.transform.up);
					}
					this.MPMLIDAOIAL(true);
				}
			}
			this.MMEECKIOJOF = Vector3.Lerp(this.MMEECKIOJOF, b, Time.deltaTime * this.platformFriction);
			this.LLACNDAELFA = llacndaelfa;
			if (!this.HGMPPHMFHJP())
			{
				this.HNJEPIBOCFJ = Time.time;
			}
		}

		// Token: 0x0600E72F RID: 59183 RVA: 0x0068F1B4 File Offset: 0x0068D3B4
		protected virtual bool ALBNIGLBLGI()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return false;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return false;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.JKDMPGMCCHL(false);
			this.NFMMKFHOCGC = Time.time + 90f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return false;
		}

		// Token: 0x0600E730 RID: 59184 RVA: 0x0068F27C File Offset: 0x0068D47C
		protected virtual bool MGCGMBJLLKC()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return false;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return true;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return false;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.MHOJPOEOBDB(true);
			this.NFMMKFHOCGC = Time.time + 485f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return false;
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x0068F344 File Offset: 0x0068D544
		protected virtual bool NJABEOGHELP()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return true;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return false;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.MHOJPOEOBDB(false);
			this.NFMMKFHOCGC = Time.time + 244f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return true;
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x0068F40C File Offset: 0x0068D60C
		private void IOPPEGCBOCL()
		{
			bool flag = this.ICFPALJKJDJ();
			if (this.CNFCKLLPIHD > 928f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 1223f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 1636f : 28f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 97f && this.ILEOIPOOHPG > 537f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1934f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 1928f)
			{
				return;
			}
			if (this.BJHMHPJDJIB && this.PGDJEAJCGAO < 143f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1219f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1851f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.BHCCJCNDPKG() ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 1255f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 972f, 1886f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x0068F660 File Offset: 0x0068D860
		private bool DHECPOOIAAH()
		{
			return Time.time >= this.NFMMKFHOCGC - 34f && Time.time <= this.NFMMKFHOCGC - 1695f + this.wallRunMaxLength && (this.PGDJEAJCGAO < this.wallRunMinVelocityY || (this.userControl.state.ANPGPHIAMDM.magnitude < this.wallRunMinMoveMag && false));
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x0068F6D0 File Offset: 0x0068D8D0
		private Vector3 KEDABIKLNCI()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1125f, 1773f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(1496f, 1601f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E735 RID: 59189 RVA: 0x0068F7F8 File Offset: 0x0068D9F8
		private void KKEFOGMFMIA(Vector3 JJGHJJONFIA)
		{
			this.JKDPCIBGJJL();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 1441f);
			if (this.BJHMHPJDJIB)
			{
				if (this.velocityToGroundTangentWeight > 607f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 850f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.HKFLKEHPDFD() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 785f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1128f);
			if (this.HGMPPHMFHJP() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 504f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.BHCCJCNDPKG()) ? 1508f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 1424f);
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x0068F9CC File Offset: 0x0068DBCC
		private Vector3 LEFKCGJONCB()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(0f, 0f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(0f, 0f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E737 RID: 59191 RVA: 0x0068FAF4 File Offset: 0x0068DCF4
		protected virtual void CKIGGCAHAFD()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			if (this.KCLACNEILLB == null)
			{
				this.KCLACNEILLB = this.characterAnimation.GetComponent<Animator>();
			}
			this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			this.CHPCFGDANLA(false);
			this.animState.BJHMHPJDJIB = false;
			if (this.cam != null)
			{
				this.cam.enabled = false;
			}
		}

		// Token: 0x0600E738 RID: 59192 RVA: 0x0068FB78 File Offset: 0x0068DD78
		private bool FOFHMHJKKMA()
		{
			return Time.time >= this.NFMMKFHOCGC - 1941f && Time.time <= this.NFMMKFHOCGC - 1361f + this.wallRunMaxLength && (this.PGDJEAJCGAO < this.wallRunMinVelocityY || this.userControl.state.ANPGPHIAMDM.magnitude >= this.wallRunMinMoveMag);
		}

		// Token: 0x0600E739 RID: 59193 RVA: 0x0068FBE8 File Offset: 0x0068DDE8
		private void EMNIFMFINFA()
		{
			this.LCDLOHFKEAE = base.ELMGJAAEJCM();
			this.BJKJIEJEMGE = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1687f);
			this.PGDJEAJCGAO = this.BJKJIEJEMGE.magnitude;
			if (Vector3.Dot(this.BJKJIEJEMGE, this.LCDLOHFKEAE) > 1954f)
			{
				this.PGDJEAJCGAO = -this.PGDJEAJCGAO;
			}
			if (this.KCLACNEILLB != null && this.KCLACNEILLB.updateMode == AnimatorUpdateMode.AnimatePhysics)
			{
				this.smoothPhysics = false;
				this.characterAnimation.smoothFollow = false;
			}
			this.AJMNDCHJPNK.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.None : RigidbodyInterpolation.None);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.ENMDOICDPCA(this.CPLNLHENAIG);
			this.CPLNLHENAIG = Vector3.zero;
			base.transform.rotation *= this.IJFHDCJKBDI;
			this.IJFHDCJKBDI = Quaternion.identity;
			this.HGENHMIHDFB();
			this.CEKFGIDCBHJ();
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero && this.GIMHHECOIEA < this.airborneThreshold * 1308f)
			{
				base.MKKPLGICIGC();
			}
			else
			{
				base.KOGHHDLBDCJ();
			}
			if (this.gravityTarget != null)
			{
				this.AJMNDCHJPNK.useGravity = false;
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE);
			}
			if (this.NFEOLKHFKCI())
			{
				this.animState.IELMDLPINAH = this.JLBHKKEAEPD();
			}
			else
			{
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE * this.gravityMultiplier);
			}
			base.BEAHCIFHCNP(this.userControl.state.MGCOIPEBMIF ? this.crouchCapsuleScaleMlp : 1602f);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E73A RID: 59194 RVA: 0x0068FDC8 File Offset: 0x0068DFC8
		private bool HEAEHMFGFLJ()
		{
			return Time.time >= this.NFMMKFHOCGC - 542f && (Time.time > this.NFMMKFHOCGC - 919f + this.wallRunMaxLength || (this.PGDJEAJCGAO >= this.wallRunMinVelocityY && (this.userControl.state.ANPGPHIAMDM.magnitude >= this.wallRunMinMoveMag || true)));
		}

		// Token: 0x0600E73B RID: 59195 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void DPIABDPILBB()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E73C RID: 59196 RVA: 0x0068FE38 File Offset: 0x0068E038
		private bool ANGBPPJHANC()
		{
			return Time.time < this.NFMMKFHOCGC - 738f || (Time.time <= this.NFMMKFHOCGC - 641f + this.wallRunMaxLength && this.PGDJEAJCGAO >= this.wallRunMinVelocityY && this.userControl.state.ANPGPHIAMDM.magnitude < this.wallRunMinMoveMag);
		}

		// Token: 0x0600E73D RID: 59197 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void CGIDEFEOIGE()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E73E RID: 59198 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void NBMDNOGKINA()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E73F RID: 59199 RVA: 0x0068FEA8 File Offset: 0x0068E0A8
		protected virtual void DLPPPLJIGLK()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E740 RID: 59200 RVA: 0x0068FF10 File Offset: 0x0068E110
		protected virtual bool BOMCBHBMGPG()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return false;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return false;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.CHPCFGDANLA(false);
			this.NFMMKFHOCGC = Time.time + 1164f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return false;
		}

		// Token: 0x0600E741 RID: 59201 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		private void IDCKOMJADMH(bool DCCPCBLODIG)
		{
			this.<FCIBIGGGAAO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E742 RID: 59202 RVA: 0x0068FFD8 File Offset: 0x0068E1D8
		private bool ICFPALJKJDJ()
		{
			return Time.time >= this.NFMMKFHOCGC - 223f && Time.time <= this.NFMMKFHOCGC - 323f + this.wallRunMaxLength && this.PGDJEAJCGAO >= this.wallRunMinVelocityY && this.userControl.state.ANPGPHIAMDM.magnitude >= this.wallRunMinMoveMag;
		}

		// Token: 0x0600E743 RID: 59203 RVA: 0x00690048 File Offset: 0x0068E248
		private void ACPCJLEKCPM()
		{
			this.LCDLOHFKEAE = base.ELMGJAAEJCM();
			this.BJKJIEJEMGE = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 720f);
			this.PGDJEAJCGAO = this.BJKJIEJEMGE.magnitude;
			if (Vector3.Dot(this.BJKJIEJEMGE, this.LCDLOHFKEAE) > 1740f)
			{
				this.PGDJEAJCGAO = -this.PGDJEAJCGAO;
			}
			if (this.KCLACNEILLB != null && this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal)
			{
				this.smoothPhysics = true;
				this.characterAnimation.smoothFollow = false;
			}
			this.AJMNDCHJPNK.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.None : RigidbodyInterpolation.Interpolate);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.BNOGLGBBILP(this.CPLNLHENAIG);
			this.CPLNLHENAIG = Vector3.zero;
			base.transform.rotation *= this.IJFHDCJKBDI;
			this.IJFHDCJKBDI = Quaternion.identity;
			this.MOJCLEMKLPB();
			this.PHGNKKBPAIM();
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero && this.GIMHHECOIEA < this.airborneThreshold * 770f)
			{
				base.MKKPLGICIGC();
			}
			else
			{
				base.KOGHHDLBDCJ();
			}
			if (this.gravityTarget != null)
			{
				this.AJMNDCHJPNK.useGravity = true;
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE);
			}
			if (this.BHCCJCNDPKG())
			{
				this.animState.IELMDLPINAH = this.BOMCBHBMGPG();
			}
			else
			{
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE * this.gravityMultiplier);
			}
			base.BEAHCIFHCNP(this.userControl.state.MGCOIPEBMIF ? this.crouchCapsuleScaleMlp : 1930f);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E744 RID: 59204 RVA: 0x00690228 File Offset: 0x0068E428
		protected virtual void JCHBFAJDBGN()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.KOIJIKJGICK());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1136f - Mathf.Abs(num) / 701f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E745 RID: 59205 RVA: 0x00690330 File Offset: 0x0068E530
		private void DDMPNIMCOHA()
		{
			bool flag = this.KPPHKMDCACE();
			if (this.CNFCKLLPIHD > 0f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 0.5f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 1f : 0f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 0f && this.ILEOIPOOHPG > 0f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 0f)
			{
				return;
			}
			if (this.BJHMHPJDJIB && this.PGDJEAJCGAO < 0f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.BJHMHPJDJIB ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 3f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 0.017453292f, 0f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x00690584 File Offset: 0x0068E784
		private bool GFKCHMFEEJF()
		{
			return Time.time >= this.NFMMKFHOCGC - 696f && (Time.time > this.NFMMKFHOCGC - 1437f + this.wallRunMaxLength || (this.PGDJEAJCGAO >= this.wallRunMinVelocityY && this.userControl.state.ANPGPHIAMDM.magnitude >= this.wallRunMinMoveMag));
		}

		// Token: 0x0600E747 RID: 59207 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void JNIGLGKMFDO()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E748 RID: 59208 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void NADFPCBFLBB()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E749 RID: 59209 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void APPNFODHEAG()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E74A RID: 59210 RVA: 0x006905F4 File Offset: 0x0068E7F4
		private void OAJBCIJCKPB()
		{
			bool flag = this.GAMDMLMOGKK();
			if (this.CNFCKLLPIHD > 1676f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 696f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 360f : 179f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 234f && this.ILEOIPOOHPG > 1775f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1167f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 1680f)
			{
				return;
			}
			if (this.BHCCJCNDPKG() && this.PGDJEAJCGAO < 98f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1820f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 465f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.NFEOLKHFKCI() ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 1021f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 235f, 1782f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void JNENPACLMAJ(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E74C RID: 59212 RVA: 0x00690848 File Offset: 0x0068EA48
		private void EIBGPBOGMKE()
		{
			this.LCDLOHFKEAE = base.ELMGJAAEJCM();
			this.BJKJIEJEMGE = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1617f);
			this.PGDJEAJCGAO = this.BJKJIEJEMGE.magnitude;
			if (Vector3.Dot(this.BJKJIEJEMGE, this.LCDLOHFKEAE) > 138f)
			{
				this.PGDJEAJCGAO = -this.PGDJEAJCGAO;
			}
			if (this.KCLACNEILLB != null && this.KCLACNEILLB.updateMode == AnimatorUpdateMode.AnimatePhysics)
			{
				this.smoothPhysics = false;
				this.characterAnimation.smoothFollow = false;
			}
			this.AJMNDCHJPNK.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.None : RigidbodyInterpolation.Interpolate);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.ENMDOICDPCA(this.CPLNLHENAIG);
			this.CPLNLHENAIG = Vector3.zero;
			base.transform.rotation *= this.IJFHDCJKBDI;
			this.IJFHDCJKBDI = Quaternion.identity;
			this.MOJCLEMKLPB();
			this.MGGENGHIFGG();
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero && this.GIMHHECOIEA < this.airborneThreshold * 1341f)
			{
				base.MKKPLGICIGC();
			}
			else
			{
				base.KOGHHDLBDCJ();
			}
			if (this.gravityTarget != null)
			{
				this.AJMNDCHJPNK.useGravity = false;
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE);
			}
			if (this.BJHMHPJDJIB)
			{
				this.animState.IELMDLPINAH = this.CGCHPGIMDKE();
			}
			else
			{
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE * this.gravityMultiplier);
			}
			base.BEAHCIFHCNP(this.userControl.state.MGCOIPEBMIF ? this.crouchCapsuleScaleMlp : 1001f);
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0600E74D RID: 59213 RVA: 0x00690A28 File Offset: 0x0068EC28
		private Vector3 OCCIGGAGAFC()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1448f, 1607f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(1637f, 850f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x00690B50 File Offset: 0x0068ED50
		protected virtual void MDBPBJHACDA()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x00690BB8 File Offset: 0x0068EDB8
		protected virtual bool CGCHPGIMDKE()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return false;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return false;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.BJHMHPJDJIB = false;
			this.NFMMKFHOCGC = Time.time + 0.1f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return true;
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x00690C80 File Offset: 0x0068EE80
		protected virtual void JPHLMNIMDHH()
		{
			this.animState.BJHMHPJDJIB = this.NFEOLKHFKCI();
			this.animState.JDFLHKMFHBJ = this.OCCIGGAGAFC();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 35f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600E751 RID: 59217 RVA: 0x00690D0C File Offset: 0x0068EF0C
		protected virtual void AGCPGBGIHOP()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.ANKHMCCPKIO((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E752 RID: 59218 RVA: 0x00690D74 File Offset: 0x0068EF74
		private Vector3 KMAGDLGIMHD()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1512f, 1609f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(1731f, 985f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E753 RID: 59219 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void CKKABCEOIJK()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x00690E9C File Offset: 0x0068F09C
		private void FJFAAGCCMDJ()
		{
			bool flag = this.MLDNDELGANL();
			if (this.CNFCKLLPIHD > 196f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 644f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 1341f : 123f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 1720f && this.ILEOIPOOHPG > 213f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1462f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 631f)
			{
				return;
			}
			if (this.HGMPPHMFHJP() && this.PGDJEAJCGAO < 1335f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 968f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 124f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.BJHMHPJDJIB ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 129f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 1444f, 1011f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E755 RID: 59221 RVA: 0x006910F0 File Offset: 0x0068F2F0
		protected virtual void BNBNECJKAJJ()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.ECLLDHOIIEJ());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1912f - Mathf.Abs(num) / 1224f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E756 RID: 59222 RVA: 0x006911F8 File Offset: 0x0068F3F8
		private Vector3 MNKLMMKGKKK()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1623f, 1696f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(902f, 767f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E757 RID: 59223 RVA: 0x00691320 File Offset: 0x0068F520
		protected virtual void HPEMKDKDKFC()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0600E758 RID: 59224 RVA: 0x00691388 File Offset: 0x0068F588
		private void BNOGLGBBILP(Vector3 JJGHJJONFIA)
		{
			this.DDMPNIMCOHA();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 1f);
			if (this.BJHMHPJDJIB)
			{
				if (this.velocityToGroundTangentWeight > 0f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 1f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.BJHMHPJDJIB && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1f);
			if (this.BJHMHPJDJIB && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 0f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.BJHMHPJDJIB) ? 1f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 5f);
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x0069155C File Offset: 0x0068F75C
		private Vector3 OONMIKKLDHC()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(572f, 927f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(1878f, 99f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E75A RID: 59226 RVA: 0x00691684 File Offset: 0x0068F884
		private Vector3 IABPGJKGHJH()
		{
			bool flag = this.userControl.state.ANPGPHIAMDM != Vector3.zero;
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				if (moveMode != CharacterThirdPerson.MoveMode.Directional)
				{
					return Vector3.zero;
				}
				if (flag)
				{
					return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
			else
			{
				if (flag)
				{
					return this.userControl.state.ANPGPHIAMDM;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
		}

		// Token: 0x0600E75B RID: 59227 RVA: 0x00691768 File Offset: 0x0068F968
		protected virtual void PCGMJEBLBLD()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0600E75C RID: 59228 RVA: 0x006917D0 File Offset: 0x0068F9D0
		protected virtual void Update()
		{
			this.animState.BJHMHPJDJIB = this.BJHMHPJDJIB;
			this.animState.JDFLHKMFHBJ = this.LEFKCGJONCB();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 10f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600E75D RID: 59229 RVA: 0x0069185C File Offset: 0x0068FA5C
		private void JKEBNHHOELB(Vector3 JJGHJJONFIA)
		{
			this.KNHNNOEFCOC();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 1124f);
			if (this.HGMPPHMFHJP())
			{
				if (this.velocityToGroundTangentWeight > 1495f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 1486f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.HKFLKEHPDFD() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1462f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1178f);
			if (this.AMPBDOAELJM() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 584f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.HGMPPHMFHJP()) ? 1133f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 853f);
		}

		// Token: 0x0600E75E RID: 59230 RVA: 0x00691A30 File Offset: 0x0068FC30
		private bool GAMDMLMOGKK()
		{
			return Time.time < this.NFMMKFHOCGC - 1470f || Time.time > this.NFMMKFHOCGC - 1520f + this.wallRunMaxLength || this.PGDJEAJCGAO < this.wallRunMinVelocityY || this.userControl.state.ANPGPHIAMDM.magnitude >= this.wallRunMinMoveMag || true;
		}

		// Token: 0x0600E75F RID: 59231 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public override void Move(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E760 RID: 59232 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void NNPNJLKGJBF()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E761 RID: 59233 RVA: 0x00691AA0 File Offset: 0x0068FCA0
		private void AKBPDNMHECH(Vector3 JJGHJJONFIA)
		{
			this.KNHNNOEFCOC();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 1195f);
			if (this.BJHMHPJDJIB)
			{
				if (this.velocityToGroundTangentWeight > 1040f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 870f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.BHCCJCNDPKG() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 917f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 37f);
			if (this.HKFLKEHPDFD() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 1259f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.HKFLKEHPDFD()) ? 1332f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 223f);
		}

		// Token: 0x0600E762 RID: 59234 RVA: 0x00691C74 File Offset: 0x0068FE74
		private void FHOHGPMAKDJ()
		{
			Vector3 b = Vector3.zero;
			this.EAMGKJANLCG = Vector3.zero;
			float llacndaelfa = 279f;
			this.CGAFKGPDBAD = this.PNELEAMKFFE();
			this.LJGHBOFJDBJ = base.transform.up;
			this.GIMHHECOIEA = Vector3.Project(this.AJMNDCHJPNK.position - this.CGAFKGPDBAD.point, base.transform.up).magnitude;
			if (Time.time > this.NFMMKFHOCGC && this.PGDJEAJCGAO < this.jumpPower * 1673f)
			{
				bool flag = this.BHCCJCNDPKG();
				this.BJHMHPJDJIB = true;
				float num = (!flag) ? (this.airborneThreshold * 379f) : this.airborneThreshold;
				float magnitude = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1749f).magnitude;
				if (this.GIMHHECOIEA < num)
				{
					llacndaelfa = this.groundStickyEffect * magnitude * num;
					if (this.CGAFKGPDBAD.rigidbody != null)
					{
						b = this.CGAFKGPDBAD.rigidbody.GetPointVelocity(this.CGAFKGPDBAD.point);
						this.EAMGKJANLCG = Vector3.Project(this.CGAFKGPDBAD.rigidbody.angularVelocity, base.transform.up);
					}
					this.MHOJPOEOBDB(false);
				}
			}
			this.MMEECKIOJOF = Vector3.Lerp(this.MMEECKIOJOF, b, Time.deltaTime * this.platformFriction);
			this.LLACNDAELFA = llacndaelfa;
			if (!this.HKFLKEHPDFD())
			{
				this.HNJEPIBOCFJ = Time.time;
			}
		}

		// Token: 0x0600E763 RID: 59235 RVA: 0x00691E0C File Offset: 0x0069000C
		private void NKJAIIEJKBH()
		{
			this.LCDLOHFKEAE = base.ELMGJAAEJCM();
			this.BJKJIEJEMGE = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1793f);
			this.PGDJEAJCGAO = this.BJKJIEJEMGE.magnitude;
			if (Vector3.Dot(this.BJKJIEJEMGE, this.LCDLOHFKEAE) > 1635f)
			{
				this.PGDJEAJCGAO = -this.PGDJEAJCGAO;
			}
			if (this.KCLACNEILLB != null && this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal)
			{
				this.smoothPhysics = true;
				this.characterAnimation.smoothFollow = false;
			}
			this.AJMNDCHJPNK.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.None : RigidbodyInterpolation.None);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.PGEAIJCBILL(this.CPLNLHENAIG);
			this.CPLNLHENAIG = Vector3.zero;
			base.transform.rotation *= this.IJFHDCJKBDI;
			this.IJFHDCJKBDI = Quaternion.identity;
			this.EDIKBJHGOML();
			this.MGGENGHIFGG();
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero && this.GIMHHECOIEA < this.airborneThreshold * 1071f)
			{
				base.MKKPLGICIGC();
			}
			else
			{
				base.KOGHHDLBDCJ();
			}
			if (this.gravityTarget != null)
			{
				this.AJMNDCHJPNK.useGravity = false;
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE);
			}
			if (this.AMPBDOAELJM())
			{
				this.animState.IELMDLPINAH = this.JLBHKKEAEPD();
			}
			else
			{
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE * this.gravityMultiplier);
			}
			base.BEAHCIFHCNP(this.userControl.state.MGCOIPEBMIF ? this.crouchCapsuleScaleMlp : 1516f);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E764 RID: 59236 RVA: 0x00691FEC File Offset: 0x006901EC
		protected override void Start()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			if (this.KCLACNEILLB == null)
			{
				this.KCLACNEILLB = this.characterAnimation.GetComponent<Animator>();
			}
			this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			this.BJHMHPJDJIB = true;
			this.animState.BJHMHPJDJIB = true;
			if (this.cam != null)
			{
				this.cam.enabled = false;
			}
		}

		// Token: 0x0600E765 RID: 59237 RVA: 0x0068E308 File Offset: 0x0068C508
		public bool AMPBDOAELJM()
		{
			return this.<FCIBIGGGAAO>k__BackingField;
		}

		// Token: 0x0600E766 RID: 59238 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void OnAnimatorMove()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E767 RID: 59239 RVA: 0x00692070 File Offset: 0x00690270
		private Vector3 JDJPDIIHCPL()
		{
			bool flag = this.userControl.state.ANPGPHIAMDM != Vector3.zero;
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
				{
					return Vector3.zero;
				}
				if (flag)
				{
					return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
			else
			{
				if (flag)
				{
					return this.userControl.state.ANPGPHIAMDM;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
		}

		// Token: 0x0600E768 RID: 59240 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void MOPCGHIELAO(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E769 RID: 59241 RVA: 0x00692154 File Offset: 0x00690354
		protected virtual void HDGNIHBIEDG()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			if (this.KCLACNEILLB == null)
			{
				this.KCLACNEILLB = this.characterAnimation.GetComponent<Animator>();
			}
			this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			this.EBADCBKDPAN(false);
			this.animState.BJHMHPJDJIB = false;
			if (this.cam != null)
			{
				this.cam.enabled = false;
			}
		}

		// Token: 0x0600E76A RID: 59242 RVA: 0x006921D8 File Offset: 0x006903D8
		protected virtual void APHJJJHNFNP()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.CFPCGNCDJCK();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0600E76B RID: 59243 RVA: 0x00692240 File Offset: 0x00690440
		protected virtual bool MJOGEIMLHCA()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return false;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return true;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return false;
			}
			this.MPMLIDAOIAL(false);
			this.NFMMKFHOCGC = Time.time + 572f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return false;
		}

		// Token: 0x0600E76C RID: 59244 RVA: 0x00692308 File Offset: 0x00690508
		private Vector3 NHPADKHOFNI()
		{
			bool flag = this.userControl.state.ANPGPHIAMDM != Vector3.zero;
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				if (moveMode != CharacterThirdPerson.MoveMode.Directional)
				{
					return Vector3.zero;
				}
				if (flag)
				{
					return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
			else
			{
				if (flag)
				{
					return this.userControl.state.ANPGPHIAMDM;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
		}

		// Token: 0x0600E76D RID: 59245 RVA: 0x006923EC File Offset: 0x006905EC
		private void KNHNNOEFCOC()
		{
			bool flag = this.KPPHKMDCACE();
			if (this.CNFCKLLPIHD > 151f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 880f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 860f : 762f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 171f && this.ILEOIPOOHPG > 606f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 156f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 1931f)
			{
				return;
			}
			if (this.BHCCJCNDPKG() && this.PGDJEAJCGAO < 1425f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1888f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1752f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.AMPBDOAELJM() ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 1452f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 1874f, 1087f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E76E RID: 59246 RVA: 0x00692640 File Offset: 0x00690840
		protected virtual void EDIKBJHGOML()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.ECLLDHOIIEJ());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1197f - Mathf.Abs(num) / 437f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E76F RID: 59247 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void GDEGOMJLCIM(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E770 RID: 59248 RVA: 0x00692748 File Offset: 0x00690948
		private void PHGNKKBPAIM()
		{
			Vector3 b = Vector3.zero;
			this.EAMGKJANLCG = Vector3.zero;
			float llacndaelfa = 1219f;
			this.CGAFKGPDBAD = this.PNELEAMKFFE();
			this.LJGHBOFJDBJ = base.transform.up;
			this.GIMHHECOIEA = Vector3.Project(this.AJMNDCHJPNK.position - this.CGAFKGPDBAD.point, base.transform.up).magnitude;
			if (Time.time > this.NFMMKFHOCGC && this.PGDJEAJCGAO < this.jumpPower * 556f)
			{
				bool onGround = this.BJHMHPJDJIB;
				this.MPMLIDAOIAL(true);
				float num = (!onGround) ? (this.airborneThreshold * 1401f) : this.airborneThreshold;
				float magnitude = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1987f).magnitude;
				if (this.GIMHHECOIEA < num)
				{
					llacndaelfa = this.groundStickyEffect * magnitude * num;
					if (this.CGAFKGPDBAD.rigidbody != null)
					{
						b = this.CGAFKGPDBAD.rigidbody.GetPointVelocity(this.CGAFKGPDBAD.point);
						this.EAMGKJANLCG = Vector3.Project(this.CGAFKGPDBAD.rigidbody.angularVelocity, base.transform.up);
					}
					this.BJHMHPJDJIB = true;
				}
			}
			this.MMEECKIOJOF = Vector3.Lerp(this.MMEECKIOJOF, b, Time.deltaTime * this.platformFriction);
			this.LLACNDAELFA = llacndaelfa;
			if (!this.BHCCJCNDPKG())
			{
				this.HNJEPIBOCFJ = Time.time;
			}
		}

		// Token: 0x0600E772 RID: 59250 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		private void MPMLIDAOIAL(bool DCCPCBLODIG)
		{
			this.<FCIBIGGGAAO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E773 RID: 59251 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void HBBOOAHGMCM(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E774 RID: 59252 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void OLOFIGGMNFB()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E775 RID: 59253 RVA: 0x006928E0 File Offset: 0x00690AE0
		protected virtual void NMMGHFDLNOE()
		{
			this.animState.BJHMHPJDJIB = this.NFEOLKHFKCI();
			this.animState.JDFLHKMFHBJ = this.KEDABIKLNCI();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 1032f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600E776 RID: 59254 RVA: 0x0069296C File Offset: 0x00690B6C
		protected virtual void GDPMOMHBIFN()
		{
			this.animState.BJHMHPJDJIB = this.BHCCJCNDPKG();
			this.animState.JDFLHKMFHBJ = this.AIGGELLCJGC();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 1414f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600E777 RID: 59255 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void DKGDIFHEHJP(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E778 RID: 59256 RVA: 0x006929F8 File Offset: 0x00690BF8
		private bool MLDNDELGANL()
		{
			return Time.time < this.NFMMKFHOCGC - 1173f || Time.time > this.NFMMKFHOCGC - 1258f + this.wallRunMaxLength || (this.PGDJEAJCGAO >= this.wallRunMinVelocityY && this.userControl.state.ANPGPHIAMDM.magnitude < this.wallRunMinMoveMag && false);
		}

		// Token: 0x0600E779 RID: 59257 RVA: 0x00692A68 File Offset: 0x00690C68
		protected virtual void MOJCLEMKLPB()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.ECLLDHOIIEJ());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (91f - Mathf.Abs(num) / 454f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E77A RID: 59258 RVA: 0x00692B70 File Offset: 0x00690D70
		private void OKOCDCABAGI()
		{
			bool flag = this.KPPHKMDCACE();
			if (this.CNFCKLLPIHD > 1845f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 1989f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 347f : 522f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 1576f && this.ILEOIPOOHPG > 1998f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 546f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 635f)
			{
				return;
			}
			if (this.AMPBDOAELJM() && this.PGDJEAJCGAO < 88f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1592f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1038f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.NFEOLKHFKCI() ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 396f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 129f, 1059f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E77B RID: 59259 RVA: 0x00692DC4 File Offset: 0x00690FC4
		private Vector3 KOIJIKJGICK()
		{
			bool flag = this.userControl.state.ANPGPHIAMDM != Vector3.zero;
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				if (moveMode != CharacterThirdPerson.MoveMode.Strafe)
				{
					return Vector3.zero;
				}
				if (flag)
				{
					return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
			else
			{
				if (flag)
				{
					return this.userControl.state.ANPGPHIAMDM;
				}
				if (!this.lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return this.userControl.state.IGEMIODEOPE - this.AJMNDCHJPNK.position;
			}
		}

		// Token: 0x0600E77C RID: 59260 RVA: 0x00692EA8 File Offset: 0x006910A8
		protected virtual void PNKOKLGMEIB()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.ECLLDHOIIEJ());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1466f - Mathf.Abs(num) / 126f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E77D RID: 59261 RVA: 0x0068E308 File Offset: 0x0068C508
		public bool HGMPPHMFHJP()
		{
			return this.<FCIBIGGGAAO>k__BackingField;
		}

		// Token: 0x0600E77E RID: 59262 RVA: 0x00692FB0 File Offset: 0x006911B0
		private void JKDPCIBGJJL()
		{
			bool flag = this.OGCJLGJKFFD();
			if (this.CNFCKLLPIHD > 131f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 998f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 1453f : 453f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 1975f && this.ILEOIPOOHPG > 1362f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1517f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 648f)
			{
				return;
			}
			if (this.HGMPPHMFHJP() && this.PGDJEAJCGAO < 1141f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1939f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 906f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.HGMPPHMFHJP() ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 413f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 1433f, 963f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E77F RID: 59263 RVA: 0x0068DFE6 File Offset: 0x0068C1E6
		private void AKNLHCOKFFM()
		{
			this.Move(this.KCLACNEILLB.deltaPosition, this.KCLACNEILLB.deltaRotation);
		}

		// Token: 0x0600E780 RID: 59264 RVA: 0x00693204 File Offset: 0x00691404
		private void FixedUpdate()
		{
			this.LCDLOHFKEAE = base.ELMGJAAEJCM();
			this.BJKJIEJEMGE = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1f);
			this.PGDJEAJCGAO = this.BJKJIEJEMGE.magnitude;
			if (Vector3.Dot(this.BJKJIEJEMGE, this.LCDLOHFKEAE) > 0f)
			{
				this.PGDJEAJCGAO = -this.PGDJEAJCGAO;
			}
			if (this.KCLACNEILLB != null && this.KCLACNEILLB.updateMode == AnimatorUpdateMode.AnimatePhysics)
			{
				this.smoothPhysics = false;
				this.characterAnimation.smoothFollow = false;
			}
			this.AJMNDCHJPNK.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.Interpolate : RigidbodyInterpolation.None);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.BNOGLGBBILP(this.CPLNLHENAIG);
			this.CPLNLHENAIG = Vector3.zero;
			base.transform.rotation *= this.IJFHDCJKBDI;
			this.IJFHDCJKBDI = Quaternion.identity;
			this.IJLMODAICMN();
			this.NHGGADIJIED();
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero && this.GIMHHECOIEA < this.airborneThreshold * 0.5f)
			{
				base.MKKPLGICIGC();
			}
			else
			{
				base.KOGHHDLBDCJ();
			}
			if (this.gravityTarget != null)
			{
				this.AJMNDCHJPNK.useGravity = false;
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE);
			}
			if (this.BJHMHPJDJIB)
			{
				this.animState.IELMDLPINAH = this.CGCHPGIMDKE();
			}
			else
			{
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE * this.gravityMultiplier);
			}
			base.BEAHCIFHCNP(this.userControl.state.MGCOIPEBMIF ? this.crouchCapsuleScaleMlp : 1f);
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0600E781 RID: 59265 RVA: 0x006933E4 File Offset: 0x006915E4
		private void PGEAIJCBILL(Vector3 JJGHJJONFIA)
		{
			this.IOPPEGCBOCL();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 1750f);
			if (this.AMPBDOAELJM())
			{
				if (this.velocityToGroundTangentWeight > 1459f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 197f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.HGMPPHMFHJP() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1673f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1374f);
			if (this.HGMPPHMFHJP() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 181f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.HGMPPHMFHJP()) ? 277f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 1509f);
		}

		// Token: 0x0600E782 RID: 59266 RVA: 0x0068E308 File Offset: 0x0068C508
		public bool HKFLKEHPDFD()
		{
			return this.<FCIBIGGGAAO>k__BackingField;
		}

		// Token: 0x0600E783 RID: 59267 RVA: 0x006935B8 File Offset: 0x006917B8
		protected virtual bool BAJMJGMBMCC()
		{
			if (!this.userControl.state.IELMDLPINAH)
			{
				return false;
			}
			if (this.userControl.state.MGCOIPEBMIF)
			{
				return false;
			}
			if (!this.characterAnimation.DEJEBGPIADO)
			{
				return true;
			}
			if (Time.time < this.HNJEPIBOCFJ + this.jumpRepeatDelayTime)
			{
				return true;
			}
			this.EBADCBKDPAN(true);
			this.NFMMKFHOCGC = Time.time + 994f;
			Vector3 velocity = this.userControl.state.ANPGPHIAMDM * this.airSpeed;
			this.AJMNDCHJPNK.velocity = velocity;
			this.AJMNDCHJPNK.velocity += base.transform.up * this.jumpPower;
			return true;
		}

		// Token: 0x0600E784 RID: 59268 RVA: 0x0068E308 File Offset: 0x0068C508
		public bool NFEOLKHFKCI()
		{
			return this.<FCIBIGGGAAO>k__BackingField;
		}

		// Token: 0x0600E785 RID: 59269 RVA: 0x00693680 File Offset: 0x00691880
		protected virtual void PPPDNIIGGGC()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.IABPGJKGHJH());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (247f - Mathf.Abs(num) / 897f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E786 RID: 59270 RVA: 0x00693788 File Offset: 0x00691988
		private void ENMDOICDPCA(Vector3 JJGHJJONFIA)
		{
			this.KNHNNOEFCOC();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 1411f);
			if (this.NFEOLKHFKCI())
			{
				if (this.velocityToGroundTangentWeight > 1685f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 1333f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.HKFLKEHPDFD() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 206f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1349f);
			if (this.NFEOLKHFKCI() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 983f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.BJHMHPJDJIB) ? 1899f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 1038f);
		}

		// Token: 0x0600E787 RID: 59271 RVA: 0x0069395C File Offset: 0x00691B5C
		private void HDLAFHAPLHC()
		{
			this.LCDLOHFKEAE = base.ELMGJAAEJCM();
			this.BJKJIEJEMGE = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 959f);
			this.PGDJEAJCGAO = this.BJKJIEJEMGE.magnitude;
			if (Vector3.Dot(this.BJKJIEJEMGE, this.LCDLOHFKEAE) > 1930f)
			{
				this.PGDJEAJCGAO = -this.PGDJEAJCGAO;
			}
			if (this.KCLACNEILLB != null && this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal)
			{
				this.smoothPhysics = true;
				this.characterAnimation.smoothFollow = false;
			}
			this.AJMNDCHJPNK.interpolation = (this.smoothPhysics ? RigidbodyInterpolation.Interpolate : RigidbodyInterpolation.Interpolate);
			this.characterAnimation.smoothFollow = this.smoothPhysics;
			this.FDHDLCIIICP(this.CPLNLHENAIG);
			this.CPLNLHENAIG = Vector3.zero;
			base.transform.rotation *= this.IJFHDCJKBDI;
			this.IJFHDCJKBDI = Quaternion.identity;
			this.BNBNECJKAJJ();
			this.IFBPBOKCNIH();
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero && this.GIMHHECOIEA < this.airborneThreshold * 161f)
			{
				base.MKKPLGICIGC();
			}
			else
			{
				base.KOGHHDLBDCJ();
			}
			if (this.gravityTarget != null)
			{
				this.AJMNDCHJPNK.useGravity = false;
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE);
			}
			if (this.NFEOLKHFKCI())
			{
				this.animState.IELMDLPINAH = this.MGCGMBJLLKC();
			}
			else
			{
				this.AJMNDCHJPNK.AddForce(this.LCDLOHFKEAE * this.gravityMultiplier);
			}
			base.BEAHCIFHCNP(this.userControl.state.MGCOIPEBMIF ? this.crouchCapsuleScaleMlp : 603f);
			this.BLMPHOICDPK = true;
		}

		// Token: 0x0600E788 RID: 59272 RVA: 0x00693B3C File Offset: 0x00691D3C
		protected virtual void NOMFFPEGNNF()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.NHPADKHOFNI());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (691f - Mathf.Abs(num) / 1039f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E789 RID: 59273 RVA: 0x00693C44 File Offset: 0x00691E44
		private void FDHDLCIIICP(Vector3 JJGHJJONFIA)
		{
			this.DDMPNIMCOHA();
			Vector3 vector = JJGHJJONFIA / Time.deltaTime;
			vector += OOJJKBHKGNJ.BNKAEBNIMLP(this.MMEECKIOJOF, this.LCDLOHFKEAE, 339f);
			if (this.NFEOLKHFKCI())
			{
				if (this.velocityToGroundTangentWeight > 1835f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, this.LJGHBOFJDBJ);
					vector = Quaternion.Lerp(Quaternion.identity, b, this.velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = OOJJKBHKGNJ.BNKAEBNIMLP(this.userControl.state.ANPGPHIAMDM * this.airSpeed, this.LCDLOHFKEAE, 1086f);
				vector = Vector3.Lerp(this.AJMNDCHJPNK.velocity, b2, Time.deltaTime * this.airControl);
			}
			if (this.BHCCJCNDPKG() && Time.time > this.NFMMKFHOCGC)
			{
				this.AJMNDCHJPNK.velocity = this.AJMNDCHJPNK.velocity - base.transform.up * this.LLACNDAELFA * Time.deltaTime;
			}
			Vector3 vector2 = OOJJKBHKGNJ.LGBBHCACOMH(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1179f);
			Vector3 a = OOJJKBHKGNJ.BNKAEBNIMLP(vector, this.LCDLOHFKEAE, 1672f);
			if (this.HGMPPHMFHJP() && Vector3.Dot(vector2, this.LCDLOHFKEAE) < 394f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, this.maxVerticalVelocityOnGround);
			}
			this.AJMNDCHJPNK.velocity = a + vector2;
			float b3 = (!this.HKFLKEHPDFD()) ? 1757f : base.AEHHJKHJFKK(-JJGHJJONFIA / Time.deltaTime, this.LJGHBOFJDBJ);
			this.BNGCMELBADO = Mathf.Lerp(this.BNGCMELBADO, b3, Time.deltaTime * 576f);
		}

		// Token: 0x0600E78A RID: 59274 RVA: 0x00693E18 File Offset: 0x00692018
		private Vector3 AIGGELLCJGC()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1126f, 1595f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(1685f, 557f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E78B RID: 59275 RVA: 0x00693F40 File Offset: 0x00692140
		protected virtual void LMGBKHCHPHO()
		{
			this.animState.BJHMHPJDJIB = this.AMPBDOAELJM();
			this.animState.JDFLHKMFHBJ = this.OCCIGGAGAFC();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 1273f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Directional);
		}

		// Token: 0x0600E78C RID: 59276 RVA: 0x00693FCC File Offset: 0x006921CC
		private bool KPPHKMDCACE()
		{
			return Time.time >= this.NFMMKFHOCGC - 0.1f && Time.time <= this.NFMMKFHOCGC - 0.1f + this.wallRunMaxLength && this.PGDJEAJCGAO >= this.wallRunMinVelocityY && this.userControl.state.ANPGPHIAMDM.magnitude >= this.wallRunMinMoveMag;
		}

		// Token: 0x0600E78D RID: 59277 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		private void MHOJPOEOBDB(bool DCCPCBLODIG)
		{
			this.<FCIBIGGGAAO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E78E RID: 59278 RVA: 0x0069403C File Offset: 0x0069223C
		protected virtual void KPJCCEOODIN()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.IABPGJKGHJH());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1999f - Mathf.Abs(num) / 1483f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E78F RID: 59279 RVA: 0x00694144 File Offset: 0x00692344
		protected virtual void NOLKOIHEICD()
		{
			this.animState.BJHMHPJDJIB = this.BJHMHPJDJIB;
			this.animState.JDFLHKMFHBJ = this.OEODELAKAMB();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 680f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Directional);
		}

		// Token: 0x0600E790 RID: 59280 RVA: 0x006941D0 File Offset: 0x006923D0
		protected virtual void DFLBAKCDEPB()
		{
			if (this.cam == null)
			{
				return;
			}
			this.cam.UpdateInput();
			if (!this.BLMPHOICDPK && this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None)
			{
				return;
			}
			this.cam.UpdateTransform((this.AJMNDCHJPNK.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
			this.BLMPHOICDPK = false;
		}

		// Token: 0x0600E791 RID: 59281 RVA: 0x0068E308 File Offset: 0x0068C508
		public bool BHCCJCNDPKG()
		{
			return this.<FCIBIGGGAAO>k__BackingField;
		}

		// Token: 0x0600E792 RID: 59282 RVA: 0x00694238 File Offset: 0x00692438
		private void PFLCLLEAELB()
		{
			bool flag = this.GFKCHMFEEJF();
			if (this.CNFCKLLPIHD > 1193f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 655f)
			{
				flag = true;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 232f : 422f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 748f && this.ILEOIPOOHPG > 1474f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 537f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 504f)
			{
				return;
			}
			if (this.BJHMHPJDJIB && this.PGDJEAJCGAO < 954f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1671f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 908f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.BHCCJCNDPKG() ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 760f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 1891f, 1698f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x0069448C File Offset: 0x0069268C
		protected virtual void EDEODHDFANE()
		{
			this.animState.BJHMHPJDJIB = this.AMPBDOAELJM();
			this.animState.JDFLHKMFHBJ = this.LEFKCGJONCB();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 1138f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600E794 RID: 59284 RVA: 0x00694518 File Offset: 0x00692718
		protected virtual void PAKOHKKBKHD()
		{
			this.animState.BJHMHPJDJIB = this.NFEOLKHFKCI();
			this.animState.JDFLHKMFHBJ = this.GHJDAANBFOP();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 385f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Strafe);
		}

		// Token: 0x0600E795 RID: 59285 RVA: 0x006945A4 File Offset: 0x006927A4
		private bool HBHHDPLAGMA()
		{
			return Time.time >= this.NFMMKFHOCGC - 175f && (Time.time > this.NFMMKFHOCGC - 863f + this.wallRunMaxLength || this.PGDJEAJCGAO < this.wallRunMinVelocityY || this.userControl.state.ANPGPHIAMDM.magnitude >= this.wallRunMinMoveMag || true);
		}

		// Token: 0x0600E796 RID: 59286 RVA: 0x00694614 File Offset: 0x00692814
		private void LLDKOLBPPAA()
		{
			bool flag = this.HECNMBPKPJJ();
			if (this.CNFCKLLPIHD > 1740f && !flag)
			{
				this.GHPMNECLMJM = Time.time;
			}
			if (Time.time < this.GHPMNECLMJM + 1272f)
			{
				flag = false;
			}
			this.CNFCKLLPIHD = Mathf.MoveTowards(this.CNFCKLLPIHD, flag ? 1709f : 592f, Time.deltaTime * this.wallRunWeightSpeed);
			if (this.CNFCKLLPIHD <= 1953f && this.ILEOIPOOHPG > 1207f)
			{
				Vector3 forward = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 899f);
				base.transform.rotation = Quaternion.LookRotation(forward, -this.LCDLOHFKEAE);
				this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			}
			this.ILEOIPOOHPG = this.CNFCKLLPIHD;
			if (this.CNFCKLLPIHD <= 581f)
			{
				return;
			}
			if (this.AMPBDOAELJM() && this.PGDJEAJCGAO < 583f)
			{
				this.AJMNDCHJPNK.velocity = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 662f);
			}
			Vector3 vector = OOJJKBHKGNJ.BNKAEBNIMLP(base.transform.forward, this.LCDLOHFKEAE, 1318f);
			RaycastHit raycastHit = default(RaycastHit);
			raycastHit.normal = -this.LCDLOHFKEAE.normalized;
			Physics.Raycast(this.BJHMHPJDJIB ? base.transform.position : this.HJIJJCMLPDF.bounds.center, vector, out raycastHit, 1412f, this.wallRunLayers);
			this.DBFNNAOBHPL = Vector3.Lerp(this.DBFNNAOBHPL, raycastHit.normal, Time.deltaTime * this.wallRunRotationSpeed);
			this.DBFNNAOBHPL = Vector3.RotateTowards(-this.LCDLOHFKEAE.normalized, this.DBFNNAOBHPL, this.wallRunMaxRotationAngle * 1084f, 575f);
			Vector3 forward2 = base.transform.forward;
			Vector3 dbfnnaobhpl = this.DBFNNAOBHPL;
			Vector3.OrthoNormalize(ref dbfnnaobhpl, ref forward2);
			base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -this.LCDLOHFKEAE), Quaternion.LookRotation(forward2, this.DBFNNAOBHPL), this.CNFCKLLPIHD);
		}

		// Token: 0x0600E797 RID: 59287 RVA: 0x00694868 File Offset: 0x00692A68
		private bool GFEKBEKCNGK()
		{
			return Time.time >= this.NFMMKFHOCGC - 1378f && (Time.time > this.NFMMKFHOCGC - 1964f + this.wallRunMaxLength || this.PGDJEAJCGAO < this.wallRunMinVelocityY || this.userControl.state.ANPGPHIAMDM.magnitude < this.wallRunMinMoveMag);
		}

		// Token: 0x0600E798 RID: 59288 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void BMGMIMPAOPF(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E799 RID: 59289 RVA: 0x006948D8 File Offset: 0x00692AD8
		private bool HECNMBPKPJJ()
		{
			return Time.time < this.NFMMKFHOCGC - 800f || (Time.time <= this.NFMMKFHOCGC - 868f + this.wallRunMaxLength && (this.PGDJEAJCGAO < this.wallRunMinVelocityY || (this.userControl.state.ANPGPHIAMDM.magnitude < this.wallRunMinMoveMag && false)));
		}

		// Token: 0x0600E79A RID: 59290 RVA: 0x00694948 File Offset: 0x00692B48
		private void IMHAIHEBKFB()
		{
			Vector3 b = Vector3.zero;
			this.EAMGKJANLCG = Vector3.zero;
			float llacndaelfa = 1540f;
			this.CGAFKGPDBAD = this.PNELEAMKFFE();
			this.LJGHBOFJDBJ = base.transform.up;
			this.GIMHHECOIEA = Vector3.Project(this.AJMNDCHJPNK.position - this.CGAFKGPDBAD.point, base.transform.up).magnitude;
			if (Time.time > this.NFMMKFHOCGC && this.PGDJEAJCGAO < this.jumpPower * 1993f)
			{
				bool flag = this.BHCCJCNDPKG();
				this.JKDMPGMCCHL(true);
				float num = (!flag) ? (this.airborneThreshold * 1780f) : this.airborneThreshold;
				float magnitude = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1744f).magnitude;
				if (this.GIMHHECOIEA < num)
				{
					llacndaelfa = this.groundStickyEffect * magnitude * num;
					if (this.CGAFKGPDBAD.rigidbody != null)
					{
						b = this.CGAFKGPDBAD.rigidbody.GetPointVelocity(this.CGAFKGPDBAD.point);
						this.EAMGKJANLCG = Vector3.Project(this.CGAFKGPDBAD.rigidbody.angularVelocity, base.transform.up);
					}
					this.BJHMHPJDJIB = true;
				}
			}
			this.MMEECKIOJOF = Vector3.Lerp(this.MMEECKIOJOF, b, Time.deltaTime * this.platformFriction);
			this.LLACNDAELFA = llacndaelfa;
			if (!this.HGMPPHMFHJP())
			{
				this.HNJEPIBOCFJ = Time.time;
			}
		}

		// Token: 0x0600E79B RID: 59291 RVA: 0x00694AE0 File Offset: 0x00692CE0
		private void MGGENGHIFGG()
		{
			Vector3 b = Vector3.zero;
			this.EAMGKJANLCG = Vector3.zero;
			float llacndaelfa = 1982f;
			this.CGAFKGPDBAD = this.PNELEAMKFFE();
			this.LJGHBOFJDBJ = base.transform.up;
			this.GIMHHECOIEA = Vector3.Project(this.AJMNDCHJPNK.position - this.CGAFKGPDBAD.point, base.transform.up).magnitude;
			if (Time.time <= this.NFMMKFHOCGC || this.PGDJEAJCGAO < this.jumpPower * 310f)
			{
				bool flag = this.BHCCJCNDPKG();
				this.IDCKOMJADMH(true);
				float num = (!flag) ? (this.airborneThreshold * 1606f) : this.airborneThreshold;
				float magnitude = OOJJKBHKGNJ.BNKAEBNIMLP(this.AJMNDCHJPNK.velocity, this.LCDLOHFKEAE, 1864f).magnitude;
				if (this.GIMHHECOIEA < num)
				{
					llacndaelfa = this.groundStickyEffect * magnitude * num;
					if (this.CGAFKGPDBAD.rigidbody != null)
					{
						b = this.CGAFKGPDBAD.rigidbody.GetPointVelocity(this.CGAFKGPDBAD.point);
						this.EAMGKJANLCG = Vector3.Project(this.CGAFKGPDBAD.rigidbody.angularVelocity, base.transform.up);
					}
					this.BJHMHPJDJIB = true;
				}
			}
			this.MMEECKIOJOF = Vector3.Lerp(this.MMEECKIOJOF, b, Time.deltaTime * this.platformFriction);
			this.LLACNDAELFA = llacndaelfa;
			if (!this.BHCCJCNDPKG())
			{
				this.HNJEPIBOCFJ = Time.time;
			}
		}

		// Token: 0x0600E79C RID: 59292 RVA: 0x00694C78 File Offset: 0x00692E78
		protected virtual void KDDAHPGHCMA()
		{
			if (this.gravityTarget != null)
			{
				base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - this.gravityTarget.position) * base.transform.rotation;
			}
			if (this.EAMGKJANLCG != Vector3.zero)
			{
				base.transform.rotation = Quaternion.Euler(this.EAMGKJANLCG) * base.transform.rotation;
			}
			float num = base.GetAngleFromForward(this.ECLLDHOIIEJ());
			if (this.userControl.state.ANPGPHIAMDM == Vector3.zero)
			{
				num *= (1870f - Mathf.Abs(num) / 332f) * this.stationaryTurnSpeedMlp;
			}
			base.GCKIGCJNBLJ(this.characterAnimation.GetPivotPoint(), base.transform.up, num * Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600E79D RID: 59293 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		private void CHPCFGDANLA(bool DCCPCBLODIG)
		{
			this.<FCIBIGGGAAO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E79E RID: 59294 RVA: 0x00694D80 File Offset: 0x00692F80
		private Vector3 GHJDAANBFOP()
		{
			CharacterThirdPerson.MoveMode moveMode = this.moveMode;
			if (moveMode == CharacterThirdPerson.MoveMode.Directional)
			{
				this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, new Vector3(1621f, 481f, this.userControl.state.ANPGPHIAMDM.magnitude), ref this.IIJNNPEILGL, this.smoothAccelerationTime);
				this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, new Vector3(796f, 104f, this.userControl.state.ANPGPHIAMDM.magnitude), Time.deltaTime * this.linearAccelerationSpeed);
				return this.JDFLHKMFHBJ * this.BNGCMELBADO;
			}
			if (moveMode != CharacterThirdPerson.MoveMode.Directional)
			{
				return Vector3.zero;
			}
			this.JDFLHKMFHBJ = Vector3.SmoothDamp(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, ref this.IIJNNPEILGL, this.smoothAccelerationTime);
			this.JDFLHKMFHBJ = Vector3.MoveTowards(this.JDFLHKMFHBJ, this.userControl.state.ANPGPHIAMDM, Time.deltaTime * this.linearAccelerationSpeed);
			return base.transform.InverseTransformDirection(this.JDFLHKMFHBJ);
		}

		// Token: 0x0600E79F RID: 59295 RVA: 0x0068ED90 File Offset: 0x0068CF90
		public virtual void FBBAEMKMCMI(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM)
		{
			this.CPLNLHENAIG += JJGHJJONFIA;
			this.IJFHDCJKBDI *= MDAFOPGGGEM;
		}

		// Token: 0x0600E7A0 RID: 59296 RVA: 0x00694EA8 File Offset: 0x006930A8
		protected virtual void BJHGPFGBFKF()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			if (this.KCLACNEILLB == null)
			{
				this.KCLACNEILLB = this.characterAnimation.GetComponent<Animator>();
			}
			this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			this.JKDMPGMCCHL(false);
			this.animState.BJHMHPJDJIB = false;
			if (this.cam != null)
			{
				this.cam.enabled = false;
			}
		}

		// Token: 0x0600E7A1 RID: 59297 RVA: 0x00694F2C File Offset: 0x0069312C
		protected virtual void CGMHGDEKDEP()
		{
			base.Start();
			this.KCLACNEILLB = base.GetComponent<Animator>();
			if (this.KCLACNEILLB == null)
			{
				this.KCLACNEILLB = this.characterAnimation.GetComponent<Animator>();
			}
			this.DBFNNAOBHPL = -this.LCDLOHFKEAE.normalized;
			this.MHOJPOEOBDB(true);
			this.animState.BJHMHPJDJIB = true;
			if (this.cam != null)
			{
				this.cam.enabled = true;
			}
		}

		// Token: 0x0600E7A2 RID: 59298 RVA: 0x0068E5D0 File Offset: 0x0068C7D0
		private void EBADCBKDPAN(bool DCCPCBLODIG)
		{
			this.<FCIBIGGGAAO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600E7A3 RID: 59299 RVA: 0x00694FB0 File Offset: 0x006931B0
		protected virtual void KJJEEMEHGBF()
		{
			this.animState.BJHMHPJDJIB = this.BHCCJCNDPKG();
			this.animState.JDFLHKMFHBJ = this.MNKLMMKGKKK();
			this.animState.FBDMDIOLLFA = Mathf.Lerp(this.animState.FBDMDIOLLFA, this.PGDJEAJCGAO, Time.deltaTime * 885f);
			this.animState.MGCOIPEBMIF = this.userControl.state.MGCOIPEBMIF;
			this.animState.NFOBHHKGILA = (this.moveMode == CharacterThirdPerson.MoveMode.Directional);
		}

		// Token: 0x04001E38 RID: 7736
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		// Token: 0x04001E39 RID: 7737
		public UserControlThirdPerson userControl;

		// Token: 0x04001E3A RID: 7738
		public CameraController cam;

		// Token: 0x04001E3B RID: 7739
		[Header("Movement")]
		public CharacterThirdPerson.MoveMode moveMode;

		// Token: 0x04001E3C RID: 7740
		public bool smoothPhysics = true;

		// Token: 0x04001E3D RID: 7741
		public float smoothAccelerationTime = 0.2f;

		// Token: 0x04001E3E RID: 7742
		public float linearAccelerationSpeed = 3f;

		// Token: 0x04001E3F RID: 7743
		public float platformFriction = 7f;

		// Token: 0x04001E40 RID: 7744
		public float groundStickyEffect = 4f;

		// Token: 0x04001E41 RID: 7745
		public float maxVerticalVelocityOnGround = 3f;

		// Token: 0x04001E42 RID: 7746
		public float velocityToGroundTangentWeight;

		// Token: 0x04001E43 RID: 7747
		[Header("Rotation")]
		public bool lookInCameraDirection;

		// Token: 0x04001E44 RID: 7748
		public float turnSpeed = 5f;

		// Token: 0x04001E45 RID: 7749
		public float stationaryTurnSpeedMlp = 1f;

		// Token: 0x04001E46 RID: 7750
		[Header("Jumping and Falling")]
		public float airSpeed = 6f;

		// Token: 0x04001E47 RID: 7751
		public float airControl = 2f;

		// Token: 0x04001E48 RID: 7752
		public float jumpPower = 12f;

		// Token: 0x04001E49 RID: 7753
		public float jumpRepeatDelayTime;

		// Token: 0x04001E4A RID: 7754
		[SerializeField]
		[Header("Wall Running")]
		private LayerMask wallRunLayers;

		// Token: 0x04001E4B RID: 7755
		public float wallRunMaxLength = 1f;

		// Token: 0x04001E4C RID: 7756
		public float wallRunMinMoveMag = 0.6f;

		// Token: 0x04001E4D RID: 7757
		public float wallRunMinVelocityY = -1f;

		// Token: 0x04001E4E RID: 7758
		public float wallRunRotationSpeed = 1.5f;

		// Token: 0x04001E4F RID: 7759
		public float wallRunMaxRotationAngle = 70f;

		// Token: 0x04001E50 RID: 7760
		public float wallRunWeightSpeed = 5f;

		// Token: 0x04001E51 RID: 7761
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp = 0.6f;

		// Token: 0x04001E53 RID: 7763
		public CharacterThirdPerson.CBNHECDPFGD animState;

		// Token: 0x04001E54 RID: 7764
		protected Vector3 JDFLHKMFHBJ;

		// Token: 0x04001E55 RID: 7765
		private Animator KCLACNEILLB;

		// Token: 0x04001E56 RID: 7766
		private Vector3 LJGHBOFJDBJ;

		// Token: 0x04001E57 RID: 7767
		private Vector3 MMEECKIOJOF;

		// Token: 0x04001E58 RID: 7768
		private Vector3 EAMGKJANLCG;

		// Token: 0x04001E59 RID: 7769
		private RaycastHit CGAFKGPDBAD;

		// Token: 0x04001E5A RID: 7770
		private float EDEIAFFLGEE;

		// Token: 0x04001E5B RID: 7771
		private float NFMMKFHOCGC;

		// Token: 0x04001E5C RID: 7772
		private float BNGCMELBADO;

		// Token: 0x04001E5D RID: 7773
		private float GIMHHECOIEA;

		// Token: 0x04001E5E RID: 7774
		private float HNJEPIBOCFJ;

		// Token: 0x04001E5F RID: 7775
		private float LLACNDAELFA;

		// Token: 0x04001E60 RID: 7776
		private Vector3 DBFNNAOBHPL = Vector3.up;

		// Token: 0x04001E61 RID: 7777
		private Vector3 IIJNNPEILGL;

		// Token: 0x04001E62 RID: 7778
		private float CNFCKLLPIHD;

		// Token: 0x04001E63 RID: 7779
		private float ILEOIPOOHPG;

		// Token: 0x04001E64 RID: 7780
		private Vector3 CPLNLHENAIG;

		// Token: 0x04001E65 RID: 7781
		private Quaternion IJFHDCJKBDI;

		// Token: 0x04001E66 RID: 7782
		private bool BLMPHOICDPK;

		// Token: 0x04001E67 RID: 7783
		private float GHPMNECLMJM;

		// Token: 0x04001E68 RID: 7784
		private Vector3 LCDLOHFKEAE;

		// Token: 0x04001E69 RID: 7785
		private Vector3 BJKJIEJEMGE;

		// Token: 0x04001E6A RID: 7786
		private float PGDJEAJCGAO;

		// Token: 0x02000430 RID: 1072
		[Serializable]
		public enum MoveMode
		{
			// Token: 0x04001E6C RID: 7788
			Directional,
			// Token: 0x04001E6D RID: 7789
			Strafe
		}

		// Token: 0x02000431 RID: 1073
		public struct CBNHECDPFGD
		{
			// Token: 0x04001E6E RID: 7790
			public Vector3 JDFLHKMFHBJ;

			// Token: 0x04001E6F RID: 7791
			public bool IELMDLPINAH;

			// Token: 0x04001E70 RID: 7792
			public bool MGCOIPEBMIF;

			// Token: 0x04001E71 RID: 7793
			public bool BJHMHPJDJIB;

			// Token: 0x04001E72 RID: 7794
			public bool NFOBHHKGILA;

			// Token: 0x04001E73 RID: 7795
			public float FBDMDIOLLFA;
		}
	}
}
