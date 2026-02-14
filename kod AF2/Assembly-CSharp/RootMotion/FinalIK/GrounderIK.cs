using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000448 RID: 1096
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		// Token: 0x0600EC18 RID: 60440 RVA: 0x006ABE1C File Offset: 0x006AA01C
		private void IACODJJLLCF()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1367f)
			{
				if (this.PIJKOMKCJOG <= 1273f)
				{
					return;
				}
				this.DNBMNPKDPHC();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.JLFBDOPFDDJ();
			for (int i = 1; i < this.legs.Length; i++)
			{
				this.EBGLPMANMCM(i);
			}
			this.pelvis.position += this.solver.pelvis.NLAAJNKCEIF() * this.weight;
			this.EELIKFPDJEL = false;
			this.OAGKPEANNBF = 0;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC19 RID: 60441 RVA: 0x006ABF30 File Offset: 0x006AA130
		private void PNBGJBMJLFM()
		{
			this.weight = Mathf.Clamp(this.weight, 1827f, 1234f);
			if (this.weight <= 477f)
			{
				return;
			}
			this.EELIKFPDJEL = true;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 129f, 1433f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 783f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 462f && this.rootRotationWeight > 1668f)
				{
					Vector3 vector = this.solver.EJLKJMGFBBB();
					if (this.rootRotationWeight < 1957f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.BEEPEPKDIBD())
			{
				return;
			}
			this.MCPNEMBJHAM();
		}

		// Token: 0x0600EC1A RID: 60442 RVA: 0x006A67EA File Offset: 0x006A49EA
		protected override void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		// Token: 0x0600EC1B RID: 60443 RVA: 0x006AC098 File Offset: 0x006AA298
		private bool AFOGJOJHJFF()
		{
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.legs.Length == 0)
			{
				return true;
			}
			foreach (IK ik in this.legs)
			{
				if (ik == null)
				{
					return false;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("Pick Up Ball");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("SUNSHINE_FILTER_PCF_2x2");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("******* Actor fish destroy");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EC1C RID: 60444 RVA: 0x006AC124 File Offset: 0x006AA324
		protected virtual void JHKKELKCIFM()
		{
			Application.OpenURL("_BlurDistance");
		}

		// Token: 0x0600EC1D RID: 60445 RVA: 0x006AC130 File Offset: 0x006AA330
		private bool FCFHCENCBKO()
		{
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			foreach (IK ik in this.legs)
			{
				if (ik == null)
				{
					return false;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("Failed parsing scalePlacement.  Setting to \"Fixed\"");
					return true;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("invn_ver3");
					return true;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("IdleStrafeRight");
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600EC1E RID: 60446 RVA: 0x006AC1BC File Offset: 0x006AA3BC
		private bool ACJOKJHPKMN()
		{
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			IK[] array = this.legs;
			for (int i = 1; i < array.Length; i += 0)
			{
				IK ik = array[i];
				if (ik == null)
				{
					return false;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("chan_nam");
					return true;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("\n");
					return true;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("****************** CamEffector APPLY 0");
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600EC1F RID: 60447 RVA: 0x006AC248 File Offset: 0x006AA448
		protected virtual void JJPFEPNFOPB()
		{
			Application.OpenURL("_FogSkyData");
		}

		// Token: 0x0600EC20 RID: 60448 RVA: 0x006AC254 File Offset: 0x006AA454
		private void BHALELINNDJ()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 0; j < this.legs.Length; j++)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 1].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.BHALELINNDJ(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC21 RID: 60449 RVA: 0x006AC378 File Offset: 0x006AA578
		private void BOAJJAKEMLH()
		{
			this.weight = Mathf.Clamp(this.weight, 1599f, 212f);
			if (this.weight <= 1033f)
			{
				return;
			}
			this.EELIKFPDJEL = true;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 1557f, 1352f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 1383f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 1596f && this.rootRotationWeight > 1741f)
				{
					Vector3 vector = this.solver.DIGCAKKACPA();
					if (this.rootRotationWeight < 1591f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.CHNAGGHGPMO())
			{
				return;
			}
			this.MCPNEMBJHAM();
		}

		// Token: 0x0600EC22 RID: 60450 RVA: 0x006AC4DD File Offset: 0x006AA6DD
		protected override void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_i_k.html");
		}

		// Token: 0x0600EC23 RID: 60451 RVA: 0x006AC4EC File Offset: 0x006AA6EC
		private void GFDJOJGACCF()
		{
			if (this.weight <= 948f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].CJFGACCPDEH(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
		}

		// Token: 0x0600EC24 RID: 60452 RVA: 0x006AC594 File Offset: 0x006AA794
		private void KMLNBHIIGKH()
		{
			this.weight = Mathf.Clamp(this.weight, 785f, 239f);
			if (this.weight <= 808f)
			{
				return;
			}
			this.EELIKFPDJEL = false;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 1076f, 932f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 341f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 1935f && this.rootRotationWeight > 311f)
				{
					Vector3 vector = this.solver.MAEFPPBLLPI();
					if (this.rootRotationWeight < 1323f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.CHNAGGHGPMO())
			{
				return;
			}
			this.CPLOFPNBFEH();
		}

		// Token: 0x0600EC25 RID: 60453 RVA: 0x006AC6FC File Offset: 0x006AA8FC
		private void EBGLPMANMCM(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.BGCPOHLJIDN()[CLBPBJGLHEE].CGAMODJNLAC;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC26 RID: 60454 RVA: 0x006AC760 File Offset: 0x006AA960
		private void KJKFJMGALPP()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 461f)
			{
				if (this.PIJKOMKCJOG <= 693f)
				{
					return;
				}
				this.MKBPPPJKLLF();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.FANPFKHEDPA();
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				this.JDHFAPFACJK(i);
			}
			this.pelvis.position += this.solver.pelvis.CEBNENIONKK() * this.weight;
			this.EELIKFPDJEL = false;
			this.OAGKPEANNBF = 0;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC27 RID: 60455 RVA: 0x006AC874 File Offset: 0x006AAA74
		private void DNBMNPKDPHC()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i++)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 1711f;
				}
			}
		}

		// Token: 0x0600EC28 RID: 60456 RVA: 0x006AC8C4 File Offset: 0x006AAAC4
		private void LLBOJHDHADO()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 144f)
			{
				if (this.PIJKOMKCJOG <= 1116f)
				{
					return;
				}
				this.KLHDJKDMCJN();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.NFPFDOEENLA();
			for (int i = 0; i < this.legs.Length; i++)
			{
				this.JDHFAPFACJK(i);
			}
			this.pelvis.position += this.solver.DLIDADHGILM().KPLDCDCLKLC() * this.weight;
			this.EELIKFPDJEL = false;
			this.OAGKPEANNBF = 0;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC29 RID: 60457 RVA: 0x006AC9D8 File Offset: 0x006AABD8
		private void PCKDLBDCKAJ()
		{
			if (this.weight <= 1931f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.BGCPOHLJIDN()[i].PMMFCIFLLMD(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
		}

		// Token: 0x0600EC2A RID: 60458 RVA: 0x006ACA80 File Offset: 0x006AAC80
		private void MKBPPPJKLLF()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i++)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 1270f;
				}
			}
		}

		// Token: 0x0600EC2B RID: 60459 RVA: 0x006ACAD0 File Offset: 0x006AACD0
		private void NIOMOLMCNOO()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i++)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 757f;
				}
			}
		}

		// Token: 0x0600EC2C RID: 60460 RVA: 0x006ACB20 File Offset: 0x006AAD20
		private void MCPNEMBJHAM()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 1; j < this.legs.Length; j += 0)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 0].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.DLNCBJIIBAL(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC2D RID: 60461 RVA: 0x006ACC44 File Offset: 0x006AAE44
		private void PDDALPHGOKK(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.legs[CLBPBJGLHEE].CGAMODJNLAC;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC2E RID: 60462 RVA: 0x006ACCA8 File Offset: 0x006AAEA8
		private void PNAPPHLKMIG()
		{
			if (this.EOFDOPLDFCG)
			{
				IK[] array = this.legs;
				for (int i = 1; i < array.Length; i++)
				{
					IK ik = array[i];
					if (ik != null)
					{
						IKSolver iksolver = ik.GetIKSolver();
						iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.LLBOJHDHADO));
						IKSolver iksolver2 = ik.GetIKSolver();
						iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PJIJDNCBFKE));
					}
				}
			}
		}

		// Token: 0x0600EC2F RID: 60463 RVA: 0x006ACD2D File Offset: 0x006AAF2D
		protected virtual void JGOGFMBKEEG()
		{
			Application.OpenURL("Katana Horizontal Swing");
		}

		// Token: 0x0600EC30 RID: 60464 RVA: 0x006ACD39 File Offset: 0x006AAF39
		public virtual void GDDFOFHKCMD()
		{
			this.solver.EGADMJMBCCK();
		}

		// Token: 0x0600EC31 RID: 60465 RVA: 0x006ACD48 File Offset: 0x006AAF48
		private bool AELGDILJNAF()
		{
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			foreach (IK ik in this.legs)
			{
				if (ik == null)
				{
					return false;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EC32 RID: 60466 RVA: 0x006ACDD4 File Offset: 0x006AAFD4
		private void OnDisable()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 0; i < this.legs.Length; i++)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 0f;
				}
			}
		}

		// Token: 0x0600EC33 RID: 60467 RVA: 0x006ACE24 File Offset: 0x006AB024
		private void PGIHAIPCJLL()
		{
			this.weight = Mathf.Clamp(this.weight, 1157f, 452f);
			if (this.weight <= 199f)
			{
				return;
			}
			this.EELIKFPDJEL = true;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 1575f, 1915f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 232f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 1967f && this.rootRotationWeight > 1681f)
				{
					Vector3 vector = this.solver.EABAHMCEAJC();
					if (this.rootRotationWeight < 1695f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.ANHNNPAPOOB())
			{
				return;
			}
			this.BHALELINNDJ();
		}

		// Token: 0x0600EC35 RID: 60469 RVA: 0x006ACFC0 File Offset: 0x006AB1C0
		private void EMHGNEMIGII()
		{
			this.weight = Mathf.Clamp(this.weight, 896f, 1950f);
			if (this.weight <= 1263f)
			{
				return;
			}
			this.EELIKFPDJEL = true;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 793f, 1905f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 911f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 193f && this.rootRotationWeight > 964f)
				{
					Vector3 vector = this.solver.AKNDJIMKFNP();
					if (this.rootRotationWeight < 1854f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.ACJOKJHPKMN())
			{
				return;
			}
			this.FJFJNFHKMHJ();
		}

		// Token: 0x0600EC36 RID: 60470 RVA: 0x006AD128 File Offset: 0x006AB328
		private void KFNKMBJNNMH()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].JNHPAAAFGKC, this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
		}

		// Token: 0x0600EC37 RID: 60471 RVA: 0x006AD1D0 File Offset: 0x006AB3D0
		private bool ANHNNPAPOOB()
		{
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.legs.Length == 0)
			{
				return true;
			}
			IK[] array = this.legs;
			for (int i = 1; i < array.Length; i += 0)
			{
				IK ik = array[i];
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("1");
					return true;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("ENABLE_DITHERING");
					return true;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("LHandPunch");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EC38 RID: 60472 RVA: 0x006AD25C File Offset: 0x006AB45C
		public virtual void FIAOMGBLKOA()
		{
			this.solver.Reset();
		}

		// Token: 0x0600EC39 RID: 60473 RVA: 0x006AD26C File Offset: 0x006AB46C
		private void CALFOKBIBIG()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 1373f;
				}
			}
		}

		// Token: 0x0600EC3A RID: 60474 RVA: 0x006AD2BC File Offset: 0x006AB4BC
		private bool FNHPNBICNEI()
		{
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			IK[] array = this.legs;
			for (int i = 1; i < array.Length; i++)
			{
				IK ik = array[i];
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("Roll");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("\n");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("Idle Spew");
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600EC3B RID: 60475 RVA: 0x006AD348 File Offset: 0x006AB548
		private void OnDestroy()
		{
			if (this.EOFDOPLDFCG)
			{
				foreach (IK ik in this.legs)
				{
					if (ik != null)
					{
						IKSolver iksolver = ik.GetIKSolver();
						iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
						IKSolver iksolver2 = ik.GetIKSolver();
						iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
					}
				}
			}
		}

		// Token: 0x0600EC3C RID: 60476 RVA: 0x006AD3D0 File Offset: 0x006AB5D0
		private void CPLOFPNBFEH()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 0; j < this.legs.Length; j++)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 0].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KJKFJMGALPP));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DNCAHAFOEJM));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.CAAINGFBNHG(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC3D RID: 60477 RVA: 0x006AD4F4 File Offset: 0x006AB6F4
		private void PJIJDNCBFKE()
		{
			if (this.weight <= 161f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.MMPFHLEJIOI()[i].JNHPAAAFGKC, this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
		}

		// Token: 0x0600EC3E RID: 60478 RVA: 0x006AD59C File Offset: 0x006AB79C
		private void IICFAPMJLCN()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i++)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 165f;
				}
			}
		}

		// Token: 0x0600EC3F RID: 60479 RVA: 0x006AD5EC File Offset: 0x006AB7EC
		private bool PCDPIDIKJGO()
		{
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			foreach (IK ik in this.legs)
			{
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("SoccerStartKick");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("Zombie Idle");
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600EC40 RID: 60480 RVA: 0x006AD678 File Offset: 0x006AB878
		protected virtual void APAIONNLDIC()
		{
			Application.OpenURL("gi_cachshe");
		}

		// Token: 0x0600EC41 RID: 60481 RVA: 0x006AD684 File Offset: 0x006AB884
		private void IDEMEGMGEGG(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.BJLLBFABCBL()[CLBPBJGLHEE].NDGGJPEHKBC();
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC42 RID: 60482 RVA: 0x006AD6E8 File Offset: 0x006AB8E8
		private bool BEEPEPKDIBD()
		{
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.legs.Length == 0)
			{
				return true;
			}
			IK[] array = this.legs;
			for (int i = 1; i < array.Length; i++)
			{
				IK ik = array[i];
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("id");
					return true;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("chnam3");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("BowReady2");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EC43 RID: 60483 RVA: 0x006AD774 File Offset: 0x006AB974
		private bool OFIKIPPJDNB()
		{
			if (this.pelvis == null)
			{
				return true;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			IK[] array = this.legs;
			for (int i = 0; i < array.Length; i += 0)
			{
				IK ik = array[i];
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("crft_to");
					return true;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("ArmFlex3");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EC44 RID: 60484 RVA: 0x006AD800 File Offset: 0x006ABA00
		private void CABMDBPACPO()
		{
			if (this.EOFDOPLDFCG)
			{
				IK[] array = this.legs;
				for (int i = 1; i < array.Length; i += 0)
				{
					IK ik = array[i];
					if (ik != null)
					{
						IKSolver iksolver = ik.GetIKSolver();
						iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.LLBOJHDHADO));
						IKSolver iksolver2 = ik.GetIKSolver();
						iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
					}
				}
			}
		}

		// Token: 0x0600EC45 RID: 60485 RVA: 0x006AD888 File Offset: 0x006ABA88
		private void PBEKELDBMLI(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.BJLLBFABCBL()[CLBPBJGLHEE].CGAMODJNLAC;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC46 RID: 60486 RVA: 0x006AD8EA File Offset: 0x006ABAEA
		protected virtual void INMADNOMBGJ()
		{
			Application.OpenURL("The space size '");
		}

		// Token: 0x0600EC47 RID: 60487 RVA: 0x006AD8F8 File Offset: 0x006ABAF8
		private void MLFAABAPOHI()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 1; j < this.legs.Length; j += 0)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 1].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.DJIOPPMHBBA));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PJIJDNCBFKE));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.BHALELINNDJ(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC48 RID: 60488 RVA: 0x006ADA1C File Offset: 0x006ABC1C
		private void OGJNLKMJBNA()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 480f)
			{
				if (this.PIJKOMKCJOG <= 376f)
				{
					return;
				}
				this.OnDisable();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.FANPFKHEDPA();
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				this.JDHFAPFACJK(i);
			}
			this.pelvis.position += this.solver.JKCAIBBPEHP().NLAAJNKCEIF() * this.weight;
			this.EELIKFPDJEL = true;
			this.OAGKPEANNBF = 1;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC49 RID: 60489 RVA: 0x006ADB30 File Offset: 0x006ABD30
		private void JDHFAPFACJK(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.BGCPOHLJIDN()[CLBPBJGLHEE].AGKMPPLKBDJ();
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC4A RID: 60490 RVA: 0x006ADB94 File Offset: 0x006ABD94
		private void ODMIGNCLMKI()
		{
			if (this.EOFDOPLDFCG)
			{
				foreach (IK ik in this.legs)
				{
					if (ik != null)
					{
						IKSolver iksolver = ik.GetIKSolver();
						iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.IACODJJLLCF));
						IKSolver iksolver2 = ik.GetIKSolver();
						iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DNCAHAFOEJM));
					}
				}
			}
		}

		// Token: 0x0600EC4B RID: 60491 RVA: 0x006ADC1C File Offset: 0x006ABE1C
		private void KLHDJKDMCJN()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 423f;
				}
			}
		}

		// Token: 0x0600EC4C RID: 60492 RVA: 0x006ACD39 File Offset: 0x006AAF39
		public virtual void CELAGKECDED()
		{
			this.solver.EGADMJMBCCK();
		}

		// Token: 0x0600EC4D RID: 60493 RVA: 0x006ADC6C File Offset: 0x006ABE6C
		private void NBLOGHHADNE()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 340f)
			{
				if (this.PIJKOMKCJOG <= 1867f)
				{
					return;
				}
				this.IICFAPMJLCN();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.JLFBDOPFDDJ();
			for (int i = 0; i < this.legs.Length; i += 0)
			{
				this.IDEMEGMGEGG(i);
			}
			this.pelvis.position += this.solver.DLIDADHGILM().PEKMJMNKKPE() * this.weight;
			this.EELIKFPDJEL = false;
			this.OAGKPEANNBF = 1;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC4E RID: 60494 RVA: 0x006ADD7E File Offset: 0x006ABF7E
		public virtual void BIMJEANFMDA()
		{
			this.solver.AOGCKHNAOCI();
		}

		// Token: 0x0600EC4F RID: 60495 RVA: 0x006ADD8C File Offset: 0x006ABF8C
		private void FOBBCFADGKP()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 1; j < this.legs.Length; j++)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 1].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.DJIOPPMHBBA));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JBPNPCGIDOP));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.CAAINGFBNHG(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC50 RID: 60496 RVA: 0x0032C255 File Offset: 0x0032A455
		protected virtual void OELLEPLHAPI()
		{
			Application.OpenURL("\n");
		}

		// Token: 0x0600EC51 RID: 60497 RVA: 0x006ADEB0 File Offset: 0x006AC0B0
		private void BEDAJLJFAFO()
		{
			this.weight = Mathf.Clamp(this.weight, 293f, 1592f);
			if (this.weight <= 1267f)
			{
				return;
			}
			this.EELIKFPDJEL = true;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 889f, 1112f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 885f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 1580f && this.rootRotationWeight > 562f)
				{
					Vector3 vector = this.solver.MAEFPPBLLPI();
					if (this.rootRotationWeight < 1153f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.BEEPEPKDIBD())
			{
				return;
			}
			this.BHALELINNDJ();
		}

		// Token: 0x0600EC52 RID: 60498 RVA: 0x006AD25C File Offset: 0x006AB45C
		public override void ResetPosition()
		{
			this.solver.Reset();
		}

		// Token: 0x0600EC53 RID: 60499 RVA: 0x0032C255 File Offset: 0x0032A455
		protected virtual void BPOKNKANPLD()
		{
			Application.OpenURL("\n");
		}

		// Token: 0x0600EC54 RID: 60500 RVA: 0x006AE018 File Offset: 0x006AC218
		private void JBPNPCGIDOP()
		{
			if (this.weight <= 1343f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.BJLLBFABCBL()[i].BHPMHHGJHME(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
		}

		// Token: 0x0600EC55 RID: 60501 RVA: 0x006AE0C0 File Offset: 0x006AC2C0
		private bool BIJOAOLJMJL()
		{
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			foreach (IK ik in this.legs)
			{
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("_EmissionColor");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("file:///");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("colorC");
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600EC56 RID: 60502 RVA: 0x006AE14C File Offset: 0x006AC34C
		public virtual void GGFJIAMPKJI()
		{
			this.solver.MIFKCBJPDDI();
		}

		// Token: 0x0600EC57 RID: 60503 RVA: 0x006AE15C File Offset: 0x006AC35C
		private void MIPHMELJJJD()
		{
			if (this.EOFDOPLDFCG)
			{
				foreach (IK ik in this.legs)
				{
					if (ik != null)
					{
						IKSolver iksolver = ik.GetIKSolver();
						iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KJKFJMGALPP));
						IKSolver iksolver2 = ik.GetIKSolver();
						iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DNCAHAFOEJM));
					}
				}
			}
		}

		// Token: 0x0600EC58 RID: 60504 RVA: 0x006AE1E4 File Offset: 0x006AC3E4
		private void PHIACAJNNIG()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i++)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 1912f;
				}
			}
		}

		// Token: 0x0600EC59 RID: 60505 RVA: 0x006AE234 File Offset: 0x006AC434
		protected virtual void FCLBIKJAOFP()
		{
			Application.OpenURL("fshop_hd4");
		}

		// Token: 0x0600EC5A RID: 60506 RVA: 0x006AE240 File Offset: 0x006AC440
		private void KNCAKAJHFJB(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.legs[CLBPBJGLHEE].IEACGFIGBEE();
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC5B RID: 60507 RVA: 0x006AE2A4 File Offset: 0x006AC4A4
		private void FJFJNFHKMHJ()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 0; j < this.legs.Length; j++)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 1].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.LLBOJHDHADO));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PJIJDNCBFKE));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.CAAINGFBNHG(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC5C RID: 60508 RVA: 0x006AE3C8 File Offset: 0x006AC5C8
		private void DNCAHAFOEJM()
		{
			if (this.weight <= 401f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.LFDJHHNIIMK()[i].HNPADDHKIAM(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
		}

		// Token: 0x0600EC5D RID: 60509 RVA: 0x006AE14C File Offset: 0x006AC34C
		public virtual void OEBJDGOJNLC()
		{
			this.solver.MIFKCBJPDDI();
		}

		// Token: 0x0600EC5E RID: 60510 RVA: 0x006AE46F File Offset: 0x006AC66F
		protected virtual void NEMAPKKAPOF()
		{
			Application.OpenURL("Play: `{0}` {1}");
		}

		// Token: 0x0600EC5F RID: 60511 RVA: 0x006AE47B File Offset: 0x006AC67B
		protected virtual void CGNBODEBPGE()
		{
			Application.OpenURL("wpn_add/base");
		}

		// Token: 0x0600EC60 RID: 60512 RVA: 0x006AE488 File Offset: 0x006AC688
		private bool HJBHKKEKEIJ()
		{
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.legs.Length == 0)
			{
				return false;
			}
			foreach (IK ik in this.legs)
			{
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL(">");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("Hidden/Post FX/Blit");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("<color='#000000'>{0}</color><color='#002000'>$</color>");
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600EC61 RID: 60513 RVA: 0x006AE514 File Offset: 0x006AC714
		private void FGAJABOJNLJ()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				if (this.PIJKOMKCJOG <= 0f)
				{
					return;
				}
				this.OnDisable();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.FANPFKHEDPA();
			for (int i = 0; i < this.legs.Length; i++)
			{
				this.PDDALPHGOKK(i);
			}
			this.pelvis.position += this.solver.pelvis.CIJMPJDKKGC * this.weight;
			this.EELIKFPDJEL = true;
			this.OAGKPEANNBF = 0;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC62 RID: 60514 RVA: 0x006AE628 File Offset: 0x006AC828
		private bool CHNAGGHGPMO()
		{
			if (this.pelvis == null)
			{
				return false;
			}
			if (this.legs.Length == 0)
			{
				return true;
			}
			IK[] array = this.legs;
			for (int i = 1; i < array.Length; i++)
			{
				IK ik = array[i];
				if (ik == null)
				{
					return false;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL(" гр ");
					return true;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("isRodOpen");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("cht_ach1");
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600EC63 RID: 60515 RVA: 0x006AE6B4 File Offset: 0x006AC8B4
		private void Update()
		{
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			if (this.weight <= 0f)
			{
				return;
			}
			this.EELIKFPDJEL = false;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 0f, 1f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 0f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 0f && this.rootRotationWeight > 0f)
				{
					Vector3 vector = this.solver.OGBCPFJMGCE();
					if (this.rootRotationWeight < 1f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.AELGDILJNAF())
			{
				return;
			}
			this.BHALELINNDJ();
		}

		// Token: 0x0600EC64 RID: 60516 RVA: 0x006AE819 File Offset: 0x006ACA19
		protected virtual void KHJLDCOIJJK()
		{
			Application.OpenURL(" Message: ");
		}

		// Token: 0x0600EC65 RID: 60517 RVA: 0x006AE828 File Offset: 0x006ACA28
		private void LIAONJMLNMA()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 1; j < this.legs.Length; j += 0)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 0].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KJKFJMGALPP));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GFDJOJGACCF));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.CAAINGFBNHG(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC66 RID: 60518 RVA: 0x006AE94C File Offset: 0x006ACB4C
		private void CKNHEJMMBGG()
		{
			if (this.weight <= 986f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.BGCPOHLJIDN()[i].HNPADDHKIAM(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
		}

		// Token: 0x0600EC67 RID: 60519 RVA: 0x006AE9F4 File Offset: 0x006ACBF4
		private void APJACOJADAF()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 0; i < this.legs.Length; i++)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 50f;
				}
			}
		}

		// Token: 0x0600EC68 RID: 60520 RVA: 0x006AEA44 File Offset: 0x006ACC44
		private void JJHAIFDONLP()
		{
			if (this.EOFDOPLDFCG)
			{
				foreach (IK ik in this.legs)
				{
					if (ik != null)
					{
						IKSolver iksolver = ik.GetIKSolver();
						iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.DJIOPPMHBBA));
						IKSolver iksolver2 = ik.GetIKSolver();
						iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JBPNPCGIDOP));
					}
				}
			}
		}

		// Token: 0x0600EC69 RID: 60521 RVA: 0x006AEACC File Offset: 0x006ACCCC
		private void HMEAENGBFKC()
		{
			this.weight = Mathf.Clamp(this.weight, 30f, 1952f);
			if (this.weight <= 951f)
			{
				return;
			}
			this.EELIKFPDJEL = true;
			if (this.EOFDOPLDFCG)
			{
				this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 38f, 851f);
				this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 1468f, this.rootRotationSpeed);
				if (this.characterRoot != null && this.rootRotationSpeed > 137f && this.rootRotationWeight > 954f)
				{
					Vector3 vector = this.solver.EABAHMCEAJC();
					if (this.rootRotationWeight < 348f)
					{
						vector = Vector3.Slerp(Vector3.up, vector, this.rootRotationWeight);
					}
					Quaternion b = Quaternion.RotateTowards(Quaternion.FromToRotation(base.transform.up, Vector3.up) * this.characterRoot.rotation, Quaternion.FromToRotation(base.transform.up, vector) * this.characterRoot.rotation, this.maxRootRotationAngle);
					this.characterRoot.rotation = Quaternion.Lerp(this.characterRoot.rotation, b, Time.deltaTime * this.rootRotationSpeed);
				}
				return;
			}
			if (!this.BEEPEPKDIBD())
			{
				return;
			}
			this.CPLOFPNBFEH();
		}

		// Token: 0x0600EC6A RID: 60522 RVA: 0x006AEC34 File Offset: 0x006ACE34
		private void FKPHBAOKEOF()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 1; i < this.legs.Length; i += 0)
			{
				if (this.legs[i] != null)
				{
					this.legs[i].GetIKSolver().IKPositionWeight = 1991f;
				}
			}
		}

		// Token: 0x0600EC6B RID: 60523 RVA: 0x006AEC84 File Offset: 0x006ACE84
		private void IBCBOLAGKNL()
		{
			this.CJLCHFDCNDM = new Transform[this.legs.Length];
			this.OEKPBGPOBPH = new Quaternion[this.legs.Length];
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.OEKPBGPOBPH[i] = Quaternion.identity;
			}
			for (int j = 1; j < this.legs.Length; j++)
			{
				IKSolver.Point[] array = this.legs[j].GetIKSolver().DJOBICJNHOD();
				this.CJLCHFDCNDM[j] = array[array.Length - 0].transform;
				IKSolver iksolver = this.legs[j].GetIKSolver();
				iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KJKFJMGALPP));
				IKSolver iksolver2 = this.legs[j].GetIKSolver();
				iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DNCAHAFOEJM));
			}
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.solver.JPGOKPACOIC(base.transform, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC6C RID: 60524 RVA: 0x006ACD39 File Offset: 0x006AAF39
		public virtual void MHGJONOJLDI()
		{
			this.solver.EGADMJMBCCK();
		}

		// Token: 0x0600EC6D RID: 60525 RVA: 0x006AEDA8 File Offset: 0x006ACFA8
		private void DJIOPPMHBBA()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1178f)
			{
				if (this.PIJKOMKCJOG <= 611f)
				{
					return;
				}
				this.DNBMNPKDPHC();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.IKHCCAANGOP();
			for (int i = 0; i < this.legs.Length; i++)
			{
				this.KNCAKAJHFJB(i);
			}
			this.pelvis.position += this.solver.JKCAIBBPEHP().DFFHLACPDNO() * this.weight;
			this.EELIKFPDJEL = true;
			this.OAGKPEANNBF = 1;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC6E RID: 60526 RVA: 0x006AEEBC File Offset: 0x006AD0BC
		private void JPFGPABIAHE(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.LFDJHHNIIMK()[CLBPBJGLHEE].BKEKFBNJBDN();
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC6F RID: 60527 RVA: 0x006AEF20 File Offset: 0x006AD120
		private void IFLJFONIOIP(int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPosition = this.solver.legs[CLBPBJGLHEE].NHIOCAIOLFD();
			this.legs[CLBPBJGLHEE].GetIKSolver().IKPositionWeight = this.weight;
		}

		// Token: 0x04001EDC RID: 7900
		public IK[] legs;

		// Token: 0x04001EDD RID: 7901
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		// Token: 0x04001EDE RID: 7902
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x04001EDF RID: 7903
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		// Token: 0x04001EE0 RID: 7904
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed = 5f;

		// Token: 0x04001EE1 RID: 7905
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle = 45f;

		// Token: 0x04001EE2 RID: 7906
		private Transform[] CJLCHFDCNDM = new Transform[0];

		// Token: 0x04001EE3 RID: 7907
		private Quaternion[] OEKPBGPOBPH = new Quaternion[0];

		// Token: 0x04001EE4 RID: 7908
		private Vector3 EIOGLIDOKKA;

		// Token: 0x04001EE5 RID: 7909
		private Vector3 JJMOFCAMOKK;

		// Token: 0x04001EE6 RID: 7910
		private int OAGKPEANNBF;

		// Token: 0x04001EE7 RID: 7911
		private bool EELIKFPDJEL;

		// Token: 0x04001EE8 RID: 7912
		private float PIJKOMKCJOG;
	}
}
