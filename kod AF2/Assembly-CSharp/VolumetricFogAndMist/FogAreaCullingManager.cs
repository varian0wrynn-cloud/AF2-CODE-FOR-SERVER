using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020002BE RID: 702
	public class FogAreaCullingManager : MonoBehaviour
	{
		// Token: 0x0600A526 RID: 42278 RVA: 0x004A75B8 File Offset: 0x004A57B8
		private void JAFCKIKCHGM()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > -19);
			if (!Application.isPlaying)
			{
				Debug.Log("IdleDie");
			}
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void ALHFAHBHHPP()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x004A7610 File Offset: 0x004A5810
		private void AHPHMMJMKOG()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 64);
			if (!Application.isPlaying)
			{
				Debug.Log("isKeyPress");
			}
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void OnBecameInvisible()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x004A764A File Offset: 0x004A584A
		private void EIMMHKNMIKI()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x004A7668 File Offset: 0x004A5868
		public void GHBEKMCFLFJ()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 344f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1444f;
				this.fog.GNDFOJIILMC = 1651f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1444f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1739f;
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x004A7758 File Offset: 0x004A5958
		public void FDJCGPEFCPL()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 853f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1715f;
				this.fog.GNDFOJIILMC = 1858f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 150f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1209f;
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x004A7846 File Offset: 0x004A5A46
		private void JIBKGOFOPHJ()
		{
			this.OHPAEHCPIBL();
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void NLNGGPJDBBP()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x004A786A File Offset: 0x004A5A6A
		private void JOPKEFJOKIM()
		{
			if (this.fog != null)
			{
				this.fog.CMCEEMFLMHC();
			}
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x004A7885 File Offset: 0x004A5A85
		private void KMPEBHIPKJH()
		{
			this.DCIIHHGEPKE();
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x004A7890 File Offset: 0x004A5A90
		private void AOABMLPHMME()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > -99);
			if (!Application.isPlaying)
			{
				Debug.Log("The 'font' command requires a font name parameter and an optional font size parameter.");
			}
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x004A78CC File Offset: 0x004A5ACC
		private void ALHFPHHGIHK()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > -93);
			if (!Application.isPlaying)
			{
				Debug.Log("  locid=");
			}
		}

		// Token: 0x0600A533 RID: 42291 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void GNINFJOJDLH()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A534 RID: 42292 RVA: 0x004A7908 File Offset: 0x004A5B08
		public void ECKIPHEFCOD()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 1474f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 772f;
				this.fog.GNDFOJIILMC = 1330f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 961f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 815f;
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x004A7885 File Offset: 0x004A5A85
		private void KJJBBLDJHPD()
		{
			this.DCIIHHGEPKE();
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x004A79F8 File Offset: 0x004A5BF8
		private void PLLCHLCDKFA()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 20);
			if (!Application.isPlaying)
			{
				Debug.Log("SoundData");
			}
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x004A7A32 File Offset: 0x004A5C32
		private void LMMDHJJJNJO()
		{
			this.HOPOAOBNHHJ();
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x004A7A3A File Offset: 0x004A5C3A
		private void AIAMIFEPALP()
		{
			this.CNCDDMLALFA();
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x004A7A44 File Offset: 0x004A5C44
		private void NGOKJEOMFFP()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > -106);
			if (!Application.isPlaying)
			{
				Debug.Log("Invalid bone hierarchy detected. IK requires for it's bones to be parented to each other in descending order.");
			}
		}

		// Token: 0x0600A53A RID: 42298 RVA: 0x004A7A3A File Offset: 0x004A5C3A
		private void FPLNDDMFFKG()
		{
			this.CNCDDMLALFA();
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void JLAOHDINLNI()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x004A7A7E File Offset: 0x004A5C7E
		private void CDLDCKAHLHC()
		{
			this.KMOOLABDCME();
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void HGPLHFLFKOL()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x004A7A86 File Offset: 0x004A5C86
		private void DFFOEGHGPGP()
		{
			this.BKJNKGAHOKO();
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x004A7A90 File Offset: 0x004A5C90
		public void MCMDCHPFIBJ()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 969f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1500f;
				this.fog.GNDFOJIILMC = 87f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 658f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1588f;
		}

		// Token: 0x0600A540 RID: 42304 RVA: 0x004A7B7E File Offset: 0x004A5D7E
		private void MEFOGCFJBNE()
		{
			this.OCOIJILBFDJ();
		}

		// Token: 0x0600A541 RID: 42305 RVA: 0x004A7B88 File Offset: 0x004A5D88
		public void OHPAEHCPIBL()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 1714f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1751f;
				this.fog.GNDFOJIILMC = 1861f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 357f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1058f;
		}

		// Token: 0x0600A542 RID: 42306 RVA: 0x004A7C78 File Offset: 0x004A5E78
		public void OCOIJILBFDJ()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 279f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 492f;
				this.fog.GNDFOJIILMC = 1480f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1841f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1148f;
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x004A7D66 File Offset: 0x004A5F66
		private void LDDIGEMBDNF()
		{
			this.KELGHGDPGAB();
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x004A7D70 File Offset: 0x004A5F70
		public void KGPJAFOGJHL()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 70f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 509f;
				this.fog.GNDFOJIILMC = 801f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 548f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 57f;
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x004A7E60 File Offset: 0x004A6060
		private void OCIANPBJNND()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 1);
			if (!Application.isPlaying)
			{
				Debug.Log("author");
			}
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void MELHPGNGABI()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x004A7E9C File Offset: 0x004A609C
		public void DCIIHHGEPKE()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 1685f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 485f;
				this.fog.GNDFOJIILMC = 119f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1747f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 143f;
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void CICNKDLNCIP()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x004A786A File Offset: 0x004A5A6A
		private void KGBOBCIIFBI()
		{
			if (this.fog != null)
			{
				this.fog.CMCEEMFLMHC();
			}
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x004A7A7E File Offset: 0x004A5C7E
		private void LACNPNKHCAA()
		{
			this.KMOOLABDCME();
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x004A764A File Offset: 0x004A584A
		private void MIPHMELJJJD()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x004A7F8A File Offset: 0x004A618A
		private void EMFOECIPBIP()
		{
			this.CNPDONKJHIO();
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x004A764A File Offset: 0x004A584A
		private void DNFMEMNJADK()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x004A786A File Offset: 0x004A5A6A
		private void JIIMDDDEDEA()
		{
			if (this.fog != null)
			{
				this.fog.CMCEEMFLMHC();
			}
		}

		// Token: 0x0600A54F RID: 42319 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void MEJOKJGJIOJ()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A550 RID: 42320 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void LOMKBGPMAPI()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A551 RID: 42321 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void GJHNMLJIBLI()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void DHLCJAKMBOG()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x004A7F94 File Offset: 0x004A6194
		private void OOGPDGBACLC()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 45);
			if (!Application.isPlaying)
			{
				Debug.Log("long:");
			}
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x004A7FD0 File Offset: 0x004A61D0
		public void EKKJBHGDABP()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 236f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1011f;
				this.fog.GNDFOJIILMC = 864f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1591f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1696f;
		}

		// Token: 0x0600A556 RID: 42326 RVA: 0x004A764A File Offset: 0x004A584A
		private void OnDestroy()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A557 RID: 42327 RVA: 0x004A80C0 File Offset: 0x004A62C0
		private void ECHEPDJBGLP()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 17);
			if (!Application.isPlaying)
			{
				Debug.Log("---");
			}
		}

		// Token: 0x0600A558 RID: 42328 RVA: 0x004A80FC File Offset: 0x004A62FC
		public void GAGAGPHKAKL()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 334f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 868f;
				this.fog.GNDFOJIILMC = 88f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1435f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 664f;
		}

		// Token: 0x0600A559 RID: 42329 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void ILFNEHPAPAG()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void KHFCOKBEIEB()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x004A764A File Offset: 0x004A584A
		private void MOILNLOMCAK()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void OnBecameVisible()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A55D RID: 42333 RVA: 0x004A81EA File Offset: 0x004A63EA
		private void LIOCDEICIFD()
		{
			this.FDJCGPEFCPL();
		}

		// Token: 0x0600A55E RID: 42334 RVA: 0x004A81F4 File Offset: 0x004A63F4
		private void FDLEOEFIFOO()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 79);
			if (!Application.isPlaying)
			{
				Debug.Log("fshop_btn1");
			}
		}

		// Token: 0x0600A55F RID: 42335 RVA: 0x004A8230 File Offset: 0x004A6430
		public void BKJNKGAHOKO()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 766f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1235f;
				this.fog.GNDFOJIILMC = 1518f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1712f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 432f;
		}

		// Token: 0x0600A560 RID: 42336 RVA: 0x004A764A File Offset: 0x004A584A
		private void BHECIFOGAIE()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A561 RID: 42337 RVA: 0x004A7885 File Offset: 0x004A5A85
		private void BOAJJAKEMLH()
		{
			this.DCIIHHGEPKE();
		}

		// Token: 0x0600A562 RID: 42338 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void OBFHNFIEGFP()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A563 RID: 42339 RVA: 0x004A764A File Offset: 0x004A584A
		private void KCFKCLCADGM()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void APNJICBIOHH()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x004A831E File Offset: 0x004A651E
		private void CLCJPEDHFJA()
		{
			this.KGPJAFOGJHL();
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x004A786A File Offset: 0x004A5A6A
		private void ALPOPEGDHBL()
		{
			if (this.fog != null)
			{
				this.fog.CMCEEMFLMHC();
			}
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x004A8328 File Offset: 0x004A6528
		public void CAEJCNOBDHP()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 662f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1163f;
				this.fog.GNDFOJIILMC = 1045f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1772f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1068f;
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void CPBLIDKCKOD()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x004A831E File Offset: 0x004A651E
		private void CIBBPIIDHJH()
		{
			this.KGPJAFOGJHL();
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x004A8418 File Offset: 0x004A6618
		private void INIMDNDBMDK()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 89);
			if (!Application.isPlaying)
			{
				Debug.Log("wpn_add/base");
			}
		}

		// Token: 0x0600A56B RID: 42347 RVA: 0x004A8454 File Offset: 0x004A6654
		public void HOPOAOBNHHJ()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 800f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1977f;
				this.fog.GNDFOJIILMC = 628f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 244f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1751f;
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x004A8544 File Offset: 0x004A6744
		public void FFNBIODCFKM()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 1618f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 144f;
				this.fog.GNDFOJIILMC = 1732f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 828f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 760f;
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x004A8634 File Offset: 0x004A6834
		private void HHOJJINMMMA()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 122);
			if (!Application.isPlaying)
			{
				Debug.Log("IceHockeyShotRight");
			}
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x004A8670 File Offset: 0x004A6870
		private void BHEHCDDBKIE()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 73);
			if (!Application.isPlaying)
			{
				Debug.Log("Vertical");
			}
		}

		// Token: 0x0600A56F RID: 42351 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void MHEDGKNFLLF()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x004A86AC File Offset: 0x004A68AC
		public void CNPDONKJHIO()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 1635f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 309f;
				this.fog.GNDFOJIILMC = 1376f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 208f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 781f;
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x004A879C File Offset: 0x004A699C
		private void OHPHJCGMNGD()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 74);
			if (!Application.isPlaying)
			{
				Debug.Log("{0}:{1}:{2}:{3}");
			}
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x004A87D6 File Offset: 0x004A69D6
		private void JFGGBEGNAFP()
		{
			this.MNBLJCAPDPN();
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x004A87E0 File Offset: 0x004A69E0
		public void KMOOLABDCME()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 690f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1547f;
				this.fog.GNDFOJIILMC = 253f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 745f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1211f;
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x004A88D0 File Offset: 0x004A6AD0
		public void UpdateFogAreaExtents()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 0.5f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 0f;
				this.fog.GNDFOJIILMC = 0f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 0.5f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 0.5f;
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x004A89C0 File Offset: 0x004A6BC0
		private void KFLFNGGBAEB()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 0);
			if (!Application.isPlaying)
			{
				Debug.Log("_FgOverlap");
			}
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x004A89FA File Offset: 0x004A6BFA
		private void INKGAFANFIB()
		{
			this.FFNBIODCFKM();
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x004A8A04 File Offset: 0x004A6C04
		private void PCJAGJKHLHN()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 117);
			if (!Application.isPlaying)
			{
				Debug.Log("turn_state");
			}
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void JEGCHHGDFPC()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void CDKCHDJOGPF()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void GNFEJBHPLLB()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void EGNPNMPBLJB()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x004A8A40 File Offset: 0x004A6C40
		private void PPNAHPOBOHK()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 55);
			if (!Application.isPlaying)
			{
				Debug.Log("");
			}
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x004A8A7A File Offset: 0x004A6C7A
		private void JLFBDOPFDDJ()
		{
			this.MCMDCHPFIBJ();
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x004A8A84 File Offset: 0x004A6C84
		private void EBLJKEAHIGD()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 110);
			if (!Application.isPlaying)
			{
				Debug.Log("{not_found}");
			}
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x004A8AC0 File Offset: 0x004A6CC0
		private void OnEnable()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 24);
			if (!Application.isPlaying)
			{
				Debug.Log("Fog Areas should be created on runtime.");
			}
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x004A8AFC File Offset: 0x004A6CFC
		public void CNCDDMLALFA()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 907f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 921f;
				this.fog.GNDFOJIILMC = 1082f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1060f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 772f;
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x004A8BEC File Offset: 0x004A6DEC
		private void IBOMADDAFAO()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 121);
			if (!Application.isPlaying)
			{
				Debug.Log("Rooms  ");
			}
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x004A8C26 File Offset: 0x004A6E26
		private void EKCKBDKEAKO()
		{
			this.EKKJBHGDABP();
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x004A8C30 File Offset: 0x004A6E30
		private void GICMHNKKECK()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 101);
			if (!Application.isPlaying)
			{
				Debug.Log("PaperTurn.wav");
			}
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x004A8C6C File Offset: 0x004A6E6C
		private void NFJKCBFCHBP()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > 81);
			if (!Application.isPlaying)
			{
				Debug.Log("RollerBladeGrindRoyale");
			}
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x004A8CA8 File Offset: 0x004A6EA8
		public void MNBLJCAPDPN()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 1337f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 71f;
				this.fog.GNDFOJIILMC = 1689f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1741f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 753f;
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void NBDJNPJEPIB()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x004A764A File Offset: 0x004A584A
		private void IEHOIMHFICG()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x004A764A File Offset: 0x004A584A
		private void GJNKCBMCFJA()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x004A8A7A File Offset: 0x004A6C7A
		private void BNKJNBIDPME()
		{
			this.MCMDCHPFIBJ();
		}

		// Token: 0x0600A58A RID: 42378 RVA: 0x004A81EA File Offset: 0x004A63EA
		private void HNMODJBBKBI()
		{
			this.FDJCGPEFCPL();
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x004A786A File Offset: 0x004A5A6A
		private void MEFOBNJIMGC()
		{
			if (this.fog != null)
			{
				this.fog.CMCEEMFLMHC();
			}
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x004A8D98 File Offset: 0x004A6F98
		public void LDLNKACLPNP()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 636f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 17f;
				this.fog.GNDFOJIILMC = 760f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1630f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1218f;
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x004A87D6 File Offset: 0x004A69D6
		private void GDPMOMHBIFN()
		{
			this.MNBLJCAPDPN();
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void FOFNNHHJBMH()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x004A89FA File Offset: 0x004A6BFA
		private void HAIMGCDKPDC()
		{
			this.FFNBIODCFKM();
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void PHNKOMLBOIH()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x004A764A File Offset: 0x004A584A
		private void GJOAHIPJKEL()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x004A786A File Offset: 0x004A5A6A
		private void PINOEKEMAHE()
		{
			if (this.fog != null)
			{
				this.fog.CMCEEMFLMHC();
			}
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x004A8E88 File Offset: 0x004A7088
		public void KELGHGDPGAB()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 1133f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1480f;
				this.fog.GNDFOJIILMC = 187f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1008f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 1045f;
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void HLDDMIJILOO()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x004A8F78 File Offset: 0x004A7178
		private void PNGOLEOOHCD()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > -111);
			if (!Application.isPlaying)
			{
				Debug.Log("");
			}
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x004A75F2 File Offset: 0x004A57F2
		private void FJDDEOKOOAM()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x004A8FB4 File Offset: 0x004A71B4
		public void IGGFIBFMCDC()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 871f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1320f;
				this.fog.GNDFOJIILMC = 645f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 191f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 241f;
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x004A764A File Offset: 0x004A584A
		private void MECEHFDKHPF()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A599 RID: 42393 RVA: 0x004A764A File Offset: 0x004A584A
		private void GPKHKLEINDH()
		{
			if (this.fog != null)
			{
				this.fog.DestroySelf();
			}
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x004A90A4 File Offset: 0x004A72A4
		private void BBDOHOKDBLO()
		{
			MeshFilter component = base.GetComponent<MeshFilter>();
			this.ODBNCIANMDG = (component.sharedMesh.vertexCount > -63);
			if (!Application.isPlaying)
			{
				Debug.Log("{not_found}");
			}
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x004A784E File Offset: 0x004A5A4E
		private void HGKHMFLDDCF()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x004A90E0 File Offset: 0x004A72E0
		public void HJDBFJOMKEI()
		{
			if (this.fog == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			this.fog.GJDBFGOIJBO = base.transform.position;
			this.fog.KNKNDOFLNMP = base.transform.localScale.x * 958f;
			if (this.ODBNCIANMDG)
			{
				base.transform.localScale = Vector3.one * base.transform.localScale.x;
				this.fog.ENIMEAJNMLM = 1207f;
				this.fog.GNDFOJIILMC = 948f;
				return;
			}
			this.fog.ENIMEAJNMLM = base.transform.localScale.y * 1531f;
			this.fog.GNDFOJIILMC = base.transform.localScale.z * 664f;
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x004A91CE File Offset: 0x004A73CE
		private void Update()
		{
			this.UpdateFogAreaExtents();
		}

		// Token: 0x04001512 RID: 5394
		public VolumetricFog fog;

		// Token: 0x04001513 RID: 5395
		private bool ODBNCIANMDG;
	}
}
