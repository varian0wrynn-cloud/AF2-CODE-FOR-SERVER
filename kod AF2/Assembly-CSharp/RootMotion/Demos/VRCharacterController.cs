using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000423 RID: 1059
	[RequireComponent(typeof(CharacterController))]
	public class VRCharacterController : MonoBehaviour
	{
		// Token: 0x0600E47F RID: 58495 RVA: 0x00681E8B File Offset: 0x0068008B
		private void COOHBKKNOLG()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E480 RID: 58496 RVA: 0x00681E8B File Offset: 0x0068008B
		private void BHPGDKJHKKG()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E481 RID: 58497 RVA: 0x00681EB4 File Offset: 0x006800B4
		private void PJHEGHHOJHJ()
		{
			Vector3 vector = new Vector3(Input.GetAxis("idlist"), 1817f, Input.GetAxis("RepFractions.xml"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 0f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 23f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(1190f, this.rotationRatchet, 1632f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1865f, -this.rotationRatchet, 414f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(1408f, Input.GetAxis("Press E to start interaction") * this.rotationSpeed, 977f) * base.transform.rotation;
		}

		// Token: 0x0600E483 RID: 58499 RVA: 0x00681E8B File Offset: 0x0068008B
		private void AEJLGHDKHHE()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E484 RID: 58500 RVA: 0x00682018 File Offset: 0x00680218
		private void JPHLMNIMDHH()
		{
			Vector3 vector = new Vector3(Input.GetAxis(""), 1020f, Input.GetAxis("_SampleMip"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 1794f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 126f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(960f, this.rotationRatchet, 1832f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1612f, -this.rotationRatchet, 1288f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(1532f, Input.GetAxis("_Saturation") * this.rotationSpeed, 1969f) * base.transform.rotation;
		}

		// Token: 0x0600E485 RID: 58501 RVA: 0x00682144 File Offset: 0x00680344
		private void PFPPDNHLCCA()
		{
			Vector3 vector = new Vector3(Input.GetAxis("[userfish]"), 946f, Input.GetAxis("OfficeSittingLegCross"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 36f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1126f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(1553f, this.rotationRatchet, 74f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1329f, -this.rotationRatchet, 644f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(313f, Input.GetAxis("BOTTOM") * this.rotationSpeed, 1342f) * base.transform.rotation;
		}

		// Token: 0x0600E486 RID: 58502 RVA: 0x00681E8B File Offset: 0x0068008B
		private void GDMEEIBDKLP()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E487 RID: 58503 RVA: 0x00682270 File Offset: 0x00680470
		private void MFHGOLNLAAF()
		{
			Vector3 vector = new Vector3(Input.GetAxis("Flap_07.wav"), 896f, Input.GetAxis("{0}"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 707f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1321f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(677f, this.rotationRatchet, 814f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1323f, -this.rotationRatchet, 304f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(895f, Input.GetAxis("Watering Can Idle") * this.rotationSpeed, 374f) * base.transform.rotation;
		}

		// Token: 0x0600E488 RID: 58504 RVA: 0x0068239C File Offset: 0x0068059C
		private void KJJBBLDJHPD()
		{
			Vector3 vector = new Vector3(Input.GetAxis("OfficeSitting"), 1194f, Input.GetAxis("_WaveOffset"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 1928f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1634f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(1010f, this.rotationRatchet, 80f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1840f, -this.rotationRatchet, 281f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(168f, Input.GetAxis("WeaponFire") * this.rotationSpeed, 393f) * base.transform.rotation;
		}

		// Token: 0x0600E489 RID: 58505 RVA: 0x00681E8B File Offset: 0x0068008B
		private void KOJNOPBGPAM()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E48A RID: 58506 RVA: 0x00681E8B File Offset: 0x0068008B
		private void DJIFJMEEBKA()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E48B RID: 58507 RVA: 0x006824C8 File Offset: 0x006806C8
		private void IOGAKGCADBL()
		{
			Vector3 vector = new Vector3(Input.GetAxis("<color=red>$&</color>"), 1674f, Input.GetAxis("CrawlLocomotion"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 1208f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1560f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(889f, this.rotationRatchet, 984f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1972f, -this.rotationRatchet, 776f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(969f, Input.GetAxis("Pricorm count=") * this.rotationSpeed, 1275f) * base.transform.rotation;
		}

		// Token: 0x0600E48C RID: 58508 RVA: 0x00681E8B File Offset: 0x0068008B
		private void LHHFHDNBKKC()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E48D RID: 58509 RVA: 0x006825F4 File Offset: 0x006807F4
		private void Update()
		{
			Vector3 vector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 0f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(0f, this.rotationRatchet, 0f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(0f, -this.rotationRatchet, 0f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(0f, Input.GetAxis("Mouse X") * this.rotationSpeed, 0f) * base.transform.rotation;
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x00681E8B File Offset: 0x0068008B
		private void CBBIADNKMLI()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E48F RID: 58511 RVA: 0x00682720 File Offset: 0x00680920
		private void DFFOEGHGPGP()
		{
			Vector3 vector = new Vector3(Input.GetAxis("KatanaReadyHigh"), 1112f, Input.GetAxis("WalkInjured"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 850f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1798f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(298f, this.rotationRatchet, 1360f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1730f, -this.rotationRatchet, 455f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(94f, Input.GetAxis("tintColor") * this.rotationSpeed, 622f) * base.transform.rotation;
		}

		// Token: 0x0600E490 RID: 58512 RVA: 0x0068284C File Offset: 0x00680A4C
		private void OPDCJCFMIPE()
		{
			Vector3 vector = new Vector3(Input.GetAxis("#url Sound "), 213f, Input.GetAxis("FOG_POINT_LIGHT"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 1593f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1160f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(1712f, this.rotationRatchet, 1220f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1852f, -this.rotationRatchet, 1082f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(50f, Input.GetAxis("IceHockeyPassLeft") * this.rotationSpeed, 1661f) * base.transform.rotation;
		}

		// Token: 0x0600E491 RID: 58513 RVA: 0x00681E8B File Offset: 0x0068008B
		private void ONBJLCJMLJH()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E492 RID: 58514 RVA: 0x00682978 File Offset: 0x00680B78
		private void AKLFCMNCPKL()
		{
			Vector3 vector = new Vector3(Input.GetAxis("JNT_R_Hand"), 1126f, Input.GetAxis("colorA"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 424f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1707f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(1426f, this.rotationRatchet, 1166f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1046f, -this.rotationRatchet, 775f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(946f, Input.GetAxis("Wand Stand") * this.rotationSpeed, 1643f) * base.transform.rotation;
		}

		// Token: 0x0600E493 RID: 58515 RVA: 0x00681E8B File Offset: 0x0068008B
		private void NPKEBODNBAI()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E494 RID: 58516 RVA: 0x00681E8B File Offset: 0x0068008B
		private void CACBLLBNIJE()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x00682AA4 File Offset: 0x00680CA4
		private void BOAJJAKEMLH()
		{
			Vector3 vector = new Vector3(Input.GetAxis("Formatted Label"), 843f, Input.GetAxis("_OcclusionTexture"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 99f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1375f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(362f, this.rotationRatchet, 1302f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1653f, -this.rotationRatchet, 619f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(1434f, Input.GetAxis("MotorbikeTurnRight") * this.rotationSpeed, 1933f) * base.transform.rotation;
		}

		// Token: 0x0600E496 RID: 58518 RVA: 0x00682BD0 File Offset: 0x00680DD0
		private void CBBLGEDCJBF()
		{
			Vector3 vector = new Vector3(Input.GetAxis("_AddCountitem.wav"), 1608f, Input.GetAxis("InterfaceLang.txt"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 1137f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1352f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(597f, this.rotationRatchet, 1459f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1885f, -this.rotationRatchet, 629f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(568f, Input.GetAxis("post_11") * this.rotationSpeed, 814f) * base.transform.rotation;
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x00681E8B File Offset: 0x0068008B
		private void CEBAOOAIADJ()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E498 RID: 58520 RVA: 0x00681E8B File Offset: 0x0068008B
		private void MGNGNBMMAAD()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x00681E8B File Offset: 0x0068008B
		private void JGKDNHLKBEN()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x00682CFC File Offset: 0x00680EFC
		private void LIOCDEICIFD()
		{
			Vector3 vector = new Vector3(Input.GetAxis("_FogScatteringData2"), 251f, Input.GetAxis("offsets"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 1076f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1475f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(412f, this.rotationRatchet, 1457f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(1570f, -this.rotationRatchet, 864f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(547f, Input.GetAxis("wpn_add/base") * this.rotationSpeed, 784f) * base.transform.rotation;
		}

		// Token: 0x0600E49B RID: 58523 RVA: 0x00681E8B File Offset: 0x0068008B
		private void MBNCGMLPNLD()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E49C RID: 58524 RVA: 0x00682E28 File Offset: 0x00681028
		private void GCNGEFBKMNC()
		{
			Vector3 vector = new Vector3(Input.GetAxis("rodDwDelta="), 478f, Input.GetAxis("1 Hand Small Weapon Combo"));
			Vector3 forward = this.forwardDirection.forward;
			forward.y = 1534f;
			this.FDLHJAOGDLJ.SimpleMove(Quaternion.LookRotation(forward) * Vector3.ClampMagnitude(vector, 1215f) * this.moveSpeed);
			if (Input.GetKeyDown(this.ratchetRight))
			{
				base.transform.rotation = Quaternion.Euler(1274f, this.rotationRatchet, 881f) * base.transform.rotation;
			}
			else if (Input.GetKeyDown(this.ratchetLeft))
			{
				base.transform.rotation = Quaternion.Euler(24f, -this.rotationRatchet, 157f) * base.transform.rotation;
			}
			base.transform.rotation = Quaternion.Euler(516f, Input.GetAxis("IdleDodgeRight") * this.rotationSpeed, 1110f) * base.transform.rotation;
		}

		// Token: 0x0600E49D RID: 58525 RVA: 0x00681E8B File Offset: 0x0068008B
		private void CCPOIOJPKIF()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E49E RID: 58526 RVA: 0x00681E8B File Offset: 0x0068008B
		private void CFNLKNOKAGC()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E49F RID: 58527 RVA: 0x00681E8B File Offset: 0x0068008B
		private void HCMHMFHMPHN()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E4A0 RID: 58528 RVA: 0x00681E8B File Offset: 0x0068008B
		private void LKDGGPNGLAO()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E4A1 RID: 58529 RVA: 0x00681E8B File Offset: 0x0068008B
		private void Awake()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x0600E4A2 RID: 58530 RVA: 0x00681E8B File Offset: 0x0068008B
		private void ENJFBODNKHO()
		{
			this.FDLHJAOGDLJ = base.GetComponent<CharacterController>();
			if (this.forwardDirection == null)
			{
				this.forwardDirection = base.transform;
			}
		}

		// Token: 0x04001DEB RID: 7659
		public float moveSpeed = 2f;

		// Token: 0x04001DEC RID: 7660
		public float rotationSpeed = 2f;

		// Token: 0x04001DED RID: 7661
		[Range(0f, 180f)]
		public float rotationRatchet = 45f;

		// Token: 0x04001DEE RID: 7662
		public KeyCode ratchetRight = KeyCode.E;

		// Token: 0x04001DEF RID: 7663
		public KeyCode ratchetLeft = KeyCode.Q;

		// Token: 0x04001DF0 RID: 7664
		public Transform forwardDirection;

		// Token: 0x04001DF1 RID: 7665
		private CharacterController FDLHJAOGDLJ;
	}
}
