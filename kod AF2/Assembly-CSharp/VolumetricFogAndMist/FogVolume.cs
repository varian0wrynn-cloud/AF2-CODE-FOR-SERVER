using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020002BF RID: 703
	public class FogVolume : MonoBehaviour
	{
		// Token: 0x0600A59E RID: 42398 RVA: 0x004A91D8 File Offset: 0x004A73D8
		private void COLPPHAICAJ(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x004A9244 File Offset: 0x004A7444
		private void NGHNBKOJCJM(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void KFGKKLAKFGH()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x004A92B0 File Offset: 0x004A74B0
		private void LELKOMPOCEL(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void CBLGFOFHNPJ()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void EDGALMCHPPH()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x004A931C File Offset: 0x004A751C
		private void KDGNFKNGJNO(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x004A9388 File Offset: 0x004A7588
		private void KLABHFPNHOD(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x004A93F4 File Offset: 0x004A75F4
		private void GPOJMKLGNMP(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x004A9460 File Offset: 0x004A7660
		private void LHKMHLEONKJ(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x004A94C0 File Offset: 0x004A76C0
		private void MALIPLEHBAL(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x004A952C File Offset: 0x004A772C
		private void OnTriggerEnter(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x004A9598 File Offset: 0x004A7798
		private void FKOLJDCBFGI(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x004A962C File Offset: 0x004A782C
		private void DGKKCNIGHPP(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void KKCFKEDABLB()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x004A968C File Offset: 0x004A788C
		private void EJFHPBJPBNB(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x004A96F8 File Offset: 0x004A78F8
		private void FGCLFNBLJKJ(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x004A9758 File Offset: 0x004A7958
		private void MIDCDGCCFEL(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x004A97C4 File Offset: 0x004A79C4
		private void OKLKHBIJOPN(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void OFGMIEJKMGC()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x004A9824 File Offset: 0x004A7A24
		private void KMAOCOANNAK(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void PFNPOHMMJDN()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void DGEIACONKCJ()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x004A9884 File Offset: 0x004A7A84
		private void NMNFMPKPNGI(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x004A98F0 File Offset: 0x004A7AF0
		private void HGEMEIEKPOM(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x004A9950 File Offset: 0x004A7B50
		private void PFNDBONPCMK(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x004A99BC File Offset: 0x004A7BBC
		private void GAEILEALOBI(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x004A9A1C File Offset: 0x004A7C1C
		private void KOABECHGJGE(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void Start()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x004A9A88 File Offset: 0x004A7C88
		private void HPILJDPOLFB(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x004A9AE8 File Offset: 0x004A7CE8
		private void OnTriggerExit(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x004A9B48 File Offset: 0x004A7D48
		private void OHPJHDICJCA(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x004A9BA8 File Offset: 0x004A7DA8
		private void HJEAMBIEAEA(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x004A9C14 File Offset: 0x004A7E14
		private void EIFCBCCCLMI(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x004A9C74 File Offset: 0x004A7E74
		private void FAKAEOJDOGL(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void EHFPLKEINFO()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void ONIHHFLOJMN()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x004A9CD4 File Offset: 0x004A7ED4
		private void BDOAHNKOKBP(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = false;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x004A92A2 File Offset: 0x004A74A2
		private void PMDPLLIBJAF()
		{
			this.ANCIMKLOHFH = VolumetricFog.COIPKPKLDAH;
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x004A9D34 File Offset: 0x004A7F34
		private void PDEJKMAKHBK(Collider INDANOPGHCN)
		{
			if (this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
			}
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x004A9DA0 File Offset: 0x004A7FA0
		private void KJHDOGBCANF(Collider INDANOPGHCN)
		{
			if (!this.NHGOCNNCFGD)
			{
				return;
			}
			if (INDANOPGHCN == this.targetCollider || INDANOPGHCN.gameObject.transform.GetComponentInChildren<Camera>() == this.ANCIMKLOHFH.AAAOLCMHAGN)
			{
				this.NHGOCNNCFGD = true;
				this.ANCIMKLOHFH.ClearTargetAlpha(this.transitionDuration);
			}
		}

		// Token: 0x04001514 RID: 5396
		[Tooltip("Target fog alpha when camera enters this fog volume")]
		[Range(0f, 1f)]
		public float targetFogAlpha = 0.5f;

		// Token: 0x04001515 RID: 5397
		[Tooltip("Target sky haze alpha when camera enters this fog volume")]
		[Range(0f, 1f)]
		public float targetSkyHazeAlpha = 0.5f;

		// Token: 0x04001516 RID: 5398
		[Tooltip("Set this to zero for changing fog alpha immediately upon enter/exit fog volume.")]
		public float transitionDuration = 3f;

		// Token: 0x04001517 RID: 5399
		[Tooltip("Set collider that will trigger this fog volume. If not set, this fog volume will react to any collider which has the main camera. If you use a third person controller, assign the character collider here.")]
		public Collider targetCollider;

		// Token: 0x04001518 RID: 5400
		private bool NHGOCNNCFGD;

		// Token: 0x04001519 RID: 5401
		private VolumetricFog ANCIMKLOHFH;
	}
}
