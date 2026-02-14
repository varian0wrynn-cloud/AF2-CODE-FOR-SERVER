using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000453 RID: 1107
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		// Token: 0x0600EF3D RID: 61245 RVA: 0x006B74F8 File Offset: 0x006B56F8
		public bool LDHEMGKJLBN(ref string BGLNFEHPENB)
		{
			if (BipedReferences.NHKPNDBILCF(this.references, ref BGLNFEHPENB))
			{
				return false;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 1262f)
			{
				BGLNFEHPENB = "VolumetricFogAndMist/CopyDepth";
				return true;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1939f)
			{
				BGLNFEHPENB = "OnRodChangeClck toorder=";
				return true;
			}
			return true;
		}

		// Token: 0x0600EF3E RID: 61246 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600EF3F RID: 61247 RVA: 0x006B75F4 File Offset: 0x006B57F4
		private void BKOJKLCMMEO()
		{
			this.SetReferences(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF40 RID: 61248 RVA: 0x006B760D File Offset: 0x006B580D
		private void BBCMGGIIOII()
		{
			Application.OpenURL("Boxed");
		}

		// Token: 0x0600EF41 RID: 61249 RVA: 0x006B7619 File Offset: 0x006B5819
		protected virtual void FCLBIKJAOFP()
		{
			Application.OpenURL("---");
		}

		// Token: 0x0600EF42 RID: 61250 RVA: 0x006B7625 File Offset: 0x006B5825
		protected virtual void ICFACKFHDOP()
		{
			Application.OpenURL("#a0d0a0");
		}

		// Token: 0x0600EF43 RID: 61251 RVA: 0x006B7631 File Offset: 0x006B5831
		public void JEMMDAKFGPL(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.GLMPANINIPF(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EF44 RID: 61252 RVA: 0x006B764C File Offset: 0x006B584C
		private void ANOKGOBIGMB()
		{
			this.references = new BipedReferences();
			BipedReferences.DGEFPDHMNDH(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(false, false));
			this.solver.rootNode = IKSolverFullBodyBiped.NFJOLIHNHCO(this.references);
			this.solver.GLMPANINIPF(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF45 RID: 61253 RVA: 0x006B76B0 File Offset: 0x006B58B0
		public bool EMPNDBBOKFP(ref string BGLNFEHPENB)
		{
			if (BipedReferences.JAFMGGEHGGA(this.references, ref BGLNFEHPENB))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 1138f)
			{
				BGLNFEHPENB = "Sound #";
				return false;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 235f)
			{
				BGLNFEHPENB = "null";
				return false;
			}
			return false;
		}

		// Token: 0x0600EF46 RID: 61254 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver MOMLABJMNBM()
		{
			return this.solver;
		}

		// Token: 0x0600EF47 RID: 61255 RVA: 0x006B77B4 File Offset: 0x006B59B4
		private void JCDLADHFDFN()
		{
			this.references = new BipedReferences();
			BipedReferences.LICOAIPNLFE(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(true, false));
			this.solver.rootNode = IKSolverFullBodyBiped.CMAFBCAEDKN(this.references);
			this.solver.NBOFHKJNIIJ(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF48 RID: 61256 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver KDOJOMAEFCJ()
		{
			return this.solver;
		}

		// Token: 0x0600EF49 RID: 61257 RVA: 0x006B7817 File Offset: 0x006B5A17
		private void NBAOMLCPMPL()
		{
			this.FINJHEGOKJI(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF4A RID: 61258 RVA: 0x006B7830 File Offset: 0x006B5A30
		protected virtual void DOILOPFLLPB()
		{
			Application.OpenURL("[baitid]");
		}

		// Token: 0x0600EF4B RID: 61259 RVA: 0x006B783C File Offset: 0x006B5A3C
		private void JHKFHGPJCHL()
		{
			this.references = new BipedReferences();
			BipedReferences.LICOAIPNLFE(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(false, true));
			this.solver.rootNode = IKSolverFullBodyBiped.NFJOLIHNHCO(this.references);
			this.solver.GLMPANINIPF(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF4C RID: 61260 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver EOCLLOKMEAL()
		{
			return this.solver;
		}

		// Token: 0x0600EF4D RID: 61261 RVA: 0x006B789F File Offset: 0x006B5A9F
		public void CBNJCFIJEGM(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.LHIFOKBEMMG(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EF4E RID: 61262 RVA: 0x006B78BA File Offset: 0x006B5ABA
		private void JOJMECCFEOL()
		{
			Application.OpenURL("IdleFeedThrow");
		}

		// Token: 0x0600EF4F RID: 61263 RVA: 0x006B78C8 File Offset: 0x006B5AC8
		public bool HLFNIFNJJCI(ref string BGLNFEHPENB)
		{
			if (BipedReferences.HCMCHKMCLMD(this.references, ref BGLNFEHPENB))
			{
				return false;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 454f)
			{
				BGLNFEHPENB = "\n";
				return false;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1090f)
			{
				BGLNFEHPENB = "Mouse Y";
				return true;
			}
			return false;
		}

		// Token: 0x0600EF50 RID: 61264 RVA: 0x006AA69F File Offset: 0x006A889F
		private void PCOHLGIMNEB()
		{
			Application.OpenURL("error");
		}

		// Token: 0x0600EF51 RID: 61265 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver CKMABIBIGOG()
		{
			return this.solver;
		}

		// Token: 0x0600EF52 RID: 61266 RVA: 0x006B79C4 File Offset: 0x006B5BC4
		private void BJPLDFEPEIM()
		{
			Application.OpenURL("_FinalBlendParameters");
		}

		// Token: 0x0600EF53 RID: 61267 RVA: 0x006B79D0 File Offset: 0x006B5BD0
		private void NMNNGMCNGLM()
		{
			this.references = new BipedReferences();
			BipedReferences.IBAJIPDAJND(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(false, false));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.LHIFOKBEMMG(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF54 RID: 61268 RVA: 0x006B7A33 File Offset: 0x006B5C33
		private void AOHNKMBDLMD()
		{
			Application.OpenURL("-");
		}

		// Token: 0x0600EF55 RID: 61269 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver AACFHEOPCAC()
		{
			return this.solver;
		}

		// Token: 0x0600EF56 RID: 61270 RVA: 0x006B7A40 File Offset: 0x006B5C40
		public bool KBJCEEPODCA(ref string BGLNFEHPENB)
		{
			if (BipedReferences.NHKPNDBILCF(this.references, ref BGLNFEHPENB))
			{
				return false;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 1886f)
			{
				BGLNFEHPENB = "_LerpRgbTex";
				return false;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1225f)
			{
				BGLNFEHPENB = "FOG_SCATTERING_ON";
				return true;
			}
			return true;
		}

		// Token: 0x0600EF57 RID: 61271 RVA: 0x006B7B3C File Offset: 0x006B5D3C
		private void HJFBADBCPDA()
		{
			this.references = new BipedReferences();
			BipedReferences.HEGFACJFFFF(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(true, true));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.LHIFOKBEMMG(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF58 RID: 61272 RVA: 0x006B7BA0 File Offset: 0x006B5DA0
		private void AKLKFONNNBK()
		{
			this.references = new BipedReferences();
			BipedReferences.IBAJIPDAJND(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(true, true));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.PGMOOFECKGC(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF59 RID: 61273 RVA: 0x006B7C03 File Offset: 0x006B5E03
		private void JLNFNAEIOLC()
		{
			Application.OpenURL("crft_from");
		}

		// Token: 0x0600EF5A RID: 61274 RVA: 0x006B7C10 File Offset: 0x006B5E10
		public bool PACCBFCNPJJ(ref string CLDHEEJDHNK)
		{
			if (BipedReferences.KICGCCHLNGM(this.references, ref CLDHEEJDHNK))
			{
				return true;
			}
			if (this.references.spine.Length == 0)
			{
				CLDHEEJDHNK = ", ";
				return false;
			}
			if (this.solver.rootNode == null)
			{
				CLDHEEJDHNK = "MotorbikeBackwardStand";
				return true;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = false;
				for (int i = 0; i < this.references.spine.Length; i += 0)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					CLDHEEJDHNK = "wgt_gr";
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EF5B RID: 61275 RVA: 0x006B7CC8 File Offset: 0x006B5EC8
		public bool ReferencesError(ref string CLDHEEJDHNK)
		{
			if (BipedReferences.CKILGDFJBCP(this.references, ref CLDHEEJDHNK))
			{
				return true;
			}
			if (this.references.spine.Length == 0)
			{
				CLDHEEJDHNK = "References has no spine bones assigned, can not initiate the solver.";
				return true;
			}
			if (this.solver.rootNode == null)
			{
				CLDHEEJDHNK = "Root Node bone is null, can not initiate the solver.";
				return true;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = false;
				for (int i = 0; i < this.references.spine.Length; i++)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					CLDHEEJDHNK = "The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver.";
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600EF5C RID: 61276 RVA: 0x006B7D80 File Offset: 0x006B5F80
		public bool MLEGFGAECMB(ref string BGLNFEHPENB)
		{
			if (BipedReferences.LEKPFMEHAJO(this.references, ref BGLNFEHPENB))
			{
				return false;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 743f)
			{
				BGLNFEHPENB = "KatanaReadyHigh";
				return true;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1448f)
			{
				BGLNFEHPENB = "{0:dd/MM/yyyy в HH:mm}";
				return false;
			}
			return true;
		}

		// Token: 0x0600EF5D RID: 61277 RVA: 0x006B7E7C File Offset: 0x006B607C
		public bool CJDCOLJAOEN(ref string BGLNFEHPENB)
		{
			if (BipedReferences.LEKPFMEHAJO(this.references, ref BGLNFEHPENB))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 191f)
			{
				BGLNFEHPENB = "BowIdle";
				return true;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1757f)
			{
				BGLNFEHPENB = "MotorbikeSpecialFlip";
				return true;
			}
			return true;
		}

		// Token: 0x0600EF5E RID: 61278 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver IEKKDEKDJKB()
		{
			return this.solver;
		}

		// Token: 0x0600EF5F RID: 61279 RVA: 0x006B7F78 File Offset: 0x006B6178
		public bool ReferencesWarning(ref string BGLNFEHPENB)
		{
			if (BipedReferences.DPPLIPOHAOF(this.references, ref BGLNFEHPENB))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 0.95f)
			{
				BGLNFEHPENB = "The root node, the left upper arm and the right upper arm bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left upper arm and the right upper arm bones. This might cause unwanted behaviour like the spine turning upside down when pulled by a hand effector.Please set the root node bone to be one of the lower bones in the spine.";
				return true;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 0.95f)
			{
				BGLNFEHPENB = "The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.";
				return true;
			}
			return false;
		}

		// Token: 0x0600EF60 RID: 61280 RVA: 0x006B8074 File Offset: 0x006B6274
		protected virtual void HNJDJKMFENE()
		{
			Application.OpenURL("gi_letgoshe");
		}

		// Token: 0x0600EF61 RID: 61281 RVA: 0x006A561C File Offset: 0x006A381C
		private void AKODODMPKDD()
		{
			Application.OpenURL("Flares");
		}

		// Token: 0x0600EF62 RID: 61282 RVA: 0x0032BF3E File Offset: 0x0032A13E
		protected virtual void NOCAKEKEBJL()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600EF63 RID: 61283 RVA: 0x006B8080 File Offset: 0x006B6280
		private void LPDFEHHKHIN()
		{
			this.references = new BipedReferences();
			BipedReferences.LICOAIPNLFE(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(false, true));
			this.solver.rootNode = IKSolverFullBodyBiped.CMAFBCAEDKN(this.references);
			this.solver.PGMOOFECKGC(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF64 RID: 61284 RVA: 0x006B80E4 File Offset: 0x006B62E4
		private void GJODFKAPHBC()
		{
			this.references = new BipedReferences();
			BipedReferences.HEGFACJFFFF(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(false, true));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.GLMPANINIPF(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF65 RID: 61285 RVA: 0x006B8147 File Offset: 0x006B6347
		private void ECMICNJHBLM()
		{
			this.FFDJMMHLDFN(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF66 RID: 61286 RVA: 0x006B8160 File Offset: 0x006B6360
		protected virtual void IEOIDIPBNAO()
		{
			Application.OpenURL("[userfish]");
		}

		// Token: 0x0600EF67 RID: 61287 RVA: 0x006B816C File Offset: 0x006B636C
		private void KMENBLJLDLC()
		{
			Application.OpenURL("HYPERLINK");
		}

		// Token: 0x0600EF68 RID: 61288 RVA: 0x006B8178 File Offset: 0x006B6378
		private void FIGIKMFMJNO()
		{
			Application.OpenURL("{x}");
		}

		// Token: 0x0600EF69 RID: 61289 RVA: 0x006B8184 File Offset: 0x006B6384
		protected virtual void HIHJCGPJCKB()
		{
			Application.OpenURL("cht_msg20");
		}

		// Token: 0x0600EF6A RID: 61290 RVA: 0x006B8190 File Offset: 0x006B6390
		public void HCKEJAKLHCJ(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.NBOFHKJNIIJ(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EF6B RID: 61291 RVA: 0x006B81AB File Offset: 0x006B63AB
		private void KNAFBEGJDGH()
		{
			Application.OpenURL("wpn_iwgt");
		}

		// Token: 0x0600EF6C RID: 61292 RVA: 0x006B81B8 File Offset: 0x006B63B8
		private void KPIKKFENINN()
		{
			this.references = new BipedReferences();
			BipedReferences.DGEFPDHMNDH(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(true, true));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.LHIFOKBEMMG(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF6D RID: 61293 RVA: 0x006B821B File Offset: 0x006B641B
		private void JACPEFAOKEJ()
		{
			this.CBNJCFIJEGM(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF6E RID: 61294 RVA: 0x006B8234 File Offset: 0x006B6434
		private void IMIBKHCFNNA()
		{
			this.references = new BipedReferences();
			BipedReferences.DGEFPDHMNDH(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(true, false));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.LHIFOKBEMMG(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF6F RID: 61295 RVA: 0x006B8297 File Offset: 0x006B6497
		private void EIBFMCPMBMJ()
		{
			this.HCKEJAKLHCJ(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF70 RID: 61296 RVA: 0x006B7631 File Offset: 0x006B5831
		public void FFDJMMHLDFN(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.GLMPANINIPF(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EF72 RID: 61298 RVA: 0x006B82D0 File Offset: 0x006B64D0
		private void PCLPIMIHLFK()
		{
			this.references = new BipedReferences();
			BipedReferences.LICOAIPNLFE(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(false, false));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.NBOFHKJNIIJ(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF73 RID: 61299 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver BOBPADFKHGF()
		{
			return this.solver;
		}

		// Token: 0x0600EF74 RID: 61300 RVA: 0x006B8334 File Offset: 0x006B6534
		public bool DEBOPPLNMFI(ref string BGLNFEHPENB)
		{
			if (BipedReferences.LEKPFMEHAJO(this.references, ref BGLNFEHPENB))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 1798f)
			{
				BGLNFEHPENB = "_FogParams";
				return false;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 597f)
			{
				BGLNFEHPENB = " ";
				return true;
			}
			return true;
		}

		// Token: 0x0600EF75 RID: 61301 RVA: 0x006B73DF File Offset: 0x006B55DF
		private void LKDGMLKLMLF()
		{
			Application.OpenURL("_name");
		}

		// Token: 0x0600EF76 RID: 61302 RVA: 0x006B8430 File Offset: 0x006B6630
		private void MGJBFNCLBDA()
		{
			Application.OpenURL("WeaponStand");
		}

		// Token: 0x0600EF77 RID: 61303 RVA: 0x006B843C File Offset: 0x006B663C
		private void MLAONAKMCLA()
		{
			Application.OpenURL("  ");
		}

		// Token: 0x0600EF78 RID: 61304 RVA: 0x006B8147 File Offset: 0x006B6347
		private void JKICFBDGFFE()
		{
			this.FFDJMMHLDFN(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF79 RID: 61305 RVA: 0x006B8448 File Offset: 0x006B6648
		protected virtual void CJGBDODJCDK()
		{
			Application.OpenURL("wpn_fid2");
		}

		// Token: 0x0600EF7A RID: 61306 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver GIBEBBLFNFF()
		{
			return this.solver;
		}

		// Token: 0x0600EF7B RID: 61307 RVA: 0x006B8454 File Offset: 0x006B6654
		private void NEHPMHFGANL()
		{
			Application.OpenURL("_camHue");
		}

		// Token: 0x0600EF7C RID: 61308 RVA: 0x006B8460 File Offset: 0x006B6660
		public bool IOAFMKFCAEN(ref string CLDHEEJDHNK)
		{
			if (BipedReferences.CKILGDFJBCP(this.references, ref CLDHEEJDHNK))
			{
				return true;
			}
			if (this.references.spine.Length == 0)
			{
				CLDHEEJDHNK = "maxdeep";
				return false;
			}
			if (this.solver.rootNode == null)
			{
				CLDHEEJDHNK = "_name";
				return true;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = true;
				for (int i = 1; i < this.references.spine.Length; i++)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					CLDHEEJDHNK = "collar";
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600EF7D RID: 61309 RVA: 0x006B8517 File Offset: 0x006B6717
		private void CLKMDHGEKPG()
		{
			Application.OpenURL("S");
		}

		// Token: 0x0600EF7E RID: 61310 RVA: 0x006B8524 File Offset: 0x006B6724
		public bool DMHIJGECHJG(ref string CLDHEEJDHNK)
		{
			if (BipedReferences.FCKBJGPDMKK(this.references, ref CLDHEEJDHNK))
			{
				return true;
			}
			if (this.references.spine.Length == 0)
			{
				CLDHEEJDHNK = "CheerKnees";
				return false;
			}
			if (this.solver.rootNode == null)
			{
				CLDHEEJDHNK = "_Histogram";
				return true;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = true;
				for (int i = 1; i < this.references.spine.Length; i += 0)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					CLDHEEJDHNK = "OfficeSitting1LegStraight";
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EF7F RID: 61311 RVA: 0x006B85DB File Offset: 0x006B67DB
		private void LHGHHPLGPEF()
		{
			Application.OpenURL("Wizard 2 Hand Throw");
		}

		// Token: 0x0600EF80 RID: 61312 RVA: 0x006B85E8 File Offset: 0x006B67E8
		public bool PKDHKNPNJNI(ref string CLDHEEJDHNK)
		{
			if (BipedReferences.KICGCCHLNGM(this.references, ref CLDHEEJDHNK))
			{
				return true;
			}
			if (this.references.spine.Length == 0)
			{
				CLDHEEJDHNK = "BowReady";
				return true;
			}
			if (this.solver.rootNode == null)
			{
				CLDHEEJDHNK = "PlayerPrefs:";
				return false;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = false;
				for (int i = 1; i < this.references.spine.Length; i++)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					CLDHEEJDHNK = "textAsset is NULL! Path: Weapons";
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EF81 RID: 61313 RVA: 0x006B869F File Offset: 0x006B689F
		protected virtual void BLEKNHMEDJF()
		{
			Application.OpenURL("wpn_cat4");
		}

		// Token: 0x0600EF82 RID: 61314 RVA: 0x006B86AB File Offset: 0x006B68AB
		protected virtual void BONLOKHJKKB()
		{
			Application.OpenURL("FireBreath");
		}

		// Token: 0x0600EF83 RID: 61315 RVA: 0x006B86B7 File Offset: 0x006B68B7
		private void JODJNJCCMKJ()
		{
			Application.OpenURL("wpn_drop");
		}

		// Token: 0x0600EF84 RID: 61316 RVA: 0x006B86C3 File Offset: 0x006B68C3
		private void BBNDKLOFBAE()
		{
			Application.OpenURL("DealerIdle");
		}

		// Token: 0x0600EF85 RID: 61317 RVA: 0x006A50F9 File Offset: 0x006A32F9
		private void IOBJCIAHPNG()
		{
			Application.OpenURL("Idle Keep Back");
		}

		// Token: 0x0600EF86 RID: 61318 RVA: 0x006AE47B File Offset: 0x006AC67B
		private void DDFNNFGCHGK()
		{
			Application.OpenURL("wpn_add/base");
		}

		// Token: 0x0600EF87 RID: 61319 RVA: 0x006AA450 File Offset: 0x006A8650
		private void GCNICIOAHFD()
		{
			Application.OpenURL("FaceHit");
		}

		// Token: 0x0600EF88 RID: 61320 RVA: 0x006B86CF File Offset: 0x006B68CF
		private void FAFJGKNFFNF()
		{
			Application.OpenURL("_DistAmount");
		}

		// Token: 0x0600EF89 RID: 61321 RVA: 0x006B86DC File Offset: 0x006B68DC
		public bool CCBOLELGHKI(ref string CLDHEEJDHNK)
		{
			if (BipedReferences.CKILGDFJBCP(this.references, ref CLDHEEJDHNK))
			{
				return false;
			}
			if (this.references.spine.Length == 0)
			{
				CLDHEEJDHNK = "error.wav";
				return false;
			}
			if (this.solver.rootNode == null)
			{
				CLDHEEJDHNK = "wpn_cat4";
				return false;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = true;
				for (int i = 1; i < this.references.spine.Length; i += 0)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					CLDHEEJDHNK = "********* End INSTANIATE Level  instLevelTime=";
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600EF8A RID: 61322 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver KCIKDBHHGLK()
		{
			return this.solver;
		}

		// Token: 0x0600EF8B RID: 61323 RVA: 0x006B8793 File Offset: 0x006B6993
		protected virtual void HKAMOEDOGJH()
		{
			Application.OpenURL("_QualitySettings");
		}

		// Token: 0x0600EF8C RID: 61324 RVA: 0x006B879F File Offset: 0x006B699F
		private void PJBAACJIBJG()
		{
			Application.OpenURL("WeaponRunBackward");
		}

		// Token: 0x0600EF8D RID: 61325 RVA: 0x006B87AB File Offset: 0x006B69AB
		private void PCEBNCHOIDM()
		{
			Application.OpenURL("ScatterDitherData");
		}

		// Token: 0x0600EF8E RID: 61326 RVA: 0x006B87B7 File Offset: 0x006B69B7
		private void AOAFNGEHIFN()
		{
			Application.OpenURL("Assembly-CSharp-firstpass");
		}

		// Token: 0x0600EF8F RID: 61327 RVA: 0x006B87C4 File Offset: 0x006B69C4
		public bool CPFEHBGHEIG(ref string CLDHEEJDHNK)
		{
			if (BipedReferences.CKILGDFJBCP(this.references, ref CLDHEEJDHNK))
			{
				return true;
			}
			if (this.references.spine.Length == 0)
			{
				CLDHEEJDHNK = "FlyForward";
				return true;
			}
			if (this.solver.rootNode == null)
			{
				CLDHEEJDHNK = "ClimbRight";
				return true;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = false;
				for (int i = 0; i < this.references.spine.Length; i++)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					CLDHEEJDHNK = "Wood Cut";
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600EF90 RID: 61328 RVA: 0x0032C255 File Offset: 0x0032A455
		private void EBKDDGPPPGG()
		{
			Application.OpenURL("\n");
		}

		// Token: 0x0600EF91 RID: 61329 RVA: 0x006B887B File Offset: 0x006B6A7B
		protected override void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page6.html");
		}

		// Token: 0x0600EF92 RID: 61330 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver DIDJKDMBIJO()
		{
			return this.solver;
		}

		// Token: 0x0600EF93 RID: 61331 RVA: 0x006B8888 File Offset: 0x006B6A88
		public bool HDAGDJODACA(ref string BGLNFEHPENB)
		{
			if (BipedReferences.NHKPNDBILCF(this.references, ref BGLNFEHPENB))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 1505f)
			{
				BGLNFEHPENB = "isWoman";
				return true;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1192f)
			{
				BGLNFEHPENB = "SoccerPassHeavy";
				return true;
			}
			return false;
		}

		// Token: 0x0600EF94 RID: 61332 RVA: 0x006B8984 File Offset: 0x006B6B84
		public void FINJHEGOKJI(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.PGMOOFECKGC(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EF95 RID: 61333 RVA: 0x006B6F6D File Offset: 0x006B516D
		protected virtual void LAOFAIEKFGE()
		{
			Application.OpenURL("u_UniqueShadowLightWidth");
		}

		// Token: 0x0600EF96 RID: 61334 RVA: 0x006B899F File Offset: 0x006B6B9F
		protected virtual void HCDBIHPOLIB()
		{
			Application.OpenURL("BipedReferences spine bone at index ");
		}

		// Token: 0x0600EF97 RID: 61335 RVA: 0x006B89AB File Offset: 0x006B6BAB
		private void IOGPDOBKNNA()
		{
			Application.OpenURL("RussianDance");
		}

		// Token: 0x0600EF98 RID: 61336 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void FEHDIPIHBDN()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600EF99 RID: 61337 RVA: 0x006B89B7 File Offset: 0x006B6BB7
		protected virtual void AOOPGMEHBHD()
		{
			Application.OpenURL("Horizontal");
		}

		// Token: 0x0600EF9A RID: 61338 RVA: 0x006B8190 File Offset: 0x006B6390
		public void ANDNALDNOHG(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.NBOFHKJNIIJ(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EF9B RID: 61339 RVA: 0x006B89C3 File Offset: 0x006B6BC3
		private void KKHLENNEPAI()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=tgRMsTphjJo");
		}

		// Token: 0x0600EF9C RID: 61340 RVA: 0x006B89CF File Offset: 0x006B6BCF
		private void KEJNODCHNJK()
		{
			this.CJGDDEAIJOJ(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF9D RID: 61341 RVA: 0x006B89E8 File Offset: 0x006B6BE8
		public bool JFEAEONEBEK(ref string BGLNFEHPENB)
		{
			if (BipedReferences.DPPLIPOHAOF(this.references, ref BGLNFEHPENB))
			{
				return false;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 507f)
			{
				BGLNFEHPENB = "Yawn";
				return false;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 774f)
			{
				BGLNFEHPENB = "startA";
				return false;
			}
			return false;
		}

		// Token: 0x0600EF9E RID: 61342 RVA: 0x006B8297 File Offset: 0x006B6497
		private void ELLNCPENKOO()
		{
			this.HCKEJAKLHCJ(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EF9F RID: 61343 RVA: 0x006B8AE4 File Offset: 0x006B6CE4
		private void IBAJIPDAJND()
		{
			this.references = new BipedReferences();
			BipedReferences.IBAJIPDAJND(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(true, false));
			this.solver.rootNode = IKSolverFullBodyBiped.IJLOECPOEGH(this.references);
			this.solver.NBOFHKJNIIJ(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x006B8B47 File Offset: 0x006B6D47
		protected virtual void LFBJPFALGOB()
		{
			Application.OpenURL("LEFT");
		}

		// Token: 0x0600EFA1 RID: 61345 RVA: 0x006B8B53 File Offset: 0x006B6D53
		protected virtual void MIBOIINAIPD()
		{
			Application.OpenURL("OneHandSwordReady");
		}

		// Token: 0x0600EFA2 RID: 61346 RVA: 0x006B7190 File Offset: 0x006B5390
		private void DOAJGIBJMHI()
		{
			Application.OpenURL("360SpinDeath");
		}

		// Token: 0x0600EFA3 RID: 61347 RVA: 0x006B789F File Offset: 0x006B5A9F
		public void CJGDDEAIJOJ(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.LHIFOKBEMMG(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EFA4 RID: 61348 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver FCFLFBPEMCO()
		{
			return this.solver;
		}

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x006B8B5F File Offset: 0x006B6D5F
		private void LMENMPAOPCG()
		{
			Application.OpenURL("2000");
		}

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver BOBOJJCPJPB()
		{
			return this.solver;
		}

		// Token: 0x0600EFA7 RID: 61351 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600EFA8 RID: 61352 RVA: 0x006B8B6C File Offset: 0x006B6D6C
		public bool ACEIBOLGMBM(ref string BGLNFEHPENB)
		{
			if (BipedReferences.JAFMGGEHGGA(this.references, ref BGLNFEHPENB))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 1905f)
			{
				BGLNFEHPENB = "Loser";
				return true;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1363f)
			{
				BGLNFEHPENB = "1HSwordStrafeRunLeft";
				return false;
			}
			return true;
		}

		// Token: 0x0600EFA9 RID: 61353 RVA: 0x006991BC File Offset: 0x006973BC
		private void PFKNJBGMLDD()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600EFAA RID: 61354 RVA: 0x006B6E62 File Offset: 0x006B5062
		protected virtual void KBLLNAHHLLJ()
		{
			Application.OpenURL("+ACVolumeProxy");
		}

		// Token: 0x0600EFAB RID: 61355 RVA: 0x006B8C68 File Offset: 0x006B6E68
		protected override void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html");
		}

		// Token: 0x0600EFAC RID: 61356 RVA: 0x006AD8EA File Offset: 0x006ABAEA
		private void PMGPOCPMMNB()
		{
			Application.OpenURL("The space size '");
		}

		// Token: 0x0600EFAD RID: 61357 RVA: 0x006B8C74 File Offset: 0x006B6E74
		private void JGBCJMIBKLG()
		{
			Application.OpenURL("_TrStartYou.ogg");
		}

		// Token: 0x0600EFAE RID: 61358 RVA: 0x006B8C80 File Offset: 0x006B6E80
		public bool PBENCJINOGN(ref string BGLNFEHPENB)
		{
			if (BipedReferences.JAFMGGEHGGA(this.references, ref BGLNFEHPENB))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 508f)
			{
				BGLNFEHPENB = "knopje.wav";
				return false;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 1336f)
			{
				BGLNFEHPENB = "";
				return false;
			}
			return true;
		}

		// Token: 0x0600EFAF RID: 61359 RVA: 0x006B78BA File Offset: 0x006B5ABA
		protected virtual void GLNJIGOLCFC()
		{
			Application.OpenURL("IdleFeedThrow");
		}

		// Token: 0x0600EFB0 RID: 61360 RVA: 0x006B8D7C File Offset: 0x006B6F7C
		private void OCEJJENJLCO()
		{
			Application.OpenURL("u_pass");
		}

		// Token: 0x0600EFB1 RID: 61361 RVA: 0x006B8D88 File Offset: 0x006B6F88
		private void NPAGDGOBLGE()
		{
			Application.OpenURL("RodParams not found!");
		}

		// Token: 0x0600EFB2 RID: 61362 RVA: 0x006B8D94 File Offset: 0x006B6F94
		private void GCCBFEAHBOD()
		{
			Application.OpenURL("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'");
		}

		// Token: 0x0600EFB3 RID: 61363 RVA: 0x006AE47B File Offset: 0x006AC67B
		private void HNIDHBNCPKN()
		{
			Application.OpenURL("wpn_add/base");
		}

		// Token: 0x0600EFB4 RID: 61364 RVA: 0x006B8DA0 File Offset: 0x006B6FA0
		public bool KGJKMEHAHFL(ref string BGLNFEHPENB)
		{
			if (BipedReferences.JAFMGGEHGGA(this.references, ref BGLNFEHPENB))
			{
				return false;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 598f)
			{
				BGLNFEHPENB = "1 Hand Sword Jab";
				return false;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 754f)
			{
				BGLNFEHPENB = "TOD_SunSkyColor";
				return true;
			}
			return true;
		}

		// Token: 0x0600EFB5 RID: 61365 RVA: 0x006B77AC File Offset: 0x006B59AC
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x0600EFB6 RID: 61366 RVA: 0x006B75F4 File Offset: 0x006B57F4
		private void AACGGOGLMAB()
		{
			this.SetReferences(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EFB7 RID: 61367 RVA: 0x006B8190 File Offset: 0x006B6390
		public void SetReferences(BipedReferences LJPKBBNNOIC, Transform KAOKEJPBAHM)
		{
			this.references = LJPKBBNNOIC;
			this.solver.NBOFHKJNIIJ(this.references, KAOKEJPBAHM);
		}

		// Token: 0x0600EFB8 RID: 61368 RVA: 0x006B6D8A File Offset: 0x006B4F8A
		private void ICOHNKDOEEF()
		{
			Application.OpenURL("Vertical");
		}

		// Token: 0x0600EFB9 RID: 61369 RVA: 0x006B7817 File Offset: 0x006B5A17
		private void KNMDLIBPPEO()
		{
			this.FINJHEGOKJI(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EFBA RID: 61370 RVA: 0x006B8E9C File Offset: 0x006B709C
		protected virtual void NHNNOGDKJBI()
		{
			Application.OpenURL("gi_fs_itm");
		}

		// Token: 0x0600EFBB RID: 61371 RVA: 0x006B8EA8 File Offset: 0x006B70A8
		private void LCJLNINPIIL()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=7__IafZGwvI");
		}

		// Token: 0x0600EFBC RID: 61372 RVA: 0x006B8EB4 File Offset: 0x006B70B4
		protected virtual void PFCIPAAIBNN()
		{
			Application.OpenURL("_Radius");
		}

		// Token: 0x0600EFBD RID: 61373 RVA: 0x006B8EC0 File Offset: 0x006B70C0
		private void MHLBCDNAOFH()
		{
			Application.OpenURL("_WrinkleOcclusionMap0");
		}

		// Token: 0x0600EFBE RID: 61374 RVA: 0x006AE47B File Offset: 0x006AC67B
		private void GFKLCOJJHPH()
		{
			Application.OpenURL("wpn_add/base");
		}

		// Token: 0x0600EFBF RID: 61375 RVA: 0x006B8ECC File Offset: 0x006B70CC
		private void DEJCHABEPGO()
		{
			Application.OpenURL("root");
		}

		// Token: 0x0600EFC0 RID: 61376 RVA: 0x006B8ED8 File Offset: 0x006B70D8
		private void HMGMNIFHDJG()
		{
			this.references = new BipedReferences();
			BipedReferences.LICOAIPNLFE(ref this.references, base.transform, new BipedReferences.DOBIPAPLIMK(false, false));
			this.solver.rootNode = IKSolverFullBodyBiped.IBKIHIJCIEN(this.references);
			this.solver.GLMPANINIPF(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EFC1 RID: 61377 RVA: 0x006B75F4 File Offset: 0x006B57F4
		private void KMNGJLLNHLN()
		{
			this.SetReferences(this.references, this.solver.rootNode);
		}

		// Token: 0x0600EFC2 RID: 61378 RVA: 0x006B77AC File Offset: 0x006B59AC
		public virtual IKSolver FKBJACCMGGE()
		{
			return this.solver;
		}

		// Token: 0x04001F3E RID: 7998
		public BipedReferences references = new BipedReferences();

		// Token: 0x04001F3F RID: 7999
		public IKSolverFullBodyBiped solver = new IKSolverFullBodyBiped();
	}
}
