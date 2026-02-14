using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000417 RID: 1047
	public class PlatformRotator : MonoBehaviour
	{
		// Token: 0x0600E150 RID: 57680 RVA: 0x0066E058 File Offset: 0x0066C258
		private void LMPOOLJDJME(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E151 RID: 57681 RVA: 0x0066E0A0 File Offset: 0x0066C2A0
		private void CMCMNNDKEOK(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E152 RID: 57682 RVA: 0x0066E0E8 File Offset: 0x0066C2E8
		private void DNGABPGCNEO()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 93f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1037f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E153 RID: 57683 RVA: 0x0066E19C File Offset: 0x0066C39C
		private void HMDHPBGKNAB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x0066E1DC File Offset: 0x0066C3DC
		private void JLAPBKONNDH(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x0066E21C File Offset: 0x0066C41C
		private void IHFOOBCFDAC(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E156 RID: 57686 RVA: 0x0066E25C File Offset: 0x0066C45C
		private void CFADLPHGPJP(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E157 RID: 57687 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator DHNBNKKDICF()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E158 RID: 57688 RVA: 0x0066E2A8 File Offset: 0x0066C4A8
		private void PMDPLLIBJAF()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.BMFMMOJIDFG());
		}

		// Token: 0x0600E159 RID: 57689 RVA: 0x0066E2FC File Offset: 0x0066C4FC
		private void IIKDDILLGLF()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.MIHNIGIECBA());
		}

		// Token: 0x0600E15A RID: 57690 RVA: 0x0066E350 File Offset: 0x0066C550
		private void FixedUpdate()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 0.1f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E15B RID: 57691 RVA: 0x0066E404 File Offset: 0x0066C604
		private void ACBAGDCLNMA()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.MCDMELBCCMK());
		}

		// Token: 0x0600E15C RID: 57692 RVA: 0x0066E458 File Offset: 0x0066C658
		private void NDHNLOENGHJ(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E15D RID: 57693 RVA: 0x0066E498 File Offset: 0x0066C698
		private void OCPDMAEEGOC()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AGGKBOKHLDF());
		}

		// Token: 0x0600E15E RID: 57694 RVA: 0x0066E4EC File Offset: 0x0066C6EC
		private void FLHIOAMPEBD(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E15F RID: 57695 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator EGAPCKOJMGN()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E160 RID: 57696 RVA: 0x0066E52C File Offset: 0x0066C72C
		private void ACPCJLEKCPM()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 645f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1921f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E161 RID: 57697 RVA: 0x0066E5E0 File Offset: 0x0066C7E0
		private void ENOHCEKJCBI()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 43f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1263f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E162 RID: 57698 RVA: 0x0066E694 File Offset: 0x0066C894
		private void NIPBPPJFFKE(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E163 RID: 57699 RVA: 0x0066E6D4 File Offset: 0x0066C8D4
		private void DGGMJCMLLED()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.MIHNIGIECBA());
		}

		// Token: 0x0600E164 RID: 57700 RVA: 0x0066E728 File Offset: 0x0066C928
		private void ELADFDNPOOI()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.MCDMELBCCMK());
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator AGGKBOKHLDF()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x0066E77C File Offset: 0x0066C97C
		private void IJFPHGEFOLF()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AGGKBOKHLDF());
		}

		// Token: 0x0600E167 RID: 57703 RVA: 0x0066E7D0 File Offset: 0x0066C9D0
		private void HDLJBFECCPE(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x0066E810 File Offset: 0x0066CA10
		private void HLKJKCKBELP()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1337f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 627f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E169 RID: 57705 RVA: 0x0066E8C4 File Offset: 0x0066CAC4
		private void OGMFCKNPFPP(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E16A RID: 57706 RVA: 0x0066E90C File Offset: 0x0066CB0C
		private void PIIFKLKDHFN(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E16B RID: 57707 RVA: 0x0066E954 File Offset: 0x0066CB54
		private void JLBGLBPCKKL(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E16C RID: 57708 RVA: 0x0066E99C File Offset: 0x0066CB9C
		private void DMANGIDPLDM(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E16D RID: 57709 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator KDNKGNAPIGC()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E16E RID: 57710 RVA: 0x0066E9F0 File Offset: 0x0066CBF0
		private void PEPNOEMFLMA(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E16F RID: 57711 RVA: 0x0066EA30 File Offset: 0x0066CC30
		private void HCCODCKINEK(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E170 RID: 57712 RVA: 0x0066EA70 File Offset: 0x0066CC70
		private void ENOGFDLIMLP(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E171 RID: 57713 RVA: 0x0066EAB0 File Offset: 0x0066CCB0
		private void CAJLCEPLKJG()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.OEDAHLBCOEA());
		}

		// Token: 0x0600E172 RID: 57714 RVA: 0x0066EB04 File Offset: 0x0066CD04
		private void CHDJGEOFHEE()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.DEAOPANIDIC());
		}

		// Token: 0x0600E173 RID: 57715 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator LHKEOMLJCFO()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator GBOPLJCILNF()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E175 RID: 57717 RVA: 0x0066EB58 File Offset: 0x0066CD58
		private void OnCollisionEnter(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E176 RID: 57718 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator DEAOPANIDIC()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E177 RID: 57719 RVA: 0x0066EBA0 File Offset: 0x0066CDA0
		private void JDKKDAKIPHO()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 747f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 141f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E178 RID: 57720 RVA: 0x0066EC54 File Offset: 0x0066CE54
		private void OIEJDIDFEFB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E179 RID: 57721 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator OCDFJJJLHJB()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E17A RID: 57722 RVA: 0x0066EC9C File Offset: 0x0066CE9C
		private void MBEFFGJNJFO(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E17B RID: 57723 RVA: 0x0066ECE4 File Offset: 0x0066CEE4
		private void FECFLBMPAAL()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.DEAOPANIDIC());
		}

		// Token: 0x0600E17C RID: 57724 RVA: 0x0066ED38 File Offset: 0x0066CF38
		private void ACNBNBBCAML(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E17D RID: 57725 RVA: 0x0066ED78 File Offset: 0x0066CF78
		private void MODJFGGIAHD()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.KDNKGNAPIGC());
		}

		// Token: 0x0600E17E RID: 57726 RVA: 0x0066EDCC File Offset: 0x0066CFCC
		private void BANBKNEKCKO(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E17F RID: 57727 RVA: 0x0066EE14 File Offset: 0x0066D014
		private void MPCAEAAHKAA(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E180 RID: 57728 RVA: 0x0066EE54 File Offset: 0x0066D054
		private void DGDFIALNJKJ(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E181 RID: 57729 RVA: 0x0066EE94 File Offset: 0x0066D094
		private void GBJEPJCCMFF()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1189f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 87f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E182 RID: 57730 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator OLOIFKEMIDI()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E183 RID: 57731 RVA: 0x0066EF48 File Offset: 0x0066D148
		private void AEOPIOEJMKO()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1744f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1199f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E184 RID: 57732 RVA: 0x0066EFFC File Offset: 0x0066D1FC
		private void OAIAEJABILB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E185 RID: 57733 RVA: 0x0066F044 File Offset: 0x0066D244
		private void IFCMNNOFNEJ(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E186 RID: 57734 RVA: 0x0066F084 File Offset: 0x0066D284
		private void CECDCNLECKA(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E187 RID: 57735 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator BIPIPDAFEKG()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E188 RID: 57736 RVA: 0x0066F0CC File Offset: 0x0066D2CC
		private void JJOHOKFPFDM(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E189 RID: 57737 RVA: 0x0066F10C File Offset: 0x0066D30C
		private void IJOCHELLKJH()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.IKPNGNEMIHA());
		}

		// Token: 0x0600E18A RID: 57738 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator LNCOKBKJPGB()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E18B RID: 57739 RVA: 0x0066F160 File Offset: 0x0066D360
		private void IIHNDJOIMAH()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.LNCOKBKJPGB());
		}

		// Token: 0x0600E18C RID: 57740 RVA: 0x0066F1B4 File Offset: 0x0066D3B4
		private void EFJDBBDMPMC()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.LNCOKBKJPGB());
		}

		// Token: 0x0600E18D RID: 57741 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator DGLOOIIJKLE()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E18E RID: 57742 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator MDEOHCMFOIF()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E18F RID: 57743 RVA: 0x0066F208 File Offset: 0x0066D408
		private void NLJAKIHPKPM()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 555f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1396f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E190 RID: 57744 RVA: 0x0066F2BC File Offset: 0x0066D4BC
		private void DNBHFANOHAB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E191 RID: 57745 RVA: 0x0066F2FC File Offset: 0x0066D4FC
		private void LEKLKLDNKIJ(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E192 RID: 57746 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator HCOBBNCPCJF()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E193 RID: 57747 RVA: 0x0066F344 File Offset: 0x0066D544
		private void KAGPLPIMAIK(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E194 RID: 57748 RVA: 0x0066F384 File Offset: 0x0066D584
		private void HNAKGHHGDPE()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 751f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 949f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E195 RID: 57749 RVA: 0x0066F438 File Offset: 0x0066D638
		private void JKDBDEGLIJN()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1178f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1341f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E196 RID: 57750 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator AAPIEBDCOOG()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E197 RID: 57751 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator OEDAHLBCOEA()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E198 RID: 57752 RVA: 0x0066F4EC File Offset: 0x0066D6EC
		private void AGGPLGOLJMN(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E199 RID: 57753 RVA: 0x0066F52C File Offset: 0x0066D72C
		private void HDGNIHBIEDG()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.OEDAHLBCOEA());
		}

		// Token: 0x0600E19A RID: 57754 RVA: 0x0066F580 File Offset: 0x0066D780
		private void EHJICANDJCK(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E19B RID: 57755 RVA: 0x0066F5C8 File Offset: 0x0066D7C8
		private void MIDLFGPFCGF()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 47f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 355f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E19C RID: 57756 RVA: 0x0066F67C File Offset: 0x0066D87C
		private void PPLCIOFMKHB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E19D RID: 57757 RVA: 0x0066F6BC File Offset: 0x0066D8BC
		private void IJIOLGIKDNF(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E19E RID: 57758 RVA: 0x0066F704 File Offset: 0x0066D904
		private void FEIMHGLLCDB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E19F RID: 57759 RVA: 0x0066F74C File Offset: 0x0066D94C
		private void MFGKBHNECJH()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1789f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1606f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1A0 RID: 57760 RVA: 0x0066F800 File Offset: 0x0066DA00
		private void JHPFENJCEKP()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1749f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1827f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1A1 RID: 57761 RVA: 0x0066F8B4 File Offset: 0x0066DAB4
		private void PBGBHJLEPOC(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1A2 RID: 57762 RVA: 0x0066F8FC File Offset: 0x0066DAFC
		private void BCKAGKIGLLA(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1A3 RID: 57763 RVA: 0x0066F944 File Offset: 0x0066DB44
		private void PJJGNKHHLAK(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E1A4 RID: 57764 RVA: 0x0066F984 File Offset: 0x0066DB84
		private void ONIHHFLOJMN()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.HDMJMKCDNJE());
		}

		// Token: 0x0600E1A5 RID: 57765 RVA: 0x0066F9D8 File Offset: 0x0066DBD8
		private void HBAHMBGCGAB()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1432f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 288f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1A6 RID: 57766 RVA: 0x0066FA8C File Offset: 0x0066DC8C
		private void DFDBDEBBMOA(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E1A7 RID: 57767 RVA: 0x0066FACC File Offset: 0x0066DCCC
		private void KGICJDGIIJK()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AAPIEBDCOOG());
		}

		// Token: 0x0600E1A8 RID: 57768 RVA: 0x0066FB20 File Offset: 0x0066DD20
		private void MIMEIDIDANM()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1263f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1598f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1A9 RID: 57769 RVA: 0x0066FBD4 File Offset: 0x0066DDD4
		private void MFCPAFOKBIC()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 804f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1478f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1AA RID: 57770 RVA: 0x0066FC88 File Offset: 0x0066DE88
		private void COMGGKGILHC()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 453f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1194f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1AB RID: 57771 RVA: 0x0066FD3C File Offset: 0x0066DF3C
		private void OnCollisionExit(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E1AC RID: 57772 RVA: 0x0066FD7C File Offset: 0x0066DF7C
		private void ECDGOPAINIG()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 722f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1195f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1AD RID: 57773 RVA: 0x0066FE30 File Offset: 0x0066E030
		private void BMNJGPIPKLL()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AAPIEBDCOOG());
		}

		// Token: 0x0600E1AE RID: 57774 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator ENMOJNFFKIM()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1AF RID: 57775 RVA: 0x0066FE84 File Offset: 0x0066E084
		private void AOJICLCCJHF()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AGGKBOKHLDF());
		}

		// Token: 0x0600E1B0 RID: 57776 RVA: 0x0066FED8 File Offset: 0x0066E0D8
		private void BGCLAKJHAFK()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.OLOIFKEMIDI());
		}

		// Token: 0x0600E1B1 RID: 57777 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator KOFPAGGDKFI()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1B2 RID: 57778 RVA: 0x0066FF2C File Offset: 0x0066E12C
		private void JLKBMEBFHBI()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AHLKLDEBPEE());
		}

		// Token: 0x0600E1B3 RID: 57779 RVA: 0x0066FF80 File Offset: 0x0066E180
		private void FBHENANNAAC(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E1B5 RID: 57781 RVA: 0x0066FFFC File Offset: 0x0066E1FC
		private void PPKAADBBANJ(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1B6 RID: 57782 RVA: 0x00670044 File Offset: 0x0066E244
		private void KJGPKCLBLJA()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 992f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 779f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1B7 RID: 57783 RVA: 0x006700F8 File Offset: 0x0066E2F8
		private void ECMAANIDEBA()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.KNCFBNNOEBK());
		}

		// Token: 0x0600E1B8 RID: 57784 RVA: 0x0067014C File Offset: 0x0066E34C
		private void ILCOPJPEKEC()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AHLKLDEBPEE());
		}

		// Token: 0x0600E1B9 RID: 57785 RVA: 0x006701A0 File Offset: 0x0066E3A0
		private void MCNAPFOFHHA()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1854f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1594f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1BA RID: 57786 RVA: 0x00670254 File Offset: 0x0066E454
		private void JOKFCJIIDBP(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E1BB RID: 57787 RVA: 0x0067029C File Offset: 0x0066E49C
		private void JFNOIJPDNDP()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1213f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1572f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1BC RID: 57788 RVA: 0x00670350 File Offset: 0x0066E550
		private void LHMNFJBJBJM()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.KOFPAGGDKFI());
		}

		// Token: 0x0600E1BD RID: 57789 RVA: 0x006703A4 File Offset: 0x0066E5A4
		private void NAFNNEPNCBM(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1BE RID: 57790 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator KNCFBNNOEBK()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1BF RID: 57791 RVA: 0x006703EC File Offset: 0x0066E5EC
		private void OHGNKFGBOJL()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1263f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 150f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1C0 RID: 57792 RVA: 0x006704A0 File Offset: 0x0066E6A0
		private void KEIILPMCFEO()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.DHNBNKKDICF());
		}

		// Token: 0x0600E1C1 RID: 57793 RVA: 0x006704F4 File Offset: 0x0066E6F4
		private void ECIDPGNPFNI(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1C2 RID: 57794 RVA: 0x0067053C File Offset: 0x0066E73C
		private void IJADGLBFJOB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E1C3 RID: 57795 RVA: 0x0067057C File Offset: 0x0066E77C
		private void IHDGILKMKKB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E1C4 RID: 57796 RVA: 0x006705C4 File Offset: 0x0066E7C4
		private void NDLLDNIOLPK()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 1668f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 477f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1C5 RID: 57797 RVA: 0x00670678 File Offset: 0x0066E878
		private void FEJINKMDMCM(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1C6 RID: 57798 RVA: 0x006706C0 File Offset: 0x0066E8C0
		private void KDCOHILDJJO()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.LHKEOMLJCFO());
		}

		// Token: 0x0600E1C7 RID: 57799 RVA: 0x00670714 File Offset: 0x0066E914
		private void PNOHGOJEJKL()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.DHNBNKKDICF());
		}

		// Token: 0x0600E1C8 RID: 57800 RVA: 0x00670768 File Offset: 0x0066E968
		private void LHDBDELJKFB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E1C9 RID: 57801 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator BMFMMOJIDFG()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E1CA RID: 57802 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator LJJOPLBDIOA()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1CB RID: 57803 RVA: 0x006707A8 File Offset: 0x0066E9A8
		private void FOKLBMKFCDP(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1CC RID: 57804 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator IKPNGNEMIHA()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x006707F0 File Offset: 0x0066E9F0
		private void COLOIGCGLGD(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E1CE RID: 57806 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator AHLKLDEBPEE()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E1CF RID: 57807 RVA: 0x00670838 File Offset: 0x0066EA38
		private void DICALFKKKCM(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1D0 RID: 57808 RVA: 0x00670880 File Offset: 0x0066EA80
		private void DGEPHMCMPJO()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 428f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 1206f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1D1 RID: 57809 RVA: 0x00670934 File Offset: 0x0066EB34
		private void BHFMGBNIAMC()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.LJJOPLBDIOA());
		}

		// Token: 0x0600E1D2 RID: 57810 RVA: 0x00670988 File Offset: 0x0066EB88
		private void DEGGJBFOKIK(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1D3 RID: 57811 RVA: 0x006709D0 File Offset: 0x0066EBD0
		private void DCDMPBJDCAN(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x00670A10 File Offset: 0x0066EC10
		private void Start()
		{
			this.FPGKHBHIGNB = base.transform.rotation;
			this.AOBKCEEGJNC = base.transform.position + this.movePosition;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			base.StartCoroutine(this.AHLKLDEBPEE());
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00670A64 File Offset: 0x0066EC64
		private void FHIGEJPEKMD(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator HDMJMKCDNJE()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x00670AAC File Offset: 0x0066ECAC
		private void KCONHAMKCGB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x00670AF4 File Offset: 0x0066ECF4
		private void HKFIDKNNBJA(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = true;
				}
			}
		}

		// Token: 0x0600E1D9 RID: 57817 RVA: 0x00670B3C File Offset: 0x0066ED3C
		private void ICCIPMDIJLI()
		{
			this.AJMNDCHJPNK.MovePosition(Vector3.SmoothDamp(this.AJMNDCHJPNK.position, this.AOBKCEEGJNC, ref this.APOIOHJJDDC, 267f, this.moveSpeed));
			if (Vector3.Distance(base.GetComponent<Rigidbody>().position, this.AOBKCEEGJNC) < 209f)
			{
				this.movePosition = -this.movePosition;
				this.AOBKCEEGJNC += this.movePosition;
			}
			this.AJMNDCHJPNK.MoveRotation(Quaternion.RotateTowards(this.AJMNDCHJPNK.rotation, this.BBPPDJKLPNL, this.rotationSpeed * Time.deltaTime));
		}

		// Token: 0x0600E1DA RID: 57818 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator PPIODBIKBDJ()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1DB RID: 57819 RVA: 0x00670BF0 File Offset: 0x0066EDF0
		private void DHMKPGJAJEB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = true;
			}
		}

		// Token: 0x0600E1DC RID: 57820 RVA: 0x00670C30 File Offset: 0x0066EE30
		private void NFFAACOKJPB(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E1DD RID: 57821 RVA: 0x00670C70 File Offset: 0x0066EE70
		private void NFNHJBAAOMC(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E1DE RID: 57822 RVA: 0x0066E299 File Offset: 0x0066C499
		private IEnumerator MCDMELBCCMK()
		{
			for (;;)
			{
				float angle = UnityEngine.Random.Range(-this.maxAngle, this.maxAngle);
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				this.BBPPDJKLPNL = Quaternion.AngleAxis(angle, onUnitSphere) * this.FPGKHBHIGNB;
				yield return new WaitForSeconds(this.switchRotationTime + UnityEngine.Random.value * this.random);
			}
			yield break;
		}

		// Token: 0x0600E1DF RID: 57823 RVA: 0x00670CB0 File Offset: 0x0066EEB0
		private void LFADHOAMIFC(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x0600E1E0 RID: 57824 RVA: 0x0066E9E1 File Offset: 0x0066CBE1
		private IEnumerator MIHNIGIECBA()
		{
			PlatformRotator.LOBBMOCOIGG lobbmocoigg = new PlatformRotator.LOBBMOCOIGG(1);
			lobbmocoigg.AENJLLPLILM = this;
			return lobbmocoigg;
		}

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x00670CF8 File Offset: 0x0066EEF8
		private void GGJNKJMIGDC(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				component.smoothPhysics = false;
			}
		}

		// Token: 0x0600E1E2 RID: 57826 RVA: 0x00670D38 File Offset: 0x0066EF38
		private void DHBCGOHFEGN(Collision LMIOFHFPLJD)
		{
			if (LMIOFHFPLJD.gameObject.layer == this.characterLayer)
			{
				CharacterThirdPerson component = LMIOFHFPLJD.gameObject.GetComponent<CharacterThirdPerson>();
				if (component == null)
				{
					return;
				}
				if (component.smoothPhysics)
				{
					component.smoothPhysics = false;
				}
			}
		}

		// Token: 0x04001D94 RID: 7572
		public float maxAngle = 70f;

		// Token: 0x04001D95 RID: 7573
		public float switchRotationTime = 0.5f;

		// Token: 0x04001D96 RID: 7574
		public float random = 0.5f;

		// Token: 0x04001D97 RID: 7575
		public float rotationSpeed = 50f;

		// Token: 0x04001D98 RID: 7576
		public Vector3 movePosition;

		// Token: 0x04001D99 RID: 7577
		public float moveSpeed = 5f;

		// Token: 0x04001D9A RID: 7578
		public int characterLayer;

		// Token: 0x04001D9B RID: 7579
		private Quaternion FPGKHBHIGNB;

		// Token: 0x04001D9C RID: 7580
		private Quaternion BBPPDJKLPNL;

		// Token: 0x04001D9D RID: 7581
		private Vector3 AOBKCEEGJNC;

		// Token: 0x04001D9E RID: 7582
		private Vector3 APOIOHJJDDC;

		// Token: 0x04001D9F RID: 7583
		private Rigidbody AJMNDCHJPNK;
	}
}
