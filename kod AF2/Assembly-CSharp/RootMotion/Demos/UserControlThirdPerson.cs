using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000435 RID: 1077
	public class UserControlThirdPerson : MonoBehaviour
	{
		// Token: 0x0600E7E5 RID: 59365 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void INDGOHJGCFN()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x0600E7E6 RID: 59366 RVA: 0x00696B34 File Offset: 0x00694D34
		protected virtual void HMEAENGBFKC()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey((KeyCode)(-27)));
			this.state.IELMDLPINAH = (!this.canJump || Input.GetButton("Jump"));
			float axisRaw = Input.GetAxisRaw("Low adminlevel!");
			float axisRaw2 = Input.GetAxisRaw(" x");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 364f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)84);
			float d = this.walkByDefault ? (key ? 661f : 972f) : (key ? 1298f : 759f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1807f;
		}

		// Token: 0x0600E7E7 RID: 59367 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void ONIHHFLOJMN()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x0600E7E8 RID: 59368 RVA: 0x00696C80 File Offset: 0x00694E80
		protected virtual void LIOCDEICIFD()
		{
			this.state.MGCOIPEBMIF = (!this.canCrouch || Input.GetKey((KeyCode)87));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton("DeadmanFloat"));
			float axisRaw = Input.GetAxisRaw("#FF4040");
			float axisRaw2 = Input.GetAxisRaw("");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 1587f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)(-90));
			float d = this.walkByDefault ? (key ? 858f : 106f) : (key ? 1196f : 1280f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1875f;
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x00696DCC File Offset: 0x00694FCC
		protected virtual void CBBLGEDCJBF()
		{
			this.state.MGCOIPEBMIF = (!this.canCrouch || Input.GetKey((KeyCode)(-106)));
			this.state.IELMDLPINAH = (!this.canJump || Input.GetButton("INTERFACE"));
			float axisRaw = Input.GetAxisRaw("AC_TONEMAPPING");
			float axisRaw2 = Input.GetAxisRaw("Hidden/DepthOfField/MedianFilter");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 1738f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)184);
			float d = this.walkByDefault ? (key ? 1396f : 1757f) : (key ? 1151f : 1013f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 478f;
		}

		// Token: 0x0600E7EA RID: 59370 RVA: 0x00696F18 File Offset: 0x00695118
		protected virtual void AIAMIFEPALP()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey(KeyCode.Tab));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton("russian"));
			float axisRaw = Input.GetAxisRaw("L");
			float axisRaw2 = Input.GetAxisRaw("\n");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 1746f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)75);
			float d = this.walkByDefault ? (key ? 883f : 1032f) : (key ? 228f : 178f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1982f;
		}

		// Token: 0x0600E7EB RID: 59371 RVA: 0x00697064 File Offset: 0x00695264
		protected virtual void KJJBBLDJHPD()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey((KeyCode)82));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton("_isSelect"));
			float axisRaw = Input.GetAxisRaw("WizardOverhead");
			float axisRaw2 = Input.GetAxisRaw("Anti-Cheat Toolkit Detectors");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 248f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)(-6));
			float d = this.walkByDefault ? (key ? 1501f : 1790f) : (key ? 1301f : 976f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1014f;
		}

		// Token: 0x0600E7EC RID: 59372 RVA: 0x006971B0 File Offset: 0x006953B0
		protected virtual void JPHLMNIMDHH()
		{
			this.state.MGCOIPEBMIF = (!this.canCrouch || Input.GetKey((KeyCode)78));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton(" "));
			float axisRaw = Input.GetAxisRaw("");
			float axisRaw2 = Input.GetAxisRaw("{0:0.} fps ping:{1} pck/sec: {2}");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 336f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)161);
			float d = this.walkByDefault ? (key ? 134f : 322f) : (key ? 531f : 1760f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1428f;
		}

		// Token: 0x0600E7ED RID: 59373 RVA: 0x006972FC File Offset: 0x006954FC
		protected virtual void OFPGMNGFLNH()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey((KeyCode)16));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton("MotorbikeAirWalk"));
			float axisRaw = Input.GetAxisRaw("Horizontal");
			float axisRaw2 = Input.GetAxisRaw("_EmissionColor");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 660f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)(-63));
			float d = this.walkByDefault ? (key ? 1271f : 1439f) : (key ? 1696f : 39f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1383f;
		}

		// Token: 0x0600E7EE RID: 59374 RVA: 0x00697448 File Offset: 0x00695648
		protected virtual void DFFOEGHGPGP()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey((KeyCode)(-14)));
			this.state.IELMDLPINAH = (!this.canJump || Input.GetButton("OfficeSittingReading"));
			float axisRaw = Input.GetAxisRaw("sonar_");
			float axisRaw2 = Input.GetAxisRaw("Please assign all Bones to the IK solver.");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 1280f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey(KeyCode.Alpha5);
			float d = this.walkByDefault ? (key ? 985f : 333f) : (key ? 1613f : 591f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1776f;
		}

		// Token: 0x0600E7F0 RID: 59376 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void Start()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x0600E7F1 RID: 59377 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void MCHAAIIHOKD()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x0600E7F2 RID: 59378 RVA: 0x006975A8 File Offset: 0x006957A8
		protected virtual void OPDCJCFMIPE()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey((KeyCode)(-84)));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton("<color=\""));
			float axisRaw = Input.GetAxisRaw("close");
			float axisRaw2 = Input.GetAxisRaw("private");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 283f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)191);
			float d = this.walkByDefault ? (key ? 769f : 1939f) : (key ? 1319f : 462f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1188f;
		}

		// Token: 0x0600E7F3 RID: 59379 RVA: 0x006976F4 File Offset: 0x006958F4
		protected virtual void LMMDHJJJNJO()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey((KeyCode)(-77)));
			this.state.IELMDLPINAH = (!this.canJump || Input.GetButton("Palm"));
			float axisRaw = Input.GetAxisRaw("MotorbikeWheelyNoHands");
			float axisRaw2 = Input.GetAxisRaw("_BumpMap");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 993f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey(KeyCode.Colon);
			float d = this.walkByDefault ? (key ? 453f : 1051f) : (key ? 1583f : 952f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1839f;
		}

		// Token: 0x0600E7F4 RID: 59380 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void HDFCIACDDEK()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x00697840 File Offset: 0x00695A40
		protected virtual void BJOICAKCPLI()
		{
			this.state.MGCOIPEBMIF = (!this.canCrouch || Input.GetKey(KeyCode.RightCurlyBracket));
			this.state.IELMDLPINAH = (!this.canJump || Input.GetButton("_VelocityScale"));
			float axisRaw = Input.GetAxisRaw("Crawl Locomotion");
			float axisRaw2 = Input.GetAxisRaw("34");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 1112f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey(KeyCode.B);
			float d = this.walkByDefault ? (key ? 209f : 430f) : (key ? 1429f : 358f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 1306f;
		}

		// Token: 0x0600E7F6 RID: 59382 RVA: 0x0069798C File Offset: 0x00695B8C
		protected virtual void AKLFCMNCPKL()
		{
			this.state.MGCOIPEBMIF = (!this.canCrouch || Input.GetKey(KeyCode.Equals));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton("help"));
			float axisRaw = Input.GetAxisRaw("_Offsets");
			float axisRaw2 = Input.GetAxisRaw("1HandSwordStrafeRight");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 351f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey((KeyCode)175);
			float d = this.walkByDefault ? (key ? 1456f : 7f) : (key ? 1469f : 1737f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 695f;
		}

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void ANHOOJFEJJE()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x0600E7F8 RID: 59384 RVA: 0x00697AD8 File Offset: 0x00695CD8
		protected virtual void Update()
		{
			this.state.MGCOIPEBMIF = (this.canCrouch && Input.GetKey(KeyCode.C));
			this.state.IELMDLPINAH = (this.canJump && Input.GetButton("Jump"));
			float axisRaw = Input.GetAxisRaw("Horizontal");
			float axisRaw2 = Input.GetAxisRaw("Vertical");
			Vector3 vector = this.PMMEFNKFJIA.rotation * new Vector3(axisRaw, 0f, axisRaw2).normalized;
			if (vector != Vector3.zero)
			{
				Vector3 up = base.transform.up;
				Vector3.OrthoNormalize(ref up, ref vector);
				this.state.ANPGPHIAMDM = vector;
			}
			else
			{
				this.state.ANPGPHIAMDM = Vector3.zero;
			}
			bool key = Input.GetKey(KeyCode.LeftShift);
			float d = this.walkByDefault ? (key ? 1f : 0.5f) : (key ? 0.5f : 1f);
			this.state.ANPGPHIAMDM = this.state.ANPGPHIAMDM * d;
			this.state.IGEMIODEOPE = base.transform.position + this.PMMEFNKFJIA.forward * 100f;
		}

		// Token: 0x0600E7F9 RID: 59385 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void OBJCOJEHLBE()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x0600E7FA RID: 59386 RVA: 0x00696B1F File Offset: 0x00694D1F
		private void FIJKDFIMELM()
		{
			this.PMMEFNKFJIA = Camera.main.transform;
		}

		// Token: 0x04001E87 RID: 7815
		public bool walkByDefault;

		// Token: 0x04001E88 RID: 7816
		public bool canCrouch = true;

		// Token: 0x04001E89 RID: 7817
		public bool canJump = true;

		// Token: 0x04001E8A RID: 7818
		public UserControlThirdPerson.HGAPDOOIFEG state;

		// Token: 0x04001E8B RID: 7819
		protected Transform PMMEFNKFJIA;

		// Token: 0x02000436 RID: 1078
		public struct HGAPDOOIFEG
		{
			// Token: 0x04001E8C RID: 7820
			public Vector3 ANPGPHIAMDM;

			// Token: 0x04001E8D RID: 7821
			public Vector3 IGEMIODEOPE;

			// Token: 0x04001E8E RID: 7822
			public bool MGCOIPEBMIF;

			// Token: 0x04001E8F RID: 7823
			public bool IELMDLPINAH;

			// Token: 0x04001E90 RID: 7824
			public int GPGEJAHJLHC;
		}
	}
}
